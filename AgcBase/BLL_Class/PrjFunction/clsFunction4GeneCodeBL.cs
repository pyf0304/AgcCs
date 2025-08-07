
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4GeneCodeBL
 表名:Function4GeneCode(00050311)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsFunction4GeneCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4GeneCodeEN GetObj(this K_FuncId4GC_Function4GeneCode myKey)
{
clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.Function4GeneCodeDA.GetObjByFuncId4GC(myKey.Value);
return objFunction4GeneCodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4GeneCodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],函数代码类型Id = [{1}]的数据已经存在!(in clsFunction4GeneCodeBL.AddNewRecord)", objFunction4GeneCodeEN.FuncName,objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
bool bolResult = clsFunction4GeneCodeBL.Function4GeneCodeDA.AddNewRecordBySQL2(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
public static bool AddRecordEx(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFunction4GeneCodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunction4GeneCodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数名(FuncName)=[{0}],函数代码类型Id(FuncCodeTypeId)=[{1}])已经存在,不能重复!", objFunction4GeneCodeEN.FuncName, objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFunction4GeneCodeEN.AddNewRecord();
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4GeneCodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],函数代码类型Id = [{1}]的数据已经存在!(in clsFunction4GeneCodeBL.AddNewRecordWithMaxId)", objFunction4GeneCodeEN.FuncName,objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
string strFuncId4GC = clsFunction4GeneCodeBL.Function4GeneCodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4GeneCodeEN);
     objFunction4GeneCodeEN.FuncId4GC = strFuncId4GC;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
}
return strFuncId4GC;
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4GeneCodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],函数代码类型Id = [{1}]的数据已经存在!(in clsFunction4GeneCodeBL.AddNewRecordWithReturnKey)", objFunction4GeneCodeEN.FuncName,objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
string strKey = clsFunction4GeneCodeBL.Function4GeneCodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncId4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncId4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
}
objFunction4GeneCodeEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncId4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncId4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncId4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncName(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, conFunction4GeneCode.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, conFunction4GeneCode.FuncName);
}
objFunction4GeneCodeEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncName) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncName, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncName] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncId4Code(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
}
objFunction4GeneCodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncId4Code) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncId4Code, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncId4Code] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncName4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncName4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4GC, 50, conFunction4GeneCode.FuncName4GC);
}
objFunction4GeneCodeEN.FuncName4GC = strFuncName4GC; //函数名4生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncName4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncName4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncName4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCHName4GC(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCHName4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4GC, 50, conFunction4GeneCode.FuncCHName4GC);
}
objFunction4GeneCodeEN.FuncCHName4GC = strFuncCHName4GC; //函数中文名4生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCHName4GC) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCHName4GC, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCHName4GC] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFeatureId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFunction4GeneCode.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFunction4GeneCode.FeatureId);
}
objFunction4GeneCodeEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FeatureId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FeatureId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FeatureId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetProgLangTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conFunction4GeneCode.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
}
objFunction4GeneCodeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ProgLangTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ProgLangTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ProgLangTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCodeTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
}
objFunction4GeneCodeEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCodeTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCodeTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCodeTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetSqlDsTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conFunction4GeneCode.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
}
objFunction4GeneCodeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.SqlDsTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.SqlDsTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.SqlDsTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncGCTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, conFunction4GeneCode.FuncGCTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
}
objFunction4GeneCodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncGCTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncGCTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncGCTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetPrjId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFunction4GeneCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFunction4GeneCode.PrjId);
}
objFunction4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.PrjId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.PrjId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.PrjId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetReturnTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
}
objFunction4GeneCodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ReturnTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ReturnTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ReturnTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncTypeId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
}
objFunction4GeneCodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncTypeId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncTypeId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncTypeId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetIsTemplate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFunction4GeneCodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.IsTemplate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.IsTemplate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.IsTemplate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFunctionSignature(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conFunction4GeneCode.FunctionSignature);
}
objFunction4GeneCodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FunctionSignature) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FunctionSignature, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FunctionSignature] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetFuncCode(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strFuncCode, string strComparisonOp="")
	{
objFunction4GeneCodeEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.FuncCode) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.FuncCode, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.FuncCode] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUserId(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conFunction4GeneCode.UserId);
}
objFunction4GeneCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UserId) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UserId, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UserId] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetOrderNum(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFunction4GeneCode.OrderNum);
objFunction4GeneCodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.OrderNum) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.OrderNum, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.OrderNum] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetInUse(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolInUse, string strComparisonOp="")
	{
objFunction4GeneCodeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.InUse) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.InUse, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.InUse] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetPrimaryTypeIds(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strPrimaryTypeIds, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeIds, 50, conFunction4GeneCode.PrimaryTypeIds);
}
objFunction4GeneCodeEN.PrimaryTypeIds = strPrimaryTypeIds; //主键类型s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.PrimaryTypeIds) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.PrimaryTypeIds, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.PrimaryTypeIds] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetCodeText(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strCodeText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeText, 8000, conFunction4GeneCode.CodeText);
}
objFunction4GeneCodeEN.CodeText = strCodeText; //代码文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.CodeText) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.CodeText, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.CodeText] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUsedTimes(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, int? intUsedTimes, string strComparisonOp="")
	{
objFunction4GeneCodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UsedTimes) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UsedTimes, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UsedTimes] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUpdDate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunction4GeneCode.UpdDate);
}
objFunction4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UpdDate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UpdDate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UpdDate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetUpdUser(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunction4GeneCode.UpdUser);
}
objFunction4GeneCodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.UpdUser) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.UpdUser, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.UpdUser] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetMemo(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunction4GeneCode.Memo);
}
objFunction4GeneCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.Memo) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.Memo, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.Memo] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetParsedWords(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strParsedWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParsedWords, 500, conFunction4GeneCode.ParsedWords);
}
objFunction4GeneCodeEN.ParsedWords = strParsedWords; //分析的词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ParsedWords) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ParsedWords, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ParsedWords] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetParsedWordsExcluded(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strParsedWordsExcluded, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParsedWordsExcluded, 500, conFunction4GeneCode.ParsedWordsExcluded);
}
objFunction4GeneCodeEN.ParsedWordsExcluded = strParsedWordsExcluded; //剔除后的词组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.ParsedWordsExcluded) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.ParsedWordsExcluded, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.ParsedWordsExcluded] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetWordVector(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWordVector, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordVector, 500, conFunction4GeneCode.WordVector);
}
objFunction4GeneCodeEN.WordVector = strWordVector; //词向量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.WordVector) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.WordVector, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.WordVector] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4GeneCodeEN SetIsFuncTemplate(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsFuncTemplate, string strComparisonOp="")
	{
objFunction4GeneCodeEN.IsFuncTemplate = bolIsFuncTemplate; //是否函数模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4GeneCodeEN.dicFldComparisonOp.ContainsKey(conFunction4GeneCode.IsFuncTemplate) == false)
{
objFunction4GeneCodeEN.dicFldComparisonOp.Add(conFunction4GeneCode.IsFuncTemplate, strComparisonOp);
}
else
{
objFunction4GeneCodeEN.dicFldComparisonOp[conFunction4GeneCode.IsFuncTemplate] = strComparisonOp;
}
}
return objFunction4GeneCodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunction4GeneCodeEN.CheckPropertyNew();
clsFunction4GeneCodeEN objFunction4GeneCodeCond = new clsFunction4GeneCodeEN();
string strCondition = objFunction4GeneCodeCond
.SetFuncId4GC(objFunction4GeneCodeEN.FuncId4GC, "<>")
.SetFuncName(objFunction4GeneCodeEN.FuncName, "=")
.SetFuncCodeTypeId(objFunction4GeneCodeEN.FuncCodeTypeId, "=")
.GetCombineCondition();
objFunction4GeneCodeEN._IsCheckProperty = true;
bool bolIsExist = clsFunction4GeneCodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncName_FuncCodeTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunction4GeneCodeEN.Update();
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
 /// <param name = "objFunction4GeneCode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunction4GeneCodeEN objFunction4GeneCode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunction4GeneCodeEN objFunction4GeneCodeCond = new clsFunction4GeneCodeEN();
string strCondition = objFunction4GeneCodeCond
.SetFuncName(objFunction4GeneCode.FuncName, "=")
.SetFuncCodeTypeId(objFunction4GeneCode.FuncCodeTypeId, "=")
.GetCombineCondition();
objFunction4GeneCode._IsCheckProperty = true;
bool bolIsExist = clsFunction4GeneCodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunction4GeneCode.FuncId4GC = clsFunction4GeneCodeBL.GetFirstID_S(strCondition);
objFunction4GeneCode.UpdateWithCondition(strCondition);
}
else
{
objFunction4GeneCode.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
objFunction4GeneCode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunction4GeneCodeBL.Function4GeneCodeDA.UpdateBySql2(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunction4GeneCodeBL.Function4GeneCodeDA.UpdateBySql2(objFunction4GeneCodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWhereCond)
{
try
{
bool bolResult = clsFunction4GeneCodeBL.Function4GeneCodeDA.UpdateBySqlWithCondition(objFunction4GeneCodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunction4GeneCodeBL.Function4GeneCodeDA.UpdateBySqlWithConditionTransaction(objFunction4GeneCodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
int intRecNum = clsFunction4GeneCodeBL.Function4GeneCodeDA.DelRecord(objFunction4GeneCodeEN.FuncId4GC);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeENS">源对象</param>
 /// <param name = "objFunction4GeneCodeENT">目标对象</param>
 public static void CopyTo(this clsFunction4GeneCodeEN objFunction4GeneCodeENS, clsFunction4GeneCodeEN objFunction4GeneCodeENT)
{
try
{
objFunction4GeneCodeENT.FuncId4GC = objFunction4GeneCodeENS.FuncId4GC; //函数ID
objFunction4GeneCodeENT.FuncName = objFunction4GeneCodeENS.FuncName; //函数名
objFunction4GeneCodeENT.FuncId4Code = objFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objFunction4GeneCodeENT.FuncName4GC = objFunction4GeneCodeENS.FuncName4GC; //函数名4生成代码
objFunction4GeneCodeENT.FuncCHName4GC = objFunction4GeneCodeENS.FuncCHName4GC; //函数中文名4生成代码
objFunction4GeneCodeENT.FeatureId = objFunction4GeneCodeENS.FeatureId; //功能Id
objFunction4GeneCodeENT.ProgLangTypeId = objFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objFunction4GeneCodeENT.FuncCodeTypeId = objFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objFunction4GeneCodeENT.SqlDsTypeId = objFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objFunction4GeneCodeENT.FuncGCTypeId = objFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4GeneCodeENT.PrjId = objFunction4GeneCodeENS.PrjId; //工程Id
objFunction4GeneCodeENT.ReturnTypeId = objFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objFunction4GeneCodeENT.FuncTypeId = objFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objFunction4GeneCodeENT.IsTemplate = objFunction4GeneCodeENS.IsTemplate; //是否模板
objFunction4GeneCodeENT.FunctionSignature = objFunction4GeneCodeENS.FunctionSignature; //函数签名
objFunction4GeneCodeENT.FuncCode = objFunction4GeneCodeENS.FuncCode; //函数代码
objFunction4GeneCodeENT.UserId = objFunction4GeneCodeENS.UserId; //用户Id
objFunction4GeneCodeENT.OrderNum = objFunction4GeneCodeENS.OrderNum; //序号
objFunction4GeneCodeENT.InUse = objFunction4GeneCodeENS.InUse; //是否在用
objFunction4GeneCodeENT.PrimaryTypeIds = objFunction4GeneCodeENS.PrimaryTypeIds; //主键类型s
objFunction4GeneCodeENT.CodeText = objFunction4GeneCodeENS.CodeText; //代码文本
objFunction4GeneCodeENT.UsedTimes = objFunction4GeneCodeENS.UsedTimes; //使用次数
objFunction4GeneCodeENT.UpdDate = objFunction4GeneCodeENS.UpdDate; //修改日期
objFunction4GeneCodeENT.UpdUser = objFunction4GeneCodeENS.UpdUser; //修改者
objFunction4GeneCodeENT.Memo = objFunction4GeneCodeENS.Memo; //说明
objFunction4GeneCodeENT.ParsedWords = objFunction4GeneCodeENS.ParsedWords; //分析的词
objFunction4GeneCodeENT.ParsedWordsExcluded = objFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objFunction4GeneCodeENT.WordVector = objFunction4GeneCodeENS.WordVector; //词向量
objFunction4GeneCodeENT.IsFuncTemplate = objFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
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
 /// <param name = "objFunction4GeneCodeENS">源对象</param>
 /// <returns>目标对象=>clsFunction4GeneCodeEN:objFunction4GeneCodeENT</returns>
 public static clsFunction4GeneCodeEN CopyTo(this clsFunction4GeneCodeEN objFunction4GeneCodeENS)
{
try
{
 clsFunction4GeneCodeEN objFunction4GeneCodeENT = new clsFunction4GeneCodeEN()
{
FuncId4GC = objFunction4GeneCodeENS.FuncId4GC, //函数ID
FuncName = objFunction4GeneCodeENS.FuncName, //函数名
FuncId4Code = objFunction4GeneCodeENS.FuncId4Code, //函数Id4Code
FuncName4GC = objFunction4GeneCodeENS.FuncName4GC, //函数名4生成代码
FuncCHName4GC = objFunction4GeneCodeENS.FuncCHName4GC, //函数中文名4生成代码
FeatureId = objFunction4GeneCodeENS.FeatureId, //功能Id
ProgLangTypeId = objFunction4GeneCodeENS.ProgLangTypeId, //编程语言类型Id
FuncCodeTypeId = objFunction4GeneCodeENS.FuncCodeTypeId, //函数代码类型Id
SqlDsTypeId = objFunction4GeneCodeENS.SqlDsTypeId, //数据源类型Id
FuncGCTypeId = objFunction4GeneCodeENS.FuncGCTypeId, //函数生成代码类型Id
PrjId = objFunction4GeneCodeENS.PrjId, //工程Id
ReturnTypeId = objFunction4GeneCodeENS.ReturnTypeId, //返回类型ID
FuncTypeId = objFunction4GeneCodeENS.FuncTypeId, //函数类型Id
IsTemplate = objFunction4GeneCodeENS.IsTemplate, //是否模板
FunctionSignature = objFunction4GeneCodeENS.FunctionSignature, //函数签名
FuncCode = objFunction4GeneCodeENS.FuncCode, //函数代码
UserId = objFunction4GeneCodeENS.UserId, //用户Id
OrderNum = objFunction4GeneCodeENS.OrderNum, //序号
InUse = objFunction4GeneCodeENS.InUse, //是否在用
PrimaryTypeIds = objFunction4GeneCodeENS.PrimaryTypeIds, //主键类型s
CodeText = objFunction4GeneCodeENS.CodeText, //代码文本
UsedTimes = objFunction4GeneCodeENS.UsedTimes, //使用次数
UpdDate = objFunction4GeneCodeENS.UpdDate, //修改日期
UpdUser = objFunction4GeneCodeENS.UpdUser, //修改者
Memo = objFunction4GeneCodeENS.Memo, //说明
ParsedWords = objFunction4GeneCodeENS.ParsedWords, //分析的词
ParsedWordsExcluded = objFunction4GeneCodeENS.ParsedWordsExcluded, //剔除后的词组
WordVector = objFunction4GeneCodeENS.WordVector, //词向量
IsFuncTemplate = objFunction4GeneCodeENS.IsFuncTemplate, //是否函数模板
};
 return objFunction4GeneCodeENT;
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
public static void CheckPropertyNew(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 clsFunction4GeneCodeBL.Function4GeneCodeDA.CheckPropertyNew(objFunction4GeneCodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 clsFunction4GeneCodeBL.Function4GeneCodeDA.CheckProperty4Condition(objFunction4GeneCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunction4GeneCodeEN objFunction4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncId4GC, objFunction4GeneCodeCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncName) == true)
{
string strComparisonOpFuncName = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncName, objFunction4GeneCodeCond.FuncName, strComparisonOpFuncName);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncId4Code, objFunction4GeneCodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncName4GC) == true)
{
string strComparisonOpFuncName4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncName4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncName4GC, objFunction4GeneCodeCond.FuncName4GC, strComparisonOpFuncName4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncCHName4GC) == true)
{
string strComparisonOpFuncCHName4GC = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncCHName4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncCHName4GC, objFunction4GeneCodeCond.FuncCHName4GC, strComparisonOpFuncCHName4GC);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FeatureId) == true)
{
string strComparisonOpFeatureId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FeatureId, objFunction4GeneCodeCond.FeatureId, strComparisonOpFeatureId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ProgLangTypeId, objFunction4GeneCodeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncCodeTypeId, objFunction4GeneCodeCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.SqlDsTypeId, objFunction4GeneCodeCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncGCTypeId, objFunction4GeneCodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.PrjId, objFunction4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ReturnTypeId, objFunction4GeneCodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FuncTypeId, objFunction4GeneCodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.IsTemplate) == true)
{
if (objFunction4GeneCodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.IsTemplate);
}
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.FunctionSignature, objFunction4GeneCodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UserId) == true)
{
string strComparisonOpUserId = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UserId, objFunction4GeneCodeCond.UserId, strComparisonOpUserId);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4GeneCode.OrderNum, objFunction4GeneCodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.InUse) == true)
{
if (objFunction4GeneCodeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.InUse);
}
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.PrimaryTypeIds) == true)
{
string strComparisonOpPrimaryTypeIds = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.PrimaryTypeIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.PrimaryTypeIds, objFunction4GeneCodeCond.PrimaryTypeIds, strComparisonOpPrimaryTypeIds);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.CodeText) == true)
{
string strComparisonOpCodeText = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.CodeText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.CodeText, objFunction4GeneCodeCond.CodeText, strComparisonOpCodeText);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4GeneCode.UsedTimes, objFunction4GeneCodeCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UpdDate, objFunction4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.UpdUser, objFunction4GeneCodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.Memo) == true)
{
string strComparisonOpMemo = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.Memo, objFunction4GeneCodeCond.Memo, strComparisonOpMemo);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ParsedWords) == true)
{
string strComparisonOpParsedWords = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ParsedWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ParsedWords, objFunction4GeneCodeCond.ParsedWords, strComparisonOpParsedWords);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded) == true)
{
string strComparisonOpParsedWordsExcluded = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.ParsedWordsExcluded];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.ParsedWordsExcluded, objFunction4GeneCodeCond.ParsedWordsExcluded, strComparisonOpParsedWordsExcluded);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.WordVector) == true)
{
string strComparisonOpWordVector = objFunction4GeneCodeCond.dicFldComparisonOp[conFunction4GeneCode.WordVector];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4GeneCode.WordVector, objFunction4GeneCodeCond.WordVector, strComparisonOpWordVector);
}
if (objFunction4GeneCodeCond.IsUpdated(conFunction4GeneCode.IsFuncTemplate) == true)
{
if (objFunction4GeneCodeCond.IsFuncTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4GeneCode.IsFuncTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4GeneCode.IsFuncTemplate);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Function4GeneCode(函数4GeneCode), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncName_FuncCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunction4GeneCodeEN == null) return true;
if (objFunction4GeneCodeEN.FuncId4GC == null || objFunction4GeneCodeEN.FuncId4GC == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 if (objFunction4GeneCodeEN.FuncCodeTypeId == null)
{
 sbCondition.AppendFormat(" and FuncCodeTypeId is null", objFunction4GeneCodeEN.FuncCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
}
if (clsFunction4GeneCodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncId4GC !=  '{0}'", objFunction4GeneCodeEN.FuncId4GC);
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
if (clsFunction4GeneCodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Function4GeneCode(函数4GeneCode), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncName_FuncCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunction4GeneCodeEN == null) return "";
if (objFunction4GeneCodeEN.FuncId4GC == null || objFunction4GeneCodeEN.FuncId4GC == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 if (objFunction4GeneCodeEN.FuncCodeTypeId == null)
{
 sbCondition.AppendFormat(" and FuncCodeTypeId is null", objFunction4GeneCodeEN.FuncCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncId4GC !=  '{0}'", objFunction4GeneCodeEN.FuncId4GC);
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Function4GeneCode
{
public virtual bool UpdRelaTabDate(string strFuncId4GC, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数4GeneCode(Function4GeneCode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunction4GeneCodeBL
{
public static RelatedActions_Function4GeneCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunction4GeneCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunction4GeneCodeDA Function4GeneCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunction4GeneCodeDA();
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
 public clsFunction4GeneCodeBL()
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
if (string.IsNullOrEmpty(clsFunction4GeneCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunction4GeneCodeEN._ConnectString);
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
public static DataTable GetDataTable_Function4GeneCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Function4GeneCodeDA.GetDataTable_Function4GeneCode(strWhereCond);
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
objDT = Function4GeneCodeDA.GetDataTable(strWhereCond);
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
objDT = Function4GeneCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Function4GeneCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Function4GeneCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Function4GeneCodeDA.GetDataTable_Top(objTopPara);
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
objDT = Function4GeneCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Function4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Function4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLstByFuncId4GCLst(List<string> arrFuncId4GCLst)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncId4GCLst, true);
 string strWhereCond = string.Format("FuncId4GC in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4GCLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunction4GeneCodeEN> GetObjLstByFuncId4GCLstCache(List<string> arrFuncId4GCLst)
{
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel =
arrFunction4GeneCodeObjLstCache
.Where(x => arrFuncId4GCLst.Contains(x.FuncId4GC));
return arrFunction4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLst(string strWhereCond)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
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
public static List<clsFunction4GeneCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunction4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunction4GeneCodeEN> GetSubObjLstCache(clsFunction4GeneCodeEN objFunction4GeneCodeCond)
{
List<clsFunction4GeneCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunction4GeneCode._AttributeName)
{
if (objFunction4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objFunction4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4GeneCodeCond[strFldName].ToString());
}
else
{
if (objFunction4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunction4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunction4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunction4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunction4GeneCodeCond[strFldName]));
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
public static List<clsFunction4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
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
List<clsFunction4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunction4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunction4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
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
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
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
public static List<clsFunction4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunction4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
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
public static List<clsFunction4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4GeneCodeEN.FuncId4GC, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunction4GeneCode(ref clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
bool bolResult = Function4GeneCodeDA.GetFunction4GeneCode(ref objFunction4GeneCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
if (strFuncId4GC.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId4GC]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId4GC]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFunction4GeneCodeEN objFunction4GeneCodeEN = Function4GeneCodeDA.GetObjByFuncId4GC(strFuncId4GC);
return objFunction4GeneCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunction4GeneCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunction4GeneCodeEN objFunction4GeneCodeEN = Function4GeneCodeDA.GetFirstObj(strWhereCond);
 return objFunction4GeneCodeEN;
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
public static clsFunction4GeneCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunction4GeneCodeEN objFunction4GeneCodeEN = Function4GeneCodeDA.GetObjByDataRow(objRow);
 return objFunction4GeneCodeEN;
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
public static clsFunction4GeneCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunction4GeneCodeEN objFunction4GeneCodeEN = Function4GeneCodeDA.GetObjByDataRow(objRow);
 return objFunction4GeneCodeEN;
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
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <param name = "lstFunction4GeneCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunction4GeneCodeEN GetObjByFuncId4GCFromList(string strFuncId4GC, List<clsFunction4GeneCodeEN> lstFunction4GeneCodeObjLst)
{
foreach (clsFunction4GeneCodeEN objFunction4GeneCodeEN in lstFunction4GeneCodeObjLst)
{
if (objFunction4GeneCodeEN.FuncId4GC == strFuncId4GC)
{
return objFunction4GeneCodeEN;
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
 string strMaxFuncId4GC;
 try
 {
 strMaxFuncId4GC = clsFunction4GeneCodeDA.GetMaxStrId();
 return strMaxFuncId4GC;
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
 string strFuncId4GC;
 try
 {
 strFuncId4GC = new clsFunction4GeneCodeDA().GetFirstID(strWhereCond);
 return strFuncId4GC;
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
 arrList = Function4GeneCodeDA.GetID(strWhereCond);
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
bool bolIsExist = Function4GeneCodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId4GC]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = Function4GeneCodeDA.IsExist(strFuncId4GC);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncId4GC">函数ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncId4GC, string strOpUser)
{
clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunction4GeneCodeEN.UpdUser = strOpUser;
return clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);
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
 bolIsExist = clsFunction4GeneCodeDA.IsExistTable();
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
 bolIsExist = Function4GeneCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunction4GeneCodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],函数代码类型Id = [{1}]的数据已经存在!(in clsFunction4GeneCodeBL.AddNewRecordBySql2)", objFunction4GeneCodeEN.FuncName,objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
bool bolResult = Function4GeneCodeDA.AddNewRecordBySQL2(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunction4GeneCodeEN objFunction4GeneCodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunction4GeneCodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],函数代码类型Id = [{1}]的数据已经存在!(in clsFunction4GeneCodeBL.AddNewRecordBySql2WithReturnKey)", objFunction4GeneCodeEN.FuncName,objFunction4GeneCodeEN.FuncCodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true || clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
     objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
 }
string strKey = Function4GeneCodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
bool bolResult = Function4GeneCodeDA.Update(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 if (string.IsNullOrEmpty(objFunction4GeneCodeEN.FuncId4GC) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Function4GeneCodeDA.UpdateBySql2(objFunction4GeneCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4GeneCodeBL.ReFreshCache();

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
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
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncId4GC)
{
try
{
 clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);

if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(objFunction4GeneCodeEN.FuncId4GC, objFunction4GeneCodeEN.UpdUser);
}
if (objFunction4GeneCodeEN != null)
{
int intRecNum = Function4GeneCodeDA.DelRecord(strFuncId4GC);
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
/// <param name="strFuncId4GC">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncId4GC )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
//删除与表:[Function4GeneCode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunction4GeneCode.FuncId4GC,
//strFuncId4GC);
//        clsFunction4GeneCodeBL.DelFunction4GeneCodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunction4GeneCodeBL.DelRecord(strFuncId4GC, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunction4GeneCodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId4GC, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncId4GC, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFunction4GeneCodeBL.relatedActions != null)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(strFuncId4GC, "UpdRelaTabDate");
}
bool bolResult = Function4GeneCodeDA.DelRecord(strFuncId4GC,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncId4GCLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFunction4GeneCodes(List<string> arrFuncId4GCLst)
{
if (arrFuncId4GCLst.Count == 0) return 0;
try
{
if (clsFunction4GeneCodeBL.relatedActions != null)
{
foreach (var strFuncId4GC in arrFuncId4GCLst)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(strFuncId4GC, "UpdRelaTabDate");
}
}
int intDelRecNum = Function4GeneCodeDA.DelFunction4GeneCode(arrFuncId4GCLst);
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
public static int DelFunction4GeneCodesByCond(string strWhereCond)
{
try
{
if (clsFunction4GeneCodeBL.relatedActions != null)
{
List<string> arrFuncId4GC = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncId4GC in arrFuncId4GC)
{
clsFunction4GeneCodeBL.relatedActions.UpdRelaTabDate(strFuncId4GC, "UpdRelaTabDate");
}
}
int intRecNum = Function4GeneCodeDA.DelFunction4GeneCode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Function4GeneCode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncId4GC">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncId4GC)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
//删除与表:[Function4GeneCode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunction4GeneCodeBL.DelRecord(strFuncId4GC, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunction4GeneCodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId4GC, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunction4GeneCodeENS">源对象</param>
 /// <param name = "objFunction4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsFunction4GeneCodeEN objFunction4GeneCodeENS, clsFunction4GeneCodeEN objFunction4GeneCodeENT)
{
try
{
objFunction4GeneCodeENT.FuncId4GC = objFunction4GeneCodeENS.FuncId4GC; //函数ID
objFunction4GeneCodeENT.FuncName = objFunction4GeneCodeENS.FuncName; //函数名
objFunction4GeneCodeENT.FuncId4Code = objFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objFunction4GeneCodeENT.FuncName4GC = objFunction4GeneCodeENS.FuncName4GC; //函数名4生成代码
objFunction4GeneCodeENT.FuncCHName4GC = objFunction4GeneCodeENS.FuncCHName4GC; //函数中文名4生成代码
objFunction4GeneCodeENT.FeatureId = objFunction4GeneCodeENS.FeatureId; //功能Id
objFunction4GeneCodeENT.ProgLangTypeId = objFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objFunction4GeneCodeENT.FuncCodeTypeId = objFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objFunction4GeneCodeENT.SqlDsTypeId = objFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objFunction4GeneCodeENT.FuncGCTypeId = objFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4GeneCodeENT.PrjId = objFunction4GeneCodeENS.PrjId; //工程Id
objFunction4GeneCodeENT.ReturnTypeId = objFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objFunction4GeneCodeENT.FuncTypeId = objFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objFunction4GeneCodeENT.IsTemplate = objFunction4GeneCodeENS.IsTemplate; //是否模板
objFunction4GeneCodeENT.FunctionSignature = objFunction4GeneCodeENS.FunctionSignature; //函数签名
objFunction4GeneCodeENT.FuncCode = objFunction4GeneCodeENS.FuncCode; //函数代码
objFunction4GeneCodeENT.UserId = objFunction4GeneCodeENS.UserId; //用户Id
objFunction4GeneCodeENT.OrderNum = objFunction4GeneCodeENS.OrderNum; //序号
objFunction4GeneCodeENT.InUse = objFunction4GeneCodeENS.InUse; //是否在用
objFunction4GeneCodeENT.PrimaryTypeIds = objFunction4GeneCodeENS.PrimaryTypeIds; //主键类型s
objFunction4GeneCodeENT.CodeText = objFunction4GeneCodeENS.CodeText; //代码文本
objFunction4GeneCodeENT.UsedTimes = objFunction4GeneCodeENS.UsedTimes; //使用次数
objFunction4GeneCodeENT.UpdDate = objFunction4GeneCodeENS.UpdDate; //修改日期
objFunction4GeneCodeENT.UpdUser = objFunction4GeneCodeENS.UpdUser; //修改者
objFunction4GeneCodeENT.Memo = objFunction4GeneCodeENS.Memo; //说明
objFunction4GeneCodeENT.ParsedWords = objFunction4GeneCodeENS.ParsedWords; //分析的词
objFunction4GeneCodeENT.ParsedWordsExcluded = objFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objFunction4GeneCodeENT.WordVector = objFunction4GeneCodeENS.WordVector; //词向量
objFunction4GeneCodeENT.IsFuncTemplate = objFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
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
 /// <param name = "objFunction4GeneCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
objFunction4GeneCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunction4GeneCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunction4GeneCode.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncId4GC = objFunction4GeneCodeEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncName = objFunction4GeneCodeEN.FuncName; //函数名
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncId4Code = objFunction4GeneCodeEN.FuncId4Code == "[null]" ? null :  objFunction4GeneCodeEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncName4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncName4GC = objFunction4GeneCodeEN.FuncName4GC == "[null]" ? null :  objFunction4GeneCodeEN.FuncName4GC; //函数名4生成代码
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncCHName4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC == "[null]" ? null :  objFunction4GeneCodeEN.FuncCHName4GC; //函数中文名4生成代码
}
if (arrFldSet.Contains(conFunction4GeneCode.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FeatureId = objFunction4GeneCodeEN.FeatureId == "[null]" ? null :  objFunction4GeneCodeEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conFunction4GeneCode.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.ProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId == "[null]" ? null :  objFunction4GeneCodeEN.FuncCodeTypeId; //函数代码类型Id
}
if (arrFldSet.Contains(conFunction4GeneCode.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.SqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncGCTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId; //函数生成代码类型Id
}
if (arrFldSet.Contains(conFunction4GeneCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.PrjId = objFunction4GeneCodeEN.PrjId == "[null]" ? null :  objFunction4GeneCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFunction4GeneCode.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.ReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId == "[null]" ? null :  objFunction4GeneCodeEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncTypeId = objFunction4GeneCodeEN.FuncTypeId == "[null]" ? null :  objFunction4GeneCodeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conFunction4GeneCode.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.IsTemplate = objFunction4GeneCodeEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conFunction4GeneCode.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FunctionSignature = objFunction4GeneCodeEN.FunctionSignature == "[null]" ? null :  objFunction4GeneCodeEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(conFunction4GeneCode.FuncCode, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.FuncCode = objFunction4GeneCodeEN.FuncCode == "[null]" ? null :  objFunction4GeneCodeEN.FuncCode; //函数代码
}
if (arrFldSet.Contains(conFunction4GeneCode.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.UserId = objFunction4GeneCodeEN.UserId == "[null]" ? null :  objFunction4GeneCodeEN.UserId; //用户Id
}
if (arrFldSet.Contains(conFunction4GeneCode.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.OrderNum = objFunction4GeneCodeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFunction4GeneCode.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.InUse = objFunction4GeneCodeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conFunction4GeneCode.PrimaryTypeIds, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.PrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds == "[null]" ? null :  objFunction4GeneCodeEN.PrimaryTypeIds; //主键类型s
}
if (arrFldSet.Contains(conFunction4GeneCode.CodeText, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.CodeText = objFunction4GeneCodeEN.CodeText == "[null]" ? null :  objFunction4GeneCodeEN.CodeText; //代码文本
}
if (arrFldSet.Contains(conFunction4GeneCode.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.UsedTimes = objFunction4GeneCodeEN.UsedTimes; //使用次数
}
if (arrFldSet.Contains(conFunction4GeneCode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.UpdDate = objFunction4GeneCodeEN.UpdDate == "[null]" ? null :  objFunction4GeneCodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunction4GeneCode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.UpdUser = objFunction4GeneCodeEN.UpdUser == "[null]" ? null :  objFunction4GeneCodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFunction4GeneCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.Memo = objFunction4GeneCodeEN.Memo == "[null]" ? null :  objFunction4GeneCodeEN.Memo; //说明
}
if (arrFldSet.Contains(conFunction4GeneCode.ParsedWords, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.ParsedWords = objFunction4GeneCodeEN.ParsedWords == "[null]" ? null :  objFunction4GeneCodeEN.ParsedWords; //分析的词
}
if (arrFldSet.Contains(conFunction4GeneCode.ParsedWordsExcluded, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.ParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded == "[null]" ? null :  objFunction4GeneCodeEN.ParsedWordsExcluded; //剔除后的词组
}
if (arrFldSet.Contains(conFunction4GeneCode.WordVector, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.WordVector = objFunction4GeneCodeEN.WordVector == "[null]" ? null :  objFunction4GeneCodeEN.WordVector; //词向量
}
if (arrFldSet.Contains(conFunction4GeneCode.IsFuncTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4GeneCodeEN.IsFuncTemplate = objFunction4GeneCodeEN.IsFuncTemplate; //是否函数模板
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
 /// <param name = "objFunction4GeneCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
try
{
if (objFunction4GeneCodeEN.FuncId4Code == "[null]") objFunction4GeneCodeEN.FuncId4Code = null; //函数Id4Code
if (objFunction4GeneCodeEN.FuncName4GC == "[null]") objFunction4GeneCodeEN.FuncName4GC = null; //函数名4生成代码
if (objFunction4GeneCodeEN.FuncCHName4GC == "[null]") objFunction4GeneCodeEN.FuncCHName4GC = null; //函数中文名4生成代码
if (objFunction4GeneCodeEN.FeatureId == "[null]") objFunction4GeneCodeEN.FeatureId = null; //功能Id
if (objFunction4GeneCodeEN.FuncCodeTypeId == "[null]") objFunction4GeneCodeEN.FuncCodeTypeId = null; //函数代码类型Id
if (objFunction4GeneCodeEN.PrjId == "[null]") objFunction4GeneCodeEN.PrjId = null; //工程Id
if (objFunction4GeneCodeEN.ReturnTypeId == "[null]") objFunction4GeneCodeEN.ReturnTypeId = null; //返回类型ID
if (objFunction4GeneCodeEN.FuncTypeId == "[null]") objFunction4GeneCodeEN.FuncTypeId = null; //函数类型Id
if (objFunction4GeneCodeEN.FunctionSignature == "[null]") objFunction4GeneCodeEN.FunctionSignature = null; //函数签名
if (objFunction4GeneCodeEN.FuncCode == "[null]") objFunction4GeneCodeEN.FuncCode = null; //函数代码
if (objFunction4GeneCodeEN.UserId == "[null]") objFunction4GeneCodeEN.UserId = null; //用户Id
if (objFunction4GeneCodeEN.PrimaryTypeIds == "[null]") objFunction4GeneCodeEN.PrimaryTypeIds = null; //主键类型s
if (objFunction4GeneCodeEN.CodeText == "[null]") objFunction4GeneCodeEN.CodeText = null; //代码文本
if (objFunction4GeneCodeEN.UpdDate == "[null]") objFunction4GeneCodeEN.UpdDate = null; //修改日期
if (objFunction4GeneCodeEN.UpdUser == "[null]") objFunction4GeneCodeEN.UpdUser = null; //修改者
if (objFunction4GeneCodeEN.Memo == "[null]") objFunction4GeneCodeEN.Memo = null; //说明
if (objFunction4GeneCodeEN.ParsedWords == "[null]") objFunction4GeneCodeEN.ParsedWords = null; //分析的词
if (objFunction4GeneCodeEN.ParsedWordsExcluded == "[null]") objFunction4GeneCodeEN.ParsedWordsExcluded = null; //剔除后的词组
if (objFunction4GeneCodeEN.WordVector == "[null]") objFunction4GeneCodeEN.WordVector = null; //词向量
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
public static void CheckPropertyNew(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 Function4GeneCodeDA.CheckPropertyNew(objFunction4GeneCodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 Function4GeneCodeDA.CheckProperty4Condition(objFunction4GeneCodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindCbo_FuncId4GC(System.Windows.Forms.ComboBox objComboBox , string strFuncCodeTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunction4GeneCode.FuncId4GC); 
List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN()
{
FuncId4GC = "0",
FuncName = "选[函数4GeneCode]..."
};
arrObjLstSel.Insert(0, objFunction4GeneCodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunction4GeneCode.FuncId4GC;
objComboBox.DisplayMember = conFunction4GeneCode.FuncName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncCodeTypeId"></param>
public static void BindDdl_FuncId4GC(System.Web.UI.WebControls.DropDownList objDDL , string strFuncCodeTypeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数4GeneCode]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFunction4GeneCode.FuncId4GC); 
IEnumerable<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncCodeTypeId == strFuncCodeTypeId).ToList();
objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
objDDL.DataTextField = conFunction4GeneCode.FuncName;
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
public static void BindDdl_FuncId4GCCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数4GeneCode]...","0");
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = GetAllFunction4GeneCodeObjLstCache(); 
objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
objDDL.DataTextField = conFunction4GeneCode.FuncName;
objDDL.DataSource = arrFunction4GeneCodeObjLst;
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
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId4GC");
//if (arrFunction4GeneCodeObjLstCache == null)
//{
//arrFunction4GeneCodeObjLstCache = Function4GeneCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunction4GeneCodeEN GetObjByFuncId4GCCache(string strFuncId4GC)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel =
arrFunction4GeneCodeObjLstCache
.Where(x=> x.FuncId4GC == strFuncId4GC 
);
if (arrFunction4GeneCodeObjLst_Sel.Count() == 0)
{
   clsFunction4GeneCodeEN obj = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunction4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//获取缓存中的对象列表
clsFunction4GeneCodeEN objFunction4GeneCode = GetObjByFuncId4GCCache(strFuncId4GC);
if (objFunction4GeneCode == null) return "";
return objFunction4GeneCode.FuncName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4GC">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncId4GCCache(string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFuncId4GC) == true) return "";
//获取缓存中的对象列表
clsFunction4GeneCodeEN objFunction4GeneCode = GetObjByFuncId4GCCache(strFuncId4GC);
if (objFunction4GeneCode == null) return "";
return objFunction4GeneCode.FuncName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetAllFunction4GeneCodeObjLstCache()
{
//获取缓存中的对象列表
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache(); 
return arrFunction4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunction4GeneCodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunction4GeneCodeObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:ProgLangTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunction4GeneCodeObjLst">需要排序的对象列表</param>
public static List <clsFunction4GeneCodeEN> GetSubSet4Function4GeneCodeObjLstByProgLangTypeIdCache(string strProgLangTypeId)
{
   if (string.IsNullOrEmpty(strProgLangTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
from objFunction4GeneCodeEN in arrFunction4GeneCodeObjLstCache
where objFunction4GeneCodeEN.ProgLangTypeId == strProgLangTypeId
select objFunction4GeneCodeEN;
List <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsFunction4GeneCodeEN>();
foreach (clsFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
{
arrFunction4GeneCodeObjLst_Sel.Add(obj);
}
return arrFunction4GeneCodeObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:SqlDsTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunction4GeneCodeObjLst">需要排序的对象列表</param>
public static List <clsFunction4GeneCodeEN> GetSubSet4Function4GeneCodeObjLstBySqlDsTypeIdCache(string strSqlDsTypeId)
{
   if (string.IsNullOrEmpty(strSqlDsTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
from objFunction4GeneCodeEN in arrFunction4GeneCodeObjLstCache
where objFunction4GeneCodeEN.SqlDsTypeId == strSqlDsTypeId
select objFunction4GeneCodeEN;
List <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsFunction4GeneCodeEN>();
foreach (clsFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
{
arrFunction4GeneCodeObjLst_Sel.Add(obj);
}
return arrFunction4GeneCodeObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFunction4GeneCodeObjLst">需要排序的对象列表</param>
public static List <clsFunction4GeneCodeEN> GetSubSet4Function4GeneCodeObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
from objFunction4GeneCodeEN in arrFunction4GeneCodeObjLstCache
where objFunction4GeneCodeEN.PrjId == strPrjId
select objFunction4GeneCodeEN;
List <clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsFunction4GeneCodeEN>();
foreach (clsFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
{
arrFunction4GeneCodeObjLst_Sel.Add(obj);
}
return arrFunction4GeneCodeObjLst_Sel;
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
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunction4GeneCodeEN._RefreshTimeLst.Count == 0) return "";
return clsFunction4GeneCodeEN._RefreshTimeLst[clsFunction4GeneCodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFunction4GeneCodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunction4GeneCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunction4GeneCodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Function4GeneCode(函数4GeneCode)
 /// 唯一性条件:FuncName_FuncCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检测记录是否存在
string strResult = Function4GeneCodeDA.GetUniCondStr(objFunction4GeneCodeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncId4GC)
{
if (strInFldName != conFunction4GeneCode.FuncId4GC)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunction4GeneCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunction4GeneCode._AttributeName));
throw new Exception(strMsg);
}
var objFunction4GeneCode = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(strFuncId4GC);
if (objFunction4GeneCode == null) return "";
return objFunction4GeneCode[strOutFldName].ToString();
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
int intRecCount = clsFunction4GeneCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsFunction4GeneCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunction4GeneCodeDA.GetRecCount();
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
int intRecCount = clsFunction4GeneCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunction4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunction4GeneCodeEN objFunction4GeneCodeCond)
{
List<clsFunction4GeneCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunction4GeneCode._AttributeName)
{
if (objFunction4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objFunction4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4GeneCodeCond[strFldName].ToString());
}
else
{
if (objFunction4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunction4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunction4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunction4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunction4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunction4GeneCodeCond[strFldName]));
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
 List<string> arrList = clsFunction4GeneCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Function4GeneCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Function4GeneCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Function4GeneCodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunction4GeneCodeDA.SetFldValue(clsFunction4GeneCodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Function4GeneCodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunction4GeneCodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunction4GeneCodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunction4GeneCodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Function4GeneCode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId4GC char(10) primary key, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) not Null, "); 
 // /**函数Id4Code*/ 
 strCreateTabCode.Append(" FuncId4Code char(8) Null, "); 
 // /**函数名4生成代码*/ 
 strCreateTabCode.Append(" FuncName4GC varchar(50) Null, "); 
 // /**函数中文名4生成代码*/ 
 strCreateTabCode.Append(" FuncCHName4GC varchar(50) Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) not Null, "); 
 // /**函数代码类型Id*/ 
 strCreateTabCode.Append(" FuncCodeTypeId char(4) Null, "); 
 // /**数据源类型Id*/ 
 strCreateTabCode.Append(" SqlDsTypeId char(2) not Null, "); 
 // /**函数生成代码类型Id*/ 
 strCreateTabCode.Append(" FuncGCTypeId char(2) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**返回类型ID*/ 
 strCreateTabCode.Append(" ReturnTypeId char(2) Null, "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit Null, "); 
 // /**函数签名*/ 
 strCreateTabCode.Append(" FunctionSignature varchar(500) Null, "); 
 // /**函数代码*/ 
 strCreateTabCode.Append(" FuncCode text Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**主键类型s*/ 
 strCreateTabCode.Append(" PrimaryTypeIds varchar(50) Null, "); 
 // /**代码文本*/ 
 strCreateTabCode.Append(" CodeText varchar(8000) Null, "); 
 // /**使用次数*/ 
 strCreateTabCode.Append(" UsedTimes int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**分析的词*/ 
 strCreateTabCode.Append(" ParsedWords varchar(500) Null, "); 
 // /**剔除后的词组*/ 
 strCreateTabCode.Append(" ParsedWordsExcluded varchar(500) Null, "); 
 // /**词向量*/ 
 strCreateTabCode.Append(" WordVector varchar(500) Null, "); 
 // /**是否函数模板*/ 
 strCreateTabCode.Append(" IsFuncTemplate bit Null, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) Null, "); 
 // /**函数名4Code*/ 
 strCreateTabCode.Append(" FuncName4Code varchar(100) Null, "); 
 // /**函数类型名*/ 
 strCreateTabCode.Append(" FuncTypeName varchar(20) Null, "); 
 // /**函数生成代码类型名*/ 
 strCreateTabCode.Append(" FuncGCTypeName varchar(50) Null, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) Null, "); 
 // /**Sql数据源名*/ 
 strCreateTabCode.Append(" SqlDsTypeName varchar(20) Null, "); 
 // /**父功能名*/ 
 strCreateTabCode.Append(" ParentFeatureName varchar(500) Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数4GeneCode(Function4GeneCode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Function4GeneCode : clsCommFun4BL
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
clsFunction4GeneCodeBL.ReFreshThisCache();
}
}

}