
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityBL
 表名:SetFieldVisibility(00050242)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:23
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
public static class  clsSetFieldVisibilityBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSetFieldVisibilityEN GetObj(this K_mId_SetFieldVisibility myKey)
{
clsSetFieldVisibilityEN objSetFieldVisibilityEN = clsSetFieldVisibilityBL.SetFieldVisibilityDA.GetObjBymId(myKey.Value);
return objSetFieldVisibilityEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSetFieldVisibilityEN) == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],用户Id = [{1}],界面名称 = [{2}],字段名 = [{3}]的数据已经存在!(in clsSetFieldVisibilityBL.AddNewRecord)", objSetFieldVisibilityEN.IdSchool,objSetFieldVisibilityEN.UserId,objSetFieldVisibilityEN.ViewName,objSetFieldVisibilityEN.FieldName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSetFieldVisibilityBL.SetFieldVisibilityDA.AddNewRecordBySQL2(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
public static bool AddRecordEx(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsNeedCheckUniqueness = true)
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
objSetFieldVisibilityEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSetFieldVisibilityEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学校流水号(IdSchool)=[{0}],用户Id(UserId)=[{1}],界面名称(ViewName)=[{2}],字段名(FieldName)=[{3}])已经存在,不能重复!", objSetFieldVisibilityEN.IdSchool, objSetFieldVisibilityEN.UserId, objSetFieldVisibilityEN.ViewName, objSetFieldVisibilityEN.FieldName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSetFieldVisibilityEN.AddNewRecord();
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSetFieldVisibilityEN) == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],用户Id = [{1}],界面名称 = [{2}],字段名 = [{3}]的数据已经存在!(in clsSetFieldVisibilityBL.AddNewRecordWithReturnKey)", objSetFieldVisibilityEN.IdSchool,objSetFieldVisibilityEN.UserId,objSetFieldVisibilityEN.ViewName,objSetFieldVisibilityEN.FieldName);
throw new Exception(strMsg);
}
try
{
string strKey = clsSetFieldVisibilityBL.SetFieldVisibilityDA.AddNewRecordBySQL2WithReturnKey(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetmId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, long lngmId, string strComparisonOp="")
	{
objSetFieldVisibilityEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.mId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.mId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.mId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetIdSchool(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conSetFieldVisibility.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conSetFieldVisibility.IdSchool);
}
objSetFieldVisibilityEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.IdSchool) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.IdSchool, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.IdSchool] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conSetFieldVisibility.UserId);
}
objSetFieldVisibilityEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetViewName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, conSetFieldVisibility.ViewName);
}
objSetFieldVisibilityEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.ViewName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.ViewName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.ViewName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFieldName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldName, conSetFieldVisibility.FieldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldName, 50, conSetFieldVisibility.FieldName);
}
objSetFieldVisibilityEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FieldName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FieldName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FieldName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCaption(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, conSetFieldVisibility.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, conSetFieldVisibility.Caption);
}
objSetFieldVisibilityEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Caption) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Caption, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Caption] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCtrlType(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, conSetFieldVisibility.CtrlType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtrlType, 50, conSetFieldVisibility.CtrlType);
}
objSetFieldVisibilityEN.CtrlType = strCtrlType; //控件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.CtrlType) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.CtrlType, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.CtrlType] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetIsVisible(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsVisible, string strComparisonOp="")
	{
objSetFieldVisibilityEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.IsVisible) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.IsVisible, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.IsVisible] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdDate(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSetFieldVisibility.UpdDate);
}
objSetFieldVisibilityEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdDate) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdDate, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdDate] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSetFieldVisibility.UpdUserId);
}
objSetFieldVisibilityEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdUserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdUserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdUserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetMemo(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSetFieldVisibility.Memo);
}
objSetFieldVisibilityEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Memo) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Memo, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Memo] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFuncModuleId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
}
objSetFieldVisibilityEN.FuncModuleId = strFuncModuleId; //FuncModuleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FuncModuleId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FuncModuleId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSetFieldVisibilityEN.CheckPropertyNew();
clsSetFieldVisibilityEN objSetFieldVisibilityCond = new clsSetFieldVisibilityEN();
string strCondition = objSetFieldVisibilityCond
.SetmId(objSetFieldVisibilityEN.mId, "<>")
.SetIdSchool(objSetFieldVisibilityEN.IdSchool, "=")
.SetUserId(objSetFieldVisibilityEN.UserId, "=")
.SetViewName(objSetFieldVisibilityEN.ViewName, "=")
.SetFieldName(objSetFieldVisibilityEN.FieldName, "=")
.GetCombineCondition();
objSetFieldVisibilityEN._IsCheckProperty = true;
bool bolIsExist = clsSetFieldVisibilityBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_School_UserId_ViewName_FieldName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSetFieldVisibilityEN.Update();
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
 /// <param name = "objSetFieldVisibility">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSetFieldVisibilityEN objSetFieldVisibility)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSetFieldVisibilityEN objSetFieldVisibilityCond = new clsSetFieldVisibilityEN();
string strCondition = objSetFieldVisibilityCond
.SetIdSchool(objSetFieldVisibility.IdSchool, "=")
.SetUserId(objSetFieldVisibility.UserId, "=")
.SetViewName(objSetFieldVisibility.ViewName, "=")
.SetFieldName(objSetFieldVisibility.FieldName, "=")
.GetCombineCondition();
objSetFieldVisibility._IsCheckProperty = true;
bool bolIsExist = clsSetFieldVisibilityBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSetFieldVisibility.mId = clsSetFieldVisibilityBL.GetFirstID_S(strCondition);
objSetFieldVisibility.UpdateWithCondition(strCondition);
}
else
{
objSetFieldVisibility.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 if (objSetFieldVisibilityEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSetFieldVisibilityBL.SetFieldVisibilityDA.UpdateBySql2(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSetFieldVisibilityEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSetFieldVisibilityBL.SetFieldVisibilityDA.UpdateBySql2(objSetFieldVisibilityEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
try
{
bool bolResult = clsSetFieldVisibilityBL.SetFieldVisibilityDA.UpdateBySqlWithCondition(objSetFieldVisibilityEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSetFieldVisibilityBL.SetFieldVisibilityDA.UpdateBySqlWithConditionTransaction(objSetFieldVisibilityEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
public static int Delete(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
int intRecNum = clsSetFieldVisibilityBL.SetFieldVisibilityDA.DelRecord(objSetFieldVisibilityEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <param name = "objSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(this clsSetFieldVisibilityEN objSetFieldVisibilityENS, clsSetFieldVisibilityEN objSetFieldVisibilityENT)
{
try
{
objSetFieldVisibilityENT.mId = objSetFieldVisibilityENS.mId; //mId
objSetFieldVisibilityENT.IdSchool = objSetFieldVisibilityENS.IdSchool; //学校流水号
objSetFieldVisibilityENT.UserId = objSetFieldVisibilityENS.UserId; //用户Id
objSetFieldVisibilityENT.ViewName = objSetFieldVisibilityENS.ViewName; //界面名称
objSetFieldVisibilityENT.FieldName = objSetFieldVisibilityENS.FieldName; //字段名
objSetFieldVisibilityENT.Caption = objSetFieldVisibilityENS.Caption; //标题
objSetFieldVisibilityENT.CtrlType = objSetFieldVisibilityENS.CtrlType; //控件类型
objSetFieldVisibilityENT.IsVisible = objSetFieldVisibilityENS.IsVisible; //是否显示
objSetFieldVisibilityENT.UpdDate = objSetFieldVisibilityENS.UpdDate; //修改日期
objSetFieldVisibilityENT.UpdUserId = objSetFieldVisibilityENS.UpdUserId; //修改用户Id
objSetFieldVisibilityENT.Memo = objSetFieldVisibilityENS.Memo; //说明
objSetFieldVisibilityENT.FuncModuleId = objSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <returns>目标对象=>clsSetFieldVisibilityEN:objSetFieldVisibilityENT</returns>
 public static clsSetFieldVisibilityEN CopyTo(this clsSetFieldVisibilityEN objSetFieldVisibilityENS)
{
try
{
 clsSetFieldVisibilityEN objSetFieldVisibilityENT = new clsSetFieldVisibilityEN()
{
mId = objSetFieldVisibilityENS.mId, //mId
IdSchool = objSetFieldVisibilityENS.IdSchool, //学校流水号
UserId = objSetFieldVisibilityENS.UserId, //用户Id
ViewName = objSetFieldVisibilityENS.ViewName, //界面名称
FieldName = objSetFieldVisibilityENS.FieldName, //字段名
Caption = objSetFieldVisibilityENS.Caption, //标题
CtrlType = objSetFieldVisibilityENS.CtrlType, //控件类型
IsVisible = objSetFieldVisibilityENS.IsVisible, //是否显示
UpdDate = objSetFieldVisibilityENS.UpdDate, //修改日期
UpdUserId = objSetFieldVisibilityENS.UpdUserId, //修改用户Id
Memo = objSetFieldVisibilityENS.Memo, //说明
FuncModuleId = objSetFieldVisibilityENS.FuncModuleId, //FuncModuleId
};
 return objSetFieldVisibilityENT;
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
public static void CheckPropertyNew(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 clsSetFieldVisibilityBL.SetFieldVisibilityDA.CheckPropertyNew(objSetFieldVisibilityEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 clsSetFieldVisibilityBL.SetFieldVisibilityDA.CheckProperty4Condition(objSetFieldVisibilityEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.mId) == true)
{
string strComparisonOpmId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSetFieldVisibility.mId, objSetFieldVisibilityCond.mId, strComparisonOpmId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.IdSchool) == true)
{
string strComparisonOpIdSchool = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.IdSchool, objSetFieldVisibilityCond.IdSchool, strComparisonOpIdSchool);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UserId) == true)
{
string strComparisonOpUserId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UserId, objSetFieldVisibilityCond.UserId, strComparisonOpUserId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.ViewName) == true)
{
string strComparisonOpViewName = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.ViewName, objSetFieldVisibilityCond.ViewName, strComparisonOpViewName);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.FieldName) == true)
{
string strComparisonOpFieldName = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FieldName, objSetFieldVisibilityCond.FieldName, strComparisonOpFieldName);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.Caption) == true)
{
string strComparisonOpCaption = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Caption, objSetFieldVisibilityCond.Caption, strComparisonOpCaption);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.CtrlType) == true)
{
string strComparisonOpCtrlType = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.CtrlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.CtrlType, objSetFieldVisibilityCond.CtrlType, strComparisonOpCtrlType);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.IsVisible) == true)
{
if (objSetFieldVisibilityCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSetFieldVisibility.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSetFieldVisibility.IsVisible);
}
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UpdDate) == true)
{
string strComparisonOpUpdDate = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdDate, objSetFieldVisibilityCond.UpdDate, strComparisonOpUpdDate);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdUserId, objSetFieldVisibilityCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.Memo) == true)
{
string strComparisonOpMemo = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Memo, objSetFieldVisibilityCond.Memo, strComparisonOpMemo);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FuncModuleId, objSetFieldVisibilityCond.FuncModuleId, strComparisonOpFuncModuleId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SetFieldVisibility(设置字段可视性), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_School_UserId_ViewName_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSetFieldVisibilityEN == null) return true;
if (objSetFieldVisibilityEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objSetFieldVisibilityEN.IdSchool == null)
{
 sbCondition.AppendFormat(" and IdSchool is null", objSetFieldVisibilityEN.IdSchool);
}
else
{
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
}
 if (objSetFieldVisibilityEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objSetFieldVisibilityEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
}
 if (objSetFieldVisibilityEN.ViewName == null)
{
 sbCondition.AppendFormat(" and ViewName is null", objSetFieldVisibilityEN.ViewName);
}
else
{
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
}
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
if (clsSetFieldVisibilityBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSetFieldVisibilityEN.mId);
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
if (clsSetFieldVisibilityBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SetFieldVisibility(设置字段可视性), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_School_UserId_ViewName_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSetFieldVisibilityEN == null) return "";
if (objSetFieldVisibilityEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objSetFieldVisibilityEN.IdSchool == null)
{
 sbCondition.AppendFormat(" and IdSchool is null", objSetFieldVisibilityEN.IdSchool);
}
else
{
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
}
 if (objSetFieldVisibilityEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objSetFieldVisibilityEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
}
 if (objSetFieldVisibilityEN.ViewName == null)
{
 sbCondition.AppendFormat(" and ViewName is null", objSetFieldVisibilityEN.ViewName);
}
else
{
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
}
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSetFieldVisibilityEN.mId);
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SetFieldVisibility
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSetFieldVisibilityBL
{
public static RelatedActions_SetFieldVisibility relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSetFieldVisibilityDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSetFieldVisibilityDA SetFieldVisibilityDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSetFieldVisibilityDA();
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
 public clsSetFieldVisibilityBL()
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
if (string.IsNullOrEmpty(clsSetFieldVisibilityEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSetFieldVisibilityEN._ConnectString);
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
public static DataTable GetDataTable_SetFieldVisibility(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SetFieldVisibilityDA.GetDataTable_SetFieldVisibility(strWhereCond);
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
objDT = SetFieldVisibilityDA.GetDataTable(strWhereCond);
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
objDT = SetFieldVisibilityDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SetFieldVisibilityDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SetFieldVisibilityDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SetFieldVisibilityDA.GetDataTable_Top(objTopPara);
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
objDT = SetFieldVisibilityDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SetFieldVisibilityDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SetFieldVisibilityDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
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
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSetFieldVisibilityEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLstCache = GetObjLstCache();
IEnumerable <clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Sel =
arrSetFieldVisibilityObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrSetFieldVisibilityObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public static List<clsSetFieldVisibilityEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSetFieldVisibilityCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSetFieldVisibilityEN> GetSubObjLstCache(clsSetFieldVisibilityEN objSetFieldVisibilityCond)
{
List<clsSetFieldVisibilityEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSetFieldVisibilityEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSetFieldVisibility._AttributeName)
{
if (objSetFieldVisibilityCond.IsUpdated(strFldName) == false) continue;
if (objSetFieldVisibilityCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSetFieldVisibilityCond[strFldName].ToString());
}
else
{
if (objSetFieldVisibilityCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSetFieldVisibilityCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSetFieldVisibilityCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSetFieldVisibilityCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSetFieldVisibilityCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSetFieldVisibilityCond[strFldName]));
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
public static List<clsSetFieldVisibilityEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
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
List<clsSetFieldVisibilityEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSetFieldVisibilityEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSetFieldVisibilityEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
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
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public static List<clsSetFieldVisibilityEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
try
{
objSetFieldVisibilityEN.mId = Int32.Parse(objRow[conSetFieldVisibility.mId].ToString().Trim()); //mId
objSetFieldVisibilityEN.IdSchool = objRow[conSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[conSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.UserId = objRow[conSetFieldVisibility.UserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UserId].ToString().Trim(); //用户Id
objSetFieldVisibilityEN.ViewName = objRow[conSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[conSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow[conSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objSetFieldVisibilityEN.Caption = objRow[conSetFieldVisibility.Caption].ToString().Trim(); //标题
objSetFieldVisibilityEN.CtrlType = objRow[conSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.UpdDate = objRow[conSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow[conSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[conSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.Memo = objRow[conSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[conSetFieldVisibility.Memo].ToString().Trim(); //说明
objSetFieldVisibilityEN.FuncModuleId = objRow[conSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[conSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSetFieldVisibility(ref clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
bool bolResult = SetFieldVisibilityDA.GetSetFieldVisibility(ref objSetFieldVisibilityEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSetFieldVisibilityEN GetObjBymId(long lngmId)
{
clsSetFieldVisibilityEN objSetFieldVisibilityEN = SetFieldVisibilityDA.GetObjBymId(lngmId);
return objSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSetFieldVisibilityEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = SetFieldVisibilityDA.GetFirstObj(strWhereCond);
 return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = SetFieldVisibilityDA.GetObjByDataRow(objRow);
 return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = SetFieldVisibilityDA.GetObjByDataRow(objRow);
 return objSetFieldVisibilityEN;
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
 /// <param name = "lstSetFieldVisibilityObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSetFieldVisibilityEN GetObjBymIdFromList(long lngmId, List<clsSetFieldVisibilityEN> lstSetFieldVisibilityObjLst)
{
foreach (clsSetFieldVisibilityEN objSetFieldVisibilityEN in lstSetFieldVisibilityObjLst)
{
if (objSetFieldVisibilityEN.mId == lngmId)
{
return objSetFieldVisibilityEN;
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
 lngmId = new clsSetFieldVisibilityDA().GetFirstID(strWhereCond);
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
 arrList = SetFieldVisibilityDA.GetID(strWhereCond);
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
bool bolIsExist = SetFieldVisibilityDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = SetFieldVisibilityDA.IsExist(lngmId);
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
clsSetFieldVisibilityEN objSetFieldVisibilityEN = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
objSetFieldVisibilityEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSetFieldVisibilityEN.UpdUserId = strOpUser;
return clsSetFieldVisibilityBL.UpdateBySql2(objSetFieldVisibilityEN);
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
 bolIsExist = clsSetFieldVisibilityDA.IsExistTable();
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
 bolIsExist = SetFieldVisibilityDA.IsExistTable(strTabName);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSetFieldVisibilityEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],用户Id = [{1}],界面名称 = [{2}],字段名 = [{3}]的数据已经存在!(in clsSetFieldVisibilityBL.AddNewRecordBySql2)", objSetFieldVisibilityEN.IdSchool,objSetFieldVisibilityEN.UserId,objSetFieldVisibilityEN.ViewName,objSetFieldVisibilityEN.FieldName);
throw new Exception(strMsg);
}
try
{
bool bolResult = SetFieldVisibilityDA.AddNewRecordBySQL2(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSetFieldVisibilityEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学校流水号 = [{0}],用户Id = [{1}],界面名称 = [{2}],字段名 = [{3}]的数据已经存在!(in clsSetFieldVisibilityBL.AddNewRecordBySql2WithReturnKey)", objSetFieldVisibilityEN.IdSchool,objSetFieldVisibilityEN.UserId,objSetFieldVisibilityEN.ViewName,objSetFieldVisibilityEN.FieldName);
throw new Exception(strMsg);
}
try
{
string strKey = SetFieldVisibilityDA.AddNewRecordBySQL2WithReturnKey(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
bool bolResult = SetFieldVisibilityDA.Update(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 if (objSetFieldVisibilityEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SetFieldVisibilityDA.UpdateBySql2(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSetFieldVisibilityBL.ReFreshCache();

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
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
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = clsSetFieldVisibilityBL.GetObjBymId(lngmId);

if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(objSetFieldVisibilityEN.mId, objSetFieldVisibilityEN.UpdUserId);
}
if (objSetFieldVisibilityEN != null)
{
int intRecNum = SetFieldVisibilityDA.DelRecord(lngmId);
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
objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
//删除与表:[SetFieldVisibility]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSetFieldVisibility.mId,
//lngmId);
//        clsSetFieldVisibilityBL.DelSetFieldVisibilitysByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSetFieldVisibilityBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSetFieldVisibilityBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsSetFieldVisibilityBL.relatedActions != null)
{
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = SetFieldVisibilityDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelSetFieldVisibilitys(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsSetFieldVisibilityBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = SetFieldVisibilityDA.DelSetFieldVisibility(arrmIdLst);
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
public static int DelSetFieldVisibilitysByCond(string strWhereCond)
{
try
{
if (clsSetFieldVisibilityBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsSetFieldVisibilityBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = SetFieldVisibilityDA.DelSetFieldVisibility(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SetFieldVisibility]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSetFieldVisibilityDA.GetSpecSQLObj();
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
//删除与表:[SetFieldVisibility]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSetFieldVisibilityBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSetFieldVisibilityBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <param name = "objSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(clsSetFieldVisibilityEN objSetFieldVisibilityENS, clsSetFieldVisibilityEN objSetFieldVisibilityENT)
{
try
{
objSetFieldVisibilityENT.mId = objSetFieldVisibilityENS.mId; //mId
objSetFieldVisibilityENT.IdSchool = objSetFieldVisibilityENS.IdSchool; //学校流水号
objSetFieldVisibilityENT.UserId = objSetFieldVisibilityENS.UserId; //用户Id
objSetFieldVisibilityENT.ViewName = objSetFieldVisibilityENS.ViewName; //界面名称
objSetFieldVisibilityENT.FieldName = objSetFieldVisibilityENS.FieldName; //字段名
objSetFieldVisibilityENT.Caption = objSetFieldVisibilityENS.Caption; //标题
objSetFieldVisibilityENT.CtrlType = objSetFieldVisibilityENS.CtrlType; //控件类型
objSetFieldVisibilityENT.IsVisible = objSetFieldVisibilityENS.IsVisible; //是否显示
objSetFieldVisibilityENT.UpdDate = objSetFieldVisibilityENS.UpdDate; //修改日期
objSetFieldVisibilityENT.UpdUserId = objSetFieldVisibilityENS.UpdUserId; //修改用户Id
objSetFieldVisibilityENT.Memo = objSetFieldVisibilityENS.Memo; //说明
objSetFieldVisibilityENT.FuncModuleId = objSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
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
 /// <param name = "objSetFieldVisibilityEN">源简化对象</param>
 public static void SetUpdFlag(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
objSetFieldVisibilityEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSetFieldVisibilityEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSetFieldVisibility.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.mId = objSetFieldVisibilityEN.mId; //mId
}
if (arrFldSet.Contains(conSetFieldVisibility.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.IdSchool = objSetFieldVisibilityEN.IdSchool == "[null]" ? null :  objSetFieldVisibilityEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conSetFieldVisibility.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.UserId = objSetFieldVisibilityEN.UserId == "[null]" ? null :  objSetFieldVisibilityEN.UserId; //用户Id
}
if (arrFldSet.Contains(conSetFieldVisibility.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.ViewName = objSetFieldVisibilityEN.ViewName == "[null]" ? null :  objSetFieldVisibilityEN.ViewName; //界面名称
}
if (arrFldSet.Contains(conSetFieldVisibility.FieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.FieldName = objSetFieldVisibilityEN.FieldName; //字段名
}
if (arrFldSet.Contains(conSetFieldVisibility.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.Caption = objSetFieldVisibilityEN.Caption; //标题
}
if (arrFldSet.Contains(conSetFieldVisibility.CtrlType, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.CtrlType = objSetFieldVisibilityEN.CtrlType; //控件类型
}
if (arrFldSet.Contains(conSetFieldVisibility.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.IsVisible = objSetFieldVisibilityEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conSetFieldVisibility.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.UpdDate = objSetFieldVisibilityEN.UpdDate == "[null]" ? null :  objSetFieldVisibilityEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSetFieldVisibility.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.UpdUserId = objSetFieldVisibilityEN.UpdUserId == "[null]" ? null :  objSetFieldVisibilityEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSetFieldVisibility.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.Memo = objSetFieldVisibilityEN.Memo == "[null]" ? null :  objSetFieldVisibilityEN.Memo; //说明
}
if (arrFldSet.Contains(conSetFieldVisibility.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objSetFieldVisibilityEN.FuncModuleId = objSetFieldVisibilityEN.FuncModuleId == "[null]" ? null :  objSetFieldVisibilityEN.FuncModuleId; //FuncModuleId
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
 /// <param name = "objSetFieldVisibilityEN">源简化对象</param>
 public static void AccessFldValueNull(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
if (objSetFieldVisibilityEN.IdSchool == "[null]") objSetFieldVisibilityEN.IdSchool = null; //学校流水号
if (objSetFieldVisibilityEN.UserId == "[null]") objSetFieldVisibilityEN.UserId = null; //用户Id
if (objSetFieldVisibilityEN.ViewName == "[null]") objSetFieldVisibilityEN.ViewName = null; //界面名称
if (objSetFieldVisibilityEN.UpdDate == "[null]") objSetFieldVisibilityEN.UpdDate = null; //修改日期
if (objSetFieldVisibilityEN.UpdUserId == "[null]") objSetFieldVisibilityEN.UpdUserId = null; //修改用户Id
if (objSetFieldVisibilityEN.Memo == "[null]") objSetFieldVisibilityEN.Memo = null; //说明
if (objSetFieldVisibilityEN.FuncModuleId == "[null]") objSetFieldVisibilityEN.FuncModuleId = null; //FuncModuleId
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
public static void CheckPropertyNew(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 SetFieldVisibilityDA.CheckPropertyNew(objSetFieldVisibilityEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 SetFieldVisibilityDA.CheckProperty4Condition(objSetFieldVisibilityEN);
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
if (clsSetFieldVisibilityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSetFieldVisibilityBL没有刷新缓存机制(clsSetFieldVisibilityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSetFieldVisibilityObjLstCache == null)
//{
//arrSetFieldVisibilityObjLstCache = SetFieldVisibilityDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSetFieldVisibilityEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLstCache = GetObjLstCache();
IEnumerable <clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Sel =
arrSetFieldVisibilityObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrSetFieldVisibilityObjLst_Sel.Count() == 0)
{
   clsSetFieldVisibilityEN obj = clsSetFieldVisibilityBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSetFieldVisibilityObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetAllSetFieldVisibilityObjLstCache()
{
//获取缓存中的对象列表
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLstCache = GetObjLstCache(); 
return arrSetFieldVisibilityObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSetFieldVisibilityObjLstCache;
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
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSetFieldVisibilityEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSetFieldVisibilityEN._RefreshTimeLst.Count == 0) return "";
return clsSetFieldVisibilityEN._RefreshTimeLst[clsSetFieldVisibilityEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSetFieldVisibilityBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSetFieldVisibilityEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSetFieldVisibilityBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SetFieldVisibility(设置字段可视性)
 /// 唯一性条件:id_School_UserId_ViewName_FieldName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检测记录是否存在
string strResult = SetFieldVisibilityDA.GetUniCondStr(objSetFieldVisibilityEN);
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
if (strInFldName != conSetFieldVisibility.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSetFieldVisibility._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSetFieldVisibility._AttributeName));
throw new Exception(strMsg);
}
var objSetFieldVisibility = clsSetFieldVisibilityBL.GetObjBymIdCache(lngmId);
if (objSetFieldVisibility == null) return "";
return objSetFieldVisibility[strOutFldName].ToString();
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
int intRecCount = clsSetFieldVisibilityDA.GetRecCount(strTabName);
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
int intRecCount = clsSetFieldVisibilityDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSetFieldVisibilityDA.GetRecCount();
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
int intRecCount = clsSetFieldVisibilityDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSetFieldVisibilityCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSetFieldVisibilityEN objSetFieldVisibilityCond)
{
List<clsSetFieldVisibilityEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSetFieldVisibilityEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSetFieldVisibility._AttributeName)
{
if (objSetFieldVisibilityCond.IsUpdated(strFldName) == false) continue;
if (objSetFieldVisibilityCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSetFieldVisibilityCond[strFldName].ToString());
}
else
{
if (objSetFieldVisibilityCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSetFieldVisibilityCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSetFieldVisibilityCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSetFieldVisibilityCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSetFieldVisibilityCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSetFieldVisibilityCond[strFldName]));
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
 List<string> arrList = clsSetFieldVisibilityDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SetFieldVisibilityDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SetFieldVisibilityDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SetFieldVisibilityDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSetFieldVisibilityDA.SetFldValue(clsSetFieldVisibilityEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SetFieldVisibilityDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSetFieldVisibilityDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSetFieldVisibilityDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSetFieldVisibilityDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SetFieldVisibility] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FieldName varchar(50) not Null, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" Caption varchar(200) not Null, "); 
 // /**控件类型*/ 
 strCreateTabCode.Append(" CtrlType varchar(50) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**FuncModuleId*/ 
 strCreateTabCode.Append(" FuncModuleId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SetFieldVisibility : clsCommFun4BL
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
clsSetFieldVisibilityBL.ReFreshThisCache();
}
}

}