
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFieldRelaBL
 表名:TabFieldRela(00050266)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsTabFieldRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFieldRelaEN GetObj(this K_IdFieldTabRela_TabFieldRela myKey)
{
clsTabFieldRelaEN objTabFieldRelaEN = clsTabFieldRelaBL.TabFieldRelaDA.GetObjByIdFieldTabRela(myKey.Value);
return objTabFieldRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFieldRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!字段Id = [{0}],表ID = [{1}]的数据已经存在!(in clsTabFieldRelaBL.AddNewRecord)", objTabFieldRelaEN.FldId,objTabFieldRelaEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabFieldRelaBL.TabFieldRelaDA.AddNewRecordBySQL2(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
public static bool AddRecordEx(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objTabFieldRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabFieldRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字段Id(FldId)=[{0}],表ID(TabId)=[{1}])已经存在,不能重复!", objTabFieldRelaEN.FldId, objTabFieldRelaEN.TabId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabFieldRelaEN.AddNewRecord();
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFieldRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!字段Id = [{0}],表ID = [{1}]的数据已经存在!(in clsTabFieldRelaBL.AddNewRecordWithReturnKey)", objTabFieldRelaEN.FldId,objTabFieldRelaEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabFieldRelaBL.TabFieldRelaDA.AddNewRecordBySQL2WithReturnKey(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIdFieldTabRela(this clsTabFieldRelaEN objTabFieldRelaEN, long lngIdFieldTabRela, string strComparisonOp="")
	{
objTabFieldRelaEN.IdFieldTabRela = lngIdFieldTabRela; //字段表关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IdFieldTabRela) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IdFieldTabRela, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IdFieldTabRela] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFldId(this clsTabFieldRelaEN objTabFieldRelaEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conTabFieldRela.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conTabFieldRela.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conTabFieldRela.FldId);
}
objTabFieldRelaEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FldId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FldId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FldId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTabId(this clsTabFieldRelaEN objTabFieldRelaEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabFieldRela.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabFieldRela.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabFieldRela.TabId);
}
objTabFieldRelaEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TabId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TabId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TabId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetSqlFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strSqlFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlFldName, 100, conTabFieldRela.SqlFldName);
}
objTabFieldRelaEN.SqlFldName = strSqlFldName; //Sql字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.SqlFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.SqlFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.SqlFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetExcelFieldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strExcelFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcelFieldName, 100, conTabFieldRela.ExcelFieldName);
}
objTabFieldRelaEN.ExcelFieldName = strExcelFieldName; //Excel字段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.ExcelFieldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.ExcelFieldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.ExcelFieldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetDefaultValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conTabFieldRela.DefaultValue);
}
objTabFieldRelaEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.DefaultValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.DefaultValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.DefaultValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsNeedTrans(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedTrans, string strComparisonOp="")
	{
objTabFieldRelaEN.IsNeedTrans = bolIsNeedTrans; //是否需要转换
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsNeedTrans) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsNeedTrans, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsNeedTrans] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransWayId(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTransWayId, conTabFieldRela.TransWayId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransWayId, 2, conTabFieldRela.TransWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTransWayId, 2, conTabFieldRela.TransWayId);
}
objTabFieldRelaEN.TransWayId = strTransWayId; //转换方式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransWayId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransWayId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransWayId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransTabName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransTabName, 50, conTabFieldRela.TransTabName);
}
objTabFieldRelaEN.TransTabName = strTransTabName; //转换表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransTabName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransTabName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransTabName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransInFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransInFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransInFldName, 50, conTabFieldRela.TransInFldName);
}
objTabFieldRelaEN.TransInFldName = strTransInFldName; //转换IN字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransInFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransInFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransInFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransOutFldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransOutFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransOutFldName, 50, conTabFieldRela.TransOutFldName);
}
objTabFieldRelaEN.TransOutFldName = strTransOutFldName; //转换Out字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransOutFldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransOutFldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransOutFldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabPrimary(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabPrimary, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabPrimary = bolIsTabPrimary; //是否作为表中主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabPrimary) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabPrimary, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabPrimary] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabForeignKey(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabForeignKey) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabForeignKey, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabForeignKey] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryTypeId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conTabFieldRela.PrimaryTypeId);
}
objTabFieldRelaEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryTypeId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryTypeId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryTypeId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsIdentity(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsIdentity, string strComparisonOp="")
	{
objTabFieldRelaEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsIdentity) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsIdentity, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsIdentity] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabUnique(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabUnique) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabUnique, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabUnique] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsTabNullable(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsTabNullable, string strComparisonOp="")
	{
objTabFieldRelaEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsTabNullable) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsTabNullable, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsTabNullable] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFieldTypeId(this clsTabFieldRelaEN objTabFieldRelaEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conTabFieldRela.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conTabFieldRela.FieldTypeId);
}
objTabFieldRelaEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FieldTypeId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FieldTypeId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FieldTypeId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsNeedCheckPriForeignKey(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckPriForeignKey, string strComparisonOp="")
	{
objTabFieldRelaEN.IsNeedCheckPriForeignKey = bolIsNeedCheckPriForeignKey; //是否检查主外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsNeedCheckPriForeignKey) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsNeedCheckPriForeignKey, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsNeedCheckPriForeignKey] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryKeyTabName(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryKeyTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabName, 50, conTabFieldRela.PrimaryKeyTabName);
}
objTabFieldRelaEN.PrimaryKeyTabName = strPrimaryKeyTabName; //主键表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryKeyTabName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryKeyTabName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryKeyTabName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrimaryKeyFieldName(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrimaryKeyFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyFieldName, 50, conTabFieldRela.PrimaryKeyFieldName);
}
objTabFieldRelaEN.PrimaryKeyFieldName = strPrimaryKeyFieldName; //主键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrimaryKeyFieldName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrimaryKeyFieldName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrimaryKeyFieldName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransMissingValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransMissingValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransMissingValue, 50, conTabFieldRela.TransMissingValue);
}
objTabFieldRelaEN.TransMissingValue = strTransMissingValue; //转换失败值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransMissingValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransMissingValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransMissingValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetTransNullValue(this clsTabFieldRelaEN objTabFieldRelaEN, string strTransNullValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransNullValue, 50, conTabFieldRela.TransNullValue);
}
objTabFieldRelaEN.TransNullValue = strTransNullValue; //转换空值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.TransNullValue) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.TransNullValue, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.TransNullValue] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrjId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabFieldRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFieldRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFieldRela.PrjId);
}
objTabFieldRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrjId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrjId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrjId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsVisible(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objTabFieldRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsVisible) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsVisible, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsVisible] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetSequenceNumber(this clsTabFieldRelaEN objTabFieldRelaEN, int? intSequenceNumber, string strComparisonOp="")
	{
objTabFieldRelaEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.SequenceNumber) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.SequenceNumber, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.SequenceNumber] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetMemo(this clsTabFieldRelaEN objTabFieldRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFieldRela.Memo);
}
objTabFieldRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.Memo) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.Memo, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.Memo] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFieldTypeIdS(this clsTabFieldRelaEN objTabFieldRelaEN, string strFieldTypeIdS, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeIdS, 2, conTabFieldRela.FieldTypeIdS);
}
objTabFieldRelaEN.FieldTypeIdS = strFieldTypeIdS; //FieldTypeId_S
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FieldTypeIdS) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FieldTypeIdS, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FieldTypeIdS] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetFldLengthS(this clsTabFieldRelaEN objTabFieldRelaEN, int? intFldLengthS, string strComparisonOp="")
	{
objTabFieldRelaEN.FldLengthS = intFldLengthS; //FldLength_S
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.FldLengthS) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.FldLengthS, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.FldLengthS] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetForeignKeyTabId(this clsTabFieldRelaEN objTabFieldRelaEN, string strForeignKeyTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conTabFieldRela.ForeignKeyTabId);
}
objTabFieldRelaEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.ForeignKeyTabId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.ForeignKeyTabId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.ForeignKeyTabId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetHashIndex(this clsTabFieldRelaEN objTabFieldRelaEN, int? intHashIndex, string strComparisonOp="")
	{
objTabFieldRelaEN.HashIndex = intHashIndex; //HASH表序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.HashIndex) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.HashIndex, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.HashIndex] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetIsUseHash(this clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsUseHash, string strComparisonOp="")
	{
objTabFieldRelaEN.IsUseHash = bolIsUseHash; //是否用HASH表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.IsUseHash) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.IsUseHash, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.IsUseHash] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrefix(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, conTabFieldRela.Prefix);
}
objTabFieldRelaEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.Prefix) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.Prefix, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.Prefix] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetPrefixFldId(this clsTabFieldRelaEN objTabFieldRelaEN, string strPrefixFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefixFldId, 8, conTabFieldRela.PrefixFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrefixFldId, 8, conTabFieldRela.PrefixFldId);
}
objTabFieldRelaEN.PrefixFldId = strPrefixFldId; //前缀字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.PrefixFldId) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.PrefixFldId, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.PrefixFldId] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFieldRelaEN SetvFieldCnName(this clsTabFieldRelaEN objTabFieldRelaEN, string strvFieldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strvFieldCnName, 100, conTabFieldRela.vFieldCnName);
}
objTabFieldRelaEN.vFieldCnName = strvFieldCnName; //视图字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFieldRelaEN.dicFldComparisonOp.ContainsKey(conTabFieldRela.vFieldCnName) == false)
{
objTabFieldRelaEN.dicFldComparisonOp.Add(conTabFieldRela.vFieldCnName, strComparisonOp);
}
else
{
objTabFieldRelaEN.dicFldComparisonOp[conTabFieldRela.vFieldCnName] = strComparisonOp;
}
}
return objTabFieldRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabFieldRelaEN objTabFieldRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabFieldRelaEN.CheckPropertyNew();
clsTabFieldRelaEN objTabFieldRelaCond = new clsTabFieldRelaEN();
string strCondition = objTabFieldRelaCond
.SetIdFieldTabRela(objTabFieldRelaEN.IdFieldTabRela, "<>")
.SetFldId(objTabFieldRelaEN.FldId, "=")
.SetTabId(objTabFieldRelaEN.TabId, "=")
.GetCombineCondition();
objTabFieldRelaEN._IsCheckProperty = true;
bool bolIsExist = clsTabFieldRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FldId_TabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabFieldRelaEN.Update();
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
 /// <param name = "objTabFieldRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabFieldRelaEN objTabFieldRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabFieldRelaEN objTabFieldRelaCond = new clsTabFieldRelaEN();
string strCondition = objTabFieldRelaCond
.SetFldId(objTabFieldRela.FldId, "=")
.SetTabId(objTabFieldRela.TabId, "=")
.GetCombineCondition();
objTabFieldRela._IsCheckProperty = true;
bool bolIsExist = clsTabFieldRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabFieldRela.IdFieldTabRela = clsTabFieldRelaBL.GetFirstID_S(strCondition);
objTabFieldRela.UpdateWithCondition(strCondition);
}
else
{
objTabFieldRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN.IdFieldTabRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFieldRelaBL.TabFieldRelaDA.UpdateBySql2(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFieldRelaEN objTabFieldRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabFieldRelaEN.IdFieldTabRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFieldRelaBL.TabFieldRelaDA.UpdateBySql2(objTabFieldRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFieldRelaEN objTabFieldRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsTabFieldRelaBL.TabFieldRelaDA.UpdateBySqlWithCondition(objTabFieldRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFieldRelaEN objTabFieldRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabFieldRelaBL.TabFieldRelaDA.UpdateBySqlWithConditionTransaction(objTabFieldRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabFieldRelaEN objTabFieldRelaEN)
{
try
{
int intRecNum = clsTabFieldRelaBL.TabFieldRelaDA.DelRecord(objTabFieldRelaEN.IdFieldTabRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaENS">源对象</param>
 /// <param name = "objTabFieldRelaENT">目标对象</param>
 public static void CopyTo(this clsTabFieldRelaEN objTabFieldRelaENS, clsTabFieldRelaEN objTabFieldRelaENT)
{
try
{
objTabFieldRelaENT.IdFieldTabRela = objTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objTabFieldRelaENT.FldId = objTabFieldRelaENS.FldId; //字段Id
objTabFieldRelaENT.TabId = objTabFieldRelaENS.TabId; //表ID
objTabFieldRelaENT.SqlFldName = objTabFieldRelaENS.SqlFldName; //Sql字段名称
objTabFieldRelaENT.ExcelFieldName = objTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objTabFieldRelaENT.DefaultValue = objTabFieldRelaENS.DefaultValue; //缺省值
objTabFieldRelaENT.IsNeedTrans = objTabFieldRelaENS.IsNeedTrans; //是否需要转换
objTabFieldRelaENT.TransWayId = objTabFieldRelaENS.TransWayId; //转换方式ID
objTabFieldRelaENT.TransTabName = objTabFieldRelaENS.TransTabName; //转换表名
objTabFieldRelaENT.TransInFldName = objTabFieldRelaENS.TransInFldName; //转换IN字段名
objTabFieldRelaENT.TransOutFldName = objTabFieldRelaENS.TransOutFldName; //转换Out字段名
objTabFieldRelaENT.IsTabPrimary = objTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objTabFieldRelaENT.IsTabForeignKey = objTabFieldRelaENS.IsTabForeignKey; //是否表外键
objTabFieldRelaENT.PrimaryTypeId = objTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objTabFieldRelaENT.IsIdentity = objTabFieldRelaENS.IsIdentity; //是否Identity
objTabFieldRelaENT.IsTabUnique = objTabFieldRelaENS.IsTabUnique; //是否表中唯一
objTabFieldRelaENT.IsTabNullable = objTabFieldRelaENS.IsTabNullable; //是否表中可空
objTabFieldRelaENT.FieldTypeId = objTabFieldRelaENS.FieldTypeId; //字段类型Id
objTabFieldRelaENT.IsNeedCheckPriForeignKey = objTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objTabFieldRelaENT.PrimaryKeyTabName = objTabFieldRelaENS.PrimaryKeyTabName; //主键表
objTabFieldRelaENT.PrimaryKeyFieldName = objTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objTabFieldRelaENT.TransMissingValue = objTabFieldRelaENS.TransMissingValue; //转换失败值
objTabFieldRelaENT.TransNullValue = objTabFieldRelaENS.TransNullValue; //转换空值
objTabFieldRelaENT.PrjId = objTabFieldRelaENS.PrjId; //工程Id
objTabFieldRelaENT.IsVisible = objTabFieldRelaENS.IsVisible; //是否显示
objTabFieldRelaENT.SequenceNumber = objTabFieldRelaENS.SequenceNumber; //顺序号
objTabFieldRelaENT.Memo = objTabFieldRelaENS.Memo; //说明
objTabFieldRelaENT.FieldTypeIdS = objTabFieldRelaENS.FieldTypeIdS; //FieldTypeId_S
objTabFieldRelaENT.FldLengthS = objTabFieldRelaENS.FldLengthS; //FldLength_S
objTabFieldRelaENT.ForeignKeyTabId = objTabFieldRelaENS.ForeignKeyTabId; //外键表ID
objTabFieldRelaENT.HashIndex = objTabFieldRelaENS.HashIndex; //HASH表序号
objTabFieldRelaENT.IsUseHash = objTabFieldRelaENS.IsUseHash; //是否用HASH表
objTabFieldRelaENT.Prefix = objTabFieldRelaENS.Prefix; //前缀
objTabFieldRelaENT.PrefixFldId = objTabFieldRelaENS.PrefixFldId; //前缀字段Id
objTabFieldRelaENT.vFieldCnName = objTabFieldRelaENS.vFieldCnName; //视图字段中文名称
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
 /// <param name = "objTabFieldRelaENS">源对象</param>
 /// <returns>目标对象=>clsTabFieldRelaEN:objTabFieldRelaENT</returns>
 public static clsTabFieldRelaEN CopyTo(this clsTabFieldRelaEN objTabFieldRelaENS)
{
try
{
 clsTabFieldRelaEN objTabFieldRelaENT = new clsTabFieldRelaEN()
{
IdFieldTabRela = objTabFieldRelaENS.IdFieldTabRela, //字段表关系流水号
FldId = objTabFieldRelaENS.FldId, //字段Id
TabId = objTabFieldRelaENS.TabId, //表ID
SqlFldName = objTabFieldRelaENS.SqlFldName, //Sql字段名称
ExcelFieldName = objTabFieldRelaENS.ExcelFieldName, //Excel字段名称
DefaultValue = objTabFieldRelaENS.DefaultValue, //缺省值
IsNeedTrans = objTabFieldRelaENS.IsNeedTrans, //是否需要转换
TransWayId = objTabFieldRelaENS.TransWayId, //转换方式ID
TransTabName = objTabFieldRelaENS.TransTabName, //转换表名
TransInFldName = objTabFieldRelaENS.TransInFldName, //转换IN字段名
TransOutFldName = objTabFieldRelaENS.TransOutFldName, //转换Out字段名
IsTabPrimary = objTabFieldRelaENS.IsTabPrimary, //是否作为表中主键
IsTabForeignKey = objTabFieldRelaENS.IsTabForeignKey, //是否表外键
PrimaryTypeId = objTabFieldRelaENS.PrimaryTypeId, //主键类型ID
IsIdentity = objTabFieldRelaENS.IsIdentity, //是否Identity
IsTabUnique = objTabFieldRelaENS.IsTabUnique, //是否表中唯一
IsTabNullable = objTabFieldRelaENS.IsTabNullable, //是否表中可空
FieldTypeId = objTabFieldRelaENS.FieldTypeId, //字段类型Id
IsNeedCheckPriForeignKey = objTabFieldRelaENS.IsNeedCheckPriForeignKey, //是否检查主外键
PrimaryKeyTabName = objTabFieldRelaENS.PrimaryKeyTabName, //主键表
PrimaryKeyFieldName = objTabFieldRelaENS.PrimaryKeyFieldName, //主键字段名
TransMissingValue = objTabFieldRelaENS.TransMissingValue, //转换失败值
TransNullValue = objTabFieldRelaENS.TransNullValue, //转换空值
PrjId = objTabFieldRelaENS.PrjId, //工程Id
IsVisible = objTabFieldRelaENS.IsVisible, //是否显示
SequenceNumber = objTabFieldRelaENS.SequenceNumber, //顺序号
Memo = objTabFieldRelaENS.Memo, //说明
FieldTypeIdS = objTabFieldRelaENS.FieldTypeIdS, //FieldTypeId_S
FldLengthS = objTabFieldRelaENS.FldLengthS, //FldLength_S
ForeignKeyTabId = objTabFieldRelaENS.ForeignKeyTabId, //外键表ID
HashIndex = objTabFieldRelaENS.HashIndex, //HASH表序号
IsUseHash = objTabFieldRelaENS.IsUseHash, //是否用HASH表
Prefix = objTabFieldRelaENS.Prefix, //前缀
PrefixFldId = objTabFieldRelaENS.PrefixFldId, //前缀字段Id
vFieldCnName = objTabFieldRelaENS.vFieldCnName, //视图字段中文名称
};
 return objTabFieldRelaENT;
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
public static void CheckPropertyNew(this clsTabFieldRelaEN objTabFieldRelaEN)
{
 clsTabFieldRelaBL.TabFieldRelaDA.CheckPropertyNew(objTabFieldRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabFieldRelaEN objTabFieldRelaEN)
{
 clsTabFieldRelaBL.TabFieldRelaDA.CheckProperty4Condition(objTabFieldRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFieldRelaEN objTabFieldRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IdFieldTabRela) == true)
{
string strComparisonOpIdFieldTabRela = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.IdFieldTabRela];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.IdFieldTabRela, objTabFieldRelaCond.IdFieldTabRela, strComparisonOpIdFieldTabRela);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FldId) == true)
{
string strComparisonOpFldId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FldId, objTabFieldRelaCond.FldId, strComparisonOpFldId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TabId) == true)
{
string strComparisonOpTabId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TabId, objTabFieldRelaCond.TabId, strComparisonOpTabId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.SqlFldName) == true)
{
string strComparisonOpSqlFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.SqlFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.SqlFldName, objTabFieldRelaCond.SqlFldName, strComparisonOpSqlFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.ExcelFieldName) == true)
{
string strComparisonOpExcelFieldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.ExcelFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.ExcelFieldName, objTabFieldRelaCond.ExcelFieldName, strComparisonOpExcelFieldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.DefaultValue, objTabFieldRelaCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsNeedTrans) == true)
{
if (objTabFieldRelaCond.IsNeedTrans == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsNeedTrans);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsNeedTrans);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransWayId) == true)
{
string strComparisonOpTransWayId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransWayId, objTabFieldRelaCond.TransWayId, strComparisonOpTransWayId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransTabName) == true)
{
string strComparisonOpTransTabName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransTabName, objTabFieldRelaCond.TransTabName, strComparisonOpTransTabName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransInFldName) == true)
{
string strComparisonOpTransInFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransInFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransInFldName, objTabFieldRelaCond.TransInFldName, strComparisonOpTransInFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransOutFldName) == true)
{
string strComparisonOpTransOutFldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransOutFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransOutFldName, objTabFieldRelaCond.TransOutFldName, strComparisonOpTransOutFldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabPrimary) == true)
{
if (objTabFieldRelaCond.IsTabPrimary == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabPrimary);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabPrimary);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabForeignKey) == true)
{
if (objTabFieldRelaCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabForeignKey);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryTypeId, objTabFieldRelaCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsIdentity) == true)
{
if (objTabFieldRelaCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsIdentity);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabUnique) == true)
{
if (objTabFieldRelaCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabUnique);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsTabNullable) == true)
{
if (objTabFieldRelaCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsTabNullable);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FieldTypeId, objTabFieldRelaCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsNeedCheckPriForeignKey) == true)
{
if (objTabFieldRelaCond.IsNeedCheckPriForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsNeedCheckPriForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsNeedCheckPriForeignKey);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryKeyTabName) == true)
{
string strComparisonOpPrimaryKeyTabName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryKeyTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryKeyTabName, objTabFieldRelaCond.PrimaryKeyTabName, strComparisonOpPrimaryKeyTabName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrimaryKeyFieldName) == true)
{
string strComparisonOpPrimaryKeyFieldName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrimaryKeyFieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrimaryKeyFieldName, objTabFieldRelaCond.PrimaryKeyFieldName, strComparisonOpPrimaryKeyFieldName);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransMissingValue) == true)
{
string strComparisonOpTransMissingValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransMissingValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransMissingValue, objTabFieldRelaCond.TransMissingValue, strComparisonOpTransMissingValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.TransNullValue) == true)
{
string strComparisonOpTransNullValue = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.TransNullValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.TransNullValue, objTabFieldRelaCond.TransNullValue, strComparisonOpTransNullValue);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrjId) == true)
{
string strComparisonOpPrjId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrjId, objTabFieldRelaCond.PrjId, strComparisonOpPrjId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsVisible) == true)
{
if (objTabFieldRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsVisible);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.SequenceNumber, objTabFieldRelaCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.Memo) == true)
{
string strComparisonOpMemo = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.Memo, objTabFieldRelaCond.Memo, strComparisonOpMemo);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FieldTypeIdS) == true)
{
string strComparisonOpFieldTypeIdS = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FieldTypeIdS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.FieldTypeIdS, objTabFieldRelaCond.FieldTypeIdS, strComparisonOpFieldTypeIdS);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.FldLengthS) == true)
{
string strComparisonOpFldLengthS = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.FldLengthS];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.FldLengthS, objTabFieldRelaCond.FldLengthS, strComparisonOpFldLengthS);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.ForeignKeyTabId, objTabFieldRelaCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.HashIndex) == true)
{
string strComparisonOpHashIndex = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.HashIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFieldRela.HashIndex, objTabFieldRelaCond.HashIndex, strComparisonOpHashIndex);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.IsUseHash) == true)
{
if (objTabFieldRelaCond.IsUseHash == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFieldRela.IsUseHash);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFieldRela.IsUseHash);
}
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.Prefix) == true)
{
string strComparisonOpPrefix = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.Prefix, objTabFieldRelaCond.Prefix, strComparisonOpPrefix);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.PrefixFldId) == true)
{
string strComparisonOpPrefixFldId = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.PrefixFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.PrefixFldId, objTabFieldRelaCond.PrefixFldId, strComparisonOpPrefixFldId);
}
if (objTabFieldRelaCond.IsUpdated(conTabFieldRela.vFieldCnName) == true)
{
string strComparisonOpvFieldCnName = objTabFieldRelaCond.dicFldComparisonOp[conTabFieldRela.vFieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFieldRela.vFieldCnName, objTabFieldRelaCond.vFieldCnName, strComparisonOpvFieldCnName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabFieldRela(表字段关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FldId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabFieldRelaEN objTabFieldRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabFieldRelaEN == null) return true;
if (objTabFieldRelaEN.IdFieldTabRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
if (clsTabFieldRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdFieldTabRela !=  {0}", objTabFieldRelaEN.IdFieldTabRela);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
if (clsTabFieldRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TabFieldRela(表字段关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabFieldRelaEN objTabFieldRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFieldRelaEN == null) return "";
if (objTabFieldRelaEN.IdFieldTabRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdFieldTabRela !=  {0}", objTabFieldRelaEN.IdFieldTabRela);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFieldRelaEN.FldId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFieldRelaEN.TabId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabFieldRela
{
public virtual bool UpdRelaTabDate(long lngIdFieldTabRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表字段关系(TabFieldRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabFieldRelaBL
{
public static RelatedActions_TabFieldRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabFieldRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabFieldRelaDA TabFieldRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabFieldRelaDA();
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
 public clsTabFieldRelaBL()
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
if (string.IsNullOrEmpty(clsTabFieldRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFieldRelaEN._ConnectString);
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
public static DataTable GetDataTable_TabFieldRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabFieldRelaDA.GetDataTable_TabFieldRela(strWhereCond);
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
objDT = TabFieldRelaDA.GetDataTable(strWhereCond);
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
objDT = TabFieldRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabFieldRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabFieldRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabFieldRelaDA.GetDataTable_Top(objTopPara);
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
objDT = TabFieldRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabFieldRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabFieldRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdFieldTabRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstByIdFieldTabRelaLst(List<long> arrIdFieldTabRelaLst)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdFieldTabRelaLst);
 string strWhereCond = string.Format("IdFieldTabRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdFieldTabRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabFieldRelaEN> GetObjLstByIdFieldTabRelaLstCache(List<long> arrIdFieldTabRelaLst)
{
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrTabFieldRelaObjLst_Sel =
arrTabFieldRelaObjLstCache
.Where(x => arrIdFieldTabRelaLst.Contains(x.IdFieldTabRela));
return arrTabFieldRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLst(string strWhereCond)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
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
public static List<clsTabFieldRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabFieldRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabFieldRelaEN> GetSubObjLstCache(clsTabFieldRelaEN objTabFieldRelaCond)
{
List<clsTabFieldRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFieldRela._AttributeName)
{
if (objTabFieldRelaCond.IsUpdated(strFldName) == false) continue;
if (objTabFieldRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFieldRelaCond[strFldName].ToString());
}
else
{
if (objTabFieldRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFieldRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFieldRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFieldRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFieldRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFieldRelaCond[strFldName]));
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
public static List<clsTabFieldRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
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
public static List<clsTabFieldRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
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
List<clsTabFieldRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabFieldRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabFieldRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
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
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
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
public static List<clsTabFieldRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabFieldRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
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
public static List<clsTabFieldRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabFieldRelaEN> arrObjLst = new List<clsTabFieldRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFieldRelaEN objTabFieldRelaEN = new clsTabFieldRelaEN();
try
{
objTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[conTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objTabFieldRelaEN.FldId = objRow[conTabFieldRela.FldId].ToString().Trim(); //字段Id
objTabFieldRelaEN.TabId = objRow[conTabFieldRela.TabId].ToString().Trim(); //表ID
objTabFieldRelaEN.SqlFldName = objRow[conTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[conTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objTabFieldRelaEN.ExcelFieldName = objRow[conTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objTabFieldRelaEN.DefaultValue = objRow[conTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[conTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objTabFieldRelaEN.TransWayId = objRow[conTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objTabFieldRelaEN.TransTabName = objRow[conTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[conTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objTabFieldRelaEN.TransInFldName = objRow[conTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objTabFieldRelaEN.TransOutFldName = objRow[conTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[conTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objTabFieldRelaEN.PrimaryTypeId = objRow[conTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objTabFieldRelaEN.FieldTypeId = objRow[conTabFieldRela.FieldTypeId] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeId].ToString().Trim(); //字段类型Id
objTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objTabFieldRelaEN.PrimaryKeyTabName = objRow[conTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objTabFieldRelaEN.PrimaryKeyFieldName = objRow[conTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[conTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objTabFieldRelaEN.TransMissingValue = objRow[conTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objTabFieldRelaEN.TransNullValue = objRow[conTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[conTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objTabFieldRelaEN.PrjId = objRow[conTabFieldRela.PrjId].ToString().Trim(); //工程Id
objTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objTabFieldRelaEN.SequenceNumber = objRow[conTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objTabFieldRelaEN.Memo = objRow[conTabFieldRela.Memo] == DBNull.Value ? null : objRow[conTabFieldRela.Memo].ToString().Trim(); //说明
objTabFieldRelaEN.FieldTypeIdS = objRow[conTabFieldRela.FieldTypeIdS] == DBNull.Value ? null : objRow[conTabFieldRela.FieldTypeIdS].ToString().Trim(); //FieldTypeId_S
objTabFieldRelaEN.FldLengthS = objRow[conTabFieldRela.FldLengthS] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.FldLengthS].ToString().Trim()); //FldLength_S
objTabFieldRelaEN.ForeignKeyTabId = objRow[conTabFieldRela.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabFieldRela.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabFieldRelaEN.HashIndex = objRow[conTabFieldRela.HashIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFieldRela.HashIndex].ToString().Trim()); //HASH表序号
objTabFieldRelaEN.IsUseHash = clsEntityBase2.TransNullToBool_S(objRow[conTabFieldRela.IsUseHash].ToString().Trim()); //是否用HASH表
objTabFieldRelaEN.Prefix = objRow[conTabFieldRela.Prefix] == DBNull.Value ? null : objRow[conTabFieldRela.Prefix].ToString().Trim(); //前缀
objTabFieldRelaEN.PrefixFldId = objRow[conTabFieldRela.PrefixFldId] == DBNull.Value ? null : objRow[conTabFieldRela.PrefixFldId].ToString().Trim(); //前缀字段Id
objTabFieldRelaEN.vFieldCnName = objRow[conTabFieldRela.vFieldCnName] == DBNull.Value ? null : objRow[conTabFieldRela.vFieldCnName].ToString().Trim(); //视图字段中文名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFieldRelaEN.IdFieldTabRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFieldRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabFieldRela(ref clsTabFieldRelaEN objTabFieldRelaEN)
{
bool bolResult = TabFieldRelaDA.GetTabFieldRela(ref objTabFieldRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
clsTabFieldRelaEN objTabFieldRelaEN = TabFieldRelaDA.GetObjByIdFieldTabRela(lngIdFieldTabRela);
return objTabFieldRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabFieldRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabFieldRelaEN objTabFieldRelaEN = TabFieldRelaDA.GetFirstObj(strWhereCond);
 return objTabFieldRelaEN;
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
public static clsTabFieldRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabFieldRelaEN objTabFieldRelaEN = TabFieldRelaDA.GetObjByDataRow(objRow);
 return objTabFieldRelaEN;
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
public static clsTabFieldRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabFieldRelaEN objTabFieldRelaEN = TabFieldRelaDA.GetObjByDataRow(objRow);
 return objTabFieldRelaEN;
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
 /// <param name = "lngIdFieldTabRela">所给的关键字</param>
 /// <param name = "lstTabFieldRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFieldRelaEN GetObjByIdFieldTabRelaFromList(long lngIdFieldTabRela, List<clsTabFieldRelaEN> lstTabFieldRelaObjLst)
{
foreach (clsTabFieldRelaEN objTabFieldRelaEN in lstTabFieldRelaObjLst)
{
if (objTabFieldRelaEN.IdFieldTabRela == lngIdFieldTabRela)
{
return objTabFieldRelaEN;
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
 long lngIdFieldTabRela;
 try
 {
 lngIdFieldTabRela = new clsTabFieldRelaDA().GetFirstID(strWhereCond);
 return lngIdFieldTabRela;
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
 arrList = TabFieldRelaDA.GetID(strWhereCond);
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
bool bolIsExist = TabFieldRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdFieldTabRela)
{
//检测记录是否存在
bool bolIsExist = TabFieldRelaDA.IsExist(lngIdFieldTabRela);
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
 bolIsExist = clsTabFieldRelaDA.IsExistTable();
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
 bolIsExist = TabFieldRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabFieldRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段Id = [{0}],表ID = [{1}]的数据已经存在!(in clsTabFieldRelaBL.AddNewRecordBySql2)", objTabFieldRelaEN.FldId,objTabFieldRelaEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabFieldRelaDA.AddNewRecordBySQL2(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabFieldRelaEN objTabFieldRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabFieldRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段Id = [{0}],表ID = [{1}]的数据已经存在!(in clsTabFieldRelaBL.AddNewRecordBySql2WithReturnKey)", objTabFieldRelaEN.FldId,objTabFieldRelaEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = TabFieldRelaDA.AddNewRecordBySQL2WithReturnKey(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabFieldRelaEN objTabFieldRelaEN)
{
try
{
bool bolResult = TabFieldRelaDA.Update(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "objTabFieldRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabFieldRelaEN objTabFieldRelaEN)
{
 if (objTabFieldRelaEN.IdFieldTabRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabFieldRelaDA.UpdateBySql2(objTabFieldRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFieldRelaBL.ReFreshCache();

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdFieldTabRela)
{
try
{
 clsTabFieldRelaEN objTabFieldRelaEN = clsTabFieldRelaBL.GetObjByIdFieldTabRela(lngIdFieldTabRela);

if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(objTabFieldRelaEN.IdFieldTabRela, "SetUpdDate");
}
if (objTabFieldRelaEN != null)
{
int intRecNum = TabFieldRelaDA.DelRecord(lngIdFieldTabRela);
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
/// <param name="lngIdFieldTabRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdFieldTabRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
//删除与表:[TabFieldRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabFieldRela.IdFieldTabRela,
//lngIdFieldTabRela);
//        clsTabFieldRelaBL.DelTabFieldRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFieldRelaBL.DelRecord(lngIdFieldTabRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFieldRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdFieldTabRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdFieldTabRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabFieldRelaBL.relatedActions != null)
{
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(lngIdFieldTabRela, "UpdRelaTabDate");
}
bool bolResult = TabFieldRelaDA.DelRecord(lngIdFieldTabRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdFieldTabRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabFieldRelas(List<string> arrIdFieldTabRelaLst)
{
if (arrIdFieldTabRelaLst.Count == 0) return 0;
try
{
if (clsTabFieldRelaBL.relatedActions != null)
{
foreach (var strIdFieldTabRela in arrIdFieldTabRelaLst)
{
long lngIdFieldTabRela = long.Parse(strIdFieldTabRela);
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(lngIdFieldTabRela, "UpdRelaTabDate");
}
}
int intDelRecNum = TabFieldRelaDA.DelTabFieldRela(arrIdFieldTabRelaLst);
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
public static int DelTabFieldRelasByCond(string strWhereCond)
{
try
{
if (clsTabFieldRelaBL.relatedActions != null)
{
List<string> arrIdFieldTabRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdFieldTabRela in arrIdFieldTabRela)
{
long lngIdFieldTabRela = long.Parse(strIdFieldTabRela);
clsTabFieldRelaBL.relatedActions.UpdRelaTabDate(lngIdFieldTabRela, "UpdRelaTabDate");
}
}
int intRecNum = TabFieldRelaDA.DelTabFieldRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabFieldRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdFieldTabRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdFieldTabRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFieldRelaDA.GetSpecSQLObj();
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
//删除与表:[TabFieldRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFieldRelaBL.DelRecord(lngIdFieldTabRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFieldRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdFieldTabRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabFieldRelaENS">源对象</param>
 /// <param name = "objTabFieldRelaENT">目标对象</param>
 public static void CopyTo(clsTabFieldRelaEN objTabFieldRelaENS, clsTabFieldRelaEN objTabFieldRelaENT)
{
try
{
objTabFieldRelaENT.IdFieldTabRela = objTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objTabFieldRelaENT.FldId = objTabFieldRelaENS.FldId; //字段Id
objTabFieldRelaENT.TabId = objTabFieldRelaENS.TabId; //表ID
objTabFieldRelaENT.SqlFldName = objTabFieldRelaENS.SqlFldName; //Sql字段名称
objTabFieldRelaENT.ExcelFieldName = objTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objTabFieldRelaENT.DefaultValue = objTabFieldRelaENS.DefaultValue; //缺省值
objTabFieldRelaENT.IsNeedTrans = objTabFieldRelaENS.IsNeedTrans; //是否需要转换
objTabFieldRelaENT.TransWayId = objTabFieldRelaENS.TransWayId; //转换方式ID
objTabFieldRelaENT.TransTabName = objTabFieldRelaENS.TransTabName; //转换表名
objTabFieldRelaENT.TransInFldName = objTabFieldRelaENS.TransInFldName; //转换IN字段名
objTabFieldRelaENT.TransOutFldName = objTabFieldRelaENS.TransOutFldName; //转换Out字段名
objTabFieldRelaENT.IsTabPrimary = objTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objTabFieldRelaENT.IsTabForeignKey = objTabFieldRelaENS.IsTabForeignKey; //是否表外键
objTabFieldRelaENT.PrimaryTypeId = objTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objTabFieldRelaENT.IsIdentity = objTabFieldRelaENS.IsIdentity; //是否Identity
objTabFieldRelaENT.IsTabUnique = objTabFieldRelaENS.IsTabUnique; //是否表中唯一
objTabFieldRelaENT.IsTabNullable = objTabFieldRelaENS.IsTabNullable; //是否表中可空
objTabFieldRelaENT.FieldTypeId = objTabFieldRelaENS.FieldTypeId; //字段类型Id
objTabFieldRelaENT.IsNeedCheckPriForeignKey = objTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objTabFieldRelaENT.PrimaryKeyTabName = objTabFieldRelaENS.PrimaryKeyTabName; //主键表
objTabFieldRelaENT.PrimaryKeyFieldName = objTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objTabFieldRelaENT.TransMissingValue = objTabFieldRelaENS.TransMissingValue; //转换失败值
objTabFieldRelaENT.TransNullValue = objTabFieldRelaENS.TransNullValue; //转换空值
objTabFieldRelaENT.PrjId = objTabFieldRelaENS.PrjId; //工程Id
objTabFieldRelaENT.IsVisible = objTabFieldRelaENS.IsVisible; //是否显示
objTabFieldRelaENT.SequenceNumber = objTabFieldRelaENS.SequenceNumber; //顺序号
objTabFieldRelaENT.Memo = objTabFieldRelaENS.Memo; //说明
objTabFieldRelaENT.FieldTypeIdS = objTabFieldRelaENS.FieldTypeIdS; //FieldTypeId_S
objTabFieldRelaENT.FldLengthS = objTabFieldRelaENS.FldLengthS; //FldLength_S
objTabFieldRelaENT.ForeignKeyTabId = objTabFieldRelaENS.ForeignKeyTabId; //外键表ID
objTabFieldRelaENT.HashIndex = objTabFieldRelaENS.HashIndex; //HASH表序号
objTabFieldRelaENT.IsUseHash = objTabFieldRelaENS.IsUseHash; //是否用HASH表
objTabFieldRelaENT.Prefix = objTabFieldRelaENS.Prefix; //前缀
objTabFieldRelaENT.PrefixFldId = objTabFieldRelaENS.PrefixFldId; //前缀字段Id
objTabFieldRelaENT.vFieldCnName = objTabFieldRelaENS.vFieldCnName; //视图字段中文名称
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
 /// <param name = "objTabFieldRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsTabFieldRelaEN objTabFieldRelaEN)
{
try
{
objTabFieldRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabFieldRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabFieldRela.IdFieldTabRela, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IdFieldTabRela = objTabFieldRelaEN.IdFieldTabRela; //字段表关系流水号
}
if (arrFldSet.Contains(conTabFieldRela.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.FldId = objTabFieldRelaEN.FldId; //字段Id
}
if (arrFldSet.Contains(conTabFieldRela.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TabId = objTabFieldRelaEN.TabId; //表ID
}
if (arrFldSet.Contains(conTabFieldRela.SqlFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.SqlFldName = objTabFieldRelaEN.SqlFldName == "[null]" ? null :  objTabFieldRelaEN.SqlFldName; //Sql字段名称
}
if (arrFldSet.Contains(conTabFieldRela.ExcelFieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.ExcelFieldName = objTabFieldRelaEN.ExcelFieldName == "[null]" ? null :  objTabFieldRelaEN.ExcelFieldName; //Excel字段名称
}
if (arrFldSet.Contains(conTabFieldRela.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.DefaultValue = objTabFieldRelaEN.DefaultValue == "[null]" ? null :  objTabFieldRelaEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conTabFieldRela.IsNeedTrans, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsNeedTrans = objTabFieldRelaEN.IsNeedTrans; //是否需要转换
}
if (arrFldSet.Contains(conTabFieldRela.TransWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransWayId = objTabFieldRelaEN.TransWayId; //转换方式ID
}
if (arrFldSet.Contains(conTabFieldRela.TransTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransTabName = objTabFieldRelaEN.TransTabName == "[null]" ? null :  objTabFieldRelaEN.TransTabName; //转换表名
}
if (arrFldSet.Contains(conTabFieldRela.TransInFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransInFldName = objTabFieldRelaEN.TransInFldName == "[null]" ? null :  objTabFieldRelaEN.TransInFldName; //转换IN字段名
}
if (arrFldSet.Contains(conTabFieldRela.TransOutFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransOutFldName = objTabFieldRelaEN.TransOutFldName == "[null]" ? null :  objTabFieldRelaEN.TransOutFldName; //转换Out字段名
}
if (arrFldSet.Contains(conTabFieldRela.IsTabPrimary, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsTabPrimary = objTabFieldRelaEN.IsTabPrimary; //是否作为表中主键
}
if (arrFldSet.Contains(conTabFieldRela.IsTabForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsTabForeignKey = objTabFieldRelaEN.IsTabForeignKey; //是否表外键
}
if (arrFldSet.Contains(conTabFieldRela.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.PrimaryTypeId = objTabFieldRelaEN.PrimaryTypeId == "[null]" ? null :  objTabFieldRelaEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(conTabFieldRela.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsIdentity = objTabFieldRelaEN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(conTabFieldRela.IsTabUnique, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsTabUnique = objTabFieldRelaEN.IsTabUnique; //是否表中唯一
}
if (arrFldSet.Contains(conTabFieldRela.IsTabNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsTabNullable = objTabFieldRelaEN.IsTabNullable; //是否表中可空
}
if (arrFldSet.Contains(conTabFieldRela.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.FieldTypeId = objTabFieldRelaEN.FieldTypeId == "[null]" ? null :  objTabFieldRelaEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conTabFieldRela.IsNeedCheckPriForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsNeedCheckPriForeignKey = objTabFieldRelaEN.IsNeedCheckPriForeignKey; //是否检查主外键
}
if (arrFldSet.Contains(conTabFieldRela.PrimaryKeyTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.PrimaryKeyTabName = objTabFieldRelaEN.PrimaryKeyTabName == "[null]" ? null :  objTabFieldRelaEN.PrimaryKeyTabName; //主键表
}
if (arrFldSet.Contains(conTabFieldRela.PrimaryKeyFieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.PrimaryKeyFieldName = objTabFieldRelaEN.PrimaryKeyFieldName == "[null]" ? null :  objTabFieldRelaEN.PrimaryKeyFieldName; //主键字段名
}
if (arrFldSet.Contains(conTabFieldRela.TransMissingValue, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransMissingValue = objTabFieldRelaEN.TransMissingValue == "[null]" ? null :  objTabFieldRelaEN.TransMissingValue; //转换失败值
}
if (arrFldSet.Contains(conTabFieldRela.TransNullValue, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.TransNullValue = objTabFieldRelaEN.TransNullValue == "[null]" ? null :  objTabFieldRelaEN.TransNullValue; //转换空值
}
if (arrFldSet.Contains(conTabFieldRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.PrjId = objTabFieldRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabFieldRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsVisible = objTabFieldRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conTabFieldRela.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.SequenceNumber = objTabFieldRelaEN.SequenceNumber; //顺序号
}
if (arrFldSet.Contains(conTabFieldRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.Memo = objTabFieldRelaEN.Memo == "[null]" ? null :  objTabFieldRelaEN.Memo; //说明
}
if (arrFldSet.Contains(conTabFieldRela.FieldTypeIdS, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.FieldTypeIdS = objTabFieldRelaEN.FieldTypeIdS == "[null]" ? null :  objTabFieldRelaEN.FieldTypeIdS; //FieldTypeId_S
}
if (arrFldSet.Contains(conTabFieldRela.FldLengthS, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.FldLengthS = objTabFieldRelaEN.FldLengthS; //FldLength_S
}
if (arrFldSet.Contains(conTabFieldRela.ForeignKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.ForeignKeyTabId = objTabFieldRelaEN.ForeignKeyTabId == "[null]" ? null :  objTabFieldRelaEN.ForeignKeyTabId; //外键表ID
}
if (arrFldSet.Contains(conTabFieldRela.HashIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.HashIndex = objTabFieldRelaEN.HashIndex; //HASH表序号
}
if (arrFldSet.Contains(conTabFieldRela.IsUseHash, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.IsUseHash = objTabFieldRelaEN.IsUseHash; //是否用HASH表
}
if (arrFldSet.Contains(conTabFieldRela.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.Prefix = objTabFieldRelaEN.Prefix == "[null]" ? null :  objTabFieldRelaEN.Prefix; //前缀
}
if (arrFldSet.Contains(conTabFieldRela.PrefixFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.PrefixFldId = objTabFieldRelaEN.PrefixFldId == "[null]" ? null :  objTabFieldRelaEN.PrefixFldId; //前缀字段Id
}
if (arrFldSet.Contains(conTabFieldRela.vFieldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFieldRelaEN.vFieldCnName = objTabFieldRelaEN.vFieldCnName == "[null]" ? null :  objTabFieldRelaEN.vFieldCnName; //视图字段中文名称
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
 /// <param name = "objTabFieldRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabFieldRelaEN objTabFieldRelaEN)
{
try
{
if (objTabFieldRelaEN.SqlFldName == "[null]") objTabFieldRelaEN.SqlFldName = null; //Sql字段名称
if (objTabFieldRelaEN.ExcelFieldName == "[null]") objTabFieldRelaEN.ExcelFieldName = null; //Excel字段名称
if (objTabFieldRelaEN.DefaultValue == "[null]") objTabFieldRelaEN.DefaultValue = null; //缺省值
if (objTabFieldRelaEN.TransTabName == "[null]") objTabFieldRelaEN.TransTabName = null; //转换表名
if (objTabFieldRelaEN.TransInFldName == "[null]") objTabFieldRelaEN.TransInFldName = null; //转换IN字段名
if (objTabFieldRelaEN.TransOutFldName == "[null]") objTabFieldRelaEN.TransOutFldName = null; //转换Out字段名
if (objTabFieldRelaEN.PrimaryTypeId == "[null]") objTabFieldRelaEN.PrimaryTypeId = null; //主键类型ID
if (objTabFieldRelaEN.FieldTypeId == "[null]") objTabFieldRelaEN.FieldTypeId = null; //字段类型Id
if (objTabFieldRelaEN.PrimaryKeyTabName == "[null]") objTabFieldRelaEN.PrimaryKeyTabName = null; //主键表
if (objTabFieldRelaEN.PrimaryKeyFieldName == "[null]") objTabFieldRelaEN.PrimaryKeyFieldName = null; //主键字段名
if (objTabFieldRelaEN.TransMissingValue == "[null]") objTabFieldRelaEN.TransMissingValue = null; //转换失败值
if (objTabFieldRelaEN.TransNullValue == "[null]") objTabFieldRelaEN.TransNullValue = null; //转换空值
if (objTabFieldRelaEN.Memo == "[null]") objTabFieldRelaEN.Memo = null; //说明
if (objTabFieldRelaEN.FieldTypeIdS == "[null]") objTabFieldRelaEN.FieldTypeIdS = null; //FieldTypeId_S
if (objTabFieldRelaEN.ForeignKeyTabId == "[null]") objTabFieldRelaEN.ForeignKeyTabId = null; //外键表ID
if (objTabFieldRelaEN.Prefix == "[null]") objTabFieldRelaEN.Prefix = null; //前缀
if (objTabFieldRelaEN.PrefixFldId == "[null]") objTabFieldRelaEN.PrefixFldId = null; //前缀字段Id
if (objTabFieldRelaEN.vFieldCnName == "[null]") objTabFieldRelaEN.vFieldCnName = null; //视图字段中文名称
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
public static void CheckPropertyNew(clsTabFieldRelaEN objTabFieldRelaEN)
{
 TabFieldRelaDA.CheckPropertyNew(objTabFieldRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabFieldRelaEN objTabFieldRelaEN)
{
 TabFieldRelaDA.CheckProperty4Condition(objTabFieldRelaEN);
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
if (clsTabFieldRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFieldRelaBL没有刷新缓存机制(clsTabFieldRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFieldTabRela");
//if (arrTabFieldRelaObjLstCache == null)
//{
//arrTabFieldRelaObjLstCache = TabFieldRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFieldRelaEN GetObjByIdFieldTabRelaCache(long lngIdFieldTabRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrTabFieldRelaObjLst_Sel =
arrTabFieldRelaObjLstCache
.Where(x=> x.IdFieldTabRela == lngIdFieldTabRela 
);
if (arrTabFieldRelaObjLst_Sel.Count() == 0)
{
   clsTabFieldRelaEN obj = clsTabFieldRelaBL.GetObjByIdFieldTabRela(lngIdFieldTabRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTabFieldRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFieldRelaEN> GetAllTabFieldRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = GetObjLstCache(); 
return arrTabFieldRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFieldRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
List<clsTabFieldRelaEN> arrTabFieldRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTabFieldRelaObjLstCache;
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
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabFieldRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabFieldRelaEN._RefreshTimeLst.Count == 0) return "";
return clsTabFieldRelaEN._RefreshTimeLst[clsTabFieldRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsTabFieldRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabFieldRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabFieldRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabFieldRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabFieldRela(表字段关系)
 /// 唯一性条件:FldId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFieldRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabFieldRelaEN objTabFieldRelaEN)
{
//检测记录是否存在
string strResult = TabFieldRelaDA.GetUniCondStr(objTabFieldRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdFieldTabRela)
{
if (strInFldName != conTabFieldRela.IdFieldTabRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabFieldRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabFieldRela._AttributeName));
throw new Exception(strMsg);
}
var objTabFieldRela = clsTabFieldRelaBL.GetObjByIdFieldTabRelaCache(lngIdFieldTabRela);
if (objTabFieldRela == null) return "";
return objTabFieldRela[strOutFldName].ToString();
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
int intRecCount = clsTabFieldRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsTabFieldRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabFieldRelaDA.GetRecCount();
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
int intRecCount = clsTabFieldRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabFieldRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabFieldRelaEN objTabFieldRelaCond)
{
List<clsTabFieldRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabFieldRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFieldRela._AttributeName)
{
if (objTabFieldRelaCond.IsUpdated(strFldName) == false) continue;
if (objTabFieldRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFieldRelaCond[strFldName].ToString());
}
else
{
if (objTabFieldRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFieldRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFieldRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFieldRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFieldRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFieldRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFieldRelaCond[strFldName]));
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
 List<string> arrList = clsTabFieldRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabFieldRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabFieldRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabFieldRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFieldRelaDA.SetFldValue(clsTabFieldRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabFieldRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFieldRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFieldRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFieldRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabFieldRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字段表关系流水号*/ 
 strCreateTabCode.Append(" IdFieldTabRela bigint primary key identity, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**Sql字段名称*/ 
 strCreateTabCode.Append(" SqlFldName varchar(100) Null, "); 
 // /**Excel字段名称*/ 
 strCreateTabCode.Append(" ExcelFieldName varchar(100) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**是否需要转换*/ 
 strCreateTabCode.Append(" IsNeedTrans bit Null, "); 
 // /**转换方式ID*/ 
 strCreateTabCode.Append(" TransWayId char(2) not Null, "); 
 // /**转换表名*/ 
 strCreateTabCode.Append(" TransTabName varchar(50) Null, "); 
 // /**转换IN字段名*/ 
 strCreateTabCode.Append(" TransInFldName varchar(50) Null, "); 
 // /**转换Out字段名*/ 
 strCreateTabCode.Append(" TransOutFldName varchar(50) Null, "); 
 // /**是否作为表中主键*/ 
 strCreateTabCode.Append(" IsTabPrimary bit Null, "); 
 // /**是否表外键*/ 
 strCreateTabCode.Append(" IsTabForeignKey bit Null, "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) Null, "); 
 // /**是否Identity*/ 
 strCreateTabCode.Append(" IsIdentity bit Null, "); 
 // /**是否表中唯一*/ 
 strCreateTabCode.Append(" IsTabUnique bit Null, "); 
 // /**是否表中可空*/ 
 strCreateTabCode.Append(" IsTabNullable bit Null, "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) Null, "); 
 // /**是否检查主外键*/ 
 strCreateTabCode.Append(" IsNeedCheckPriForeignKey bit Null, "); 
 // /**主键表*/ 
 strCreateTabCode.Append(" PrimaryKeyTabName varchar(50) Null, "); 
 // /**主键字段名*/ 
 strCreateTabCode.Append(" PrimaryKeyFieldName varchar(50) Null, "); 
 // /**转换失败值*/ 
 strCreateTabCode.Append(" TransMissingValue varchar(50) Null, "); 
 // /**转换空值*/ 
 strCreateTabCode.Append(" TransNullValue varchar(50) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**顺序号*/ 
 strCreateTabCode.Append(" SequenceNumber int Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**FieldTypeId_S*/ 
 strCreateTabCode.Append(" FieldTypeIdS char(2) Null, "); 
 // /**FldLength_S*/ 
 strCreateTabCode.Append(" FldLengthS int Null, "); 
 // /**外键表ID*/ 
 strCreateTabCode.Append(" ForeignKeyTabId char(8) Null, "); 
 // /**HASH表序号*/ 
 strCreateTabCode.Append(" HashIndex int Null, "); 
 // /**是否用HASH表*/ 
 strCreateTabCode.Append(" IsUseHash bit Null, "); 
 // /**前缀*/ 
 strCreateTabCode.Append(" Prefix varchar(10) Null, "); 
 // /**前缀字段Id*/ 
 strCreateTabCode.Append(" PrefixFldId char(8) Null, "); 
 // /**视图字段中文名称*/ 
 strCreateTabCode.Append(" vFieldCnName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 表字段关系(TabFieldRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabFieldRela : clsCommFun4BL
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
clsTabFieldRelaBL.ReFreshThisCache();
}
}

}