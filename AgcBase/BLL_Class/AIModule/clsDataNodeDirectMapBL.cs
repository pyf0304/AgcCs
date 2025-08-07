
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeDirectMapBL
 表名:DataNodeDirectMap(00050570)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:26
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
public static class  clsDataNodeDirectMapBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeDirectMapEN GetObj(this K_mId_DataNodeDirectMap myKey)
{
clsDataNodeDirectMapEN objDataNodeDirectMapEN = clsDataNodeDirectMapBL.DataNodeDirectMapDA.GetObjBymId(myKey.Value);
return objDataNodeDirectMapEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeDirectMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}],工程Id = [{2}]的数据已经存在!(in clsDataNodeDirectMapBL.AddNewRecord)", objDataNodeDirectMapEN.InDataNodeId,objDataNodeDirectMapEN.OutDataNodeId,objDataNodeDirectMapEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDataNodeDirectMapBL.DataNodeDirectMapDA.AddNewRecordBySQL2(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
public static bool AddRecordEx(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, bool bolIsNeedCheckUniqueness = true)
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
objDataNodeDirectMapEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDataNodeDirectMapEN.CheckUniqueness() == false)
{
strMsg = string.Format("(In数据结点Id(InDataNodeId)=[{0}],Out数据结点Id(OutDataNodeId)=[{1}],工程Id(PrjId)=[{2}])已经存在,不能重复!", objDataNodeDirectMapEN.InDataNodeId, objDataNodeDirectMapEN.OutDataNodeId, objDataNodeDirectMapEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDataNodeDirectMapEN.AddNewRecord();
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeDirectMapEN) == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}],工程Id = [{2}]的数据已经存在!(in clsDataNodeDirectMapBL.AddNewRecordWithReturnKey)", objDataNodeDirectMapEN.InDataNodeId,objDataNodeDirectMapEN.OutDataNodeId,objDataNodeDirectMapEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsDataNodeDirectMapBL.DataNodeDirectMapDA.AddNewRecordBySQL2WithReturnKey(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetmId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, long lngmId, string strComparisonOp="")
	{
objDataNodeDirectMapEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.mId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.mId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.mId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetInDataNodeId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, conDataNodeDirectMap.InDataNodeId);
objDataNodeDirectMapEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.InDataNodeId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.InDataNodeId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.InDataNodeId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetOutDataNodeId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, conDataNodeDirectMap.OutDataNodeId);
objDataNodeDirectMapEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.OutDataNodeId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.OutDataNodeId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.OutDataNodeId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetAssociationMappingId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDataNodeDirectMap.AssociationMappingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDataNodeDirectMap.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDataNodeDirectMap.AssociationMappingId);
}
objDataNodeDirectMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.AssociationMappingId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.AssociationMappingId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.AssociationMappingId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetFuncMapModeId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncMapModeId, conDataNodeDirectMap.FuncMapModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, conDataNodeDirectMap.FuncMapModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, conDataNodeDirectMap.FuncMapModeId);
}
objDataNodeDirectMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.FuncMapModeId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.FuncMapModeId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.FuncMapModeId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetTabId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conDataNodeDirectMap.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDataNodeDirectMap.TabId);
}
objDataNodeDirectMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.TabId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.TabId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.TabId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetDnFunctionId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strDnFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, conDataNodeDirectMap.DnFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, conDataNodeDirectMap.DnFunctionId);
}
objDataNodeDirectMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.DnFunctionId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.DnFunctionId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.DnFunctionId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetPrjId(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDataNodeDirectMap.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDataNodeDirectMap.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDataNodeDirectMap.PrjId);
}
objDataNodeDirectMapEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.PrjId) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.PrjId, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.PrjId] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetUpdDate(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNodeDirectMap.UpdDate);
}
objDataNodeDirectMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.UpdDate) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.UpdDate, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.UpdDate] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetUpdUser(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNodeDirectMap.UpdUser);
}
objDataNodeDirectMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.UpdUser) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.UpdUser, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.UpdUser] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeDirectMapEN SetMemo(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNodeDirectMap.Memo);
}
objDataNodeDirectMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeDirectMapEN.dicFldComparisonOp.ContainsKey(conDataNodeDirectMap.Memo) == false)
{
objDataNodeDirectMapEN.dicFldComparisonOp.Add(conDataNodeDirectMap.Memo, strComparisonOp);
}
else
{
objDataNodeDirectMapEN.dicFldComparisonOp[conDataNodeDirectMap.Memo] = strComparisonOp;
}
}
return objDataNodeDirectMapEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataNodeDirectMapEN.CheckPropertyNew();
clsDataNodeDirectMapEN objDataNodeDirectMapCond = new clsDataNodeDirectMapEN();
string strCondition = objDataNodeDirectMapCond
.SetmId(objDataNodeDirectMapEN.mId, "<>")
.SetInDataNodeId(objDataNodeDirectMapEN.InDataNodeId, "=")
.SetOutDataNodeId(objDataNodeDirectMapEN.OutDataNodeId, "=")
.SetPrjId(objDataNodeDirectMapEN.PrjId, "=")
.GetCombineCondition();
objDataNodeDirectMapEN._IsCheckProperty = true;
bool bolIsExist = clsDataNodeDirectMapBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(InDataNodeId_OutDataNodeId_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataNodeDirectMapEN.Update();
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
 /// <param name = "objDataNodeDirectMap">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDataNodeDirectMapEN objDataNodeDirectMap)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDataNodeDirectMapEN objDataNodeDirectMapCond = new clsDataNodeDirectMapEN();
string strCondition = objDataNodeDirectMapCond
.SetInDataNodeId(objDataNodeDirectMap.InDataNodeId, "=")
.SetOutDataNodeId(objDataNodeDirectMap.OutDataNodeId, "=")
.SetPrjId(objDataNodeDirectMap.PrjId, "=")
.GetCombineCondition();
objDataNodeDirectMap._IsCheckProperty = true;
bool bolIsExist = clsDataNodeDirectMapBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDataNodeDirectMap.mId = clsDataNodeDirectMapBL.GetFirstID_S(strCondition);
objDataNodeDirectMap.UpdateWithCondition(strCondition);
}
else
{
objDataNodeDirectMap.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 if (objDataNodeDirectMapEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeDirectMapBL.DataNodeDirectMapDA.UpdateBySql2(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataNodeDirectMapEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeDirectMapBL.DataNodeDirectMapDA.UpdateBySql2(objDataNodeDirectMapEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strWhereCond)
{
try
{
bool bolResult = clsDataNodeDirectMapBL.DataNodeDirectMapDA.UpdateBySqlWithCondition(objDataNodeDirectMapEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataNodeDirectMapBL.DataNodeDirectMapDA.UpdateBySqlWithConditionTransaction(objDataNodeDirectMapEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
public static int Delete(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
try
{
int intRecNum = clsDataNodeDirectMapBL.DataNodeDirectMapDA.DelRecord(objDataNodeDirectMapEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapENS">源对象</param>
 /// <param name = "objDataNodeDirectMapENT">目标对象</param>
 public static void CopyTo(this clsDataNodeDirectMapEN objDataNodeDirectMapENS, clsDataNodeDirectMapEN objDataNodeDirectMapENT)
{
try
{
objDataNodeDirectMapENT.mId = objDataNodeDirectMapENS.mId; //mId
objDataNodeDirectMapENT.InDataNodeId = objDataNodeDirectMapENS.InDataNodeId; //In数据结点Id
objDataNodeDirectMapENT.OutDataNodeId = objDataNodeDirectMapENS.OutDataNodeId; //Out数据结点Id
objDataNodeDirectMapENT.AssociationMappingId = objDataNodeDirectMapENS.AssociationMappingId; //关联关系映射Id
objDataNodeDirectMapENT.FuncMapModeId = objDataNodeDirectMapENS.FuncMapModeId; //函数映射模式Id
objDataNodeDirectMapENT.TabId = objDataNodeDirectMapENS.TabId; //表ID
objDataNodeDirectMapENT.DnFunctionId = objDataNodeDirectMapENS.DnFunctionId; //DN函数Id
objDataNodeDirectMapENT.PrjId = objDataNodeDirectMapENS.PrjId; //工程Id
objDataNodeDirectMapENT.UpdDate = objDataNodeDirectMapENS.UpdDate; //修改日期
objDataNodeDirectMapENT.UpdUser = objDataNodeDirectMapENS.UpdUser; //修改者
objDataNodeDirectMapENT.Memo = objDataNodeDirectMapENS.Memo; //说明
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
 /// <param name = "objDataNodeDirectMapENS">源对象</param>
 /// <returns>目标对象=>clsDataNodeDirectMapEN:objDataNodeDirectMapENT</returns>
 public static clsDataNodeDirectMapEN CopyTo(this clsDataNodeDirectMapEN objDataNodeDirectMapENS)
{
try
{
 clsDataNodeDirectMapEN objDataNodeDirectMapENT = new clsDataNodeDirectMapEN()
{
mId = objDataNodeDirectMapENS.mId, //mId
InDataNodeId = objDataNodeDirectMapENS.InDataNodeId, //In数据结点Id
OutDataNodeId = objDataNodeDirectMapENS.OutDataNodeId, //Out数据结点Id
AssociationMappingId = objDataNodeDirectMapENS.AssociationMappingId, //关联关系映射Id
FuncMapModeId = objDataNodeDirectMapENS.FuncMapModeId, //函数映射模式Id
TabId = objDataNodeDirectMapENS.TabId, //表ID
DnFunctionId = objDataNodeDirectMapENS.DnFunctionId, //DN函数Id
PrjId = objDataNodeDirectMapENS.PrjId, //工程Id
UpdDate = objDataNodeDirectMapENS.UpdDate, //修改日期
UpdUser = objDataNodeDirectMapENS.UpdUser, //修改者
Memo = objDataNodeDirectMapENS.Memo, //说明
};
 return objDataNodeDirectMapENT;
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
public static void CheckPropertyNew(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 clsDataNodeDirectMapBL.DataNodeDirectMapDA.CheckPropertyNew(objDataNodeDirectMapEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 clsDataNodeDirectMapBL.DataNodeDirectMapDA.CheckProperty4Condition(objDataNodeDirectMapEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeDirectMapEN objDataNodeDirectMapCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.mId) == true)
{
string strComparisonOpmId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNodeDirectMap.mId, objDataNodeDirectMapCond.mId, strComparisonOpmId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNodeDirectMap.InDataNodeId, objDataNodeDirectMapCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNodeDirectMap.OutDataNodeId, objDataNodeDirectMapCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.AssociationMappingId, objDataNodeDirectMapCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.FuncMapModeId, objDataNodeDirectMapCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.TabId) == true)
{
string strComparisonOpTabId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.TabId, objDataNodeDirectMapCond.TabId, strComparisonOpTabId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.DnFunctionId, objDataNodeDirectMapCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.PrjId) == true)
{
string strComparisonOpPrjId = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.PrjId, objDataNodeDirectMapCond.PrjId, strComparisonOpPrjId);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.UpdDate, objDataNodeDirectMapCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.UpdUser, objDataNodeDirectMapCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataNodeDirectMapCond.IsUpdated(conDataNodeDirectMap.Memo) == true)
{
string strComparisonOpMemo = objDataNodeDirectMapCond.dicFldComparisonOp[conDataNodeDirectMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeDirectMap.Memo, objDataNodeDirectMapCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DataNodeDirectMap(数据结点直接映射), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:InDataNodeId_OutDataNodeId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeDirectMapEN == null) return true;
if (objDataNodeDirectMapEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeDirectMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeDirectMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDataNodeDirectMapEN.PrjId);
if (clsDataNodeDirectMapBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDataNodeDirectMapEN.mId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeDirectMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeDirectMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDataNodeDirectMapEN.PrjId);
if (clsDataNodeDirectMapBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DataNodeDirectMap(数据结点直接映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:InDataNodeId_OutDataNodeId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeDirectMapEN == null) return "";
if (objDataNodeDirectMapEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeDirectMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeDirectMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDataNodeDirectMapEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDataNodeDirectMapEN.mId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeDirectMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeDirectMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDataNodeDirectMapEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataNodeDirectMap
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据结点直接映射(DataNodeDirectMap)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeDirectMapBL
{
public static RelatedActions_DataNodeDirectMap relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataNodeDirectMapDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataNodeDirectMapDA DataNodeDirectMapDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataNodeDirectMapDA();
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
 public clsDataNodeDirectMapBL()
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
if (string.IsNullOrEmpty(clsDataNodeDirectMapEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeDirectMapEN._ConnectString);
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
public static DataTable GetDataTable_DataNodeDirectMap(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataNodeDirectMapDA.GetDataTable_DataNodeDirectMap(strWhereCond);
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
objDT = DataNodeDirectMapDA.GetDataTable(strWhereCond);
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
objDT = DataNodeDirectMapDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataNodeDirectMapDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataNodeDirectMapDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataNodeDirectMapDA.GetDataTable_Top(objTopPara);
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
objDT = DataNodeDirectMapDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataNodeDirectMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataNodeDirectMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsDataNodeDirectMapEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
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
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataNodeDirectMapEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDataNodeDirectMapEN._CurrTabName, strPrjId);
List<clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLst_Sel =
arrDataNodeDirectMapObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrDataNodeDirectMapObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetObjLst(string strWhereCond)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
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
public static List<clsDataNodeDirectMapEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataNodeDirectMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataNodeDirectMapEN> GetSubObjLstCache(clsDataNodeDirectMapEN objDataNodeDirectMapCond)
{
 string strPrjId = objDataNodeDirectMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDataNodeDirectMapBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDataNodeDirectMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeDirectMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNodeDirectMap._AttributeName)
{
if (objDataNodeDirectMapCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeDirectMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeDirectMapCond[strFldName].ToString());
}
else
{
if (objDataNodeDirectMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeDirectMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeDirectMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeDirectMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeDirectMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeDirectMapCond[strFldName]));
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
public static List<clsDataNodeDirectMapEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
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
public static List<clsDataNodeDirectMapEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
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
List<clsDataNodeDirectMapEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataNodeDirectMapEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataNodeDirectMapEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
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
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
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
public static List<clsDataNodeDirectMapEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataNodeDirectMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
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
public static List<clsDataNodeDirectMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeDirectMapEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataNodeDirectMap(ref clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
bool bolResult = DataNodeDirectMapDA.GetDataNodeDirectMap(ref objDataNodeDirectMapEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeDirectMapEN GetObjBymId(long lngmId)
{
clsDataNodeDirectMapEN objDataNodeDirectMapEN = DataNodeDirectMapDA.GetObjBymId(lngmId);
return objDataNodeDirectMapEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataNodeDirectMapEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataNodeDirectMapEN objDataNodeDirectMapEN = DataNodeDirectMapDA.GetFirstObj(strWhereCond);
 return objDataNodeDirectMapEN;
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
public static clsDataNodeDirectMapEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataNodeDirectMapEN objDataNodeDirectMapEN = DataNodeDirectMapDA.GetObjByDataRow(objRow);
 return objDataNodeDirectMapEN;
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
public static clsDataNodeDirectMapEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataNodeDirectMapEN objDataNodeDirectMapEN = DataNodeDirectMapDA.GetObjByDataRow(objRow);
 return objDataNodeDirectMapEN;
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
 /// <param name = "lstDataNodeDirectMapObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeDirectMapEN GetObjBymIdFromList(long lngmId, List<clsDataNodeDirectMapEN> lstDataNodeDirectMapObjLst)
{
foreach (clsDataNodeDirectMapEN objDataNodeDirectMapEN in lstDataNodeDirectMapObjLst)
{
if (objDataNodeDirectMapEN.mId == lngmId)
{
return objDataNodeDirectMapEN;
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
 lngmId = new clsDataNodeDirectMapDA().GetFirstID(strWhereCond);
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
 arrList = DataNodeDirectMapDA.GetID(strWhereCond);
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
bool bolIsExist = DataNodeDirectMapDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = DataNodeDirectMapDA.IsExist(lngmId);
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
clsDataNodeDirectMapEN objDataNodeDirectMapEN = clsDataNodeDirectMapBL.GetObjBymId(lngmId);
objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDataNodeDirectMapEN.UpdUser = strOpUser;
return clsDataNodeDirectMapBL.UpdateBySql2(objDataNodeDirectMapEN);
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
 bolIsExist = clsDataNodeDirectMapDA.IsExistTable();
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
 bolIsExist = DataNodeDirectMapDA.IsExistTable(strTabName);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataNodeDirectMapEN objDataNodeDirectMapEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeDirectMapEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}],工程Id = [{2}]的数据已经存在!(in clsDataNodeDirectMapBL.AddNewRecordBySql2)", objDataNodeDirectMapEN.InDataNodeId,objDataNodeDirectMapEN.OutDataNodeId,objDataNodeDirectMapEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = DataNodeDirectMapDA.AddNewRecordBySQL2(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataNodeDirectMapEN objDataNodeDirectMapEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeDirectMapEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!In数据结点Id = [{0}],Out数据结点Id = [{1}],工程Id = [{2}]的数据已经存在!(in clsDataNodeDirectMapBL.AddNewRecordBySql2WithReturnKey)", objDataNodeDirectMapEN.InDataNodeId,objDataNodeDirectMapEN.OutDataNodeId,objDataNodeDirectMapEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = DataNodeDirectMapDA.AddNewRecordBySQL2WithReturnKey(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
try
{
bool bolResult = DataNodeDirectMapDA.Update(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 if (objDataNodeDirectMapEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataNodeDirectMapDA.UpdateBySql2(objDataNodeDirectMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeDirectMapBL.ReFreshCache(objDataNodeDirectMapEN.PrjId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
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
 clsDataNodeDirectMapEN objDataNodeDirectMapEN = clsDataNodeDirectMapBL.GetObjBymId(lngmId);

if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(objDataNodeDirectMapEN.mId, objDataNodeDirectMapEN.UpdUser);
}
if (objDataNodeDirectMapEN != null)
{
int intRecNum = DataNodeDirectMapDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDataNodeDirectMapEN.PrjId);
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
objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
//删除与表:[DataNodeDirectMap]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataNodeDirectMap.mId,
//lngmId);
//        clsDataNodeDirectMapBL.DelDataNodeDirectMapsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeDirectMapBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeDirectMapBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsDataNodeDirectMapBL.relatedActions != null)
{
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = DataNodeDirectMapDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelDataNodeDirectMaps(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsDataNodeDirectMapBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsDataNodeDirectMapEN objDataNodeDirectMapEN = clsDataNodeDirectMapBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = DataNodeDirectMapDA.DelDataNodeDirectMap(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDataNodeDirectMapEN.PrjId);
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
public static int DelDataNodeDirectMapsByCond(string strWhereCond)
{
try
{
if (clsDataNodeDirectMapBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsDataNodeDirectMapBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDataNodeDirectMap.PrjId, strWhereCond);
int intRecNum = DataNodeDirectMapDA.DelDataNodeDirectMap(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataNodeDirectMap]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
//删除与表:[DataNodeDirectMap]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeDirectMapBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeDirectMapBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objDataNodeDirectMapENS">源对象</param>
 /// <param name = "objDataNodeDirectMapENT">目标对象</param>
 public static void CopyTo(clsDataNodeDirectMapEN objDataNodeDirectMapENS, clsDataNodeDirectMapEN objDataNodeDirectMapENT)
{
try
{
objDataNodeDirectMapENT.mId = objDataNodeDirectMapENS.mId; //mId
objDataNodeDirectMapENT.InDataNodeId = objDataNodeDirectMapENS.InDataNodeId; //In数据结点Id
objDataNodeDirectMapENT.OutDataNodeId = objDataNodeDirectMapENS.OutDataNodeId; //Out数据结点Id
objDataNodeDirectMapENT.AssociationMappingId = objDataNodeDirectMapENS.AssociationMappingId; //关联关系映射Id
objDataNodeDirectMapENT.FuncMapModeId = objDataNodeDirectMapENS.FuncMapModeId; //函数映射模式Id
objDataNodeDirectMapENT.TabId = objDataNodeDirectMapENS.TabId; //表ID
objDataNodeDirectMapENT.DnFunctionId = objDataNodeDirectMapENS.DnFunctionId; //DN函数Id
objDataNodeDirectMapENT.PrjId = objDataNodeDirectMapENS.PrjId; //工程Id
objDataNodeDirectMapENT.UpdDate = objDataNodeDirectMapENS.UpdDate; //修改日期
objDataNodeDirectMapENT.UpdUser = objDataNodeDirectMapENS.UpdUser; //修改者
objDataNodeDirectMapENT.Memo = objDataNodeDirectMapENS.Memo; //说明
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
 /// <param name = "objDataNodeDirectMapEN">源简化对象</param>
 public static void SetUpdFlag(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
try
{
objDataNodeDirectMapEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataNodeDirectMapEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataNodeDirectMap.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.mId = objDataNodeDirectMapEN.mId; //mId
}
if (arrFldSet.Contains(conDataNodeDirectMap.InDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.InDataNodeId = objDataNodeDirectMapEN.InDataNodeId; //In数据结点Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.OutDataNodeId = objDataNodeDirectMapEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.AssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.FuncMapModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.FuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId; //函数映射模式Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.TabId = objDataNodeDirectMapEN.TabId == "[null]" ? null :  objDataNodeDirectMapEN.TabId; //表ID
}
if (arrFldSet.Contains(conDataNodeDirectMap.DnFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.DnFunctionId = objDataNodeDirectMapEN.DnFunctionId == "[null]" ? null :  objDataNodeDirectMapEN.DnFunctionId; //DN函数Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.PrjId = objDataNodeDirectMapEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDataNodeDirectMap.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.UpdDate = objDataNodeDirectMapEN.UpdDate == "[null]" ? null :  objDataNodeDirectMapEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDataNodeDirectMap.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.UpdUser = objDataNodeDirectMapEN.UpdUser == "[null]" ? null :  objDataNodeDirectMapEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDataNodeDirectMap.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeDirectMapEN.Memo = objDataNodeDirectMapEN.Memo == "[null]" ? null :  objDataNodeDirectMapEN.Memo; //说明
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
 /// <param name = "objDataNodeDirectMapEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
try
{
if (objDataNodeDirectMapEN.TabId == "[null]") objDataNodeDirectMapEN.TabId = null; //表ID
if (objDataNodeDirectMapEN.DnFunctionId == "[null]") objDataNodeDirectMapEN.DnFunctionId = null; //DN函数Id
if (objDataNodeDirectMapEN.UpdDate == "[null]") objDataNodeDirectMapEN.UpdDate = null; //修改日期
if (objDataNodeDirectMapEN.UpdUser == "[null]") objDataNodeDirectMapEN.UpdUser = null; //修改者
if (objDataNodeDirectMapEN.Memo == "[null]") objDataNodeDirectMapEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 DataNodeDirectMapDA.CheckPropertyNew(objDataNodeDirectMapEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 DataNodeDirectMapDA.CheckProperty4Condition(objDataNodeDirectMapEN);
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
if (clsDataNodeDirectMapBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeDirectMapBL没有刷新缓存机制(clsDataNodeDirectMapBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDataNodeDirectMapObjLstCache == null)
//{
//arrDataNodeDirectMapObjLstCache = DataNodeDirectMapDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeDirectMapEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDataNodeDirectMapEN._CurrTabName, strPrjId);
List<clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLst_Sel =
arrDataNodeDirectMapObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrDataNodeDirectMapObjLst_Sel.Count() == 0)
{
   clsDataNodeDirectMapEN obj = clsDataNodeDirectMapBL.GetObjBymId(lngmId);
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
return arrDataNodeDirectMapObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetAllDataNodeDirectMapObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLstCache = GetObjLstCache(strPrjId); 
return arrDataNodeDirectMapObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeDirectMapEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDataNodeDirectMapEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDataNodeDirectMapEN> arrDataNodeDirectMapObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDataNodeDirectMapObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDataNodeDirectMapEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDataNodeDirectMapEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDataNodeDirectMapEN._RefreshTimeLst.Count == 0) return "";
return clsDataNodeDirectMapEN._RefreshTimeLst[clsDataNodeDirectMapEN._RefreshTimeLst.Count - 1];
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
if (clsDataNodeDirectMapBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDataNodeDirectMapEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDataNodeDirectMapEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDataNodeDirectMapBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DataNodeDirectMap(数据结点直接映射)
 /// 唯一性条件:InDataNodeId_OutDataNodeId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检测记录是否存在
string strResult = DataNodeDirectMapDA.GetUniCondStr(objDataNodeDirectMapEN);
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
if (strInFldName != conDataNodeDirectMap.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataNodeDirectMap._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataNodeDirectMap._AttributeName));
throw new Exception(strMsg);
}
var objDataNodeDirectMap = clsDataNodeDirectMapBL.GetObjBymIdCache(lngmId, strPrjId);
if (objDataNodeDirectMap == null) return "";
return objDataNodeDirectMap[strOutFldName].ToString();
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
int intRecCount = clsDataNodeDirectMapDA.GetRecCount(strTabName);
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
int intRecCount = clsDataNodeDirectMapDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataNodeDirectMapDA.GetRecCount();
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
int intRecCount = clsDataNodeDirectMapDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataNodeDirectMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataNodeDirectMapEN objDataNodeDirectMapCond)
{
 string strPrjId = objDataNodeDirectMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDataNodeDirectMapBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDataNodeDirectMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeDirectMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNodeDirectMap._AttributeName)
{
if (objDataNodeDirectMapCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeDirectMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeDirectMapCond[strFldName].ToString());
}
else
{
if (objDataNodeDirectMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeDirectMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeDirectMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeDirectMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeDirectMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeDirectMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeDirectMapCond[strFldName]));
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
 List<string> arrList = clsDataNodeDirectMapDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataNodeDirectMapDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataNodeDirectMapDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataNodeDirectMapDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeDirectMapDA.SetFldValue(clsDataNodeDirectMapEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataNodeDirectMapDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeDirectMapDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeDirectMapDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeDirectMapDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataNodeDirectMap] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
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
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据结点直接映射(DataNodeDirectMap)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataNodeDirectMap : clsCommFun4BLV2
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
clsDataNodeDirectMapBL.ReFreshThisCache(strPrjId);
}
}

}