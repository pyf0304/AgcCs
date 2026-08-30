
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_nodeBL
 表名:dm_model_diagram_node(00050668)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/18 16:25:33
 生成者:pyf_agc
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型图(ModelDiagram)
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
public static class  clsdm_model_diagram_nodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_node_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagram_nodeEN GetObj(this K_diagram_node_id_dm_model_diagram_node myKey)
{
clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.GetObjBydiagram_node_id(myKey.Value);
return objdm_model_diagram_nodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagram_nodeEN.diagram_node_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_nodeEN) == false)
{
var strMsg = string.Format("记录已经存在!图ID = [{0}],节点名称 = [{1}],结点类型编码 = [{2}]的数据已经存在!(in clsdm_model_diagram_nodeBL.AddNewRecord)", objdm_model_diagram_nodeEN.diagram_id,objdm_model_diagram_nodeEN.node_label,objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.AddNewRecordBySQL2(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
public static bool AddRecordEx(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objdm_model_diagram_nodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_nodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(图ID(diagram_id)=[{0}],节点名称(node_label)=[{1}],结点类型编码(node_type_code)=[{2}])已经存在,不能重复!", objdm_model_diagram_nodeEN.diagram_id, objdm_model_diagram_nodeEN.node_label, objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objdm_model_diagram_nodeEN.AddNewRecord();
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_nodeEN) == false)
{
var strMsg = string.Format("记录已经存在!图ID = [{0}],节点名称 = [{1}],结点类型编码 = [{2}]的数据已经存在!(in clsdm_model_diagram_nodeBL.AddNewRecordWithMaxId)", objdm_model_diagram_nodeEN.diagram_id,objdm_model_diagram_nodeEN.node_label,objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true || clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
     objdm_model_diagram_nodeEN.diagram_node_id = clsdm_model_diagram_nodeBL.GetMaxStrIdByPrefix_S(objdm_model_diagram_nodeEN.PrjId);
 }
string strdiagram_node_id = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_nodeEN);
     objdm_model_diagram_nodeEN.diagram_node_id = strdiagram_node_id;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
}
return strdiagram_node_id;
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagram_nodeEN.diagram_node_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_nodeEN) == false)
{
var strMsg = string.Format("记录已经存在!图ID = [{0}],节点名称 = [{1}],结点类型编码 = [{2}]的数据已经存在!(in clsdm_model_diagram_nodeBL.AddNewRecordWithReturnKey)", objdm_model_diagram_nodeEN.diagram_id,objdm_model_diagram_nodeEN.node_label,objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
try
{
string strKey = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setdiagram_node_id(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strdiagram_node_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_node_id, 8, condm_model_diagram_node.diagram_node_id);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strdiagram_node_id, 8, condm_model_diagram_node.diagram_node_id);
}
objdm_model_diagram_nodeEN.diagram_node_id = strdiagram_node_id; //图节点映射ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.diagram_node_id) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.diagram_node_id, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.diagram_node_id] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN SetPrjId(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, condm_model_diagram_node.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, condm_model_diagram_node.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, condm_model_diagram_node.PrjId);
}
objdm_model_diagram_nodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.PrjId) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.PrjId, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.PrjId] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setdiagram_id(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strdiagram_id, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strdiagram_id, condm_model_diagram_node.diagram_id);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_id, 8, condm_model_diagram_node.diagram_id);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strdiagram_id, 8, condm_model_diagram_node.diagram_id);
}
objdm_model_diagram_nodeEN.diagram_id = strdiagram_id; //图ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.diagram_id) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.diagram_id, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.diagram_id] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setstage_node_map_id(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strstage_node_map_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strstage_node_map_id, 8, condm_model_diagram_node.stage_node_map_id);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strstage_node_map_id, 8, condm_model_diagram_node.stage_node_map_id);
}
objdm_model_diagram_nodeEN.stage_node_map_id = strstage_node_map_id; //阶段结点映射ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.stage_node_map_id) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.stage_node_map_id, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.stage_node_map_id] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setnode_type_code(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strnode_type_code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strnode_type_code, 30, condm_model_diagram_node.node_type_code);
}
objdm_model_diagram_nodeEN.node_type_code = strnode_type_code; //结点类型编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.node_type_code) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.node_type_code, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.node_type_code] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setnode_label(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strnode_label, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strnode_label, 100, condm_model_diagram_node.node_label);
}
objdm_model_diagram_nodeEN.node_label = strnode_label; //节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.node_label) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.node_label, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.node_label] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setx_pos(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, int? intx_pos, string strComparisonOp="")
	{
objdm_model_diagram_nodeEN.x_pos = intx_pos; //X坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.x_pos) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.x_pos, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.x_pos] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Sety_pos(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, int? inty_pos, string strComparisonOp="")
	{
objdm_model_diagram_nodeEN.y_pos = inty_pos; //Y坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.y_pos) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.y_pos, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.y_pos] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN SetWidth(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, int? intWidth, string strComparisonOp="")
	{
objdm_model_diagram_nodeEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.Width) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.Width, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.Width] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN SetHeight(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, int? intHeight, string strComparisonOp="")
	{
objdm_model_diagram_nodeEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.Height) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.Height, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.Height] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setnode_style(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strnode_style, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strnode_style, 200, condm_model_diagram_node.node_style);
}
objdm_model_diagram_nodeEN.node_style = strnode_style; //结点样式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.node_style) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.node_style, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.node_style] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setshape_type(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strshape_type, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strshape_type, 50, condm_model_diagram_node.shape_type);
}
objdm_model_diagram_nodeEN.shape_type = strshape_type; //外形
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.shape_type) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.shape_type, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.shape_type] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setis_visible(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolis_visible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolis_visible, condm_model_diagram_node.is_visible);
objdm_model_diagram_nodeEN.is_visible = bolis_visible; //是否可见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.is_visible) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.is_visible, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.is_visible] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setsort_no(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, int intsort_no, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intsort_no, condm_model_diagram_node.sort_no);
objdm_model_diagram_nodeEN.sort_no = intsort_no; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.sort_no) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.sort_no, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.sort_no] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN SetStatus(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, condm_model_diagram_node.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, condm_model_diagram_node.Status);
}
objdm_model_diagram_nodeEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.Status) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.Status, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.Status] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setcreated_by(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strcreated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcreated_by, condm_model_diagram_node.created_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreated_by, 50, condm_model_diagram_node.created_by);
}
objdm_model_diagram_nodeEN.created_by = strcreated_by; //创建人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.created_by) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.created_by, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.created_by] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setcreated_time(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, DateTime dtecreated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dtecreated_time, condm_model_diagram_node.created_time);
objdm_model_diagram_nodeEN.created_time = dtecreated_time; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.created_time) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.created_time, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.created_time] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setupdated_by(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strupdated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strupdated_by, condm_model_diagram_node.updated_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdated_by, 50, condm_model_diagram_node.updated_by);
}
objdm_model_diagram_nodeEN.updated_by = strupdated_by; //更新人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.updated_by) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.updated_by, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.updated_by] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setupdated_time(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, DateTime dteupdated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteupdated_time, condm_model_diagram_node.updated_time);
objdm_model_diagram_nodeEN.updated_time = dteupdated_time; //更新时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.updated_time) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.updated_time, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.updated_time] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_nodeEN Setremark(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 1000, condm_model_diagram_node.remark);
}
objdm_model_diagram_nodeEN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_nodeEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_node.remark) == false)
{
objdm_model_diagram_nodeEN.dicFldComparisonOp.Add(condm_model_diagram_node.remark, strComparisonOp);
}
else
{
objdm_model_diagram_nodeEN.dicFldComparisonOp[condm_model_diagram_node.remark] = strComparisonOp;
}
}
return objdm_model_diagram_nodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objdm_model_diagram_nodeEN.CheckPropertyNew();
clsdm_model_diagram_nodeEN objdm_model_diagram_nodeCond = new clsdm_model_diagram_nodeEN();
string strCondition = objdm_model_diagram_nodeCond
.Setdiagram_node_id(objdm_model_diagram_nodeEN.diagram_node_id, "<>")
.Setdiagram_id(objdm_model_diagram_nodeEN.diagram_id, "=")
.Setnode_label(objdm_model_diagram_nodeEN.node_label, "=")
.Setnode_type_code(objdm_model_diagram_nodeEN.node_type_code, "=")
.GetCombineCondition();
objdm_model_diagram_nodeEN._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagram_nodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objdm_model_diagram_nodeEN.Update();
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
 /// <param name = "objdm_model_diagram_node">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsdm_model_diagram_nodeEN objdm_model_diagram_node)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsdm_model_diagram_nodeEN objdm_model_diagram_nodeCond = new clsdm_model_diagram_nodeEN();
string strCondition = objdm_model_diagram_nodeCond
.Setdiagram_id(objdm_model_diagram_node.diagram_id, "=")
.Setnode_label(objdm_model_diagram_node.node_label, "=")
.Setnode_type_code(objdm_model_diagram_node.node_type_code, "=")
.GetCombineCondition();
objdm_model_diagram_node._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagram_nodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objdm_model_diagram_node.diagram_node_id = clsdm_model_diagram_nodeBL.GetFirstID_S(strCondition);
objdm_model_diagram_node.UpdateWithCondition(strCondition);
}
else
{
objdm_model_diagram_node.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.UpdateBySql2(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.UpdateBySql2(objdm_model_diagram_nodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strWhereCond)
{
try
{
bool bolResult = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.UpdateBySqlWithCondition(objdm_model_diagram_nodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.UpdateBySqlWithConditionTransaction(objdm_model_diagram_nodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "strdiagram_node_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
try
{
int intRecNum = clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.DelRecord(objdm_model_diagram_nodeEN.diagram_node_id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeENS">源对象</param>
 /// <param name = "objdm_model_diagram_nodeENT">目标对象</param>
 public static void CopyTo(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENS, clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENT)
{
try
{
objdm_model_diagram_nodeENT.diagram_node_id = objdm_model_diagram_nodeENS.diagram_node_id; //图节点映射ID
objdm_model_diagram_nodeENT.PrjId = objdm_model_diagram_nodeENS.PrjId; //工程Id
objdm_model_diagram_nodeENT.diagram_id = objdm_model_diagram_nodeENS.diagram_id; //图ID
objdm_model_diagram_nodeENT.stage_node_map_id = objdm_model_diagram_nodeENS.stage_node_map_id; //阶段结点映射ID
objdm_model_diagram_nodeENT.node_type_code = objdm_model_diagram_nodeENS.node_type_code; //结点类型编码
objdm_model_diagram_nodeENT.node_label = objdm_model_diagram_nodeENS.node_label; //节点名称
objdm_model_diagram_nodeENT.x_pos = objdm_model_diagram_nodeENS.x_pos; //X坐标
objdm_model_diagram_nodeENT.y_pos = objdm_model_diagram_nodeENS.y_pos; //Y坐标
objdm_model_diagram_nodeENT.Width = objdm_model_diagram_nodeENS.Width; //宽
objdm_model_diagram_nodeENT.Height = objdm_model_diagram_nodeENS.Height; //高度
objdm_model_diagram_nodeENT.node_style = objdm_model_diagram_nodeENS.node_style; //结点样式
objdm_model_diagram_nodeENT.shape_type = objdm_model_diagram_nodeENS.shape_type; //外形
objdm_model_diagram_nodeENT.is_visible = objdm_model_diagram_nodeENS.is_visible; //是否可见
objdm_model_diagram_nodeENT.sort_no = objdm_model_diagram_nodeENS.sort_no; //排序号
objdm_model_diagram_nodeENT.Status = objdm_model_diagram_nodeENS.Status; //Status
objdm_model_diagram_nodeENT.created_by = objdm_model_diagram_nodeENS.created_by; //创建人
objdm_model_diagram_nodeENT.created_time = objdm_model_diagram_nodeENS.created_time; //创建时间
objdm_model_diagram_nodeENT.updated_by = objdm_model_diagram_nodeENS.updated_by; //更新人
objdm_model_diagram_nodeENT.updated_time = objdm_model_diagram_nodeENS.updated_time; //更新时间
objdm_model_diagram_nodeENT.remark = objdm_model_diagram_nodeENS.remark; //备注
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
 /// <param name = "objdm_model_diagram_nodeENS">源对象</param>
 /// <returns>目标对象=>clsdm_model_diagram_nodeEN:objdm_model_diagram_nodeENT</returns>
 public static clsdm_model_diagram_nodeEN CopyTo(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENS)
{
try
{
 clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENT = new clsdm_model_diagram_nodeEN()
{
diagram_node_id = objdm_model_diagram_nodeENS.diagram_node_id, //图节点映射ID
PrjId = objdm_model_diagram_nodeENS.PrjId, //工程Id
diagram_id = objdm_model_diagram_nodeENS.diagram_id, //图ID
stage_node_map_id = objdm_model_diagram_nodeENS.stage_node_map_id, //阶段结点映射ID
node_type_code = objdm_model_diagram_nodeENS.node_type_code, //结点类型编码
node_label = objdm_model_diagram_nodeENS.node_label, //节点名称
x_pos = objdm_model_diagram_nodeENS.x_pos, //X坐标
y_pos = objdm_model_diagram_nodeENS.y_pos, //Y坐标
Width = objdm_model_diagram_nodeENS.Width, //宽
Height = objdm_model_diagram_nodeENS.Height, //高度
node_style = objdm_model_diagram_nodeENS.node_style, //结点样式
shape_type = objdm_model_diagram_nodeENS.shape_type, //外形
is_visible = objdm_model_diagram_nodeENS.is_visible, //是否可见
sort_no = objdm_model_diagram_nodeENS.sort_no, //排序号
Status = objdm_model_diagram_nodeENS.Status, //Status
created_by = objdm_model_diagram_nodeENS.created_by, //创建人
created_time = objdm_model_diagram_nodeENS.created_time, //创建时间
updated_by = objdm_model_diagram_nodeENS.updated_by, //更新人
updated_time = objdm_model_diagram_nodeENS.updated_time, //更新时间
remark = objdm_model_diagram_nodeENS.remark, //备注
};
 return objdm_model_diagram_nodeENT;
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
public static void CheckPropertyNew(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.CheckPropertyNew(objdm_model_diagram_nodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 clsdm_model_diagram_nodeBL.dm_model_diagram_nodeDA.CheckProperty4Condition(objdm_model_diagram_nodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.diagram_node_id) == true)
{
string strComparisonOpdiagram_node_id = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.diagram_node_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.diagram_node_id, objdm_model_diagram_nodeCond.diagram_node_id, strComparisonOpdiagram_node_id);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.PrjId) == true)
{
string strComparisonOpPrjId = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.PrjId, objdm_model_diagram_nodeCond.PrjId, strComparisonOpPrjId);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.diagram_id) == true)
{
string strComparisonOpdiagram_id = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.diagram_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.diagram_id, objdm_model_diagram_nodeCond.diagram_id, strComparisonOpdiagram_id);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.stage_node_map_id) == true)
{
string strComparisonOpstage_node_map_id = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.stage_node_map_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.stage_node_map_id, objdm_model_diagram_nodeCond.stage_node_map_id, strComparisonOpstage_node_map_id);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.node_type_code) == true)
{
string strComparisonOpnode_type_code = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.node_type_code];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.node_type_code, objdm_model_diagram_nodeCond.node_type_code, strComparisonOpnode_type_code);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.node_label) == true)
{
string strComparisonOpnode_label = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.node_label];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.node_label, objdm_model_diagram_nodeCond.node_label, strComparisonOpnode_label);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.x_pos) == true)
{
string strComparisonOpx_pos = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.x_pos];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_node.x_pos, objdm_model_diagram_nodeCond.x_pos, strComparisonOpx_pos);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.y_pos) == true)
{
string strComparisonOpy_pos = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.y_pos];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_node.y_pos, objdm_model_diagram_nodeCond.y_pos, strComparisonOpy_pos);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.Width) == true)
{
string strComparisonOpWidth = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.Width];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_node.Width, objdm_model_diagram_nodeCond.Width, strComparisonOpWidth);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.Height) == true)
{
string strComparisonOpHeight = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.Height];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_node.Height, objdm_model_diagram_nodeCond.Height, strComparisonOpHeight);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.node_style) == true)
{
string strComparisonOpnode_style = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.node_style];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.node_style, objdm_model_diagram_nodeCond.node_style, strComparisonOpnode_style);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.shape_type) == true)
{
string strComparisonOpshape_type = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.shape_type];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.shape_type, objdm_model_diagram_nodeCond.shape_type, strComparisonOpshape_type);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.is_visible) == true)
{
if (objdm_model_diagram_nodeCond.is_visible == true)
{
strWhereCond += string.Format(" And {0} = '1'", condm_model_diagram_node.is_visible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", condm_model_diagram_node.is_visible);
}
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.sort_no) == true)
{
string strComparisonOpsort_no = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.sort_no];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_node.sort_no, objdm_model_diagram_nodeCond.sort_no, strComparisonOpsort_no);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.Status) == true)
{
string strComparisonOpStatus = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.Status, objdm_model_diagram_nodeCond.Status, strComparisonOpStatus);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.created_by) == true)
{
string strComparisonOpcreated_by = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.created_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.created_by, objdm_model_diagram_nodeCond.created_by, strComparisonOpcreated_by);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.created_time) == true)
{
string strComparisonOpcreated_time = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.created_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.created_time, objdm_model_diagram_nodeCond.created_time, strComparisonOpcreated_time);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.updated_by) == true)
{
string strComparisonOpupdated_by = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.updated_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.updated_by, objdm_model_diagram_nodeCond.updated_by, strComparisonOpupdated_by);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.updated_time) == true)
{
string strComparisonOpupdated_time = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.updated_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.updated_time, objdm_model_diagram_nodeCond.updated_time, strComparisonOpupdated_time);
}
if (objdm_model_diagram_nodeCond.IsUpdated(condm_model_diagram_node.remark) == true)
{
string strComparisonOpremark = objdm_model_diagram_nodeCond.dicFldComparisonOp[condm_model_diagram_node.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_node.remark, objdm_model_diagram_nodeCond.remark, strComparisonOpremark);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--dm_model_diagram_node(数据模型图节点映射), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:diagram_id_node_label_node_type_code
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagram_nodeEN == null) return true;
if (objdm_model_diagram_nodeEN.diagram_node_id == null || objdm_model_diagram_nodeEN.diagram_node_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_nodeEN.diagram_id);
 if (objdm_model_diagram_nodeEN.node_label == null)
{
 sbCondition.AppendFormat(" and node_label is null", objdm_model_diagram_nodeEN.node_label);
}
else
{
 sbCondition.AppendFormat(" and node_label = '{0}'", objdm_model_diagram_nodeEN.node_label);
}
 if (objdm_model_diagram_nodeEN.node_type_code == null)
{
 sbCondition.AppendFormat(" and node_type_code is null", objdm_model_diagram_nodeEN.node_type_code);
}
else
{
 sbCondition.AppendFormat(" and node_type_code = '{0}'", objdm_model_diagram_nodeEN.node_type_code);
}
if (clsdm_model_diagram_nodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("diagram_node_id !=  '{0}'", objdm_model_diagram_nodeEN.diagram_node_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_nodeEN.diagram_id);
 sbCondition.AppendFormat(" and node_label = '{0}'", objdm_model_diagram_nodeEN.node_label);
 sbCondition.AppendFormat(" and node_type_code = '{0}'", objdm_model_diagram_nodeEN.node_type_code);
if (clsdm_model_diagram_nodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--dm_model_diagram_node(数据模型图节点映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:diagram_id_node_label_node_type_code
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagram_nodeEN == null) return "";
if (objdm_model_diagram_nodeEN.diagram_node_id == null || objdm_model_diagram_nodeEN.diagram_node_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_nodeEN.diagram_id);
 if (objdm_model_diagram_nodeEN.node_label == null)
{
 sbCondition.AppendFormat(" and node_label is null", objdm_model_diagram_nodeEN.node_label);
}
else
{
 sbCondition.AppendFormat(" and node_label = '{0}'", objdm_model_diagram_nodeEN.node_label);
}
 if (objdm_model_diagram_nodeEN.node_type_code == null)
{
 sbCondition.AppendFormat(" and node_type_code is null", objdm_model_diagram_nodeEN.node_type_code);
}
else
{
 sbCondition.AppendFormat(" and node_type_code = '{0}'", objdm_model_diagram_nodeEN.node_type_code);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("diagram_node_id !=  '{0}'", objdm_model_diagram_nodeEN.diagram_node_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_nodeEN.diagram_id);
 sbCondition.AppendFormat(" and node_label = '{0}'", objdm_model_diagram_nodeEN.node_label);
 sbCondition.AppendFormat(" and node_type_code = '{0}'", objdm_model_diagram_nodeEN.node_type_code);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_dm_model_diagram_node
{
public virtual bool UpdRelaTabDate(string strdiagram_node_id, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据模型图节点映射(dm_model_diagram_node)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsdm_model_diagram_nodeBL
{
public static RelatedActions_dm_model_diagram_node relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsdm_model_diagram_nodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsdm_model_diagram_nodeDA dm_model_diagram_nodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsdm_model_diagram_nodeDA();
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
 public clsdm_model_diagram_nodeBL()
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
if (string.IsNullOrEmpty(clsdm_model_diagram_nodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_diagram_nodeEN._ConnectString);
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
public static DataTable GetDataTable_dm_model_diagram_node(string strWhereCond)
{
DataTable objDT;
try
{
objDT = dm_model_diagram_nodeDA.GetDataTable_dm_model_diagram_node(strWhereCond);
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
objDT = dm_model_diagram_nodeDA.GetDataTable(strWhereCond);
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
objDT = dm_model_diagram_nodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = dm_model_diagram_nodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = dm_model_diagram_nodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = dm_model_diagram_nodeDA.GetDataTable_Top(objTopPara);
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
objDT = dm_model_diagram_nodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = dm_model_diagram_nodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = dm_model_diagram_nodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDiagram_node_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetObjLstByDiagram_node_idLst(List<string> arrDiagram_node_idLst)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDiagram_node_idLst, true);
 string strWhereCond = string.Format("diagram_node_id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDiagram_node_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsdm_model_diagram_nodeEN> GetObjLstByDiagram_node_idLstCache(List<string> arrDiagram_node_idLst)
{
string strKey = string.Format("{0}", clsdm_model_diagram_nodeEN._CurrTabName);
List<clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLst_Sel =
arrdm_model_diagram_nodeObjLstCache
.Where(x => arrDiagram_node_idLst.Contains(x.diagram_node_id));
return arrdm_model_diagram_nodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetObjLst(string strWhereCond)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
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
public static List<clsdm_model_diagram_nodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsdm_model_diagram_nodeEN> GetSubObjLstCache(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeCond)
{
List<clsdm_model_diagram_nodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_nodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram_node._AttributeName)
{
if (objdm_model_diagram_nodeCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagram_nodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_nodeCond[strFldName].ToString());
}
else
{
if (objdm_model_diagram_nodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagram_nodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_nodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagram_nodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_nodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_nodeCond[strFldName]));
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
public static List<clsdm_model_diagram_nodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
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
public static List<clsdm_model_diagram_nodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
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
List<clsdm_model_diagram_nodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsdm_model_diagram_nodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsdm_model_diagram_nodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
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
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
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
public static List<clsdm_model_diagram_nodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsdm_model_diagram_nodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
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
public static List<clsdm_model_diagram_nodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsdm_model_diagram_nodeEN> arrObjLst = new List<clsdm_model_diagram_nodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = new clsdm_model_diagram_nodeEN();
try
{
objdm_model_diagram_nodeEN.diagram_node_id = objRow[condm_model_diagram_node.diagram_node_id].ToString().Trim(); //图节点映射ID
objdm_model_diagram_nodeEN.PrjId = objRow[condm_model_diagram_node.PrjId].ToString().Trim(); //工程Id
objdm_model_diagram_nodeEN.diagram_id = objRow[condm_model_diagram_node.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_nodeEN.stage_node_map_id = objRow[condm_model_diagram_node.stage_node_map_id] == DBNull.Value ? null : objRow[condm_model_diagram_node.stage_node_map_id].ToString().Trim(); //阶段结点映射ID
objdm_model_diagram_nodeEN.node_type_code = objRow[condm_model_diagram_node.node_type_code] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_type_code].ToString().Trim(); //结点类型编码
objdm_model_diagram_nodeEN.node_label = objRow[condm_model_diagram_node.node_label] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_label].ToString().Trim(); //节点名称
objdm_model_diagram_nodeEN.x_pos = objRow[condm_model_diagram_node.x_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.x_pos].ToString().Trim()); //X坐标
objdm_model_diagram_nodeEN.y_pos = objRow[condm_model_diagram_node.y_pos] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.y_pos].ToString().Trim()); //Y坐标
objdm_model_diagram_nodeEN.Width = objRow[condm_model_diagram_node.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Width].ToString().Trim()); //宽
objdm_model_diagram_nodeEN.Height = objRow[condm_model_diagram_node.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_node.Height].ToString().Trim()); //高度
objdm_model_diagram_nodeEN.node_style = objRow[condm_model_diagram_node.node_style] == DBNull.Value ? null : objRow[condm_model_diagram_node.node_style].ToString().Trim(); //结点样式
objdm_model_diagram_nodeEN.shape_type = objRow[condm_model_diagram_node.shape_type] == DBNull.Value ? null : objRow[condm_model_diagram_node.shape_type].ToString().Trim(); //外形
objdm_model_diagram_nodeEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_node.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_nodeEN.sort_no = Int32.Parse(objRow[condm_model_diagram_node.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_nodeEN.Status = objRow[condm_model_diagram_node.Status].ToString().Trim(); //Status
objdm_model_diagram_nodeEN.created_by = objRow[condm_model_diagram_node.created_by].ToString().Trim(); //创建人
objdm_model_diagram_nodeEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_node.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_nodeEN.updated_by = objRow[condm_model_diagram_node.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_nodeEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_node.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_nodeEN.remark = objRow[condm_model_diagram_node.remark] == DBNull.Value ? null : objRow[condm_model_diagram_node.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_nodeEN.diagram_node_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_nodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getdm_model_diagram_node(ref clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
bool bolResult = dm_model_diagram_nodeDA.Getdm_model_diagram_node(ref objdm_model_diagram_nodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_node_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagram_nodeEN GetObjBydiagram_node_id(string strdiagram_node_id)
{
if (strdiagram_node_id.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strdiagram_node_id]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strdiagram_node_id) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strdiagram_node_id]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = dm_model_diagram_nodeDA.GetObjBydiagram_node_id(strdiagram_node_id);
return objdm_model_diagram_nodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsdm_model_diagram_nodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = dm_model_diagram_nodeDA.GetFirstObj(strWhereCond);
 return objdm_model_diagram_nodeEN;
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
public static clsdm_model_diagram_nodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = dm_model_diagram_nodeDA.GetObjByDataRow(objRow);
 return objdm_model_diagram_nodeEN;
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
public static clsdm_model_diagram_nodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = dm_model_diagram_nodeDA.GetObjByDataRow(objRow);
 return objdm_model_diagram_nodeEN;
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
 /// <param name = "strdiagram_node_id">所给的关键字</param>
 /// <param name = "lstdm_model_diagram_nodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagram_nodeEN GetObjBydiagram_node_idFromList(string strdiagram_node_id, List<clsdm_model_diagram_nodeEN> lstdm_model_diagram_nodeObjLst)
{
foreach (clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN in lstdm_model_diagram_nodeObjLst)
{
if (objdm_model_diagram_nodeEN.diagram_node_id == strdiagram_node_id)
{
return objdm_model_diagram_nodeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxDiagram_node_id;
 try
 {
 strMaxDiagram_node_id = new clsdm_model_diagram_nodeDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxDiagram_node_id;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strdiagram_node_id;
 try
 {
 strdiagram_node_id = new clsdm_model_diagram_nodeDA().GetFirstID(strWhereCond);
 return strdiagram_node_id;
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
 arrList = dm_model_diagram_nodeDA.GetID(strWhereCond);
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
bool bolIsExist = dm_model_diagram_nodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strdiagram_node_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strdiagram_node_id)
{
if (string.IsNullOrEmpty(strdiagram_node_id) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strdiagram_node_id]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = dm_model_diagram_nodeDA.IsExist(strdiagram_node_id);
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
 bolIsExist = clsdm_model_diagram_nodeDA.IsExistTable();
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
 bolIsExist = dm_model_diagram_nodeDA.IsExistTable(strTabName);
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagram_nodeEN.diagram_node_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_nodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!图ID = [{0}],节点名称 = [{1}],结点类型编码 = [{2}]的数据已经存在!(in clsdm_model_diagram_nodeBL.AddNewRecordBySql2)", objdm_model_diagram_nodeEN.diagram_id,objdm_model_diagram_nodeEN.node_label,objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
try
{
bool bolResult = dm_model_diagram_nodeDA.AddNewRecordBySQL2(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagram_nodeBL.IsExist(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagram_nodeEN.diagram_node_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_nodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!图ID = [{0}],节点名称 = [{1}],结点类型编码 = [{2}]的数据已经存在!(in clsdm_model_diagram_nodeBL.AddNewRecordBySql2WithReturnKey)", objdm_model_diagram_nodeEN.diagram_id,objdm_model_diagram_nodeEN.node_label,objdm_model_diagram_nodeEN.node_type_code);
throw new Exception(strMsg);
}
try
{
string strKey = dm_model_diagram_nodeDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
try
{
bool bolResult = dm_model_diagram_nodeDA.Update(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_nodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_nodeEN.diagram_node_id) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = dm_model_diagram_nodeDA.UpdateBySql2(objdm_model_diagram_nodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_nodeBL.ReFreshCache();

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
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
 /// <param name = "strdiagram_node_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strdiagram_node_id)
{
try
{
 clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN = clsdm_model_diagram_nodeBL.GetObjBydiagram_node_id(strdiagram_node_id);

if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_nodeEN.diagram_node_id, "SetUpdDate");
}
if (objdm_model_diagram_nodeEN != null)
{
int intRecNum = dm_model_diagram_nodeDA.DelRecord(strdiagram_node_id);
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
/// <param name="strdiagram_node_id">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strdiagram_node_id )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagram_nodeDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram_node]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//condm_model_diagram_node.diagram_node_id,
//strdiagram_node_id);
//        clsdm_model_diagram_nodeBL.Deldm_model_diagram_nodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagram_nodeBL.DelRecord(strdiagram_node_id, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagram_nodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_node_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strdiagram_node_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strdiagram_node_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(strdiagram_node_id, "UpdRelaTabDate");
}
bool bolResult = dm_model_diagram_nodeDA.DelRecord(strdiagram_node_id,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrdiagram_node_idLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deldm_model_diagram_nodes(List<string> arrdiagram_node_idLst)
{
if (arrdiagram_node_idLst.Count == 0) return 0;
try
{
if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
foreach (var strdiagram_node_id in arrdiagram_node_idLst)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(strdiagram_node_id, "UpdRelaTabDate");
}
}
int intDelRecNum = dm_model_diagram_nodeDA.Deldm_model_diagram_node(arrdiagram_node_idLst);
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
public static int Deldm_model_diagram_nodesByCond(string strWhereCond)
{
try
{
if (clsdm_model_diagram_nodeBL.relatedActions != null)
{
List<string> arrdiagram_node_id = GetPrimaryKeyID_S(strWhereCond);
foreach (var strdiagram_node_id in arrdiagram_node_id)
{
clsdm_model_diagram_nodeBL.relatedActions.UpdRelaTabDate(strdiagram_node_id, "UpdRelaTabDate");
}
}
int intRecNum = dm_model_diagram_nodeDA.Deldm_model_diagram_node(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[dm_model_diagram_node]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strdiagram_node_id">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strdiagram_node_id)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagram_nodeDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram_node]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagram_nodeBL.DelRecord(strdiagram_node_id, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagram_nodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_node_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objdm_model_diagram_nodeENS">源对象</param>
 /// <param name = "objdm_model_diagram_nodeENT">目标对象</param>
 public static void CopyTo(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENS, clsdm_model_diagram_nodeEN objdm_model_diagram_nodeENT)
{
try
{
objdm_model_diagram_nodeENT.diagram_node_id = objdm_model_diagram_nodeENS.diagram_node_id; //图节点映射ID
objdm_model_diagram_nodeENT.PrjId = objdm_model_diagram_nodeENS.PrjId; //工程Id
objdm_model_diagram_nodeENT.diagram_id = objdm_model_diagram_nodeENS.diagram_id; //图ID
objdm_model_diagram_nodeENT.stage_node_map_id = objdm_model_diagram_nodeENS.stage_node_map_id; //阶段结点映射ID
objdm_model_diagram_nodeENT.node_type_code = objdm_model_diagram_nodeENS.node_type_code; //结点类型编码
objdm_model_diagram_nodeENT.node_label = objdm_model_diagram_nodeENS.node_label; //节点名称
objdm_model_diagram_nodeENT.x_pos = objdm_model_diagram_nodeENS.x_pos; //X坐标
objdm_model_diagram_nodeENT.y_pos = objdm_model_diagram_nodeENS.y_pos; //Y坐标
objdm_model_diagram_nodeENT.Width = objdm_model_diagram_nodeENS.Width; //宽
objdm_model_diagram_nodeENT.Height = objdm_model_diagram_nodeENS.Height; //高度
objdm_model_diagram_nodeENT.node_style = objdm_model_diagram_nodeENS.node_style; //结点样式
objdm_model_diagram_nodeENT.shape_type = objdm_model_diagram_nodeENS.shape_type; //外形
objdm_model_diagram_nodeENT.is_visible = objdm_model_diagram_nodeENS.is_visible; //是否可见
objdm_model_diagram_nodeENT.sort_no = objdm_model_diagram_nodeENS.sort_no; //排序号
objdm_model_diagram_nodeENT.Status = objdm_model_diagram_nodeENS.Status; //Status
objdm_model_diagram_nodeENT.created_by = objdm_model_diagram_nodeENS.created_by; //创建人
objdm_model_diagram_nodeENT.created_time = objdm_model_diagram_nodeENS.created_time; //创建时间
objdm_model_diagram_nodeENT.updated_by = objdm_model_diagram_nodeENS.updated_by; //更新人
objdm_model_diagram_nodeENT.updated_time = objdm_model_diagram_nodeENS.updated_time; //更新时间
objdm_model_diagram_nodeENT.remark = objdm_model_diagram_nodeENS.remark; //备注
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
 /// <param name = "objdm_model_diagram_nodeEN">源简化对象</param>
 public static void SetUpdFlag(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
try
{
objdm_model_diagram_nodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objdm_model_diagram_nodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(condm_model_diagram_node.diagram_node_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.diagram_node_id = objdm_model_diagram_nodeEN.diagram_node_id; //图节点映射ID
}
if (arrFldSet.Contains(condm_model_diagram_node.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.PrjId = objdm_model_diagram_nodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(condm_model_diagram_node.diagram_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.diagram_id = objdm_model_diagram_nodeEN.diagram_id; //图ID
}
if (arrFldSet.Contains(condm_model_diagram_node.stage_node_map_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.stage_node_map_id = objdm_model_diagram_nodeEN.stage_node_map_id == "[null]" ? null :  objdm_model_diagram_nodeEN.stage_node_map_id; //阶段结点映射ID
}
if (arrFldSet.Contains(condm_model_diagram_node.node_type_code, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.node_type_code = objdm_model_diagram_nodeEN.node_type_code == "[null]" ? null :  objdm_model_diagram_nodeEN.node_type_code; //结点类型编码
}
if (arrFldSet.Contains(condm_model_diagram_node.node_label, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.node_label = objdm_model_diagram_nodeEN.node_label == "[null]" ? null :  objdm_model_diagram_nodeEN.node_label; //节点名称
}
if (arrFldSet.Contains(condm_model_diagram_node.x_pos, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.x_pos = objdm_model_diagram_nodeEN.x_pos; //X坐标
}
if (arrFldSet.Contains(condm_model_diagram_node.y_pos, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.y_pos = objdm_model_diagram_nodeEN.y_pos; //Y坐标
}
if (arrFldSet.Contains(condm_model_diagram_node.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.Width = objdm_model_diagram_nodeEN.Width; //宽
}
if (arrFldSet.Contains(condm_model_diagram_node.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.Height = objdm_model_diagram_nodeEN.Height; //高度
}
if (arrFldSet.Contains(condm_model_diagram_node.node_style, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.node_style = objdm_model_diagram_nodeEN.node_style == "[null]" ? null :  objdm_model_diagram_nodeEN.node_style; //结点样式
}
if (arrFldSet.Contains(condm_model_diagram_node.shape_type, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.shape_type = objdm_model_diagram_nodeEN.shape_type == "[null]" ? null :  objdm_model_diagram_nodeEN.shape_type; //外形
}
if (arrFldSet.Contains(condm_model_diagram_node.is_visible, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.is_visible = objdm_model_diagram_nodeEN.is_visible; //是否可见
}
if (arrFldSet.Contains(condm_model_diagram_node.sort_no, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.sort_no = objdm_model_diagram_nodeEN.sort_no; //排序号
}
if (arrFldSet.Contains(condm_model_diagram_node.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.Status = objdm_model_diagram_nodeEN.Status; //Status
}
if (arrFldSet.Contains(condm_model_diagram_node.created_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.created_by = objdm_model_diagram_nodeEN.created_by; //创建人
}
if (arrFldSet.Contains(condm_model_diagram_node.created_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.created_time = objdm_model_diagram_nodeEN.created_time; //创建时间
}
if (arrFldSet.Contains(condm_model_diagram_node.updated_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.updated_by = objdm_model_diagram_nodeEN.updated_by; //更新人
}
if (arrFldSet.Contains(condm_model_diagram_node.updated_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.updated_time = objdm_model_diagram_nodeEN.updated_time; //更新时间
}
if (arrFldSet.Contains(condm_model_diagram_node.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_nodeEN.remark = objdm_model_diagram_nodeEN.remark == "[null]" ? null :  objdm_model_diagram_nodeEN.remark; //备注
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
 /// <param name = "objdm_model_diagram_nodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
try
{
if (objdm_model_diagram_nodeEN.stage_node_map_id == "[null]") objdm_model_diagram_nodeEN.stage_node_map_id = null; //阶段结点映射ID
if (objdm_model_diagram_nodeEN.node_type_code == "[null]") objdm_model_diagram_nodeEN.node_type_code = null; //结点类型编码
if (objdm_model_diagram_nodeEN.node_label == "[null]") objdm_model_diagram_nodeEN.node_label = null; //节点名称
if (objdm_model_diagram_nodeEN.node_style == "[null]") objdm_model_diagram_nodeEN.node_style = null; //结点样式
if (objdm_model_diagram_nodeEN.shape_type == "[null]") objdm_model_diagram_nodeEN.shape_type = null; //外形
if (objdm_model_diagram_nodeEN.remark == "[null]") objdm_model_diagram_nodeEN.remark = null; //备注
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
public static void CheckPropertyNew(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 dm_model_diagram_nodeDA.CheckPropertyNew(objdm_model_diagram_nodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
 dm_model_diagram_nodeDA.CheckProperty4Condition(objdm_model_diagram_nodeEN);
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
if (clsdm_model_diagram_nodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsdm_model_diagram_nodeBL没有刷新缓存机制(clsdm_model_diagram_nodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by diagram_node_id");
//if (arrdm_model_diagram_nodeObjLstCache == null)
//{
//arrdm_model_diagram_nodeObjLstCache = dm_model_diagram_nodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strdiagram_node_id">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagram_nodeEN GetObjBydiagram_node_idCache(string strdiagram_node_id)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsdm_model_diagram_nodeEN._CurrTabName);
List<clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLst_Sel =
arrdm_model_diagram_nodeObjLstCache
.Where(x=> x.diagram_node_id == strdiagram_node_id 
);
if (arrdm_model_diagram_nodeObjLst_Sel.Count() == 0)
{
   clsdm_model_diagram_nodeEN obj = clsdm_model_diagram_nodeBL.GetObjBydiagram_node_id(strdiagram_node_id);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrdm_model_diagram_nodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetAlldm_model_diagram_nodeObjLstCache()
{
//获取缓存中的对象列表
List<clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLstCache = GetObjLstCache(); 
return arrdm_model_diagram_nodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagram_nodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsdm_model_diagram_nodeEN._CurrTabName);
List<clsdm_model_diagram_nodeEN> arrdm_model_diagram_nodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrdm_model_diagram_nodeObjLstCache;
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
string strKey = string.Format("{0}", clsdm_model_diagram_nodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagram_nodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsdm_model_diagram_nodeEN._RefreshTimeLst.Count == 0) return "";
return clsdm_model_diagram_nodeEN._RefreshTimeLst[clsdm_model_diagram_nodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsdm_model_diagram_nodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsdm_model_diagram_nodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagram_nodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsdm_model_diagram_nodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--dm_model_diagram_node(数据模型图节点映射)
 /// 唯一性条件:diagram_id_node_label_node_type_code
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeEN)
{
//检测记录是否存在
string strResult = dm_model_diagram_nodeDA.GetUniCondStr(objdm_model_diagram_nodeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf_agc
 /// 日期:2026-08-18
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strdiagram_node_id)
{
if (strInFldName != condm_model_diagram_node.diagram_node_id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (condm_model_diagram_node._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", condm_model_diagram_node._AttributeName));
throw new Exception(strMsg);
}
var objdm_model_diagram_node = clsdm_model_diagram_nodeBL.GetObjBydiagram_node_idCache(strdiagram_node_id);
if (objdm_model_diagram_node == null) return "";
return objdm_model_diagram_node[strOutFldName].ToString();
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
int intRecCount = clsdm_model_diagram_nodeDA.GetRecCount(strTabName);
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
int intRecCount = clsdm_model_diagram_nodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsdm_model_diagram_nodeDA.GetRecCount();
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
int intRecCount = clsdm_model_diagram_nodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objdm_model_diagram_nodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsdm_model_diagram_nodeEN objdm_model_diagram_nodeCond)
{
List<clsdm_model_diagram_nodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_nodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram_node._AttributeName)
{
if (objdm_model_diagram_nodeCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagram_nodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_nodeCond[strFldName].ToString());
}
else
{
if (objdm_model_diagram_nodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagram_nodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_nodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagram_nodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagram_nodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_nodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_nodeCond[strFldName]));
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
 List<string> arrList = clsdm_model_diagram_nodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagram_nodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagram_nodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = dm_model_diagram_nodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_nodeDA.SetFldValue(clsdm_model_diagram_nodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = dm_model_diagram_nodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_nodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_nodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_nodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[dm_model_diagram_node] "); 
 strCreateTabCode.Append(" ( "); 
 // /**图节点映射ID*/ 
 strCreateTabCode.Append(" diagram_node_id char(8) primary key, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**图ID*/ 
 strCreateTabCode.Append(" diagram_id char(8) not Null, "); 
 // /**阶段结点映射ID*/ 
 strCreateTabCode.Append(" stage_node_map_id char(8) Null, "); 
 // /**结点类型编码*/ 
 strCreateTabCode.Append(" node_type_code varchar(30) Null, "); 
 // /**节点名称*/ 
 strCreateTabCode.Append(" node_label varchar(100) Null, "); 
 // /**X坐标*/ 
 strCreateTabCode.Append(" x_pos int Null, "); 
 // /**Y坐标*/ 
 strCreateTabCode.Append(" y_pos int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**结点样式*/ 
 strCreateTabCode.Append(" node_style varchar(200) Null, "); 
 // /**外形*/ 
 strCreateTabCode.Append(" shape_type varchar(50) Null, "); 
 // /**是否可见*/ 
 strCreateTabCode.Append(" is_visible bit not Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" sort_no int not Null, "); 
 // /**Status*/ 
 strCreateTabCode.Append(" Status varchar(20) not Null, "); 
 // /**创建人*/ 
 strCreateTabCode.Append(" created_by varchar(50) not Null, "); 
 // /**创建时间*/ 
 strCreateTabCode.Append(" created_time datetime not Null, "); 
 // /**更新人*/ 
 strCreateTabCode.Append(" updated_by varchar(50) not Null, "); 
 // /**更新时间*/ 
 strCreateTabCode.Append(" updated_time datetime not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" remark varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据模型图节点映射(dm_model_diagram_node)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4dm_model_diagram_node : clsCommFun4BL
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
clsdm_model_diagram_nodeBL.ReFreshThisCache();
}
}

}