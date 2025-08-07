
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserWebSrvSetBL
 表名:UserWebSrvSet(00050528)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:54
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
public static class  clsUserWebSrvSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserWebSrvSetEN GetObj(this K_mId_UserWebSrvSet myKey)
{
clsUserWebSrvSetEN objUserWebSrvSetEN = clsUserWebSrvSetBL.UserWebSrvSetDA.GetObjBymId(myKey.Value);
return objUserWebSrvSetEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserWebSrvSetEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserWebSrvSetBL.AddNewRecord)", objUserWebSrvSetEN.UserId,objUserWebSrvSetEN.MachineName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserWebSrvSetBL.UserWebSrvSetDA.AddNewRecordBySQL2(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
public static bool AddRecordEx(this clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsNeedCheckUniqueness = true)
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
objUserWebSrvSetEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserWebSrvSetEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户Id(UserId)=[{0}],机器名(MachineName)=[{1}])已经存在,不能重复!", objUserWebSrvSetEN.UserId, objUserWebSrvSetEN.MachineName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserWebSrvSetEN.AddNewRecord();
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserWebSrvSetEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserWebSrvSetBL.AddNewRecordWithReturnKey)", objUserWebSrvSetEN.UserId,objUserWebSrvSetEN.MachineName);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserWebSrvSetBL.UserWebSrvSetDA.AddNewRecordBySQL2WithReturnKey(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetmId(this clsUserWebSrvSetEN objUserWebSrvSetEN, long lngmId, string strComparisonOp="")
	{
objUserWebSrvSetEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.mId) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.mId, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.mId] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetUserId(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserWebSrvSet.UserId);
}
objUserWebSrvSetEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.UserId) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.UserId, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.UserId] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetMachineName(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strMachineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMachineName, 50, conUserWebSrvSet.MachineName);
}
objUserWebSrvSetEN.MachineName = strMachineName; //机器名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.MachineName) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.MachineName, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.MachineName] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetWebApiIPAndPort(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strWebApiIPAndPort, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebApiIPAndPort, 50, conUserWebSrvSet.WebApiIPAndPort);
}
objUserWebSrvSetEN.WebApiIPAndPort = strWebApiIPAndPort; //WebApiIPAndPort
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.WebApiIPAndPort) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.WebApiIPAndPort, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.WebApiIPAndPort] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetWebApiVirtualPath(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strWebApiVirtualPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebApiVirtualPath, 50, conUserWebSrvSet.WebApiVirtualPath);
}
objUserWebSrvSetEN.WebApiVirtualPath = strWebApiVirtualPath; //WebApi虚拟路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.WebApiVirtualPath) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.WebApiVirtualPath, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.WebApiVirtualPath] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetIsTemplate(this clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conUserWebSrvSet.IsTemplate);
objUserWebSrvSetEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.IsTemplate) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.IsTemplate, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.IsTemplate] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetUpdDate(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserWebSrvSet.UpdDate);
}
objUserWebSrvSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.UpdDate) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.UpdDate, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.UpdDate] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetUpdUserId(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserWebSrvSet.UpdUserId);
}
objUserWebSrvSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.UpdUserId) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.UpdUserId, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.UpdUserId] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserWebSrvSetEN SetMemo(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserWebSrvSet.Memo);
}
objUserWebSrvSetEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserWebSrvSetEN.dicFldComparisonOp.ContainsKey(conUserWebSrvSet.Memo) == false)
{
objUserWebSrvSetEN.dicFldComparisonOp.Add(conUserWebSrvSet.Memo, strComparisonOp);
}
else
{
objUserWebSrvSetEN.dicFldComparisonOp[conUserWebSrvSet.Memo] = strComparisonOp;
}
}
return objUserWebSrvSetEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserWebSrvSetEN.CheckPropertyNew();
clsUserWebSrvSetEN objUserWebSrvSetCond = new clsUserWebSrvSetEN();
string strCondition = objUserWebSrvSetCond
.SetmId(objUserWebSrvSetEN.mId, "<>")
.SetUserId(objUserWebSrvSetEN.UserId, "=")
.SetMachineName(objUserWebSrvSetEN.MachineName, "=")
.GetCombineCondition();
objUserWebSrvSetEN._IsCheckProperty = true;
bool bolIsExist = clsUserWebSrvSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_MachineName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserWebSrvSetEN.Update();
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
 /// <param name = "objUserWebSrvSet">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserWebSrvSetEN objUserWebSrvSet)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserWebSrvSetEN objUserWebSrvSetCond = new clsUserWebSrvSetEN();
string strCondition = objUserWebSrvSetCond
.SetUserId(objUserWebSrvSet.UserId, "=")
.SetMachineName(objUserWebSrvSet.MachineName, "=")
.GetCombineCondition();
objUserWebSrvSet._IsCheckProperty = true;
bool bolIsExist = clsUserWebSrvSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserWebSrvSet.mId = clsUserWebSrvSetBL.GetFirstID_S(strCondition);
objUserWebSrvSet.UpdateWithCondition(strCondition);
}
else
{
objUserWebSrvSet.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 if (objUserWebSrvSetEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserWebSrvSetBL.UserWebSrvSetDA.UpdateBySql2(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserWebSrvSetEN objUserWebSrvSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserWebSrvSetEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserWebSrvSetBL.UserWebSrvSetDA.UpdateBySql2(objUserWebSrvSetEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strWhereCond)
{
try
{
bool bolResult = clsUserWebSrvSetBL.UserWebSrvSetDA.UpdateBySqlWithCondition(objUserWebSrvSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserWebSrvSetEN objUserWebSrvSetEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserWebSrvSetBL.UserWebSrvSetDA.UpdateBySqlWithConditionTransaction(objUserWebSrvSetEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
public static int Delete(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
try
{
int intRecNum = clsUserWebSrvSetBL.UserWebSrvSetDA.DelRecord(objUserWebSrvSetEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetENS">源对象</param>
 /// <param name = "objUserWebSrvSetENT">目标对象</param>
 public static void CopyTo(this clsUserWebSrvSetEN objUserWebSrvSetENS, clsUserWebSrvSetEN objUserWebSrvSetENT)
{
try
{
objUserWebSrvSetENT.mId = objUserWebSrvSetENS.mId; //mId
objUserWebSrvSetENT.UserId = objUserWebSrvSetENS.UserId; //用户Id
objUserWebSrvSetENT.MachineName = objUserWebSrvSetENS.MachineName; //机器名
objUserWebSrvSetENT.WebApiIPAndPort = objUserWebSrvSetENS.WebApiIPAndPort; //WebApiIPAndPort
objUserWebSrvSetENT.WebApiVirtualPath = objUserWebSrvSetENS.WebApiVirtualPath; //WebApi虚拟路径
objUserWebSrvSetENT.IsTemplate = objUserWebSrvSetENS.IsTemplate; //是否模板
objUserWebSrvSetENT.UpdDate = objUserWebSrvSetENS.UpdDate; //修改日期
objUserWebSrvSetENT.UpdUserId = objUserWebSrvSetENS.UpdUserId; //修改用户Id
objUserWebSrvSetENT.Memo = objUserWebSrvSetENS.Memo; //说明
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
 /// <param name = "objUserWebSrvSetENS">源对象</param>
 /// <returns>目标对象=>clsUserWebSrvSetEN:objUserWebSrvSetENT</returns>
 public static clsUserWebSrvSetEN CopyTo(this clsUserWebSrvSetEN objUserWebSrvSetENS)
{
try
{
 clsUserWebSrvSetEN objUserWebSrvSetENT = new clsUserWebSrvSetEN()
{
mId = objUserWebSrvSetENS.mId, //mId
UserId = objUserWebSrvSetENS.UserId, //用户Id
MachineName = objUserWebSrvSetENS.MachineName, //机器名
WebApiIPAndPort = objUserWebSrvSetENS.WebApiIPAndPort, //WebApiIPAndPort
WebApiVirtualPath = objUserWebSrvSetENS.WebApiVirtualPath, //WebApi虚拟路径
IsTemplate = objUserWebSrvSetENS.IsTemplate, //是否模板
UpdDate = objUserWebSrvSetENS.UpdDate, //修改日期
UpdUserId = objUserWebSrvSetENS.UpdUserId, //修改用户Id
Memo = objUserWebSrvSetENS.Memo, //说明
};
 return objUserWebSrvSetENT;
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
public static void CheckPropertyNew(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 clsUserWebSrvSetBL.UserWebSrvSetDA.CheckPropertyNew(objUserWebSrvSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 clsUserWebSrvSetBL.UserWebSrvSetDA.CheckProperty4Condition(objUserWebSrvSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserWebSrvSetEN objUserWebSrvSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.mId) == true)
{
string strComparisonOpmId = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserWebSrvSet.mId, objUserWebSrvSetCond.mId, strComparisonOpmId);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.UserId) == true)
{
string strComparisonOpUserId = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.UserId, objUserWebSrvSetCond.UserId, strComparisonOpUserId);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.MachineName) == true)
{
string strComparisonOpMachineName = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.MachineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.MachineName, objUserWebSrvSetCond.MachineName, strComparisonOpMachineName);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.WebApiIPAndPort) == true)
{
string strComparisonOpWebApiIPAndPort = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.WebApiIPAndPort];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.WebApiIPAndPort, objUserWebSrvSetCond.WebApiIPAndPort, strComparisonOpWebApiIPAndPort);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.WebApiVirtualPath) == true)
{
string strComparisonOpWebApiVirtualPath = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.WebApiVirtualPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.WebApiVirtualPath, objUserWebSrvSetCond.WebApiVirtualPath, strComparisonOpWebApiVirtualPath);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.IsTemplate) == true)
{
if (objUserWebSrvSetCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserWebSrvSet.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserWebSrvSet.IsTemplate);
}
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.UpdDate, objUserWebSrvSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.UpdUserId, objUserWebSrvSetCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserWebSrvSetCond.IsUpdated(conUserWebSrvSet.Memo) == true)
{
string strComparisonOpMemo = objUserWebSrvSetCond.dicFldComparisonOp[conUserWebSrvSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserWebSrvSet.Memo, objUserWebSrvSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserWebSrvSet(用户WebSrv设置), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserWebSrvSetEN == null) return true;
if (objUserWebSrvSetEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserWebSrvSetEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserWebSrvSetEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserWebSrvSetEN.UserId);
}
 if (objUserWebSrvSetEN.MachineName == null)
{
 sbCondition.AppendFormat(" and MachineName is null", objUserWebSrvSetEN.MachineName);
}
else
{
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserWebSrvSetEN.MachineName);
}
if (clsUserWebSrvSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserWebSrvSetEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserWebSrvSetEN.UserId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserWebSrvSetEN.MachineName);
if (clsUserWebSrvSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserWebSrvSet(用户WebSrv设置), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserWebSrvSetEN == null) return "";
if (objUserWebSrvSetEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserWebSrvSetEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserWebSrvSetEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserWebSrvSetEN.UserId);
}
 if (objUserWebSrvSetEN.MachineName == null)
{
 sbCondition.AppendFormat(" and MachineName is null", objUserWebSrvSetEN.MachineName);
}
else
{
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserWebSrvSetEN.MachineName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserWebSrvSetEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserWebSrvSetEN.UserId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserWebSrvSetEN.MachineName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserWebSrvSet
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户WebSrv设置(UserWebSrvSet)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserWebSrvSetBL
{
public static RelatedActions_UserWebSrvSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserWebSrvSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserWebSrvSetDA UserWebSrvSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserWebSrvSetDA();
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
 public clsUserWebSrvSetBL()
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
if (string.IsNullOrEmpty(clsUserWebSrvSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserWebSrvSetEN._ConnectString);
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
public static DataTable GetDataTable_UserWebSrvSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserWebSrvSetDA.GetDataTable_UserWebSrvSet(strWhereCond);
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
objDT = UserWebSrvSetDA.GetDataTable(strWhereCond);
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
objDT = UserWebSrvSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserWebSrvSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserWebSrvSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserWebSrvSetDA.GetDataTable_Top(objTopPara);
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
objDT = UserWebSrvSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserWebSrvSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserWebSrvSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsUserWebSrvSetEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
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
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserWebSrvSetEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsUserWebSrvSetEN._CurrTabName);
List<clsUserWebSrvSetEN> arrUserWebSrvSetObjLstCache = GetObjLstCache();
IEnumerable <clsUserWebSrvSetEN> arrUserWebSrvSetObjLst_Sel =
arrUserWebSrvSetObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrUserWebSrvSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserWebSrvSetEN> GetObjLst(string strWhereCond)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
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
public static List<clsUserWebSrvSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserWebSrvSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserWebSrvSetEN> GetSubObjLstCache(clsUserWebSrvSetEN objUserWebSrvSetCond)
{
List<clsUserWebSrvSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserWebSrvSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserWebSrvSet._AttributeName)
{
if (objUserWebSrvSetCond.IsUpdated(strFldName) == false) continue;
if (objUserWebSrvSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserWebSrvSetCond[strFldName].ToString());
}
else
{
if (objUserWebSrvSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserWebSrvSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserWebSrvSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserWebSrvSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserWebSrvSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserWebSrvSetCond[strFldName]));
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
public static List<clsUserWebSrvSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
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
public static List<clsUserWebSrvSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
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
List<clsUserWebSrvSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserWebSrvSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserWebSrvSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserWebSrvSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
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
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
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
public static List<clsUserWebSrvSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserWebSrvSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserWebSrvSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
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
public static List<clsUserWebSrvSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserWebSrvSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserWebSrvSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserWebSrvSet(ref clsUserWebSrvSetEN objUserWebSrvSetEN)
{
bool bolResult = UserWebSrvSetDA.GetUserWebSrvSet(ref objUserWebSrvSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserWebSrvSetEN GetObjBymId(long lngmId)
{
clsUserWebSrvSetEN objUserWebSrvSetEN = UserWebSrvSetDA.GetObjBymId(lngmId);
return objUserWebSrvSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserWebSrvSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserWebSrvSetEN objUserWebSrvSetEN = UserWebSrvSetDA.GetFirstObj(strWhereCond);
 return objUserWebSrvSetEN;
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
public static clsUserWebSrvSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserWebSrvSetEN objUserWebSrvSetEN = UserWebSrvSetDA.GetObjByDataRow(objRow);
 return objUserWebSrvSetEN;
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
public static clsUserWebSrvSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserWebSrvSetEN objUserWebSrvSetEN = UserWebSrvSetDA.GetObjByDataRow(objRow);
 return objUserWebSrvSetEN;
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
 /// <param name = "lstUserWebSrvSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserWebSrvSetEN GetObjBymIdFromList(long lngmId, List<clsUserWebSrvSetEN> lstUserWebSrvSetObjLst)
{
foreach (clsUserWebSrvSetEN objUserWebSrvSetEN in lstUserWebSrvSetObjLst)
{
if (objUserWebSrvSetEN.mId == lngmId)
{
return objUserWebSrvSetEN;
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
 lngmId = new clsUserWebSrvSetDA().GetFirstID(strWhereCond);
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
 arrList = UserWebSrvSetDA.GetID(strWhereCond);
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
bool bolIsExist = UserWebSrvSetDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = UserWebSrvSetDA.IsExist(lngmId);
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
clsUserWebSrvSetEN objUserWebSrvSetEN = clsUserWebSrvSetBL.GetObjBymId(lngmId);
objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserWebSrvSetEN.UpdUserId = strOpUser;
return clsUserWebSrvSetBL.UpdateBySql2(objUserWebSrvSetEN);
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
 bolIsExist = clsUserWebSrvSetDA.IsExistTable();
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
 bolIsExist = UserWebSrvSetDA.IsExistTable(strTabName);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserWebSrvSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserWebSrvSetBL.AddNewRecordBySql2)", objUserWebSrvSetEN.UserId,objUserWebSrvSetEN.MachineName);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserWebSrvSetDA.AddNewRecordBySQL2(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserWebSrvSetEN objUserWebSrvSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserWebSrvSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserWebSrvSetBL.AddNewRecordBySql2WithReturnKey)", objUserWebSrvSetEN.UserId,objUserWebSrvSetEN.MachineName);
throw new Exception(strMsg);
}
try
{
string strKey = UserWebSrvSetDA.AddNewRecordBySQL2WithReturnKey(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
try
{
bool bolResult = UserWebSrvSetDA.Update(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 if (objUserWebSrvSetEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserWebSrvSetDA.UpdateBySql2(objUserWebSrvSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserWebSrvSetBL.ReFreshCache();

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
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
 clsUserWebSrvSetEN objUserWebSrvSetEN = clsUserWebSrvSetBL.GetObjBymId(lngmId);

if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(objUserWebSrvSetEN.mId, objUserWebSrvSetEN.UpdUserId);
}
if (objUserWebSrvSetEN != null)
{
int intRecNum = UserWebSrvSetDA.DelRecord(lngmId);
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
objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
//删除与表:[UserWebSrvSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserWebSrvSet.mId,
//lngmId);
//        clsUserWebSrvSetBL.DelUserWebSrvSetsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserWebSrvSetBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserWebSrvSetBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsUserWebSrvSetBL.relatedActions != null)
{
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = UserWebSrvSetDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelUserWebSrvSets(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsUserWebSrvSetBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = UserWebSrvSetDA.DelUserWebSrvSet(arrmIdLst);
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
public static int DelUserWebSrvSetsByCond(string strWhereCond)
{
try
{
if (clsUserWebSrvSetBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserWebSrvSetBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = UserWebSrvSetDA.DelUserWebSrvSet(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserWebSrvSet]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
//删除与表:[UserWebSrvSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserWebSrvSetBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserWebSrvSetBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserWebSrvSetENS">源对象</param>
 /// <param name = "objUserWebSrvSetENT">目标对象</param>
 public static void CopyTo(clsUserWebSrvSetEN objUserWebSrvSetENS, clsUserWebSrvSetEN objUserWebSrvSetENT)
{
try
{
objUserWebSrvSetENT.mId = objUserWebSrvSetENS.mId; //mId
objUserWebSrvSetENT.UserId = objUserWebSrvSetENS.UserId; //用户Id
objUserWebSrvSetENT.MachineName = objUserWebSrvSetENS.MachineName; //机器名
objUserWebSrvSetENT.WebApiIPAndPort = objUserWebSrvSetENS.WebApiIPAndPort; //WebApiIPAndPort
objUserWebSrvSetENT.WebApiVirtualPath = objUserWebSrvSetENS.WebApiVirtualPath; //WebApi虚拟路径
objUserWebSrvSetENT.IsTemplate = objUserWebSrvSetENS.IsTemplate; //是否模板
objUserWebSrvSetENT.UpdDate = objUserWebSrvSetENS.UpdDate; //修改日期
objUserWebSrvSetENT.UpdUserId = objUserWebSrvSetENS.UpdUserId; //修改用户Id
objUserWebSrvSetENT.Memo = objUserWebSrvSetENS.Memo; //说明
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
 /// <param name = "objUserWebSrvSetEN">源简化对象</param>
 public static void SetUpdFlag(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
try
{
objUserWebSrvSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserWebSrvSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserWebSrvSet.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.mId = objUserWebSrvSetEN.mId; //mId
}
if (arrFldSet.Contains(conUserWebSrvSet.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.UserId = objUserWebSrvSetEN.UserId == "[null]" ? null :  objUserWebSrvSetEN.UserId; //用户Id
}
if (arrFldSet.Contains(conUserWebSrvSet.MachineName, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.MachineName = objUserWebSrvSetEN.MachineName == "[null]" ? null :  objUserWebSrvSetEN.MachineName; //机器名
}
if (arrFldSet.Contains(conUserWebSrvSet.WebApiIPAndPort, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.WebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort == "[null]" ? null :  objUserWebSrvSetEN.WebApiIPAndPort; //WebApiIPAndPort
}
if (arrFldSet.Contains(conUserWebSrvSet.WebApiVirtualPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.WebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath == "[null]" ? null :  objUserWebSrvSetEN.WebApiVirtualPath; //WebApi虚拟路径
}
if (arrFldSet.Contains(conUserWebSrvSet.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.IsTemplate = objUserWebSrvSetEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conUserWebSrvSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.UpdDate = objUserWebSrvSetEN.UpdDate == "[null]" ? null :  objUserWebSrvSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserWebSrvSet.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.UpdUserId = objUserWebSrvSetEN.UpdUserId == "[null]" ? null :  objUserWebSrvSetEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conUserWebSrvSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserWebSrvSetEN.Memo = objUserWebSrvSetEN.Memo == "[null]" ? null :  objUserWebSrvSetEN.Memo; //说明
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
 /// <param name = "objUserWebSrvSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
try
{
if (objUserWebSrvSetEN.UserId == "[null]") objUserWebSrvSetEN.UserId = null; //用户Id
if (objUserWebSrvSetEN.MachineName == "[null]") objUserWebSrvSetEN.MachineName = null; //机器名
if (objUserWebSrvSetEN.WebApiIPAndPort == "[null]") objUserWebSrvSetEN.WebApiIPAndPort = null; //WebApiIPAndPort
if (objUserWebSrvSetEN.WebApiVirtualPath == "[null]") objUserWebSrvSetEN.WebApiVirtualPath = null; //WebApi虚拟路径
if (objUserWebSrvSetEN.UpdDate == "[null]") objUserWebSrvSetEN.UpdDate = null; //修改日期
if (objUserWebSrvSetEN.UpdUserId == "[null]") objUserWebSrvSetEN.UpdUserId = null; //修改用户Id
if (objUserWebSrvSetEN.Memo == "[null]") objUserWebSrvSetEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 UserWebSrvSetDA.CheckPropertyNew(objUserWebSrvSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 UserWebSrvSetDA.CheckProperty4Condition(objUserWebSrvSetEN);
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
if (clsUserWebSrvSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserWebSrvSetBL没有刷新缓存机制(clsUserWebSrvSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserWebSrvSetObjLstCache == null)
//{
//arrUserWebSrvSetObjLstCache = UserWebSrvSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserWebSrvSetEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUserWebSrvSetEN._CurrTabName);
List<clsUserWebSrvSetEN> arrUserWebSrvSetObjLstCache = GetObjLstCache();
IEnumerable <clsUserWebSrvSetEN> arrUserWebSrvSetObjLst_Sel =
arrUserWebSrvSetObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrUserWebSrvSetObjLst_Sel.Count() == 0)
{
   clsUserWebSrvSetEN obj = clsUserWebSrvSetBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUserWebSrvSetObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserWebSrvSetEN> GetAllUserWebSrvSetObjLstCache()
{
//获取缓存中的对象列表
List<clsUserWebSrvSetEN> arrUserWebSrvSetObjLstCache = GetObjLstCache(); 
return arrUserWebSrvSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserWebSrvSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUserWebSrvSetEN._CurrTabName);
List<clsUserWebSrvSetEN> arrUserWebSrvSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserWebSrvSetObjLstCache;
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
string strKey = string.Format("{0}", clsUserWebSrvSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserWebSrvSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserWebSrvSetEN._RefreshTimeLst.Count == 0) return "";
return clsUserWebSrvSetEN._RefreshTimeLst[clsUserWebSrvSetEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsUserWebSrvSetBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserWebSrvSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserWebSrvSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserWebSrvSetBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserWebSrvSet(用户WebSrv设置)
 /// 唯一性条件:UserId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检测记录是否存在
string strResult = UserWebSrvSetDA.GetUniCondStr(objUserWebSrvSetEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conUserWebSrvSet.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserWebSrvSet._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserWebSrvSet._AttributeName));
throw new Exception(strMsg);
}
var objUserWebSrvSet = clsUserWebSrvSetBL.GetObjBymIdCache(lngmId);
if (objUserWebSrvSet == null) return "";
return objUserWebSrvSet[strOutFldName].ToString();
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
int intRecCount = clsUserWebSrvSetDA.GetRecCount(strTabName);
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
int intRecCount = clsUserWebSrvSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserWebSrvSetDA.GetRecCount();
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
int intRecCount = clsUserWebSrvSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserWebSrvSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserWebSrvSetEN objUserWebSrvSetCond)
{
List<clsUserWebSrvSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserWebSrvSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserWebSrvSet._AttributeName)
{
if (objUserWebSrvSetCond.IsUpdated(strFldName) == false) continue;
if (objUserWebSrvSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserWebSrvSetCond[strFldName].ToString());
}
else
{
if (objUserWebSrvSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserWebSrvSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserWebSrvSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserWebSrvSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserWebSrvSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserWebSrvSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserWebSrvSetCond[strFldName]));
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
 List<string> arrList = clsUserWebSrvSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserWebSrvSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserWebSrvSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserWebSrvSetDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserWebSrvSetDA.SetFldValue(clsUserWebSrvSetEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserWebSrvSetDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserWebSrvSetDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserWebSrvSetDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserWebSrvSetDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserWebSrvSet] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**机器名*/ 
 strCreateTabCode.Append(" MachineName varchar(50) Null, "); 
 // /**WebApiIPAndPort*/ 
 strCreateTabCode.Append(" WebApiIPAndPort varchar(50) Null, "); 
 // /**WebApi虚拟路径*/ 
 strCreateTabCode.Append(" WebApiVirtualPath varchar(50) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户WebSrv设置(UserWebSrvSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserWebSrvSet : clsCommFun4BL
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
clsUserWebSrvSetBL.ReFreshThisCache();
}
}

}