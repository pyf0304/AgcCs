
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFKeysBL
 表名:FKeys(00050237)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsFKeysBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFKeysEN GetObj(this K_Id_FKeys myKey)
{
clsFKeysEN objFKeysEN = clsFKeysBL.FKeysDA.GetObjById(myKey.Value);
return objFKeysEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFKeysEN objFKeysEN)
{
if (CheckUniqueness_PKeyTabId_PKeyColumnID(objFKeysEN) == false)
{
var strMsg = string.Format("记录已经存在!主键表Id = [{0}],主键列ID = [{1}]的数据已经存在!(in clsFKeysBL.AddNewRecord)", objFKeysEN.PKeyTabId,objFKeysEN.PKeyColumnID);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFKeysBL.FKeysDA.AddNewRecordBySQL2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
public static bool AddRecordEx(this clsFKeysEN objFKeysEN)
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
objFKeysEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objFKeysEN. CheckUniqueness_PKeyTabId_PKeyColumnID() == false)
{
strMsg = string.Format("(主键表Id(PKeyTabId)=[{0}],主键列ID(PKeyColumnID)=[{1}])已经存在，不能重复!", objFKeysEN.PKeyTabId, objFKeysEN.PKeyColumnID);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFKeysEN.AddNewRecord();
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFKeysEN objFKeysEN)
{
if (CheckUniqueness_PKeyTabId_PKeyColumnID(objFKeysEN) == false)
{
var strMsg = string.Format("记录已经存在!主键表Id = [{0}],主键列ID = [{1}]的数据已经存在!(in clsFKeysBL.AddNewRecordWithReturnKey)", objFKeysEN.PKeyTabId,objFKeysEN.PKeyColumnID);
throw new Exception(strMsg);
}
try
{
string strKey = clsFKeysBL.FKeysDA.AddNewRecordBySQL2WithReturnKey(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetId(this clsFKeysEN objFKeysEN, long lngId, string strComparisonOp="")
	{
objFKeysEN.Id = lngId; //对象Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Id) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Id, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Id] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyName(this clsFKeysEN objFKeysEN, string strFKeyName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyName, conFKeys.FKeyName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFKeyName, 128, conFKeys.FKeyName);
}
objFKeysEN.FKeyName = strFKeyName; //外键名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyColumnID(this clsFKeysEN objFKeysEN, string strFKeyColumnID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyColumnID, conFKeys.FKeyColumnID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFKeyColumnID, 128, conFKeys.FKeyColumnID);
}
objFKeysEN.FKeyColumnID = strFKeyColumnID; //外键列Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyColumnID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyColumnID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyColumnID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyColumnName(this clsFKeysEN objFKeysEN, string strFKeyColumnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyColumnName, conFKeys.FKeyColumnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFKeyColumnName, 128, conFKeys.FKeyColumnName);
}
objFKeysEN.FKeyColumnName = strFKeyColumnName; //外键列名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyColumnName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyColumnName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyColumnName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyTabID(this clsFKeysEN objFKeysEN, string strFKeyTabID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFKeyTabID, 128, conFKeys.FKeyTabID);
}
objFKeysEN.FKeyTabID = strFKeyTabID; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyTabID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyTabID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyTabID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetFKeyTabName(this clsFKeysEN objFKeysEN, string strFKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFKeyTabName, conFKeys.FKeyTabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFKeyTabName, 128, conFKeys.FKeyTabName);
}
objFKeysEN.FKeyTabName = strFKeyTabName; //外键表名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.FKeyTabName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.FKeyTabName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.FKeyTabName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyColumnID(this clsFKeysEN objFKeysEN, string strPKeyColumnID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyColumnID, conFKeys.PKeyColumnID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPKeyColumnID, 128, conFKeys.PKeyColumnID);
}
objFKeysEN.PKeyColumnID = strPKeyColumnID; //主键列ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyColumnID) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyColumnID, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyColumnID] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyColumnName(this clsFKeysEN objFKeysEN, string strPKeyColumnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyColumnName, conFKeys.PKeyColumnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPKeyColumnName, 128, conFKeys.PKeyColumnName);
}
objFKeysEN.PKeyColumnName = strPKeyColumnName; //主键列名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyColumnName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyColumnName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyColumnName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyTabId(this clsFKeysEN objFKeysEN, string strPKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyTabId, conFKeys.PKeyTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPKeyTabId, 128, conFKeys.PKeyTabId);
}
objFKeysEN.PKeyTabId = strPKeyTabId; //主键表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyTabId) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyTabId, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyTabId] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetPKeyTabName(this clsFKeysEN objFKeysEN, string strPKeyTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPKeyTabName, conFKeys.PKeyTabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPKeyTabName, 128, conFKeys.PKeyTabName);
}
objFKeysEN.PKeyTabName = strPKeyTabName; //主键表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.PKeyTabName) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.PKeyTabName, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.PKeyTabName] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetUpdate_Action(this clsFKeysEN objFKeysEN, string strUpdate_Action, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdate_Action, conFKeys.Update_Action);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdate_Action, 128, conFKeys.Update_Action);
}
objFKeysEN.Update_Action = strUpdate_Action; //级联更新
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Update_Action) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Update_Action, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Update_Action] = strComparisonOp;
}
}
return objFKeysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFKeysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFKeysEN SetDelete_Action(this clsFKeysEN objFKeysEN, int intDelete_Action, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intDelete_Action, conFKeys.Delete_Action);
objFKeysEN.Delete_Action = intDelete_Action; //级联删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFKeysEN.dicFldComparisonOp.ContainsKey(conFKeys.Delete_Action) == false)
{
objFKeysEN.dicFldComparisonOp.Add(conFKeys.Delete_Action, strComparisonOp);
}
else
{
objFKeysEN.dicFldComparisonOp[conFKeys.Delete_Action] = strComparisonOp;
}
}
return objFKeysEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFKeysEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFKeysEN objFKeysEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFKeysEN.CheckPropertyNew();
clsFKeysEN objFKeysCond = new clsFKeysEN();
string strCondition = objFKeysCond
.SetId(objFKeysEN.Id, "<>")
.SetPKeyTabId(objFKeysEN.PKeyTabId, "=")
.SetPKeyColumnID(objFKeysEN.PKeyColumnID, "=")
.GetCombineCondition();
objFKeysEN._IsCheckProperty = true;
bool bolIsExist = clsFKeysBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PKeyTabId_PKeyColumnID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFKeysEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objFKeys">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFKeysEN objFKeys)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFKeysEN objFKeysCond = new clsFKeysEN();
string strCondition = objFKeysCond
.SetPKeyTabId(objFKeys.PKeyTabId, "=")
.SetPKeyColumnID(objFKeys.PKeyColumnID, "=")
.GetCombineCondition();
objFKeys._IsCheckProperty = true;
bool bolIsExist = clsFKeysBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFKeys.Id = clsFKeysBL.GetFirstID_S(strCondition);
objFKeys.UpdateWithCondition(strCondition);
}
else
{
objFKeys.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFKeysEN objFKeysEN)
{
 if (objFKeysEN.Id == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFKeysBL.FKeysDA.UpdateBySql2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFKeysEN objFKeysEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFKeysEN.Id == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFKeysBL.FKeysDA.UpdateBySql2(objFKeysEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFKeysEN objFKeysEN, string strWhereCond)
{
try
{
bool bolResult = clsFKeysBL.FKeysDA.UpdateBySqlWithCondition(objFKeysEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFKeysEN objFKeysEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFKeysBL.FKeysDA.UpdateBySqlWithConditionTransaction(objFKeysEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFKeysEN objFKeysEN)
{
try
{
int intRecNum = clsFKeysBL.FKeysDA.DelRecord(objFKeysEN.Id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysENS">源对象</param>
 /// <param name = "objFKeysENT">目标对象</param>
 public static void CopyTo(this clsFKeysEN objFKeysENS, clsFKeysEN objFKeysENT)
{
try
{
objFKeysENT.Id = objFKeysENS.Id; //对象Id
objFKeysENT.FKeyName = objFKeysENS.FKeyName; //外键名称
objFKeysENT.FKeyColumnID = objFKeysENS.FKeyColumnID; //外键列Id
objFKeysENT.FKeyColumnName = objFKeysENS.FKeyColumnName; //外键列名
objFKeysENT.FKeyTabID = objFKeysENS.FKeyTabID; //外键表ID
objFKeysENT.FKeyTabName = objFKeysENS.FKeyTabName; //外键表名称
objFKeysENT.PKeyColumnID = objFKeysENS.PKeyColumnID; //主键列ID
objFKeysENT.PKeyColumnName = objFKeysENS.PKeyColumnName; //主键列名
objFKeysENT.PKeyTabId = objFKeysENS.PKeyTabId; //主键表Id
objFKeysENT.PKeyTabName = objFKeysENS.PKeyTabName; //主键表名
objFKeysENT.Update_Action = objFKeysENS.Update_Action; //级联更新
objFKeysENT.Delete_Action = objFKeysENS.Delete_Action; //级联删除
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
 /// <param name = "objFKeysENS">源对象</param>
 /// <returns>目标对象=>clsFKeysEN:objFKeysENT</returns>
 public static clsFKeysEN CopyTo(this clsFKeysEN objFKeysENS)
{
try
{
 clsFKeysEN objFKeysENT = new clsFKeysEN()
{
Id = objFKeysENS.Id, //对象Id
FKeyName = objFKeysENS.FKeyName, //外键名称
FKeyColumnID = objFKeysENS.FKeyColumnID, //外键列Id
FKeyColumnName = objFKeysENS.FKeyColumnName, //外键列名
FKeyTabID = objFKeysENS.FKeyTabID, //外键表ID
FKeyTabName = objFKeysENS.FKeyTabName, //外键表名称
PKeyColumnID = objFKeysENS.PKeyColumnID, //主键列ID
PKeyColumnName = objFKeysENS.PKeyColumnName, //主键列名
PKeyTabId = objFKeysENS.PKeyTabId, //主键表Id
PKeyTabName = objFKeysENS.PKeyTabName, //主键表名
Update_Action = objFKeysENS.Update_Action, //级联更新
Delete_Action = objFKeysENS.Delete_Action, //级联删除
};
 return objFKeysENT;
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
public static void CheckPropertyNew(this clsFKeysEN objFKeysEN)
{
 clsFKeysBL.FKeysDA.CheckPropertyNew(objFKeysEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFKeysEN objFKeysEN)
{
 clsFKeysBL.FKeysDA.CheckProperty4Condition(objFKeysEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFKeysEN objFKeysCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFKeysCond.IsUpdated(conFKeys.Id) == true)
{
string strComparisonOpId = objFKeysCond.dicFldComparisonOp[conFKeys.Id];
strWhereCond += string.Format(" And {0} {2} {1}", conFKeys.Id, objFKeysCond.Id, strComparisonOpId);
}
if (objFKeysCond.IsUpdated(conFKeys.FKeyName) == true)
{
string strComparisonOpFKeyName = objFKeysCond.dicFldComparisonOp[conFKeys.FKeyName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyName, objFKeysCond.FKeyName, strComparisonOpFKeyName);
}
if (objFKeysCond.IsUpdated(conFKeys.FKeyColumnID) == true)
{
string strComparisonOpFKeyColumnID = objFKeysCond.dicFldComparisonOp[conFKeys.FKeyColumnID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyColumnID, objFKeysCond.FKeyColumnID, strComparisonOpFKeyColumnID);
}
if (objFKeysCond.IsUpdated(conFKeys.FKeyColumnName) == true)
{
string strComparisonOpFKeyColumnName = objFKeysCond.dicFldComparisonOp[conFKeys.FKeyColumnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyColumnName, objFKeysCond.FKeyColumnName, strComparisonOpFKeyColumnName);
}
if (objFKeysCond.IsUpdated(conFKeys.FKeyTabID) == true)
{
string strComparisonOpFKeyTabID = objFKeysCond.dicFldComparisonOp[conFKeys.FKeyTabID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyTabID, objFKeysCond.FKeyTabID, strComparisonOpFKeyTabID);
}
if (objFKeysCond.IsUpdated(conFKeys.FKeyTabName) == true)
{
string strComparisonOpFKeyTabName = objFKeysCond.dicFldComparisonOp[conFKeys.FKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.FKeyTabName, objFKeysCond.FKeyTabName, strComparisonOpFKeyTabName);
}
if (objFKeysCond.IsUpdated(conFKeys.PKeyColumnID) == true)
{
string strComparisonOpPKeyColumnID = objFKeysCond.dicFldComparisonOp[conFKeys.PKeyColumnID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyColumnID, objFKeysCond.PKeyColumnID, strComparisonOpPKeyColumnID);
}
if (objFKeysCond.IsUpdated(conFKeys.PKeyColumnName) == true)
{
string strComparisonOpPKeyColumnName = objFKeysCond.dicFldComparisonOp[conFKeys.PKeyColumnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyColumnName, objFKeysCond.PKeyColumnName, strComparisonOpPKeyColumnName);
}
if (objFKeysCond.IsUpdated(conFKeys.PKeyTabId) == true)
{
string strComparisonOpPKeyTabId = objFKeysCond.dicFldComparisonOp[conFKeys.PKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyTabId, objFKeysCond.PKeyTabId, strComparisonOpPKeyTabId);
}
if (objFKeysCond.IsUpdated(conFKeys.PKeyTabName) == true)
{
string strComparisonOpPKeyTabName = objFKeysCond.dicFldComparisonOp[conFKeys.PKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.PKeyTabName, objFKeysCond.PKeyTabName, strComparisonOpPKeyTabName);
}
if (objFKeysCond.IsUpdated(conFKeys.Update_Action) == true)
{
string strComparisonOpUpdate_Action = objFKeysCond.dicFldComparisonOp[conFKeys.Update_Action];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFKeys.Update_Action, objFKeysCond.Update_Action, strComparisonOpUpdate_Action);
}
if (objFKeysCond.IsUpdated(conFKeys.Delete_Action) == true)
{
string strComparisonOpDelete_Action = objFKeysCond.dicFldComparisonOp[conFKeys.Delete_Action];
strWhereCond += string.Format(" And {0} {2} {1}", conFKeys.Delete_Action, objFKeysCond.Delete_Action, strComparisonOpDelete_Action);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FKeys(表外键), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFKeysEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_PKeyTabId_PKeyColumnID(this clsFKeysEN objFKeysEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFKeysEN == null) return true;
if (objFKeysEN.Id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
if (clsFKeysBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("Id !=  {0}", objFKeysEN.Id);
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
if (clsFKeysBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--FKeys(表外键), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFKeysEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrPKeyTabId_PKeyColumnID(this clsFKeysEN objFKeysEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFKeysEN == null) return "";
if (objFKeysEN.Id == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id !=  {0}", objFKeysEN.Id);
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FKeys
{
public virtual bool UpdRelaTabDate(long lngId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表外键(FKeys)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFKeysBL
{
public static RelatedActions_FKeys relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "FKeysListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "FKeysList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsFKeysEN> arrFKeysObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFKeysDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFKeysDA FKeysDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFKeysDA();
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
 public clsFKeysBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsFKeysEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFKeysEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = FKeysDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = FKeysDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = FKeysDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_FKeys(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTable_FKeys(strWhereCond);
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
objDT = FKeysDA.GetDataTable(strWhereCond);
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
objDT = FKeysDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FKeysDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FKeysDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FKeysDA.GetDataTable_Top(objTopPara);
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
objDT = FKeysDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = FKeysDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FKeysDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FKeysDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFKeysEN> GetObjLstByIdLst(List<long> arrIdLst)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdLst);
 string strWhereCond = string.Format("Id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFKeysEN> GetObjLstByIdLstCache(List<long> arrIdLst)
{
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLstCache = GetObjLstCache();
IEnumerable <clsFKeysEN> arrFKeysObjLst_Sel =
arrFKeysObjLstCache
.Where(x => arrIdLst.Contains(x.Id));
return arrFKeysObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLst(string strWhereCond)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
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
public static List<clsFKeysEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFKeysCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFKeysEN> GetSubObjLstCache(clsFKeysEN objFKeysCond)
{
List<clsFKeysEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFKeysEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFKeys.AttributeName)
{
if (objFKeysCond.IsUpdated(strFldName) == false) continue;
if (objFKeysCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else
{
if (objFKeysCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFKeysCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFKeysCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
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
public static List<clsFKeysEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
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
public static List<clsFKeysEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
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
List<clsFKeysEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFKeysEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFKeysEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
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
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
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
public static List<clsFKeysEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFKeysEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFKeysEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
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
public static List<clsFKeysEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsFKeysEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsFKeysEN objFKeysCond, string strOrderBy)
{
List<clsFKeysEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFKeysEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFKeys.AttributeName)
{
if (objFKeysCond.IsUpdated(strFldName) == false) continue;
if (objFKeysCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else
{
if (objFKeysCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFKeysCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFKeysCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsFKeysEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsFKeysEN objFKeysCond = JsonConvert.DeserializeObject<clsFKeysEN>(objPagerPara.whereCond);
if (objFKeysCond.sfFldComparisonOp == null)
{
objFKeysCond.dicFldComparisonOp = null;
}
else
{
objFKeysCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objFKeysCond.sfFldComparisonOp);
}
clsFKeysBL.SetUpdFlag(objFKeysCond);
 try
{
CheckProperty4Condition(objFKeysCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsFKeysBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objFKeysCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFKeysEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFKeysEN.Id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFKeysEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFKeys(ref clsFKeysEN objFKeysEN)
{
bool bolResult = FKeysDA.GetFKeys(ref objFKeysEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFKeysEN GetObjById(long lngId)
{
clsFKeysEN objFKeysEN = FKeysDA.GetObjById(lngId);
return objFKeysEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFKeysEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFKeysEN objFKeysEN = FKeysDA.GetFirstObj(strWhereCond);
 return objFKeysEN;
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
public static clsFKeysEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFKeysEN objFKeysEN = FKeysDA.GetObjByDataRow(objRow);
 return objFKeysEN;
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
public static clsFKeysEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFKeysEN objFKeysEN = FKeysDA.GetObjByDataRow(objRow);
 return objFKeysEN;
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
 /// <param name = "lngId">所给的关键字</param>
 /// <param name = "lstFKeysObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFKeysEN GetObjByIdFromList(long lngId, List<clsFKeysEN> lstFKeysObjLst)
{
foreach (clsFKeysEN objFKeysEN in lstFKeysObjLst)
{
if (objFKeysEN.Id == lngId)
{
return objFKeysEN;
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
 long lngId;
 try
 {
 lngId = new clsFKeysDA().GetFirstID(strWhereCond);
 return lngId;
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
 arrList = FKeysDA.GetID(strWhereCond);
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
bool bolIsExist = FKeysDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngId)
{
//检测记录是否存在
bool bolIsExist = FKeysDA.IsExist(lngId);
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
 bolIsExist = clsFKeysDA.IsExistTable();
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
 bolIsExist = FKeysDA.IsExistTable(strTabName);
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFKeysEN objFKeysEN)
{
if (objFKeysEN.CheckUniqueness_PKeyTabId_PKeyColumnID() == false)
{
var strMsg = string.Format("记录已经存在!主键表Id = [{0}],主键列ID = [{1}]的数据已经存在!(in clsFKeysBL.AddNewRecordBySql2)", objFKeysEN.PKeyTabId,objFKeysEN.PKeyColumnID);
throw new Exception(strMsg);
}
try
{
bool bolResult = FKeysDA.AddNewRecordBySQL2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFKeysEN objFKeysEN)
{
if (objFKeysEN.CheckUniqueness_PKeyTabId_PKeyColumnID() == false)
{
var strMsg = string.Format("记录已经存在!主键表Id = [{0}],主键列ID = [{1}]的数据已经存在!(in clsFKeysBL.AddNewRecordBySql2WithReturnKey)", objFKeysEN.PKeyTabId,objFKeysEN.PKeyColumnID);
throw new Exception(strMsg);
}
try
{
string strKey = FKeysDA.AddNewRecordBySQL2WithReturnKey(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strFKeysObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strFKeysObjXml)
{
clsFKeysEN objFKeysEN = GetObjFromXmlStr(strFKeysObjXml);
try
{
bool bolResult = FKeysDA.AddNewRecordBySQL2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFKeysEN objFKeysEN)
{
try
{
bool bolResult = FKeysDA.Update(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN.Id == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FKeysDA.UpdateBySql2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strFKeysObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strFKeysObjXml)
{
clsFKeysEN objFKeysEN = GetObjFromXmlStr(strFKeysObjXml);
try
{
bool bolResult = FKeysDA.UpdateBySql2(objFKeysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFKeysBL.ReFreshCache();

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngId)
{
try
{
 clsFKeysEN objFKeysEN = clsFKeysBL.GetObjById(lngId);

if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(objFKeysEN.Id, "SetUpdDate");
}
if (objFKeysEN != null)
{
int intRecNum = FKeysDA.DelRecord(lngId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFKeysDA.GetSpecSQLObj();
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
//删除与表:[FKeys]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFKeys.Id,
//lngId);
//        clsFKeysBL.DelFKeyssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFKeysBL.DelRecord(lngId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFKeysBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(lngId, "UpdRelaTabDate");
}
bool bolResult = FKeysDA.DelRecord(lngId,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngId) 
{
try
{
if (clsFKeysBL.relatedActions != null)
{
clsFKeysBL.relatedActions.UpdRelaTabDate(lngId, "UpdRelaTabDate");
}
bool bolResult = FKeysDA.DelRecordBySP(lngId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFKeyss(List<string> arrIdLst)
{
if (arrIdLst.Count == 0) return 0;
try
{
if (clsFKeysBL.relatedActions != null)
{
foreach (var strId in arrIdLst)
{
long lngId = long.Parse(strId);
clsFKeysBL.relatedActions.UpdRelaTabDate(lngId, "UpdRelaTabDate");
}
}
int intDelRecNum = FKeysDA.DelFKeys(arrIdLst);
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
public static int DelFKeyssByCond(string strWhereCond)
{
try
{
if (clsFKeysBL.relatedActions != null)
{
List<string> arrId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strId in arrId)
{
long lngId = long.Parse(strId);
clsFKeysBL.relatedActions.UpdRelaTabDate(lngId, "UpdRelaTabDate");
}
}
int intRecNum = FKeysDA.DelFKeys(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[FKeys]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFKeysDA.GetSpecSQLObj();
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
//删除与表:[FKeys]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFKeysBL.DelRecord(lngId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFKeysBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFKeysENS">源对象</param>
 /// <param name = "objFKeysENT">目标对象</param>
 public static void CopyTo(clsFKeysEN objFKeysENS, clsFKeysEN objFKeysENT)
{
try
{
objFKeysENT.Id = objFKeysENS.Id; //对象Id
objFKeysENT.FKeyName = objFKeysENS.FKeyName; //外键名称
objFKeysENT.FKeyColumnID = objFKeysENS.FKeyColumnID; //外键列Id
objFKeysENT.FKeyColumnName = objFKeysENS.FKeyColumnName; //外键列名
objFKeysENT.FKeyTabID = objFKeysENS.FKeyTabID; //外键表ID
objFKeysENT.FKeyTabName = objFKeysENS.FKeyTabName; //外键表名称
objFKeysENT.PKeyColumnID = objFKeysENS.PKeyColumnID; //主键列ID
objFKeysENT.PKeyColumnName = objFKeysENS.PKeyColumnName; //主键列名
objFKeysENT.PKeyTabId = objFKeysENS.PKeyTabId; //主键表Id
objFKeysENT.PKeyTabName = objFKeysENS.PKeyTabName; //主键表名
objFKeysENT.Update_Action = objFKeysENS.Update_Action; //级联更新
objFKeysENT.Delete_Action = objFKeysENS.Delete_Action; //级联删除
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
 /// <param name = "objFKeysEN">源简化对象</param>
 public static void SetUpdFlag(clsFKeysEN objFKeysEN)
{
try
{
objFKeysEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objFKeysEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFKeys.Id, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.Id = objFKeysEN.Id; //对象Id
}
if (arrFldSet.Contains(conFKeys.FKeyName, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.FKeyName = objFKeysEN.FKeyName; //外键名称
}
if (arrFldSet.Contains(conFKeys.FKeyColumnID, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID; //外键列Id
}
if (arrFldSet.Contains(conFKeys.FKeyColumnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName; //外键列名
}
if (arrFldSet.Contains(conFKeys.FKeyTabID, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID == "[null]" ? null :  objFKeysEN.FKeyTabID; //外键表ID
}
if (arrFldSet.Contains(conFKeys.FKeyTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName; //外键表名称
}
if (arrFldSet.Contains(conFKeys.PKeyColumnID, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID; //主键列ID
}
if (arrFldSet.Contains(conFKeys.PKeyColumnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName; //主键列名
}
if (arrFldSet.Contains(conFKeys.PKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId; //主键表Id
}
if (arrFldSet.Contains(conFKeys.PKeyTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName; //主键表名
}
if (arrFldSet.Contains(conFKeys.Update_Action, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.Update_Action = objFKeysEN.Update_Action; //级联更新
}
if (arrFldSet.Contains(conFKeys.Delete_Action, new clsStrCompareIgnoreCase())  ==  true)
{
objFKeysEN.Delete_Action = objFKeysEN.Delete_Action; //级联删除
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objFKeysEN">源简化对象</param>
 public static void AccessFldValueNull(clsFKeysEN objFKeysEN)
{
try
{
if (objFKeysEN.FKeyTabID == "[null]") objFKeysEN.FKeyTabID = null; //外键表ID
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsFKeysEN objFKeysEN)
{
 FKeysDA.CheckPropertyNew(objFKeysEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFKeysEN objFKeysEN)
{
 FKeysDA.CheckProperty4Condition(objFKeysEN);
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
if (clsFKeysBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFKeysBL没有刷新缓存机制(clsFKeysBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id");
//if (arrFKeysObjLstCache == null)
//{
//arrFKeysObjLstCache = FKeysDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFKeysEN GetObjByIdCache(long lngId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLstCache = GetObjLstCache();
IEnumerable <clsFKeysEN> arrFKeysObjLst_Sel =
arrFKeysObjLstCache
.Where(x=> x.Id == lngId 
);
if (arrFKeysObjLst_Sel.Count() == 0)
{
   clsFKeysEN obj = clsFKeysBL.GetObjById(lngId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFKeysObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFKeysEN> GetAllFKeysObjLstCache()
{
//获取缓存中的对象列表
List<clsFKeysEN> arrFKeysObjLstCache = GetObjLstCache(); 
return arrFKeysObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFKeysEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
List<clsFKeysEN> arrFKeysObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFKeysObjLstCache;
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
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFKeysBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFKeysEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFKeysBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FKeys(表外键)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFKeysEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrPKeyTabId_PKeyColumnID(clsFKeysEN objFKeysEN)
{
//检测记录是否存在
string strResult = FKeysDA.GetUniCondStrPKeyTabId_PKeyColumnID(objFKeysEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstFKeysObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsFKeysEN> lstFKeysObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstFKeysObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstFKeysObjLst">[clsFKeysEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsFKeysEN> lstFKeysObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsFKeysBL.listXmlNode);
writer.WriteStartElement(clsFKeysBL.itemsXmlNode);
foreach (clsFKeysEN objFKeysEN in lstFKeysObjLst)
{
clsFKeysBL.SerializeXML(writer, objFKeysEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objFKeysEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsFKeysEN objFKeysEN)
{
writer.WriteStartElement(clsFKeysBL.itemXmlNode);
 
writer.WriteElementString(conFKeys.Id, objFKeysEN.Id.ToString(CultureInfo.InvariantCulture));
 
if (objFKeysEN.FKeyName != null)
{
writer.WriteElementString(conFKeys.FKeyName, objFKeysEN.FKeyName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.FKeyColumnID != null)
{
writer.WriteElementString(conFKeys.FKeyColumnID, objFKeysEN.FKeyColumnID.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.FKeyColumnName != null)
{
writer.WriteElementString(conFKeys.FKeyColumnName, objFKeysEN.FKeyColumnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.FKeyTabID != null)
{
writer.WriteElementString(conFKeys.FKeyTabID, objFKeysEN.FKeyTabID.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.FKeyTabName != null)
{
writer.WriteElementString(conFKeys.FKeyTabName, objFKeysEN.FKeyTabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.PKeyColumnID != null)
{
writer.WriteElementString(conFKeys.PKeyColumnID, objFKeysEN.PKeyColumnID.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.PKeyColumnName != null)
{
writer.WriteElementString(conFKeys.PKeyColumnName, objFKeysEN.PKeyColumnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.PKeyTabId != null)
{
writer.WriteElementString(conFKeys.PKeyTabId, objFKeysEN.PKeyTabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.PKeyTabName != null)
{
writer.WriteElementString(conFKeys.PKeyTabName, objFKeysEN.PKeyTabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objFKeysEN.Update_Action != null)
{
writer.WriteElementString(conFKeys.Update_Action, objFKeysEN.Update_Action.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conFKeys.Delete_Action, objFKeysEN.Delete_Action.ToString(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsFKeysEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsFKeysEN objFKeysEN = new clsFKeysEN();
reader.Read();
while (!(reader.Name == clsFKeysBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conFKeys.Id))
{
objFKeysEN.Id = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conFKeys.FKeyName))
{
objFKeysEN.FKeyName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.FKeyColumnID))
{
objFKeysEN.FKeyColumnID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.FKeyColumnName))
{
objFKeysEN.FKeyColumnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.FKeyTabID))
{
objFKeysEN.FKeyTabID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.FKeyTabName))
{
objFKeysEN.FKeyTabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.PKeyColumnID))
{
objFKeysEN.PKeyColumnID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.PKeyColumnName))
{
objFKeysEN.PKeyColumnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.PKeyTabId))
{
objFKeysEN.PKeyTabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.PKeyTabName))
{
objFKeysEN.PKeyTabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.Update_Action))
{
objFKeysEN.Update_Action = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFKeys.Delete_Action))
{
objFKeysEN.Delete_Action = reader.ReadElementContentAsInt();
}
}
return objFKeysEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strFKeysObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsFKeysEN GetObjFromXmlStr(string strFKeysObjXmlStr)
{
clsFKeysEN objFKeysEN = new clsFKeysEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strFKeysObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsFKeysBL.itemXmlNode))
{
objFKeysEN = GetObjFromXml(reader);
return objFKeysEN;
}
}
return objFKeysEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objFKeysEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsFKeysEN objFKeysEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objFKeysEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngId)
{
if (strInFldName != conFKeys.Id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFKeys.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFKeys.AttributeName));
throw new Exception(strMsg);
}
var objFKeys = clsFKeysBL.GetObjByIdCache(lngId);
if (objFKeys == null) return "";
return objFKeys[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objFKeysEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsFKeysEN objFKeysEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsFKeysEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objFKeysEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstFKeysObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsFKeysEN> lstFKeysObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstFKeysObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsFKeysEN objFKeysEN in lstFKeysObjLst)
{
string strJSON_One = SerializeObjToJSON(objFKeysEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsFKeysDA.GetRecCount(strTabName);
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
int intRecCount = clsFKeysDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFKeysDA.GetRecCount();
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
int intRecCount = clsFKeysDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFKeysCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFKeysEN objFKeysCond)
{
List<clsFKeysEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFKeysEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFKeys.AttributeName)
{
if (objFKeysCond.IsUpdated(strFldName) == false) continue;
if (objFKeysCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else
{
if (objFKeysCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFKeysCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFKeysCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFKeysCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFKeysCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFKeysCond[strFldName]));
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
 List<string> arrList = clsFKeysDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FKeysDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FKeysDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FKeysDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFKeysDA.SetFldValue(clsFKeysEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FKeysDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFKeysDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFKeysDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFKeysDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FKeys] "); 
 strCreateTabCode.Append(" ( "); 
 // /**对象Id*/ 
 strCreateTabCode.Append(" Id bigint primary key identity, "); 
 // /**外键名称*/ 
 strCreateTabCode.Append(" FKeyName varchar(128) not Null, "); 
 // /**外键列Id*/ 
 strCreateTabCode.Append(" FKeyColumnID varchar(128) not Null, "); 
 // /**外键列名*/ 
 strCreateTabCode.Append(" FKeyColumnName varchar(128) not Null, "); 
 // /**外键表ID*/ 
 strCreateTabCode.Append(" FKeyTabID varchar(128) Null, "); 
 // /**外键表名称*/ 
 strCreateTabCode.Append(" FKeyTabName varchar(128) not Null, "); 
 // /**主键列ID*/ 
 strCreateTabCode.Append(" PKeyColumnID varchar(128) not Null, "); 
 // /**主键列名*/ 
 strCreateTabCode.Append(" PKeyColumnName varchar(128) not Null, "); 
 // /**主键表Id*/ 
 strCreateTabCode.Append(" PKeyTabId varchar(128) not Null, "); 
 // /**主键表名*/ 
 strCreateTabCode.Append(" PKeyTabName varchar(128) not Null, "); 
 // /**级联更新*/ 
 strCreateTabCode.Append(" Update_Action varchar(128) not Null, "); 
 // /**级联删除*/ 
 strCreateTabCode.Append(" Delete_Action int not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 表外键(FKeys)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4FKeys : clsCommFun4BL
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
clsFKeysBL.ReFreshThisCache();
}
}

}