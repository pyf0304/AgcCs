
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProgLangTypeBL
 表名:ProgLangType(00050303)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:04
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
public static class  clsProgLangTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProgLangTypeEN GetObj(this K_ProgLangTypeId_ProgLangType myKey)
{
clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.ProgLangTypeDA.GetObjByProgLangTypeId(myKey.Value);
return objProgLangTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsProgLangTypeEN objProgLangTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objProgLangTypeEN.ProgLangTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsProgLangTypeBL.ProgLangTypeDA.AddNewRecordBySQL2(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clsProgLangTypeEN objProgLangTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objProgLangTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objProgLangTypeEN.AddNewRecord();
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsProgLangTypeEN objProgLangTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objProgLangTypeEN.ProgLangTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsProgLangTypeBL.ProgLangTypeDA.AddNewRecordBySQL2WithReturnKey(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeId(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conProgLangType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conProgLangType.ProgLangTypeId);
}
objProgLangTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, conProgLangType.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, conProgLangType.ProgLangTypeName);
}
objProgLangTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeSimName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, conProgLangType.ProgLangTypeSimName);
}
objProgLangTypeEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeSimName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeSimName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeSimName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeENName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, conProgLangType.ProgLangTypeENName);
}
objProgLangTypeEN.ProgLangTypeENName = strProgLangTypeENName; //编程语言类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeENName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeENName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeENName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetCharEncodingId(this clsProgLangTypeEN objProgLangTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, conProgLangType.CharEncodingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, conProgLangType.CharEncodingId);
}
objProgLangTypeEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.CharEncodingId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.CharEncodingId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.CharEncodingId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetIsVisible(this clsProgLangTypeEN objProgLangTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objProgLangTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.IsVisible) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.IsVisible, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.IsVisible] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetOrderNum(this clsProgLangTypeEN objProgLangTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conProgLangType.OrderNum);
objProgLangTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.OrderNum) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.OrderNum, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.OrderNum] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetUpdDate(this clsProgLangTypeEN objProgLangTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conProgLangType.UpdDate);
}
objProgLangTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.UpdDate) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.UpdDate, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.UpdDate] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetUpdUserId(this clsProgLangTypeEN objProgLangTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conProgLangType.UpdUserId);
}
objProgLangTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.UpdUserId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.UpdUserId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.UpdUserId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetMemo(this clsProgLangTypeEN objProgLangTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conProgLangType.Memo);
}
objProgLangTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.Memo) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.Memo, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.Memo] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsProgLangTypeEN objProgLangTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objProgLangTypeEN.CheckPropertyNew();
clsProgLangTypeEN objProgLangTypeCond = new clsProgLangTypeEN();
string strCondition = objProgLangTypeCond
.SetProgLangTypeId(objProgLangTypeEN.ProgLangTypeId, "=")
.GetCombineCondition();
objProgLangTypeEN._IsCheckProperty = true;
bool bolIsExist = clsProgLangTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objProgLangTypeEN.Update();
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProgLangTypeEN objProgLangTypeEN)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsProgLangTypeBL.ProgLangTypeDA.UpdateBySql2(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProgLangTypeEN objProgLangTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsProgLangTypeBL.ProgLangTypeDA.UpdateBySql2(objProgLangTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProgLangTypeEN objProgLangTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsProgLangTypeBL.ProgLangTypeDA.UpdateBySqlWithCondition(objProgLangTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProgLangTypeEN objProgLangTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsProgLangTypeBL.ProgLangTypeDA.UpdateBySqlWithConditionTransaction(objProgLangTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsProgLangTypeEN objProgLangTypeEN)
{
try
{
int intRecNum = clsProgLangTypeBL.ProgLangTypeDA.DelRecord(objProgLangTypeEN.ProgLangTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
 public static void CopyTo(this clsProgLangTypeEN objProgLangTypeENS, clsProgLangTypeEN objProgLangTypeENT)
{
try
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
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
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <returns>目标对象=>clsProgLangTypeEN:objProgLangTypeENT</returns>
 public static clsProgLangTypeEN CopyTo(this clsProgLangTypeEN objProgLangTypeENS)
{
try
{
 clsProgLangTypeEN objProgLangTypeENT = new clsProgLangTypeEN()
{
ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName, //编程语言类型简称
ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName, //编程语言类型英文名
CharEncodingId = objProgLangTypeENS.CharEncodingId, //字符编码
IsVisible = objProgLangTypeENS.IsVisible, //是否显示
OrderNum = objProgLangTypeENS.OrderNum, //序号
UpdDate = objProgLangTypeENS.UpdDate, //修改日期
UpdUserId = objProgLangTypeENS.UpdUserId, //修改用户Id
Memo = objProgLangTypeENS.Memo, //说明
};
 return objProgLangTypeENT;
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
public static void CheckPropertyNew(this clsProgLangTypeEN objProgLangTypeEN)
{
 clsProgLangTypeBL.ProgLangTypeDA.CheckPropertyNew(objProgLangTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsProgLangTypeEN objProgLangTypeEN)
{
 clsProgLangTypeBL.ProgLangTypeDA.CheckProperty4Condition(objProgLangTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsProgLangTypeEN objProgLangTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeId, objProgLangTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeName, objProgLangTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeSimName, objProgLangTypeCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeENName) == true)
{
string strComparisonOpProgLangTypeENName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeENName, objProgLangTypeCond.ProgLangTypeENName, strComparisonOpProgLangTypeENName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.CharEncodingId, objProgLangTypeCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.IsVisible) == true)
{
if (objProgLangTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProgLangType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProgLangType.IsVisible);
}
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.OrderNum) == true)
{
string strComparisonOpOrderNum = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conProgLangType.OrderNum, objProgLangTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.UpdDate) == true)
{
string strComparisonOpUpdDate = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.UpdDate, objProgLangTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.UpdUserId, objProgLangTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.Memo) == true)
{
string strComparisonOpMemo = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.Memo, objProgLangTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ProgLangType
{
public virtual bool UpdRelaTabDate(string strProgLangTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumProgLangType
{
 /// <summary>
 /// AA0
 /// </summary>
public const string AA0_00 = "00";
 /// <summary>
 /// CSharp
 /// </summary>
public const string CSharp_01 = "01";
 /// <summary>
 /// JAVA
 /// </summary>
public const string JAVA_02 = "02";
 /// <summary>
 /// Swift
 /// </summary>
public const string Swift_03 = "03";
 /// <summary>
 /// JavaScript
 /// </summary>
public const string JavaScript_04 = "04";
 /// <summary>
 /// SilverLight
 /// </summary>
public const string SilverLight_05 = "05";
 /// <summary>
 /// VB
 /// </summary>
public const string VB_06 = "06";
 /// <summary>
 /// Swift3
 /// </summary>
public const string Swift3_07 = "07";
 /// <summary>
 /// Swift4
 /// </summary>
public const string Swift4_08 = "08";
 /// <summary>
 /// TypeScript
 /// </summary>
public const string TypeScript_09 = "09";
 /// <summary>
 /// Html
 /// </summary>
public const string Html_10 = "10";
}
 /// <summary>
 /// 编程语言类型(ProgLangType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsProgLangTypeBL
{
public static RelatedActions_ProgLangType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsProgLangTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsProgLangTypeDA ProgLangTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsProgLangTypeDA();
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
 public clsProgLangTypeBL()
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
if (string.IsNullOrEmpty(clsProgLangTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsProgLangTypeEN._ConnectString);
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
public static DataTable GetDataTable_ProgLangType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ProgLangTypeDA.GetDataTable_ProgLangType(strWhereCond);
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
objDT = ProgLangTypeDA.GetDataTable(strWhereCond);
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
objDT = ProgLangTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ProgLangTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ProgLangTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ProgLangTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ProgLangTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ProgLangTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ProgLangTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrProgLangTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstByProgLangTypeIdLst(List<string> arrProgLangTypeIdLst)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProgLangTypeIdLst, true);
 string strWhereCond = string.Format("ProgLangTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProgLangTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsProgLangTypeEN> GetObjLstByProgLangTypeIdLstCache(List<string> arrProgLangTypeIdLst)
{
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel =
arrProgLangTypeObjLstCache
.Where(x => arrProgLangTypeIdLst.Contains(x.ProgLangTypeId));
return arrProgLangTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLst(string strWhereCond)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
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
public static List<clsProgLangTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objProgLangTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsProgLangTypeEN> GetSubObjLstCache(clsProgLangTypeEN objProgLangTypeCond)
{
List<clsProgLangTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conProgLangType._AttributeName)
{
if (objProgLangTypeCond.IsUpdated(strFldName) == false) continue;
if (objProgLangTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProgLangTypeCond[strFldName].ToString());
}
else
{
if (objProgLangTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objProgLangTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProgLangTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objProgLangTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objProgLangTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objProgLangTypeCond[strFldName]));
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
public static List<clsProgLangTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
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
public static List<clsProgLangTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
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
List<clsProgLangTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsProgLangTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsProgLangTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
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
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
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
public static List<clsProgLangTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsProgLangTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
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
public static List<clsProgLangTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsProgLangTypeEN> arrObjLst = new List<clsProgLangTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN();
try
{
objProgLangTypeEN.ProgLangTypeId = objRow[conProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objProgLangTypeEN.ProgLangTypeName = objRow[conProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objProgLangTypeEN.ProgLangTypeSimName = objRow[conProgLangType.ProgLangTypeSimName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objProgLangTypeEN.ProgLangTypeENName = objRow[conProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[conProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objProgLangTypeEN.CharEncodingId = objRow[conProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conProgLangType.IsVisible].ToString().Trim()); //是否显示
objProgLangTypeEN.OrderNum = Int32.Parse(objRow[conProgLangType.OrderNum].ToString().Trim()); //序号
objProgLangTypeEN.UpdDate = objRow[conProgLangType.UpdDate] == DBNull.Value ? null : objRow[conProgLangType.UpdDate].ToString().Trim(); //修改日期
objProgLangTypeEN.UpdUserId = objRow[conProgLangType.UpdUserId] == DBNull.Value ? null : objRow[conProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objProgLangTypeEN.Memo = objRow[conProgLangType.Memo] == DBNull.Value ? null : objRow[conProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProgLangTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objProgLangTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetProgLangType(ref clsProgLangTypeEN objProgLangTypeEN)
{
bool bolResult = ProgLangTypeDA.GetProgLangType(ref objProgLangTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProgLangTypeEN GetObjByProgLangTypeId(string strProgLangTypeId)
{
if (strProgLangTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProgLangTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProgLangTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProgLangTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsProgLangTypeEN objProgLangTypeEN = ProgLangTypeDA.GetObjByProgLangTypeId(strProgLangTypeId);
return objProgLangTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsProgLangTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsProgLangTypeEN objProgLangTypeEN = ProgLangTypeDA.GetFirstObj(strWhereCond);
 return objProgLangTypeEN;
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
public static clsProgLangTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsProgLangTypeEN objProgLangTypeEN = ProgLangTypeDA.GetObjByDataRow(objRow);
 return objProgLangTypeEN;
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
public static clsProgLangTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsProgLangTypeEN objProgLangTypeEN = ProgLangTypeDA.GetObjByDataRow(objRow);
 return objProgLangTypeEN;
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
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <param name = "lstProgLangTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProgLangTypeEN GetObjByProgLangTypeIdFromList(string strProgLangTypeId, List<clsProgLangTypeEN> lstProgLangTypeObjLst)
{
foreach (clsProgLangTypeEN objProgLangTypeEN in lstProgLangTypeObjLst)
{
if (objProgLangTypeEN.ProgLangTypeId == strProgLangTypeId)
{
return objProgLangTypeEN;
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
 string strProgLangTypeId;
 try
 {
 strProgLangTypeId = new clsProgLangTypeDA().GetFirstID(strWhereCond);
 return strProgLangTypeId;
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
 arrList = ProgLangTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ProgLangTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProgLangTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ProgLangTypeDA.IsExist(strProgLangTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strProgLangTypeId">编程语言类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strProgLangTypeId, string strOpUser)
{
clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeId(strProgLangTypeId);
objProgLangTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objProgLangTypeEN.UpdUserId = strOpUser;
return clsProgLangTypeBL.UpdateBySql2(objProgLangTypeEN);
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
 bolIsExist = clsProgLangTypeDA.IsExistTable();
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
 bolIsExist = ProgLangTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsProgLangTypeEN objProgLangTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objProgLangTypeEN.ProgLangTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ProgLangTypeDA.AddNewRecordBySQL2(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsProgLangTypeEN objProgLangTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsProgLangTypeBL.IsExist(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objProgLangTypeEN.ProgLangTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ProgLangTypeDA.AddNewRecordBySQL2WithReturnKey(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsProgLangTypeEN objProgLangTypeEN)
{
try
{
bool bolResult = ProgLangTypeDA.Update(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsProgLangTypeEN objProgLangTypeEN)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ProgLangTypeDA.UpdateBySql2(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeBL.ReFreshCache();

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
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
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strProgLangTypeId)
{
try
{
 clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeId(strProgLangTypeId);

if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(objProgLangTypeEN.ProgLangTypeId, objProgLangTypeEN.UpdUserId);
}
if (objProgLangTypeEN != null)
{
int intRecNum = ProgLangTypeDA.DelRecord(strProgLangTypeId);
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
/// <param name="strProgLangTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strProgLangTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsProgLangTypeDA.GetSpecSQLObj();
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
//删除与表:[ProgLangType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conProgLangType.ProgLangTypeId,
//strProgLangTypeId);
//        clsProgLangTypeBL.DelProgLangTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsProgLangTypeBL.DelRecord(strProgLangTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsProgLangTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strProgLangTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strProgLangTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsProgLangTypeBL.relatedActions != null)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(strProgLangTypeId, "UpdRelaTabDate");
}
bool bolResult = ProgLangTypeDA.DelRecord(strProgLangTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrProgLangTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelProgLangTypes(List<string> arrProgLangTypeIdLst)
{
if (arrProgLangTypeIdLst.Count == 0) return 0;
try
{
if (clsProgLangTypeBL.relatedActions != null)
{
foreach (var strProgLangTypeId in arrProgLangTypeIdLst)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(strProgLangTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ProgLangTypeDA.DelProgLangType(arrProgLangTypeIdLst);
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
public static int DelProgLangTypesByCond(string strWhereCond)
{
try
{
if (clsProgLangTypeBL.relatedActions != null)
{
List<string> arrProgLangTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strProgLangTypeId in arrProgLangTypeId)
{
clsProgLangTypeBL.relatedActions.UpdRelaTabDate(strProgLangTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ProgLangTypeDA.DelProgLangType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ProgLangType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strProgLangTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strProgLangTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsProgLangTypeDA.GetSpecSQLObj();
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
//删除与表:[ProgLangType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsProgLangTypeBL.DelRecord(strProgLangTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsProgLangTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strProgLangTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
 public static void CopyTo(clsProgLangTypeEN objProgLangTypeENS, clsProgLangTypeEN objProgLangTypeENT)
{
try
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
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
 /// <param name = "objProgLangTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsProgLangTypeEN objProgLangTypeEN)
{
try
{
objProgLangTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objProgLangTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conProgLangType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.ProgLangTypeId = objProgLangTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conProgLangType.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.ProgLangTypeName = objProgLangTypeEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(conProgLangType.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.ProgLangTypeSimName = objProgLangTypeEN.ProgLangTypeSimName == "[null]" ? null :  objProgLangTypeEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(conProgLangType.ProgLangTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.ProgLangTypeENName = objProgLangTypeEN.ProgLangTypeENName == "[null]" ? null :  objProgLangTypeEN.ProgLangTypeENName; //编程语言类型英文名
}
if (arrFldSet.Contains(conProgLangType.CharEncodingId, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.CharEncodingId = objProgLangTypeEN.CharEncodingId; //字符编码
}
if (arrFldSet.Contains(conProgLangType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.IsVisible = objProgLangTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conProgLangType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.OrderNum = objProgLangTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conProgLangType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.UpdDate = objProgLangTypeEN.UpdDate == "[null]" ? null :  objProgLangTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conProgLangType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.UpdUserId = objProgLangTypeEN.UpdUserId == "[null]" ? null :  objProgLangTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conProgLangType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objProgLangTypeEN.Memo = objProgLangTypeEN.Memo == "[null]" ? null :  objProgLangTypeEN.Memo; //说明
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
 /// <param name = "objProgLangTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsProgLangTypeEN objProgLangTypeEN)
{
try
{
if (objProgLangTypeEN.ProgLangTypeSimName == "[null]") objProgLangTypeEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objProgLangTypeEN.ProgLangTypeENName == "[null]") objProgLangTypeEN.ProgLangTypeENName = null; //编程语言类型英文名
if (objProgLangTypeEN.UpdDate == "[null]") objProgLangTypeEN.UpdDate = null; //修改日期
if (objProgLangTypeEN.UpdUserId == "[null]") objProgLangTypeEN.UpdUserId = null; //修改用户Id
if (objProgLangTypeEN.Memo == "[null]") objProgLangTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsProgLangTypeEN objProgLangTypeEN)
{
 ProgLangTypeDA.CheckPropertyNew(objProgLangTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsProgLangTypeEN objProgLangTypeEN)
{
 ProgLangTypeDA.CheckProperty4Condition(objProgLangTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ProgLangTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conProgLangType.ProgLangTypeId); 
List<clsProgLangTypeEN> arrObjLst = clsProgLangTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN()
{
ProgLangTypeId = "0",
ProgLangTypeName = "选[编程语言类型]..."
};
arrObjLst.Insert(0, objProgLangTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conProgLangType.ProgLangTypeId;
objComboBox.DisplayMember = conProgLangType.ProgLangTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[编程语言类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conProgLangType.ProgLangTypeId); 
IEnumerable<clsProgLangTypeEN> arrObjLst = clsProgLangTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum);
objDDL.DataValueField = conProgLangType.ProgLangTypeId;
objDDL.DataTextField = conProgLangType.ProgLangTypeName;
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
public static void BindDdl_ProgLangTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[编程语言类型]...","0");
List<clsProgLangTypeEN> arrProgLangTypeObjLst = GetAllProgLangTypeObjLstCache(); 
objDDL.DataValueField = conProgLangType.ProgLangTypeId;
objDDL.DataTextField = conProgLangType.ProgLangTypeName;
objDDL.DataSource = arrProgLangTypeObjLst;
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
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProgLangTypeId");
//if (arrProgLangTypeObjLstCache == null)
//{
//arrProgLangTypeObjLstCache = ProgLangTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProgLangTypeEN GetObjByProgLangTypeIdCache(string strProgLangTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel =
arrProgLangTypeObjLstCache
.Where(x=> x.ProgLangTypeId == strProgLangTypeId 
);
if (arrProgLangTypeObjLst_Sel.Count() == 0)
{
   clsProgLangTypeEN obj = clsProgLangTypeBL.GetObjByProgLangTypeId(strProgLangTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrProgLangTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProgLangTypeNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//获取缓存中的对象列表
clsProgLangTypeEN objProgLangType = GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objProgLangType == null) return "";
return objProgLangType.ProgLangTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//获取缓存中的对象列表
clsProgLangTypeEN objProgLangType = GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objProgLangType == null) return "";
return objProgLangType.ProgLangTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProgLangTypeEN> GetAllProgLangTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache(); 
return arrProgLangTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrProgLangTypeObjLstCache;
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
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProgLangTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsProgLangTypeEN._RefreshTimeLst.Count == 0) return "";
return clsProgLangTypeEN._RefreshTimeLst[clsProgLangTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsProgLangTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProgLangTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsProgLangTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strProgLangTypeId)
{
if (strInFldName != conProgLangType.ProgLangTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conProgLangType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conProgLangType._AttributeName));
throw new Exception(strMsg);
}
var objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objProgLangType == null) return "";
return objProgLangType[strOutFldName].ToString();
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
int intRecCount = clsProgLangTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsProgLangTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsProgLangTypeDA.GetRecCount();
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
int intRecCount = clsProgLangTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objProgLangTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsProgLangTypeEN objProgLangTypeCond)
{
List<clsProgLangTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conProgLangType._AttributeName)
{
if (objProgLangTypeCond.IsUpdated(strFldName) == false) continue;
if (objProgLangTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProgLangTypeCond[strFldName].ToString());
}
else
{
if (objProgLangTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objProgLangTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProgLangTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objProgLangTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objProgLangTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objProgLangTypeCond[strFldName]));
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
 List<string> arrList = clsProgLangTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ProgLangTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ProgLangTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ProgLangTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsProgLangTypeDA.SetFldValue(clsProgLangTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ProgLangTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsProgLangTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsProgLangTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsProgLangTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ProgLangType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) primary key, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) not Null, "); 
 // /**编程语言类型简称*/ 
 strCreateTabCode.Append(" ProgLangTypeSimName varchar(30) Null, "); 
 // /**编程语言类型英文名*/ 
 strCreateTabCode.Append(" ProgLangTypeENName varchar(50) Null, "); 
 // /**字符编码*/ 
 strCreateTabCode.Append(" CharEncodingId varchar(20) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**字符编码名称*/ 
 strCreateTabCode.Append(" CharEncodingName varchar(100) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 编程语言类型(ProgLangType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ProgLangType : clsCommFun4BL
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
clsProgLangTypeBL.ReFreshThisCache();
}
}

}