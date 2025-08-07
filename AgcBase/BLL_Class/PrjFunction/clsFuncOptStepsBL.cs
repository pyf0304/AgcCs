
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncOptStepsBL
 表名:FuncOptSteps(00050062)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsFuncOptStepsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncOptStepsEN GetObj(this K_mId_FuncOptSteps myKey)
{
clsFuncOptStepsEN objFuncOptStepsEN = clsFuncOptStepsBL.FuncOptStepsDA.GetObjBymId(myKey.Value);
return objFuncOptStepsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncOptStepsEN objFuncOptStepsEN)
{
if (CheckUniqueness_FuncId_StepIndex_StepName(objFuncOptStepsEN) == false)
{
var strMsg = string.Format("记录已经存在!函数ID = [{0}],StepIndex = [{1}],StepName = [{2}]的数据已经存在!(in clsFuncOptStepsBL.AddNewRecord)", objFuncOptStepsEN.FuncId,objFuncOptStepsEN.StepIndex,objFuncOptStepsEN.StepName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFuncOptStepsBL.FuncOptStepsDA.AddNewRecordBySQL2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFuncOptStepsEN objFuncOptStepsEN)
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
objFuncOptStepsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objFuncOptStepsEN. CheckUniqueness_FuncId_StepIndex_StepName() == false)
{
strMsg = string.Format("(函数ID(FuncId)=[{0}],StepIndex(StepIndex)=[{1}],StepName(StepName)=[{2}])已经存在，不能重复!", objFuncOptStepsEN.FuncId, objFuncOptStepsEN.StepIndex, objFuncOptStepsEN.StepName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFuncOptStepsEN.AddNewRecord();
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncOptStepsEN objFuncOptStepsEN)
{
if (CheckUniqueness_FuncId_StepIndex_StepName(objFuncOptStepsEN) == false)
{
var strMsg = string.Format("记录已经存在!函数ID = [{0}],StepIndex = [{1}],StepName = [{2}]的数据已经存在!(in clsFuncOptStepsBL.AddNewRecordWithReturnKey)", objFuncOptStepsEN.FuncId,objFuncOptStepsEN.StepIndex,objFuncOptStepsEN.StepName);
throw new Exception(strMsg);
}
try
{
string strKey = clsFuncOptStepsBL.FuncOptStepsDA.AddNewRecordBySQL2WithReturnKey(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetmId(this clsFuncOptStepsEN objFuncOptStepsEN, long lngmId, string strComparisonOp="")
	{
objFuncOptStepsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.mId) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.mId, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.mId] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetFuncId(this clsFuncOptStepsEN objFuncOptStepsEN, string strFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId, conFuncOptSteps.FuncId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId, 10, conFuncOptSteps.FuncId);
}
objFuncOptStepsEN.FuncId = strFuncId; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.FuncId) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.FuncId, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.FuncId] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetStepIndex(this clsFuncOptStepsEN objFuncOptStepsEN, int intStepIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStepIndex, conFuncOptSteps.StepIndex);
objFuncOptStepsEN.StepIndex = intStepIndex; //StepIndex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.StepIndex) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.StepIndex, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.StepIndex] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetStepName(this clsFuncOptStepsEN objFuncOptStepsEN, string strStepName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStepName, conFuncOptSteps.StepName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStepName, 50, conFuncOptSteps.StepName);
}
objFuncOptStepsEN.StepName = strStepName; //StepName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.StepName) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.StepName, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.StepName] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetStepCode(this clsFuncOptStepsEN objFuncOptStepsEN, string strStepCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStepCode, 1000, conFuncOptSteps.StepCode);
}
objFuncOptStepsEN.StepCode = strStepCode; //StepCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.StepCode) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.StepCode, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.StepCode] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetStepDetail(this clsFuncOptStepsEN objFuncOptStepsEN, string strStepDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStepDetail, 1000, conFuncOptSteps.StepDetail);
}
objFuncOptStepsEN.StepDetail = strStepDetail; //StepDetail
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.StepDetail) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.StepDetail, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.StepDetail] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFuncOptStepsEN SetIsTemplate(this clsFuncOptStepsEN objFuncOptStepsEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conFuncOptSteps.IsTemplate);
objFuncOptStepsEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncOptStepsEN.dicFldComparisonOp.ContainsKey(conFuncOptSteps.IsTemplate) == false)
{
objFuncOptStepsEN.dicFldComparisonOp.Add(conFuncOptSteps.IsTemplate, strComparisonOp);
}
else
{
objFuncOptStepsEN.dicFldComparisonOp[conFuncOptSteps.IsTemplate] = strComparisonOp;
}
}
return objFuncOptStepsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncOptStepsEN objFuncOptStepsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncOptStepsEN.CheckPropertyNew();
clsFuncOptStepsEN objFuncOptStepsCond = new clsFuncOptStepsEN();
string strCondition = objFuncOptStepsCond
.SetmId(objFuncOptStepsEN.mId, "<>")
.SetFuncId(objFuncOptStepsEN.FuncId, "=")
.SetStepIndex(objFuncOptStepsEN.StepIndex, "=")
.SetStepName(objFuncOptStepsEN.StepName, "=")
.GetCombineCondition();
objFuncOptStepsEN._IsCheckProperty = true;
bool bolIsExist = clsFuncOptStepsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncId_StepIndex_StepName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncOptStepsEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objFuncOptSteps">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFuncOptStepsEN objFuncOptSteps)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFuncOptStepsEN objFuncOptStepsCond = new clsFuncOptStepsEN();
string strCondition = objFuncOptStepsCond
.SetFuncId(objFuncOptSteps.FuncId, "=")
.SetStepIndex(objFuncOptSteps.StepIndex, "=")
.SetStepName(objFuncOptSteps.StepName, "=")
.GetCombineCondition();
objFuncOptSteps._IsCheckProperty = true;
bool bolIsExist = clsFuncOptStepsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFuncOptSteps.mId = clsFuncOptStepsBL.GetFirstID_S(strCondition);
objFuncOptSteps.UpdateWithCondition(strCondition);
}
else
{
objFuncOptSteps.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncOptStepsBL.FuncOptStepsDA.UpdateBySql2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncOptStepsEN objFuncOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFuncOptStepsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncOptStepsBL.FuncOptStepsDA.UpdateBySql2(objFuncOptStepsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncOptStepsEN objFuncOptStepsEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncOptStepsBL.FuncOptStepsDA.UpdateBySqlWithCondition(objFuncOptStepsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncOptStepsEN objFuncOptStepsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncOptStepsBL.FuncOptStepsDA.UpdateBySqlWithConditionTransaction(objFuncOptStepsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
public static int Delete(this clsFuncOptStepsEN objFuncOptStepsEN)
{
try
{
int intRecNum = clsFuncOptStepsBL.FuncOptStepsDA.DelRecord(objFuncOptStepsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsENS">源对象</param>
 /// <param name = "objFuncOptStepsENT">目标对象</param>
 public static void CopyTo(this clsFuncOptStepsEN objFuncOptStepsENS, clsFuncOptStepsEN objFuncOptStepsENT)
{
try
{
objFuncOptStepsENT.mId = objFuncOptStepsENS.mId; //mId
objFuncOptStepsENT.FuncId = objFuncOptStepsENS.FuncId; //函数ID
objFuncOptStepsENT.StepIndex = objFuncOptStepsENS.StepIndex; //StepIndex
objFuncOptStepsENT.StepName = objFuncOptStepsENS.StepName; //StepName
objFuncOptStepsENT.StepCode = objFuncOptStepsENS.StepCode; //StepCode
objFuncOptStepsENT.StepDetail = objFuncOptStepsENS.StepDetail; //StepDetail
objFuncOptStepsENT.IsTemplate = objFuncOptStepsENS.IsTemplate; //是否模板
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
 /// <param name = "objFuncOptStepsENS">源对象</param>
 /// <returns>目标对象=>clsFuncOptStepsEN:objFuncOptStepsENT</returns>
 public static clsFuncOptStepsEN CopyTo(this clsFuncOptStepsEN objFuncOptStepsENS)
{
try
{
 clsFuncOptStepsEN objFuncOptStepsENT = new clsFuncOptStepsEN()
{
mId = objFuncOptStepsENS.mId, //mId
FuncId = objFuncOptStepsENS.FuncId, //函数ID
StepIndex = objFuncOptStepsENS.StepIndex, //StepIndex
StepName = objFuncOptStepsENS.StepName, //StepName
StepCode = objFuncOptStepsENS.StepCode, //StepCode
StepDetail = objFuncOptStepsENS.StepDetail, //StepDetail
IsTemplate = objFuncOptStepsENS.IsTemplate, //是否模板
};
 return objFuncOptStepsENT;
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
public static void CheckPropertyNew(this clsFuncOptStepsEN objFuncOptStepsEN)
{
 clsFuncOptStepsBL.FuncOptStepsDA.CheckPropertyNew(objFuncOptStepsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncOptStepsEN objFuncOptStepsEN)
{
 clsFuncOptStepsBL.FuncOptStepsDA.CheckProperty4Condition(objFuncOptStepsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncOptStepsEN objFuncOptStepsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.mId) == true)
{
string strComparisonOpmId = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncOptSteps.mId, objFuncOptStepsCond.mId, strComparisonOpmId);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.FuncId) == true)
{
string strComparisonOpFuncId = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.FuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncOptSteps.FuncId, objFuncOptStepsCond.FuncId, strComparisonOpFuncId);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.StepIndex) == true)
{
string strComparisonOpStepIndex = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.StepIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncOptSteps.StepIndex, objFuncOptStepsCond.StepIndex, strComparisonOpStepIndex);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.StepName) == true)
{
string strComparisonOpStepName = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.StepName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncOptSteps.StepName, objFuncOptStepsCond.StepName, strComparisonOpStepName);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.StepCode) == true)
{
string strComparisonOpStepCode = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.StepCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncOptSteps.StepCode, objFuncOptStepsCond.StepCode, strComparisonOpStepCode);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.StepDetail) == true)
{
string strComparisonOpStepDetail = objFuncOptStepsCond.dicFldComparisonOp[conFuncOptSteps.StepDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncOptSteps.StepDetail, objFuncOptStepsCond.StepDetail, strComparisonOpStepDetail);
}
if (objFuncOptStepsCond.IsUpdated(conFuncOptSteps.IsTemplate) == true)
{
if (objFuncOptStepsCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFuncOptSteps.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFuncOptSteps.IsTemplate);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FuncOptSteps(函数操作步骤), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_FuncId_StepIndex_StepName(this clsFuncOptStepsEN objFuncOptStepsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFuncOptStepsEN == null) return true;
if (objFuncOptStepsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncId = '{0}'", objFuncOptStepsEN.FuncId);
 sbCondition.AppendFormat(" and StepIndex = '{0}'", objFuncOptStepsEN.StepIndex);
 sbCondition.AppendFormat(" and StepName = '{0}'", objFuncOptStepsEN.StepName);
if (clsFuncOptStepsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFuncOptStepsEN.mId);
 sbCondition.AppendFormat(" and FuncId = '{0}'", objFuncOptStepsEN.FuncId);
 sbCondition.AppendFormat(" and StepIndex = '{0}'", objFuncOptStepsEN.StepIndex);
 sbCondition.AppendFormat(" and StepName = '{0}'", objFuncOptStepsEN.StepName);
if (clsFuncOptStepsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--FuncOptSteps(函数操作步骤), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrFuncId_StepIndex_StepName(this clsFuncOptStepsEN objFuncOptStepsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncOptStepsEN == null) return "";
if (objFuncOptStepsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncId = '{0}'", objFuncOptStepsEN.FuncId);
 sbCondition.AppendFormat(" and StepIndex = '{0}'", objFuncOptStepsEN.StepIndex);
 sbCondition.AppendFormat(" and StepName = '{0}'", objFuncOptStepsEN.StepName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFuncOptStepsEN.mId);
 sbCondition.AppendFormat(" and FuncId = '{0}'", objFuncOptStepsEN.FuncId);
 sbCondition.AppendFormat(" and StepIndex = '{0}'", objFuncOptStepsEN.StepIndex);
 sbCondition.AppendFormat(" and StepName = '{0}'", objFuncOptStepsEN.StepName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncOptSteps
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数操作步骤(FuncOptSteps)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncOptStepsBL
{
public static RelatedActions_FuncOptSteps relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "FuncOptStepsListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "FuncOptStepsList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsFuncOptStepsEN> arrFuncOptStepsObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncOptStepsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncOptStepsDA FuncOptStepsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncOptStepsDA();
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
 public clsFuncOptStepsBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsFuncOptStepsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncOptStepsEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = FuncOptStepsDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = FuncOptStepsDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = FuncOptStepsDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_FuncOptSteps(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTable_FuncOptSteps(strWhereCond);
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
objDT = FuncOptStepsDA.GetDataTable(strWhereCond);
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
objDT = FuncOptStepsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncOptStepsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncOptStepsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncOptStepsDA.GetDataTable_Top(objTopPara);
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
objDT = FuncOptStepsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = FuncOptStepsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncOptStepsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FuncOptStepsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
public static List<clsFuncOptStepsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
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
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncOptStepsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFuncOptStepsEN._CurrTabName);
List<clsFuncOptStepsEN> arrFuncOptStepsObjLstCache = GetObjLstCache();
IEnumerable <clsFuncOptStepsEN> arrFuncOptStepsObjLst_Sel =
arrFuncOptStepsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFuncOptStepsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLst(string strWhereCond)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
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
public static List<clsFuncOptStepsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncOptStepsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncOptStepsEN> GetSubObjLstCache(clsFuncOptStepsEN objFuncOptStepsCond)
{
List<clsFuncOptStepsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncOptStepsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncOptSteps.AttributeName)
{
if (objFuncOptStepsCond.IsUpdated(strFldName) == false) continue;
if (objFuncOptStepsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else
{
if (objFuncOptStepsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncOptStepsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncOptStepsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
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
public static List<clsFuncOptStepsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
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
public static List<clsFuncOptStepsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
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
List<clsFuncOptStepsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncOptStepsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncOptStepsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
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
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
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
public static List<clsFuncOptStepsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncOptStepsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
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
public static List<clsFuncOptStepsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsFuncOptStepsEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsFuncOptStepsEN objFuncOptStepsCond, string strOrderBy)
{
List<clsFuncOptStepsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncOptStepsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncOptSteps.AttributeName)
{
if (objFuncOptStepsCond.IsUpdated(strFldName) == false) continue;
if (objFuncOptStepsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else
{
if (objFuncOptStepsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncOptStepsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncOptStepsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsFuncOptStepsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsFuncOptStepsEN objFuncOptStepsCond = JsonConvert.DeserializeObject<clsFuncOptStepsEN>(objPagerPara.whereCond);
if (objFuncOptStepsCond.sfFldComparisonOp == null)
{
objFuncOptStepsCond.dicFldComparisonOp = null;
}
else
{
objFuncOptStepsCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objFuncOptStepsCond.sfFldComparisonOp);
}
clsFuncOptStepsBL.SetUpdFlag(objFuncOptStepsCond);
 try
{
CheckProperty4Condition(objFuncOptStepsCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsFuncOptStepsBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objFuncOptStepsCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncOptStepsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncOptSteps(ref clsFuncOptStepsEN objFuncOptStepsEN)
{
bool bolResult = FuncOptStepsDA.GetFuncOptSteps(ref objFuncOptStepsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncOptStepsEN GetObjBymId(long lngmId)
{
clsFuncOptStepsEN objFuncOptStepsEN = FuncOptStepsDA.GetObjBymId(lngmId);
return objFuncOptStepsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncOptStepsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncOptStepsEN objFuncOptStepsEN = FuncOptStepsDA.GetFirstObj(strWhereCond);
 return objFuncOptStepsEN;
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
public static clsFuncOptStepsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncOptStepsEN objFuncOptStepsEN = FuncOptStepsDA.GetObjByDataRow(objRow);
 return objFuncOptStepsEN;
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
public static clsFuncOptStepsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncOptStepsEN objFuncOptStepsEN = FuncOptStepsDA.GetObjByDataRow(objRow);
 return objFuncOptStepsEN;
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
 /// <param name = "lstFuncOptStepsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncOptStepsEN GetObjBymIdFromList(long lngmId, List<clsFuncOptStepsEN> lstFuncOptStepsObjLst)
{
foreach (clsFuncOptStepsEN objFuncOptStepsEN in lstFuncOptStepsObjLst)
{
if (objFuncOptStepsEN.mId == lngmId)
{
return objFuncOptStepsEN;
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
 lngmId = new clsFuncOptStepsDA().GetFirstID(strWhereCond);
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
 arrList = FuncOptStepsDA.GetID(strWhereCond);
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
bool bolIsExist = FuncOptStepsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FuncOptStepsDA.IsExist(lngmId);
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
 bolIsExist = clsFuncOptStepsDA.IsExistTable();
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
 bolIsExist = FuncOptStepsDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncOptStepsEN objFuncOptStepsEN)
{
if (objFuncOptStepsEN.CheckUniqueness_FuncId_StepIndex_StepName() == false)
{
var strMsg = string.Format("记录已经存在!函数ID = [{0}],StepIndex = [{1}],StepName = [{2}]的数据已经存在!(in clsFuncOptStepsBL.AddNewRecordBySql2)", objFuncOptStepsEN.FuncId,objFuncOptStepsEN.StepIndex,objFuncOptStepsEN.StepName);
throw new Exception(strMsg);
}
try
{
bool bolResult = FuncOptStepsDA.AddNewRecordBySQL2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncOptStepsEN objFuncOptStepsEN)
{
if (objFuncOptStepsEN.CheckUniqueness_FuncId_StepIndex_StepName() == false)
{
var strMsg = string.Format("记录已经存在!函数ID = [{0}],StepIndex = [{1}],StepName = [{2}]的数据已经存在!(in clsFuncOptStepsBL.AddNewRecordBySql2WithReturnKey)", objFuncOptStepsEN.FuncId,objFuncOptStepsEN.StepIndex,objFuncOptStepsEN.StepName);
throw new Exception(strMsg);
}
try
{
string strKey = FuncOptStepsDA.AddNewRecordBySQL2WithReturnKey(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strFuncOptStepsObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strFuncOptStepsObjXml)
{
clsFuncOptStepsEN objFuncOptStepsEN = GetObjFromXmlStr(strFuncOptStepsObjXml);
try
{
bool bolResult = FuncOptStepsDA.AddNewRecordBySQL2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncOptStepsEN objFuncOptStepsEN)
{
try
{
bool bolResult = FuncOptStepsDA.Update(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncOptStepsDA.UpdateBySql2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strFuncOptStepsObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strFuncOptStepsObjXml)
{
clsFuncOptStepsEN objFuncOptStepsEN = GetObjFromXmlStr(strFuncOptStepsObjXml);
try
{
bool bolResult = FuncOptStepsDA.UpdateBySql2(objFuncOptStepsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncOptStepsBL.ReFreshCache();

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 clsFuncOptStepsEN objFuncOptStepsEN = clsFuncOptStepsBL.GetObjBymId(lngmId);

if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(objFuncOptStepsEN.mId, "SetUpdDate");
}
if (objFuncOptStepsEN != null)
{
int intRecNum = FuncOptStepsDA.DelRecord(lngmId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
//删除与表:[FuncOptSteps]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncOptSteps.mId,
//lngmId);
//        clsFuncOptStepsBL.DelFuncOptStepssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncOptStepsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncOptStepsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
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
if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FuncOptStepsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
try
{
if (clsFuncOptStepsBL.relatedActions != null)
{
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FuncOptStepsDA.DelRecordBySP(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
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
public static int DelFuncOptStepss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFuncOptStepsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FuncOptStepsDA.DelFuncOptSteps(arrmIdLst);
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
public static int DelFuncOptStepssByCond(string strWhereCond)
{
try
{
if (clsFuncOptStepsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFuncOptStepsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FuncOptStepsDA.DelFuncOptSteps(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[FuncOptSteps]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
//删除与表:[FuncOptSteps]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncOptStepsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncOptStepsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
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
 /// <param name = "objFuncOptStepsENS">源对象</param>
 /// <param name = "objFuncOptStepsENT">目标对象</param>
 public static void CopyTo(clsFuncOptStepsEN objFuncOptStepsENS, clsFuncOptStepsEN objFuncOptStepsENT)
{
try
{
objFuncOptStepsENT.mId = objFuncOptStepsENS.mId; //mId
objFuncOptStepsENT.FuncId = objFuncOptStepsENS.FuncId; //函数ID
objFuncOptStepsENT.StepIndex = objFuncOptStepsENS.StepIndex; //StepIndex
objFuncOptStepsENT.StepName = objFuncOptStepsENS.StepName; //StepName
objFuncOptStepsENT.StepCode = objFuncOptStepsENS.StepCode; //StepCode
objFuncOptStepsENT.StepDetail = objFuncOptStepsENS.StepDetail; //StepDetail
objFuncOptStepsENT.IsTemplate = objFuncOptStepsENS.IsTemplate; //是否模板
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
 /// <param name = "objFuncOptStepsEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncOptStepsEN objFuncOptStepsEN)
{
try
{
objFuncOptStepsEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objFuncOptStepsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncOptSteps.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.mId = objFuncOptStepsEN.mId; //mId
}
if (arrFldSet.Contains(conFuncOptSteps.FuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId; //函数ID
}
if (arrFldSet.Contains(conFuncOptSteps.StepIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.StepIndex = objFuncOptStepsEN.StepIndex; //StepIndex
}
if (arrFldSet.Contains(conFuncOptSteps.StepName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName; //StepName
}
if (arrFldSet.Contains(conFuncOptSteps.StepCode, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode == "[null]" ? null :  objFuncOptStepsEN.StepCode; //StepCode
}
if (arrFldSet.Contains(conFuncOptSteps.StepDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail == "[null]" ? null :  objFuncOptStepsEN.StepDetail; //StepDetail
}
if (arrFldSet.Contains(conFuncOptSteps.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncOptStepsEN.IsTemplate = objFuncOptStepsEN.IsTemplate; //是否模板
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncOptStepsEN objFuncOptStepsEN)
{
try
{
if (objFuncOptStepsEN.StepCode == "[null]") objFuncOptStepsEN.StepCode = null; //StepCode
if (objFuncOptStepsEN.StepDetail == "[null]") objFuncOptStepsEN.StepDetail = null; //StepDetail
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsFuncOptStepsEN objFuncOptStepsEN)
{
 FuncOptStepsDA.CheckPropertyNew(objFuncOptStepsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncOptStepsEN objFuncOptStepsEN)
{
 FuncOptStepsDA.CheckProperty4Condition(objFuncOptStepsEN);
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
if (clsFuncOptStepsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncOptStepsBL没有刷新缓存机制(clsFuncOptStepsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFuncOptStepsObjLstCache == null)
//{
//arrFuncOptStepsObjLstCache = FuncOptStepsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncOptStepsEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFuncOptStepsEN._CurrTabName);
List<clsFuncOptStepsEN> arrFuncOptStepsObjLstCache = GetObjLstCache();
IEnumerable <clsFuncOptStepsEN> arrFuncOptStepsObjLst_Sel =
arrFuncOptStepsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFuncOptStepsObjLst_Sel.Count() == 0)
{
   clsFuncOptStepsEN obj = clsFuncOptStepsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFuncOptStepsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncOptStepsEN> GetAllFuncOptStepsObjLstCache()
{
//获取缓存中的对象列表
List<clsFuncOptStepsEN> arrFuncOptStepsObjLstCache = GetObjLstCache(); 
return arrFuncOptStepsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncOptStepsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFuncOptStepsEN._CurrTabName);
List<clsFuncOptStepsEN> arrFuncOptStepsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFuncOptStepsObjLstCache;
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
string strKey = string.Format("{0}", clsFuncOptStepsEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFuncOptStepsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncOptStepsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncOptStepsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FuncOptSteps(函数操作步骤)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrFuncId_StepIndex_StepName(clsFuncOptStepsEN objFuncOptStepsEN)
{
//检测记录是否存在
string strResult = FuncOptStepsDA.GetUniCondStrFuncId_StepIndex_StepName(objFuncOptStepsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstFuncOptStepsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsFuncOptStepsEN> lstFuncOptStepsObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstFuncOptStepsObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstFuncOptStepsObjLst">[clsFuncOptStepsEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsFuncOptStepsEN> lstFuncOptStepsObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsFuncOptStepsBL.listXmlNode);
writer.WriteStartElement(clsFuncOptStepsBL.itemsXmlNode);
foreach (clsFuncOptStepsEN objFuncOptStepsEN in lstFuncOptStepsObjLst)
{
clsFuncOptStepsBL.SerializeXML(writer, objFuncOptStepsEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objFuncOptStepsEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsFuncOptStepsEN objFuncOptStepsEN)
{
writer.WriteStartElement(clsFuncOptStepsBL.itemXmlNode);
 
writer.WriteElementString(conFuncOptSteps.mId, objFuncOptStepsEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objFuncOptStepsEN.FuncId != null)
{
writer.WriteElementString(conFuncOptSteps.FuncId, objFuncOptStepsEN.FuncId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conFuncOptSteps.StepIndex, objFuncOptStepsEN.StepIndex.ToString(CultureInfo.InvariantCulture));
 
if (objFuncOptStepsEN.StepName != null)
{
writer.WriteElementString(conFuncOptSteps.StepName, objFuncOptStepsEN.StepName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFuncOptStepsEN.StepCode != null)
{
writer.WriteElementString(conFuncOptSteps.StepCode, objFuncOptStepsEN.StepCode.ToString(CultureInfo.InvariantCulture));
}
 
if (objFuncOptStepsEN.StepDetail != null)
{
writer.WriteElementString(conFuncOptSteps.StepDetail, objFuncOptStepsEN.StepDetail.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conFuncOptSteps.IsTemplate, objFuncOptStepsEN.IsTemplate.ToString().ToLower(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsFuncOptStepsEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
reader.Read();
while (!(reader.Name == clsFuncOptStepsBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conFuncOptSteps.mId))
{
objFuncOptStepsEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conFuncOptSteps.FuncId))
{
objFuncOptStepsEN.FuncId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFuncOptSteps.StepIndex))
{
objFuncOptStepsEN.StepIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conFuncOptSteps.StepName))
{
objFuncOptStepsEN.StepName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFuncOptSteps.StepCode))
{
objFuncOptStepsEN.StepCode = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFuncOptSteps.StepDetail))
{
objFuncOptStepsEN.StepDetail = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFuncOptSteps.IsTemplate))
{
objFuncOptStepsEN.IsTemplate = reader.ReadElementContentAsBoolean();
}
}
return objFuncOptStepsEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strFuncOptStepsObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsFuncOptStepsEN GetObjFromXmlStr(string strFuncOptStepsObjXmlStr)
{
clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strFuncOptStepsObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsFuncOptStepsBL.itemXmlNode))
{
objFuncOptStepsEN = GetObjFromXml(reader);
return objFuncOptStepsEN;
}
}
return objFuncOptStepsEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsFuncOptStepsEN objFuncOptStepsEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objFuncOptStepsEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFuncOptSteps.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncOptSteps.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncOptSteps.AttributeName));
throw new Exception(strMsg);
}
var objFuncOptSteps = clsFuncOptStepsBL.GetObjBymIdCache(lngmId);
if (objFuncOptSteps == null) return "";
return objFuncOptSteps[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsFuncOptStepsEN objFuncOptStepsEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsFuncOptStepsEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objFuncOptStepsEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstFuncOptStepsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsFuncOptStepsEN> lstFuncOptStepsObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstFuncOptStepsObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsFuncOptStepsEN objFuncOptStepsEN in lstFuncOptStepsObjLst)
{
string strJSON_One = SerializeObjToJSON(objFuncOptStepsEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsFuncOptStepsDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncOptStepsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncOptStepsDA.GetRecCount();
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
int intRecCount = clsFuncOptStepsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncOptStepsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncOptStepsEN objFuncOptStepsCond)
{
List<clsFuncOptStepsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncOptStepsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncOptSteps.AttributeName)
{
if (objFuncOptStepsCond.IsUpdated(strFldName) == false) continue;
if (objFuncOptStepsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else
{
if (objFuncOptStepsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncOptStepsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncOptStepsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncOptStepsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncOptStepsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncOptStepsCond[strFldName]));
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
 List<string> arrList = clsFuncOptStepsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncOptStepsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncOptStepsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncOptStepsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncOptStepsDA.SetFldValue(clsFuncOptStepsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncOptStepsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncOptStepsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncOptStepsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncOptStepsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncOptSteps] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId varchar(10) not Null, "); 
 // /**StepIndex*/ 
 strCreateTabCode.Append(" StepIndex int not Null, "); 
 // /**StepName*/ 
 strCreateTabCode.Append(" StepName varchar(50) not Null, "); 
 // /**StepCode*/ 
 strCreateTabCode.Append(" StepCode varchar(1000) Null, "); 
 // /**StepDetail*/ 
 strCreateTabCode.Append(" StepDetail varchar(1000) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 函数操作步骤(FuncOptSteps)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4FuncOptSteps : clsCommFun4BL
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
clsFuncOptStepsBL.ReFreshThisCache();
}
}

}