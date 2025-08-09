
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersBL
 表名:ExportExcel4Users(00050241)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsExportExcel4UsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcel4UsersEN GetObj(this K_mId_ExportExcel4Users myKey)
{
clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.ExportExcel4UsersDA.GetObjBymId(myKey.Value);
return objExportExcel4UsersEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExportExcel4UsersEN) == false)
{
var strMsg = string.Format("记录已经存在!导出Excel用户字段流水号 = [{0}],字段名 = [{1}]的数据已经存在!(in clsExportExcel4UsersBL.AddNewRecord)", objExportExcel4UsersEN.IdExportExcel4Users,objExportExcel4UsersEN.FieldName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsExportExcel4UsersBL.ExportExcel4UsersDA.AddNewRecordBySQL2(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
public static bool AddRecordEx(this clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsNeedCheckUniqueness = true)
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
objExportExcel4UsersEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objExportExcel4UsersEN.CheckUniqueness() == false)
{
strMsg = string.Format("(导出Excel用户字段流水号(IdExportExcel4Users)=[{0}],字段名(FieldName)=[{1}])已经存在,不能重复!", objExportExcel4UsersEN.IdExportExcel4Users, objExportExcel4UsersEN.FieldName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objExportExcel4UsersEN.AddNewRecord();
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExportExcel4UsersEN) == false)
{
var strMsg = string.Format("记录已经存在!导出Excel用户字段流水号 = [{0}],字段名 = [{1}]的数据已经存在!(in clsExportExcel4UsersBL.AddNewRecordWithReturnKey)", objExportExcel4UsersEN.IdExportExcel4Users,objExportExcel4UsersEN.FieldName);
throw new Exception(strMsg);
}
try
{
string strKey = clsExportExcel4UsersBL.ExportExcel4UsersDA.AddNewRecordBySQL2WithReturnKey(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetmId(this clsExportExcel4UsersEN objExportExcel4UsersEN, long lngmId, string strComparisonOp="")
	{
objExportExcel4UsersEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.mId) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.mId, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.mId] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetIdExportExcel4Users(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strIdExportExcel4Users, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
}
objExportExcel4UsersEN.IdExportExcel4Users = strIdExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.IdExportExcel4Users) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.IdExportExcel4Users, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.IdExportExcel4Users] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetFieldName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldName, conExportExcel4Users.FieldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldName, 50, conExportExcel4Users.FieldName);
}
objExportExcel4UsersEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.FieldName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.FieldName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.FieldName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetFieldCnName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strFieldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldCnName, conExportExcel4Users.FieldCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldCnName, 50, conExportExcel4Users.FieldCnName);
}
objExportExcel4UsersEN.FieldCnName = strFieldCnName; //字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.FieldCnName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.FieldCnName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.FieldCnName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetIsExport(this clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsExport, conExportExcel4Users.IsExport);
objExportExcel4UsersEN.IsExport = bolIsExport; //是否导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.IsExport) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.IsExport, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.IsExport] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetOrderNum(this clsExportExcel4UsersEN objExportExcel4UsersEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conExportExcel4Users.OrderNum);
objExportExcel4UsersEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.OrderNum) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.OrderNum, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.OrderNum] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetViewName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, conExportExcel4Users.ViewName);
}
objExportExcel4UsersEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.ViewName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.ViewName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.ViewName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetUpdDate(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conExportExcel4Users.UpdDate);
}
objExportExcel4UsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.UpdDate) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.UpdDate, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.UpdDate] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetUpdUserId(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conExportExcel4Users.UpdUserId);
}
objExportExcel4UsersEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.UpdUserId) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.UpdUserId, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.UpdUserId] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetMemo(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExportExcel4Users.Memo);
}
objExportExcel4UsersEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.Memo) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.Memo, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.Memo] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objExportExcel4UsersEN.CheckPropertyNew();
clsExportExcel4UsersEN objExportExcel4UsersCond = new clsExportExcel4UsersEN();
string strCondition = objExportExcel4UsersCond
.SetmId(objExportExcel4UsersEN.mId, "<>")
.SetIdExportExcel4Users(objExportExcel4UsersEN.IdExportExcel4Users, "=")
.SetFieldName(objExportExcel4UsersEN.FieldName, "=")
.GetCombineCondition();
objExportExcel4UsersEN._IsCheckProperty = true;
bool bolIsExist = clsExportExcel4UsersBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_ExportExcel4Users_FieldName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objExportExcel4UsersEN.Update();
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
 /// <param name = "objExportExcel4Users">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsExportExcel4UsersEN objExportExcel4Users)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsExportExcel4UsersEN objExportExcel4UsersCond = new clsExportExcel4UsersEN();
string strCondition = objExportExcel4UsersCond
.SetIdExportExcel4Users(objExportExcel4Users.IdExportExcel4Users, "=")
.SetFieldName(objExportExcel4Users.FieldName, "=")
.GetCombineCondition();
objExportExcel4Users._IsCheckProperty = true;
bool bolIsExist = clsExportExcel4UsersBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objExportExcel4Users.mId = clsExportExcel4UsersBL.GetFirstID_S(strCondition);
objExportExcel4Users.UpdateWithCondition(strCondition);
}
else
{
objExportExcel4Users.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (objExportExcel4UsersEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExportExcel4UsersBL.ExportExcel4UsersDA.UpdateBySql2(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExportExcel4UsersEN objExportExcel4UsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objExportExcel4UsersEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExportExcel4UsersBL.ExportExcel4UsersDA.UpdateBySql2(objExportExcel4UsersEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strWhereCond)
{
try
{
bool bolResult = clsExportExcel4UsersBL.ExportExcel4UsersDA.UpdateBySqlWithCondition(objExportExcel4UsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsExportExcel4UsersBL.ExportExcel4UsersDA.UpdateBySqlWithConditionTransaction(objExportExcel4UsersEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
public static int Delete(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
try
{
int intRecNum = clsExportExcel4UsersBL.ExportExcel4UsersDA.DelRecord(objExportExcel4UsersEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <param name = "objExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(this clsExportExcel4UsersEN objExportExcel4UsersENS, clsExportExcel4UsersEN objExportExcel4UsersENT)
{
try
{
objExportExcel4UsersENT.mId = objExportExcel4UsersENS.mId; //mId
objExportExcel4UsersENT.IdExportExcel4Users = objExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcel4UsersENT.FieldName = objExportExcel4UsersENS.FieldName; //字段名
objExportExcel4UsersENT.FieldCnName = objExportExcel4UsersENS.FieldCnName; //字段中文名称
objExportExcel4UsersENT.IsExport = objExportExcel4UsersENS.IsExport; //是否导出
objExportExcel4UsersENT.OrderNum = objExportExcel4UsersENS.OrderNum; //序号
objExportExcel4UsersENT.ViewName = objExportExcel4UsersENS.ViewName; //界面名称
objExportExcel4UsersENT.UpdDate = objExportExcel4UsersENS.UpdDate; //修改日期
objExportExcel4UsersENT.UpdUserId = objExportExcel4UsersENS.UpdUserId; //修改用户Id
objExportExcel4UsersENT.Memo = objExportExcel4UsersENS.Memo; //说明
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <returns>目标对象=>clsExportExcel4UsersEN:objExportExcel4UsersENT</returns>
 public static clsExportExcel4UsersEN CopyTo(this clsExportExcel4UsersEN objExportExcel4UsersENS)
{
try
{
 clsExportExcel4UsersEN objExportExcel4UsersENT = new clsExportExcel4UsersEN()
{
mId = objExportExcel4UsersENS.mId, //mId
IdExportExcel4Users = objExportExcel4UsersENS.IdExportExcel4Users, //导出Excel用户字段流水号
FieldName = objExportExcel4UsersENS.FieldName, //字段名
FieldCnName = objExportExcel4UsersENS.FieldCnName, //字段中文名称
IsExport = objExportExcel4UsersENS.IsExport, //是否导出
OrderNum = objExportExcel4UsersENS.OrderNum, //序号
ViewName = objExportExcel4UsersENS.ViewName, //界面名称
UpdDate = objExportExcel4UsersENS.UpdDate, //修改日期
UpdUserId = objExportExcel4UsersENS.UpdUserId, //修改用户Id
Memo = objExportExcel4UsersENS.Memo, //说明
};
 return objExportExcel4UsersENT;
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
public static void CheckPropertyNew(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 clsExportExcel4UsersBL.ExportExcel4UsersDA.CheckPropertyNew(objExportExcel4UsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 clsExportExcel4UsersBL.ExportExcel4UsersDA.CheckProperty4Condition(objExportExcel4UsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExportExcel4UsersEN objExportExcel4UsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.mId) == true)
{
string strComparisonOpmId = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conExportExcel4Users.mId, objExportExcel4UsersCond.mId, strComparisonOpmId);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.IdExportExcel4Users) == true)
{
string strComparisonOpIdExportExcel4Users = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.IdExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.IdExportExcel4Users, objExportExcel4UsersCond.IdExportExcel4Users, strComparisonOpIdExportExcel4Users);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.FieldName) == true)
{
string strComparisonOpFieldName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.FieldName, objExportExcel4UsersCond.FieldName, strComparisonOpFieldName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.FieldCnName) == true)
{
string strComparisonOpFieldCnName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.FieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.FieldCnName, objExportExcel4UsersCond.FieldCnName, strComparisonOpFieldCnName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.IsExport) == true)
{
if (objExportExcel4UsersCond.IsExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExportExcel4Users.IsExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExportExcel4Users.IsExport);
}
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.OrderNum) == true)
{
string strComparisonOpOrderNum = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conExportExcel4Users.OrderNum, objExportExcel4UsersCond.OrderNum, strComparisonOpOrderNum);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.ViewName) == true)
{
string strComparisonOpViewName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.ViewName, objExportExcel4UsersCond.ViewName, strComparisonOpViewName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.UpdDate) == true)
{
string strComparisonOpUpdDate = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.UpdDate, objExportExcel4UsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.UpdUserId, objExportExcel4UsersCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.Memo) == true)
{
string strComparisonOpMemo = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.Memo, objExportExcel4UsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExportExcel4Users(导出Excel用户字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_ExportExcel4Users_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objExportExcel4UsersEN == null) return true;
if (objExportExcel4UsersEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
if (clsExportExcel4UsersBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExportExcel4UsersEN.mId);
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
if (clsExportExcel4UsersBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ExportExcel4Users(导出Excel用户字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_ExportExcel4Users_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExportExcel4UsersEN == null) return "";
if (objExportExcel4UsersEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExportExcel4UsersEN.mId);
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ExportExcel4Users
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 导出Excel用户字段(ExportExcel4Users)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsExportExcel4UsersBL
{
public static RelatedActions_ExportExcel4Users relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsExportExcel4UsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsExportExcel4UsersDA ExportExcel4UsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsExportExcel4UsersDA();
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
 public clsExportExcel4UsersBL()
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
if (string.IsNullOrEmpty(clsExportExcel4UsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExportExcel4UsersEN._ConnectString);
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
public static DataTable GetDataTable_ExportExcel4Users(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ExportExcel4UsersDA.GetDataTable_ExportExcel4Users(strWhereCond);
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
objDT = ExportExcel4UsersDA.GetDataTable(strWhereCond);
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
objDT = ExportExcel4UsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ExportExcel4UsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ExportExcel4UsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ExportExcel4UsersDA.GetDataTable_Top(objTopPara);
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
objDT = ExportExcel4UsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ExportExcel4UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ExportExcel4UsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsExportExcel4UsersEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
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
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsExportExcel4UsersEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrExportExcel4UsersObjLst_Sel =
arrExportExcel4UsersObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrExportExcel4UsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLst(string strWhereCond)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
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
public static List<clsExportExcel4UsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objExportExcel4UsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsExportExcel4UsersEN> GetSubObjLstCache(clsExportExcel4UsersEN objExportExcel4UsersCond)
{
List<clsExportExcel4UsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExportExcel4Users._AttributeName)
{
if (objExportExcel4UsersCond.IsUpdated(strFldName) == false) continue;
if (objExportExcel4UsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcel4UsersCond[strFldName].ToString());
}
else
{
if (objExportExcel4UsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExportExcel4UsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcel4UsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExportExcel4UsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExportExcel4UsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExportExcel4UsersCond[strFldName]));
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
public static List<clsExportExcel4UsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
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
public static List<clsExportExcel4UsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
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
List<clsExportExcel4UsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsExportExcel4UsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcel4UsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsExportExcel4UsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
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
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
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
public static List<clsExportExcel4UsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsExportExcel4UsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
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
public static List<clsExportExcel4UsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExportExcel4UsersEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetExportExcel4Users(ref clsExportExcel4UsersEN objExportExcel4UsersEN)
{
bool bolResult = ExportExcel4UsersDA.GetExportExcel4Users(ref objExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcel4UsersEN GetObjBymId(long lngmId)
{
clsExportExcel4UsersEN objExportExcel4UsersEN = ExportExcel4UsersDA.GetObjBymId(lngmId);
return objExportExcel4UsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsExportExcel4UsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsExportExcel4UsersEN objExportExcel4UsersEN = ExportExcel4UsersDA.GetFirstObj(strWhereCond);
 return objExportExcel4UsersEN;
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
public static clsExportExcel4UsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsExportExcel4UsersEN objExportExcel4UsersEN = ExportExcel4UsersDA.GetObjByDataRow(objRow);
 return objExportExcel4UsersEN;
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
public static clsExportExcel4UsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsExportExcel4UsersEN objExportExcel4UsersEN = ExportExcel4UsersDA.GetObjByDataRow(objRow);
 return objExportExcel4UsersEN;
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
 /// <param name = "lstExportExcel4UsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExportExcel4UsersEN GetObjBymIdFromList(long lngmId, List<clsExportExcel4UsersEN> lstExportExcel4UsersObjLst)
{
foreach (clsExportExcel4UsersEN objExportExcel4UsersEN in lstExportExcel4UsersObjLst)
{
if (objExportExcel4UsersEN.mId == lngmId)
{
return objExportExcel4UsersEN;
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
 lngmId = new clsExportExcel4UsersDA().GetFirstID(strWhereCond);
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
 arrList = ExportExcel4UsersDA.GetID(strWhereCond);
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
bool bolIsExist = ExportExcel4UsersDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ExportExcel4UsersDA.IsExist(lngmId);
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
clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetObjBymId(lngmId);
objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objExportExcel4UsersEN.UpdUserId = strOpUser;
return clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);
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
 bolIsExist = clsExportExcel4UsersDA.IsExistTable();
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
 bolIsExist = ExportExcel4UsersDA.IsExistTable(strTabName);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExportExcel4UsersEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!导出Excel用户字段流水号 = [{0}],字段名 = [{1}]的数据已经存在!(in clsExportExcel4UsersBL.AddNewRecordBySql2)", objExportExcel4UsersEN.IdExportExcel4Users,objExportExcel4UsersEN.FieldName);
throw new Exception(strMsg);
}
try
{
bool bolResult = ExportExcel4UsersDA.AddNewRecordBySQL2(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExportExcel4UsersEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!导出Excel用户字段流水号 = [{0}],字段名 = [{1}]的数据已经存在!(in clsExportExcel4UsersBL.AddNewRecordBySql2WithReturnKey)", objExportExcel4UsersEN.IdExportExcel4Users,objExportExcel4UsersEN.FieldName);
throw new Exception(strMsg);
}
try
{
string strKey = ExportExcel4UsersDA.AddNewRecordBySQL2WithReturnKey(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
try
{
bool bolResult = ExportExcel4UsersDA.Update(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (objExportExcel4UsersEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ExportExcel4UsersDA.UpdateBySql2(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.ReFreshCache();

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
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
 clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetObjBymId(lngmId);

if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(objExportExcel4UsersEN.mId, objExportExcel4UsersEN.UpdUserId);
}
if (objExportExcel4UsersEN != null)
{
int intRecNum = ExportExcel4UsersDA.DelRecord(lngmId);
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
objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
//删除与表:[ExportExcel4Users]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conExportExcel4Users.mId,
//lngmId);
//        clsExportExcel4UsersBL.DelExportExcel4UserssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExportExcel4UsersBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExportExcel4UsersBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsExportExcel4UsersBL.relatedActions != null)
{
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ExportExcel4UsersDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelExportExcel4Userss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsExportExcel4UsersBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = ExportExcel4UsersDA.DelExportExcel4Users(arrmIdLst);
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
public static int DelExportExcel4UserssByCond(string strWhereCond)
{
try
{
if (clsExportExcel4UsersBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsExportExcel4UsersBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = ExportExcel4UsersDA.DelExportExcel4Users(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ExportExcel4Users]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
//删除与表:[ExportExcel4Users]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExportExcel4UsersBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExportExcel4UsersBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <param name = "objExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(clsExportExcel4UsersEN objExportExcel4UsersENS, clsExportExcel4UsersEN objExportExcel4UsersENT)
{
try
{
objExportExcel4UsersENT.mId = objExportExcel4UsersENS.mId; //mId
objExportExcel4UsersENT.IdExportExcel4Users = objExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcel4UsersENT.FieldName = objExportExcel4UsersENS.FieldName; //字段名
objExportExcel4UsersENT.FieldCnName = objExportExcel4UsersENS.FieldCnName; //字段中文名称
objExportExcel4UsersENT.IsExport = objExportExcel4UsersENS.IsExport; //是否导出
objExportExcel4UsersENT.OrderNum = objExportExcel4UsersENS.OrderNum; //序号
objExportExcel4UsersENT.ViewName = objExportExcel4UsersENS.ViewName; //界面名称
objExportExcel4UsersENT.UpdDate = objExportExcel4UsersENS.UpdDate; //修改日期
objExportExcel4UsersENT.UpdUserId = objExportExcel4UsersENS.UpdUserId; //修改用户Id
objExportExcel4UsersENT.Memo = objExportExcel4UsersENS.Memo; //说明
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
 /// <param name = "objExportExcel4UsersEN">源简化对象</param>
 public static void SetUpdFlag(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
try
{
objExportExcel4UsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objExportExcel4UsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conExportExcel4Users.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.mId = objExportExcel4UsersEN.mId; //mId
}
if (arrFldSet.Contains(conExportExcel4Users.IdExportExcel4Users, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.IdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users; //导出Excel用户字段流水号
}
if (arrFldSet.Contains(conExportExcel4Users.FieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.FieldName = objExportExcel4UsersEN.FieldName; //字段名
}
if (arrFldSet.Contains(conExportExcel4Users.FieldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.FieldCnName = objExportExcel4UsersEN.FieldCnName; //字段中文名称
}
if (arrFldSet.Contains(conExportExcel4Users.IsExport, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.IsExport = objExportExcel4UsersEN.IsExport; //是否导出
}
if (arrFldSet.Contains(conExportExcel4Users.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.OrderNum = objExportExcel4UsersEN.OrderNum; //序号
}
if (arrFldSet.Contains(conExportExcel4Users.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.ViewName = objExportExcel4UsersEN.ViewName == "[null]" ? null :  objExportExcel4UsersEN.ViewName; //界面名称
}
if (arrFldSet.Contains(conExportExcel4Users.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.UpdDate = objExportExcel4UsersEN.UpdDate == "[null]" ? null :  objExportExcel4UsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conExportExcel4Users.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.UpdUserId = objExportExcel4UsersEN.UpdUserId == "[null]" ? null :  objExportExcel4UsersEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conExportExcel4Users.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objExportExcel4UsersEN.Memo = objExportExcel4UsersEN.Memo == "[null]" ? null :  objExportExcel4UsersEN.Memo; //说明
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
 /// <param name = "objExportExcel4UsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
try
{
if (objExportExcel4UsersEN.ViewName == "[null]") objExportExcel4UsersEN.ViewName = null; //界面名称
if (objExportExcel4UsersEN.UpdDate == "[null]") objExportExcel4UsersEN.UpdDate = null; //修改日期
if (objExportExcel4UsersEN.UpdUserId == "[null]") objExportExcel4UsersEN.UpdUserId = null; //修改用户Id
if (objExportExcel4UsersEN.Memo == "[null]") objExportExcel4UsersEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 ExportExcel4UsersDA.CheckPropertyNew(objExportExcel4UsersEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 ExportExcel4UsersDA.CheckProperty4Condition(objExportExcel4UsersEN);
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
if (clsExportExcel4UsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcel4UsersBL没有刷新缓存机制(clsExportExcel4UsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrExportExcel4UsersObjLstCache == null)
//{
//arrExportExcel4UsersObjLstCache = ExportExcel4UsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExportExcel4UsersEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrExportExcel4UsersObjLst_Sel =
arrExportExcel4UsersObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrExportExcel4UsersObjLst_Sel.Count() == 0)
{
   clsExportExcel4UsersEN obj = clsExportExcel4UsersBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrExportExcel4UsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExportExcel4UsersEN> GetAllExportExcel4UsersObjLstCache()
{
//获取缓存中的对象列表
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = GetObjLstCache(); 
return arrExportExcel4UsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrExportExcel4UsersObjLstCache;
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
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsExportExcel4UsersEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsExportExcel4UsersEN._RefreshTimeLst.Count == 0) return "";
return clsExportExcel4UsersEN._RefreshTimeLst[clsExportExcel4UsersEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsExportExcel4UsersBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsExportExcel4UsersEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsExportExcel4UsersBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ExportExcel4Users(导出Excel用户字段)
 /// 唯一性条件:id_ExportExcel4Users_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检测记录是否存在
string strResult = ExportExcel4UsersDA.GetUniCondStr(objExportExcel4UsersEN);
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
if (strInFldName != conExportExcel4Users.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conExportExcel4Users._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conExportExcel4Users._AttributeName));
throw new Exception(strMsg);
}
var objExportExcel4Users = clsExportExcel4UsersBL.GetObjBymIdCache(lngmId);
if (objExportExcel4Users == null) return "";
return objExportExcel4Users[strOutFldName].ToString();
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
int intRecCount = clsExportExcel4UsersDA.GetRecCount(strTabName);
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
int intRecCount = clsExportExcel4UsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsExportExcel4UsersDA.GetRecCount();
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
int intRecCount = clsExportExcel4UsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objExportExcel4UsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsExportExcel4UsersEN objExportExcel4UsersCond)
{
List<clsExportExcel4UsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExportExcel4Users._AttributeName)
{
if (objExportExcel4UsersCond.IsUpdated(strFldName) == false) continue;
if (objExportExcel4UsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcel4UsersCond[strFldName].ToString());
}
else
{
if (objExportExcel4UsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExportExcel4UsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExportExcel4UsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExportExcel4UsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExportExcel4UsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExportExcel4UsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExportExcel4UsersCond[strFldName]));
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
 List<string> arrList = clsExportExcel4UsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ExportExcel4UsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ExportExcel4UsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ExportExcel4UsersDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsExportExcel4UsersDA.SetFldValue(clsExportExcel4UsersEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ExportExcel4UsersDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsExportExcel4UsersDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsExportExcel4UsersDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsExportExcel4UsersDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ExportExcel4Users] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**导出Excel用户字段流水号*/ 
 strCreateTabCode.Append(" IdExportExcel4Users char(8) not Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FieldName varchar(50) not Null, "); 
 // /**字段中文名称*/ 
 strCreateTabCode.Append(" FieldCnName varchar(50) not Null, "); 
 // /**是否导出*/ 
 strCreateTabCode.Append(" IsExport bit not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) Null, "); 
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
 /// 导出Excel用户字段(ExportExcel4Users)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ExportExcel4Users : clsCommFun4BL
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
clsExportExcel4UsersBL.ReFreshThisCache();
}
}

}