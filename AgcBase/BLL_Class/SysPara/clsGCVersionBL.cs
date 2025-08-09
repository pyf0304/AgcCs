
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVersionBL
 表名:GCVersion(00050500)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsGCVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strGcVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVersionEN GetObj(this K_GcVersionId_GCVersion myKey)
{
clsGCVersionEN objGCVersionEN = clsGCVersionBL.GCVersionDA.GetObjByGcVersionId(myKey.Value);
return objGCVersionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCVersionEN objGCVersionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGCVersionBL.IsExist(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGCVersionEN.GcVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsGCVersionBL.GCVersionDA.AddNewRecordBySQL2(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
public static bool AddRecordEx(this clsGCVersionEN objGCVersionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsGCVersionBL.IsExist(objGCVersionEN.GcVersionId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objGCVersionEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objGCVersionEN.AddNewRecord();
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCVersionEN objGCVersionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGCVersionBL.IsExist(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGCVersionEN.GcVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsGCVersionBL.GCVersionDA.AddNewRecordBySQL2WithReturnKey(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetGcVersionId(this clsGCVersionEN objGCVersionEN, string strGcVersionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcVersionId, 4, conGCVersion.GcVersionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGcVersionId, 4, conGCVersion.GcVersionId);
}
objGCVersionEN.GcVersionId = strGcVersionId; //生成代码版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.GcVersionId) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.GcVersionId, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.GcVersionId] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetGcVersionDescription(this clsGCVersionEN objGCVersionEN, string strGcVersionDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcVersionDescription, 1000, conGCVersion.GcVersionDescription);
}
objGCVersionEN.GcVersionDescription = strGcVersionDescription; //版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.GcVersionDescription) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.GcVersionDescription, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.GcVersionDescription] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetVersionNumber(this clsGCVersionEN objGCVersionEN, string strVersionNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionNumber, conGCVersion.VersionNumber);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionNumber, 50, conGCVersion.VersionNumber);
}
objGCVersionEN.VersionNumber = strVersionNumber; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.VersionNumber) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.VersionNumber, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.VersionNumber] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetVersionCode(this clsGCVersionEN objGCVersionEN, string strVersionCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionCode, 50, conGCVersion.VersionCode);
}
objGCVersionEN.VersionCode = strVersionCode; //版本代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.VersionCode) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.VersionCode, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.VersionCode] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetPublishDate(this clsGCVersionEN objGCVersionEN, string strPublishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPublishDate, conGCVersion.PublishDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPublishDate, 20, conGCVersion.PublishDate);
}
objGCVersionEN.PublishDate = strPublishDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.PublishDate) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.PublishDate, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.PublishDate] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetVersionState(this clsGCVersionEN objGCVersionEN, bool bolVersionState, string strComparisonOp="")
	{
objGCVersionEN.VersionState = bolVersionState; //版本状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.VersionState) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.VersionState, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.VersionState] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetVersionUrl(this clsGCVersionEN objGCVersionEN, string strVersionUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionUrl, 500, conGCVersion.VersionUrl);
}
objGCVersionEN.VersionUrl = strVersionUrl; //版本文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.VersionUrl) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.VersionUrl, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.VersionUrl] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetPrjId(this clsGCVersionEN objGCVersionEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conGCVersion.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conGCVersion.PrjId);
}
objGCVersionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.PrjId) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.PrjId, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.PrjId] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetUpdDate(this clsGCVersionEN objGCVersionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCVersion.UpdDate);
}
objGCVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.UpdDate) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.UpdDate, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.UpdDate] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetUpdUser(this clsGCVersionEN objGCVersionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCVersion.UpdUser);
}
objGCVersionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.UpdUser) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.UpdUser, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.UpdUser] = strComparisonOp;
}
}
return objGCVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVersionEN SetMemo(this clsGCVersionEN objGCVersionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCVersion.Memo);
}
objGCVersionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVersionEN.dicFldComparisonOp.ContainsKey(conGCVersion.Memo) == false)
{
objGCVersionEN.dicFldComparisonOp.Add(conGCVersion.Memo, strComparisonOp);
}
else
{
objGCVersionEN.dicFldComparisonOp[conGCVersion.Memo] = strComparisonOp;
}
}
return objGCVersionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCVersionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCVersionEN objGCVersionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCVersionEN.CheckPropertyNew();
clsGCVersionEN objGCVersionCond = new clsGCVersionEN();
string strCondition = objGCVersionCond
.SetGcVersionId(objGCVersionEN.GcVersionId, "=")
.GetCombineCondition();
objGCVersionEN._IsCheckProperty = true;
bool bolIsExist = clsGCVersionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCVersionEN.Update();
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVersionEN objGCVersionEN)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVersionBL.GCVersionDA.UpdateBySql2(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVersionEN objGCVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVersionBL.GCVersionDA.UpdateBySql2(objGCVersionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVersionEN objGCVersionEN, string strWhereCond)
{
try
{
bool bolResult = clsGCVersionBL.GCVersionDA.UpdateBySqlWithCondition(objGCVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVersionEN objGCVersionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCVersionBL.GCVersionDA.UpdateBySqlWithConditionTransaction(objGCVersionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCVersionEN objGCVersionEN)
{
try
{
int intRecNum = clsGCVersionBL.GCVersionDA.DelRecord(objGCVersionEN.GcVersionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionENS">源对象</param>
 /// <param name = "objGCVersionENT">目标对象</param>
 public static void CopyTo(this clsGCVersionEN objGCVersionENS, clsGCVersionEN objGCVersionENT)
{
try
{
objGCVersionENT.GcVersionId = objGCVersionENS.GcVersionId; //生成代码版本Id
objGCVersionENT.GcVersionDescription = objGCVersionENS.GcVersionDescription; //版本说明
objGCVersionENT.VersionNumber = objGCVersionENS.VersionNumber; //版本号
objGCVersionENT.VersionCode = objGCVersionENS.VersionCode; //版本代码
objGCVersionENT.PublishDate = objGCVersionENS.PublishDate; //发布日期
objGCVersionENT.VersionState = objGCVersionENS.VersionState; //版本状态
objGCVersionENT.VersionUrl = objGCVersionENS.VersionUrl; //版本文件
objGCVersionENT.PrjId = objGCVersionENS.PrjId; //工程Id
objGCVersionENT.UpdDate = objGCVersionENS.UpdDate; //修改日期
objGCVersionENT.UpdUser = objGCVersionENS.UpdUser; //修改者
objGCVersionENT.Memo = objGCVersionENS.Memo; //说明
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
 /// <param name = "objGCVersionENS">源对象</param>
 /// <returns>目标对象=>clsGCVersionEN:objGCVersionENT</returns>
 public static clsGCVersionEN CopyTo(this clsGCVersionEN objGCVersionENS)
{
try
{
 clsGCVersionEN objGCVersionENT = new clsGCVersionEN()
{
GcVersionId = objGCVersionENS.GcVersionId, //生成代码版本Id
GcVersionDescription = objGCVersionENS.GcVersionDescription, //版本说明
VersionNumber = objGCVersionENS.VersionNumber, //版本号
VersionCode = objGCVersionENS.VersionCode, //版本代码
PublishDate = objGCVersionENS.PublishDate, //发布日期
VersionState = objGCVersionENS.VersionState, //版本状态
VersionUrl = objGCVersionENS.VersionUrl, //版本文件
PrjId = objGCVersionENS.PrjId, //工程Id
UpdDate = objGCVersionENS.UpdDate, //修改日期
UpdUser = objGCVersionENS.UpdUser, //修改者
Memo = objGCVersionENS.Memo, //说明
};
 return objGCVersionENT;
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
public static void CheckPropertyNew(this clsGCVersionEN objGCVersionEN)
{
 clsGCVersionBL.GCVersionDA.CheckPropertyNew(objGCVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCVersionEN objGCVersionEN)
{
 clsGCVersionBL.GCVersionDA.CheckProperty4Condition(objGCVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCVersionEN objGCVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCVersionCond.IsUpdated(conGCVersion.GcVersionId) == true)
{
string strComparisonOpGcVersionId = objGCVersionCond.dicFldComparisonOp[conGCVersion.GcVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.GcVersionId, objGCVersionCond.GcVersionId, strComparisonOpGcVersionId);
}
if (objGCVersionCond.IsUpdated(conGCVersion.GcVersionDescription) == true)
{
string strComparisonOpGcVersionDescription = objGCVersionCond.dicFldComparisonOp[conGCVersion.GcVersionDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.GcVersionDescription, objGCVersionCond.GcVersionDescription, strComparisonOpGcVersionDescription);
}
if (objGCVersionCond.IsUpdated(conGCVersion.VersionNumber) == true)
{
string strComparisonOpVersionNumber = objGCVersionCond.dicFldComparisonOp[conGCVersion.VersionNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.VersionNumber, objGCVersionCond.VersionNumber, strComparisonOpVersionNumber);
}
if (objGCVersionCond.IsUpdated(conGCVersion.VersionCode) == true)
{
string strComparisonOpVersionCode = objGCVersionCond.dicFldComparisonOp[conGCVersion.VersionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.VersionCode, objGCVersionCond.VersionCode, strComparisonOpVersionCode);
}
if (objGCVersionCond.IsUpdated(conGCVersion.PublishDate) == true)
{
string strComparisonOpPublishDate = objGCVersionCond.dicFldComparisonOp[conGCVersion.PublishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.PublishDate, objGCVersionCond.PublishDate, strComparisonOpPublishDate);
}
if (objGCVersionCond.IsUpdated(conGCVersion.VersionState) == true)
{
if (objGCVersionCond.VersionState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conGCVersion.VersionState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conGCVersion.VersionState);
}
}
if (objGCVersionCond.IsUpdated(conGCVersion.VersionUrl) == true)
{
string strComparisonOpVersionUrl = objGCVersionCond.dicFldComparisonOp[conGCVersion.VersionUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.VersionUrl, objGCVersionCond.VersionUrl, strComparisonOpVersionUrl);
}
if (objGCVersionCond.IsUpdated(conGCVersion.PrjId) == true)
{
string strComparisonOpPrjId = objGCVersionCond.dicFldComparisonOp[conGCVersion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.PrjId, objGCVersionCond.PrjId, strComparisonOpPrjId);
}
if (objGCVersionCond.IsUpdated(conGCVersion.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCVersionCond.dicFldComparisonOp[conGCVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.UpdDate, objGCVersionCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCVersionCond.IsUpdated(conGCVersion.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCVersionCond.dicFldComparisonOp[conGCVersion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.UpdUser, objGCVersionCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCVersionCond.IsUpdated(conGCVersion.Memo) == true)
{
string strComparisonOpMemo = objGCVersionCond.dicFldComparisonOp[conGCVersion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVersion.Memo, objGCVersionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCVersion
{
public virtual bool UpdRelaTabDate(string strGcVersionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 生成代码版本(GCVersion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCVersionBL
{
public static RelatedActions_GCVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCVersionDA GCVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCVersionDA();
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
 public clsGCVersionBL()
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
if (string.IsNullOrEmpty(clsGCVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVersionEN._ConnectString);
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
public static DataTable GetDataTable_GCVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCVersionDA.GetDataTable_GCVersion(strWhereCond);
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
objDT = GCVersionDA.GetDataTable(strWhereCond);
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
objDT = GCVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCVersionDA.GetDataTable_Top(objTopPara);
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
objDT = GCVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGcVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCVersionEN> GetObjLstByGcVersionIdLst(List<string> arrGcVersionIdLst)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGcVersionIdLst, true);
 string strWhereCond = string.Format("GcVersionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGcVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCVersionEN> GetObjLstByGcVersionIdLstCache(List<string> arrGcVersionIdLst)
{
string strKey = string.Format("{0}", clsGCVersionEN._CurrTabName);
List<clsGCVersionEN> arrGCVersionObjLstCache = GetObjLstCache();
IEnumerable <clsGCVersionEN> arrGCVersionObjLst_Sel =
arrGCVersionObjLstCache
.Where(x => arrGcVersionIdLst.Contains(x.GcVersionId));
return arrGCVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVersionEN> GetObjLst(string strWhereCond)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
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
public static List<clsGCVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCVersionEN> GetSubObjLstCache(clsGCVersionEN objGCVersionCond)
{
List<clsGCVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVersion._AttributeName)
{
if (objGCVersionCond.IsUpdated(strFldName) == false) continue;
if (objGCVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVersionCond[strFldName].ToString());
}
else
{
if (objGCVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVersionCond[strFldName]));
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
public static List<clsGCVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
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
public static List<clsGCVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
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
List<clsGCVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
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
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
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
public static List<clsGCVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
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
public static List<clsGCVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCVersionEN> arrObjLst = new List<clsGCVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVersionEN objGCVersionEN = new clsGCVersionEN();
try
{
objGCVersionEN.GcVersionId = objRow[conGCVersion.GcVersionId].ToString().Trim(); //生成代码版本Id
objGCVersionEN.GcVersionDescription = objRow[conGCVersion.GcVersionDescription] == DBNull.Value ? null : objRow[conGCVersion.GcVersionDescription].ToString().Trim(); //版本说明
objGCVersionEN.VersionNumber = objRow[conGCVersion.VersionNumber].ToString().Trim(); //版本号
objGCVersionEN.VersionCode = objRow[conGCVersion.VersionCode] == DBNull.Value ? null : objRow[conGCVersion.VersionCode].ToString().Trim(); //版本代码
objGCVersionEN.PublishDate = objRow[conGCVersion.PublishDate].ToString().Trim(); //发布日期
objGCVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conGCVersion.VersionState].ToString().Trim()); //版本状态
objGCVersionEN.VersionUrl = objRow[conGCVersion.VersionUrl] == DBNull.Value ? null : objRow[conGCVersion.VersionUrl].ToString().Trim(); //版本文件
objGCVersionEN.PrjId = objRow[conGCVersion.PrjId] == DBNull.Value ? null : objRow[conGCVersion.PrjId].ToString().Trim(); //工程Id
objGCVersionEN.UpdDate = objRow[conGCVersion.UpdDate] == DBNull.Value ? null : objRow[conGCVersion.UpdDate].ToString().Trim(); //修改日期
objGCVersionEN.UpdUser = objRow[conGCVersion.UpdUser] == DBNull.Value ? null : objRow[conGCVersion.UpdUser].ToString().Trim(); //修改者
objGCVersionEN.Memo = objRow[conGCVersion.Memo] == DBNull.Value ? null : objRow[conGCVersion.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVersionEN.GcVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCVersion(ref clsGCVersionEN objGCVersionEN)
{
bool bolResult = GCVersionDA.GetGCVersion(ref objGCVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strGcVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVersionEN GetObjByGcVersionId(string strGcVersionId)
{
if (strGcVersionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strGcVersionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGcVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strGcVersionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCVersionEN objGCVersionEN = GCVersionDA.GetObjByGcVersionId(strGcVersionId);
return objGCVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCVersionEN objGCVersionEN = GCVersionDA.GetFirstObj(strWhereCond);
 return objGCVersionEN;
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
public static clsGCVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCVersionEN objGCVersionEN = GCVersionDA.GetObjByDataRow(objRow);
 return objGCVersionEN;
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
public static clsGCVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCVersionEN objGCVersionEN = GCVersionDA.GetObjByDataRow(objRow);
 return objGCVersionEN;
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
 /// <param name = "strGcVersionId">所给的关键字</param>
 /// <param name = "lstGCVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVersionEN GetObjByGcVersionIdFromList(string strGcVersionId, List<clsGCVersionEN> lstGCVersionObjLst)
{
foreach (clsGCVersionEN objGCVersionEN in lstGCVersionObjLst)
{
if (objGCVersionEN.GcVersionId == strGcVersionId)
{
return objGCVersionEN;
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
 string strGcVersionId;
 try
 {
 strGcVersionId = new clsGCVersionDA().GetFirstID(strWhereCond);
 return strGcVersionId;
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
 arrList = GCVersionDA.GetID(strWhereCond);
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
bool bolIsExist = GCVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strGcVersionId)
{
if (string.IsNullOrEmpty(strGcVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strGcVersionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCVersionDA.IsExist(strGcVersionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strGcVersionId">生成代码版本Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strGcVersionId, string strOpUser)
{
clsGCVersionEN objGCVersionEN = clsGCVersionBL.GetObjByGcVersionId(strGcVersionId);
objGCVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCVersionEN.UpdUser = strOpUser;
return clsGCVersionBL.UpdateBySql2(objGCVersionEN);
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
 bolIsExist = clsGCVersionDA.IsExistTable();
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
 bolIsExist = GCVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCVersionEN objGCVersionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGCVersionBL.IsExist(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGCVersionEN.GcVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = GCVersionDA.AddNewRecordBySQL2(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCVersionEN objGCVersionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGCVersionBL.IsExist(objGCVersionEN.GcVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGCVersionEN.GcVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = GCVersionDA.AddNewRecordBySQL2WithReturnKey(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCVersionEN objGCVersionEN)
{
try
{
bool bolResult = GCVersionDA.Update(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "objGCVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCVersionEN objGCVersionEN)
{
 if (string.IsNullOrEmpty(objGCVersionEN.GcVersionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCVersionDA.UpdateBySql2(objGCVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVersionBL.ReFreshCache();

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
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
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strGcVersionId)
{
try
{
 clsGCVersionEN objGCVersionEN = clsGCVersionBL.GetObjByGcVersionId(strGcVersionId);

if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(objGCVersionEN.GcVersionId, objGCVersionEN.UpdUser);
}
if (objGCVersionEN != null)
{
int intRecNum = GCVersionDA.DelRecord(strGcVersionId);
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
/// <param name="strGcVersionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strGcVersionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVersionDA.GetSpecSQLObj();
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
//删除与表:[GCVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCVersion.GcVersionId,
//strGcVersionId);
//        clsGCVersionBL.DelGCVersionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVersionBL.DelRecord(strGcVersionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVersionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGcVersionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strGcVersionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strGcVersionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCVersionBL.relatedActions != null)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(strGcVersionId, "UpdRelaTabDate");
}
bool bolResult = GCVersionDA.DelRecord(strGcVersionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrGcVersionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCVersions(List<string> arrGcVersionIdLst)
{
if (arrGcVersionIdLst.Count == 0) return 0;
try
{
if (clsGCVersionBL.relatedActions != null)
{
foreach (var strGcVersionId in arrGcVersionIdLst)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(strGcVersionId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCVersionDA.DelGCVersion(arrGcVersionIdLst);
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
public static int DelGCVersionsByCond(string strWhereCond)
{
try
{
if (clsGCVersionBL.relatedActions != null)
{
List<string> arrGcVersionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strGcVersionId in arrGcVersionId)
{
clsGCVersionBL.relatedActions.UpdRelaTabDate(strGcVersionId, "UpdRelaTabDate");
}
}
int intRecNum = GCVersionDA.DelGCVersion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCVersion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strGcVersionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strGcVersionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVersionDA.GetSpecSQLObj();
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
//删除与表:[GCVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVersionBL.DelRecord(strGcVersionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVersionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGcVersionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCVersionENS">源对象</param>
 /// <param name = "objGCVersionENT">目标对象</param>
 public static void CopyTo(clsGCVersionEN objGCVersionENS, clsGCVersionEN objGCVersionENT)
{
try
{
objGCVersionENT.GcVersionId = objGCVersionENS.GcVersionId; //生成代码版本Id
objGCVersionENT.GcVersionDescription = objGCVersionENS.GcVersionDescription; //版本说明
objGCVersionENT.VersionNumber = objGCVersionENS.VersionNumber; //版本号
objGCVersionENT.VersionCode = objGCVersionENS.VersionCode; //版本代码
objGCVersionENT.PublishDate = objGCVersionENS.PublishDate; //发布日期
objGCVersionENT.VersionState = objGCVersionENS.VersionState; //版本状态
objGCVersionENT.VersionUrl = objGCVersionENS.VersionUrl; //版本文件
objGCVersionENT.PrjId = objGCVersionENS.PrjId; //工程Id
objGCVersionENT.UpdDate = objGCVersionENS.UpdDate; //修改日期
objGCVersionENT.UpdUser = objGCVersionENS.UpdUser; //修改者
objGCVersionENT.Memo = objGCVersionENS.Memo; //说明
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
 /// <param name = "objGCVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsGCVersionEN objGCVersionEN)
{
try
{
objGCVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCVersion.GcVersionId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.GcVersionId = objGCVersionEN.GcVersionId; //生成代码版本Id
}
if (arrFldSet.Contains(conGCVersion.GcVersionDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.GcVersionDescription = objGCVersionEN.GcVersionDescription == "[null]" ? null :  objGCVersionEN.GcVersionDescription; //版本说明
}
if (arrFldSet.Contains(conGCVersion.VersionNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.VersionNumber = objGCVersionEN.VersionNumber; //版本号
}
if (arrFldSet.Contains(conGCVersion.VersionCode, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.VersionCode = objGCVersionEN.VersionCode == "[null]" ? null :  objGCVersionEN.VersionCode; //版本代码
}
if (arrFldSet.Contains(conGCVersion.PublishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.PublishDate = objGCVersionEN.PublishDate; //发布日期
}
if (arrFldSet.Contains(conGCVersion.VersionState, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.VersionState = objGCVersionEN.VersionState; //版本状态
}
if (arrFldSet.Contains(conGCVersion.VersionUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.VersionUrl = objGCVersionEN.VersionUrl == "[null]" ? null :  objGCVersionEN.VersionUrl; //版本文件
}
if (arrFldSet.Contains(conGCVersion.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.PrjId = objGCVersionEN.PrjId == "[null]" ? null :  objGCVersionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conGCVersion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.UpdDate = objGCVersionEN.UpdDate == "[null]" ? null :  objGCVersionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCVersion.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.UpdUser = objGCVersionEN.UpdUser == "[null]" ? null :  objGCVersionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCVersion.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVersionEN.Memo = objGCVersionEN.Memo == "[null]" ? null :  objGCVersionEN.Memo; //说明
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
 /// <param name = "objGCVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCVersionEN objGCVersionEN)
{
try
{
if (objGCVersionEN.GcVersionDescription == "[null]") objGCVersionEN.GcVersionDescription = null; //版本说明
if (objGCVersionEN.VersionCode == "[null]") objGCVersionEN.VersionCode = null; //版本代码
if (objGCVersionEN.VersionUrl == "[null]") objGCVersionEN.VersionUrl = null; //版本文件
if (objGCVersionEN.PrjId == "[null]") objGCVersionEN.PrjId = null; //工程Id
if (objGCVersionEN.UpdDate == "[null]") objGCVersionEN.UpdDate = null; //修改日期
if (objGCVersionEN.UpdUser == "[null]") objGCVersionEN.UpdUser = null; //修改者
if (objGCVersionEN.Memo == "[null]") objGCVersionEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCVersionEN objGCVersionEN)
{
 GCVersionDA.CheckPropertyNew(objGCVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCVersionEN objGCVersionEN)
{
 GCVersionDA.CheckProperty4Condition(objGCVersionEN);
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
if (clsGCVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVersionBL没有刷新缓存机制(clsGCVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by GcVersionId");
//if (arrGCVersionObjLstCache == null)
//{
//arrGCVersionObjLstCache = GCVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strGcVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVersionEN GetObjByGcVersionIdCache(string strGcVersionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCVersionEN._CurrTabName);
List<clsGCVersionEN> arrGCVersionObjLstCache = GetObjLstCache();
IEnumerable <clsGCVersionEN> arrGCVersionObjLst_Sel =
arrGCVersionObjLstCache
.Where(x=> x.GcVersionId == strGcVersionId 
);
if (arrGCVersionObjLst_Sel.Count() == 0)
{
   clsGCVersionEN obj = clsGCVersionBL.GetObjByGcVersionId(strGcVersionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCVersionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVersionEN> GetAllGCVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsGCVersionEN> arrGCVersionObjLstCache = GetObjLstCache(); 
return arrGCVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCVersionEN._CurrTabName);
List<clsGCVersionEN> arrGCVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCVersionObjLstCache;
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
string strKey = string.Format("{0}", clsGCVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCVersionEN._RefreshTimeLst.Count == 0) return "";
return clsGCVersionEN._RefreshTimeLst[clsGCVersionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsGCVersionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCVersionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strGcVersionId)
{
if (strInFldName != conGCVersion.GcVersionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCVersion._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCVersion._AttributeName));
throw new Exception(strMsg);
}
var objGCVersion = clsGCVersionBL.GetObjByGcVersionIdCache(strGcVersionId);
if (objGCVersion == null) return "";
return objGCVersion[strOutFldName].ToString();
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
int intRecCount = clsGCVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsGCVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCVersionDA.GetRecCount();
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
int intRecCount = clsGCVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCVersionEN objGCVersionCond)
{
List<clsGCVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVersion._AttributeName)
{
if (objGCVersionCond.IsUpdated(strFldName) == false) continue;
if (objGCVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVersionCond[strFldName].ToString());
}
else
{
if (objGCVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVersionCond[strFldName]));
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
 List<string> arrList = clsGCVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCVersionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVersionDA.SetFldValue(clsGCVersionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCVersionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVersionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVersionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVersionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCVersion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**生成代码版本Id*/ 
 strCreateTabCode.Append(" GcVersionId char(4) primary key, "); 
 // /**版本说明*/ 
 strCreateTabCode.Append(" GcVersionDescription varchar(1000) Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" VersionNumber varchar(50) not Null, "); 
 // /**版本代码*/ 
 strCreateTabCode.Append(" VersionCode varchar(50) Null, "); 
 // /**发布日期*/ 
 strCreateTabCode.Append(" PublishDate varchar(20) not Null, "); 
 // /**版本状态*/ 
 strCreateTabCode.Append(" VersionState bit Null, "); 
 // /**版本文件*/ 
 strCreateTabCode.Append(" VersionUrl varchar(500) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
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
}
 /// <summary>
 /// 生成代码版本(GCVersion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCVersion : clsCommFun4BL
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
clsGCVersionBL.ReFreshThisCache();
}
}

}