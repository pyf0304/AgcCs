
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapBL
 表名:DnFuncMap(00050549)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsDnFuncMapBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnFuncMapEN GetObj(this K_DnFuncMapId_DnFuncMap myKey)
{
clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.DnFuncMapDA.GetObjByDnFuncMapId(myKey.Value);
return objDnFuncMapEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnFuncMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecord)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.AddNewRecordBySQL2(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
public static bool AddRecordEx(this clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDnFuncMapEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDnFuncMapEN.CheckUniqueness() == false)
{
strMsg = string.Format("(In数据结点Id(InDataNodeId)=[{0}],Out数据结点Id(OutDataNodeId)=[{1}])已经存在,不能重复!", objDnFuncMapEN.InDataNodeId, objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDnFuncMapEN.AddNewRecord();
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnFuncMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecordWithMaxId)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
string strDnFuncMapId = clsDnFuncMapBL.DnFuncMapDA.AddNewRecordBySQL2WithReturnKey(objDnFuncMapEN);
     objDnFuncMapEN.DnFuncMapId = strDnFuncMapId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
}
return strDnFuncMapId;
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
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnFuncMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecord(SqlTransaction))", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.AddNewRecordBySQL2(objDnFuncMapEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnFuncMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecordWithReturnKey)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
string strKey = clsDnFuncMapBL.DnFuncMapDA.AddNewRecordBySQL2WithReturnKey(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnFuncMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecordWithReturnKey)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsDnFuncMapBL.DnFuncMapDA.AddNewRecordBySQL2WithReturnKey(objDnFuncMapEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetDnFuncMapId(this clsDnFuncMapEN objDnFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
}
objDnFuncMapEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.DnFuncMapId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.DnFuncMapId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.DnFuncMapId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetInDataNodeId(this clsDnFuncMapEN objDnFuncMapEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, conDnFuncMap.InDataNodeId);
objDnFuncMapEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.InDataNodeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.InDataNodeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.InDataNodeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetOutDataNodeId(this clsDnFuncMapEN objDnFuncMapEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, conDnFuncMap.OutDataNodeId);
objDnFuncMapEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.OutDataNodeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.OutDataNodeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.OutDataNodeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetAssociationMappingId(this clsDnFuncMapEN objDnFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDnFuncMap.AssociationMappingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
}
objDnFuncMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.AssociationMappingId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.AssociationMappingId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.AssociationMappingId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetFuncMapModeId(this clsDnFuncMapEN objDnFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncMapModeId, conDnFuncMap.FuncMapModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
}
objDnFuncMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.FuncMapModeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.FuncMapModeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.FuncMapModeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetTabId(this clsDnFuncMapEN objDnFuncMapEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conDnFuncMap.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDnFuncMap.TabId);
}
objDnFuncMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.TabId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.TabId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.TabId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetDnFunctionId(this clsDnFuncMapEN objDnFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, conDnFuncMap.DnFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, conDnFuncMap.DnFunctionId);
}
objDnFuncMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.DnFunctionId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.DnFunctionId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.DnFunctionId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetErrMsg(this clsDnFuncMapEN objDnFuncMapEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDnFuncMap.ErrMsg);
}
objDnFuncMapEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.ErrMsg) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.ErrMsg, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.ErrMsg] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetPrjId(this clsDnFuncMapEN objDnFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnFuncMap.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnFuncMap.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnFuncMap.PrjId);
}
objDnFuncMapEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.PrjId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.PrjId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.PrjId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUsedTimes(this clsDnFuncMapEN objDnFuncMapEN, int? intUsedTimes, string strComparisonOp="")
	{
objDnFuncMapEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UsedTimes) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UsedTimes, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UsedTimes] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUpdDate(this clsDnFuncMapEN objDnFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnFuncMap.UpdDate);
}
objDnFuncMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UpdDate) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UpdDate, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UpdDate] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUpdUser(this clsDnFuncMapEN objDnFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnFuncMap.UpdUser);
}
objDnFuncMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UpdUser) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UpdUser, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UpdUser] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetMemo(this clsDnFuncMapEN objDnFuncMapEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnFuncMap.Memo);
}
objDnFuncMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.Memo) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.Memo, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.Memo] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDnFuncMapEN objDnFuncMapEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDnFuncMapEN.CheckPropertyNew();
clsDnFuncMapEN objDnFuncMapCond = new clsDnFuncMapEN();
string strCondition = objDnFuncMapCond
.SetDnFuncMapId(objDnFuncMapEN.DnFuncMapId, "<>")
.SetInDataNodeId(objDnFuncMapEN.InDataNodeId, "=")
.SetOutDataNodeId(objDnFuncMapEN.OutDataNodeId, "=")
.GetCombineCondition();
objDnFuncMapEN._IsCheckProperty = true;
bool bolIsExist = clsDnFuncMapBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(InDataNodeId_OutDataNodeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDnFuncMapEN.Update();
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
 /// <param name = "objDnFuncMap">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDnFuncMapEN objDnFuncMap)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDnFuncMapEN objDnFuncMapCond = new clsDnFuncMapEN();
string strCondition = objDnFuncMapCond
.SetInDataNodeId(objDnFuncMap.InDataNodeId, "=")
.SetOutDataNodeId(objDnFuncMap.OutDataNodeId, "=")
.GetCombineCondition();
objDnFuncMap._IsCheckProperty = true;
bool bolIsExist = clsDnFuncMapBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDnFuncMap.DnFuncMapId = clsDnFuncMapBL.GetFirstID_S(strCondition);
objDnFuncMap.UpdateWithCondition(strCondition);
}
else
{
objDnFuncMap.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
objDnFuncMap.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnFuncMapEN objDnFuncMapEN)
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.UpdateBySql2(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.UpdateBySql2(objDnFuncMapEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnFuncMapEN objDnFuncMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.UpdateBySql2(objDnFuncMapEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnFuncMapEN objDnFuncMapEN, string strWhereCond)
{
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.UpdateBySqlWithCondition(objDnFuncMapEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnFuncMapEN objDnFuncMapEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDnFuncMapBL.DnFuncMapDA.UpdateBySqlWithConditionTransaction(objDnFuncMapEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDnFuncMapEN objDnFuncMapEN)
{
try
{
int intRecNum = clsDnFuncMapBL.DnFuncMapDA.DelRecord(objDnFuncMapEN.DnFuncMapId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapENS">源对象</param>
 /// <param name = "objDnFuncMapENT">目标对象</param>
 public static void CopyTo(this clsDnFuncMapEN objDnFuncMapENS, clsDnFuncMapEN objDnFuncMapENT)
{
try
{
objDnFuncMapENT.DnFuncMapId = objDnFuncMapENS.DnFuncMapId; //函数映射Id
objDnFuncMapENT.InDataNodeId = objDnFuncMapENS.InDataNodeId; //In数据结点Id
objDnFuncMapENT.OutDataNodeId = objDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objDnFuncMapENT.AssociationMappingId = objDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objDnFuncMapENT.FuncMapModeId = objDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objDnFuncMapENT.TabId = objDnFuncMapENS.TabId; //表ID
objDnFuncMapENT.DnFunctionId = objDnFuncMapENS.DnFunctionId; //DN函数Id
objDnFuncMapENT.ErrMsg = objDnFuncMapENS.ErrMsg; //错误信息
objDnFuncMapENT.PrjId = objDnFuncMapENS.PrjId; //工程Id
objDnFuncMapENT.UsedTimes = objDnFuncMapENS.UsedTimes; //使用次数
objDnFuncMapENT.UpdDate = objDnFuncMapENS.UpdDate; //修改日期
objDnFuncMapENT.UpdUser = objDnFuncMapENS.UpdUser; //修改者
objDnFuncMapENT.Memo = objDnFuncMapENS.Memo; //说明
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
 /// <param name = "objDnFuncMapENS">源对象</param>
 /// <returns>目标对象=>clsDnFuncMapEN:objDnFuncMapENT</returns>
 public static clsDnFuncMapEN CopyTo(this clsDnFuncMapEN objDnFuncMapENS)
{
try
{
 clsDnFuncMapEN objDnFuncMapENT = new clsDnFuncMapEN()
{
DnFuncMapId = objDnFuncMapENS.DnFuncMapId, //函数映射Id
InDataNodeId = objDnFuncMapENS.InDataNodeId, //In数据结点Id
OutDataNodeId = objDnFuncMapENS.OutDataNodeId, //Out数据结点Id
AssociationMappingId = objDnFuncMapENS.AssociationMappingId, //关联关系映射Id
FuncMapModeId = objDnFuncMapENS.FuncMapModeId, //函数映射模式Id
TabId = objDnFuncMapENS.TabId, //表ID
DnFunctionId = objDnFuncMapENS.DnFunctionId, //DN函数Id
ErrMsg = objDnFuncMapENS.ErrMsg, //错误信息
PrjId = objDnFuncMapENS.PrjId, //工程Id
UsedTimes = objDnFuncMapENS.UsedTimes, //使用次数
UpdDate = objDnFuncMapENS.UpdDate, //修改日期
UpdUser = objDnFuncMapENS.UpdUser, //修改者
Memo = objDnFuncMapENS.Memo, //说明
};
 return objDnFuncMapENT;
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
public static void CheckPropertyNew(this clsDnFuncMapEN objDnFuncMapEN)
{
 clsDnFuncMapBL.DnFuncMapDA.CheckPropertyNew(objDnFuncMapEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDnFuncMapEN objDnFuncMapEN)
{
 clsDnFuncMapBL.DnFuncMapDA.CheckProperty4Condition(objDnFuncMapEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnFuncMapEN objDnFuncMapCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.DnFuncMapId, objDnFuncMapCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.InDataNodeId, objDnFuncMapCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.OutDataNodeId, objDnFuncMapCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.AssociationMappingId, objDnFuncMapCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.FuncMapModeId, objDnFuncMapCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.TabId) == true)
{
string strComparisonOpTabId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.TabId, objDnFuncMapCond.TabId, strComparisonOpTabId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.DnFunctionId, objDnFuncMapCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.ErrMsg, objDnFuncMapCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.PrjId) == true)
{
string strComparisonOpPrjId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.PrjId, objDnFuncMapCond.PrjId, strComparisonOpPrjId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.UsedTimes, objDnFuncMapCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.UpdDate, objDnFuncMapCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.UpdUser, objDnFuncMapCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.Memo) == true)
{
string strComparisonOpMemo = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.Memo, objDnFuncMapCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DnFuncMap(结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:InDataNodeId_OutDataNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDnFuncMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDnFuncMapEN objDnFuncMapEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDnFuncMapEN == null) return true;
if (objDnFuncMapEN.DnFuncMapId == null || objDnFuncMapEN.DnFuncMapId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
if (clsDnFuncMapBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DnFuncMapId !=  '{0}'", objDnFuncMapEN.DnFuncMapId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
if (clsDnFuncMapBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DnFuncMap(结点函数映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:InDataNodeId_OutDataNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnFuncMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDnFuncMapEN objDnFuncMapEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnFuncMapEN == null) return "";
if (objDnFuncMapEN.DnFuncMapId == null || objDnFuncMapEN.DnFuncMapId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFuncMapId !=  '{0}'", objDnFuncMapEN.DnFuncMapId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DnFuncMap
{
public virtual bool UpdRelaTabDate(string strDnFuncMapId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 结点函数映射(DnFuncMap)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDnFuncMapBL
{
public static RelatedActions_DnFuncMap relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDnFuncMapDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDnFuncMapDA DnFuncMapDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDnFuncMapDA();
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
 public clsDnFuncMapBL()
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
if (string.IsNullOrEmpty(clsDnFuncMapEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnFuncMapEN._ConnectString);
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
public static DataTable GetDataTable_DnFuncMap(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DnFuncMapDA.GetDataTable_DnFuncMap(strWhereCond);
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
objDT = DnFuncMapDA.GetDataTable(strWhereCond);
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
objDT = DnFuncMapDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DnFuncMapDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DnFuncMapDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DnFuncMapDA.GetDataTable_Top(objTopPara);
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
objDT = DnFuncMapDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DnFuncMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DnFuncMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDnFuncMapIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDnFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapIdLst)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDnFuncMapIdLst, true);
 string strWhereCond = string.Format("DnFuncMapId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDnFuncMapIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDnFuncMapEN> GetObjLstByDnFuncMapIdLstCache(List<string> arrDnFuncMapIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
arrDnFuncMapObjLstCache
.Where(x => arrDnFuncMapIdLst.Contains(x.DnFuncMapId));
return arrDnFuncMapObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFuncMapEN> GetObjLst(string strWhereCond)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
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
public static List<clsDnFuncMapEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDnFuncMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDnFuncMapEN> GetSubObjLstCache(clsDnFuncMapEN objDnFuncMapCond)
{
 string strPrjId = objDnFuncMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDnFuncMapBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDnFuncMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFuncMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnFuncMap._AttributeName)
{
if (objDnFuncMapCond.IsUpdated(strFldName) == false) continue;
if (objDnFuncMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnFuncMapCond[strFldName].ToString());
}
else
{
if (objDnFuncMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnFuncMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnFuncMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnFuncMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnFuncMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnFuncMapCond[strFldName]));
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
public static List<clsDnFuncMapEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
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
public static List<clsDnFuncMapEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
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
List<clsDnFuncMapEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDnFuncMapEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDnFuncMapEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
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
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
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
public static List<clsDnFuncMapEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDnFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDnFuncMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
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
public static List<clsDnFuncMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFuncMapEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDnFuncMapEN> arrObjLst = new List<clsDnFuncMapEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnFuncMapEN objDnFuncMapEN = new clsDnFuncMapEN();
try
{
objDnFuncMapEN.DnFuncMapId = objRow[conDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objDnFuncMapEN.InDataNodeId = Int32.Parse(objRow[conDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnFuncMapEN.OutDataNodeId = Int32.Parse(objRow[conDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnFuncMapEN.AssociationMappingId = objRow[conDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnFuncMapEN.FuncMapModeId = objRow[conDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDnFuncMapEN.TabId = objRow[conDnFuncMap.TabId] == DBNull.Value ? null : objRow[conDnFuncMap.TabId].ToString().Trim(); //表ID
objDnFuncMapEN.DnFunctionId = objRow[conDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[conDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDnFuncMapEN.ErrMsg = objRow[conDnFuncMap.ErrMsg] == DBNull.Value ? null : objRow[conDnFuncMap.ErrMsg].ToString().Trim(); //错误信息
objDnFuncMapEN.PrjId = objRow[conDnFuncMap.PrjId].ToString().Trim(); //工程Id
objDnFuncMapEN.UsedTimes = objRow[conDnFuncMap.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnFuncMap.UsedTimes].ToString().Trim()); //使用次数
objDnFuncMapEN.UpdDate = objRow[conDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[conDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objDnFuncMapEN.UpdUser = objRow[conDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[conDnFuncMap.UpdUser].ToString().Trim(); //修改者
objDnFuncMapEN.Memo = objRow[conDnFuncMap.Memo] == DBNull.Value ? null : objRow[conDnFuncMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnFuncMapEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDnFuncMapEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDnFuncMap(ref clsDnFuncMapEN objDnFuncMapEN)
{
bool bolResult = DnFuncMapDA.GetDnFuncMap(ref objDnFuncMapEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
if (strDnFuncMapId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDnFuncMapId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDnFuncMapId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDnFuncMapId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDnFuncMapEN objDnFuncMapEN = DnFuncMapDA.GetObjByDnFuncMapId(strDnFuncMapId);
return objDnFuncMapEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDnFuncMapEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDnFuncMapEN objDnFuncMapEN = DnFuncMapDA.GetFirstObj(strWhereCond);
 return objDnFuncMapEN;
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
public static clsDnFuncMapEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDnFuncMapEN objDnFuncMapEN = DnFuncMapDA.GetObjByDataRow(objRow);
 return objDnFuncMapEN;
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
public static clsDnFuncMapEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDnFuncMapEN objDnFuncMapEN = DnFuncMapDA.GetObjByDataRow(objRow);
 return objDnFuncMapEN;
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
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <param name = "lstDnFuncMapObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnFuncMapEN GetObjByDnFuncMapIdFromList(string strDnFuncMapId, List<clsDnFuncMapEN> lstDnFuncMapObjLst)
{
foreach (clsDnFuncMapEN objDnFuncMapEN in lstDnFuncMapObjLst)
{
if (objDnFuncMapEN.DnFuncMapId == strDnFuncMapId)
{
return objDnFuncMapEN;
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
 string strMaxDnFuncMapId;
 try
 {
 strMaxDnFuncMapId = clsDnFuncMapDA.GetMaxStrId();
 return strMaxDnFuncMapId;
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
 string strDnFuncMapId;
 try
 {
 strDnFuncMapId = new clsDnFuncMapDA().GetFirstID(strWhereCond);
 return strDnFuncMapId;
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
 arrList = DnFuncMapDA.GetID(strWhereCond);
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
bool bolIsExist = DnFuncMapDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDnFuncMapId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDnFuncMapId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DnFuncMapDA.IsExist(strDnFuncMapId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDnFuncMapId">函数映射Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDnFuncMapId, string strOpUser)
{
clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);
objDnFuncMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDnFuncMapEN.UpdUser = strOpUser;
return clsDnFuncMapBL.UpdateBySql2(objDnFuncMapEN);
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
 bolIsExist = clsDnFuncMapDA.IsExistTable();
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
 bolIsExist = DnFuncMapDA.IsExistTable(strTabName);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnFuncMapEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecordBySql2)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
bool bolResult = DnFuncMapDA.AddNewRecordBySQL2(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDnFuncMapEN objDnFuncMapEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnFuncMapEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}]的数据已经存在!(in clsDnFuncMapBL.AddNewRecordBySql2WithReturnKey)", objDnFuncMapEN.InDataNodeId,objDnFuncMapEN.OutDataNodeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapBL.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapBL.GetMaxStrId_S();
 }
string strKey = DnFuncMapDA.AddNewRecordBySQL2WithReturnKey(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDnFuncMapEN objDnFuncMapEN)
{
try
{
bool bolResult = DnFuncMapDA.Update(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDnFuncMapEN objDnFuncMapEN)
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DnFuncMapDA.UpdateBySql2(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFuncMapBL.ReFreshCache(objDnFuncMapEN.PrjId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDnFuncMapId)
{
try
{
 clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);

if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(objDnFuncMapEN.DnFuncMapId, objDnFuncMapEN.UpdUser);
}
if (objDnFuncMapEN != null)
{
int intRecNum = DnFuncMapDA.DelRecord(strDnFuncMapId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDnFuncMapEN.PrjId);
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
/// <param name="strDnFuncMapId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strDnFuncMapId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
//删除与表:[DnFuncMap]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDnFuncMap.DnFuncMapId,
//strDnFuncMapId);
//        clsDnFuncMapBL.DelDnFuncMapsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnFuncMapBL.DelRecord(strDnFuncMapId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnFuncMapBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDnFuncMapId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDnFuncMapId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDnFuncMapBL.relatedActions != null)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(strDnFuncMapId, "UpdRelaTabDate");
}
bool bolResult = DnFuncMapDA.DelRecord(strDnFuncMapId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDnFuncMapIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDnFuncMaps(List<string> arrDnFuncMapIdLst)
{
if (arrDnFuncMapIdLst.Count == 0) return 0;
try
{
if (clsDnFuncMapBL.relatedActions != null)
{
foreach (var strDnFuncMapId in arrDnFuncMapIdLst)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(strDnFuncMapId, "UpdRelaTabDate");
}
}
 clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapBL.GetObjByDnFuncMapId(arrDnFuncMapIdLst[0]);
int intDelRecNum = DnFuncMapDA.DelDnFuncMap(arrDnFuncMapIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDnFuncMapEN.PrjId);
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
public static int DelDnFuncMapsByCond(string strWhereCond)
{
try
{
if (clsDnFuncMapBL.relatedActions != null)
{
List<string> arrDnFuncMapId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDnFuncMapId in arrDnFuncMapId)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(strDnFuncMapId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDnFuncMap.PrjId, strWhereCond);
int intRecNum = DnFuncMapDA.DelDnFuncMap(strWhereCond);
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
public static bool DelDnFuncMapsByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDnFuncMapBL.relatedActions != null)
{
List<string> arrDnFuncMapId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDnFuncMapId in arrDnFuncMapId)
{
clsDnFuncMapBL.relatedActions.UpdRelaTabDate(strDnFuncMapId, "UpdRelaTabDate");
}
}
bool bolResult = DnFuncMapDA.DelDnFuncMapWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DnFuncMap]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDnFuncMapId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDnFuncMapId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnFuncMapDA.GetSpecSQLObj();
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
//删除与表:[DnFuncMap]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnFuncMapBL.DelRecord(strDnFuncMapId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnFuncMapBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDnFuncMapId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDnFuncMapENS">源对象</param>
 /// <param name = "objDnFuncMapENT">目标对象</param>
 public static void CopyTo(clsDnFuncMapEN objDnFuncMapENS, clsDnFuncMapEN objDnFuncMapENT)
{
try
{
objDnFuncMapENT.DnFuncMapId = objDnFuncMapENS.DnFuncMapId; //函数映射Id
objDnFuncMapENT.InDataNodeId = objDnFuncMapENS.InDataNodeId; //In数据结点Id
objDnFuncMapENT.OutDataNodeId = objDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objDnFuncMapENT.AssociationMappingId = objDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objDnFuncMapENT.FuncMapModeId = objDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objDnFuncMapENT.TabId = objDnFuncMapENS.TabId; //表ID
objDnFuncMapENT.DnFunctionId = objDnFuncMapENS.DnFunctionId; //DN函数Id
objDnFuncMapENT.ErrMsg = objDnFuncMapENS.ErrMsg; //错误信息
objDnFuncMapENT.PrjId = objDnFuncMapENS.PrjId; //工程Id
objDnFuncMapENT.UsedTimes = objDnFuncMapENS.UsedTimes; //使用次数
objDnFuncMapENT.UpdDate = objDnFuncMapENS.UpdDate; //修改日期
objDnFuncMapENT.UpdUser = objDnFuncMapENS.UpdUser; //修改者
objDnFuncMapENT.Memo = objDnFuncMapENS.Memo; //说明
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
 /// <param name = "objDnFuncMapEN">源简化对象</param>
 public static void SetUpdFlag(clsDnFuncMapEN objDnFuncMapEN)
{
try
{
objDnFuncMapEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDnFuncMapEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDnFuncMap.DnFuncMapId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.DnFuncMapId = objDnFuncMapEN.DnFuncMapId; //函数映射Id
}
if (arrFldSet.Contains(conDnFuncMap.InDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.InDataNodeId = objDnFuncMapEN.InDataNodeId; //In数据结点Id
}
if (arrFldSet.Contains(conDnFuncMap.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.OutDataNodeId = objDnFuncMapEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(conDnFuncMap.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.AssociationMappingId = objDnFuncMapEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(conDnFuncMap.FuncMapModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.FuncMapModeId = objDnFuncMapEN.FuncMapModeId; //函数映射模式Id
}
if (arrFldSet.Contains(conDnFuncMap.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.TabId = objDnFuncMapEN.TabId == "[null]" ? null :  objDnFuncMapEN.TabId; //表ID
}
if (arrFldSet.Contains(conDnFuncMap.DnFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.DnFunctionId = objDnFuncMapEN.DnFunctionId == "[null]" ? null :  objDnFuncMapEN.DnFunctionId; //DN函数Id
}
if (arrFldSet.Contains(conDnFuncMap.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.ErrMsg = objDnFuncMapEN.ErrMsg == "[null]" ? null :  objDnFuncMapEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conDnFuncMap.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.PrjId = objDnFuncMapEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDnFuncMap.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.UsedTimes = objDnFuncMapEN.UsedTimes; //使用次数
}
if (arrFldSet.Contains(conDnFuncMap.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.UpdDate = objDnFuncMapEN.UpdDate == "[null]" ? null :  objDnFuncMapEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDnFuncMap.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.UpdUser = objDnFuncMapEN.UpdUser == "[null]" ? null :  objDnFuncMapEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDnFuncMap.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDnFuncMapEN.Memo = objDnFuncMapEN.Memo == "[null]" ? null :  objDnFuncMapEN.Memo; //说明
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
 /// <param name = "objDnFuncMapEN">源简化对象</param>
 public static void AccessFldValueNull(clsDnFuncMapEN objDnFuncMapEN)
{
try
{
if (objDnFuncMapEN.TabId == "[null]") objDnFuncMapEN.TabId = null; //表ID
if (objDnFuncMapEN.DnFunctionId == "[null]") objDnFuncMapEN.DnFunctionId = null; //DN函数Id
if (objDnFuncMapEN.ErrMsg == "[null]") objDnFuncMapEN.ErrMsg = null; //错误信息
if (objDnFuncMapEN.UpdDate == "[null]") objDnFuncMapEN.UpdDate = null; //修改日期
if (objDnFuncMapEN.UpdUser == "[null]") objDnFuncMapEN.UpdUser = null; //修改者
if (objDnFuncMapEN.Memo == "[null]") objDnFuncMapEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDnFuncMapEN objDnFuncMapEN)
{
 DnFuncMapDA.CheckPropertyNew(objDnFuncMapEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDnFuncMapEN objDnFuncMapEN)
{
 DnFuncMapDA.CheckProperty4Condition(objDnFuncMapEN);
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
if (clsDnFuncMapBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnFuncMapBL没有刷新缓存机制(clsDnFuncMapBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DnFuncMapId");
//if (arrDnFuncMapObjLstCache == null)
//{
//arrDnFuncMapObjLstCache = DnFuncMapDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnFuncMapEN GetObjByDnFuncMapIdCache(string strDnFuncMapId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFuncMapEN> arrDnFuncMapObjLst_Sel =
arrDnFuncMapObjLstCache
.Where(x=> x.DnFuncMapId == strDnFuncMapId 
);
if (arrDnFuncMapObjLst_Sel.Count() == 0)
{
   clsDnFuncMapEN obj = clsDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strDnFuncMapId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrDnFuncMapObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnFuncMapEN> GetAllDnFuncMapObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = GetObjLstCache(strPrjId); 
return arrDnFuncMapObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnFuncMapEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDnFuncMapEN> arrDnFuncMapObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDnFuncMapObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnFuncMapEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDnFuncMapEN._RefreshTimeLst.Count == 0) return "";
return clsDnFuncMapEN._RefreshTimeLst[clsDnFuncMapEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnFuncMapBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnFuncMapBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsDnFuncMapBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDnFuncMapEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnFuncMapEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDnFuncMapBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DnFuncMap(结点函数映射)
 /// 唯一性条件:InDataNodeId_OutDataNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnFuncMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDnFuncMapEN objDnFuncMapEN)
{
//检测记录是否存在
string strResult = DnFuncMapDA.GetUniCondStr(objDnFuncMapEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strDnFuncMapId, string strPrjId)
{
if (strInFldName != conDnFuncMap.DnFuncMapId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDnFuncMap._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDnFuncMap._AttributeName));
throw new Exception(strMsg);
}
var objDnFuncMap = clsDnFuncMapBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
if (objDnFuncMap == null) return "";
return objDnFuncMap[strOutFldName].ToString();
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
int intRecCount = clsDnFuncMapDA.GetRecCount(strTabName);
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
int intRecCount = clsDnFuncMapDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDnFuncMapDA.GetRecCount();
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
int intRecCount = clsDnFuncMapDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDnFuncMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDnFuncMapEN objDnFuncMapCond)
{
 string strPrjId = objDnFuncMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDnFuncMapBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDnFuncMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFuncMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnFuncMap._AttributeName)
{
if (objDnFuncMapCond.IsUpdated(strFldName) == false) continue;
if (objDnFuncMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnFuncMapCond[strFldName].ToString());
}
else
{
if (objDnFuncMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnFuncMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnFuncMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnFuncMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnFuncMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnFuncMapCond[strFldName]));
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
 List<string> arrList = clsDnFuncMapDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DnFuncMapDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DnFuncMapDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DnFuncMapDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnFuncMapDA.SetFldValue(clsDnFuncMapEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DnFuncMapDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnFuncMapDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnFuncMapDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnFuncMapDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DnFuncMap] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数映射Id*/ 
 strCreateTabCode.Append(" DnFuncMapId char(8) primary key, "); 
 // /**In数据结点Id*/ 
 strCreateTabCode.Append(" InDataNodeId bigint not Null, "); 
 // /**Out数据结点Id*/ 
 strCreateTabCode.Append(" OutDataNodeId bigint not Null, "); 
 // /**关联关系映射Id*/ 
 strCreateTabCode.Append(" AssociationMappingId char(2) not Null, "); 
 // /**函数映射模式Id*/ 
 strCreateTabCode.Append(" FuncMapModeId char(2) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**DN函数Id*/ 
 strCreateTabCode.Append(" DnFunctionId char(8) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**使用次数*/ 
 strCreateTabCode.Append(" UsedTimes int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**In数据结点名*/ 
 strCreateTabCode.Append(" InDataNodeName varchar(100) Null, "); 
 // /**Out数据结点名*/ 
 strCreateTabCode.Append(" OutDataNodeName varchar(100) Null, "); 
 // /**关联关系映射名*/ 
 strCreateTabCode.Append(" AssociationMappingName varchar(50) Null, "); 
 // /**函数映射模式名*/ 
 strCreateTabCode.Append(" FuncMapModeName varchar(50) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**映射说明*/ 
 strCreateTabCode.Append(" MapDescription varchar(100) Null, "); 
 // /**DN函数*/ 
 strCreateTabCode.Append(" DnFunctionName varchar(50) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 结点函数映射(DnFuncMap)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DnFuncMap : clsCommFun4BLV2
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
clsDnFuncMapBL.ReFreshThisCache(strPrjId);
}
}

}