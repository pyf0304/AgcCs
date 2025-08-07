
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQL_DataBaseBL
 表名:SQL_DataBase(00050172)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
public static class  clsSQL_DataBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDataBaseName">表关键字</param>
 /// <returns>表对象</returns>
public static clsSQL_DataBaseEN GetObj(this K_DataBaseName_SQL_DataBase myKey)
{
clsSQL_DataBaseEN objSQL_DataBaseEN = clsSQL_DataBaseBL.SQL_DataBaseDA.GetObjByDataBaseName(myKey.Value);
return objSQL_DataBaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSQL_DataBaseEN objSQL_DataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSQL_DataBaseBL.IsExist(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSQL_DataBaseEN.DataBaseName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSQL_DataBaseBL.SQL_DataBaseDA.AddNewRecordBySQL2(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
public static bool AddRecordEx(this clsSQL_DataBaseEN objSQL_DataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSQL_DataBaseBL.IsExist(objSQL_DataBaseEN.DataBaseName))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSQL_DataBaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSQL_DataBaseEN.AddNewRecord();
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSQL_DataBaseEN objSQL_DataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSQL_DataBaseBL.IsExist(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSQL_DataBaseEN.DataBaseName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSQL_DataBaseBL.SQL_DataBaseDA.AddNewRecordBySQL2WithReturnKey(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetServer(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strServer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strServer, conSQL_DataBase.Server);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strServer, 20, conSQL_DataBase.Server);
}
objSQL_DataBaseEN.Server = strServer; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.Server) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.Server, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.Server] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetUserId(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conSQL_DataBase.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conSQL_DataBase.UserId);
}
objSQL_DataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.UserId) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.UserId, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.UserId] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetPassword(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, conSQL_DataBase.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, conSQL_DataBase.Password);
}
objSQL_DataBaseEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.Password) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.Password, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.Password] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetUserIdForMaster(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strUserIdForMaster, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserIdForMaster, conSQL_DataBase.UserIdForMaster);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserIdForMaster, 18, conSQL_DataBase.UserIdForMaster);
}
objSQL_DataBaseEN.UserIdForMaster = strUserIdForMaster; //用户ID4Master
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.UserIdForMaster) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.UserIdForMaster, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.UserIdForMaster] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetPasswordForMaster(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strPasswordForMaster, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPasswordForMaster, conSQL_DataBase.PasswordForMaster);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPasswordForMaster, 20, conSQL_DataBase.PasswordForMaster);
}
objSQL_DataBaseEN.PasswordForMaster = strPasswordForMaster; //口令4Master
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.PasswordForMaster) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.PasswordForMaster, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.PasswordForMaster] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetPrjId(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSQL_DataBase.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSQL_DataBase.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSQL_DataBase.PrjId);
}
objSQL_DataBaseEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.PrjId) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.PrjId, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.PrjId] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetDatabaseOwner(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, conSQL_DataBase.DatabaseOwner);
}
objSQL_DataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.DatabaseOwner) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.DatabaseOwner, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.DatabaseOwner] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSQL_DataBaseEN SetDataBaseName(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conSQL_DataBase.DataBaseName);
}
objSQL_DataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSQL_DataBaseEN.dicFldComparisonOp.ContainsKey(conSQL_DataBase.DataBaseName) == false)
{
objSQL_DataBaseEN.dicFldComparisonOp.Add(conSQL_DataBase.DataBaseName, strComparisonOp);
}
else
{
objSQL_DataBaseEN.dicFldComparisonOp[conSQL_DataBase.DataBaseName] = strComparisonOp;
}
}
return objSQL_DataBaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSQL_DataBaseEN objSQL_DataBaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSQL_DataBaseEN.CheckPropertyNew();
clsSQL_DataBaseEN objSQL_DataBaseCond = new clsSQL_DataBaseEN();
string strCondition = objSQL_DataBaseCond
.SetDataBaseName(objSQL_DataBaseEN.DataBaseName, "=")
.GetCombineCondition();
objSQL_DataBaseEN._IsCheckProperty = true;
bool bolIsExist = clsSQL_DataBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSQL_DataBaseEN.Update();
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSQL_DataBaseBL.SQL_DataBaseDA.UpdateBySql2(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSQL_DataBaseEN objSQL_DataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSQL_DataBaseBL.SQL_DataBaseDA.UpdateBySql2(objSQL_DataBaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strWhereCond)
{
try
{
bool bolResult = clsSQL_DataBaseBL.SQL_DataBaseDA.UpdateBySqlWithCondition(objSQL_DataBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSQL_DataBaseEN objSQL_DataBaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSQL_DataBaseBL.SQL_DataBaseDA.UpdateBySqlWithConditionTransaction(objSQL_DataBaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSQL_DataBaseEN objSQL_DataBaseEN)
{
try
{
int intRecNum = clsSQL_DataBaseBL.SQL_DataBaseDA.DelRecord(objSQL_DataBaseEN.DataBaseName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseENS">源对象</param>
 /// <param name = "objSQL_DataBaseENT">目标对象</param>
 public static void CopyTo(this clsSQL_DataBaseEN objSQL_DataBaseENS, clsSQL_DataBaseEN objSQL_DataBaseENT)
{
try
{
objSQL_DataBaseENT.Server = objSQL_DataBaseENS.Server; //服务器
objSQL_DataBaseENT.UserId = objSQL_DataBaseENS.UserId; //用户Id
objSQL_DataBaseENT.Password = objSQL_DataBaseENS.Password; //口令
objSQL_DataBaseENT.UserIdForMaster = objSQL_DataBaseENS.UserIdForMaster; //用户ID4Master
objSQL_DataBaseENT.PasswordForMaster = objSQL_DataBaseENS.PasswordForMaster; //口令4Master
objSQL_DataBaseENT.PrjId = objSQL_DataBaseENS.PrjId; //工程Id
objSQL_DataBaseENT.DatabaseOwner = objSQL_DataBaseENS.DatabaseOwner; //数据库拥有者
objSQL_DataBaseENT.DataBaseName = objSQL_DataBaseENS.DataBaseName; //数据库名
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
 /// <param name = "objSQL_DataBaseENS">源对象</param>
 /// <returns>目标对象=>clsSQL_DataBaseEN:objSQL_DataBaseENT</returns>
 public static clsSQL_DataBaseEN CopyTo(this clsSQL_DataBaseEN objSQL_DataBaseENS)
{
try
{
 clsSQL_DataBaseEN objSQL_DataBaseENT = new clsSQL_DataBaseEN()
{
Server = objSQL_DataBaseENS.Server, //服务器
UserId = objSQL_DataBaseENS.UserId, //用户Id
Password = objSQL_DataBaseENS.Password, //口令
UserIdForMaster = objSQL_DataBaseENS.UserIdForMaster, //用户ID4Master
PasswordForMaster = objSQL_DataBaseENS.PasswordForMaster, //口令4Master
PrjId = objSQL_DataBaseENS.PrjId, //工程Id
DatabaseOwner = objSQL_DataBaseENS.DatabaseOwner, //数据库拥有者
DataBaseName = objSQL_DataBaseENS.DataBaseName, //数据库名
};
 return objSQL_DataBaseENT;
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
public static void CheckPropertyNew(this clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 clsSQL_DataBaseBL.SQL_DataBaseDA.CheckPropertyNew(objSQL_DataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 clsSQL_DataBaseBL.SQL_DataBaseDA.CheckProperty4Condition(objSQL_DataBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSQL_DataBaseEN objSQL_DataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.Server) == true)
{
string strComparisonOpServer = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.Server];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.Server, objSQL_DataBaseCond.Server, strComparisonOpServer);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.UserId) == true)
{
string strComparisonOpUserId = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.UserId, objSQL_DataBaseCond.UserId, strComparisonOpUserId);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.Password) == true)
{
string strComparisonOpPassword = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.Password, objSQL_DataBaseCond.Password, strComparisonOpPassword);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.UserIdForMaster) == true)
{
string strComparisonOpUserIdForMaster = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.UserIdForMaster];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.UserIdForMaster, objSQL_DataBaseCond.UserIdForMaster, strComparisonOpUserIdForMaster);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.PasswordForMaster) == true)
{
string strComparisonOpPasswordForMaster = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.PasswordForMaster];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.PasswordForMaster, objSQL_DataBaseCond.PasswordForMaster, strComparisonOpPasswordForMaster);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.PrjId) == true)
{
string strComparisonOpPrjId = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.PrjId, objSQL_DataBaseCond.PrjId, strComparisonOpPrjId);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.DatabaseOwner, objSQL_DataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objSQL_DataBaseCond.IsUpdated(conSQL_DataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objSQL_DataBaseCond.dicFldComparisonOp[conSQL_DataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSQL_DataBase.DataBaseName, objSQL_DataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SQL_DataBase
{
public virtual bool UpdRelaTabDate(string strDataBaseName, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// SQL数据库(SQL_DataBase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSQL_DataBaseBL
{
public static RelatedActions_SQL_DataBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSQL_DataBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSQL_DataBaseDA SQL_DataBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSQL_DataBaseDA();
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
 public clsSQL_DataBaseBL()
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
if (string.IsNullOrEmpty(clsSQL_DataBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSQL_DataBaseEN._ConnectString);
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
public static DataTable GetDataTable_SQL_DataBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SQL_DataBaseDA.GetDataTable_SQL_DataBase(strWhereCond);
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
objDT = SQL_DataBaseDA.GetDataTable(strWhereCond);
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
objDT = SQL_DataBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SQL_DataBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SQL_DataBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SQL_DataBaseDA.GetDataTable_Top(objTopPara);
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
objDT = SQL_DataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SQL_DataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SQL_DataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDataBaseNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSQL_DataBaseEN> GetObjLstByDataBaseNameLst(List<string> arrDataBaseNameLst)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataBaseNameLst, true);
 string strWhereCond = string.Format("DataBaseName in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataBaseNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSQL_DataBaseEN> GetObjLstByDataBaseNameLstCache(List<string> arrDataBaseNameLst)
{
string strKey = string.Format("{0}", clsSQL_DataBaseEN._CurrTabName);
List<clsSQL_DataBaseEN> arrSQL_DataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsSQL_DataBaseEN> arrSQL_DataBaseObjLst_Sel =
arrSQL_DataBaseObjLstCache
.Where(x => arrDataBaseNameLst.Contains(x.DataBaseName));
return arrSQL_DataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSQL_DataBaseEN> GetObjLst(string strWhereCond)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
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
public static List<clsSQL_DataBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSQL_DataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSQL_DataBaseEN> GetSubObjLstCache(clsSQL_DataBaseEN objSQL_DataBaseCond)
{
List<clsSQL_DataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSQL_DataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSQL_DataBase._AttributeName)
{
if (objSQL_DataBaseCond.IsUpdated(strFldName) == false) continue;
if (objSQL_DataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSQL_DataBaseCond[strFldName].ToString());
}
else
{
if (objSQL_DataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSQL_DataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSQL_DataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSQL_DataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSQL_DataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSQL_DataBaseCond[strFldName]));
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
public static List<clsSQL_DataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
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
public static List<clsSQL_DataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
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
List<clsSQL_DataBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSQL_DataBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSQL_DataBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSQL_DataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
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
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
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
public static List<clsSQL_DataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSQL_DataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSQL_DataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
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
public static List<clsSQL_DataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSQL_DataBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSQL_DataBaseEN> arrObjLst = new List<clsSQL_DataBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSQL_DataBaseEN objSQL_DataBaseEN = new clsSQL_DataBaseEN();
try
{
objSQL_DataBaseEN.Server = objRow[conSQL_DataBase.Server].ToString().Trim(); //服务器
objSQL_DataBaseEN.UserId = objRow[conSQL_DataBase.UserId].ToString().Trim(); //用户Id
objSQL_DataBaseEN.Password = objRow[conSQL_DataBase.Password].ToString().Trim(); //口令
objSQL_DataBaseEN.UserIdForMaster = objRow[conSQL_DataBase.UserIdForMaster].ToString().Trim(); //用户ID4Master
objSQL_DataBaseEN.PasswordForMaster = objRow[conSQL_DataBase.PasswordForMaster].ToString().Trim(); //口令4Master
objSQL_DataBaseEN.PrjId = objRow[conSQL_DataBase.PrjId].ToString().Trim(); //工程Id
objSQL_DataBaseEN.DatabaseOwner = objRow[conSQL_DataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conSQL_DataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objSQL_DataBaseEN.DataBaseName = objRow[conSQL_DataBase.DataBaseName].ToString().Trim(); //数据库名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSQL_DataBaseEN.DataBaseName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSQL_DataBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSQL_DataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSQL_DataBase(ref clsSQL_DataBaseEN objSQL_DataBaseEN)
{
bool bolResult = SQL_DataBaseDA.GetSQL_DataBase(ref objSQL_DataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDataBaseName">表关键字</param>
 /// <returns>表对象</returns>
public static clsSQL_DataBaseEN GetObjByDataBaseName(string strDataBaseName)
{
if (strDataBaseName.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDataBaseName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDataBaseName) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDataBaseName]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSQL_DataBaseEN objSQL_DataBaseEN = SQL_DataBaseDA.GetObjByDataBaseName(strDataBaseName);
return objSQL_DataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSQL_DataBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSQL_DataBaseEN objSQL_DataBaseEN = SQL_DataBaseDA.GetFirstObj(strWhereCond);
 return objSQL_DataBaseEN;
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
public static clsSQL_DataBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSQL_DataBaseEN objSQL_DataBaseEN = SQL_DataBaseDA.GetObjByDataRow(objRow);
 return objSQL_DataBaseEN;
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
public static clsSQL_DataBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSQL_DataBaseEN objSQL_DataBaseEN = SQL_DataBaseDA.GetObjByDataRow(objRow);
 return objSQL_DataBaseEN;
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
 /// <param name = "strDataBaseName">所给的关键字</param>
 /// <param name = "lstSQL_DataBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSQL_DataBaseEN GetObjByDataBaseNameFromList(string strDataBaseName, List<clsSQL_DataBaseEN> lstSQL_DataBaseObjLst)
{
foreach (clsSQL_DataBaseEN objSQL_DataBaseEN in lstSQL_DataBaseObjLst)
{
if (objSQL_DataBaseEN.DataBaseName == strDataBaseName)
{
return objSQL_DataBaseEN;
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
 string strDataBaseName;
 try
 {
 strDataBaseName = new clsSQL_DataBaseDA().GetFirstID(strWhereCond);
 return strDataBaseName;
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
 arrList = SQL_DataBaseDA.GetID(strWhereCond);
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
bool bolIsExist = SQL_DataBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDataBaseName)
{
if (string.IsNullOrEmpty(strDataBaseName) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDataBaseName]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SQL_DataBaseDA.IsExist(strDataBaseName);
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
 bolIsExist = clsSQL_DataBaseDA.IsExistTable();
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
 bolIsExist = SQL_DataBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSQL_DataBaseEN objSQL_DataBaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSQL_DataBaseBL.IsExist(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSQL_DataBaseEN.DataBaseName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SQL_DataBaseDA.AddNewRecordBySQL2(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSQL_DataBaseEN objSQL_DataBaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSQL_DataBaseBL.IsExist(objSQL_DataBaseEN.DataBaseName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSQL_DataBaseEN.DataBaseName, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SQL_DataBaseDA.AddNewRecordBySQL2WithReturnKey(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
try
{
bool bolResult = SQL_DataBaseDA.Update(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "objSQL_DataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 if (string.IsNullOrEmpty(objSQL_DataBaseEN.DataBaseName) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SQL_DataBaseDA.UpdateBySql2(objSQL_DataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSQL_DataBaseBL.ReFreshCache();

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
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
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDataBaseName)
{
try
{
 clsSQL_DataBaseEN objSQL_DataBaseEN = clsSQL_DataBaseBL.GetObjByDataBaseName(strDataBaseName);

if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(objSQL_DataBaseEN.DataBaseName, "SetUpdDate");
}
if (objSQL_DataBaseEN != null)
{
int intRecNum = SQL_DataBaseDA.DelRecord(strDataBaseName);
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
/// <param name="strDataBaseName">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDataBaseName )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
//删除与表:[SQL_DataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSQL_DataBase.DataBaseName,
//strDataBaseName);
//        clsSQL_DataBaseBL.DelSQL_DataBasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSQL_DataBaseBL.DelRecord(strDataBaseName, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSQL_DataBaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataBaseName, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDataBaseName">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDataBaseName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSQL_DataBaseBL.relatedActions != null)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(strDataBaseName, "UpdRelaTabDate");
}
bool bolResult = SQL_DataBaseDA.DelRecord(strDataBaseName,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDataBaseNameLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSQL_DataBases(List<string> arrDataBaseNameLst)
{
if (arrDataBaseNameLst.Count == 0) return 0;
try
{
if (clsSQL_DataBaseBL.relatedActions != null)
{
foreach (var strDataBaseName in arrDataBaseNameLst)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(strDataBaseName, "UpdRelaTabDate");
}
}
int intDelRecNum = SQL_DataBaseDA.DelSQL_DataBase(arrDataBaseNameLst);
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
public static int DelSQL_DataBasesByCond(string strWhereCond)
{
try
{
if (clsSQL_DataBaseBL.relatedActions != null)
{
List<string> arrDataBaseName = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataBaseName in arrDataBaseName)
{
clsSQL_DataBaseBL.relatedActions.UpdRelaTabDate(strDataBaseName, "UpdRelaTabDate");
}
}
int intRecNum = SQL_DataBaseDA.DelSQL_DataBase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SQL_DataBase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDataBaseName">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDataBaseName)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSQL_DataBaseDA.GetSpecSQLObj();
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
//删除与表:[SQL_DataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSQL_DataBaseBL.DelRecord(strDataBaseName, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSQL_DataBaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataBaseName, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSQL_DataBaseENS">源对象</param>
 /// <param name = "objSQL_DataBaseENT">目标对象</param>
 public static void CopyTo(clsSQL_DataBaseEN objSQL_DataBaseENS, clsSQL_DataBaseEN objSQL_DataBaseENT)
{
try
{
objSQL_DataBaseENT.Server = objSQL_DataBaseENS.Server; //服务器
objSQL_DataBaseENT.UserId = objSQL_DataBaseENS.UserId; //用户Id
objSQL_DataBaseENT.Password = objSQL_DataBaseENS.Password; //口令
objSQL_DataBaseENT.UserIdForMaster = objSQL_DataBaseENS.UserIdForMaster; //用户ID4Master
objSQL_DataBaseENT.PasswordForMaster = objSQL_DataBaseENS.PasswordForMaster; //口令4Master
objSQL_DataBaseENT.PrjId = objSQL_DataBaseENS.PrjId; //工程Id
objSQL_DataBaseENT.DatabaseOwner = objSQL_DataBaseENS.DatabaseOwner; //数据库拥有者
objSQL_DataBaseENT.DataBaseName = objSQL_DataBaseENS.DataBaseName; //数据库名
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
 /// <param name = "objSQL_DataBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
try
{
objSQL_DataBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSQL_DataBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSQL_DataBase.Server, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.Server = objSQL_DataBaseEN.Server; //服务器
}
if (arrFldSet.Contains(conSQL_DataBase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.UserId = objSQL_DataBaseEN.UserId; //用户Id
}
if (arrFldSet.Contains(conSQL_DataBase.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.Password = objSQL_DataBaseEN.Password; //口令
}
if (arrFldSet.Contains(conSQL_DataBase.UserIdForMaster, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.UserIdForMaster = objSQL_DataBaseEN.UserIdForMaster; //用户ID4Master
}
if (arrFldSet.Contains(conSQL_DataBase.PasswordForMaster, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.PasswordForMaster = objSQL_DataBaseEN.PasswordForMaster; //口令4Master
}
if (arrFldSet.Contains(conSQL_DataBase.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.PrjId = objSQL_DataBaseEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSQL_DataBase.DatabaseOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.DatabaseOwner = objSQL_DataBaseEN.DatabaseOwner == "[null]" ? null :  objSQL_DataBaseEN.DatabaseOwner; //数据库拥有者
}
if (arrFldSet.Contains(conSQL_DataBase.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objSQL_DataBaseEN.DataBaseName = objSQL_DataBaseEN.DataBaseName; //数据库名
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
 /// <param name = "objSQL_DataBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
try
{
if (objSQL_DataBaseEN.DatabaseOwner == "[null]") objSQL_DataBaseEN.DatabaseOwner = null; //数据库拥有者
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
public static void CheckPropertyNew(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 SQL_DataBaseDA.CheckPropertyNew(objSQL_DataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSQL_DataBaseEN objSQL_DataBaseEN)
{
 SQL_DataBaseDA.CheckProperty4Condition(objSQL_DataBaseEN);
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
if (clsSQL_DataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQL_DataBaseBL没有刷新缓存机制(clsSQL_DataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataBaseName");
//if (arrSQL_DataBaseObjLstCache == null)
//{
//arrSQL_DataBaseObjLstCache = SQL_DataBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDataBaseName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSQL_DataBaseEN GetObjByDataBaseNameCache(string strDataBaseName)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSQL_DataBaseEN._CurrTabName);
List<clsSQL_DataBaseEN> arrSQL_DataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsSQL_DataBaseEN> arrSQL_DataBaseObjLst_Sel =
arrSQL_DataBaseObjLstCache
.Where(x=> x.DataBaseName == strDataBaseName 
);
if (arrSQL_DataBaseObjLst_Sel.Count() == 0)
{
   clsSQL_DataBaseEN obj = clsSQL_DataBaseBL.GetObjByDataBaseName(strDataBaseName);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSQL_DataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSQL_DataBaseEN> GetAllSQL_DataBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsSQL_DataBaseEN> arrSQL_DataBaseObjLstCache = GetObjLstCache(); 
return arrSQL_DataBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSQL_DataBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSQL_DataBaseEN._CurrTabName);
List<clsSQL_DataBaseEN> arrSQL_DataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSQL_DataBaseObjLstCache;
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
string strKey = string.Format("{0}", clsSQL_DataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSQL_DataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSQL_DataBaseEN._RefreshTimeLst.Count == 0) return "";
return clsSQL_DataBaseEN._RefreshTimeLst[clsSQL_DataBaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSQL_DataBaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSQL_DataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSQL_DataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSQL_DataBaseBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strDataBaseName)
{
if (strInFldName != conSQL_DataBase.DataBaseName)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSQL_DataBase._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSQL_DataBase._AttributeName));
throw new Exception(strMsg);
}
var objSQL_DataBase = clsSQL_DataBaseBL.GetObjByDataBaseNameCache(strDataBaseName);
if (objSQL_DataBase == null) return "";
return objSQL_DataBase[strOutFldName].ToString();
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
int intRecCount = clsSQL_DataBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsSQL_DataBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSQL_DataBaseDA.GetRecCount();
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
int intRecCount = clsSQL_DataBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSQL_DataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSQL_DataBaseEN objSQL_DataBaseCond)
{
List<clsSQL_DataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSQL_DataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSQL_DataBase._AttributeName)
{
if (objSQL_DataBaseCond.IsUpdated(strFldName) == false) continue;
if (objSQL_DataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSQL_DataBaseCond[strFldName].ToString());
}
else
{
if (objSQL_DataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSQL_DataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSQL_DataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSQL_DataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSQL_DataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSQL_DataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSQL_DataBaseCond[strFldName]));
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
 List<string> arrList = clsSQL_DataBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SQL_DataBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SQL_DataBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SQL_DataBaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSQL_DataBaseDA.SetFldValue(clsSQL_DataBaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SQL_DataBaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSQL_DataBaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSQL_DataBaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSQL_DataBaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SQL_DataBase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**服务器*/ 
 strCreateTabCode.Append(" Server varchar(20) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**口令*/ 
 strCreateTabCode.Append(" Password varchar(20) not Null, "); 
 // /**用户ID4Master*/ 
 strCreateTabCode.Append(" UserIdForMaster varchar(18) not Null, "); 
 // /**口令4Master*/ 
 strCreateTabCode.Append(" PasswordForMaster varchar(20) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**数据库拥有者*/ 
 strCreateTabCode.Append(" DatabaseOwner varchar(30) Null, "); 
 // /**数据库名*/ 
 strCreateTabCode.Append(" DataBaseName varchar(50) primary key ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// SQL数据库(SQL_DataBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SQL_DataBase : clsCommFun4BL
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
clsSQL_DataBaseBL.ReFreshThisCache();
}
}

}