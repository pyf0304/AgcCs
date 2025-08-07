
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_CommKeyWordsBL
 表名:tz_CommKeyWords(00050330)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clstz_CommKeyWordsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKeyId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_CommKeyWordsEN GetObj(this K_KeyId_tz_CommKeyWords myKey)
{
clstz_CommKeyWordsEN objtz_CommKeyWordsEN = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.GetObjByKeyId(myKey.Value);
return objtz_CommKeyWordsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objtz_CommKeyWordsEN) == false)
{
var strMsg = string.Format("记录已经存在!数据表关键字值 = [{0}],关键字 = [{1}]的数据已经存在!(in clstz_CommKeyWordsBL.AddNewRecord)", objtz_CommKeyWordsEN.TableKey,objtz_CommKeyWordsEN.Keyword);
throw new Exception(strMsg);
}
try
{
bool bolResult = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.AddNewRecordBySQL2(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
public static bool AddRecordEx(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, bool bolIsNeedCheckUniqueness = true)
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
objtz_CommKeyWordsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objtz_CommKeyWordsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(数据表关键字值(TableKey)=[{0}],关键字(Keyword)=[{1}])已经存在,不能重复!", objtz_CommKeyWordsEN.TableKey, objtz_CommKeyWordsEN.Keyword);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objtz_CommKeyWordsEN.AddNewRecord();
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objtz_CommKeyWordsEN) == false)
{
var strMsg = string.Format("记录已经存在!数据表关键字值 = [{0}],关键字 = [{1}]的数据已经存在!(in clstz_CommKeyWordsBL.AddNewRecordWithReturnKey)", objtz_CommKeyWordsEN.TableKey,objtz_CommKeyWordsEN.Keyword);
throw new Exception(strMsg);
}
try
{
string strKey = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.AddNewRecordBySQL2WithReturnKey(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetKeyId(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId, 8, contz_CommKeyWords.KeyId);
}
objtz_CommKeyWordsEN.KeyId = strKeyId; //关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.KeyId) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.KeyId, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.KeyId] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetKeyword(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyword, contz_CommKeyWords.Keyword);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, contz_CommKeyWords.Keyword);
}
objtz_CommKeyWordsEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.Keyword) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.Keyword, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.Keyword] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetTableName(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableName, contz_CommKeyWords.TableName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, contz_CommKeyWords.TableName);
}
objtz_CommKeyWordsEN.TableName = strTableName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.TableName) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.TableName, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.TableName] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetTableKey(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strTableKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableKey, contz_CommKeyWords.TableKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 100, contz_CommKeyWords.TableKey);
}
objtz_CommKeyWordsEN.TableKey = strTableKey; //数据表关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.TableKey) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.TableKey, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.TableKey] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetUpdUser(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, contz_CommKeyWords.UpdUser);
}
objtz_CommKeyWordsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.UpdUser) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.UpdUser, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.UpdUser] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetUpdDate(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, contz_CommKeyWords.UpdDate);
}
objtz_CommKeyWordsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.UpdDate) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.UpdDate, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.UpdDate] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetMemo(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, contz_CommKeyWords.Memo);
}
objtz_CommKeyWordsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.Memo) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.Memo, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.Memo] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objtz_CommKeyWordsEN.CheckPropertyNew();
clstz_CommKeyWordsEN objtz_CommKeyWordsCond = new clstz_CommKeyWordsEN();
string strCondition = objtz_CommKeyWordsCond
.SetKeyId(objtz_CommKeyWordsEN.KeyId, "<>")
.SetTableKey(objtz_CommKeyWordsEN.TableKey, "=")
.SetKeyword(objtz_CommKeyWordsEN.Keyword, "=")
.GetCombineCondition();
objtz_CommKeyWordsEN._IsCheckProperty = true;
bool bolIsExist = clstz_CommKeyWordsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TableKey_KeyWord)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objtz_CommKeyWordsEN.Update();
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
 /// <param name = "objtz_CommKeyWords">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clstz_CommKeyWordsEN objtz_CommKeyWords)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clstz_CommKeyWordsEN objtz_CommKeyWordsCond = new clstz_CommKeyWordsEN();
string strCondition = objtz_CommKeyWordsCond
.SetTableKey(objtz_CommKeyWords.TableKey, "=")
.SetKeyword(objtz_CommKeyWords.Keyword, "=")
.GetCombineCondition();
objtz_CommKeyWords._IsCheckProperty = true;
bool bolIsExist = clstz_CommKeyWordsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objtz_CommKeyWords.KeyId = clstz_CommKeyWordsBL.GetFirstID_S(strCondition);
objtz_CommKeyWords.UpdateWithCondition(strCondition);
}
else
{
objtz_CommKeyWords.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.KeyId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.UpdateBySql2(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.KeyId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.UpdateBySql2(objtz_CommKeyWordsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strWhereCond)
{
try
{
bool bolResult = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.UpdateBySqlWithCondition(objtz_CommKeyWordsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.UpdateBySqlWithConditionTransaction(objtz_CommKeyWordsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
int intRecNum = clstz_CommKeyWordsBL.tz_CommKeyWordsDA.DelRecord(objtz_CommKeyWordsEN.KeyId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsENS">源对象</param>
 /// <param name = "objtz_CommKeyWordsENT">目标对象</param>
 public static void CopyTo(this clstz_CommKeyWordsEN objtz_CommKeyWordsENS, clstz_CommKeyWordsEN objtz_CommKeyWordsENT)
{
try
{
objtz_CommKeyWordsENT.KeyId = objtz_CommKeyWordsENS.KeyId; //关键字Id
objtz_CommKeyWordsENT.Keyword = objtz_CommKeyWordsENS.Keyword; //关键字
objtz_CommKeyWordsENT.TableName = objtz_CommKeyWordsENS.TableName; //表名
objtz_CommKeyWordsENT.TableKey = objtz_CommKeyWordsENS.TableKey; //数据表关键字值
objtz_CommKeyWordsENT.UpdUser = objtz_CommKeyWordsENS.UpdUser; //修改者
objtz_CommKeyWordsENT.UpdDate = objtz_CommKeyWordsENS.UpdDate; //修改日期
objtz_CommKeyWordsENT.Memo = objtz_CommKeyWordsENS.Memo; //说明
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
 /// <param name = "objtz_CommKeyWordsENS">源对象</param>
 /// <returns>目标对象=>clstz_CommKeyWordsEN:objtz_CommKeyWordsENT</returns>
 public static clstz_CommKeyWordsEN CopyTo(this clstz_CommKeyWordsEN objtz_CommKeyWordsENS)
{
try
{
 clstz_CommKeyWordsEN objtz_CommKeyWordsENT = new clstz_CommKeyWordsEN()
{
KeyId = objtz_CommKeyWordsENS.KeyId, //关键字Id
Keyword = objtz_CommKeyWordsENS.Keyword, //关键字
TableName = objtz_CommKeyWordsENS.TableName, //表名
TableKey = objtz_CommKeyWordsENS.TableKey, //数据表关键字值
UpdUser = objtz_CommKeyWordsENS.UpdUser, //修改者
UpdDate = objtz_CommKeyWordsENS.UpdDate, //修改日期
Memo = objtz_CommKeyWordsENS.Memo, //说明
};
 return objtz_CommKeyWordsENT;
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
public static void CheckPropertyNew(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 clstz_CommKeyWordsBL.tz_CommKeyWordsDA.CheckPropertyNew(objtz_CommKeyWordsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 clstz_CommKeyWordsBL.tz_CommKeyWordsDA.CheckProperty4Condition(objtz_CommKeyWordsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clstz_CommKeyWordsEN objtz_CommKeyWordsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.KeyId) == true)
{
string strComparisonOpKeyId = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.KeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.KeyId, objtz_CommKeyWordsCond.KeyId, strComparisonOpKeyId);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.Keyword) == true)
{
string strComparisonOpKeyword = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.Keyword, objtz_CommKeyWordsCond.Keyword, strComparisonOpKeyword);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.TableName) == true)
{
string strComparisonOpTableName = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.TableName, objtz_CommKeyWordsCond.TableName, strComparisonOpTableName);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.TableKey) == true)
{
string strComparisonOpTableKey = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.TableKey, objtz_CommKeyWordsCond.TableKey, strComparisonOpTableKey);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.UpdUser) == true)
{
string strComparisonOpUpdUser = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.UpdUser, objtz_CommKeyWordsCond.UpdUser, strComparisonOpUpdUser);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.UpdDate) == true)
{
string strComparisonOpUpdDate = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.UpdDate, objtz_CommKeyWordsCond.UpdDate, strComparisonOpUpdDate);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.Memo) == true)
{
string strComparisonOpMemo = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.Memo, objtz_CommKeyWordsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--tz_CommKeyWords(tz_通用关键字), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TableKey_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objtz_CommKeyWordsEN == null) return true;
if (objtz_CommKeyWordsEN.KeyId == null || objtz_CommKeyWordsEN.KeyId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
if (clstz_CommKeyWordsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("KeyId !=  '{0}'", objtz_CommKeyWordsEN.KeyId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
if (clstz_CommKeyWordsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--tz_CommKeyWords(tz_通用关键字), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TableKey_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objtz_CommKeyWordsEN == null) return "";
if (objtz_CommKeyWordsEN.KeyId == null || objtz_CommKeyWordsEN.KeyId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KeyId !=  '{0}'", objtz_CommKeyWordsEN.KeyId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_tz_CommKeyWords
{
public virtual bool UpdRelaTabDate(string strKeyId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clstz_CommKeyWordsBL
{
public static RelatedActions_tz_CommKeyWords relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clstz_CommKeyWordsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clstz_CommKeyWordsDA tz_CommKeyWordsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clstz_CommKeyWordsDA();
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
 public clstz_CommKeyWordsBL()
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
if (string.IsNullOrEmpty(clstz_CommKeyWordsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clstz_CommKeyWordsEN._ConnectString);
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
public static DataTable GetDataTable_tz_CommKeyWords(string strWhereCond)
{
DataTable objDT;
try
{
objDT = tz_CommKeyWordsDA.GetDataTable_tz_CommKeyWords(strWhereCond);
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
objDT = tz_CommKeyWordsDA.GetDataTable(strWhereCond);
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
objDT = tz_CommKeyWordsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = tz_CommKeyWordsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = tz_CommKeyWordsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = tz_CommKeyWordsDA.GetDataTable_Top(objTopPara);
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
objDT = tz_CommKeyWordsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = tz_CommKeyWordsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = tz_CommKeyWordsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKeyIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstByKeyIdLst(List<string> arrKeyIdLst)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKeyIdLst, true);
 string strWhereCond = string.Format("KeyId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clstz_CommKeyWordsEN> GetObjLstByKeyIdLstCache(List<string> arrKeyIdLst)
{
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLst_Sel =
arrtz_CommKeyWordsObjLstCache
.Where(x => arrKeyIdLst.Contains(x.KeyId));
return arrtz_CommKeyWordsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLst(string strWhereCond)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
public static List<clstz_CommKeyWordsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clstz_CommKeyWordsEN> GetSubObjLstCache(clstz_CommKeyWordsEN objtz_CommKeyWordsCond)
{
List<clstz_CommKeyWordsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in contz_CommKeyWords._AttributeName)
{
if (objtz_CommKeyWordsCond.IsUpdated(strFldName) == false) continue;
if (objtz_CommKeyWordsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_CommKeyWordsCond[strFldName].ToString());
}
else
{
if (objtz_CommKeyWordsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objtz_CommKeyWordsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_CommKeyWordsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objtz_CommKeyWordsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objtz_CommKeyWordsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objtz_CommKeyWordsCond[strFldName]));
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
public static List<clstz_CommKeyWordsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
public static List<clstz_CommKeyWordsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
List<clstz_CommKeyWordsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clstz_CommKeyWordsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clstz_CommKeyWordsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
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
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
public static List<clstz_CommKeyWordsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clstz_CommKeyWordsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
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
public static List<clstz_CommKeyWordsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clstz_CommKeyWordsEN> arrObjLst = new List<clstz_CommKeyWordsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
try
{
objtz_CommKeyWordsEN.KeyId = objRow[contz_CommKeyWords.KeyId].ToString().Trim(); //关键字Id
objtz_CommKeyWordsEN.Keyword = objRow[contz_CommKeyWords.Keyword].ToString().Trim(); //关键字
objtz_CommKeyWordsEN.TableName = objRow[contz_CommKeyWords.TableName].ToString().Trim(); //表名
objtz_CommKeyWordsEN.TableKey = objRow[contz_CommKeyWords.TableKey].ToString().Trim(); //数据表关键字值
objtz_CommKeyWordsEN.UpdUser = objRow[contz_CommKeyWords.UpdUser] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdUser].ToString().Trim(); //修改者
objtz_CommKeyWordsEN.UpdDate = objRow[contz_CommKeyWords.UpdDate] == DBNull.Value ? null : objRow[contz_CommKeyWords.UpdDate].ToString().Trim(); //修改日期
objtz_CommKeyWordsEN.Memo = objRow[contz_CommKeyWords.Memo] == DBNull.Value ? null : objRow[contz_CommKeyWords.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_CommKeyWordsEN.KeyId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_CommKeyWordsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Gettz_CommKeyWords(ref clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
bool bolResult = tz_CommKeyWordsDA.Gettz_CommKeyWords(ref objtz_CommKeyWordsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKeyId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_CommKeyWordsEN GetObjByKeyId(string strKeyId)
{
if (strKeyId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKeyId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKeyId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKeyId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clstz_CommKeyWordsEN objtz_CommKeyWordsEN = tz_CommKeyWordsDA.GetObjByKeyId(strKeyId);
return objtz_CommKeyWordsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clstz_CommKeyWordsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clstz_CommKeyWordsEN objtz_CommKeyWordsEN = tz_CommKeyWordsDA.GetFirstObj(strWhereCond);
 return objtz_CommKeyWordsEN;
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
public static clstz_CommKeyWordsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clstz_CommKeyWordsEN objtz_CommKeyWordsEN = tz_CommKeyWordsDA.GetObjByDataRow(objRow);
 return objtz_CommKeyWordsEN;
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
public static clstz_CommKeyWordsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clstz_CommKeyWordsEN objtz_CommKeyWordsEN = tz_CommKeyWordsDA.GetObjByDataRow(objRow);
 return objtz_CommKeyWordsEN;
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
 /// <param name = "strKeyId">所给的关键字</param>
 /// <param name = "lsttz_CommKeyWordsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clstz_CommKeyWordsEN GetObjByKeyIdFromList(string strKeyId, List<clstz_CommKeyWordsEN> lsttz_CommKeyWordsObjLst)
{
foreach (clstz_CommKeyWordsEN objtz_CommKeyWordsEN in lsttz_CommKeyWordsObjLst)
{
if (objtz_CommKeyWordsEN.KeyId == strKeyId)
{
return objtz_CommKeyWordsEN;
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
 string strKeyId;
 try
 {
 strKeyId = new clstz_CommKeyWordsDA().GetFirstID(strWhereCond);
 return strKeyId;
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
 arrList = tz_CommKeyWordsDA.GetID(strWhereCond);
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
bool bolIsExist = tz_CommKeyWordsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKeyId)
{
if (string.IsNullOrEmpty(strKeyId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKeyId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = tz_CommKeyWordsDA.IsExist(strKeyId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strKeyId">关键字Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strKeyId, string strOpUser)
{
clstz_CommKeyWordsEN objtz_CommKeyWordsEN = clstz_CommKeyWordsBL.GetObjByKeyId(strKeyId);
objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objtz_CommKeyWordsEN.UpdUser = strOpUser;
return clstz_CommKeyWordsBL.UpdateBySql2(objtz_CommKeyWordsEN);
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
 bolIsExist = clstz_CommKeyWordsDA.IsExistTable();
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
 bolIsExist = tz_CommKeyWordsDA.IsExistTable(strTabName);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objtz_CommKeyWordsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据表关键字值 = [{0}],关键字 = [{1}]的数据已经存在!(in clstz_CommKeyWordsBL.AddNewRecordBySql2)", objtz_CommKeyWordsEN.TableKey,objtz_CommKeyWordsEN.Keyword);
throw new Exception(strMsg);
}
try
{
bool bolResult = tz_CommKeyWordsDA.AddNewRecordBySQL2(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objtz_CommKeyWordsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据表关键字值 = [{0}],关键字 = [{1}]的数据已经存在!(in clstz_CommKeyWordsBL.AddNewRecordBySql2WithReturnKey)", objtz_CommKeyWordsEN.TableKey,objtz_CommKeyWordsEN.Keyword);
throw new Exception(strMsg);
}
try
{
string strKey = tz_CommKeyWordsDA.AddNewRecordBySQL2WithReturnKey(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
bool bolResult = tz_CommKeyWordsDA.Update(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.KeyId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = tz_CommKeyWordsDA.UpdateBySql2(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsBL.ReFreshCache();

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
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
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strKeyId)
{
try
{
 clstz_CommKeyWordsEN objtz_CommKeyWordsEN = clstz_CommKeyWordsBL.GetObjByKeyId(strKeyId);

if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(objtz_CommKeyWordsEN.KeyId, objtz_CommKeyWordsEN.UpdUser);
}
if (objtz_CommKeyWordsEN != null)
{
int intRecNum = tz_CommKeyWordsDA.DelRecord(strKeyId);
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
/// <param name="strKeyId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strKeyId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
//删除与表:[tz_CommKeyWords]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//contz_CommKeyWords.KeyId,
//strKeyId);
//        clstz_CommKeyWordsBL.Deltz_CommKeyWordssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clstz_CommKeyWordsBL.DelRecord(strKeyId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clstz_CommKeyWordsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKeyId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strKeyId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strKeyId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clstz_CommKeyWordsBL.relatedActions != null)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(strKeyId, "UpdRelaTabDate");
}
bool bolResult = tz_CommKeyWordsDA.DelRecord(strKeyId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrKeyIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deltz_CommKeyWordss(List<string> arrKeyIdLst)
{
if (arrKeyIdLst.Count == 0) return 0;
try
{
if (clstz_CommKeyWordsBL.relatedActions != null)
{
foreach (var strKeyId in arrKeyIdLst)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(strKeyId, "UpdRelaTabDate");
}
}
int intDelRecNum = tz_CommKeyWordsDA.Deltz_CommKeyWords(arrKeyIdLst);
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
public static int Deltz_CommKeyWordssByCond(string strWhereCond)
{
try
{
if (clstz_CommKeyWordsBL.relatedActions != null)
{
List<string> arrKeyId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strKeyId in arrKeyId)
{
clstz_CommKeyWordsBL.relatedActions.UpdRelaTabDate(strKeyId, "UpdRelaTabDate");
}
}
int intRecNum = tz_CommKeyWordsDA.Deltz_CommKeyWords(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[tz_CommKeyWords]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strKeyId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strKeyId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clstz_CommKeyWordsDA.GetSpecSQLObj();
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
//删除与表:[tz_CommKeyWords]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clstz_CommKeyWordsBL.DelRecord(strKeyId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clstz_CommKeyWordsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKeyId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objtz_CommKeyWordsENS">源对象</param>
 /// <param name = "objtz_CommKeyWordsENT">目标对象</param>
 public static void CopyTo(clstz_CommKeyWordsEN objtz_CommKeyWordsENS, clstz_CommKeyWordsEN objtz_CommKeyWordsENT)
{
try
{
objtz_CommKeyWordsENT.KeyId = objtz_CommKeyWordsENS.KeyId; //关键字Id
objtz_CommKeyWordsENT.Keyword = objtz_CommKeyWordsENS.Keyword; //关键字
objtz_CommKeyWordsENT.TableName = objtz_CommKeyWordsENS.TableName; //表名
objtz_CommKeyWordsENT.TableKey = objtz_CommKeyWordsENS.TableKey; //数据表关键字值
objtz_CommKeyWordsENT.UpdUser = objtz_CommKeyWordsENS.UpdUser; //修改者
objtz_CommKeyWordsENT.UpdDate = objtz_CommKeyWordsENS.UpdDate; //修改日期
objtz_CommKeyWordsENT.Memo = objtz_CommKeyWordsENS.Memo; //说明
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
 /// <param name = "objtz_CommKeyWordsEN">源简化对象</param>
 public static void SetUpdFlag(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
objtz_CommKeyWordsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objtz_CommKeyWordsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(contz_CommKeyWords.KeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.KeyId = objtz_CommKeyWordsEN.KeyId; //关键字Id
}
if (arrFldSet.Contains(contz_CommKeyWords.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.Keyword = objtz_CommKeyWordsEN.Keyword; //关键字
}
if (arrFldSet.Contains(contz_CommKeyWords.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.TableName = objtz_CommKeyWordsEN.TableName; //表名
}
if (arrFldSet.Contains(contz_CommKeyWords.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.TableKey = objtz_CommKeyWordsEN.TableKey; //数据表关键字值
}
if (arrFldSet.Contains(contz_CommKeyWords.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.UpdUser = objtz_CommKeyWordsEN.UpdUser == "[null]" ? null :  objtz_CommKeyWordsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(contz_CommKeyWords.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.UpdDate = objtz_CommKeyWordsEN.UpdDate == "[null]" ? null :  objtz_CommKeyWordsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(contz_CommKeyWords.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_CommKeyWordsEN.Memo = objtz_CommKeyWordsEN.Memo == "[null]" ? null :  objtz_CommKeyWordsEN.Memo; //说明
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
 /// <param name = "objtz_CommKeyWordsEN">源简化对象</param>
 public static void AccessFldValueNull(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
if (objtz_CommKeyWordsEN.UpdUser == "[null]") objtz_CommKeyWordsEN.UpdUser = null; //修改者
if (objtz_CommKeyWordsEN.UpdDate == "[null]") objtz_CommKeyWordsEN.UpdDate = null; //修改日期
if (objtz_CommKeyWordsEN.Memo == "[null]") objtz_CommKeyWordsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 tz_CommKeyWordsDA.CheckPropertyNew(objtz_CommKeyWordsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 tz_CommKeyWordsDA.CheckProperty4Condition(objtz_CommKeyWordsEN);
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
if (clstz_CommKeyWordsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clstz_CommKeyWordsBL没有刷新缓存机制(clstz_CommKeyWordsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KeyId");
//if (arrtz_CommKeyWordsObjLstCache == null)
//{
//arrtz_CommKeyWordsObjLstCache = tz_CommKeyWordsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKeyId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clstz_CommKeyWordsEN GetObjByKeyIdCache(string strKeyId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLst_Sel =
arrtz_CommKeyWordsObjLstCache
.Where(x=> x.KeyId == strKeyId 
);
if (arrtz_CommKeyWordsObjLst_Sel.Count() == 0)
{
   clstz_CommKeyWordsEN obj = clstz_CommKeyWordsBL.GetObjByKeyId(strKeyId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrtz_CommKeyWordsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetAlltz_CommKeyWordsObjLstCache()
{
//获取缓存中的对象列表
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = GetObjLstCache(); 
return arrtz_CommKeyWordsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrtz_CommKeyWordsObjLstCache;
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
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
CacheHelper.Remove(strKey);
clstz_CommKeyWordsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clstz_CommKeyWordsEN._RefreshTimeLst.Count == 0) return "";
return clstz_CommKeyWordsEN._RefreshTimeLst[clstz_CommKeyWordsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clstz_CommKeyWordsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
CacheHelper.Remove(strKey);
clstz_CommKeyWordsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clstz_CommKeyWordsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--tz_CommKeyWords(tz_通用关键字)
 /// 唯一性条件:TableKey_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检测记录是否存在
string strResult = tz_CommKeyWordsDA.GetUniCondStr(objtz_CommKeyWordsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strKeyId)
{
if (strInFldName != contz_CommKeyWords.KeyId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (contz_CommKeyWords._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", contz_CommKeyWords._AttributeName));
throw new Exception(strMsg);
}
var objtz_CommKeyWords = clstz_CommKeyWordsBL.GetObjByKeyIdCache(strKeyId);
if (objtz_CommKeyWords == null) return "";
return objtz_CommKeyWords[strOutFldName].ToString();
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
int intRecCount = clstz_CommKeyWordsDA.GetRecCount(strTabName);
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
int intRecCount = clstz_CommKeyWordsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clstz_CommKeyWordsDA.GetRecCount();
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
int intRecCount = clstz_CommKeyWordsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clstz_CommKeyWordsEN objtz_CommKeyWordsCond)
{
List<clstz_CommKeyWordsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in contz_CommKeyWords._AttributeName)
{
if (objtz_CommKeyWordsCond.IsUpdated(strFldName) == false) continue;
if (objtz_CommKeyWordsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_CommKeyWordsCond[strFldName].ToString());
}
else
{
if (objtz_CommKeyWordsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objtz_CommKeyWordsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_CommKeyWordsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objtz_CommKeyWordsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objtz_CommKeyWordsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objtz_CommKeyWordsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objtz_CommKeyWordsCond[strFldName]));
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
 List<string> arrList = clstz_CommKeyWordsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = tz_CommKeyWordsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = tz_CommKeyWordsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = tz_CommKeyWordsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clstz_CommKeyWordsDA.SetFldValue(clstz_CommKeyWordsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = tz_CommKeyWordsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clstz_CommKeyWordsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clstz_CommKeyWordsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clstz_CommKeyWordsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[tz_CommKeyWords] "); 
 strCreateTabCode.Append(" ( "); 
 // /**关键字Id*/ 
 strCreateTabCode.Append(" KeyId varchar(8) primary key identity, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(50) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TableName varchar(100) not Null, "); 
 // /**数据表关键字值*/ 
 strCreateTabCode.Append(" TableKey varchar(100) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4tz_CommKeyWords : clsCommFun4BL
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
clstz_CommKeyWordsBL.ReFreshThisCache();
}
}

}