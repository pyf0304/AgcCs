
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckStatusBL
 表名:TabCheckStatus(00050568)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsTabCheckStatusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckStatusEN GetObj(this K_mId_TabCheckStatus myKey)
{
clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.TabCheckStatusDA.GetObjBymId(myKey.Value);
return objTabCheckStatusEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckStatusEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}]的数据已经存在!(in clsTabCheckStatusBL.AddNewRecord)", objTabCheckStatusEN.PrjId,objTabCheckStatusEN.PrjDataBaseId,objTabCheckStatusEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabCheckStatusBL.TabCheckStatusDA.AddNewRecordBySQL2(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
public static bool AddRecordEx(this clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckUniqueness = true)
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
objTabCheckStatusEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabCheckStatusEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],项目数据库Id(PrjDataBaseId)=[{1}],表ID(TabId)=[{2}])已经存在,不能重复!", objTabCheckStatusEN.PrjId, objTabCheckStatusEN.PrjDataBaseId, objTabCheckStatusEN.TabId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabCheckStatusEN.AddNewRecord();
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckStatusEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}]的数据已经存在!(in clsTabCheckStatusBL.AddNewRecordWithReturnKey)", objTabCheckStatusEN.PrjId,objTabCheckStatusEN.PrjDataBaseId,objTabCheckStatusEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabCheckStatusBL.TabCheckStatusDA.AddNewRecordBySQL2WithReturnKey(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetmId(this clsTabCheckStatusEN objTabCheckStatusEN, long lngmId, string strComparisonOp="")
	{
objTabCheckStatusEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.mId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.mId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.mId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetPrjId(this clsTabCheckStatusEN objTabCheckStatusEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabCheckStatus.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabCheckStatus.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabCheckStatus.PrjId);
}
objTabCheckStatusEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.PrjId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.PrjId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.PrjId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetPrjDataBaseId(this clsTabCheckStatusEN objTabCheckStatusEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, conTabCheckStatus.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
}
objTabCheckStatusEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.PrjDataBaseId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.PrjDataBaseId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.PrjDataBaseId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetTabId(this clsTabCheckStatusEN objTabCheckStatusEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabCheckStatus.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabCheckStatus.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabCheckStatus.TabId);
}
objTabCheckStatusEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.TabId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.TabId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.TabId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetIsNeedCheckTab(this clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedCheckTab, conTabCheckStatus.IsNeedCheckTab);
objTabCheckStatusEN.IsNeedCheckTab = bolIsNeedCheckTab; //是否需要检查表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.IsNeedCheckTab) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.IsNeedCheckTab, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.IsNeedCheckTab] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetErrorLevelId(this clsTabCheckStatusEN objTabCheckStatusEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, conTabCheckStatus.ErrorLevelId);
objTabCheckStatusEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.ErrorLevelId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.ErrorLevelId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.ErrorLevelId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetErrorMsg(this clsTabCheckStatusEN objTabCheckStatusEN, string strErrorMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, conTabCheckStatus.ErrorMsg);
}
objTabCheckStatusEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.ErrorMsg) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.ErrorMsg, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.ErrorMsg] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetTabCheckErrorTypeId(this clsTabCheckStatusEN objTabCheckStatusEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
}
objTabCheckStatusEN.TabCheckErrorTypeId = strTabCheckErrorTypeId; //表检查错误类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.TabCheckErrorTypeId) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.TabCheckErrorTypeId, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.TabCheckErrorTypeId] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetUpdDate(this clsTabCheckStatusEN objTabCheckStatusEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conTabCheckStatus.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabCheckStatus.UpdDate);
}
objTabCheckStatusEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.UpdDate) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.UpdDate, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.UpdDate] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetUpdUser(this clsTabCheckStatusEN objTabCheckStatusEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conTabCheckStatus.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabCheckStatus.UpdUser);
}
objTabCheckStatusEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.UpdUser) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.UpdUser, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.UpdUser] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckStatusEN SetMemo(this clsTabCheckStatusEN objTabCheckStatusEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabCheckStatus.Memo);
}
objTabCheckStatusEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckStatusEN.dicFldComparisonOp.ContainsKey(conTabCheckStatus.Memo) == false)
{
objTabCheckStatusEN.dicFldComparisonOp.Add(conTabCheckStatus.Memo, strComparisonOp);
}
else
{
objTabCheckStatusEN.dicFldComparisonOp[conTabCheckStatus.Memo] = strComparisonOp;
}
}
return objTabCheckStatusEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabCheckStatusEN objTabCheckStatusEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabCheckStatusEN.CheckPropertyNew();
clsTabCheckStatusEN objTabCheckStatusCond = new clsTabCheckStatusEN();
string strCondition = objTabCheckStatusCond
.SetmId(objTabCheckStatusEN.mId, "<>")
.SetPrjId(objTabCheckStatusEN.PrjId, "=")
.SetPrjDataBaseId(objTabCheckStatusEN.PrjDataBaseId, "=")
.SetTabId(objTabCheckStatusEN.TabId, "=")
.GetCombineCondition();
objTabCheckStatusEN._IsCheckProperty = true;
bool bolIsExist = clsTabCheckStatusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_PrjDataBaseId_TabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabCheckStatusEN.Update();
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
 /// <param name = "objTabCheckStatus">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabCheckStatusEN objTabCheckStatus)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabCheckStatusEN objTabCheckStatusCond = new clsTabCheckStatusEN();
string strCondition = objTabCheckStatusCond
.SetPrjId(objTabCheckStatus.PrjId, "=")
.SetPrjDataBaseId(objTabCheckStatus.PrjDataBaseId, "=")
.SetTabId(objTabCheckStatus.TabId, "=")
.GetCombineCondition();
objTabCheckStatus._IsCheckProperty = true;
bool bolIsExist = clsTabCheckStatusBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabCheckStatus.mId = clsTabCheckStatusBL.GetFirstID_S(strCondition);
objTabCheckStatus.UpdateWithCondition(strCondition);
}
else
{
objTabCheckStatus.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckStatusEN objTabCheckStatusEN)
{
 if (objTabCheckStatusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckStatusBL.TabCheckStatusDA.UpdateBySql2(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckStatusEN objTabCheckStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabCheckStatusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckStatusBL.TabCheckStatusDA.UpdateBySql2(objTabCheckStatusEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckStatusEN objTabCheckStatusEN, string strWhereCond)
{
try
{
bool bolResult = clsTabCheckStatusBL.TabCheckStatusDA.UpdateBySqlWithCondition(objTabCheckStatusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckStatusEN objTabCheckStatusEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabCheckStatusBL.TabCheckStatusDA.UpdateBySqlWithConditionTransaction(objTabCheckStatusEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
public static int Delete(this clsTabCheckStatusEN objTabCheckStatusEN)
{
try
{
int intRecNum = clsTabCheckStatusBL.TabCheckStatusDA.DelRecord(objTabCheckStatusEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusENS">源对象</param>
 /// <param name = "objTabCheckStatusENT">目标对象</param>
 public static void CopyTo(this clsTabCheckStatusEN objTabCheckStatusENS, clsTabCheckStatusEN objTabCheckStatusENT)
{
try
{
objTabCheckStatusENT.mId = objTabCheckStatusENS.mId; //mId
objTabCheckStatusENT.PrjId = objTabCheckStatusENS.PrjId; //工程Id
objTabCheckStatusENT.PrjDataBaseId = objTabCheckStatusENS.PrjDataBaseId; //项目数据库Id
objTabCheckStatusENT.TabId = objTabCheckStatusENS.TabId; //表ID
objTabCheckStatusENT.IsNeedCheckTab = objTabCheckStatusENS.IsNeedCheckTab; //是否需要检查表字段
objTabCheckStatusENT.ErrorLevelId = objTabCheckStatusENS.ErrorLevelId; //错误等级Id
objTabCheckStatusENT.ErrorMsg = objTabCheckStatusENS.ErrorMsg; //错误信息
objTabCheckStatusENT.TabCheckErrorTypeId = objTabCheckStatusENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckStatusENT.UpdDate = objTabCheckStatusENS.UpdDate; //修改日期
objTabCheckStatusENT.UpdUser = objTabCheckStatusENS.UpdUser; //修改者
objTabCheckStatusENT.Memo = objTabCheckStatusENS.Memo; //说明
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
 /// <param name = "objTabCheckStatusENS">源对象</param>
 /// <returns>目标对象=>clsTabCheckStatusEN:objTabCheckStatusENT</returns>
 public static clsTabCheckStatusEN CopyTo(this clsTabCheckStatusEN objTabCheckStatusENS)
{
try
{
 clsTabCheckStatusEN objTabCheckStatusENT = new clsTabCheckStatusEN()
{
mId = objTabCheckStatusENS.mId, //mId
PrjId = objTabCheckStatusENS.PrjId, //工程Id
PrjDataBaseId = objTabCheckStatusENS.PrjDataBaseId, //项目数据库Id
TabId = objTabCheckStatusENS.TabId, //表ID
IsNeedCheckTab = objTabCheckStatusENS.IsNeedCheckTab, //是否需要检查表字段
ErrorLevelId = objTabCheckStatusENS.ErrorLevelId, //错误等级Id
ErrorMsg = objTabCheckStatusENS.ErrorMsg, //错误信息
TabCheckErrorTypeId = objTabCheckStatusENS.TabCheckErrorTypeId, //表检查错误类型Id
UpdDate = objTabCheckStatusENS.UpdDate, //修改日期
UpdUser = objTabCheckStatusENS.UpdUser, //修改者
Memo = objTabCheckStatusENS.Memo, //说明
};
 return objTabCheckStatusENT;
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
public static void CheckPropertyNew(this clsTabCheckStatusEN objTabCheckStatusEN)
{
 clsTabCheckStatusBL.TabCheckStatusDA.CheckPropertyNew(objTabCheckStatusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabCheckStatusEN objTabCheckStatusEN)
{
 clsTabCheckStatusBL.TabCheckStatusDA.CheckProperty4Condition(objTabCheckStatusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabCheckStatusEN objTabCheckStatusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.mId) == true)
{
string strComparisonOpmId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckStatus.mId, objTabCheckStatusCond.mId, strComparisonOpmId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.PrjId) == true)
{
string strComparisonOpPrjId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.PrjId, objTabCheckStatusCond.PrjId, strComparisonOpPrjId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.PrjDataBaseId, objTabCheckStatusCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.TabId) == true)
{
string strComparisonOpTabId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.TabId, objTabCheckStatusCond.TabId, strComparisonOpTabId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.IsNeedCheckTab) == true)
{
if (objTabCheckStatusCond.IsNeedCheckTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabCheckStatus.IsNeedCheckTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabCheckStatus.IsNeedCheckTab);
}
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckStatus.ErrorLevelId, objTabCheckStatusCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.ErrorMsg, objTabCheckStatusCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId) == true)
{
string strComparisonOpTabCheckErrorTypeId = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.TabCheckErrorTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.TabCheckErrorTypeId, objTabCheckStatusCond.TabCheckErrorTypeId, strComparisonOpTabCheckErrorTypeId);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.UpdDate, objTabCheckStatusCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.UpdUser, objTabCheckStatusCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabCheckStatusCond.IsUpdated(conTabCheckStatus.Memo) == true)
{
string strComparisonOpMemo = objTabCheckStatusCond.dicFldComparisonOp[conTabCheckStatus.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckStatus.Memo, objTabCheckStatusCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabCheckStatus(表检查状态), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabCheckStatusEN objTabCheckStatusEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckStatusEN == null) return true;
if (objTabCheckStatusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
if (clsTabCheckStatusBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckStatusEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
if (clsTabCheckStatusBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TabCheckStatus(表检查状态), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabCheckStatusEN objTabCheckStatusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckStatusEN == null) return "";
if (objTabCheckStatusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckStatusEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabCheckStatus
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表检查状态(TabCheckStatus)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabCheckStatusBL
{
public static RelatedActions_TabCheckStatus relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabCheckStatusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabCheckStatusDA TabCheckStatusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabCheckStatusDA();
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
 public clsTabCheckStatusBL()
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
if (string.IsNullOrEmpty(clsTabCheckStatusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabCheckStatusEN._ConnectString);
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
public static DataTable GetDataTable_TabCheckStatus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabCheckStatusDA.GetDataTable_TabCheckStatus(strWhereCond);
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
objDT = TabCheckStatusDA.GetDataTable(strWhereCond);
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
objDT = TabCheckStatusDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabCheckStatusDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabCheckStatusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabCheckStatusDA.GetDataTable_Top(objTopPara);
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
objDT = TabCheckStatusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabCheckStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabCheckStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsTabCheckStatusEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
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
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabCheckStatusEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrTabCheckStatusObjLst_Sel =
arrTabCheckStatusObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTabCheckStatusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLst(string strWhereCond)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
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
public static List<clsTabCheckStatusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabCheckStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabCheckStatusEN> GetSubObjLstCache(clsTabCheckStatusEN objTabCheckStatusCond)
{
 string strPrjId = objTabCheckStatusCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsTabCheckStatusBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsTabCheckStatusEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckStatus._AttributeName)
{
if (objTabCheckStatusCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckStatusCond[strFldName].ToString());
}
else
{
if (objTabCheckStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckStatusCond[strFldName]));
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
public static List<clsTabCheckStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
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
public static List<clsTabCheckStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
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
List<clsTabCheckStatusEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabCheckStatusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabCheckStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
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
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
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
public static List<clsTabCheckStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabCheckStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
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
public static List<clsTabCheckStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckStatusEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabCheckStatus(ref clsTabCheckStatusEN objTabCheckStatusEN)
{
bool bolResult = TabCheckStatusDA.GetTabCheckStatus(ref objTabCheckStatusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckStatusEN GetObjBymId(long lngmId)
{
clsTabCheckStatusEN objTabCheckStatusEN = TabCheckStatusDA.GetObjBymId(lngmId);
return objTabCheckStatusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabCheckStatusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabCheckStatusEN objTabCheckStatusEN = TabCheckStatusDA.GetFirstObj(strWhereCond);
 return objTabCheckStatusEN;
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
public static clsTabCheckStatusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabCheckStatusEN objTabCheckStatusEN = TabCheckStatusDA.GetObjByDataRow(objRow);
 return objTabCheckStatusEN;
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
public static clsTabCheckStatusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabCheckStatusEN objTabCheckStatusEN = TabCheckStatusDA.GetObjByDataRow(objRow);
 return objTabCheckStatusEN;
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
 /// <param name = "lstTabCheckStatusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckStatusEN GetObjBymIdFromList(long lngmId, List<clsTabCheckStatusEN> lstTabCheckStatusObjLst)
{
foreach (clsTabCheckStatusEN objTabCheckStatusEN in lstTabCheckStatusObjLst)
{
if (objTabCheckStatusEN.mId == lngmId)
{
return objTabCheckStatusEN;
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
 lngmId = new clsTabCheckStatusDA().GetFirstID(strWhereCond);
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
 arrList = TabCheckStatusDA.GetID(strWhereCond);
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
bool bolIsExist = TabCheckStatusDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = TabCheckStatusDA.IsExist(lngmId);
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
clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.GetObjBymId(lngmId);
objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTabCheckStatusEN.UpdUser = strOpUser;
return clsTabCheckStatusBL.UpdateBySql2(objTabCheckStatusEN);
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
 bolIsExist = clsTabCheckStatusDA.IsExistTable();
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
 bolIsExist = TabCheckStatusDA.IsExistTable(strTabName);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckStatusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}]的数据已经存在!(in clsTabCheckStatusBL.AddNewRecordBySql2)", objTabCheckStatusEN.PrjId,objTabCheckStatusEN.PrjDataBaseId,objTabCheckStatusEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabCheckStatusDA.AddNewRecordBySQL2(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabCheckStatusEN objTabCheckStatusEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckStatusEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}]的数据已经存在!(in clsTabCheckStatusBL.AddNewRecordBySql2WithReturnKey)", objTabCheckStatusEN.PrjId,objTabCheckStatusEN.PrjDataBaseId,objTabCheckStatusEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = TabCheckStatusDA.AddNewRecordBySQL2WithReturnKey(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabCheckStatusEN objTabCheckStatusEN)
{
try
{
bool bolResult = TabCheckStatusDA.Update(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabCheckStatusEN objTabCheckStatusEN)
{
 if (objTabCheckStatusEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabCheckStatusDA.UpdateBySql2(objTabCheckStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckStatusBL.ReFreshCache(objTabCheckStatusEN.PrjId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
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
 clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.GetObjBymId(lngmId);

if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(objTabCheckStatusEN.mId, objTabCheckStatusEN.UpdUser);
}
if (objTabCheckStatusEN != null)
{
int intRecNum = TabCheckStatusDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabCheckStatusEN.PrjId);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
//删除与表:[TabCheckStatus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabCheckStatus.mId,
//lngmId);
//        clsTabCheckStatusBL.DelTabCheckStatussByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckStatusBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckStatusBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabCheckStatusBL.relatedActions != null)
{
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TabCheckStatusDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabCheckStatuss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTabCheckStatusBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = TabCheckStatusDA.DelTabCheckStatus(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabCheckStatusEN.PrjId);
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
public static int DelTabCheckStatussByCond(string strWhereCond)
{
try
{
if (clsTabCheckStatusBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTabCheckStatusBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conTabCheckStatus.PrjId, strWhereCond);
int intRecNum = TabCheckStatusDA.DelTabCheckStatus(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabCheckStatus]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
//删除与表:[TabCheckStatus]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckStatusBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckStatusBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objTabCheckStatusENS">源对象</param>
 /// <param name = "objTabCheckStatusENT">目标对象</param>
 public static void CopyTo(clsTabCheckStatusEN objTabCheckStatusENS, clsTabCheckStatusEN objTabCheckStatusENT)
{
try
{
objTabCheckStatusENT.mId = objTabCheckStatusENS.mId; //mId
objTabCheckStatusENT.PrjId = objTabCheckStatusENS.PrjId; //工程Id
objTabCheckStatusENT.PrjDataBaseId = objTabCheckStatusENS.PrjDataBaseId; //项目数据库Id
objTabCheckStatusENT.TabId = objTabCheckStatusENS.TabId; //表ID
objTabCheckStatusENT.IsNeedCheckTab = objTabCheckStatusENS.IsNeedCheckTab; //是否需要检查表字段
objTabCheckStatusENT.ErrorLevelId = objTabCheckStatusENS.ErrorLevelId; //错误等级Id
objTabCheckStatusENT.ErrorMsg = objTabCheckStatusENS.ErrorMsg; //错误信息
objTabCheckStatusENT.TabCheckErrorTypeId = objTabCheckStatusENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckStatusENT.UpdDate = objTabCheckStatusENS.UpdDate; //修改日期
objTabCheckStatusENT.UpdUser = objTabCheckStatusENS.UpdUser; //修改者
objTabCheckStatusENT.Memo = objTabCheckStatusENS.Memo; //说明
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
 /// <param name = "objTabCheckStatusEN">源简化对象</param>
 public static void SetUpdFlag(clsTabCheckStatusEN objTabCheckStatusEN)
{
try
{
objTabCheckStatusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabCheckStatusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabCheckStatus.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.mId = objTabCheckStatusEN.mId; //mId
}
if (arrFldSet.Contains(conTabCheckStatus.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.PrjId = objTabCheckStatusEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabCheckStatus.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.PrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(conTabCheckStatus.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.TabId = objTabCheckStatusEN.TabId; //表ID
}
if (arrFldSet.Contains(conTabCheckStatus.IsNeedCheckTab, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.IsNeedCheckTab = objTabCheckStatusEN.IsNeedCheckTab; //是否需要检查表字段
}
if (arrFldSet.Contains(conTabCheckStatus.ErrorLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.ErrorLevelId = objTabCheckStatusEN.ErrorLevelId; //错误等级Id
}
if (arrFldSet.Contains(conTabCheckStatus.ErrorMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.ErrorMsg = objTabCheckStatusEN.ErrorMsg == "[null]" ? null :  objTabCheckStatusEN.ErrorMsg; //错误信息
}
if (arrFldSet.Contains(conTabCheckStatus.TabCheckErrorTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.TabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId == "[null]" ? null :  objTabCheckStatusEN.TabCheckErrorTypeId; //表检查错误类型Id
}
if (arrFldSet.Contains(conTabCheckStatus.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.UpdDate = objTabCheckStatusEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTabCheckStatus.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.UpdUser = objTabCheckStatusEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conTabCheckStatus.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckStatusEN.Memo = objTabCheckStatusEN.Memo == "[null]" ? null :  objTabCheckStatusEN.Memo; //说明
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
 /// <param name = "objTabCheckStatusEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabCheckStatusEN objTabCheckStatusEN)
{
try
{
if (objTabCheckStatusEN.ErrorMsg == "[null]") objTabCheckStatusEN.ErrorMsg = null; //错误信息
if (objTabCheckStatusEN.TabCheckErrorTypeId == "[null]") objTabCheckStatusEN.TabCheckErrorTypeId = null; //表检查错误类型Id
if (objTabCheckStatusEN.Memo == "[null]") objTabCheckStatusEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTabCheckStatusEN objTabCheckStatusEN)
{
 TabCheckStatusDA.CheckPropertyNew(objTabCheckStatusEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabCheckStatusEN objTabCheckStatusEN)
{
 TabCheckStatusDA.CheckProperty4Condition(objTabCheckStatusEN);
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
if (clsTabCheckStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckStatusBL没有刷新缓存机制(clsTabCheckStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTabCheckStatusObjLstCache == null)
//{
//arrTabCheckStatusObjLstCache = TabCheckStatusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckStatusEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrTabCheckStatusObjLst_Sel =
arrTabCheckStatusObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTabCheckStatusObjLst_Sel.Count() == 0)
{
   clsTabCheckStatusEN obj = clsTabCheckStatusBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrTabCheckStatusObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckStatusEN> GetAllTabCheckStatusObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = GetObjLstCache(strPrjId); 
return arrTabCheckStatusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckStatusEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsTabCheckStatusEN> arrTabCheckStatusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrTabCheckStatusObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabCheckStatusEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabCheckStatusEN._RefreshTimeLst.Count == 0) return "";
return clsTabCheckStatusEN._RefreshTimeLst[clsTabCheckStatusEN._RefreshTimeLst.Count - 1];
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
if (clsTabCheckStatusBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabCheckStatusEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabCheckStatusEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabCheckStatusBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabCheckStatus(表检查状态)
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabCheckStatusEN objTabCheckStatusEN)
{
//检测记录是否存在
string strResult = TabCheckStatusDA.GetUniCondStr(objTabCheckStatusEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conTabCheckStatus.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabCheckStatus._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabCheckStatus._AttributeName));
throw new Exception(strMsg);
}
var objTabCheckStatus = clsTabCheckStatusBL.GetObjBymIdCache(lngmId, strPrjId);
if (objTabCheckStatus == null) return "";
return objTabCheckStatus[strOutFldName].ToString();
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
int intRecCount = clsTabCheckStatusDA.GetRecCount(strTabName);
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
int intRecCount = clsTabCheckStatusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabCheckStatusDA.GetRecCount();
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
int intRecCount = clsTabCheckStatusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabCheckStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabCheckStatusEN objTabCheckStatusCond)
{
 string strPrjId = objTabCheckStatusCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsTabCheckStatusBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsTabCheckStatusEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabCheckStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckStatus._AttributeName)
{
if (objTabCheckStatusCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckStatusCond[strFldName].ToString());
}
else
{
if (objTabCheckStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckStatusCond[strFldName]));
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
 List<string> arrList = clsTabCheckStatusDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabCheckStatusDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabCheckStatusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabCheckStatusDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabCheckStatusDA.SetFldValue(clsTabCheckStatusEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabCheckStatusDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabCheckStatusDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabCheckStatusDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabCheckStatusDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabCheckStatus] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**项目数据库Id*/ 
 strCreateTabCode.Append(" PrjDataBaseId char(4) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**是否需要检查表字段*/ 
 strCreateTabCode.Append(" IsNeedCheckTab bit not Null, "); 
 // /**错误等级Id*/ 
 strCreateTabCode.Append(" ErrorLevelId int not Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrorMsg varchar(5000) Null, "); 
 // /**表检查错误类型Id*/ 
 strCreateTabCode.Append(" TabCheckErrorTypeId char(2) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 表检查状态(TabCheckStatus)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabCheckStatus : clsCommFun4BLV2
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
clsTabCheckStatusBL.ReFreshThisCache(strPrjId);
}
}

}