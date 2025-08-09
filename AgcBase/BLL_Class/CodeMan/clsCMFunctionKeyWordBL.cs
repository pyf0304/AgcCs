
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionKeyWordBL
 表名:CMFunctionKeyWord(00050515)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMFunctionKeyWordBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionKeyWordEN GetObj(this K_mId_CMFunctionKeyWord myKey)
{
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.GetObjBymId(myKey.Value);
return objCMFunctionKeyWordEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionKeyWordEN) == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],关键字 = [{1}]的数据已经存在!(in clsCMFunctionKeyWordBL.AddNewRecord)", objCMFunctionKeyWordEN.CmFunctionId,objCMFunctionKeyWordEN.Keyword);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.AddNewRecordBySQL2(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
public static bool AddRecordEx(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsNeedCheckUniqueness = true)
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
objCMFunctionKeyWordEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMFunctionKeyWordEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数Id(CmFunctionId)=[{0}],关键字(Keyword)=[{1}])已经存在,不能重复!", objCMFunctionKeyWordEN.CmFunctionId, objCMFunctionKeyWordEN.Keyword);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMFunctionKeyWordEN.AddNewRecord();
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionKeyWordEN) == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],关键字 = [{1}]的数据已经存在!(in clsCMFunctionKeyWordBL.AddNewRecordWithReturnKey)", objCMFunctionKeyWordEN.CmFunctionId,objCMFunctionKeyWordEN.Keyword);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetmId(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, long lngmId, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.mId) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.mId, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.mId] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetCmFunctionId(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, conCMFunctionKeyWord.CmFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
}
objCMFunctionKeyWordEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.CmFunctionId) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.CmFunctionId, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.CmFunctionId] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetKeyword(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyword, conCMFunctionKeyWord.Keyword);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, conCMFunctionKeyWord.Keyword);
}
objCMFunctionKeyWordEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.Keyword) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.Keyword, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.Keyword] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetUpdDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFunctionKeyWord.UpdDate);
}
objCMFunctionKeyWordEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.UpdDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.UpdDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.UpdDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetUpdUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFunctionKeyWord.UpdUser);
}
objCMFunctionKeyWordEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.UpdUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.UpdUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.UpdUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetMemo(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFunctionKeyWord.Memo);
}
objCMFunctionKeyWordEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.Memo) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.Memo, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.Memo] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetIsSynchToServer(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.IsSynchToServer) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.IsSynchToServer, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.IsSynchToServer] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToServerDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToServerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMFunctionKeyWord.SynchToServerDate);
}
objCMFunctionKeyWordEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToServerDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToServerDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToServerUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToServerUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMFunctionKeyWord.SynchToServerUser);
}
objCMFunctionKeyWordEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToServerUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToServerUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetIsSynchToClient(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.IsSynchToClient) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.IsSynchToClient, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.IsSynchToClient] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToClientDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToClientDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMFunctionKeyWord.SynchToClientDate);
}
objCMFunctionKeyWordEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToClientDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToClientDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToClientUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToClientUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMFunctionKeyWord.SynchToClientUser);
}
objCMFunctionKeyWordEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToClientUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToClientUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynSource(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMFunctionKeyWord.SynSource);
}
objCMFunctionKeyWordEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynSource) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynSource, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynSource] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMFunctionKeyWordEN.CheckPropertyNew();
clsCMFunctionKeyWordEN objCMFunctionKeyWordCond = new clsCMFunctionKeyWordEN();
string strCondition = objCMFunctionKeyWordCond
.SetmId(objCMFunctionKeyWordEN.mId, "<>")
.SetCmFunctionId(objCMFunctionKeyWordEN.CmFunctionId, "=")
.SetKeyword(objCMFunctionKeyWordEN.Keyword, "=")
.GetCombineCondition();
objCMFunctionKeyWordEN._IsCheckProperty = true;
bool bolIsExist = clsCMFunctionKeyWordBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CMFunctionId_KeyWord)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMFunctionKeyWordEN.Update();
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
 /// <param name = "objCMFunctionKeyWord">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMFunctionKeyWordEN objCMFunctionKeyWord)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMFunctionKeyWordEN objCMFunctionKeyWordCond = new clsCMFunctionKeyWordEN();
string strCondition = objCMFunctionKeyWordCond
.SetCmFunctionId(objCMFunctionKeyWord.CmFunctionId, "=")
.SetKeyword(objCMFunctionKeyWord.Keyword, "=")
.GetCombineCondition();
objCMFunctionKeyWord._IsCheckProperty = true;
bool bolIsExist = clsCMFunctionKeyWordBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMFunctionKeyWord.mId = clsCMFunctionKeyWordBL.GetFirstID_S(strCondition);
objCMFunctionKeyWord.UpdateWithCondition(strCondition);
}
else
{
objCMFunctionKeyWord.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 if (objCMFunctionKeyWordEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.UpdateBySql2(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCMFunctionKeyWordEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.UpdateBySql2(objCMFunctionKeyWordEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strWhereCond)
{
try
{
bool bolResult = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.UpdateBySqlWithCondition(objCMFunctionKeyWordEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.UpdateBySqlWithConditionTransaction(objCMFunctionKeyWordEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
public static int Delete(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
try
{
int intRecNum = clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.DelRecord(objCMFunctionKeyWordEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(this clsCMFunctionKeyWordEN objCMFunctionKeyWordENS, clsCMFunctionKeyWordEN objCMFunctionKeyWordENT)
{
try
{
objCMFunctionKeyWordENT.mId = objCMFunctionKeyWordENS.mId; //mId
objCMFunctionKeyWordENT.CmFunctionId = objCMFunctionKeyWordENS.CmFunctionId; //函数Id
objCMFunctionKeyWordENT.Keyword = objCMFunctionKeyWordENS.Keyword; //关键字
objCMFunctionKeyWordENT.UpdDate = objCMFunctionKeyWordENS.UpdDate; //修改日期
objCMFunctionKeyWordENT.UpdUser = objCMFunctionKeyWordENS.UpdUser; //修改者
objCMFunctionKeyWordENT.Memo = objCMFunctionKeyWordENS.Memo; //说明
objCMFunctionKeyWordENT.IsSynchToServer = objCMFunctionKeyWordENS.IsSynchToServer; //是否同步到Server
objCMFunctionKeyWordENT.SynchToServerDate = objCMFunctionKeyWordENS.SynchToServerDate; //同步到Server日期
objCMFunctionKeyWordENT.SynchToServerUser = objCMFunctionKeyWordENS.SynchToServerUser; //同步到Server用户
objCMFunctionKeyWordENT.IsSynchToClient = objCMFunctionKeyWordENS.IsSynchToClient; //是否同步到Client
objCMFunctionKeyWordENT.SynchToClientDate = objCMFunctionKeyWordENS.SynchToClientDate; //同步到Client库日期
objCMFunctionKeyWordENT.SynchToClientUser = objCMFunctionKeyWordENS.SynchToClientUser; //同步到Client库用户
objCMFunctionKeyWordENT.SynSource = objCMFunctionKeyWordENS.SynSource; //同步来源
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
 /// <param name = "objCMFunctionKeyWordENS">源对象</param>
 /// <returns>目标对象=>clsCMFunctionKeyWordEN:objCMFunctionKeyWordENT</returns>
 public static clsCMFunctionKeyWordEN CopyTo(this clsCMFunctionKeyWordEN objCMFunctionKeyWordENS)
{
try
{
 clsCMFunctionKeyWordEN objCMFunctionKeyWordENT = new clsCMFunctionKeyWordEN()
{
mId = objCMFunctionKeyWordENS.mId, //mId
CmFunctionId = objCMFunctionKeyWordENS.CmFunctionId, //函数Id
Keyword = objCMFunctionKeyWordENS.Keyword, //关键字
UpdDate = objCMFunctionKeyWordENS.UpdDate, //修改日期
UpdUser = objCMFunctionKeyWordENS.UpdUser, //修改者
Memo = objCMFunctionKeyWordENS.Memo, //说明
IsSynchToServer = objCMFunctionKeyWordENS.IsSynchToServer, //是否同步到Server
SynchToServerDate = objCMFunctionKeyWordENS.SynchToServerDate, //同步到Server日期
SynchToServerUser = objCMFunctionKeyWordENS.SynchToServerUser, //同步到Server用户
IsSynchToClient = objCMFunctionKeyWordENS.IsSynchToClient, //是否同步到Client
SynchToClientDate = objCMFunctionKeyWordENS.SynchToClientDate, //同步到Client库日期
SynchToClientUser = objCMFunctionKeyWordENS.SynchToClientUser, //同步到Client库用户
SynSource = objCMFunctionKeyWordENS.SynSource, //同步来源
};
 return objCMFunctionKeyWordENT;
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
public static void CheckPropertyNew(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.CheckPropertyNew(objCMFunctionKeyWordEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 clsCMFunctionKeyWordBL.CMFunctionKeyWordDA.CheckProperty4Condition(objCMFunctionKeyWordEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.mId) == true)
{
string strComparisonOpmId = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFunctionKeyWord.mId, objCMFunctionKeyWordCond.mId, strComparisonOpmId);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.CmFunctionId, objCMFunctionKeyWordCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.Keyword) == true)
{
string strComparisonOpKeyword = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.Keyword, objCMFunctionKeyWordCond.Keyword, strComparisonOpKeyword);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.UpdDate, objCMFunctionKeyWordCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.UpdUser, objCMFunctionKeyWordCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.Memo) == true)
{
string strComparisonOpMemo = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.Memo, objCMFunctionKeyWordCond.Memo, strComparisonOpMemo);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.IsSynchToServer) == true)
{
if (objCMFunctionKeyWordCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunctionKeyWord.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunctionKeyWord.IsSynchToServer);
}
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToServerDate, objCMFunctionKeyWordCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToServerUser, objCMFunctionKeyWordCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.IsSynchToClient) == true)
{
if (objCMFunctionKeyWordCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunctionKeyWord.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunctionKeyWord.IsSynchToClient);
}
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToClientDate, objCMFunctionKeyWordCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToClientUser, objCMFunctionKeyWordCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynSource) == true)
{
string strComparisonOpSynSource = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynSource, objCMFunctionKeyWordCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMFunctionKeyWord(CM函数关键字), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMFunctionId_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionKeyWordEN == null) return true;
if (objCMFunctionKeyWordEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
if (clsCMFunctionKeyWordBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMFunctionKeyWordEN.mId);
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
if (clsCMFunctionKeyWordBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMFunctionKeyWord(CM函数关键字), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMFunctionId_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionKeyWordEN == null) return "";
if (objCMFunctionKeyWordEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMFunctionKeyWordEN.mId);
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMFunctionKeyWord
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM函数关键字(CMFunctionKeyWord)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMFunctionKeyWordBL
{
public static RelatedActions_CMFunctionKeyWord relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMFunctionKeyWordDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMFunctionKeyWordDA CMFunctionKeyWordDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMFunctionKeyWordDA();
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
 public clsCMFunctionKeyWordBL()
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
if (string.IsNullOrEmpty(clsCMFunctionKeyWordEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFunctionKeyWordEN._ConnectString);
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
public static DataTable GetDataTable_CMFunctionKeyWord(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMFunctionKeyWordDA.GetDataTable_CMFunctionKeyWord(strWhereCond);
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
objDT = CMFunctionKeyWordDA.GetDataTable(strWhereCond);
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
objDT = CMFunctionKeyWordDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMFunctionKeyWordDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMFunctionKeyWordDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMFunctionKeyWordDA.GetDataTable_Top(objTopPara);
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
objDT = CMFunctionKeyWordDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMFunctionKeyWordDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMFunctionKeyWordDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
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
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMFunctionKeyWordEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLst_Sel =
arrCMFunctionKeyWordObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCMFunctionKeyWordObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetObjLst(string strWhereCond)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
public static List<clsCMFunctionKeyWordEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMFunctionKeyWordEN> GetSubObjLstCache(clsCMFunctionKeyWordEN objCMFunctionKeyWordCond)
{
List<clsCMFunctionKeyWordEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionKeyWordEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFunctionKeyWord._AttributeName)
{
if (objCMFunctionKeyWordCond.IsUpdated(strFldName) == false) continue;
if (objCMFunctionKeyWordCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionKeyWordCond[strFldName].ToString());
}
else
{
if (objCMFunctionKeyWordCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFunctionKeyWordCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionKeyWordCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFunctionKeyWordCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFunctionKeyWordCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFunctionKeyWordCond[strFldName]));
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
List<clsCMFunctionKeyWordEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMFunctionKeyWordEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMFunctionKeyWordEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
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
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
public static List<clsCMFunctionKeyWordEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionKeyWordEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMFunctionKeyWord(ref clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
bool bolResult = CMFunctionKeyWordDA.GetCMFunctionKeyWord(ref objCMFunctionKeyWordEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = CMFunctionKeyWordDA.GetObjBymId(lngmId);
return objCMFunctionKeyWordEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMFunctionKeyWordEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = CMFunctionKeyWordDA.GetFirstObj(strWhereCond);
 return objCMFunctionKeyWordEN;
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
public static clsCMFunctionKeyWordEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = CMFunctionKeyWordDA.GetObjByDataRow(objRow);
 return objCMFunctionKeyWordEN;
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
public static clsCMFunctionKeyWordEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = CMFunctionKeyWordDA.GetObjByDataRow(objRow);
 return objCMFunctionKeyWordEN;
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
 /// <param name = "lstCMFunctionKeyWordObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFunctionKeyWordEN GetObjBymIdFromList(long lngmId, List<clsCMFunctionKeyWordEN> lstCMFunctionKeyWordObjLst)
{
foreach (clsCMFunctionKeyWordEN objCMFunctionKeyWordEN in lstCMFunctionKeyWordObjLst)
{
if (objCMFunctionKeyWordEN.mId == lngmId)
{
return objCMFunctionKeyWordEN;
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
 lngmId = new clsCMFunctionKeyWordDA().GetFirstID(strWhereCond);
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
 arrList = CMFunctionKeyWordDA.GetID(strWhereCond);
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
bool bolIsExist = CMFunctionKeyWordDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = CMFunctionKeyWordDA.IsExist(lngmId);
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
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = clsCMFunctionKeyWordBL.GetObjBymId(lngmId);
objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMFunctionKeyWordEN.UpdUser = strOpUser;
return clsCMFunctionKeyWordBL.UpdateBySql2(objCMFunctionKeyWordEN);
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
 bolIsExist = clsCMFunctionKeyWordDA.IsExistTable();
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
 bolIsExist = CMFunctionKeyWordDA.IsExistTable(strTabName);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFunctionKeyWordEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],关键字 = [{1}]的数据已经存在!(in clsCMFunctionKeyWordBL.AddNewRecordBySql2)", objCMFunctionKeyWordEN.CmFunctionId,objCMFunctionKeyWordEN.Keyword);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMFunctionKeyWordDA.AddNewRecordBySQL2(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFunctionKeyWordEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],关键字 = [{1}]的数据已经存在!(in clsCMFunctionKeyWordBL.AddNewRecordBySql2WithReturnKey)", objCMFunctionKeyWordEN.CmFunctionId,objCMFunctionKeyWordEN.Keyword);
throw new Exception(strMsg);
}
try
{
string strKey = CMFunctionKeyWordDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
try
{
bool bolResult = CMFunctionKeyWordDA.Update(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 if (objCMFunctionKeyWordEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMFunctionKeyWordDA.UpdateBySql2(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionKeyWordBL.ReFreshCache();

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
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
 clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = clsCMFunctionKeyWordBL.GetObjBymId(lngmId);

if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(objCMFunctionKeyWordEN.mId, objCMFunctionKeyWordEN.UpdUser);
}
if (objCMFunctionKeyWordEN != null)
{
int intRecNum = CMFunctionKeyWordDA.DelRecord(lngmId);
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
objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
//删除与表:[CMFunctionKeyWord]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMFunctionKeyWord.mId,
//lngmId);
//        clsCMFunctionKeyWordBL.DelCMFunctionKeyWordsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFunctionKeyWordBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFunctionKeyWordBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsCMFunctionKeyWordBL.relatedActions != null)
{
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CMFunctionKeyWordDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelCMFunctionKeyWords(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCMFunctionKeyWordBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMFunctionKeyWordDA.DelCMFunctionKeyWord(arrmIdLst);
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
public static int DelCMFunctionKeyWordsByCond(string strWhereCond)
{
try
{
if (clsCMFunctionKeyWordBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCMFunctionKeyWordBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = CMFunctionKeyWordDA.DelCMFunctionKeyWord(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMFunctionKeyWord]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
//删除与表:[CMFunctionKeyWord]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFunctionKeyWordBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFunctionKeyWordBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(clsCMFunctionKeyWordEN objCMFunctionKeyWordENS, clsCMFunctionKeyWordEN objCMFunctionKeyWordENT)
{
try
{
objCMFunctionKeyWordENT.mId = objCMFunctionKeyWordENS.mId; //mId
objCMFunctionKeyWordENT.CmFunctionId = objCMFunctionKeyWordENS.CmFunctionId; //函数Id
objCMFunctionKeyWordENT.Keyword = objCMFunctionKeyWordENS.Keyword; //关键字
objCMFunctionKeyWordENT.UpdDate = objCMFunctionKeyWordENS.UpdDate; //修改日期
objCMFunctionKeyWordENT.UpdUser = objCMFunctionKeyWordENS.UpdUser; //修改者
objCMFunctionKeyWordENT.Memo = objCMFunctionKeyWordENS.Memo; //说明
objCMFunctionKeyWordENT.IsSynchToServer = objCMFunctionKeyWordENS.IsSynchToServer; //是否同步到Server
objCMFunctionKeyWordENT.SynchToServerDate = objCMFunctionKeyWordENS.SynchToServerDate; //同步到Server日期
objCMFunctionKeyWordENT.SynchToServerUser = objCMFunctionKeyWordENS.SynchToServerUser; //同步到Server用户
objCMFunctionKeyWordENT.IsSynchToClient = objCMFunctionKeyWordENS.IsSynchToClient; //是否同步到Client
objCMFunctionKeyWordENT.SynchToClientDate = objCMFunctionKeyWordENS.SynchToClientDate; //同步到Client库日期
objCMFunctionKeyWordENT.SynchToClientUser = objCMFunctionKeyWordENS.SynchToClientUser; //同步到Client库用户
objCMFunctionKeyWordENT.SynSource = objCMFunctionKeyWordENS.SynSource; //同步来源
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
 /// <param name = "objCMFunctionKeyWordEN">源简化对象</param>
 public static void SetUpdFlag(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
try
{
objCMFunctionKeyWordEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMFunctionKeyWordEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMFunctionKeyWord.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.mId = objCMFunctionKeyWordEN.mId; //mId
}
if (arrFldSet.Contains(conCMFunctionKeyWord.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.CmFunctionId = objCMFunctionKeyWordEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(conCMFunctionKeyWord.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.Keyword = objCMFunctionKeyWordEN.Keyword; //关键字
}
if (arrFldSet.Contains(conCMFunctionKeyWord.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.UpdDate = objCMFunctionKeyWordEN.UpdDate == "[null]" ? null :  objCMFunctionKeyWordEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMFunctionKeyWord.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.UpdUser = objCMFunctionKeyWordEN.UpdUser == "[null]" ? null :  objCMFunctionKeyWordEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMFunctionKeyWord.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.Memo = objCMFunctionKeyWordEN.Memo == "[null]" ? null :  objCMFunctionKeyWordEN.Memo; //说明
}
if (arrFldSet.Contains(conCMFunctionKeyWord.IsSynchToServer, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.IsSynchToServer = objCMFunctionKeyWordEN.IsSynchToServer; //是否同步到Server
}
if (arrFldSet.Contains(conCMFunctionKeyWord.SynchToServerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.SynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate == "[null]" ? null :  objCMFunctionKeyWordEN.SynchToServerDate; //同步到Server日期
}
if (arrFldSet.Contains(conCMFunctionKeyWord.SynchToServerUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.SynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser == "[null]" ? null :  objCMFunctionKeyWordEN.SynchToServerUser; //同步到Server用户
}
if (arrFldSet.Contains(conCMFunctionKeyWord.IsSynchToClient, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.IsSynchToClient = objCMFunctionKeyWordEN.IsSynchToClient; //是否同步到Client
}
if (arrFldSet.Contains(conCMFunctionKeyWord.SynchToClientDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.SynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate == "[null]" ? null :  objCMFunctionKeyWordEN.SynchToClientDate; //同步到Client库日期
}
if (arrFldSet.Contains(conCMFunctionKeyWord.SynchToClientUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.SynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser == "[null]" ? null :  objCMFunctionKeyWordEN.SynchToClientUser; //同步到Client库用户
}
if (arrFldSet.Contains(conCMFunctionKeyWord.SynSource, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionKeyWordEN.SynSource = objCMFunctionKeyWordEN.SynSource == "[null]" ? null :  objCMFunctionKeyWordEN.SynSource; //同步来源
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
 /// <param name = "objCMFunctionKeyWordEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
try
{
if (objCMFunctionKeyWordEN.UpdDate == "[null]") objCMFunctionKeyWordEN.UpdDate = null; //修改日期
if (objCMFunctionKeyWordEN.UpdUser == "[null]") objCMFunctionKeyWordEN.UpdUser = null; //修改者
if (objCMFunctionKeyWordEN.Memo == "[null]") objCMFunctionKeyWordEN.Memo = null; //说明
if (objCMFunctionKeyWordEN.SynchToServerDate == "[null]") objCMFunctionKeyWordEN.SynchToServerDate = null; //同步到Server日期
if (objCMFunctionKeyWordEN.SynchToServerUser == "[null]") objCMFunctionKeyWordEN.SynchToServerUser = null; //同步到Server用户
if (objCMFunctionKeyWordEN.SynchToClientDate == "[null]") objCMFunctionKeyWordEN.SynchToClientDate = null; //同步到Client库日期
if (objCMFunctionKeyWordEN.SynchToClientUser == "[null]") objCMFunctionKeyWordEN.SynchToClientUser = null; //同步到Client库用户
if (objCMFunctionKeyWordEN.SynSource == "[null]") objCMFunctionKeyWordEN.SynSource = null; //同步来源
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
public static void CheckPropertyNew(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 CMFunctionKeyWordDA.CheckPropertyNew(objCMFunctionKeyWordEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 CMFunctionKeyWordDA.CheckProperty4Condition(objCMFunctionKeyWordEN);
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
if (clsCMFunctionKeyWordBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionKeyWordBL没有刷新缓存机制(clsCMFunctionKeyWordBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCMFunctionKeyWordObjLstCache == null)
//{
//arrCMFunctionKeyWordObjLstCache = CMFunctionKeyWordDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFunctionKeyWordEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLst_Sel =
arrCMFunctionKeyWordObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCMFunctionKeyWordObjLst_Sel.Count() == 0)
{
   clsCMFunctionKeyWordEN obj = clsCMFunctionKeyWordBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMFunctionKeyWordObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetAllCMFunctionKeyWordObjLstCache()
{
//获取缓存中的对象列表
List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLstCache = GetObjLstCache(); 
return arrCMFunctionKeyWordObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
List<clsCMFunctionKeyWordEN> arrCMFunctionKeyWordObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMFunctionKeyWordObjLstCache;
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
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionKeyWordEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMFunctionKeyWordEN._RefreshTimeLst.Count == 0) return "";
return clsCMFunctionKeyWordEN._RefreshTimeLst[clsCMFunctionKeyWordEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCMFunctionKeyWordBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionKeyWordEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMFunctionKeyWordBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMFunctionKeyWord(CM函数关键字)
 /// 唯一性条件:CMFunctionId_KeyWord
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检测记录是否存在
string strResult = CMFunctionKeyWordDA.GetUniCondStr(objCMFunctionKeyWordEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conCMFunctionKeyWord.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMFunctionKeyWord._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMFunctionKeyWord._AttributeName));
throw new Exception(strMsg);
}
var objCMFunctionKeyWord = clsCMFunctionKeyWordBL.GetObjBymIdCache(lngmId);
if (objCMFunctionKeyWord == null) return "";
return objCMFunctionKeyWord[strOutFldName].ToString();
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
int intRecCount = clsCMFunctionKeyWordDA.GetRecCount(strTabName);
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
int intRecCount = clsCMFunctionKeyWordDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMFunctionKeyWordDA.GetRecCount();
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
int intRecCount = clsCMFunctionKeyWordDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMFunctionKeyWordEN objCMFunctionKeyWordCond)
{
List<clsCMFunctionKeyWordEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionKeyWordEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFunctionKeyWord._AttributeName)
{
if (objCMFunctionKeyWordCond.IsUpdated(strFldName) == false) continue;
if (objCMFunctionKeyWordCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionKeyWordCond[strFldName].ToString());
}
else
{
if (objCMFunctionKeyWordCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFunctionKeyWordCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionKeyWordCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFunctionKeyWordCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFunctionKeyWordCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFunctionKeyWordCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFunctionKeyWordCond[strFldName]));
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
 List<string> arrList = clsCMFunctionKeyWordDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMFunctionKeyWordDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMFunctionKeyWordDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMFunctionKeyWordDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFunctionKeyWordDA.SetFldValue(clsCMFunctionKeyWordEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMFunctionKeyWordDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFunctionKeyWordDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFunctionKeyWordDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFunctionKeyWordDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMFunctionKeyWord] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**函数Id*/ 
 strCreateTabCode.Append(" CmFunctionId char(8) not Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否同步到Server*/ 
 strCreateTabCode.Append(" IsSynchToServer bit Null, "); 
 // /**同步到Server日期*/ 
 strCreateTabCode.Append(" SynchToServerDate varchar(20) Null, "); 
 // /**同步到Server用户*/ 
 strCreateTabCode.Append(" SynchToServerUser varchar(20) Null, "); 
 // /**是否同步到Client*/ 
 strCreateTabCode.Append(" IsSynchToClient bit Null, "); 
 // /**同步到Client库日期*/ 
 strCreateTabCode.Append(" SynchToClientDate varchar(20) Null, "); 
 // /**同步到Client库用户*/ 
 strCreateTabCode.Append(" SynchToClientUser varchar(20) Null, "); 
 // /**同步来源*/ 
 strCreateTabCode.Append(" SynSource varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CM函数关键字(CMFunctionKeyWord)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMFunctionKeyWord : clsCommFun4BL
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
clsCMFunctionKeyWordBL.ReFreshThisCache();
}
}

}