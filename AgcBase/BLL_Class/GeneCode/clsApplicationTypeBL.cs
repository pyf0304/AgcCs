
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeBL
 表名:ApplicationType(00050127)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:42
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
public static class  clsApplicationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsApplicationTypeEN GetObj(this K_ApplicationTypeId_ApplicationType myKey)
{
clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.ApplicationTypeDA.GetObjByApplicationTypeId(myKey.Value);
return objApplicationTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsApplicationTypeEN objApplicationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objApplicationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型名称 = [{0}]的数据已经存在!(in clsApplicationTypeBL.AddNewRecord)", objApplicationTypeEN.ApplicationTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsApplicationTypeBL.ApplicationTypeDA.AddNewRecordBySQL2(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsApplicationTypeEN objApplicationTypeEN, bool bolIsNeedCheckUniqueness = true)
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
objApplicationTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objApplicationTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(应用程序类型名称(ApplicationTypeName)=[{0}])已经存在,不能重复!", objApplicationTypeEN.ApplicationTypeName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objApplicationTypeEN.AddNewRecord();
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsApplicationTypeEN objApplicationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objApplicationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型名称 = [{0}]的数据已经存在!(in clsApplicationTypeBL.AddNewRecordWithReturnKey)", objApplicationTypeEN.ApplicationTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = clsApplicationTypeBL.ApplicationTypeDA.AddNewRecordBySQL2WithReturnKey(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeId(this clsApplicationTypeEN objApplicationTypeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objApplicationTypeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeId) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeId, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeId] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, conApplicationType.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, conApplicationType.ApplicationTypeName);
}
objApplicationTypeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeSimName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, conApplicationType.ApplicationTypeSimName);
}
objApplicationTypeEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeSimName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeSimName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeSimName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeENName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, conApplicationType.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, conApplicationType.ApplicationTypeENName);
}
objApplicationTypeEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeENName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeENName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeENName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
}
objApplicationTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId2(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
}
objApplicationTypeEN.ProgLangTypeId2 = strProgLangTypeId2; //编程语言类型Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId2) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId2, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId2] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId3(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId3, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
}
objApplicationTypeEN.ProgLangTypeId3 = strProgLangTypeId3; //编程语言类型Id3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId3) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId3, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId3] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId4(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId4, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
}
objApplicationTypeEN.ProgLangTypeId4 = strProgLangTypeId4; //编程语言类型Id4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId4) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId4, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId4] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId5(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId5, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
}
objApplicationTypeEN.ProgLangTypeId5 = strProgLangTypeId5; //编程语言类型Id5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId5) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId5, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId5] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetIsVisible(this clsApplicationTypeEN objApplicationTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objApplicationTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.IsVisible) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.IsVisible, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.IsVisible] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetVisitedNum(this clsApplicationTypeEN objApplicationTypeEN, int? intVisitedNum, string strComparisonOp="")
	{
objApplicationTypeEN.VisitedNum = intVisitedNum; //访问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.VisitedNum) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.VisitedNum, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.VisitedNum] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetOrderNum(this clsApplicationTypeEN objApplicationTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conApplicationType.OrderNum);
objApplicationTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.OrderNum) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.OrderNum, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.OrderNum] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetMemo(this clsApplicationTypeEN objApplicationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conApplicationType.Memo);
}
objApplicationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.Memo) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.Memo, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.Memo] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsApplicationTypeEN objApplicationTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objApplicationTypeEN.CheckPropertyNew();
clsApplicationTypeEN objApplicationTypeCond = new clsApplicationTypeEN();
string strCondition = objApplicationTypeCond
.SetApplicationTypeId(objApplicationTypeEN.ApplicationTypeId, "<>")
.SetApplicationTypeName(objApplicationTypeEN.ApplicationTypeName, "=")
.GetCombineCondition();
objApplicationTypeEN._IsCheckProperty = true;
bool bolIsExist = clsApplicationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ApplicationTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objApplicationTypeEN.Update();
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
 /// <param name = "objApplicationType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsApplicationTypeEN objApplicationType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsApplicationTypeEN objApplicationTypeCond = new clsApplicationTypeEN();
string strCondition = objApplicationTypeCond
.SetApplicationTypeName(objApplicationType.ApplicationTypeName, "=")
.GetCombineCondition();
objApplicationType._IsCheckProperty = true;
bool bolIsExist = clsApplicationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objApplicationType.ApplicationTypeId = clsApplicationTypeBL.GetFirstID_S(strCondition);
objApplicationType.UpdateWithCondition(strCondition);
}
else
{
objApplicationType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN.ApplicationTypeId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsApplicationTypeBL.ApplicationTypeDA.UpdateBySql2(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsApplicationTypeEN objApplicationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objApplicationTypeEN.ApplicationTypeId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsApplicationTypeBL.ApplicationTypeDA.UpdateBySql2(objApplicationTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsApplicationTypeEN objApplicationTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsApplicationTypeBL.ApplicationTypeDA.UpdateBySqlWithCondition(objApplicationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsApplicationTypeEN objApplicationTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsApplicationTypeBL.ApplicationTypeDA.UpdateBySqlWithConditionTransaction(objApplicationTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsApplicationTypeEN objApplicationTypeEN)
{
try
{
int intRecNum = clsApplicationTypeBL.ApplicationTypeDA.DelRecord(objApplicationTypeEN.ApplicationTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
 public static void CopyTo(this clsApplicationTypeEN objApplicationTypeENS, clsApplicationTypeEN objApplicationTypeENT)
{
try
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
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
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <returns>目标对象=>clsApplicationTypeEN:objApplicationTypeENT</returns>
 public static clsApplicationTypeEN CopyTo(this clsApplicationTypeEN objApplicationTypeENS)
{
try
{
 clsApplicationTypeEN objApplicationTypeENT = new clsApplicationTypeEN()
{
ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName, //应用程序类型简称
ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName, //应用类型英文名
ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2, //编程语言类型Id2
ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3, //编程语言类型Id3
ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4, //编程语言类型Id4
ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5, //编程语言类型Id5
IsVisible = objApplicationTypeENS.IsVisible, //是否显示
VisitedNum = objApplicationTypeENS.VisitedNum, //访问数
OrderNum = objApplicationTypeENS.OrderNum, //序号
Memo = objApplicationTypeENS.Memo, //说明
};
 return objApplicationTypeENT;
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
public static void CheckPropertyNew(this clsApplicationTypeEN objApplicationTypeEN)
{
 clsApplicationTypeBL.ApplicationTypeDA.CheckPropertyNew(objApplicationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsApplicationTypeEN objApplicationTypeEN)
{
 clsApplicationTypeBL.ApplicationTypeDA.CheckProperty4Condition(objApplicationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsApplicationTypeEN objApplicationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.ApplicationTypeId, objApplicationTypeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeName, objApplicationTypeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeSimName, objApplicationTypeCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeENName, objApplicationTypeCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId, objApplicationTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId2) == true)
{
string strComparisonOpProgLangTypeId2 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId2, objApplicationTypeCond.ProgLangTypeId2, strComparisonOpProgLangTypeId2);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId3) == true)
{
string strComparisonOpProgLangTypeId3 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId3];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId3, objApplicationTypeCond.ProgLangTypeId3, strComparisonOpProgLangTypeId3);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId4) == true)
{
string strComparisonOpProgLangTypeId4 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId4];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId4, objApplicationTypeCond.ProgLangTypeId4, strComparisonOpProgLangTypeId4);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId5) == true)
{
string strComparisonOpProgLangTypeId5 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId5];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId5, objApplicationTypeCond.ProgLangTypeId5, strComparisonOpProgLangTypeId5);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.IsVisible) == true)
{
if (objApplicationTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conApplicationType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conApplicationType.IsVisible);
}
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.VisitedNum) == true)
{
string strComparisonOpVisitedNum = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.VisitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.VisitedNum, objApplicationTypeCond.VisitedNum, strComparisonOpVisitedNum);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.OrderNum) == true)
{
string strComparisonOpOrderNum = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.OrderNum, objApplicationTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.Memo) == true)
{
string strComparisonOpMemo = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.Memo, objApplicationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ApplicationType(应用程序类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objApplicationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsApplicationTypeEN objApplicationTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objApplicationTypeEN == null) return true;
if (objApplicationTypeEN.ApplicationTypeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
if (clsApplicationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ApplicationTypeId !=  {0}", objApplicationTypeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
if (clsApplicationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ApplicationType(应用程序类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objApplicationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsApplicationTypeEN objApplicationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objApplicationTypeEN == null) return "";
if (objApplicationTypeEN.ApplicationTypeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ApplicationTypeId !=  {0}", objApplicationTypeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ApplicationType
{
public virtual bool UpdRelaTabDate(int intApplicationTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public enum enumApplicationType : int
{
[Description("未知")]
Unknown_0 = 0,
[Description("Win应用")]
WinApp_1 = 1,
[Description("Web应用")]
WebApp_2 = 2,
[Description("JavaWeb应用")]
JavaWeb_3 = 3,
[Description("Web网站")]
WebSite_4 = 4,
[Description("AndroidApp")]
AndroidApp_5 = 5,
[Description("IOSApp")]
IOSApp_6 = 6,
[Description("公共应用后台")]
PubApp4WinWeb_7 = 7,
[Description("SilverLight应用")]
SilverLightApp_8 = 8,
[Description("未知")]
Unknown_9 = 9,
[Description("Web服务访问应用")]
WebSrvAccess_10 = 10,
[Description("表字段常量")]
TableFldConst_11 = 11,
[Description("WebApi访问应用")]
WebApiAccess_12 = 12,
[Description("AspMvc应用")]
AspMvcApp_13 = 13,
[Description("JavaWin应用程序")]
JavaWinApp_14 = 14,
[Description("SwiftWin应用程序")]
SwiftWinApp_15 = 15,
[Description("AspMvc应用-TS")]
AspMvcApp_TS_16 = 16,
[Description("Web应用-JS")]
WebApp_JS_17 = 17,
[Description("Spa应用InCore-TS")]
SpaAppInCore_TS_18 = 18,
[Description("WebApi应用")]
WebApi_19 = 19,
[Description("AspMvcAjax应用")]
AspMvcAjaxApp_20 = 20,
[Description("AndroidApp-WA")]
AndroidApp_WA_21 = 21,
[Description("IOSApp-WA")]
IOSApp_WA_22 = 22,
[Description("公共类")]
PubClass_23 = 23,
[Description("Neo4J应用")]
Neo4JApp_24 = 24,
[Description("Neo4J应用后台")]
Neo4JApp4WinWeb_25 = 25,
[Description("Neo4JWA访问应用")]
Neo4JWAAccess_26 = 26,
[Description("SpaInCoreUT")]
SpaInCoreUT_27 = 27,
[Description("Web应用-JS-RJ")]
WebApp_JS_RJ_28 = 28,
[Description("公共类-TS")]
PubClass_TS_29 = 29,
[Description("Vue应用InCore-TS")]
VueAppInCore_TS_30 = 30,
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsApplicationTypeBL
{
public static RelatedActions_ApplicationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsApplicationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsApplicationTypeDA ApplicationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsApplicationTypeDA();
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
 public clsApplicationTypeBL()
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
if (string.IsNullOrEmpty(clsApplicationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsApplicationTypeEN._ConnectString);
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
public static DataTable GetDataTable_ApplicationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ApplicationTypeDA.GetDataTable_ApplicationType(strWhereCond);
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
objDT = ApplicationTypeDA.GetDataTable(strWhereCond);
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
objDT = ApplicationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ApplicationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ApplicationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ApplicationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ApplicationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ApplicationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ApplicationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrApplicationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstByApplicationTypeIdLst(List<int> arrApplicationTypeIdLst)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrApplicationTypeIdLst);
 string strWhereCond = string.Format("ApplicationTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrApplicationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsApplicationTypeEN> GetObjLstByApplicationTypeIdLstCache(List<int> arrApplicationTypeIdLst)
{
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel =
arrApplicationTypeObjLstCache
.Where(x => arrApplicationTypeIdLst.Contains(x.ApplicationTypeId));
return arrApplicationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLst(string strWhereCond)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
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
public static List<clsApplicationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objApplicationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsApplicationTypeEN> GetSubObjLstCache(clsApplicationTypeEN objApplicationTypeCond)
{
List<clsApplicationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conApplicationType._AttributeName)
{
if (objApplicationTypeCond.IsUpdated(strFldName) == false) continue;
if (objApplicationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objApplicationTypeCond[strFldName].ToString());
}
else
{
if (objApplicationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objApplicationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objApplicationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objApplicationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objApplicationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objApplicationTypeCond[strFldName]));
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
public static List<clsApplicationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
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
public static List<clsApplicationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
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
List<clsApplicationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsApplicationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsApplicationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
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
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
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
public static List<clsApplicationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsApplicationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
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
public static List<clsApplicationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsApplicationTypeEN> arrObjLst = new List<clsApplicationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN();
try
{
objApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[conApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objApplicationTypeEN.ApplicationTypeName = objRow[conApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objApplicationTypeEN.ApplicationTypeSimName = objRow[conApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[conApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objApplicationTypeEN.ApplicationTypeENName = objRow[conApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objApplicationTypeEN.ProgLangTypeId = objRow[conApplicationType.ProgLangTypeId] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objApplicationTypeEN.ProgLangTypeId2 = objRow[conApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objApplicationTypeEN.ProgLangTypeId3 = objRow[conApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objApplicationTypeEN.ProgLangTypeId4 = objRow[conApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objApplicationTypeEN.ProgLangTypeId5 = objRow[conApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[conApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conApplicationType.IsVisible].ToString().Trim()); //是否显示
objApplicationTypeEN.VisitedNum = objRow[conApplicationType.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conApplicationType.VisitedNum].ToString().Trim()); //访问数
objApplicationTypeEN.OrderNum = Int32.Parse(objRow[conApplicationType.OrderNum].ToString().Trim()); //序号
objApplicationTypeEN.Memo = objRow[conApplicationType.Memo] == DBNull.Value ? null : objRow[conApplicationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objApplicationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objApplicationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetApplicationType(ref clsApplicationTypeEN objApplicationTypeEN)
{
bool bolResult = ApplicationTypeDA.GetApplicationType(ref objApplicationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
clsApplicationTypeEN objApplicationTypeEN = ApplicationTypeDA.GetObjByApplicationTypeId(intApplicationTypeId);
return objApplicationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsApplicationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsApplicationTypeEN objApplicationTypeEN = ApplicationTypeDA.GetFirstObj(strWhereCond);
 return objApplicationTypeEN;
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
public static clsApplicationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsApplicationTypeEN objApplicationTypeEN = ApplicationTypeDA.GetObjByDataRow(objRow);
 return objApplicationTypeEN;
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
public static clsApplicationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsApplicationTypeEN objApplicationTypeEN = ApplicationTypeDA.GetObjByDataRow(objRow);
 return objApplicationTypeEN;
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
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <param name = "lstApplicationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsApplicationTypeEN GetObjByApplicationTypeIdFromList(int intApplicationTypeId, List<clsApplicationTypeEN> lstApplicationTypeObjLst)
{
foreach (clsApplicationTypeEN objApplicationTypeEN in lstApplicationTypeObjLst)
{
if (objApplicationTypeEN.ApplicationTypeId == intApplicationTypeId)
{
return objApplicationTypeEN;
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
 int intApplicationTypeId;
 try
 {
 intApplicationTypeId = new clsApplicationTypeDA().GetFirstID(strWhereCond);
 return intApplicationTypeId;
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
 arrList = ApplicationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ApplicationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intApplicationTypeId)
{
//检测记录是否存在
bool bolIsExist = ApplicationTypeDA.IsExist(intApplicationTypeId);
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
 bolIsExist = clsApplicationTypeDA.IsExistTable();
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
 bolIsExist = ApplicationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsApplicationTypeEN objApplicationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objApplicationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型名称 = [{0}]的数据已经存在!(in clsApplicationTypeBL.AddNewRecordBySql2)", objApplicationTypeEN.ApplicationTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = ApplicationTypeDA.AddNewRecordBySQL2(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsApplicationTypeEN objApplicationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objApplicationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型名称 = [{0}]的数据已经存在!(in clsApplicationTypeBL.AddNewRecordBySql2WithReturnKey)", objApplicationTypeEN.ApplicationTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = ApplicationTypeDA.AddNewRecordBySQL2WithReturnKey(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsApplicationTypeEN objApplicationTypeEN)
{
try
{
bool bolResult = ApplicationTypeDA.Update(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN.ApplicationTypeId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ApplicationTypeDA.UpdateBySql2(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeBL.ReFreshCache();

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(int intApplicationTypeId)
{
try
{
 clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeId(intApplicationTypeId);

if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(objApplicationTypeEN.ApplicationTypeId, "SetUpdDate");
}
if (objApplicationTypeEN != null)
{
int intRecNum = ApplicationTypeDA.DelRecord(intApplicationTypeId);
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
/// <param name="intApplicationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(int intApplicationTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
//删除与表:[ApplicationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conApplicationType.ApplicationTypeId,
//intApplicationTypeId);
//        clsApplicationTypeBL.DelApplicationTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsApplicationTypeBL.DelRecord(intApplicationTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsApplicationTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intApplicationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(int intApplicationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsApplicationTypeBL.relatedActions != null)
{
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(intApplicationTypeId, "UpdRelaTabDate");
}
bool bolResult = ApplicationTypeDA.DelRecord(intApplicationTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrApplicationTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelApplicationTypes(List<string> arrApplicationTypeIdLst)
{
if (arrApplicationTypeIdLst.Count == 0) return 0;
try
{
if (clsApplicationTypeBL.relatedActions != null)
{
foreach (var strApplicationTypeId in arrApplicationTypeIdLst)
{
int intApplicationTypeId = int.Parse(strApplicationTypeId);
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(intApplicationTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ApplicationTypeDA.DelApplicationType(arrApplicationTypeIdLst);
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
public static int DelApplicationTypesByCond(string strWhereCond)
{
try
{
if (clsApplicationTypeBL.relatedActions != null)
{
List<string> arrApplicationTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strApplicationTypeId in arrApplicationTypeId)
{
int intApplicationTypeId = int.Parse(strApplicationTypeId);
clsApplicationTypeBL.relatedActions.UpdRelaTabDate(intApplicationTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ApplicationTypeDA.DelApplicationType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ApplicationType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="intApplicationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(int intApplicationTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsApplicationTypeDA.GetSpecSQLObj();
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
//删除与表:[ApplicationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsApplicationTypeBL.DelRecord(intApplicationTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsApplicationTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
intApplicationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
 public static void CopyTo(clsApplicationTypeEN objApplicationTypeENS, clsApplicationTypeEN objApplicationTypeENT)
{
try
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
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
 /// <param name = "objApplicationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsApplicationTypeEN objApplicationTypeEN)
{
try
{
objApplicationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objApplicationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conApplicationType.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ApplicationTypeId = objApplicationTypeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conApplicationType.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ApplicationTypeName = objApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(conApplicationType.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ApplicationTypeSimName = objApplicationTypeEN.ApplicationTypeSimName == "[null]" ? null :  objApplicationTypeEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(conApplicationType.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ApplicationTypeENName = objApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(conApplicationType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ProgLangTypeId = objApplicationTypeEN.ProgLangTypeId == "[null]" ? null :  objApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conApplicationType.ProgLangTypeId2, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ProgLangTypeId2 = objApplicationTypeEN.ProgLangTypeId2 == "[null]" ? null :  objApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
}
if (arrFldSet.Contains(conApplicationType.ProgLangTypeId3, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ProgLangTypeId3 = objApplicationTypeEN.ProgLangTypeId3 == "[null]" ? null :  objApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
}
if (arrFldSet.Contains(conApplicationType.ProgLangTypeId4, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ProgLangTypeId4 = objApplicationTypeEN.ProgLangTypeId4 == "[null]" ? null :  objApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
}
if (arrFldSet.Contains(conApplicationType.ProgLangTypeId5, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.ProgLangTypeId5 = objApplicationTypeEN.ProgLangTypeId5 == "[null]" ? null :  objApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
}
if (arrFldSet.Contains(conApplicationType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.IsVisible = objApplicationTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conApplicationType.VisitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.VisitedNum = objApplicationTypeEN.VisitedNum; //访问数
}
if (arrFldSet.Contains(conApplicationType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.OrderNum = objApplicationTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conApplicationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objApplicationTypeEN.Memo = objApplicationTypeEN.Memo == "[null]" ? null :  objApplicationTypeEN.Memo; //说明
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
 /// <param name = "objApplicationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsApplicationTypeEN objApplicationTypeEN)
{
try
{
if (objApplicationTypeEN.ApplicationTypeSimName == "[null]") objApplicationTypeEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objApplicationTypeEN.ProgLangTypeId == "[null]") objApplicationTypeEN.ProgLangTypeId = null; //编程语言类型Id
if (objApplicationTypeEN.ProgLangTypeId2 == "[null]") objApplicationTypeEN.ProgLangTypeId2 = null; //编程语言类型Id2
if (objApplicationTypeEN.ProgLangTypeId3 == "[null]") objApplicationTypeEN.ProgLangTypeId3 = null; //编程语言类型Id3
if (objApplicationTypeEN.ProgLangTypeId4 == "[null]") objApplicationTypeEN.ProgLangTypeId4 = null; //编程语言类型Id4
if (objApplicationTypeEN.ProgLangTypeId5 == "[null]") objApplicationTypeEN.ProgLangTypeId5 = null; //编程语言类型Id5
if (objApplicationTypeEN.Memo == "[null]") objApplicationTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsApplicationTypeEN objApplicationTypeEN)
{
 ApplicationTypeDA.CheckPropertyNew(objApplicationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsApplicationTypeEN objApplicationTypeEN)
{
 ApplicationTypeDA.CheckProperty4Condition(objApplicationTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conApplicationType.ApplicationTypeId); 
List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN()
{
ApplicationTypeId = 0,
ApplicationTypeName = "选[应用程序类型]..."
};
arrObjLst.Insert(0, objApplicationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conApplicationType.ApplicationTypeId;
objComboBox.DisplayMember = conApplicationType.ApplicationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[应用程序类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conApplicationType.ApplicationTypeId); 
IEnumerable<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum);
objDDL.DataValueField = conApplicationType.ApplicationTypeId;
objDDL.DataTextField = conApplicationType.ApplicationTypeName;
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
public static void BindDdl_ApplicationTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[应用程序类型]...","0");
List<clsApplicationTypeEN> arrApplicationTypeObjLst = GetAllApplicationTypeObjLstCache(); 
objDDL.DataValueField = conApplicationType.ApplicationTypeId;
objDDL.DataTextField = conApplicationType.ApplicationTypeName;
objDDL.DataSource = arrApplicationTypeObjLst;
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
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ApplicationTypeId");
//if (arrApplicationTypeObjLstCache == null)
//{
//arrApplicationTypeObjLstCache = ApplicationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsApplicationTypeEN GetObjByApplicationTypeIdCache(int intApplicationTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel =
arrApplicationTypeObjLstCache
.Where(x=> x.ApplicationTypeId == intApplicationTypeId 
);
if (arrApplicationTypeObjLst_Sel.Count() == 0)
{
   clsApplicationTypeEN obj = clsApplicationTypeBL.GetObjByApplicationTypeId(intApplicationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrApplicationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetApplicationTypeNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//获取缓存中的对象列表
clsApplicationTypeEN objApplicationType = GetObjByApplicationTypeIdCache(intApplicationTypeId);
if (objApplicationType == null) return "";
return objApplicationType.ApplicationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//获取缓存中的对象列表
clsApplicationTypeEN objApplicationType = GetObjByApplicationTypeIdCache(intApplicationTypeId);
if (objApplicationType == null) return "";
return objApplicationType.ApplicationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsApplicationTypeEN> GetAllApplicationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache(); 
return arrApplicationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrApplicationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsApplicationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsApplicationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsApplicationTypeEN._RefreshTimeLst[clsApplicationTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsApplicationTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsApplicationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsApplicationTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ApplicationType(应用程序类型)
 /// 唯一性条件:ApplicationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objApplicationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsApplicationTypeEN objApplicationTypeEN)
{
//检测记录是否存在
string strResult = ApplicationTypeDA.GetUniCondStr(objApplicationTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, int intApplicationTypeId)
{
if (strInFldName != conApplicationType.ApplicationTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conApplicationType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conApplicationType._AttributeName));
throw new Exception(strMsg);
}
var objApplicationType = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
if (objApplicationType == null) return "";
return objApplicationType[strOutFldName].ToString();
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
int intRecCount = clsApplicationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsApplicationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsApplicationTypeDA.GetRecCount();
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
int intRecCount = clsApplicationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objApplicationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsApplicationTypeEN objApplicationTypeCond)
{
List<clsApplicationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conApplicationType._AttributeName)
{
if (objApplicationTypeCond.IsUpdated(strFldName) == false) continue;
if (objApplicationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objApplicationTypeCond[strFldName].ToString());
}
else
{
if (objApplicationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objApplicationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objApplicationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objApplicationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objApplicationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objApplicationTypeCond[strFldName]));
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
 List<string> arrList = clsApplicationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ApplicationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ApplicationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ApplicationTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsApplicationTypeDA.SetFldValue(clsApplicationTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ApplicationTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsApplicationTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsApplicationTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsApplicationTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ApplicationType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int primary key identity, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) not Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**应用类型英文名*/ 
 strCreateTabCode.Append(" ApplicationTypeENName varchar(30) not Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) Null, "); 
 // /**编程语言类型Id2*/ 
 strCreateTabCode.Append(" ProgLangTypeId2 char(2) Null, "); 
 // /**编程语言类型Id3*/ 
 strCreateTabCode.Append(" ProgLangTypeId3 char(2) Null, "); 
 // /**编程语言类型Id4*/ 
 strCreateTabCode.Append(" ProgLangTypeId4 char(2) Null, "); 
 // /**编程语言类型Id5*/ 
 strCreateTabCode.Append(" ProgLangTypeId5 char(2) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**访问数*/ 
 strCreateTabCode.Append(" VisitedNum int Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ApplicationType : clsCommFun4BL
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
clsApplicationTypeBL.ReFreshThisCache();
}
}

}