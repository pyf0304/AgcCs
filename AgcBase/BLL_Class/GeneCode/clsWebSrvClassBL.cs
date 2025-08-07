
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvClassBL
 表名:WebSrvClass(00050344)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsWebSrvClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvClassEN GetObj(this K_WebSrvClassId_WebSrvClass myKey)
{
clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.WebSrvClassDA.GetObjByWebSrvClassId(myKey.Value);
return objWebSrvClassEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvClassEN) == false)
{
var strMsg = string.Format("记录已经存在!类名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsWebSrvClassBL.AddNewRecord)", objWebSrvClassEN.ClsName,objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
bool bolResult = clsWebSrvClassBL.WebSrvClassDA.AddNewRecordBySQL2(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
public static bool AddRecordEx(this clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objWebSrvClassEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objWebSrvClassEN.CheckUniqueness() == false)
{
strMsg = string.Format("(类名(ClsName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objWebSrvClassEN.ClsName, objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objWebSrvClassEN.AddNewRecord();
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvClassEN) == false)
{
var strMsg = string.Format("记录已经存在!类名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsWebSrvClassBL.AddNewRecordWithMaxId)", objWebSrvClassEN.ClsName,objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
string strWebSrvClassId = clsWebSrvClassBL.WebSrvClassDA.AddNewRecordBySQL2WithReturnKey(objWebSrvClassEN);
     objWebSrvClassEN.WebSrvClassId = strWebSrvClassId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
}
return strWebSrvClassId;
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvClassEN) == false)
{
var strMsg = string.Format("记录已经存在!类名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsWebSrvClassBL.AddNewRecordWithReturnKey)", objWebSrvClassEN.ClsName,objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
string strKey = clsWebSrvClassBL.WebSrvClassDA.AddNewRecordBySQL2WithReturnKey(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetWebSrvClassId(this clsWebSrvClassEN objWebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, conWebSrvClass.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, conWebSrvClass.WebSrvClassId);
}
objWebSrvClassEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.WebSrvClassId) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.WebSrvClassId, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.WebSrvClassId] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetNameSpace(this clsWebSrvClassEN objWebSrvClassEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, conWebSrvClass.NameSpace);
}
objWebSrvClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.NameSpace) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.NameSpace, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.NameSpace] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetWebSrvUrl(this clsWebSrvClassEN objWebSrvClassEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, conWebSrvClass.WebSrvUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, conWebSrvClass.WebSrvUrl);
}
objWebSrvClassEN.WebSrvUrl = strWebSrvUrl; //WebSrv地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.WebSrvUrl) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.WebSrvUrl, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.WebSrvUrl] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetPageName(this clsWebSrvClassEN objWebSrvClassEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPageName, conWebSrvClass.PageName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, conWebSrvClass.PageName);
}
objWebSrvClassEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.PageName) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.PageName, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.PageName] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetFuncModuleAgcId(this clsWebSrvClassEN objWebSrvClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conWebSrvClass.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conWebSrvClass.FuncModuleAgcId);
}
objWebSrvClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.FuncModuleAgcId) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetIsNeedGene(this clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objWebSrvClassEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.IsNeedGene) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.IsNeedGene, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.IsNeedGene] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetPrjId(this clsWebSrvClassEN objWebSrvClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conWebSrvClass.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conWebSrvClass.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conWebSrvClass.PrjId);
}
objWebSrvClassEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.PrjId) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.PrjId, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.PrjId] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetUpdDate(this clsWebSrvClassEN objWebSrvClassEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWebSrvClass.UpdDate);
}
objWebSrvClassEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.UpdDate) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.UpdDate, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.UpdDate] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetUpdUser(this clsWebSrvClassEN objWebSrvClassEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conWebSrvClass.UpdUser);
}
objWebSrvClassEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.UpdUser) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.UpdUser, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.UpdUser] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetMemo(this clsWebSrvClassEN objWebSrvClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWebSrvClass.Memo);
}
objWebSrvClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.Memo) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.Memo, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.Memo] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetCodeTypeId(this clsWebSrvClassEN objWebSrvClassEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conWebSrvClass.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conWebSrvClass.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conWebSrvClass.CodeTypeId);
}
objWebSrvClassEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.CodeTypeId) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.CodeTypeId, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.CodeTypeId] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvClassEN SetClsName(this clsWebSrvClassEN objWebSrvClassEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, conWebSrvClass.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conWebSrvClass.ClsName);
}
objWebSrvClassEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvClassEN.dicFldComparisonOp.ContainsKey(conWebSrvClass.ClsName) == false)
{
objWebSrvClassEN.dicFldComparisonOp.Add(conWebSrvClass.ClsName, strComparisonOp);
}
else
{
objWebSrvClassEN.dicFldComparisonOp[conWebSrvClass.ClsName] = strComparisonOp;
}
}
return objWebSrvClassEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsWebSrvClassEN objWebSrvClassEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objWebSrvClassEN.CheckPropertyNew();
clsWebSrvClassEN objWebSrvClassCond = new clsWebSrvClassEN();
string strCondition = objWebSrvClassCond
.SetWebSrvClassId(objWebSrvClassEN.WebSrvClassId, "<>")
.SetClsName(objWebSrvClassEN.ClsName, "=")
.SetPrjId(objWebSrvClassEN.PrjId, "=")
.GetCombineCondition();
objWebSrvClassEN._IsCheckProperty = true;
bool bolIsExist = clsWebSrvClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClsName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objWebSrvClassEN.Update();
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
 /// <param name = "objWebSrvClass">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsWebSrvClassEN objWebSrvClass)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsWebSrvClassEN objWebSrvClassCond = new clsWebSrvClassEN();
string strCondition = objWebSrvClassCond
.SetClsName(objWebSrvClass.ClsName, "=")
.SetPrjId(objWebSrvClass.PrjId, "=")
.GetCombineCondition();
objWebSrvClass._IsCheckProperty = true;
bool bolIsExist = clsWebSrvClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objWebSrvClass.WebSrvClassId = clsWebSrvClassBL.GetFirstID_S(strCondition);
objWebSrvClass.UpdateWithCondition(strCondition);
}
else
{
objWebSrvClass.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
objWebSrvClass.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvClassEN objWebSrvClassEN)
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebSrvClassBL.WebSrvClassDA.UpdateBySql2(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvClassEN objWebSrvClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebSrvClassBL.WebSrvClassDA.UpdateBySql2(objWebSrvClassEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvClassEN objWebSrvClassEN, string strWhereCond)
{
try
{
bool bolResult = clsWebSrvClassBL.WebSrvClassDA.UpdateBySqlWithCondition(objWebSrvClassEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvClassEN objWebSrvClassEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsWebSrvClassBL.WebSrvClassDA.UpdateBySqlWithConditionTransaction(objWebSrvClassEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsWebSrvClassEN objWebSrvClassEN)
{
try
{
int intRecNum = clsWebSrvClassBL.WebSrvClassDA.DelRecord(objWebSrvClassEN.WebSrvClassId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassENS">源对象</param>
 /// <param name = "objWebSrvClassENT">目标对象</param>
 public static void CopyTo(this clsWebSrvClassEN objWebSrvClassENS, clsWebSrvClassEN objWebSrvClassENT)
{
try
{
objWebSrvClassENT.WebSrvClassId = objWebSrvClassENS.WebSrvClassId; //类Id
objWebSrvClassENT.NameSpace = objWebSrvClassENS.NameSpace; //域名
objWebSrvClassENT.WebSrvUrl = objWebSrvClassENS.WebSrvUrl; //WebSrv地址
objWebSrvClassENT.PageName = objWebSrvClassENS.PageName; //页面名称
objWebSrvClassENT.FuncModuleAgcId = objWebSrvClassENS.FuncModuleAgcId; //功能模块Id
objWebSrvClassENT.IsNeedGene = objWebSrvClassENS.IsNeedGene; //是否需要生成
objWebSrvClassENT.PrjId = objWebSrvClassENS.PrjId; //工程Id
objWebSrvClassENT.UpdDate = objWebSrvClassENS.UpdDate; //修改日期
objWebSrvClassENT.UpdUser = objWebSrvClassENS.UpdUser; //修改者
objWebSrvClassENT.Memo = objWebSrvClassENS.Memo; //说明
objWebSrvClassENT.CodeTypeId = objWebSrvClassENS.CodeTypeId; //代码类型Id
objWebSrvClassENT.ClsName = objWebSrvClassENS.ClsName; //类名
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
 /// <param name = "objWebSrvClassENS">源对象</param>
 /// <returns>目标对象=>clsWebSrvClassEN:objWebSrvClassENT</returns>
 public static clsWebSrvClassEN CopyTo(this clsWebSrvClassEN objWebSrvClassENS)
{
try
{
 clsWebSrvClassEN objWebSrvClassENT = new clsWebSrvClassEN()
{
WebSrvClassId = objWebSrvClassENS.WebSrvClassId, //类Id
NameSpace = objWebSrvClassENS.NameSpace, //域名
WebSrvUrl = objWebSrvClassENS.WebSrvUrl, //WebSrv地址
PageName = objWebSrvClassENS.PageName, //页面名称
FuncModuleAgcId = objWebSrvClassENS.FuncModuleAgcId, //功能模块Id
IsNeedGene = objWebSrvClassENS.IsNeedGene, //是否需要生成
PrjId = objWebSrvClassENS.PrjId, //工程Id
UpdDate = objWebSrvClassENS.UpdDate, //修改日期
UpdUser = objWebSrvClassENS.UpdUser, //修改者
Memo = objWebSrvClassENS.Memo, //说明
CodeTypeId = objWebSrvClassENS.CodeTypeId, //代码类型Id
ClsName = objWebSrvClassENS.ClsName, //类名
};
 return objWebSrvClassENT;
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
public static void CheckPropertyNew(this clsWebSrvClassEN objWebSrvClassEN)
{
 clsWebSrvClassBL.WebSrvClassDA.CheckPropertyNew(objWebSrvClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsWebSrvClassEN objWebSrvClassEN)
{
 clsWebSrvClassBL.WebSrvClassDA.CheckProperty4Condition(objWebSrvClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWebSrvClassEN objWebSrvClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.WebSrvClassId, objWebSrvClassCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.NameSpace, objWebSrvClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.WebSrvUrl) == true)
{
string strComparisonOpWebSrvUrl = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.WebSrvUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.WebSrvUrl, objWebSrvClassCond.WebSrvUrl, strComparisonOpWebSrvUrl);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.PageName) == true)
{
string strComparisonOpPageName = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.PageName, objWebSrvClassCond.PageName, strComparisonOpPageName);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.FuncModuleAgcId, objWebSrvClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.IsNeedGene) == true)
{
if (objWebSrvClassCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvClass.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvClass.IsNeedGene);
}
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.PrjId) == true)
{
string strComparisonOpPrjId = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.PrjId, objWebSrvClassCond.PrjId, strComparisonOpPrjId);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.UpdDate) == true)
{
string strComparisonOpUpdDate = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.UpdDate, objWebSrvClassCond.UpdDate, strComparisonOpUpdDate);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.UpdUser) == true)
{
string strComparisonOpUpdUser = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.UpdUser, objWebSrvClassCond.UpdUser, strComparisonOpUpdUser);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.Memo) == true)
{
string strComparisonOpMemo = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.Memo, objWebSrvClassCond.Memo, strComparisonOpMemo);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.CodeTypeId, objWebSrvClassCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objWebSrvClassCond.IsUpdated(conWebSrvClass.ClsName) == true)
{
string strComparisonOpClsName = objWebSrvClassCond.dicFldComparisonOp[conWebSrvClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvClass.ClsName, objWebSrvClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--WebSrvClass(WebSrv类), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClsName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objWebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsWebSrvClassEN objWebSrvClassEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvClassEN == null) return true;
if (objWebSrvClassEN.WebSrvClassId == null || objWebSrvClassEN.WebSrvClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClsName = '{0}'", objWebSrvClassEN.ClsName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objWebSrvClassEN.PrjId);
if (clsWebSrvClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("WebSrvClassId !=  '{0}'", objWebSrvClassEN.WebSrvClassId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objWebSrvClassEN.ClsName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objWebSrvClassEN.PrjId);
if (clsWebSrvClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--WebSrvClass(WebSrv类), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClsName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objWebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsWebSrvClassEN objWebSrvClassEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvClassEN == null) return "";
if (objWebSrvClassEN.WebSrvClassId == null || objWebSrvClassEN.WebSrvClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClsName = '{0}'", objWebSrvClassEN.ClsName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objWebSrvClassEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WebSrvClassId !=  '{0}'", objWebSrvClassEN.WebSrvClassId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objWebSrvClassEN.ClsName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objWebSrvClassEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_WebSrvClass
{
public virtual bool UpdRelaTabDate(string strWebSrvClassId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// WebSrv类(WebSrvClass)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsWebSrvClassBL
{
public static RelatedActions_WebSrvClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsWebSrvClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsWebSrvClassDA WebSrvClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsWebSrvClassDA();
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
 public clsWebSrvClassBL()
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
if (string.IsNullOrEmpty(clsWebSrvClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebSrvClassEN._ConnectString);
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
public static DataTable GetDataTable_WebSrvClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = WebSrvClassDA.GetDataTable_WebSrvClass(strWhereCond);
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
objDT = WebSrvClassDA.GetDataTable(strWhereCond);
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
objDT = WebSrvClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = WebSrvClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = WebSrvClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = WebSrvClassDA.GetDataTable_Top(objTopPara);
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
objDT = WebSrvClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrWebSrvClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsWebSrvClassEN> GetObjLstByWebSrvClassIdLst(List<string> arrWebSrvClassIdLst)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWebSrvClassIdLst, true);
 string strWhereCond = string.Format("WebSrvClassId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsWebSrvClassEN> GetObjLstByWebSrvClassIdLstCache(List<string> arrWebSrvClassIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsWebSrvClassEN._CurrTabName, strPrjId);
List<clsWebSrvClassEN> arrWebSrvClassObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsWebSrvClassEN> arrWebSrvClassObjLst_Sel =
arrWebSrvClassObjLstCache
.Where(x => arrWebSrvClassIdLst.Contains(x.WebSrvClassId));
return arrWebSrvClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvClassEN> GetObjLst(string strWhereCond)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
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
public static List<clsWebSrvClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objWebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsWebSrvClassEN> GetSubObjLstCache(clsWebSrvClassEN objWebSrvClassCond)
{
 string strPrjId = objWebSrvClassCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsWebSrvClassBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsWebSrvClassEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsWebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebSrvClass._AttributeName)
{
if (objWebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objWebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvClassCond[strFldName].ToString());
}
else
{
if (objWebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebSrvClassCond[strFldName]));
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
public static List<clsWebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
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
public static List<clsWebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
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
List<clsWebSrvClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsWebSrvClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsWebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
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
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
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
public static List<clsWebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsWebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsWebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
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
public static List<clsWebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsWebSrvClassEN> arrObjLst = new List<clsWebSrvClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN();
try
{
objWebSrvClassEN.WebSrvClassId = objRow[conWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvClassEN.NameSpace = objRow[conWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[conWebSrvClass.NameSpace].ToString().Trim(); //域名
objWebSrvClassEN.WebSrvUrl = objRow[conWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objWebSrvClassEN.PageName = objRow[conWebSrvClass.PageName].ToString().Trim(); //页面名称
objWebSrvClassEN.FuncModuleAgcId = objRow[conWebSrvClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objWebSrvClassEN.PrjId = objRow[conWebSrvClass.PrjId].ToString().Trim(); //工程Id
objWebSrvClassEN.UpdDate = objRow[conWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[conWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objWebSrvClassEN.UpdUser = objRow[conWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[conWebSrvClass.UpdUser].ToString().Trim(); //修改者
objWebSrvClassEN.Memo = objRow[conWebSrvClass.Memo] == DBNull.Value ? null : objRow[conWebSrvClass.Memo].ToString().Trim(); //说明
objWebSrvClassEN.CodeTypeId = objRow[conWebSrvClass.CodeTypeId].ToString().Trim(); //代码类型Id
objWebSrvClassEN.ClsName = objRow[conWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objWebSrvClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetWebSrvClass(ref clsWebSrvClassEN objWebSrvClassEN)
{
bool bolResult = WebSrvClassDA.GetWebSrvClass(ref objWebSrvClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvClassEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
if (strWebSrvClassId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWebSrvClassId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWebSrvClassId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWebSrvClassId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsWebSrvClassEN objWebSrvClassEN = WebSrvClassDA.GetObjByWebSrvClassId(strWebSrvClassId);
return objWebSrvClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsWebSrvClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsWebSrvClassEN objWebSrvClassEN = WebSrvClassDA.GetFirstObj(strWhereCond);
 return objWebSrvClassEN;
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
public static clsWebSrvClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsWebSrvClassEN objWebSrvClassEN = WebSrvClassDA.GetObjByDataRow(objRow);
 return objWebSrvClassEN;
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
public static clsWebSrvClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsWebSrvClassEN objWebSrvClassEN = WebSrvClassDA.GetObjByDataRow(objRow);
 return objWebSrvClassEN;
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
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <param name = "lstWebSrvClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebSrvClassEN GetObjByWebSrvClassIdFromList(string strWebSrvClassId, List<clsWebSrvClassEN> lstWebSrvClassObjLst)
{
foreach (clsWebSrvClassEN objWebSrvClassEN in lstWebSrvClassObjLst)
{
if (objWebSrvClassEN.WebSrvClassId == strWebSrvClassId)
{
return objWebSrvClassEN;
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
 string strMaxWebSrvClassId;
 try
 {
 strMaxWebSrvClassId = clsWebSrvClassDA.GetMaxStrId();
 return strMaxWebSrvClassId;
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
 string strWebSrvClassId;
 try
 {
 strWebSrvClassId = new clsWebSrvClassDA().GetFirstID(strWhereCond);
 return strWebSrvClassId;
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
 arrList = WebSrvClassDA.GetID(strWhereCond);
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
bool bolIsExist = WebSrvClassDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWebSrvClassId)
{
if (string.IsNullOrEmpty(strWebSrvClassId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWebSrvClassId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = WebSrvClassDA.IsExist(strWebSrvClassId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strWebSrvClassId">类Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strWebSrvClassId, string strOpUser)
{
clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassId(strWebSrvClassId);
objWebSrvClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objWebSrvClassEN.UpdUser = strOpUser;
return clsWebSrvClassBL.UpdateBySql2(objWebSrvClassEN);
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
 bolIsExist = clsWebSrvClassDA.IsExistTable();
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
 bolIsExist = WebSrvClassDA.IsExistTable(strTabName);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebSrvClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!类名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsWebSrvClassBL.AddNewRecordBySql2)", objWebSrvClassEN.ClsName,objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
bool bolResult = WebSrvClassDA.AddNewRecordBySQL2(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsWebSrvClassEN objWebSrvClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebSrvClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!类名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsWebSrvClassBL.AddNewRecordBySql2WithReturnKey)", objWebSrvClassEN.ClsName,objWebSrvClassEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true || clsWebSrvClassBL.IsExist(objWebSrvClassEN.WebSrvClassId) == true)
 {
     objWebSrvClassEN.WebSrvClassId = clsWebSrvClassBL.GetMaxStrId_S();
 }
string strKey = WebSrvClassDA.AddNewRecordBySQL2WithReturnKey(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsWebSrvClassEN objWebSrvClassEN)
{
try
{
bool bolResult = WebSrvClassDA.Update(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "objWebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsWebSrvClassEN objWebSrvClassEN)
{
 if (string.IsNullOrEmpty(objWebSrvClassEN.WebSrvClassId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = WebSrvClassDA.UpdateBySql2(objWebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvClassBL.ReFreshCache(objWebSrvClassEN.PrjId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strWebSrvClassId)
{
try
{
 clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassId(strWebSrvClassId);

if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(objWebSrvClassEN.WebSrvClassId, objWebSrvClassEN.UpdUser);
}
if (objWebSrvClassEN != null)
{
int intRecNum = WebSrvClassDA.DelRecord(strWebSrvClassId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objWebSrvClassEN.PrjId);
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
/// <param name="strWebSrvClassId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strWebSrvClassId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
//删除与表:[WebSrvClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conWebSrvClass.WebSrvClassId,
//strWebSrvClassId);
//        clsWebSrvClassBL.DelWebSrvClasssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebSrvClassBL.DelRecord(strWebSrvClassId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebSrvClassBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strWebSrvClassId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strWebSrvClassId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsWebSrvClassBL.relatedActions != null)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(strWebSrvClassId, "UpdRelaTabDate");
}
bool bolResult = WebSrvClassDA.DelRecord(strWebSrvClassId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrWebSrvClassIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelWebSrvClasss(List<string> arrWebSrvClassIdLst)
{
if (arrWebSrvClassIdLst.Count == 0) return 0;
try
{
if (clsWebSrvClassBL.relatedActions != null)
{
foreach (var strWebSrvClassId in arrWebSrvClassIdLst)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(strWebSrvClassId, "UpdRelaTabDate");
}
}
 clsWebSrvClassEN objWebSrvClassEN = clsWebSrvClassBL.GetObjByWebSrvClassId(arrWebSrvClassIdLst[0]);
int intDelRecNum = WebSrvClassDA.DelWebSrvClass(arrWebSrvClassIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objWebSrvClassEN.PrjId);
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
public static int DelWebSrvClasssByCond(string strWhereCond)
{
try
{
if (clsWebSrvClassBL.relatedActions != null)
{
List<string> arrWebSrvClassId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strWebSrvClassId in arrWebSrvClassId)
{
clsWebSrvClassBL.relatedActions.UpdRelaTabDate(strWebSrvClassId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conWebSrvClass.PrjId, strWhereCond);
int intRecNum = WebSrvClassDA.DelWebSrvClass(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[WebSrvClass]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strWebSrvClassId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strWebSrvClassId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsWebSrvClassDA.GetSpecSQLObj();
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
//删除与表:[WebSrvClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebSrvClassBL.DelRecord(strWebSrvClassId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebSrvClassBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strWebSrvClassId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objWebSrvClassENS">源对象</param>
 /// <param name = "objWebSrvClassENT">目标对象</param>
 public static void CopyTo(clsWebSrvClassEN objWebSrvClassENS, clsWebSrvClassEN objWebSrvClassENT)
{
try
{
objWebSrvClassENT.WebSrvClassId = objWebSrvClassENS.WebSrvClassId; //类Id
objWebSrvClassENT.NameSpace = objWebSrvClassENS.NameSpace; //域名
objWebSrvClassENT.WebSrvUrl = objWebSrvClassENS.WebSrvUrl; //WebSrv地址
objWebSrvClassENT.PageName = objWebSrvClassENS.PageName; //页面名称
objWebSrvClassENT.FuncModuleAgcId = objWebSrvClassENS.FuncModuleAgcId; //功能模块Id
objWebSrvClassENT.IsNeedGene = objWebSrvClassENS.IsNeedGene; //是否需要生成
objWebSrvClassENT.PrjId = objWebSrvClassENS.PrjId; //工程Id
objWebSrvClassENT.UpdDate = objWebSrvClassENS.UpdDate; //修改日期
objWebSrvClassENT.UpdUser = objWebSrvClassENS.UpdUser; //修改者
objWebSrvClassENT.Memo = objWebSrvClassENS.Memo; //说明
objWebSrvClassENT.CodeTypeId = objWebSrvClassENS.CodeTypeId; //代码类型Id
objWebSrvClassENT.ClsName = objWebSrvClassENS.ClsName; //类名
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
 /// <param name = "objWebSrvClassEN">源简化对象</param>
 public static void SetUpdFlag(clsWebSrvClassEN objWebSrvClassEN)
{
try
{
objWebSrvClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objWebSrvClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conWebSrvClass.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.WebSrvClassId = objWebSrvClassEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(conWebSrvClass.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.NameSpace = objWebSrvClassEN.NameSpace == "[null]" ? null :  objWebSrvClassEN.NameSpace; //域名
}
if (arrFldSet.Contains(conWebSrvClass.WebSrvUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.WebSrvUrl = objWebSrvClassEN.WebSrvUrl; //WebSrv地址
}
if (arrFldSet.Contains(conWebSrvClass.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.PageName = objWebSrvClassEN.PageName; //页面名称
}
if (arrFldSet.Contains(conWebSrvClass.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.FuncModuleAgcId = objWebSrvClassEN.FuncModuleAgcId == "[null]" ? null :  objWebSrvClassEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conWebSrvClass.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.IsNeedGene = objWebSrvClassEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(conWebSrvClass.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.PrjId = objWebSrvClassEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conWebSrvClass.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.UpdDate = objWebSrvClassEN.UpdDate == "[null]" ? null :  objWebSrvClassEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conWebSrvClass.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.UpdUser = objWebSrvClassEN.UpdUser == "[null]" ? null :  objWebSrvClassEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conWebSrvClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.Memo = objWebSrvClassEN.Memo == "[null]" ? null :  objWebSrvClassEN.Memo; //说明
}
if (arrFldSet.Contains(conWebSrvClass.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.CodeTypeId = objWebSrvClassEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conWebSrvClass.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvClassEN.ClsName = objWebSrvClassEN.ClsName; //类名
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
 /// <param name = "objWebSrvClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsWebSrvClassEN objWebSrvClassEN)
{
try
{
if (objWebSrvClassEN.NameSpace == "[null]") objWebSrvClassEN.NameSpace = null; //域名
if (objWebSrvClassEN.FuncModuleAgcId == "[null]") objWebSrvClassEN.FuncModuleAgcId = null; //功能模块Id
if (objWebSrvClassEN.UpdDate == "[null]") objWebSrvClassEN.UpdDate = null; //修改日期
if (objWebSrvClassEN.UpdUser == "[null]") objWebSrvClassEN.UpdUser = null; //修改者
if (objWebSrvClassEN.Memo == "[null]") objWebSrvClassEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsWebSrvClassEN objWebSrvClassEN)
{
 WebSrvClassDA.CheckPropertyNew(objWebSrvClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsWebSrvClassEN objWebSrvClassEN)
{
 WebSrvClassDA.CheckProperty4Condition(objWebSrvClassEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_WebSrvClassId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conWebSrvClass.WebSrvClassId); 
List<clsWebSrvClassEN> arrObjLst = clsWebSrvClassBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsWebSrvClassEN objWebSrvClassEN = new clsWebSrvClassEN()
{
WebSrvClassId = "0",
ClsName = "选[WebSrv类]..."
};
arrObjLstSel.Insert(0, objWebSrvClassEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conWebSrvClass.WebSrvClassId;
objComboBox.DisplayMember = conWebSrvClass.ClsName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_WebSrvClassId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[WebSrv类]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conWebSrvClass.WebSrvClassId); 
IEnumerable<clsWebSrvClassEN> arrObjLst = clsWebSrvClassBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conWebSrvClass.WebSrvClassId;
objDDL.DataTextField = conWebSrvClass.ClsName;
objDDL.DataSource = arrObjLstSel;
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
if (clsWebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvClassId");
//if (arrWebSrvClassObjLstCache == null)
//{
//arrWebSrvClassObjLstCache = WebSrvClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebSrvClassEN GetObjByWebSrvClassIdCache(string strWebSrvClassId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsWebSrvClassEN._CurrTabName, strPrjId);
List<clsWebSrvClassEN> arrWebSrvClassObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsWebSrvClassEN> arrWebSrvClassObjLst_Sel =
arrWebSrvClassObjLstCache
.Where(x=> x.WebSrvClassId == strWebSrvClassId 
);
if (arrWebSrvClassObjLst_Sel.Count() == 0)
{
   clsWebSrvClassEN obj = clsWebSrvClassBL.GetObjByWebSrvClassId(strWebSrvClassId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strWebSrvClassId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrWebSrvClassObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebSrvClassEN> GetAllWebSrvClassObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsWebSrvClassEN> arrWebSrvClassObjLstCache = GetObjLstCache(strPrjId); 
return arrWebSrvClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebSrvClassEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsWebSrvClassEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsWebSrvClassEN> arrWebSrvClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrWebSrvClassObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsWebSrvClassEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsWebSrvClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsWebSrvClassEN._RefreshTimeLst.Count == 0) return "";
return clsWebSrvClassEN._RefreshTimeLst[clsWebSrvClassEN._RefreshTimeLst.Count - 1];
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
if (clsWebSrvClassBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsWebSrvClassEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsWebSrvClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsWebSrvClassBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--WebSrvClass(WebSrv类)
 /// 唯一性条件:ClsName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsWebSrvClassEN objWebSrvClassEN)
{
//检测记录是否存在
string strResult = WebSrvClassDA.GetUniCondStr(objWebSrvClassEN);
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
public static string Func(string strInFldName, string strOutFldName, string strWebSrvClassId, string strPrjId)
{
if (strInFldName != conWebSrvClass.WebSrvClassId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conWebSrvClass._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conWebSrvClass._AttributeName));
throw new Exception(strMsg);
}
var objWebSrvClass = clsWebSrvClassBL.GetObjByWebSrvClassIdCache(strWebSrvClassId, strPrjId);
if (objWebSrvClass == null) return "";
return objWebSrvClass[strOutFldName].ToString();
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
int intRecCount = clsWebSrvClassDA.GetRecCount(strTabName);
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
int intRecCount = clsWebSrvClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsWebSrvClassDA.GetRecCount();
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
int intRecCount = clsWebSrvClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objWebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsWebSrvClassEN objWebSrvClassCond)
{
 string strPrjId = objWebSrvClassCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsWebSrvClassBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsWebSrvClassEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsWebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebSrvClass._AttributeName)
{
if (objWebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objWebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvClassCond[strFldName].ToString());
}
else
{
if (objWebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebSrvClassCond[strFldName]));
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
 List<string> arrList = clsWebSrvClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = WebSrvClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = WebSrvClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = WebSrvClassDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebSrvClassDA.SetFldValue(clsWebSrvClassEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = WebSrvClassDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebSrvClassDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebSrvClassDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebSrvClassDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[WebSrvClass] "); 
 strCreateTabCode.Append(" ( "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" WebSrvClassId char(8) primary key, "); 
 // /**域名*/ 
 strCreateTabCode.Append(" NameSpace varchar(50) Null, "); 
 // /**WebSrv地址*/ 
 strCreateTabCode.Append(" WebSrvUrl varchar(300) not Null, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**是否需要生成*/ 
 strCreateTabCode.Append(" IsNeedGene bit Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) not Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// WebSrv类(WebSrvClass)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4WebSrvClass : clsCommFun4BLV2
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
clsWebSrvClassBL.ReFreshThisCache(strPrjId);
}
}

}