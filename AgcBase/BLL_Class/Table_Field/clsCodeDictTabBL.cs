
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeDictTabBL
 表名:CodeDictTab(00050542)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:52
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
public static class  clsCodeDictTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeDictTabEN GetObj(this K_CodeTabCodeId_CodeDictTab myKey)
{
clsCodeDictTabEN objCodeDictTabEN = clsCodeDictTabBL.CodeDictTabDA.GetObjByCodeTabCodeId(myKey.Value);
return objCodeDictTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeDictTabEN objCodeDictTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeDictTabBL.IsExist(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeDictTabEN.CodeTabCodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCodeDictTabBL.CodeDictTabDA.AddNewRecordBySQL2(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
public static bool AddRecordEx(this clsCodeDictTabEN objCodeDictTabEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCodeDictTabBL.IsExist(objCodeDictTabEN.CodeTabCodeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCodeDictTabEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCodeDictTabEN.AddNewRecord();
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCodeDictTabEN objCodeDictTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeDictTabBL.IsExist(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeDictTabEN.CodeTabCodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCodeDictTabBL.CodeDictTabDA.AddNewRecordBySQL2WithReturnKey(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetCodeTabCodeId(this clsCodeDictTabEN objCodeDictTabEN, string strCodeTabCodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, conCodeDictTab.CodeTabCodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, conCodeDictTab.CodeTabCodeId);
}
objCodeDictTabEN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.CodeTabCodeId) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.CodeTabCodeId, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.CodeTabCodeId] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetCodeTabId(this clsCodeDictTabEN objCodeDictTabEN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabId, conCodeDictTab.CodeTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, conCodeDictTab.CodeTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, conCodeDictTab.CodeTabId);
}
objCodeDictTabEN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.CodeTabId) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.CodeTabId, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.CodeTabId] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetCodeTabNameId(this clsCodeDictTabEN objCodeDictTabEN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabNameId, conCodeDictTab.CodeTabNameId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, conCodeDictTab.CodeTabNameId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, conCodeDictTab.CodeTabNameId);
}
objCodeDictTabEN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.CodeTabNameId) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.CodeTabNameId, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.CodeTabNameId] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetPrjId(this clsCodeDictTabEN objCodeDictTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCodeDictTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCodeDictTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCodeDictTab.PrjId);
}
objCodeDictTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.PrjId) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.PrjId, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.PrjId] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetUpdUser(this clsCodeDictTabEN objCodeDictTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodeDictTab.UpdUser);
}
objCodeDictTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.UpdUser) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.UpdUser, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.UpdUser] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetUpdDate(this clsCodeDictTabEN objCodeDictTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conCodeDictTab.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodeDictTab.UpdDate);
}
objCodeDictTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.UpdDate) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.UpdDate, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.UpdDate] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeDictTabEN SetMemo(this clsCodeDictTabEN objCodeDictTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodeDictTab.Memo);
}
objCodeDictTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeDictTabEN.dicFldComparisonOp.ContainsKey(conCodeDictTab.Memo) == false)
{
objCodeDictTabEN.dicFldComparisonOp.Add(conCodeDictTab.Memo, strComparisonOp);
}
else
{
objCodeDictTabEN.dicFldComparisonOp[conCodeDictTab.Memo] = strComparisonOp;
}
}
return objCodeDictTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCodeDictTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCodeDictTabEN objCodeDictTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeDictTabEN.CheckPropertyNew();
clsCodeDictTabEN objCodeDictTabCond = new clsCodeDictTabEN();
string strCondition = objCodeDictTabCond
.SetCodeTabCodeId(objCodeDictTabEN.CodeTabCodeId, "=")
.GetCombineCondition();
objCodeDictTabEN._IsCheckProperty = true;
bool bolIsExist = clsCodeDictTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCodeDictTabEN.Update();
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeDictTabEN objCodeDictTabEN)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeDictTabBL.CodeDictTabDA.UpdateBySql2(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeDictTabEN objCodeDictTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeDictTabBL.CodeDictTabDA.UpdateBySql2(objCodeDictTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeDictTabEN objCodeDictTabEN, string strWhereCond)
{
try
{
bool bolResult = clsCodeDictTabBL.CodeDictTabDA.UpdateBySqlWithCondition(objCodeDictTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeDictTabEN objCodeDictTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCodeDictTabBL.CodeDictTabDA.UpdateBySqlWithConditionTransaction(objCodeDictTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCodeDictTabEN objCodeDictTabEN)
{
try
{
int intRecNum = clsCodeDictTabBL.CodeDictTabDA.DelRecord(objCodeDictTabEN.CodeTabCodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabENS">源对象</param>
 /// <param name = "objCodeDictTabENT">目标对象</param>
 public static void CopyTo(this clsCodeDictTabEN objCodeDictTabENS, clsCodeDictTabEN objCodeDictTabENT)
{
try
{
objCodeDictTabENT.CodeTabCodeId = objCodeDictTabENS.CodeTabCodeId; //代码Id
objCodeDictTabENT.CodeTabId = objCodeDictTabENS.CodeTabId; //代码表Id
objCodeDictTabENT.CodeTabNameId = objCodeDictTabENS.CodeTabNameId; //代码_名Id
objCodeDictTabENT.PrjId = objCodeDictTabENS.PrjId; //工程Id
objCodeDictTabENT.UpdUser = objCodeDictTabENS.UpdUser; //修改者
objCodeDictTabENT.UpdDate = objCodeDictTabENS.UpdDate; //修改日期
objCodeDictTabENT.Memo = objCodeDictTabENS.Memo; //说明
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
 /// <param name = "objCodeDictTabENS">源对象</param>
 /// <returns>目标对象=>clsCodeDictTabEN:objCodeDictTabENT</returns>
 public static clsCodeDictTabEN CopyTo(this clsCodeDictTabEN objCodeDictTabENS)
{
try
{
 clsCodeDictTabEN objCodeDictTabENT = new clsCodeDictTabEN()
{
CodeTabCodeId = objCodeDictTabENS.CodeTabCodeId, //代码Id
CodeTabId = objCodeDictTabENS.CodeTabId, //代码表Id
CodeTabNameId = objCodeDictTabENS.CodeTabNameId, //代码_名Id
PrjId = objCodeDictTabENS.PrjId, //工程Id
UpdUser = objCodeDictTabENS.UpdUser, //修改者
UpdDate = objCodeDictTabENS.UpdDate, //修改日期
Memo = objCodeDictTabENS.Memo, //说明
};
 return objCodeDictTabENT;
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
public static void CheckPropertyNew(this clsCodeDictTabEN objCodeDictTabEN)
{
 clsCodeDictTabBL.CodeDictTabDA.CheckPropertyNew(objCodeDictTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCodeDictTabEN objCodeDictTabEN)
{
 clsCodeDictTabBL.CodeDictTabDA.CheckProperty4Condition(objCodeDictTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeDictTabEN objCodeDictTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.CodeTabCodeId, objCodeDictTabCond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.CodeTabId, objCodeDictTabCond.CodeTabId, strComparisonOpCodeTabId);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.CodeTabNameId, objCodeDictTabCond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.PrjId) == true)
{
string strComparisonOpPrjId = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.PrjId, objCodeDictTabCond.PrjId, strComparisonOpPrjId);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.UpdUser, objCodeDictTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.UpdDate, objCodeDictTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objCodeDictTabCond.IsUpdated(conCodeDictTab.Memo) == true)
{
string strComparisonOpMemo = objCodeDictTabCond.dicFldComparisonOp[conCodeDictTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeDictTab.Memo, objCodeDictTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CodeDictTab
{
public virtual bool UpdRelaTabDate(string strCodeTabCodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CodeDictTab(CodeDictTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCodeDictTabBL
{
public static RelatedActions_CodeDictTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCodeDictTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCodeDictTabDA CodeDictTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCodeDictTabDA();
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
 public clsCodeDictTabBL()
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
if (string.IsNullOrEmpty(clsCodeDictTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeDictTabEN._ConnectString);
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
public static DataTable GetDataTable_CodeDictTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CodeDictTabDA.GetDataTable_CodeDictTab(strWhereCond);
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
objDT = CodeDictTabDA.GetDataTable(strWhereCond);
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
objDT = CodeDictTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CodeDictTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CodeDictTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CodeDictTabDA.GetDataTable_Top(objTopPara);
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
objDT = CodeDictTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CodeDictTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CodeDictTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeTabCodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCodeDictTabEN> GetObjLstByCodeTabCodeIdLst(List<string> arrCodeTabCodeIdLst)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeTabCodeIdLst, true);
 string strWhereCond = string.Format("CodeTabCodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeTabCodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCodeDictTabEN> GetObjLstByCodeTabCodeIdLstCache(List<string> arrCodeTabCodeIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsCodeDictTabEN._CurrTabName, strPrjId);
List<clsCodeDictTabEN> arrCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCodeDictTabEN> arrCodeDictTabObjLst_Sel =
arrCodeDictTabObjLstCache
.Where(x => arrCodeTabCodeIdLst.Contains(x.CodeTabCodeId));
return arrCodeDictTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeDictTabEN> GetObjLst(string strWhereCond)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
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
public static List<clsCodeDictTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCodeDictTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCodeDictTabEN> GetSubObjLstCache(clsCodeDictTabEN objCodeDictTabCond)
{
 string strPrjId = objCodeDictTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCodeDictTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCodeDictTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCodeDictTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodeDictTab._AttributeName)
{
if (objCodeDictTabCond.IsUpdated(strFldName) == false) continue;
if (objCodeDictTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeDictTabCond[strFldName].ToString());
}
else
{
if (objCodeDictTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeDictTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeDictTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeDictTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeDictTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeDictTabCond[strFldName]));
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
public static List<clsCodeDictTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
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
public static List<clsCodeDictTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
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
List<clsCodeDictTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCodeDictTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeDictTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCodeDictTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
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
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
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
public static List<clsCodeDictTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCodeDictTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCodeDictTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
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
public static List<clsCodeDictTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeDictTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCodeDictTabEN> arrObjLst = new List<clsCodeDictTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeDictTabEN objCodeDictTabEN = new clsCodeDictTabEN();
try
{
objCodeDictTabEN.CodeTabCodeId = objRow[conCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objCodeDictTabEN.CodeTabId = objRow[conCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objCodeDictTabEN.CodeTabNameId = objRow[conCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objCodeDictTabEN.PrjId = objRow[conCodeDictTab.PrjId].ToString().Trim(); //工程Id
objCodeDictTabEN.UpdUser = objRow[conCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[conCodeDictTab.UpdUser].ToString().Trim(); //修改者
objCodeDictTabEN.UpdDate = objRow[conCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objCodeDictTabEN.Memo = objRow[conCodeDictTab.Memo] == DBNull.Value ? null : objRow[conCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeDictTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCodeDictTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCodeDictTab(ref clsCodeDictTabEN objCodeDictTabEN)
{
bool bolResult = CodeDictTabDA.GetCodeDictTab(ref objCodeDictTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeDictTabEN GetObjByCodeTabCodeId(string strCodeTabCodeId)
{
if (strCodeTabCodeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeTabCodeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTabCodeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeTabCodeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCodeDictTabEN objCodeDictTabEN = CodeDictTabDA.GetObjByCodeTabCodeId(strCodeTabCodeId);
return objCodeDictTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCodeDictTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCodeDictTabEN objCodeDictTabEN = CodeDictTabDA.GetFirstObj(strWhereCond);
 return objCodeDictTabEN;
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
public static clsCodeDictTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCodeDictTabEN objCodeDictTabEN = CodeDictTabDA.GetObjByDataRow(objRow);
 return objCodeDictTabEN;
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
public static clsCodeDictTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCodeDictTabEN objCodeDictTabEN = CodeDictTabDA.GetObjByDataRow(objRow);
 return objCodeDictTabEN;
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
 /// <param name = "strCodeTabCodeId">所给的关键字</param>
 /// <param name = "lstCodeDictTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeDictTabEN GetObjByCodeTabCodeIdFromList(string strCodeTabCodeId, List<clsCodeDictTabEN> lstCodeDictTabObjLst)
{
foreach (clsCodeDictTabEN objCodeDictTabEN in lstCodeDictTabObjLst)
{
if (objCodeDictTabEN.CodeTabCodeId == strCodeTabCodeId)
{
return objCodeDictTabEN;
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
 string strCodeTabCodeId;
 try
 {
 strCodeTabCodeId = new clsCodeDictTabDA().GetFirstID(strWhereCond);
 return strCodeTabCodeId;
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
 arrList = CodeDictTabDA.GetID(strWhereCond);
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
bool bolIsExist = CodeDictTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeTabCodeId)
{
if (string.IsNullOrEmpty(strCodeTabCodeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeTabCodeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CodeDictTabDA.IsExist(strCodeTabCodeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCodeTabCodeId">代码Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCodeTabCodeId, string strOpUser)
{
clsCodeDictTabEN objCodeDictTabEN = clsCodeDictTabBL.GetObjByCodeTabCodeId(strCodeTabCodeId);
objCodeDictTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCodeDictTabEN.UpdUser = strOpUser;
return clsCodeDictTabBL.UpdateBySql2(objCodeDictTabEN);
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
 bolIsExist = clsCodeDictTabDA.IsExistTable();
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
 bolIsExist = CodeDictTabDA.IsExistTable(strTabName);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCodeDictTabEN objCodeDictTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeDictTabBL.IsExist(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeDictTabEN.CodeTabCodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CodeDictTabDA.AddNewRecordBySQL2(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCodeDictTabEN objCodeDictTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeDictTabBL.IsExist(objCodeDictTabEN.CodeTabCodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeDictTabEN.CodeTabCodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CodeDictTabDA.AddNewRecordBySQL2WithReturnKey(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCodeDictTabEN objCodeDictTabEN)
{
try
{
bool bolResult = CodeDictTabDA.Update(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "objCodeDictTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCodeDictTabEN objCodeDictTabEN)
{
 if (string.IsNullOrEmpty(objCodeDictTabEN.CodeTabCodeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CodeDictTabDA.UpdateBySql2(objCodeDictTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeDictTabBL.ReFreshCache(objCodeDictTabEN.PrjId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
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
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCodeTabCodeId)
{
try
{
 clsCodeDictTabEN objCodeDictTabEN = clsCodeDictTabBL.GetObjByCodeTabCodeId(strCodeTabCodeId);

if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(objCodeDictTabEN.CodeTabCodeId, objCodeDictTabEN.UpdUser);
}
if (objCodeDictTabEN != null)
{
int intRecNum = CodeDictTabDA.DelRecord(strCodeTabCodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCodeDictTabEN.PrjId);
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
/// <param name="strCodeTabCodeId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCodeTabCodeId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
//删除与表:[CodeDictTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodeDictTab.CodeTabCodeId,
//strCodeTabCodeId);
//        clsCodeDictTabBL.DelCodeDictTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeDictTabBL.DelRecord(strCodeTabCodeId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeDictTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeTabCodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCodeTabCodeId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCodeDictTabBL.relatedActions != null)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(strCodeTabCodeId, "UpdRelaTabDate");
}
bool bolResult = CodeDictTabDA.DelRecord(strCodeTabCodeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCodeTabCodeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCodeDictTabs(List<string> arrCodeTabCodeIdLst)
{
if (arrCodeTabCodeIdLst.Count == 0) return 0;
try
{
if (clsCodeDictTabBL.relatedActions != null)
{
foreach (var strCodeTabCodeId in arrCodeTabCodeIdLst)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(strCodeTabCodeId, "UpdRelaTabDate");
}
}
 clsCodeDictTabEN objCodeDictTabEN = clsCodeDictTabBL.GetObjByCodeTabCodeId(arrCodeTabCodeIdLst[0]);
int intDelRecNum = CodeDictTabDA.DelCodeDictTab(arrCodeTabCodeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCodeDictTabEN.PrjId);
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
public static int DelCodeDictTabsByCond(string strWhereCond)
{
try
{
if (clsCodeDictTabBL.relatedActions != null)
{
List<string> arrCodeTabCodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCodeTabCodeId in arrCodeTabCodeId)
{
clsCodeDictTabBL.relatedActions.UpdRelaTabDate(strCodeTabCodeId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conCodeDictTab.PrjId, strWhereCond);
int intRecNum = CodeDictTabDA.DelCodeDictTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CodeDictTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCodeTabCodeId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCodeTabCodeId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeDictTabDA.GetSpecSQLObj();
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
//删除与表:[CodeDictTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeDictTabBL.DelRecord(strCodeTabCodeId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeDictTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeTabCodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCodeDictTabENS">源对象</param>
 /// <param name = "objCodeDictTabENT">目标对象</param>
 public static void CopyTo(clsCodeDictTabEN objCodeDictTabENS, clsCodeDictTabEN objCodeDictTabENT)
{
try
{
objCodeDictTabENT.CodeTabCodeId = objCodeDictTabENS.CodeTabCodeId; //代码Id
objCodeDictTabENT.CodeTabId = objCodeDictTabENS.CodeTabId; //代码表Id
objCodeDictTabENT.CodeTabNameId = objCodeDictTabENS.CodeTabNameId; //代码_名Id
objCodeDictTabENT.PrjId = objCodeDictTabENS.PrjId; //工程Id
objCodeDictTabENT.UpdUser = objCodeDictTabENS.UpdUser; //修改者
objCodeDictTabENT.UpdDate = objCodeDictTabENS.UpdDate; //修改日期
objCodeDictTabENT.Memo = objCodeDictTabENS.Memo; //说明
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
 /// <param name = "objCodeDictTabEN">源简化对象</param>
 public static void SetUpdFlag(clsCodeDictTabEN objCodeDictTabEN)
{
try
{
objCodeDictTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCodeDictTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCodeDictTab.CodeTabCodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.CodeTabCodeId = objCodeDictTabEN.CodeTabCodeId; //代码Id
}
if (arrFldSet.Contains(conCodeDictTab.CodeTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.CodeTabId = objCodeDictTabEN.CodeTabId; //代码表Id
}
if (arrFldSet.Contains(conCodeDictTab.CodeTabNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.CodeTabNameId = objCodeDictTabEN.CodeTabNameId; //代码_名Id
}
if (arrFldSet.Contains(conCodeDictTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.PrjId = objCodeDictTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCodeDictTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.UpdUser = objCodeDictTabEN.UpdUser == "[null]" ? null :  objCodeDictTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCodeDictTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.UpdDate = objCodeDictTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCodeDictTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeDictTabEN.Memo = objCodeDictTabEN.Memo == "[null]" ? null :  objCodeDictTabEN.Memo; //说明
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
 /// <param name = "objCodeDictTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsCodeDictTabEN objCodeDictTabEN)
{
try
{
if (objCodeDictTabEN.UpdUser == "[null]") objCodeDictTabEN.UpdUser = null; //修改者
if (objCodeDictTabEN.Memo == "[null]") objCodeDictTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCodeDictTabEN objCodeDictTabEN)
{
 CodeDictTabDA.CheckPropertyNew(objCodeDictTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCodeDictTabEN objCodeDictTabEN)
{
 CodeDictTabDA.CheckProperty4Condition(objCodeDictTabEN);
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
if (clsCodeDictTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeDictTabBL没有刷新缓存机制(clsCodeDictTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTabCodeId");
//if (arrCodeDictTabObjLstCache == null)
//{
//arrCodeDictTabObjLstCache = CodeDictTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeTabCodeId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeDictTabEN GetObjByCodeTabCodeIdCache(string strCodeTabCodeId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCodeDictTabEN._CurrTabName, strPrjId);
List<clsCodeDictTabEN> arrCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCodeDictTabEN> arrCodeDictTabObjLst_Sel =
arrCodeDictTabObjLstCache
.Where(x=> x.CodeTabCodeId == strCodeTabCodeId 
);
if (arrCodeDictTabObjLst_Sel.Count() == 0)
{
   clsCodeDictTabEN obj = clsCodeDictTabBL.GetObjByCodeTabCodeId(strCodeTabCodeId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCodeTabCodeId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCodeDictTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeDictTabEN> GetAllCodeDictTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsCodeDictTabEN> arrCodeDictTabObjLstCache = GetObjLstCache(strPrjId); 
return arrCodeDictTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeDictTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCodeDictTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsCodeDictTabEN> arrCodeDictTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCodeDictTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsCodeDictTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCodeDictTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCodeDictTabEN._RefreshTimeLst.Count == 0) return "";
return clsCodeDictTabEN._RefreshTimeLst[clsCodeDictTabEN._RefreshTimeLst.Count - 1];
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
if (clsCodeDictTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCodeDictTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCodeDictTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCodeDictTabBL.objCommFun4BL.ReFreshCache(strPrjId);
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
public static string Func(string strInFldName, string strOutFldName, string strCodeTabCodeId, string strPrjId)
{
if (strInFldName != conCodeDictTab.CodeTabCodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCodeDictTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCodeDictTab._AttributeName));
throw new Exception(strMsg);
}
var objCodeDictTab = clsCodeDictTabBL.GetObjByCodeTabCodeIdCache(strCodeTabCodeId, strPrjId);
if (objCodeDictTab == null) return "";
return objCodeDictTab[strOutFldName].ToString();
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
int intRecCount = clsCodeDictTabDA.GetRecCount(strTabName);
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
int intRecCount = clsCodeDictTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCodeDictTabDA.GetRecCount();
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
int intRecCount = clsCodeDictTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCodeDictTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCodeDictTabEN objCodeDictTabCond)
{
 string strPrjId = objCodeDictTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCodeDictTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCodeDictTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCodeDictTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodeDictTab._AttributeName)
{
if (objCodeDictTabCond.IsUpdated(strFldName) == false) continue;
if (objCodeDictTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeDictTabCond[strFldName].ToString());
}
else
{
if (objCodeDictTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeDictTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeDictTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeDictTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeDictTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeDictTabCond[strFldName]));
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
 List<string> arrList = clsCodeDictTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CodeDictTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CodeDictTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CodeDictTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeDictTabDA.SetFldValue(clsCodeDictTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CodeDictTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeDictTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeDictTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeDictTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CodeDictTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**代码Id*/ 
 strCreateTabCode.Append(" CodeTabCodeId char(8) primary key, "); 
 // /**代码表Id*/ 
 strCreateTabCode.Append(" CodeTabId char(8) not Null, "); 
 // /**代码_名Id*/ 
 strCreateTabCode.Append(" CodeTabNameId char(8) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CodeDictTab(CodeDictTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CodeDictTab : clsCommFun4BLV2
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
clsCodeDictTabBL.ReFreshThisCache(strPrjId);
}
}

}