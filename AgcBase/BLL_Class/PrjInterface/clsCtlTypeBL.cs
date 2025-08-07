
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeBL
 表名:CtlType(00050058)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:13
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
public static class  clsCtlTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCtlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCtlTypeEN GetObj(this K_CtlTypeId_CtlType myKey)
{
clsCtlTypeEN objCtlTypeEN = clsCtlTypeBL.CtlTypeDA.GetObjByCtlTypeId(myKey.Value);
return objCtlTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCtlTypeEN objCtlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCtlTypeBL.IsExist(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCtlTypeEN.CtlTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCtlTypeBL.CtlTypeDA.AddNewRecordBySQL2(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsCtlTypeEN objCtlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCtlTypeBL.IsExist(objCtlTypeEN.CtlTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCtlTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCtlTypeEN.AddNewRecord();
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCtlTypeEN objCtlTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCtlTypeBL.IsExist(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCtlTypeEN.CtlTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCtlTypeBL.CtlTypeDA.AddNewRecordBySQL2WithReturnKey(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeId(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conCtlType.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conCtlType.CtlTypeId);
}
objCtlTypeEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeId) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeId, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeId] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeName(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, conCtlType.CtlTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, conCtlType.CtlTypeName);
}
objCtlTypeEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeENName(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeENName, 50, conCtlType.CtlTypeENName);
}
objCtlTypeEN.CtlTypeENName = strCtlTypeENName; //控件类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeENName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeENName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeENName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlCnName(this clsCtlTypeEN objCtlTypeEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, conCtlType.CtlCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlCnName, 50, conCtlType.CtlCnName);
}
objCtlTypeEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlCnName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlCnName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlCnName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeAbbr(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, conCtlType.CtlTypeAbbr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, conCtlType.CtlTypeAbbr);
}
objCtlTypeEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeAbbr) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeAbbr, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeAbbr] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetHtmlCtrlTypeName(this clsCtlTypeEN objCtlTypeEN, string strHtmlCtrlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHtmlCtrlTypeName, 50, conCtlType.HtmlCtrlTypeName);
}
objCtlTypeEN.HtmlCtrlTypeName = strHtmlCtrlTypeName; //HtmlCtrlTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.HtmlCtrlTypeName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.HtmlCtrlTypeName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.HtmlCtrlTypeName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetIsForApple(this clsCtlTypeEN objCtlTypeEN, bool bolIsForApple, string strComparisonOp="")
	{
objCtlTypeEN.IsForApple = bolIsForApple; //IsForApple
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.IsForApple) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.IsForApple, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.IsForApple] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetInUse(this clsCtlTypeEN objCtlTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCtlTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.InUse) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.InUse, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.InUse] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetIsVisible(this clsCtlTypeEN objCtlTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objCtlTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.IsVisible) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.IsVisible, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.IsVisible] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetOrderNum(this clsCtlTypeEN objCtlTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objCtlTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.OrderNum) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.OrderNum, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.OrderNum] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetUpdDate(this clsCtlTypeEN objCtlTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCtlType.UpdDate);
}
objCtlTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.UpdDate) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.UpdDate, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.UpdDate] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetUpdUser(this clsCtlTypeEN objCtlTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCtlType.UpdUser);
}
objCtlTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.UpdUser) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.UpdUser, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.UpdUser] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetMemo(this clsCtlTypeEN objCtlTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCtlType.Memo);
}
objCtlTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.Memo) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.Memo, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.Memo] = strComparisonOp;
}
}
return objCtlTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCtlTypeEN objCtlTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCtlTypeEN.CheckPropertyNew();
clsCtlTypeEN objCtlTypeCond = new clsCtlTypeEN();
string strCondition = objCtlTypeCond
.SetCtlTypeId(objCtlTypeEN.CtlTypeId, "=")
.GetCombineCondition();
objCtlTypeEN._IsCheckProperty = true;
bool bolIsExist = clsCtlTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCtlTypeEN.Update();
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCtlTypeEN objCtlTypeEN)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCtlTypeBL.CtlTypeDA.UpdateBySql2(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCtlTypeEN objCtlTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCtlTypeBL.CtlTypeDA.UpdateBySql2(objCtlTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCtlTypeEN objCtlTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsCtlTypeBL.CtlTypeDA.UpdateBySqlWithCondition(objCtlTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCtlTypeEN objCtlTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCtlTypeBL.CtlTypeDA.UpdateBySqlWithConditionTransaction(objCtlTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCtlTypeEN objCtlTypeEN)
{
try
{
int intRecNum = clsCtlTypeBL.CtlTypeDA.DelRecord(objCtlTypeEN.CtlTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeENS">源对象</param>
 /// <param name = "objCtlTypeENT">目标对象</param>
 public static void CopyTo(this clsCtlTypeEN objCtlTypeENS, clsCtlTypeEN objCtlTypeENT)
{
try
{
objCtlTypeENT.CtlTypeId = objCtlTypeENS.CtlTypeId; //控件类型号
objCtlTypeENT.CtlTypeName = objCtlTypeENS.CtlTypeName; //控件类型名
objCtlTypeENT.CtlTypeENName = objCtlTypeENS.CtlTypeENName; //控件类型英文名
objCtlTypeENT.CtlCnName = objCtlTypeENS.CtlCnName; //控件类型中文名
objCtlTypeENT.CtlTypeAbbr = objCtlTypeENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeENT.HtmlCtrlTypeName = objCtlTypeENS.HtmlCtrlTypeName; //HtmlCtrlTypeName
objCtlTypeENT.IsForApple = objCtlTypeENS.IsForApple; //IsForApple
objCtlTypeENT.InUse = objCtlTypeENS.InUse; //是否在用
objCtlTypeENT.IsVisible = objCtlTypeENS.IsVisible; //是否显示
objCtlTypeENT.OrderNum = objCtlTypeENS.OrderNum; //序号
objCtlTypeENT.UpdDate = objCtlTypeENS.UpdDate; //修改日期
objCtlTypeENT.UpdUser = objCtlTypeENS.UpdUser; //修改者
objCtlTypeENT.Memo = objCtlTypeENS.Memo; //说明
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
 /// <param name = "objCtlTypeENS">源对象</param>
 /// <returns>目标对象=>clsCtlTypeEN:objCtlTypeENT</returns>
 public static clsCtlTypeEN CopyTo(this clsCtlTypeEN objCtlTypeENS)
{
try
{
 clsCtlTypeEN objCtlTypeENT = new clsCtlTypeEN()
{
CtlTypeId = objCtlTypeENS.CtlTypeId, //控件类型号
CtlTypeName = objCtlTypeENS.CtlTypeName, //控件类型名
CtlTypeENName = objCtlTypeENS.CtlTypeENName, //控件类型英文名
CtlCnName = objCtlTypeENS.CtlCnName, //控件类型中文名
CtlTypeAbbr = objCtlTypeENS.CtlTypeAbbr, //控件类型缩写
HtmlCtrlTypeName = objCtlTypeENS.HtmlCtrlTypeName, //HtmlCtrlTypeName
IsForApple = objCtlTypeENS.IsForApple, //IsForApple
InUse = objCtlTypeENS.InUse, //是否在用
IsVisible = objCtlTypeENS.IsVisible, //是否显示
OrderNum = objCtlTypeENS.OrderNum, //序号
UpdDate = objCtlTypeENS.UpdDate, //修改日期
UpdUser = objCtlTypeENS.UpdUser, //修改者
Memo = objCtlTypeENS.Memo, //说明
};
 return objCtlTypeENT;
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
public static void CheckPropertyNew(this clsCtlTypeEN objCtlTypeEN)
{
 clsCtlTypeBL.CtlTypeDA.CheckPropertyNew(objCtlTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCtlTypeEN objCtlTypeEN)
{
 clsCtlTypeBL.CtlTypeDA.CheckProperty4Condition(objCtlTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCtlTypeEN objCtlTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeId, objCtlTypeCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeName, objCtlTypeCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeENName) == true)
{
string strComparisonOpCtlTypeENName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeENName, objCtlTypeCond.CtlTypeENName, strComparisonOpCtlTypeENName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlCnName, objCtlTypeCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeAbbr, objCtlTypeCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objCtlTypeCond.IsUpdated(conCtlType.HtmlCtrlTypeName) == true)
{
string strComparisonOpHtmlCtrlTypeName = objCtlTypeCond.dicFldComparisonOp[conCtlType.HtmlCtrlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.HtmlCtrlTypeName, objCtlTypeCond.HtmlCtrlTypeName, strComparisonOpHtmlCtrlTypeName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.IsForApple) == true)
{
if (objCtlTypeCond.IsForApple == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.IsForApple);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.IsForApple);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.InUse) == true)
{
if (objCtlTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.InUse);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.IsVisible) == true)
{
if (objCtlTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.IsVisible);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCtlTypeCond.dicFldComparisonOp[conCtlType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCtlType.OrderNum, objCtlTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCtlTypeCond.IsUpdated(conCtlType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCtlTypeCond.dicFldComparisonOp[conCtlType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.UpdDate, objCtlTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCtlTypeCond.IsUpdated(conCtlType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCtlTypeCond.dicFldComparisonOp[conCtlType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.UpdUser, objCtlTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCtlTypeCond.IsUpdated(conCtlType.Memo) == true)
{
string strComparisonOpMemo = objCtlTypeCond.dicFldComparisonOp[conCtlType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.Memo, objCtlTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CtlType
{
public virtual bool UpdRelaTabDate(string strCtlTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCtlType
{
 /// <summary>
 /// None
 /// </summary>
public const string None_00 = "00";
 /// <summary>
 /// Button
 /// </summary>
public const string Button_01 = "01";
 /// <summary>
 /// CheckBox
 /// </summary>
public const string CheckBox_02 = "02";
 /// <summary>
 /// CheckBoxList
 /// </summary>
public const string CheckBoxList_03 = "03";
 /// <summary>
 /// DataGrid
 /// </summary>
public const string DataGrid_04 = "04";
 /// <summary>
 /// DataList
 /// </summary>
public const string DataList_05 = "05";
 /// <summary>
 /// DropDownList
 /// </summary>
public const string DropDownList_06 = "06";
 /// <summary>
 /// HyperLink
 /// </summary>
public const string HyperLink_07 = "07";
 /// <summary>
 /// Image
 /// </summary>
public const string Image_08 = "08";
 /// <summary>
 /// ImageButton
 /// </summary>
public const string ImageButton_09 = "09";
 /// <summary>
 /// Label
 /// </summary>
public const string Label_10 = "10";
 /// <summary>
 /// LinkButton
 /// </summary>
public const string LinkButton_11 = "11";
 /// <summary>
 /// ListBox
 /// </summary>
public const string ListBox_12 = "12";
 /// <summary>
 /// Panel
 /// </summary>
public const string Panel_13 = "13";
 /// <summary>
 /// RadioButton
 /// </summary>
public const string RadioButton_14 = "14";
 /// <summary>
 /// RadioButtonList
 /// </summary>
public const string RadioButtonList_15 = "15";
 /// <summary>
 /// TextBox
 /// </summary>
public const string TextBox_16 = "16";
 /// <summary>
 /// RadioButton_Bool
 /// </summary>
public const string RadioButton_Bool_17 = "17";
 /// <summary>
 /// DropDownList_Bool
 /// </summary>
public const string DropDownList_Bool_18 = "18";
 /// <summary>
 /// GridView
 /// </summary>
public const string GridView_19 = "19";
 /// <summary>
 /// ISOstoryBoard
 /// </summary>
public const string ISOstoryBoard_20 = "20";
 /// <summary>
 /// ISOscene
 /// </summary>
public const string ISOscene_21 = "21";
 /// <summary>
 /// ISOviewController
 /// </summary>
public const string ISOviewController_22 = "22";
 /// <summary>
 /// ISOviewControllerLayoutGuide
 /// </summary>
public const string ISOviewControllerLayoutGuide_23 = "23";
 /// <summary>
 /// ISOview
 /// </summary>
public const string ISOview_24 = "24";
 /// <summary>
 /// ISOStackView
 /// </summary>
public const string ISOStackView_25 = "25";
 /// <summary>
 /// ISOButton
 /// </summary>
public const string ISOButton_26 = "26";
 /// <summary>
 /// ISOtextField
 /// </summary>
public const string ISOtextField_27 = "27";
 /// <summary>
 /// ISOlabel
 /// </summary>
public const string ISOlabel_28 = "28";
 /// <summary>
 /// ISOnavigationBar
 /// </summary>
public const string ISOnavigationBar_29 = "29";
 /// <summary>
 /// ISONavigationItem
 /// </summary>
public const string ISONavigationItem_30 = "30";
 /// <summary>
 /// ISOBarButtonItem
 /// </summary>
public const string ISOBarButtonItem_31 = "31";
 /// <summary>
 /// ISOOutlet
 /// </summary>
public const string ISOOutlet_32 = "32";
 /// <summary>
 /// ISOAction
 /// </summary>
public const string ISOAction_33 = "33";
 /// <summary>
 /// ISOAutoresizingMask
 /// </summary>
public const string ISOAutoresizingMask_34 = "34";
 /// <summary>
 /// GivenValue
 /// </summary>
public const string GivenValue_35 = "35";
 /// <summary>
 /// DefaultValue
 /// </summary>
public const string DefaultValue_36 = "36";
 /// <summary>
 /// ViewVariable
 /// </summary>
public const string ViewVariable_38 = "38";
 /// <summary>
 /// DisplayName
 /// </summary>
public const string DisplayName_39 = "39";
 /// <summary>
 /// TextArea
 /// </summary>
public const string TextArea_41 = "41";
 /// <summary>
 /// Table
 /// </summary>
public const string Table_42 = "42";
 /// <summary>
 /// span
 /// </summary>
public const string span_43 = "43";
 /// <summary>
 /// TableHeader
 /// </summary>
public const string TableHeader_44 = "44";
 /// <summary>
 /// TablePager
 /// </summary>
public const string TablePager_45 = "45";
 /// <summary>
 /// Icon
 /// </summary>
public const string Icon_46 = "46";
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCtlTypeBL
{
public static RelatedActions_CtlType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCtlTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCtlTypeDA CtlTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCtlTypeDA();
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
 public clsCtlTypeBL()
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
if (string.IsNullOrEmpty(clsCtlTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCtlTypeEN._ConnectString);
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
public static DataTable GetDataTable_CtlType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CtlTypeDA.GetDataTable_CtlType(strWhereCond);
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
objDT = CtlTypeDA.GetDataTable(strWhereCond);
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
objDT = CtlTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CtlTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CtlTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CtlTypeDA.GetDataTable_Top(objTopPara);
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
objDT = CtlTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CtlTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CtlTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCtlTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstByCtlTypeIdLst(List<string> arrCtlTypeIdLst)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCtlTypeIdLst, true);
 string strWhereCond = string.Format("CtlTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCtlTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCtlTypeEN> GetObjLstByCtlTypeIdLstCache(List<string> arrCtlTypeIdLst)
{
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel =
arrCtlTypeObjLstCache
.Where(x => arrCtlTypeIdLst.Contains(x.CtlTypeId));
return arrCtlTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetObjLst(string strWhereCond)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
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
public static List<clsCtlTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCtlTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCtlTypeEN> GetSubObjLstCache(clsCtlTypeEN objCtlTypeCond)
{
List<clsCtlTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCtlType._AttributeName)
{
if (objCtlTypeCond.IsUpdated(strFldName) == false) continue;
if (objCtlTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCtlTypeCond[strFldName].ToString());
}
else
{
if (objCtlTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCtlTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCtlTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCtlTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCtlTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCtlTypeCond[strFldName]));
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
public static List<clsCtlTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
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
public static List<clsCtlTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
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
List<clsCtlTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCtlTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCtlTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
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
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
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
public static List<clsCtlTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCtlTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
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
public static List<clsCtlTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCtlTypeEN> arrObjLst = new List<clsCtlTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN();
try
{
objCtlTypeEN.CtlTypeId = objRow[conCtlType.CtlTypeId].ToString().Trim(); //控件类型号
objCtlTypeEN.CtlTypeName = objRow[conCtlType.CtlTypeName].ToString().Trim(); //控件类型名
objCtlTypeEN.CtlTypeENName = objRow[conCtlType.CtlTypeENName] == DBNull.Value ? null : objRow[conCtlType.CtlTypeENName].ToString().Trim(); //控件类型英文名
objCtlTypeEN.CtlCnName = objRow[conCtlType.CtlCnName].ToString().Trim(); //控件类型中文名
objCtlTypeEN.CtlTypeAbbr = objRow[conCtlType.CtlTypeAbbr].ToString().Trim(); //控件类型缩写
objCtlTypeEN.HtmlCtrlTypeName = objRow[conCtlType.HtmlCtrlTypeName] == DBNull.Value ? null : objRow[conCtlType.HtmlCtrlTypeName].ToString().Trim(); //HtmlCtrlTypeName
objCtlTypeEN.IsForApple = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsForApple].ToString().Trim()); //IsForApple
objCtlTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.InUse].ToString().Trim()); //是否在用
objCtlTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCtlType.IsVisible].ToString().Trim()); //是否显示
objCtlTypeEN.OrderNum = objRow[conCtlType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCtlType.OrderNum].ToString().Trim()); //序号
objCtlTypeEN.UpdDate = objRow[conCtlType.UpdDate] == DBNull.Value ? null : objRow[conCtlType.UpdDate].ToString().Trim(); //修改日期
objCtlTypeEN.UpdUser = objRow[conCtlType.UpdUser] == DBNull.Value ? null : objRow[conCtlType.UpdUser].ToString().Trim(); //修改者
objCtlTypeEN.Memo = objRow[conCtlType.Memo] == DBNull.Value ? null : objRow[conCtlType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCtlTypeEN.CtlTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCtlTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCtlTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCtlType(ref clsCtlTypeEN objCtlTypeEN)
{
bool bolResult = CtlTypeDA.GetCtlType(ref objCtlTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCtlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCtlTypeEN GetObjByCtlTypeId(string strCtlTypeId)
{
if (strCtlTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCtlTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCtlTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCtlTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCtlTypeEN objCtlTypeEN = CtlTypeDA.GetObjByCtlTypeId(strCtlTypeId);
return objCtlTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCtlTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCtlTypeEN objCtlTypeEN = CtlTypeDA.GetFirstObj(strWhereCond);
 return objCtlTypeEN;
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
public static clsCtlTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCtlTypeEN objCtlTypeEN = CtlTypeDA.GetObjByDataRow(objRow);
 return objCtlTypeEN;
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
public static clsCtlTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCtlTypeEN objCtlTypeEN = CtlTypeDA.GetObjByDataRow(objRow);
 return objCtlTypeEN;
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
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <param name = "lstCtlTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCtlTypeEN GetObjByCtlTypeIdFromList(string strCtlTypeId, List<clsCtlTypeEN> lstCtlTypeObjLst)
{
foreach (clsCtlTypeEN objCtlTypeEN in lstCtlTypeObjLst)
{
if (objCtlTypeEN.CtlTypeId == strCtlTypeId)
{
return objCtlTypeEN;
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
 string strCtlTypeId;
 try
 {
 strCtlTypeId = new clsCtlTypeDA().GetFirstID(strWhereCond);
 return strCtlTypeId;
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
 arrList = CtlTypeDA.GetID(strWhereCond);
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
bool bolIsExist = CtlTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCtlTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CtlTypeDA.IsExist(strCtlTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCtlTypeId">控件类型号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCtlTypeId, string strOpUser)
{
clsCtlTypeEN objCtlTypeEN = clsCtlTypeBL.GetObjByCtlTypeId(strCtlTypeId);
objCtlTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCtlTypeEN.UpdUser = strOpUser;
return clsCtlTypeBL.UpdateBySql2(objCtlTypeEN);
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
 bolIsExist = clsCtlTypeDA.IsExistTable();
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
 bolIsExist = CtlTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCtlTypeEN objCtlTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCtlTypeBL.IsExist(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCtlTypeEN.CtlTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CtlTypeDA.AddNewRecordBySQL2(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCtlTypeEN objCtlTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCtlTypeBL.IsExist(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCtlTypeEN.CtlTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CtlTypeDA.AddNewRecordBySQL2WithReturnKey(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCtlTypeEN objCtlTypeEN)
{
try
{
bool bolResult = CtlTypeDA.Update(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCtlTypeEN objCtlTypeEN)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CtlTypeDA.UpdateBySql2(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeBL.ReFreshCache();

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
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
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCtlTypeId)
{
try
{
 clsCtlTypeEN objCtlTypeEN = clsCtlTypeBL.GetObjByCtlTypeId(strCtlTypeId);

if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlTypeEN.CtlTypeId, objCtlTypeEN.UpdUser);
}
if (objCtlTypeEN != null)
{
int intRecNum = CtlTypeDA.DelRecord(strCtlTypeId);
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
/// <param name="strCtlTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCtlTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
//删除与表:[CtlType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCtlType.CtlTypeId,
//strCtlTypeId);
//        clsCtlTypeBL.DelCtlTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCtlTypeBL.DelRecord(strCtlTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCtlTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtlTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCtlTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCtlTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(strCtlTypeId, "UpdRelaTabDate");
}
bool bolResult = CtlTypeDA.DelRecord(strCtlTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCtlTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCtlTypes(List<string> arrCtlTypeIdLst)
{
if (arrCtlTypeIdLst.Count == 0) return 0;
try
{
if (clsCtlTypeBL.relatedActions != null)
{
foreach (var strCtlTypeId in arrCtlTypeIdLst)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(strCtlTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = CtlTypeDA.DelCtlType(arrCtlTypeIdLst);
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
public static int DelCtlTypesByCond(string strWhereCond)
{
try
{
if (clsCtlTypeBL.relatedActions != null)
{
List<string> arrCtlTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCtlTypeId in arrCtlTypeId)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(strCtlTypeId, "UpdRelaTabDate");
}
}
int intRecNum = CtlTypeDA.DelCtlType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CtlType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCtlTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCtlTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCtlTypeDA.GetSpecSQLObj();
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
//删除与表:[CtlType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCtlTypeBL.DelRecord(strCtlTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCtlTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtlTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCtlTypeENS">源对象</param>
 /// <param name = "objCtlTypeENT">目标对象</param>
 public static void CopyTo(clsCtlTypeEN objCtlTypeENS, clsCtlTypeEN objCtlTypeENT)
{
try
{
objCtlTypeENT.CtlTypeId = objCtlTypeENS.CtlTypeId; //控件类型号
objCtlTypeENT.CtlTypeName = objCtlTypeENS.CtlTypeName; //控件类型名
objCtlTypeENT.CtlTypeENName = objCtlTypeENS.CtlTypeENName; //控件类型英文名
objCtlTypeENT.CtlCnName = objCtlTypeENS.CtlCnName; //控件类型中文名
objCtlTypeENT.CtlTypeAbbr = objCtlTypeENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeENT.HtmlCtrlTypeName = objCtlTypeENS.HtmlCtrlTypeName; //HtmlCtrlTypeName
objCtlTypeENT.IsForApple = objCtlTypeENS.IsForApple; //IsForApple
objCtlTypeENT.InUse = objCtlTypeENS.InUse; //是否在用
objCtlTypeENT.IsVisible = objCtlTypeENS.IsVisible; //是否显示
objCtlTypeENT.OrderNum = objCtlTypeENS.OrderNum; //序号
objCtlTypeENT.UpdDate = objCtlTypeENS.UpdDate; //修改日期
objCtlTypeENT.UpdUser = objCtlTypeENS.UpdUser; //修改者
objCtlTypeENT.Memo = objCtlTypeENS.Memo; //说明
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
 /// <param name = "objCtlTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsCtlTypeEN objCtlTypeEN)
{
try
{
objCtlTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCtlTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCtlType.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.CtlTypeId = objCtlTypeEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conCtlType.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.CtlTypeName = objCtlTypeEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(conCtlType.CtlTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.CtlTypeENName = objCtlTypeEN.CtlTypeENName == "[null]" ? null :  objCtlTypeEN.CtlTypeENName; //控件类型英文名
}
if (arrFldSet.Contains(conCtlType.CtlCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.CtlCnName = objCtlTypeEN.CtlCnName; //控件类型中文名
}
if (arrFldSet.Contains(conCtlType.CtlTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.CtlTypeAbbr = objCtlTypeEN.CtlTypeAbbr; //控件类型缩写
}
if (arrFldSet.Contains(conCtlType.HtmlCtrlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.HtmlCtrlTypeName = objCtlTypeEN.HtmlCtrlTypeName == "[null]" ? null :  objCtlTypeEN.HtmlCtrlTypeName; //HtmlCtrlTypeName
}
if (arrFldSet.Contains(conCtlType.IsForApple, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.IsForApple = objCtlTypeEN.IsForApple; //IsForApple
}
if (arrFldSet.Contains(conCtlType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.InUse = objCtlTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCtlType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.IsVisible = objCtlTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conCtlType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.OrderNum = objCtlTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCtlType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.UpdDate = objCtlTypeEN.UpdDate == "[null]" ? null :  objCtlTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCtlType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.UpdUser = objCtlTypeEN.UpdUser == "[null]" ? null :  objCtlTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCtlType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCtlTypeEN.Memo = objCtlTypeEN.Memo == "[null]" ? null :  objCtlTypeEN.Memo; //说明
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
 /// <param name = "objCtlTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsCtlTypeEN objCtlTypeEN)
{
try
{
if (objCtlTypeEN.CtlTypeENName == "[null]") objCtlTypeEN.CtlTypeENName = null; //控件类型英文名
if (objCtlTypeEN.HtmlCtrlTypeName == "[null]") objCtlTypeEN.HtmlCtrlTypeName = null; //HtmlCtrlTypeName
if (objCtlTypeEN.UpdDate == "[null]") objCtlTypeEN.UpdDate = null; //修改日期
if (objCtlTypeEN.UpdUser == "[null]") objCtlTypeEN.UpdUser = null; //修改者
if (objCtlTypeEN.Memo == "[null]") objCtlTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCtlTypeEN objCtlTypeEN)
{
 CtlTypeDA.CheckPropertyNew(objCtlTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCtlTypeEN objCtlTypeEN)
{
 CtlTypeDA.CheckProperty4Condition(objCtlTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CtlTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCtlType.CtlTypeId); 
List<clsCtlTypeEN> arrObjLst = clsCtlTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN()
{
CtlTypeId = "0",
CtlTypeName = "选[控件类型缩写]..."
};
arrObjLst.Insert(0, objCtlTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCtlType.CtlTypeId;
objComboBox.DisplayMember = conCtlType.CtlTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CtlTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[控件类型缩写]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCtlType.CtlTypeId); 
IEnumerable<clsCtlTypeEN> arrObjLst = clsCtlTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum);
objDDL.DataValueField = conCtlType.CtlTypeId;
objDDL.DataTextField = conCtlType.CtlTypeName;
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
public static void BindDdl_CtlTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[控件类型缩写]...","0");
List<clsCtlTypeEN> arrCtlTypeObjLst = GetAllCtlTypeObjLstCache(); 
arrCtlTypeObjLst = arrCtlTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conCtlType.CtlTypeId;
objDDL.DataTextField = conCtlType.CtlTypeName;
objDDL.DataSource = arrCtlTypeObjLst;
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
if (clsCtlTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCtlTypeBL没有刷新缓存机制(clsCtlTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CtlTypeId");
//if (arrCtlTypeObjLstCache == null)
//{
//arrCtlTypeObjLstCache = CtlTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCtlTypeEN GetObjByCtlTypeIdCache(string strCtlTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel =
arrCtlTypeObjLstCache
.Where(x=> x.CtlTypeId == strCtlTypeId 
);
if (arrCtlTypeObjLst_Sel.Count() == 0)
{
   clsCtlTypeEN obj = clsCtlTypeBL.GetObjByCtlTypeId(strCtlTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCtlTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCtlTypeNameByCtlTypeIdCache(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return "";
//获取缓存中的对象列表
clsCtlTypeEN objCtlType = GetObjByCtlTypeIdCache(strCtlTypeId);
if (objCtlType == null) return "";
return objCtlType.CtlTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCtlTypeIdCache(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return "";
//获取缓存中的对象列表
clsCtlTypeEN objCtlType = GetObjByCtlTypeIdCache(strCtlTypeId);
if (objCtlType == null) return "";
return objCtlType.CtlTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCtlTypeEN> GetAllCtlTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache(); 
return arrCtlTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
List<clsCtlTypeEN> arrCtlTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCtlTypeObjLstCache;
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
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCtlTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCtlTypeEN._RefreshTimeLst.Count == 0) return "";
return clsCtlTypeEN._RefreshTimeLst[clsCtlTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCtlTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCtlTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCtlTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strCtlTypeId)
{
if (strInFldName != conCtlType.CtlTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCtlType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCtlType._AttributeName));
throw new Exception(strMsg);
}
var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(strCtlTypeId);
if (objCtlType == null) return "";
return objCtlType[strOutFldName].ToString();
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
int intRecCount = clsCtlTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsCtlTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCtlTypeDA.GetRecCount();
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
int intRecCount = clsCtlTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCtlTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCtlTypeEN objCtlTypeCond)
{
List<clsCtlTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCtlType._AttributeName)
{
if (objCtlTypeCond.IsUpdated(strFldName) == false) continue;
if (objCtlTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCtlTypeCond[strFldName].ToString());
}
else
{
if (objCtlTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCtlTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCtlTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCtlTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCtlTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCtlTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCtlTypeCond[strFldName]));
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
 List<string> arrList = clsCtlTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CtlTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CtlTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CtlTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCtlTypeDA.SetFldValue(clsCtlTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CtlTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCtlTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCtlTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCtlTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CtlType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) primary key, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) not Null, "); 
 // /**控件类型英文名*/ 
 strCreateTabCode.Append(" CtlTypeENName varchar(50) Null, "); 
 // /**控件类型中文名*/ 
 strCreateTabCode.Append(" CtlCnName varchar(50) not Null, "); 
 // /**控件类型缩写*/ 
 strCreateTabCode.Append(" CtlTypeAbbr varchar(5) not Null, "); 
 // /**HtmlCtrlTypeName*/ 
 strCreateTabCode.Append(" HtmlCtrlTypeName varchar(50) Null, "); 
 // /**IsForApple*/ 
 strCreateTabCode.Append(" IsForApple bit Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
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


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conCtlType.OrderNum); 
List<clsCtlTypeEN> arrCtlTypeObjList = new clsCtlTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCtlTypeEN objCtlType in arrCtlTypeObjList)
{
objCtlType.OrderNum = intIndex;
UpdateBySql2(objCtlType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCtlTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strCtlTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CtlTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CtlTypeId
//5、把当前关键字CtlTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CtlTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCtlTypeId = "";    //上一条序号的关键字CtlTypeId
string strNextCtlTypeId = "";    //下一条序号的关键字CtlTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[CtlTypeId],获取相应的序号[OrderNum]。

clsCtlTypeEN objCtlType = clsCtlTypeBL.GetObjByCtlTypeId(strCtlTypeId);

intOrderNum = objCtlType.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsCtlTypeBL.GetRecCountByCond(clsCtlTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conCtlType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字CtlTypeId
strPrevCtlTypeId = clsCtlTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevCtlTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CtlTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字CtlTypeId所对应的记录序号加1
clsCtlTypeBL.SetFldValue(clsCtlTypeEN._CurrTabName, conCtlType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conCtlType.CtlTypeId, strCtlTypeId));
clsCtlTypeBL.SetFldValue(clsCtlTypeEN._CurrTabName, conCtlType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conCtlType.CtlTypeId, strPrevCtlTypeId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字CtlTypeId
strCondition.AppendFormat(" {0} = {1}", conCtlType.OrderNum, intOrderNum + 1);

strNextCtlTypeId = clsCtlTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextCtlTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CtlTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字CtlTypeId所对应的记录序号减1
clsCtlTypeBL.SetFldValue(clsCtlTypeEN._CurrTabName, conCtlType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conCtlType.CtlTypeId, strCtlTypeId));
clsCtlTypeBL.SetFldValue(clsCtlTypeEN._CurrTabName, conCtlType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCtlType.CtlTypeId, strNextCtlTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsCtlTypeBL.ReFreshCache();
if (clsCtlTypeBL.relatedActions != null)
{
clsCtlTypeBL.relatedActions.UpdRelaTabDate(objCtlType.CtlTypeId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCtlType.CtlTypeId, strKeyList);
List<clsCtlTypeEN> arrCtlTypeLst = GetObjLst(strCondition);
foreach (clsCtlTypeEN objCtlType in arrCtlTypeLst)
{
objCtlType.OrderNum = objCtlType.OrderNum + 10000;
UpdateBySql2(objCtlType);
}
strCondition = string.Format("1 = 1 order by {0} ", conCtlType.OrderNum); 
List<clsCtlTypeEN> arrCtlTypeObjList = new clsCtlTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCtlTypeEN objCtlType in arrCtlTypeObjList)
{
objCtlType.OrderNum = intIndex;
UpdateBySql2(objCtlType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCtlType.CtlTypeId, strKeyList);
List<clsCtlTypeEN> arrCtlTypeLst = GetObjLst(strCondition);
foreach (clsCtlTypeEN objCtlType in arrCtlTypeLst)
{
objCtlType.OrderNum = objCtlType.OrderNum - 10000;
UpdateBySql2(objCtlType);
}
strCondition = string.Format("1 = 1 order by {0} ", conCtlType.OrderNum); 
List<clsCtlTypeEN> arrCtlTypeObjList = new clsCtlTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCtlTypeEN objCtlType in arrCtlTypeObjList)
{
objCtlType.OrderNum = intIndex;
UpdateBySql2(objCtlType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CtlType : clsCommFun4BL
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
clsCtlTypeBL.ReFreshThisCache();
}
}

}