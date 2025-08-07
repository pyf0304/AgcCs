
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewTypeCodeTabBL
 表名:ViewTypeCodeTab(00050104)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:04
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
public static class  clsViewTypeCodeTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewTypeCodeTabEN GetObj(this K_ViewTypeCode_ViewTypeCodeTab myKey)
{
clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.GetObjByViewTypeCode(myKey.Value);
return objViewTypeCodeTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewTypeCodeTabEN) == false)
{
var strMsg = string.Format("记录已经存在!界面类型名称 = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsViewTypeCodeTabBL.AddNewRecord)", objViewTypeCodeTabEN.ViewTypeName,objViewTypeCodeTabEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.AddNewRecordBySQL2(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsNeedCheckUniqueness = true)
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
objViewTypeCodeTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewTypeCodeTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面类型名称(ViewTypeName)=[{0}],应用程序类型ID(ApplicationTypeId)=[{1}])已经存在,不能重复!", objViewTypeCodeTabEN.ViewTypeName, objViewTypeCodeTabEN.ApplicationTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewTypeCodeTabEN.AddNewRecord();
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewTypeCodeTabEN) == false)
{
var strMsg = string.Format("记录已经存在!界面类型名称 = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsViewTypeCodeTabBL.AddNewRecordWithReturnKey)", objViewTypeCodeTabEN.ViewTypeName,objViewTypeCodeTabEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.AddNewRecordBySQL2WithReturnKey(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeCode(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int intViewTypeCode, string strComparisonOp="")
	{
objViewTypeCodeTabEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeCode) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeCode, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeCode] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeName(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTypeName, conViewTypeCodeTab.ViewTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeName, 40, conViewTypeCodeTab.ViewTypeName);
}
objViewTypeCodeTabEN.ViewTypeName = strViewTypeName; //界面类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeName) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeName, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeName] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewTypeENName(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTypeENName, 40, conViewTypeCodeTab.ViewTypeENName);
}
objViewTypeCodeTabEN.ViewTypeENName = strViewTypeENName; //ViewTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewTypeENName) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewTypeENName, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeENName] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsWinApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsWinApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsWinApp = bolIsWinApp; //IsWinApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsWinApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsWinApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsWinApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsMobileApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsMobileApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsMobileApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsMobileApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsWebApp(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsWebApp, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsWebApp = bolIsWebApp; //IsWebApp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsWebApp) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsWebApp, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsWebApp] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewFunction(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conViewTypeCodeTab.ViewFunction);
}
objViewTypeCodeTabEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewFunction) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewFunction, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewFunction] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetOptProcess(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strOptProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptProcess, 1000, conViewTypeCodeTab.OptProcess);
}
objViewTypeCodeTabEN.OptProcess = strOptProcess; //操作流程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.OptProcess) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.OptProcess, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.OptProcess] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetViewDetail(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conViewTypeCodeTab.ViewDetail);
}
objViewTypeCodeTabEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ViewDetail) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ViewDetail, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ViewDetail] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetApplicationTypeId(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewTypeCodeTab.ApplicationTypeId);
objViewTypeCodeTabEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.ApplicationTypeId) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.ApplicationTypeId, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.ApplicationTypeId] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveAdd(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveAdd, conViewTypeCodeTab.IsHaveAdd);
objViewTypeCodeTabEN.IsHaveAdd = bolIsHaveAdd; //是否有添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveAdd) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveAdd, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveAdd] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveUpdate(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveUpdate, conViewTypeCodeTab.IsHaveUpdate);
objViewTypeCodeTabEN.IsHaveUpdate = bolIsHaveUpdate; //是否有修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveUpdate) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveUpdate, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveUpdate] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveDel(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveDel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDel, conViewTypeCodeTab.IsHaveDel);
objViewTypeCodeTabEN.IsHaveDel = bolIsHaveDel; //是否有删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveDel) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveDel, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveDel] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveQuery(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveQuery, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveQuery, conViewTypeCodeTab.IsHaveQuery);
objViewTypeCodeTabEN.IsHaveQuery = bolIsHaveQuery; //是否有查询
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveQuery) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveQuery, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveQuery] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExcelExport(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExcelExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExcelExport, conViewTypeCodeTab.IsHaveExcelExport);
objViewTypeCodeTabEN.IsHaveExcelExport = bolIsHaveExcelExport; //是否EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExcelExport) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExcelExport, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExcelExport] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveSetExportExcel(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveSetExportExcel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSetExportExcel, conViewTypeCodeTab.IsHaveSetExportExcel);
objViewTypeCodeTabEN.IsHaveSetExportExcel = bolIsHaveSetExportExcel; //是否有设置EXCEL导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveSetExportExcel) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveSetExportExcel, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveSetExportExcel] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveDetail(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveDetail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveDetail, conViewTypeCodeTab.IsHaveDetail);
objViewTypeCodeTabEN.IsHaveDetail = bolIsHaveDetail; //是否有详细
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveDetail) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveDetail, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveDetail] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExeAdd(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExeAdd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeAdd, conViewTypeCodeTab.IsHaveExeAdd);
objViewTypeCodeTabEN.IsHaveExeAdd = bolIsHaveExeAdd; //是否有调用添加
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExeAdd) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExeAdd, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExeAdd] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveExeUpdate(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveExeUpdate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveExeUpdate, conViewTypeCodeTab.IsHaveExeUpdate);
objViewTypeCodeTabEN.IsHaveExeUpdate = bolIsHaveExeUpdate; //是否有调用修改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveExeUpdate) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveExeUpdate, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveExeUpdate] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveMainView(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveMainView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveMainView, conViewTypeCodeTab.IsHaveMainView);
objViewTypeCodeTabEN.IsHaveMainView = bolIsHaveMainView; //是否有主界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveMainView) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveMainView, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveMainView] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsHaveSubView(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsHaveSubView, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsHaveSubView, conViewTypeCodeTab.IsHaveSubView);
objViewTypeCodeTabEN.IsHaveSubView = bolIsHaveSubView; //是否有子界面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsHaveSubView) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsHaveSubView, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsHaveSubView] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetOrderNum(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, int? intOrderNum, string strComparisonOp="")
	{
objViewTypeCodeTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.OrderNum) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.OrderNum, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.OrderNum] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewTypeCodeTabEN SetIsUsed(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsUsed, string strComparisonOp="")
	{
objViewTypeCodeTabEN.IsUsed = bolIsUsed; //IsUsed
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewTypeCodeTabEN.dicFldComparisonOp.ContainsKey(conViewTypeCodeTab.IsUsed) == false)
{
objViewTypeCodeTabEN.dicFldComparisonOp.Add(conViewTypeCodeTab.IsUsed, strComparisonOp);
}
else
{
objViewTypeCodeTabEN.dicFldComparisonOp[conViewTypeCodeTab.IsUsed] = strComparisonOp;
}
}
return objViewTypeCodeTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewTypeCodeTabEN.CheckPropertyNew();
clsViewTypeCodeTabEN objViewTypeCodeTabCond = new clsViewTypeCodeTabEN();
string strCondition = objViewTypeCodeTabCond
.SetViewTypeCode(objViewTypeCodeTabEN.ViewTypeCode, "<>")
.SetViewTypeName(objViewTypeCodeTabEN.ViewTypeName, "=")
.SetApplicationTypeId(objViewTypeCodeTabEN.ApplicationTypeId, "=")
.GetCombineCondition();
objViewTypeCodeTabEN._IsCheckProperty = true;
bool bolIsExist = clsViewTypeCodeTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewTypeName_ApplicationTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewTypeCodeTabEN.Update();
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
 /// <param name = "objViewTypeCodeTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewTypeCodeTabEN objViewTypeCodeTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewTypeCodeTabEN objViewTypeCodeTabCond = new clsViewTypeCodeTabEN();
string strCondition = objViewTypeCodeTabCond
.SetViewTypeName(objViewTypeCodeTab.ViewTypeName, "=")
.SetApplicationTypeId(objViewTypeCodeTab.ApplicationTypeId, "=")
.GetCombineCondition();
objViewTypeCodeTab._IsCheckProperty = true;
bool bolIsExist = clsViewTypeCodeTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewTypeCodeTab.ViewTypeCode = clsViewTypeCodeTabBL.GetFirstID_S(strCondition);
objViewTypeCodeTab.UpdateWithCondition(strCondition);
}
else
{
objViewTypeCodeTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN.ViewTypeCode == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.UpdateBySql2(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewTypeCodeTabEN.ViewTypeCode == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.UpdateBySql2(objViewTypeCodeTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strWhereCond)
{
try
{
bool bolResult = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.UpdateBySqlWithCondition(objViewTypeCodeTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewTypeCodeTabEN objViewTypeCodeTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.UpdateBySqlWithConditionTransaction(objViewTypeCodeTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
try
{
int intRecNum = clsViewTypeCodeTabBL.ViewTypeCodeTabDA.DelRecord(objViewTypeCodeTabEN.ViewTypeCode);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
 public static void CopyTo(this clsViewTypeCodeTabEN objViewTypeCodeTabENS, clsViewTypeCodeTabEN objViewTypeCodeTabENT)
{
try
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
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
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <returns>目标对象=>clsViewTypeCodeTabEN:objViewTypeCodeTabENT</returns>
 public static clsViewTypeCodeTabEN CopyTo(this clsViewTypeCodeTabEN objViewTypeCodeTabENS)
{
try
{
 clsViewTypeCodeTabEN objViewTypeCodeTabENT = new clsViewTypeCodeTabEN()
{
ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode, //界面类型码
ViewTypeName = objViewTypeCodeTabENS.ViewTypeName, //界面类型名称
ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName, //ViewTypeENName
IsWinApp = objViewTypeCodeTabENS.IsWinApp, //IsWinApp
IsMobileApp = objViewTypeCodeTabENS.IsMobileApp, //是否移动终端应用
IsWebApp = objViewTypeCodeTabENS.IsWebApp, //IsWebApp
ViewFunction = objViewTypeCodeTabENS.ViewFunction, //界面功能
OptProcess = objViewTypeCodeTabENS.OptProcess, //操作流程
ViewDetail = objViewTypeCodeTabENS.ViewDetail, //界面说明
ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId, //应用程序类型ID
IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd, //是否有添加
IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate, //是否有修改
IsHaveDel = objViewTypeCodeTabENS.IsHaveDel, //是否有删除
IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery, //是否有查询
IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport, //是否EXCEL导出
IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel, //是否有设置EXCEL导出
IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail, //是否有详细
IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd, //是否有调用添加
IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate, //是否有调用修改
IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView, //是否有主界面
IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView, //是否有子界面
OrderNum = objViewTypeCodeTabENS.OrderNum, //序号
IsUsed = objViewTypeCodeTabENS.IsUsed, //IsUsed
};
 return objViewTypeCodeTabENT;
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
public static void CheckPropertyNew(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 clsViewTypeCodeTabBL.ViewTypeCodeTabDA.CheckPropertyNew(objViewTypeCodeTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 clsViewTypeCodeTabBL.ViewTypeCodeTabDA.CheckProperty4Condition(objViewTypeCodeTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewTypeCodeTabEN objViewTypeCodeTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.ViewTypeCode, objViewTypeCodeTabCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeName) == true)
{
string strComparisonOpViewTypeName = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewTypeName, objViewTypeCodeTabCond.ViewTypeName, strComparisonOpViewTypeName);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewTypeENName) == true)
{
string strComparisonOpViewTypeENName = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewTypeENName, objViewTypeCodeTabCond.ViewTypeENName, strComparisonOpViewTypeENName);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsWinApp) == true)
{
if (objViewTypeCodeTabCond.IsWinApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWinApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWinApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsMobileApp) == true)
{
if (objViewTypeCodeTabCond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsMobileApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsWebApp) == true)
{
if (objViewTypeCodeTabCond.IsWebApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsWebApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsWebApp);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewFunction) == true)
{
string strComparisonOpViewFunction = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewFunction, objViewTypeCodeTabCond.ViewFunction, strComparisonOpViewFunction);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.OptProcess) == true)
{
string strComparisonOpOptProcess = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.OptProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.OptProcess, objViewTypeCodeTabCond.OptProcess, strComparisonOpOptProcess);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ViewDetail) == true)
{
string strComparisonOpViewDetail = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewTypeCodeTab.ViewDetail, objViewTypeCodeTabCond.ViewDetail, strComparisonOpViewDetail);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.ApplicationTypeId, objViewTypeCodeTabCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveAdd) == true)
{
if (objViewTypeCodeTabCond.IsHaveAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveAdd);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveUpdate) == true)
{
if (objViewTypeCodeTabCond.IsHaveUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveUpdate);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveDel) == true)
{
if (objViewTypeCodeTabCond.IsHaveDel == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveDel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveDel);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveQuery) == true)
{
if (objViewTypeCodeTabCond.IsHaveQuery == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveQuery);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveQuery);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExcelExport) == true)
{
if (objViewTypeCodeTabCond.IsHaveExcelExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExcelExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExcelExport);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveSetExportExcel) == true)
{
if (objViewTypeCodeTabCond.IsHaveSetExportExcel == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveSetExportExcel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveSetExportExcel);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveDetail) == true)
{
if (objViewTypeCodeTabCond.IsHaveDetail == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveDetail);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveDetail);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExeAdd) == true)
{
if (objViewTypeCodeTabCond.IsHaveExeAdd == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExeAdd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExeAdd);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveExeUpdate) == true)
{
if (objViewTypeCodeTabCond.IsHaveExeUpdate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveExeUpdate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveExeUpdate);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveMainView) == true)
{
if (objViewTypeCodeTabCond.IsHaveMainView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveMainView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveMainView);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsHaveSubView) == true)
{
if (objViewTypeCodeTabCond.IsHaveSubView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsHaveSubView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsHaveSubView);
}
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewTypeCodeTabCond.dicFldComparisonOp[conViewTypeCodeTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewTypeCodeTab.OrderNum, objViewTypeCodeTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewTypeCodeTabCond.IsUpdated(conViewTypeCodeTab.IsUsed) == true)
{
if (objViewTypeCodeTabCond.IsUsed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewTypeCodeTab.IsUsed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewTypeCodeTab.IsUsed);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewTypeCodeTab(界面类型码), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewTypeName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewTypeCodeTabEN == null) return true;
if (objViewTypeCodeTabEN.ViewTypeCode == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
if (clsViewTypeCodeTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewTypeCode !=  {0}", objViewTypeCodeTabEN.ViewTypeCode);
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
if (clsViewTypeCodeTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewTypeCodeTab(界面类型码), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewTypeName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewTypeCodeTabEN == null) return "";
if (objViewTypeCodeTabEN.ViewTypeCode == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewTypeCode !=  {0}", objViewTypeCodeTabEN.ViewTypeCode);
 sbCondition.AppendFormat(" and ViewTypeName = '{0}'", objViewTypeCodeTabEN.ViewTypeName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewTypeCodeTabEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewTypeCodeTab
{
public virtual bool UpdRelaTabDate(int intViewTypeCode, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public enum enumViewTypeCodeTab : int
{
[Description("单表插入")]
Table_Insert_1 = 1,
[Description("单表修改")]
Table_Update_2 = 2,
[Description("单表查询")]
Table_Query_3 = 3,
[Description("单表的QUDI")]
Table_QUDI_4 = 4,
[Description("单表的查询插入")]
Table_QI_5 = 5,
[Description("单表的查询修改")]
Table_QU_6 = 6,
[Description("单表的查询删除")]
Table_QD_7 = 7,
[Description("单表插入修改")]
Table_UI_9 = 9,
[Description("单表组合界面_ListView")]
Table_QD_InvokeUI_ListView_11 = 11,
[Description("列表界面")]
Table_List_14 = 14,
[Description("详细信息界面")]
Table_Detail_17 = 17,
[Description("界面查询修改删除")]
Table_QUD_18 = 18,
[Description("单表组合界面_GridView")]
Table_QD_InvokeUI_GridView_20 = 20,
[Description("单表的QUDI4Android")]
Table_QUDI4Android_21 = 21,
[Description("单表的CRUD4Mvc")]
Table_CRUD4Mvc_22 = 22,
[Description("单表的CRUD4ISO")]
Table_CRUD4ISO_23 = 23,
[Description("单表的CRUD4Spa")]
Table_CRUD4Spa_24 = 24,
[Description("单表的CRUD4MvcAjax")]
Table_CRUD4MvcAjax_25 = 25,
[Description("单表的CRUD4Mvc_TS")]
Table_CRUD4Mvc_TS_26 = 26,
[Description("单表的CRUD4Node")]
Table_CRUD4Node_27 = 27,
[Description("单表的CRUD4Relation")]
Table_CRUD4Relation_28 = 28,
[Description("单表的CRUD4JsRj")]
Table_CRUD4JsRj_29 = 29,
[Description("单表的CRUD4Spa_UT")]
Table_CRUD4Spa_UT_30 = 30,
[Description("单表的CRUD4Vue")]
Table_CRUD4Vue_31 = 31,
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewTypeCodeTabBL
{
public static RelatedActions_ViewTypeCodeTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewTypeCodeTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewTypeCodeTabDA ViewTypeCodeTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewTypeCodeTabDA();
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
 public clsViewTypeCodeTabBL()
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
if (string.IsNullOrEmpty(clsViewTypeCodeTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewTypeCodeTabEN._ConnectString);
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
public static DataTable GetDataTable_ViewTypeCodeTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewTypeCodeTabDA.GetDataTable_ViewTypeCodeTab(strWhereCond);
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
objDT = ViewTypeCodeTabDA.GetDataTable(strWhereCond);
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
objDT = ViewTypeCodeTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewTypeCodeTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewTypeCodeTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewTypeCodeTabDA.GetDataTable_Top(objTopPara);
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
objDT = ViewTypeCodeTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewTypeCodeTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewTypeCodeTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewTypeCodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLstByViewTypeCodeLst(List<int> arrViewTypeCodeLst)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewTypeCodeLst);
 string strWhereCond = string.Format("ViewTypeCode in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewTypeCodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewTypeCodeTabEN> GetObjLstByViewTypeCodeLstCache(List<int> arrViewTypeCodeLst)
{
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel =
arrViewTypeCodeTabObjLstCache
.Where(x => arrViewTypeCodeLst.Contains(x.ViewTypeCode));
return arrViewTypeCodeTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLst(string strWhereCond)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
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
public static List<clsViewTypeCodeTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewTypeCodeTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewTypeCodeTabEN> GetSubObjLstCache(clsViewTypeCodeTabEN objViewTypeCodeTabCond)
{
List<clsViewTypeCodeTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewTypeCodeTab._AttributeName)
{
if (objViewTypeCodeTabCond.IsUpdated(strFldName) == false) continue;
if (objViewTypeCodeTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewTypeCodeTabCond[strFldName].ToString());
}
else
{
if (objViewTypeCodeTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewTypeCodeTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewTypeCodeTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewTypeCodeTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewTypeCodeTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewTypeCodeTabCond[strFldName]));
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
public static List<clsViewTypeCodeTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
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
List<clsViewTypeCodeTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewTypeCodeTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewTypeCodeTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
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
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
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
public static List<clsViewTypeCodeTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewTypeCodeTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
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
public static List<clsViewTypeCodeTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewTypeCodeTabEN> arrObjLst = new List<clsViewTypeCodeTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN();
try
{
objViewTypeCodeTabEN.ViewTypeCode = Int32.Parse(objRow[conViewTypeCodeTab.ViewTypeCode].ToString().Trim()); //界面类型码
objViewTypeCodeTabEN.ViewTypeName = objRow[conViewTypeCodeTab.ViewTypeName].ToString().Trim(); //界面类型名称
objViewTypeCodeTabEN.ViewTypeENName = objRow[conViewTypeCodeTab.ViewTypeENName] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewTypeENName].ToString().Trim(); //ViewTypeENName
objViewTypeCodeTabEN.IsWinApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWinApp].ToString().Trim()); //IsWinApp
objViewTypeCodeTabEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsMobileApp].ToString().Trim()); //是否移动终端应用
objViewTypeCodeTabEN.IsWebApp = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsWebApp].ToString().Trim()); //IsWebApp
objViewTypeCodeTabEN.ViewFunction = objRow[conViewTypeCodeTab.ViewFunction] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewFunction].ToString().Trim(); //界面功能
objViewTypeCodeTabEN.OptProcess = objRow[conViewTypeCodeTab.OptProcess] == DBNull.Value ? null : objRow[conViewTypeCodeTab.OptProcess].ToString().Trim(); //操作流程
objViewTypeCodeTabEN.ViewDetail = objRow[conViewTypeCodeTab.ViewDetail] == DBNull.Value ? null : objRow[conViewTypeCodeTab.ViewDetail].ToString().Trim(); //界面说明
objViewTypeCodeTabEN.ApplicationTypeId = Int32.Parse(objRow[conViewTypeCodeTab.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewTypeCodeTabEN.IsHaveAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveAdd].ToString().Trim()); //是否有添加
objViewTypeCodeTabEN.IsHaveUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveUpdate].ToString().Trim()); //是否有修改
objViewTypeCodeTabEN.IsHaveDel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDel].ToString().Trim()); //是否有删除
objViewTypeCodeTabEN.IsHaveQuery = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveQuery].ToString().Trim()); //是否有查询
objViewTypeCodeTabEN.IsHaveExcelExport = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExcelExport].ToString().Trim()); //是否EXCEL导出
objViewTypeCodeTabEN.IsHaveSetExportExcel = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSetExportExcel].ToString().Trim()); //是否有设置EXCEL导出
objViewTypeCodeTabEN.IsHaveDetail = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveDetail].ToString().Trim()); //是否有详细
objViewTypeCodeTabEN.IsHaveExeAdd = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeAdd].ToString().Trim()); //是否有调用添加
objViewTypeCodeTabEN.IsHaveExeUpdate = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveExeUpdate].ToString().Trim()); //是否有调用修改
objViewTypeCodeTabEN.IsHaveMainView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveMainView].ToString().Trim()); //是否有主界面
objViewTypeCodeTabEN.IsHaveSubView = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsHaveSubView].ToString().Trim()); //是否有子界面
objViewTypeCodeTabEN.OrderNum = objRow[conViewTypeCodeTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewTypeCodeTab.OrderNum].ToString().Trim()); //序号
objViewTypeCodeTabEN.IsUsed = clsEntityBase2.TransNullToBool_S(objRow[conViewTypeCodeTab.IsUsed].ToString().Trim()); //IsUsed
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewTypeCodeTabEN.ViewTypeCode, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewTypeCodeTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewTypeCodeTab(ref clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
bool bolResult = ViewTypeCodeTabDA.GetViewTypeCodeTab(ref objViewTypeCodeTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intViewTypeCode">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewTypeCodeTabEN GetObjByViewTypeCode(int intViewTypeCode)
{
clsViewTypeCodeTabEN objViewTypeCodeTabEN = ViewTypeCodeTabDA.GetObjByViewTypeCode(intViewTypeCode);
return objViewTypeCodeTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewTypeCodeTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewTypeCodeTabEN objViewTypeCodeTabEN = ViewTypeCodeTabDA.GetFirstObj(strWhereCond);
 return objViewTypeCodeTabEN;
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
public static clsViewTypeCodeTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewTypeCodeTabEN objViewTypeCodeTabEN = ViewTypeCodeTabDA.GetObjByDataRow(objRow);
 return objViewTypeCodeTabEN;
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
public static clsViewTypeCodeTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewTypeCodeTabEN objViewTypeCodeTabEN = ViewTypeCodeTabDA.GetObjByDataRow(objRow);
 return objViewTypeCodeTabEN;
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
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <param name = "lstViewTypeCodeTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewTypeCodeTabEN GetObjByViewTypeCodeFromList(int intViewTypeCode, List<clsViewTypeCodeTabEN> lstViewTypeCodeTabObjLst)
{
foreach (clsViewTypeCodeTabEN objViewTypeCodeTabEN in lstViewTypeCodeTabObjLst)
{
if (objViewTypeCodeTabEN.ViewTypeCode == intViewTypeCode)
{
return objViewTypeCodeTabEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intViewTypeCode;
 try
 {
 intViewTypeCode = new clsViewTypeCodeTabDA().GetFirstID(strWhereCond);
 return intViewTypeCode;
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
 arrList = ViewTypeCodeTabDA.GetID(strWhereCond);
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
bool bolIsExist = ViewTypeCodeTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intViewTypeCode)
{
//检测记录是否存在
bool bolIsExist = ViewTypeCodeTabDA.IsExist(intViewTypeCode);
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
 bolIsExist = clsViewTypeCodeTabDA.IsExistTable();
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
 bolIsExist = ViewTypeCodeTabDA.IsExistTable(strTabName);
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewTypeCodeTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面类型名称 = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsViewTypeCodeTabBL.AddNewRecordBySql2)", objViewTypeCodeTabEN.ViewTypeName,objViewTypeCodeTabEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewTypeCodeTabDA.AddNewRecordBySQL2(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewTypeCodeTabEN objViewTypeCodeTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewTypeCodeTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面类型名称 = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsViewTypeCodeTabBL.AddNewRecordBySql2WithReturnKey)", objViewTypeCodeTabEN.ViewTypeName,objViewTypeCodeTabEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewTypeCodeTabDA.AddNewRecordBySQL2WithReturnKey(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
try
{
bool bolResult = ViewTypeCodeTabDA.Update(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "objViewTypeCodeTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 if (objViewTypeCodeTabEN.ViewTypeCode == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewTypeCodeTabDA.UpdateBySql2(objViewTypeCodeTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewTypeCodeTabBL.ReFreshCache();

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
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
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intViewTypeCode)
{
try
{
 clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCode(intViewTypeCode);

if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(objViewTypeCodeTabEN.ViewTypeCode, "SetUpdDate");
}
if (objViewTypeCodeTabEN != null)
{
int intRecNum = ViewTypeCodeTabDA.DelRecord(intViewTypeCode);
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
/// <param name="intViewTypeCode">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intViewTypeCode )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
//删除与表:[ViewTypeCodeTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewTypeCodeTab.ViewTypeCode,
//intViewTypeCode);
//        clsViewTypeCodeTabBL.DelViewTypeCodeTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewTypeCodeTabBL.DelRecord(intViewTypeCode, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewTypeCodeTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intViewTypeCode, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intViewTypeCode">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intViewTypeCode, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewTypeCodeTabBL.relatedActions != null)
{
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(intViewTypeCode, "UpdRelaTabDate");
}
bool bolResult = ViewTypeCodeTabDA.DelRecord(intViewTypeCode,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewTypeCodeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewTypeCodeTabs(List<string> arrViewTypeCodeLst)
{
if (arrViewTypeCodeLst.Count == 0) return 0;
try
{
if (clsViewTypeCodeTabBL.relatedActions != null)
{
foreach (var strViewTypeCode in arrViewTypeCodeLst)
{
int intViewTypeCode = int.Parse(strViewTypeCode);
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(intViewTypeCode, "UpdRelaTabDate");
}
}
int intDelRecNum = ViewTypeCodeTabDA.DelViewTypeCodeTab(arrViewTypeCodeLst);
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
public static int DelViewTypeCodeTabsByCond(string strWhereCond)
{
try
{
if (clsViewTypeCodeTabBL.relatedActions != null)
{
List<string> arrViewTypeCode = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewTypeCode in arrViewTypeCode)
{
int intViewTypeCode = int.Parse(strViewTypeCode);
clsViewTypeCodeTabBL.relatedActions.UpdRelaTabDate(intViewTypeCode, "UpdRelaTabDate");
}
}
int intRecNum = ViewTypeCodeTabDA.DelViewTypeCodeTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewTypeCodeTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intViewTypeCode">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intViewTypeCode)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewTypeCodeTabDA.GetSpecSQLObj();
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
//删除与表:[ViewTypeCodeTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewTypeCodeTabBL.DelRecord(intViewTypeCode, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewTypeCodeTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intViewTypeCode, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewTypeCodeTabENS">源对象</param>
 /// <param name = "objViewTypeCodeTabENT">目标对象</param>
 public static void CopyTo(clsViewTypeCodeTabEN objViewTypeCodeTabENS, clsViewTypeCodeTabEN objViewTypeCodeTabENT)
{
try
{
objViewTypeCodeTabENT.ViewTypeCode = objViewTypeCodeTabENS.ViewTypeCode; //界面类型码
objViewTypeCodeTabENT.ViewTypeName = objViewTypeCodeTabENS.ViewTypeName; //界面类型名称
objViewTypeCodeTabENT.ViewTypeENName = objViewTypeCodeTabENS.ViewTypeENName; //ViewTypeENName
objViewTypeCodeTabENT.IsWinApp = objViewTypeCodeTabENS.IsWinApp; //IsWinApp
objViewTypeCodeTabENT.IsMobileApp = objViewTypeCodeTabENS.IsMobileApp; //是否移动终端应用
objViewTypeCodeTabENT.IsWebApp = objViewTypeCodeTabENS.IsWebApp; //IsWebApp
objViewTypeCodeTabENT.ViewFunction = objViewTypeCodeTabENS.ViewFunction; //界面功能
objViewTypeCodeTabENT.OptProcess = objViewTypeCodeTabENS.OptProcess; //操作流程
objViewTypeCodeTabENT.ViewDetail = objViewTypeCodeTabENS.ViewDetail; //界面说明
objViewTypeCodeTabENT.ApplicationTypeId = objViewTypeCodeTabENS.ApplicationTypeId; //应用程序类型ID
objViewTypeCodeTabENT.IsHaveAdd = objViewTypeCodeTabENS.IsHaveAdd; //是否有添加
objViewTypeCodeTabENT.IsHaveUpdate = objViewTypeCodeTabENS.IsHaveUpdate; //是否有修改
objViewTypeCodeTabENT.IsHaveDel = objViewTypeCodeTabENS.IsHaveDel; //是否有删除
objViewTypeCodeTabENT.IsHaveQuery = objViewTypeCodeTabENS.IsHaveQuery; //是否有查询
objViewTypeCodeTabENT.IsHaveExcelExport = objViewTypeCodeTabENS.IsHaveExcelExport; //是否EXCEL导出
objViewTypeCodeTabENT.IsHaveSetExportExcel = objViewTypeCodeTabENS.IsHaveSetExportExcel; //是否有设置EXCEL导出
objViewTypeCodeTabENT.IsHaveDetail = objViewTypeCodeTabENS.IsHaveDetail; //是否有详细
objViewTypeCodeTabENT.IsHaveExeAdd = objViewTypeCodeTabENS.IsHaveExeAdd; //是否有调用添加
objViewTypeCodeTabENT.IsHaveExeUpdate = objViewTypeCodeTabENS.IsHaveExeUpdate; //是否有调用修改
objViewTypeCodeTabENT.IsHaveMainView = objViewTypeCodeTabENS.IsHaveMainView; //是否有主界面
objViewTypeCodeTabENT.IsHaveSubView = objViewTypeCodeTabENS.IsHaveSubView; //是否有子界面
objViewTypeCodeTabENT.OrderNum = objViewTypeCodeTabENS.OrderNum; //序号
objViewTypeCodeTabENT.IsUsed = objViewTypeCodeTabENS.IsUsed; //IsUsed
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
 /// <param name = "objViewTypeCodeTabEN">源简化对象</param>
 public static void SetUpdFlag(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
try
{
objViewTypeCodeTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewTypeCodeTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewTypeCodeTab.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ViewTypeCode = objViewTypeCodeTabEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(conViewTypeCodeTab.ViewTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ViewTypeName = objViewTypeCodeTabEN.ViewTypeName; //界面类型名称
}
if (arrFldSet.Contains(conViewTypeCodeTab.ViewTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ViewTypeENName = objViewTypeCodeTabEN.ViewTypeENName == "[null]" ? null :  objViewTypeCodeTabEN.ViewTypeENName; //ViewTypeENName
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsWinApp, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsWinApp = objViewTypeCodeTabEN.IsWinApp; //IsWinApp
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsMobileApp, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsMobileApp = objViewTypeCodeTabEN.IsMobileApp; //是否移动终端应用
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsWebApp, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsWebApp = objViewTypeCodeTabEN.IsWebApp; //IsWebApp
}
if (arrFldSet.Contains(conViewTypeCodeTab.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ViewFunction = objViewTypeCodeTabEN.ViewFunction == "[null]" ? null :  objViewTypeCodeTabEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(conViewTypeCodeTab.OptProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.OptProcess = objViewTypeCodeTabEN.OptProcess == "[null]" ? null :  objViewTypeCodeTabEN.OptProcess; //操作流程
}
if (arrFldSet.Contains(conViewTypeCodeTab.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ViewDetail = objViewTypeCodeTabEN.ViewDetail == "[null]" ? null :  objViewTypeCodeTabEN.ViewDetail; //界面说明
}
if (arrFldSet.Contains(conViewTypeCodeTab.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.ApplicationTypeId = objViewTypeCodeTabEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveAdd = objViewTypeCodeTabEN.IsHaveAdd; //是否有添加
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveUpdate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveUpdate = objViewTypeCodeTabEN.IsHaveUpdate; //是否有修改
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveDel, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveDel = objViewTypeCodeTabEN.IsHaveDel; //是否有删除
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveQuery, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveQuery = objViewTypeCodeTabEN.IsHaveQuery; //是否有查询
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveExcelExport, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveExcelExport = objViewTypeCodeTabEN.IsHaveExcelExport; //是否EXCEL导出
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveSetExportExcel, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveSetExportExcel = objViewTypeCodeTabEN.IsHaveSetExportExcel; //是否有设置EXCEL导出
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveDetail = objViewTypeCodeTabEN.IsHaveDetail; //是否有详细
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveExeAdd, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveExeAdd = objViewTypeCodeTabEN.IsHaveExeAdd; //是否有调用添加
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveExeUpdate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveExeUpdate = objViewTypeCodeTabEN.IsHaveExeUpdate; //是否有调用修改
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveMainView, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveMainView = objViewTypeCodeTabEN.IsHaveMainView; //是否有主界面
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsHaveSubView, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsHaveSubView = objViewTypeCodeTabEN.IsHaveSubView; //是否有子界面
}
if (arrFldSet.Contains(conViewTypeCodeTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.OrderNum = objViewTypeCodeTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conViewTypeCodeTab.IsUsed, new clsStrCompareIgnoreCase())  ==  true)
{
objViewTypeCodeTabEN.IsUsed = objViewTypeCodeTabEN.IsUsed; //IsUsed
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
 /// <param name = "objViewTypeCodeTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
try
{
if (objViewTypeCodeTabEN.ViewTypeENName == "[null]") objViewTypeCodeTabEN.ViewTypeENName = null; //ViewTypeENName
if (objViewTypeCodeTabEN.ViewFunction == "[null]") objViewTypeCodeTabEN.ViewFunction = null; //界面功能
if (objViewTypeCodeTabEN.OptProcess == "[null]") objViewTypeCodeTabEN.OptProcess = null; //操作流程
if (objViewTypeCodeTabEN.ViewDetail == "[null]") objViewTypeCodeTabEN.ViewDetail = null; //界面说明
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
public static void CheckPropertyNew(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 ViewTypeCodeTabDA.CheckPropertyNew(objViewTypeCodeTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
 ViewTypeCodeTabDA.CheckProperty4Condition(objViewTypeCodeTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ViewTypeCode(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewTypeCodeTab.ViewTypeCode); 
List<clsViewTypeCodeTabEN> arrObjLst = clsViewTypeCodeTabBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewTypeCodeTabEN objViewTypeCodeTabEN = new clsViewTypeCodeTabEN()
{
ViewTypeCode = 0,
ViewTypeName = "选[界面类型码]..."
};
arrObjLst.Insert(0, objViewTypeCodeTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewTypeCodeTab.ViewTypeCode;
objComboBox.DisplayMember = conViewTypeCodeTab.ViewTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面类型码]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conViewTypeCodeTab.ViewTypeCode); 
IEnumerable<clsViewTypeCodeTabEN> arrObjLst = clsViewTypeCodeTabBL.GetObjLst(strCondition);
objDDL.DataValueField = conViewTypeCodeTab.ViewTypeCode;
objDDL.DataTextField = conViewTypeCodeTab.ViewTypeName;
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
public static void BindDdl_ViewTypeCodeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面类型码]...","0");
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst = GetAllViewTypeCodeTabObjLstCache(); 
objDDL.DataValueField = conViewTypeCodeTab.ViewTypeCode;
objDDL.DataTextField = conViewTypeCodeTab.ViewTypeName;
objDDL.DataSource = arrViewTypeCodeTabObjLst;
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
if (clsViewTypeCodeTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewTypeCodeTabBL没有刷新缓存机制(clsViewTypeCodeTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewTypeCode");
//if (arrViewTypeCodeTabObjLstCache == null)
//{
//arrViewTypeCodeTabObjLstCache = ViewTypeCodeTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewTypeCodeTabEN GetObjByViewTypeCodeCache(int intViewTypeCode)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLst_Sel =
arrViewTypeCodeTabObjLstCache
.Where(x=> x.ViewTypeCode == intViewTypeCode 
);
if (arrViewTypeCodeTabObjLst_Sel.Count() == 0)
{
   clsViewTypeCodeTabEN obj = clsViewTypeCodeTabBL.GetObjByViewTypeCode(intViewTypeCode);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewTypeCodeTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewTypeNameByViewTypeCodeCache(int intViewTypeCode)
{
//获取缓存中的对象列表
clsViewTypeCodeTabEN objViewTypeCodeTab = GetObjByViewTypeCodeCache(intViewTypeCode);
if (objViewTypeCodeTab == null) return "";
return objViewTypeCodeTab.ViewTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intViewTypeCode">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewTypeCodeCache(int intViewTypeCode)
{
//获取缓存中的对象列表
clsViewTypeCodeTabEN objViewTypeCodeTab = GetObjByViewTypeCodeCache(intViewTypeCode);
if (objViewTypeCodeTab == null) return "";
return objViewTypeCodeTab.ViewTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetAllViewTypeCodeTabObjLstCache()
{
//获取缓存中的对象列表
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = GetObjLstCache(); 
return arrViewTypeCodeTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewTypeCodeTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewTypeCodeTabObjLstCache;
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
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewTypeCodeTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewTypeCodeTabEN._RefreshTimeLst.Count == 0) return "";
return clsViewTypeCodeTabEN._RefreshTimeLst[clsViewTypeCodeTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsViewTypeCodeTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewTypeCodeTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewTypeCodeTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewTypeCodeTabBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewTypeCodeTab(界面类型码)
 /// 唯一性条件:ViewTypeName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewTypeCodeTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewTypeCodeTabEN objViewTypeCodeTabEN)
{
//检测记录是否存在
string strResult = ViewTypeCodeTabDA.GetUniCondStr(objViewTypeCodeTabEN);
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
public static string Func(string strInFldName, string strOutFldName, int intViewTypeCode)
{
if (strInFldName != conViewTypeCodeTab.ViewTypeCode)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewTypeCodeTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewTypeCodeTab._AttributeName));
throw new Exception(strMsg);
}
var objViewTypeCodeTab = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(intViewTypeCode);
if (objViewTypeCodeTab == null) return "";
return objViewTypeCodeTab[strOutFldName].ToString();
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
int intRecCount = clsViewTypeCodeTabDA.GetRecCount(strTabName);
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
int intRecCount = clsViewTypeCodeTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewTypeCodeTabDA.GetRecCount();
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
int intRecCount = clsViewTypeCodeTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewTypeCodeTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewTypeCodeTabEN objViewTypeCodeTabCond)
{
List<clsViewTypeCodeTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewTypeCodeTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewTypeCodeTab._AttributeName)
{
if (objViewTypeCodeTabCond.IsUpdated(strFldName) == false) continue;
if (objViewTypeCodeTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewTypeCodeTabCond[strFldName].ToString());
}
else
{
if (objViewTypeCodeTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewTypeCodeTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewTypeCodeTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewTypeCodeTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewTypeCodeTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewTypeCodeTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewTypeCodeTabCond[strFldName]));
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
 List<string> arrList = clsViewTypeCodeTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewTypeCodeTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewTypeCodeTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewTypeCodeTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewTypeCodeTabDA.SetFldValue(clsViewTypeCodeTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewTypeCodeTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewTypeCodeTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewTypeCodeTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewTypeCodeTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewTypeCodeTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面类型码*/ 
 strCreateTabCode.Append(" ViewTypeCode int primary key identity, "); 
 // /**界面类型名称*/ 
 strCreateTabCode.Append(" ViewTypeName varchar(40) not Null, "); 
 // /**ViewTypeENName*/ 
 strCreateTabCode.Append(" ViewTypeENName varchar(40) Null, "); 
 // /**IsWinApp*/ 
 strCreateTabCode.Append(" IsWinApp bit Null, "); 
 // /**是否移动终端应用*/ 
 strCreateTabCode.Append(" IsMobileApp bit Null, "); 
 // /**IsWebApp*/ 
 strCreateTabCode.Append(" IsWebApp bit Null, "); 
 // /**界面功能*/ 
 strCreateTabCode.Append(" ViewFunction varchar(100) Null, "); 
 // /**操作流程*/ 
 strCreateTabCode.Append(" OptProcess varchar(1000) Null, "); 
 // /**界面说明*/ 
 strCreateTabCode.Append(" ViewDetail varchar(1000) Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**是否有添加*/ 
 strCreateTabCode.Append(" IsHaveAdd bit not Null, "); 
 // /**是否有修改*/ 
 strCreateTabCode.Append(" IsHaveUpdate bit not Null, "); 
 // /**是否有删除*/ 
 strCreateTabCode.Append(" IsHaveDel bit not Null, "); 
 // /**是否有查询*/ 
 strCreateTabCode.Append(" IsHaveQuery bit not Null, "); 
 // /**是否EXCEL导出*/ 
 strCreateTabCode.Append(" IsHaveExcelExport bit not Null, "); 
 // /**是否有设置EXCEL导出*/ 
 strCreateTabCode.Append(" IsHaveSetExportExcel bit not Null, "); 
 // /**是否有详细*/ 
 strCreateTabCode.Append(" IsHaveDetail bit not Null, "); 
 // /**是否有调用添加*/ 
 strCreateTabCode.Append(" IsHaveExeAdd bit not Null, "); 
 // /**是否有调用修改*/ 
 strCreateTabCode.Append(" IsHaveExeUpdate bit not Null, "); 
 // /**是否有主界面*/ 
 strCreateTabCode.Append(" IsHaveMainView bit not Null, "); 
 // /**是否有子界面*/ 
 strCreateTabCode.Append(" IsHaveSubView bit not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**IsUsed*/ 
 strCreateTabCode.Append(" IsUsed bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面类型码(ViewTypeCodeTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewTypeCodeTab : clsCommFun4BL
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
clsViewTypeCodeTabBL.ReFreshThisCache();
}
}

}