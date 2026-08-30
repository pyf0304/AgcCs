
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationNodeBL
 表名:UiFileRelationNode(00050654)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:19
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
public static class  clsUiFileRelationNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationNodeEN GetObj(this K_NodeId_UiFileRelationNode myKey)
{
clsUiFileRelationNodeEN objUiFileRelationNodeEN = clsUiFileRelationNodeBL.UiFileRelationNodeDA.GetObjByNodeId(myKey.Value);
return objUiFileRelationNodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!FileId = [{0}],NodeId = [{1}],NodeType = [{2}]的数据已经存在!(in clsUiFileRelationNodeBL.AddNewRecord)", objUiFileRelationNodeEN.FileId,objUiFileRelationNodeEN.NodeId,objUiFileRelationNodeEN.NodeType);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUiFileRelationNodeBL.UiFileRelationNodeDA.AddNewRecordBySQL2(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, bool bolIsNeedCheckUniqueness = true)
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
objUiFileRelationNodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUiFileRelationNodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(FileId(FileId)=[{0}],NodeId(NodeId)=[{1}],NodeType(NodeType)=[{2}])已经存在,不能重复!", objUiFileRelationNodeEN.FileId, objUiFileRelationNodeEN.NodeId, objUiFileRelationNodeEN.NodeType);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUiFileRelationNodeEN.AddNewRecord();
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!FileId = [{0}],NodeId = [{1}],NodeType = [{2}]的数据已经存在!(in clsUiFileRelationNodeBL.AddNewRecordWithReturnKey)", objUiFileRelationNodeEN.FileId,objUiFileRelationNodeEN.NodeId,objUiFileRelationNodeEN.NodeType);
throw new Exception(strMsg);
}
try
{
string strKey = clsUiFileRelationNodeBL.UiFileRelationNodeDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetNodeId(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, long lngNodeId, string strComparisonOp="")
	{
objUiFileRelationNodeEN.NodeId = lngNodeId; //NodeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.NodeId) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.NodeId, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.NodeId] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetTaskId(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, long lngTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTaskId, conUiFileRelationNode.TaskId);
objUiFileRelationNodeEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.TaskId) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.TaskId, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.TaskId] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetFileId(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, long? lngFileId, string strComparisonOp="")
	{
objUiFileRelationNodeEN.FileId = lngFileId; //FileId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.FileId) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.FileId, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.FileId] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetNodeType(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strNodeType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNodeType, conUiFileRelationNode.NodeType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNodeType, 20, conUiFileRelationNode.NodeType);
}
objUiFileRelationNodeEN.NodeType = strNodeType; //NodeType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.NodeType) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.NodeType, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.NodeType] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetSymbolName(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolName, conUiFileRelationNode.SymbolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolName, 400, conUiFileRelationNode.SymbolName);
}
objUiFileRelationNodeEN.SymbolName = strSymbolName; //SymbolName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.SymbolName) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.SymbolName, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.SymbolName] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetSymbolKey(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strSymbolKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolKey, 600, conUiFileRelationNode.SymbolKey);
}
objUiFileRelationNodeEN.SymbolKey = strSymbolKey; //SymbolKey
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.SymbolKey) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.SymbolKey, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.SymbolKey] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetSourcePath(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strSourcePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourcePath, 1000, conUiFileRelationNode.SourcePath);
}
objUiFileRelationNodeEN.SourcePath = strSourcePath; //SourcePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.SourcePath) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.SourcePath, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.SourcePath] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetLineNo(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, int? intLineNo, string strComparisonOp="")
	{
objUiFileRelationNodeEN.LineNo = intLineNo; //LineNo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.LineNo) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.LineNo, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.LineNo] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetColumnNo(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, int? intColumnNo, string strComparisonOp="")
	{
objUiFileRelationNodeEN.ColumnNo = intColumnNo; //ColumnNo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.ColumnNo) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.ColumnNo, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.ColumnNo] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetLevelNo(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, int intLevelNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intLevelNo, conUiFileRelationNode.LevelNo);
objUiFileRelationNodeEN.LevelNo = intLevelNo; //层序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.LevelNo) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.LevelNo, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.LevelNo] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetParentNodeId(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, long? lngParentNodeId, string strComparisonOp="")
	{
objUiFileRelationNodeEN.ParentNodeId = lngParentNodeId; //ParentNodeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.ParentNodeId) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.ParentNodeId, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.ParentNodeId] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetExtraJson(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strExtraJson, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtraJson, 2147483646, conUiFileRelationNode.ExtraJson);
}
objUiFileRelationNodeEN.ExtraJson = strExtraJson; //ExtraJson
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.ExtraJson) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.ExtraJson, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.ExtraJson] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationNodeEN SetCreatedAt(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, DateTime dteCreatedAt, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteCreatedAt, conUiFileRelationNode.CreatedAt);
objUiFileRelationNodeEN.CreatedAt = dteCreatedAt; //CreatedAt
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationNodeEN.dicFldComparisonOp.ContainsKey(conUiFileRelationNode.CreatedAt) == false)
{
objUiFileRelationNodeEN.dicFldComparisonOp.Add(conUiFileRelationNode.CreatedAt, strComparisonOp);
}
else
{
objUiFileRelationNodeEN.dicFldComparisonOp[conUiFileRelationNode.CreatedAt] = strComparisonOp;
}
}
return objUiFileRelationNodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUiFileRelationNodeEN.CheckPropertyNew();
clsUiFileRelationNodeEN objUiFileRelationNodeCond = new clsUiFileRelationNodeEN();
string strCondition = objUiFileRelationNodeCond
.SetNodeId(objUiFileRelationNodeEN.NodeId, "<>")
.SetFileId(objUiFileRelationNodeEN.FileId, "=")
.SetNodeId(objUiFileRelationNodeEN.NodeId, "=")
.SetNodeType(objUiFileRelationNodeEN.NodeType, "=")
.GetCombineCondition();
objUiFileRelationNodeEN._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUiFileRelationNodeEN.Update();
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
 /// <param name = "objUiFileRelationNode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUiFileRelationNodeEN objUiFileRelationNode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUiFileRelationNodeEN objUiFileRelationNodeCond = new clsUiFileRelationNodeEN();
string strCondition = objUiFileRelationNodeCond
.SetFileId(objUiFileRelationNode.FileId, "=")
.SetNodeId(objUiFileRelationNode.NodeId, "=")
.SetNodeType(objUiFileRelationNode.NodeType, "=")
.GetCombineCondition();
objUiFileRelationNode._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUiFileRelationNode.NodeId = clsUiFileRelationNodeBL.GetFirstID_S(strCondition);
objUiFileRelationNode.UpdateWithCondition(strCondition);
}
else
{
objUiFileRelationNode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN.NodeId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationNodeBL.UiFileRelationNodeDA.UpdateBySql2(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationNodeEN.NodeId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationNodeBL.UiFileRelationNodeDA.UpdateBySql2(objUiFileRelationNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strWhereCond)
{
try
{
bool bolResult = clsUiFileRelationNodeBL.UiFileRelationNodeDA.UpdateBySqlWithCondition(objUiFileRelationNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUiFileRelationNodeBL.UiFileRelationNodeDA.UpdateBySqlWithConditionTransaction(objUiFileRelationNodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
try
{
int intRecNum = clsUiFileRelationNodeBL.UiFileRelationNodeDA.DelRecord(objUiFileRelationNodeEN.NodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <param name = "objUiFileRelationNodeENT">目标对象</param>
 public static void CopyTo(this clsUiFileRelationNodeEN objUiFileRelationNodeENS, clsUiFileRelationNodeEN objUiFileRelationNodeENT)
{
try
{
objUiFileRelationNodeENT.NodeId = objUiFileRelationNodeENS.NodeId; //NodeId
objUiFileRelationNodeENT.TaskId = objUiFileRelationNodeENS.TaskId; //TaskId
objUiFileRelationNodeENT.FileId = objUiFileRelationNodeENS.FileId; //FileId
objUiFileRelationNodeENT.NodeType = objUiFileRelationNodeENS.NodeType; //NodeType
objUiFileRelationNodeENT.SymbolName = objUiFileRelationNodeENS.SymbolName; //SymbolName
objUiFileRelationNodeENT.SymbolKey = objUiFileRelationNodeENS.SymbolKey; //SymbolKey
objUiFileRelationNodeENT.SourcePath = objUiFileRelationNodeENS.SourcePath; //SourcePath
objUiFileRelationNodeENT.LineNo = objUiFileRelationNodeENS.LineNo; //LineNo
objUiFileRelationNodeENT.ColumnNo = objUiFileRelationNodeENS.ColumnNo; //ColumnNo
objUiFileRelationNodeENT.LevelNo = objUiFileRelationNodeENS.LevelNo; //层序号
objUiFileRelationNodeENT.ParentNodeId = objUiFileRelationNodeENS.ParentNodeId; //ParentNodeId
objUiFileRelationNodeENT.ExtraJson = objUiFileRelationNodeENS.ExtraJson; //ExtraJson
objUiFileRelationNodeENT.CreatedAt = objUiFileRelationNodeENS.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationNodeEN:objUiFileRelationNodeENT</returns>
 public static clsUiFileRelationNodeEN CopyTo(this clsUiFileRelationNodeEN objUiFileRelationNodeENS)
{
try
{
 clsUiFileRelationNodeEN objUiFileRelationNodeENT = new clsUiFileRelationNodeEN()
{
NodeId = objUiFileRelationNodeENS.NodeId, //NodeId
TaskId = objUiFileRelationNodeENS.TaskId, //TaskId
FileId = objUiFileRelationNodeENS.FileId, //FileId
NodeType = objUiFileRelationNodeENS.NodeType, //NodeType
SymbolName = objUiFileRelationNodeENS.SymbolName, //SymbolName
SymbolKey = objUiFileRelationNodeENS.SymbolKey, //SymbolKey
SourcePath = objUiFileRelationNodeENS.SourcePath, //SourcePath
LineNo = objUiFileRelationNodeENS.LineNo, //LineNo
ColumnNo = objUiFileRelationNodeENS.ColumnNo, //ColumnNo
LevelNo = objUiFileRelationNodeENS.LevelNo, //层序号
ParentNodeId = objUiFileRelationNodeENS.ParentNodeId, //ParentNodeId
ExtraJson = objUiFileRelationNodeENS.ExtraJson, //ExtraJson
CreatedAt = objUiFileRelationNodeENS.CreatedAt, //CreatedAt
};
 return objUiFileRelationNodeENT;
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
public static void CheckPropertyNew(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 clsUiFileRelationNodeBL.UiFileRelationNodeDA.CheckPropertyNew(objUiFileRelationNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 clsUiFileRelationNodeBL.UiFileRelationNodeDA.CheckProperty4Condition(objUiFileRelationNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUiFileRelationNodeEN objUiFileRelationNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.NodeId) == true)
{
string strComparisonOpNodeId = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.NodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.NodeId, objUiFileRelationNodeCond.NodeId, strComparisonOpNodeId);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.TaskId) == true)
{
string strComparisonOpTaskId = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.TaskId, objUiFileRelationNodeCond.TaskId, strComparisonOpTaskId);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.FileId) == true)
{
string strComparisonOpFileId = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.FileId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.FileId, objUiFileRelationNodeCond.FileId, strComparisonOpFileId);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.NodeType) == true)
{
string strComparisonOpNodeType = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.NodeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationNode.NodeType, objUiFileRelationNodeCond.NodeType, strComparisonOpNodeType);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.SymbolName) == true)
{
string strComparisonOpSymbolName = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationNode.SymbolName, objUiFileRelationNodeCond.SymbolName, strComparisonOpSymbolName);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.SymbolKey) == true)
{
string strComparisonOpSymbolKey = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.SymbolKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationNode.SymbolKey, objUiFileRelationNodeCond.SymbolKey, strComparisonOpSymbolKey);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.SourcePath) == true)
{
string strComparisonOpSourcePath = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.SourcePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationNode.SourcePath, objUiFileRelationNodeCond.SourcePath, strComparisonOpSourcePath);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.LineNo) == true)
{
string strComparisonOpLineNo = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.LineNo];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.LineNo, objUiFileRelationNodeCond.LineNo, strComparisonOpLineNo);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.ColumnNo) == true)
{
string strComparisonOpColumnNo = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.ColumnNo];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.ColumnNo, objUiFileRelationNodeCond.ColumnNo, strComparisonOpColumnNo);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.LevelNo) == true)
{
string strComparisonOpLevelNo = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.LevelNo, objUiFileRelationNodeCond.LevelNo, strComparisonOpLevelNo);
}
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationNode.ParentNodeId, objUiFileRelationNodeCond.ParentNodeId, strComparisonOpParentNodeId);
}
//数据类型string(ntext)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objUiFileRelationNodeCond.IsUpdated(conUiFileRelationNode.CreatedAt) == true)
{
string strComparisonOpCreatedAt = objUiFileRelationNodeCond.dicFldComparisonOp[conUiFileRelationNode.CreatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationNode.CreatedAt, objUiFileRelationNodeCond.CreatedAt, strComparisonOpCreatedAt);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UiFileRelationNode(UiFileRelationNode), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FileId_NodeId_NodeType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationNodeEN == null) return true;
if (objUiFileRelationNodeEN.NodeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUiFileRelationNodeEN.FileId == null)
{
 sbCondition.AppendFormat(" and FileId is null", objUiFileRelationNodeEN.FileId);
}
else
{
 sbCondition.AppendFormat(" and FileId = '{0}'", objUiFileRelationNodeEN.FileId);
}
 sbCondition.AppendFormat(" and NodeId = '{0}'", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and NodeType = '{0}'", objUiFileRelationNodeEN.NodeType);
if (clsUiFileRelationNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("NodeId !=  {0}", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and FileId = '{0}'", objUiFileRelationNodeEN.FileId);
 sbCondition.AppendFormat(" and NodeId = '{0}'", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and NodeType = '{0}'", objUiFileRelationNodeEN.NodeType);
if (clsUiFileRelationNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UiFileRelationNode(UiFileRelationNode), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileId_NodeId_NodeType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationNodeEN == null) return "";
if (objUiFileRelationNodeEN.NodeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUiFileRelationNodeEN.FileId == null)
{
 sbCondition.AppendFormat(" and FileId is null", objUiFileRelationNodeEN.FileId);
}
else
{
 sbCondition.AppendFormat(" and FileId = '{0}'", objUiFileRelationNodeEN.FileId);
}
 sbCondition.AppendFormat(" and NodeId = '{0}'", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and NodeType = '{0}'", objUiFileRelationNodeEN.NodeType);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("NodeId !=  {0}", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and FileId = '{0}'", objUiFileRelationNodeEN.FileId);
 sbCondition.AppendFormat(" and NodeId = '{0}'", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and NodeType = '{0}'", objUiFileRelationNodeEN.NodeType);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UiFileRelationNode
{
public virtual bool UpdRelaTabDate(long lngNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// UiFileRelationNode(UiFileRelationNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUiFileRelationNodeBL
{
public static RelatedActions_UiFileRelationNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUiFileRelationNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUiFileRelationNodeDA UiFileRelationNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUiFileRelationNodeDA();
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
 public clsUiFileRelationNodeBL()
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
if (string.IsNullOrEmpty(clsUiFileRelationNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationNodeEN._ConnectString);
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
public static DataTable GetDataTable_UiFileRelationNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UiFileRelationNodeDA.GetDataTable_UiFileRelationNode(strWhereCond);
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
objDT = UiFileRelationNodeDA.GetDataTable(strWhereCond);
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
objDT = UiFileRelationNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UiFileRelationNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UiFileRelationNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UiFileRelationNodeDA.GetDataTable_Top(objTopPara);
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
objDT = UiFileRelationNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UiFileRelationNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UiFileRelationNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetObjLstByNodeIdLst(List<long> arrNodeIdLst)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrNodeIdLst);
 string strWhereCond = string.Format("NodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUiFileRelationNodeEN> GetObjLstByNodeIdLstCache(List<long> arrNodeIdLst)
{
string strKey = string.Format("{0}", clsUiFileRelationNodeEN._CurrTabName);
List<clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLst_Sel =
arrUiFileRelationNodeObjLstCache
.Where(x => arrNodeIdLst.Contains(x.NodeId));
return arrUiFileRelationNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetObjLst(string strWhereCond)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
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
public static List<clsUiFileRelationNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUiFileRelationNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUiFileRelationNodeEN> GetSubObjLstCache(clsUiFileRelationNodeEN objUiFileRelationNodeCond)
{
List<clsUiFileRelationNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationNode._AttributeName)
{
if (objUiFileRelationNodeCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationNodeCond[strFldName].ToString());
}
else
{
if (objUiFileRelationNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationNodeCond[strFldName]));
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
public static List<clsUiFileRelationNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
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
public static List<clsUiFileRelationNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
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
List<clsUiFileRelationNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUiFileRelationNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUiFileRelationNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
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
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
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
public static List<clsUiFileRelationNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUiFileRelationNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
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
public static List<clsUiFileRelationNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationNodeEN.NodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUiFileRelationNode(ref clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
bool bolResult = UiFileRelationNodeDA.GetUiFileRelationNode(ref objUiFileRelationNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationNodeEN GetObjByNodeId(long lngNodeId)
{
clsUiFileRelationNodeEN objUiFileRelationNodeEN = UiFileRelationNodeDA.GetObjByNodeId(lngNodeId);
return objUiFileRelationNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUiFileRelationNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUiFileRelationNodeEN objUiFileRelationNodeEN = UiFileRelationNodeDA.GetFirstObj(strWhereCond);
 return objUiFileRelationNodeEN;
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
public static clsUiFileRelationNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUiFileRelationNodeEN objUiFileRelationNodeEN = UiFileRelationNodeDA.GetObjByDataRow(objRow);
 return objUiFileRelationNodeEN;
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
public static clsUiFileRelationNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUiFileRelationNodeEN objUiFileRelationNodeEN = UiFileRelationNodeDA.GetObjByDataRow(objRow);
 return objUiFileRelationNodeEN;
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
 /// <param name = "lngNodeId">所给的关键字</param>
 /// <param name = "lstUiFileRelationNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationNodeEN GetObjByNodeIdFromList(long lngNodeId, List<clsUiFileRelationNodeEN> lstUiFileRelationNodeObjLst)
{
foreach (clsUiFileRelationNodeEN objUiFileRelationNodeEN in lstUiFileRelationNodeObjLst)
{
if (objUiFileRelationNodeEN.NodeId == lngNodeId)
{
return objUiFileRelationNodeEN;
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
 long lngNodeId;
 try
 {
 lngNodeId = new clsUiFileRelationNodeDA().GetFirstID(strWhereCond);
 return lngNodeId;
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
 arrList = UiFileRelationNodeDA.GetID(strWhereCond);
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
bool bolIsExist = UiFileRelationNodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngNodeId)
{
//检测记录是否存在
bool bolIsExist = UiFileRelationNodeDA.IsExist(lngNodeId);
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
 bolIsExist = clsUiFileRelationNodeDA.IsExistTable();
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
 bolIsExist = UiFileRelationNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUiFileRelationNodeEN objUiFileRelationNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FileId = [{0}],NodeId = [{1}],NodeType = [{2}]的数据已经存在!(in clsUiFileRelationNodeBL.AddNewRecordBySql2)", objUiFileRelationNodeEN.FileId,objUiFileRelationNodeEN.NodeId,objUiFileRelationNodeEN.NodeType);
throw new Exception(strMsg);
}
try
{
bool bolResult = UiFileRelationNodeDA.AddNewRecordBySQL2(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUiFileRelationNodeEN objUiFileRelationNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FileId = [{0}],NodeId = [{1}],NodeType = [{2}]的数据已经存在!(in clsUiFileRelationNodeBL.AddNewRecordBySql2WithReturnKey)", objUiFileRelationNodeEN.FileId,objUiFileRelationNodeEN.NodeId,objUiFileRelationNodeEN.NodeType);
throw new Exception(strMsg);
}
try
{
string strKey = UiFileRelationNodeDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
try
{
bool bolResult = UiFileRelationNodeDA.Update(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN.NodeId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UiFileRelationNodeDA.UpdateBySql2(objUiFileRelationNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationNodeBL.ReFreshCache();

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
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
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngNodeId)
{
try
{
 clsUiFileRelationNodeEN objUiFileRelationNodeEN = clsUiFileRelationNodeBL.GetObjByNodeId(lngNodeId);

if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(objUiFileRelationNodeEN.NodeId, "SetUpdDate");
}
if (objUiFileRelationNodeEN != null)
{
int intRecNum = UiFileRelationNodeDA.DelRecord(lngNodeId);
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
/// <param name="lngNodeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngNodeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUiFileRelationNode.NodeId,
//lngNodeId);
//        clsUiFileRelationNodeBL.DelUiFileRelationNodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationNodeBL.DelRecord(lngNodeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngNodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUiFileRelationNodeBL.relatedActions != null)
{
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(lngNodeId, "UpdRelaTabDate");
}
bool bolResult = UiFileRelationNodeDA.DelRecord(lngNodeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrNodeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUiFileRelationNodes(List<string> arrNodeIdLst)
{
if (arrNodeIdLst.Count == 0) return 0;
try
{
if (clsUiFileRelationNodeBL.relatedActions != null)
{
foreach (var strNodeId in arrNodeIdLst)
{
long lngNodeId = long.Parse(strNodeId);
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(lngNodeId, "UpdRelaTabDate");
}
}
int intDelRecNum = UiFileRelationNodeDA.DelUiFileRelationNode(arrNodeIdLst);
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
public static int DelUiFileRelationNodesByCond(string strWhereCond)
{
try
{
if (clsUiFileRelationNodeBL.relatedActions != null)
{
List<string> arrNodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strNodeId in arrNodeId)
{
long lngNodeId = long.Parse(strNodeId);
clsUiFileRelationNodeBL.relatedActions.UpdRelaTabDate(lngNodeId, "UpdRelaTabDate");
}
}
int intRecNum = UiFileRelationNodeDA.DelUiFileRelationNode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UiFileRelationNode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngNodeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngNodeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationNodeBL.DelRecord(lngNodeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationNodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <param name = "objUiFileRelationNodeENT">目标对象</param>
 public static void CopyTo(clsUiFileRelationNodeEN objUiFileRelationNodeENS, clsUiFileRelationNodeEN objUiFileRelationNodeENT)
{
try
{
objUiFileRelationNodeENT.NodeId = objUiFileRelationNodeENS.NodeId; //NodeId
objUiFileRelationNodeENT.TaskId = objUiFileRelationNodeENS.TaskId; //TaskId
objUiFileRelationNodeENT.FileId = objUiFileRelationNodeENS.FileId; //FileId
objUiFileRelationNodeENT.NodeType = objUiFileRelationNodeENS.NodeType; //NodeType
objUiFileRelationNodeENT.SymbolName = objUiFileRelationNodeENS.SymbolName; //SymbolName
objUiFileRelationNodeENT.SymbolKey = objUiFileRelationNodeENS.SymbolKey; //SymbolKey
objUiFileRelationNodeENT.SourcePath = objUiFileRelationNodeENS.SourcePath; //SourcePath
objUiFileRelationNodeENT.LineNo = objUiFileRelationNodeENS.LineNo; //LineNo
objUiFileRelationNodeENT.ColumnNo = objUiFileRelationNodeENS.ColumnNo; //ColumnNo
objUiFileRelationNodeENT.LevelNo = objUiFileRelationNodeENS.LevelNo; //层序号
objUiFileRelationNodeENT.ParentNodeId = objUiFileRelationNodeENS.ParentNodeId; //ParentNodeId
objUiFileRelationNodeENT.ExtraJson = objUiFileRelationNodeENS.ExtraJson; //ExtraJson
objUiFileRelationNodeENT.CreatedAt = objUiFileRelationNodeENS.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
try
{
objUiFileRelationNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUiFileRelationNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUiFileRelationNode.NodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.NodeId = objUiFileRelationNodeEN.NodeId; //NodeId
}
if (arrFldSet.Contains(conUiFileRelationNode.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.TaskId = objUiFileRelationNodeEN.TaskId; //TaskId
}
if (arrFldSet.Contains(conUiFileRelationNode.FileId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.FileId = objUiFileRelationNodeEN.FileId; //FileId
}
if (arrFldSet.Contains(conUiFileRelationNode.NodeType, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.NodeType = objUiFileRelationNodeEN.NodeType; //NodeType
}
if (arrFldSet.Contains(conUiFileRelationNode.SymbolName, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.SymbolName = objUiFileRelationNodeEN.SymbolName; //SymbolName
}
if (arrFldSet.Contains(conUiFileRelationNode.SymbolKey, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.SymbolKey = objUiFileRelationNodeEN.SymbolKey == "[null]" ? null :  objUiFileRelationNodeEN.SymbolKey; //SymbolKey
}
if (arrFldSet.Contains(conUiFileRelationNode.SourcePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.SourcePath = objUiFileRelationNodeEN.SourcePath == "[null]" ? null :  objUiFileRelationNodeEN.SourcePath; //SourcePath
}
if (arrFldSet.Contains(conUiFileRelationNode.LineNo, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.LineNo = objUiFileRelationNodeEN.LineNo; //LineNo
}
if (arrFldSet.Contains(conUiFileRelationNode.ColumnNo, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.ColumnNo = objUiFileRelationNodeEN.ColumnNo; //ColumnNo
}
if (arrFldSet.Contains(conUiFileRelationNode.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.LevelNo = objUiFileRelationNodeEN.LevelNo; //层序号
}
if (arrFldSet.Contains(conUiFileRelationNode.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.ParentNodeId = objUiFileRelationNodeEN.ParentNodeId; //ParentNodeId
}
if (arrFldSet.Contains(conUiFileRelationNode.ExtraJson, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.ExtraJson = objUiFileRelationNodeEN.ExtraJson == "[null]" ? null :  objUiFileRelationNodeEN.ExtraJson; //ExtraJson
}
if (arrFldSet.Contains(conUiFileRelationNode.CreatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationNodeEN.CreatedAt = objUiFileRelationNodeEN.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
try
{
if (objUiFileRelationNodeEN.SymbolKey == "[null]") objUiFileRelationNodeEN.SymbolKey = null; //SymbolKey
if (objUiFileRelationNodeEN.SourcePath == "[null]") objUiFileRelationNodeEN.SourcePath = null; //SourcePath
if (objUiFileRelationNodeEN.ExtraJson == "[null]") objUiFileRelationNodeEN.ExtraJson = null; //ExtraJson
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
public static void CheckPropertyNew(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 UiFileRelationNodeDA.CheckPropertyNew(objUiFileRelationNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 UiFileRelationNodeDA.CheckProperty4Condition(objUiFileRelationNodeEN);
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
if (clsUiFileRelationNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUiFileRelationNodeBL没有刷新缓存机制(clsUiFileRelationNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by NodeId");
//if (arrUiFileRelationNodeObjLstCache == null)
//{
//arrUiFileRelationNodeObjLstCache = UiFileRelationNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationNodeEN GetObjByNodeIdCache(long lngNodeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUiFileRelationNodeEN._CurrTabName);
List<clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLst_Sel =
arrUiFileRelationNodeObjLstCache
.Where(x=> x.NodeId == lngNodeId 
);
if (arrUiFileRelationNodeObjLst_Sel.Count() == 0)
{
   clsUiFileRelationNodeEN obj = clsUiFileRelationNodeBL.GetObjByNodeId(lngNodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUiFileRelationNodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetAllUiFileRelationNodeObjLstCache()
{
//获取缓存中的对象列表
List<clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLstCache = GetObjLstCache(); 
return arrUiFileRelationNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationNodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUiFileRelationNodeEN._CurrTabName);
List<clsUiFileRelationNodeEN> arrUiFileRelationNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUiFileRelationNodeObjLstCache;
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
string strKey = string.Format("{0}", clsUiFileRelationNodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUiFileRelationNodeEN._RefreshTimeLst.Count == 0) return "";
return clsUiFileRelationNodeEN._RefreshTimeLst[clsUiFileRelationNodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsUiFileRelationNodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUiFileRelationNodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUiFileRelationNodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UiFileRelationNode(UiFileRelationNode)
 /// 唯一性条件:FileId_NodeId_NodeType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检测记录是否存在
string strResult = UiFileRelationNodeDA.GetUniCondStr(objUiFileRelationNodeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngNodeId)
{
if (strInFldName != conUiFileRelationNode.NodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUiFileRelationNode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUiFileRelationNode._AttributeName));
throw new Exception(strMsg);
}
var objUiFileRelationNode = clsUiFileRelationNodeBL.GetObjByNodeIdCache(lngNodeId);
if (objUiFileRelationNode == null) return "";
return objUiFileRelationNode[strOutFldName].ToString();
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
int intRecCount = clsUiFileRelationNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsUiFileRelationNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUiFileRelationNodeDA.GetRecCount();
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
int intRecCount = clsUiFileRelationNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUiFileRelationNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUiFileRelationNodeEN objUiFileRelationNodeCond)
{
List<clsUiFileRelationNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationNode._AttributeName)
{
if (objUiFileRelationNodeCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationNodeCond[strFldName].ToString());
}
else
{
if (objUiFileRelationNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationNodeCond[strFldName]));
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
 List<string> arrList = clsUiFileRelationNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UiFileRelationNodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationNodeDA.SetFldValue(clsUiFileRelationNodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UiFileRelationNodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationNodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationNodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationNodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UiFileRelationNode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**NodeId*/ 
 strCreateTabCode.Append(" NodeId bigint primary key identity, "); 
 // /**TaskId*/ 
 strCreateTabCode.Append(" TaskId bigint not Null, "); 
 // /**FileId*/ 
 strCreateTabCode.Append(" FileId bigint Null, "); 
 // /**NodeType*/ 
 strCreateTabCode.Append(" NodeType varchar(20) not Null, "); 
 // /**SymbolName*/ 
 strCreateTabCode.Append(" SymbolName nvarchar(400) not Null, "); 
 // /**SymbolKey*/ 
 strCreateTabCode.Append(" SymbolKey nvarchar(600) Null, "); 
 // /**SourcePath*/ 
 strCreateTabCode.Append(" SourcePath nvarchar(1000) Null, "); 
 // /**LineNo*/ 
 strCreateTabCode.Append(" LineNo int Null, "); 
 // /**ColumnNo*/ 
 strCreateTabCode.Append(" ColumnNo int Null, "); 
 // /**层序号*/ 
 strCreateTabCode.Append(" LevelNo int not Null, "); 
 // /**ParentNodeId*/ 
 strCreateTabCode.Append(" ParentNodeId bigint Null, "); 
 // /**ExtraJson*/ 
 strCreateTabCode.Append(" ExtraJson ntext(2147483646) Null, "); 
 // /**CreatedAt*/ 
 strCreateTabCode.Append(" CreatedAt datetime not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// UiFileRelationNode(UiFileRelationNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UiFileRelationNode : clsCommFun4BL
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
clsUiFileRelationNodeBL.ReFreshThisCache();
}
}

}