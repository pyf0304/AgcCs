
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationEdgeBL
 表名:UiFileRelationEdge(00050652)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsUiFileRelationEdgeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngEdgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationEdgeEN GetObj(this K_EdgeId_UiFileRelationEdge myKey)
{
clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.GetObjByEdgeId(myKey.Value);
return objUiFileRelationEdgeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationEdgeEN) == false)
{
var strMsg = string.Format("记录已经存在!FromNodeId = [{0}],ToNodeId = [{1}]的数据已经存在!(in clsUiFileRelationEdgeBL.AddNewRecord)", objUiFileRelationEdgeEN.FromNodeId,objUiFileRelationEdgeEN.ToNodeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.AddNewRecordBySQL2(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsNeedCheckUniqueness = true)
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
objUiFileRelationEdgeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUiFileRelationEdgeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(FromNodeId(FromNodeId)=[{0}],ToNodeId(ToNodeId)=[{1}])已经存在,不能重复!", objUiFileRelationEdgeEN.FromNodeId, objUiFileRelationEdgeEN.ToNodeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUiFileRelationEdgeEN.AddNewRecord();
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationEdgeEN) == false)
{
var strMsg = string.Format("记录已经存在!FromNodeId = [{0}],ToNodeId = [{1}]的数据已经存在!(in clsUiFileRelationEdgeBL.AddNewRecordWithReturnKey)", objUiFileRelationEdgeEN.FromNodeId,objUiFileRelationEdgeEN.ToNodeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetEdgeId(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, long lngEdgeId, string strComparisonOp="")
	{
objUiFileRelationEdgeEN.EdgeId = lngEdgeId; //EdgeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.EdgeId) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.EdgeId, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.EdgeId] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetTaskId(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, long lngTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTaskId, conUiFileRelationEdge.TaskId);
objUiFileRelationEdgeEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.TaskId) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.TaskId, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.TaskId] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetFromNodeId(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, long lngFromNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFromNodeId, conUiFileRelationEdge.FromNodeId);
objUiFileRelationEdgeEN.FromNodeId = lngFromNodeId; //FromNodeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.FromNodeId) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.FromNodeId, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.FromNodeId] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetToNodeId(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, long lngToNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngToNodeId, conUiFileRelationEdge.ToNodeId);
objUiFileRelationEdgeEN.ToNodeId = lngToNodeId; //ToNodeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.ToNodeId) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.ToNodeId, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.ToNodeId] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetEdgeType(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, string strEdgeType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEdgeType, conUiFileRelationEdge.EdgeType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEdgeType, 30, conUiFileRelationEdge.EdgeType);
}
objUiFileRelationEdgeEN.EdgeType = strEdgeType; //EdgeType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.EdgeType) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.EdgeType, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.EdgeType] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetDepth(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, int? intDepth, string strComparisonOp="")
	{
objUiFileRelationEdgeEN.Depth = intDepth; //深度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.Depth) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.Depth, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.Depth] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetRelationText(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, string strRelationText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationText, 400, conUiFileRelationEdge.RelationText);
}
objUiFileRelationEdgeEN.RelationText = strRelationText; //RelationText
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.RelationText) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.RelationText, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.RelationText] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetIsRecursive(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsRecursive, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRecursive, conUiFileRelationEdge.IsRecursive);
objUiFileRelationEdgeEN.IsRecursive = bolIsRecursive; //IsRecursive
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.IsRecursive) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.IsRecursive, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.IsRecursive] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationEdgeEN SetExtraJson(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, string strExtraJson, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtraJson, 2147483646, conUiFileRelationEdge.ExtraJson);
}
objUiFileRelationEdgeEN.ExtraJson = strExtraJson; //ExtraJson
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationEdgeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationEdge.ExtraJson) == false)
{
objUiFileRelationEdgeEN.dicFldComparisonOp.Add(conUiFileRelationEdge.ExtraJson, strComparisonOp);
}
else
{
objUiFileRelationEdgeEN.dicFldComparisonOp[conUiFileRelationEdge.ExtraJson] = strComparisonOp;
}
}
return objUiFileRelationEdgeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUiFileRelationEdgeEN.CheckPropertyNew();
clsUiFileRelationEdgeEN objUiFileRelationEdgeCond = new clsUiFileRelationEdgeEN();
string strCondition = objUiFileRelationEdgeCond
.SetEdgeId(objUiFileRelationEdgeEN.EdgeId, "<>")
.SetFromNodeId(objUiFileRelationEdgeEN.FromNodeId, "=")
.SetToNodeId(objUiFileRelationEdgeEN.ToNodeId, "=")
.GetCombineCondition();
objUiFileRelationEdgeEN._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationEdgeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUiFileRelationEdgeEN.Update();
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
 /// <param name = "objUiFileRelationEdge">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUiFileRelationEdgeEN objUiFileRelationEdge)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUiFileRelationEdgeEN objUiFileRelationEdgeCond = new clsUiFileRelationEdgeEN();
string strCondition = objUiFileRelationEdgeCond
.SetFromNodeId(objUiFileRelationEdge.FromNodeId, "=")
.SetToNodeId(objUiFileRelationEdge.ToNodeId, "=")
.GetCombineCondition();
objUiFileRelationEdge._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationEdgeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUiFileRelationEdge.EdgeId = clsUiFileRelationEdgeBL.GetFirstID_S(strCondition);
objUiFileRelationEdge.UpdateWithCondition(strCondition);
}
else
{
objUiFileRelationEdge.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 if (objUiFileRelationEdgeEN.EdgeId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.UpdateBySql2(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationEdgeEN.EdgeId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.UpdateBySql2(objUiFileRelationEdgeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, string strWhereCond)
{
try
{
bool bolResult = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.UpdateBySqlWithCondition(objUiFileRelationEdgeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.UpdateBySqlWithConditionTransaction(objUiFileRelationEdgeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "lngEdgeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
try
{
int intRecNum = clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.DelRecord(objUiFileRelationEdgeEN.EdgeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeENS">源对象</param>
 /// <param name = "objUiFileRelationEdgeENT">目标对象</param>
 public static void CopyTo(this clsUiFileRelationEdgeEN objUiFileRelationEdgeENS, clsUiFileRelationEdgeEN objUiFileRelationEdgeENT)
{
try
{
objUiFileRelationEdgeENT.EdgeId = objUiFileRelationEdgeENS.EdgeId; //EdgeId
objUiFileRelationEdgeENT.TaskId = objUiFileRelationEdgeENS.TaskId; //TaskId
objUiFileRelationEdgeENT.FromNodeId = objUiFileRelationEdgeENS.FromNodeId; //FromNodeId
objUiFileRelationEdgeENT.ToNodeId = objUiFileRelationEdgeENS.ToNodeId; //ToNodeId
objUiFileRelationEdgeENT.EdgeType = objUiFileRelationEdgeENS.EdgeType; //EdgeType
objUiFileRelationEdgeENT.Depth = objUiFileRelationEdgeENS.Depth; //深度
objUiFileRelationEdgeENT.RelationText = objUiFileRelationEdgeENS.RelationText; //RelationText
objUiFileRelationEdgeENT.IsRecursive = objUiFileRelationEdgeENS.IsRecursive; //IsRecursive
objUiFileRelationEdgeENT.ExtraJson = objUiFileRelationEdgeENS.ExtraJson; //ExtraJson
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
 /// <param name = "objUiFileRelationEdgeENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationEdgeEN:objUiFileRelationEdgeENT</returns>
 public static clsUiFileRelationEdgeEN CopyTo(this clsUiFileRelationEdgeEN objUiFileRelationEdgeENS)
{
try
{
 clsUiFileRelationEdgeEN objUiFileRelationEdgeENT = new clsUiFileRelationEdgeEN()
{
EdgeId = objUiFileRelationEdgeENS.EdgeId, //EdgeId
TaskId = objUiFileRelationEdgeENS.TaskId, //TaskId
FromNodeId = objUiFileRelationEdgeENS.FromNodeId, //FromNodeId
ToNodeId = objUiFileRelationEdgeENS.ToNodeId, //ToNodeId
EdgeType = objUiFileRelationEdgeENS.EdgeType, //EdgeType
Depth = objUiFileRelationEdgeENS.Depth, //深度
RelationText = objUiFileRelationEdgeENS.RelationText, //RelationText
IsRecursive = objUiFileRelationEdgeENS.IsRecursive, //IsRecursive
ExtraJson = objUiFileRelationEdgeENS.ExtraJson, //ExtraJson
};
 return objUiFileRelationEdgeENT;
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
public static void CheckPropertyNew(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.CheckPropertyNew(objUiFileRelationEdgeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 clsUiFileRelationEdgeBL.UiFileRelationEdgeDA.CheckProperty4Condition(objUiFileRelationEdgeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUiFileRelationEdgeEN objUiFileRelationEdgeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.EdgeId) == true)
{
string strComparisonOpEdgeId = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.EdgeId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationEdge.EdgeId, objUiFileRelationEdgeCond.EdgeId, strComparisonOpEdgeId);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.TaskId) == true)
{
string strComparisonOpTaskId = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationEdge.TaskId, objUiFileRelationEdgeCond.TaskId, strComparisonOpTaskId);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.FromNodeId) == true)
{
string strComparisonOpFromNodeId = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.FromNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationEdge.FromNodeId, objUiFileRelationEdgeCond.FromNodeId, strComparisonOpFromNodeId);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.ToNodeId) == true)
{
string strComparisonOpToNodeId = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.ToNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationEdge.ToNodeId, objUiFileRelationEdgeCond.ToNodeId, strComparisonOpToNodeId);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.EdgeType) == true)
{
string strComparisonOpEdgeType = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.EdgeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationEdge.EdgeType, objUiFileRelationEdgeCond.EdgeType, strComparisonOpEdgeType);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.Depth) == true)
{
string strComparisonOpDepth = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.Depth];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationEdge.Depth, objUiFileRelationEdgeCond.Depth, strComparisonOpDepth);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.RelationText) == true)
{
string strComparisonOpRelationText = objUiFileRelationEdgeCond.dicFldComparisonOp[conUiFileRelationEdge.RelationText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationEdge.RelationText, objUiFileRelationEdgeCond.RelationText, strComparisonOpRelationText);
}
if (objUiFileRelationEdgeCond.IsUpdated(conUiFileRelationEdge.IsRecursive) == true)
{
if (objUiFileRelationEdgeCond.IsRecursive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUiFileRelationEdge.IsRecursive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUiFileRelationEdge.IsRecursive);
}
}
//数据类型string(ntext)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UiFileRelationEdge(UiFileRelationEdge), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FromNodeId_ToNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationEdgeEN == null) return true;
if (objUiFileRelationEdgeEN.EdgeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FromNodeId = '{0}'", objUiFileRelationEdgeEN.FromNodeId);
 sbCondition.AppendFormat(" and ToNodeId = '{0}'", objUiFileRelationEdgeEN.ToNodeId);
if (clsUiFileRelationEdgeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("EdgeId !=  {0}", objUiFileRelationEdgeEN.EdgeId);
 sbCondition.AppendFormat(" and FromNodeId = '{0}'", objUiFileRelationEdgeEN.FromNodeId);
 sbCondition.AppendFormat(" and ToNodeId = '{0}'", objUiFileRelationEdgeEN.ToNodeId);
if (clsUiFileRelationEdgeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UiFileRelationEdge(UiFileRelationEdge), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FromNodeId_ToNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationEdgeEN == null) return "";
if (objUiFileRelationEdgeEN.EdgeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FromNodeId = '{0}'", objUiFileRelationEdgeEN.FromNodeId);
 sbCondition.AppendFormat(" and ToNodeId = '{0}'", objUiFileRelationEdgeEN.ToNodeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("EdgeId !=  {0}", objUiFileRelationEdgeEN.EdgeId);
 sbCondition.AppendFormat(" and FromNodeId = '{0}'", objUiFileRelationEdgeEN.FromNodeId);
 sbCondition.AppendFormat(" and ToNodeId = '{0}'", objUiFileRelationEdgeEN.ToNodeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UiFileRelationEdge
{
public virtual bool UpdRelaTabDate(long lngEdgeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// UiFileRelationEdge(UiFileRelationEdge)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUiFileRelationEdgeBL
{
public static RelatedActions_UiFileRelationEdge relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUiFileRelationEdgeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUiFileRelationEdgeDA UiFileRelationEdgeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUiFileRelationEdgeDA();
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
 public clsUiFileRelationEdgeBL()
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
if (string.IsNullOrEmpty(clsUiFileRelationEdgeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationEdgeEN._ConnectString);
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
public static DataTable GetDataTable_UiFileRelationEdge(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UiFileRelationEdgeDA.GetDataTable_UiFileRelationEdge(strWhereCond);
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
objDT = UiFileRelationEdgeDA.GetDataTable(strWhereCond);
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
objDT = UiFileRelationEdgeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UiFileRelationEdgeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UiFileRelationEdgeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UiFileRelationEdgeDA.GetDataTable_Top(objTopPara);
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
objDT = UiFileRelationEdgeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UiFileRelationEdgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UiFileRelationEdgeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrEdgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetObjLstByEdgeIdLst(List<long> arrEdgeIdLst)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrEdgeIdLst);
 string strWhereCond = string.Format("EdgeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrEdgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUiFileRelationEdgeEN> GetObjLstByEdgeIdLstCache(List<long> arrEdgeIdLst)
{
string strKey = string.Format("{0}", clsUiFileRelationEdgeEN._CurrTabName);
List<clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLst_Sel =
arrUiFileRelationEdgeObjLstCache
.Where(x => arrEdgeIdLst.Contains(x.EdgeId));
return arrUiFileRelationEdgeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetObjLst(string strWhereCond)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
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
public static List<clsUiFileRelationEdgeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUiFileRelationEdgeEN> GetSubObjLstCache(clsUiFileRelationEdgeEN objUiFileRelationEdgeCond)
{
List<clsUiFileRelationEdgeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationEdgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationEdge._AttributeName)
{
if (objUiFileRelationEdgeCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationEdgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationEdgeCond[strFldName].ToString());
}
else
{
if (objUiFileRelationEdgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationEdgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationEdgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationEdgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationEdgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationEdgeCond[strFldName]));
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
public static List<clsUiFileRelationEdgeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
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
public static List<clsUiFileRelationEdgeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
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
List<clsUiFileRelationEdgeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUiFileRelationEdgeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUiFileRelationEdgeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
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
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
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
public static List<clsUiFileRelationEdgeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUiFileRelationEdgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
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
public static List<clsUiFileRelationEdgeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUiFileRelationEdgeEN> arrObjLst = new List<clsUiFileRelationEdgeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = new clsUiFileRelationEdgeEN();
try
{
objUiFileRelationEdgeEN.EdgeId = Int32.Parse(objRow[conUiFileRelationEdge.EdgeId].ToString().Trim()); //EdgeId
objUiFileRelationEdgeEN.TaskId = Int32.Parse(objRow[conUiFileRelationEdge.TaskId].ToString().Trim()); //TaskId
objUiFileRelationEdgeEN.FromNodeId = Int32.Parse(objRow[conUiFileRelationEdge.FromNodeId].ToString().Trim()); //FromNodeId
objUiFileRelationEdgeEN.ToNodeId = Int32.Parse(objRow[conUiFileRelationEdge.ToNodeId].ToString().Trim()); //ToNodeId
objUiFileRelationEdgeEN.EdgeType = objRow[conUiFileRelationEdge.EdgeType].ToString().Trim(); //EdgeType
objUiFileRelationEdgeEN.Depth = objRow[conUiFileRelationEdge.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationEdge.Depth].ToString().Trim()); //深度
objUiFileRelationEdgeEN.RelationText = objRow[conUiFileRelationEdge.RelationText] == DBNull.Value ? null : objRow[conUiFileRelationEdge.RelationText].ToString().Trim(); //RelationText
objUiFileRelationEdgeEN.IsRecursive = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationEdge.IsRecursive].ToString().Trim()); //IsRecursive
objUiFileRelationEdgeEN.ExtraJson = objRow[conUiFileRelationEdge.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationEdge.ExtraJson].ToString().Trim(); //ExtraJson
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationEdgeEN.EdgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationEdgeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUiFileRelationEdge(ref clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
bool bolResult = UiFileRelationEdgeDA.GetUiFileRelationEdge(ref objUiFileRelationEdgeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngEdgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationEdgeEN GetObjByEdgeId(long lngEdgeId)
{
clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = UiFileRelationEdgeDA.GetObjByEdgeId(lngEdgeId);
return objUiFileRelationEdgeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUiFileRelationEdgeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = UiFileRelationEdgeDA.GetFirstObj(strWhereCond);
 return objUiFileRelationEdgeEN;
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
public static clsUiFileRelationEdgeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = UiFileRelationEdgeDA.GetObjByDataRow(objRow);
 return objUiFileRelationEdgeEN;
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
public static clsUiFileRelationEdgeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = UiFileRelationEdgeDA.GetObjByDataRow(objRow);
 return objUiFileRelationEdgeEN;
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
 /// <param name = "lngEdgeId">所给的关键字</param>
 /// <param name = "lstUiFileRelationEdgeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationEdgeEN GetObjByEdgeIdFromList(long lngEdgeId, List<clsUiFileRelationEdgeEN> lstUiFileRelationEdgeObjLst)
{
foreach (clsUiFileRelationEdgeEN objUiFileRelationEdgeEN in lstUiFileRelationEdgeObjLst)
{
if (objUiFileRelationEdgeEN.EdgeId == lngEdgeId)
{
return objUiFileRelationEdgeEN;
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
 long lngEdgeId;
 try
 {
 lngEdgeId = new clsUiFileRelationEdgeDA().GetFirstID(strWhereCond);
 return lngEdgeId;
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
 arrList = UiFileRelationEdgeDA.GetID(strWhereCond);
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
bool bolIsExist = UiFileRelationEdgeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngEdgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngEdgeId)
{
//检测记录是否存在
bool bolIsExist = UiFileRelationEdgeDA.IsExist(lngEdgeId);
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
 bolIsExist = clsUiFileRelationEdgeDA.IsExistTable();
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
 bolIsExist = UiFileRelationEdgeDA.IsExistTable(strTabName);
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationEdgeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FromNodeId = [{0}],ToNodeId = [{1}]的数据已经存在!(in clsUiFileRelationEdgeBL.AddNewRecordBySql2)", objUiFileRelationEdgeEN.FromNodeId,objUiFileRelationEdgeEN.ToNodeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = UiFileRelationEdgeDA.AddNewRecordBySQL2(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationEdgeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FromNodeId = [{0}],ToNodeId = [{1}]的数据已经存在!(in clsUiFileRelationEdgeBL.AddNewRecordBySql2WithReturnKey)", objUiFileRelationEdgeEN.FromNodeId,objUiFileRelationEdgeEN.ToNodeId);
throw new Exception(strMsg);
}
try
{
string strKey = UiFileRelationEdgeDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
try
{
bool bolResult = UiFileRelationEdgeDA.Update(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationEdgeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 if (objUiFileRelationEdgeEN.EdgeId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UiFileRelationEdgeDA.UpdateBySql2(objUiFileRelationEdgeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationEdgeBL.ReFreshCache();

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
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
 /// <param name = "lngEdgeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngEdgeId)
{
try
{
 clsUiFileRelationEdgeEN objUiFileRelationEdgeEN = clsUiFileRelationEdgeBL.GetObjByEdgeId(lngEdgeId);

if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(objUiFileRelationEdgeEN.EdgeId, "SetUpdDate");
}
if (objUiFileRelationEdgeEN != null)
{
int intRecNum = UiFileRelationEdgeDA.DelRecord(lngEdgeId);
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
/// <param name="lngEdgeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngEdgeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationEdgeDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationEdge]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUiFileRelationEdge.EdgeId,
//lngEdgeId);
//        clsUiFileRelationEdgeBL.DelUiFileRelationEdgesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationEdgeBL.DelRecord(lngEdgeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationEdgeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngEdgeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngEdgeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngEdgeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUiFileRelationEdgeBL.relatedActions != null)
{
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(lngEdgeId, "UpdRelaTabDate");
}
bool bolResult = UiFileRelationEdgeDA.DelRecord(lngEdgeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrEdgeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUiFileRelationEdges(List<string> arrEdgeIdLst)
{
if (arrEdgeIdLst.Count == 0) return 0;
try
{
if (clsUiFileRelationEdgeBL.relatedActions != null)
{
foreach (var strEdgeId in arrEdgeIdLst)
{
long lngEdgeId = long.Parse(strEdgeId);
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(lngEdgeId, "UpdRelaTabDate");
}
}
int intDelRecNum = UiFileRelationEdgeDA.DelUiFileRelationEdge(arrEdgeIdLst);
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
public static int DelUiFileRelationEdgesByCond(string strWhereCond)
{
try
{
if (clsUiFileRelationEdgeBL.relatedActions != null)
{
List<string> arrEdgeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strEdgeId in arrEdgeId)
{
long lngEdgeId = long.Parse(strEdgeId);
clsUiFileRelationEdgeBL.relatedActions.UpdRelaTabDate(lngEdgeId, "UpdRelaTabDate");
}
}
int intRecNum = UiFileRelationEdgeDA.DelUiFileRelationEdge(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UiFileRelationEdge]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngEdgeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngEdgeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationEdgeDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationEdge]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationEdgeBL.DelRecord(lngEdgeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationEdgeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngEdgeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUiFileRelationEdgeENS">源对象</param>
 /// <param name = "objUiFileRelationEdgeENT">目标对象</param>
 public static void CopyTo(clsUiFileRelationEdgeEN objUiFileRelationEdgeENS, clsUiFileRelationEdgeEN objUiFileRelationEdgeENT)
{
try
{
objUiFileRelationEdgeENT.EdgeId = objUiFileRelationEdgeENS.EdgeId; //EdgeId
objUiFileRelationEdgeENT.TaskId = objUiFileRelationEdgeENS.TaskId; //TaskId
objUiFileRelationEdgeENT.FromNodeId = objUiFileRelationEdgeENS.FromNodeId; //FromNodeId
objUiFileRelationEdgeENT.ToNodeId = objUiFileRelationEdgeENS.ToNodeId; //ToNodeId
objUiFileRelationEdgeENT.EdgeType = objUiFileRelationEdgeENS.EdgeType; //EdgeType
objUiFileRelationEdgeENT.Depth = objUiFileRelationEdgeENS.Depth; //深度
objUiFileRelationEdgeENT.RelationText = objUiFileRelationEdgeENS.RelationText; //RelationText
objUiFileRelationEdgeENT.IsRecursive = objUiFileRelationEdgeENS.IsRecursive; //IsRecursive
objUiFileRelationEdgeENT.ExtraJson = objUiFileRelationEdgeENS.ExtraJson; //ExtraJson
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
 /// <param name = "objUiFileRelationEdgeEN">源简化对象</param>
 public static void SetUpdFlag(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
try
{
objUiFileRelationEdgeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUiFileRelationEdgeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUiFileRelationEdge.EdgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.EdgeId = objUiFileRelationEdgeEN.EdgeId; //EdgeId
}
if (arrFldSet.Contains(conUiFileRelationEdge.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.TaskId = objUiFileRelationEdgeEN.TaskId; //TaskId
}
if (arrFldSet.Contains(conUiFileRelationEdge.FromNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.FromNodeId = objUiFileRelationEdgeEN.FromNodeId; //FromNodeId
}
if (arrFldSet.Contains(conUiFileRelationEdge.ToNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.ToNodeId = objUiFileRelationEdgeEN.ToNodeId; //ToNodeId
}
if (arrFldSet.Contains(conUiFileRelationEdge.EdgeType, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.EdgeType = objUiFileRelationEdgeEN.EdgeType; //EdgeType
}
if (arrFldSet.Contains(conUiFileRelationEdge.Depth, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.Depth = objUiFileRelationEdgeEN.Depth; //深度
}
if (arrFldSet.Contains(conUiFileRelationEdge.RelationText, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.RelationText = objUiFileRelationEdgeEN.RelationText == "[null]" ? null :  objUiFileRelationEdgeEN.RelationText; //RelationText
}
if (arrFldSet.Contains(conUiFileRelationEdge.IsRecursive, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.IsRecursive = objUiFileRelationEdgeEN.IsRecursive; //IsRecursive
}
if (arrFldSet.Contains(conUiFileRelationEdge.ExtraJson, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationEdgeEN.ExtraJson = objUiFileRelationEdgeEN.ExtraJson == "[null]" ? null :  objUiFileRelationEdgeEN.ExtraJson; //ExtraJson
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
 /// <param name = "objUiFileRelationEdgeEN">源简化对象</param>
 public static void AccessFldValueNull(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
try
{
if (objUiFileRelationEdgeEN.RelationText == "[null]") objUiFileRelationEdgeEN.RelationText = null; //RelationText
if (objUiFileRelationEdgeEN.ExtraJson == "[null]") objUiFileRelationEdgeEN.ExtraJson = null; //ExtraJson
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
public static void CheckPropertyNew(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 UiFileRelationEdgeDA.CheckPropertyNew(objUiFileRelationEdgeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
 UiFileRelationEdgeDA.CheckProperty4Condition(objUiFileRelationEdgeEN);
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
if (clsUiFileRelationEdgeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUiFileRelationEdgeBL没有刷新缓存机制(clsUiFileRelationEdgeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by EdgeId");
//if (arrUiFileRelationEdgeObjLstCache == null)
//{
//arrUiFileRelationEdgeObjLstCache = UiFileRelationEdgeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngEdgeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationEdgeEN GetObjByEdgeIdCache(long lngEdgeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUiFileRelationEdgeEN._CurrTabName);
List<clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLst_Sel =
arrUiFileRelationEdgeObjLstCache
.Where(x=> x.EdgeId == lngEdgeId 
);
if (arrUiFileRelationEdgeObjLst_Sel.Count() == 0)
{
   clsUiFileRelationEdgeEN obj = clsUiFileRelationEdgeBL.GetObjByEdgeId(lngEdgeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUiFileRelationEdgeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetAllUiFileRelationEdgeObjLstCache()
{
//获取缓存中的对象列表
List<clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLstCache = GetObjLstCache(); 
return arrUiFileRelationEdgeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationEdgeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUiFileRelationEdgeEN._CurrTabName);
List<clsUiFileRelationEdgeEN> arrUiFileRelationEdgeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUiFileRelationEdgeObjLstCache;
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
string strKey = string.Format("{0}", clsUiFileRelationEdgeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationEdgeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUiFileRelationEdgeEN._RefreshTimeLst.Count == 0) return "";
return clsUiFileRelationEdgeEN._RefreshTimeLst[clsUiFileRelationEdgeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsUiFileRelationEdgeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUiFileRelationEdgeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationEdgeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUiFileRelationEdgeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UiFileRelationEdge(UiFileRelationEdge)
 /// 唯一性条件:FromNodeId_ToNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUiFileRelationEdgeEN objUiFileRelationEdgeEN)
{
//检测记录是否存在
string strResult = UiFileRelationEdgeDA.GetUniCondStr(objUiFileRelationEdgeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-07-21
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngEdgeId)
{
if (strInFldName != conUiFileRelationEdge.EdgeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUiFileRelationEdge._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUiFileRelationEdge._AttributeName));
throw new Exception(strMsg);
}
var objUiFileRelationEdge = clsUiFileRelationEdgeBL.GetObjByEdgeIdCache(lngEdgeId);
if (objUiFileRelationEdge == null) return "";
return objUiFileRelationEdge[strOutFldName].ToString();
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
int intRecCount = clsUiFileRelationEdgeDA.GetRecCount(strTabName);
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
int intRecCount = clsUiFileRelationEdgeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUiFileRelationEdgeDA.GetRecCount();
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
int intRecCount = clsUiFileRelationEdgeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUiFileRelationEdgeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUiFileRelationEdgeEN objUiFileRelationEdgeCond)
{
List<clsUiFileRelationEdgeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationEdgeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationEdge._AttributeName)
{
if (objUiFileRelationEdgeCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationEdgeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationEdgeCond[strFldName].ToString());
}
else
{
if (objUiFileRelationEdgeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationEdgeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationEdgeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationEdgeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationEdgeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationEdgeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationEdgeCond[strFldName]));
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
 List<string> arrList = clsUiFileRelationEdgeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationEdgeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationEdgeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UiFileRelationEdgeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationEdgeDA.SetFldValue(clsUiFileRelationEdgeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UiFileRelationEdgeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationEdgeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationEdgeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationEdgeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UiFileRelationEdge] "); 
 strCreateTabCode.Append(" ( "); 
 // /**EdgeId*/ 
 strCreateTabCode.Append(" EdgeId bigint primary key identity, "); 
 // /**TaskId*/ 
 strCreateTabCode.Append(" TaskId bigint not Null, "); 
 // /**FromNodeId*/ 
 strCreateTabCode.Append(" FromNodeId bigint not Null, "); 
 // /**ToNodeId*/ 
 strCreateTabCode.Append(" ToNodeId bigint not Null, "); 
 // /**EdgeType*/ 
 strCreateTabCode.Append(" EdgeType varchar(30) not Null, "); 
 // /**深度*/ 
 strCreateTabCode.Append(" Depth int Null, "); 
 // /**RelationText*/ 
 strCreateTabCode.Append(" RelationText nvarchar(400) Null, "); 
 // /**IsRecursive*/ 
 strCreateTabCode.Append(" IsRecursive bit not Null, "); 
 // /**ExtraJson*/ 
 strCreateTabCode.Append(" ExtraJson ntext(2147483646) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// UiFileRelationEdge(UiFileRelationEdge)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UiFileRelationEdge : clsCommFun4BL
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
clsUiFileRelationEdgeBL.ReFreshThisCache();
}
}

}