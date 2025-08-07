
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationBL
 表名:PrjTabRelation(00050606)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsPrjTabRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabRelationEN GetObj(this K_PrjRelationId_PrjTabRelation myKey)
{
clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationBL.PrjTabRelationDA.GetObjByPrjRelationId(myKey.Value);
return objPrjTabRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],表关系类型Id = [{1}],相关表Id = [{2}]的数据已经存在!(in clsPrjTabRelationBL.AddNewRecord)", objPrjTabRelationEN.TabId,objPrjTabRelationEN.PrjTabRelaTypeId,objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjTabRelationBL.PrjTabRelationDA.AddNewRecordBySQL2(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjTabRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjTabRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],表关系类型Id(PrjTabRelaTypeId)=[{1}],相关表Id(RelationTabId)=[{2}])已经存在,不能重复!", objPrjTabRelationEN.TabId, objPrjTabRelationEN.PrjTabRelaTypeId, objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjTabRelationEN.AddNewRecord();
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],表关系类型Id = [{1}],相关表Id = [{2}]的数据已经存在!(in clsPrjTabRelationBL.AddNewRecordWithMaxId)", objPrjTabRelationEN.TabId,objPrjTabRelationEN.PrjTabRelaTypeId,objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
string strPrjRelationId = clsPrjTabRelationBL.PrjTabRelationDA.AddNewRecordBySQL2WithReturnKey(objPrjTabRelationEN);
     objPrjTabRelationEN.PrjRelationId = strPrjRelationId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
}
return strPrjRelationId;
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],表关系类型Id = [{1}],相关表Id = [{2}]的数据已经存在!(in clsPrjTabRelationBL.AddNewRecordWithReturnKey)", objPrjTabRelationEN.TabId,objPrjTabRelationEN.PrjTabRelaTypeId,objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
string strKey = clsPrjTabRelationBL.PrjTabRelationDA.AddNewRecordBySQL2WithReturnKey(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjRelationId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjRelationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjRelationId, 8, conPrjTabRelation.PrjRelationId);
}
objPrjTabRelationEN.PrjRelationId = strPrjRelationId; //关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjRelationId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjRelationId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjRelationId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetRelationName(this clsPrjTabRelationEN objPrjTabRelationEN, string strRelationName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationName, conPrjTabRelation.RelationName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationName, 40, conPrjTabRelation.RelationName);
}
objPrjTabRelationEN.RelationName = strRelationName; //关系名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.RelationName) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.RelationName, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.RelationName] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjTabRelation.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTabRelation.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTabRelation.TabId);
}
objPrjTabRelationEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.TabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.TabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.TabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjTabRelaTypeId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjTabRelaTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
}
objPrjTabRelationEN.PrjTabRelaTypeId = strPrjTabRelaTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjTabRelaTypeId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjTabRelaTypeId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjTabRelaTypeId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetDnPathId(this clsPrjTabRelationEN objPrjTabRelationEN, string strDnPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conPrjTabRelation.DnPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conPrjTabRelation.DnPathId);
}
objPrjTabRelationEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.DnPathId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.DnPathId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.DnPathId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetRelationTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strRelationTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationTabId, conPrjTabRelation.RelationTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationTabId, 8, conPrjTabRelation.RelationTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelationTabId, 8, conPrjTabRelation.RelationTabId);
}
objPrjTabRelationEN.RelationTabId = strRelationTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.RelationTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.RelationTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.RelationTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetFldId4TabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strFldId4TabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId4TabId, conPrjTabRelation.FldId4TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId4TabId, 8, conPrjTabRelation.FldId4TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId4TabId, 8, conPrjTabRelation.FldId4TabId);
}
objPrjTabRelationEN.FldId4TabId = strFldId4TabId; //当前表的关系字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.FldId4TabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.FldId4TabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.FldId4TabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetFldId4RelaTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strFldId4RelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
}
objPrjTabRelationEN.FldId4RelaTabId = strFldId4RelaTabId; //关系表的关系字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.FldId4RelaTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.FldId4RelaTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.FldId4RelaTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetForeignKeyTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strForeignKeyTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
}
objPrjTabRelationEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.ForeignKeyTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.ForeignKeyTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.ForeignKeyTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetForeignKeyFldId(this clsPrjTabRelationEN objPrjTabRelationEN, string strForeignKeyFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
}
objPrjTabRelationEN.ForeignKeyFldId = strForeignKeyFldId; //外键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.ForeignKeyFldId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.ForeignKeyFldId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.ForeignKeyFldId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsCheckCurrData(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsCheckCurrData, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCheckCurrData, conPrjTabRelation.IsCheckCurrData);
objPrjTabRelationEN.IsCheckCurrData = bolIsCheckCurrData; //是否检查当前数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsCheckCurrData) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsCheckCurrData, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsCheckCurrData] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsCopyForceRela(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsCopyForceRela, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCopyForceRela, conPrjTabRelation.IsCopyForceRela);
objPrjTabRelationEN.IsCopyForceRela = bolIsCopyForceRela; //IsCopyForceRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsCopyForceRela) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsCopyForceRela, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsCopyForceRela] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsUpdRelateFld(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsUpdRelateFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdRelateFld, conPrjTabRelation.IsUpdRelateFld);
objPrjTabRelationEN.IsUpdRelateFld = bolIsUpdRelateFld; //是否修改关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsUpdRelateFld) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsUpdRelateFld, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsUpdRelateFld] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsUpdMainTabDate(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsUpdMainTabDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdMainTabDate, conPrjTabRelation.IsUpdMainTabDate);
objPrjTabRelationEN.IsUpdMainTabDate = bolIsUpdMainTabDate; //是否修改主表日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsUpdMainTabDate) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsUpdMainTabDate, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsUpdMainTabDate] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsRefreshMainTabCache(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsRefreshMainTabCache, string strComparisonOp="")
	{
objPrjTabRelationEN.IsRefreshMainTabCache = bolIsRefreshMainTabCache; //是否刷新主表缓存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsRefreshMainTabCache) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsRefreshMainTabCache, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsRefreshMainTabCache] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsDelRelateRec(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsDelRelateRec, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDelRelateRec, conPrjTabRelation.IsDelRelateRec);
objPrjTabRelationEN.IsDelRelateRec = bolIsDelRelateRec; //是否删除相关记录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsDelRelateRec) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsDelRelateRec, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsDelRelateRec] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTabRelation.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTabRelation.PrjId);
}
objPrjTabRelationEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetMemo(this clsPrjTabRelationEN objPrjTabRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTabRelation.Memo);
}
objPrjTabRelationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.Memo) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.Memo, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.Memo] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrimaryKeyTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrimaryKeyTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabId, 8, conPrjTabRelation.PrimaryKeyTabId);
}
objPrjTabRelationEN.PrimaryKeyTabId = strPrimaryKeyTabId; //PrimaryKeyTabId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrimaryKeyTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrimaryKeyTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrimaryKeyFldId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrimaryKeyFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyFldId, 8, conPrjTabRelation.PrimaryKeyFldId);
}
objPrjTabRelationEN.PrimaryKeyFldId = strPrimaryKeyFldId; //PrimaryKeyFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrimaryKeyFldId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrimaryKeyFldId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyFldId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjTabRelationEN objPrjTabRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjTabRelationEN.CheckPropertyNew();
clsPrjTabRelationEN objPrjTabRelationCond = new clsPrjTabRelationEN();
string strCondition = objPrjTabRelationCond
.SetPrjRelationId(objPrjTabRelationEN.PrjRelationId, "<>")
.SetTabId(objPrjTabRelationEN.TabId, "=")
.SetPrjTabRelaTypeId(objPrjTabRelationEN.PrjTabRelaTypeId, "=")
.SetRelationTabId(objPrjTabRelationEN.RelationTabId, "=")
.GetCombineCondition();
objPrjTabRelationEN._IsCheckProperty = true;
bool bolIsExist = clsPrjTabRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_PrjTabRelaTypeId_RelationTabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjTabRelationEN.Update();
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
 /// <param name = "objPrjTabRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjTabRelationEN objPrjTabRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjTabRelationEN objPrjTabRelationCond = new clsPrjTabRelationEN();
string strCondition = objPrjTabRelationCond
.SetTabId(objPrjTabRelation.TabId, "=")
.SetPrjTabRelaTypeId(objPrjTabRelation.PrjTabRelaTypeId, "=")
.SetRelationTabId(objPrjTabRelation.RelationTabId, "=")
.GetCombineCondition();
objPrjTabRelation._IsCheckProperty = true;
bool bolIsExist = clsPrjTabRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjTabRelation.PrjRelationId = clsPrjTabRelationBL.GetFirstID_S(strCondition);
objPrjTabRelation.UpdateWithCondition(strCondition);
}
else
{
objPrjTabRelation.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
objPrjTabRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabRelationBL.PrjTabRelationDA.UpdateBySql2(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabRelationEN objPrjTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabRelationBL.PrjTabRelationDA.UpdateBySql2(objPrjTabRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabRelationEN objPrjTabRelationEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjTabRelationBL.PrjTabRelationDA.UpdateBySqlWithCondition(objPrjTabRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabRelationEN objPrjTabRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjTabRelationBL.PrjTabRelationDA.UpdateBySqlWithConditionTransaction(objPrjTabRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
int intRecNum = clsPrjTabRelationBL.PrjTabRelationDA.DelRecord(objPrjTabRelationEN.PrjRelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <param name = "objPrjTabRelationENT">目标对象</param>
 public static void CopyTo(this clsPrjTabRelationEN objPrjTabRelationENS, clsPrjTabRelationEN objPrjTabRelationENT)
{
try
{
objPrjTabRelationENT.PrjRelationId = objPrjTabRelationENS.PrjRelationId; //关系Id
objPrjTabRelationENT.RelationName = objPrjTabRelationENS.RelationName; //关系名
objPrjTabRelationENT.TabId = objPrjTabRelationENS.TabId; //表ID
objPrjTabRelationENT.PrjTabRelaTypeId = objPrjTabRelationENS.PrjTabRelaTypeId; //表关系类型Id
objPrjTabRelationENT.DnPathId = objPrjTabRelationENS.DnPathId; //DN路径Id
objPrjTabRelationENT.RelationTabId = objPrjTabRelationENS.RelationTabId; //相关表Id
objPrjTabRelationENT.FldId4TabId = objPrjTabRelationENS.FldId4TabId; //当前表的关系字段Id
objPrjTabRelationENT.FldId4RelaTabId = objPrjTabRelationENS.FldId4RelaTabId; //关系表的关系字段Id
objPrjTabRelationENT.ForeignKeyTabId = objPrjTabRelationENS.ForeignKeyTabId; //外键表ID
objPrjTabRelationENT.ForeignKeyFldId = objPrjTabRelationENS.ForeignKeyFldId; //外键字段Id
objPrjTabRelationENT.IsCheckCurrData = objPrjTabRelationENS.IsCheckCurrData; //是否检查当前数据
objPrjTabRelationENT.IsCopyForceRela = objPrjTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objPrjTabRelationENT.IsUpdRelateFld = objPrjTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objPrjTabRelationENT.IsUpdMainTabDate = objPrjTabRelationENS.IsUpdMainTabDate; //是否修改主表日期
objPrjTabRelationENT.IsRefreshMainTabCache = objPrjTabRelationENS.IsRefreshMainTabCache; //是否刷新主表缓存
objPrjTabRelationENT.IsDelRelateRec = objPrjTabRelationENS.IsDelRelateRec; //是否删除相关记录
objPrjTabRelationENT.PrjId = objPrjTabRelationENS.PrjId; //工程Id
objPrjTabRelationENT.Memo = objPrjTabRelationENS.Memo; //说明
objPrjTabRelationENT.PrimaryKeyTabId = objPrjTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objPrjTabRelationENT.PrimaryKeyFldId = objPrjTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationEN:objPrjTabRelationENT</returns>
 public static clsPrjTabRelationEN CopyTo(this clsPrjTabRelationEN objPrjTabRelationENS)
{
try
{
 clsPrjTabRelationEN objPrjTabRelationENT = new clsPrjTabRelationEN()
{
PrjRelationId = objPrjTabRelationENS.PrjRelationId, //关系Id
RelationName = objPrjTabRelationENS.RelationName, //关系名
TabId = objPrjTabRelationENS.TabId, //表ID
PrjTabRelaTypeId = objPrjTabRelationENS.PrjTabRelaTypeId, //表关系类型Id
DnPathId = objPrjTabRelationENS.DnPathId, //DN路径Id
RelationTabId = objPrjTabRelationENS.RelationTabId, //相关表Id
FldId4TabId = objPrjTabRelationENS.FldId4TabId, //当前表的关系字段Id
FldId4RelaTabId = objPrjTabRelationENS.FldId4RelaTabId, //关系表的关系字段Id
ForeignKeyTabId = objPrjTabRelationENS.ForeignKeyTabId, //外键表ID
ForeignKeyFldId = objPrjTabRelationENS.ForeignKeyFldId, //外键字段Id
IsCheckCurrData = objPrjTabRelationENS.IsCheckCurrData, //是否检查当前数据
IsCopyForceRela = objPrjTabRelationENS.IsCopyForceRela, //IsCopyForceRela
IsUpdRelateFld = objPrjTabRelationENS.IsUpdRelateFld, //是否修改关系字段
IsUpdMainTabDate = objPrjTabRelationENS.IsUpdMainTabDate, //是否修改主表日期
IsRefreshMainTabCache = objPrjTabRelationENS.IsRefreshMainTabCache, //是否刷新主表缓存
IsDelRelateRec = objPrjTabRelationENS.IsDelRelateRec, //是否删除相关记录
PrjId = objPrjTabRelationENS.PrjId, //工程Id
Memo = objPrjTabRelationENS.Memo, //说明
PrimaryKeyTabId = objPrjTabRelationENS.PrimaryKeyTabId, //PrimaryKeyTabId
PrimaryKeyFldId = objPrjTabRelationENS.PrimaryKeyFldId, //PrimaryKeyFldId
};
 return objPrjTabRelationENT;
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
public static void CheckPropertyNew(this clsPrjTabRelationEN objPrjTabRelationEN)
{
 clsPrjTabRelationBL.PrjTabRelationDA.CheckPropertyNew(objPrjTabRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjTabRelationEN objPrjTabRelationEN)
{
 clsPrjTabRelationBL.PrjTabRelationDA.CheckProperty4Condition(objPrjTabRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabRelationEN objPrjTabRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjRelationId) == true)
{
string strComparisonOpPrjRelationId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjRelationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjRelationId, objPrjTabRelationCond.PrjRelationId, strComparisonOpPrjRelationId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.RelationName) == true)
{
string strComparisonOpRelationName = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.RelationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.RelationName, objPrjTabRelationCond.RelationName, strComparisonOpRelationName);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.TabId) == true)
{
string strComparisonOpTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.TabId, objPrjTabRelationCond.TabId, strComparisonOpTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId) == true)
{
string strComparisonOpPrjTabRelaTypeId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjTabRelaTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjTabRelaTypeId, objPrjTabRelationCond.PrjTabRelaTypeId, strComparisonOpPrjTabRelaTypeId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.DnPathId) == true)
{
string strComparisonOpDnPathId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.DnPathId, objPrjTabRelationCond.DnPathId, strComparisonOpDnPathId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.RelationTabId) == true)
{
string strComparisonOpRelationTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.RelationTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.RelationTabId, objPrjTabRelationCond.RelationTabId, strComparisonOpRelationTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.FldId4TabId) == true)
{
string strComparisonOpFldId4TabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.FldId4TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.FldId4TabId, objPrjTabRelationCond.FldId4TabId, strComparisonOpFldId4TabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.FldId4RelaTabId) == true)
{
string strComparisonOpFldId4RelaTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.FldId4RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.FldId4RelaTabId, objPrjTabRelationCond.FldId4RelaTabId, strComparisonOpFldId4RelaTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.ForeignKeyTabId, objPrjTabRelationCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.ForeignKeyFldId) == true)
{
string strComparisonOpForeignKeyFldId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.ForeignKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.ForeignKeyFldId, objPrjTabRelationCond.ForeignKeyFldId, strComparisonOpForeignKeyFldId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsCheckCurrData) == true)
{
if (objPrjTabRelationCond.IsCheckCurrData == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsCheckCurrData);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsCheckCurrData);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsCopyForceRela) == true)
{
if (objPrjTabRelationCond.IsCopyForceRela == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsCopyForceRela);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsCopyForceRela);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsUpdRelateFld) == true)
{
if (objPrjTabRelationCond.IsUpdRelateFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsUpdRelateFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsUpdRelateFld);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsUpdMainTabDate) == true)
{
if (objPrjTabRelationCond.IsUpdMainTabDate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsUpdMainTabDate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsUpdMainTabDate);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache) == true)
{
if (objPrjTabRelationCond.IsRefreshMainTabCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsRefreshMainTabCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsRefreshMainTabCache);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsDelRelateRec) == true)
{
if (objPrjTabRelationCond.IsDelRelateRec == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsDelRelateRec);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsDelRelateRec);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjId, objPrjTabRelationCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.Memo) == true)
{
string strComparisonOpMemo = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.Memo, objPrjTabRelationCond.Memo, strComparisonOpMemo);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrimaryKeyTabId) == true)
{
string strComparisonOpPrimaryKeyTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrimaryKeyTabId, objPrjTabRelationCond.PrimaryKeyTabId, strComparisonOpPrimaryKeyTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrimaryKeyFldId) == true)
{
string strComparisonOpPrimaryKeyFldId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrimaryKeyFldId, objPrjTabRelationCond.PrimaryKeyFldId, strComparisonOpPrimaryKeyFldId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjTabRelation(工程表关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_PrjTabRelaTypeId_RelationTabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjTabRelationEN objPrjTabRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabRelationEN == null) return true;
if (objPrjTabRelationEN.PrjRelationId == null || objPrjTabRelationEN.PrjRelationId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
if (clsPrjTabRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjRelationId !=  '{0}'", objPrjTabRelationEN.PrjRelationId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
if (clsPrjTabRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjTabRelation(工程表关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_PrjTabRelaTypeId_RelationTabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjTabRelationEN objPrjTabRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabRelationEN == null) return "";
if (objPrjTabRelationEN.PrjRelationId == null || objPrjTabRelationEN.PrjRelationId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjRelationId !=  '{0}'", objPrjTabRelationEN.PrjRelationId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjTabRelation
{
public virtual bool UpdRelaTabDate(string strPrjRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程表关系(PrjTabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabRelationBL
{
public static RelatedActions_PrjTabRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjTabRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjTabRelationDA PrjTabRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjTabRelationDA();
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
 public clsPrjTabRelationBL()
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
if (string.IsNullOrEmpty(clsPrjTabRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabRelationEN._ConnectString);
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
public static DataTable GetDataTable_PrjTabRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjTabRelationDA.GetDataTable_PrjTabRelation(strWhereCond);
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
objDT = PrjTabRelationDA.GetDataTable(strWhereCond);
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
objDT = PrjTabRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjTabRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjTabRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjTabRelationDA.GetDataTable_Top(objTopPara);
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
objDT = PrjTabRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjTabRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjTabRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstByPrjRelationIdLst(List<string> arrPrjRelationIdLst)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjRelationIdLst, true);
 string strWhereCond = string.Format("PrjRelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjTabRelationEN> GetObjLstByPrjRelationIdLstCache(List<string> arrPrjRelationIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel =
arrPrjTabRelationObjLstCache
.Where(x => arrPrjRelationIdLst.Contains(x.PrjRelationId));
return arrPrjTabRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLst(string strWhereCond)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
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
public static List<clsPrjTabRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjTabRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjTabRelationEN> GetSubObjLstCache(clsPrjTabRelationEN objPrjTabRelationCond)
{
 string strPrjId = objPrjTabRelationCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPrjTabRelationBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPrjTabRelationEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTabRelation._AttributeName)
{
if (objPrjTabRelationCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabRelationCond[strFldName].ToString());
}
else
{
if (objPrjTabRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabRelationCond[strFldName]));
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
public static List<clsPrjTabRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
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
public static List<clsPrjTabRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
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
List<clsPrjTabRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjTabRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjTabRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
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
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
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
public static List<clsPrjTabRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjTabRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
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
public static List<clsPrjTabRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabRelationEN.PrjRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjTabRelation(ref clsPrjTabRelationEN objPrjTabRelationEN)
{
bool bolResult = PrjTabRelationDA.GetPrjTabRelation(ref objPrjTabRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabRelationEN GetObjByPrjRelationId(string strPrjRelationId)
{
if (strPrjRelationId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjRelationId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjRelationId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjRelationId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjTabRelationEN objPrjTabRelationEN = PrjTabRelationDA.GetObjByPrjRelationId(strPrjRelationId);
return objPrjTabRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjTabRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjTabRelationEN objPrjTabRelationEN = PrjTabRelationDA.GetFirstObj(strWhereCond);
 return objPrjTabRelationEN;
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
public static clsPrjTabRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjTabRelationEN objPrjTabRelationEN = PrjTabRelationDA.GetObjByDataRow(objRow);
 return objPrjTabRelationEN;
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
public static clsPrjTabRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjTabRelationEN objPrjTabRelationEN = PrjTabRelationDA.GetObjByDataRow(objRow);
 return objPrjTabRelationEN;
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
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <param name = "lstPrjTabRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabRelationEN GetObjByPrjRelationIdFromList(string strPrjRelationId, List<clsPrjTabRelationEN> lstPrjTabRelationObjLst)
{
foreach (clsPrjTabRelationEN objPrjTabRelationEN in lstPrjTabRelationObjLst)
{
if (objPrjTabRelationEN.PrjRelationId == strPrjRelationId)
{
return objPrjTabRelationEN;
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
 string strMaxPrjRelationId;
 try
 {
 strMaxPrjRelationId = clsPrjTabRelationDA.GetMaxStrId();
 return strMaxPrjRelationId;
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
 string strPrjRelationId;
 try
 {
 strPrjRelationId = new clsPrjTabRelationDA().GetFirstID(strWhereCond);
 return strPrjRelationId;
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
 arrList = PrjTabRelationDA.GetID(strWhereCond);
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
bool bolIsExist = PrjTabRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjRelationId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjRelationId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjTabRelationDA.IsExist(strPrjRelationId);
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
 bolIsExist = clsPrjTabRelationDA.IsExistTable();
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
 bolIsExist = PrjTabRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjTabRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],表关系类型Id = [{1}],相关表Id = [{2}]的数据已经存在!(in clsPrjTabRelationBL.AddNewRecordBySql2)", objPrjTabRelationEN.TabId,objPrjTabRelationEN.PrjTabRelaTypeId,objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
bool bolResult = PrjTabRelationDA.AddNewRecordBySQL2(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjTabRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],表关系类型Id = [{1}],相关表Id = [{2}]的数据已经存在!(in clsPrjTabRelationBL.AddNewRecordBySql2WithReturnKey)", objPrjTabRelationEN.TabId,objPrjTabRelationEN.PrjTabRelaTypeId,objPrjTabRelationEN.RelationTabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationBL.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationBL.GetMaxStrId_S();
 }
string strKey = PrjTabRelationDA.AddNewRecordBySQL2WithReturnKey(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
bool bolResult = PrjTabRelationDA.Update(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjTabRelationDA.UpdateBySql2(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationBL.ReFreshCache(objPrjTabRelationEN.PrjId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
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
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjRelationId)
{
try
{
 clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationBL.GetObjByPrjRelationId(strPrjRelationId);

if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(objPrjTabRelationEN.PrjRelationId, "SetUpdDate");
}
if (objPrjTabRelationEN != null)
{
int intRecNum = PrjTabRelationDA.DelRecord(strPrjRelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabRelationEN.PrjId);
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
/// <param name="strPrjRelationId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjRelationId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
//删除与表:[PrjTabRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjTabRelation.PrjRelationId,
//strPrjRelationId);
//        clsPrjTabRelationBL.DelPrjTabRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabRelationBL.DelRecord(strPrjRelationId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjRelationId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjTabRelationBL.relatedActions != null)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(strPrjRelationId, "UpdRelaTabDate");
}
bool bolResult = PrjTabRelationDA.DelRecord(strPrjRelationId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjRelationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjTabRelations(List<string> arrPrjRelationIdLst)
{
if (arrPrjRelationIdLst.Count == 0) return 0;
try
{
if (clsPrjTabRelationBL.relatedActions != null)
{
foreach (var strPrjRelationId in arrPrjRelationIdLst)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(strPrjRelationId, "UpdRelaTabDate");
}
}
 clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationBL.GetObjByPrjRelationId(arrPrjRelationIdLst[0]);
int intDelRecNum = PrjTabRelationDA.DelPrjTabRelation(arrPrjRelationIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabRelationEN.PrjId);
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
public static int DelPrjTabRelationsByCond(string strWhereCond)
{
try
{
if (clsPrjTabRelationBL.relatedActions != null)
{
List<string> arrPrjRelationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjRelationId in arrPrjRelationId)
{
clsPrjTabRelationBL.relatedActions.UpdRelaTabDate(strPrjRelationId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conPrjTabRelation.PrjId, strWhereCond);
int intRecNum = PrjTabRelationDA.DelPrjTabRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjTabRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjRelationId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjRelationId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
//删除与表:[PrjTabRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabRelationBL.DelRecord(strPrjRelationId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <param name = "objPrjTabRelationENT">目标对象</param>
 public static void CopyTo(clsPrjTabRelationEN objPrjTabRelationENS, clsPrjTabRelationEN objPrjTabRelationENT)
{
try
{
objPrjTabRelationENT.PrjRelationId = objPrjTabRelationENS.PrjRelationId; //关系Id
objPrjTabRelationENT.RelationName = objPrjTabRelationENS.RelationName; //关系名
objPrjTabRelationENT.TabId = objPrjTabRelationENS.TabId; //表ID
objPrjTabRelationENT.PrjTabRelaTypeId = objPrjTabRelationENS.PrjTabRelaTypeId; //表关系类型Id
objPrjTabRelationENT.DnPathId = objPrjTabRelationENS.DnPathId; //DN路径Id
objPrjTabRelationENT.RelationTabId = objPrjTabRelationENS.RelationTabId; //相关表Id
objPrjTabRelationENT.FldId4TabId = objPrjTabRelationENS.FldId4TabId; //当前表的关系字段Id
objPrjTabRelationENT.FldId4RelaTabId = objPrjTabRelationENS.FldId4RelaTabId; //关系表的关系字段Id
objPrjTabRelationENT.ForeignKeyTabId = objPrjTabRelationENS.ForeignKeyTabId; //外键表ID
objPrjTabRelationENT.ForeignKeyFldId = objPrjTabRelationENS.ForeignKeyFldId; //外键字段Id
objPrjTabRelationENT.IsCheckCurrData = objPrjTabRelationENS.IsCheckCurrData; //是否检查当前数据
objPrjTabRelationENT.IsCopyForceRela = objPrjTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objPrjTabRelationENT.IsUpdRelateFld = objPrjTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objPrjTabRelationENT.IsUpdMainTabDate = objPrjTabRelationENS.IsUpdMainTabDate; //是否修改主表日期
objPrjTabRelationENT.IsRefreshMainTabCache = objPrjTabRelationENS.IsRefreshMainTabCache; //是否刷新主表缓存
objPrjTabRelationENT.IsDelRelateRec = objPrjTabRelationENS.IsDelRelateRec; //是否删除相关记录
objPrjTabRelationENT.PrjId = objPrjTabRelationENS.PrjId; //工程Id
objPrjTabRelationENT.Memo = objPrjTabRelationENS.Memo; //说明
objPrjTabRelationENT.PrimaryKeyTabId = objPrjTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objPrjTabRelationENT.PrimaryKeyFldId = objPrjTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
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
 /// <param name = "objPrjTabRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
objPrjTabRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjTabRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjTabRelation.PrjRelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.PrjRelationId = objPrjTabRelationEN.PrjRelationId; //关系Id
}
if (arrFldSet.Contains(conPrjTabRelation.RelationName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.RelationName = objPrjTabRelationEN.RelationName; //关系名
}
if (arrFldSet.Contains(conPrjTabRelation.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.TabId = objPrjTabRelationEN.TabId; //表ID
}
if (arrFldSet.Contains(conPrjTabRelation.PrjTabRelaTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.PrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId; //表关系类型Id
}
if (arrFldSet.Contains(conPrjTabRelation.DnPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.DnPathId = objPrjTabRelationEN.DnPathId == "[null]" ? null :  objPrjTabRelationEN.DnPathId; //DN路径Id
}
if (arrFldSet.Contains(conPrjTabRelation.RelationTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.RelationTabId = objPrjTabRelationEN.RelationTabId; //相关表Id
}
if (arrFldSet.Contains(conPrjTabRelation.FldId4TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.FldId4TabId = objPrjTabRelationEN.FldId4TabId; //当前表的关系字段Id
}
if (arrFldSet.Contains(conPrjTabRelation.FldId4RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.FldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId; //关系表的关系字段Id
}
if (arrFldSet.Contains(conPrjTabRelation.ForeignKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.ForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId == "[null]" ? null :  objPrjTabRelationEN.ForeignKeyTabId; //外键表ID
}
if (arrFldSet.Contains(conPrjTabRelation.ForeignKeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.ForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId == "[null]" ? null :  objPrjTabRelationEN.ForeignKeyFldId; //外键字段Id
}
if (arrFldSet.Contains(conPrjTabRelation.IsCheckCurrData, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsCheckCurrData = objPrjTabRelationEN.IsCheckCurrData; //是否检查当前数据
}
if (arrFldSet.Contains(conPrjTabRelation.IsCopyForceRela, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsCopyForceRela = objPrjTabRelationEN.IsCopyForceRela; //IsCopyForceRela
}
if (arrFldSet.Contains(conPrjTabRelation.IsUpdRelateFld, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsUpdRelateFld = objPrjTabRelationEN.IsUpdRelateFld; //是否修改关系字段
}
if (arrFldSet.Contains(conPrjTabRelation.IsUpdMainTabDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsUpdMainTabDate = objPrjTabRelationEN.IsUpdMainTabDate; //是否修改主表日期
}
if (arrFldSet.Contains(conPrjTabRelation.IsRefreshMainTabCache, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsRefreshMainTabCache = objPrjTabRelationEN.IsRefreshMainTabCache; //是否刷新主表缓存
}
if (arrFldSet.Contains(conPrjTabRelation.IsDelRelateRec, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.IsDelRelateRec = objPrjTabRelationEN.IsDelRelateRec; //是否删除相关记录
}
if (arrFldSet.Contains(conPrjTabRelation.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.PrjId = objPrjTabRelationEN.PrjId == "[null]" ? null :  objPrjTabRelationEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjTabRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.Memo = objPrjTabRelationEN.Memo == "[null]" ? null :  objPrjTabRelationEN.Memo; //说明
}
if (arrFldSet.Contains(conPrjTabRelation.PrimaryKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.PrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId == "[null]" ? null :  objPrjTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
}
if (arrFldSet.Contains(conPrjTabRelation.PrimaryKeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabRelationEN.PrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId == "[null]" ? null :  objPrjTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
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
 /// <param name = "objPrjTabRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
if (objPrjTabRelationEN.DnPathId == "[null]") objPrjTabRelationEN.DnPathId = null; //DN路径Id
if (objPrjTabRelationEN.ForeignKeyTabId == "[null]") objPrjTabRelationEN.ForeignKeyTabId = null; //外键表ID
if (objPrjTabRelationEN.ForeignKeyFldId == "[null]") objPrjTabRelationEN.ForeignKeyFldId = null; //外键字段Id
if (objPrjTabRelationEN.PrjId == "[null]") objPrjTabRelationEN.PrjId = null; //工程Id
if (objPrjTabRelationEN.Memo == "[null]") objPrjTabRelationEN.Memo = null; //说明
if (objPrjTabRelationEN.PrimaryKeyTabId == "[null]") objPrjTabRelationEN.PrimaryKeyTabId = null; //PrimaryKeyTabId
if (objPrjTabRelationEN.PrimaryKeyFldId == "[null]") objPrjTabRelationEN.PrimaryKeyFldId = null; //PrimaryKeyFldId
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
public static void CheckPropertyNew(clsPrjTabRelationEN objPrjTabRelationEN)
{
 PrjTabRelationDA.CheckPropertyNew(objPrjTabRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjTabRelationEN objPrjTabRelationEN)
{
 PrjTabRelationDA.CheckProperty4Condition(objPrjTabRelationEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjRelationIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表关系]...","0");
List<clsPrjTabRelationEN> arrPrjTabRelationObjLst = GetAllPrjTabRelationObjLstCache(strPrjId); 
objDDL.DataValueField = conPrjTabRelation.PrjRelationId;
objDDL.DataTextField = conPrjTabRelation.RelationName;
objDDL.DataSource = arrPrjTabRelationObjLst;
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
if (clsPrjTabRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabRelationBL没有刷新缓存机制(clsPrjTabRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjRelationId");
//if (arrPrjTabRelationObjLstCache == null)
//{
//arrPrjTabRelationObjLstCache = PrjTabRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabRelationEN GetObjByPrjRelationIdCache(string strPrjRelationId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel =
arrPrjTabRelationObjLstCache
.Where(x=> x.PrjRelationId == strPrjRelationId 
);
if (arrPrjTabRelationObjLst_Sel.Count() == 0)
{
   clsPrjTabRelationEN obj = clsPrjTabRelationBL.GetObjByPrjRelationId(strPrjRelationId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPrjRelationId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPrjTabRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRelationNameByPrjRelationIdCache(string strPrjRelationId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return "";
//获取缓存中的对象列表
clsPrjTabRelationEN objPrjTabRelation = GetObjByPrjRelationIdCache(strPrjRelationId, strPrjId);
if (objPrjTabRelation == null) return "";
return objPrjTabRelation.RelationName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjRelationIdCache(string strPrjRelationId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return "";
//获取缓存中的对象列表
clsPrjTabRelationEN objPrjTabRelation = GetObjByPrjRelationIdCache(strPrjRelationId, strPrjId);
if (objPrjTabRelation == null) return "";
return objPrjTabRelation.RelationName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabRelationEN> GetAllPrjTabRelationObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId); 
return arrPrjTabRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPrjTabRelationObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjTabRelationEN._RefreshTimeLst.Count == 0) return "";
return clsPrjTabRelationEN._RefreshTimeLst[clsPrjTabRelationEN._RefreshTimeLst.Count - 1];
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
if (clsPrjTabRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjTabRelationBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjTabRelation(工程表关系)
 /// 唯一性条件:TabId_PrjTabRelaTypeId_RelationTabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjTabRelationEN objPrjTabRelationEN)
{
//检测记录是否存在
string strResult = PrjTabRelationDA.GetUniCondStr(objPrjTabRelationEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjRelationId, string strPrjId)
{
if (strInFldName != conPrjTabRelation.PrjRelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjTabRelation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjTabRelation._AttributeName));
throw new Exception(strMsg);
}
var objPrjTabRelation = clsPrjTabRelationBL.GetObjByPrjRelationIdCache(strPrjRelationId, strPrjId);
if (objPrjTabRelation == null) return "";
return objPrjTabRelation[strOutFldName].ToString();
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
int intRecCount = clsPrjTabRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjTabRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjTabRelationDA.GetRecCount();
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
int intRecCount = clsPrjTabRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjTabRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjTabRelationEN objPrjTabRelationCond)
{
 string strPrjId = objPrjTabRelationCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPrjTabRelationBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPrjTabRelationEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTabRelation._AttributeName)
{
if (objPrjTabRelationCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabRelationCond[strFldName].ToString());
}
else
{
if (objPrjTabRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabRelationCond[strFldName]));
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
 List<string> arrList = clsPrjTabRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjTabRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjTabRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjTabRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabRelationDA.SetFldValue(clsPrjTabRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjTabRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjTabRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**关系Id*/ 
 strCreateTabCode.Append(" PrjRelationId varchar(8) primary key, "); 
 // /**关系名*/ 
 strCreateTabCode.Append(" RelationName varchar(40) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**表关系类型Id*/ 
 strCreateTabCode.Append(" PrjTabRelaTypeId char(2) not Null, "); 
 // /**DN路径Id*/ 
 strCreateTabCode.Append(" DnPathId char(8) Null, "); 
 // /**相关表Id*/ 
 strCreateTabCode.Append(" RelationTabId char(8) not Null, "); 
 // /**当前表的关系字段Id*/ 
 strCreateTabCode.Append(" FldId4TabId char(8) not Null, "); 
 // /**关系表的关系字段Id*/ 
 strCreateTabCode.Append(" FldId4RelaTabId char(8) not Null, "); 
 // /**外键表ID*/ 
 strCreateTabCode.Append(" ForeignKeyTabId char(8) Null, "); 
 // /**外键字段Id*/ 
 strCreateTabCode.Append(" ForeignKeyFldId char(8) Null, "); 
 // /**是否检查当前数据*/ 
 strCreateTabCode.Append(" IsCheckCurrData bit not Null, "); 
 // /**IsCopyForceRela*/ 
 strCreateTabCode.Append(" IsCopyForceRela bit not Null, "); 
 // /**是否修改关系字段*/ 
 strCreateTabCode.Append(" IsUpdRelateFld bit not Null, "); 
 // /**是否修改主表日期*/ 
 strCreateTabCode.Append(" IsUpdMainTabDate bit not Null, "); 
 // /**是否刷新主表缓存*/ 
 strCreateTabCode.Append(" IsRefreshMainTabCache bit Null, "); 
 // /**是否删除相关记录*/ 
 strCreateTabCode.Append(" IsDelRelateRec bit not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PrimaryKeyTabId*/ 
 strCreateTabCode.Append(" PrimaryKeyTabId varchar(8) Null, "); 
 // /**PrimaryKeyFldId*/ 
 strCreateTabCode.Append(" PrimaryKeyFldId varchar(8) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**相关表名*/ 
 strCreateTabCode.Append(" RelaTabName varchar(100) Null, "); 
 // /**表关系类型名*/ 
 strCreateTabCode.Append(" TabRelationTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程表关系(PrjTabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjTabRelation : clsCommFun4BLV2
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
clsPrjTabRelationBL.ReFreshThisCache(strPrjId);
}
}

}