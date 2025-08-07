
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTypeBL
 表名:FunctionType(00050063)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:26
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
public static class  clsFunctionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTypeEN GetObj(this K_FuncTypeId_FunctionType myKey)
{
clsFunctionTypeEN objFunctionTypeEN = clsFunctionTypeBL.FunctionTypeDA.GetObjByFuncTypeId(myKey.Value);
return objFunctionTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数类型名 = [{0}]的数据已经存在!(in clsFunctionTypeBL.AddNewRecord)", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsFunctionTypeBL.FunctionTypeDA.AddNewRecordBySQL2(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFunctionTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunctionTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数类型名(FuncTypeName)=[{0}])已经存在,不能重复!", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFunctionTypeEN.AddNewRecord();
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数类型名 = [{0}]的数据已经存在!(in clsFunctionTypeBL.AddNewRecordWithMaxId)", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
string strFuncTypeId = clsFunctionTypeBL.FunctionTypeDA.AddNewRecordBySQL2WithReturnKey(objFunctionTypeEN);
     objFunctionTypeEN.FuncTypeId = strFuncTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
}
return strFuncTypeId;
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数类型名 = [{0}]的数据已经存在!(in clsFunctionTypeBL.AddNewRecordWithReturnKey)", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
string strKey = clsFunctionTypeBL.FunctionTypeDA.AddNewRecordBySQL2WithReturnKey(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeId(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunctionType.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunctionType.FuncTypeId);
}
objFunctionTypeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeId) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeId, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeId] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeName(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, conFunctionType.FuncTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, conFunctionType.FuncTypeName);
}
objFunctionTypeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeName) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeName, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeName] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeENName(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeENName, 50, conFunctionType.FuncTypeENName);
}
objFunctionTypeEN.FuncTypeENName = strFuncTypeENName; //函数类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeENName) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeENName, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeENName] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetCodeTypeId(this clsFunctionTypeEN objFunctionTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conFunctionType.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conFunctionType.CodeTypeId);
}
objFunctionTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.CodeTypeId) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.CodeTypeId, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.CodeTypeId] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetMemo(this clsFunctionTypeEN objFunctionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionType.Memo);
}
objFunctionTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.Memo) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.Memo, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.Memo] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunctionTypeEN objFunctionTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunctionTypeEN.CheckPropertyNew();
clsFunctionTypeEN objFunctionTypeCond = new clsFunctionTypeEN();
string strCondition = objFunctionTypeCond
.SetFuncTypeId(objFunctionTypeEN.FuncTypeId, "<>")
.SetFuncTypeName(objFunctionTypeEN.FuncTypeName, "=")
.GetCombineCondition();
objFunctionTypeEN._IsCheckProperty = true;
bool bolIsExist = clsFunctionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunctionTypeEN.Update();
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
 /// <param name = "objFunctionType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunctionTypeEN objFunctionType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunctionTypeEN objFunctionTypeCond = new clsFunctionTypeEN();
string strCondition = objFunctionTypeCond
.SetFuncTypeName(objFunctionType.FuncTypeName, "=")
.GetCombineCondition();
objFunctionType._IsCheckProperty = true;
bool bolIsExist = clsFunctionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunctionType.FuncTypeId = clsFunctionTypeBL.GetFirstID_S(strCondition);
objFunctionType.UpdateWithCondition(strCondition);
}
else
{
objFunctionType.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
objFunctionType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTypeEN objFunctionTypeEN)
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionTypeBL.FunctionTypeDA.UpdateBySql2(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTypeEN objFunctionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionTypeBL.FunctionTypeDA.UpdateBySql2(objFunctionTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTypeEN objFunctionTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionTypeBL.FunctionTypeDA.UpdateBySqlWithCondition(objFunctionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTypeEN objFunctionTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionTypeBL.FunctionTypeDA.UpdateBySqlWithConditionTransaction(objFunctionTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFunctionTypeEN objFunctionTypeEN)
{
try
{
int intRecNum = clsFunctionTypeBL.FunctionTypeDA.DelRecord(objFunctionTypeEN.FuncTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeENS">源对象</param>
 /// <param name = "objFunctionTypeENT">目标对象</param>
 public static void CopyTo(this clsFunctionTypeEN objFunctionTypeENS, clsFunctionTypeEN objFunctionTypeENT)
{
try
{
objFunctionTypeENT.FuncTypeId = objFunctionTypeENS.FuncTypeId; //函数类型Id
objFunctionTypeENT.FuncTypeName = objFunctionTypeENS.FuncTypeName; //函数类型名
objFunctionTypeENT.FuncTypeENName = objFunctionTypeENS.FuncTypeENName; //函数类型英文名
objFunctionTypeENT.CodeTypeId = objFunctionTypeENS.CodeTypeId; //代码类型Id
objFunctionTypeENT.Memo = objFunctionTypeENS.Memo; //说明
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
 /// <param name = "objFunctionTypeENS">源对象</param>
 /// <returns>目标对象=>clsFunctionTypeEN:objFunctionTypeENT</returns>
 public static clsFunctionTypeEN CopyTo(this clsFunctionTypeEN objFunctionTypeENS)
{
try
{
 clsFunctionTypeEN objFunctionTypeENT = new clsFunctionTypeEN()
{
FuncTypeId = objFunctionTypeENS.FuncTypeId, //函数类型Id
FuncTypeName = objFunctionTypeENS.FuncTypeName, //函数类型名
FuncTypeENName = objFunctionTypeENS.FuncTypeENName, //函数类型英文名
CodeTypeId = objFunctionTypeENS.CodeTypeId, //代码类型Id
Memo = objFunctionTypeENS.Memo, //说明
};
 return objFunctionTypeENT;
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
public static void CheckPropertyNew(this clsFunctionTypeEN objFunctionTypeEN)
{
 clsFunctionTypeBL.FunctionTypeDA.CheckPropertyNew(objFunctionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionTypeEN objFunctionTypeEN)
{
 clsFunctionTypeBL.FunctionTypeDA.CheckProperty4Condition(objFunctionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionTypeEN objFunctionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeId, objFunctionTypeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeName, objFunctionTypeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeENName) == true)
{
string strComparisonOpFuncTypeENName = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeENName, objFunctionTypeCond.FuncTypeENName, strComparisonOpFuncTypeENName);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.CodeTypeId, objFunctionTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.Memo) == true)
{
string strComparisonOpMemo = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.Memo, objFunctionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FunctionType(函数类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunctionTypeEN objFunctionTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTypeEN == null) return true;
if (objFunctionTypeEN.FuncTypeId == null || objFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
if (clsFunctionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
if (clsFunctionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FunctionType(函数类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunctionTypeEN objFunctionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTypeEN == null) return "";
if (objFunctionTypeEN.FuncTypeId == null || objFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionType
{
public virtual bool UpdRelaTabDate(string strFuncTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumFunctionType
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 工程私有函数
 /// </summary>
public const string EngineeringPrivateFunctions_06 = "06";
 /// <summary>
 /// 公共函数
 /// </summary>
public const string PublicFunction_07 = "07";
 /// <summary>
 /// 模板函数
 /// </summary>
public const string TemplateFunction_08 = "08";
 /// <summary>
 /// 系统函数
 /// </summary>
public const string SystemFunction_09 = "09";
 /// <summary>
 /// 用户定义函数
 /// </summary>
public const string UserDefinedFunctions_10 = "10";
 /// <summary>
 /// 界面后台函数
 /// </summary>
public const string ViewBackgroundFunction_11 = "11";
 /// <summary>
 /// 纯静态函数
 /// </summary>
public const string PureStaticFunction_12 = "12";
 /// <summary>
 /// 扩展生成函数
 /// </summary>
public const string ExGCFunc_13 = "13";
 /// <summary>
 /// 泛型函数
 /// </summary>
public const string GenericFunctions_14 = "14";
 /// <summary>
 /// 类静态函数
 /// </summary>
public const string ClassStaticFunction_15 = "15";
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionTypeBL
{
public static RelatedActions_FunctionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionTypeDA FunctionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionTypeDA();
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
 public clsFunctionTypeBL()
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
if (string.IsNullOrEmpty(clsFunctionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionTypeEN._ConnectString);
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
public static DataTable GetDataTable_FunctionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionTypeDA.GetDataTable_FunctionType(strWhereCond);
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
objDT = FunctionTypeDA.GetDataTable(strWhereCond);
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
objDT = FunctionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstByFuncTypeIdLst(List<string> arrFuncTypeIdLst)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncTypeIdLst, true);
 string strWhereCond = string.Format("FuncTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionTypeEN> GetObjLstByFuncTypeIdLstCache(List<string> arrFuncTypeIdLst)
{
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel =
arrFunctionTypeObjLstCache
.Where(x => arrFuncTypeIdLst.Contains(x.FuncTypeId));
return arrFunctionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLst(string strWhereCond)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
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
public static List<clsFunctionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionTypeEN> GetSubObjLstCache(clsFunctionTypeEN objFunctionTypeCond)
{
List<clsFunctionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionType._AttributeName)
{
if (objFunctionTypeCond.IsUpdated(strFldName) == false) continue;
if (objFunctionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTypeCond[strFldName].ToString());
}
else
{
if (objFunctionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionTypeCond[strFldName]));
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
public static List<clsFunctionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
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
public static List<clsFunctionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
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
List<clsFunctionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
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
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
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
public static List<clsFunctionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
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
public static List<clsFunctionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionTypeEN> arrObjLst = new List<clsFunctionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN();
try
{
objFunctionTypeEN.FuncTypeId = objRow[conFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objFunctionTypeEN.FuncTypeName = objRow[conFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objFunctionTypeEN.FuncTypeENName = objRow[conFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[conFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objFunctionTypeEN.CodeTypeId = objRow[conFunctionType.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTypeEN.Memo = objRow[conFunctionType.Memo] == DBNull.Value ? null : objRow[conFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionType(ref clsFunctionTypeEN objFunctionTypeEN)
{
bool bolResult = FunctionTypeDA.GetFunctionType(ref objFunctionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTypeEN GetObjByFuncTypeId(string strFuncTypeId)
{
if (strFuncTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFunctionTypeEN objFunctionTypeEN = FunctionTypeDA.GetObjByFuncTypeId(strFuncTypeId);
return objFunctionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionTypeEN objFunctionTypeEN = FunctionTypeDA.GetFirstObj(strWhereCond);
 return objFunctionTypeEN;
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
public static clsFunctionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionTypeEN objFunctionTypeEN = FunctionTypeDA.GetObjByDataRow(objRow);
 return objFunctionTypeEN;
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
public static clsFunctionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionTypeEN objFunctionTypeEN = FunctionTypeDA.GetObjByDataRow(objRow);
 return objFunctionTypeEN;
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
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <param name = "lstFunctionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTypeEN GetObjByFuncTypeIdFromList(string strFuncTypeId, List<clsFunctionTypeEN> lstFunctionTypeObjLst)
{
foreach (clsFunctionTypeEN objFunctionTypeEN in lstFunctionTypeObjLst)
{
if (objFunctionTypeEN.FuncTypeId == strFuncTypeId)
{
return objFunctionTypeEN;
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
 string strMaxFuncTypeId;
 try
 {
 strMaxFuncTypeId = clsFunctionTypeDA.GetMaxStrId();
 return strMaxFuncTypeId;
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
 string strFuncTypeId;
 try
 {
 strFuncTypeId = new clsFunctionTypeDA().GetFirstID(strWhereCond);
 return strFuncTypeId;
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
 arrList = FunctionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FunctionTypeDA.IsExist(strFuncTypeId);
return bolIsExist;
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
 bolIsExist = clsFunctionTypeDA.IsExistTable();
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
 bolIsExist = FunctionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数类型名 = [{0}]的数据已经存在!(in clsFunctionTypeBL.AddNewRecordBySql2)", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
bool bolResult = FunctionTypeDA.AddNewRecordBySQL2(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionTypeEN objFunctionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数类型名 = [{0}]的数据已经存在!(in clsFunctionTypeBL.AddNewRecordBySql2WithReturnKey)", objFunctionTypeEN.FuncTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeBL.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeBL.GetMaxStrId_S();
 }
string strKey = FunctionTypeDA.AddNewRecordBySQL2WithReturnKey(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionTypeEN objFunctionTypeEN)
{
try
{
bool bolResult = FunctionTypeDA.Update(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionTypeEN objFunctionTypeEN)
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionTypeDA.UpdateBySql2(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeBL.ReFreshCache();

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
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
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncTypeId)
{
try
{
 clsFunctionTypeEN objFunctionTypeEN = clsFunctionTypeBL.GetObjByFuncTypeId(strFuncTypeId);

if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(objFunctionTypeEN.FuncTypeId, "SetUpdDate");
}
if (objFunctionTypeEN != null)
{
int intRecNum = FunctionTypeDA.DelRecord(strFuncTypeId);
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
/// <param name="strFuncTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
//删除与表:[FunctionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionType.FuncTypeId,
//strFuncTypeId);
//        clsFunctionTypeBL.DelFunctionTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionTypeBL.DelRecord(strFuncTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFunctionTypeBL.relatedActions != null)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(strFuncTypeId, "UpdRelaTabDate");
}
bool bolResult = FunctionTypeDA.DelRecord(strFuncTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFunctionTypes(List<string> arrFuncTypeIdLst)
{
if (arrFuncTypeIdLst.Count == 0) return 0;
try
{
if (clsFunctionTypeBL.relatedActions != null)
{
foreach (var strFuncTypeId in arrFuncTypeIdLst)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(strFuncTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionTypeDA.DelFunctionType(arrFuncTypeIdLst);
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
public static int DelFunctionTypesByCond(string strWhereCond)
{
try
{
if (clsFunctionTypeBL.relatedActions != null)
{
List<string> arrFuncTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncTypeId in arrFuncTypeId)
{
clsFunctionTypeBL.relatedActions.UpdRelaTabDate(strFuncTypeId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionTypeDA.DelFunctionType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionTypeDA.GetSpecSQLObj();
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
//删除与表:[FunctionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionTypeBL.DelRecord(strFuncTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunctionTypeENS">源对象</param>
 /// <param name = "objFunctionTypeENT">目标对象</param>
 public static void CopyTo(clsFunctionTypeEN objFunctionTypeENS, clsFunctionTypeEN objFunctionTypeENT)
{
try
{
objFunctionTypeENT.FuncTypeId = objFunctionTypeENS.FuncTypeId; //函数类型Id
objFunctionTypeENT.FuncTypeName = objFunctionTypeENS.FuncTypeName; //函数类型名
objFunctionTypeENT.FuncTypeENName = objFunctionTypeENS.FuncTypeENName; //函数类型英文名
objFunctionTypeENT.CodeTypeId = objFunctionTypeENS.CodeTypeId; //代码类型Id
objFunctionTypeENT.Memo = objFunctionTypeENS.Memo; //说明
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
 /// <param name = "objFunctionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionTypeEN objFunctionTypeEN)
{
try
{
objFunctionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionType.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTypeEN.FuncTypeId = objFunctionTypeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conFunctionType.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTypeEN.FuncTypeName = objFunctionTypeEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(conFunctionType.FuncTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTypeEN.FuncTypeENName = objFunctionTypeEN.FuncTypeENName == "[null]" ? null :  objFunctionTypeEN.FuncTypeENName; //函数类型英文名
}
if (arrFldSet.Contains(conFunctionType.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTypeEN.CodeTypeId = objFunctionTypeEN.CodeTypeId == "[null]" ? null :  objFunctionTypeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conFunctionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTypeEN.Memo = objFunctionTypeEN.Memo == "[null]" ? null :  objFunctionTypeEN.Memo; //说明
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
 /// <param name = "objFunctionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionTypeEN objFunctionTypeEN)
{
try
{
if (objFunctionTypeEN.FuncTypeENName == "[null]") objFunctionTypeEN.FuncTypeENName = null; //函数类型英文名
if (objFunctionTypeEN.CodeTypeId == "[null]") objFunctionTypeEN.CodeTypeId = null; //代码类型Id
if (objFunctionTypeEN.Memo == "[null]") objFunctionTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFunctionTypeEN objFunctionTypeEN)
{
 FunctionTypeDA.CheckPropertyNew(objFunctionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionTypeEN objFunctionTypeEN)
{
 FunctionTypeDA.CheckProperty4Condition(objFunctionTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionType.FuncTypeId); 
List<clsFunctionTypeEN> arrObjLst = clsFunctionTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN()
{
FuncTypeId = "0",
FuncTypeName = "选[函数类型]..."
};
arrObjLst.Insert(0, objFunctionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionType.FuncTypeId;
objComboBox.DisplayMember = conFunctionType.FuncTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFunctionType.FuncTypeId); 
IEnumerable<clsFunctionTypeEN> arrObjLst = clsFunctionTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conFunctionType.FuncTypeId;
objDDL.DataTextField = conFunctionType.FuncTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数类型]...","0");
List<clsFunctionTypeEN> arrFunctionTypeObjLst = GetAllFunctionTypeObjLstCache(); 
objDDL.DataValueField = conFunctionType.FuncTypeId;
objDDL.DataTextField = conFunctionType.FuncTypeName;
objDDL.DataSource = arrFunctionTypeObjLst;
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
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncTypeId");
//if (arrFunctionTypeObjLstCache == null)
//{
//arrFunctionTypeObjLstCache = FunctionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTypeEN GetObjByFuncTypeIdCache(string strFuncTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel =
arrFunctionTypeObjLstCache
.Where(x=> x.FuncTypeId == strFuncTypeId 
);
if (arrFunctionTypeObjLst_Sel.Count() == 0)
{
   clsFunctionTypeEN obj = clsFunctionTypeBL.GetObjByFuncTypeId(strFuncTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncTypeNameByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return "";
//获取缓存中的对象列表
clsFunctionTypeEN objFunctionType = GetObjByFuncTypeIdCache(strFuncTypeId);
if (objFunctionType == null) return "";
return objFunctionType.FuncTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return "";
//获取缓存中的对象列表
clsFunctionTypeEN objFunctionType = GetObjByFuncTypeIdCache(strFuncTypeId);
if (objFunctionType == null) return "";
return objFunctionType.FuncTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTypeEN> GetAllFunctionTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache(); 
return arrFunctionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionTypeObjLstCache;
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
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunctionTypeEN._RefreshTimeLst.Count == 0) return "";
return clsFunctionTypeEN._RefreshTimeLst[clsFunctionTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFunctionTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunctionTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FunctionType(函数类型)
 /// 唯一性条件:FuncTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunctionTypeEN objFunctionTypeEN)
{
//检测记录是否存在
string strResult = FunctionTypeDA.GetUniCondStr(objFunctionTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncTypeId)
{
if (strInFldName != conFunctionType.FuncTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionType._AttributeName));
throw new Exception(strMsg);
}
var objFunctionType = clsFunctionTypeBL.GetObjByFuncTypeIdCache(strFuncTypeId);
if (objFunctionType == null) return "";
return objFunctionType[strOutFldName].ToString();
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
int intRecCount = clsFunctionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionTypeDA.GetRecCount();
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
int intRecCount = clsFunctionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionTypeEN objFunctionTypeCond)
{
List<clsFunctionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionType._AttributeName)
{
if (objFunctionTypeCond.IsUpdated(strFldName) == false) continue;
if (objFunctionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTypeCond[strFldName].ToString());
}
else
{
if (objFunctionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionTypeCond[strFldName]));
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
 List<string> arrList = clsFunctionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionTypeDA.SetFldValue(clsFunctionTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) primary key, "); 
 // /**函数类型名*/ 
 strCreateTabCode.Append(" FuncTypeName varchar(20) not Null, "); 
 // /**函数类型英文名*/ 
 strCreateTabCode.Append(" FuncTypeENName varchar(50) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionType : clsCommFun4BL
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
clsFunctionTypeBL.ReFreshThisCache();
}
}

}