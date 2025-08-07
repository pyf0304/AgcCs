
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeBL
 表名:DataNode(00050547)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsDataNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeEN GetObj(this K_DataNodeId_DataNode myKey)
{
clsDataNodeEN objDataNodeEN = clsDataNodeBL.DataNodeDA.GetObjByDataNodeId(myKey.Value);
return objDataNodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeEN objDataNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecord)", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.AddNewRecordBySQL2(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
public static bool AddRecordEx(this clsDataNodeEN objDataNodeEN, bool bolIsNeedCheckUniqueness = true)
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
objDataNodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDataNodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],字段Id(FldId)=[{1}],关键字段Id列表(KeyFldLst)=[{2}],版本号(VersionNo)=[{3}])已经存在,不能重复!", objDataNodeEN.TabId, objDataNodeEN.FldId, objDataNodeEN.KeyFldLst, objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDataNodeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecord(SqlTransaction))", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.AddNewRecordBySQL2(objDataNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000086)添加记录出错!(带事务处理), {1}.({0})",
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataNodeEN objDataNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecordWithReturnKey)", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
string strKey = clsDataNodeBL.DataNodeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecordWithReturnKey)", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
string strKey = clsDataNodeBL.DataNodeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000092)带返回值的添加记录出错!(带事务处理), {1}.(from {0})",
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
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeId(this clsDataNodeEN objDataNodeEN, long lngDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.DataNodeId = lngDataNodeId; //数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeName(this clsDataNodeEN objDataNodeEN, string strDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeName, conDataNode.DataNodeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, conDataNode.DataNodeName);
}
objDataNodeEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeName) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeName, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeName] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetTabId(this clsDataNodeEN objDataNodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conDataNode.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conDataNode.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDataNode.TabId);
}
objDataNodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.TabId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.TabId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.TabId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetFldId(this clsDataNodeEN objDataNodeEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conDataNode.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conDataNode.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDataNode.FldId);
}
objDataNodeEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.FldId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.FldId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.FldId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetKeyFldLst(this clsDataNodeEN objDataNodeEN, string strKeyFldLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldLst, 100, conDataNode.KeyFldLst);
}
objDataNodeEN.KeyFldLst = strKeyFldLst; //关键字段Id列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.KeyFldLst) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.KeyFldLst, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.KeyFldLst] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetVersionNo(this clsDataNodeEN objDataNodeEN, int intVersionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intVersionNo, conDataNode.VersionNo);
objDataNodeEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.VersionNo) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.VersionNo, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.VersionNo] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeTypeId(this clsDataNodeEN objDataNodeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeTypeId, conDataNode.DataNodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, conDataNode.DataNodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, conDataNode.DataNodeTypeId);
}
objDataNodeEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeTypeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeTypeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeTypeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDepth(this clsDataNodeEN objDataNodeEN, int? intDepth, string strComparisonOp="")
	{
objDataNodeEN.Depth = intDepth; //深度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.Depth) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.Depth, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.Depth] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPrevDataNodeId(this clsDataNodeEN objDataNodeEN, long? lngPrevDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.PrevDataNodeId = lngPrevDataNodeId; //前置数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PrevDataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PrevDataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PrevDataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetNextDataNodeId(this clsDataNodeEN objDataNodeEN, long? lngNextDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.NextDataNodeId = lngNextDataNodeId; //后继数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.NextDataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.NextDataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.NextDataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetSubGraphName(this clsDataNodeEN objDataNodeEN, string strSubGraphName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubGraphName, 50, conDataNode.SubGraphName);
}
objDataNodeEN.SubGraphName = strSubGraphName; //子图名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.SubGraphName) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.SubGraphName, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.SubGraphName] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetErrMsg(this clsDataNodeEN objDataNodeEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDataNode.ErrMsg);
}
objDataNodeEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.ErrMsg) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.ErrMsg, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.ErrMsg] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPrjId(this clsDataNodeEN objDataNodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDataNode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDataNode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDataNode.PrjId);
}
objDataNodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PrjId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PrjId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PrjId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPosX(this clsDataNodeEN objDataNodeEN, double? dblPosX, string strComparisonOp="")
	{
objDataNodeEN.PosX = dblPosX; //位置X
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PosX) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PosX, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PosX] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPosY(this clsDataNodeEN objDataNodeEN, double? dblPosY, string strComparisonOp="")
	{
objDataNodeEN.PosY = dblPosY; //位置Y
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PosY) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PosY, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PosY] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUsedTimes(this clsDataNodeEN objDataNodeEN, int? intUsedTimes, string strComparisonOp="")
	{
objDataNodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UsedTimes) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UsedTimes, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UsedTimes] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUpdDate(this clsDataNodeEN objDataNodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDataNode.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNode.UpdDate);
}
objDataNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UpdDate) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UpdDate, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UpdDate] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUpdUser(this clsDataNodeEN objDataNodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDataNode.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNode.UpdUser);
}
objDataNodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UpdUser) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UpdUser, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UpdUser] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetMemo(this clsDataNodeEN objDataNodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNode.Memo);
}
objDataNodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.Memo) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.Memo, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.Memo] = strComparisonOp;
}
}
return objDataNodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataNodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataNodeEN objDataNodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataNodeEN.CheckPropertyNew();
clsDataNodeEN objDataNodeCond = new clsDataNodeEN();
string strCondition = objDataNodeCond
.SetDataNodeId(objDataNodeEN.DataNodeId, "<>")
.SetTabId(objDataNodeEN.TabId, "=")
.SetFldId(objDataNodeEN.FldId, "=")
.SetKeyFldLst(objDataNodeEN.KeyFldLst, "=")
.SetVersionNo(objDataNodeEN.VersionNo, "=")
.GetCombineCondition();
objDataNodeEN._IsCheckProperty = true;
bool bolIsExist = clsDataNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_FldId_KeyFldLst_VersionNo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataNodeEN.Update();
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
 /// <param name = "objDataNode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDataNodeEN objDataNode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDataNodeEN objDataNodeCond = new clsDataNodeEN();
string strCondition = objDataNodeCond
.SetTabId(objDataNode.TabId, "=")
.SetFldId(objDataNode.FldId, "=")
.SetKeyFldLst(objDataNode.KeyFldLst, "=")
.SetVersionNo(objDataNode.VersionNo, "=")
.GetCombineCondition();
objDataNode._IsCheckProperty = true;
bool bolIsExist = clsDataNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDataNode.DataNodeId = clsDataNodeBL.GetFirstID_S(strCondition);
objDataNode.UpdateWithCondition(strCondition);
}
else
{
objDataNode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeEN objDataNodeEN)
{
 if (objDataNodeEN.DataNodeId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.UpdateBySql2(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateBySql2WithTransaction_S)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataNodeEN.DataNodeId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.UpdateBySql2(objDataNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000035)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataNodeEN.DataNodeId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.UpdateBySql2(objDataNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeEN objDataNodeEN, string strWhereCond)
{
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.UpdateBySqlWithCondition(objDataNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeEN objDataNodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataNodeBL.DataNodeDA.UpdateBySqlWithConditionTransaction(objDataNodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataNodeEN objDataNodeEN)
{
try
{
int intRecNum = clsDataNodeBL.DataNodeDA.DelRecord(objDataNodeEN.DataNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeENS">源对象</param>
 /// <param name = "objDataNodeENT">目标对象</param>
 public static void CopyTo(this clsDataNodeEN objDataNodeENS, clsDataNodeEN objDataNodeENT)
{
try
{
objDataNodeENT.DataNodeId = objDataNodeENS.DataNodeId; //数据结点Id
objDataNodeENT.DataNodeName = objDataNodeENS.DataNodeName; //数据结点名
objDataNodeENT.TabId = objDataNodeENS.TabId; //表ID
objDataNodeENT.FldId = objDataNodeENS.FldId; //字段Id
objDataNodeENT.KeyFldLst = objDataNodeENS.KeyFldLst; //关键字段Id列表
objDataNodeENT.VersionNo = objDataNodeENS.VersionNo; //版本号
objDataNodeENT.DataNodeTypeId = objDataNodeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeENT.Depth = objDataNodeENS.Depth; //深度
objDataNodeENT.PrevDataNodeId = objDataNodeENS.PrevDataNodeId; //前置数据结点Id
objDataNodeENT.NextDataNodeId = objDataNodeENS.NextDataNodeId; //后继数据结点Id
objDataNodeENT.SubGraphName = objDataNodeENS.SubGraphName; //子图名
objDataNodeENT.ErrMsg = objDataNodeENS.ErrMsg; //错误信息
objDataNodeENT.PrjId = objDataNodeENS.PrjId; //工程Id
objDataNodeENT.PosX = objDataNodeENS.PosX; //位置X
objDataNodeENT.PosY = objDataNodeENS.PosY; //位置Y
objDataNodeENT.UsedTimes = objDataNodeENS.UsedTimes; //使用次数
objDataNodeENT.UpdDate = objDataNodeENS.UpdDate; //修改日期
objDataNodeENT.UpdUser = objDataNodeENS.UpdUser; //修改者
objDataNodeENT.Memo = objDataNodeENS.Memo; //说明
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
 /// <param name = "objDataNodeENS">源对象</param>
 /// <returns>目标对象=>clsDataNodeEN:objDataNodeENT</returns>
 public static clsDataNodeEN CopyTo(this clsDataNodeEN objDataNodeENS)
{
try
{
 clsDataNodeEN objDataNodeENT = new clsDataNodeEN()
{
DataNodeId = objDataNodeENS.DataNodeId, //数据结点Id
DataNodeName = objDataNodeENS.DataNodeName, //数据结点名
TabId = objDataNodeENS.TabId, //表ID
FldId = objDataNodeENS.FldId, //字段Id
KeyFldLst = objDataNodeENS.KeyFldLst, //关键字段Id列表
VersionNo = objDataNodeENS.VersionNo, //版本号
DataNodeTypeId = objDataNodeENS.DataNodeTypeId, //数据结点类型Id
Depth = objDataNodeENS.Depth, //深度
PrevDataNodeId = objDataNodeENS.PrevDataNodeId, //前置数据结点Id
NextDataNodeId = objDataNodeENS.NextDataNodeId, //后继数据结点Id
SubGraphName = objDataNodeENS.SubGraphName, //子图名
ErrMsg = objDataNodeENS.ErrMsg, //错误信息
PrjId = objDataNodeENS.PrjId, //工程Id
PosX = objDataNodeENS.PosX, //位置X
PosY = objDataNodeENS.PosY, //位置Y
UsedTimes = objDataNodeENS.UsedTimes, //使用次数
UpdDate = objDataNodeENS.UpdDate, //修改日期
UpdUser = objDataNodeENS.UpdUser, //修改者
Memo = objDataNodeENS.Memo, //说明
};
 return objDataNodeENT;
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
public static void CheckPropertyNew(this clsDataNodeEN objDataNodeEN)
{
 clsDataNodeBL.DataNodeDA.CheckPropertyNew(objDataNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataNodeEN objDataNodeEN)
{
 clsDataNodeBL.DataNodeDA.CheckProperty4Condition(objDataNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeEN objDataNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeId) == true)
{
string strComparisonOpDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.DataNodeId, objDataNodeCond.DataNodeId, strComparisonOpDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.DataNodeName, objDataNodeCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objDataNodeCond.IsUpdated(conDataNode.TabId) == true)
{
string strComparisonOpTabId = objDataNodeCond.dicFldComparisonOp[conDataNode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.TabId, objDataNodeCond.TabId, strComparisonOpTabId);
}
if (objDataNodeCond.IsUpdated(conDataNode.FldId) == true)
{
string strComparisonOpFldId = objDataNodeCond.dicFldComparisonOp[conDataNode.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.FldId, objDataNodeCond.FldId, strComparisonOpFldId);
}
if (objDataNodeCond.IsUpdated(conDataNode.KeyFldLst) == true)
{
string strComparisonOpKeyFldLst = objDataNodeCond.dicFldComparisonOp[conDataNode.KeyFldLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.KeyFldLst, objDataNodeCond.KeyFldLst, strComparisonOpKeyFldLst);
}
if (objDataNodeCond.IsUpdated(conDataNode.VersionNo) == true)
{
string strComparisonOpVersionNo = objDataNodeCond.dicFldComparisonOp[conDataNode.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.VersionNo, objDataNodeCond.VersionNo, strComparisonOpVersionNo);
}
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.DataNodeTypeId, objDataNodeCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.Depth) == true)
{
string strComparisonOpDepth = objDataNodeCond.dicFldComparisonOp[conDataNode.Depth];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.Depth, objDataNodeCond.Depth, strComparisonOpDepth);
}
if (objDataNodeCond.IsUpdated(conDataNode.PrevDataNodeId) == true)
{
string strComparisonOpPrevDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.PrevDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PrevDataNodeId, objDataNodeCond.PrevDataNodeId, strComparisonOpPrevDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.NextDataNodeId) == true)
{
string strComparisonOpNextDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.NextDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.NextDataNodeId, objDataNodeCond.NextDataNodeId, strComparisonOpNextDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.SubGraphName) == true)
{
string strComparisonOpSubGraphName = objDataNodeCond.dicFldComparisonOp[conDataNode.SubGraphName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.SubGraphName, objDataNodeCond.SubGraphName, strComparisonOpSubGraphName);
}
if (objDataNodeCond.IsUpdated(conDataNode.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDataNodeCond.dicFldComparisonOp[conDataNode.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.ErrMsg, objDataNodeCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDataNodeCond.IsUpdated(conDataNode.PrjId) == true)
{
string strComparisonOpPrjId = objDataNodeCond.dicFldComparisonOp[conDataNode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.PrjId, objDataNodeCond.PrjId, strComparisonOpPrjId);
}
if (objDataNodeCond.IsUpdated(conDataNode.PosX) == true)
{
string strComparisonOpPosX = objDataNodeCond.dicFldComparisonOp[conDataNode.PosX];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PosX, objDataNodeCond.PosX, strComparisonOpPosX);
}
if (objDataNodeCond.IsUpdated(conDataNode.PosY) == true)
{
string strComparisonOpPosY = objDataNodeCond.dicFldComparisonOp[conDataNode.PosY];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PosY, objDataNodeCond.PosY, strComparisonOpPosY);
}
if (objDataNodeCond.IsUpdated(conDataNode.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objDataNodeCond.dicFldComparisonOp[conDataNode.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.UsedTimes, objDataNodeCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objDataNodeCond.IsUpdated(conDataNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataNodeCond.dicFldComparisonOp[conDataNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.UpdDate, objDataNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataNodeCond.IsUpdated(conDataNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataNodeCond.dicFldComparisonOp[conDataNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.UpdUser, objDataNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataNodeCond.IsUpdated(conDataNode.Memo) == true)
{
string strComparisonOpMemo = objDataNodeCond.dicFldComparisonOp[conDataNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.Memo, objDataNodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DataNode(数据结点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_FldId_KeyFldLst_VersionNo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDataNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDataNodeEN objDataNodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeEN == null) return true;
if (objDataNodeEN.DataNodeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 if (objDataNodeEN.KeyFldLst == null)
{
 sbCondition.AppendFormat(" and KeyFldLst is null", objDataNodeEN.KeyFldLst);
}
else
{
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
}
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
if (clsDataNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DataNodeId !=  {0}", objDataNodeEN.DataNodeId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
if (clsDataNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DataNode(数据结点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId_KeyFldLst_VersionNo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDataNodeEN objDataNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeEN == null) return "";
if (objDataNodeEN.DataNodeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 if (objDataNodeEN.KeyFldLst == null)
{
 sbCondition.AppendFormat(" and KeyFldLst is null", objDataNodeEN.KeyFldLst);
}
else
{
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
}
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DataNodeId !=  {0}", objDataNodeEN.DataNodeId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataNode
{
public virtual bool UpdRelaTabDate(long lngDataNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据结点(DataNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeBL
{
public static RelatedActions_DataNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataNodeDA DataNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataNodeDA();
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
 public clsDataNodeBL()
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
if (string.IsNullOrEmpty(clsDataNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeEN._ConnectString);
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
public static DataTable GetDataTable_DataNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataNodeDA.GetDataTable_DataNode(strWhereCond);
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
objDT = DataNodeDA.GetDataTable(strWhereCond);
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
objDT = DataNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataNodeDA.GetDataTable_Top(objTopPara);
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
objDT = DataNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDataNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataNodeEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeIdLst)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataNodeIdLst);
 string strWhereCond = string.Format("DataNodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataNodeEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel =
arrDataNodeObjLstCache
.Where(x => arrDataNodeIdLst.Contains(x.DataNodeId));
return arrDataNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeEN> GetObjLst(string strWhereCond)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
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
public static List<clsDataNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataNodeEN> GetSubObjLstCache(clsDataNodeEN objDataNodeCond)
{
 string strPrjId = objDataNodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDataNodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDataNodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNode._AttributeName)
{
if (objDataNodeCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeCond[strFldName].ToString());
}
else
{
if (objDataNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeCond[strFldName]));
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
public static List<clsDataNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
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
public static List<clsDataNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
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
List<clsDataNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
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
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
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
public static List<clsDataNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
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
public static List<clsDataNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataNode(ref clsDataNodeEN objDataNodeEN)
{
bool bolResult = DataNodeDA.GetDataNode(ref objDataNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
clsDataNodeEN objDataNodeEN = DataNodeDA.GetObjByDataNodeId(lngDataNodeId);
return objDataNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataNodeEN objDataNodeEN = DataNodeDA.GetFirstObj(strWhereCond);
 return objDataNodeEN;
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
public static clsDataNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataNodeEN objDataNodeEN = DataNodeDA.GetObjByDataRow(objRow);
 return objDataNodeEN;
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
public static clsDataNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataNodeEN objDataNodeEN = DataNodeDA.GetObjByDataRow(objRow);
 return objDataNodeEN;
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
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <param name = "lstDataNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeEN GetObjByDataNodeIdFromList(long lngDataNodeId, List<clsDataNodeEN> lstDataNodeObjLst)
{
foreach (clsDataNodeEN objDataNodeEN in lstDataNodeObjLst)
{
if (objDataNodeEN.DataNodeId == lngDataNodeId)
{
return objDataNodeEN;
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
 long lngDataNodeId;
 try
 {
 lngDataNodeId = new clsDataNodeDA().GetFirstID(strWhereCond);
 return lngDataNodeId;
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
 arrList = DataNodeDA.GetID(strWhereCond);
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
bool bolIsExist = DataNodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngDataNodeId)
{
//检测记录是否存在
bool bolIsExist = DataNodeDA.IsExist(lngDataNodeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngDataNodeId">数据结点Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngDataNodeId, string strOpUser)
{
clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(lngDataNodeId);
objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDataNodeEN.UpdUser = strOpUser;
return clsDataNodeBL.UpdateBySql2(objDataNodeEN);
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
 bolIsExist = clsDataNodeDA.IsExistTable();
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
 bolIsExist = DataNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataNodeEN objDataNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecordBySql2)", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
bool bolResult = DataNodeDA.AddNewRecordBySQL2(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataNodeEN objDataNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}],关键字段Id列表 = [{2}],版本号 = [{3}]的数据已经存在!(in clsDataNodeBL.AddNewRecordBySql2WithReturnKey)", objDataNodeEN.TabId,objDataNodeEN.FldId,objDataNodeEN.KeyFldLst,objDataNodeEN.VersionNo);
throw new Exception(strMsg);
}
try
{
string strKey = DataNodeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataNodeEN objDataNodeEN)
{
try
{
bool bolResult = DataNodeDA.Update(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataNodeEN objDataNodeEN)
{
 if (objDataNodeEN.DataNodeId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataNodeDA.UpdateBySql2(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeBL.ReFreshCache(objDataNodeEN.PrjId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
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
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngDataNodeId)
{
try
{
 clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(lngDataNodeId);

if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(objDataNodeEN.DataNodeId, objDataNodeEN.UpdUser);
}
if (objDataNodeEN != null)
{
int intRecNum = DataNodeDA.DelRecord(lngDataNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDataNodeEN.PrjId);
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
/// <param name="lngDataNodeId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngDataNodeId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataNodeDA.GetSpecSQLObj();
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
//删除与表:[DataNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataNode.DataNodeId,
//lngDataNodeId);
//        clsDataNodeBL.DelDataNodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeBL.DelRecord(lngDataNodeId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngDataNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngDataNodeId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataNodeBL.relatedActions != null)
{
clsDataNodeBL.relatedActions.UpdRelaTabDate(lngDataNodeId, "UpdRelaTabDate");
}
bool bolResult = DataNodeDA.DelRecord(lngDataNodeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDataNodeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataNodes(List<string> arrDataNodeIdLst)
{
if (arrDataNodeIdLst.Count == 0) return 0;
try
{
if (clsDataNodeBL.relatedActions != null)
{
foreach (var strDataNodeId in arrDataNodeIdLst)
{
long lngDataNodeId = long.Parse(strDataNodeId);
clsDataNodeBL.relatedActions.UpdRelaTabDate(lngDataNodeId, "UpdRelaTabDate");
}
}
 clsDataNodeEN objDataNodeEN = clsDataNodeBL.GetObjByDataNodeId(long.Parse(arrDataNodeIdLst[0]));
int intDelRecNum = DataNodeDA.DelDataNode(arrDataNodeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDataNodeEN.PrjId);
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
public static int DelDataNodesByCond(string strWhereCond)
{
try
{
if (clsDataNodeBL.relatedActions != null)
{
List<string> arrDataNodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataNodeId in arrDataNodeId)
{
long lngDataNodeId = long.Parse(strDataNodeId);
clsDataNodeBL.relatedActions.UpdRelaTabDate(lngDataNodeId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDataNode.PrjId, strWhereCond);
int intRecNum = DataNodeDA.DelDataNode(strWhereCond);
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
 /// 功能:删除满足条件的多条记录.(带事务处理)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCondWithTransaction)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public static bool DelDataNodesByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataNodeBL.relatedActions != null)
{
List<string> arrDataNodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataNodeId in arrDataNodeId)
{
long lngDataNodeId = long.Parse(strDataNodeId);
clsDataNodeBL.relatedActions.UpdRelaTabDate(lngDataNodeId, "UpdRelaTabDate");
}
}
bool bolResult = DataNodeDA.DelDataNodeWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000044)删除带条件表记录出错!(同时处理事务)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataNode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngDataNodeId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngDataNodeId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataNodeDA.GetSpecSQLObj();
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
//删除与表:[DataNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeBL.DelRecord(lngDataNodeId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngDataNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataNodeENS">源对象</param>
 /// <param name = "objDataNodeENT">目标对象</param>
 public static void CopyTo(clsDataNodeEN objDataNodeENS, clsDataNodeEN objDataNodeENT)
{
try
{
objDataNodeENT.DataNodeId = objDataNodeENS.DataNodeId; //数据结点Id
objDataNodeENT.DataNodeName = objDataNodeENS.DataNodeName; //数据结点名
objDataNodeENT.TabId = objDataNodeENS.TabId; //表ID
objDataNodeENT.FldId = objDataNodeENS.FldId; //字段Id
objDataNodeENT.KeyFldLst = objDataNodeENS.KeyFldLst; //关键字段Id列表
objDataNodeENT.VersionNo = objDataNodeENS.VersionNo; //版本号
objDataNodeENT.DataNodeTypeId = objDataNodeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeENT.Depth = objDataNodeENS.Depth; //深度
objDataNodeENT.PrevDataNodeId = objDataNodeENS.PrevDataNodeId; //前置数据结点Id
objDataNodeENT.NextDataNodeId = objDataNodeENS.NextDataNodeId; //后继数据结点Id
objDataNodeENT.SubGraphName = objDataNodeENS.SubGraphName; //子图名
objDataNodeENT.ErrMsg = objDataNodeENS.ErrMsg; //错误信息
objDataNodeENT.PrjId = objDataNodeENS.PrjId; //工程Id
objDataNodeENT.PosX = objDataNodeENS.PosX; //位置X
objDataNodeENT.PosY = objDataNodeENS.PosY; //位置Y
objDataNodeENT.UsedTimes = objDataNodeENS.UsedTimes; //使用次数
objDataNodeENT.UpdDate = objDataNodeENS.UpdDate; //修改日期
objDataNodeENT.UpdUser = objDataNodeENS.UpdUser; //修改者
objDataNodeENT.Memo = objDataNodeENS.Memo; //说明
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
 /// <param name = "objDataNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsDataNodeEN objDataNodeEN)
{
try
{
objDataNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataNode.DataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.DataNodeId = objDataNodeEN.DataNodeId; //数据结点Id
}
if (arrFldSet.Contains(conDataNode.DataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.DataNodeName = objDataNodeEN.DataNodeName; //数据结点名
}
if (arrFldSet.Contains(conDataNode.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.TabId = objDataNodeEN.TabId; //表ID
}
if (arrFldSet.Contains(conDataNode.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.FldId = objDataNodeEN.FldId; //字段Id
}
if (arrFldSet.Contains(conDataNode.KeyFldLst, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.KeyFldLst = objDataNodeEN.KeyFldLst == "[null]" ? null :  objDataNodeEN.KeyFldLst; //关键字段Id列表
}
if (arrFldSet.Contains(conDataNode.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.VersionNo = objDataNodeEN.VersionNo; //版本号
}
if (arrFldSet.Contains(conDataNode.DataNodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.DataNodeTypeId = objDataNodeEN.DataNodeTypeId; //数据结点类型Id
}
if (arrFldSet.Contains(conDataNode.Depth, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.Depth = objDataNodeEN.Depth; //深度
}
if (arrFldSet.Contains(conDataNode.PrevDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.PrevDataNodeId = objDataNodeEN.PrevDataNodeId; //前置数据结点Id
}
if (arrFldSet.Contains(conDataNode.NextDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.NextDataNodeId = objDataNodeEN.NextDataNodeId; //后继数据结点Id
}
if (arrFldSet.Contains(conDataNode.SubGraphName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.SubGraphName = objDataNodeEN.SubGraphName == "[null]" ? null :  objDataNodeEN.SubGraphName; //子图名
}
if (arrFldSet.Contains(conDataNode.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.ErrMsg = objDataNodeEN.ErrMsg == "[null]" ? null :  objDataNodeEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conDataNode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.PrjId = objDataNodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDataNode.PosX, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.PosX = objDataNodeEN.PosX; //位置X
}
if (arrFldSet.Contains(conDataNode.PosY, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.PosY = objDataNodeEN.PosY; //位置Y
}
if (arrFldSet.Contains(conDataNode.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.UsedTimes = objDataNodeEN.UsedTimes; //使用次数
}
if (arrFldSet.Contains(conDataNode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.UpdDate = objDataNodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDataNode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.UpdUser = objDataNodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDataNode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeEN.Memo = objDataNodeEN.Memo == "[null]" ? null :  objDataNodeEN.Memo; //说明
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
 /// <param name = "objDataNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataNodeEN objDataNodeEN)
{
try
{
if (objDataNodeEN.KeyFldLst == "[null]") objDataNodeEN.KeyFldLst = null; //关键字段Id列表
if (objDataNodeEN.SubGraphName == "[null]") objDataNodeEN.SubGraphName = null; //子图名
if (objDataNodeEN.ErrMsg == "[null]") objDataNodeEN.ErrMsg = null; //错误信息
if (objDataNodeEN.Memo == "[null]") objDataNodeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDataNodeEN objDataNodeEN)
{
 DataNodeDA.CheckPropertyNew(objDataNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataNodeEN objDataNodeEN)
{
 DataNodeDA.CheckProperty4Condition(objDataNodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_DataNodeId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId); 
List<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataNodeEN objDataNodeEN = new clsDataNodeEN()
{
DataNodeId = 0,
DataNodeName = "选[数据结点]..."
};
arrObjLstSel.Insert(0, objDataNodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataNode.DataNodeId;
objComboBox.DisplayMember = conDataNode.DataNodeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_DataNodeId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId); 
IEnumerable<clsDataNodeEN> arrObjLst = clsDataNodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conDataNode.DataNodeId;
objDDL.DataTextField = conDataNode.DataNodeName;
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
public static void BindDdl_DataNodeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...","0");
List<clsDataNodeEN> arrDataNodeObjLst = GetAllDataNodeObjLstCache(strPrjId); 
objDDL.DataValueField = conDataNode.DataNodeId;
objDDL.DataTextField = conDataNode.DataNodeName;
objDDL.DataSource = arrDataNodeObjLst;
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
if (clsDataNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeBL没有刷新缓存机制(clsDataNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataNodeId");
//if (arrDataNodeObjLstCache == null)
//{
//arrDataNodeObjLstCache = DataNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeEN GetObjByDataNodeIdCache(long lngDataNodeId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel =
arrDataNodeObjLstCache
.Where(x=> x.DataNodeId == lngDataNodeId 
);
if (arrDataNodeObjLst_Sel.Count() == 0)
{
   clsDataNodeEN obj = clsDataNodeBL.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngDataNodeId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrDataNodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId, string strPrjId)
{
//获取缓存中的对象列表
clsDataNodeEN objDataNode = GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objDataNode == null) return "";
return objDataNode.DataNodeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId, string strPrjId)
{
//获取缓存中的对象列表
clsDataNodeEN objDataNode = GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objDataNode == null) return "";
return objDataNode.DataNodeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeEN> GetAllDataNodeObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId); 
return arrDataNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDataNodeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDataNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDataNodeEN._RefreshTimeLst.Count == 0) return "";
return clsDataNodeEN._RefreshTimeLst[clsDataNodeEN._RefreshTimeLst.Count - 1];
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
if (clsDataNodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDataNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDataNodeBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DataNode(数据结点)
 /// 唯一性条件:TabId_FldId_KeyFldLst_VersionNo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDataNodeEN objDataNodeEN)
{
//检测记录是否存在
string strResult = DataNodeDA.GetUniCondStr(objDataNodeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngDataNodeId, string strPrjId)
{
if (strInFldName != conDataNode.DataNodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataNode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataNode._AttributeName));
throw new Exception(strMsg);
}
var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objDataNode == null) return "";
return objDataNode[strOutFldName].ToString();
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
int intRecCount = clsDataNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsDataNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataNodeDA.GetRecCount();
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
int intRecCount = clsDataNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataNodeEN objDataNodeCond)
{
 string strPrjId = objDataNodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDataNodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDataNodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNode._AttributeName)
{
if (objDataNodeCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeCond[strFldName].ToString());
}
else
{
if (objDataNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeCond[strFldName]));
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
 List<string> arrList = clsDataNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataNodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeDA.SetFldValue(clsDataNodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataNodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataNode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**数据结点Id*/ 
 strCreateTabCode.Append(" DataNodeId bigint primary key identity, "); 
 // /**数据结点名*/ 
 strCreateTabCode.Append(" DataNodeName varchar(100) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**关键字段Id列表*/ 
 strCreateTabCode.Append(" KeyFldLst varchar(100) Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" VersionNo int not Null, "); 
 // /**数据结点类型Id*/ 
 strCreateTabCode.Append(" DataNodeTypeId char(2) not Null, "); 
 // /**深度*/ 
 strCreateTabCode.Append(" Depth int Null, "); 
 // /**前置数据结点Id*/ 
 strCreateTabCode.Append(" PrevDataNodeId bigint Null, "); 
 // /**后继数据结点Id*/ 
 strCreateTabCode.Append(" NextDataNodeId bigint Null, "); 
 // /**子图名*/ 
 strCreateTabCode.Append(" SubGraphName varchar(50) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**位置X*/ 
 strCreateTabCode.Append(" PosX decimal(7,2) Null, "); 
 // /**位置Y*/ 
 strCreateTabCode.Append(" PosY decimal(7,2) Null, "); 
 // /**使用次数*/ 
 strCreateTabCode.Append(" UsedTimes int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**数据结点类型名*/ 
 strCreateTabCode.Append(" DataNodeTypeName varchar(50) Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**入度*/ 
 strCreateTabCode.Append(" InDegree int Null, "); 
 // /**出度*/ 
 strCreateTabCode.Append(" OutDegree int Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据结点(DataNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataNode : clsCommFun4BLV2
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
clsDataNodeBL.ReFreshThisCache(strPrjId);
}
}

}