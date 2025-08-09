
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionGroupRelaBL
 表名:FunctionGroupRela(00050328)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsFunctionGroupRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionGroupRelaEN GetObj(this K_mId_FunctionGroupRela myKey)
{
clsFunctionGroupRelaEN objFunctionGroupRelaEN = clsFunctionGroupRelaBL.FunctionGroupRelaDA.GetObjBymId(myKey.Value);
return objFunctionGroupRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionGroupRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!函数组Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionGroupRelaBL.AddNewRecord)", objFunctionGroupRelaEN.FunctionGroupId,objFunctionGroupRelaEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFunctionGroupRelaBL.FunctionGroupRelaDA.AddNewRecordBySQL2(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objFunctionGroupRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunctionGroupRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数组Id(FunctionGroupId)=[{0}],函数ID(FuncId4GC)=[{1}])已经存在,不能重复!", objFunctionGroupRelaEN.FunctionGroupId, objFunctionGroupRelaEN.FuncId4GC);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFunctionGroupRelaEN.AddNewRecord();
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionGroupRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!函数组Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionGroupRelaBL.AddNewRecordWithReturnKey)", objFunctionGroupRelaEN.FunctionGroupId,objFunctionGroupRelaEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
string strKey = clsFunctionGroupRelaBL.FunctionGroupRelaDA.AddNewRecordBySQL2WithReturnKey(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetmId(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, long lngmId, string strComparisonOp="")
	{
objFunctionGroupRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.mId) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.mId, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.mId] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetFunctionGroupId(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, conFunctionGroupRela.FunctionGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, conFunctionGroupRela.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, conFunctionGroupRela.FunctionGroupId);
}
objFunctionGroupRelaEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.FunctionGroupId) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.FunctionGroupId, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.FunctionGroupId] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetFuncId4GC(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, conFunctionGroupRela.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFunctionGroupRela.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFunctionGroupRela.FuncId4GC);
}
objFunctionGroupRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.FuncId4GC) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.FuncId4GC, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.FuncId4GC] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetUpdDate(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionGroupRela.UpdDate);
}
objFunctionGroupRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.UpdDate) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.UpdDate, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.UpdDate] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetUpdUser(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionGroupRela.UpdUser);
}
objFunctionGroupRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.UpdUser) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.UpdUser, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.UpdUser] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupRelaEN SetMemo(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionGroupRela.Memo);
}
objFunctionGroupRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(conFunctionGroupRela.Memo) == false)
{
objFunctionGroupRelaEN.dicFldComparisonOp.Add(conFunctionGroupRela.Memo, strComparisonOp);
}
else
{
objFunctionGroupRelaEN.dicFldComparisonOp[conFunctionGroupRela.Memo] = strComparisonOp;
}
}
return objFunctionGroupRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunctionGroupRelaEN.CheckPropertyNew();
clsFunctionGroupRelaEN objFunctionGroupRelaCond = new clsFunctionGroupRelaEN();
string strCondition = objFunctionGroupRelaCond
.SetmId(objFunctionGroupRelaEN.mId, "<>")
.SetFunctionGroupId(objFunctionGroupRelaEN.FunctionGroupId, "=")
.SetFuncId4GC(objFunctionGroupRelaEN.FuncId4GC, "=")
.GetCombineCondition();
objFunctionGroupRelaEN._IsCheckProperty = true;
bool bolIsExist = clsFunctionGroupRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FunctionGroupId_FuncId4GC)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunctionGroupRelaEN.Update();
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
 /// <param name = "objFunctionGroupRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunctionGroupRelaEN objFunctionGroupRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunctionGroupRelaEN objFunctionGroupRelaCond = new clsFunctionGroupRelaEN();
string strCondition = objFunctionGroupRelaCond
.SetFunctionGroupId(objFunctionGroupRela.FunctionGroupId, "=")
.SetFuncId4GC(objFunctionGroupRela.FuncId4GC, "=")
.GetCombineCondition();
objFunctionGroupRela._IsCheckProperty = true;
bool bolIsExist = clsFunctionGroupRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunctionGroupRela.mId = clsFunctionGroupRelaBL.GetFirstID_S(strCondition);
objFunctionGroupRela.UpdateWithCondition(strCondition);
}
else
{
objFunctionGroupRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 if (objFunctionGroupRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionGroupRelaBL.FunctionGroupRelaDA.UpdateBySql2(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFunctionGroupRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionGroupRelaBL.FunctionGroupRelaDA.UpdateBySql2(objFunctionGroupRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionGroupRelaBL.FunctionGroupRelaDA.UpdateBySqlWithCondition(objFunctionGroupRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionGroupRelaEN objFunctionGroupRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionGroupRelaBL.FunctionGroupRelaDA.UpdateBySqlWithConditionTransaction(objFunctionGroupRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
public static int Delete(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
try
{
int intRecNum = clsFunctionGroupRelaBL.FunctionGroupRelaDA.DelRecord(objFunctionGroupRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaENS">源对象</param>
 /// <param name = "objFunctionGroupRelaENT">目标对象</param>
 public static void CopyTo(this clsFunctionGroupRelaEN objFunctionGroupRelaENS, clsFunctionGroupRelaEN objFunctionGroupRelaENT)
{
try
{
objFunctionGroupRelaENT.mId = objFunctionGroupRelaENS.mId; //mId
objFunctionGroupRelaENT.FunctionGroupId = objFunctionGroupRelaENS.FunctionGroupId; //函数组Id
objFunctionGroupRelaENT.FuncId4GC = objFunctionGroupRelaENS.FuncId4GC; //函数ID
objFunctionGroupRelaENT.UpdDate = objFunctionGroupRelaENS.UpdDate; //修改日期
objFunctionGroupRelaENT.UpdUser = objFunctionGroupRelaENS.UpdUser; //修改者
objFunctionGroupRelaENT.Memo = objFunctionGroupRelaENS.Memo; //说明
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
 /// <param name = "objFunctionGroupRelaENS">源对象</param>
 /// <returns>目标对象=>clsFunctionGroupRelaEN:objFunctionGroupRelaENT</returns>
 public static clsFunctionGroupRelaEN CopyTo(this clsFunctionGroupRelaEN objFunctionGroupRelaENS)
{
try
{
 clsFunctionGroupRelaEN objFunctionGroupRelaENT = new clsFunctionGroupRelaEN()
{
mId = objFunctionGroupRelaENS.mId, //mId
FunctionGroupId = objFunctionGroupRelaENS.FunctionGroupId, //函数组Id
FuncId4GC = objFunctionGroupRelaENS.FuncId4GC, //函数ID
UpdDate = objFunctionGroupRelaENS.UpdDate, //修改日期
UpdUser = objFunctionGroupRelaENS.UpdUser, //修改者
Memo = objFunctionGroupRelaENS.Memo, //说明
};
 return objFunctionGroupRelaENT;
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
public static void CheckPropertyNew(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 clsFunctionGroupRelaBL.FunctionGroupRelaDA.CheckPropertyNew(objFunctionGroupRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 clsFunctionGroupRelaBL.FunctionGroupRelaDA.CheckProperty4Condition(objFunctionGroupRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionGroupRelaEN objFunctionGroupRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.mId) == true)
{
string strComparisonOpmId = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionGroupRela.mId, objFunctionGroupRelaCond.mId, strComparisonOpmId);
}
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroupRela.FunctionGroupId, objFunctionGroupRelaCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroupRela.FuncId4GC, objFunctionGroupRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroupRela.UpdDate, objFunctionGroupRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroupRela.UpdUser, objFunctionGroupRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionGroupRelaCond.IsUpdated(conFunctionGroupRela.Memo) == true)
{
string strComparisonOpMemo = objFunctionGroupRelaCond.dicFldComparisonOp[conFunctionGroupRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroupRela.Memo, objFunctionGroupRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FunctionGroupRela(函数与组关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FunctionGroupId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunctionGroupRelaEN == null) return true;
if (objFunctionGroupRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionGroupId = '{0}'", objFunctionGroupRelaEN.FunctionGroupId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionGroupRelaEN.FuncId4GC);
if (clsFunctionGroupRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionGroupRelaEN.mId);
 sbCondition.AppendFormat(" and FunctionGroupId = '{0}'", objFunctionGroupRelaEN.FunctionGroupId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionGroupRelaEN.FuncId4GC);
if (clsFunctionGroupRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FunctionGroupRela(函数与组关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FunctionGroupId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionGroupRelaEN == null) return "";
if (objFunctionGroupRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionGroupId = '{0}'", objFunctionGroupRelaEN.FunctionGroupId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionGroupRelaEN.FuncId4GC);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionGroupRelaEN.mId);
 sbCondition.AppendFormat(" and FunctionGroupId = '{0}'", objFunctionGroupRelaEN.FunctionGroupId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionGroupRelaEN.FuncId4GC);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionGroupRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数与组关系(FunctionGroupRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionGroupRelaBL
{
public static RelatedActions_FunctionGroupRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionGroupRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionGroupRelaDA FunctionGroupRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionGroupRelaDA();
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
 public clsFunctionGroupRelaBL()
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
if (string.IsNullOrEmpty(clsFunctionGroupRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionGroupRelaEN._ConnectString);
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
public static DataTable GetDataTable_FunctionGroupRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionGroupRelaDA.GetDataTable_FunctionGroupRela(strWhereCond);
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
objDT = FunctionGroupRelaDA.GetDataTable(strWhereCond);
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
objDT = FunctionGroupRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionGroupRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionGroupRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionGroupRelaDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionGroupRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFunctionGroupRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
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
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionGroupRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFunctionGroupRelaEN._CurrTabName);
List<clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLst_Sel =
arrFunctionGroupRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFunctionGroupRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetObjLst(string strWhereCond)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
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
public static List<clsFunctionGroupRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionGroupRelaEN> GetSubObjLstCache(clsFunctionGroupRelaEN objFunctionGroupRelaCond)
{
List<clsFunctionGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionGroupRela._AttributeName)
{
if (objFunctionGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objFunctionGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionGroupRelaCond[strFldName].ToString());
}
else
{
if (objFunctionGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionGroupRelaCond[strFldName]));
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
public static List<clsFunctionGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
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
public static List<clsFunctionGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
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
List<clsFunctionGroupRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionGroupRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
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
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
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
public static List<clsFunctionGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
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
public static List<clsFunctionGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionGroupRelaEN> arrObjLst = new List<clsFunctionGroupRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionGroupRelaEN objFunctionGroupRelaEN = new clsFunctionGroupRelaEN();
try
{
objFunctionGroupRelaEN.mId = Int32.Parse(objRow[conFunctionGroupRela.mId].ToString().Trim()); //mId
objFunctionGroupRelaEN.FunctionGroupId = objRow[conFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objFunctionGroupRelaEN.FuncId4GC = objRow[conFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionGroupRelaEN.UpdDate = objRow[conFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objFunctionGroupRelaEN.UpdUser = objRow[conFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objFunctionGroupRelaEN.Memo = objRow[conFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[conFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionGroupRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionGroupRela(ref clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
bool bolResult = FunctionGroupRelaDA.GetFunctionGroupRela(ref objFunctionGroupRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionGroupRelaEN GetObjBymId(long lngmId)
{
clsFunctionGroupRelaEN objFunctionGroupRelaEN = FunctionGroupRelaDA.GetObjBymId(lngmId);
return objFunctionGroupRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionGroupRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionGroupRelaEN objFunctionGroupRelaEN = FunctionGroupRelaDA.GetFirstObj(strWhereCond);
 return objFunctionGroupRelaEN;
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
public static clsFunctionGroupRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionGroupRelaEN objFunctionGroupRelaEN = FunctionGroupRelaDA.GetObjByDataRow(objRow);
 return objFunctionGroupRelaEN;
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
public static clsFunctionGroupRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionGroupRelaEN objFunctionGroupRelaEN = FunctionGroupRelaDA.GetObjByDataRow(objRow);
 return objFunctionGroupRelaEN;
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
 /// <param name = "lstFunctionGroupRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionGroupRelaEN GetObjBymIdFromList(long lngmId, List<clsFunctionGroupRelaEN> lstFunctionGroupRelaObjLst)
{
foreach (clsFunctionGroupRelaEN objFunctionGroupRelaEN in lstFunctionGroupRelaObjLst)
{
if (objFunctionGroupRelaEN.mId == lngmId)
{
return objFunctionGroupRelaEN;
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
 lngmId = new clsFunctionGroupRelaDA().GetFirstID(strWhereCond);
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
 arrList = FunctionGroupRelaDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionGroupRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FunctionGroupRelaDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsFunctionGroupRelaEN objFunctionGroupRelaEN = clsFunctionGroupRelaBL.GetObjBymId(lngmId);
objFunctionGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunctionGroupRelaEN.UpdUser = strOpUser;
return clsFunctionGroupRelaBL.UpdateBySql2(objFunctionGroupRelaEN);
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
 bolIsExist = clsFunctionGroupRelaDA.IsExistTable();
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
 bolIsExist = FunctionGroupRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionGroupRelaEN objFunctionGroupRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionGroupRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数组Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionGroupRelaBL.AddNewRecordBySql2)", objFunctionGroupRelaEN.FunctionGroupId,objFunctionGroupRelaEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
bool bolResult = FunctionGroupRelaDA.AddNewRecordBySQL2(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionGroupRelaEN objFunctionGroupRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionGroupRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数组Id = [{0}],函数ID = [{1}]的数据已经存在!(in clsFunctionGroupRelaBL.AddNewRecordBySql2WithReturnKey)", objFunctionGroupRelaEN.FunctionGroupId,objFunctionGroupRelaEN.FuncId4GC);
throw new Exception(strMsg);
}
try
{
string strKey = FunctionGroupRelaDA.AddNewRecordBySQL2WithReturnKey(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
try
{
bool bolResult = FunctionGroupRelaDA.Update(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 /// <param name = "objFunctionGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 if (objFunctionGroupRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionGroupRelaDA.UpdateBySql2(objFunctionGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupRelaBL.ReFreshCache();

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
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
 clsFunctionGroupRelaEN objFunctionGroupRelaEN = clsFunctionGroupRelaBL.GetObjBymId(lngmId);

if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(objFunctionGroupRelaEN.mId, objFunctionGroupRelaEN.UpdUser);
}
if (objFunctionGroupRelaEN != null)
{
int intRecNum = FunctionGroupRelaDA.DelRecord(lngmId);
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
objSQL = clsFunctionGroupRelaDA.GetSpecSQLObj();
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
//删除与表:[FunctionGroupRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionGroupRela.mId,
//lngmId);
//        clsFunctionGroupRelaBL.DelFunctionGroupRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionGroupRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionGroupRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFunctionGroupRelaBL.relatedActions != null)
{
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FunctionGroupRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFunctionGroupRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFunctionGroupRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionGroupRelaDA.DelFunctionGroupRela(arrmIdLst);
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
public static int DelFunctionGroupRelasByCond(string strWhereCond)
{
try
{
if (clsFunctionGroupRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFunctionGroupRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionGroupRelaDA.DelFunctionGroupRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionGroupRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionGroupRelaDA.GetSpecSQLObj();
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
//删除与表:[FunctionGroupRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionGroupRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionGroupRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFunctionGroupRelaENS">源对象</param>
 /// <param name = "objFunctionGroupRelaENT">目标对象</param>
 public static void CopyTo(clsFunctionGroupRelaEN objFunctionGroupRelaENS, clsFunctionGroupRelaEN objFunctionGroupRelaENT)
{
try
{
objFunctionGroupRelaENT.mId = objFunctionGroupRelaENS.mId; //mId
objFunctionGroupRelaENT.FunctionGroupId = objFunctionGroupRelaENS.FunctionGroupId; //函数组Id
objFunctionGroupRelaENT.FuncId4GC = objFunctionGroupRelaENS.FuncId4GC; //函数ID
objFunctionGroupRelaENT.UpdDate = objFunctionGroupRelaENS.UpdDate; //修改日期
objFunctionGroupRelaENT.UpdUser = objFunctionGroupRelaENS.UpdUser; //修改者
objFunctionGroupRelaENT.Memo = objFunctionGroupRelaENS.Memo; //说明
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
 /// <param name = "objFunctionGroupRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
try
{
objFunctionGroupRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionGroupRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionGroupRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.mId = objFunctionGroupRelaEN.mId; //mId
}
if (arrFldSet.Contains(conFunctionGroupRela.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.FunctionGroupId = objFunctionGroupRelaEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(conFunctionGroupRela.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.FuncId4GC = objFunctionGroupRelaEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(conFunctionGroupRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.UpdDate = objFunctionGroupRelaEN.UpdDate == "[null]" ? null :  objFunctionGroupRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunctionGroupRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.UpdUser = objFunctionGroupRelaEN.UpdUser == "[null]" ? null :  objFunctionGroupRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFunctionGroupRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionGroupRelaEN.Memo = objFunctionGroupRelaEN.Memo == "[null]" ? null :  objFunctionGroupRelaEN.Memo; //说明
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
 /// <param name = "objFunctionGroupRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
try
{
if (objFunctionGroupRelaEN.UpdDate == "[null]") objFunctionGroupRelaEN.UpdDate = null; //修改日期
if (objFunctionGroupRelaEN.UpdUser == "[null]") objFunctionGroupRelaEN.UpdUser = null; //修改者
if (objFunctionGroupRelaEN.Memo == "[null]") objFunctionGroupRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 FunctionGroupRelaDA.CheckPropertyNew(objFunctionGroupRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
 FunctionGroupRelaDA.CheckProperty4Condition(objFunctionGroupRelaEN);
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
if (clsFunctionGroupRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupRelaBL没有刷新缓存机制(clsFunctionGroupRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFunctionGroupRelaObjLstCache == null)
//{
//arrFunctionGroupRelaObjLstCache = FunctionGroupRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionGroupRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionGroupRelaEN._CurrTabName);
List<clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLst_Sel =
arrFunctionGroupRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFunctionGroupRelaObjLst_Sel.Count() == 0)
{
   clsFunctionGroupRelaEN obj = clsFunctionGroupRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionGroupRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetAllFunctionGroupRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLstCache = GetObjLstCache(); 
return arrFunctionGroupRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionGroupRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionGroupRelaEN._CurrTabName);
List<clsFunctionGroupRelaEN> arrFunctionGroupRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionGroupRelaObjLstCache;
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
string strKey = string.Format("{0}", clsFunctionGroupRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionGroupRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunctionGroupRelaEN._RefreshTimeLst.Count == 0) return "";
return clsFunctionGroupRelaEN._RefreshTimeLst[clsFunctionGroupRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFunctionGroupRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionGroupRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionGroupRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunctionGroupRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FunctionGroupRela(函数与组关系)
 /// 唯一性条件:FunctionGroupId_FuncId4GC
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionGroupRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunctionGroupRelaEN objFunctionGroupRelaEN)
{
//检测记录是否存在
string strResult = FunctionGroupRelaDA.GetUniCondStr(objFunctionGroupRelaEN);
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
if (strInFldName != conFunctionGroupRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionGroupRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionGroupRela._AttributeName));
throw new Exception(strMsg);
}
var objFunctionGroupRela = clsFunctionGroupRelaBL.GetObjBymIdCache(lngmId);
if (objFunctionGroupRela == null) return "";
return objFunctionGroupRela[strOutFldName].ToString();
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
int intRecCount = clsFunctionGroupRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionGroupRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionGroupRelaDA.GetRecCount();
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
int intRecCount = clsFunctionGroupRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionGroupRelaEN objFunctionGroupRelaCond)
{
List<clsFunctionGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionGroupRela._AttributeName)
{
if (objFunctionGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objFunctionGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionGroupRelaCond[strFldName].ToString());
}
else
{
if (objFunctionGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionGroupRelaCond[strFldName]));
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
 List<string> arrList = clsFunctionGroupRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionGroupRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionGroupRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionGroupRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionGroupRelaDA.SetFldValue(clsFunctionGroupRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionGroupRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionGroupRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionGroupRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionGroupRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionGroupRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**函数组Id*/ 
 strCreateTabCode.Append(" FunctionGroupId char(4) not Null, "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId4GC char(10) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数与组关系(FunctionGroupRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionGroupRela : clsCommFun4BL
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
clsFunctionGroupRelaBL.ReFreshThisCache();
}
}

}