
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeBL
 表名:CodeType(00050203)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsCodeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeTypeEN GetObj(this K_CodeTypeId_CodeType myKey)
{
clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.CodeTypeDA.GetObjByCodeTypeId(myKey.Value);
return objCodeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecord)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCodeTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCodeTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(代码类型名(CodeTypeName)=[{0}])已经存在,不能重复!", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCodeTypeEN.AddNewRecord();
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordWithMaxId)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strCodeTypeId = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
     objCodeTypeEN.CodeTypeId = strCodeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
}
return strCodeTypeId;
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordWithReturnKey)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strKey = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeId(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCodeType.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCodeType.CodeTypeId);
}
objCodeTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, conCodeType.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, conCodeType.CodeTypeName);
}
objCodeTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeSimName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, conCodeType.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, conCodeType.CodeTypeSimName);
}
objCodeTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeSimName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeSimName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeSimName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeENName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, conCodeType.CodeTypeENName);
}
objCodeTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeENName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeENName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeENName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetGroupName(this clsCodeTypeEN objCodeTypeEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, conCodeType.GroupName);
}
objCodeTypeEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.GroupName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.GroupName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.GroupName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetProgLangTypeId(this clsCodeTypeEN objCodeTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conCodeType.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
}
objCodeTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ProgLangTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ProgLangTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ProgLangTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetRegionTypeId(this clsCodeTypeEN objCodeTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, conCodeType.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conCodeType.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conCodeType.RegionTypeId);
}
objCodeTypeEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.RegionTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.RegionTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.RegionTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetPrefix(this clsCodeTypeEN objCodeTypeEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, conCodeType.Prefix);
}
objCodeTypeEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Prefix) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Prefix, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Prefix] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetDependsOn(this clsCodeTypeEN objCodeTypeEN, string strDependsOn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDependsOn, 50, conCodeType.DependsOn);
}
objCodeTypeEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.DependsOn) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.DependsOn, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.DependsOn] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetFrontOrBack(this clsCodeTypeEN objCodeTypeEN, string strFrontOrBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, conCodeType.FrontOrBack);
}
objCodeTypeEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FrontOrBack) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FrontOrBack, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FrontOrBack] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetSqlDsTypeId(this clsCodeTypeEN objCodeTypeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conCodeType.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
}
objCodeTypeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.SqlDsTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.SqlDsTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.SqlDsTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetClassNameFormat(this clsCodeTypeEN objCodeTypeEN, string strClassNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, conCodeType.ClassNameFormat);
}
objCodeTypeEN.ClassNameFormat = strClassNameFormat; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetFileNameFormat(this clsCodeTypeEN objCodeTypeEN, string strFileNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameFormat, 50, conCodeType.FileNameFormat);
}
objCodeTypeEN.FileNameFormat = strFileNameFormat; //文件名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FileNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FileNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FileNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetClassNamePattern(this clsCodeTypeEN objCodeTypeEN, string strClassNamePattern, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNamePattern, 50, conCodeType.ClassNamePattern);
}
objCodeTypeEN.ClassNamePattern = strClassNamePattern; //类名模式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNamePattern) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNamePattern, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNamePattern] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsCSharp(this clsCodeTypeEN objCodeTypeEN, bool bolIsCSharp, string strComparisonOp="")
	{
objCodeTypeEN.IsCSharp = bolIsCSharp; //是否CSharp语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsCSharp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsCSharp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsCSharp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsJava(this clsCodeTypeEN objCodeTypeEN, bool bolIsJava, string strComparisonOp="")
	{
objCodeTypeEN.IsJava = bolIsJava; //是否Java语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJava) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJava, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJava] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsJavaScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsJavaScript, string strComparisonOp="")
	{
objCodeTypeEN.IsJavaScript = bolIsJavaScript; //是否JavaScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJavaScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJavaScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJavaScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsTypeScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsTypeScript, string strComparisonOp="")
	{
objCodeTypeEN.IsTypeScript = bolIsTypeScript; //是否TypeScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTypeScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTypeScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTypeScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsSilverLight(this clsCodeTypeEN objCodeTypeEN, bool bolIsSilverLight, string strComparisonOp="")
	{
objCodeTypeEN.IsSilverLight = bolIsSilverLight; //是否SilverLight语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSilverLight) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSilverLight, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSilverLight] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsSwift(this clsCodeTypeEN objCodeTypeEN, bool bolIsSwift, string strComparisonOp="")
	{
objCodeTypeEN.IsSwift = bolIsSwift; //是否Swift语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSwift) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSwift, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSwift] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsVB(this clsCodeTypeEN objCodeTypeEN, bool bolIsVB, string strComparisonOp="")
	{
objCodeTypeEN.IsVB = bolIsVB; //IsVB语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsVB) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsVB, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsVB] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsTableFldConst(this clsCodeTypeEN objCodeTypeEN, bool bolIsTableFldConst, string strComparisonOp="")
	{
objCodeTypeEN.IsTableFldConst = bolIsTableFldConst; //IsTableFldConst
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTableFldConst) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTableFldConst, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTableFldConst] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsPubApp4WinWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsPubApp4WinWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsPubApp4WinWeb = bolIsPubApp4WinWeb; //IsPubApp4WinWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsPubApp4WinWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsPubApp4WinWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsPubApp4WinWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsWeb = bolIsWeb; //是否Web应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsAspMvc(this clsCodeTypeEN objCodeTypeEN, bool bolIsAspMvc, string strComparisonOp="")
	{
objCodeTypeEN.IsAspMvc = bolIsAspMvc; //是否AspMvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAspMvc) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAspMvc, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAspMvc] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWebSrvAccess(this clsCodeTypeEN objCodeTypeEN, bool bolIsWebSrvAccess, string strComparisonOp="")
	{
objCodeTypeEN.IsWebSrvAccess = bolIsWebSrvAccess; //IsWebSrvAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWebSrvAccess) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWebSrvAccess, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWebSrvAccess] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsWin(this clsCodeTypeEN objCodeTypeEN, bool bolIsWin, string strComparisonOp="")
	{
objCodeTypeEN.IsWin = bolIsWin; //是否Win应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWin) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWin, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWin] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsMobileApp(this clsCodeTypeEN objCodeTypeEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objCodeTypeEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsMobileApp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsMobileApp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsMobileApp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsExtend(this clsCodeTypeEN objCodeTypeEN, bool bolIsExtend, string strComparisonOp="")
	{
objCodeTypeEN.IsExtend = bolIsExtend; //是否扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsExtend) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsExtend, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsExtend] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetOrderNum(this clsCodeTypeEN objCodeTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objCodeTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.OrderNum) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.OrderNum, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.OrderNum] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetWinOrWeb(this clsCodeTypeEN objCodeTypeEN, string strWinOrWeb, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWinOrWeb, 50, conCodeType.WinOrWeb);
}
objCodeTypeEN.WinOrWeb = strWinOrWeb; //WinOrWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.WinOrWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.WinOrWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.WinOrWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsDirByTabName(this clsCodeTypeEN objCodeTypeEN, bool bolIsDirByTabName, string strComparisonOp="")
	{
objCodeTypeEN.IsDirByTabName = bolIsDirByTabName; //是否用表名作为路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDirByTabName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDirByTabName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDirByTabName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsDefaultOverride(this clsCodeTypeEN objCodeTypeEN, bool bolIsDefaultOverride, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultOverride, conCodeType.IsDefaultOverride);
objCodeTypeEN.IsDefaultOverride = bolIsDefaultOverride; //是否默认覆盖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDefaultOverride) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDefaultOverride, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDefaultOverride] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetInUse(this clsCodeTypeEN objCodeTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCodeTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.InUse) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.InUse, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.InUse] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetIsAutoParseFile(this clsCodeTypeEN objCodeTypeEN, bool bolIsAutoParseFile, string strComparisonOp="")
	{
objCodeTypeEN.IsAutoParseFile = bolIsAutoParseFile; //是否自动分析文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAutoParseFile) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAutoParseFile, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAutoParseFile] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetUpdDate(this clsCodeTypeEN objCodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodeType.UpdDate);
}
objCodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdDate) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdDate, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdDate] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetUpdUser(this clsCodeTypeEN objCodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodeType.UpdUser);
}
objCodeTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdUser) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdUser, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdUser] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeTypeEN SetMemo(this clsCodeTypeEN objCodeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodeType.Memo);
}
objCodeTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Memo) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Memo, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Memo] = strComparisonOp;
}
}
return objCodeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCodeTypeEN objCodeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeTypeEN.CheckPropertyNew();
clsCodeTypeEN objCodeTypeCond = new clsCodeTypeEN();
string strCondition = objCodeTypeCond
.SetCodeTypeId(objCodeTypeEN.CodeTypeId, "<>")
.SetCodeTypeName(objCodeTypeEN.CodeTypeName, "=")
.GetCombineCondition();
objCodeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsCodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CodeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCodeTypeEN.Update();
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
 /// <param name = "objCodeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCodeTypeEN objCodeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCodeTypeEN objCodeTypeCond = new clsCodeTypeEN();
string strCondition = objCodeTypeCond
.SetCodeTypeName(objCodeType.CodeTypeName, "=")
.GetCombineCondition();
objCodeType._IsCheckProperty = true;
bool bolIsExist = clsCodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCodeType.CodeTypeId = clsCodeTypeBL.GetFirstID_S(strCondition);
objCodeType.UpdateWithCondition(strCondition);
}
else
{
objCodeType.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
objCodeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeTypeEN objCodeTypeEN)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySql2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeTypeEN objCodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySql2(objCodeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeTypeEN objCodeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySqlWithCondition(objCodeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeTypeEN objCodeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySqlWithConditionTransaction(objCodeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCodeTypeEN objCodeTypeEN)
{
try
{
int intRecNum = clsCodeTypeBL.CodeTypeDA.DelRecord(objCodeTypeEN.CodeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
 public static void CopyTo(this clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
try
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <returns>目标对象=>clsCodeTypeEN:objCodeTypeENT</returns>
 public static clsCodeTypeEN CopyTo(this clsCodeTypeEN objCodeTypeENS)
{
try
{
 clsCodeTypeEN objCodeTypeENT = new clsCodeTypeEN()
{
CodeTypeId = objCodeTypeENS.CodeTypeId, //代码类型Id
CodeTypeName = objCodeTypeENS.CodeTypeName, //代码类型名
CodeTypeSimName = objCodeTypeENS.CodeTypeSimName, //简称
CodeTypeENName = objCodeTypeENS.CodeTypeENName, //代码类型英文名
GroupName = objCodeTypeENS.GroupName, //组名
ProgLangTypeId = objCodeTypeENS.ProgLangTypeId, //编程语言类型Id
RegionTypeId = objCodeTypeENS.RegionTypeId, //区域类型Id
Prefix = objCodeTypeENS.Prefix, //前缀
DependsOn = objCodeTypeENS.DependsOn, //依赖于
FrontOrBack = objCodeTypeENS.FrontOrBack, //前台Or后台
SqlDsTypeId = objCodeTypeENS.SqlDsTypeId, //数据源类型Id
ClassNameFormat = objCodeTypeENS.ClassNameFormat, //类名格式
FileNameFormat = objCodeTypeENS.FileNameFormat, //文件名格式
ClassNamePattern = objCodeTypeENS.ClassNamePattern, //类名模式
IsCSharp = objCodeTypeENS.IsCSharp, //是否CSharp语言
IsJava = objCodeTypeENS.IsJava, //是否Java语言
IsJavaScript = objCodeTypeENS.IsJavaScript, //是否JavaScript语言
IsTypeScript = objCodeTypeENS.IsTypeScript, //是否TypeScript语言
IsSilverLight = objCodeTypeENS.IsSilverLight, //是否SilverLight语言
IsSwift = objCodeTypeENS.IsSwift, //是否Swift语言
IsVB = objCodeTypeENS.IsVB, //IsVB语言
IsTableFldConst = objCodeTypeENS.IsTableFldConst, //IsTableFldConst
IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb, //IsPubApp4WinWeb
IsWeb = objCodeTypeENS.IsWeb, //是否Web应用
IsAspMvc = objCodeTypeENS.IsAspMvc, //是否AspMvc
IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess, //IsWebSrvAccess
IsWin = objCodeTypeENS.IsWin, //是否Win应用
IsMobileApp = objCodeTypeENS.IsMobileApp, //是否移动终端应用
IsExtend = objCodeTypeENS.IsExtend, //是否扩展类
OrderNum = objCodeTypeENS.OrderNum, //序号
WinOrWeb = objCodeTypeENS.WinOrWeb, //WinOrWeb
IsDirByTabName = objCodeTypeENS.IsDirByTabName, //是否用表名作为路径
IsDefaultOverride = objCodeTypeENS.IsDefaultOverride, //是否默认覆盖
InUse = objCodeTypeENS.InUse, //是否在用
IsAutoParseFile = objCodeTypeENS.IsAutoParseFile, //是否自动分析文件
UpdDate = objCodeTypeENS.UpdDate, //修改日期
UpdUser = objCodeTypeENS.UpdUser, //修改者
Memo = objCodeTypeENS.Memo, //说明
};
 return objCodeTypeENT;
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
public static void CheckPropertyNew(this clsCodeTypeEN objCodeTypeEN)
{
 clsCodeTypeBL.CodeTypeDA.CheckPropertyNew(objCodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCodeTypeEN objCodeTypeEN)
{
 clsCodeTypeBL.CodeTypeDA.CheckProperty4Condition(objCodeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeTypeEN objCodeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeId, objCodeTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeName, objCodeTypeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeSimName, objCodeTypeCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objCodeTypeCond.dicFldComparisonOp[conCodeType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeENName, objCodeTypeCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.GroupName) == true)
{
string strComparisonOpGroupName = objCodeTypeCond.dicFldComparisonOp[conCodeType.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.GroupName, objCodeTypeCond.GroupName, strComparisonOpGroupName);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ProgLangTypeId, objCodeTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.RegionTypeId, objCodeTypeCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.Prefix) == true)
{
string strComparisonOpPrefix = objCodeTypeCond.dicFldComparisonOp[conCodeType.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Prefix, objCodeTypeCond.Prefix, strComparisonOpPrefix);
}
if (objCodeTypeCond.IsUpdated(conCodeType.DependsOn) == true)
{
string strComparisonOpDependsOn = objCodeTypeCond.dicFldComparisonOp[conCodeType.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.DependsOn, objCodeTypeCond.DependsOn, strComparisonOpDependsOn);
}
if (objCodeTypeCond.IsUpdated(conCodeType.FrontOrBack) == true)
{
string strComparisonOpFrontOrBack = objCodeTypeCond.dicFldComparisonOp[conCodeType.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FrontOrBack, objCodeTypeCond.FrontOrBack, strComparisonOpFrontOrBack);
}
if (objCodeTypeCond.IsUpdated(conCodeType.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objCodeTypeCond.dicFldComparisonOp[conCodeType.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.SqlDsTypeId, objCodeTypeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ClassNameFormat) == true)
{
string strComparisonOpClassNameFormat = objCodeTypeCond.dicFldComparisonOp[conCodeType.ClassNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNameFormat, objCodeTypeCond.ClassNameFormat, strComparisonOpClassNameFormat);
}
if (objCodeTypeCond.IsUpdated(conCodeType.FileNameFormat) == true)
{
string strComparisonOpFileNameFormat = objCodeTypeCond.dicFldComparisonOp[conCodeType.FileNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FileNameFormat, objCodeTypeCond.FileNameFormat, strComparisonOpFileNameFormat);
}
if (objCodeTypeCond.IsUpdated(conCodeType.ClassNamePattern) == true)
{
string strComparisonOpClassNamePattern = objCodeTypeCond.dicFldComparisonOp[conCodeType.ClassNamePattern];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNamePattern, objCodeTypeCond.ClassNamePattern, strComparisonOpClassNamePattern);
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsCSharp) == true)
{
if (objCodeTypeCond.IsCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsCSharp);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsJava) == true)
{
if (objCodeTypeCond.IsJava == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJava);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJava);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsJavaScript) == true)
{
if (objCodeTypeCond.IsJavaScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJavaScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJavaScript);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsTypeScript) == true)
{
if (objCodeTypeCond.IsTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTypeScript);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsSilverLight) == true)
{
if (objCodeTypeCond.IsSilverLight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSilverLight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSilverLight);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsSwift) == true)
{
if (objCodeTypeCond.IsSwift == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSwift);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSwift);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsVB) == true)
{
if (objCodeTypeCond.IsVB == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsVB);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsVB);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsTableFldConst) == true)
{
if (objCodeTypeCond.IsTableFldConst == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTableFldConst);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTableFldConst);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsPubApp4WinWeb) == true)
{
if (objCodeTypeCond.IsPubApp4WinWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsPubApp4WinWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsPubApp4WinWeb);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWeb) == true)
{
if (objCodeTypeCond.IsWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWeb);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsAspMvc) == true)
{
if (objCodeTypeCond.IsAspMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAspMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAspMvc);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWebSrvAccess) == true)
{
if (objCodeTypeCond.IsWebSrvAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWebSrvAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWebSrvAccess);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsWin) == true)
{
if (objCodeTypeCond.IsWin == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWin);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWin);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsMobileApp) == true)
{
if (objCodeTypeCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsMobileApp);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsExtend) == true)
{
if (objCodeTypeCond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsExtend);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCodeTypeCond.dicFldComparisonOp[conCodeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCodeType.OrderNum, objCodeTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCodeTypeCond.IsUpdated(conCodeType.WinOrWeb) == true)
{
string strComparisonOpWinOrWeb = objCodeTypeCond.dicFldComparisonOp[conCodeType.WinOrWeb];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.WinOrWeb, objCodeTypeCond.WinOrWeb, strComparisonOpWinOrWeb);
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsDirByTabName) == true)
{
if (objCodeTypeCond.IsDirByTabName == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDirByTabName);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDirByTabName);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsDefaultOverride) == true)
{
if (objCodeTypeCond.IsDefaultOverride == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDefaultOverride);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDefaultOverride);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.InUse) == true)
{
if (objCodeTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.InUse);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.IsAutoParseFile) == true)
{
if (objCodeTypeCond.IsAutoParseFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAutoParseFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAutoParseFile);
}
}
if (objCodeTypeCond.IsUpdated(conCodeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCodeTypeCond.dicFldComparisonOp[conCodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdDate, objCodeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCodeTypeCond.IsUpdated(conCodeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCodeTypeCond.dicFldComparisonOp[conCodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdUser, objCodeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCodeTypeCond.IsUpdated(conCodeType.Memo) == true)
{
string strComparisonOpMemo = objCodeTypeCond.dicFldComparisonOp[conCodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Memo, objCodeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCodeTypeEN == null) return true;
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
if (clsCodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", objCodeTypeEN.CodeTypeId);
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
if (clsCodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CodeType(代码类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCodeTypeEN == null) return "";
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", objCodeTypeEN.CodeTypeId);
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CodeType
{
public virtual bool UpdRelaTabDate(string strCodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCodeType
{
 /// <summary>
 /// 未知(CS)
 /// </summary>
public const string Unknown_0000 = "0000";
 /// <summary>
 /// 实体层(CS)
 /// </summary>
public const string EntityLayer_0001 = "0001";
 /// <summary>
 /// 数据处理层(CS)
 /// </summary>
public const string DALCode_0002 = "0002";
 /// <summary>
 /// 业务逻辑层(CS)
 /// </summary>
public const string BusinessLogic_0003 = "0003";
 /// <summary>
 /// WEB界面前台脚本(Html)
 /// </summary>
public const string WebViewCode_0004 = "0004";
 /// <summary>
 /// Web用户控件前台脚本(Html)
 /// </summary>
public const string WebCtlViewCode_0005 = "0005";
 /// <summary>
 /// Win界面层_QD(CS)
 /// </summary>
public const string WinViewCode_QD_0006 = "0006";
 /// <summary>
 /// WEB服务层(CS)
 /// </summary>
public const string WS_Srv_0009 = "0009";
 /// <summary>
 /// WEB服务访问层(CS)
 /// </summary>
public const string WS_Access_0010 = "0010";
 /// <summary>
 /// 简化实体层(CS)
 /// </summary>
public const string EntityLayer_Sim_0011 = "0011";
 /// <summary>
 /// Web服务访问高层(JAVA)
 /// </summary>
public const string WS_AccessHigh_0012 = "0012";
 /// <summary>
 /// App控制层(JAVA)
 /// </summary>
public const string AppController_0013 = "0013";
 /// <summary>
 /// Web界面后台(CS)
 /// </summary>
public const string WebViewControlCode_0014 = "0014";
 /// <summary>
 /// Web用户控件后台(CS)
 /// </summary>
public const string WebCtlControlCode_0015 = "0015";
 /// <summary>
 /// Win界面层_UI(CS)
 /// </summary>
public const string WinViewCode_UI_0016 = "0016";
 /// <summary>
 /// Web服务前台(CS)
 /// </summary>
public const string WS_Srv4Front_0017 = "0017";
 /// <summary>
 /// Win界面层_QD_设计(CS)
 /// </summary>
public const string WinViewCode_QD_Design_0018 = "0018";
 /// <summary>
 /// Win界面层_UI_设计(CS)
 /// </summary>
public const string WinViewCode_UI_Design_0019 = "0019";
 /// <summary>
 /// 逻辑层公共函数类扩展(CS)
 /// </summary>
public const string CommFun4BL_0020 = "0020";
 /// <summary>
 /// 业务逻辑扩展层(CS)
 /// </summary>
public const string BusinessLogicEx_0021 = "0021";
 /// <summary>
 /// 数据处理扩展层(CS)
 /// </summary>
public const string DALExCode_0022 = "0022";
 /// <summary>
 /// Mvc界面层(CS)
 /// </summary>
public const string Mvc_View_0023 = "0023";
 /// <summary>
 /// Mvc控制层Base(CS)
 /// </summary>
public const string Mvc_ControllerBase_0024 = "0024";
 /// <summary>
 /// App界面UT(JAVA)
 /// </summary>
public const string AppViewUnitTest_0025 = "0025";
 /// <summary>
 /// App界面UT脚本(JAVA)
 /// </summary>
public const string AppViewUTScript_0026 = "0026";
 /// <summary>
 /// App界面UT脚本后台(JAVA)
 /// </summary>
public const string AppViewUTScriptCS_0027 = "0027";
 /// <summary>
 /// 条件实体层(CS)
 /// </summary>
public const string CondEntityLayer_0028 = "0028";
 /// <summary>
 /// App界面脚本内容页(JAVA)
 /// </summary>
public const string AppViewScriptContent_0029 = "0029";
 /// <summary>
 /// App界面脚本后台(JAVA)
 /// </summary>
public const string AppViewScriptCS_0030 = "0030";
 /// <summary>
 /// App界面查询控件脚本(JAVA)
 /// </summary>
public const string AppViewQryScript_0031 = "0031";
 /// <summary>
 /// App界面编辑控件脚本(JAVA)
 /// </summary>
public const string AppViewEdtScript_0032 = "0032";
 /// <summary>
 /// Web用户Gv控件后台(CS)
 /// </summary>
public const string WebCtlControlCode4Gv_0033 = "0033";
 /// <summary>
 /// Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string WebCtlViewCode4Gv_0034 = "0034";
 /// <summary>
 /// App界面脚本主页(JAVA)
 /// </summary>
public const string AppViewScriptMain_0035 = "0035";
 /// <summary>
 /// App界面ListViewItem控件脚本(JAVA)
 /// </summary>
public const string AppViewLvItemScript_0036 = "0036";
 /// <summary>
 /// App界面ListViewAdapter(JAVA)
 /// </summary>
public const string AppViewListViewAdapter_0037 = "0037";
 /// <summary>
 /// App界面Ddl绑定(JAVA)
 /// </summary>
public const string AppViewDdlBind_0038 = "0038";
 /// <summary>
 /// App界面Ddl适配器(JAVA)
 /// </summary>
public const string AppViewDdlAdapter_0039 = "0039";
 /// <summary>
 /// App界面ListView头控件脚本(JAVA)
 /// </summary>
public const string AppViewLvHeadScript_0040 = "0040";
 /// <summary>
 /// 表字段常量CSharp(CS)
 /// </summary>
public const string TableFldConst_0041 = "0041";
 /// <summary>
 /// 实体扩展层(CS)
 /// </summary>
public const string EntityLayerEx_0042 = "0042";
 /// <summary>
 /// App业务逻辑层(JAVA)
 /// </summary>
public const string AppBusiness_0043 = "0043";
 /// <summary>
 /// WA_服务层(CS)
 /// </summary>
public const string WA_Srv_0044 = "0044";
 /// <summary>
 /// WA_访问层(CS)
 /// </summary>
public const string WA_Access_0045 = "0045";
 /// <summary>
 /// Mvc界面模型(CS)
 /// </summary>
public const string Mvc_Model_View_0046 = "0046";
 /// <summary>
 /// Mvc查询区模型(CS)
 /// </summary>
public const string Mvc_Model_Query_0047 = "0047";
 /// <summary>
 /// Mvc界面层Ajax(CS)
 /// </summary>
public const string Mvc_ViewAjax_0048 = "0048";
 /// <summary>
 /// Mvc界面-列表Ajax(CS)
 /// </summary>
public const string Mvc_ViewLstAjax_0049 = "0049";
 /// <summary>
 /// Mvc界面层Spa(CS)
 /// </summary>
public const string Mvc_ViewSpa_0050 = "0050";
 /// <summary>
 /// 业务逻辑层4Mvc(CS)
 /// </summary>
public const string BusinessLogic4Mvc_0051 = "0051";
 /// <summary>
 /// WA_界面UT(CS)
 /// </summary>
public const string WA_ViewUTScript_0052 = "0052";
 /// <summary>
 /// WA_界面UT后台(CS)
 /// </summary>
public const string WA_ViewUTScriptCS_0053 = "0053";
 /// <summary>
 /// WA_界面UT_TS(Html)
 /// </summary>
public const string WA_ViewUTScript_TS_0054 = "0054";
 /// <summary>
 /// 实体层(JAVA)
 /// </summary>
public const string EntityLayer_0056 = "0056";
 /// <summary>
 /// 数据处理层(JAVA)
 /// </summary>
public const string DALCode_0057 = "0057";
 /// <summary>
 /// 业务逻辑层(JAVA)
 /// </summary>
public const string BusinessLogic_0058 = "0058";
 /// <summary>
 /// WEB界面前台脚本(JAVA)
 /// </summary>
public const string WebViewCode_0059 = "0059";
 /// <summary>
 /// Web用户控件前台脚本(JAVA)
 /// </summary>
public const string WebCtlViewCode_0060 = "0060";
 /// <summary>
 /// Win界面层_QD(JAVA)
 /// </summary>
public const string WinViewCode_QD_0061 = "0061";
 /// <summary>
 /// WEB服务访问层(JAVA)
 /// </summary>
public const string WS_Access_0062 = "0062";
 /// <summary>
 /// Web服务访问高层(JS)
 /// </summary>
public const string WS_AccessHigh_0063 = "0063";
 /// <summary>
 /// App控制层(JS)
 /// </summary>
public const string AppController_0064 = "0064";
 /// <summary>
 /// Web界面后台2(JAVA)
 /// </summary>
public const string WebViewControlCode_0065 = "0065";
 /// <summary>
 /// Web用户控件后台(JAVA)
 /// </summary>
public const string WebCtlControlCode_0066 = "0066";
 /// <summary>
 /// App界面UT(JS)
 /// </summary>
public const string AppViewUnitTest_0067 = "0067";
 /// <summary>
 /// App界面UT脚本(JS)
 /// </summary>
public const string AppViewUTScript_0068 = "0068";
 /// <summary>
 /// App界面UT脚本后台(JS)
 /// </summary>
public const string AppViewUTScriptCS_0069 = "0069";
 /// <summary>
 /// App界面脚本内容页(JS)
 /// </summary>
public const string AppViewScriptContent_0070 = "0070";
 /// <summary>
 /// App界面脚本后台(JS)
 /// </summary>
public const string AppViewScriptCS_0071 = "0071";
 /// <summary>
 /// App界面查询控件脚本(JS)
 /// </summary>
public const string AppViewQryScript_0072 = "0072";
 /// <summary>
 /// App界面编辑控件脚本(JS)
 /// </summary>
public const string AppViewEdtScript_0073 = "0073";
 /// <summary>
 /// Web用户Gv控件后台(JAVA)
 /// </summary>
public const string WebCtlControlCode4Gv_0074 = "0074";
 /// <summary>
 /// Web用户Gv控件前台脚本(JAVA)
 /// </summary>
public const string WebCtlViewCode4Gv_0075 = "0075";
 /// <summary>
 /// App界面脚本主页(JS)
 /// </summary>
public const string AppViewScriptMain_0076 = "0076";
 /// <summary>
 /// App界面ListViewItem控件脚本(JS)
 /// </summary>
public const string AppViewLvItemScript_0077 = "0077";
 /// <summary>
 /// App界面ListViewAdapter(JS)
 /// </summary>
public const string AppViewListViewAdapter_0078 = "0078";
 /// <summary>
 /// App界面Ddl绑定(JS)
 /// </summary>
public const string AppViewDdlBind_0079 = "0079";
 /// <summary>
 /// App界面Ddl适配器(JS)
 /// </summary>
public const string AppViewDdlAdapter_0080 = "0080";
 /// <summary>
 /// App界面ListView头控件脚本(JS)
 /// </summary>
public const string AppViewLvHeadScript_0081 = "0081";
 /// <summary>
 /// 表字段常量(JAVA)
 /// </summary>
public const string TableFldConst_0082 = "0082";
 /// <summary>
 /// 实体扩展层(JAVA)
 /// </summary>
public const string EntityLayerEx_0083 = "0083";
 /// <summary>
 /// App业务逻辑层(JS)
 /// </summary>
public const string AppBusiness_0084 = "0084";
 /// <summary>
 /// WA_访问层(JAVA)
 /// </summary>
public const string WA_Access_0085 = "0085";
 /// <summary>
 /// WA_界面UT(JAVA)
 /// </summary>
public const string WA_ViewUTScript_0086 = "0086";
 /// <summary>
 /// WA_界面UT后台(JAVA)
 /// </summary>
public const string WA_ViewUTScriptCS_0087 = "0087";
 /// <summary>
 /// WA_界面UT_TS(JAVA)
 /// </summary>
public const string WA_ViewUTScript_TS_0088 = "0088";
 /// <summary>
 /// 实体层(JS)
 /// </summary>
public const string EntityLayer_0090 = "0090";
 /// <summary>
 /// 业务逻辑层(JS)
 /// </summary>
public const string BusinessLogic_0091 = "0091";
 /// <summary>
 /// WEB服务访问层(JS)
 /// </summary>
public const string WS_Access_0092 = "0092";
 /// <summary>
 /// Web服务访问高层(Swift4)
 /// </summary>
public const string WS_AccessHigh_0093 = "0093";
 /// <summary>
 /// App控制层(Swift4)
 /// </summary>
public const string AppController_0094 = "0094";
 /// <summary>
 /// App界面UT(Swift4)
 /// </summary>
public const string AppViewUnitTest_0095 = "0095";
 /// <summary>
 /// App界面UT脚本(Swift4)
 /// </summary>
public const string AppViewUTScript_0096 = "0096";
 /// <summary>
 /// App界面UT脚本后台(Swift4)
 /// </summary>
public const string AppViewUTScriptCS_0097 = "0097";
 /// <summary>
 /// App界面脚本内容页(Swift4)
 /// </summary>
public const string AppViewScriptContent_0098 = "0098";
 /// <summary>
 /// App界面脚本后台(Swift4)
 /// </summary>
public const string AppViewScriptCS_0099 = "0099";
 /// <summary>
 /// App界面查询控件脚本(Swift4)
 /// </summary>
public const string AppViewQryScript_0100 = "0100";
 /// <summary>
 /// App界面编辑控件脚本(Swift4)
 /// </summary>
public const string AppViewEdtScript_0101 = "0101";
 /// <summary>
 /// App界面脚本主页(Swift4)
 /// </summary>
public const string AppViewScriptMain_0102 = "0102";
 /// <summary>
 /// App界面ListViewItem控件脚本(Swift4)
 /// </summary>
public const string AppViewLvItemScript_0103 = "0103";
 /// <summary>
 /// App界面ListViewAdapter(Swift4)
 /// </summary>
public const string AppViewListViewAdapter_0104 = "0104";
 /// <summary>
 /// App界面ListView头控件脚本(Swift4)
 /// </summary>
public const string AppViewLvHeadScript_0107 = "0107";
 /// <summary>
 /// 表字段常量(JS)
 /// </summary>
public const string TableFldConst_0108 = "0108";
 /// <summary>
 /// 实体扩展层(JS)
 /// </summary>
public const string EntityLayerEx_0109 = "0109";
 /// <summary>
 /// App业务逻辑层(Swift4)
 /// </summary>
public const string AppBusiness_0110 = "0110";
 /// <summary>
 /// WA_访问层(JS)
 /// </summary>
public const string WA_Access_0111 = "0111";
 /// <summary>
 /// WA_界面UT(Html)
 /// </summary>
public const string WA_ViewUTScript_0112 = "0112";
 /// <summary>
 /// WA_界面UT后台(JS)
 /// </summary>
public const string WA_ViewUTScriptCS_0113 = "0113";
 /// <summary>
 /// 实体层(Swift4)
 /// </summary>
public const string EntityLayer_0116 = "0116";
 /// <summary>
 /// 业务逻辑层(Swift4)
 /// </summary>
public const string BusinessLogic_0117 = "0117";
 /// <summary>
 /// WEB服务访问层(Swift4)
 /// </summary>
public const string WS_Access_0118 = "0118";
 /// <summary>
 /// 实体层(TS)
 /// </summary>
public const string EntityLayer_0121 = "0121";
 /// <summary>
 /// 业务逻辑层(TS)
 /// </summary>
public const string BusinessLogic_0122 = "0122";
 /// <summary>
 /// 表字段常量(Swift4)
 /// </summary>
public const string TableFldConst_0135 = "0135";
 /// <summary>
 /// 实体扩展层(Swift4)
 /// </summary>
public const string EntityLayerEx_0136 = "0136";
 /// <summary>
 /// WA_访问层(Swift4)
 /// </summary>
public const string WA_Access_0138 = "0138";
 /// <summary>
 /// WA_界面UT(Swift4)
 /// </summary>
public const string WA_ViewUTScript_0139 = "0139";
 /// <summary>
 /// WA_界面UT后台(Swift4)
 /// </summary>
public const string WA_ViewUTScriptCS_0140 = "0140";
 /// <summary>
 /// WA_界面UT_TS(Swift4)
 /// </summary>
public const string WA_ViewUTScript_TS_0141 = "0141";
 /// <summary>
 /// WEB服务访问层(Swift3)
 /// </summary>
public const string WS_Access_0143 = "0143";
 /// <summary>
 /// WEB服务访问层(Swift)
 /// </summary>
public const string WS_Access_0144 = "0144";
 /// <summary>
 /// WEB服务访问层(SL)
 /// </summary>
public const string WS_Access_0145 = "0145";
 /// <summary>
 /// 业务逻辑层(Swift3)
 /// </summary>
public const string BusinessLogic_0146 = "0146";
 /// <summary>
 /// 业务逻辑层(Swift)
 /// </summary>
public const string BusinessLogic_0147 = "0147";
 /// <summary>
 /// 业务逻辑层(SL)
 /// </summary>
public const string BusinessLogic_0148 = "0148";
 /// <summary>
 /// App控制层(Swift3)
 /// </summary>
public const string AppController_0149 = "0149";
 /// <summary>
 /// App控制层(Swift)
 /// </summary>
public const string AppController_0150 = "0150";
 /// <summary>
 /// App控制层(SL)
 /// </summary>
public const string AppController_0151 = "0151";
 /// <summary>
 /// 实体层(Swift3)
 /// </summary>
public const string EntityLayer_0152 = "0152";
 /// <summary>
 /// 实体层(Swift)
 /// </summary>
public const string EntityLayer_0153 = "0153";
 /// <summary>
 /// 实体层(SL)
 /// </summary>
public const string EntityLayer_0154 = "0154";
 /// <summary>
 /// WA_访问层(TS)
 /// </summary>
public const string WA_Access_0155 = "0155";
 /// <summary>
 /// Web服务访问高层(Swift3)
 /// </summary>
public const string WS_AccessHigh_0157 = "0157";
 /// <summary>
 /// Web服务访问高层(Swift)
 /// </summary>
public const string WS_AccessHigh_0158 = "0158";
 /// <summary>
 /// Web服务访问高层(SL)
 /// </summary>
public const string WS_AccessHigh_0159 = "0159";
 /// <summary>
 /// App界面UT(Swift3)
 /// </summary>
public const string AppViewUnitTest_0160 = "0160";
 /// <summary>
 /// WA_界面UT后台_TS(TS)
 /// </summary>
public const string WA_ViewUTScriptCS_TS_0161 = "0161";
 /// <summary>
 /// 简化实体层(JAVA)
 /// </summary>
public const string EntityLayer_Sim_0162 = "0162";
 /// <summary>
 /// 简化实体层(Swift)
 /// </summary>
public const string EntityLayer_Sim_0163 = "0163";
 /// <summary>
 /// 简化实体层(Swift3)
 /// </summary>
public const string EntityLayer_Sim_0164 = "0164";
 /// <summary>
 /// 简化实体层(Swift4)
 /// </summary>
public const string EntityLayer_Sim_0165 = "0165";
 /// <summary>
 /// 简化实体层(JS)
 /// </summary>
public const string EntityLayer_Sim_0166 = "0166";
 /// <summary>
 /// 简化实体层(SL)
 /// </summary>
public const string EntityLayer_Sim_0167 = "0167";
 /// <summary>
 /// Win界面层_QD_Gv(CS)
 /// </summary>
public const string WinViewCode_QD_Gv_0168 = "0168";
 /// <summary>
 /// Win界面层_QD_Gv_设计(CS)
 /// </summary>
public const string WinViewCode_QD_Gv_Design_0169 = "0169";
 /// <summary>
 /// WA_界面后台(老)_TS(TS)
 /// </summary>
public const string WA_ViewScriptCS_Old_TS_0170 = "0170";
 /// <summary>
 /// WA_界面脚本_TS(Html)
 /// </summary>
public const string WA_ViewScript_TS_0171 = "0171";
 /// <summary>
 /// WA_访问高层(JAVA)
 /// </summary>
public const string WA_AccessHigh_0172 = "0172";
 /// <summary>
 /// WA_App控制层(JAVA)
 /// </summary>
public const string WA_AppController_0173 = "0173";
 /// <summary>
 /// WA_App界面UT(JAVA)
 /// </summary>
public const string WA_AppViewUT_0174 = "0174";
 /// <summary>
 /// WA_App界面UT脚本(JAVA)
 /// </summary>
public const string WA_AppViewUTScript_0175 = "0175";
 /// <summary>
 /// WA_App界面UT脚本后台(JAVA)
 /// </summary>
public const string WA_AppViewUTScriptCS_0176 = "0176";
 /// <summary>
 /// 简化实体层(TS)
 /// </summary>
public const string EntityLayer_Sim_0177 = "0177";
 /// <summary>
 /// Mvc控制层(CS)
 /// </summary>
public const string Mvc_Controller_0178 = "0178";
 /// <summary>
 /// Mvc界面-编辑区(CS)
 /// </summary>
public const string Mvc_View_Edit_0179 = "0179";
 /// <summary>
 /// Mvc界面-查询区(CS)
 /// </summary>
public const string Mvc_View_Query_0180 = "0180";
 /// <summary>
 /// Mvc界面-编辑区Ajax(CS)
 /// </summary>
public const string Mvc_View_EditAjax_0181 = "0181";
 /// <summary>
 /// Mvc界面-查询区Ajax(CS)
 /// </summary>
public const string Mvc_View_QueryAjax_0182 = "0182";
 /// <summary>
 /// Mvc列表模型(CS)
 /// </summary>
public const string Mvc_Model_List_0183 = "0183";
 /// <summary>
 /// Mvc编辑模型(CS)
 /// </summary>
public const string Mvc_Model_Edit_0184 = "0184";
 /// <summary>
 /// WA_服务扩展层(CS)
 /// </summary>
public const string WA_SrvEx_0185 = "0185";
 /// <summary>
 /// WA_访问扩展层(CS)
 /// </summary>
public const string WA_AccessEx_0186 = "0186";
 /// <summary>
 /// Mvc功能区模型(CS)
 /// </summary>
public const string Mvc_Model_Feature_0187 = "0187";
 /// <summary>
 /// WA_界面后台模型_TS(CS)
 /// </summary>
public const string WA_ViewScriptCSModel_TS_0188 = "0188";
 /// <summary>
 /// WA_界面后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScriptCSEx_TS_0189 = "0189";
 /// <summary>
 /// WA_访问扩展层(TS)
 /// </summary>
public const string WA_AccessEx_0190 = "0190";
 /// <summary>
 /// 实体扩展层(TS)
 /// </summary>
public const string EntityLayerEx_0191 = "0191";
 /// <summary>
 /// 纯粹类(CS)
 /// </summary>
public const string PureClass_0192 = "0192";
 /// <summary>
 /// 纯粹类处理层(CS)
 /// </summary>
public const string PureClassAccess_0193 = "0193";
 /// <summary>
 /// 静态业务逻辑扩展层(CS)
 /// </summary>
public const string BusinessLogicEx_Static_0194 = "0194";
 /// <summary>
 /// 静态业务逻辑层(CS)
 /// </summary>
public const string BusinessLogic_Static_0195 = "0195";
 /// <summary>
 /// WA_访问层公共函数类扩展(CS)
 /// </summary>
public const string CommFun4WA_0196 = "0196";
 /// <summary>
 /// 结点实体层(CS)
 /// </summary>
public const string NodeEntityLayer_0197 = "0197";
 /// <summary>
 /// 结点数据处理层(CS)
 /// </summary>
public const string NodeDALCode_0198 = "0198";
 /// <summary>
 /// 结点业务逻辑层(CS)
 /// </summary>
public const string NodeBusinessLogic_0199 = "0199";
 /// <summary>
 /// 结点Web界面后台(CS)
 /// </summary>
public const string NodeWVCCode_0200 = "0200";
 /// <summary>
 /// 结点WEB界面脚本(Html)
 /// </summary>
public const string NodeWVCode_0201 = "0201";
 /// <summary>
 /// 关系Web用户控件前台脚本(Html)
 /// </summary>
public const string RelaWCVCode_0202 = "0202";
 /// <summary>
 /// 结点Web用户控件后台(CS)
 /// </summary>
public const string NodeWCCCode_0203 = "0203";
 /// <summary>
 /// 结点Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string NodeWCVCode4Gv_0204 = "0204";
 /// <summary>
 /// 结点Web用户Gv控件后台(CS)
 /// </summary>
public const string NodeWCCCode4Gv_0205 = "0205";
 /// <summary>
 /// 结点实体扩展层(CS)
 /// </summary>
public const string NodeEntityLayerEx_0206 = "0206";
 /// <summary>
 /// 结点数据处理扩展层(CS)
 /// </summary>
public const string NodeDALExCode_0207 = "0207";
 /// <summary>
 /// 结点业务逻辑扩展层(CS)
 /// </summary>
public const string NodeBusinessLogicEx_0208 = "0208";
 /// <summary>
 /// 结点WA_服务层(CS)
 /// </summary>
public const string NodeWA_Srv_0209 = "0209";
 /// <summary>
 /// 结点WA_服务扩展层(CS)
 /// </summary>
public const string NodeWA_SrvEx_0210 = "0210";
 /// <summary>
 /// 结点WA_访问层(CS)
 /// </summary>
public const string NodeWA_Access_0211 = "0211";
 /// <summary>
 /// 结点WA_访问扩展层(CS)
 /// </summary>
public const string NodeWA_AccessEx_0212 = "0212";
 /// <summary>
 /// 关系实体层(CS)
 /// </summary>
public const string RelaEntityLayer_0213 = "0213";
 /// <summary>
 /// 关系实体扩展层(CS)
 /// </summary>
public const string RelaEntityLayerEx_0214 = "0214";
 /// <summary>
 /// 关系数据处理层(CS)
 /// </summary>
public const string RelaDALCode_0215 = "0215";
 /// <summary>
 /// 关系数据处理扩展层(CS)
 /// </summary>
public const string RelaDALExCode_0216 = "0216";
 /// <summary>
 /// 关系业务逻辑层(CS)
 /// </summary>
public const string RelaBusinessLogic_0217 = "0217";
 /// <summary>
 /// 关系业务逻辑扩展层(CS)
 /// </summary>
public const string RelaBusinessLogicEx_0218 = "0218";
 /// <summary>
 /// 关系WA_服务层(CS)
 /// </summary>
public const string RelaWA_Srv_0219 = "0219";
 /// <summary>
 /// 关系WA_服务扩展层(CS)
 /// </summary>
public const string RelaWA_SrvEx_0220 = "0220";
 /// <summary>
 /// 关系WA_访问层(CS)
 /// </summary>
public const string RelaWA_Access_0221 = "0221";
 /// <summary>
 /// 关系WA_访问扩展层(CS)
 /// </summary>
public const string RelaWA_AccessEx_0222 = "0222";
 /// <summary>
 /// 关系WEB界面前台脚本(Html)
 /// </summary>
public const string RelaWVCode_0223 = "0223";
 /// <summary>
 /// 关系Web界面后台(CS)
 /// </summary>
public const string RelaWVCCode_0224 = "0224";
 /// <summary>
 /// 关系Web用户控件后台(CS)
 /// </summary>
public const string RelaWCCCode_0225 = "0225";
 /// <summary>
 /// 关系Web用户Gv控件前台脚本(Html)
 /// </summary>
public const string RelaWCVCode4Gv_0226 = "0226";
 /// <summary>
 /// 关系Web用户Gv控件后台(CS)
 /// </summary>
public const string RelaWCCCode4Gv_0227 = "0227";
 /// <summary>
 /// 结点Web用户控件前台脚本(Html)
 /// </summary>
public const string NodeWCVCode_0228 = "0228";
 /// <summary>
 /// WA_访问层公共函数类扩展(TS)
 /// </summary>
public const string CommFun4WA_0229 = "0229";
 /// <summary>
 /// WA_访问扩展层(JS)
 /// </summary>
public const string WA_AccessEx_0230 = "0230";
 /// <summary>
 /// WA_界面UT后台RJ(JS)
 /// </summary>
public const string WA_ViewUTScriptCSRJ_0231 = "0231";
 /// <summary>
 /// WA_访问层RJ(JS)
 /// </summary>
public const string WA_AccessRJ_0232 = "0232";
 /// <summary>
 /// 实体层RJ(JS)
 /// </summary>
public const string EntityLayerRJ_0233 = "0233";
 /// <summary>
 /// 实体扩展层RJ(JS)
 /// </summary>
public const string EntityLayerRJEx_0234 = "0234";
 /// <summary>
 /// 简化实体层RJ(JS)
 /// </summary>
public const string EntityLayerRJ_Sim_0235 = "0235";
 /// <summary>
 /// 业务逻辑层RJ(JS)
 /// </summary>
public const string BusinessLogicRJ_0236 = "0236";
 /// <summary>
 /// WA_访问公共函数扩展(JS)
 /// </summary>
public const string CommFun4WARJ_0237 = "0237";
 /// <summary>
 /// WA_界面脚本_JS(Html)
 /// </summary>
public const string WA_ViewScript_JS_0238 = "0238";
 /// <summary>
 /// WA_界面后台_JS(JS)
 /// </summary>
public const string WA_ViewScriptCS_JS_0239 = "0239";
 /// <summary>
 /// WA_界面后台Ex_JS(JS)
 /// </summary>
public const string WA_ViewScriptCSEx_JS_0240 = "0240";
 /// <summary>
 /// WA_访问扩展层RJ(JS)
 /// </summary>
public const string WA_AccessRJEx_0241 = "0241";
 /// <summary>
 /// WA_编辑区_JS(Html)
 /// </summary>
public const string WA_ViewScript_Edit_JS_0242 = "0242";
 /// <summary>
 /// WA_编辑区_TS(Html)
 /// </summary>
public const string WA_ViewScript_Edit_TS_0243 = "0243";
 /// <summary>
 /// WA_详细信息_TS(Html)
 /// </summary>
public const string WA_ViewScript_Detail_TS_0244 = "0244";
 /// <summary>
 /// 纯粹类(TS)
 /// </summary>
public const string PureClass_0245 = "0245";
 /// <summary>
 /// 纯粹类处理层(TS)
 /// </summary>
public const string PureClassAccess_0246 = "0246";
 /// <summary>
 /// Copy_纯粹类(TS)
 /// </summary>
public const string PureClass_0247 = "0247";
 /// <summary>
 /// WA_编辑区后台_TS(TS)
 /// </summary>
public const string WA_ViewScript_EditCS_TS_0248 = "0248";
 /// <summary>
 /// WA_编辑区后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScript_EditCSEx_TS_0249 = "0249";
 /// <summary>
 /// WA_界面后台_TS(TS)
 /// </summary>
public const string WA_ViewScriptCS_TS_0250 = "0250";
 /// <summary>
 /// WA_详细信息后台_TS(TS)
 /// </summary>
public const string WA_ViewScript_DetailCS_TS_0251 = "0251";
 /// <summary>
 /// WA_详细信息后台Ex_TS(TS)
 /// </summary>
public const string WA_ViewScript_DetailCSEx_TS_0252 = "0252";
 /// <summary>
 /// Vue_界面脚本_TS(Html)
 /// </summary>
public const string Vue_ViewScript_TS_0253 = "0253";
 /// <summary>
 /// Vue_界面后台_TS(TS)
 /// </summary>
public const string Vue_ViewScriptCS_TS_0254 = "0254";
 /// <summary>
 /// Vue_界面后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScriptCSEx_TS_0255 = "0255";
 /// <summary>
 /// Vue_编辑区_TS(Html)
 /// </summary>
public const string Vue_ViewScript_Edit_TS_0256 = "0256";
 /// <summary>
 /// Vue_编辑区后台_TS(TS)
 /// </summary>
public const string Vue_ViewScript_EditCS_TS_0257 = "0257";
 /// <summary>
 /// Vue_编辑区后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScript_EditCSEx_TS_0258 = "0258";
 /// <summary>
 /// Vue_详细信息_TS(Html)
 /// </summary>
public const string Vue_ViewScript_Detail_TS_0259 = "0259";
 /// <summary>
 /// Vue_详细信息后台_TS(TS)
 /// </summary>
public const string Vue_ViewScript_DetailCS_TS_0260 = "0260";
 /// <summary>
 /// Vue_详细信息后台Ex_TS(TS)
 /// </summary>
public const string Vue_ViewScript_DetailCSEx_TS_0261 = "0261";
 /// <summary>
 /// 实体层Store(TS)
 /// </summary>
public const string StoreEntityLayer_0262 = "0262";
 /// <summary>
 /// Vue_列表区_TS(Html)
 /// </summary>
public const string Vue_ViewScript_List_TS_0263 = "0263";
 /// <summary>
 /// Vue共享(TS)
 /// </summary>
public const string Vue_Share_TS_0264 = "0264";
}
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCodeTypeBL
{
public static RelatedActions_CodeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCodeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCodeTypeDA CodeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCodeTypeDA();
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
 public clsCodeTypeBL()
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
if (string.IsNullOrEmpty(clsCodeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeTypeEN._ConnectString);
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
public static DataTable GetDataTable_CodeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CodeTypeDA.GetDataTable_CodeType(strWhereCond);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CodeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = CodeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeIdLst)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeTypeIdLst, true);
 string strWhereCond = string.Format("CodeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCodeTypeEN> GetObjLstByCodeTypeIdLstCache(List<string> arrCodeTypeIdLst)
{
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
List<clsCodeTypeEN> arrCodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel =
arrCodeTypeObjLstCache
.Where(x => arrCodeTypeIdLst.Contains(x.CodeTypeId));
return arrCodeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLst(string strWhereCond)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCodeTypeEN> GetSubObjLstCache(clsCodeTypeEN objCodeTypeCond)
{
List<clsCodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodeType._AttributeName)
{
if (objCodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objCodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeTypeCond[strFldName].ToString());
}
else
{
if (objCodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeTypeCond[strFldName]));
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
public static List<clsCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
List<clsCodeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCodeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
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
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = objRow[conCodeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum].ToString().Trim()); //序号
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改者
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCodeType(ref clsCodeTypeEN objCodeTypeEN)
{
bool bolResult = CodeTypeDA.GetCodeType(ref objCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByCodeTypeId(strCodeTypeId);
return objCodeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCodeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetFirstObj(strWhereCond);
 return objCodeTypeEN;
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
public static clsCodeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByDataRow(objRow);
 return objCodeTypeEN;
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
public static clsCodeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByDataRow(objRow);
 return objCodeTypeEN;
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
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <param name = "lstCodeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeIdFromList(string strCodeTypeId, List<clsCodeTypeEN> lstCodeTypeObjLst)
{
foreach (clsCodeTypeEN objCodeTypeEN in lstCodeTypeObjLst)
{
if (objCodeTypeEN.CodeTypeId == strCodeTypeId)
{
return objCodeTypeEN;
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
 string strMaxCodeTypeId;
 try
 {
 strMaxCodeTypeId = clsCodeTypeDA.GetMaxStrId();
 return strMaxCodeTypeId;
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
 string strCodeTypeId;
 try
 {
 strCodeTypeId = new clsCodeTypeDA().GetFirstID(strWhereCond);
 return strCodeTypeId;
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
 arrList = CodeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = CodeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CodeTypeDA.IsExist(strCodeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCodeTypeId">代码类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCodeTypeId, string strOpUser)
{
clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCodeTypeEN.UpdUser = strOpUser;
return clsCodeTypeBL.UpdateBySql2(objCodeTypeEN);
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
 bolIsExist = clsCodeTypeDA.IsExistTable();
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
 bolIsExist = CodeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCodeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordBySql2)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = CodeTypeDA.AddNewRecordBySQL2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCodeTypeEN objCodeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCodeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordBySql2WithReturnKey)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strKey = CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCodeTypeEN objCodeTypeEN)
{
try
{
bool bolResult = CodeTypeDA.Update(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCodeTypeEN objCodeTypeEN)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CodeTypeDA.UpdateBySql2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCodeTypeId)
{
try
{
 clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
}
if (objCodeTypeEN != null)
{
int intRecNum = CodeTypeDA.DelRecord(strCodeTypeId);
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
/// <param name="strCodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCodeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
//删除与表:[CodeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodeType.CodeTypeId,
//strCodeTypeId);
//        clsCodeTypeBL.DelCodeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeTypeBL.DelRecord(strCodeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
bool bolResult = CodeTypeDA.DelRecord(strCodeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCodeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCodeTypes(List<string> arrCodeTypeIdLst)
{
if (arrCodeTypeIdLst.Count == 0) return 0;
try
{
if (clsCodeTypeBL.relatedActions != null)
{
foreach (var strCodeTypeId in arrCodeTypeIdLst)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = CodeTypeDA.DelCodeType(arrCodeTypeIdLst);
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
public static int DelCodeTypesByCond(string strWhereCond)
{
try
{
if (clsCodeTypeBL.relatedActions != null)
{
List<string> arrCodeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCodeTypeId in arrCodeTypeId)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
}
int intRecNum = CodeTypeDA.DelCodeType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CodeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCodeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
//删除与表:[CodeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeTypeBL.DelRecord(strCodeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
 public static void CopyTo(clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
try
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //序号
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改者
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //说明
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
 /// <param name = "objCodeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsCodeTypeEN objCodeTypeEN)
{
try
{
objCodeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCodeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCodeType.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conCodeType.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(conCodeType.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(conCodeType.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName == "[null]" ? null :  objCodeTypeEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(conCodeType.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.GroupName = objCodeTypeEN.GroupName == "[null]" ? null :  objCodeTypeEN.GroupName; //组名
}
if (arrFldSet.Contains(conCodeType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conCodeType.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conCodeType.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.Prefix = objCodeTypeEN.Prefix == "[null]" ? null :  objCodeTypeEN.Prefix; //前缀
}
if (arrFldSet.Contains(conCodeType.DependsOn, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn == "[null]" ? null :  objCodeTypeEN.DependsOn; //依赖于
}
if (arrFldSet.Contains(conCodeType.FrontOrBack, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack == "[null]" ? null :  objCodeTypeEN.FrontOrBack; //前台Or后台
}
if (arrFldSet.Contains(conCodeType.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(conCodeType.ClassNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat == "[null]" ? null :  objCodeTypeEN.ClassNameFormat; //类名格式
}
if (arrFldSet.Contains(conCodeType.FileNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat == "[null]" ? null :  objCodeTypeEN.FileNameFormat; //文件名格式
}
if (arrFldSet.Contains(conCodeType.ClassNamePattern, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern == "[null]" ? null :  objCodeTypeEN.ClassNamePattern; //类名模式
}
if (arrFldSet.Contains(conCodeType.IsCSharp, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsCSharp = objCodeTypeEN.IsCSharp; //是否CSharp语言
}
if (arrFldSet.Contains(conCodeType.IsJava, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsJava = objCodeTypeEN.IsJava; //是否Java语言
}
if (arrFldSet.Contains(conCodeType.IsJavaScript, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsJavaScript = objCodeTypeEN.IsJavaScript; //是否JavaScript语言
}
if (arrFldSet.Contains(conCodeType.IsTypeScript, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsTypeScript = objCodeTypeEN.IsTypeScript; //是否TypeScript语言
}
if (arrFldSet.Contains(conCodeType.IsSilverLight, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsSilverLight = objCodeTypeEN.IsSilverLight; //是否SilverLight语言
}
if (arrFldSet.Contains(conCodeType.IsSwift, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsSwift = objCodeTypeEN.IsSwift; //是否Swift语言
}
if (arrFldSet.Contains(conCodeType.IsVB, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsVB = objCodeTypeEN.IsVB; //IsVB语言
}
if (arrFldSet.Contains(conCodeType.IsTableFldConst, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsTableFldConst = objCodeTypeEN.IsTableFldConst; //IsTableFldConst
}
if (arrFldSet.Contains(conCodeType.IsPubApp4WinWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsPubApp4WinWeb = objCodeTypeEN.IsPubApp4WinWeb; //IsPubApp4WinWeb
}
if (arrFldSet.Contains(conCodeType.IsWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWeb = objCodeTypeEN.IsWeb; //是否Web应用
}
if (arrFldSet.Contains(conCodeType.IsAspMvc, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsAspMvc = objCodeTypeEN.IsAspMvc; //是否AspMvc
}
if (arrFldSet.Contains(conCodeType.IsWebSrvAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWebSrvAccess = objCodeTypeEN.IsWebSrvAccess; //IsWebSrvAccess
}
if (arrFldSet.Contains(conCodeType.IsWin, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWin = objCodeTypeEN.IsWin; //是否Win应用
}
if (arrFldSet.Contains(conCodeType.IsMobileApp, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsMobileApp = objCodeTypeEN.IsMobileApp; //是否移动终端应用
}
if (arrFldSet.Contains(conCodeType.IsExtend, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsExtend = objCodeTypeEN.IsExtend; //是否扩展类
}
if (arrFldSet.Contains(conCodeType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.OrderNum = objCodeTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCodeType.WinOrWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb == "[null]" ? null :  objCodeTypeEN.WinOrWeb; //WinOrWeb
}
if (arrFldSet.Contains(conCodeType.IsDirByTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsDirByTabName = objCodeTypeEN.IsDirByTabName; //是否用表名作为路径
}
if (arrFldSet.Contains(conCodeType.IsDefaultOverride, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsDefaultOverride = objCodeTypeEN.IsDefaultOverride; //是否默认覆盖
}
if (arrFldSet.Contains(conCodeType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.InUse = objCodeTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCodeType.IsAutoParseFile, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsAutoParseFile = objCodeTypeEN.IsAutoParseFile; //是否自动分析文件
}
if (arrFldSet.Contains(conCodeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate == "[null]" ? null :  objCodeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCodeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser == "[null]" ? null :  objCodeTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCodeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.Memo = objCodeTypeEN.Memo == "[null]" ? null :  objCodeTypeEN.Memo; //说明
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
 /// <param name = "objCodeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsCodeTypeEN objCodeTypeEN)
{
try
{
if (objCodeTypeEN.CodeTypeENName == "[null]") objCodeTypeEN.CodeTypeENName = null; //代码类型英文名
if (objCodeTypeEN.GroupName == "[null]") objCodeTypeEN.GroupName = null; //组名
if (objCodeTypeEN.Prefix == "[null]") objCodeTypeEN.Prefix = null; //前缀
if (objCodeTypeEN.DependsOn == "[null]") objCodeTypeEN.DependsOn = null; //依赖于
if (objCodeTypeEN.FrontOrBack == "[null]") objCodeTypeEN.FrontOrBack = null; //前台Or后台
if (objCodeTypeEN.ClassNameFormat == "[null]") objCodeTypeEN.ClassNameFormat = null; //类名格式
if (objCodeTypeEN.FileNameFormat == "[null]") objCodeTypeEN.FileNameFormat = null; //文件名格式
if (objCodeTypeEN.ClassNamePattern == "[null]") objCodeTypeEN.ClassNamePattern = null; //类名模式
if (objCodeTypeEN.WinOrWeb == "[null]") objCodeTypeEN.WinOrWeb = null; //WinOrWeb
if (objCodeTypeEN.UpdDate == "[null]") objCodeTypeEN.UpdDate = null; //修改日期
if (objCodeTypeEN.UpdUser == "[null]") objCodeTypeEN.UpdUser = null; //修改者
if (objCodeTypeEN.Memo == "[null]") objCodeTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCodeTypeEN objCodeTypeEN)
{
 CodeTypeDA.CheckPropertyNew(objCodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCodeTypeEN objCodeTypeEN)
{
 CodeTypeDA.CheckProperty4Condition(objCodeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strProgLangTypeId"></param>
public static void BindCbo_CodeTypeId(System.Windows.Forms.ComboBox objComboBox , string strProgLangTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCodeType.CodeTypeId); 
List<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.ProgLangTypeId == strProgLangTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN()
{
CodeTypeId = "0",
CodeTypeName = "选[代码类型]..."
};
arrObjLstSel.Insert(0, objCodeTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCodeType.CodeTypeId;
objComboBox.DisplayMember = conCodeType.CodeTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strProgLangTypeId"></param>
public static void BindDdl_CodeTypeId(System.Web.UI.WebControls.DropDownList objDDL , string strProgLangTypeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCodeType.CodeTypeId); 
IEnumerable<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.ProgLangTypeId == strProgLangTypeId).ToList();
objDDL.DataValueField = conCodeType.CodeTypeId;
objDDL.DataTextField = conCodeType.CodeTypeName;
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
public static void BindDdl_CodeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码类型]...","0");
List<clsCodeTypeEN> arrCodeTypeObjLst = GetAllCodeTypeObjLstCache(); 
objDDL.DataValueField = conCodeType.CodeTypeId;
objDDL.DataTextField = conCodeType.CodeTypeName;
objDDL.DataSource = arrCodeTypeObjLst;
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTypeId");
//if (arrCodeTypeObjLstCache == null)
//{
//arrCodeTypeObjLstCache = CodeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeIdCache(string strCodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
List<clsCodeTypeEN> arrCodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel =
arrCodeTypeObjLstCache
.Where(x=> x.CodeTypeId == strCodeTypeId 
);
if (arrCodeTypeObjLst_Sel.Count() == 0)
{
   clsCodeTypeEN obj = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCodeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeTypeNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsCodeTypeEN objCodeType = GetObjByCodeTypeIdCache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType.CodeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeTypeIdCache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsCodeTypeEN objCodeType = GetObjByCodeTypeIdCache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType.CodeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeTypeEN> GetAllCodeTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsCodeTypeEN> arrCodeTypeObjLstCache = GetObjLstCache(); 
return arrCodeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
List<clsCodeTypeEN> arrCodeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCodeTypeObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:SqlDsTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCodeTypeObjLst">需要排序的对象列表</param>
public static List <clsCodeTypeEN> GetSubSet4CodeTypeObjLstBySqlDsTypeIdCache(string strSqlDsTypeId)
{
   if (string.IsNullOrEmpty(strSqlDsTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
List<clsCodeTypeEN> arrCodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel1 =
from objCodeTypeEN in arrCodeTypeObjLstCache
where objCodeTypeEN.SqlDsTypeId == strSqlDsTypeId
select objCodeTypeEN;
List <clsCodeTypeEN> arrCodeTypeObjLst_Sel = new List<clsCodeTypeEN>();
foreach (clsCodeTypeEN obj in arrCodeTypeObjLst_Sel1)
{
arrCodeTypeObjLst_Sel.Add(obj);
}
return arrCodeTypeObjLst_Sel;
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
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCodeTypeEN._RefreshTimeLst.Count == 0) return "";
return clsCodeTypeEN._RefreshTimeLst[clsCodeTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCodeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCodeTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CodeType(代码类型)
 /// 唯一性条件:CodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
string strResult = CodeTypeDA.GetUniCondStr(objCodeTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCodeTypeId)
{
if (strInFldName != conCodeType.CodeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCodeType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCodeType._AttributeName));
throw new Exception(strMsg);
}
var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType[strOutFldName].ToString();
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
int intRecCount = clsCodeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsCodeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCodeTypeDA.GetRecCount();
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
int intRecCount = clsCodeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCodeTypeEN objCodeTypeCond)
{
List<clsCodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodeType._AttributeName)
{
if (objCodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objCodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeTypeCond[strFldName].ToString());
}
else
{
if (objCodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeTypeCond[strFldName]));
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
 List<string> arrList = clsCodeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CodeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CodeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CodeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(clsCodeTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CodeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CodeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) primary key, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) not Null, "); 
 // /**简称*/ 
 strCreateTabCode.Append(" CodeTypeSimName varchar(50) not Null, "); 
 // /**代码类型英文名*/ 
 strCreateTabCode.Append(" CodeTypeENName varchar(50) Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) not Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) not Null, "); 
 // /**前缀*/ 
 strCreateTabCode.Append(" Prefix varchar(10) Null, "); 
 // /**依赖于*/ 
 strCreateTabCode.Append(" DependsOn varchar(50) Null, "); 
 // /**前台Or后台*/ 
 strCreateTabCode.Append(" FrontOrBack varchar(50) Null, "); 
 // /**数据源类型Id*/ 
 strCreateTabCode.Append(" SqlDsTypeId char(2) not Null, "); 
 // /**类名格式*/ 
 strCreateTabCode.Append(" ClassNameFormat varchar(50) Null, "); 
 // /**类名格式*/ 
 strCreateTabCode.Append(" ClassNameFormatEx varchar(50) Null, "); 
 // /**文件名格式*/ 
 strCreateTabCode.Append(" FileNameFormat varchar(50) Null, "); 
 // /**类名模式*/ 
 strCreateTabCode.Append(" ClassNamePattern varchar(50) Null, "); 
 // /**是否CSharp语言*/ 
 strCreateTabCode.Append(" IsCSharp bit Null, "); 
 // /**是否Java语言*/ 
 strCreateTabCode.Append(" IsJava bit Null, "); 
 // /**是否JavaScript语言*/ 
 strCreateTabCode.Append(" IsJavaScript bit Null, "); 
 // /**是否TypeScript语言*/ 
 strCreateTabCode.Append(" IsTypeScript bit Null, "); 
 // /**是否SilverLight语言*/ 
 strCreateTabCode.Append(" IsSilverLight bit Null, "); 
 // /**是否Swift语言*/ 
 strCreateTabCode.Append(" IsSwift bit Null, "); 
 // /**IsVB语言*/ 
 strCreateTabCode.Append(" IsVB bit Null, "); 
 // /**IsTableFldConst*/ 
 strCreateTabCode.Append(" IsTableFldConst bit Null, "); 
 // /**IsPubApp4WinWeb*/ 
 strCreateTabCode.Append(" IsPubApp4WinWeb bit Null, "); 
 // /**是否Web应用*/ 
 strCreateTabCode.Append(" IsWeb bit Null, "); 
 // /**是否AspMvc*/ 
 strCreateTabCode.Append(" IsAspMvc bit Null, "); 
 // /**IsWebSrvAccess*/ 
 strCreateTabCode.Append(" IsWebSrvAccess bit Null, "); 
 // /**是否Win应用*/ 
 strCreateTabCode.Append(" IsWin bit Null, "); 
 // /**是否移动终端应用*/ 
 strCreateTabCode.Append(" IsMobileApp bit Null, "); 
 // /**是否扩展类*/ 
 strCreateTabCode.Append(" IsExtend bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**WinOrWeb*/ 
 strCreateTabCode.Append(" WinOrWeb varchar(50) Null, "); 
 // /**是否用表名作为路径*/ 
 strCreateTabCode.Append(" IsDirByTabName bit Null, "); 
 // /**是否默认覆盖*/ 
 strCreateTabCode.Append(" IsDefaultOverride bit not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否自动分析文件*/ 
 strCreateTabCode.Append(" IsAutoParseFile bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**Sql数据源名*/ 
 strCreateTabCode.Append(" SqlDsTypeName varchar(20) Null, "); 
 // /**函数数目*/ 
 strCreateTabCode.Append(" FuncCount int not Null, "); 
 // /**应用数*/ 
 strCreateTabCode.Append(" AppCount int not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CodeType : clsCommFun4BL
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
clsCodeTypeBL.ReFreshThisCache();
}
}

}