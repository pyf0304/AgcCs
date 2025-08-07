
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupBL
 表名:ViewGroup(00050134)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:59
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
public static class  clsViewGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewGroupEN GetObj(this K_ViewGroupId_ViewGroup myKey)
{
clsViewGroupEN objViewGroupEN = clsViewGroupBL.ViewGroupDA.GetObjByViewGroupId(myKey.Value);
return objViewGroupEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewGroupEN.ViewGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!界面组名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsViewGroupBL.AddNewRecord)", objViewGroupEN.ViewGroupName,objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewGroupBL.ViewGroupDA.AddNewRecordBySQL2(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewGroupEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewGroupEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面组名称(ViewGroupName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objViewGroupEN.ViewGroupName, objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewGroupEN.AddNewRecord();
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!界面组名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsViewGroupBL.AddNewRecordWithMaxId)", objViewGroupEN.ViewGroupName,objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true || clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
     objViewGroupEN.ViewGroupId = clsViewGroupBL.GetMaxStrIdByPrefix_S(objViewGroupEN.PrjId);
 }
string strViewGroupId = clsViewGroupBL.ViewGroupDA.AddNewRecordBySQL2WithReturnKey(objViewGroupEN);
     objViewGroupEN.ViewGroupId = strViewGroupId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
}
return strViewGroupId;
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewGroupEN.ViewGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!界面组名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsViewGroupBL.AddNewRecordWithReturnKey)", objViewGroupEN.ViewGroupName,objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewGroupBL.ViewGroupDA.AddNewRecordBySQL2WithReturnKey(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetViewGroupId(this clsViewGroupEN objViewGroupEN, string strViewGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, conViewGroup.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, conViewGroup.ViewGroupId);
}
objViewGroupEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ViewGroupId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ViewGroupId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ViewGroupId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetViewGroupName(this clsViewGroupEN objViewGroupEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, conViewGroup.ViewGroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupName, 30, conViewGroup.ViewGroupName);
}
objViewGroupEN.ViewGroupName = strViewGroupName; //界面组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ViewGroupName) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ViewGroupName, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ViewGroupName] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetInSqlDsTypeId(this clsViewGroupEN objViewGroupEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
}
objViewGroupEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.InSqlDsTypeId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.InSqlDsTypeId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.InSqlDsTypeId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetInRelaTabId(this clsViewGroupEN objViewGroupEN, string strInRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, conViewGroup.InRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, conViewGroup.InRelaTabId);
}
objViewGroupEN.InRelaTabId = strInRelaTabId; //输入数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.InRelaTabId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.InRelaTabId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.InRelaTabId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetOutSqlDsTypeId(this clsViewGroupEN objViewGroupEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
}
objViewGroupEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.OutSqlDsTypeId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.OutSqlDsTypeId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.OutSqlDsTypeId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetOutRelaTabId(this clsViewGroupEN objViewGroupEN, string strOutRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOutRelaTabId, conViewGroup.OutRelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, conViewGroup.OutRelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, conViewGroup.OutRelaTabId);
}
objViewGroupEN.OutRelaTabId = strOutRelaTabId; //输出数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.OutRelaTabId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.OutRelaTabId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.OutRelaTabId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetPrjDomain(this clsViewGroupEN objViewGroupEN, string strPrjDomain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, conViewGroup.PrjDomain);
}
objViewGroupEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.PrjDomain) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.PrjDomain, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.PrjDomain] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetActionPath(this clsViewGroupEN objViewGroupEN, string strActionPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionPath, conViewGroup.ActionPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActionPath, 100, conViewGroup.ActionPath);
}
objViewGroupEN.ActionPath = strActionPath; //Action路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ActionPath) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ActionPath, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ActionPath] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetPrjId(this clsViewGroupEN objViewGroupEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewGroup.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewGroup.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewGroup.PrjId);
}
objViewGroupEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.PrjId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.PrjId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.PrjId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetUserId(this clsViewGroupEN objViewGroupEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conViewGroup.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conViewGroup.UserId);
}
objViewGroupEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.UserId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.UserId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.UserId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetUpdDate(this clsViewGroupEN objViewGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewGroup.UpdDate);
}
objViewGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.UpdDate) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.UpdDate, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.UpdDate] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetMemo(this clsViewGroupEN objViewGroupEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewGroup.Memo);
}
objViewGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.Memo) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.Memo, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.Memo] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetTableNameForProg(this clsViewGroupEN objViewGroupEN, string strTableNameForProg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameForProg, 50, conViewGroup.TableNameForProg);
}
objViewGroupEN.TableNameForProg = strTableNameForProg; //编程用表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.TableNameForProg) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.TableNameForProg, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.TableNameForProg] = strComparisonOp;
}
}
return objViewGroupEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewGroupEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewGroupEN objViewGroupEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewGroupEN.CheckPropertyNew();
clsViewGroupEN objViewGroupCond = new clsViewGroupEN();
string strCondition = objViewGroupCond
.SetViewGroupId(objViewGroupEN.ViewGroupId, "<>")
.SetViewGroupName(objViewGroupEN.ViewGroupName, "=")
.SetPrjId(objViewGroupEN.PrjId, "=")
.GetCombineCondition();
objViewGroupEN._IsCheckProperty = true;
bool bolIsExist = clsViewGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewGroupName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewGroupEN.Update();
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
 /// <param name = "objViewGroup">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewGroupEN objViewGroup)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewGroupEN objViewGroupCond = new clsViewGroupEN();
string strCondition = objViewGroupCond
.SetViewGroupName(objViewGroup.ViewGroupName, "=")
.SetPrjId(objViewGroup.PrjId, "=")
.GetCombineCondition();
objViewGroup._IsCheckProperty = true;
bool bolIsExist = clsViewGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewGroup.ViewGroupId = clsViewGroupBL.GetFirstID_S(strCondition);
objViewGroup.UpdateWithCondition(strCondition);
}
else
{
objViewGroup.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewGroupEN objViewGroupEN)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewGroupBL.ViewGroupDA.UpdateBySql2(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewGroupEN objViewGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewGroupBL.ViewGroupDA.UpdateBySql2(objViewGroupEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewGroupEN objViewGroupEN, string strWhereCond)
{
try
{
bool bolResult = clsViewGroupBL.ViewGroupDA.UpdateBySqlWithCondition(objViewGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewGroupEN objViewGroupEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewGroupBL.ViewGroupDA.UpdateBySqlWithConditionTransaction(objViewGroupEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewGroupEN objViewGroupEN)
{
try
{
int intRecNum = clsViewGroupBL.ViewGroupDA.DelRecord(objViewGroupEN.ViewGroupId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupENS">源对象</param>
 /// <param name = "objViewGroupENT">目标对象</param>
 public static void CopyTo(this clsViewGroupEN objViewGroupENS, clsViewGroupEN objViewGroupENT)
{
try
{
objViewGroupENT.ViewGroupId = objViewGroupENS.ViewGroupId; //界面组ID
objViewGroupENT.ViewGroupName = objViewGroupENS.ViewGroupName; //界面组名称
objViewGroupENT.InSqlDsTypeId = objViewGroupENS.InSqlDsTypeId; //输入数据源类型
objViewGroupENT.InRelaTabId = objViewGroupENS.InRelaTabId; //输入数据源表ID
objViewGroupENT.OutSqlDsTypeId = objViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objViewGroupENT.OutRelaTabId = objViewGroupENS.OutRelaTabId; //输出数据源表ID
objViewGroupENT.PrjDomain = objViewGroupENS.PrjDomain; //域/包名
objViewGroupENT.ActionPath = objViewGroupENS.ActionPath; //Action路径
objViewGroupENT.PrjId = objViewGroupENS.PrjId; //工程Id
objViewGroupENT.UserId = objViewGroupENS.UserId; //用户Id
objViewGroupENT.UpdDate = objViewGroupENS.UpdDate; //修改日期
objViewGroupENT.Memo = objViewGroupENS.Memo; //说明
objViewGroupENT.TableNameForProg = objViewGroupENS.TableNameForProg; //编程用表名
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
 /// <param name = "objViewGroupENS">源对象</param>
 /// <returns>目标对象=>clsViewGroupEN:objViewGroupENT</returns>
 public static clsViewGroupEN CopyTo(this clsViewGroupEN objViewGroupENS)
{
try
{
 clsViewGroupEN objViewGroupENT = new clsViewGroupEN()
{
ViewGroupId = objViewGroupENS.ViewGroupId, //界面组ID
ViewGroupName = objViewGroupENS.ViewGroupName, //界面组名称
InSqlDsTypeId = objViewGroupENS.InSqlDsTypeId, //输入数据源类型
InRelaTabId = objViewGroupENS.InRelaTabId, //输入数据源表ID
OutSqlDsTypeId = objViewGroupENS.OutSqlDsTypeId, //输出数据源类型
OutRelaTabId = objViewGroupENS.OutRelaTabId, //输出数据源表ID
PrjDomain = objViewGroupENS.PrjDomain, //域/包名
ActionPath = objViewGroupENS.ActionPath, //Action路径
PrjId = objViewGroupENS.PrjId, //工程Id
UserId = objViewGroupENS.UserId, //用户Id
UpdDate = objViewGroupENS.UpdDate, //修改日期
Memo = objViewGroupENS.Memo, //说明
TableNameForProg = objViewGroupENS.TableNameForProg, //编程用表名
};
 return objViewGroupENT;
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
public static void CheckPropertyNew(this clsViewGroupEN objViewGroupEN)
{
 clsViewGroupBL.ViewGroupDA.CheckPropertyNew(objViewGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewGroupEN objViewGroupEN)
{
 clsViewGroupBL.ViewGroupDA.CheckProperty4Condition(objViewGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewGroupEN objViewGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewGroupCond.IsUpdated(conViewGroup.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objViewGroupCond.dicFldComparisonOp[conViewGroup.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ViewGroupId, objViewGroupCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.ViewGroupName) == true)
{
string strComparisonOpViewGroupName = objViewGroupCond.dicFldComparisonOp[conViewGroup.ViewGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ViewGroupName, objViewGroupCond.ViewGroupName, strComparisonOpViewGroupName);
}
if (objViewGroupCond.IsUpdated(conViewGroup.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objViewGroupCond.dicFldComparisonOp[conViewGroup.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.InSqlDsTypeId, objViewGroupCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.InRelaTabId) == true)
{
string strComparisonOpInRelaTabId = objViewGroupCond.dicFldComparisonOp[conViewGroup.InRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.InRelaTabId, objViewGroupCond.InRelaTabId, strComparisonOpInRelaTabId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objViewGroupCond.dicFldComparisonOp[conViewGroup.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.OutSqlDsTypeId, objViewGroupCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.OutRelaTabId) == true)
{
string strComparisonOpOutRelaTabId = objViewGroupCond.dicFldComparisonOp[conViewGroup.OutRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.OutRelaTabId, objViewGroupCond.OutRelaTabId, strComparisonOpOutRelaTabId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objViewGroupCond.dicFldComparisonOp[conViewGroup.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.PrjDomain, objViewGroupCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objViewGroupCond.IsUpdated(conViewGroup.ActionPath) == true)
{
string strComparisonOpActionPath = objViewGroupCond.dicFldComparisonOp[conViewGroup.ActionPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ActionPath, objViewGroupCond.ActionPath, strComparisonOpActionPath);
}
if (objViewGroupCond.IsUpdated(conViewGroup.PrjId) == true)
{
string strComparisonOpPrjId = objViewGroupCond.dicFldComparisonOp[conViewGroup.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.PrjId, objViewGroupCond.PrjId, strComparisonOpPrjId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.UserId) == true)
{
string strComparisonOpUserId = objViewGroupCond.dicFldComparisonOp[conViewGroup.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.UserId, objViewGroupCond.UserId, strComparisonOpUserId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewGroupCond.dicFldComparisonOp[conViewGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.UpdDate, objViewGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewGroupCond.IsUpdated(conViewGroup.Memo) == true)
{
string strComparisonOpMemo = objViewGroupCond.dicFldComparisonOp[conViewGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.Memo, objViewGroupCond.Memo, strComparisonOpMemo);
}
if (objViewGroupCond.IsUpdated(conViewGroup.TableNameForProg) == true)
{
string strComparisonOpTableNameForProg = objViewGroupCond.dicFldComparisonOp[conViewGroup.TableNameForProg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.TableNameForProg, objViewGroupCond.TableNameForProg, strComparisonOpTableNameForProg);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewGroup(界面组), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewGroupName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewGroupEN objViewGroupEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewGroupEN == null) return true;
if (objViewGroupEN.ViewGroupId == null || objViewGroupEN.ViewGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
if (clsViewGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewGroupId !=  '{0}'", objViewGroupEN.ViewGroupId);
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
if (clsViewGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewGroup(界面组), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewGroupName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewGroupEN objViewGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewGroupEN == null) return "";
if (objViewGroupEN.ViewGroupId == null || objViewGroupEN.ViewGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewGroupId !=  '{0}'", objViewGroupEN.ViewGroupId);
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewGroup
{
public virtual bool UpdRelaTabDate(string strViewGroupId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面组(ViewGroup)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewGroupBL
{
public static RelatedActions_ViewGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewGroupDA ViewGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewGroupDA();
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
 public clsViewGroupBL()
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
if (string.IsNullOrEmpty(clsViewGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewGroupEN._ConnectString);
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
public static DataTable GetDataTable_ViewGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewGroupDA.GetDataTable_ViewGroup(strWhereCond);
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
objDT = ViewGroupDA.GetDataTable(strWhereCond);
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
objDT = ViewGroupDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewGroupDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewGroupDA.GetDataTable_Top(objTopPara);
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
objDT = ViewGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewGroupEN> GetObjLstByViewGroupIdLst(List<string> arrViewGroupIdLst)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewGroupIdLst, true);
 string strWhereCond = string.Format("ViewGroupId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewGroupEN> GetObjLstByViewGroupIdLstCache(List<string> arrViewGroupIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel =
arrViewGroupObjLstCache
.Where(x => arrViewGroupIdLst.Contains(x.ViewGroupId));
return arrViewGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetObjLst(string strWhereCond)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
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
public static List<clsViewGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewGroupEN> GetSubObjLstCache(clsViewGroupEN objViewGroupCond)
{
 string strPrjId = objViewGroupCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewGroupBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewGroupEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewGroup._AttributeName)
{
if (objViewGroupCond.IsUpdated(strFldName) == false) continue;
if (objViewGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupCond[strFldName].ToString());
}
else
{
if (objViewGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewGroupCond[strFldName]));
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
public static List<clsViewGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
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
public static List<clsViewGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
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
List<clsViewGroupEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
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
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
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
public static List<clsViewGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
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
public static List<clsViewGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewGroupEN> arrObjLst = new List<clsViewGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupEN objViewGroupEN = new clsViewGroupEN();
try
{
objViewGroupEN.ViewGroupId = objRow[conViewGroup.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupEN.ViewGroupName = objRow[conViewGroup.ViewGroupName].ToString().Trim(); //界面组名称
objViewGroupEN.InSqlDsTypeId = objRow[conViewGroup.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewGroupEN.InRelaTabId = objRow[conViewGroup.InRelaTabId] == DBNull.Value ? null : objRow[conViewGroup.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewGroupEN.OutSqlDsTypeId = objRow[conViewGroup.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewGroup.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewGroupEN.OutRelaTabId = objRow[conViewGroup.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewGroupEN.PrjDomain = objRow[conViewGroup.PrjDomain] == DBNull.Value ? null : objRow[conViewGroup.PrjDomain].ToString().Trim(); //域/包名
objViewGroupEN.ActionPath = objRow[conViewGroup.ActionPath].ToString().Trim(); //Action路径
objViewGroupEN.PrjId = objRow[conViewGroup.PrjId].ToString().Trim(); //工程Id
objViewGroupEN.UserId = objRow[conViewGroup.UserId].ToString().Trim(); //用户Id
objViewGroupEN.UpdDate = objRow[conViewGroup.UpdDate] == DBNull.Value ? null : objRow[conViewGroup.UpdDate].ToString().Trim(); //修改日期
objViewGroupEN.Memo = objRow[conViewGroup.Memo] == DBNull.Value ? null : objRow[conViewGroup.Memo].ToString().Trim(); //说明
objViewGroupEN.TableNameForProg = objRow[conViewGroup.TableNameForProg] == DBNull.Value ? null : objRow[conViewGroup.TableNameForProg].ToString().Trim(); //编程用表名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupEN.ViewGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewGroup(ref clsViewGroupEN objViewGroupEN)
{
bool bolResult = ViewGroupDA.GetViewGroup(ref objViewGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
if (strViewGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewGroupId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewGroupEN objViewGroupEN = ViewGroupDA.GetObjByViewGroupId(strViewGroupId);
return objViewGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewGroupEN objViewGroupEN = ViewGroupDA.GetFirstObj(strWhereCond);
 return objViewGroupEN;
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
public static clsViewGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewGroupEN objViewGroupEN = ViewGroupDA.GetObjByDataRow(objRow);
 return objViewGroupEN;
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
public static clsViewGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewGroupEN objViewGroupEN = ViewGroupDA.GetObjByDataRow(objRow);
 return objViewGroupEN;
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
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <param name = "lstViewGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewGroupEN GetObjByViewGroupIdFromList(string strViewGroupId, List<clsViewGroupEN> lstViewGroupObjLst)
{
foreach (clsViewGroupEN objViewGroupEN in lstViewGroupObjLst)
{
if (objViewGroupEN.ViewGroupId == strViewGroupId)
{
return objViewGroupEN;
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
 string strMaxViewGroupId;
 try
 {
 strMaxViewGroupId = new clsViewGroupDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxViewGroupId;
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
 string strViewGroupId;
 try
 {
 strViewGroupId = new clsViewGroupDA().GetFirstID(strWhereCond);
 return strViewGroupId;
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
 arrList = ViewGroupDA.GetID(strWhereCond);
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
bool bolIsExist = ViewGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewGroupId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewGroupId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ViewGroupDA.IsExist(strViewGroupId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewGroupId">界面组ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewGroupId, string strOpUser)
{
clsViewGroupEN objViewGroupEN = clsViewGroupBL.GetObjByViewGroupId(strViewGroupId);
objViewGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsViewGroupBL.UpdateBySql2(objViewGroupEN);
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
 bolIsExist = clsViewGroupDA.IsExistTable();
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
 bolIsExist = ViewGroupDA.IsExistTable(strTabName);
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewGroupEN.ViewGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面组名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsViewGroupBL.AddNewRecordBySql2)", objViewGroupEN.ViewGroupName,objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewGroupDA.AddNewRecordBySQL2(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewGroupEN objViewGroupEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewGroupBL.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewGroupEN.ViewGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面组名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsViewGroupBL.AddNewRecordBySql2WithReturnKey)", objViewGroupEN.ViewGroupName,objViewGroupEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewGroupDA.AddNewRecordBySQL2WithReturnKey(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewGroupEN objViewGroupEN)
{
try
{
bool bolResult = ViewGroupDA.Update(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewGroupEN objViewGroupEN)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewGroupDA.UpdateBySql2(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupBL.ReFreshCache(objViewGroupEN.PrjId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
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
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewGroupId)
{
try
{
 clsViewGroupEN objViewGroupEN = clsViewGroupBL.GetObjByViewGroupId(strViewGroupId);

if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(objViewGroupEN.ViewGroupId, "SetUpdDate");
}
if (objViewGroupEN != null)
{
int intRecNum = ViewGroupDA.DelRecord(strViewGroupId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewGroupEN.PrjId);
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
/// <param name="strViewGroupId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewGroupId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewGroupDA.GetSpecSQLObj();
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
//删除与表:[ViewGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewGroup.ViewGroupId,
//strViewGroupId);
//        clsViewGroupBL.DelViewGroupsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewGroupBL.DelRecord(strViewGroupId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewGroupBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewGroupId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewGroupBL.relatedActions != null)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(strViewGroupId, "UpdRelaTabDate");
}
bool bolResult = ViewGroupDA.DelRecord(strViewGroupId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewGroupIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewGroups(List<string> arrViewGroupIdLst)
{
if (arrViewGroupIdLst.Count == 0) return 0;
try
{
if (clsViewGroupBL.relatedActions != null)
{
foreach (var strViewGroupId in arrViewGroupIdLst)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(strViewGroupId, "UpdRelaTabDate");
}
}
 clsViewGroupEN objViewGroupEN = clsViewGroupBL.GetObjByViewGroupId(arrViewGroupIdLst[0]);
int intDelRecNum = ViewGroupDA.DelViewGroup(arrViewGroupIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewGroupEN.PrjId);
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
public static int DelViewGroupsByCond(string strWhereCond)
{
try
{
if (clsViewGroupBL.relatedActions != null)
{
List<string> arrViewGroupId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewGroupId in arrViewGroupId)
{
clsViewGroupBL.relatedActions.UpdRelaTabDate(strViewGroupId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewGroup.PrjId, strWhereCond);
int intRecNum = ViewGroupDA.DelViewGroup(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewGroup]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewGroupId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewGroupId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewGroupDA.GetSpecSQLObj();
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
//删除与表:[ViewGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewGroupBL.DelRecord(strViewGroupId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewGroupBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewGroupENS">源对象</param>
 /// <param name = "objViewGroupENT">目标对象</param>
 public static void CopyTo(clsViewGroupEN objViewGroupENS, clsViewGroupEN objViewGroupENT)
{
try
{
objViewGroupENT.ViewGroupId = objViewGroupENS.ViewGroupId; //界面组ID
objViewGroupENT.ViewGroupName = objViewGroupENS.ViewGroupName; //界面组名称
objViewGroupENT.InSqlDsTypeId = objViewGroupENS.InSqlDsTypeId; //输入数据源类型
objViewGroupENT.InRelaTabId = objViewGroupENS.InRelaTabId; //输入数据源表ID
objViewGroupENT.OutSqlDsTypeId = objViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objViewGroupENT.OutRelaTabId = objViewGroupENS.OutRelaTabId; //输出数据源表ID
objViewGroupENT.PrjDomain = objViewGroupENS.PrjDomain; //域/包名
objViewGroupENT.ActionPath = objViewGroupENS.ActionPath; //Action路径
objViewGroupENT.PrjId = objViewGroupENS.PrjId; //工程Id
objViewGroupENT.UserId = objViewGroupENS.UserId; //用户Id
objViewGroupENT.UpdDate = objViewGroupENS.UpdDate; //修改日期
objViewGroupENT.Memo = objViewGroupENS.Memo; //说明
objViewGroupENT.TableNameForProg = objViewGroupENS.TableNameForProg; //编程用表名
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
 /// <param name = "objViewGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsViewGroupEN objViewGroupEN)
{
try
{
objViewGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewGroup.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.ViewGroupId = objViewGroupEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(conViewGroup.ViewGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.ViewGroupName = objViewGroupEN.ViewGroupName; //界面组名称
}
if (arrFldSet.Contains(conViewGroup.InSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.InSqlDsTypeId = objViewGroupEN.InSqlDsTypeId == "[null]" ? null :  objViewGroupEN.InSqlDsTypeId; //输入数据源类型
}
if (arrFldSet.Contains(conViewGroup.InRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.InRelaTabId = objViewGroupEN.InRelaTabId == "[null]" ? null :  objViewGroupEN.InRelaTabId; //输入数据源表ID
}
if (arrFldSet.Contains(conViewGroup.OutSqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.OutSqlDsTypeId = objViewGroupEN.OutSqlDsTypeId == "[null]" ? null :  objViewGroupEN.OutSqlDsTypeId; //输出数据源类型
}
if (arrFldSet.Contains(conViewGroup.OutRelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.OutRelaTabId = objViewGroupEN.OutRelaTabId; //输出数据源表ID
}
if (arrFldSet.Contains(conViewGroup.PrjDomain, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.PrjDomain = objViewGroupEN.PrjDomain == "[null]" ? null :  objViewGroupEN.PrjDomain; //域/包名
}
if (arrFldSet.Contains(conViewGroup.ActionPath, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.ActionPath = objViewGroupEN.ActionPath; //Action路径
}
if (arrFldSet.Contains(conViewGroup.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.PrjId = objViewGroupEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewGroup.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.UserId = objViewGroupEN.UserId; //用户Id
}
if (arrFldSet.Contains(conViewGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.UpdDate = objViewGroupEN.UpdDate == "[null]" ? null :  objViewGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewGroup.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.Memo = objViewGroupEN.Memo == "[null]" ? null :  objViewGroupEN.Memo; //说明
}
if (arrFldSet.Contains(conViewGroup.TableNameForProg, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupEN.TableNameForProg = objViewGroupEN.TableNameForProg == "[null]" ? null :  objViewGroupEN.TableNameForProg; //编程用表名
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
 /// <param name = "objViewGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewGroupEN objViewGroupEN)
{
try
{
if (objViewGroupEN.InSqlDsTypeId == "[null]") objViewGroupEN.InSqlDsTypeId = null; //输入数据源类型
if (objViewGroupEN.InRelaTabId == "[null]") objViewGroupEN.InRelaTabId = null; //输入数据源表ID
if (objViewGroupEN.OutSqlDsTypeId == "[null]") objViewGroupEN.OutSqlDsTypeId = null; //输出数据源类型
if (objViewGroupEN.PrjDomain == "[null]") objViewGroupEN.PrjDomain = null; //域/包名
if (objViewGroupEN.UpdDate == "[null]") objViewGroupEN.UpdDate = null; //修改日期
if (objViewGroupEN.Memo == "[null]") objViewGroupEN.Memo = null; //说明
if (objViewGroupEN.TableNameForProg == "[null]") objViewGroupEN.TableNameForProg = null; //编程用表名
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
public static void CheckPropertyNew(clsViewGroupEN objViewGroupEN)
{
 ViewGroupDA.CheckPropertyNew(objViewGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewGroupEN objViewGroupEN)
{
 ViewGroupDA.CheckProperty4Condition(objViewGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewGroup.ViewGroupId); 
List<clsViewGroupEN> arrObjLst = clsViewGroupBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewGroupEN objViewGroupEN = new clsViewGroupEN()
{
ViewGroupId = "0",
ViewGroupName = "选[界面组]..."
};
arrObjLstSel.Insert(0, objViewGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewGroup.ViewGroupId;
objComboBox.DisplayMember = conViewGroup.ViewGroupName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面组]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conViewGroup.ViewGroupId); 
IEnumerable<clsViewGroupEN> arrObjLst = clsViewGroupBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conViewGroup.ViewGroupId;
objDDL.DataTextField = conViewGroup.ViewGroupName;
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
public static void BindDdl_ViewGroupIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面组]...","0");
List<clsViewGroupEN> arrViewGroupObjLst = GetAllViewGroupObjLstCache(strPrjId); 
objDDL.DataValueField = conViewGroup.ViewGroupId;
objDDL.DataTextField = conViewGroup.ViewGroupName;
objDDL.DataSource = arrViewGroupObjLst;
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
if (clsViewGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewGroupBL没有刷新缓存机制(clsViewGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewGroupId");
//if (arrViewGroupObjLstCache == null)
//{
//arrViewGroupObjLstCache = ViewGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewGroupEN GetObjByViewGroupIdCache(string strViewGroupId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel =
arrViewGroupObjLstCache
.Where(x=> x.ViewGroupId == strViewGroupId 
);
if (arrViewGroupObjLst_Sel.Count() == 0)
{
   clsViewGroupEN obj = clsViewGroupBL.GetObjByViewGroupId(strViewGroupId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewGroupId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewGroupNameByViewGroupIdCache(string strViewGroupId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//获取缓存中的对象列表
clsViewGroupEN objViewGroup = GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objViewGroup == null) return "";
return objViewGroup.ViewGroupName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewGroupIdCache(string strViewGroupId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//获取缓存中的对象列表
clsViewGroupEN objViewGroup = GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objViewGroup == null) return "";
return objViewGroup.ViewGroupName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupEN> GetAllViewGroupObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId); 
return arrViewGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewGroupObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewGroupEN._RefreshTimeLst.Count == 0) return "";
return clsViewGroupEN._RefreshTimeLst[clsViewGroupEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewGroupBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewGroupBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewGroup(界面组)
 /// 唯一性条件:ViewGroupName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewGroupEN objViewGroupEN)
{
//检测记录是否存在
string strResult = ViewGroupDA.GetUniCondStr(objViewGroupEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strViewGroupId, string strPrjId)
{
if (strInFldName != conViewGroup.ViewGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewGroup._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewGroup._AttributeName));
throw new Exception(strMsg);
}
var objViewGroup = clsViewGroupBL.GetObjByViewGroupIdCache(strViewGroupId, strPrjId);
if (objViewGroup == null) return "";
return objViewGroup[strOutFldName].ToString();
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
int intRecCount = clsViewGroupDA.GetRecCount(strTabName);
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
int intRecCount = clsViewGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewGroupDA.GetRecCount();
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
int intRecCount = clsViewGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewGroupEN objViewGroupCond)
{
 string strPrjId = objViewGroupCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewGroupBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewGroupEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewGroup._AttributeName)
{
if (objViewGroupCond.IsUpdated(strFldName) == false) continue;
if (objViewGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupCond[strFldName].ToString());
}
else
{
if (objViewGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewGroupCond[strFldName]));
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
 List<string> arrList = clsViewGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewGroupDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewGroupDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewGroupDA.SetFldValue(clsViewGroupEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewGroupDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewGroupDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewGroupDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewGroupDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewGroup] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面组ID*/ 
 strCreateTabCode.Append(" ViewGroupId char(8) primary key, "); 
 // /**界面组名称*/ 
 strCreateTabCode.Append(" ViewGroupName varchar(30) not Null, "); 
 // /**输入数据源类型*/ 
 strCreateTabCode.Append(" InSqlDsTypeId char(2) Null, "); 
 // /**输入数据源表ID*/ 
 strCreateTabCode.Append(" InRelaTabId char(8) Null, "); 
 // /**输出数据源类型*/ 
 strCreateTabCode.Append(" OutSqlDsTypeId char(2) Null, "); 
 // /**输出数据源表ID*/ 
 strCreateTabCode.Append(" OutRelaTabId char(8) not Null, "); 
 // /**域/包名*/ 
 strCreateTabCode.Append(" PrjDomain varchar(128) Null, "); 
 // /**Action路径*/ 
 strCreateTabCode.Append(" ActionPath varchar(100) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**编程用表名*/ 
 strCreateTabCode.Append(" TableNameForProg varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面组(ViewGroup)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewGroup : clsCommFun4BLV2
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
clsViewGroupBL.ReFreshThisCache(strPrjId);
}
}

}