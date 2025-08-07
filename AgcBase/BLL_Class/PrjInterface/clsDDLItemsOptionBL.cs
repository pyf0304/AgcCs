
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLItemsOptionBL
 表名:DDLItemsOption(00050059)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsDDLItemsOptionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLItemsOptionEN GetObj(this K_DdlItemsOptionId_DDLItemsOption myKey)
{
clsDDLItemsOptionEN objDDLItemsOptionEN = clsDDLItemsOptionBL.DDLItemsOptionDA.GetObjByDdlItemsOptionId(myKey.Value);
return objDDLItemsOptionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDDLItemsOptionEN objDDLItemsOptionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDDLItemsOptionBL.IsExist(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDDLItemsOptionEN.DdlItemsOptionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDDLItemsOptionBL.DDLItemsOptionDA.AddNewRecordBySQL2(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDDLItemsOptionEN objDDLItemsOptionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDDLItemsOptionBL.IsExist(objDDLItemsOptionEN.DdlItemsOptionId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDDLItemsOptionEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDDLItemsOptionEN.AddNewRecord();
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDDLItemsOptionEN objDDLItemsOptionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDDLItemsOptionBL.IsExist(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDDLItemsOptionEN.DdlItemsOptionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDDLItemsOptionBL.DDLItemsOptionDA.AddNewRecordBySQL2WithReturnKey(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLItemsOptionEN SetDdlItemsOptionId(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conDDLItemsOption.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conDDLItemsOption.DdlItemsOptionId);
}
objDDLItemsOptionEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLItemsOptionEN.dicFldComparisonOp.ContainsKey(conDDLItemsOption.DdlItemsOptionId) == false)
{
objDDLItemsOptionEN.dicFldComparisonOp.Add(conDDLItemsOption.DdlItemsOptionId, strComparisonOp);
}
else
{
objDDLItemsOptionEN.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionId] = strComparisonOp;
}
}
return objDDLItemsOptionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLItemsOptionEN SetDdlItemsOptionName(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strDdlItemsOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionName, conDDLItemsOption.DdlItemsOptionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionName, 20, conDDLItemsOption.DdlItemsOptionName);
}
objDDLItemsOptionEN.DdlItemsOptionName = strDdlItemsOptionName; //下拉选项名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLItemsOptionEN.dicFldComparisonOp.ContainsKey(conDDLItemsOption.DdlItemsOptionName) == false)
{
objDDLItemsOptionEN.dicFldComparisonOp.Add(conDDLItemsOption.DdlItemsOptionName, strComparisonOp);
}
else
{
objDDLItemsOptionEN.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionName] = strComparisonOp;
}
}
return objDDLItemsOptionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLItemsOptionEN SetDdlItemsOptionENName(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strDdlItemsOptionENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionENName, 50, conDDLItemsOption.DdlItemsOptionENName);
}
objDDLItemsOptionEN.DdlItemsOptionENName = strDdlItemsOptionENName; //下拉框列表选项英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLItemsOptionEN.dicFldComparisonOp.ContainsKey(conDDLItemsOption.DdlItemsOptionENName) == false)
{
objDDLItemsOptionEN.dicFldComparisonOp.Add(conDDLItemsOption.DdlItemsOptionENName, strComparisonOp);
}
else
{
objDDLItemsOptionEN.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionENName] = strComparisonOp;
}
}
return objDDLItemsOptionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLItemsOptionEN SetMemo(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDDLItemsOption.Memo);
}
objDDLItemsOptionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLItemsOptionEN.dicFldComparisonOp.ContainsKey(conDDLItemsOption.Memo) == false)
{
objDDLItemsOptionEN.dicFldComparisonOp.Add(conDDLItemsOption.Memo, strComparisonOp);
}
else
{
objDDLItemsOptionEN.dicFldComparisonOp[conDDLItemsOption.Memo] = strComparisonOp;
}
}
return objDDLItemsOptionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDDLItemsOptionEN objDDLItemsOptionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDDLItemsOptionEN.CheckPropertyNew();
clsDDLItemsOptionEN objDDLItemsOptionCond = new clsDDLItemsOptionEN();
string strCondition = objDDLItemsOptionCond
.SetDdlItemsOptionId(objDDLItemsOptionEN.DdlItemsOptionId, "=")
.GetCombineCondition();
objDDLItemsOptionEN._IsCheckProperty = true;
bool bolIsExist = clsDDLItemsOptionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDDLItemsOptionEN.Update();
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLItemsOptionBL.DDLItemsOptionDA.UpdateBySql2(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLItemsOptionEN objDDLItemsOptionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLItemsOptionBL.DDLItemsOptionDA.UpdateBySql2(objDDLItemsOptionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strWhereCond)
{
try
{
bool bolResult = clsDDLItemsOptionBL.DDLItemsOptionDA.UpdateBySqlWithCondition(objDDLItemsOptionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLItemsOptionEN objDDLItemsOptionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDDLItemsOptionBL.DDLItemsOptionDA.UpdateBySqlWithConditionTransaction(objDDLItemsOptionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "strDdlItemsOptionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDDLItemsOptionEN objDDLItemsOptionEN)
{
try
{
int intRecNum = clsDDLItemsOptionBL.DDLItemsOptionDA.DelRecord(objDDLItemsOptionEN.DdlItemsOptionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
 public static void CopyTo(this clsDDLItemsOptionEN objDDLItemsOptionENS, clsDDLItemsOptionEN objDDLItemsOptionENT)
{
try
{
objDDLItemsOptionENT.DdlItemsOptionId = objDDLItemsOptionENS.DdlItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DdlItemsOptionName = objDDLItemsOptionENS.DdlItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DdlItemsOptionENName = objDDLItemsOptionENS.DdlItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
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
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <returns>目标对象=>clsDDLItemsOptionEN:objDDLItemsOptionENT</returns>
 public static clsDDLItemsOptionEN CopyTo(this clsDDLItemsOptionEN objDDLItemsOptionENS)
{
try
{
 clsDDLItemsOptionEN objDDLItemsOptionENT = new clsDDLItemsOptionEN()
{
DdlItemsOptionId = objDDLItemsOptionENS.DdlItemsOptionId, //下拉框列表选项ID
DdlItemsOptionName = objDDLItemsOptionENS.DdlItemsOptionName, //下拉选项名
DdlItemsOptionENName = objDDLItemsOptionENS.DdlItemsOptionENName, //下拉框列表选项英文名
Memo = objDDLItemsOptionENS.Memo, //说明
};
 return objDDLItemsOptionENT;
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
public static void CheckPropertyNew(this clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 clsDDLItemsOptionBL.DDLItemsOptionDA.CheckPropertyNew(objDDLItemsOptionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 clsDDLItemsOptionBL.DDLItemsOptionDA.CheckProperty4Condition(objDDLItemsOptionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDDLItemsOptionEN objDDLItemsOptionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDDLItemsOptionCond.IsUpdated(conDDLItemsOption.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objDDLItemsOptionCond.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLItemsOption.DdlItemsOptionId, objDDLItemsOptionCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objDDLItemsOptionCond.IsUpdated(conDDLItemsOption.DdlItemsOptionName) == true)
{
string strComparisonOpDdlItemsOptionName = objDDLItemsOptionCond.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLItemsOption.DdlItemsOptionName, objDDLItemsOptionCond.DdlItemsOptionName, strComparisonOpDdlItemsOptionName);
}
if (objDDLItemsOptionCond.IsUpdated(conDDLItemsOption.DdlItemsOptionENName) == true)
{
string strComparisonOpDdlItemsOptionENName = objDDLItemsOptionCond.dicFldComparisonOp[conDDLItemsOption.DdlItemsOptionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLItemsOption.DdlItemsOptionENName, objDDLItemsOptionCond.DdlItemsOptionENName, strComparisonOpDdlItemsOptionENName);
}
if (objDDLItemsOptionCond.IsUpdated(conDDLItemsOption.Memo) == true)
{
string strComparisonOpMemo = objDDLItemsOptionCond.dicFldComparisonOp[conDDLItemsOption.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLItemsOption.Memo, objDDLItemsOptionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DDLItemsOption
{
public virtual bool UpdRelaTabDate(string strDdlItemsOptionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumDDLItemsOption
{
 /// <summary>
 /// 未定
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 列表项串
 /// </summary>
public const string ListItemString_01 = "01";
 /// <summary>
 /// 数据源表
 /// </summary>
public const string DataSourceTable_02 = "02";
 /// <summary>
 /// SQL串
 /// </summary>
public const string SQLString_03 = "03";
 /// <summary>
 /// 真假列表
 /// </summary>
public const string TrueAndFalseList_04 = "04";
}
 /// <summary>
 /// 下拉框列表选项(DDLItemsOption)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDDLItemsOptionBL
{
public static RelatedActions_DDLItemsOption relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDDLItemsOptionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDDLItemsOptionDA DDLItemsOptionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDDLItemsOptionDA();
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
 public clsDDLItemsOptionBL()
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
if (string.IsNullOrEmpty(clsDDLItemsOptionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDDLItemsOptionEN._ConnectString);
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
public static DataTable GetDataTable_DDLItemsOption(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DDLItemsOptionDA.GetDataTable_DDLItemsOption(strWhereCond);
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
objDT = DDLItemsOptionDA.GetDataTable(strWhereCond);
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
objDT = DDLItemsOptionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DDLItemsOptionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DDLItemsOptionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DDLItemsOptionDA.GetDataTable_Top(objTopPara);
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
objDT = DDLItemsOptionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DDLItemsOptionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DDLItemsOptionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDdlItemsOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDDLItemsOptionEN> GetObjLstByDdlItemsOptionIdLst(List<string> arrDdlItemsOptionIdLst)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDdlItemsOptionIdLst, true);
 string strWhereCond = string.Format("DdlItemsOptionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDdlItemsOptionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDDLItemsOptionEN> GetObjLstByDdlItemsOptionIdLstCache(List<string> arrDdlItemsOptionIdLst)
{
string strKey = string.Format("{0}", clsDDLItemsOptionEN._CurrTabName);
List<clsDDLItemsOptionEN> arrDDLItemsOptionObjLstCache = GetObjLstCache();
IEnumerable <clsDDLItemsOptionEN> arrDDLItemsOptionObjLst_Sel =
arrDDLItemsOptionObjLstCache
.Where(x => arrDdlItemsOptionIdLst.Contains(x.DdlItemsOptionId));
return arrDDLItemsOptionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLItemsOptionEN> GetObjLst(string strWhereCond)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
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
public static List<clsDDLItemsOptionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDDLItemsOptionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDDLItemsOptionEN> GetSubObjLstCache(clsDDLItemsOptionEN objDDLItemsOptionCond)
{
List<clsDDLItemsOptionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLItemsOptionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLItemsOption._AttributeName)
{
if (objDDLItemsOptionCond.IsUpdated(strFldName) == false) continue;
if (objDDLItemsOptionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLItemsOptionCond[strFldName].ToString());
}
else
{
if (objDDLItemsOptionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLItemsOptionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLItemsOptionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLItemsOptionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLItemsOptionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLItemsOptionCond[strFldName]));
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
public static List<clsDDLItemsOptionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
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
public static List<clsDDLItemsOptionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
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
List<clsDDLItemsOptionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDDLItemsOptionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLItemsOptionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDDLItemsOptionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
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
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
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
public static List<clsDDLItemsOptionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDDLItemsOptionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDDLItemsOptionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
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
public static List<clsDDLItemsOptionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLItemsOptionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDDLItemsOptionEN> arrObjLst = new List<clsDDLItemsOptionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN();
try
{
objDDLItemsOptionEN.DdlItemsOptionId = objRow[conDDLItemsOption.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objDDLItemsOptionEN.DdlItemsOptionName = objRow[conDDLItemsOption.DdlItemsOptionName].ToString().Trim(); //下拉选项名
objDDLItemsOptionEN.DdlItemsOptionENName = objRow[conDDLItemsOption.DdlItemsOptionENName] == DBNull.Value ? null : objRow[conDDLItemsOption.DdlItemsOptionENName].ToString().Trim(); //下拉框列表选项英文名
objDDLItemsOptionEN.Memo = objRow[conDDLItemsOption.Memo] == DBNull.Value ? null : objRow[conDDLItemsOption.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLItemsOptionEN.DdlItemsOptionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLItemsOptionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDDLItemsOptionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDDLItemsOption(ref clsDDLItemsOptionEN objDDLItemsOptionEN)
{
bool bolResult = DDLItemsOptionDA.GetDDLItemsOption(ref objDDLItemsOptionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLItemsOptionEN GetObjByDdlItemsOptionId(string strDdlItemsOptionId)
{
if (strDdlItemsOptionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDdlItemsOptionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDdlItemsOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDdlItemsOptionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDDLItemsOptionEN objDDLItemsOptionEN = DDLItemsOptionDA.GetObjByDdlItemsOptionId(strDdlItemsOptionId);
return objDDLItemsOptionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDDLItemsOptionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDDLItemsOptionEN objDDLItemsOptionEN = DDLItemsOptionDA.GetFirstObj(strWhereCond);
 return objDDLItemsOptionEN;
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
public static clsDDLItemsOptionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDDLItemsOptionEN objDDLItemsOptionEN = DDLItemsOptionDA.GetObjByDataRow(objRow);
 return objDDLItemsOptionEN;
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
public static clsDDLItemsOptionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDDLItemsOptionEN objDDLItemsOptionEN = DDLItemsOptionDA.GetObjByDataRow(objRow);
 return objDDLItemsOptionEN;
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
 /// <param name = "strDdlItemsOptionId">所给的关键字</param>
 /// <param name = "lstDDLItemsOptionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLItemsOptionEN GetObjByDdlItemsOptionIdFromList(string strDdlItemsOptionId, List<clsDDLItemsOptionEN> lstDDLItemsOptionObjLst)
{
foreach (clsDDLItemsOptionEN objDDLItemsOptionEN in lstDDLItemsOptionObjLst)
{
if (objDDLItemsOptionEN.DdlItemsOptionId == strDdlItemsOptionId)
{
return objDDLItemsOptionEN;
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
 string strDdlItemsOptionId;
 try
 {
 strDdlItemsOptionId = new clsDDLItemsOptionDA().GetFirstID(strWhereCond);
 return strDdlItemsOptionId;
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
 arrList = DDLItemsOptionDA.GetID(strWhereCond);
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
bool bolIsExist = DDLItemsOptionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDdlItemsOptionId)
{
if (string.IsNullOrEmpty(strDdlItemsOptionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDdlItemsOptionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DDLItemsOptionDA.IsExist(strDdlItemsOptionId);
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
 bolIsExist = clsDDLItemsOptionDA.IsExistTable();
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
 bolIsExist = DDLItemsOptionDA.IsExistTable(strTabName);
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDDLItemsOptionEN objDDLItemsOptionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDDLItemsOptionBL.IsExist(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDDLItemsOptionEN.DdlItemsOptionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DDLItemsOptionDA.AddNewRecordBySQL2(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDDLItemsOptionEN objDDLItemsOptionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDDLItemsOptionBL.IsExist(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDDLItemsOptionEN.DdlItemsOptionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DDLItemsOptionDA.AddNewRecordBySQL2WithReturnKey(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
try
{
bool bolResult = DDLItemsOptionDA.Update(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "objDDLItemsOptionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 if (string.IsNullOrEmpty(objDDLItemsOptionEN.DdlItemsOptionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DDLItemsOptionDA.UpdateBySql2(objDDLItemsOptionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLItemsOptionBL.ReFreshCache();

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
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
 /// <param name = "strDdlItemsOptionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDdlItemsOptionId)
{
try
{
 clsDDLItemsOptionEN objDDLItemsOptionEN = clsDDLItemsOptionBL.GetObjByDdlItemsOptionId(strDdlItemsOptionId);

if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(objDDLItemsOptionEN.DdlItemsOptionId, "SetUpdDate");
}
if (objDDLItemsOptionEN != null)
{
int intRecNum = DDLItemsOptionDA.DelRecord(strDdlItemsOptionId);
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
/// <param name="strDdlItemsOptionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDdlItemsOptionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDDLItemsOptionDA.GetSpecSQLObj();
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
//删除与表:[DDLItemsOption]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDDLItemsOption.DdlItemsOptionId,
//strDdlItemsOptionId);
//        clsDDLItemsOptionBL.DelDDLItemsOptionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLItemsOptionBL.DelRecord(strDdlItemsOptionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLItemsOptionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDdlItemsOptionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDdlItemsOptionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDdlItemsOptionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDDLItemsOptionBL.relatedActions != null)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(strDdlItemsOptionId, "UpdRelaTabDate");
}
bool bolResult = DDLItemsOptionDA.DelRecord(strDdlItemsOptionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDdlItemsOptionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDDLItemsOptions(List<string> arrDdlItemsOptionIdLst)
{
if (arrDdlItemsOptionIdLst.Count == 0) return 0;
try
{
if (clsDDLItemsOptionBL.relatedActions != null)
{
foreach (var strDdlItemsOptionId in arrDdlItemsOptionIdLst)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(strDdlItemsOptionId, "UpdRelaTabDate");
}
}
int intDelRecNum = DDLItemsOptionDA.DelDDLItemsOption(arrDdlItemsOptionIdLst);
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
public static int DelDDLItemsOptionsByCond(string strWhereCond)
{
try
{
if (clsDDLItemsOptionBL.relatedActions != null)
{
List<string> arrDdlItemsOptionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDdlItemsOptionId in arrDdlItemsOptionId)
{
clsDDLItemsOptionBL.relatedActions.UpdRelaTabDate(strDdlItemsOptionId, "UpdRelaTabDate");
}
}
int intRecNum = DDLItemsOptionDA.DelDDLItemsOption(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DDLItemsOption]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDdlItemsOptionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDdlItemsOptionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDDLItemsOptionDA.GetSpecSQLObj();
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
//删除与表:[DDLItemsOption]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLItemsOptionBL.DelRecord(strDdlItemsOptionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLItemsOptionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDdlItemsOptionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDDLItemsOptionENS">源对象</param>
 /// <param name = "objDDLItemsOptionENT">目标对象</param>
 public static void CopyTo(clsDDLItemsOptionEN objDDLItemsOptionENS, clsDDLItemsOptionEN objDDLItemsOptionENT)
{
try
{
objDDLItemsOptionENT.DdlItemsOptionId = objDDLItemsOptionENS.DdlItemsOptionId; //下拉框列表选项ID
objDDLItemsOptionENT.DdlItemsOptionName = objDDLItemsOptionENS.DdlItemsOptionName; //下拉选项名
objDDLItemsOptionENT.DdlItemsOptionENName = objDDLItemsOptionENS.DdlItemsOptionENName; //下拉框列表选项英文名
objDDLItemsOptionENT.Memo = objDDLItemsOptionENS.Memo; //说明
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
 /// <param name = "objDDLItemsOptionEN">源简化对象</param>
 public static void SetUpdFlag(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
try
{
objDDLItemsOptionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDDLItemsOptionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDDLItemsOption.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLItemsOptionEN.DdlItemsOptionId = objDDLItemsOptionEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(conDDLItemsOption.DdlItemsOptionName, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLItemsOptionEN.DdlItemsOptionName = objDDLItemsOptionEN.DdlItemsOptionName; //下拉选项名
}
if (arrFldSet.Contains(conDDLItemsOption.DdlItemsOptionENName, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLItemsOptionEN.DdlItemsOptionENName = objDDLItemsOptionEN.DdlItemsOptionENName == "[null]" ? null :  objDDLItemsOptionEN.DdlItemsOptionENName; //下拉框列表选项英文名
}
if (arrFldSet.Contains(conDDLItemsOption.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLItemsOptionEN.Memo = objDDLItemsOptionEN.Memo == "[null]" ? null :  objDDLItemsOptionEN.Memo; //说明
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
 /// <param name = "objDDLItemsOptionEN">源简化对象</param>
 public static void AccessFldValueNull(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
try
{
if (objDDLItemsOptionEN.DdlItemsOptionENName == "[null]") objDDLItemsOptionEN.DdlItemsOptionENName = null; //下拉框列表选项英文名
if (objDDLItemsOptionEN.Memo == "[null]") objDDLItemsOptionEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 DDLItemsOptionDA.CheckPropertyNew(objDDLItemsOptionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDDLItemsOptionEN objDDLItemsOptionEN)
{
 DDLItemsOptionDA.CheckProperty4Condition(objDDLItemsOptionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DdlItemsOptionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDDLItemsOption.DdlItemsOptionId); 
List<clsDDLItemsOptionEN> arrObjLst = clsDDLItemsOptionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDDLItemsOptionEN objDDLItemsOptionEN = new clsDDLItemsOptionEN()
{
DdlItemsOptionId = "0",
DdlItemsOptionName = "选[下拉框列表选项]..."
};
arrObjLst.Insert(0, objDDLItemsOptionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDDLItemsOption.DdlItemsOptionId;
objComboBox.DisplayMember = conDDLItemsOption.DdlItemsOptionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DdlItemsOptionId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[下拉框列表选项]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDDLItemsOption.DdlItemsOptionId); 
IEnumerable<clsDDLItemsOptionEN> arrObjLst = clsDDLItemsOptionBL.GetObjLst(strCondition);
objDDL.DataValueField = conDDLItemsOption.DdlItemsOptionId;
objDDL.DataTextField = conDDLItemsOption.DdlItemsOptionName;
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
public static void BindDdl_DdlItemsOptionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[下拉框列表选项]...","0");
List<clsDDLItemsOptionEN> arrDDLItemsOptionObjLst = GetAllDDLItemsOptionObjLstCache(); 
objDDL.DataValueField = conDDLItemsOption.DdlItemsOptionId;
objDDL.DataTextField = conDDLItemsOption.DdlItemsOptionName;
objDDL.DataSource = arrDDLItemsOptionObjLst;
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
if (clsDDLItemsOptionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDDLItemsOptionBL没有刷新缓存机制(clsDDLItemsOptionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DdlItemsOptionId");
//if (arrDDLItemsOptionObjLstCache == null)
//{
//arrDDLItemsOptionObjLstCache = DDLItemsOptionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLItemsOptionEN GetObjByDdlItemsOptionIdCache(string strDdlItemsOptionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDDLItemsOptionEN._CurrTabName);
List<clsDDLItemsOptionEN> arrDDLItemsOptionObjLstCache = GetObjLstCache();
IEnumerable <clsDDLItemsOptionEN> arrDDLItemsOptionObjLst_Sel =
arrDDLItemsOptionObjLstCache
.Where(x=> x.DdlItemsOptionId == strDdlItemsOptionId 
);
if (arrDDLItemsOptionObjLst_Sel.Count() == 0)
{
   clsDDLItemsOptionEN obj = clsDDLItemsOptionBL.GetObjByDdlItemsOptionId(strDdlItemsOptionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDDLItemsOptionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDdlItemsOptionNameByDdlItemsOptionIdCache(string strDdlItemsOptionId)
{
if (string.IsNullOrEmpty(strDdlItemsOptionId) == true) return "";
//获取缓存中的对象列表
clsDDLItemsOptionEN objDDLItemsOption = GetObjByDdlItemsOptionIdCache(strDdlItemsOptionId);
if (objDDLItemsOption == null) return "";
return objDDLItemsOption.DdlItemsOptionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDdlItemsOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDdlItemsOptionIdCache(string strDdlItemsOptionId)
{
if (string.IsNullOrEmpty(strDdlItemsOptionId) == true) return "";
//获取缓存中的对象列表
clsDDLItemsOptionEN objDDLItemsOption = GetObjByDdlItemsOptionIdCache(strDdlItemsOptionId);
if (objDDLItemsOption == null) return "";
return objDDLItemsOption.DdlItemsOptionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLItemsOptionEN> GetAllDDLItemsOptionObjLstCache()
{
//获取缓存中的对象列表
List<clsDDLItemsOptionEN> arrDDLItemsOptionObjLstCache = GetObjLstCache(); 
return arrDDLItemsOptionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLItemsOptionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDDLItemsOptionEN._CurrTabName);
List<clsDDLItemsOptionEN> arrDDLItemsOptionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDDLItemsOptionObjLstCache;
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
string strKey = string.Format("{0}", clsDDLItemsOptionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDDLItemsOptionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDDLItemsOptionEN._RefreshTimeLst.Count == 0) return "";
return clsDDLItemsOptionEN._RefreshTimeLst[clsDDLItemsOptionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDDLItemsOptionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDDLItemsOptionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDDLItemsOptionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDDLItemsOptionBL.objCommFun4BL.ReFreshCache();
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strDdlItemsOptionId)
{
if (strInFldName != conDDLItemsOption.DdlItemsOptionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDDLItemsOption._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDDLItemsOption._AttributeName));
throw new Exception(strMsg);
}
var objDDLItemsOption = clsDDLItemsOptionBL.GetObjByDdlItemsOptionIdCache(strDdlItemsOptionId);
if (objDDLItemsOption == null) return "";
return objDDLItemsOption[strOutFldName].ToString();
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
int intRecCount = clsDDLItemsOptionDA.GetRecCount(strTabName);
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
int intRecCount = clsDDLItemsOptionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDDLItemsOptionDA.GetRecCount();
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
int intRecCount = clsDDLItemsOptionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDDLItemsOptionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDDLItemsOptionEN objDDLItemsOptionCond)
{
List<clsDDLItemsOptionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLItemsOptionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLItemsOption._AttributeName)
{
if (objDDLItemsOptionCond.IsUpdated(strFldName) == false) continue;
if (objDDLItemsOptionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLItemsOptionCond[strFldName].ToString());
}
else
{
if (objDDLItemsOptionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLItemsOptionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLItemsOptionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLItemsOptionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLItemsOptionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLItemsOptionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLItemsOptionCond[strFldName]));
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
 List<string> arrList = clsDDLItemsOptionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DDLItemsOptionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DDLItemsOptionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DDLItemsOptionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLItemsOptionDA.SetFldValue(clsDDLItemsOptionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DDLItemsOptionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLItemsOptionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLItemsOptionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLItemsOptionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DDLItemsOption] "); 
 strCreateTabCode.Append(" ( "); 
 // /**下拉框列表选项ID*/ 
 strCreateTabCode.Append(" DdlItemsOptionId char(2) primary key, "); 
 // /**下拉选项名*/ 
 strCreateTabCode.Append(" DdlItemsOptionName varchar(20) not Null, "); 
 // /**下拉框列表选项英文名*/ 
 strCreateTabCode.Append(" DdlItemsOptionENName varchar(50) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 下拉框列表选项(DDLItemsOption)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DDLItemsOption : clsCommFun4BL
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
clsDDLItemsOptionBL.ReFreshThisCache();
}
}

}