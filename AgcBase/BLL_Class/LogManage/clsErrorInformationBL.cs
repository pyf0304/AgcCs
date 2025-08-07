
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorInformationBL
 表名:ErrorInformation(00050185)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsErrorInformationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngErrorID">表关键字</param>
 /// <returns>表对象</returns>
public static clsErrorInformationEN GetObj(this K_ErrorID_ErrorInformation myKey)
{
clsErrorInformationEN objErrorInformationEN = clsErrorInformationBL.ErrorInformationDA.GetObjByErrorID(myKey.Value);
return objErrorInformationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsErrorInformationEN objErrorInformationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objErrorInformationEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],功能名称 = [{1}],错误信息 = [{2}],页面名称 = [{3}]的数据已经存在!(in clsErrorInformationBL.AddNewRecord)", objErrorInformationEN.UserId,objErrorInformationEN.FunctionName,objErrorInformationEN.ErrorInformation,objErrorInformationEN.PageName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsErrorInformationBL.ErrorInformationDA.AddNewRecordBySQL2(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
public static bool AddRecordEx(this clsErrorInformationEN objErrorInformationEN, bool bolIsNeedCheckUniqueness = true)
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
objErrorInformationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objErrorInformationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户Id(UserId)=[{0}],功能名称(FunctionName)=[{1}],错误信息(ErrorInformation)=[{2}],页面名称(PageName)=[{3}])已经存在,不能重复!", objErrorInformationEN.UserId, objErrorInformationEN.FunctionName, objErrorInformationEN.ErrorInformation, objErrorInformationEN.PageName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objErrorInformationEN.AddNewRecord();
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsErrorInformationEN objErrorInformationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objErrorInformationEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],功能名称 = [{1}],错误信息 = [{2}],页面名称 = [{3}]的数据已经存在!(in clsErrorInformationBL.AddNewRecordWithReturnKey)", objErrorInformationEN.UserId,objErrorInformationEN.FunctionName,objErrorInformationEN.ErrorInformation,objErrorInformationEN.PageName);
throw new Exception(strMsg);
}
try
{
string strKey = clsErrorInformationBL.ErrorInformationDA.AddNewRecordBySQL2WithReturnKey(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetErrorID(this clsErrorInformationEN objErrorInformationEN, long lngErrorID, string strComparisonOp="")
	{
objErrorInformationEN.ErrorID = lngErrorID; //错误流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.ErrorID) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.ErrorID, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.ErrorID] = strComparisonOp;
}
}
return objErrorInformationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetPageName(this clsErrorInformationEN objErrorInformationEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, conErrorInformation.PageName);
}
objErrorInformationEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.PageName) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.PageName, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.PageName] = strComparisonOp;
}
}
return objErrorInformationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetFunctionName(this clsErrorInformationEN objErrorInformationEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, conErrorInformation.FunctionName);
}
objErrorInformationEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.FunctionName) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.FunctionName, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.FunctionName] = strComparisonOp;
}
}
return objErrorInformationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetErrorInformation(this clsErrorInformationEN objErrorInformationEN, string strErrorInformation, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorInformation, conErrorInformation.ErrorInformation);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorInformation, 5000, conErrorInformation.ErrorInformation);
}
objErrorInformationEN.ErrorInformation = strErrorInformation; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.ErrorInformation) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.ErrorInformation, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.ErrorInformation] = strComparisonOp;
}
}
return objErrorInformationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetUserId(this clsErrorInformationEN objErrorInformationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conErrorInformation.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conErrorInformation.UserId);
}
objErrorInformationEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.UserId) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.UserId, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.UserId] = strComparisonOp;
}
}
return objErrorInformationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsErrorInformationEN SetCreateTime(this clsErrorInformationEN objErrorInformationEN, DateTime dteCreateTime, string strComparisonOp="")
	{
objErrorInformationEN.CreateTime = dteCreateTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objErrorInformationEN.dicFldComparisonOp.ContainsKey(conErrorInformation.CreateTime) == false)
{
objErrorInformationEN.dicFldComparisonOp.Add(conErrorInformation.CreateTime, strComparisonOp);
}
else
{
objErrorInformationEN.dicFldComparisonOp[conErrorInformation.CreateTime] = strComparisonOp;
}
}
return objErrorInformationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsErrorInformationEN objErrorInformationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objErrorInformationEN.CheckPropertyNew();
clsErrorInformationEN objErrorInformationCond = new clsErrorInformationEN();
string strCondition = objErrorInformationCond
.SetErrorID(objErrorInformationEN.ErrorID, "<>")
.SetUserId(objErrorInformationEN.UserId, "=")
.SetFunctionName(objErrorInformationEN.FunctionName, "=")
.SetErrorInformation(objErrorInformationEN.ErrorInformation, "=")
.SetPageName(objErrorInformationEN.PageName, "=")
.GetCombineCondition();
objErrorInformationEN._IsCheckProperty = true;
bool bolIsExist = clsErrorInformationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_FunctionName_ErrorInformation_PageName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objErrorInformationEN.Update();
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
 /// <param name = "objErrorInformation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsErrorInformationEN objErrorInformation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsErrorInformationEN objErrorInformationCond = new clsErrorInformationEN();
string strCondition = objErrorInformationCond
.SetUserId(objErrorInformation.UserId, "=")
.SetFunctionName(objErrorInformation.FunctionName, "=")
.SetErrorInformation(objErrorInformation.ErrorInformation, "=")
.SetPageName(objErrorInformation.PageName, "=")
.GetCombineCondition();
objErrorInformation._IsCheckProperty = true;
bool bolIsExist = clsErrorInformationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objErrorInformation.ErrorID = clsErrorInformationBL.GetFirstID_S(strCondition);
objErrorInformation.UpdateWithCondition(strCondition);
}
else
{
objErrorInformation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsErrorInformationEN objErrorInformationEN)
{
 if (objErrorInformationEN.ErrorID == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsErrorInformationBL.ErrorInformationDA.UpdateBySql2(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsErrorInformationEN objErrorInformationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objErrorInformationEN.ErrorID == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsErrorInformationBL.ErrorInformationDA.UpdateBySql2(objErrorInformationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsErrorInformationEN objErrorInformationEN, string strWhereCond)
{
try
{
bool bolResult = clsErrorInformationBL.ErrorInformationDA.UpdateBySqlWithCondition(objErrorInformationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsErrorInformationEN objErrorInformationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsErrorInformationBL.ErrorInformationDA.UpdateBySqlWithConditionTransaction(objErrorInformationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "lngErrorID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsErrorInformationEN objErrorInformationEN)
{
try
{
int intRecNum = clsErrorInformationBL.ErrorInformationDA.DelRecord(objErrorInformationEN.ErrorID);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationENS">源对象</param>
 /// <param name = "objErrorInformationENT">目标对象</param>
 public static void CopyTo(this clsErrorInformationEN objErrorInformationENS, clsErrorInformationEN objErrorInformationENT)
{
try
{
objErrorInformationENT.ErrorID = objErrorInformationENS.ErrorID; //错误流水号
objErrorInformationENT.PageName = objErrorInformationENS.PageName; //页面名称
objErrorInformationENT.FunctionName = objErrorInformationENS.FunctionName; //功能名称
objErrorInformationENT.ErrorInformation = objErrorInformationENS.ErrorInformation; //错误信息
objErrorInformationENT.UserId = objErrorInformationENS.UserId; //用户Id
objErrorInformationENT.CreateTime = objErrorInformationENS.CreateTime; //创建时间
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
 /// <param name = "objErrorInformationENS">源对象</param>
 /// <returns>目标对象=>clsErrorInformationEN:objErrorInformationENT</returns>
 public static clsErrorInformationEN CopyTo(this clsErrorInformationEN objErrorInformationENS)
{
try
{
 clsErrorInformationEN objErrorInformationENT = new clsErrorInformationEN()
{
ErrorID = objErrorInformationENS.ErrorID, //错误流水号
PageName = objErrorInformationENS.PageName, //页面名称
FunctionName = objErrorInformationENS.FunctionName, //功能名称
ErrorInformation = objErrorInformationENS.ErrorInformation, //错误信息
UserId = objErrorInformationENS.UserId, //用户Id
CreateTime = objErrorInformationENS.CreateTime, //创建时间
};
 return objErrorInformationENT;
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
public static void CheckPropertyNew(this clsErrorInformationEN objErrorInformationEN)
{
 clsErrorInformationBL.ErrorInformationDA.CheckPropertyNew(objErrorInformationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsErrorInformationEN objErrorInformationEN)
{
 clsErrorInformationBL.ErrorInformationDA.CheckProperty4Condition(objErrorInformationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsErrorInformationEN objErrorInformationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objErrorInformationCond.IsUpdated(conErrorInformation.ErrorID) == true)
{
string strComparisonOpErrorID = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.ErrorID];
strWhereCond += string.Format(" And {0} {2} {1}", conErrorInformation.ErrorID, objErrorInformationCond.ErrorID, strComparisonOpErrorID);
}
if (objErrorInformationCond.IsUpdated(conErrorInformation.PageName) == true)
{
string strComparisonOpPageName = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conErrorInformation.PageName, objErrorInformationCond.PageName, strComparisonOpPageName);
}
if (objErrorInformationCond.IsUpdated(conErrorInformation.FunctionName) == true)
{
string strComparisonOpFunctionName = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conErrorInformation.FunctionName, objErrorInformationCond.FunctionName, strComparisonOpFunctionName);
}
if (objErrorInformationCond.IsUpdated(conErrorInformation.ErrorInformation) == true)
{
string strComparisonOpErrorInformation = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.ErrorInformation];
strWhereCond += string.Format(" And {0} {2} '{1}'", conErrorInformation.ErrorInformation, objErrorInformationCond.ErrorInformation, strComparisonOpErrorInformation);
}
if (objErrorInformationCond.IsUpdated(conErrorInformation.UserId) == true)
{
string strComparisonOpUserId = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conErrorInformation.UserId, objErrorInformationCond.UserId, strComparisonOpUserId);
}
if (objErrorInformationCond.IsUpdated(conErrorInformation.CreateTime) == true)
{
string strComparisonOpCreateTime = objErrorInformationCond.dicFldComparisonOp[conErrorInformation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conErrorInformation.CreateTime, objErrorInformationCond.CreateTime, strComparisonOpCreateTime);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ErrorInformation(错误), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_FunctionName_ErrorInformation_PageName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objErrorInformationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsErrorInformationEN objErrorInformationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objErrorInformationEN == null) return true;
if (objErrorInformationEN.ErrorID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objErrorInformationEN.UserId);
 if (objErrorInformationEN.FunctionName == null)
{
 sbCondition.AppendFormat(" and FunctionName is null", objErrorInformationEN.FunctionName);
}
else
{
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objErrorInformationEN.FunctionName);
}
 sbCondition.AppendFormat(" and ErrorInformation = '{0}'", objErrorInformationEN.ErrorInformation);
 if (objErrorInformationEN.PageName == null)
{
 sbCondition.AppendFormat(" and PageName is null", objErrorInformationEN.PageName);
}
else
{
 sbCondition.AppendFormat(" and PageName = '{0}'", objErrorInformationEN.PageName);
}
if (clsErrorInformationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ErrorID !=  {0}", objErrorInformationEN.ErrorID);
 sbCondition.AppendFormat(" and UserId = '{0}'", objErrorInformationEN.UserId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objErrorInformationEN.FunctionName);
 sbCondition.AppendFormat(" and ErrorInformation = '{0}'", objErrorInformationEN.ErrorInformation);
 sbCondition.AppendFormat(" and PageName = '{0}'", objErrorInformationEN.PageName);
if (clsErrorInformationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ErrorInformation(错误), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_FunctionName_ErrorInformation_PageName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objErrorInformationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsErrorInformationEN objErrorInformationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objErrorInformationEN == null) return "";
if (objErrorInformationEN.ErrorID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objErrorInformationEN.UserId);
 if (objErrorInformationEN.FunctionName == null)
{
 sbCondition.AppendFormat(" and FunctionName is null", objErrorInformationEN.FunctionName);
}
else
{
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objErrorInformationEN.FunctionName);
}
 sbCondition.AppendFormat(" and ErrorInformation = '{0}'", objErrorInformationEN.ErrorInformation);
 if (objErrorInformationEN.PageName == null)
{
 sbCondition.AppendFormat(" and PageName is null", objErrorInformationEN.PageName);
}
else
{
 sbCondition.AppendFormat(" and PageName = '{0}'", objErrorInformationEN.PageName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ErrorID !=  {0}", objErrorInformationEN.ErrorID);
 sbCondition.AppendFormat(" and UserId = '{0}'", objErrorInformationEN.UserId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objErrorInformationEN.FunctionName);
 sbCondition.AppendFormat(" and ErrorInformation = '{0}'", objErrorInformationEN.ErrorInformation);
 sbCondition.AppendFormat(" and PageName = '{0}'", objErrorInformationEN.PageName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ErrorInformation
{
public virtual bool UpdRelaTabDate(long lngErrorID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsErrorInformationBL
{
public static RelatedActions_ErrorInformation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsErrorInformationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsErrorInformationDA ErrorInformationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsErrorInformationDA();
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
 public clsErrorInformationBL()
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
if (string.IsNullOrEmpty(clsErrorInformationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsErrorInformationEN._ConnectString);
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
public static DataTable GetDataTable_ErrorInformation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ErrorInformationDA.GetDataTable_ErrorInformation(strWhereCond);
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
objDT = ErrorInformationDA.GetDataTable(strWhereCond);
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
objDT = ErrorInformationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ErrorInformationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ErrorInformationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ErrorInformationDA.GetDataTable_Top(objTopPara);
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
objDT = ErrorInformationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ErrorInformationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ErrorInformationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrErrorIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsErrorInformationEN> GetObjLstByErrorIDLst(List<long> arrErrorIDLst)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrErrorIDLst);
 string strWhereCond = string.Format("ErrorID in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrErrorIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsErrorInformationEN> GetObjLstByErrorIDLstCache(List<long> arrErrorIDLst)
{
string strKey = string.Format("{0}", clsErrorInformationEN._CurrTabName);
List<clsErrorInformationEN> arrErrorInformationObjLstCache = GetObjLstCache();
IEnumerable <clsErrorInformationEN> arrErrorInformationObjLst_Sel =
arrErrorInformationObjLstCache
.Where(x => arrErrorIDLst.Contains(x.ErrorID));
return arrErrorInformationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsErrorInformationEN> GetObjLst(string strWhereCond)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
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
public static List<clsErrorInformationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objErrorInformationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsErrorInformationEN> GetSubObjLstCache(clsErrorInformationEN objErrorInformationCond)
{
List<clsErrorInformationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsErrorInformationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conErrorInformation._AttributeName)
{
if (objErrorInformationCond.IsUpdated(strFldName) == false) continue;
if (objErrorInformationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objErrorInformationCond[strFldName].ToString());
}
else
{
if (objErrorInformationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objErrorInformationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objErrorInformationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objErrorInformationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objErrorInformationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objErrorInformationCond[strFldName]));
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
public static List<clsErrorInformationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
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
public static List<clsErrorInformationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
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
List<clsErrorInformationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsErrorInformationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsErrorInformationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsErrorInformationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
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
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
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
public static List<clsErrorInformationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsErrorInformationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsErrorInformationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
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
public static List<clsErrorInformationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsErrorInformationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
try
{
objErrorInformationEN.ErrorID = Int32.Parse(objRow[conErrorInformation.ErrorID].ToString().Trim()); //错误流水号
objErrorInformationEN.PageName = objRow[conErrorInformation.PageName] == DBNull.Value ? null : objRow[conErrorInformation.PageName].ToString().Trim(); //页面名称
objErrorInformationEN.FunctionName = objRow[conErrorInformation.FunctionName] == DBNull.Value ? null : objRow[conErrorInformation.FunctionName].ToString().Trim(); //功能名称
objErrorInformationEN.ErrorInformation = objRow[conErrorInformation.ErrorInformation].ToString().Trim(); //错误信息
objErrorInformationEN.UserId = objRow[conErrorInformation.UserId].ToString().Trim(); //用户Id
objErrorInformationEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[conErrorInformation.CreateTime].ToString().Trim()); //创建时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objErrorInformationEN.ErrorID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objErrorInformationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objErrorInformationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetErrorInformation(ref clsErrorInformationEN objErrorInformationEN)
{
bool bolResult = ErrorInformationDA.GetErrorInformation(ref objErrorInformationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngErrorID">表关键字</param>
 /// <returns>表对象</returns>
public static clsErrorInformationEN GetObjByErrorID(long lngErrorID)
{
clsErrorInformationEN objErrorInformationEN = ErrorInformationDA.GetObjByErrorID(lngErrorID);
return objErrorInformationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsErrorInformationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsErrorInformationEN objErrorInformationEN = ErrorInformationDA.GetFirstObj(strWhereCond);
 return objErrorInformationEN;
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
public static clsErrorInformationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsErrorInformationEN objErrorInformationEN = ErrorInformationDA.GetObjByDataRow(objRow);
 return objErrorInformationEN;
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
public static clsErrorInformationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsErrorInformationEN objErrorInformationEN = ErrorInformationDA.GetObjByDataRow(objRow);
 return objErrorInformationEN;
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
 /// <param name = "lngErrorID">所给的关键字</param>
 /// <param name = "lstErrorInformationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsErrorInformationEN GetObjByErrorIDFromList(long lngErrorID, List<clsErrorInformationEN> lstErrorInformationObjLst)
{
foreach (clsErrorInformationEN objErrorInformationEN in lstErrorInformationObjLst)
{
if (objErrorInformationEN.ErrorID == lngErrorID)
{
return objErrorInformationEN;
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
 long lngErrorID;
 try
 {
 lngErrorID = new clsErrorInformationDA().GetFirstID(strWhereCond);
 return lngErrorID;
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
 arrList = ErrorInformationDA.GetID(strWhereCond);
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
bool bolIsExist = ErrorInformationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngErrorID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngErrorID)
{
//检测记录是否存在
bool bolIsExist = ErrorInformationDA.IsExist(lngErrorID);
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
 bolIsExist = clsErrorInformationDA.IsExistTable();
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
 bolIsExist = ErrorInformationDA.IsExistTable(strTabName);
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsErrorInformationEN objErrorInformationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objErrorInformationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],功能名称 = [{1}],错误信息 = [{2}],页面名称 = [{3}]的数据已经存在!(in clsErrorInformationBL.AddNewRecordBySql2)", objErrorInformationEN.UserId,objErrorInformationEN.FunctionName,objErrorInformationEN.ErrorInformation,objErrorInformationEN.PageName);
throw new Exception(strMsg);
}
try
{
bool bolResult = ErrorInformationDA.AddNewRecordBySQL2(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsErrorInformationEN objErrorInformationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objErrorInformationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],功能名称 = [{1}],错误信息 = [{2}],页面名称 = [{3}]的数据已经存在!(in clsErrorInformationBL.AddNewRecordBySql2WithReturnKey)", objErrorInformationEN.UserId,objErrorInformationEN.FunctionName,objErrorInformationEN.ErrorInformation,objErrorInformationEN.PageName);
throw new Exception(strMsg);
}
try
{
string strKey = ErrorInformationDA.AddNewRecordBySQL2WithReturnKey(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsErrorInformationEN objErrorInformationEN)
{
try
{
bool bolResult = ErrorInformationDA.Update(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "objErrorInformationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsErrorInformationEN objErrorInformationEN)
{
 if (objErrorInformationEN.ErrorID == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ErrorInformationDA.UpdateBySql2(objErrorInformationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsErrorInformationBL.ReFreshCache();

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
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
 /// <param name = "lngErrorID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngErrorID)
{
try
{
 clsErrorInformationEN objErrorInformationEN = clsErrorInformationBL.GetObjByErrorID(lngErrorID);

if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(objErrorInformationEN.ErrorID, "SetUpdDate");
}
if (objErrorInformationEN != null)
{
int intRecNum = ErrorInformationDA.DelRecord(lngErrorID);
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
/// <param name="lngErrorID">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngErrorID )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsErrorInformationDA.GetSpecSQLObj();
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
//删除与表:[ErrorInformation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conErrorInformation.ErrorID,
//lngErrorID);
//        clsErrorInformationBL.DelErrorInformationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsErrorInformationBL.DelRecord(lngErrorID, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsErrorInformationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngErrorID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngErrorID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngErrorID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsErrorInformationBL.relatedActions != null)
{
clsErrorInformationBL.relatedActions.UpdRelaTabDate(lngErrorID, "UpdRelaTabDate");
}
bool bolResult = ErrorInformationDA.DelRecord(lngErrorID,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrErrorIDLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelErrorInformations(List<string> arrErrorIDLst)
{
if (arrErrorIDLst.Count == 0) return 0;
try
{
if (clsErrorInformationBL.relatedActions != null)
{
foreach (var strErrorID in arrErrorIDLst)
{
long lngErrorID = long.Parse(strErrorID);
clsErrorInformationBL.relatedActions.UpdRelaTabDate(lngErrorID, "UpdRelaTabDate");
}
}
int intDelRecNum = ErrorInformationDA.DelErrorInformation(arrErrorIDLst);
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
public static int DelErrorInformationsByCond(string strWhereCond)
{
try
{
if (clsErrorInformationBL.relatedActions != null)
{
List<string> arrErrorID = GetPrimaryKeyID_S(strWhereCond);
foreach (var strErrorID in arrErrorID)
{
long lngErrorID = long.Parse(strErrorID);
clsErrorInformationBL.relatedActions.UpdRelaTabDate(lngErrorID, "UpdRelaTabDate");
}
}
int intRecNum = ErrorInformationDA.DelErrorInformation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ErrorInformation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngErrorID">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngErrorID)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsErrorInformationDA.GetSpecSQLObj();
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
//删除与表:[ErrorInformation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsErrorInformationBL.DelRecord(lngErrorID, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsErrorInformationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngErrorID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objErrorInformationENS">源对象</param>
 /// <param name = "objErrorInformationENT">目标对象</param>
 public static void CopyTo(clsErrorInformationEN objErrorInformationENS, clsErrorInformationEN objErrorInformationENT)
{
try
{
objErrorInformationENT.ErrorID = objErrorInformationENS.ErrorID; //错误流水号
objErrorInformationENT.PageName = objErrorInformationENS.PageName; //页面名称
objErrorInformationENT.FunctionName = objErrorInformationENS.FunctionName; //功能名称
objErrorInformationENT.ErrorInformation = objErrorInformationENS.ErrorInformation; //错误信息
objErrorInformationENT.UserId = objErrorInformationENS.UserId; //用户Id
objErrorInformationENT.CreateTime = objErrorInformationENS.CreateTime; //创建时间
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
 /// <param name = "objErrorInformationEN">源简化对象</param>
 public static void SetUpdFlag(clsErrorInformationEN objErrorInformationEN)
{
try
{
objErrorInformationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objErrorInformationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conErrorInformation.ErrorID, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.ErrorID = objErrorInformationEN.ErrorID; //错误流水号
}
if (arrFldSet.Contains(conErrorInformation.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.PageName = objErrorInformationEN.PageName == "[null]" ? null :  objErrorInformationEN.PageName; //页面名称
}
if (arrFldSet.Contains(conErrorInformation.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.FunctionName = objErrorInformationEN.FunctionName == "[null]" ? null :  objErrorInformationEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(conErrorInformation.ErrorInformation, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.ErrorInformation = objErrorInformationEN.ErrorInformation; //错误信息
}
if (arrFldSet.Contains(conErrorInformation.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.UserId = objErrorInformationEN.UserId; //用户Id
}
if (arrFldSet.Contains(conErrorInformation.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objErrorInformationEN.CreateTime = objErrorInformationEN.CreateTime; //创建时间
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
 /// <param name = "objErrorInformationEN">源简化对象</param>
 public static void AccessFldValueNull(clsErrorInformationEN objErrorInformationEN)
{
try
{
if (objErrorInformationEN.PageName == "[null]") objErrorInformationEN.PageName = null; //页面名称
if (objErrorInformationEN.FunctionName == "[null]") objErrorInformationEN.FunctionName = null; //功能名称
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
public static void CheckPropertyNew(clsErrorInformationEN objErrorInformationEN)
{
 ErrorInformationDA.CheckPropertyNew(objErrorInformationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsErrorInformationEN objErrorInformationEN)
{
 ErrorInformationDA.CheckProperty4Condition(objErrorInformationEN);
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
if (clsErrorInformationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsErrorInformationBL没有刷新缓存机制(clsErrorInformationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ErrorID");
//if (arrErrorInformationObjLstCache == null)
//{
//arrErrorInformationObjLstCache = ErrorInformationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngErrorID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsErrorInformationEN GetObjByErrorIDCache(long lngErrorID)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsErrorInformationEN._CurrTabName);
List<clsErrorInformationEN> arrErrorInformationObjLstCache = GetObjLstCache();
IEnumerable <clsErrorInformationEN> arrErrorInformationObjLst_Sel =
arrErrorInformationObjLstCache
.Where(x=> x.ErrorID == lngErrorID 
);
if (arrErrorInformationObjLst_Sel.Count() == 0)
{
   clsErrorInformationEN obj = clsErrorInformationBL.GetObjByErrorID(lngErrorID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrErrorInformationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsErrorInformationEN> GetAllErrorInformationObjLstCache()
{
//获取缓存中的对象列表
List<clsErrorInformationEN> arrErrorInformationObjLstCache = GetObjLstCache(); 
return arrErrorInformationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsErrorInformationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsErrorInformationEN._CurrTabName);
List<clsErrorInformationEN> arrErrorInformationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrErrorInformationObjLstCache;
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
string strKey = string.Format("{0}", clsErrorInformationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsErrorInformationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsErrorInformationEN._RefreshTimeLst.Count == 0) return "";
return clsErrorInformationEN._RefreshTimeLst[clsErrorInformationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsErrorInformationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsErrorInformationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsErrorInformationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsErrorInformationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ErrorInformation(错误)
 /// 唯一性条件:UserId_FunctionName_ErrorInformation_PageName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objErrorInformationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsErrorInformationEN objErrorInformationEN)
{
//检测记录是否存在
string strResult = ErrorInformationDA.GetUniCondStr(objErrorInformationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngErrorID)
{
if (strInFldName != conErrorInformation.ErrorID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conErrorInformation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conErrorInformation._AttributeName));
throw new Exception(strMsg);
}
var objErrorInformation = clsErrorInformationBL.GetObjByErrorIDCache(lngErrorID);
if (objErrorInformation == null) return "";
return objErrorInformation[strOutFldName].ToString();
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
int intRecCount = clsErrorInformationDA.GetRecCount(strTabName);
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
int intRecCount = clsErrorInformationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsErrorInformationDA.GetRecCount();
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
int intRecCount = clsErrorInformationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objErrorInformationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsErrorInformationEN objErrorInformationCond)
{
List<clsErrorInformationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsErrorInformationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conErrorInformation._AttributeName)
{
if (objErrorInformationCond.IsUpdated(strFldName) == false) continue;
if (objErrorInformationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objErrorInformationCond[strFldName].ToString());
}
else
{
if (objErrorInformationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objErrorInformationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objErrorInformationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objErrorInformationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objErrorInformationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objErrorInformationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objErrorInformationCond[strFldName]));
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
 List<string> arrList = clsErrorInformationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ErrorInformationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ErrorInformationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ErrorInformationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsErrorInformationDA.SetFldValue(clsErrorInformationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ErrorInformationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsErrorInformationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsErrorInformationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsErrorInformationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ErrorInformation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**错误流水号*/ 
 strCreateTabCode.Append(" ErrorID bigint primary key identity, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FunctionName varchar(200) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrorInformation varchar(5000) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**创建时间*/ 
 strCreateTabCode.Append(" CreateTime datetime Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ErrorInformation : clsCommFun4BL
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
clsErrorInformationBL.ReFreshThisCache();
}
}

}