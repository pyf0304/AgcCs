
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFldOperationTypeBL
 表名:FldOperationType(00050278)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:03
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
public static class  clsFldOperationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldOpTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFldOperationTypeEN GetObj(this K_FldOpTypeId_FldOperationType myKey)
{
clsFldOperationTypeEN objFldOperationTypeEN = clsFldOperationTypeBL.FldOperationTypeDA.GetObjByFldOpTypeId(myKey.Value);
return objFldOperationTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFldOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!字段操作类型名称 = [{0}]的数据已经存在!(in clsFldOperationTypeBL.AddNewRecord)", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsFldOperationTypeBL.FldOperationTypeDA.AddNewRecordBySQL2(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFldOperationTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFldOperationTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字段操作类型名称(FldOpTypeName)=[{0}])已经存在,不能重复!", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFldOperationTypeEN.AddNewRecord();
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFldOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!字段操作类型名称 = [{0}]的数据已经存在!(in clsFldOperationTypeBL.AddNewRecordWithMaxId)", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
string strFldOpTypeId = clsFldOperationTypeBL.FldOperationTypeDA.AddNewRecordBySQL2WithReturnKey(objFldOperationTypeEN);
     objFldOperationTypeEN.FldOpTypeId = strFldOpTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
}
return strFldOpTypeId;
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFldOperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!字段操作类型名称 = [{0}]的数据已经存在!(in clsFldOperationTypeBL.AddNewRecordWithReturnKey)", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
string strKey = clsFldOperationTypeBL.FldOperationTypeDA.AddNewRecordBySQL2WithReturnKey(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFldOperationTypeEN SetFldOpTypeId(this clsFldOperationTypeEN objFldOperationTypeEN, string strFldOpTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeId, 4, conFldOperationType.FldOpTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldOpTypeId, 4, conFldOperationType.FldOpTypeId);
}
objFldOperationTypeEN.FldOpTypeId = strFldOpTypeId; //字段操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFldOperationTypeEN.dicFldComparisonOp.ContainsKey(conFldOperationType.FldOpTypeId) == false)
{
objFldOperationTypeEN.dicFldComparisonOp.Add(conFldOperationType.FldOpTypeId, strComparisonOp);
}
else
{
objFldOperationTypeEN.dicFldComparisonOp[conFldOperationType.FldOpTypeId] = strComparisonOp;
}
}
return objFldOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFldOperationTypeEN SetFldOpTypeName(this clsFldOperationTypeEN objFldOperationTypeEN, string strFldOpTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeName, conFldOperationType.FldOpTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeName, 100, conFldOperationType.FldOpTypeName);
}
objFldOperationTypeEN.FldOpTypeName = strFldOpTypeName; //字段操作类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFldOperationTypeEN.dicFldComparisonOp.ContainsKey(conFldOperationType.FldOpTypeName) == false)
{
objFldOperationTypeEN.dicFldComparisonOp.Add(conFldOperationType.FldOpTypeName, strComparisonOp);
}
else
{
objFldOperationTypeEN.dicFldComparisonOp[conFldOperationType.FldOpTypeName] = strComparisonOp;
}
}
return objFldOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFldOperationTypeEN SetFldOpTypeENName(this clsFldOperationTypeEN objFldOperationTypeEN, string strFldOpTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeENName, conFldOperationType.FldOpTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeENName, 100, conFldOperationType.FldOpTypeENName);
}
objFldOperationTypeEN.FldOpTypeENName = strFldOpTypeENName; //字段操作类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFldOperationTypeEN.dicFldComparisonOp.ContainsKey(conFldOperationType.FldOpTypeENName) == false)
{
objFldOperationTypeEN.dicFldComparisonOp.Add(conFldOperationType.FldOpTypeENName, strComparisonOp);
}
else
{
objFldOperationTypeEN.dicFldComparisonOp[conFldOperationType.FldOpTypeENName] = strComparisonOp;
}
}
return objFldOperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFldOperationTypeEN SetMemo(this clsFldOperationTypeEN objFldOperationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFldOperationType.Memo);
}
objFldOperationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFldOperationTypeEN.dicFldComparisonOp.ContainsKey(conFldOperationType.Memo) == false)
{
objFldOperationTypeEN.dicFldComparisonOp.Add(conFldOperationType.Memo, strComparisonOp);
}
else
{
objFldOperationTypeEN.dicFldComparisonOp[conFldOperationType.Memo] = strComparisonOp;
}
}
return objFldOperationTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFldOperationTypeEN objFldOperationTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFldOperationTypeEN.CheckPropertyNew();
clsFldOperationTypeEN objFldOperationTypeCond = new clsFldOperationTypeEN();
string strCondition = objFldOperationTypeCond
.SetFldOpTypeId(objFldOperationTypeEN.FldOpTypeId, "<>")
.SetFldOpTypeName(objFldOperationTypeEN.FldOpTypeName, "=")
.GetCombineCondition();
objFldOperationTypeEN._IsCheckProperty = true;
bool bolIsExist = clsFldOperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FldOpTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFldOperationTypeEN.Update();
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
 /// <param name = "objFldOperationType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFldOperationTypeEN objFldOperationType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFldOperationTypeEN objFldOperationTypeCond = new clsFldOperationTypeEN();
string strCondition = objFldOperationTypeCond
.SetFldOpTypeName(objFldOperationType.FldOpTypeName, "=")
.GetCombineCondition();
objFldOperationType._IsCheckProperty = true;
bool bolIsExist = clsFldOperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFldOperationType.FldOpTypeId = clsFldOperationTypeBL.GetFirstID_S(strCondition);
objFldOperationType.UpdateWithCondition(strCondition);
}
else
{
objFldOperationType.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
objFldOperationType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFldOperationTypeEN objFldOperationTypeEN)
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFldOperationTypeBL.FldOperationTypeDA.UpdateBySql2(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFldOperationTypeEN objFldOperationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFldOperationTypeBL.FldOperationTypeDA.UpdateBySql2(objFldOperationTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFldOperationTypeEN objFldOperationTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsFldOperationTypeBL.FldOperationTypeDA.UpdateBySqlWithCondition(objFldOperationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFldOperationTypeEN objFldOperationTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFldOperationTypeBL.FldOperationTypeDA.UpdateBySqlWithConditionTransaction(objFldOperationTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "strFldOpTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFldOperationTypeEN objFldOperationTypeEN)
{
try
{
int intRecNum = clsFldOperationTypeBL.FldOperationTypeDA.DelRecord(objFldOperationTypeEN.FldOpTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeENS">源对象</param>
 /// <param name = "objFldOperationTypeENT">目标对象</param>
 public static void CopyTo(this clsFldOperationTypeEN objFldOperationTypeENS, clsFldOperationTypeEN objFldOperationTypeENT)
{
try
{
objFldOperationTypeENT.FldOpTypeId = objFldOperationTypeENS.FldOpTypeId; //字段操作类型Id
objFldOperationTypeENT.FldOpTypeName = objFldOperationTypeENS.FldOpTypeName; //字段操作类型名称
objFldOperationTypeENT.FldOpTypeENName = objFldOperationTypeENS.FldOpTypeENName; //字段操作类型英文名
objFldOperationTypeENT.Memo = objFldOperationTypeENS.Memo; //说明
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
 /// <param name = "objFldOperationTypeENS">源对象</param>
 /// <returns>目标对象=>clsFldOperationTypeEN:objFldOperationTypeENT</returns>
 public static clsFldOperationTypeEN CopyTo(this clsFldOperationTypeEN objFldOperationTypeENS)
{
try
{
 clsFldOperationTypeEN objFldOperationTypeENT = new clsFldOperationTypeEN()
{
FldOpTypeId = objFldOperationTypeENS.FldOpTypeId, //字段操作类型Id
FldOpTypeName = objFldOperationTypeENS.FldOpTypeName, //字段操作类型名称
FldOpTypeENName = objFldOperationTypeENS.FldOpTypeENName, //字段操作类型英文名
Memo = objFldOperationTypeENS.Memo, //说明
};
 return objFldOperationTypeENT;
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
public static void CheckPropertyNew(this clsFldOperationTypeEN objFldOperationTypeEN)
{
 clsFldOperationTypeBL.FldOperationTypeDA.CheckPropertyNew(objFldOperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFldOperationTypeEN objFldOperationTypeEN)
{
 clsFldOperationTypeBL.FldOperationTypeDA.CheckProperty4Condition(objFldOperationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFldOperationTypeEN objFldOperationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFldOperationTypeCond.IsUpdated(conFldOperationType.FldOpTypeId) == true)
{
string strComparisonOpFldOpTypeId = objFldOperationTypeCond.dicFldComparisonOp[conFldOperationType.FldOpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFldOperationType.FldOpTypeId, objFldOperationTypeCond.FldOpTypeId, strComparisonOpFldOpTypeId);
}
if (objFldOperationTypeCond.IsUpdated(conFldOperationType.FldOpTypeName) == true)
{
string strComparisonOpFldOpTypeName = objFldOperationTypeCond.dicFldComparisonOp[conFldOperationType.FldOpTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFldOperationType.FldOpTypeName, objFldOperationTypeCond.FldOpTypeName, strComparisonOpFldOpTypeName);
}
if (objFldOperationTypeCond.IsUpdated(conFldOperationType.FldOpTypeENName) == true)
{
string strComparisonOpFldOpTypeENName = objFldOperationTypeCond.dicFldComparisonOp[conFldOperationType.FldOpTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFldOperationType.FldOpTypeENName, objFldOperationTypeCond.FldOpTypeENName, strComparisonOpFldOpTypeENName);
}
if (objFldOperationTypeCond.IsUpdated(conFldOperationType.Memo) == true)
{
string strComparisonOpMemo = objFldOperationTypeCond.dicFldComparisonOp[conFldOperationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFldOperationType.Memo, objFldOperationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FldOperationType(字段操作类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FldOpTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFldOperationTypeEN objFldOperationTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFldOperationTypeEN == null) return true;
if (objFldOperationTypeEN.FldOpTypeId == null || objFldOperationTypeEN.FldOpTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldOpTypeName = '{0}'", objFldOperationTypeEN.FldOpTypeName);
if (clsFldOperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FldOpTypeId !=  '{0}'", objFldOperationTypeEN.FldOpTypeId);
 sbCondition.AppendFormat(" and FldOpTypeName = '{0}'", objFldOperationTypeEN.FldOpTypeName);
if (clsFldOperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FldOperationType(字段操作类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldOpTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFldOperationTypeEN objFldOperationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFldOperationTypeEN == null) return "";
if (objFldOperationTypeEN.FldOpTypeId == null || objFldOperationTypeEN.FldOpTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldOpTypeName = '{0}'", objFldOperationTypeEN.FldOpTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FldOpTypeId !=  '{0}'", objFldOperationTypeEN.FldOpTypeId);
 sbCondition.AppendFormat(" and FldOpTypeName = '{0}'", objFldOperationTypeEN.FldOpTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FldOperationType
{
public virtual bool UpdRelaTabDate(string strFldOpTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumFldOperationType
{
 /// <summary>
 /// 未知
 /// </summary>
public const string UnKnown_0000 = "0000";
 /// <summary>
 /// 可读写
 /// </summary>
public const string ReadWrite_0001 = "0001";
 /// <summary>
 /// 只读
 /// </summary>
public const string OnlyRead_0002 = "0002";
 /// <summary>
 /// 只写
 /// </summary>
public const string OnlyWrite_0003 = "0003";
 /// <summary>
 /// 不可读写
 /// </summary>
public const string CannotReadWrite_0004 = "0004";
}
 /// <summary>
 /// 字段操作类型(FldOperationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFldOperationTypeBL
{
public static RelatedActions_FldOperationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFldOperationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFldOperationTypeDA FldOperationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFldOperationTypeDA();
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
 public clsFldOperationTypeBL()
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
if (string.IsNullOrEmpty(clsFldOperationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFldOperationTypeEN._ConnectString);
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
public static DataTable GetDataTable_FldOperationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FldOperationTypeDA.GetDataTable_FldOperationType(strWhereCond);
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
objDT = FldOperationTypeDA.GetDataTable(strWhereCond);
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
objDT = FldOperationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FldOperationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FldOperationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FldOperationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = FldOperationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FldOperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FldOperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldOpTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFldOperationTypeEN> GetObjLstByFldOpTypeIdLst(List<string> arrFldOpTypeIdLst)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldOpTypeIdLst, true);
 string strWhereCond = string.Format("FldOpTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldOpTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFldOperationTypeEN> GetObjLstByFldOpTypeIdLstCache(List<string> arrFldOpTypeIdLst)
{
string strKey = string.Format("{0}", clsFldOperationTypeEN._CurrTabName);
List<clsFldOperationTypeEN> arrFldOperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFldOperationTypeEN> arrFldOperationTypeObjLst_Sel =
arrFldOperationTypeObjLstCache
.Where(x => arrFldOpTypeIdLst.Contains(x.FldOpTypeId));
return arrFldOperationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFldOperationTypeEN> GetObjLst(string strWhereCond)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
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
public static List<clsFldOperationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFldOperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFldOperationTypeEN> GetSubObjLstCache(clsFldOperationTypeEN objFldOperationTypeCond)
{
List<clsFldOperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFldOperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFldOperationType._AttributeName)
{
if (objFldOperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objFldOperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFldOperationTypeCond[strFldName].ToString());
}
else
{
if (objFldOperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFldOperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFldOperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFldOperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFldOperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFldOperationTypeCond[strFldName]));
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
public static List<clsFldOperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
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
public static List<clsFldOperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
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
List<clsFldOperationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFldOperationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFldOperationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFldOperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
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
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
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
public static List<clsFldOperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFldOperationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFldOperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
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
public static List<clsFldOperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFldOperationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFldOperationTypeEN> arrObjLst = new List<clsFldOperationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN();
try
{
objFldOperationTypeEN.FldOpTypeId = objRow[conFldOperationType.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objFldOperationTypeEN.FldOpTypeName = objRow[conFldOperationType.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objFldOperationTypeEN.FldOpTypeENName = objRow[conFldOperationType.FldOpTypeENName].ToString().Trim(); //字段操作类型英文名
objFldOperationTypeEN.Memo = objRow[conFldOperationType.Memo] == DBNull.Value ? null : objRow[conFldOperationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFldOperationTypeEN.FldOpTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFldOperationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFldOperationType(ref clsFldOperationTypeEN objFldOperationTypeEN)
{
bool bolResult = FldOperationTypeDA.GetFldOperationType(ref objFldOperationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldOpTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFldOperationTypeEN GetObjByFldOpTypeId(string strFldOpTypeId)
{
if (strFldOpTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldOpTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldOpTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldOpTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFldOperationTypeEN objFldOperationTypeEN = FldOperationTypeDA.GetObjByFldOpTypeId(strFldOpTypeId);
return objFldOperationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFldOperationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFldOperationTypeEN objFldOperationTypeEN = FldOperationTypeDA.GetFirstObj(strWhereCond);
 return objFldOperationTypeEN;
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
public static clsFldOperationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFldOperationTypeEN objFldOperationTypeEN = FldOperationTypeDA.GetObjByDataRow(objRow);
 return objFldOperationTypeEN;
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
public static clsFldOperationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFldOperationTypeEN objFldOperationTypeEN = FldOperationTypeDA.GetObjByDataRow(objRow);
 return objFldOperationTypeEN;
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
 /// <param name = "strFldOpTypeId">所给的关键字</param>
 /// <param name = "lstFldOperationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFldOperationTypeEN GetObjByFldOpTypeIdFromList(string strFldOpTypeId, List<clsFldOperationTypeEN> lstFldOperationTypeObjLst)
{
foreach (clsFldOperationTypeEN objFldOperationTypeEN in lstFldOperationTypeObjLst)
{
if (objFldOperationTypeEN.FldOpTypeId == strFldOpTypeId)
{
return objFldOperationTypeEN;
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
 string strMaxFldOpTypeId;
 try
 {
 strMaxFldOpTypeId = clsFldOperationTypeDA.GetMaxStrId();
 return strMaxFldOpTypeId;
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
 string strFldOpTypeId;
 try
 {
 strFldOpTypeId = new clsFldOperationTypeDA().GetFirstID(strWhereCond);
 return strFldOpTypeId;
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
 arrList = FldOperationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = FldOperationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldOpTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldOpTypeId)
{
if (string.IsNullOrEmpty(strFldOpTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldOpTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FldOperationTypeDA.IsExist(strFldOpTypeId);
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
 bolIsExist = clsFldOperationTypeDA.IsExistTable();
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
 bolIsExist = FldOperationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFldOperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段操作类型名称 = [{0}]的数据已经存在!(in clsFldOperationTypeBL.AddNewRecordBySql2)", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
bool bolResult = FldOperationTypeDA.AddNewRecordBySQL2(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFldOperationTypeEN objFldOperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFldOperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段操作类型名称 = [{0}]的数据已经存在!(in clsFldOperationTypeBL.AddNewRecordBySql2WithReturnKey)", objFldOperationTypeEN.FldOpTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true || clsFldOperationTypeBL.IsExist(objFldOperationTypeEN.FldOpTypeId) == true)
 {
     objFldOperationTypeEN.FldOpTypeId = clsFldOperationTypeBL.GetMaxStrId_S();
 }
string strKey = FldOperationTypeDA.AddNewRecordBySQL2WithReturnKey(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFldOperationTypeEN objFldOperationTypeEN)
{
try
{
bool bolResult = FldOperationTypeDA.Update(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "objFldOperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFldOperationTypeEN objFldOperationTypeEN)
{
 if (string.IsNullOrEmpty(objFldOperationTypeEN.FldOpTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FldOperationTypeDA.UpdateBySql2(objFldOperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFldOperationTypeBL.ReFreshCache();

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
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
 /// <param name = "strFldOpTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFldOpTypeId)
{
try
{
 clsFldOperationTypeEN objFldOperationTypeEN = clsFldOperationTypeBL.GetObjByFldOpTypeId(strFldOpTypeId);

if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(objFldOperationTypeEN.FldOpTypeId, "SetUpdDate");
}
if (objFldOperationTypeEN != null)
{
int intRecNum = FldOperationTypeDA.DelRecord(strFldOpTypeId);
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
/// <param name="strFldOpTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFldOpTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFldOperationTypeDA.GetSpecSQLObj();
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
//删除与表:[FldOperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFldOperationType.FldOpTypeId,
//strFldOpTypeId);
//        clsFldOperationTypeBL.DelFldOperationTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFldOperationTypeBL.DelRecord(strFldOpTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFldOperationTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldOpTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFldOpTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFldOpTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFldOperationTypeBL.relatedActions != null)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(strFldOpTypeId, "UpdRelaTabDate");
}
bool bolResult = FldOperationTypeDA.DelRecord(strFldOpTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFldOpTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFldOperationTypes(List<string> arrFldOpTypeIdLst)
{
if (arrFldOpTypeIdLst.Count == 0) return 0;
try
{
if (clsFldOperationTypeBL.relatedActions != null)
{
foreach (var strFldOpTypeId in arrFldOpTypeIdLst)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(strFldOpTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = FldOperationTypeDA.DelFldOperationType(arrFldOpTypeIdLst);
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
public static int DelFldOperationTypesByCond(string strWhereCond)
{
try
{
if (clsFldOperationTypeBL.relatedActions != null)
{
List<string> arrFldOpTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFldOpTypeId in arrFldOpTypeId)
{
clsFldOperationTypeBL.relatedActions.UpdRelaTabDate(strFldOpTypeId, "UpdRelaTabDate");
}
}
int intRecNum = FldOperationTypeDA.DelFldOperationType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FldOperationType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFldOpTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFldOpTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFldOperationTypeDA.GetSpecSQLObj();
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
//删除与表:[FldOperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFldOperationTypeBL.DelRecord(strFldOpTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFldOperationTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldOpTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFldOperationTypeENS">源对象</param>
 /// <param name = "objFldOperationTypeENT">目标对象</param>
 public static void CopyTo(clsFldOperationTypeEN objFldOperationTypeENS, clsFldOperationTypeEN objFldOperationTypeENT)
{
try
{
objFldOperationTypeENT.FldOpTypeId = objFldOperationTypeENS.FldOpTypeId; //字段操作类型Id
objFldOperationTypeENT.FldOpTypeName = objFldOperationTypeENS.FldOpTypeName; //字段操作类型名称
objFldOperationTypeENT.FldOpTypeENName = objFldOperationTypeENS.FldOpTypeENName; //字段操作类型英文名
objFldOperationTypeENT.Memo = objFldOperationTypeENS.Memo; //说明
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
 /// <param name = "objFldOperationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsFldOperationTypeEN objFldOperationTypeEN)
{
try
{
objFldOperationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFldOperationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFldOperationType.FldOpTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFldOperationTypeEN.FldOpTypeId = objFldOperationTypeEN.FldOpTypeId; //字段操作类型Id
}
if (arrFldSet.Contains(conFldOperationType.FldOpTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objFldOperationTypeEN.FldOpTypeName = objFldOperationTypeEN.FldOpTypeName; //字段操作类型名称
}
if (arrFldSet.Contains(conFldOperationType.FldOpTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objFldOperationTypeEN.FldOpTypeENName = objFldOperationTypeEN.FldOpTypeENName; //字段操作类型英文名
}
if (arrFldSet.Contains(conFldOperationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFldOperationTypeEN.Memo = objFldOperationTypeEN.Memo == "[null]" ? null :  objFldOperationTypeEN.Memo; //说明
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
 /// <param name = "objFldOperationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFldOperationTypeEN objFldOperationTypeEN)
{
try
{
if (objFldOperationTypeEN.Memo == "[null]") objFldOperationTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFldOperationTypeEN objFldOperationTypeEN)
{
 FldOperationTypeDA.CheckPropertyNew(objFldOperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFldOperationTypeEN objFldOperationTypeEN)
{
 FldOperationTypeDA.CheckProperty4Condition(objFldOperationTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FldOpTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFldOperationType.FldOpTypeId); 
List<clsFldOperationTypeEN> arrObjLst = clsFldOperationTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFldOperationTypeEN objFldOperationTypeEN = new clsFldOperationTypeEN()
{
FldOpTypeId = "0",
FldOpTypeName = "选[字段操作类型]..."
};
arrObjLst.Insert(0, objFldOperationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFldOperationType.FldOpTypeId;
objComboBox.DisplayMember = conFldOperationType.FldOpTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FldOpTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段操作类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFldOperationType.FldOpTypeId); 
IEnumerable<clsFldOperationTypeEN> arrObjLst = clsFldOperationTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conFldOperationType.FldOpTypeId;
objDDL.DataTextField = conFldOperationType.FldOpTypeName;
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
public static void BindDdl_FldOpTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段操作类型]...","0");
List<clsFldOperationTypeEN> arrFldOperationTypeObjLst = GetAllFldOperationTypeObjLstCache(); 
objDDL.DataValueField = conFldOperationType.FldOpTypeId;
objDDL.DataTextField = conFldOperationType.FldOpTypeName;
objDDL.DataSource = arrFldOperationTypeObjLst;
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
if (clsFldOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFldOperationTypeBL没有刷新缓存机制(clsFldOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldOpTypeId");
//if (arrFldOperationTypeObjLstCache == null)
//{
//arrFldOperationTypeObjLstCache = FldOperationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldOpTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFldOperationTypeEN GetObjByFldOpTypeIdCache(string strFldOpTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFldOperationTypeEN._CurrTabName);
List<clsFldOperationTypeEN> arrFldOperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFldOperationTypeEN> arrFldOperationTypeObjLst_Sel =
arrFldOperationTypeObjLstCache
.Where(x=> x.FldOpTypeId == strFldOpTypeId 
);
if (arrFldOperationTypeObjLst_Sel.Count() == 0)
{
   clsFldOperationTypeEN obj = clsFldOperationTypeBL.GetObjByFldOpTypeId(strFldOpTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFldOperationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldOpTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldOpTypeNameByFldOpTypeIdCache(string strFldOpTypeId)
{
if (string.IsNullOrEmpty(strFldOpTypeId) == true) return "";
//获取缓存中的对象列表
clsFldOperationTypeEN objFldOperationType = GetObjByFldOpTypeIdCache(strFldOpTypeId);
if (objFldOperationType == null) return "";
return objFldOperationType.FldOpTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldOpTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldOpTypeIdCache(string strFldOpTypeId)
{
if (string.IsNullOrEmpty(strFldOpTypeId) == true) return "";
//获取缓存中的对象列表
clsFldOperationTypeEN objFldOperationType = GetObjByFldOpTypeIdCache(strFldOpTypeId);
if (objFldOperationType == null) return "";
return objFldOperationType.FldOpTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFldOperationTypeEN> GetAllFldOperationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsFldOperationTypeEN> arrFldOperationTypeObjLstCache = GetObjLstCache(); 
return arrFldOperationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFldOperationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFldOperationTypeEN._CurrTabName);
List<clsFldOperationTypeEN> arrFldOperationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFldOperationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsFldOperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFldOperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFldOperationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsFldOperationTypeEN._RefreshTimeLst[clsFldOperationTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFldOperationTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFldOperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFldOperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFldOperationTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FldOperationType(字段操作类型)
 /// 唯一性条件:FldOpTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFldOperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFldOperationTypeEN objFldOperationTypeEN)
{
//检测记录是否存在
string strResult = FldOperationTypeDA.GetUniCondStr(objFldOperationTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFldOpTypeId)
{
if (strInFldName != conFldOperationType.FldOpTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFldOperationType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFldOperationType._AttributeName));
throw new Exception(strMsg);
}
var objFldOperationType = clsFldOperationTypeBL.GetObjByFldOpTypeIdCache(strFldOpTypeId);
if (objFldOperationType == null) return "";
return objFldOperationType[strOutFldName].ToString();
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
int intRecCount = clsFldOperationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsFldOperationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFldOperationTypeDA.GetRecCount();
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
int intRecCount = clsFldOperationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFldOperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFldOperationTypeEN objFldOperationTypeCond)
{
List<clsFldOperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFldOperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFldOperationType._AttributeName)
{
if (objFldOperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objFldOperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFldOperationTypeCond[strFldName].ToString());
}
else
{
if (objFldOperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFldOperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFldOperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFldOperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFldOperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFldOperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFldOperationTypeCond[strFldName]));
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
 List<string> arrList = clsFldOperationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FldOperationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FldOperationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FldOperationTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFldOperationTypeDA.SetFldValue(clsFldOperationTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FldOperationTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFldOperationTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFldOperationTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFldOperationTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FldOperationType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字段操作类型Id*/ 
 strCreateTabCode.Append(" FldOpTypeId char(4) primary key, "); 
 // /**字段操作类型名称*/ 
 strCreateTabCode.Append(" FldOpTypeName varchar(100) not Null, "); 
 // /**字段操作类型英文名*/ 
 strCreateTabCode.Append(" FldOpTypeENName varchar(100) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 字段操作类型(FldOperationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FldOperationType : clsCommFun4BL
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
clsFldOperationTypeBL.ReFreshThisCache();
}
}

}