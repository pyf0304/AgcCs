
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjDataBaseBL
 表名:PrjDataBase(00050176)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsPrjDataBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjDataBaseEN GetObj(this K_PrjDataBaseId_PrjDataBase myKey)
{
clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.PrjDataBaseDA.GetObjByPrjDataBaseId(myKey.Value);
return objPrjDataBaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsPrjDataBaseBL.AddNewRecord)", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjDataBaseBL.PrjDataBaseDA.AddNewRecordBySQL2(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjDataBaseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjDataBaseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(项目数据库名(PrjDataBaseName)=[{0}])已经存在,不能重复!", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjDataBaseEN.AddNewRecord();
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsPrjDataBaseBL.AddNewRecordWithMaxId)", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
string strPrjDataBaseId = clsPrjDataBaseBL.PrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objPrjDataBaseEN);
     objPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
}
return strPrjDataBaseId;
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjDataBaseEN) == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsPrjDataBaseBL.AddNewRecordWithReturnKey)", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
string strKey = clsPrjDataBaseBL.PrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetPrjDataBaseId(this clsPrjDataBaseEN objPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conPrjDataBase.PrjDataBaseId);
}
objPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.PrjDataBaseId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.PrjDataBaseId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.PrjDataBaseId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetPrjDataBaseName(this clsPrjDataBaseEN objPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseName, conPrjDataBase.PrjDataBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, conPrjDataBase.PrjDataBaseName);
}
objPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.PrjDataBaseName) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseName(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conPrjDataBase.DataBaseName);
}
objPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseName) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDatabaseOwner(this clsPrjDataBaseEN objPrjDataBaseEN, string strDatabaseOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, conPrjDataBase.DatabaseOwner);
}
objPrjDataBaseEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DatabaseOwner) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DatabaseOwner, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DatabaseOwner] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBasePwd(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBasePwd, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBasePwd, conPrjDataBase.DataBasePwd);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, conPrjDataBase.DataBasePwd);
}
objPrjDataBaseEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBasePwd) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBasePwd, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBasePwd] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseTypeId(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, conPrjDataBase.DataBaseTypeId);
}
objPrjDataBaseEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseTypeId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseTypeId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseTypeId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetDataBaseUserId(this clsPrjDataBaseEN objPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, conPrjDataBase.DataBaseUserId);
}
objPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.DataBaseUserId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetIpAddress(this clsPrjDataBaseEN objPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, conPrjDataBase.IpAddress);
}
objPrjDataBaseEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.IpAddress) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetSid(this clsPrjDataBaseEN objPrjDataBaseEN, string strSid, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSid, 50, conPrjDataBase.Sid);
}
objPrjDataBaseEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.Sid) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.Sid, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.Sid] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetTableSpace(this clsPrjDataBaseEN objPrjDataBaseEN, string strTableSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableSpace, 50, conPrjDataBase.TableSpace);
}
objPrjDataBaseEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.TableSpace) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.TableSpace, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.TableSpace] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUseStateId(this clsPrjDataBaseEN objPrjDataBaseEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conPrjDataBase.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conPrjDataBase.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conPrjDataBase.UseStateId);
}
objPrjDataBaseEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UseStateId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UseStateId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UseStateId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUserId(this clsPrjDataBaseEN objPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conPrjDataBase.UserId);
}
objPrjDataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UserId) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UserId, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UserId] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetUpdDate(this clsPrjDataBaseEN objPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjDataBase.UpdDate);
}
objPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.UpdDate) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjDataBaseEN SetMemo(this clsPrjDataBaseEN objPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjDataBase.Memo);
}
objPrjDataBaseEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjDataBaseEN.dicFldComparisonOp.ContainsKey(conPrjDataBase.Memo) == false)
{
objPrjDataBaseEN.dicFldComparisonOp.Add(conPrjDataBase.Memo, strComparisonOp);
}
else
{
objPrjDataBaseEN.dicFldComparisonOp[conPrjDataBase.Memo] = strComparisonOp;
}
}
return objPrjDataBaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjDataBaseEN objPrjDataBaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjDataBaseEN.CheckPropertyNew();
clsPrjDataBaseEN objPrjDataBaseCond = new clsPrjDataBaseEN();
string strCondition = objPrjDataBaseCond
.SetPrjDataBaseId(objPrjDataBaseEN.PrjDataBaseId, "<>")
.SetPrjDataBaseName(objPrjDataBaseEN.PrjDataBaseName, "=")
.GetCombineCondition();
objPrjDataBaseEN._IsCheckProperty = true;
bool bolIsExist = clsPrjDataBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjDataBaseName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjDataBaseEN.Update();
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
 /// <param name = "objPrjDataBase">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjDataBaseEN objPrjDataBase)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjDataBaseEN objPrjDataBaseCond = new clsPrjDataBaseEN();
string strCondition = objPrjDataBaseCond
.SetPrjDataBaseName(objPrjDataBase.PrjDataBaseName, "=")
.GetCombineCondition();
objPrjDataBase._IsCheckProperty = true;
bool bolIsExist = clsPrjDataBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjDataBase.PrjDataBaseId = clsPrjDataBaseBL.GetFirstID_S(strCondition);
objPrjDataBase.UpdateWithCondition(strCondition);
}
else
{
objPrjDataBase.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
objPrjDataBase.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjDataBaseEN objPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjDataBaseBL.PrjDataBaseDA.UpdateBySql2(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjDataBaseEN objPrjDataBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjDataBaseBL.PrjDataBaseDA.UpdateBySql2(objPrjDataBaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjDataBaseEN objPrjDataBaseEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjDataBaseBL.PrjDataBaseDA.UpdateBySqlWithCondition(objPrjDataBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjDataBaseEN objPrjDataBaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjDataBaseBL.PrjDataBaseDA.UpdateBySqlWithConditionTransaction(objPrjDataBaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
int intRecNum = clsPrjDataBaseBL.PrjDataBaseDA.DelRecord(objPrjDataBaseEN.PrjDataBaseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseENS">源对象</param>
 /// <param name = "objPrjDataBaseENT">目标对象</param>
 public static void CopyTo(this clsPrjDataBaseEN objPrjDataBaseENS, clsPrjDataBaseEN objPrjDataBaseENT)
{
try
{
objPrjDataBaseENT.PrjDataBaseId = objPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objPrjDataBaseENT.PrjDataBaseName = objPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objPrjDataBaseENT.DataBaseName = objPrjDataBaseENS.DataBaseName; //数据库名
objPrjDataBaseENT.DatabaseOwner = objPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objPrjDataBaseENT.DataBasePwd = objPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objPrjDataBaseENT.DataBaseTypeId = objPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objPrjDataBaseENT.DataBaseUserId = objPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objPrjDataBaseENT.IpAddress = objPrjDataBaseENS.IpAddress; //服务器
objPrjDataBaseENT.Sid = objPrjDataBaseENS.Sid; //SID
objPrjDataBaseENT.TableSpace = objPrjDataBaseENS.TableSpace; //表空间
objPrjDataBaseENT.UseStateId = objPrjDataBaseENS.UseStateId; //使用状态Id
objPrjDataBaseENT.UserId = objPrjDataBaseENS.UserId; //用户Id
objPrjDataBaseENT.UpdDate = objPrjDataBaseENS.UpdDate; //修改日期
objPrjDataBaseENT.Memo = objPrjDataBaseENS.Memo; //说明
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
 /// <param name = "objPrjDataBaseENS">源对象</param>
 /// <returns>目标对象=>clsPrjDataBaseEN:objPrjDataBaseENT</returns>
 public static clsPrjDataBaseEN CopyTo(this clsPrjDataBaseEN objPrjDataBaseENS)
{
try
{
 clsPrjDataBaseEN objPrjDataBaseENT = new clsPrjDataBaseEN()
{
PrjDataBaseId = objPrjDataBaseENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objPrjDataBaseENS.PrjDataBaseName, //项目数据库名
DataBaseName = objPrjDataBaseENS.DataBaseName, //数据库名
DatabaseOwner = objPrjDataBaseENS.DatabaseOwner, //数据库拥有者
DataBasePwd = objPrjDataBaseENS.DataBasePwd, //数据库的用户口令
DataBaseTypeId = objPrjDataBaseENS.DataBaseTypeId, //数据库类型ID
DataBaseUserId = objPrjDataBaseENS.DataBaseUserId, //数据库的用户ID
IpAddress = objPrjDataBaseENS.IpAddress, //服务器
Sid = objPrjDataBaseENS.Sid, //SID
TableSpace = objPrjDataBaseENS.TableSpace, //表空间
UseStateId = objPrjDataBaseENS.UseStateId, //使用状态Id
UserId = objPrjDataBaseENS.UserId, //用户Id
UpdDate = objPrjDataBaseENS.UpdDate, //修改日期
Memo = objPrjDataBaseENS.Memo, //说明
};
 return objPrjDataBaseENT;
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
public static void CheckPropertyNew(this clsPrjDataBaseEN objPrjDataBaseEN)
{
 clsPrjDataBaseBL.PrjDataBaseDA.CheckPropertyNew(objPrjDataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjDataBaseEN objPrjDataBaseEN)
{
 clsPrjDataBaseBL.PrjDataBaseDA.CheckProperty4Condition(objPrjDataBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjDataBaseEN objPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.PrjDataBaseId, objPrjDataBaseCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.PrjDataBaseName, objPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseName, objPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DatabaseOwner, objPrjDataBaseCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBasePwd, objPrjDataBaseCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseTypeId, objPrjDataBaseCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.DataBaseUserId, objPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.IpAddress, objPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.Sid) == true)
{
string strComparisonOpSid = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.Sid, objPrjDataBaseCond.Sid, strComparisonOpSid);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.TableSpace) == true)
{
string strComparisonOpTableSpace = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.TableSpace, objPrjDataBaseCond.TableSpace, strComparisonOpTableSpace);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UseStateId) == true)
{
string strComparisonOpUseStateId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UseStateId, objPrjDataBaseCond.UseStateId, strComparisonOpUseStateId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UserId, objPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.UpdDate, objPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjDataBaseCond.IsUpdated(conPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objPrjDataBaseCond.dicFldComparisonOp[conPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjDataBase.Memo, objPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjDataBase(数据库对象), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjDataBaseEN objPrjDataBaseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjDataBaseEN == null) return true;
if (objPrjDataBaseEN.PrjDataBaseId == null || objPrjDataBaseEN.PrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
if (clsPrjDataBaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjDataBaseId !=  '{0}'", objPrjDataBaseEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
if (clsPrjDataBaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjDataBase(数据库对象), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjDataBaseEN objPrjDataBaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjDataBaseEN == null) return "";
if (objPrjDataBaseEN.PrjDataBaseId == null || objPrjDataBaseEN.PrjDataBaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjDataBaseId !=  '{0}'", objPrjDataBaseEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and PrjDataBaseName = '{0}'", objPrjDataBaseEN.PrjDataBaseName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjDataBase
{
public virtual bool UpdRelaTabDate(string strPrjDataBaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjDataBaseBL
{
public static RelatedActions_PrjDataBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjDataBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjDataBaseDA PrjDataBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjDataBaseDA();
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
 public clsPrjDataBaseBL()
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
if (string.IsNullOrEmpty(clsPrjDataBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjDataBaseEN._ConnectString);
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
public static DataTable GetDataTable_PrjDataBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjDataBaseDA.GetDataTable_PrjDataBase(strWhereCond);
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
objDT = PrjDataBaseDA.GetDataTable(strWhereCond);
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
objDT = PrjDataBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjDataBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjDataBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjDataBaseDA.GetDataTable_Top(objTopPara);
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
objDT = PrjDataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLstByPrjDataBaseIdLst(List<string> arrPrjDataBaseIdLst)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjDataBaseIdLst, true);
 string strWhereCond = string.Format("PrjDataBaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjDataBaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjDataBaseEN> GetObjLstByPrjDataBaseIdLstCache(List<string> arrPrjDataBaseIdLst)
{
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel =
arrPrjDataBaseObjLstCache
.Where(x => arrPrjDataBaseIdLst.Contains(x.PrjDataBaseId));
return arrPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLst(string strWhereCond)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
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
public static List<clsPrjDataBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjDataBaseEN> GetSubObjLstCache(clsPrjDataBaseEN objPrjDataBaseCond)
{
List<clsPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjDataBase._AttributeName)
{
if (objPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjDataBaseCond[strFldName]));
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
public static List<clsPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
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
public static List<clsPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
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
List<clsPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
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
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
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
public static List<clsPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
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
public static List<clsPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjDataBaseEN> arrObjLst = new List<clsPrjDataBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN();
try
{
objPrjDataBaseEN.PrjDataBaseId = objRow[conPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objPrjDataBaseEN.PrjDataBaseName = objRow[conPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objPrjDataBaseEN.DataBaseName = objRow[conPrjDataBase.DataBaseName] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objPrjDataBaseEN.DatabaseOwner = objRow[conPrjDataBase.DatabaseOwner] == DBNull.Value ? null : objRow[conPrjDataBase.DatabaseOwner].ToString().Trim(); //数据库拥有者
objPrjDataBaseEN.DataBasePwd = objRow[conPrjDataBase.DataBasePwd].ToString().Trim(); //数据库的用户口令
objPrjDataBaseEN.DataBaseTypeId = objRow[conPrjDataBase.DataBaseTypeId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objPrjDataBaseEN.DataBaseUserId = objRow[conPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[conPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objPrjDataBaseEN.IpAddress = objRow[conPrjDataBase.IpAddress] == DBNull.Value ? null : objRow[conPrjDataBase.IpAddress].ToString().Trim(); //服务器
objPrjDataBaseEN.Sid = objRow[conPrjDataBase.Sid] == DBNull.Value ? null : objRow[conPrjDataBase.Sid].ToString().Trim(); //SID
objPrjDataBaseEN.TableSpace = objRow[conPrjDataBase.TableSpace] == DBNull.Value ? null : objRow[conPrjDataBase.TableSpace].ToString().Trim(); //表空间
objPrjDataBaseEN.UseStateId = objRow[conPrjDataBase.UseStateId].ToString().Trim(); //使用状态Id
objPrjDataBaseEN.UserId = objRow[conPrjDataBase.UserId] == DBNull.Value ? null : objRow[conPrjDataBase.UserId].ToString().Trim(); //用户Id
objPrjDataBaseEN.UpdDate = objRow[conPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[conPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objPrjDataBaseEN.Memo = objRow[conPrjDataBase.Memo] == DBNull.Value ? null : objRow[conPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjDataBaseEN.PrjDataBaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjDataBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjDataBase(ref clsPrjDataBaseEN objPrjDataBaseEN)
{
bool bolResult = PrjDataBaseDA.GetPrjDataBase(ref objPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjDataBaseEN GetObjByPrjDataBaseId(string strPrjDataBaseId)
{
if (strPrjDataBaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjDataBaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjDataBaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjDataBaseEN objPrjDataBaseEN = PrjDataBaseDA.GetObjByPrjDataBaseId(strPrjDataBaseId);
return objPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjDataBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjDataBaseEN objPrjDataBaseEN = PrjDataBaseDA.GetFirstObj(strWhereCond);
 return objPrjDataBaseEN;
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
public static clsPrjDataBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjDataBaseEN objPrjDataBaseEN = PrjDataBaseDA.GetObjByDataRow(objRow);
 return objPrjDataBaseEN;
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
public static clsPrjDataBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjDataBaseEN objPrjDataBaseEN = PrjDataBaseDA.GetObjByDataRow(objRow);
 return objPrjDataBaseEN;
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
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <param name = "lstPrjDataBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjDataBaseEN GetObjByPrjDataBaseIdFromList(string strPrjDataBaseId, List<clsPrjDataBaseEN> lstPrjDataBaseObjLst)
{
foreach (clsPrjDataBaseEN objPrjDataBaseEN in lstPrjDataBaseObjLst)
{
if (objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId)
{
return objPrjDataBaseEN;
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
 string strMaxPrjDataBaseId;
 try
 {
 strMaxPrjDataBaseId = clsPrjDataBaseDA.GetMaxStrId();
 return strMaxPrjDataBaseId;
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
 string strPrjDataBaseId;
 try
 {
 strPrjDataBaseId = new clsPrjDataBaseDA().GetFirstID(strWhereCond);
 return strPrjDataBaseId;
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
 arrList = PrjDataBaseDA.GetID(strWhereCond);
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
bool bolIsExist = PrjDataBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjDataBaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjDataBaseDA.IsExist(strPrjDataBaseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPrjDataBaseId">项目数据库Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPrjDataBaseId, string strOpUser)
{
clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
objPrjDataBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsPrjDataBaseBL.UpdateBySql2(objPrjDataBaseEN);
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
 bolIsExist = clsPrjDataBaseDA.IsExistTable();
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
 bolIsExist = PrjDataBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjDataBaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsPrjDataBaseBL.AddNewRecordBySql2)", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
bool bolResult = PrjDataBaseDA.AddNewRecordBySQL2(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjDataBaseEN objPrjDataBaseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjDataBaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目数据库名 = [{0}]的数据已经存在!(in clsPrjDataBaseBL.AddNewRecordBySql2WithReturnKey)", objPrjDataBaseEN.PrjDataBaseName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true || clsPrjDataBaseBL.IsExist(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
     objPrjDataBaseEN.PrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
 }
string strKey = PrjDataBaseDA.AddNewRecordBySQL2WithReturnKey(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
bool bolResult = PrjDataBaseDA.Update(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "objPrjDataBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjDataBaseEN objPrjDataBaseEN)
{
 if (string.IsNullOrEmpty(objPrjDataBaseEN.PrjDataBaseId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjDataBaseDA.UpdateBySql2(objPrjDataBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjDataBaseBL.ReFreshCache();

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
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
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjDataBaseId)
{
try
{
 clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);

if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(objPrjDataBaseEN.PrjDataBaseId, "SetUpdDate");
}
if (objPrjDataBaseEN != null)
{
int intRecNum = PrjDataBaseDA.DelRecord(strPrjDataBaseId);
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
/// <param name="strPrjDataBaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjDataBaseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
//删除与表:[PrjDataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjDataBase.PrjDataBaseId,
//strPrjDataBaseId);
//        clsPrjDataBaseBL.DelPrjDataBasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjDataBaseBL.DelRecord(strPrjDataBaseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjDataBaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjDataBaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjDataBaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjDataBaseBL.relatedActions != null)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(strPrjDataBaseId, "UpdRelaTabDate");
}
bool bolResult = PrjDataBaseDA.DelRecord(strPrjDataBaseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjDataBaseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjDataBases(List<string> arrPrjDataBaseIdLst)
{
if (arrPrjDataBaseIdLst.Count == 0) return 0;
try
{
if (clsPrjDataBaseBL.relatedActions != null)
{
foreach (var strPrjDataBaseId in arrPrjDataBaseIdLst)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(strPrjDataBaseId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjDataBaseDA.DelPrjDataBase(arrPrjDataBaseIdLst);
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
public static int DelPrjDataBasesByCond(string strWhereCond)
{
try
{
if (clsPrjDataBaseBL.relatedActions != null)
{
List<string> arrPrjDataBaseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjDataBaseId in arrPrjDataBaseId)
{
clsPrjDataBaseBL.relatedActions.UpdRelaTabDate(strPrjDataBaseId, "UpdRelaTabDate");
}
}
int intRecNum = PrjDataBaseDA.DelPrjDataBase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjDataBase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjDataBaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjDataBaseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjDataBaseDA.GetSpecSQLObj();
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
//删除与表:[PrjDataBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjDataBaseBL.DelRecord(strPrjDataBaseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjDataBaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjDataBaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjDataBaseENS">源对象</param>
 /// <param name = "objPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsPrjDataBaseEN objPrjDataBaseENS, clsPrjDataBaseEN objPrjDataBaseENT)
{
try
{
objPrjDataBaseENT.PrjDataBaseId = objPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objPrjDataBaseENT.PrjDataBaseName = objPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objPrjDataBaseENT.DataBaseName = objPrjDataBaseENS.DataBaseName; //数据库名
objPrjDataBaseENT.DatabaseOwner = objPrjDataBaseENS.DatabaseOwner; //数据库拥有者
objPrjDataBaseENT.DataBasePwd = objPrjDataBaseENS.DataBasePwd; //数据库的用户口令
objPrjDataBaseENT.DataBaseTypeId = objPrjDataBaseENS.DataBaseTypeId; //数据库类型ID
objPrjDataBaseENT.DataBaseUserId = objPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objPrjDataBaseENT.IpAddress = objPrjDataBaseENS.IpAddress; //服务器
objPrjDataBaseENT.Sid = objPrjDataBaseENS.Sid; //SID
objPrjDataBaseENT.TableSpace = objPrjDataBaseENS.TableSpace; //表空间
objPrjDataBaseENT.UseStateId = objPrjDataBaseENS.UseStateId; //使用状态Id
objPrjDataBaseENT.UserId = objPrjDataBaseENS.UserId; //用户Id
objPrjDataBaseENT.UpdDate = objPrjDataBaseENS.UpdDate; //修改日期
objPrjDataBaseENT.Memo = objPrjDataBaseENS.Memo; //说明
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
 /// <param name = "objPrjDataBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
objPrjDataBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjDataBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjDataBase.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.PrjDataBaseId = objPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(conPrjDataBase.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.PrjDataBaseName = objPrjDataBaseEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(conPrjDataBase.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.DataBaseName = objPrjDataBaseEN.DataBaseName == "[null]" ? null :  objPrjDataBaseEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(conPrjDataBase.DatabaseOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.DatabaseOwner = objPrjDataBaseEN.DatabaseOwner == "[null]" ? null :  objPrjDataBaseEN.DatabaseOwner; //数据库拥有者
}
if (arrFldSet.Contains(conPrjDataBase.DataBasePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.DataBasePwd = objPrjDataBaseEN.DataBasePwd; //数据库的用户口令
}
if (arrFldSet.Contains(conPrjDataBase.DataBaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.DataBaseTypeId = objPrjDataBaseEN.DataBaseTypeId == "[null]" ? null :  objPrjDataBaseEN.DataBaseTypeId; //数据库类型ID
}
if (arrFldSet.Contains(conPrjDataBase.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.DataBaseUserId = objPrjDataBaseEN.DataBaseUserId == "[null]" ? null :  objPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
}
if (arrFldSet.Contains(conPrjDataBase.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.IpAddress = objPrjDataBaseEN.IpAddress == "[null]" ? null :  objPrjDataBaseEN.IpAddress; //服务器
}
if (arrFldSet.Contains(conPrjDataBase.Sid, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.Sid = objPrjDataBaseEN.Sid == "[null]" ? null :  objPrjDataBaseEN.Sid; //SID
}
if (arrFldSet.Contains(conPrjDataBase.TableSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.TableSpace = objPrjDataBaseEN.TableSpace == "[null]" ? null :  objPrjDataBaseEN.TableSpace; //表空间
}
if (arrFldSet.Contains(conPrjDataBase.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.UseStateId = objPrjDataBaseEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(conPrjDataBase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.UserId = objPrjDataBaseEN.UserId == "[null]" ? null :  objPrjDataBaseEN.UserId; //用户Id
}
if (arrFldSet.Contains(conPrjDataBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.UpdDate = objPrjDataBaseEN.UpdDate == "[null]" ? null :  objPrjDataBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjDataBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjDataBaseEN.Memo = objPrjDataBaseEN.Memo == "[null]" ? null :  objPrjDataBaseEN.Memo; //说明
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
 /// <param name = "objPrjDataBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjDataBaseEN objPrjDataBaseEN)
{
try
{
if (objPrjDataBaseEN.DataBaseName == "[null]") objPrjDataBaseEN.DataBaseName = null; //数据库名
if (objPrjDataBaseEN.DatabaseOwner == "[null]") objPrjDataBaseEN.DatabaseOwner = null; //数据库拥有者
if (objPrjDataBaseEN.DataBaseTypeId == "[null]") objPrjDataBaseEN.DataBaseTypeId = null; //数据库类型ID
if (objPrjDataBaseEN.DataBaseUserId == "[null]") objPrjDataBaseEN.DataBaseUserId = null; //数据库的用户ID
if (objPrjDataBaseEN.IpAddress == "[null]") objPrjDataBaseEN.IpAddress = null; //服务器
if (objPrjDataBaseEN.Sid == "[null]") objPrjDataBaseEN.Sid = null; //SID
if (objPrjDataBaseEN.TableSpace == "[null]") objPrjDataBaseEN.TableSpace = null; //表空间
if (objPrjDataBaseEN.UserId == "[null]") objPrjDataBaseEN.UserId = null; //用户Id
if (objPrjDataBaseEN.UpdDate == "[null]") objPrjDataBaseEN.UpdDate = null; //修改日期
if (objPrjDataBaseEN.Memo == "[null]") objPrjDataBaseEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjDataBaseEN objPrjDataBaseEN)
{
 PrjDataBaseDA.CheckPropertyNew(objPrjDataBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjDataBaseEN objPrjDataBaseEN)
{
 PrjDataBaseDA.CheckProperty4Condition(objPrjDataBaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PrjDataBaseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjDataBase.PrjDataBaseId); 
List<clsPrjDataBaseEN> arrObjLst = clsPrjDataBaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN()
{
PrjDataBaseId = "0",
PrjDataBaseName = "选[数据库对象]..."
};
arrObjLst.Insert(0, objPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjDataBase.PrjDataBaseId;
objComboBox.DisplayMember = conPrjDataBase.PrjDataBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjDataBase.PrjDataBaseId); 
IEnumerable<clsPrjDataBaseEN> arrObjLst = clsPrjDataBaseBL.GetObjLst(strCondition);
objDDL.DataValueField = conPrjDataBase.PrjDataBaseId;
objDDL.DataTextField = conPrjDataBase.PrjDataBaseName;
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
public static void BindDdl_PrjDataBaseIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据库对象]...","0");
List<clsPrjDataBaseEN> arrPrjDataBaseObjLst = GetAllPrjDataBaseObjLstCache(); 
objDDL.DataValueField = conPrjDataBase.PrjDataBaseId;
objDDL.DataTextField = conPrjDataBase.PrjDataBaseName;
objDDL.DataSource = arrPrjDataBaseObjLst;
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
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjDataBaseId");
//if (arrPrjDataBaseObjLstCache == null)
//{
//arrPrjDataBaseObjLstCache = PrjDataBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjDataBaseEN GetObjByPrjDataBaseIdCache(string strPrjDataBaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel =
arrPrjDataBaseObjLstCache
.Where(x=> x.PrjDataBaseId == strPrjDataBaseId 
);
if (arrPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsPrjDataBaseEN obj = clsPrjDataBaseBL.GetObjByPrjDataBaseId(strPrjDataBaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjDataBaseNameByPrjDataBaseIdCache(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return "";
//获取缓存中的对象列表
clsPrjDataBaseEN objPrjDataBase = GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
if (objPrjDataBase == null) return "";
return objPrjDataBase.PrjDataBaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjDataBaseIdCache(string strPrjDataBaseId)
{
if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return "";
//获取缓存中的对象列表
clsPrjDataBaseEN objPrjDataBase = GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
if (objPrjDataBase == null) return "";
return objPrjDataBase.PrjDataBaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjDataBaseEN> GetAllPrjDataBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = GetObjLstCache(); 
return arrPrjDataBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjDataBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
List<clsPrjDataBaseEN> arrPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjDataBaseObjLstCache;
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
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjDataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjDataBaseEN._RefreshTimeLst.Count == 0) return "";
return clsPrjDataBaseEN._RefreshTimeLst[clsPrjDataBaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPrjDataBaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjDataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjDataBaseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjDataBase(数据库对象)
 /// 唯一性条件:PrjDataBaseName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjDataBaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjDataBaseEN objPrjDataBaseEN)
{
//检测记录是否存在
string strResult = PrjDataBaseDA.GetUniCondStr(objPrjDataBaseEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjDataBaseId)
{
if (strInFldName != conPrjDataBase.PrjDataBaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjDataBase._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjDataBase._AttributeName));
throw new Exception(strMsg);
}
var objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
if (objPrjDataBase == null) return "";
return objPrjDataBase[strOutFldName].ToString();
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
int intRecCount = clsPrjDataBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjDataBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjDataBaseDA.GetRecCount();
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
int intRecCount = clsPrjDataBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjDataBaseEN objPrjDataBaseCond)
{
List<clsPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjDataBase._AttributeName)
{
if (objPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjDataBaseCond[strFldName]));
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
 List<string> arrList = clsPrjDataBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjDataBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjDataBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjDataBaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjDataBaseDA.SetFldValue(clsPrjDataBaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjDataBaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjDataBaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjDataBaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjDataBaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjDataBase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**项目数据库Id*/ 
 strCreateTabCode.Append(" PrjDataBaseId char(4) primary key, "); 
 // /**项目数据库名*/ 
 strCreateTabCode.Append(" PrjDataBaseName varchar(50) not Null, "); 
 // /**数据库名*/ 
 strCreateTabCode.Append(" DataBaseName varchar(50) Null, "); 
 // /**数据库拥有者*/ 
 strCreateTabCode.Append(" DatabaseOwner varchar(30) Null, "); 
 // /**数据库的用户口令*/ 
 strCreateTabCode.Append(" DataBasePwd varchar(30) not Null, "); 
 // /**数据库类型ID*/ 
 strCreateTabCode.Append(" DataBaseTypeId char(2) Null, "); 
 // /**数据库的用户ID*/ 
 strCreateTabCode.Append(" DataBaseUserId varchar(30) Null, "); 
 // /**服务器*/ 
 strCreateTabCode.Append(" IpAddress varchar(25) Null, "); 
 // /**SID*/ 
 strCreateTabCode.Append(" Sid varchar(50) Null, "); 
 // /**表空间*/ 
 strCreateTabCode.Append(" TableSpace varchar(50) Null, "); 
 // /**使用状态Id*/ 
 strCreateTabCode.Append(" UseStateId char(4) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据库对象(PrjDataBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjDataBase : clsCommFun4BL
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
clsPrjDataBaseBL.ReFreshThisCache();
}
}

}