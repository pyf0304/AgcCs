
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataFieldTypeBL
 表名:DataFieldType(00050596)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class clsDataFieldTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDataFieldTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataFieldTypeEN GetObj(this K_DataFieldTypeId_DataFieldType myKey)
{
clsDataFieldTypeEN objDataFieldTypeEN = clsDataFieldTypeBL.DataFieldTypeDA.GetObjByDataFieldTypeId(myKey.Value);
return objDataFieldTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataFieldTypeBL.IsExist(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objDataFieldTypeEN.DataFieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDataFieldTypeBL.DataFieldTypeDA.AddNewRecordBySQL2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsDataFieldTypeEN objDataFieldTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDataFieldTypeBL.IsExist(objDataFieldTypeEN.DataFieldTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDataFieldTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDataFieldTypeEN.AddNewRecord();
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataFieldTypeBL.IsExist(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objDataFieldTypeEN.DataFieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDataFieldTypeBL.DataFieldTypeDA.AddNewRecordBySQL2WithReturnKey(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetDataFieldTypeId(this clsDataFieldTypeEN objDataFieldTypeEN, string strDataFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataFieldTypeId, 2, conDataFieldType.DataFieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataFieldTypeId, 2, conDataFieldType.DataFieldTypeId);
}
objDataFieldTypeEN.DataFieldTypeId = strDataFieldTypeId; //数据字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.DataFieldTypeId) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.DataFieldTypeId, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.DataFieldTypeId] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetDataFieldTypeName(this clsDataFieldTypeEN objDataFieldTypeEN, string strDataFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataFieldTypeName, conDataFieldType.DataFieldTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataFieldTypeName, 30, conDataFieldType.DataFieldTypeName);
}
objDataFieldTypeEN.DataFieldTypeName = strDataFieldTypeName; //数据字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.DataFieldTypeName) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.DataFieldTypeName, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.DataFieldTypeName] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetDataFieldTypeENName(this clsDataFieldTypeEN objDataFieldTypeEN, string strDataFieldTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataFieldTypeENName, 30, conDataFieldType.DataFieldTypeENName);
}
objDataFieldTypeEN.DataFieldTypeENName = strDataFieldTypeENName; //数据字段类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.DataFieldTypeENName) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.DataFieldTypeENName, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.DataFieldTypeENName] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetUpdDate(this clsDataFieldTypeEN objDataFieldTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataFieldType.UpdDate);
}
objDataFieldTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.UpdDate) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.UpdDate, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.UpdDate] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetUpdUser(this clsDataFieldTypeEN objDataFieldTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataFieldType.UpdUser);
}
objDataFieldTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.UpdUser) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.UpdUser, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.UpdUser] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataFieldTypeEN SetMemo(this clsDataFieldTypeEN objDataFieldTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataFieldType.Memo);
}
objDataFieldTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataFieldTypeEN.dicFldComparisonOp.ContainsKey(conDataFieldType.Memo) == false)
{
objDataFieldTypeEN.dicFldComparisonOp.Add(conDataFieldType.Memo, strComparisonOp);
}
else
{
objDataFieldTypeEN.dicFldComparisonOp[conDataFieldType.Memo] = strComparisonOp;
}
}
return objDataFieldTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataFieldTypeEN objDataFieldTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataFieldTypeEN.CheckPropertyNew();
clsDataFieldTypeEN objDataFieldTypeCond = new clsDataFieldTypeEN();
string strCondition = objDataFieldTypeCond
.SetDataFieldTypeId(objDataFieldTypeEN.DataFieldTypeId, "=")
.GetCombineCondition();
objDataFieldTypeEN._IsCheckProperty = true;
bool bolIsExist = clsDataFieldTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataFieldTypeEN.Update();
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataFieldTypeBL.DataFieldTypeDA.UpdateBySql2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataFieldTypeEN objDataFieldTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataFieldTypeBL.DataFieldTypeDA.UpdateBySql2(objDataFieldTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataFieldTypeEN objDataFieldTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsDataFieldTypeBL.DataFieldTypeDA.UpdateBySqlWithCondition(objDataFieldTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataFieldTypeEN objDataFieldTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataFieldTypeBL.DataFieldTypeDA.UpdateBySqlWithConditionTransaction(objDataFieldTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataFieldTypeEN objDataFieldTypeEN)
{
try
{
int intRecNum = clsDataFieldTypeBL.DataFieldTypeDA.DelRecord(objDataFieldTypeEN.DataFieldTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <param name = "objDataFieldTypeENT">目标对象</param>
 public static void CopyTo(this clsDataFieldTypeEN objDataFieldTypeENS, clsDataFieldTypeEN objDataFieldTypeENT)
{
try
{
objDataFieldTypeENT.DataFieldTypeId = objDataFieldTypeENS.DataFieldTypeId; //数据字段类型Id
objDataFieldTypeENT.DataFieldTypeName = objDataFieldTypeENS.DataFieldTypeName; //数据字段类型名
objDataFieldTypeENT.DataFieldTypeENName = objDataFieldTypeENS.DataFieldTypeENName; //数据字段类型英文名
objDataFieldTypeENT.UpdDate = objDataFieldTypeENS.UpdDate; //修改日期
objDataFieldTypeENT.UpdUser = objDataFieldTypeENS.UpdUser; //修改者
objDataFieldTypeENT.Memo = objDataFieldTypeENS.Memo; //说明
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
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <returns>目标对象=>clsDataFieldTypeEN:objDataFieldTypeENT</returns>
 public static clsDataFieldTypeEN CopyTo(this clsDataFieldTypeEN objDataFieldTypeENS)
{
try
{
 clsDataFieldTypeEN objDataFieldTypeENT = new clsDataFieldTypeEN()
{
DataFieldTypeId = objDataFieldTypeENS.DataFieldTypeId, //数据字段类型Id
DataFieldTypeName = objDataFieldTypeENS.DataFieldTypeName, //数据字段类型名
DataFieldTypeENName = objDataFieldTypeENS.DataFieldTypeENName, //数据字段类型英文名
UpdDate = objDataFieldTypeENS.UpdDate, //修改日期
UpdUser = objDataFieldTypeENS.UpdUser, //修改者
Memo = objDataFieldTypeENS.Memo, //说明
};
 return objDataFieldTypeENT;
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
public static void CheckPropertyNew(this clsDataFieldTypeEN objDataFieldTypeEN)
{
 clsDataFieldTypeBL.DataFieldTypeDA.CheckPropertyNew(objDataFieldTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataFieldTypeEN objDataFieldTypeEN)
{
 clsDataFieldTypeBL.DataFieldTypeDA.CheckProperty4Condition(objDataFieldTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataFieldTypeEN objDataFieldTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.DataFieldTypeId) == true)
{
string strComparisonOpDataFieldTypeId = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.DataFieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.DataFieldTypeId, objDataFieldTypeCond.DataFieldTypeId, strComparisonOpDataFieldTypeId);
}
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.DataFieldTypeName) == true)
{
string strComparisonOpDataFieldTypeName = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.DataFieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.DataFieldTypeName, objDataFieldTypeCond.DataFieldTypeName, strComparisonOpDataFieldTypeName);
}
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.DataFieldTypeENName) == true)
{
string strComparisonOpDataFieldTypeENName = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.DataFieldTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.DataFieldTypeENName, objDataFieldTypeCond.DataFieldTypeENName, strComparisonOpDataFieldTypeENName);
}
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.UpdDate, objDataFieldTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.UpdUser, objDataFieldTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataFieldTypeCond.IsUpdated(conDataFieldType.Memo) == true)
{
string strComparisonOpMemo = objDataFieldTypeCond.dicFldComparisonOp[conDataFieldType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataFieldType.Memo, objDataFieldTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataFieldType
{
public virtual bool UpdRelaTabDate(string strDataFieldTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumDataFieldType
{
 /// <summary>
 /// 给定值
 /// </summary>
public const string GivenValue_01 = "01";
 /// <summary>
 /// 缺省值
 /// </summary>
public const string DefaultValue_02 = "02";
 /// <summary>
 /// 缓存分类字段
 /// </summary>
public const string CacheClassifyField_03 = "03";
 /// <summary>
 /// 界面变量
 /// </summary>
public const string ViewVariable_04 = "04";
}
 /// <summary>
 /// 数据字段类型(DataFieldType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataFieldTypeBL
{
public static RelatedActions_DataFieldType relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "DataFieldTypeListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "DataFieldTypeList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsDataFieldTypeEN> arrDataFieldTypeObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataFieldTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataFieldTypeDA DataFieldTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataFieldTypeDA();
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
 public clsDataFieldTypeBL()
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
if (string.IsNullOrEmpty(clsDataFieldTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataFieldTypeEN._ConnectString);
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
objDS = DataFieldTypeDA.GetDataSet(strWhereCond);
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
objDS = DataFieldTypeDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = DataFieldTypeDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_DataFieldType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataFieldTypeDA.GetDataTable_DataFieldType(strWhereCond);
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
objDT = DataFieldTypeDA.GetDataTable(strWhereCond);
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
objDT = DataFieldTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataFieldTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataFieldTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataFieldTypeDA.GetDataTable_Top(objTopPara);
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
objDT = DataFieldTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataFieldTypeDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = DataFieldTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataFieldTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = DataFieldTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = DataFieldTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = DataFieldTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = DataFieldTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrDataFieldTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLstByDataFieldTypeIdLst(List<string> arrDataFieldTypeIdLst)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataFieldTypeIdLst, true);
 string strWhereCond = string.Format("DataFieldTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataFieldTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataFieldTypeEN> GetObjLstByDataFieldTypeIdLstCache(List<string> arrDataFieldTypeIdLst)
{
string strKey = string.Format("{0}", clsDataFieldTypeEN._CurrTabName);
List<clsDataFieldTypeEN> arrDataFieldTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataFieldTypeEN> arrDataFieldTypeObjLst_Sel =
arrDataFieldTypeObjLstCache
.Where(x => arrDataFieldTypeIdLst.Contains(x.DataFieldTypeId));
return arrDataFieldTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLst(string strWhereCond)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static List<clsDataFieldTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataFieldTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataFieldTypeEN> GetSubObjLstCache(clsDataFieldTypeEN objDataFieldTypeCond)
{
List<clsDataFieldTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataFieldTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataFieldType.AttributeName)
{
if (objDataFieldTypeCond.IsUpdated(strFldName) == false) continue;
if (objDataFieldTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else
{
if (objDataFieldTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataFieldTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataFieldTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
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
public static List<clsDataFieldTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static List<clsDataFieldTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
List<clsDataFieldTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataFieldTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataFieldTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataFieldTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
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
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static List<clsDataFieldTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataFieldTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static List<clsDataFieldTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static IEnumerable<clsDataFieldTypeEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsDataFieldTypeEN objDataFieldTypeCond, string strOrderBy)
{
List<clsDataFieldTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataFieldTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataFieldType.AttributeName)
{
if (objDataFieldTypeCond.IsUpdated(strFldName) == false) continue;
if (objDataFieldTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else
{
if (objDataFieldTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataFieldTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataFieldTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
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
public static IEnumerable<clsDataFieldTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsDataFieldTypeEN objDataFieldTypeCond = JsonConvert.DeserializeObject<clsDataFieldTypeEN>(objPagerPara.whereCond);
if (objDataFieldTypeCond.sfFldComparisonOp == null)
{
objDataFieldTypeCond.dicFldComparisonOp = null;
}
else
{
objDataFieldTypeCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objDataFieldTypeCond.sfFldComparisonOp);
}
clsDataFieldTypeBL.SetUpdFlag(objDataFieldTypeCond);
 try
{
CheckProperty4Condition(objDataFieldTypeCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsDataFieldTypeBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objDataFieldTypeCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsDataFieldTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
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
public static List<clsDataFieldTypeEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataFieldTypeEN> arrObjLst = new List<clsDataFieldTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
try
{
objDataFieldTypeEN.DataFieldTypeId = objRow[conDataFieldType.DataFieldTypeId].ToString().Trim(); //数据字段类型Id
objDataFieldTypeEN.DataFieldTypeName = objRow[conDataFieldType.DataFieldTypeName].ToString().Trim(); //数据字段类型名
objDataFieldTypeEN.DataFieldTypeENName = objRow[conDataFieldType.DataFieldTypeENName] == DBNull.Value ? null : objRow[conDataFieldType.DataFieldTypeENName].ToString().Trim(); //数据字段类型英文名
objDataFieldTypeEN.UpdDate = objRow[conDataFieldType.UpdDate] == DBNull.Value ? null : objRow[conDataFieldType.UpdDate].ToString().Trim(); //修改日期
objDataFieldTypeEN.UpdUser = objRow[conDataFieldType.UpdUser] == DBNull.Value ? null : objRow[conDataFieldType.UpdUser].ToString().Trim(); //修改者
objDataFieldTypeEN.Memo = objRow[conDataFieldType.Memo] == DBNull.Value ? null : objRow[conDataFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataFieldTypeEN.DataFieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataFieldTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataFieldType(ref clsDataFieldTypeEN objDataFieldTypeEN)
{
bool bolResult = DataFieldTypeDA.GetDataFieldType(ref objDataFieldTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDataFieldTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataFieldTypeEN GetObjByDataFieldTypeId(string strDataFieldTypeId)
{
if (strDataFieldTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDataFieldTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDataFieldTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDataFieldTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDataFieldTypeEN objDataFieldTypeEN = DataFieldTypeDA.GetObjByDataFieldTypeId(strDataFieldTypeId);
return objDataFieldTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataFieldTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataFieldTypeEN objDataFieldTypeEN = DataFieldTypeDA.GetFirstObj(strWhereCond);
 return objDataFieldTypeEN;
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
public static clsDataFieldTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataFieldTypeEN objDataFieldTypeEN = DataFieldTypeDA.GetObjByDataRow(objRow);
 return objDataFieldTypeEN;
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
public static clsDataFieldTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataFieldTypeEN objDataFieldTypeEN = DataFieldTypeDA.GetObjByDataRow(objRow);
 return objDataFieldTypeEN;
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
 /// <param name = "strDataFieldTypeId">所给的关键字</param>
 /// <param name = "lstDataFieldTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataFieldTypeEN GetObjByDataFieldTypeIdFromList(string strDataFieldTypeId, List<clsDataFieldTypeEN> lstDataFieldTypeObjLst)
{
foreach (clsDataFieldTypeEN objDataFieldTypeEN in lstDataFieldTypeObjLst)
{
if (objDataFieldTypeEN.DataFieldTypeId == strDataFieldTypeId)
{
return objDataFieldTypeEN;
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
 string strDataFieldTypeId;
 try
 {
 strDataFieldTypeId = new clsDataFieldTypeDA().GetFirstID(strWhereCond);
 return strDataFieldTypeId;
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
 arrList = DataFieldTypeDA.GetID(strWhereCond);
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
bool bolIsExist = DataFieldTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDataFieldTypeId)
{
if (string.IsNullOrEmpty(strDataFieldTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDataFieldTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DataFieldTypeDA.IsExist(strDataFieldTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDataFieldTypeId">数据字段类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDataFieldTypeId, string strOpUser)
{
clsDataFieldTypeEN objDataFieldTypeEN = clsDataFieldTypeBL.GetObjByDataFieldTypeId(strDataFieldTypeId);
objDataFieldTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDataFieldTypeEN.UpdUser = strOpUser;
return clsDataFieldTypeBL.UpdateBySql2(objDataFieldTypeEN);
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
 bolIsExist = clsDataFieldTypeDA.IsExistTable();
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
 bolIsExist = DataFieldTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataFieldTypeBL.IsExist(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objDataFieldTypeEN.DataFieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DataFieldTypeDA.AddNewRecordBySQL2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataFieldTypeBL.IsExist(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objDataFieldTypeEN.DataFieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DataFieldTypeDA.AddNewRecordBySQL2WithReturnKey(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "strDataFieldTypeObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strDataFieldTypeObjXml)
{
clsDataFieldTypeEN objDataFieldTypeEN = GetObjFromXmlStr(strDataFieldTypeObjXml);
try
{
bool bolResult = DataFieldTypeDA.AddNewRecordBySQL2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataFieldTypeEN objDataFieldTypeEN)
{
try
{
bool bolResult = DataFieldTypeDA.Update(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "objDataFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataFieldTypeEN objDataFieldTypeEN)
{
 if (string.IsNullOrEmpty(objDataFieldTypeEN.DataFieldTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataFieldTypeDA.UpdateBySql2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "strDataFieldTypeObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strDataFieldTypeObjXml)
{
clsDataFieldTypeEN objDataFieldTypeEN = GetObjFromXmlStr(strDataFieldTypeObjXml);
try
{
bool bolResult = DataFieldTypeDA.UpdateBySql2(objDataFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataFieldTypeBL.ReFreshCache();

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDataFieldTypeId)
{
try
{
 clsDataFieldTypeEN objDataFieldTypeEN = clsDataFieldTypeBL.GetObjByDataFieldTypeId(strDataFieldTypeId);

if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(objDataFieldTypeEN.DataFieldTypeId, objDataFieldTypeEN.UpdUser);
}
if (objDataFieldTypeEN != null)
{
int intRecNum = DataFieldTypeDA.DelRecord(strDataFieldTypeId);
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
/// <param name="strDataFieldTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDataFieldTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
//删除与表:[DataFieldType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataFieldType.DataFieldTypeId,
//strDataFieldTypeId);
//        clsDataFieldTypeBL.DelDataFieldTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataFieldTypeBL.DelRecord(strDataFieldTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataFieldTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strDataFieldTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDataFieldTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(strDataFieldTypeId, "UpdRelaTabDate");
}
bool bolResult = DataFieldTypeDA.DelRecord(strDataFieldTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strDataFieldTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDataFieldTypeId) 
{
try
{
if (clsDataFieldTypeBL.relatedActions != null)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(strDataFieldTypeId, "UpdRelaTabDate");
}
bool bolResult = DataFieldTypeDA.DelRecordBySP(strDataFieldTypeId);
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
 /// <param name = "arrDataFieldTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataFieldTypes(List<string> arrDataFieldTypeIdLst)
{
if (arrDataFieldTypeIdLst.Count == 0) return 0;
try
{
if (clsDataFieldTypeBL.relatedActions != null)
{
foreach (var strDataFieldTypeId in arrDataFieldTypeIdLst)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(strDataFieldTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = DataFieldTypeDA.DelDataFieldType(arrDataFieldTypeIdLst);
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
public static int DelDataFieldTypesByCond(string strWhereCond)
{
try
{
if (clsDataFieldTypeBL.relatedActions != null)
{
List<string> arrDataFieldTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataFieldTypeId in arrDataFieldTypeId)
{
clsDataFieldTypeBL.relatedActions.UpdRelaTabDate(strDataFieldTypeId, "UpdRelaTabDate");
}
}
int intRecNum = DataFieldTypeDA.DelDataFieldType(strWhereCond);
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
/// 这里仅仅是演示函数，使用时请复制到扩展类:[DataFieldType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDataFieldTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDataFieldTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataFieldTypeDA.GetSpecSQLObj();
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
//删除与表:[DataFieldType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataFieldTypeBL.DelRecord(strDataFieldTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataFieldTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strDataFieldTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <param name = "objDataFieldTypeENT">目标对象</param>
 public static void CopyTo(clsDataFieldTypeEN objDataFieldTypeENS, clsDataFieldTypeEN objDataFieldTypeENT)
{
try
{
objDataFieldTypeENT.DataFieldTypeId = objDataFieldTypeENS.DataFieldTypeId; //数据字段类型Id
objDataFieldTypeENT.DataFieldTypeName = objDataFieldTypeENS.DataFieldTypeName; //数据字段类型名
objDataFieldTypeENT.DataFieldTypeENName = objDataFieldTypeENS.DataFieldTypeENName; //数据字段类型英文名
objDataFieldTypeENT.UpdDate = objDataFieldTypeENS.UpdDate; //修改日期
objDataFieldTypeENT.UpdUser = objDataFieldTypeENS.UpdUser; //修改者
objDataFieldTypeENT.Memo = objDataFieldTypeENS.Memo; //说明
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
 /// <param name = "objDataFieldTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsDataFieldTypeEN objDataFieldTypeEN)
{
try
{
objDataFieldTypeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objDataFieldTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataFieldType.DataFieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.DataFieldTypeId = objDataFieldTypeEN.DataFieldTypeId; //数据字段类型Id
}
if (arrFldSet.Contains(conDataFieldType.DataFieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.DataFieldTypeName = objDataFieldTypeEN.DataFieldTypeName; //数据字段类型名
}
if (arrFldSet.Contains(conDataFieldType.DataFieldTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.DataFieldTypeENName = objDataFieldTypeEN.DataFieldTypeENName == "[null]" ? null :  objDataFieldTypeEN.DataFieldTypeENName; //数据字段类型英文名
}
if (arrFldSet.Contains(conDataFieldType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.UpdDate = objDataFieldTypeEN.UpdDate == "[null]" ? null :  objDataFieldTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDataFieldType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.UpdUser = objDataFieldTypeEN.UpdUser == "[null]" ? null :  objDataFieldTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDataFieldType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataFieldTypeEN.Memo = objDataFieldTypeEN.Memo == "[null]" ? null :  objDataFieldTypeEN.Memo; //说明
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
 /// <param name = "objDataFieldTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataFieldTypeEN objDataFieldTypeEN)
{
try
{
if (objDataFieldTypeEN.DataFieldTypeENName == "[null]") objDataFieldTypeEN.DataFieldTypeENName = null; //数据字段类型英文名
if (objDataFieldTypeEN.UpdDate == "[null]") objDataFieldTypeEN.UpdDate = null; //修改日期
if (objDataFieldTypeEN.UpdUser == "[null]") objDataFieldTypeEN.UpdUser = null; //修改者
if (objDataFieldTypeEN.Memo == "[null]") objDataFieldTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDataFieldTypeEN objDataFieldTypeEN)
{
 DataFieldTypeDA.CheckPropertyNew(objDataFieldTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataFieldTypeEN objDataFieldTypeEN)
{
 DataFieldTypeDA.CheckProperty4Condition(objDataFieldTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_DataFieldTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataFieldType.DataFieldTypeId); 
List<clsDataFieldTypeEN> arrObjLst = clsDataFieldTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN()
{
DataFieldTypeId = "0",
DataFieldTypeName = "选[数据字段类型]..."
};
arrObjLst.Insert(0, objDataFieldTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataFieldType.DataFieldTypeId;
objComboBox.DisplayMember = conDataFieldType.DataFieldTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlDataFieldTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据字段类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDataFieldType.DataFieldTypeId); 
IEnumerable<clsDataFieldTypeEN> arrObjLst = clsDataFieldTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conDataFieldType.DataFieldTypeId;
objDDL.DataTextField = conDataFieldType.DataFieldTypeName;
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
public static void BindDdlDataFieldTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据字段类型]...","0");
List<clsDataFieldTypeEN> arrDataFieldTypeObjLst = GetAllDataFieldTypeObjLstCache(); 
objDDL.DataValueField = conDataFieldType.DataFieldTypeId;
objDDL.DataTextField = conDataFieldType.DataFieldTypeName;
objDDL.DataSource = arrDataFieldTypeObjLst;
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
if (clsDataFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataFieldTypeBL没有刷新缓存机制(clsDataFieldTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataFieldTypeId");
//if (arrDataFieldTypeObjLstCache == null)
//{
//arrDataFieldTypeObjLstCache = DataFieldTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDataFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataFieldTypeEN GetObjByDataFieldTypeIdCache(string strDataFieldTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDataFieldTypeEN._CurrTabName);
List<clsDataFieldTypeEN> arrDataFieldTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataFieldTypeEN> arrDataFieldTypeObjLst_Sel =
arrDataFieldTypeObjLstCache
.Where(x=> x.DataFieldTypeId == strDataFieldTypeId 
);
if (arrDataFieldTypeObjLst_Sel.Count() == 0)
{
   clsDataFieldTypeEN obj = clsDataFieldTypeBL.GetObjByDataFieldTypeId(strDataFieldTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDataFieldTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataFieldTypeNameByDataFieldTypeIdCache(string strDataFieldTypeId)
{
if (string.IsNullOrEmpty(strDataFieldTypeId) == true) return "";
//获取缓存中的对象列表
clsDataFieldTypeEN objDataFieldType = GetObjByDataFieldTypeIdCache(strDataFieldTypeId);
if (objDataFieldType == null) return "";
return objDataFieldType.DataFieldTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataFieldTypeIdCache(string strDataFieldTypeId)
{
if (string.IsNullOrEmpty(strDataFieldTypeId) == true) return "";
//获取缓存中的对象列表
clsDataFieldTypeEN objDataFieldType = GetObjByDataFieldTypeIdCache(strDataFieldTypeId);
if (objDataFieldType == null) return "";
return objDataFieldType.DataFieldTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataFieldTypeEN> GetAllDataFieldTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsDataFieldTypeEN> arrDataFieldTypeObjLstCache = GetObjLstCache(); 
return arrDataFieldTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataFieldTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDataFieldTypeEN._CurrTabName);
List<clsDataFieldTypeEN> arrDataFieldTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataFieldTypeObjLstCache;
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
string strKey = string.Format("{0}", clsDataFieldTypeEN._CurrTabName);
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
if (clsDataFieldTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataFieldTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataFieldTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstDataFieldTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsDataFieldTypeEN> lstDataFieldTypeObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstDataFieldTypeObjLst, writer);
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
 /// <param name = "lstDataFieldTypeObjLst">[clsDataFieldTypeEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsDataFieldTypeEN> lstDataFieldTypeObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsDataFieldTypeBL.listXmlNode);
writer.WriteStartElement(clsDataFieldTypeBL.itemsXmlNode);
foreach (clsDataFieldTypeEN objDataFieldTypeEN in lstDataFieldTypeObjLst)
{
clsDataFieldTypeBL.SerializeXML(writer, objDataFieldTypeEN);
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
 /// <param name = "objDataFieldTypeEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsDataFieldTypeEN objDataFieldTypeEN)
{
writer.WriteStartElement(clsDataFieldTypeBL.itemXmlNode);
 
if (objDataFieldTypeEN.DataFieldTypeId != null)
{
writer.WriteElementString(conDataFieldType.DataFieldTypeId, objDataFieldTypeEN.DataFieldTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objDataFieldTypeEN.DataFieldTypeName != null)
{
writer.WriteElementString(conDataFieldType.DataFieldTypeName, objDataFieldTypeEN.DataFieldTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objDataFieldTypeEN.DataFieldTypeENName != null)
{
writer.WriteElementString(conDataFieldType.DataFieldTypeENName, objDataFieldTypeEN.DataFieldTypeENName.ToString(CultureInfo.InvariantCulture));
}
 
if (objDataFieldTypeEN.UpdDate != null)
{
writer.WriteElementString(conDataFieldType.UpdDate, objDataFieldTypeEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objDataFieldTypeEN.UpdUser != null)
{
writer.WriteElementString(conDataFieldType.UpdUser, objDataFieldTypeEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objDataFieldTypeEN.Memo != null)
{
writer.WriteElementString(conDataFieldType.Memo, objDataFieldTypeEN.Memo.ToString(CultureInfo.InvariantCulture));
}
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
public static clsDataFieldTypeEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
reader.Read();
while (!(reader.Name == clsDataFieldTypeBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conDataFieldType.DataFieldTypeId))
{
objDataFieldTypeEN.DataFieldTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conDataFieldType.DataFieldTypeName))
{
objDataFieldTypeEN.DataFieldTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conDataFieldType.DataFieldTypeENName))
{
objDataFieldTypeEN.DataFieldTypeENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conDataFieldType.UpdDate))
{
objDataFieldTypeEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conDataFieldType.UpdUser))
{
objDataFieldTypeEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conDataFieldType.Memo))
{
objDataFieldTypeEN.Memo = reader.ReadElementContentAsString();
}
}
return objDataFieldTypeEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strDataFieldTypeObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsDataFieldTypeEN GetObjFromXmlStr(string strDataFieldTypeObjXmlStr)
{
clsDataFieldTypeEN objDataFieldTypeEN = new clsDataFieldTypeEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strDataFieldTypeObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsDataFieldTypeBL.itemXmlNode))
{
objDataFieldTypeEN = GetObjFromXml(reader);
return objDataFieldTypeEN;
}
}
return objDataFieldTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsDataFieldTypeEN objDataFieldTypeEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objDataFieldTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDataFieldTypeId)
{
if (strInFldName != conDataFieldType.DataFieldTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataFieldType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataFieldType.AttributeName));
throw new Exception(strMsg);
}
var objDataFieldType = clsDataFieldTypeBL.GetObjByDataFieldTypeIdCache(strDataFieldTypeId);
if (objDataFieldType == null) return "";
return objDataFieldType[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objDataFieldTypeEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsDataFieldTypeEN objDataFieldTypeEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsDataFieldTypeEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objDataFieldTypeEN[strField]);
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
 /// <param name = "lstDataFieldTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsDataFieldTypeEN> lstDataFieldTypeObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstDataFieldTypeObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsDataFieldTypeEN objDataFieldTypeEN in lstDataFieldTypeObjLst)
{
string strJSON_One = SerializeObjToJSON(objDataFieldTypeEN);
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
int intRecCount = clsDataFieldTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsDataFieldTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataFieldTypeDA.GetRecCount();
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
int intRecCount = clsDataFieldTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataFieldTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataFieldTypeEN objDataFieldTypeCond)
{
List<clsDataFieldTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataFieldTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataFieldType.AttributeName)
{
if (objDataFieldTypeCond.IsUpdated(strFldName) == false) continue;
if (objDataFieldTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else
{
if (objDataFieldTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataFieldTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataFieldTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataFieldTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataFieldTypeCond[strFldName]));
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
 List<string> arrList = clsDataFieldTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataFieldTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataFieldTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataFieldTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataFieldTypeDA.SetFldValue(clsDataFieldTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataFieldTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataFieldTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataFieldTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataFieldTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataFieldType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**数据字段类型Id*/ 
 strCreateTabCode.Append(" DataFieldTypeId char(2) primary key, "); 
 // /**数据字段类型名*/ 
 strCreateTabCode.Append(" DataFieldTypeName varchar(30) not Null, "); 
 // /**数据字段类型英文名*/ 
 strCreateTabCode.Append(" DataFieldTypeENName varchar(30) Null, "); 
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


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 数据字段类型(DataFieldType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4DataFieldType : clsCommFun4BL
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
clsDataFieldTypeBL.ReFreshThisCache();
}
}

}