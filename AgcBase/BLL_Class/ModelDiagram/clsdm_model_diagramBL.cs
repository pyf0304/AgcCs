
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagramBL
 表名:dm_model_diagram(00050665)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/18 04:24:51
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
public static class  clsdm_model_diagramBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagramEN GetObj(this K_diagram_id_dm_model_diagram myKey)
{
clsdm_model_diagramEN objdm_model_diagramEN = clsdm_model_diagramBL.dm_model_diagramDA.GetObjBydiagram_id(myKey.Value);
return objdm_model_diagramEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagramEN.diagram_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagramEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],图名称 = [{1}]的数据已经存在!(in clsdm_model_diagramBL.AddNewRecord)", objdm_model_diagramEN.PrjId,objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsdm_model_diagramBL.dm_model_diagramDA.AddNewRecordBySQL2(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
public static bool AddRecordEx(this clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objdm_model_diagramEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objdm_model_diagramEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],图名称(diagram_name)=[{1}])已经存在,不能重复!", objdm_model_diagramEN.PrjId, objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objdm_model_diagramEN.AddNewRecord();
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagramEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],图名称 = [{1}]的数据已经存在!(in clsdm_model_diagramBL.AddNewRecordWithMaxId)", objdm_model_diagramEN.PrjId,objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true || clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id) == true)
 {
     objdm_model_diagramEN.diagram_id = clsdm_model_diagramBL.GetMaxStrIdByPrefix_S(objdm_model_diagramEN.PrjId);
 }
string strdiagram_id = clsdm_model_diagramBL.dm_model_diagramDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagramEN);
     objdm_model_diagramEN.diagram_id = strdiagram_id;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
}
return strdiagram_id;
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagramEN.diagram_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagramEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],图名称 = [{1}]的数据已经存在!(in clsdm_model_diagramBL.AddNewRecordWithReturnKey)", objdm_model_diagramEN.PrjId,objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
try
{
string strKey = clsdm_model_diagramBL.dm_model_diagramDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setdiagram_id(this clsdm_model_diagramEN objdm_model_diagramEN, string strdiagram_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_id, 8, condm_model_diagram.diagram_id);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strdiagram_id, 8, condm_model_diagram.diagram_id);
}
objdm_model_diagramEN.diagram_id = strdiagram_id; //图ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.diagram_id) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.diagram_id, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.diagram_id] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setdiagram_name(this clsdm_model_diagramEN objdm_model_diagramEN, string strdiagram_name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strdiagram_name, condm_model_diagram.diagram_name);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_name, 200, condm_model_diagram.diagram_name);
}
objdm_model_diagramEN.diagram_name = strdiagram_name; //图名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.diagram_name) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.diagram_name, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.diagram_name] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN SetPrjId(this clsdm_model_diagramEN objdm_model_diagramEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, condm_model_diagram.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, condm_model_diagram.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, condm_model_diagram.PrjId);
}
objdm_model_diagramEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.PrjId) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.PrjId, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.PrjId] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setview_type_id(this clsdm_model_diagramEN objdm_model_diagramEN, string strview_type_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strview_type_id, 32, condm_model_diagram.view_type_id);
}
objdm_model_diagramEN.view_type_id = strview_type_id; //视图类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.view_type_id) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.view_type_id, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.view_type_id] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setsubject_scope(this clsdm_model_diagramEN objdm_model_diagramEN, string strsubject_scope, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsubject_scope, condm_model_diagram.subject_scope);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsubject_scope, 100, condm_model_diagram.subject_scope);
}
objdm_model_diagramEN.subject_scope = strsubject_scope; //主题范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.subject_scope) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.subject_scope, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.subject_scope] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setversion_no(this clsdm_model_diagramEN objdm_model_diagramEN, string strversion_no, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strversion_no, condm_model_diagram.version_no);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strversion_no, 20, condm_model_diagram.version_no);
}
objdm_model_diagramEN.version_no = strversion_no; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.version_no) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.version_no, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.version_no] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setzoom_level(this clsdm_model_diagramEN objdm_model_diagramEN, double dblzoom_level, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblzoom_level, condm_model_diagram.zoom_level);
objdm_model_diagramEN.zoom_level = dblzoom_level; //缩放级别
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.zoom_level) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.zoom_level, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.zoom_level] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setpan_x(this clsdm_model_diagramEN objdm_model_diagramEN, double dblpan_x, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblpan_x, condm_model_diagram.pan_x);
objdm_model_diagramEN.pan_x = dblpan_x; //水平偏移
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.pan_x) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.pan_x, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.pan_x] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setpan_y(this clsdm_model_diagramEN objdm_model_diagramEN, double dblpan_y, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblpan_y, condm_model_diagram.pan_y);
objdm_model_diagramEN.pan_y = dblpan_y; //垂直偏移
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.pan_y) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.pan_y, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.pan_y] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setcanvas_width(this clsdm_model_diagramEN objdm_model_diagramEN, int intcanvas_width, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intcanvas_width, condm_model_diagram.canvas_width);
objdm_model_diagramEN.canvas_width = intcanvas_width; //画布宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.canvas_width) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.canvas_width, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.canvas_width] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setcanvas_height(this clsdm_model_diagramEN objdm_model_diagramEN, int intcanvas_height, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intcanvas_height, condm_model_diagram.canvas_height);
objdm_model_diagramEN.canvas_height = intcanvas_height; //画布高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.canvas_height) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.canvas_height, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.canvas_height] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN SetStatus(this clsdm_model_diagramEN objdm_model_diagramEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, condm_model_diagram.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, condm_model_diagram.Status);
}
objdm_model_diagramEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.Status) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.Status, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.Status] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setcreated_by(this clsdm_model_diagramEN objdm_model_diagramEN, string strcreated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcreated_by, condm_model_diagram.created_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreated_by, 50, condm_model_diagram.created_by);
}
objdm_model_diagramEN.created_by = strcreated_by; //创建人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.created_by) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.created_by, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.created_by] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setcreated_time(this clsdm_model_diagramEN objdm_model_diagramEN, DateTime dtecreated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dtecreated_time, condm_model_diagram.created_time);
objdm_model_diagramEN.created_time = dtecreated_time; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.created_time) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.created_time, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.created_time] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setupdated_by(this clsdm_model_diagramEN objdm_model_diagramEN, string strupdated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strupdated_by, condm_model_diagram.updated_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdated_by, 50, condm_model_diagram.updated_by);
}
objdm_model_diagramEN.updated_by = strupdated_by; //更新人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.updated_by) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.updated_by, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.updated_by] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setupdated_time(this clsdm_model_diagramEN objdm_model_diagramEN, DateTime dteupdated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteupdated_time, condm_model_diagram.updated_time);
objdm_model_diagramEN.updated_time = dteupdated_time; //更新时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.updated_time) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.updated_time, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.updated_time] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagramEN Setremark(this clsdm_model_diagramEN objdm_model_diagramEN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 1000, condm_model_diagram.remark);
}
objdm_model_diagramEN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagramEN.dicFldComparisonOp.ContainsKey(condm_model_diagram.remark) == false)
{
objdm_model_diagramEN.dicFldComparisonOp.Add(condm_model_diagram.remark, strComparisonOp);
}
else
{
objdm_model_diagramEN.dicFldComparisonOp[condm_model_diagram.remark] = strComparisonOp;
}
}
return objdm_model_diagramEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsdm_model_diagramEN objdm_model_diagramEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objdm_model_diagramEN.CheckPropertyNew();
clsdm_model_diagramEN objdm_model_diagramCond = new clsdm_model_diagramEN();
string strCondition = objdm_model_diagramCond
.Setdiagram_id(objdm_model_diagramEN.diagram_id, "<>")
.SetPrjId(objdm_model_diagramEN.PrjId, "=")
.Setdiagram_name(objdm_model_diagramEN.diagram_name, "=")
.GetCombineCondition();
objdm_model_diagramEN._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagramBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objdm_model_diagramEN.Update();
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
 /// <param name = "objdm_model_diagram">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsdm_model_diagramEN objdm_model_diagram)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsdm_model_diagramEN objdm_model_diagramCond = new clsdm_model_diagramEN();
string strCondition = objdm_model_diagramCond
.SetPrjId(objdm_model_diagram.PrjId, "=")
.Setdiagram_name(objdm_model_diagram.diagram_name, "=")
.GetCombineCondition();
objdm_model_diagram._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagramBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objdm_model_diagram.diagram_id = clsdm_model_diagramBL.GetFirstID_S(strCondition);
objdm_model_diagram.UpdateWithCondition(strCondition);
}
else
{
objdm_model_diagram.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagramEN objdm_model_diagramEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagramBL.dm_model_diagramDA.UpdateBySql2(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagramEN objdm_model_diagramEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagramBL.dm_model_diagramDA.UpdateBySql2(objdm_model_diagramEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagramEN objdm_model_diagramEN, string strWhereCond)
{
try
{
bool bolResult = clsdm_model_diagramBL.dm_model_diagramDA.UpdateBySqlWithCondition(objdm_model_diagramEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagramEN objdm_model_diagramEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsdm_model_diagramBL.dm_model_diagramDA.UpdateBySqlWithConditionTransaction(objdm_model_diagramEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "strdiagram_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsdm_model_diagramEN objdm_model_diagramEN)
{
try
{
int intRecNum = clsdm_model_diagramBL.dm_model_diagramDA.DelRecord(objdm_model_diagramEN.diagram_id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramENS">源对象</param>
 /// <param name = "objdm_model_diagramENT">目标对象</param>
 public static void CopyTo(this clsdm_model_diagramEN objdm_model_diagramENS, clsdm_model_diagramEN objdm_model_diagramENT)
{
try
{
objdm_model_diagramENT.diagram_id = objdm_model_diagramENS.diagram_id; //图ID
objdm_model_diagramENT.diagram_name = objdm_model_diagramENS.diagram_name; //图名称
objdm_model_diagramENT.PrjId = objdm_model_diagramENS.PrjId; //工程Id
objdm_model_diagramENT.view_type_id = objdm_model_diagramENS.view_type_id; //视图类型ID
objdm_model_diagramENT.subject_scope = objdm_model_diagramENS.subject_scope; //主题范围
objdm_model_diagramENT.version_no = objdm_model_diagramENS.version_no; //版本号
objdm_model_diagramENT.zoom_level = objdm_model_diagramENS.zoom_level; //缩放级别
objdm_model_diagramENT.pan_x = objdm_model_diagramENS.pan_x; //水平偏移
objdm_model_diagramENT.pan_y = objdm_model_diagramENS.pan_y; //垂直偏移
objdm_model_diagramENT.canvas_width = objdm_model_diagramENS.canvas_width; //画布宽
objdm_model_diagramENT.canvas_height = objdm_model_diagramENS.canvas_height; //画布高
objdm_model_diagramENT.Status = objdm_model_diagramENS.Status; //Status
objdm_model_diagramENT.created_by = objdm_model_diagramENS.created_by; //创建人
objdm_model_diagramENT.created_time = objdm_model_diagramENS.created_time; //创建时间
objdm_model_diagramENT.updated_by = objdm_model_diagramENS.updated_by; //更新人
objdm_model_diagramENT.updated_time = objdm_model_diagramENS.updated_time; //更新时间
objdm_model_diagramENT.remark = objdm_model_diagramENS.remark; //备注
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
 /// <param name = "objdm_model_diagramENS">源对象</param>
 /// <returns>目标对象=>clsdm_model_diagramEN:objdm_model_diagramENT</returns>
 public static clsdm_model_diagramEN CopyTo(this clsdm_model_diagramEN objdm_model_diagramENS)
{
try
{
 clsdm_model_diagramEN objdm_model_diagramENT = new clsdm_model_diagramEN()
{
diagram_id = objdm_model_diagramENS.diagram_id, //图ID
diagram_name = objdm_model_diagramENS.diagram_name, //图名称
PrjId = objdm_model_diagramENS.PrjId, //工程Id
view_type_id = objdm_model_diagramENS.view_type_id, //视图类型ID
subject_scope = objdm_model_diagramENS.subject_scope, //主题范围
version_no = objdm_model_diagramENS.version_no, //版本号
zoom_level = objdm_model_diagramENS.zoom_level, //缩放级别
pan_x = objdm_model_diagramENS.pan_x, //水平偏移
pan_y = objdm_model_diagramENS.pan_y, //垂直偏移
canvas_width = objdm_model_diagramENS.canvas_width, //画布宽
canvas_height = objdm_model_diagramENS.canvas_height, //画布高
Status = objdm_model_diagramENS.Status, //Status
created_by = objdm_model_diagramENS.created_by, //创建人
created_time = objdm_model_diagramENS.created_time, //创建时间
updated_by = objdm_model_diagramENS.updated_by, //更新人
updated_time = objdm_model_diagramENS.updated_time, //更新时间
remark = objdm_model_diagramENS.remark, //备注
};
 return objdm_model_diagramENT;
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
public static void CheckPropertyNew(this clsdm_model_diagramEN objdm_model_diagramEN)
{
 clsdm_model_diagramBL.dm_model_diagramDA.CheckPropertyNew(objdm_model_diagramEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsdm_model_diagramEN objdm_model_diagramEN)
{
 clsdm_model_diagramBL.dm_model_diagramDA.CheckProperty4Condition(objdm_model_diagramEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsdm_model_diagramEN objdm_model_diagramCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.diagram_id) == true)
{
string strComparisonOpdiagram_id = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.diagram_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.diagram_id, objdm_model_diagramCond.diagram_id, strComparisonOpdiagram_id);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.diagram_name) == true)
{
string strComparisonOpdiagram_name = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.diagram_name];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.diagram_name, objdm_model_diagramCond.diagram_name, strComparisonOpdiagram_name);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.PrjId) == true)
{
string strComparisonOpPrjId = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.PrjId, objdm_model_diagramCond.PrjId, strComparisonOpPrjId);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.view_type_id) == true)
{
string strComparisonOpview_type_id = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.view_type_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.view_type_id, objdm_model_diagramCond.view_type_id, strComparisonOpview_type_id);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.subject_scope) == true)
{
string strComparisonOpsubject_scope = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.subject_scope];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.subject_scope, objdm_model_diagramCond.subject_scope, strComparisonOpsubject_scope);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.version_no) == true)
{
string strComparisonOpversion_no = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.version_no];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.version_no, objdm_model_diagramCond.version_no, strComparisonOpversion_no);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.zoom_level) == true)
{
string strComparisonOpzoom_level = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.zoom_level];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram.zoom_level, objdm_model_diagramCond.zoom_level, strComparisonOpzoom_level);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.pan_x) == true)
{
string strComparisonOppan_x = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.pan_x];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram.pan_x, objdm_model_diagramCond.pan_x, strComparisonOppan_x);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.pan_y) == true)
{
string strComparisonOppan_y = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.pan_y];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram.pan_y, objdm_model_diagramCond.pan_y, strComparisonOppan_y);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.canvas_width) == true)
{
string strComparisonOpcanvas_width = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.canvas_width];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram.canvas_width, objdm_model_diagramCond.canvas_width, strComparisonOpcanvas_width);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.canvas_height) == true)
{
string strComparisonOpcanvas_height = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.canvas_height];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram.canvas_height, objdm_model_diagramCond.canvas_height, strComparisonOpcanvas_height);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.Status) == true)
{
string strComparisonOpStatus = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.Status, objdm_model_diagramCond.Status, strComparisonOpStatus);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.created_by) == true)
{
string strComparisonOpcreated_by = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.created_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.created_by, objdm_model_diagramCond.created_by, strComparisonOpcreated_by);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.created_time) == true)
{
string strComparisonOpcreated_time = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.created_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.created_time, objdm_model_diagramCond.created_time, strComparisonOpcreated_time);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.updated_by) == true)
{
string strComparisonOpupdated_by = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.updated_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.updated_by, objdm_model_diagramCond.updated_by, strComparisonOpupdated_by);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.updated_time) == true)
{
string strComparisonOpupdated_time = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.updated_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.updated_time, objdm_model_diagramCond.updated_time, strComparisonOpupdated_time);
}
if (objdm_model_diagramCond.IsUpdated(condm_model_diagram.remark) == true)
{
string strComparisonOpremark = objdm_model_diagramCond.dicFldComparisonOp[condm_model_diagram.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram.remark, objdm_model_diagramCond.remark, strComparisonOpremark);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--dm_model_diagram(数据模型图定义), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:diagram_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsdm_model_diagramEN objdm_model_diagramEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagramEN == null) return true;
if (objdm_model_diagramEN.diagram_id == null || objdm_model_diagramEN.diagram_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objdm_model_diagramEN.PrjId);
 sbCondition.AppendFormat(" and diagram_name = '{0}'", objdm_model_diagramEN.diagram_name);
if (clsdm_model_diagramBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("diagram_id !=  '{0}'", objdm_model_diagramEN.diagram_id);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objdm_model_diagramEN.PrjId);
 sbCondition.AppendFormat(" and diagram_name = '{0}'", objdm_model_diagramEN.diagram_name);
if (clsdm_model_diagramBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--dm_model_diagram(数据模型图定义), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:diagram_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsdm_model_diagramEN objdm_model_diagramEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagramEN == null) return "";
if (objdm_model_diagramEN.diagram_id == null || objdm_model_diagramEN.diagram_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objdm_model_diagramEN.PrjId);
 sbCondition.AppendFormat(" and diagram_name = '{0}'", objdm_model_diagramEN.diagram_name);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("diagram_id !=  '{0}'", objdm_model_diagramEN.diagram_id);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objdm_model_diagramEN.PrjId);
 sbCondition.AppendFormat(" and diagram_name = '{0}'", objdm_model_diagramEN.diagram_name);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_dm_model_diagram
{
public virtual bool UpdRelaTabDate(string strdiagram_id, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据模型图定义(dm_model_diagram)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsdm_model_diagramBL
{
public static RelatedActions_dm_model_diagram relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsdm_model_diagramDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsdm_model_diagramDA dm_model_diagramDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsdm_model_diagramDA();
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
 public clsdm_model_diagramBL()
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
if (string.IsNullOrEmpty(clsdm_model_diagramEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_diagramEN._ConnectString);
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
public static DataTable GetDataTable_dm_model_diagram(string strWhereCond)
{
DataTable objDT;
try
{
objDT = dm_model_diagramDA.GetDataTable_dm_model_diagram(strWhereCond);
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
objDT = dm_model_diagramDA.GetDataTable(strWhereCond);
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
objDT = dm_model_diagramDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = dm_model_diagramDA.GetDataTable(strWhereCond, strTabName);
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
objDT = dm_model_diagramDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = dm_model_diagramDA.GetDataTable_Top(objTopPara);
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
objDT = dm_model_diagramDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = dm_model_diagramDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = dm_model_diagramDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDiagram_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsdm_model_diagramEN> GetObjLstByDiagram_idLst(List<string> arrDiagram_idLst)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDiagram_idLst, true);
 string strWhereCond = string.Format("diagram_id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDiagram_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsdm_model_diagramEN> GetObjLstByDiagram_idLstCache(List<string> arrDiagram_idLst)
{
string strKey = string.Format("{0}", clsdm_model_diagramEN._CurrTabName);
List<clsdm_model_diagramEN> arrdm_model_diagramObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagramEN> arrdm_model_diagramObjLst_Sel =
arrdm_model_diagramObjLstCache
.Where(x => arrDiagram_idLst.Contains(x.diagram_id));
return arrdm_model_diagramObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagramEN> GetObjLst(string strWhereCond)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
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
public static List<clsdm_model_diagramEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objdm_model_diagramCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsdm_model_diagramEN> GetSubObjLstCache(clsdm_model_diagramEN objdm_model_diagramCond)
{
List<clsdm_model_diagramEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagramEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram._AttributeName)
{
if (objdm_model_diagramCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagramCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagramCond[strFldName].ToString());
}
else
{
if (objdm_model_diagramCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagramCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagramCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagramCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagramCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagramCond[strFldName]));
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
public static List<clsdm_model_diagramEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
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
public static List<clsdm_model_diagramEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
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
List<clsdm_model_diagramEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsdm_model_diagramEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagramEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsdm_model_diagramEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
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
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
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
public static List<clsdm_model_diagramEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsdm_model_diagramEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsdm_model_diagramEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
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
public static List<clsdm_model_diagramEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagramEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsdm_model_diagramEN> arrObjLst = new List<clsdm_model_diagramEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagramEN objdm_model_diagramEN = new clsdm_model_diagramEN();
try
{
objdm_model_diagramEN.diagram_id = objRow[condm_model_diagram.diagram_id].ToString().Trim(); //图ID
objdm_model_diagramEN.diagram_name = objRow[condm_model_diagram.diagram_name].ToString().Trim(); //图名称
objdm_model_diagramEN.PrjId = objRow[condm_model_diagram.PrjId].ToString().Trim(); //工程Id
objdm_model_diagramEN.view_type_id = objRow[condm_model_diagram.view_type_id] == DBNull.Value ? null : objRow[condm_model_diagram.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_diagramEN.subject_scope = objRow[condm_model_diagram.subject_scope].ToString().Trim(); //主题范围
objdm_model_diagramEN.version_no = objRow[condm_model_diagram.version_no].ToString().Trim(); //版本号
objdm_model_diagramEN.zoom_level = Double.Parse(objRow[condm_model_diagram.zoom_level].ToString().Trim()); //缩放级别
objdm_model_diagramEN.pan_x = Double.Parse(objRow[condm_model_diagram.pan_x].ToString().Trim()); //水平偏移
objdm_model_diagramEN.pan_y = Double.Parse(objRow[condm_model_diagram.pan_y].ToString().Trim()); //垂直偏移
objdm_model_diagramEN.canvas_width = Int32.Parse(objRow[condm_model_diagram.canvas_width].ToString().Trim()); //画布宽
objdm_model_diagramEN.canvas_height = Int32.Parse(objRow[condm_model_diagram.canvas_height].ToString().Trim()); //画布高
objdm_model_diagramEN.Status = objRow[condm_model_diagram.Status].ToString().Trim(); //Status
objdm_model_diagramEN.created_by = objRow[condm_model_diagram.created_by].ToString().Trim(); //创建人
objdm_model_diagramEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram.created_time].ToString().Trim()); //创建时间
objdm_model_diagramEN.updated_by = objRow[condm_model_diagram.updated_by].ToString().Trim(); //更新人
objdm_model_diagramEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram.updated_time].ToString().Trim()); //更新时间
objdm_model_diagramEN.remark = objRow[condm_model_diagram.remark] == DBNull.Value ? null : objRow[condm_model_diagram.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagramEN.diagram_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagramEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getdm_model_diagram(ref clsdm_model_diagramEN objdm_model_diagramEN)
{
bool bolResult = dm_model_diagramDA.Getdm_model_diagram(ref objdm_model_diagramEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagramEN GetObjBydiagram_id(string strdiagram_id)
{
if (strdiagram_id.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strdiagram_id]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strdiagram_id) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strdiagram_id]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsdm_model_diagramEN objdm_model_diagramEN = dm_model_diagramDA.GetObjBydiagram_id(strdiagram_id);
return objdm_model_diagramEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsdm_model_diagramEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsdm_model_diagramEN objdm_model_diagramEN = dm_model_diagramDA.GetFirstObj(strWhereCond);
 return objdm_model_diagramEN;
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
public static clsdm_model_diagramEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsdm_model_diagramEN objdm_model_diagramEN = dm_model_diagramDA.GetObjByDataRow(objRow);
 return objdm_model_diagramEN;
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
public static clsdm_model_diagramEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsdm_model_diagramEN objdm_model_diagramEN = dm_model_diagramDA.GetObjByDataRow(objRow);
 return objdm_model_diagramEN;
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
 /// <param name = "strdiagram_id">所给的关键字</param>
 /// <param name = "lstdm_model_diagramObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagramEN GetObjBydiagram_idFromList(string strdiagram_id, List<clsdm_model_diagramEN> lstdm_model_diagramObjLst)
{
foreach (clsdm_model_diagramEN objdm_model_diagramEN in lstdm_model_diagramObjLst)
{
if (objdm_model_diagramEN.diagram_id == strdiagram_id)
{
return objdm_model_diagramEN;
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
 string strMaxDiagram_id;
 try
 {
 strMaxDiagram_id = new clsdm_model_diagramDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxDiagram_id;
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
 string strdiagram_id;
 try
 {
 strdiagram_id = new clsdm_model_diagramDA().GetFirstID(strWhereCond);
 return strdiagram_id;
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
 arrList = dm_model_diagramDA.GetID(strWhereCond);
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
bool bolIsExist = dm_model_diagramDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strdiagram_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strdiagram_id)
{
if (string.IsNullOrEmpty(strdiagram_id) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strdiagram_id]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = dm_model_diagramDA.IsExist(strdiagram_id);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strdiagram_id">图ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strdiagram_id, string strOpUser)
{
clsdm_model_diagramEN objdm_model_diagramEN = clsdm_model_diagramBL.GetObjBydiagram_id(strdiagram_id);
objdm_model_diagramEN.created_time = new DateTime();
objdm_model_diagramEN.created_by = strOpUser;
return clsdm_model_diagramBL.UpdateBySql2(objdm_model_diagramEN);
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
 bolIsExist = clsdm_model_diagramDA.IsExistTable();
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
 bolIsExist = dm_model_diagramDA.IsExistTable(strTabName);
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagramEN.diagram_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objdm_model_diagramEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],图名称 = [{1}]的数据已经存在!(in clsdm_model_diagramBL.AddNewRecordBySql2)", objdm_model_diagramEN.PrjId,objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
try
{
bool bolResult = dm_model_diagramDA.AddNewRecordBySQL2(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsdm_model_diagramEN objdm_model_diagramEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_diagramBL.IsExist(objdm_model_diagramEN.diagram_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_diagramEN.diagram_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objdm_model_diagramEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],图名称 = [{1}]的数据已经存在!(in clsdm_model_diagramBL.AddNewRecordBySql2WithReturnKey)", objdm_model_diagramEN.PrjId,objdm_model_diagramEN.diagram_name);
throw new Exception(strMsg);
}
try
{
string strKey = dm_model_diagramDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsdm_model_diagramEN objdm_model_diagramEN)
{
try
{
bool bolResult = dm_model_diagramDA.Update(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "objdm_model_diagramEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsdm_model_diagramEN objdm_model_diagramEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagramEN.diagram_id) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = dm_model_diagramDA.UpdateBySql2(objdm_model_diagramEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagramBL.ReFreshCache();

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
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
 /// <param name = "strdiagram_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strdiagram_id)
{
try
{
 clsdm_model_diagramEN objdm_model_diagramEN = clsdm_model_diagramBL.GetObjBydiagram_id(strdiagram_id);

if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(objdm_model_diagramEN.diagram_id, objdm_model_diagramEN.created_by);
}
if (objdm_model_diagramEN != null)
{
int intRecNum = dm_model_diagramDA.DelRecord(strdiagram_id);
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
/// <param name="strdiagram_id">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strdiagram_id )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagramDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//condm_model_diagram.diagram_id,
//strdiagram_id);
//        clsdm_model_diagramBL.Deldm_model_diagramsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagramBL.DelRecord(strdiagram_id, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagramBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strdiagram_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strdiagram_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsdm_model_diagramBL.relatedActions != null)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(strdiagram_id, "UpdRelaTabDate");
}
bool bolResult = dm_model_diagramDA.DelRecord(strdiagram_id,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrdiagram_idLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deldm_model_diagrams(List<string> arrdiagram_idLst)
{
if (arrdiagram_idLst.Count == 0) return 0;
try
{
if (clsdm_model_diagramBL.relatedActions != null)
{
foreach (var strdiagram_id in arrdiagram_idLst)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(strdiagram_id, "UpdRelaTabDate");
}
}
int intDelRecNum = dm_model_diagramDA.Deldm_model_diagram(arrdiagram_idLst);
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
public static int Deldm_model_diagramsByCond(string strWhereCond)
{
try
{
if (clsdm_model_diagramBL.relatedActions != null)
{
List<string> arrdiagram_id = GetPrimaryKeyID_S(strWhereCond);
foreach (var strdiagram_id in arrdiagram_id)
{
clsdm_model_diagramBL.relatedActions.UpdRelaTabDate(strdiagram_id, "UpdRelaTabDate");
}
}
int intRecNum = dm_model_diagramDA.Deldm_model_diagram(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[dm_model_diagram]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strdiagram_id">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strdiagram_id)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagramDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagramBL.DelRecord(strdiagram_id, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagramBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objdm_model_diagramENS">源对象</param>
 /// <param name = "objdm_model_diagramENT">目标对象</param>
 public static void CopyTo(clsdm_model_diagramEN objdm_model_diagramENS, clsdm_model_diagramEN objdm_model_diagramENT)
{
try
{
objdm_model_diagramENT.diagram_id = objdm_model_diagramENS.diagram_id; //图ID
objdm_model_diagramENT.diagram_name = objdm_model_diagramENS.diagram_name; //图名称
objdm_model_diagramENT.PrjId = objdm_model_diagramENS.PrjId; //工程Id
objdm_model_diagramENT.view_type_id = objdm_model_diagramENS.view_type_id; //视图类型ID
objdm_model_diagramENT.subject_scope = objdm_model_diagramENS.subject_scope; //主题范围
objdm_model_diagramENT.version_no = objdm_model_diagramENS.version_no; //版本号
objdm_model_diagramENT.zoom_level = objdm_model_diagramENS.zoom_level; //缩放级别
objdm_model_diagramENT.pan_x = objdm_model_diagramENS.pan_x; //水平偏移
objdm_model_diagramENT.pan_y = objdm_model_diagramENS.pan_y; //垂直偏移
objdm_model_diagramENT.canvas_width = objdm_model_diagramENS.canvas_width; //画布宽
objdm_model_diagramENT.canvas_height = objdm_model_diagramENS.canvas_height; //画布高
objdm_model_diagramENT.Status = objdm_model_diagramENS.Status; //Status
objdm_model_diagramENT.created_by = objdm_model_diagramENS.created_by; //创建人
objdm_model_diagramENT.created_time = objdm_model_diagramENS.created_time; //创建时间
objdm_model_diagramENT.updated_by = objdm_model_diagramENS.updated_by; //更新人
objdm_model_diagramENT.updated_time = objdm_model_diagramENS.updated_time; //更新时间
objdm_model_diagramENT.remark = objdm_model_diagramENS.remark; //备注
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
 /// <param name = "objdm_model_diagramEN">源简化对象</param>
 public static void SetUpdFlag(clsdm_model_diagramEN objdm_model_diagramEN)
{
try
{
objdm_model_diagramEN.ClearUpdateState();
   string strsfUpdFldSetStr = objdm_model_diagramEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(condm_model_diagram.diagram_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.diagram_id = objdm_model_diagramEN.diagram_id; //图ID
}
if (arrFldSet.Contains(condm_model_diagram.diagram_name, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.diagram_name = objdm_model_diagramEN.diagram_name; //图名称
}
if (arrFldSet.Contains(condm_model_diagram.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.PrjId = objdm_model_diagramEN.PrjId; //工程Id
}
if (arrFldSet.Contains(condm_model_diagram.view_type_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.view_type_id = objdm_model_diagramEN.view_type_id == "[null]" ? null :  objdm_model_diagramEN.view_type_id; //视图类型ID
}
if (arrFldSet.Contains(condm_model_diagram.subject_scope, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.subject_scope = objdm_model_diagramEN.subject_scope; //主题范围
}
if (arrFldSet.Contains(condm_model_diagram.version_no, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.version_no = objdm_model_diagramEN.version_no; //版本号
}
if (arrFldSet.Contains(condm_model_diagram.zoom_level, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.zoom_level = objdm_model_diagramEN.zoom_level; //缩放级别
}
if (arrFldSet.Contains(condm_model_diagram.pan_x, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.pan_x = objdm_model_diagramEN.pan_x; //水平偏移
}
if (arrFldSet.Contains(condm_model_diagram.pan_y, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.pan_y = objdm_model_diagramEN.pan_y; //垂直偏移
}
if (arrFldSet.Contains(condm_model_diagram.canvas_width, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.canvas_width = objdm_model_diagramEN.canvas_width; //画布宽
}
if (arrFldSet.Contains(condm_model_diagram.canvas_height, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.canvas_height = objdm_model_diagramEN.canvas_height; //画布高
}
if (arrFldSet.Contains(condm_model_diagram.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.Status = objdm_model_diagramEN.Status; //Status
}
if (arrFldSet.Contains(condm_model_diagram.created_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.created_by = objdm_model_diagramEN.created_by; //创建人
}
if (arrFldSet.Contains(condm_model_diagram.created_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.created_time = objdm_model_diagramEN.created_time; //创建时间
}
if (arrFldSet.Contains(condm_model_diagram.updated_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.updated_by = objdm_model_diagramEN.updated_by; //更新人
}
if (arrFldSet.Contains(condm_model_diagram.updated_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.updated_time = objdm_model_diagramEN.updated_time; //更新时间
}
if (arrFldSet.Contains(condm_model_diagram.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagramEN.remark = objdm_model_diagramEN.remark == "[null]" ? null :  objdm_model_diagramEN.remark; //备注
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
 /// <param name = "objdm_model_diagramEN">源简化对象</param>
 public static void AccessFldValueNull(clsdm_model_diagramEN objdm_model_diagramEN)
{
try
{
if (objdm_model_diagramEN.view_type_id == "[null]") objdm_model_diagramEN.view_type_id = null; //视图类型ID
if (objdm_model_diagramEN.remark == "[null]") objdm_model_diagramEN.remark = null; //备注
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
public static void CheckPropertyNew(clsdm_model_diagramEN objdm_model_diagramEN)
{
 dm_model_diagramDA.CheckPropertyNew(objdm_model_diagramEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsdm_model_diagramEN objdm_model_diagramEN)
{
 dm_model_diagramDA.CheckProperty4Condition(objdm_model_diagramEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_diagram_idCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据模型图定义]...","0");
List<clsdm_model_diagramEN> arrdm_model_diagramObjLst = GetAlldm_model_diagramObjLstCache(); 
objDDL.DataValueField = condm_model_diagram.diagram_id;
objDDL.DataTextField = condm_model_diagram.diagram_name;
objDDL.DataSource = arrdm_model_diagramObjLst;
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
if (clsdm_model_diagramBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsdm_model_diagramBL没有刷新缓存机制(clsdm_model_diagramBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by diagram_id");
//if (arrdm_model_diagramObjLstCache == null)
//{
//arrdm_model_diagramObjLstCache = dm_model_diagramDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strdiagram_id">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagramEN GetObjBydiagram_idCache(string strdiagram_id)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsdm_model_diagramEN._CurrTabName);
List<clsdm_model_diagramEN> arrdm_model_diagramObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagramEN> arrdm_model_diagramObjLst_Sel =
arrdm_model_diagramObjLstCache
.Where(x=> x.diagram_id == strdiagram_id 
);
if (arrdm_model_diagramObjLst_Sel.Count() == 0)
{
   clsdm_model_diagramEN obj = clsdm_model_diagramBL.GetObjBydiagram_id(strdiagram_id);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrdm_model_diagramObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strdiagram_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string Getdiagram_nameBydiagram_idCache(string strdiagram_id)
{
if (string.IsNullOrEmpty(strdiagram_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_diagramEN objdm_model_diagram = GetObjBydiagram_idCache(strdiagram_id);
if (objdm_model_diagram == null) return "";
return objdm_model_diagram.diagram_name;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strdiagram_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBydiagram_idCache(string strdiagram_id)
{
if (string.IsNullOrEmpty(strdiagram_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_diagramEN objdm_model_diagram = GetObjBydiagram_idCache(strdiagram_id);
if (objdm_model_diagram == null) return "";
return objdm_model_diagram.diagram_name;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagramEN> GetAlldm_model_diagramObjLstCache()
{
//获取缓存中的对象列表
List<clsdm_model_diagramEN> arrdm_model_diagramObjLstCache = GetObjLstCache(); 
return arrdm_model_diagramObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagramEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsdm_model_diagramEN._CurrTabName);
List<clsdm_model_diagramEN> arrdm_model_diagramObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrdm_model_diagramObjLstCache;
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
string strKey = string.Format("{0}", clsdm_model_diagramEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagramEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsdm_model_diagramEN._RefreshTimeLst.Count == 0) return "";
return clsdm_model_diagramEN._RefreshTimeLst[clsdm_model_diagramEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsdm_model_diagramBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsdm_model_diagramEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagramEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsdm_model_diagramBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--dm_model_diagram(数据模型图定义)
 /// 唯一性条件:diagram_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_diagramEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsdm_model_diagramEN objdm_model_diagramEN)
{
//检测记录是否存在
string strResult = dm_model_diagramDA.GetUniCondStr(objdm_model_diagramEN);
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
public static string Func(string strInFldName, string strOutFldName, string strdiagram_id)
{
if (strInFldName != condm_model_diagram.diagram_id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (condm_model_diagram._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", condm_model_diagram._AttributeName));
throw new Exception(strMsg);
}
var objdm_model_diagram = clsdm_model_diagramBL.GetObjBydiagram_idCache(strdiagram_id);
if (objdm_model_diagram == null) return "";
return objdm_model_diagram[strOutFldName].ToString();
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
int intRecCount = clsdm_model_diagramDA.GetRecCount(strTabName);
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
int intRecCount = clsdm_model_diagramDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsdm_model_diagramDA.GetRecCount();
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
int intRecCount = clsdm_model_diagramDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objdm_model_diagramCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsdm_model_diagramEN objdm_model_diagramCond)
{
List<clsdm_model_diagramEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagramEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram._AttributeName)
{
if (objdm_model_diagramCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagramCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagramCond[strFldName].ToString());
}
else
{
if (objdm_model_diagramCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagramCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagramCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagramCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagramCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagramCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagramCond[strFldName]));
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
 List<string> arrList = clsdm_model_diagramDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagramDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagramDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = dm_model_diagramDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagramDA.SetFldValue(clsdm_model_diagramEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = dm_model_diagramDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagramDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagramDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagramDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[dm_model_diagram] "); 
 strCreateTabCode.Append(" ( "); 
 // /**图ID*/ 
 strCreateTabCode.Append(" diagram_id char(8) primary key, "); 
 // /**图名称*/ 
 strCreateTabCode.Append(" diagram_name varchar(200) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**视图类型ID*/ 
 strCreateTabCode.Append(" view_type_id varchar(32) Null, "); 
 // /**主题范围*/ 
 strCreateTabCode.Append(" subject_scope varchar(100) not Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" version_no varchar(20) not Null, "); 
 // /**缩放级别*/ 
 strCreateTabCode.Append(" zoom_level decimal(10,2) not Null, "); 
 // /**水平偏移*/ 
 strCreateTabCode.Append(" pan_x decimal(12,2) not Null, "); 
 // /**垂直偏移*/ 
 strCreateTabCode.Append(" pan_y decimal(12,2) not Null, "); 
 // /**画布宽*/ 
 strCreateTabCode.Append(" canvas_width int not Null, "); 
 // /**画布高*/ 
 strCreateTabCode.Append(" canvas_height int not Null, "); 
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
 strCreateTabCode.Append(" remark varchar(1000) Null, "); 
 // /**视图类型名称*/ 
 strCreateTabCode.Append(" view_type_name varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据模型图定义(dm_model_diagram)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4dm_model_diagram : clsCommFun4BL
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
clsdm_model_diagramBL.ReFreshThisCache();
}
}

}