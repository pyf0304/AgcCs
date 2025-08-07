
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTab_CheckBL
 表名:PrjTab_Check(00050564)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:00:18
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
public static class  clsPrjTab_CheckBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTab_CheckEN GetObj(this K_TabId_PrjTab_Check myKey)
{
clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.PrjTab_CheckDA.GetObjByTabId(myKey.Value);
return objPrjTab_CheckEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTab_CheckBL.IsExist(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTab_CheckEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPrjTab_CheckBL.PrjTab_CheckDA.AddNewRecordBySQL2(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
public static bool AddRecordEx(this clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPrjTab_CheckBL.IsExist(objPrjTab_CheckEN.TabId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPrjTab_CheckEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPrjTab_CheckEN.AddNewRecord();
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTab_CheckBL.IsExist(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTab_CheckEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPrjTab_CheckBL.PrjTab_CheckDA.AddNewRecordBySQL2WithReturnKey(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetTabId(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTab_Check.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTab_Check.TabId);
}
objPrjTab_CheckEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.TabId) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.TabId, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.TabId] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetPrjId(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjTab_Check.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTab_Check.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTab_Check.PrjId);
}
objPrjTab_CheckEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.PrjId) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.PrjId, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.PrjId] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetUpdUserId(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPrjTab_Check.UpdUserId);
}
objPrjTab_CheckEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.UpdUserId) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.UpdUserId, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.UpdUserId] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetUpdDate(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjTab_Check.UpdDate);
}
objPrjTab_CheckEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.UpdDate) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.UpdDate, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.UpdDate] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetMemo(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTab_Check.Memo);
}
objPrjTab_CheckEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.Memo) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.Memo, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.Memo] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetErrMsg(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjTab_Check.ErrMsg);
}
objPrjTab_CheckEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.ErrMsg) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.ErrMsg, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.ErrMsg] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTab_CheckEN SetIsNeedCheckTab(this clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckTab, string strComparisonOp="")
	{
objPrjTab_CheckEN.IsNeedCheckTab = bolIsNeedCheckTab; //是否需要检查表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTab_CheckEN.dicFldComparisonOp.ContainsKey(conPrjTab_Check.IsNeedCheckTab) == false)
{
objPrjTab_CheckEN.dicFldComparisonOp.Add(conPrjTab_Check.IsNeedCheckTab, strComparisonOp);
}
else
{
objPrjTab_CheckEN.dicFldComparisonOp[conPrjTab_Check.IsNeedCheckTab] = strComparisonOp;
}
}
return objPrjTab_CheckEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjTab_CheckEN objPrjTab_CheckEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjTab_CheckEN.CheckPropertyNew();
clsPrjTab_CheckEN objPrjTab_CheckCond = new clsPrjTab_CheckEN();
string strCondition = objPrjTab_CheckCond
.SetTabId(objPrjTab_CheckEN.TabId, "=")
.GetCombineCondition();
objPrjTab_CheckEN._IsCheckProperty = true;
bool bolIsExist = clsPrjTab_CheckBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjTab_CheckEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTab_CheckBL.PrjTab_CheckDA.UpdateBySql2(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTab_CheckEN objPrjTab_CheckEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTab_CheckBL.PrjTab_CheckDA.UpdateBySql2(objPrjTab_CheckEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjTab_CheckBL.PrjTab_CheckDA.UpdateBySqlWithCondition(objPrjTab_CheckEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTab_CheckEN objPrjTab_CheckEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjTab_CheckBL.PrjTab_CheckDA.UpdateBySqlWithConditionTransaction(objPrjTab_CheckEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjTab_CheckEN objPrjTab_CheckEN)
{
try
{
int intRecNum = clsPrjTab_CheckBL.PrjTab_CheckDA.DelRecord(objPrjTab_CheckEN.TabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckENS">源对象</param>
 /// <param name = "objPrjTab_CheckENT">目标对象</param>
 public static void CopyTo(this clsPrjTab_CheckEN objPrjTab_CheckENS, clsPrjTab_CheckEN objPrjTab_CheckENT)
{
try
{
objPrjTab_CheckENT.TabId = objPrjTab_CheckENS.TabId; //表ID
objPrjTab_CheckENT.PrjId = objPrjTab_CheckENS.PrjId; //工程Id
objPrjTab_CheckENT.UpdUserId = objPrjTab_CheckENS.UpdUserId; //修改用户Id
objPrjTab_CheckENT.UpdDate = objPrjTab_CheckENS.UpdDate; //修改日期
objPrjTab_CheckENT.Memo = objPrjTab_CheckENS.Memo; //说明
objPrjTab_CheckENT.ErrMsg = objPrjTab_CheckENS.ErrMsg; //错误信息
objPrjTab_CheckENT.IsNeedCheckTab = objPrjTab_CheckENS.IsNeedCheckTab; //是否需要检查表字段
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
 /// <param name = "objPrjTab_CheckENS">源对象</param>
 /// <returns>目标对象=>clsPrjTab_CheckEN:objPrjTab_CheckENT</returns>
 public static clsPrjTab_CheckEN CopyTo(this clsPrjTab_CheckEN objPrjTab_CheckENS)
{
try
{
 clsPrjTab_CheckEN objPrjTab_CheckENT = new clsPrjTab_CheckEN()
{
TabId = objPrjTab_CheckENS.TabId, //表ID
PrjId = objPrjTab_CheckENS.PrjId, //工程Id
UpdUserId = objPrjTab_CheckENS.UpdUserId, //修改用户Id
UpdDate = objPrjTab_CheckENS.UpdDate, //修改日期
Memo = objPrjTab_CheckENS.Memo, //说明
ErrMsg = objPrjTab_CheckENS.ErrMsg, //错误信息
IsNeedCheckTab = objPrjTab_CheckENS.IsNeedCheckTab, //是否需要检查表字段
};
 return objPrjTab_CheckENT;
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
public static void CheckPropertyNew(this clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 clsPrjTab_CheckBL.PrjTab_CheckDA.CheckPropertyNew(objPrjTab_CheckEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 clsPrjTab_CheckBL.PrjTab_CheckDA.CheckProperty4Condition(objPrjTab_CheckEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTab_CheckEN objPrjTab_CheckCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.TabId) == true)
{
string strComparisonOpTabId = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.TabId, objPrjTab_CheckCond.TabId, strComparisonOpTabId);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.PrjId, objPrjTab_CheckCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.UpdUserId, objPrjTab_CheckCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.UpdDate, objPrjTab_CheckCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.Memo) == true)
{
string strComparisonOpMemo = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.Memo, objPrjTab_CheckCond.Memo, strComparisonOpMemo);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjTab_CheckCond.dicFldComparisonOp[conPrjTab_Check.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab_Check.ErrMsg, objPrjTab_CheckCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjTab_CheckCond.IsUpdated(conPrjTab_Check.IsNeedCheckTab) == true)
{
if (objPrjTab_CheckCond.IsNeedCheckTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab_Check.IsNeedCheckTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab_Check.IsNeedCheckTab);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjTab_Check
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程表_检查(PrjTab_Check)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjTab_CheckBL
{
public static RelatedActions_PrjTab_Check relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjTab_CheckDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjTab_CheckDA PrjTab_CheckDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjTab_CheckDA();
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
 public clsPrjTab_CheckBL()
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
if (string.IsNullOrEmpty(clsPrjTab_CheckEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTab_CheckEN._ConnectString);
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
public static DataTable GetDataTable_PrjTab_Check(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjTab_CheckDA.GetDataTable_PrjTab_Check(strWhereCond);
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
objDT = PrjTab_CheckDA.GetDataTable(strWhereCond);
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
objDT = PrjTab_CheckDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjTab_CheckDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjTab_CheckDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjTab_CheckDA.GetDataTable_Top(objTopPara);
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
objDT = PrjTab_CheckDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjTab_CheckDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjTab_CheckDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjTab_CheckEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjTab_CheckEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTab_CheckEN> arrPrjTab_CheckObjLst_Sel =
arrPrjTab_CheckObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrPrjTab_CheckObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTab_CheckEN> GetObjLst(string strWhereCond)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
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
public static List<clsPrjTab_CheckEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjTab_CheckCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjTab_CheckEN> GetSubObjLstCache(clsPrjTab_CheckEN objPrjTab_CheckCond)
{
 string strPrjId = objPrjTab_CheckCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPrjTab_CheckBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPrjTab_CheckEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTab_CheckEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTab_Check._AttributeName)
{
if (objPrjTab_CheckCond.IsUpdated(strFldName) == false) continue;
if (objPrjTab_CheckCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTab_CheckCond[strFldName].ToString());
}
else
{
if (objPrjTab_CheckCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTab_CheckCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTab_CheckCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTab_CheckCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTab_CheckCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTab_CheckCond[strFldName]));
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
public static List<clsPrjTab_CheckEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
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
public static List<clsPrjTab_CheckEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
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
List<clsPrjTab_CheckEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjTab_CheckEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTab_CheckEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjTab_CheckEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
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
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
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
public static List<clsPrjTab_CheckEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjTab_CheckEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjTab_CheckEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
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
public static List<clsPrjTab_CheckEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTab_CheckEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjTab_CheckEN> arrObjLst = new List<clsPrjTab_CheckEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTab_CheckEN objPrjTab_CheckEN = new clsPrjTab_CheckEN();
try
{
objPrjTab_CheckEN.TabId = objRow[conPrjTab_Check.TabId].ToString().Trim(); //表ID
objPrjTab_CheckEN.PrjId = objRow[conPrjTab_Check.PrjId].ToString().Trim(); //工程Id
objPrjTab_CheckEN.UpdUserId = objRow[conPrjTab_Check.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTab_CheckEN.UpdDate = objRow[conPrjTab_Check.UpdDate] == DBNull.Value ? null : objRow[conPrjTab_Check.UpdDate].ToString().Trim(); //修改日期
objPrjTab_CheckEN.Memo = objRow[conPrjTab_Check.Memo] == DBNull.Value ? null : objRow[conPrjTab_Check.Memo].ToString().Trim(); //说明
objPrjTab_CheckEN.ErrMsg = objRow[conPrjTab_Check.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab_Check.ErrMsg].ToString().Trim(); //错误信息
objPrjTab_CheckEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab_Check.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTab_CheckEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTab_CheckEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjTab_CheckEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjTab_Check(ref clsPrjTab_CheckEN objPrjTab_CheckEN)
{
bool bolResult = PrjTab_CheckDA.GetPrjTab_Check(ref objPrjTab_CheckEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTab_CheckEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjTab_CheckEN objPrjTab_CheckEN = PrjTab_CheckDA.GetObjByTabId(strTabId);
return objPrjTab_CheckEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjTab_CheckEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjTab_CheckEN objPrjTab_CheckEN = PrjTab_CheckDA.GetFirstObj(strWhereCond);
 return objPrjTab_CheckEN;
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
public static clsPrjTab_CheckEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjTab_CheckEN objPrjTab_CheckEN = PrjTab_CheckDA.GetObjByDataRow(objRow);
 return objPrjTab_CheckEN;
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
public static clsPrjTab_CheckEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjTab_CheckEN objPrjTab_CheckEN = PrjTab_CheckDA.GetObjByDataRow(objRow);
 return objPrjTab_CheckEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstPrjTab_CheckObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTab_CheckEN GetObjByTabIdFromList(string strTabId, List<clsPrjTab_CheckEN> lstPrjTab_CheckObjLst)
{
foreach (clsPrjTab_CheckEN objPrjTab_CheckEN in lstPrjTab_CheckObjLst)
{
if (objPrjTab_CheckEN.TabId == strTabId)
{
return objPrjTab_CheckEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsPrjTab_CheckDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = PrjTab_CheckDA.GetID(strWhereCond);
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
bool bolIsExist = PrjTab_CheckDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjTab_CheckDA.IsExist(strTabId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTabId">表ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTabId, string strOpUser)
{
clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.GetObjByTabId(strTabId);
objPrjTab_CheckEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjTab_CheckEN.UpdUserId = strOpUser;
return clsPrjTab_CheckBL.UpdateBySql2(objPrjTab_CheckEN);
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
 bolIsExist = clsPrjTab_CheckDA.IsExistTable();
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
 bolIsExist = PrjTab_CheckDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTab_CheckBL.IsExist(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTab_CheckEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PrjTab_CheckDA.AddNewRecordBySQL2(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjTab_CheckEN objPrjTab_CheckEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTab_CheckBL.IsExist(objPrjTab_CheckEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTab_CheckEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PrjTab_CheckDA.AddNewRecordBySQL2WithReturnKey(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
try
{
bool bolResult = PrjTab_CheckDA.Update(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 if (string.IsNullOrEmpty(objPrjTab_CheckEN.TabId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjTab_CheckDA.UpdateBySql2(objPrjTab_CheckEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTab_CheckBL.ReFreshCache(objPrjTab_CheckEN.PrjId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTabId)
{
try
{
 clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.GetObjByTabId(strTabId);

if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(objPrjTab_CheckEN.TabId, objPrjTab_CheckEN.UpdUserId);
}
if (objPrjTab_CheckEN != null)
{
int intRecNum = PrjTab_CheckDA.DelRecord(strTabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTab_CheckEN.PrjId);
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
/// <param name="strTabId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTab_CheckDA.GetSpecSQLObj();
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
//删除与表:[PrjTab_Check]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjTab_Check.TabId,
//strTabId);
//        clsPrjTab_CheckBL.DelPrjTab_ChecksByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTab_CheckBL.DelRecord(strTabId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTab_CheckBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTabId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjTab_CheckBL.relatedActions != null)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
bool bolResult = PrjTab_CheckDA.DelRecord(strTabId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTabIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjTab_Checks(List<string> arrTabIdLst)
{
if (arrTabIdLst.Count == 0) return 0;
try
{
if (clsPrjTab_CheckBL.relatedActions != null)
{
foreach (var strTabId in arrTabIdLst)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
 clsPrjTab_CheckEN objPrjTab_CheckEN = clsPrjTab_CheckBL.GetObjByTabId(arrTabIdLst[0]);
int intDelRecNum = PrjTab_CheckDA.DelPrjTab_Check(arrTabIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTab_CheckEN.PrjId);
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
public static int DelPrjTab_ChecksByCond(string strWhereCond)
{
try
{
if (clsPrjTab_CheckBL.relatedActions != null)
{
List<string> arrTabId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTabId in arrTabId)
{
clsPrjTab_CheckBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conPrjTab_Check.PrjId, strWhereCond);
int intRecNum = PrjTab_CheckDA.DelPrjTab_Check(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjTab_Check]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTabId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTabId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTab_CheckDA.GetSpecSQLObj();
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
//删除与表:[PrjTab_Check]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTab_CheckBL.DelRecord(strTabId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTab_CheckBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjTab_CheckENS">源对象</param>
 /// <param name = "objPrjTab_CheckENT">目标对象</param>
 public static void CopyTo(clsPrjTab_CheckEN objPrjTab_CheckENS, clsPrjTab_CheckEN objPrjTab_CheckENT)
{
try
{
objPrjTab_CheckENT.TabId = objPrjTab_CheckENS.TabId; //表ID
objPrjTab_CheckENT.PrjId = objPrjTab_CheckENS.PrjId; //工程Id
objPrjTab_CheckENT.UpdUserId = objPrjTab_CheckENS.UpdUserId; //修改用户Id
objPrjTab_CheckENT.UpdDate = objPrjTab_CheckENS.UpdDate; //修改日期
objPrjTab_CheckENT.Memo = objPrjTab_CheckENS.Memo; //说明
objPrjTab_CheckENT.ErrMsg = objPrjTab_CheckENS.ErrMsg; //错误信息
objPrjTab_CheckENT.IsNeedCheckTab = objPrjTab_CheckENS.IsNeedCheckTab; //是否需要检查表字段
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
 /// <param name = "objPrjTab_CheckEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
try
{
objPrjTab_CheckEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjTab_CheckEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjTab_Check.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.TabId = objPrjTab_CheckEN.TabId; //表ID
}
if (arrFldSet.Contains(conPrjTab_Check.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.PrjId = objPrjTab_CheckEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjTab_Check.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.UpdUserId = objPrjTab_CheckEN.UpdUserId == "[null]" ? null :  objPrjTab_CheckEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPrjTab_Check.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.UpdDate = objPrjTab_CheckEN.UpdDate == "[null]" ? null :  objPrjTab_CheckEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjTab_Check.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.Memo = objPrjTab_CheckEN.Memo == "[null]" ? null :  objPrjTab_CheckEN.Memo; //说明
}
if (arrFldSet.Contains(conPrjTab_Check.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.ErrMsg = objPrjTab_CheckEN.ErrMsg == "[null]" ? null :  objPrjTab_CheckEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conPrjTab_Check.IsNeedCheckTab, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTab_CheckEN.IsNeedCheckTab = objPrjTab_CheckEN.IsNeedCheckTab; //是否需要检查表字段
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
 /// <param name = "objPrjTab_CheckEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
try
{
if (objPrjTab_CheckEN.UpdUserId == "[null]") objPrjTab_CheckEN.UpdUserId = null; //修改用户Id
if (objPrjTab_CheckEN.UpdDate == "[null]") objPrjTab_CheckEN.UpdDate = null; //修改日期
if (objPrjTab_CheckEN.Memo == "[null]") objPrjTab_CheckEN.Memo = null; //说明
if (objPrjTab_CheckEN.ErrMsg == "[null]") objPrjTab_CheckEN.ErrMsg = null; //错误信息
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
public static void CheckPropertyNew(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 PrjTab_CheckDA.CheckPropertyNew(objPrjTab_CheckEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjTab_CheckEN objPrjTab_CheckEN)
{
 PrjTab_CheckDA.CheckProperty4Condition(objPrjTab_CheckEN);
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
if (clsPrjTab_CheckBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTab_CheckBL没有刷新缓存机制(clsPrjTab_CheckBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrPrjTab_CheckObjLstCache == null)
//{
//arrPrjTab_CheckObjLstCache = PrjTab_CheckDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTab_CheckEN GetObjByTabIdCache(string strTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTab_CheckEN> arrPrjTab_CheckObjLst_Sel =
arrPrjTab_CheckObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrPrjTab_CheckObjLst_Sel.Count() == 0)
{
   clsPrjTab_CheckEN obj = clsPrjTab_CheckBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPrjTab_CheckObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTab_CheckEN> GetAllPrjTab_CheckObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLstCache = GetObjLstCache(strPrjId); 
return arrPrjTab_CheckObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTab_CheckEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPrjTab_CheckObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrPrjTab_CheckObjLst">需要排序的对象列表</param>
public static List <clsPrjTab_CheckEN> GetSubSet4PrjTab_CheckObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTab_CheckEN> arrPrjTab_CheckObjLst_Sel1 =
from objPrjTab_CheckEN in arrPrjTab_CheckObjLstCache
where objPrjTab_CheckEN.PrjId == strPrjId
select objPrjTab_CheckEN;
List <clsPrjTab_CheckEN> arrPrjTab_CheckObjLst_Sel = new List<clsPrjTab_CheckEN>();
foreach (clsPrjTab_CheckEN obj in arrPrjTab_CheckObjLst_Sel1)
{
arrPrjTab_CheckObjLst_Sel.Add(obj);
}
return arrPrjTab_CheckObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTab_CheckEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjTab_CheckEN._RefreshTimeLst.Count == 0) return "";
return clsPrjTab_CheckEN._RefreshTimeLst[clsPrjTab_CheckEN._RefreshTimeLst.Count - 1];
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
if (clsPrjTab_CheckBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTab_CheckEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTab_CheckEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjTab_CheckBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != conPrjTab_Check.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjTab_Check._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjTab_Check._AttributeName));
throw new Exception(strMsg);
}
var objPrjTab_Check = clsPrjTab_CheckBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objPrjTab_Check == null) return "";
return objPrjTab_Check[strOutFldName].ToString();
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
int intRecCount = clsPrjTab_CheckDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjTab_CheckDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjTab_CheckDA.GetRecCount();
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
int intRecCount = clsPrjTab_CheckDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjTab_CheckCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjTab_CheckEN objPrjTab_CheckCond)
{
 string strPrjId = objPrjTab_CheckCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPrjTab_CheckBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPrjTab_CheckEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTab_CheckEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTab_Check._AttributeName)
{
if (objPrjTab_CheckCond.IsUpdated(strFldName) == false) continue;
if (objPrjTab_CheckCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTab_CheckCond[strFldName].ToString());
}
else
{
if (objPrjTab_CheckCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTab_CheckCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTab_CheckCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTab_CheckCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTab_CheckCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTab_CheckCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTab_CheckCond[strFldName]));
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
 List<string> arrList = clsPrjTab_CheckDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjTab_CheckDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjTab_CheckDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjTab_CheckDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTab_CheckDA.SetFldValue(clsPrjTab_CheckEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjTab_CheckDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTab_CheckDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTab_CheckDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTab_CheckDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjTab_Check] "); 
 strCreateTabCode.Append(" ( "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) primary key, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**是否需要检查表字段*/ 
 strCreateTabCode.Append(" IsNeedCheckTab bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程表_检查(PrjTab_Check)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjTab_Check : clsCommFun4BLV2
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
clsPrjTab_CheckBL.ReFreshThisCache(strPrjId);
}
}

}