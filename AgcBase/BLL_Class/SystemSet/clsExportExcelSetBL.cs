
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcelSetBL
 表名:ExportExcelSet(00050240)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:39
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
public static class  clsExportExcelSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcelSetEN GetObj(this K_IdExportExcel4Users_ExportExcelSet myKey)
{
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.ExportExcelSetDA.GetObjByIdExportExcel4Users(myKey.Value);
return objExportExcelSetEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExportExcelSetEN) == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],用户Id = [{1}]的数据已经存在!(in clsExportExcelSetBL.AddNewRecord)", objExportExcelSetEN.ViewName,objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
bool bolResult = clsExportExcelSetBL.ExportExcelSetDA.AddNewRecordBySQL2(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
public static bool AddRecordEx(this clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objExportExcelSetEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objExportExcelSetEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面名称(ViewName)=[{0}],用户Id(UserId)=[{1}])已经存在,不能重复!", objExportExcelSetEN.ViewName, objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objExportExcelSetEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExportExcelSetEN) == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],用户Id = [{1}]的数据已经存在!(in clsExportExcelSetBL.AddNewRecordWithMaxId)", objExportExcelSetEN.ViewName,objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
string strIdExportExcel4Users = clsExportExcelSetBL.ExportExcelSetDA.AddNewRecordBySQL2WithReturnKey(objExportExcelSetEN);
     objExportExcelSetEN.IdExportExcel4Users = strIdExportExcel4Users;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
}
return strIdExportExcel4Users;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExportExcelSetEN) == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],用户Id = [{1}]的数据已经存在!(in clsExportExcelSetBL.AddNewRecordWithReturnKey)", objExportExcelSetEN.ViewName,objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
string strKey = clsExportExcelSetBL.ExportExcelSetDA.AddNewRecordBySQL2WithReturnKey(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetIdExportExcel4Users(this clsExportExcelSetEN objExportExcelSetEN, string strIdExportExcel4Users, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExportExcel4Users, 8, conExportExcelSet.IdExportExcel4Users);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExportExcel4Users, 8, conExportExcelSet.IdExportExcel4Users);
}
objExportExcelSetEN.IdExportExcel4Users = strIdExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.IdExportExcel4Users) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.IdExportExcel4Users, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.IdExportExcel4Users] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetViewName(this clsExportExcelSetEN objExportExcelSetEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, conExportExcelSet.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, conExportExcelSet.ViewName);
}
objExportExcelSetEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.ViewName) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.ViewName, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.ViewName] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetTabName(this clsExportExcelSetEN objExportExcelSetEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conExportExcelSet.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conExportExcelSet.TabName);
}
objExportExcelSetEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.TabName) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.TabName, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.TabName] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetUserId(this clsExportExcelSetEN objExportExcelSetEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conExportExcelSet.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conExportExcelSet.UserId);
}
objExportExcelSetEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.UserId) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.UserId, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.UserId] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetIsDefaultUser(this clsExportExcelSetEN objExportExcelSetEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, conExportExcelSet.IsDefaultUser);
objExportExcelSetEN.IsDefaultUser = bolIsDefaultUser; //是否缺省用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.IsDefaultUser) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.IsDefaultUser, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.IsDefaultUser] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetExportFileName(this clsExportExcelSetEN objExportExcelSetEN, string strExportFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExportFileName, conExportExcelSet.ExportFileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportFileName, 100, conExportExcelSet.ExportFileName);
}
objExportExcelSetEN.ExportFileName = strExportFileName; //导出文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.ExportFileName) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.ExportFileName, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.ExportFileName] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetUpdDate(this clsExportExcelSetEN objExportExcelSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conExportExcelSet.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conExportExcelSet.UpdDate);
}
objExportExcelSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.UpdDate) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.UpdDate, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.UpdDate] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetUpdUserId(this clsExportExcelSetEN objExportExcelSetEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conExportExcelSet.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conExportExcelSet.UpdUserId);
}
objExportExcelSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.UpdUserId) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.UpdUserId, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.UpdUserId] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcelSetEN SetMemo(this clsExportExcelSetEN objExportExcelSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExportExcelSet.Memo);
}
objExportExcelSetEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcelSetEN.dicFldComparisonOp.ContainsKey(conExportExcelSet.Memo) == false)
{
objExportExcelSetEN.dicFldComparisonOp.Add(conExportExcelSet.Memo, strComparisonOp);
}
else
{
objExportExcelSetEN.dicFldComparisonOp[conExportExcelSet.Memo] = strComparisonOp;
}
}
return objExportExcelSetEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsExportExcelSetEN objExportExcelSetEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objExportExcelSetEN.CheckPropertyNew();
clsExportExcelSetEN objExportExcelSetCond = new clsExportExcelSetEN();
string strCondition = objExportExcelSetCond
.SetIdExportExcel4Users(objExportExcelSetEN.IdExportExcel4Users, "<>")
.SetViewName(objExportExcelSetEN.ViewName, "=")
.SetUserId(objExportExcelSetEN.UserId, "=")
.GetCombineCondition();
objExportExcelSetEN._IsCheckProperty = true;
bool bolIsExist = clsExportExcelSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewName_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objExportExcelSetEN.Update();
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
 /// <param name = "objExportExcelSet">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsExportExcelSetEN objExportExcelSet)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsExportExcelSetEN objExportExcelSetCond = new clsExportExcelSetEN();
string strCondition = objExportExcelSetCond
.SetViewName(objExportExcelSet.ViewName, "=")
.SetUserId(objExportExcelSet.UserId, "=")
.GetCombineCondition();
objExportExcelSet._IsCheckProperty = true;
bool bolIsExist = clsExportExcelSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objExportExcelSet.IdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(strCondition);
objExportExcelSet.UpdateWithCondition(strCondition);
}
else
{
objExportExcelSet.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
objExportExcelSet.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExportExcelSetBL.ExportExcelSetDA.UpdateBySql2(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExportExcelSetEN objExportExcelSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExportExcelSetBL.ExportExcelSetDA.UpdateBySql2(objExportExcelSetEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExportExcelSetEN objExportExcelSetEN, string strWhereCond)
{
try
{
bool bolResult = clsExportExcelSetBL.ExportExcelSetDA.UpdateBySqlWithCondition(objExportExcelSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExportExcelSetEN objExportExcelSetEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsExportExcelSetBL.ExportExcelSetDA.UpdateBySqlWithConditionTransaction(objExportExcelSetEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsExportExcelSetEN objExportExcelSetEN)
{
try
{
int intRecNum = clsExportExcelSetBL.ExportExcelSetDA.DelRecord(objExportExcelSetEN.IdExportExcel4Users);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetENS">源对象</param>
 /// <param name = "objExportExcelSetENT">目标对象</param>
 public static void CopyTo(this clsExportExcelSetEN objExportExcelSetENS, clsExportExcelSetEN objExportExcelSetENT)
{
try
{
objExportExcelSetENT.IdExportExcel4Users = objExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcelSetENT.ViewName = objExportExcelSetENS.ViewName; //界面名称
objExportExcelSetENT.TabName = objExportExcelSetENS.TabName; //表名
objExportExcelSetENT.UserId = objExportExcelSetENS.UserId; //用户Id
objExportExcelSetENT.IsDefaultUser = objExportExcelSetENS.IsDefaultUser; //是否缺省用户
objExportExcelSetENT.ExportFileName = objExportExcelSetENS.ExportFileName; //导出文件名
objExportExcelSetENT.UpdDate = objExportExcelSetENS.UpdDate; //修改日期
objExportExcelSetENT.UpdUserId = objExportExcelSetENS.UpdUserId; //修改用户Id
objExportExcelSetENT.Memo = objExportExcelSetENS.Memo; //说明
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
 /// <param name = "objExportExcelSetENS">源对象</param>
 /// <returns>目标对象=>clsExportExcelSetEN:objExportExcelSetENT</returns>
 public static clsExportExcelSetEN CopyTo(this clsExportExcelSetEN objExportExcelSetENS)
{
try
{
 clsExportExcelSetEN objExportExcelSetENT = new clsExportExcelSetEN()
{
IdExportExcel4Users = objExportExcelSetENS.IdExportExcel4Users, //导出Excel用户字段流水号
ViewName = objExportExcelSetENS.ViewName, //界面名称
TabName = objExportExcelSetENS.TabName, //表名
UserId = objExportExcelSetENS.UserId, //用户Id
IsDefaultUser = objExportExcelSetENS.IsDefaultUser, //是否缺省用户
ExportFileName = objExportExcelSetENS.ExportFileName, //导出文件名
UpdDate = objExportExcelSetENS.UpdDate, //修改日期
UpdUserId = objExportExcelSetENS.UpdUserId, //修改用户Id
Memo = objExportExcelSetENS.Memo, //说明
};
 return objExportExcelSetENT;
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
public static void CheckPropertyNew(this clsExportExcelSetEN objExportExcelSetEN)
{
 clsExportExcelSetBL.ExportExcelSetDA.CheckPropertyNew(objExportExcelSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsExportExcelSetEN objExportExcelSetEN)
{
 clsExportExcelSetBL.ExportExcelSetDA.CheckProperty4Condition(objExportExcelSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExportExcelSetEN objExportExcelSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.IdExportExcel4Users) == true)
{
string strComparisonOpIdExportExcel4Users = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.IdExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.IdExportExcel4Users, objExportExcelSetCond.IdExportExcel4Users, strComparisonOpIdExportExcel4Users);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.ViewName) == true)
{
string strComparisonOpViewName = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.ViewName, objExportExcelSetCond.ViewName, strComparisonOpViewName);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.TabName) == true)
{
string strComparisonOpTabName = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.TabName, objExportExcelSetCond.TabName, strComparisonOpTabName);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.UserId) == true)
{
string strComparisonOpUserId = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.UserId, objExportExcelSetCond.UserId, strComparisonOpUserId);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.IsDefaultUser) == true)
{
if (objExportExcelSetCond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExportExcelSet.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExportExcelSet.IsDefaultUser);
}
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.ExportFileName) == true)
{
string strComparisonOpExportFileName = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.ExportFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.ExportFileName, objExportExcelSetCond.ExportFileName, strComparisonOpExportFileName);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.UpdDate, objExportExcelSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.UpdUserId, objExportExcelSetCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objExportExcelSetCond.IsUpdated(conExportExcelSet.Memo) == true)
{
string strComparisonOpMemo = objExportExcelSetCond.dicFldComparisonOp[conExportExcelSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcelSet.Memo, objExportExcelSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExportExcelSet(导出Excel设置), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewName_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objExportExcelSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsExportExcelSetEN objExportExcelSetEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objExportExcelSetEN == null) return true;
if (objExportExcelSetEN.IdExportExcel4Users == null || objExportExcelSetEN.IdExportExcel4Users == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objExportExcelSetEN.ViewName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objExportExcelSetEN.UserId);
if (clsExportExcelSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdExportExcel4Users !=  '{0}'", objExportExcelSetEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objExportExcelSetEN.ViewName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objExportExcelSetEN.UserId);
if (clsExportExcelSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ExportExcelSet(导出Excel设置), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewName_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExportExcelSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsExportExcelSetEN objExportExcelSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExportExcelSetEN == null) return "";
if (objExportExcelSetEN.IdExportExcel4Users == null || objExportExcelSetEN.IdExportExcel4Users == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objExportExcelSetEN.ViewName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objExportExcelSetEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdExportExcel4Users !=  '{0}'", objExportExcelSetEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objExportExcelSetEN.ViewName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objExportExcelSetEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ExportExcelSet
{
public virtual bool UpdRelaTabDate(string strIdExportExcel4Users, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsExportExcelSetBL
{
public static RelatedActions_ExportExcelSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsExportExcelSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsExportExcelSetDA ExportExcelSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsExportExcelSetDA();
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
 public clsExportExcelSetBL()
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
if (string.IsNullOrEmpty(clsExportExcelSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExportExcelSetEN._ConnectString);
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
public static DataTable GetDataTable_ExportExcelSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ExportExcelSetDA.GetDataTable_ExportExcelSet(strWhereCond);
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
objDT = ExportExcelSetDA.GetDataTable(strWhereCond);
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
objDT = ExportExcelSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ExportExcelSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ExportExcelSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ExportExcelSetDA.GetDataTable_Top(objTopPara);
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
objDT = ExportExcelSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ExportExcelSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ExportExcelSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdExportExcel4UsersLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLstByIdExportExcel4UsersLst(List<string> arrIdExportExcel4UsersLst)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdExportExcel4UsersLst, true);
 string strWhereCond = string.Format("IdExportExcel4Users in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdExportExcel4UsersLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsExportExcelSetEN> GetObjLstByIdExportExcel4UsersLstCache(List<string> arrIdExportExcel4UsersLst)
{
string strKey = string.Format("{0}", clsExportExcelSetEN._CurrTabName);
List<clsExportExcelSetEN> arrExportExcelSetObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcelSetEN> arrExportExcelSetObjLst_Sel =
arrExportExcelSetObjLstCache
.Where(x => arrIdExportExcel4UsersLst.Contains(x.IdExportExcel4Users));
return arrExportExcelSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLst(string strWhereCond)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
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
public static List<clsExportExcelSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objExportExcelSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsExportExcelSetEN> GetSubObjLstCache(clsExportExcelSetEN objExportExcelSetCond)
{
List<clsExportExcelSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcelSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExportExcelSet._AttributeName)
{
if (objExportExcelSetCond.IsUpdated(strFldName) == false) continue;
if (objExportExcelSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcelSetCond[strFldName].ToString());
}
else
{
if (objExportExcelSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExportExcelSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcelSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExportExcelSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExportExcelSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExportExcelSetCond[strFldName]));
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
public static List<clsExportExcelSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
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
public static List<clsExportExcelSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
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
List<clsExportExcelSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsExportExcelSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcelSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsExportExcelSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
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
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
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
public static List<clsExportExcelSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsExportExcelSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
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
public static List<clsExportExcelSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetExportExcelSet(ref clsExportExcelSetEN objExportExcelSetEN)
{
bool bolResult = ExportExcelSetDA.GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcelSetEN GetObjByIdExportExcel4Users(string strIdExportExcel4Users)
{
if (strIdExportExcel4Users.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdExportExcel4Users]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdExportExcel4Users]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsExportExcelSetEN objExportExcelSetEN = ExportExcelSetDA.GetObjByIdExportExcel4Users(strIdExportExcel4Users);
return objExportExcelSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsExportExcelSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsExportExcelSetEN objExportExcelSetEN = ExportExcelSetDA.GetFirstObj(strWhereCond);
 return objExportExcelSetEN;
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
public static clsExportExcelSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsExportExcelSetEN objExportExcelSetEN = ExportExcelSetDA.GetObjByDataRow(objRow);
 return objExportExcelSetEN;
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
public static clsExportExcelSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsExportExcelSetEN objExportExcelSetEN = ExportExcelSetDA.GetObjByDataRow(objRow);
 return objExportExcelSetEN;
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
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <param name = "lstExportExcelSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExportExcelSetEN GetObjByIdExportExcel4UsersFromList(string strIdExportExcel4Users, List<clsExportExcelSetEN> lstExportExcelSetObjLst)
{
foreach (clsExportExcelSetEN objExportExcelSetEN in lstExportExcelSetObjLst)
{
if (objExportExcelSetEN.IdExportExcel4Users == strIdExportExcel4Users)
{
return objExportExcelSetEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdExportExcel4Users;
 try
 {
 strMaxIdExportExcel4Users = clsExportExcelSetDA.GetMaxStrId();
 return strMaxIdExportExcel4Users;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdExportExcel4Users;
 try
 {
 strIdExportExcel4Users = new clsExportExcelSetDA().GetFirstID(strWhereCond);
 return strIdExportExcel4Users;
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
 arrList = ExportExcelSetDA.GetID(strWhereCond);
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
bool bolIsExist = ExportExcelSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdExportExcel4Users)
{
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdExportExcel4Users]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ExportExcelSetDA.IsExist(strIdExportExcel4Users);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdExportExcel4Users">导出Excel用户字段流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdExportExcel4Users, string strOpUser)
{
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetObjByIdExportExcel4Users(strIdExportExcel4Users);
objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objExportExcelSetEN.UpdUserId = strOpUser;
return clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
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
 bolIsExist = clsExportExcelSetDA.IsExistTable();
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
 bolIsExist = ExportExcelSetDA.IsExistTable(strTabName);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExportExcelSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],用户Id = [{1}]的数据已经存在!(in clsExportExcelSetBL.AddNewRecordBySql2)", objExportExcelSetEN.ViewName,objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
bool bolResult = ExportExcelSetDA.AddNewRecordBySQL2(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsExportExcelSetEN objExportExcelSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExportExcelSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面名称 = [{0}],用户Id = [{1}]的数据已经存在!(in clsExportExcelSetBL.AddNewRecordBySql2WithReturnKey)", objExportExcelSetEN.ViewName,objExportExcelSetEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true || clsExportExcelSetBL.IsExist(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
     objExportExcelSetEN.IdExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
 }
string strKey = ExportExcelSetDA.AddNewRecordBySQL2WithReturnKey(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsExportExcelSetEN objExportExcelSetEN)
{
try
{
bool bolResult = ExportExcelSetDA.Update(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(objExportExcelSetEN.IdExportExcel4Users) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ExportExcelSetDA.UpdateBySql2(objExportExcelSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcelSetBL.ReFreshCache();

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
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
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdExportExcel4Users)
{
try
{
 clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetObjByIdExportExcel4Users(strIdExportExcel4Users);

if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(objExportExcelSetEN.IdExportExcel4Users, objExportExcelSetEN.UpdUserId);
}
if (objExportExcelSetEN != null)
{
int intRecNum = ExportExcelSetDA.DelRecord(strIdExportExcel4Users);
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
/// <param name="strIdExportExcel4Users">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdExportExcel4Users )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
//删除与表:[ExportExcelSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conExportExcelSet.IdExportExcel4Users,
//strIdExportExcel4Users);
//        clsExportExcelSetBL.DelExportExcelSetsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExportExcelSetBL.DelRecord(strIdExportExcel4Users, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExportExcelSetBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdExportExcel4Users, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdExportExcel4Users, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsExportExcelSetBL.relatedActions != null)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(strIdExportExcel4Users, "UpdRelaTabDate");
}
bool bolResult = ExportExcelSetDA.DelRecord(strIdExportExcel4Users,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdExportExcel4UsersLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelExportExcelSets(List<string> arrIdExportExcel4UsersLst)
{
if (arrIdExportExcel4UsersLst.Count == 0) return 0;
try
{
if (clsExportExcelSetBL.relatedActions != null)
{
foreach (var strIdExportExcel4Users in arrIdExportExcel4UsersLst)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(strIdExportExcel4Users, "UpdRelaTabDate");
}
}
int intDelRecNum = ExportExcelSetDA.DelExportExcelSet(arrIdExportExcel4UsersLst);
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
public static int DelExportExcelSetsByCond(string strWhereCond)
{
try
{
if (clsExportExcelSetBL.relatedActions != null)
{
List<string> arrIdExportExcel4Users = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdExportExcel4Users in arrIdExportExcel4Users)
{
clsExportExcelSetBL.relatedActions.UpdRelaTabDate(strIdExportExcel4Users, "UpdRelaTabDate");
}
}
int intRecNum = ExportExcelSetDA.DelExportExcelSet(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ExportExcelSet]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdExportExcel4Users">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdExportExcel4Users)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
//删除与表:[ExportExcelSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExportExcelSetBL.DelRecord(strIdExportExcel4Users, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExportExcelSetBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdExportExcel4Users, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objExportExcelSetENS">源对象</param>
 /// <param name = "objExportExcelSetENT">目标对象</param>
 public static void CopyTo(clsExportExcelSetEN objExportExcelSetENS, clsExportExcelSetEN objExportExcelSetENT)
{
try
{
objExportExcelSetENT.IdExportExcel4Users = objExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcelSetENT.ViewName = objExportExcelSetENS.ViewName; //界面名称
objExportExcelSetENT.TabName = objExportExcelSetENS.TabName; //表名
objExportExcelSetENT.UserId = objExportExcelSetENS.UserId; //用户Id
objExportExcelSetENT.IsDefaultUser = objExportExcelSetENS.IsDefaultUser; //是否缺省用户
objExportExcelSetENT.ExportFileName = objExportExcelSetENS.ExportFileName; //导出文件名
objExportExcelSetENT.UpdDate = objExportExcelSetENS.UpdDate; //修改日期
objExportExcelSetENT.UpdUserId = objExportExcelSetENS.UpdUserId; //修改用户Id
objExportExcelSetENT.Memo = objExportExcelSetENS.Memo; //说明
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
 /// <param name = "objExportExcelSetEN">源简化对象</param>
 public static void SetUpdFlag(clsExportExcelSetEN objExportExcelSetEN)
{
try
{
objExportExcelSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objExportExcelSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conExportExcelSet.IdExportExcel4Users, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.IdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users; //导出Excel用户字段流水号
}
if (arrFldSet.Contains(conExportExcelSet.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.ViewName = objExportExcelSetEN.ViewName; //界面名称
}
if (arrFldSet.Contains(conExportExcelSet.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.TabName = objExportExcelSetEN.TabName; //表名
}
if (arrFldSet.Contains(conExportExcelSet.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.UserId = objExportExcelSetEN.UserId; //用户Id
}
if (arrFldSet.Contains(conExportExcelSet.IsDefaultUser, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.IsDefaultUser = objExportExcelSetEN.IsDefaultUser; //是否缺省用户
}
if (arrFldSet.Contains(conExportExcelSet.ExportFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.ExportFileName = objExportExcelSetEN.ExportFileName; //导出文件名
}
if (arrFldSet.Contains(conExportExcelSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.UpdDate = objExportExcelSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conExportExcelSet.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.UpdUserId = objExportExcelSetEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conExportExcelSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcelSetEN.Memo = objExportExcelSetEN.Memo == "[null]" ? null :  objExportExcelSetEN.Memo; //说明
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
 /// <param name = "objExportExcelSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsExportExcelSetEN objExportExcelSetEN)
{
try
{
if (objExportExcelSetEN.Memo == "[null]") objExportExcelSetEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsExportExcelSetEN objExportExcelSetEN)
{
 ExportExcelSetDA.CheckPropertyNew(objExportExcelSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsExportExcelSetEN objExportExcelSetEN)
{
 ExportExcelSetDA.CheckProperty4Condition(objExportExcelSetEN);
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
if (clsExportExcelSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcelSetBL没有刷新缓存机制(clsExportExcelSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdExportExcel4Users");
//if (arrExportExcelSetObjLstCache == null)
//{
//arrExportExcelSetObjLstCache = ExportExcelSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExportExcelSetEN GetObjByIdExportExcel4UsersCache(string strIdExportExcel4Users)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsExportExcelSetEN._CurrTabName);
List<clsExportExcelSetEN> arrExportExcelSetObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcelSetEN> arrExportExcelSetObjLst_Sel =
arrExportExcelSetObjLstCache
.Where(x=> x.IdExportExcel4Users == strIdExportExcel4Users 
);
if (arrExportExcelSetObjLst_Sel.Count() == 0)
{
   clsExportExcelSetEN obj = clsExportExcelSetBL.GetObjByIdExportExcel4Users(strIdExportExcel4Users);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrExportExcelSetObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExportExcelSetEN> GetAllExportExcelSetObjLstCache()
{
//获取缓存中的对象列表
List<clsExportExcelSetEN> arrExportExcelSetObjLstCache = GetObjLstCache(); 
return arrExportExcelSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsExportExcelSetEN._CurrTabName);
List<clsExportExcelSetEN> arrExportExcelSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrExportExcelSetObjLstCache;
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
string strKey = string.Format("{0}", clsExportExcelSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsExportExcelSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsExportExcelSetEN._RefreshTimeLst.Count == 0) return "";
return clsExportExcelSetEN._RefreshTimeLst[clsExportExcelSetEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsExportExcelSetBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsExportExcelSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsExportExcelSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsExportExcelSetBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ExportExcelSet(导出Excel设置)
 /// 唯一性条件:ViewName_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExportExcelSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsExportExcelSetEN objExportExcelSetEN)
{
//检测记录是否存在
string strResult = ExportExcelSetDA.GetUniCondStr(objExportExcelSetEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdExportExcel4Users)
{
if (strInFldName != conExportExcelSet.IdExportExcel4Users)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conExportExcelSet._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conExportExcelSet._AttributeName));
throw new Exception(strMsg);
}
var objExportExcelSet = clsExportExcelSetBL.GetObjByIdExportExcel4UsersCache(strIdExportExcel4Users);
if (objExportExcelSet == null) return "";
return objExportExcelSet[strOutFldName].ToString();
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
int intRecCount = clsExportExcelSetDA.GetRecCount(strTabName);
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
int intRecCount = clsExportExcelSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsExportExcelSetDA.GetRecCount();
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
int intRecCount = clsExportExcelSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objExportExcelSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsExportExcelSetEN objExportExcelSetCond)
{
List<clsExportExcelSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcelSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExportExcelSet._AttributeName)
{
if (objExportExcelSetCond.IsUpdated(strFldName) == false) continue;
if (objExportExcelSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcelSetCond[strFldName].ToString());
}
else
{
if (objExportExcelSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExportExcelSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcelSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExportExcelSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExportExcelSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExportExcelSetCond[strFldName]));
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
 List<string> arrList = clsExportExcelSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ExportExcelSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ExportExcelSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ExportExcelSetDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsExportExcelSetDA.SetFldValue(clsExportExcelSetEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ExportExcelSetDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsExportExcelSetDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsExportExcelSetDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsExportExcelSetDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ExportExcelSet] "); 
 strCreateTabCode.Append(" ( "); 
 // /**导出Excel用户字段流水号*/ 
 strCreateTabCode.Append(" IdExportExcel4Users char(8) primary key, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**是否缺省用户*/ 
 strCreateTabCode.Append(" IsDefaultUser bit not Null, "); 
 // /**导出文件名*/ 
 strCreateTabCode.Append(" ExportFileName varchar(100) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ExportExcelSet : clsCommFun4BL
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
clsExportExcelSetBL.ReFreshThisCache();
}
}

}