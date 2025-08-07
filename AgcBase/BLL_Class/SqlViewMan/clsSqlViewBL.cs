
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewBL
 表名:SqlView(00050245)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsSqlViewBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewEN GetObj(this K_SqlViewId_SqlView myKey)
{
clsSqlViewEN objSqlViewEN = clsSqlViewBL.SqlViewDA.GetObjBySqlViewId(myKey.Value);
return objSqlViewEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewEN) == false)
{
var strMsg = string.Format("记录已经存在!相关表Id = [{0}],工程Id = [{1}]的数据已经存在!(in clsSqlViewBL.AddNewRecord)", objSqlViewEN.RelaTabId,objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
bool bolResult = clsSqlViewBL.SqlViewDA.AddNewRecordBySQL2(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
public static bool AddRecordEx(this clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSqlViewEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSqlViewEN.CheckUniqueness() == false)
{
strMsg = string.Format("(相关表Id(RelaTabId)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objSqlViewEN.RelaTabId, objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSqlViewEN.AddNewRecord();
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewEN) == false)
{
var strMsg = string.Format("记录已经存在!相关表Id = [{0}],工程Id = [{1}]的数据已经存在!(in clsSqlViewBL.AddNewRecordWithMaxId)", objSqlViewEN.RelaTabId,objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
string strSqlViewId = clsSqlViewBL.SqlViewDA.AddNewRecordBySQL2WithReturnKey(objSqlViewEN);
     objSqlViewEN.SqlViewId = strSqlViewId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
}
return strSqlViewId;
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewEN) == false)
{
var strMsg = string.Format("记录已经存在!相关表Id = [{0}],工程Id = [{1}]的数据已经存在!(in clsSqlViewBL.AddNewRecordWithReturnKey)", objSqlViewEN.RelaTabId,objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
string strKey = clsSqlViewBL.SqlViewDA.AddNewRecordBySQL2WithReturnKey(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewId(this clsSqlViewEN objSqlViewEN, string strSqlViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlView.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlView.SqlViewId);
}
objSqlViewEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewText(this clsSqlViewEN objSqlViewEN, string strSqlViewText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, conSqlView.SqlViewText);
}
objSqlViewEN.SqlViewText = strSqlViewText; //Sql视图文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewText) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewText, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewText] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewText4Gene(this clsSqlViewEN objSqlViewEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, conSqlView.SqlViewText4Gene);
}
objSqlViewEN.SqlViewText4Gene = strSqlViewText4Gene; //Sql视图文本4生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewText4Gene) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewText4Gene, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewText4Gene] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTextResouce(this clsSqlViewEN objSqlViewEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, conSqlView.TextResouce);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResouce, 100, conSqlView.TextResouce);
}
objSqlViewEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TextResouce) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TextResouce, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TextResouce] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTextResourceTypeId(this clsSqlViewEN objSqlViewEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, conSqlView.TextResourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, conSqlView.TextResourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, conSqlView.TextResourceTypeId);
}
objSqlViewEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TextResourceTypeId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TextResourceTypeId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TextResourceTypeId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetRelaTabId(this clsSqlViewEN objSqlViewEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, conSqlView.RelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlView.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlView.RelaTabId);
}
objSqlViewEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.RelaTabId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.RelaTabId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.RelaTabId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetAnalysisDate(this clsSqlViewEN objSqlViewEN, string strAnalysisDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, conSqlView.AnalysisDate);
}
objSqlViewEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.AnalysisDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.AnalysisDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.AnalysisDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetGeneCodeDate(this clsSqlViewEN objSqlViewEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conSqlView.GeneCodeDate);
}
objSqlViewEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.GeneCodeDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.GeneCodeDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.GeneCodeDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetCreateDate(this clsSqlViewEN objSqlViewEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conSqlView.CreateDate);
}
objSqlViewEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.CreateDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.CreateDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.CreateDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTopPercent(this clsSqlViewEN objSqlViewEN, string strTopPercent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopPercent, 200, conSqlView.TopPercent);
}
objSqlViewEN.TopPercent = strTopPercent; //顶百分比
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TopPercent) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TopPercent, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TopPercent] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetDistinctFlag(this clsSqlViewEN objSqlViewEN, string strDistinctFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, conSqlView.DistinctFlag);
}
objSqlViewEN.DistinctFlag = strDistinctFlag; //Distinct标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.DistinctFlag) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.DistinctFlag, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.DistinctFlag] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetWhereCondition(this clsSqlViewEN objSqlViewEN, string strWhereCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, conSqlView.WhereCondition);
}
objSqlViewEN.WhereCondition = strWhereCondition; //条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.WhereCondition) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.WhereCondition, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.WhereCondition] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetGroupBy(this clsSqlViewEN objSqlViewEN, string strGroupBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, conSqlView.GroupBy);
}
objSqlViewEN.GroupBy = strGroupBy; //分组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.GroupBy) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.GroupBy, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.GroupBy] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetHavingStr(this clsSqlViewEN objSqlViewEN, string strHavingStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHavingStr, 200, conSqlView.HavingStr);
}
objSqlViewEN.HavingStr = strHavingStr; //分组过滤
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.HavingStr) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.HavingStr, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.HavingStr] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetOrderBy(this clsSqlViewEN objSqlViewEN, string strOrderBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrderBy, 100, conSqlView.OrderBy);
}
objSqlViewEN.OrderBy = strOrderBy; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.OrderBy) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.OrderBy, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.OrderBy] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetErrMsg(this clsSqlViewEN objSqlViewEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conSqlView.ErrMsg);
}
objSqlViewEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.ErrMsg) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.ErrMsg, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.ErrMsg] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetPrjId(this clsSqlViewEN objSqlViewEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlView.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlView.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlView.PrjId);
}
objSqlViewEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.PrjId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.PrjId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.PrjId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetUpdDate(this clsSqlViewEN objSqlViewEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlView.UpdDate);
}
objSqlViewEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.UpdDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.UpdDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.UpdDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetUpdUserId(this clsSqlViewEN objSqlViewEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlView.UpdUserId);
}
objSqlViewEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.UpdUserId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.UpdUserId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.UpdUserId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetMemo(this clsSqlViewEN objSqlViewEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlView.Memo);
}
objSqlViewEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.Memo) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.Memo, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.Memo] = strComparisonOp;
}
}
return objSqlViewEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSqlViewEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSqlViewEN objSqlViewEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSqlViewEN.CheckPropertyNew();
clsSqlViewEN objSqlViewCond = new clsSqlViewEN();
string strCondition = objSqlViewCond
.SetSqlViewId(objSqlViewEN.SqlViewId, "<>")
.SetRelaTabId(objSqlViewEN.RelaTabId, "=")
.SetPrjId(objSqlViewEN.PrjId, "=")
.GetCombineCondition();
objSqlViewEN._IsCheckProperty = true;
bool bolIsExist = clsSqlViewBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RelaTabId_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSqlViewEN.Update();
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
 /// <param name = "objSqlView">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSqlViewEN objSqlView)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSqlViewEN objSqlViewCond = new clsSqlViewEN();
string strCondition = objSqlViewCond
.SetRelaTabId(objSqlView.RelaTabId, "=")
.SetPrjId(objSqlView.PrjId, "=")
.GetCombineCondition();
objSqlView._IsCheckProperty = true;
bool bolIsExist = clsSqlViewBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSqlView.SqlViewId = clsSqlViewBL.GetFirstID_S(strCondition);
objSqlView.UpdateWithCondition(strCondition);
}
else
{
objSqlView.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
objSqlView.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewEN objSqlViewEN)
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewBL.SqlViewDA.UpdateBySql2(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewEN objSqlViewEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewBL.SqlViewDA.UpdateBySql2(objSqlViewEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewEN objSqlViewEN, string strWhereCond)
{
try
{
bool bolResult = clsSqlViewBL.SqlViewDA.UpdateBySqlWithCondition(objSqlViewEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewEN objSqlViewEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSqlViewBL.SqlViewDA.UpdateBySqlWithConditionTransaction(objSqlViewEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSqlViewEN objSqlViewEN)
{
try
{
int intRecNum = clsSqlViewBL.SqlViewDA.DelRecord(objSqlViewEN.SqlViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewENS">源对象</param>
 /// <param name = "objSqlViewENT">目标对象</param>
 public static void CopyTo(this clsSqlViewEN objSqlViewENS, clsSqlViewEN objSqlViewENT)
{
try
{
objSqlViewENT.SqlViewId = objSqlViewENS.SqlViewId; //Sql视图Id
objSqlViewENT.SqlViewText = objSqlViewENS.SqlViewText; //Sql视图文本内容
objSqlViewENT.SqlViewText4Gene = objSqlViewENS.SqlViewText4Gene; //Sql视图文本4生成
objSqlViewENT.TextResouce = objSqlViewENS.TextResouce; //文本来源
objSqlViewENT.TextResourceTypeId = objSqlViewENS.TextResourceTypeId; //文本来源类型Id
objSqlViewENT.RelaTabId = objSqlViewENS.RelaTabId; //相关表Id
objSqlViewENT.AnalysisDate = objSqlViewENS.AnalysisDate; //分析日期
objSqlViewENT.GeneCodeDate = objSqlViewENS.GeneCodeDate; //生成代码日期
objSqlViewENT.CreateDate = objSqlViewENS.CreateDate; //建立日期
objSqlViewENT.TopPercent = objSqlViewENS.TopPercent; //顶百分比
objSqlViewENT.DistinctFlag = objSqlViewENS.DistinctFlag; //Distinct标志
objSqlViewENT.WhereCondition = objSqlViewENS.WhereCondition; //条件串
objSqlViewENT.GroupBy = objSqlViewENS.GroupBy; //分组
objSqlViewENT.HavingStr = objSqlViewENS.HavingStr; //分组过滤
objSqlViewENT.OrderBy = objSqlViewENS.OrderBy; //排序
objSqlViewENT.ErrMsg = objSqlViewENS.ErrMsg; //错误信息
objSqlViewENT.PrjId = objSqlViewENS.PrjId; //工程Id
objSqlViewENT.UpdDate = objSqlViewENS.UpdDate; //修改日期
objSqlViewENT.UpdUserId = objSqlViewENS.UpdUserId; //修改用户Id
objSqlViewENT.Memo = objSqlViewENS.Memo; //说明
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
 /// <param name = "objSqlViewENS">源对象</param>
 /// <returns>目标对象=>clsSqlViewEN:objSqlViewENT</returns>
 public static clsSqlViewEN CopyTo(this clsSqlViewEN objSqlViewENS)
{
try
{
 clsSqlViewEN objSqlViewENT = new clsSqlViewEN()
{
SqlViewId = objSqlViewENS.SqlViewId, //Sql视图Id
SqlViewText = objSqlViewENS.SqlViewText, //Sql视图文本内容
SqlViewText4Gene = objSqlViewENS.SqlViewText4Gene, //Sql视图文本4生成
TextResouce = objSqlViewENS.TextResouce, //文本来源
TextResourceTypeId = objSqlViewENS.TextResourceTypeId, //文本来源类型Id
RelaTabId = objSqlViewENS.RelaTabId, //相关表Id
AnalysisDate = objSqlViewENS.AnalysisDate, //分析日期
GeneCodeDate = objSqlViewENS.GeneCodeDate, //生成代码日期
CreateDate = objSqlViewENS.CreateDate, //建立日期
TopPercent = objSqlViewENS.TopPercent, //顶百分比
DistinctFlag = objSqlViewENS.DistinctFlag, //Distinct标志
WhereCondition = objSqlViewENS.WhereCondition, //条件串
GroupBy = objSqlViewENS.GroupBy, //分组
HavingStr = objSqlViewENS.HavingStr, //分组过滤
OrderBy = objSqlViewENS.OrderBy, //排序
ErrMsg = objSqlViewENS.ErrMsg, //错误信息
PrjId = objSqlViewENS.PrjId, //工程Id
UpdDate = objSqlViewENS.UpdDate, //修改日期
UpdUserId = objSqlViewENS.UpdUserId, //修改用户Id
Memo = objSqlViewENS.Memo, //说明
};
 return objSqlViewENT;
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
public static void CheckPropertyNew(this clsSqlViewEN objSqlViewEN)
{
 clsSqlViewBL.SqlViewDA.CheckPropertyNew(objSqlViewEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSqlViewEN objSqlViewEN)
{
 clsSqlViewBL.SqlViewDA.CheckProperty4Condition(objSqlViewEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewEN objSqlViewCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewId, objSqlViewCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewText) == true)
{
string strComparisonOpSqlViewText = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewText, objSqlViewCond.SqlViewText, strComparisonOpSqlViewText);
}
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewText4Gene) == true)
{
string strComparisonOpSqlViewText4Gene = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewText4Gene];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewText4Gene, objSqlViewCond.SqlViewText4Gene, strComparisonOpSqlViewText4Gene);
}
if (objSqlViewCond.IsUpdated(conSqlView.TextResouce) == true)
{
string strComparisonOpTextResouce = objSqlViewCond.dicFldComparisonOp[conSqlView.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TextResouce, objSqlViewCond.TextResouce, strComparisonOpTextResouce);
}
if (objSqlViewCond.IsUpdated(conSqlView.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objSqlViewCond.dicFldComparisonOp[conSqlView.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TextResourceTypeId, objSqlViewCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objSqlViewCond.IsUpdated(conSqlView.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewCond.dicFldComparisonOp[conSqlView.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.RelaTabId, objSqlViewCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewCond.IsUpdated(conSqlView.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objSqlViewCond.dicFldComparisonOp[conSqlView.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.AnalysisDate, objSqlViewCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objSqlViewCond.dicFldComparisonOp[conSqlView.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.GeneCodeDate, objSqlViewCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.CreateDate) == true)
{
string strComparisonOpCreateDate = objSqlViewCond.dicFldComparisonOp[conSqlView.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.CreateDate, objSqlViewCond.CreateDate, strComparisonOpCreateDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.TopPercent) == true)
{
string strComparisonOpTopPercent = objSqlViewCond.dicFldComparisonOp[conSqlView.TopPercent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TopPercent, objSqlViewCond.TopPercent, strComparisonOpTopPercent);
}
if (objSqlViewCond.IsUpdated(conSqlView.DistinctFlag) == true)
{
string strComparisonOpDistinctFlag = objSqlViewCond.dicFldComparisonOp[conSqlView.DistinctFlag];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.DistinctFlag, objSqlViewCond.DistinctFlag, strComparisonOpDistinctFlag);
}
if (objSqlViewCond.IsUpdated(conSqlView.WhereCondition) == true)
{
string strComparisonOpWhereCondition = objSqlViewCond.dicFldComparisonOp[conSqlView.WhereCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.WhereCondition, objSqlViewCond.WhereCondition, strComparisonOpWhereCondition);
}
if (objSqlViewCond.IsUpdated(conSqlView.GroupBy) == true)
{
string strComparisonOpGroupBy = objSqlViewCond.dicFldComparisonOp[conSqlView.GroupBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.GroupBy, objSqlViewCond.GroupBy, strComparisonOpGroupBy);
}
if (objSqlViewCond.IsUpdated(conSqlView.HavingStr) == true)
{
string strComparisonOpHavingStr = objSqlViewCond.dicFldComparisonOp[conSqlView.HavingStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.HavingStr, objSqlViewCond.HavingStr, strComparisonOpHavingStr);
}
if (objSqlViewCond.IsUpdated(conSqlView.OrderBy) == true)
{
string strComparisonOpOrderBy = objSqlViewCond.dicFldComparisonOp[conSqlView.OrderBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.OrderBy, objSqlViewCond.OrderBy, strComparisonOpOrderBy);
}
if (objSqlViewCond.IsUpdated(conSqlView.ErrMsg) == true)
{
string strComparisonOpErrMsg = objSqlViewCond.dicFldComparisonOp[conSqlView.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.ErrMsg, objSqlViewCond.ErrMsg, strComparisonOpErrMsg);
}
if (objSqlViewCond.IsUpdated(conSqlView.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewCond.dicFldComparisonOp[conSqlView.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.PrjId, objSqlViewCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewCond.IsUpdated(conSqlView.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewCond.dicFldComparisonOp[conSqlView.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.UpdDate, objSqlViewCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewCond.dicFldComparisonOp[conSqlView.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.UpdUserId, objSqlViewCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewCond.IsUpdated(conSqlView.Memo) == true)
{
string strComparisonOpMemo = objSqlViewCond.dicFldComparisonOp[conSqlView.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.Memo, objSqlViewCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SqlView(Sql视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RelaTabId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSqlViewEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSqlViewEN objSqlViewEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewEN == null) return true;
if (objSqlViewEN.SqlViewId == null || objSqlViewEN.SqlViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
if (clsSqlViewBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SqlViewId !=  '{0}'", objSqlViewEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
if (clsSqlViewBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SqlView(Sql视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RelaTabId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSqlViewEN objSqlViewEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewEN == null) return "";
if (objSqlViewEN.SqlViewId == null || objSqlViewEN.SqlViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SqlViewId !=  '{0}'", objSqlViewEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SqlView
{
public virtual bool UpdRelaTabDate(string strSqlViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Sql视图(SqlView)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewBL
{
public static RelatedActions_SqlView relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSqlViewDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSqlViewDA SqlViewDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSqlViewDA();
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
 public clsSqlViewBL()
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
if (string.IsNullOrEmpty(clsSqlViewEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlViewEN._ConnectString);
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
public static DataTable GetDataTable_SqlView(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SqlViewDA.GetDataTable_SqlView(strWhereCond);
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
objDT = SqlViewDA.GetDataTable(strWhereCond);
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
objDT = SqlViewDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SqlViewDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SqlViewDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SqlViewDA.GetDataTable_Top(objTopPara);
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
objDT = SqlViewDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SqlViewDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SqlViewDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSqlViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSqlViewEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewIdLst)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSqlViewIdLst, true);
 string strWhereCond = string.Format("SqlViewId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSqlViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSqlViewEN> GetObjLstBySqlViewIdLstCache(List<string> arrSqlViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
List<clsSqlViewEN> arrSqlViewObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewEN> arrSqlViewObjLst_Sel =
arrSqlViewObjLstCache
.Where(x => arrSqlViewIdLst.Contains(x.SqlViewId));
return arrSqlViewObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewEN> GetObjLst(string strWhereCond)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
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
public static List<clsSqlViewEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSqlViewCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSqlViewEN> GetSubObjLstCache(clsSqlViewEN objSqlViewCond)
{
 string strPrjId = objSqlViewCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSqlViewBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSqlViewEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlView._AttributeName)
{
if (objSqlViewCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewCond[strFldName].ToString());
}
else
{
if (objSqlViewCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewCond[strFldName]));
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
public static List<clsSqlViewEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
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
public static List<clsSqlViewEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
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
List<clsSqlViewEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSqlViewEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSqlViewEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
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
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
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
public static List<clsSqlViewEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSqlViewEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSqlViewEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
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
public static List<clsSqlViewEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSqlViewEN> arrObjLst = new List<clsSqlViewEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewEN objSqlViewEN = new clsSqlViewEN();
try
{
objSqlViewEN.SqlViewId = objRow[conSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewEN.SqlViewText = objRow[conSqlView.SqlViewText] == DBNull.Value ? null : objRow[conSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objSqlViewEN.SqlViewText4Gene = objRow[conSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[conSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objSqlViewEN.TextResouce = objRow[conSqlView.TextResouce].ToString().Trim(); //文本来源
objSqlViewEN.TextResourceTypeId = objRow[conSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlViewEN.RelaTabId = objRow[conSqlView.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewEN.AnalysisDate = objRow[conSqlView.AnalysisDate] == DBNull.Value ? null : objRow[conSqlView.AnalysisDate].ToString().Trim(); //分析日期
objSqlViewEN.GeneCodeDate = objRow[conSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[conSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objSqlViewEN.CreateDate = objRow[conSqlView.CreateDate] == DBNull.Value ? null : objRow[conSqlView.CreateDate].ToString().Trim(); //建立日期
objSqlViewEN.TopPercent = objRow[conSqlView.TopPercent] == DBNull.Value ? null : objRow[conSqlView.TopPercent].ToString().Trim(); //顶百分比
objSqlViewEN.DistinctFlag = objRow[conSqlView.DistinctFlag] == DBNull.Value ? null : objRow[conSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objSqlViewEN.WhereCondition = objRow[conSqlView.WhereCondition] == DBNull.Value ? null : objRow[conSqlView.WhereCondition].ToString().Trim(); //条件串
objSqlViewEN.GroupBy = objRow[conSqlView.GroupBy] == DBNull.Value ? null : objRow[conSqlView.GroupBy].ToString().Trim(); //分组
objSqlViewEN.HavingStr = objRow[conSqlView.HavingStr] == DBNull.Value ? null : objRow[conSqlView.HavingStr].ToString().Trim(); //分组过滤
objSqlViewEN.OrderBy = objRow[conSqlView.OrderBy] == DBNull.Value ? null : objRow[conSqlView.OrderBy].ToString().Trim(); //排序
objSqlViewEN.ErrMsg = objRow[conSqlView.ErrMsg] == DBNull.Value ? null : objRow[conSqlView.ErrMsg].ToString().Trim(); //错误信息
objSqlViewEN.PrjId = objRow[conSqlView.PrjId].ToString().Trim(); //工程Id
objSqlViewEN.UpdDate = objRow[conSqlView.UpdDate] == DBNull.Value ? null : objRow[conSqlView.UpdDate].ToString().Trim(); //修改日期
objSqlViewEN.UpdUserId = objRow[conSqlView.UpdUserId] == DBNull.Value ? null : objRow[conSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewEN.Memo = objRow[conSqlView.Memo] == DBNull.Value ? null : objRow[conSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSqlViewEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSqlView(ref clsSqlViewEN objSqlViewEN)
{
bool bolResult = SqlViewDA.GetSqlView(ref objSqlViewEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewEN GetObjBySqlViewId(string strSqlViewId)
{
if (strSqlViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSqlViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSqlViewId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSqlViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSqlViewEN objSqlViewEN = SqlViewDA.GetObjBySqlViewId(strSqlViewId);
return objSqlViewEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSqlViewEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSqlViewEN objSqlViewEN = SqlViewDA.GetFirstObj(strWhereCond);
 return objSqlViewEN;
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
public static clsSqlViewEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSqlViewEN objSqlViewEN = SqlViewDA.GetObjByDataRow(objRow);
 return objSqlViewEN;
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
public static clsSqlViewEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSqlViewEN objSqlViewEN = SqlViewDA.GetObjByDataRow(objRow);
 return objSqlViewEN;
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
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <param name = "lstSqlViewObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewEN GetObjBySqlViewIdFromList(string strSqlViewId, List<clsSqlViewEN> lstSqlViewObjLst)
{
foreach (clsSqlViewEN objSqlViewEN in lstSqlViewObjLst)
{
if (objSqlViewEN.SqlViewId == strSqlViewId)
{
return objSqlViewEN;
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
 string strMaxSqlViewId;
 try
 {
 strMaxSqlViewId = clsSqlViewDA.GetMaxStrId();
 return strMaxSqlViewId;
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
 string strSqlViewId;
 try
 {
 strSqlViewId = new clsSqlViewDA().GetFirstID(strWhereCond);
 return strSqlViewId;
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
 arrList = SqlViewDA.GetID(strWhereCond);
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
bool bolIsExist = SqlViewDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSqlViewId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSqlViewId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SqlViewDA.IsExist(strSqlViewId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strSqlViewId">Sql视图Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strSqlViewId, string strOpUser)
{
clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);
objSqlViewEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSqlViewEN.UpdUserId = strOpUser;
return clsSqlViewBL.UpdateBySql2(objSqlViewEN);
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
 bolIsExist = clsSqlViewDA.IsExistTable();
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
 bolIsExist = SqlViewDA.IsExistTable(strTabName);
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!相关表Id = [{0}],工程Id = [{1}]的数据已经存在!(in clsSqlViewBL.AddNewRecordBySql2)", objSqlViewEN.RelaTabId,objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
bool bolResult = SqlViewDA.AddNewRecordBySQL2(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSqlViewEN objSqlViewEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!相关表Id = [{0}],工程Id = [{1}]的数据已经存在!(in clsSqlViewBL.AddNewRecordBySql2WithReturnKey)", objSqlViewEN.RelaTabId,objSqlViewEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewBL.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewBL.GetMaxStrId_S();
 }
string strKey = SqlViewDA.AddNewRecordBySQL2WithReturnKey(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSqlViewEN objSqlViewEN)
{
try
{
bool bolResult = SqlViewDA.Update(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSqlViewEN objSqlViewEN)
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SqlViewDA.UpdateBySql2(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewBL.ReFreshCache(objSqlViewEN.PrjId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
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
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSqlViewId)
{
try
{
 clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);

if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(objSqlViewEN.SqlViewId, objSqlViewEN.UpdUserId);
}
if (objSqlViewEN != null)
{
int intRecNum = SqlViewDA.DelRecord(strSqlViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewEN.PrjId);
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
/// <param name="strSqlViewId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strSqlViewId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewDA.GetSpecSQLObj();
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
//删除与表:[SqlView]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSqlView.SqlViewId,
//strSqlViewId);
//        clsSqlViewBL.DelSqlViewsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewBL.DelRecord(strSqlViewId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSqlViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSqlViewId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSqlViewBL.relatedActions != null)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(strSqlViewId, "UpdRelaTabDate");
}
bool bolResult = SqlViewDA.DelRecord(strSqlViewId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSqlViewIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSqlViews(List<string> arrSqlViewIdLst)
{
if (arrSqlViewIdLst.Count == 0) return 0;
try
{
if (clsSqlViewBL.relatedActions != null)
{
foreach (var strSqlViewId in arrSqlViewIdLst)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(strSqlViewId, "UpdRelaTabDate");
}
}
 clsSqlViewEN objSqlViewEN = clsSqlViewBL.GetObjBySqlViewId(arrSqlViewIdLst[0]);
int intDelRecNum = SqlViewDA.DelSqlView(arrSqlViewIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewEN.PrjId);
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
public static int DelSqlViewsByCond(string strWhereCond)
{
try
{
if (clsSqlViewBL.relatedActions != null)
{
List<string> arrSqlViewId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSqlViewId in arrSqlViewId)
{
clsSqlViewBL.relatedActions.UpdRelaTabDate(strSqlViewId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conSqlView.PrjId, strWhereCond);
int intRecNum = SqlViewDA.DelSqlView(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SqlView]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSqlViewId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSqlViewId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewDA.GetSpecSQLObj();
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
//删除与表:[SqlView]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewBL.DelRecord(strSqlViewId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSqlViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSqlViewENS">源对象</param>
 /// <param name = "objSqlViewENT">目标对象</param>
 public static void CopyTo(clsSqlViewEN objSqlViewENS, clsSqlViewEN objSqlViewENT)
{
try
{
objSqlViewENT.SqlViewId = objSqlViewENS.SqlViewId; //Sql视图Id
objSqlViewENT.SqlViewText = objSqlViewENS.SqlViewText; //Sql视图文本内容
objSqlViewENT.SqlViewText4Gene = objSqlViewENS.SqlViewText4Gene; //Sql视图文本4生成
objSqlViewENT.TextResouce = objSqlViewENS.TextResouce; //文本来源
objSqlViewENT.TextResourceTypeId = objSqlViewENS.TextResourceTypeId; //文本来源类型Id
objSqlViewENT.RelaTabId = objSqlViewENS.RelaTabId; //相关表Id
objSqlViewENT.AnalysisDate = objSqlViewENS.AnalysisDate; //分析日期
objSqlViewENT.GeneCodeDate = objSqlViewENS.GeneCodeDate; //生成代码日期
objSqlViewENT.CreateDate = objSqlViewENS.CreateDate; //建立日期
objSqlViewENT.TopPercent = objSqlViewENS.TopPercent; //顶百分比
objSqlViewENT.DistinctFlag = objSqlViewENS.DistinctFlag; //Distinct标志
objSqlViewENT.WhereCondition = objSqlViewENS.WhereCondition; //条件串
objSqlViewENT.GroupBy = objSqlViewENS.GroupBy; //分组
objSqlViewENT.HavingStr = objSqlViewENS.HavingStr; //分组过滤
objSqlViewENT.OrderBy = objSqlViewENS.OrderBy; //排序
objSqlViewENT.ErrMsg = objSqlViewENS.ErrMsg; //错误信息
objSqlViewENT.PrjId = objSqlViewENS.PrjId; //工程Id
objSqlViewENT.UpdDate = objSqlViewENS.UpdDate; //修改日期
objSqlViewENT.UpdUserId = objSqlViewENS.UpdUserId; //修改用户Id
objSqlViewENT.Memo = objSqlViewENS.Memo; //说明
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
 /// <param name = "objSqlViewEN">源简化对象</param>
 public static void SetUpdFlag(clsSqlViewEN objSqlViewEN)
{
try
{
objSqlViewEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSqlViewEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSqlView.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.SqlViewId = objSqlViewEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(conSqlView.SqlViewText, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.SqlViewText = objSqlViewEN.SqlViewText == "[null]" ? null :  objSqlViewEN.SqlViewText; //Sql视图文本内容
}
if (arrFldSet.Contains(conSqlView.SqlViewText4Gene, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.SqlViewText4Gene = objSqlViewEN.SqlViewText4Gene == "[null]" ? null :  objSqlViewEN.SqlViewText4Gene; //Sql视图文本4生成
}
if (arrFldSet.Contains(conSqlView.TextResouce, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.TextResouce = objSqlViewEN.TextResouce; //文本来源
}
if (arrFldSet.Contains(conSqlView.TextResourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.TextResourceTypeId = objSqlViewEN.TextResourceTypeId; //文本来源类型Id
}
if (arrFldSet.Contains(conSqlView.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.RelaTabId = objSqlViewEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(conSqlView.AnalysisDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.AnalysisDate = objSqlViewEN.AnalysisDate == "[null]" ? null :  objSqlViewEN.AnalysisDate; //分析日期
}
if (arrFldSet.Contains(conSqlView.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.GeneCodeDate = objSqlViewEN.GeneCodeDate == "[null]" ? null :  objSqlViewEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(conSqlView.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.CreateDate = objSqlViewEN.CreateDate == "[null]" ? null :  objSqlViewEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conSqlView.TopPercent, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.TopPercent = objSqlViewEN.TopPercent == "[null]" ? null :  objSqlViewEN.TopPercent; //顶百分比
}
if (arrFldSet.Contains(conSqlView.DistinctFlag, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.DistinctFlag = objSqlViewEN.DistinctFlag == "[null]" ? null :  objSqlViewEN.DistinctFlag; //Distinct标志
}
if (arrFldSet.Contains(conSqlView.WhereCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.WhereCondition = objSqlViewEN.WhereCondition == "[null]" ? null :  objSqlViewEN.WhereCondition; //条件串
}
if (arrFldSet.Contains(conSqlView.GroupBy, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.GroupBy = objSqlViewEN.GroupBy == "[null]" ? null :  objSqlViewEN.GroupBy; //分组
}
if (arrFldSet.Contains(conSqlView.HavingStr, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.HavingStr = objSqlViewEN.HavingStr == "[null]" ? null :  objSqlViewEN.HavingStr; //分组过滤
}
if (arrFldSet.Contains(conSqlView.OrderBy, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.OrderBy = objSqlViewEN.OrderBy == "[null]" ? null :  objSqlViewEN.OrderBy; //排序
}
if (arrFldSet.Contains(conSqlView.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.ErrMsg = objSqlViewEN.ErrMsg == "[null]" ? null :  objSqlViewEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conSqlView.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.PrjId = objSqlViewEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSqlView.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.UpdDate = objSqlViewEN.UpdDate == "[null]" ? null :  objSqlViewEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSqlView.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.UpdUserId = objSqlViewEN.UpdUserId == "[null]" ? null :  objSqlViewEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSqlView.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewEN.Memo = objSqlViewEN.Memo == "[null]" ? null :  objSqlViewEN.Memo; //说明
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
 /// <param name = "objSqlViewEN">源简化对象</param>
 public static void AccessFldValueNull(clsSqlViewEN objSqlViewEN)
{
try
{
if (objSqlViewEN.SqlViewText == "[null]") objSqlViewEN.SqlViewText = null; //Sql视图文本内容
if (objSqlViewEN.SqlViewText4Gene == "[null]") objSqlViewEN.SqlViewText4Gene = null; //Sql视图文本4生成
if (objSqlViewEN.AnalysisDate == "[null]") objSqlViewEN.AnalysisDate = null; //分析日期
if (objSqlViewEN.GeneCodeDate == "[null]") objSqlViewEN.GeneCodeDate = null; //生成代码日期
if (objSqlViewEN.CreateDate == "[null]") objSqlViewEN.CreateDate = null; //建立日期
if (objSqlViewEN.TopPercent == "[null]") objSqlViewEN.TopPercent = null; //顶百分比
if (objSqlViewEN.DistinctFlag == "[null]") objSqlViewEN.DistinctFlag = null; //Distinct标志
if (objSqlViewEN.WhereCondition == "[null]") objSqlViewEN.WhereCondition = null; //条件串
if (objSqlViewEN.GroupBy == "[null]") objSqlViewEN.GroupBy = null; //分组
if (objSqlViewEN.HavingStr == "[null]") objSqlViewEN.HavingStr = null; //分组过滤
if (objSqlViewEN.OrderBy == "[null]") objSqlViewEN.OrderBy = null; //排序
if (objSqlViewEN.ErrMsg == "[null]") objSqlViewEN.ErrMsg = null; //错误信息
if (objSqlViewEN.UpdDate == "[null]") objSqlViewEN.UpdDate = null; //修改日期
if (objSqlViewEN.UpdUserId == "[null]") objSqlViewEN.UpdUserId = null; //修改用户Id
if (objSqlViewEN.Memo == "[null]") objSqlViewEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSqlViewEN objSqlViewEN)
{
 SqlViewDA.CheckPropertyNew(objSqlViewEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSqlViewEN objSqlViewEN)
{
 SqlViewDA.CheckProperty4Condition(objSqlViewEN);
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
if (clsSqlViewBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewBL没有刷新缓存机制(clsSqlViewBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SqlViewId");
//if (arrSqlViewObjLstCache == null)
//{
//arrSqlViewObjLstCache = SqlViewDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewEN GetObjBySqlViewIdCache(string strSqlViewId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
List<clsSqlViewEN> arrSqlViewObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewEN> arrSqlViewObjLst_Sel =
arrSqlViewObjLstCache
.Where(x=> x.SqlViewId == strSqlViewId 
);
if (arrSqlViewObjLst_Sel.Count() == 0)
{
   clsSqlViewEN obj = clsSqlViewBL.GetObjBySqlViewId(strSqlViewId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSqlViewId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSqlViewObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewEN> GetAllSqlViewObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsSqlViewEN> arrSqlViewObjLstCache = GetObjLstCache(strPrjId); 
return arrSqlViewObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsSqlViewEN> arrSqlViewObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSqlViewObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSqlViewEN._RefreshTimeLst.Count == 0) return "";
return clsSqlViewEN._RefreshTimeLst[clsSqlViewEN._RefreshTimeLst.Count - 1];
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
if (clsSqlViewBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSqlViewBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SqlView(Sql视图)
 /// 唯一性条件:RelaTabId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlViewEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSqlViewEN objSqlViewEN)
{
//检测记录是否存在
string strResult = SqlViewDA.GetUniCondStr(objSqlViewEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSqlViewId, string strPrjId)
{
if (strInFldName != conSqlView.SqlViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSqlView._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSqlView._AttributeName));
throw new Exception(strMsg);
}
var objSqlView = clsSqlViewBL.GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
if (objSqlView == null) return "";
return objSqlView[strOutFldName].ToString();
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
int intRecCount = clsSqlViewDA.GetRecCount(strTabName);
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
int intRecCount = clsSqlViewDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSqlViewDA.GetRecCount();
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
int intRecCount = clsSqlViewDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSqlViewCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSqlViewEN objSqlViewCond)
{
 string strPrjId = objSqlViewCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSqlViewBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSqlViewEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlView._AttributeName)
{
if (objSqlViewCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewCond[strFldName].ToString());
}
else
{
if (objSqlViewCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewCond[strFldName]));
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
 List<string> arrList = clsSqlViewDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SqlViewDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SqlViewDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SqlViewDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewDA.SetFldValue(clsSqlViewEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SqlViewDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SqlView] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Sql视图Id*/ 
 strCreateTabCode.Append(" SqlViewId char(8) primary key, "); 
 // /**Sql视图文本内容*/ 
 strCreateTabCode.Append(" SqlViewText varchar(8000) Null, "); 
 // /**Sql视图文本4生成*/ 
 strCreateTabCode.Append(" SqlViewText4Gene varchar(8000) Null, "); 
 // /**文本来源*/ 
 strCreateTabCode.Append(" TextResouce varchar(100) not Null, "); 
 // /**文本来源类型Id*/ 
 strCreateTabCode.Append(" TextResourceTypeId char(2) not Null, "); 
 // /**相关表Id*/ 
 strCreateTabCode.Append(" RelaTabId char(8) not Null, "); 
 // /**分析日期*/ 
 strCreateTabCode.Append(" AnalysisDate varchar(20) Null, "); 
 // /**生成代码日期*/ 
 strCreateTabCode.Append(" GeneCodeDate varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**顶百分比*/ 
 strCreateTabCode.Append(" TopPercent varchar(200) Null, "); 
 // /**Distinct标志*/ 
 strCreateTabCode.Append(" DistinctFlag varchar(100) Null, "); 
 // /**条件串*/ 
 strCreateTabCode.Append(" WhereCondition varchar(500) Null, "); 
 // /**分组*/ 
 strCreateTabCode.Append(" GroupBy varchar(1000) Null, "); 
 // /**分组过滤*/ 
 strCreateTabCode.Append(" HavingStr varchar(200) Null, "); 
 // /**排序*/ 
 strCreateTabCode.Append(" OrderBy varchar(100) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
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
 /// Sql视图(SqlView)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SqlView : clsCommFun4BLV2
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
clsSqlViewBL.ReFreshThisCache(strPrjId);
}
}

}