
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4CodeBL
 表名:Function4Code(00050386)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:49
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
public static class  clsFunction4CodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4CodeEN GetObj(this K_FuncId4Code_Function4Code myKey)
{
clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.Function4CodeDA.GetObjByFuncId4Code(myKey.Value);
return objFunction4CodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名4Code = [{0}],类名 = [{1}],函数用途Id = [{2}],工程Id = [{3}],代码类型Id = [{4}]的数据已经存在!(in clsFunction4CodeBL.AddNewRecord)", objFunction4CodeEN.FuncName4Code,objFunction4CodeEN.ClsName,objFunction4CodeEN.FuncPurposeId,objFunction4CodeEN.PrjId,objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
bool bolResult = clsFunction4CodeBL.Function4CodeDA.AddNewRecordBySQL2(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
public static bool AddRecordEx(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFunction4CodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunction4CodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数名4Code(FuncName4Code)=[{0}],类名(ClsName)=[{1}],函数用途Id(FuncPurposeId)=[{2}],工程Id(PrjId)=[{3}],代码类型Id(CodeTypeId)=[{4}])已经存在,不能重复!", objFunction4CodeEN.FuncName4Code, objFunction4CodeEN.ClsName, objFunction4CodeEN.FuncPurposeId, objFunction4CodeEN.PrjId, objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFunction4CodeEN.AddNewRecord();
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名4Code = [{0}],类名 = [{1}],函数用途Id = [{2}],工程Id = [{3}],代码类型Id = [{4}]的数据已经存在!(in clsFunction4CodeBL.AddNewRecordWithMaxId)", objFunction4CodeEN.FuncName4Code,objFunction4CodeEN.ClsName,objFunction4CodeEN.FuncPurposeId,objFunction4CodeEN.PrjId,objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
string strFuncId4Code = clsFunction4CodeBL.Function4CodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4CodeEN);
     objFunction4CodeEN.FuncId4Code = strFuncId4Code;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
}
return strFuncId4Code;
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunction4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名4Code = [{0}],类名 = [{1}],函数用途Id = [{2}],工程Id = [{3}],代码类型Id = [{4}]的数据已经存在!(in clsFunction4CodeBL.AddNewRecordWithReturnKey)", objFunction4CodeEN.FuncName4Code,objFunction4CodeEN.ClsName,objFunction4CodeEN.FuncPurposeId,objFunction4CodeEN.PrjId,objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
string strKey = clsFunction4CodeBL.Function4CodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncId4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, conFunction4Code.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, conFunction4Code.FuncId4Code);
}
objFunction4CodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncId4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncId4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncId4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncName4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, conFunction4Code.FuncName4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, conFunction4Code.FuncName4Code);
}
objFunction4CodeEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncName4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncName4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncName4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncCHName4Code(this clsFunction4CodeEN objFunction4CodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, conFunction4Code.FuncCHName4Code);
}
objFunction4CodeEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncCHName4Code) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncCHName4Code, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncCHName4Code] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetPrevFuncId(this clsFunction4CodeEN objFunction4CodeEN, string strPrevFuncId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrevFuncId, 8, conFunction4Code.PrevFuncId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrevFuncId, 8, conFunction4Code.PrevFuncId);
}
objFunction4CodeEN.PrevFuncId = strPrevFuncId; //前函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.PrevFuncId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.PrevFuncId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.PrevFuncId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetRootFuncId(this clsFunction4CodeEN objFunction4CodeEN, string strRootFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRootFuncId, conFunction4Code.RootFuncId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootFuncId, 8, conFunction4Code.RootFuncId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootFuncId, 8, conFunction4Code.RootFuncId);
}
objFunction4CodeEN.RootFuncId = strRootFuncId; //根函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.RootFuncId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.RootFuncId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.RootFuncId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetApplicationTypeId(this clsFunction4CodeEN objFunction4CodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conFunction4Code.ApplicationTypeId);
objFunction4CodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ApplicationTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ApplicationTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ApplicationTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncGCTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
}
objFunction4CodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncGCTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncGCTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncGCTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFunctionSignature(this clsFunction4CodeEN objFunction4CodeEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conFunction4Code.FunctionSignature);
}
objFunction4CodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FunctionSignature) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FunctionSignature, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FunctionSignature] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFunctionSignatureSim(this clsFunction4CodeEN objFunction4CodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, conFunction4Code.FunctionSignatureSim);
}
objFunction4CodeEN.FunctionSignatureSim = strFunctionSignatureSim; //函数签名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FunctionSignatureSim) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FunctionSignatureSim, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FunctionSignatureSim] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnType(this clsFunction4CodeEN objFunction4CodeEN, string strReturnType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, conFunction4Code.ReturnType);
}
objFunction4CodeEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnType) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnType, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnType] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetClsName(this clsFunction4CodeEN objFunction4CodeEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conFunction4Code.ClsName);
}
objFunction4CodeEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ClsName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ClsName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ClsName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeFullName(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conFunction4Code.ReturnTypeFullName);
}
objFunction4CodeEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeFullName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeFullName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeFullName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conFunction4Code.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conFunction4Code.ReturnTypeId);
}
objFunction4CodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetReturnTypeNameCustom(this clsFunction4CodeEN objFunction4CodeEN, string strReturnTypeNameCustom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeNameCustom, 50, conFunction4Code.ReturnTypeNameCustom);
}
objFunction4CodeEN.ReturnTypeNameCustom = strReturnTypeNameCustom; //定制返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.ReturnTypeNameCustom) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.ReturnTypeNameCustom, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.ReturnTypeNameCustom] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetCodeTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conFunction4Code.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conFunction4Code.CodeTypeId);
}
objFunction4CodeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.CodeTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.CodeTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.CodeTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncAccessModeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncAccessModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
}
objFunction4CodeEN.FuncAccessModeId = strFuncAccessModeId; //函数操作模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncAccessModeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncAccessModeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncAccessModeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetTabName(this clsFunction4CodeEN objFunction4CodeEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conFunction4Code.TabName);
}
objFunction4CodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.TabName) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.TabName, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.TabName] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetTabId(this clsFunction4CodeEN objFunction4CodeEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conFunction4Code.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conFunction4Code.TabId);
}
objFunction4CodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.TabId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.TabId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.TabId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncPurposeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, conFunction4Code.FuncPurposeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, conFunction4Code.FuncPurposeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, conFunction4Code.FuncPurposeId);
}
objFunction4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncPurposeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncPurposeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncPurposeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetFuncTypeId(this clsFunction4CodeEN objFunction4CodeEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunction4Code.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunction4Code.FuncTypeId);
}
objFunction4CodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.FuncTypeId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.FuncTypeId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.FuncTypeId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetGetCustomAttributes(this clsFunction4CodeEN objFunction4CodeEN, int intGetCustomAttributes, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intGetCustomAttributes, conFunction4Code.GetCustomAttributes);
objFunction4CodeEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.GetCustomAttributes) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.GetCustomAttributes, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.GetCustomAttributes] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetSourceFunction(this clsFunction4CodeEN objFunction4CodeEN, string strSourceFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conFunction4Code.SourceFunction);
}
objFunction4CodeEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.SourceFunction) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.SourceFunction, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.SourceFunction] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsAsyncFunc(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objFunction4CodeEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsAsyncFunc) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsAsyncFunc, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsAsyncFunc] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsSysFunction(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objFunction4CodeEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsSysFunction) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsSysFunction, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsSysFunction] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetOrderNum(this clsFunction4CodeEN objFunction4CodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFunction4Code.OrderNum);
objFunction4CodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.OrderNum) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.OrderNum, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.OrderNum] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetPrjId(this clsFunction4CodeEN objFunction4CodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFunction4Code.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFunction4Code.PrjId);
}
objFunction4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.PrjId) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.PrjId, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.PrjId] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetIsTemplate(this clsFunction4CodeEN objFunction4CodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFunction4CodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.IsTemplate) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.IsTemplate, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.IsTemplate] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUpdDate(this clsFunction4CodeEN objFunction4CodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunction4Code.UpdDate);
}
objFunction4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UpdDate) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UpdDate, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UpdDate] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUpdUser(this clsFunction4CodeEN objFunction4CodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunction4Code.UpdUser);
}
objFunction4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UpdUser) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UpdUser, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UpdUser] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetMemo(this clsFunction4CodeEN objFunction4CodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunction4Code.Memo);
}
objFunction4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.Memo) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.Memo, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.Memo] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunction4CodeEN SetUsedTimes(this clsFunction4CodeEN objFunction4CodeEN, int? intUsedTimes, string strComparisonOp="")
	{
objFunction4CodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunction4CodeEN.dicFldComparisonOp.ContainsKey(conFunction4Code.UsedTimes) == false)
{
objFunction4CodeEN.dicFldComparisonOp.Add(conFunction4Code.UsedTimes, strComparisonOp);
}
else
{
objFunction4CodeEN.dicFldComparisonOp[conFunction4Code.UsedTimes] = strComparisonOp;
}
}
return objFunction4CodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunction4CodeEN objFunction4CodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunction4CodeEN.CheckPropertyNew();
clsFunction4CodeEN objFunction4CodeCond = new clsFunction4CodeEN();
string strCondition = objFunction4CodeCond
.SetFuncId4Code(objFunction4CodeEN.FuncId4Code, "<>")
.SetFuncName4Code(objFunction4CodeEN.FuncName4Code, "=")
.SetClsName(objFunction4CodeEN.ClsName, "=")
.SetFuncPurposeId(objFunction4CodeEN.FuncPurposeId, "=")
.SetPrjId(objFunction4CodeEN.PrjId, "=")
.SetCodeTypeId(objFunction4CodeEN.CodeTypeId, "=")
.GetCombineCondition();
objFunction4CodeEN._IsCheckProperty = true;
bool bolIsExist = clsFunction4CodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncName4Code_ClsName_FuncPurposeId_PrjId_CodeTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunction4CodeEN.Update();
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
 /// <param name = "objFunction4Code">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunction4CodeEN objFunction4Code)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunction4CodeEN objFunction4CodeCond = new clsFunction4CodeEN();
string strCondition = objFunction4CodeCond
.SetFuncName4Code(objFunction4Code.FuncName4Code, "=")
.SetClsName(objFunction4Code.ClsName, "=")
.SetFuncPurposeId(objFunction4Code.FuncPurposeId, "=")
.SetPrjId(objFunction4Code.PrjId, "=")
.SetCodeTypeId(objFunction4Code.CodeTypeId, "=")
.GetCombineCondition();
objFunction4Code._IsCheckProperty = true;
bool bolIsExist = clsFunction4CodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunction4Code.FuncId4Code = clsFunction4CodeBL.GetFirstID_S(strCondition);
objFunction4Code.UpdateWithCondition(strCondition);
}
else
{
objFunction4Code.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
objFunction4Code.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4CodeEN objFunction4CodeEN)
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunction4CodeBL.Function4CodeDA.UpdateBySql2(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunction4CodeEN objFunction4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunction4CodeBL.Function4CodeDA.UpdateBySql2(objFunction4CodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4CodeEN objFunction4CodeEN, string strWhereCond)
{
try
{
bool bolResult = clsFunction4CodeBL.Function4CodeDA.UpdateBySqlWithCondition(objFunction4CodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunction4CodeEN objFunction4CodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunction4CodeBL.Function4CodeDA.UpdateBySqlWithConditionTransaction(objFunction4CodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFunction4CodeEN objFunction4CodeEN)
{
try
{
int intRecNum = clsFunction4CodeBL.Function4CodeDA.DelRecord(objFunction4CodeEN.FuncId4Code);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeENS">源对象</param>
 /// <param name = "objFunction4CodeENT">目标对象</param>
 public static void CopyTo(this clsFunction4CodeEN objFunction4CodeENS, clsFunction4CodeEN objFunction4CodeENT)
{
try
{
objFunction4CodeENT.FuncId4Code = objFunction4CodeENS.FuncId4Code; //函数Id4Code
objFunction4CodeENT.FuncName4Code = objFunction4CodeENS.FuncName4Code; //函数名4Code
objFunction4CodeENT.FuncCHName4Code = objFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objFunction4CodeENT.PrevFuncId = objFunction4CodeENS.PrevFuncId; //前函数Id
objFunction4CodeENT.RootFuncId = objFunction4CodeENS.RootFuncId; //根函数Id
objFunction4CodeENT.ApplicationTypeId = objFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objFunction4CodeENT.FuncGCTypeId = objFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4CodeENT.FunctionSignature = objFunction4CodeENS.FunctionSignature; //函数签名
objFunction4CodeENT.FunctionSignatureSim = objFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objFunction4CodeENT.ReturnType = objFunction4CodeENS.ReturnType; //返回类型
objFunction4CodeENT.ClsName = objFunction4CodeENS.ClsName; //类名
objFunction4CodeENT.ReturnTypeFullName = objFunction4CodeENS.ReturnTypeFullName; //返回类型全名
objFunction4CodeENT.ReturnTypeId = objFunction4CodeENS.ReturnTypeId; //返回类型ID
objFunction4CodeENT.ReturnTypeNameCustom = objFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objFunction4CodeENT.CodeTypeId = objFunction4CodeENS.CodeTypeId; //代码类型Id
objFunction4CodeENT.FuncAccessModeId = objFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objFunction4CodeENT.TabName = objFunction4CodeENS.TabName; //表名
objFunction4CodeENT.TabId = objFunction4CodeENS.TabId; //表ID
objFunction4CodeENT.FuncPurposeId = objFunction4CodeENS.FuncPurposeId; //函数用途Id
objFunction4CodeENT.FuncTypeId = objFunction4CodeENS.FuncTypeId; //函数类型Id
objFunction4CodeENT.GetCustomAttributes = objFunction4CodeENS.GetCustomAttributes; //GetCustomAttributes
objFunction4CodeENT.SourceFunction = objFunction4CodeENS.SourceFunction; //来源函数
objFunction4CodeENT.IsAsyncFunc = objFunction4CodeENS.IsAsyncFunc; //是否异步函数
objFunction4CodeENT.IsSysFunction = objFunction4CodeENS.IsSysFunction; //是否系统函数
objFunction4CodeENT.OrderNum = objFunction4CodeENS.OrderNum; //序号
objFunction4CodeENT.PrjId = objFunction4CodeENS.PrjId; //工程Id
objFunction4CodeENT.IsTemplate = objFunction4CodeENS.IsTemplate; //是否模板
objFunction4CodeENT.UpdDate = objFunction4CodeENS.UpdDate; //修改日期
objFunction4CodeENT.UpdUser = objFunction4CodeENS.UpdUser; //修改者
objFunction4CodeENT.Memo = objFunction4CodeENS.Memo; //说明
objFunction4CodeENT.UsedTimes = objFunction4CodeENS.UsedTimes; //使用次数
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
 /// <param name = "objFunction4CodeENS">源对象</param>
 /// <returns>目标对象=>clsFunction4CodeEN:objFunction4CodeENT</returns>
 public static clsFunction4CodeEN CopyTo(this clsFunction4CodeEN objFunction4CodeENS)
{
try
{
 clsFunction4CodeEN objFunction4CodeENT = new clsFunction4CodeEN()
{
FuncId4Code = objFunction4CodeENS.FuncId4Code, //函数Id4Code
FuncName4Code = objFunction4CodeENS.FuncName4Code, //函数名4Code
FuncCHName4Code = objFunction4CodeENS.FuncCHName4Code, //函数中文名4Code
PrevFuncId = objFunction4CodeENS.PrevFuncId, //前函数Id
RootFuncId = objFunction4CodeENS.RootFuncId, //根函数Id
ApplicationTypeId = objFunction4CodeENS.ApplicationTypeId, //应用程序类型ID
FuncGCTypeId = objFunction4CodeENS.FuncGCTypeId, //函数生成代码类型Id
FunctionSignature = objFunction4CodeENS.FunctionSignature, //函数签名
FunctionSignatureSim = objFunction4CodeENS.FunctionSignatureSim, //函数签名_Sim
ReturnType = objFunction4CodeENS.ReturnType, //返回类型
ClsName = objFunction4CodeENS.ClsName, //类名
ReturnTypeFullName = objFunction4CodeENS.ReturnTypeFullName, //返回类型全名
ReturnTypeId = objFunction4CodeENS.ReturnTypeId, //返回类型ID
ReturnTypeNameCustom = objFunction4CodeENS.ReturnTypeNameCustom, //定制返回类型名
CodeTypeId = objFunction4CodeENS.CodeTypeId, //代码类型Id
FuncAccessModeId = objFunction4CodeENS.FuncAccessModeId, //函数操作模式Id
TabName = objFunction4CodeENS.TabName, //表名
TabId = objFunction4CodeENS.TabId, //表ID
FuncPurposeId = objFunction4CodeENS.FuncPurposeId, //函数用途Id
FuncTypeId = objFunction4CodeENS.FuncTypeId, //函数类型Id
GetCustomAttributes = objFunction4CodeENS.GetCustomAttributes, //GetCustomAttributes
SourceFunction = objFunction4CodeENS.SourceFunction, //来源函数
IsAsyncFunc = objFunction4CodeENS.IsAsyncFunc, //是否异步函数
IsSysFunction = objFunction4CodeENS.IsSysFunction, //是否系统函数
OrderNum = objFunction4CodeENS.OrderNum, //序号
PrjId = objFunction4CodeENS.PrjId, //工程Id
IsTemplate = objFunction4CodeENS.IsTemplate, //是否模板
UpdDate = objFunction4CodeENS.UpdDate, //修改日期
UpdUser = objFunction4CodeENS.UpdUser, //修改者
Memo = objFunction4CodeENS.Memo, //说明
UsedTimes = objFunction4CodeENS.UsedTimes, //使用次数
};
 return objFunction4CodeENT;
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
public static void CheckPropertyNew(this clsFunction4CodeEN objFunction4CodeEN)
{
 clsFunction4CodeBL.Function4CodeDA.CheckPropertyNew(objFunction4CodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunction4CodeEN objFunction4CodeEN)
{
 clsFunction4CodeBL.Function4CodeDA.CheckProperty4Condition(objFunction4CodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunction4CodeEN objFunction4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncId4Code, objFunction4CodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncName4Code, objFunction4CodeCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncCHName4Code, objFunction4CodeCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.PrevFuncId) == true)
{
string strComparisonOpPrevFuncId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.PrevFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.PrevFuncId, objFunction4CodeCond.PrevFuncId, strComparisonOpPrevFuncId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.RootFuncId) == true)
{
string strComparisonOpRootFuncId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.RootFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.RootFuncId, objFunction4CodeCond.RootFuncId, strComparisonOpRootFuncId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.ApplicationTypeId, objFunction4CodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncGCTypeId, objFunction4CodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FunctionSignature, objFunction4CodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FunctionSignatureSim) == true)
{
string strComparisonOpFunctionSignatureSim = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FunctionSignatureSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FunctionSignatureSim, objFunction4CodeCond.FunctionSignatureSim, strComparisonOpFunctionSignatureSim);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnType) == true)
{
string strComparisonOpReturnType = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnType, objFunction4CodeCond.ReturnType, strComparisonOpReturnType);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ClsName) == true)
{
string strComparisonOpClsName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ClsName, objFunction4CodeCond.ClsName, strComparisonOpClsName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeFullName, objFunction4CodeCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeId, objFunction4CodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.ReturnTypeNameCustom) == true)
{
string strComparisonOpReturnTypeNameCustom = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.ReturnTypeNameCustom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.ReturnTypeNameCustom, objFunction4CodeCond.ReturnTypeNameCustom, strComparisonOpReturnTypeNameCustom);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.CodeTypeId, objFunction4CodeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncAccessModeId) == true)
{
string strComparisonOpFuncAccessModeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncAccessModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncAccessModeId, objFunction4CodeCond.FuncAccessModeId, strComparisonOpFuncAccessModeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.TabName) == true)
{
string strComparisonOpTabName = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.TabName, objFunction4CodeCond.TabName, strComparisonOpTabName);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.TabId) == true)
{
string strComparisonOpTabId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.TabId, objFunction4CodeCond.TabId, strComparisonOpTabId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncPurposeId, objFunction4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.FuncTypeId, objFunction4CodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.GetCustomAttributes, objFunction4CodeCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.SourceFunction, objFunction4CodeCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsAsyncFunc) == true)
{
if (objFunction4CodeCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsAsyncFunc);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsSysFunction) == true)
{
if (objFunction4CodeCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsSysFunction);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.OrderNum, objFunction4CodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.PrjId) == true)
{
string strComparisonOpPrjId = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.PrjId, objFunction4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.IsTemplate) == true)
{
if (objFunction4CodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunction4Code.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunction4Code.IsTemplate);
}
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.UpdDate, objFunction4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.UpdUser, objFunction4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.Memo) == true)
{
string strComparisonOpMemo = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunction4Code.Memo, objFunction4CodeCond.Memo, strComparisonOpMemo);
}
if (objFunction4CodeCond.IsUpdated(conFunction4Code.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objFunction4CodeCond.dicFldComparisonOp[conFunction4Code.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conFunction4Code.UsedTimes, objFunction4CodeCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Function4Code(函数4Code), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncName4Code_ClsName_FuncPurposeId_PrjId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunction4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunction4CodeEN objFunction4CodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunction4CodeEN == null) return true;
if (objFunction4CodeEN.FuncId4Code == null || objFunction4CodeEN.FuncId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 if (objFunction4CodeEN.ClsName == null)
{
 sbCondition.AppendFormat(" and ClsName is null", objFunction4CodeEN.ClsName);
}
else
{
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
}
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 if (objFunction4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objFunction4CodeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
}
 if (objFunction4CodeEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objFunction4CodeEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
}
if (clsFunction4CodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncId4Code !=  '{0}'", objFunction4CodeEN.FuncId4Code);
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
if (clsFunction4CodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Function4Code(函数4Code), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncName4Code_ClsName_FuncPurposeId_PrjId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunction4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunction4CodeEN objFunction4CodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunction4CodeEN == null) return "";
if (objFunction4CodeEN.FuncId4Code == null || objFunction4CodeEN.FuncId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 if (objFunction4CodeEN.ClsName == null)
{
 sbCondition.AppendFormat(" and ClsName is null", objFunction4CodeEN.ClsName);
}
else
{
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
}
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 if (objFunction4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objFunction4CodeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
}
 if (objFunction4CodeEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objFunction4CodeEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncId4Code !=  '{0}'", objFunction4CodeEN.FuncId4Code);
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Function4Code
{
public virtual bool UpdRelaTabDate(string strFuncId4Code, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数4Code(Function4Code)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunction4CodeBL
{
public static RelatedActions_Function4Code relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunction4CodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunction4CodeDA Function4CodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunction4CodeDA();
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
 public clsFunction4CodeBL()
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
if (string.IsNullOrEmpty(clsFunction4CodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunction4CodeEN._ConnectString);
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
public static DataTable GetDataTable_Function4Code(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Function4CodeDA.GetDataTable_Function4Code(strWhereCond);
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
objDT = Function4CodeDA.GetDataTable(strWhereCond);
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
objDT = Function4CodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Function4CodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Function4CodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Function4CodeDA.GetDataTable_Top(objTopPara);
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
objDT = Function4CodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Function4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Function4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstByFuncId4CodeLst(List<string> arrFuncId4CodeLst)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncId4CodeLst, true);
 string strWhereCond = string.Format("FuncId4Code in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunction4CodeEN> GetObjLstByFuncId4CodeLstCache(List<string> arrFuncId4CodeLst)
{
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel =
arrFunction4CodeObjLstCache
.Where(x => arrFuncId4CodeLst.Contains(x.FuncId4Code));
return arrFunction4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLst(string strWhereCond)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
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
public static List<clsFunction4CodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunction4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunction4CodeEN> GetSubObjLstCache(clsFunction4CodeEN objFunction4CodeCond)
{
List<clsFunction4CodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunction4Code._AttributeName)
{
if (objFunction4CodeCond.IsUpdated(strFldName) == false) continue;
if (objFunction4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4CodeCond[strFldName].ToString());
}
else
{
if (objFunction4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunction4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunction4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunction4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunction4CodeCond[strFldName]));
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
public static List<clsFunction4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
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
public static List<clsFunction4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
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
List<clsFunction4CodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunction4CodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunction4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
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
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
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
public static List<clsFunction4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunction4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
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
public static List<clsFunction4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunction4CodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunction4Code(ref clsFunction4CodeEN objFunction4CodeEN)
{
bool bolResult = Function4CodeDA.GetFunction4Code(ref objFunction4CodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
if (strFuncId4Code.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId4Code]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId4Code]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFunction4CodeEN objFunction4CodeEN = Function4CodeDA.GetObjByFuncId4Code(strFuncId4Code);
return objFunction4CodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunction4CodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunction4CodeEN objFunction4CodeEN = Function4CodeDA.GetFirstObj(strWhereCond);
 return objFunction4CodeEN;
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
public static clsFunction4CodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunction4CodeEN objFunction4CodeEN = Function4CodeDA.GetObjByDataRow(objRow);
 return objFunction4CodeEN;
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
public static clsFunction4CodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunction4CodeEN objFunction4CodeEN = Function4CodeDA.GetObjByDataRow(objRow);
 return objFunction4CodeEN;
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
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <param name = "lstFunction4CodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunction4CodeEN GetObjByFuncId4CodeFromList(string strFuncId4Code, List<clsFunction4CodeEN> lstFunction4CodeObjLst)
{
foreach (clsFunction4CodeEN objFunction4CodeEN in lstFunction4CodeObjLst)
{
if (objFunction4CodeEN.FuncId4Code == strFuncId4Code)
{
return objFunction4CodeEN;
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
 string strMaxFuncId4Code;
 try
 {
 strMaxFuncId4Code = clsFunction4CodeDA.GetMaxStrId();
 return strMaxFuncId4Code;
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
 string strFuncId4Code;
 try
 {
 strFuncId4Code = new clsFunction4CodeDA().GetFirstID(strWhereCond);
 return strFuncId4Code;
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
 arrList = Function4CodeDA.GetID(strWhereCond);
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
bool bolIsExist = Function4CodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId4Code]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = Function4CodeDA.IsExist(strFuncId4Code);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncId4Code">函数Id4Code</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncId4Code, string strOpUser)
{
clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunction4CodeEN.UpdUser = strOpUser;
return clsFunction4CodeBL.UpdateBySql2(objFunction4CodeEN);
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
 bolIsExist = clsFunction4CodeDA.IsExistTable();
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
 bolIsExist = Function4CodeDA.IsExistTable(strTabName);
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunction4CodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名4Code = [{0}],类名 = [{1}],函数用途Id = [{2}],工程Id = [{3}],代码类型Id = [{4}]的数据已经存在!(in clsFunction4CodeBL.AddNewRecordBySql2)", objFunction4CodeEN.FuncName4Code,objFunction4CodeEN.ClsName,objFunction4CodeEN.FuncPurposeId,objFunction4CodeEN.PrjId,objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
bool bolResult = Function4CodeDA.AddNewRecordBySQL2(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunction4CodeEN objFunction4CodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunction4CodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名4Code = [{0}],类名 = [{1}],函数用途Id = [{2}],工程Id = [{3}],代码类型Id = [{4}]的数据已经存在!(in clsFunction4CodeBL.AddNewRecordBySql2WithReturnKey)", objFunction4CodeEN.FuncName4Code,objFunction4CodeEN.ClsName,objFunction4CodeEN.FuncPurposeId,objFunction4CodeEN.PrjId,objFunction4CodeEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true || clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code) == true)
 {
     objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
 }
string strKey = Function4CodeDA.AddNewRecordBySQL2WithReturnKey(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunction4CodeEN objFunction4CodeEN)
{
try
{
bool bolResult = Function4CodeDA.Update(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunction4CodeEN objFunction4CodeEN)
{
 if (string.IsNullOrEmpty(objFunction4CodeEN.FuncId4Code) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Function4CodeDA.UpdateBySql2(objFunction4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunction4CodeBL.ReFreshCache();

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
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
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncId4Code)
{
try
{
 clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);

if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(objFunction4CodeEN.FuncId4Code, objFunction4CodeEN.UpdUser);
}
if (objFunction4CodeEN != null)
{
int intRecNum = Function4CodeDA.DelRecord(strFuncId4Code);
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
/// <param name="strFuncId4Code">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncId4Code )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4CodeDA.GetSpecSQLObj();
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
//删除与表:[Function4Code]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunction4Code.FuncId4Code,
//strFuncId4Code);
//        clsFunction4CodeBL.DelFunction4CodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunction4CodeBL.DelRecord(strFuncId4Code, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunction4CodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId4Code, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncId4Code, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFunction4CodeBL.relatedActions != null)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(strFuncId4Code, "UpdRelaTabDate");
}
bool bolResult = Function4CodeDA.DelRecord(strFuncId4Code,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncId4CodeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFunction4Codes(List<string> arrFuncId4CodeLst)
{
if (arrFuncId4CodeLst.Count == 0) return 0;
try
{
if (clsFunction4CodeBL.relatedActions != null)
{
foreach (var strFuncId4Code in arrFuncId4CodeLst)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(strFuncId4Code, "UpdRelaTabDate");
}
}
int intDelRecNum = Function4CodeDA.DelFunction4Code(arrFuncId4CodeLst);
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
public static int DelFunction4CodesByCond(string strWhereCond)
{
try
{
if (clsFunction4CodeBL.relatedActions != null)
{
List<string> arrFuncId4Code = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncId4Code in arrFuncId4Code)
{
clsFunction4CodeBL.relatedActions.UpdRelaTabDate(strFuncId4Code, "UpdRelaTabDate");
}
}
int intRecNum = Function4CodeDA.DelFunction4Code(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Function4Code]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncId4Code">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncId4Code)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4CodeDA.GetSpecSQLObj();
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
//删除与表:[Function4Code]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunction4CodeBL.DelRecord(strFuncId4Code, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunction4CodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId4Code, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunction4CodeENS">源对象</param>
 /// <param name = "objFunction4CodeENT">目标对象</param>
 public static void CopyTo(clsFunction4CodeEN objFunction4CodeENS, clsFunction4CodeEN objFunction4CodeENT)
{
try
{
objFunction4CodeENT.FuncId4Code = objFunction4CodeENS.FuncId4Code; //函数Id4Code
objFunction4CodeENT.FuncName4Code = objFunction4CodeENS.FuncName4Code; //函数名4Code
objFunction4CodeENT.FuncCHName4Code = objFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objFunction4CodeENT.PrevFuncId = objFunction4CodeENS.PrevFuncId; //前函数Id
objFunction4CodeENT.RootFuncId = objFunction4CodeENS.RootFuncId; //根函数Id
objFunction4CodeENT.ApplicationTypeId = objFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objFunction4CodeENT.FuncGCTypeId = objFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4CodeENT.FunctionSignature = objFunction4CodeENS.FunctionSignature; //函数签名
objFunction4CodeENT.FunctionSignatureSim = objFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objFunction4CodeENT.ReturnType = objFunction4CodeENS.ReturnType; //返回类型
objFunction4CodeENT.ClsName = objFunction4CodeENS.ClsName; //类名
objFunction4CodeENT.ReturnTypeFullName = objFunction4CodeENS.ReturnTypeFullName; //返回类型全名
objFunction4CodeENT.ReturnTypeId = objFunction4CodeENS.ReturnTypeId; //返回类型ID
objFunction4CodeENT.ReturnTypeNameCustom = objFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objFunction4CodeENT.CodeTypeId = objFunction4CodeENS.CodeTypeId; //代码类型Id
objFunction4CodeENT.FuncAccessModeId = objFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objFunction4CodeENT.TabName = objFunction4CodeENS.TabName; //表名
objFunction4CodeENT.TabId = objFunction4CodeENS.TabId; //表ID
objFunction4CodeENT.FuncPurposeId = objFunction4CodeENS.FuncPurposeId; //函数用途Id
objFunction4CodeENT.FuncTypeId = objFunction4CodeENS.FuncTypeId; //函数类型Id
objFunction4CodeENT.GetCustomAttributes = objFunction4CodeENS.GetCustomAttributes; //GetCustomAttributes
objFunction4CodeENT.SourceFunction = objFunction4CodeENS.SourceFunction; //来源函数
objFunction4CodeENT.IsAsyncFunc = objFunction4CodeENS.IsAsyncFunc; //是否异步函数
objFunction4CodeENT.IsSysFunction = objFunction4CodeENS.IsSysFunction; //是否系统函数
objFunction4CodeENT.OrderNum = objFunction4CodeENS.OrderNum; //序号
objFunction4CodeENT.PrjId = objFunction4CodeENS.PrjId; //工程Id
objFunction4CodeENT.IsTemplate = objFunction4CodeENS.IsTemplate; //是否模板
objFunction4CodeENT.UpdDate = objFunction4CodeENS.UpdDate; //修改日期
objFunction4CodeENT.UpdUser = objFunction4CodeENS.UpdUser; //修改者
objFunction4CodeENT.Memo = objFunction4CodeENS.Memo; //说明
objFunction4CodeENT.UsedTimes = objFunction4CodeENS.UsedTimes; //使用次数
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
 /// <param name = "objFunction4CodeEN">源简化对象</param>
 public static void SetUpdFlag(clsFunction4CodeEN objFunction4CodeEN)
{
try
{
objFunction4CodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunction4CodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunction4Code.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncId4Code = objFunction4CodeEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(conFunction4Code.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncName4Code = objFunction4CodeEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(conFunction4Code.FuncCHName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncCHName4Code = objFunction4CodeEN.FuncCHName4Code == "[null]" ? null :  objFunction4CodeEN.FuncCHName4Code; //函数中文名4Code
}
if (arrFldSet.Contains(conFunction4Code.PrevFuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.PrevFuncId = objFunction4CodeEN.PrevFuncId == "[null]" ? null :  objFunction4CodeEN.PrevFuncId; //前函数Id
}
if (arrFldSet.Contains(conFunction4Code.RootFuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.RootFuncId = objFunction4CodeEN.RootFuncId; //根函数Id
}
if (arrFldSet.Contains(conFunction4Code.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ApplicationTypeId = objFunction4CodeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conFunction4Code.FuncGCTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncGCTypeId = objFunction4CodeEN.FuncGCTypeId == "[null]" ? null :  objFunction4CodeEN.FuncGCTypeId; //函数生成代码类型Id
}
if (arrFldSet.Contains(conFunction4Code.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FunctionSignature = objFunction4CodeEN.FunctionSignature == "[null]" ? null :  objFunction4CodeEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(conFunction4Code.FunctionSignatureSim, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim == "[null]" ? null :  objFunction4CodeEN.FunctionSignatureSim; //函数签名_Sim
}
if (arrFldSet.Contains(conFunction4Code.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ReturnType = objFunction4CodeEN.ReturnType == "[null]" ? null :  objFunction4CodeEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(conFunction4Code.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ClsName = objFunction4CodeEN.ClsName == "[null]" ? null :  objFunction4CodeEN.ClsName; //类名
}
if (arrFldSet.Contains(conFunction4Code.ReturnTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName == "[null]" ? null :  objFunction4CodeEN.ReturnTypeFullName; //返回类型全名
}
if (arrFldSet.Contains(conFunction4Code.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ReturnTypeId = objFunction4CodeEN.ReturnTypeId == "[null]" ? null :  objFunction4CodeEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(conFunction4Code.ReturnTypeNameCustom, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.ReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom == "[null]" ? null :  objFunction4CodeEN.ReturnTypeNameCustom; //定制返回类型名
}
if (arrFldSet.Contains(conFunction4Code.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.CodeTypeId = objFunction4CodeEN.CodeTypeId == "[null]" ? null :  objFunction4CodeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conFunction4Code.FuncAccessModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncAccessModeId = objFunction4CodeEN.FuncAccessModeId == "[null]" ? null :  objFunction4CodeEN.FuncAccessModeId; //函数操作模式Id
}
if (arrFldSet.Contains(conFunction4Code.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.TabName = objFunction4CodeEN.TabName == "[null]" ? null :  objFunction4CodeEN.TabName; //表名
}
if (arrFldSet.Contains(conFunction4Code.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.TabId = objFunction4CodeEN.TabId == "[null]" ? null :  objFunction4CodeEN.TabId; //表ID
}
if (arrFldSet.Contains(conFunction4Code.FuncPurposeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncPurposeId = objFunction4CodeEN.FuncPurposeId; //函数用途Id
}
if (arrFldSet.Contains(conFunction4Code.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.FuncTypeId = objFunction4CodeEN.FuncTypeId == "[null]" ? null :  objFunction4CodeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conFunction4Code.GetCustomAttributes, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.GetCustomAttributes = objFunction4CodeEN.GetCustomAttributes; //GetCustomAttributes
}
if (arrFldSet.Contains(conFunction4Code.SourceFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.SourceFunction = objFunction4CodeEN.SourceFunction == "[null]" ? null :  objFunction4CodeEN.SourceFunction; //来源函数
}
if (arrFldSet.Contains(conFunction4Code.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.IsAsyncFunc = objFunction4CodeEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(conFunction4Code.IsSysFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.IsSysFunction = objFunction4CodeEN.IsSysFunction; //是否系统函数
}
if (arrFldSet.Contains(conFunction4Code.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.OrderNum = objFunction4CodeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFunction4Code.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.PrjId = objFunction4CodeEN.PrjId == "[null]" ? null :  objFunction4CodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFunction4Code.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.IsTemplate = objFunction4CodeEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conFunction4Code.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.UpdDate = objFunction4CodeEN.UpdDate == "[null]" ? null :  objFunction4CodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunction4Code.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.UpdUser = objFunction4CodeEN.UpdUser == "[null]" ? null :  objFunction4CodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFunction4Code.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.Memo = objFunction4CodeEN.Memo == "[null]" ? null :  objFunction4CodeEN.Memo; //说明
}
if (arrFldSet.Contains(conFunction4Code.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objFunction4CodeEN.UsedTimes = objFunction4CodeEN.UsedTimes; //使用次数
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
 /// <param name = "objFunction4CodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunction4CodeEN objFunction4CodeEN)
{
try
{
if (objFunction4CodeEN.FuncCHName4Code == "[null]") objFunction4CodeEN.FuncCHName4Code = null; //函数中文名4Code
if (objFunction4CodeEN.PrevFuncId == "[null]") objFunction4CodeEN.PrevFuncId = null; //前函数Id
if (objFunction4CodeEN.FuncGCTypeId == "[null]") objFunction4CodeEN.FuncGCTypeId = null; //函数生成代码类型Id
if (objFunction4CodeEN.FunctionSignature == "[null]") objFunction4CodeEN.FunctionSignature = null; //函数签名
if (objFunction4CodeEN.FunctionSignatureSim == "[null]") objFunction4CodeEN.FunctionSignatureSim = null; //函数签名_Sim
if (objFunction4CodeEN.ReturnType == "[null]") objFunction4CodeEN.ReturnType = null; //返回类型
if (objFunction4CodeEN.ClsName == "[null]") objFunction4CodeEN.ClsName = null; //类名
if (objFunction4CodeEN.ReturnTypeFullName == "[null]") objFunction4CodeEN.ReturnTypeFullName = null; //返回类型全名
if (objFunction4CodeEN.ReturnTypeId == "[null]") objFunction4CodeEN.ReturnTypeId = null; //返回类型ID
if (objFunction4CodeEN.ReturnTypeNameCustom == "[null]") objFunction4CodeEN.ReturnTypeNameCustom = null; //定制返回类型名
if (objFunction4CodeEN.CodeTypeId == "[null]") objFunction4CodeEN.CodeTypeId = null; //代码类型Id
if (objFunction4CodeEN.FuncAccessModeId == "[null]") objFunction4CodeEN.FuncAccessModeId = null; //函数操作模式Id
if (objFunction4CodeEN.TabName == "[null]") objFunction4CodeEN.TabName = null; //表名
if (objFunction4CodeEN.TabId == "[null]") objFunction4CodeEN.TabId = null; //表ID
if (objFunction4CodeEN.FuncTypeId == "[null]") objFunction4CodeEN.FuncTypeId = null; //函数类型Id
if (objFunction4CodeEN.SourceFunction == "[null]") objFunction4CodeEN.SourceFunction = null; //来源函数
if (objFunction4CodeEN.PrjId == "[null]") objFunction4CodeEN.PrjId = null; //工程Id
if (objFunction4CodeEN.UpdDate == "[null]") objFunction4CodeEN.UpdDate = null; //修改日期
if (objFunction4CodeEN.UpdUser == "[null]") objFunction4CodeEN.UpdUser = null; //修改者
if (objFunction4CodeEN.Memo == "[null]") objFunction4CodeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFunction4CodeEN objFunction4CodeEN)
{
 Function4CodeDA.CheckPropertyNew(objFunction4CodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunction4CodeEN objFunction4CodeEN)
{
 Function4CodeDA.CheckProperty4Condition(objFunction4CodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncId4CodeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数4Code]...","0");
List<clsFunction4CodeEN> arrFunction4CodeObjLst = GetAllFunction4CodeObjLstCache(); 
objDDL.DataValueField = conFunction4Code.FuncId4Code;
objDDL.DataTextField = conFunction4Code.FuncName4Code;
objDDL.DataSource = arrFunction4CodeObjLst;
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
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId4Code");
//if (arrFunction4CodeObjLstCache == null)
//{
//arrFunction4CodeObjLstCache = Function4CodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunction4CodeEN GetObjByFuncId4CodeCache(string strFuncId4Code)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrFunction4CodeObjLst_Sel =
arrFunction4CodeObjLstCache
.Where(x=> x.FuncId4Code == strFuncId4Code 
);
if (arrFunction4CodeObjLst_Sel.Count() == 0)
{
   clsFunction4CodeEN obj = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunction4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncName4CodeByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return "";
//获取缓存中的对象列表
clsFunction4CodeEN objFunction4Code = GetObjByFuncId4CodeCache(strFuncId4Code);
if (objFunction4Code == null) return "";
return objFunction4Code.FuncName4Code;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return "";
//获取缓存中的对象列表
clsFunction4CodeEN objFunction4Code = GetObjByFuncId4CodeCache(strFuncId4Code);
if (objFunction4Code == null) return "";
return objFunction4Code.FuncName4Code;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunction4CodeEN> GetAllFunction4CodeObjLstCache()
{
//获取缓存中的对象列表
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = GetObjLstCache(); 
return arrFunction4CodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunction4CodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
List<clsFunction4CodeEN> arrFunction4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunction4CodeObjLstCache;
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
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunction4CodeEN._RefreshTimeLst.Count == 0) return "";
return clsFunction4CodeEN._RefreshTimeLst[clsFunction4CodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFunction4CodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunction4CodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunction4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunction4CodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Function4Code(函数4Code)
 /// 唯一性条件:FuncName4Code_ClsName_FuncPurposeId_PrjId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunction4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunction4CodeEN objFunction4CodeEN)
{
//检测记录是否存在
string strResult = Function4CodeDA.GetUniCondStr(objFunction4CodeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncId4Code)
{
if (strInFldName != conFunction4Code.FuncId4Code)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunction4Code._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunction4Code._AttributeName));
throw new Exception(strMsg);
}
var objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
if (objFunction4Code == null) return "";
return objFunction4Code[strOutFldName].ToString();
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
int intRecCount = clsFunction4CodeDA.GetRecCount(strTabName);
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
int intRecCount = clsFunction4CodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunction4CodeDA.GetRecCount();
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
int intRecCount = clsFunction4CodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunction4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunction4CodeEN objFunction4CodeCond)
{
List<clsFunction4CodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunction4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunction4Code._AttributeName)
{
if (objFunction4CodeCond.IsUpdated(strFldName) == false) continue;
if (objFunction4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4CodeCond[strFldName].ToString());
}
else
{
if (objFunction4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunction4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunction4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunction4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunction4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunction4CodeCond[strFldName]));
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
 List<string> arrList = clsFunction4CodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Function4CodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Function4CodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Function4CodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunction4CodeDA.SetFldValue(clsFunction4CodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Function4CodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunction4CodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunction4CodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunction4CodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Function4Code] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数Id4Code*/ 
 strCreateTabCode.Append(" FuncId4Code char(8) primary key, "); 
 // /**函数名4Code*/ 
 strCreateTabCode.Append(" FuncName4Code varchar(100) not Null, "); 
 // /**函数中文名4Code*/ 
 strCreateTabCode.Append(" FuncCHName4Code varchar(200) Null, "); 
 // /**前函数Id*/ 
 strCreateTabCode.Append(" PrevFuncId char(8) Null, "); 
 // /**根函数Id*/ 
 strCreateTabCode.Append(" RootFuncId char(8) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**函数生成代码类型Id*/ 
 strCreateTabCode.Append(" FuncGCTypeId char(2) Null, "); 
 // /**函数签名*/ 
 strCreateTabCode.Append(" FunctionSignature varchar(500) Null, "); 
 // /**函数签名_Sim*/ 
 strCreateTabCode.Append(" FunctionSignatureSim varchar(500) Null, "); 
 // /**返回类型*/ 
 strCreateTabCode.Append(" ReturnType varchar(500) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) Null, "); 
 // /**返回类型全名*/ 
 strCreateTabCode.Append(" ReturnTypeFullName varchar(500) Null, "); 
 // /**返回类型ID*/ 
 strCreateTabCode.Append(" ReturnTypeId char(2) Null, "); 
 // /**定制返回类型名*/ 
 strCreateTabCode.Append(" ReturnTypeNameCustom varchar(50) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) Null, "); 
 // /**函数操作模式Id*/ 
 strCreateTabCode.Append(" FuncAccessModeId char(2) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**函数用途Id*/ 
 strCreateTabCode.Append(" FuncPurposeId char(2) not Null, "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) Null, "); 
 // /**GetCustomAttributes*/ 
 strCreateTabCode.Append(" GetCustomAttributes int not Null, "); 
 // /**来源函数*/ 
 strCreateTabCode.Append(" SourceFunction varchar(500) Null, "); 
 // /**是否异步函数*/ 
 strCreateTabCode.Append(" IsAsyncFunc bit Null, "); 
 // /**是否系统函数*/ 
 strCreateTabCode.Append(" IsSysFunction bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**函数类型名*/ 
 strCreateTabCode.Append(" FuncTypeName varchar(20) Null, "); 
 // /**函数操作模式名*/ 
 strCreateTabCode.Append(" FuncAccessModeName varchar(50) Null, "); 
 // /**函数用途名*/ 
 strCreateTabCode.Append(" FuncPurposeName varchar(20) Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**函数4GC数*/ 
 strCreateTabCode.Append(" Func4GCCount int Null, "); 
 // /**功能数*/ 
 strCreateTabCode.Append(" FeatureCount int Null, "); 
 // /**参数个数*/ 
 strCreateTabCode.Append(" ParaNum int Null, "); 
 // /**使用次数*/ 
 strCreateTabCode.Append(" UsedTimes int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数4Code(Function4Code)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Function4Code : clsCommFun4BL
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
clsFunction4CodeBL.ReFreshThisCache();
}
}

}