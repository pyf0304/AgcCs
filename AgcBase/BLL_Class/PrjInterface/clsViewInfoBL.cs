
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoBL
 表名:ViewInfo(00050006)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsViewInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewInfoEN GetObj(this K_ViewId_ViewInfo myKey)
{
clsViewInfoEN objViewInfoEN = clsViewInfoBL.ViewInfoDA.GetObjByViewId(myKey.Value);
return objViewInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoBL.IsExist(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],界面名称 = [{1}],应用程序类型ID = [{2}]的数据已经存在!(in clsViewInfoBL.AddNewRecord)", objViewInfoEN.PrjId,objViewInfoEN.ViewName,objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewInfoBL.ViewInfoDA.AddNewRecordBySQL2(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
public static bool AddRecordEx(this clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewInfoBL.IsExist(objViewInfoEN.ViewId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],界面名称(ViewName)=[{1}],应用程序类型ID(ApplicationTypeId)=[{2}])已经存在,不能重复!", objViewInfoEN.PrjId, objViewInfoEN.ViewName, objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewInfoEN.AddNewRecord();
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],界面名称 = [{1}],应用程序类型ID = [{2}]的数据已经存在!(in clsViewInfoBL.AddNewRecordWithMaxId)", objViewInfoEN.PrjId,objViewInfoEN.ViewName,objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true || clsViewInfoBL.IsExist(objViewInfoEN.ViewId) == true)
 {
     objViewInfoEN.ViewId = clsViewInfoBL.GetMaxStrIdByPrefix_S(objViewInfoEN.PrjId);
 }
string strViewId = clsViewInfoBL.ViewInfoDA.AddNewRecordBySQL2WithReturnKey(objViewInfoEN);
     objViewInfoEN.ViewId = strViewId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
}
return strViewId;
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoBL.IsExist(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],界面名称 = [{1}],应用程序类型ID = [{2}]的数据已经存在!(in clsViewInfoBL.AddNewRecordWithReturnKey)", objViewInfoEN.PrjId,objViewInfoEN.ViewName,objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewInfoBL.ViewInfoDA.AddNewRecordBySQL2WithReturnKey(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewId(this clsViewInfoEN objViewInfoEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewInfo.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewInfo.ViewId);
}
objViewInfoEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewName(this clsViewInfoEN objViewInfoEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, conViewInfo.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, conViewInfo.ViewName);
}
objViewInfoEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetApplicationTypeId(this clsViewInfoEN objViewInfoEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewInfo.ApplicationTypeId);
objViewInfoEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ApplicationTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ApplicationTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ApplicationTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFuncModuleAgcId(this clsViewInfoEN objViewInfoEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
}
objViewInfoEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FuncModuleAgcId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FuncModuleAgcId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FuncModuleAgcId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDataBaseName(this clsViewInfoEN objViewInfoEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conViewInfo.DataBaseName);
}
objViewInfoEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DataBaseName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DataBaseName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DataBaseName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyForMainTab(this clsViewInfoEN objViewInfoEN, string strKeyForMainTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForMainTab, 50, conViewInfo.KeyForMainTab);
}
objViewInfoEN.KeyForMainTab = strKeyForMainTab; //主表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyForMainTab) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyForMainTab, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyForMainTab] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyForDetailTab(this clsViewInfoEN objViewInfoEN, string strKeyForDetailTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyForDetailTab, 50, conViewInfo.KeyForDetailTab);
}
objViewInfoEN.KeyForDetailTab = strKeyForDetailTab; //明细表关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyForDetailTab) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyForDetailTab, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyForDetailTab] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedSort(this clsViewInfoEN objViewInfoEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conViewInfo.IsNeedSort);
objViewInfoEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedSort) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedSort, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedSort] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedTransCode(this clsViewInfoEN objViewInfoEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, conViewInfo.IsNeedTransCode);
objViewInfoEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedTransCode) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedTransCode, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedTransCode] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsNeedSetExportFld(this clsViewInfoEN objViewInfoEN, bool bolIsNeedSetExportFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSetExportFld, conViewInfo.IsNeedSetExportFld);
objViewInfoEN.IsNeedSetExportFld = bolIsNeedSetExportFld; //是否需要设置导出字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsNeedSetExportFld) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsNeedSetExportFld, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsNeedSetExportFld] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUserId(this clsViewInfoEN objViewInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conViewInfo.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conViewInfo.UserId);
}
objViewInfoEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UserId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UserId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UserId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetPrjId(this clsViewInfoEN objViewInfoEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewInfo.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewInfo.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewInfo.PrjId);
}
objViewInfoEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.PrjId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.PrjId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.PrjId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewFunction(this clsViewInfoEN objViewInfoEN, string strViewFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFunction, 100, conViewInfo.ViewFunction);
}
objViewInfoEN.ViewFunction = strViewFunction; //界面功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewFunction) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewFunction, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewFunction] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewDetail(this clsViewInfoEN objViewInfoEN, string strViewDetail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDetail, 1000, conViewInfo.ViewDetail);
}
objViewInfoEN.ViewDetail = strViewDetail; //界面说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewDetail) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewDetail, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewDetail] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDefaMenuName(this clsViewInfoEN objViewInfoEN, string strDefaMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaMenuName, conViewInfo.DefaMenuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaMenuName, 100, conViewInfo.DefaMenuName);
}
objViewInfoEN.DefaMenuName = strDefaMenuName; //缺省菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DefaMenuName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DefaMenuName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DefaMenuName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailTabId(this clsViewInfoEN objViewInfoEN, string strDetailTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabId, 8, conViewInfo.DetailTabId);
}
objViewInfoEN.DetailTabId = strDetailTabId; //明细表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFileName(this clsViewInfoEN objViewInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conViewInfo.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conViewInfo.FileName);
}
objViewInfoEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FileName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FileName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FileName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetFilePath(this clsViewInfoEN objViewInfoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conViewInfo.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conViewInfo.FilePath);
}
objViewInfoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.FilePath) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.FilePath, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.FilePath] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainTabId(this clsViewInfoEN objViewInfoEN, string strMainTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabId, 8, conViewInfo.MainTabId);
}
objViewInfoEN.MainTabId = strMainTabId; //主表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewCnName(this clsViewInfoEN objViewInfoEN, string strViewCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewCnName, conViewInfo.ViewCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewCnName, 100, conViewInfo.ViewCnName);
}
objViewInfoEN.ViewCnName = strViewCnName; //视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewCnName) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewCnName, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewCnName] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewGroupId(this clsViewInfoEN objViewInfoEN, string strViewGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, conViewInfo.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, conViewInfo.ViewGroupId);
}
objViewInfoEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewGroupId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewGroupId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewGroupId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetInRelaTabId(this clsViewInfoEN objViewInfoEN, string strInRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, conViewInfo.InRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, conViewInfo.InRelaTabId);
}
objViewInfoEN.InRelaTabId = strInRelaTabId; //输入数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.InRelaTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.InRelaTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.InRelaTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetInSqlDsTypeId(this clsViewInfoEN objViewInfoEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
}
objViewInfoEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.InSqlDsTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.InSqlDsTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.InSqlDsTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetOutRelaTabId(this clsViewInfoEN objViewInfoEN, string strOutRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, conViewInfo.OutRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, conViewInfo.OutRelaTabId);
}
objViewInfoEN.OutRelaTabId = strOutRelaTabId; //输出数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.OutRelaTabId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.OutRelaTabId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.OutRelaTabId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetOutSqlDsTypeId(this clsViewInfoEN objViewInfoEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
}
objViewInfoEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.OutSqlDsTypeId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.OutSqlDsTypeId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.OutSqlDsTypeId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailTabType(this clsViewInfoEN objViewInfoEN, string strDetailTabType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTabType, 10, conViewInfo.DetailTabType);
}
objViewInfoEN.DetailTabType = strDetailTabType; //DetailTabType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailTabType) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailTabType, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailTabType] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetDetailViewId(this clsViewInfoEN objViewInfoEN, string strDetailViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailViewId, 8, conViewInfo.DetailViewId);
}
objViewInfoEN.DetailViewId = strDetailViewId; //DetailViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.DetailViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.DetailViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.DetailViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainTabType(this clsViewInfoEN objViewInfoEN, string strMainTabType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainTabType, 10, conViewInfo.MainTabType);
}
objViewInfoEN.MainTabType = strMainTabType; //MainTabType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainTabType) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainTabType, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainTabType] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMainViewId(this clsViewInfoEN objViewInfoEN, string strMainViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMainViewId, 8, conViewInfo.MainViewId);
}
objViewInfoEN.MainViewId = strMainViewId; //MainViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.MainViewId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.MainViewId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.MainViewId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetGeneCodeDate(this clsViewInfoEN objViewInfoEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conViewInfo.GeneCodeDate);
}
objViewInfoEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.GeneCodeDate) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.GeneCodeDate, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.GeneCodeDate] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetTaskId(this clsViewInfoEN objViewInfoEN, string strTaskId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTaskId, 16, conViewInfo.TaskId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTaskId, 16, conViewInfo.TaskId);
}
objViewInfoEN.TaskId = strTaskId; //任务Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.TaskId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.TaskId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.TaskId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetKeyId4Test(this clsViewInfoEN objViewInfoEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conViewInfo.KeyId4Test);
}
objViewInfoEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.KeyId4Test) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.KeyId4Test, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.KeyId4Test] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetViewMasterId(this clsViewInfoEN objViewInfoEN, string strViewMasterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, conViewInfo.ViewMasterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, conViewInfo.ViewMasterId);
}
objViewInfoEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ViewMasterId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ViewMasterId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ViewMasterId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetIsShare(this clsViewInfoEN objViewInfoEN, bool bolIsShare, string strComparisonOp="")
	{
objViewInfoEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.IsShare) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.IsShare, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.IsShare] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetErrMsg(this clsViewInfoEN objViewInfoEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewInfo.ErrMsg);
}
objViewInfoEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.ErrMsg) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.ErrMsg, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.ErrMsg] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUpdDate(this clsViewInfoEN objViewInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewInfo.UpdDate);
}
objViewInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UpdDate) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UpdDate, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UpdDate] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetUpdUserId(this clsViewInfoEN objViewInfoEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conViewInfo.UpdUserId);
}
objViewInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.UpdUserId) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.UpdUserId, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.UpdUserId] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetMemo(this clsViewInfoEN objViewInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewInfo.Memo);
}
objViewInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.Memo) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.Memo, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.Memo] = strComparisonOp;
}
}
return objViewInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoEN SetRegionNum(this clsViewInfoEN objViewInfoEN, int? intRegionNum, string strComparisonOp="")
	{
objViewInfoEN.RegionNum = intRegionNum; //区域数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoEN.dicFldComparisonOp.ContainsKey(conViewInfo.RegionNum) == false)
{
objViewInfoEN.dicFldComparisonOp.Add(conViewInfo.RegionNum, strComparisonOp);
}
else
{
objViewInfoEN.dicFldComparisonOp[conViewInfo.RegionNum] = strComparisonOp;
}
}
return objViewInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewInfoEN objViewInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewInfoEN.CheckPropertyNew();
clsViewInfoEN objViewInfoCond = new clsViewInfoEN();
string strCondition = objViewInfoCond
.SetViewId(objViewInfoEN.ViewId, "<>")
.SetPrjId(objViewInfoEN.PrjId, "=")
.SetViewName(objViewInfoEN.ViewName, "=")
.SetApplicationTypeId(objViewInfoEN.ApplicationTypeId, "=")
.GetCombineCondition();
objViewInfoEN._IsCheckProperty = true;
bool bolIsExist = clsViewInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_ViewName_ApplicationTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewInfoEN.Update();
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
 /// <param name = "objViewInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewInfoEN objViewInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewInfoEN objViewInfoCond = new clsViewInfoEN();
string strCondition = objViewInfoCond
.SetPrjId(objViewInfo.PrjId, "=")
.SetViewName(objViewInfo.ViewName, "=")
.SetApplicationTypeId(objViewInfo.ApplicationTypeId, "=")
.GetCombineCondition();
objViewInfo._IsCheckProperty = true;
bool bolIsExist = clsViewInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewInfo.ViewId = clsViewInfoBL.GetFirstID_S(strCondition);
objViewInfo.UpdateWithCondition(strCondition);
}
else
{
objViewInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewInfoEN objViewInfoEN)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewInfoBL.ViewInfoDA.UpdateBySql2(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewInfoEN objViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewInfoBL.ViewInfoDA.UpdateBySql2(objViewInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewInfoEN objViewInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsViewInfoBL.ViewInfoDA.UpdateBySqlWithCondition(objViewInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewInfoEN objViewInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewInfoBL.ViewInfoDA.UpdateBySqlWithConditionTransaction(objViewInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewInfoEN objViewInfoEN)
{
try
{
int intRecNum = clsViewInfoBL.ViewInfoDA.DelRecord(objViewInfoEN.ViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
 public static void CopyTo(this clsViewInfoEN objViewInfoENS, clsViewInfoEN objViewInfoENT)
{
try
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程Id
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.InRelaTabId = objViewInfoENS.InRelaTabId; //输入数据源表ID
objViewInfoENT.InSqlDsTypeId = objViewInfoENS.InSqlDsTypeId; //输入数据源类型
objViewInfoENT.OutRelaTabId = objViewInfoENS.OutRelaTabId; //输出数据源表ID
objViewInfoENT.OutSqlDsTypeId = objViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.KeyId4Test = objViewInfoENS.KeyId4Test; //测试关键字Id
objViewInfoENT.ViewMasterId = objViewInfoENS.ViewMasterId; //界面母版Id
objViewInfoENT.IsShare = objViewInfoENS.IsShare; //是否共享
objViewInfoENT.ErrMsg = objViewInfoENS.ErrMsg; //错误信息
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
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
 /// <param name = "objViewInfoENS">源对象</param>
 /// <returns>目标对象=>clsViewInfoEN:objViewInfoENT</returns>
 public static clsViewInfoEN CopyTo(this clsViewInfoEN objViewInfoENS)
{
try
{
 clsViewInfoEN objViewInfoENT = new clsViewInfoEN()
{
ViewId = objViewInfoENS.ViewId, //界面Id
ViewName = objViewInfoENS.ViewName, //界面名称
ApplicationTypeId = objViewInfoENS.ApplicationTypeId, //应用程序类型ID
FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId, //功能模块Id
DataBaseName = objViewInfoENS.DataBaseName, //数据库名
KeyForMainTab = objViewInfoENS.KeyForMainTab, //主表关键字
KeyForDetailTab = objViewInfoENS.KeyForDetailTab, //明细表关键字
IsNeedSort = objViewInfoENS.IsNeedSort, //是否需要排序
IsNeedTransCode = objViewInfoENS.IsNeedTransCode, //是否需要转换代码
IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld, //是否需要设置导出字段
UserId = objViewInfoENS.UserId, //用户Id
PrjId = objViewInfoENS.PrjId, //工程Id
ViewFunction = objViewInfoENS.ViewFunction, //界面功能
ViewDetail = objViewInfoENS.ViewDetail, //界面说明
DefaMenuName = objViewInfoENS.DefaMenuName, //缺省菜单名
DetailTabId = objViewInfoENS.DetailTabId, //明细表ID
FileName = objViewInfoENS.FileName, //文件名
FilePath = objViewInfoENS.FilePath, //文件路径
MainTabId = objViewInfoENS.MainTabId, //主表ID
ViewCnName = objViewInfoENS.ViewCnName, //视图中文名
ViewGroupId = objViewInfoENS.ViewGroupId, //界面组ID
InRelaTabId = objViewInfoENS.InRelaTabId, //输入数据源表ID
InSqlDsTypeId = objViewInfoENS.InSqlDsTypeId, //输入数据源类型
OutRelaTabId = objViewInfoENS.OutRelaTabId, //输出数据源表ID
OutSqlDsTypeId = objViewInfoENS.OutSqlDsTypeId, //输出数据源类型
DetailTabType = objViewInfoENS.DetailTabType, //DetailTabType
DetailViewId = objViewInfoENS.DetailViewId, //DetailViewId
MainTabType = objViewInfoENS.MainTabType, //MainTabType
MainViewId = objViewInfoENS.MainViewId, //MainViewId
GeneCodeDate = objViewInfoENS.GeneCodeDate, //生成代码日期
TaskId = objViewInfoENS.TaskId, //任务Id
KeyId4Test = objViewInfoENS.KeyId4Test, //测试关键字Id
ViewMasterId = objViewInfoENS.ViewMasterId, //界面母版Id
IsShare = objViewInfoENS.IsShare, //是否共享
ErrMsg = objViewInfoENS.ErrMsg, //错误信息
UpdDate = objViewInfoENS.UpdDate, //修改日期
UpdUserId = objViewInfoENS.UpdUserId, //修改用户Id
Memo = objViewInfoENS.Memo, //说明
RegionNum = objViewInfoENS.RegionNum, //区域数
};
 return objViewInfoENT;
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
public static void CheckPropertyNew(this clsViewInfoEN objViewInfoEN)
{
 clsViewInfoBL.ViewInfoDA.CheckPropertyNew(objViewInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewInfoEN objViewInfoEN)
{
 clsViewInfoBL.ViewInfoDA.CheckProperty4Condition(objViewInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewInfoEN objViewInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewInfoCond.IsUpdated(conViewInfo.ViewId) == true)
{
string strComparisonOpViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewId, objViewInfoCond.ViewId, strComparisonOpViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewName) == true)
{
string strComparisonOpViewName = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewName, objViewInfoCond.ViewName, strComparisonOpViewName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewInfo.ApplicationTypeId, objViewInfoCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objViewInfoCond.dicFldComparisonOp[conViewInfo.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FuncModuleAgcId, objViewInfoCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objViewInfoCond.dicFldComparisonOp[conViewInfo.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DataBaseName, objViewInfoCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyForMainTab) == true)
{
string strComparisonOpKeyForMainTab = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyForMainTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyForMainTab, objViewInfoCond.KeyForMainTab, strComparisonOpKeyForMainTab);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyForDetailTab) == true)
{
string strComparisonOpKeyForDetailTab = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyForDetailTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyForDetailTab, objViewInfoCond.KeyForDetailTab, strComparisonOpKeyForDetailTab);
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedSort) == true)
{
if (objViewInfoCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedSort);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedTransCode) == true)
{
if (objViewInfoCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedTransCode);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsNeedSetExportFld) == true)
{
if (objViewInfoCond.IsNeedSetExportFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsNeedSetExportFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsNeedSetExportFld);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.UserId) == true)
{
string strComparisonOpUserId = objViewInfoCond.dicFldComparisonOp[conViewInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UserId, objViewInfoCond.UserId, strComparisonOpUserId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.PrjId) == true)
{
string strComparisonOpPrjId = objViewInfoCond.dicFldComparisonOp[conViewInfo.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.PrjId, objViewInfoCond.PrjId, strComparisonOpPrjId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewFunction) == true)
{
string strComparisonOpViewFunction = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewFunction, objViewInfoCond.ViewFunction, strComparisonOpViewFunction);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewDetail) == true)
{
string strComparisonOpViewDetail = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewDetail];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewDetail, objViewInfoCond.ViewDetail, strComparisonOpViewDetail);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DefaMenuName) == true)
{
string strComparisonOpDefaMenuName = objViewInfoCond.dicFldComparisonOp[conViewInfo.DefaMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DefaMenuName, objViewInfoCond.DefaMenuName, strComparisonOpDefaMenuName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailTabId) == true)
{
string strComparisonOpDetailTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailTabId, objViewInfoCond.DetailTabId, strComparisonOpDetailTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FileName) == true)
{
string strComparisonOpFileName = objViewInfoCond.dicFldComparisonOp[conViewInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FileName, objViewInfoCond.FileName, strComparisonOpFileName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.FilePath) == true)
{
string strComparisonOpFilePath = objViewInfoCond.dicFldComparisonOp[conViewInfo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.FilePath, objViewInfoCond.FilePath, strComparisonOpFilePath);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainTabId) == true)
{
string strComparisonOpMainTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainTabId, objViewInfoCond.MainTabId, strComparisonOpMainTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewCnName) == true)
{
string strComparisonOpViewCnName = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewCnName, objViewInfoCond.ViewCnName, strComparisonOpViewCnName);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewGroupId, objViewInfoCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.InRelaTabId) == true)
{
string strComparisonOpInRelaTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.InRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.InRelaTabId, objViewInfoCond.InRelaTabId, strComparisonOpInRelaTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.InSqlDsTypeId, objViewInfoCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.OutRelaTabId) == true)
{
string strComparisonOpOutRelaTabId = objViewInfoCond.dicFldComparisonOp[conViewInfo.OutRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.OutRelaTabId, objViewInfoCond.OutRelaTabId, strComparisonOpOutRelaTabId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objViewInfoCond.dicFldComparisonOp[conViewInfo.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.OutSqlDsTypeId, objViewInfoCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailTabType) == true)
{
string strComparisonOpDetailTabType = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailTabType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailTabType, objViewInfoCond.DetailTabType, strComparisonOpDetailTabType);
}
if (objViewInfoCond.IsUpdated(conViewInfo.DetailViewId) == true)
{
string strComparisonOpDetailViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.DetailViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.DetailViewId, objViewInfoCond.DetailViewId, strComparisonOpDetailViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainTabType) == true)
{
string strComparisonOpMainTabType = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainTabType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainTabType, objViewInfoCond.MainTabType, strComparisonOpMainTabType);
}
if (objViewInfoCond.IsUpdated(conViewInfo.MainViewId) == true)
{
string strComparisonOpMainViewId = objViewInfoCond.dicFldComparisonOp[conViewInfo.MainViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.MainViewId, objViewInfoCond.MainViewId, strComparisonOpMainViewId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objViewInfoCond.dicFldComparisonOp[conViewInfo.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.GeneCodeDate, objViewInfoCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objViewInfoCond.IsUpdated(conViewInfo.TaskId) == true)
{
string strComparisonOpTaskId = objViewInfoCond.dicFldComparisonOp[conViewInfo.TaskId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.TaskId, objViewInfoCond.TaskId, strComparisonOpTaskId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objViewInfoCond.dicFldComparisonOp[conViewInfo.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.KeyId4Test, objViewInfoCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objViewInfoCond.IsUpdated(conViewInfo.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objViewInfoCond.dicFldComparisonOp[conViewInfo.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ViewMasterId, objViewInfoCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.IsShare) == true)
{
if (objViewInfoCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewInfo.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewInfo.IsShare);
}
}
if (objViewInfoCond.IsUpdated(conViewInfo.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewInfoCond.dicFldComparisonOp[conViewInfo.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.ErrMsg, objViewInfoCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewInfoCond.IsUpdated(conViewInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewInfoCond.dicFldComparisonOp[conViewInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UpdDate, objViewInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewInfoCond.IsUpdated(conViewInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objViewInfoCond.dicFldComparisonOp[conViewInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.UpdUserId, objViewInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objViewInfoCond.IsUpdated(conViewInfo.Memo) == true)
{
string strComparisonOpMemo = objViewInfoCond.dicFldComparisonOp[conViewInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfo.Memo, objViewInfoCond.Memo, strComparisonOpMemo);
}
if (objViewInfoCond.IsUpdated(conViewInfo.RegionNum) == true)
{
string strComparisonOpRegionNum = objViewInfoCond.dicFldComparisonOp[conViewInfo.RegionNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewInfo.RegionNum, objViewInfoCond.RegionNum, strComparisonOpRegionNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewInfo(界面), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_ViewName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewInfoEN objViewInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewInfoEN == null) return true;
if (objViewInfoEN.ViewId == null || objViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
if (clsViewInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
if (clsViewInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewInfo(界面), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ViewName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewInfoEN objViewInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewInfoEN == null) return "";
if (objViewInfoEN.ViewId == null || objViewInfoEN.ViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewId !=  '{0}'", objViewInfoEN.ViewId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewInfo
{
public virtual bool UpdRelaTabDate(string strViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面(ViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewInfoBL
{
public static RelatedActions_ViewInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewInfoDA ViewInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsViewInfoBL()
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
if (string.IsNullOrEmpty(clsViewInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewInfoEN._ConnectString);
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
public static DataTable GetDataTable_ViewInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewInfoDA.GetDataTable_ViewInfo(strWhereCond);
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
objDT = ViewInfoDA.GetDataTable(strWhereCond);
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
objDT = ViewInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewInfoDA.GetDataTable_Top(objTopPara);
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
objDT = ViewInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewInfoEN> GetObjLstByViewIdLst(List<string> arrViewIdLst)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewIdLst, true);
 string strWhereCond = string.Format("ViewId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewInfoEN> GetObjLstByViewIdLstCache(List<string> arrViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel =
arrViewInfoObjLstCache
.Where(x => arrViewIdLst.Contains(x.ViewId));
return arrViewInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoEN> GetObjLst(string strWhereCond)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
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
public static List<clsViewInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewInfoEN> GetSubObjLstCache(clsViewInfoEN objViewInfoCond)
{
 string strPrjId = objViewInfoCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewInfoBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewInfoEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewInfo._AttributeName)
{
if (objViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCond[strFldName].ToString());
}
else
{
if (objViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewInfoCond[strFldName]));
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
public static List<clsViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
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
public static List<clsViewInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
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
List<clsViewInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
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
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
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
public static List<clsViewInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
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
public static List<clsViewInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewInfo(ref clsViewInfoEN objViewInfoEN)
{
bool bolResult = ViewInfoDA.GetViewInfo(ref objViewInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewInfoEN GetObjByViewId(string strViewId)
{
if (strViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewInfoEN objViewInfoEN = ViewInfoDA.GetObjByViewId(strViewId);
return objViewInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewInfoEN objViewInfoEN = ViewInfoDA.GetFirstObj(strWhereCond);
 return objViewInfoEN;
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
public static clsViewInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewInfoEN objViewInfoEN = ViewInfoDA.GetObjByDataRow(objRow);
 return objViewInfoEN;
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
public static clsViewInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewInfoEN objViewInfoEN = ViewInfoDA.GetObjByDataRow(objRow);
 return objViewInfoEN;
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
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "lstViewInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewInfoEN GetObjByViewIdFromList(string strViewId, List<clsViewInfoEN> lstViewInfoObjLst)
{
foreach (clsViewInfoEN objViewInfoEN in lstViewInfoObjLst)
{
if (objViewInfoEN.ViewId == strViewId)
{
return objViewInfoEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxViewId;
 try
 {
 strMaxViewId = new clsViewInfoDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxViewId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strViewId;
 try
 {
 strViewId = new clsViewInfoDA().GetFirstID(strWhereCond);
 return strViewId;
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
 arrList = ViewInfoDA.GetID(strWhereCond);
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
bool bolIsExist = ViewInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ViewInfoDA.IsExist(strViewId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewId">界面Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewId, string strOpUser)
{
clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);
objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewInfoEN.UpdUserId = strOpUser;
return clsViewInfoBL.UpdateBySql2(objViewInfoEN);
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
 bolIsExist = clsViewInfoDA.IsExistTable();
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
 bolIsExist = ViewInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoBL.IsExist(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],界面名称 = [{1}],应用程序类型ID = [{2}]的数据已经存在!(in clsViewInfoBL.AddNewRecordBySql2)", objViewInfoEN.PrjId,objViewInfoEN.ViewName,objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewInfoDA.AddNewRecordBySQL2(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewInfoEN objViewInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoBL.IsExist(objViewInfoEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],界面名称 = [{1}],应用程序类型ID = [{2}]的数据已经存在!(in clsViewInfoBL.AddNewRecordBySql2WithReturnKey)", objViewInfoEN.PrjId,objViewInfoEN.ViewName,objViewInfoEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewInfoDA.AddNewRecordBySQL2WithReturnKey(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewInfoEN objViewInfoEN)
{
try
{
bool bolResult = ViewInfoDA.Update(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewInfoEN objViewInfoEN)
{
 if (string.IsNullOrEmpty(objViewInfoEN.ViewId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewInfoDA.UpdateBySql2(objViewInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoBL.ReFreshCache(objViewInfoEN.PrjId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewId)
{
try
{
 clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(strViewId);

if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(objViewInfoEN.ViewId, objViewInfoEN.UpdUserId);
}
if (objViewInfoEN != null)
{
int intRecNum = ViewInfoDA.DelRecord(strViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewInfoEN.PrjId);
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
/// <param name="strViewId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewInfoDA.GetSpecSQLObj();
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
//删除与表:[ViewInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewInfo.ViewId,
//strViewId);
//        clsViewInfoBL.DelViewInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewInfoBL.DelRecord(strViewId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewInfoBL.relatedActions != null)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
bool bolResult = ViewInfoDA.DelRecord(strViewId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrViewIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewInfos(List<string> arrViewIdLst)
{
if (arrViewIdLst.Count == 0) return 0;
try
{
if (clsViewInfoBL.relatedActions != null)
{
foreach (var strViewId in arrViewIdLst)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
}
 clsViewInfoEN objViewInfoEN = clsViewInfoBL.GetObjByViewId(arrViewIdLst[0]);
int intDelRecNum = ViewInfoDA.DelViewInfo(arrViewIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewInfoEN.PrjId);
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
public static int DelViewInfosByCond(string strWhereCond)
{
try
{
if (clsViewInfoBL.relatedActions != null)
{
List<string> arrViewId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewId in arrViewId)
{
clsViewInfoBL.relatedActions.UpdRelaTabDate(strViewId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewInfo.PrjId, strWhereCond);
int intRecNum = ViewInfoDA.DelViewInfo(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewInfoDA.GetSpecSQLObj();
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
//删除与表:[ViewInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewInfoBL.DelRecord(strViewId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
 public static void CopyTo(clsViewInfoEN objViewInfoENS, clsViewInfoEN objViewInfoENT)
{
try
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程Id
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.InRelaTabId = objViewInfoENS.InRelaTabId; //输入数据源表ID
objViewInfoENT.InSqlDsTypeId = objViewInfoENS.InSqlDsTypeId; //输入数据源类型
objViewInfoENT.OutRelaTabId = objViewInfoENS.OutRelaTabId; //输出数据源表ID
objViewInfoENT.OutSqlDsTypeId = objViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.KeyId4Test = objViewInfoENS.KeyId4Test; //测试关键字Id
objViewInfoENT.ViewMasterId = objViewInfoENS.ViewMasterId; //界面母版Id
objViewInfoENT.IsShare = objViewInfoENS.IsShare; //是否共享
objViewInfoENT.ErrMsg = objViewInfoENS.ErrMsg; //错误信息
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
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
 /// <param name = "objViewInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsViewInfoEN objViewInfoEN)
{
try
{
objViewInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewInfo.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewId = objViewInfoEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewInfo.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewName = objViewInfoEN.ViewName; //界面名称
}
if (arrFldSet.Contains(conViewInfo.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ApplicationTypeId = objViewInfoEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conViewInfo.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.FuncModuleAgcId = objViewInfoEN.FuncModuleAgcId == "[null]" ? null :  objViewInfoEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conViewInfo.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.DataBaseName = objViewInfoEN.DataBaseName == "[null]" ? null :  objViewInfoEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(conViewInfo.KeyForMainTab, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.KeyForMainTab = objViewInfoEN.KeyForMainTab == "[null]" ? null :  objViewInfoEN.KeyForMainTab; //主表关键字
}
if (arrFldSet.Contains(conViewInfo.KeyForDetailTab, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.KeyForDetailTab = objViewInfoEN.KeyForDetailTab == "[null]" ? null :  objViewInfoEN.KeyForDetailTab; //明细表关键字
}
if (arrFldSet.Contains(conViewInfo.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.IsNeedSort = objViewInfoEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(conViewInfo.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.IsNeedTransCode = objViewInfoEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(conViewInfo.IsNeedSetExportFld, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.IsNeedSetExportFld = objViewInfoEN.IsNeedSetExportFld; //是否需要设置导出字段
}
if (arrFldSet.Contains(conViewInfo.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.UserId = objViewInfoEN.UserId; //用户Id
}
if (arrFldSet.Contains(conViewInfo.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.PrjId = objViewInfoEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewInfo.ViewFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewFunction = objViewInfoEN.ViewFunction == "[null]" ? null :  objViewInfoEN.ViewFunction; //界面功能
}
if (arrFldSet.Contains(conViewInfo.ViewDetail, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewDetail = objViewInfoEN.ViewDetail == "[null]" ? null :  objViewInfoEN.ViewDetail; //界面说明
}
if (arrFldSet.Contains(conViewInfo.DefaMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.DefaMenuName = objViewInfoEN.DefaMenuName; //缺省菜单名
}
if (arrFldSet.Contains(conViewInfo.DetailTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.DetailTabId = objViewInfoEN.DetailTabId == "[null]" ? null :  objViewInfoEN.DetailTabId; //明细表ID
}
if (arrFldSet.Contains(conViewInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.FileName = objViewInfoEN.FileName; //文件名
}
if (arrFldSet.Contains(conViewInfo.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.FilePath = objViewInfoEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conViewInfo.MainTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.MainTabId = objViewInfoEN.MainTabId == "[null]" ? null :  objViewInfoEN.MainTabId; //主表ID
}
if (arrFldSet.Contains(conViewInfo.ViewCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewCnName = objViewInfoEN.ViewCnName; //视图中文名
}
if (arrFldSet.Contains(conViewInfo.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewGroupId = objViewInfoEN.ViewGroupId == "[null]" ? null :  objViewInfoEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(conViewInfo.InRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.InRelaTabId = objViewInfoEN.InRelaTabId == "[null]" ? null :  objViewInfoEN.InRelaTabId; //输入数据源表ID
}
if (arrFldSet.Contains(conViewInfo.InSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.InSqlDsTypeId = objViewInfoEN.InSqlDsTypeId == "[null]" ? null :  objViewInfoEN.InSqlDsTypeId; //输入数据源类型
}
if (arrFldSet.Contains(conViewInfo.OutRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.OutRelaTabId = objViewInfoEN.OutRelaTabId == "[null]" ? null :  objViewInfoEN.OutRelaTabId; //输出数据源表ID
}
if (arrFldSet.Contains(conViewInfo.OutSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.OutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId == "[null]" ? null :  objViewInfoEN.OutSqlDsTypeId; //输出数据源类型
}
if (arrFldSet.Contains(conViewInfo.DetailTabType, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.DetailTabType = objViewInfoEN.DetailTabType == "[null]" ? null :  objViewInfoEN.DetailTabType; //DetailTabType
}
if (arrFldSet.Contains(conViewInfo.DetailViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.DetailViewId = objViewInfoEN.DetailViewId == "[null]" ? null :  objViewInfoEN.DetailViewId; //DetailViewId
}
if (arrFldSet.Contains(conViewInfo.MainTabType, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.MainTabType = objViewInfoEN.MainTabType == "[null]" ? null :  objViewInfoEN.MainTabType; //MainTabType
}
if (arrFldSet.Contains(conViewInfo.MainViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.MainViewId = objViewInfoEN.MainViewId == "[null]" ? null :  objViewInfoEN.MainViewId; //MainViewId
}
if (arrFldSet.Contains(conViewInfo.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.GeneCodeDate = objViewInfoEN.GeneCodeDate == "[null]" ? null :  objViewInfoEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(conViewInfo.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.TaskId = objViewInfoEN.TaskId == "[null]" ? null :  objViewInfoEN.TaskId; //任务Id
}
if (arrFldSet.Contains(conViewInfo.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.KeyId4Test = objViewInfoEN.KeyId4Test == "[null]" ? null :  objViewInfoEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(conViewInfo.ViewMasterId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ViewMasterId = objViewInfoEN.ViewMasterId == "[null]" ? null :  objViewInfoEN.ViewMasterId; //界面母版Id
}
if (arrFldSet.Contains(conViewInfo.IsShare, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.IsShare = objViewInfoEN.IsShare; //是否共享
}
if (arrFldSet.Contains(conViewInfo.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.ErrMsg = objViewInfoEN.ErrMsg == "[null]" ? null :  objViewInfoEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conViewInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.UpdDate = objViewInfoEN.UpdDate == "[null]" ? null :  objViewInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewInfo.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.UpdUserId = objViewInfoEN.UpdUserId == "[null]" ? null :  objViewInfoEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conViewInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.Memo = objViewInfoEN.Memo == "[null]" ? null :  objViewInfoEN.Memo; //说明
}
if (arrFldSet.Contains(conViewInfo.RegionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoEN.RegionNum = objViewInfoEN.RegionNum; //区域数
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
 /// <param name = "objViewInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewInfoEN objViewInfoEN)
{
try
{
if (objViewInfoEN.FuncModuleAgcId == "[null]") objViewInfoEN.FuncModuleAgcId = null; //功能模块Id
if (objViewInfoEN.DataBaseName == "[null]") objViewInfoEN.DataBaseName = null; //数据库名
if (objViewInfoEN.KeyForMainTab == "[null]") objViewInfoEN.KeyForMainTab = null; //主表关键字
if (objViewInfoEN.KeyForDetailTab == "[null]") objViewInfoEN.KeyForDetailTab = null; //明细表关键字
if (objViewInfoEN.ViewFunction == "[null]") objViewInfoEN.ViewFunction = null; //界面功能
if (objViewInfoEN.ViewDetail == "[null]") objViewInfoEN.ViewDetail = null; //界面说明
if (objViewInfoEN.DetailTabId == "[null]") objViewInfoEN.DetailTabId = null; //明细表ID
if (objViewInfoEN.MainTabId == "[null]") objViewInfoEN.MainTabId = null; //主表ID
if (objViewInfoEN.ViewGroupId == "[null]") objViewInfoEN.ViewGroupId = null; //界面组ID
if (objViewInfoEN.InRelaTabId == "[null]") objViewInfoEN.InRelaTabId = null; //输入数据源表ID
if (objViewInfoEN.InSqlDsTypeId == "[null]") objViewInfoEN.InSqlDsTypeId = null; //输入数据源类型
if (objViewInfoEN.OutRelaTabId == "[null]") objViewInfoEN.OutRelaTabId = null; //输出数据源表ID
if (objViewInfoEN.OutSqlDsTypeId == "[null]") objViewInfoEN.OutSqlDsTypeId = null; //输出数据源类型
if (objViewInfoEN.DetailTabType == "[null]") objViewInfoEN.DetailTabType = null; //DetailTabType
if (objViewInfoEN.DetailViewId == "[null]") objViewInfoEN.DetailViewId = null; //DetailViewId
if (objViewInfoEN.MainTabType == "[null]") objViewInfoEN.MainTabType = null; //MainTabType
if (objViewInfoEN.MainViewId == "[null]") objViewInfoEN.MainViewId = null; //MainViewId
if (objViewInfoEN.GeneCodeDate == "[null]") objViewInfoEN.GeneCodeDate = null; //生成代码日期
if (objViewInfoEN.TaskId == "[null]") objViewInfoEN.TaskId = null; //任务Id
if (objViewInfoEN.KeyId4Test == "[null]") objViewInfoEN.KeyId4Test = null; //测试关键字Id
if (objViewInfoEN.ViewMasterId == "[null]") objViewInfoEN.ViewMasterId = null; //界面母版Id
if (objViewInfoEN.ErrMsg == "[null]") objViewInfoEN.ErrMsg = null; //错误信息
if (objViewInfoEN.UpdDate == "[null]") objViewInfoEN.UpdDate = null; //修改日期
if (objViewInfoEN.UpdUserId == "[null]") objViewInfoEN.UpdUserId = null; //修改用户Id
if (objViewInfoEN.Memo == "[null]") objViewInfoEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewInfoEN objViewInfoEN)
{
 ViewInfoDA.CheckPropertyNew(objViewInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewInfoEN objViewInfoEN)
{
 ViewInfoDA.CheckProperty4Condition(objViewInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewInfo.ViewId); 
List<clsViewInfoEN> arrObjLst = clsViewInfoBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewInfoEN objViewInfoEN = new clsViewInfoEN()
{
ViewId = "0",
ViewName = "选[界面]..."
};
arrObjLstSel.Insert(0, objViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewInfo.ViewId;
objComboBox.DisplayMember = conViewInfo.ViewName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conViewInfo.ViewId); 
IEnumerable<clsViewInfoEN> arrObjLst = clsViewInfoBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conViewInfo.ViewId;
objDDL.DataTextField = conViewInfo.ViewName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面]...","0");
List<clsViewInfoEN> arrViewInfoObjLst = GetAllViewInfoObjLstCache(strPrjId); 
objDDL.DataValueField = conViewInfo.ViewId;
objDDL.DataTextField = conViewInfo.ViewName;
objDDL.DataSource = arrViewInfoObjLst;
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
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewId");
//if (arrViewInfoObjLstCache == null)
//{
//arrViewInfoObjLstCache = ViewInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewInfoEN GetObjByViewIdCache(string strViewId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel =
arrViewInfoObjLstCache
.Where(x=> x.ViewId == strViewId 
);
if (arrViewInfoObjLst_Sel.Count() == 0)
{
   clsViewInfoEN obj = clsViewInfoBL.GetObjByViewId(strViewId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewNameByViewIdCache(string strViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsViewInfoEN objViewInfo = GetObjByViewIdCache(strViewId, strPrjId);
if (objViewInfo == null) return "";
return objViewInfo.ViewName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewIdCache(string strViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//获取缓存中的对象列表
clsViewInfoEN objViewInfo = GetObjByViewIdCache(strViewId, strPrjId);
if (objViewInfo == null) return "";
return objViewInfo.ViewName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoEN> GetAllViewInfoObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId); 
return arrViewInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewInfoObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:MainTabId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrViewInfoObjLst">需要排序的对象列表</param>
public static List <clsViewInfoEN> GetSubSet4ViewInfoObjLstByMainTabIdCache(string strMainTabId, string strPrjId)
{
   if (string.IsNullOrEmpty(strMainTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
List<clsViewInfoEN> arrViewInfoObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrViewInfoObjLst_Sel1 =
from objViewInfoEN in arrViewInfoObjLstCache
where objViewInfoEN.MainTabId == strMainTabId
select objViewInfoEN;
List <clsViewInfoEN> arrViewInfoObjLst_Sel = new List<clsViewInfoEN>();
foreach (clsViewInfoEN obj in arrViewInfoObjLst_Sel1)
{
arrViewInfoObjLst_Sel.Add(obj);
}
return arrViewInfoObjLst_Sel;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewInfoEN._RefreshTimeLst.Count == 0) return "";
return clsViewInfoEN._RefreshTimeLst[clsViewInfoEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewInfoBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewInfoBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsViewInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewInfoEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewInfoBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewInfo(界面)
 /// 唯一性条件:PrjId_ViewName_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewInfoEN objViewInfoEN)
{
//检测记录是否存在
string strResult = ViewInfoDA.GetUniCondStr(objViewInfoEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strViewId, string strPrjId)
{
if (strInFldName != conViewInfo.ViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewInfo._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewInfo._AttributeName));
throw new Exception(strMsg);
}
var objViewInfo = clsViewInfoBL.GetObjByViewIdCache(strViewId, strPrjId);
if (objViewInfo == null) return "";
return objViewInfo[strOutFldName].ToString();
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
int intRecCount = clsViewInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsViewInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewInfoDA.GetRecCount();
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
int intRecCount = clsViewInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewInfoEN objViewInfoCond)
{
 string strPrjId = objViewInfoCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewInfoBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewInfoEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewInfo._AttributeName)
{
if (objViewInfoCond.IsUpdated(strFldName) == false) continue;
if (objViewInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCond[strFldName].ToString());
}
else
{
if (objViewInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewInfoCond[strFldName]));
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
 List<string> arrList = clsViewInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewInfoDA.SetFldValue(clsViewInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) primary key, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**数据库名*/ 
 strCreateTabCode.Append(" DataBaseName varchar(50) Null, "); 
 // /**主表关键字*/ 
 strCreateTabCode.Append(" KeyForMainTab varchar(50) Null, "); 
 // /**明细表关键字*/ 
 strCreateTabCode.Append(" KeyForDetailTab varchar(50) Null, "); 
 // /**是否需要排序*/ 
 strCreateTabCode.Append(" IsNeedSort bit not Null, "); 
 // /**是否需要转换代码*/ 
 strCreateTabCode.Append(" IsNeedTransCode bit not Null, "); 
 // /**是否需要设置导出字段*/ 
 strCreateTabCode.Append(" IsNeedSetExportFld bit not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**界面功能*/ 
 strCreateTabCode.Append(" ViewFunction varchar(100) Null, "); 
 // /**界面说明*/ 
 strCreateTabCode.Append(" ViewDetail varchar(1000) Null, "); 
 // /**缺省菜单名*/ 
 strCreateTabCode.Append(" DefaMenuName varchar(100) not Null, "); 
 // /**明细表ID*/ 
 strCreateTabCode.Append(" DetailTabId varchar(8) Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**主表ID*/ 
 strCreateTabCode.Append(" MainTabId varchar(8) Null, "); 
 // /**视图中文名*/ 
 strCreateTabCode.Append(" ViewCnName varchar(100) not Null, "); 
 // /**界面组ID*/ 
 strCreateTabCode.Append(" ViewGroupId char(8) Null, "); 
 // /**输入数据源表ID*/ 
 strCreateTabCode.Append(" InRelaTabId char(8) Null, "); 
 // /**输入数据源类型*/ 
 strCreateTabCode.Append(" InSqlDsTypeId char(2) Null, "); 
 // /**输出数据源表ID*/ 
 strCreateTabCode.Append(" OutRelaTabId char(8) Null, "); 
 // /**输出数据源类型*/ 
 strCreateTabCode.Append(" OutSqlDsTypeId char(2) Null, "); 
 // /**DetailTabType*/ 
 strCreateTabCode.Append(" DetailTabType varchar(10) Null, "); 
 // /**DetailViewId*/ 
 strCreateTabCode.Append(" DetailViewId varchar(8) Null, "); 
 // /**MainTabType*/ 
 strCreateTabCode.Append(" MainTabType varchar(10) Null, "); 
 // /**MainViewId*/ 
 strCreateTabCode.Append(" MainViewId varchar(8) Null, "); 
 // /**生成代码日期*/ 
 strCreateTabCode.Append(" GeneCodeDate varchar(20) Null, "); 
 // /**任务Id*/ 
 strCreateTabCode.Append(" TaskId char(16) Null, "); 
 // /**测试关键字Id*/ 
 strCreateTabCode.Append(" KeyId4Test varchar(50) Null, "); 
 // /**界面母版Id*/ 
 strCreateTabCode.Append(" ViewMasterId char(8) Null, "); 
 // /**是否共享*/ 
 strCreateTabCode.Append(" IsShare bit Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**区域数*/ 
 strCreateTabCode.Append(" RegionNum int Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**功能模块名称*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) Null, "); 
 // /**主表*/ 
 strCreateTabCode.Append(" MainTabName varchar(100) Null, "); 
 // /**主表表名Ex*/ 
 strCreateTabCode.Append(" MainTabNameEx varchar(100) Null, "); 
 // /**详细表名Ex*/ 
 strCreateTabCode.Append(" DetailTabNameEx varchar(40) Null, "); 
 // /**详细表*/ 
 strCreateTabCode.Append(" DetailTabName varchar(40) Null, "); 
 // /**界面名称Ex*/ 
 strCreateTabCode.Append(" ViewNameEx varchar(100) not Null, "); 
 // /**In表名*/ 
 strCreateTabCode.Append(" InRelaTabName varchar(100) Null, "); 
 // /**Out表名*/ 
 strCreateTabCode.Append(" OutRelaTabName varchar(100) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**视图中文名*/ 
 strCreateTabCode.Append(" ViewCnNameEx varchar(100) not Null, "); 
 // /**Cm工程名s*/ 
 strCreateTabCode.Append(" CmPrjNames varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面(ViewInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewInfo : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsViewInfoBL.ReFreshThisCache(strPrjId);
}
}

}