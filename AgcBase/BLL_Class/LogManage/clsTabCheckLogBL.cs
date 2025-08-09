
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckLogBL
 表名:TabCheckLog(00050190)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsTabCheckLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckLogEN GetObj(this K_mId_TabCheckLog myKey)
{
clsTabCheckLogEN objTabCheckLogEN = clsTabCheckLogBL.TabCheckLogDA.GetObjBymId(myKey.Value);
return objTabCheckLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabCheckLogEN objTabCheckLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckLogEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],设置人 = [{1}]的数据已经存在!(in clsTabCheckLogBL.AddNewRecord)", objTabCheckLogEN.PrjId,objTabCheckLogEN.SetUserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabCheckLogBL.TabCheckLogDA.AddNewRecordBySQL2(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTabCheckLogEN objTabCheckLogEN, bool bolIsNeedCheckUniqueness = true)
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
objTabCheckLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabCheckLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],设置人(SetUserId)=[{1}])已经存在,不能重复!", objTabCheckLogEN.PrjId, objTabCheckLogEN.SetUserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabCheckLogEN.AddNewRecord();
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabCheckLogEN objTabCheckLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckLogEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],设置人 = [{1}]的数据已经存在!(in clsTabCheckLogBL.AddNewRecordWithReturnKey)", objTabCheckLogEN.PrjId,objTabCheckLogEN.SetUserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabCheckLogBL.TabCheckLogDA.AddNewRecordBySQL2WithReturnKey(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetmId(this clsTabCheckLogEN objTabCheckLogEN, long lngmId, string strComparisonOp="")
	{
objTabCheckLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.mId) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.mId, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.mId] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetPrjId(this clsTabCheckLogEN objTabCheckLogEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabCheckLog.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabCheckLog.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabCheckLog.PrjId);
}
objTabCheckLogEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.PrjId) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.PrjId, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.PrjId] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetSetDate(this clsTabCheckLogEN objTabCheckLogEN, string strSetDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSetDate, conTabCheckLog.SetDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSetDate, 20, conTabCheckLog.SetDate);
}
objTabCheckLogEN.SetDate = strSetDate; //设置日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.SetDate) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.SetDate, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.SetDate] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetSetUserId(this clsTabCheckLogEN objTabCheckLogEN, string strSetUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSetUserId, conTabCheckLog.SetUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSetUserId, 20, conTabCheckLog.SetUserId);
}
objTabCheckLogEN.SetUserId = strSetUserId; //设置人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.SetUserId) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.SetUserId, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.SetUserId] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetStartDate(this clsTabCheckLogEN objTabCheckLogEN, string strStartDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStartDate, conTabCheckLog.StartDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, conTabCheckLog.StartDate);
}
objTabCheckLogEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.StartDate) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.StartDate, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.StartDate] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetFinishDate(this clsTabCheckLogEN objTabCheckLogEN, string strFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFinishDate, conTabCheckLog.FinishDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFinishDate, 20, conTabCheckLog.FinishDate);
}
objTabCheckLogEN.FinishDate = strFinishDate; //完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.FinishDate) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.FinishDate, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.FinishDate] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetCurrStatus(this clsTabCheckLogEN objTabCheckLogEN, string strCurrStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrStatus, conTabCheckLog.CurrStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrStatus, 20, conTabCheckLog.CurrStatus);
}
objTabCheckLogEN.CurrStatus = strCurrStatus; //状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.CurrStatus) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.CurrStatus, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.CurrStatus] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckLogEN SetMemo(this clsTabCheckLogEN objTabCheckLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabCheckLog.Memo);
}
objTabCheckLogEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckLogEN.dicFldComparisonOp.ContainsKey(conTabCheckLog.Memo) == false)
{
objTabCheckLogEN.dicFldComparisonOp.Add(conTabCheckLog.Memo, strComparisonOp);
}
else
{
objTabCheckLogEN.dicFldComparisonOp[conTabCheckLog.Memo] = strComparisonOp;
}
}
return objTabCheckLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabCheckLogEN objTabCheckLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabCheckLogEN.CheckPropertyNew();
clsTabCheckLogEN objTabCheckLogCond = new clsTabCheckLogEN();
string strCondition = objTabCheckLogCond
.SetmId(objTabCheckLogEN.mId, "<>")
.SetPrjId(objTabCheckLogEN.PrjId, "=")
.SetSetUserId(objTabCheckLogEN.SetUserId, "=")
.GetCombineCondition();
objTabCheckLogEN._IsCheckProperty = true;
bool bolIsExist = clsTabCheckLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_SetUserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabCheckLogEN.Update();
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
 /// <param name = "objTabCheckLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabCheckLogEN objTabCheckLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabCheckLogEN objTabCheckLogCond = new clsTabCheckLogEN();
string strCondition = objTabCheckLogCond
.SetPrjId(objTabCheckLog.PrjId, "=")
.SetSetUserId(objTabCheckLog.SetUserId, "=")
.GetCombineCondition();
objTabCheckLog._IsCheckProperty = true;
bool bolIsExist = clsTabCheckLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabCheckLog.mId = clsTabCheckLogBL.GetFirstID_S(strCondition);
objTabCheckLog.UpdateWithCondition(strCondition);
}
else
{
objTabCheckLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckLogEN objTabCheckLogEN)
{
 if (objTabCheckLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckLogBL.TabCheckLogDA.UpdateBySql2(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckLogEN objTabCheckLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabCheckLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckLogBL.TabCheckLogDA.UpdateBySql2(objTabCheckLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckLogEN objTabCheckLogEN, string strWhereCond)
{
try
{
bool bolResult = clsTabCheckLogBL.TabCheckLogDA.UpdateBySqlWithCondition(objTabCheckLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckLogEN objTabCheckLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabCheckLogBL.TabCheckLogDA.UpdateBySqlWithConditionTransaction(objTabCheckLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabCheckLogEN objTabCheckLogEN)
{
try
{
int intRecNum = clsTabCheckLogBL.TabCheckLogDA.DelRecord(objTabCheckLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogENS">源对象</param>
 /// <param name = "objTabCheckLogENT">目标对象</param>
 public static void CopyTo(this clsTabCheckLogEN objTabCheckLogENS, clsTabCheckLogEN objTabCheckLogENT)
{
try
{
objTabCheckLogENT.mId = objTabCheckLogENS.mId; //mId
objTabCheckLogENT.PrjId = objTabCheckLogENS.PrjId; //工程Id
objTabCheckLogENT.SetDate = objTabCheckLogENS.SetDate; //设置日期
objTabCheckLogENT.SetUserId = objTabCheckLogENS.SetUserId; //设置人
objTabCheckLogENT.StartDate = objTabCheckLogENS.StartDate; //开始日期
objTabCheckLogENT.FinishDate = objTabCheckLogENS.FinishDate; //完成日期
objTabCheckLogENT.CurrStatus = objTabCheckLogENS.CurrStatus; //状态
objTabCheckLogENT.Memo = objTabCheckLogENS.Memo; //说明
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
 /// <param name = "objTabCheckLogENS">源对象</param>
 /// <returns>目标对象=>clsTabCheckLogEN:objTabCheckLogENT</returns>
 public static clsTabCheckLogEN CopyTo(this clsTabCheckLogEN objTabCheckLogENS)
{
try
{
 clsTabCheckLogEN objTabCheckLogENT = new clsTabCheckLogEN()
{
mId = objTabCheckLogENS.mId, //mId
PrjId = objTabCheckLogENS.PrjId, //工程Id
SetDate = objTabCheckLogENS.SetDate, //设置日期
SetUserId = objTabCheckLogENS.SetUserId, //设置人
StartDate = objTabCheckLogENS.StartDate, //开始日期
FinishDate = objTabCheckLogENS.FinishDate, //完成日期
CurrStatus = objTabCheckLogENS.CurrStatus, //状态
Memo = objTabCheckLogENS.Memo, //说明
};
 return objTabCheckLogENT;
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
public static void CheckPropertyNew(this clsTabCheckLogEN objTabCheckLogEN)
{
 clsTabCheckLogBL.TabCheckLogDA.CheckPropertyNew(objTabCheckLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabCheckLogEN objTabCheckLogEN)
{
 clsTabCheckLogBL.TabCheckLogDA.CheckProperty4Condition(objTabCheckLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabCheckLogEN objTabCheckLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.mId) == true)
{
string strComparisonOpmId = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckLog.mId, objTabCheckLogCond.mId, strComparisonOpmId);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.PrjId) == true)
{
string strComparisonOpPrjId = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.PrjId, objTabCheckLogCond.PrjId, strComparisonOpPrjId);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.SetDate) == true)
{
string strComparisonOpSetDate = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.SetDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.SetDate, objTabCheckLogCond.SetDate, strComparisonOpSetDate);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.SetUserId) == true)
{
string strComparisonOpSetUserId = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.SetUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.SetUserId, objTabCheckLogCond.SetUserId, strComparisonOpSetUserId);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.StartDate) == true)
{
string strComparisonOpStartDate = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.StartDate, objTabCheckLogCond.StartDate, strComparisonOpStartDate);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.FinishDate) == true)
{
string strComparisonOpFinishDate = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.FinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.FinishDate, objTabCheckLogCond.FinishDate, strComparisonOpFinishDate);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.CurrStatus) == true)
{
string strComparisonOpCurrStatus = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.CurrStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.CurrStatus, objTabCheckLogCond.CurrStatus, strComparisonOpCurrStatus);
}
if (objTabCheckLogCond.IsUpdated(conTabCheckLog.Memo) == true)
{
string strComparisonOpMemo = objTabCheckLogCond.dicFldComparisonOp[conTabCheckLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckLog.Memo, objTabCheckLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabCheckLog(表检查日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_SetUserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabCheckLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabCheckLogEN objTabCheckLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckLogEN == null) return true;
if (objTabCheckLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckLogEN.PrjId);
 sbCondition.AppendFormat(" and SetUserId = '{0}'", objTabCheckLogEN.SetUserId);
if (clsTabCheckLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckLogEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckLogEN.PrjId);
 sbCondition.AppendFormat(" and SetUserId = '{0}'", objTabCheckLogEN.SetUserId);
if (clsTabCheckLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TabCheckLog(表检查日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_SetUserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabCheckLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabCheckLogEN objTabCheckLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckLogEN == null) return "";
if (objTabCheckLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckLogEN.PrjId);
 sbCondition.AppendFormat(" and SetUserId = '{0}'", objTabCheckLogEN.SetUserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckLogEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckLogEN.PrjId);
 sbCondition.AppendFormat(" and SetUserId = '{0}'", objTabCheckLogEN.SetUserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabCheckLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表检查日志(TabCheckLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabCheckLogBL
{
public static RelatedActions_TabCheckLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabCheckLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabCheckLogDA TabCheckLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabCheckLogDA();
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
 public clsTabCheckLogBL()
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
if (string.IsNullOrEmpty(clsTabCheckLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabCheckLogEN._ConnectString);
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
public static DataTable GetDataTable_TabCheckLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabCheckLogDA.GetDataTable_TabCheckLog(strWhereCond);
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
objDT = TabCheckLogDA.GetDataTable(strWhereCond);
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
objDT = TabCheckLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabCheckLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabCheckLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabCheckLogDA.GetDataTable_Top(objTopPara);
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
objDT = TabCheckLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabCheckLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabCheckLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabCheckLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabCheckLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsTabCheckLogEN._CurrTabName);
List<clsTabCheckLogEN> arrTabCheckLogObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckLogEN> arrTabCheckLogObjLst_Sel =
arrTabCheckLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTabCheckLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckLogEN> GetObjLst(string strWhereCond)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
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
public static List<clsTabCheckLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabCheckLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabCheckLogEN> GetSubObjLstCache(clsTabCheckLogEN objTabCheckLogCond)
{
List<clsTabCheckLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckLog._AttributeName)
{
if (objTabCheckLogCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckLogCond[strFldName].ToString());
}
else
{
if (objTabCheckLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckLogCond[strFldName]));
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
public static List<clsTabCheckLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
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
public static List<clsTabCheckLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
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
List<clsTabCheckLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabCheckLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabCheckLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
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
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
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
public static List<clsTabCheckLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabCheckLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabCheckLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
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
public static List<clsTabCheckLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabCheckLogEN> arrObjLst = new List<clsTabCheckLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckLogEN objTabCheckLogEN = new clsTabCheckLogEN();
try
{
objTabCheckLogEN.mId = Int32.Parse(objRow[conTabCheckLog.mId].ToString().Trim()); //mId
objTabCheckLogEN.PrjId = objRow[conTabCheckLog.PrjId].ToString().Trim(); //工程Id
objTabCheckLogEN.SetDate = objRow[conTabCheckLog.SetDate].ToString().Trim(); //设置日期
objTabCheckLogEN.SetUserId = objRow[conTabCheckLog.SetUserId].ToString().Trim(); //设置人
objTabCheckLogEN.StartDate = objRow[conTabCheckLog.StartDate].ToString().Trim(); //开始日期
objTabCheckLogEN.FinishDate = objRow[conTabCheckLog.FinishDate].ToString().Trim(); //完成日期
objTabCheckLogEN.CurrStatus = objRow[conTabCheckLog.CurrStatus].ToString().Trim(); //状态
objTabCheckLogEN.Memo = objRow[conTabCheckLog.Memo] == DBNull.Value ? null : objRow[conTabCheckLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabCheckLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabCheckLog(ref clsTabCheckLogEN objTabCheckLogEN)
{
bool bolResult = TabCheckLogDA.GetTabCheckLog(ref objTabCheckLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckLogEN GetObjBymId(long lngmId)
{
clsTabCheckLogEN objTabCheckLogEN = TabCheckLogDA.GetObjBymId(lngmId);
return objTabCheckLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabCheckLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabCheckLogEN objTabCheckLogEN = TabCheckLogDA.GetFirstObj(strWhereCond);
 return objTabCheckLogEN;
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
public static clsTabCheckLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabCheckLogEN objTabCheckLogEN = TabCheckLogDA.GetObjByDataRow(objRow);
 return objTabCheckLogEN;
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
public static clsTabCheckLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabCheckLogEN objTabCheckLogEN = TabCheckLogDA.GetObjByDataRow(objRow);
 return objTabCheckLogEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstTabCheckLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckLogEN GetObjBymIdFromList(long lngmId, List<clsTabCheckLogEN> lstTabCheckLogObjLst)
{
foreach (clsTabCheckLogEN objTabCheckLogEN in lstTabCheckLogObjLst)
{
if (objTabCheckLogEN.mId == lngmId)
{
return objTabCheckLogEN;
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
 long lngmId;
 try
 {
 lngmId = new clsTabCheckLogDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = TabCheckLogDA.GetID(strWhereCond);
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
bool bolIsExist = TabCheckLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = TabCheckLogDA.IsExist(lngmId);
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
 bolIsExist = clsTabCheckLogDA.IsExistTable();
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
 bolIsExist = TabCheckLogDA.IsExistTable(strTabName);
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabCheckLogEN objTabCheckLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],设置人 = [{1}]的数据已经存在!(in clsTabCheckLogBL.AddNewRecordBySql2)", objTabCheckLogEN.PrjId,objTabCheckLogEN.SetUserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabCheckLogDA.AddNewRecordBySQL2(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabCheckLogEN objTabCheckLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],设置人 = [{1}]的数据已经存在!(in clsTabCheckLogBL.AddNewRecordBySql2WithReturnKey)", objTabCheckLogEN.PrjId,objTabCheckLogEN.SetUserId);
throw new Exception(strMsg);
}
try
{
string strKey = TabCheckLogDA.AddNewRecordBySQL2WithReturnKey(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabCheckLogEN objTabCheckLogEN)
{
try
{
bool bolResult = TabCheckLogDA.Update(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "objTabCheckLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabCheckLogEN objTabCheckLogEN)
{
 if (objTabCheckLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabCheckLogDA.UpdateBySql2(objTabCheckLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckLogBL.ReFreshCache();

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsTabCheckLogEN objTabCheckLogEN = clsTabCheckLogBL.GetObjBymId(lngmId);

if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(objTabCheckLogEN.mId, "SetUpdDate");
}
if (objTabCheckLogEN != null)
{
int intRecNum = TabCheckLogDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckLogDA.GetSpecSQLObj();
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
//删除与表:[TabCheckLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabCheckLog.mId,
//lngmId);
//        clsTabCheckLogBL.DelTabCheckLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabCheckLogBL.relatedActions != null)
{
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TabCheckLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabCheckLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTabCheckLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = TabCheckLogDA.DelTabCheckLog(arrmIdLst);
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
public static int DelTabCheckLogsByCond(string strWhereCond)
{
try
{
if (clsTabCheckLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTabCheckLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = TabCheckLogDA.DelTabCheckLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabCheckLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckLogDA.GetSpecSQLObj();
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
//删除与表:[TabCheckLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabCheckLogENS">源对象</param>
 /// <param name = "objTabCheckLogENT">目标对象</param>
 public static void CopyTo(clsTabCheckLogEN objTabCheckLogENS, clsTabCheckLogEN objTabCheckLogENT)
{
try
{
objTabCheckLogENT.mId = objTabCheckLogENS.mId; //mId
objTabCheckLogENT.PrjId = objTabCheckLogENS.PrjId; //工程Id
objTabCheckLogENT.SetDate = objTabCheckLogENS.SetDate; //设置日期
objTabCheckLogENT.SetUserId = objTabCheckLogENS.SetUserId; //设置人
objTabCheckLogENT.StartDate = objTabCheckLogENS.StartDate; //开始日期
objTabCheckLogENT.FinishDate = objTabCheckLogENS.FinishDate; //完成日期
objTabCheckLogENT.CurrStatus = objTabCheckLogENS.CurrStatus; //状态
objTabCheckLogENT.Memo = objTabCheckLogENS.Memo; //说明
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
 /// <param name = "objTabCheckLogEN">源简化对象</param>
 public static void SetUpdFlag(clsTabCheckLogEN objTabCheckLogEN)
{
try
{
objTabCheckLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabCheckLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabCheckLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.mId = objTabCheckLogEN.mId; //mId
}
if (arrFldSet.Contains(conTabCheckLog.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.PrjId = objTabCheckLogEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabCheckLog.SetDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.SetDate = objTabCheckLogEN.SetDate; //设置日期
}
if (arrFldSet.Contains(conTabCheckLog.SetUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.SetUserId = objTabCheckLogEN.SetUserId; //设置人
}
if (arrFldSet.Contains(conTabCheckLog.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.StartDate = objTabCheckLogEN.StartDate; //开始日期
}
if (arrFldSet.Contains(conTabCheckLog.FinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.FinishDate = objTabCheckLogEN.FinishDate; //完成日期
}
if (arrFldSet.Contains(conTabCheckLog.CurrStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.CurrStatus = objTabCheckLogEN.CurrStatus; //状态
}
if (arrFldSet.Contains(conTabCheckLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckLogEN.Memo = objTabCheckLogEN.Memo == "[null]" ? null :  objTabCheckLogEN.Memo; //说明
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
 /// <param name = "objTabCheckLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabCheckLogEN objTabCheckLogEN)
{
try
{
if (objTabCheckLogEN.Memo == "[null]") objTabCheckLogEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTabCheckLogEN objTabCheckLogEN)
{
 TabCheckLogDA.CheckPropertyNew(objTabCheckLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabCheckLogEN objTabCheckLogEN)
{
 TabCheckLogDA.CheckProperty4Condition(objTabCheckLogEN);
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
if (clsTabCheckLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckLogBL没有刷新缓存机制(clsTabCheckLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTabCheckLogObjLstCache == null)
//{
//arrTabCheckLogObjLstCache = TabCheckLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTabCheckLogEN._CurrTabName);
List<clsTabCheckLogEN> arrTabCheckLogObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckLogEN> arrTabCheckLogObjLst_Sel =
arrTabCheckLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTabCheckLogObjLst_Sel.Count() == 0)
{
   clsTabCheckLogEN obj = clsTabCheckLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTabCheckLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckLogEN> GetAllTabCheckLogObjLstCache()
{
//获取缓存中的对象列表
List<clsTabCheckLogEN> arrTabCheckLogObjLstCache = GetObjLstCache(); 
return arrTabCheckLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTabCheckLogEN._CurrTabName);
List<clsTabCheckLogEN> arrTabCheckLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTabCheckLogObjLstCache;
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
string strKey = string.Format("{0}", clsTabCheckLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabCheckLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabCheckLogEN._RefreshTimeLst.Count == 0) return "";
return clsTabCheckLogEN._RefreshTimeLst[clsTabCheckLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsTabCheckLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabCheckLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabCheckLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabCheckLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabCheckLog(表检查日志)
 /// 唯一性条件:PrjId_SetUserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabCheckLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabCheckLogEN objTabCheckLogEN)
{
//检测记录是否存在
string strResult = TabCheckLogDA.GetUniCondStr(objTabCheckLogEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conTabCheckLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabCheckLog._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabCheckLog._AttributeName));
throw new Exception(strMsg);
}
var objTabCheckLog = clsTabCheckLogBL.GetObjBymIdCache(lngmId);
if (objTabCheckLog == null) return "";
return objTabCheckLog[strOutFldName].ToString();
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
int intRecCount = clsTabCheckLogDA.GetRecCount(strTabName);
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
int intRecCount = clsTabCheckLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabCheckLogDA.GetRecCount();
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
int intRecCount = clsTabCheckLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabCheckLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabCheckLogEN objTabCheckLogCond)
{
List<clsTabCheckLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckLog._AttributeName)
{
if (objTabCheckLogCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckLogCond[strFldName].ToString());
}
else
{
if (objTabCheckLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckLogCond[strFldName]));
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
 List<string> arrList = clsTabCheckLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabCheckLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabCheckLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabCheckLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabCheckLogDA.SetFldValue(clsTabCheckLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabCheckLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabCheckLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabCheckLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabCheckLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabCheckLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**设置日期*/ 
 strCreateTabCode.Append(" SetDate varchar(20) not Null, "); 
 // /**设置人*/ 
 strCreateTabCode.Append(" SetUserId varchar(20) not Null, "); 
 // /**开始日期*/ 
 strCreateTabCode.Append(" StartDate varchar(20) not Null, "); 
 // /**完成日期*/ 
 strCreateTabCode.Append(" FinishDate varchar(20) not Null, "); 
 // /**状态*/ 
 strCreateTabCode.Append(" CurrStatus varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 表检查日志(TabCheckLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabCheckLog : clsCommFun4BL
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
clsTabCheckLogBL.ReFreshThisCache();
}
}

}