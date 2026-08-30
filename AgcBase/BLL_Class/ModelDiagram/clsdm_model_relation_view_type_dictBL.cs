
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_relation_view_type_dictBL
 表名:dm_model_relation_view_type_dict(00050667)
 * 版本:2026.08.13(服务器:WIN-SRV103-116)
 日期:2026/08/13 18:21:45
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
public static class  clsdm_model_relation_view_type_dictBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strview_type_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_relation_view_type_dictEN GetObj(this K_view_type_id_dm_model_relation_view_type_dict myKey)
{
clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.GetObjByview_type_id(myKey.Value);
return objdm_model_relation_view_type_dictEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_relation_view_type_dictBL.IsExist(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_relation_view_type_dictEN.view_type_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.AddNewRecordBySQL2(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
public static bool AddRecordEx(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsdm_model_relation_view_type_dictBL.IsExist(objdm_model_relation_view_type_dictEN.view_type_id))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objdm_model_relation_view_type_dictEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objdm_model_relation_view_type_dictEN.AddNewRecord();
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_relation_view_type_dictBL.IsExist(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_relation_view_type_dictEN.view_type_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.AddNewRecordBySQL2WithReturnKey(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setview_type_id(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strview_type_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strview_type_id, 32, condm_model_relation_view_type_dict.view_type_id);
}
objdm_model_relation_view_type_dictEN.view_type_id = strview_type_id; //视图类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.view_type_id) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.view_type_id, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_id] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setview_type_code(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strview_type_code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strview_type_code, condm_model_relation_view_type_dict.view_type_code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strview_type_code, 30, condm_model_relation_view_type_dict.view_type_code);
}
objdm_model_relation_view_type_dictEN.view_type_code = strview_type_code; //视图类型编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.view_type_code) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.view_type_code, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_code] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setview_type_name(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strview_type_name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strview_type_name, condm_model_relation_view_type_dict.view_type_name);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strview_type_name, 50, condm_model_relation_view_type_dict.view_type_name);
}
objdm_model_relation_view_type_dictEN.view_type_name = strview_type_name; //视图类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.view_type_name) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.view_type_name, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_name] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setview_type_desc(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strview_type_desc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strview_type_desc, 300, condm_model_relation_view_type_dict.view_type_desc);
}
objdm_model_relation_view_type_dictEN.view_type_desc = strview_type_desc; //视图类型说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.view_type_desc) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.view_type_desc, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_desc] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setis_active(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolis_active, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolis_active, condm_model_relation_view_type_dict.is_active);
objdm_model_relation_view_type_dictEN.is_active = bolis_active; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.is_active) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.is_active, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.is_active] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setsort_no(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, int intsort_no, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intsort_no, condm_model_relation_view_type_dict.sort_no);
objdm_model_relation_view_type_dictEN.sort_no = intsort_no; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.sort_no) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.sort_no, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.sort_no] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN SetStatus(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, condm_model_relation_view_type_dict.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, condm_model_relation_view_type_dict.Status);
}
objdm_model_relation_view_type_dictEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.Status) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.Status, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.Status] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setcreated_by(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strcreated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcreated_by, condm_model_relation_view_type_dict.created_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreated_by, 50, condm_model_relation_view_type_dict.created_by);
}
objdm_model_relation_view_type_dictEN.created_by = strcreated_by; //创建人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.created_by) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.created_by, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.created_by] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setcreated_time(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, DateTime dtecreated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dtecreated_time, condm_model_relation_view_type_dict.created_time);
objdm_model_relation_view_type_dictEN.created_time = dtecreated_time; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.created_time) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.created_time, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.created_time] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setupdated_by(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strupdated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strupdated_by, condm_model_relation_view_type_dict.updated_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdated_by, 50, condm_model_relation_view_type_dict.updated_by);
}
objdm_model_relation_view_type_dictEN.updated_by = strupdated_by; //更新人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.updated_by) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.updated_by, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.updated_by] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setupdated_time(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, DateTime dteupdated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteupdated_time, condm_model_relation_view_type_dict.updated_time);
objdm_model_relation_view_type_dictEN.updated_time = dteupdated_time; //更新时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.updated_time) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.updated_time, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.updated_time] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_relation_view_type_dictEN Setremark(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 500, condm_model_relation_view_type_dict.remark);
}
objdm_model_relation_view_type_dictEN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_relation_view_type_dictEN.dicFldComparisonOp.ContainsKey(condm_model_relation_view_type_dict.remark) == false)
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp.Add(condm_model_relation_view_type_dict.remark, strComparisonOp);
}
else
{
objdm_model_relation_view_type_dictEN.dicFldComparisonOp[condm_model_relation_view_type_dict.remark] = strComparisonOp;
}
}
return objdm_model_relation_view_type_dictEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objdm_model_relation_view_type_dictEN.CheckPropertyNew();
clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictCond = new clsdm_model_relation_view_type_dictEN();
string strCondition = objdm_model_relation_view_type_dictCond
.Setview_type_id(objdm_model_relation_view_type_dictEN.view_type_id, "=")
.GetCombineCondition();
objdm_model_relation_view_type_dictEN._IsCheckProperty = true;
bool bolIsExist = clsdm_model_relation_view_type_dictBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objdm_model_relation_view_type_dictEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.UpdateBySql2(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.UpdateBySql2(objdm_model_relation_view_type_dictEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strWhereCond)
{
try
{
bool bolResult = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.UpdateBySqlWithCondition(objdm_model_relation_view_type_dictEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.UpdateBySqlWithConditionTransaction(objdm_model_relation_view_type_dictEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "strview_type_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
try
{
int intRecNum = clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.DelRecord(objdm_model_relation_view_type_dictEN.view_type_id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictENS">源对象</param>
 /// <param name = "objdm_model_relation_view_type_dictENT">目标对象</param>
 public static void CopyTo(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENS, clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENT)
{
try
{
objdm_model_relation_view_type_dictENT.view_type_id = objdm_model_relation_view_type_dictENS.view_type_id; //视图类型ID
objdm_model_relation_view_type_dictENT.view_type_code = objdm_model_relation_view_type_dictENS.view_type_code; //视图类型编码
objdm_model_relation_view_type_dictENT.view_type_name = objdm_model_relation_view_type_dictENS.view_type_name; //视图类型名称
objdm_model_relation_view_type_dictENT.view_type_desc = objdm_model_relation_view_type_dictENS.view_type_desc; //视图类型说明
objdm_model_relation_view_type_dictENT.is_active = objdm_model_relation_view_type_dictENS.is_active; //是否启用
objdm_model_relation_view_type_dictENT.sort_no = objdm_model_relation_view_type_dictENS.sort_no; //排序号
objdm_model_relation_view_type_dictENT.Status = objdm_model_relation_view_type_dictENS.Status; //Status
objdm_model_relation_view_type_dictENT.created_by = objdm_model_relation_view_type_dictENS.created_by; //创建人
objdm_model_relation_view_type_dictENT.created_time = objdm_model_relation_view_type_dictENS.created_time; //创建时间
objdm_model_relation_view_type_dictENT.updated_by = objdm_model_relation_view_type_dictENS.updated_by; //更新人
objdm_model_relation_view_type_dictENT.updated_time = objdm_model_relation_view_type_dictENS.updated_time; //更新时间
objdm_model_relation_view_type_dictENT.remark = objdm_model_relation_view_type_dictENS.remark; //备注
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
 /// <param name = "objdm_model_relation_view_type_dictENS">源对象</param>
 /// <returns>目标对象=>clsdm_model_relation_view_type_dictEN:objdm_model_relation_view_type_dictENT</returns>
 public static clsdm_model_relation_view_type_dictEN CopyTo(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENS)
{
try
{
 clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENT = new clsdm_model_relation_view_type_dictEN()
{
view_type_id = objdm_model_relation_view_type_dictENS.view_type_id, //视图类型ID
view_type_code = objdm_model_relation_view_type_dictENS.view_type_code, //视图类型编码
view_type_name = objdm_model_relation_view_type_dictENS.view_type_name, //视图类型名称
view_type_desc = objdm_model_relation_view_type_dictENS.view_type_desc, //视图类型说明
is_active = objdm_model_relation_view_type_dictENS.is_active, //是否启用
sort_no = objdm_model_relation_view_type_dictENS.sort_no, //排序号
Status = objdm_model_relation_view_type_dictENS.Status, //Status
created_by = objdm_model_relation_view_type_dictENS.created_by, //创建人
created_time = objdm_model_relation_view_type_dictENS.created_time, //创建时间
updated_by = objdm_model_relation_view_type_dictENS.updated_by, //更新人
updated_time = objdm_model_relation_view_type_dictENS.updated_time, //更新时间
remark = objdm_model_relation_view_type_dictENS.remark, //备注
};
 return objdm_model_relation_view_type_dictENT;
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
public static void CheckPropertyNew(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.CheckPropertyNew(objdm_model_relation_view_type_dictEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 clsdm_model_relation_view_type_dictBL.dm_model_relation_view_type_dictDA.CheckProperty4Condition(objdm_model_relation_view_type_dictEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.view_type_id) == true)
{
string strComparisonOpview_type_id = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.view_type_id, objdm_model_relation_view_type_dictCond.view_type_id, strComparisonOpview_type_id);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.view_type_code) == true)
{
string strComparisonOpview_type_code = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_code];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.view_type_code, objdm_model_relation_view_type_dictCond.view_type_code, strComparisonOpview_type_code);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.view_type_name) == true)
{
string strComparisonOpview_type_name = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_name];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.view_type_name, objdm_model_relation_view_type_dictCond.view_type_name, strComparisonOpview_type_name);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.view_type_desc) == true)
{
string strComparisonOpview_type_desc = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.view_type_desc];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.view_type_desc, objdm_model_relation_view_type_dictCond.view_type_desc, strComparisonOpview_type_desc);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.is_active) == true)
{
if (objdm_model_relation_view_type_dictCond.is_active == true)
{
strWhereCond += string.Format(" And {0} = '1'", condm_model_relation_view_type_dict.is_active);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", condm_model_relation_view_type_dict.is_active);
}
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.sort_no) == true)
{
string strComparisonOpsort_no = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.sort_no];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_relation_view_type_dict.sort_no, objdm_model_relation_view_type_dictCond.sort_no, strComparisonOpsort_no);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.Status) == true)
{
string strComparisonOpStatus = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.Status, objdm_model_relation_view_type_dictCond.Status, strComparisonOpStatus);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.created_by) == true)
{
string strComparisonOpcreated_by = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.created_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.created_by, objdm_model_relation_view_type_dictCond.created_by, strComparisonOpcreated_by);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.created_time) == true)
{
string strComparisonOpcreated_time = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.created_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.created_time, objdm_model_relation_view_type_dictCond.created_time, strComparisonOpcreated_time);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.updated_by) == true)
{
string strComparisonOpupdated_by = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.updated_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.updated_by, objdm_model_relation_view_type_dictCond.updated_by, strComparisonOpupdated_by);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.updated_time) == true)
{
string strComparisonOpupdated_time = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.updated_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.updated_time, objdm_model_relation_view_type_dictCond.updated_time, strComparisonOpupdated_time);
}
if (objdm_model_relation_view_type_dictCond.IsUpdated(condm_model_relation_view_type_dict.remark) == true)
{
string strComparisonOpremark = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[condm_model_relation_view_type_dict.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_relation_view_type_dict.remark, objdm_model_relation_view_type_dictCond.remark, strComparisonOpremark);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_dm_model_relation_view_type_dict
{
public virtual bool UpdRelaTabDate(string strview_type_id, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 关系视图类型字典(dm_model_relation_view_type_dict)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsdm_model_relation_view_type_dictBL
{
public static RelatedActions_dm_model_relation_view_type_dict relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsdm_model_relation_view_type_dictDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsdm_model_relation_view_type_dictDA dm_model_relation_view_type_dictDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsdm_model_relation_view_type_dictDA();
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
 public clsdm_model_relation_view_type_dictBL()
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
if (string.IsNullOrEmpty(clsdm_model_relation_view_type_dictEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_relation_view_type_dictEN._ConnectString);
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
public static DataTable GetDataTable_dm_model_relation_view_type_dict(string strWhereCond)
{
DataTable objDT;
try
{
objDT = dm_model_relation_view_type_dictDA.GetDataTable_dm_model_relation_view_type_dict(strWhereCond);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable(strWhereCond);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable(strWhereCond, strTabName);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable_Top(objTopPara);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = dm_model_relation_view_type_dictDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrView_type_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByView_type_idLst(List<string> arrView_type_idLst)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrView_type_idLst, true);
 string strWhereCond = string.Format("view_type_id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrView_type_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsdm_model_relation_view_type_dictEN> GetObjLstByView_type_idLstCache(List<string> arrView_type_idLst)
{
string strKey = string.Format("{0}", clsdm_model_relation_view_type_dictEN._CurrTabName);
List<clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLst_Sel =
arrdm_model_relation_view_type_dictObjLstCache
.Where(x => arrView_type_idLst.Contains(x.view_type_id));
return arrdm_model_relation_view_type_dictObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetObjLst(string strWhereCond)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
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
public static List<clsdm_model_relation_view_type_dictEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsdm_model_relation_view_type_dictEN> GetSubObjLstCache(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictCond)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_relation_view_type_dictEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_relation_view_type_dict._AttributeName)
{
if (objdm_model_relation_view_type_dictCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_relation_view_type_dictCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_relation_view_type_dictCond[strFldName].ToString());
}
else
{
if (objdm_model_relation_view_type_dictCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_relation_view_type_dictCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_relation_view_type_dictCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_relation_view_type_dictCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_relation_view_type_dictCond[strFldName]));
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
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
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
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
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
List<clsdm_model_relation_view_type_dictEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsdm_model_relation_view_type_dictEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsdm_model_relation_view_type_dictEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
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
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
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
public static List<clsdm_model_relation_view_type_dictEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
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
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLst = new List<clsdm_model_relation_view_type_dictEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = new clsdm_model_relation_view_type_dictEN();
try
{
objdm_model_relation_view_type_dictEN.view_type_id = objRow[condm_model_relation_view_type_dict.view_type_id].ToString().Trim(); //视图类型ID
objdm_model_relation_view_type_dictEN.view_type_code = objRow[condm_model_relation_view_type_dict.view_type_code].ToString().Trim(); //视图类型编码
objdm_model_relation_view_type_dictEN.view_type_name = objRow[condm_model_relation_view_type_dict.view_type_name].ToString().Trim(); //视图类型名称
objdm_model_relation_view_type_dictEN.view_type_desc = objRow[condm_model_relation_view_type_dict.view_type_desc] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.view_type_desc].ToString().Trim(); //视图类型说明
objdm_model_relation_view_type_dictEN.is_active = clsEntityBase2.TransNullToBool_S(objRow[condm_model_relation_view_type_dict.is_active].ToString().Trim()); //是否启用
objdm_model_relation_view_type_dictEN.sort_no = Int32.Parse(objRow[condm_model_relation_view_type_dict.sort_no].ToString().Trim()); //排序号
objdm_model_relation_view_type_dictEN.Status = objRow[condm_model_relation_view_type_dict.Status].ToString().Trim(); //Status
objdm_model_relation_view_type_dictEN.created_by = objRow[condm_model_relation_view_type_dict.created_by].ToString().Trim(); //创建人
objdm_model_relation_view_type_dictEN.created_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.created_time].ToString().Trim()); //创建时间
objdm_model_relation_view_type_dictEN.updated_by = objRow[condm_model_relation_view_type_dict.updated_by].ToString().Trim(); //更新人
objdm_model_relation_view_type_dictEN.updated_time = System.DateTime.Parse(objRow[condm_model_relation_view_type_dict.updated_time].ToString().Trim()); //更新时间
objdm_model_relation_view_type_dictEN.remark = objRow[condm_model_relation_view_type_dict.remark] == DBNull.Value ? null : objRow[condm_model_relation_view_type_dict.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_relation_view_type_dictEN.view_type_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_relation_view_type_dictEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getdm_model_relation_view_type_dict(ref clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
bool bolResult = dm_model_relation_view_type_dictDA.Getdm_model_relation_view_type_dict(ref objdm_model_relation_view_type_dictEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strview_type_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_relation_view_type_dictEN GetObjByview_type_id(string strview_type_id)
{
if (strview_type_id.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strview_type_id]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strview_type_id) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strview_type_id]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = dm_model_relation_view_type_dictDA.GetObjByview_type_id(strview_type_id);
return objdm_model_relation_view_type_dictEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsdm_model_relation_view_type_dictEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = dm_model_relation_view_type_dictDA.GetFirstObj(strWhereCond);
 return objdm_model_relation_view_type_dictEN;
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
public static clsdm_model_relation_view_type_dictEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = dm_model_relation_view_type_dictDA.GetObjByDataRow(objRow);
 return objdm_model_relation_view_type_dictEN;
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
public static clsdm_model_relation_view_type_dictEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = dm_model_relation_view_type_dictDA.GetObjByDataRow(objRow);
 return objdm_model_relation_view_type_dictEN;
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
 /// <param name = "strview_type_id">所给的关键字</param>
 /// <param name = "lstdm_model_relation_view_type_dictObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_relation_view_type_dictEN GetObjByview_type_idFromList(string strview_type_id, List<clsdm_model_relation_view_type_dictEN> lstdm_model_relation_view_type_dictObjLst)
{
foreach (clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN in lstdm_model_relation_view_type_dictObjLst)
{
if (objdm_model_relation_view_type_dictEN.view_type_id == strview_type_id)
{
return objdm_model_relation_view_type_dictEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strview_type_id;
 try
 {
 strview_type_id = new clsdm_model_relation_view_type_dictDA().GetFirstID(strWhereCond);
 return strview_type_id;
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
 arrList = dm_model_relation_view_type_dictDA.GetID(strWhereCond);
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
bool bolIsExist = dm_model_relation_view_type_dictDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strview_type_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strview_type_id)
{
if (string.IsNullOrEmpty(strview_type_id) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strview_type_id]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = dm_model_relation_view_type_dictDA.IsExist(strview_type_id);
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
 bolIsExist = clsdm_model_relation_view_type_dictDA.IsExistTable();
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
 bolIsExist = dm_model_relation_view_type_dictDA.IsExistTable(strTabName);
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_relation_view_type_dictBL.IsExist(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_relation_view_type_dictEN.view_type_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = dm_model_relation_view_type_dictDA.AddNewRecordBySQL2(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsdm_model_relation_view_type_dictBL.IsExist(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objdm_model_relation_view_type_dictEN.view_type_id, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = dm_model_relation_view_type_dictDA.AddNewRecordBySQL2WithReturnKey(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
try
{
bool bolResult = dm_model_relation_view_type_dictDA.Update(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "objdm_model_relation_view_type_dictEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 if (string.IsNullOrEmpty(objdm_model_relation_view_type_dictEN.view_type_id) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = dm_model_relation_view_type_dictDA.UpdateBySql2(objdm_model_relation_view_type_dictEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_relation_view_type_dictBL.ReFreshCache();

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
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
 /// <param name = "strview_type_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strview_type_id)
{
try
{
 clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN = clsdm_model_relation_view_type_dictBL.GetObjByview_type_id(strview_type_id);

if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(objdm_model_relation_view_type_dictEN.view_type_id, "SetUpdDate");
}
if (objdm_model_relation_view_type_dictEN != null)
{
int intRecNum = dm_model_relation_view_type_dictDA.DelRecord(strview_type_id);
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
/// <param name="strview_type_id">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strview_type_id )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_relation_view_type_dictDA.GetSpecSQLObj();
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
//删除与表:[dm_model_relation_view_type_dict]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//condm_model_relation_view_type_dict.view_type_id,
//strview_type_id);
//        clsdm_model_relation_view_type_dictBL.Deldm_model_relation_view_type_dictsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_relation_view_type_dictBL.DelRecord(strview_type_id, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_relation_view_type_dictBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strview_type_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strview_type_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strview_type_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(strview_type_id, "UpdRelaTabDate");
}
bool bolResult = dm_model_relation_view_type_dictDA.DelRecord(strview_type_id,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrview_type_idLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deldm_model_relation_view_type_dicts(List<string> arrview_type_idLst)
{
if (arrview_type_idLst.Count == 0) return 0;
try
{
if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
foreach (var strview_type_id in arrview_type_idLst)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(strview_type_id, "UpdRelaTabDate");
}
}
int intDelRecNum = dm_model_relation_view_type_dictDA.Deldm_model_relation_view_type_dict(arrview_type_idLst);
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
public static int Deldm_model_relation_view_type_dictsByCond(string strWhereCond)
{
try
{
if (clsdm_model_relation_view_type_dictBL.relatedActions != null)
{
List<string> arrview_type_id = GetPrimaryKeyID_S(strWhereCond);
foreach (var strview_type_id in arrview_type_id)
{
clsdm_model_relation_view_type_dictBL.relatedActions.UpdRelaTabDate(strview_type_id, "UpdRelaTabDate");
}
}
int intRecNum = dm_model_relation_view_type_dictDA.Deldm_model_relation_view_type_dict(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[dm_model_relation_view_type_dict]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strview_type_id">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strview_type_id)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_relation_view_type_dictDA.GetSpecSQLObj();
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
//删除与表:[dm_model_relation_view_type_dict]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_relation_view_type_dictBL.DelRecord(strview_type_id, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_relation_view_type_dictBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strview_type_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objdm_model_relation_view_type_dictENS">源对象</param>
 /// <param name = "objdm_model_relation_view_type_dictENT">目标对象</param>
 public static void CopyTo(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENS, clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictENT)
{
try
{
objdm_model_relation_view_type_dictENT.view_type_id = objdm_model_relation_view_type_dictENS.view_type_id; //视图类型ID
objdm_model_relation_view_type_dictENT.view_type_code = objdm_model_relation_view_type_dictENS.view_type_code; //视图类型编码
objdm_model_relation_view_type_dictENT.view_type_name = objdm_model_relation_view_type_dictENS.view_type_name; //视图类型名称
objdm_model_relation_view_type_dictENT.view_type_desc = objdm_model_relation_view_type_dictENS.view_type_desc; //视图类型说明
objdm_model_relation_view_type_dictENT.is_active = objdm_model_relation_view_type_dictENS.is_active; //是否启用
objdm_model_relation_view_type_dictENT.sort_no = objdm_model_relation_view_type_dictENS.sort_no; //排序号
objdm_model_relation_view_type_dictENT.Status = objdm_model_relation_view_type_dictENS.Status; //Status
objdm_model_relation_view_type_dictENT.created_by = objdm_model_relation_view_type_dictENS.created_by; //创建人
objdm_model_relation_view_type_dictENT.created_time = objdm_model_relation_view_type_dictENS.created_time; //创建时间
objdm_model_relation_view_type_dictENT.updated_by = objdm_model_relation_view_type_dictENS.updated_by; //更新人
objdm_model_relation_view_type_dictENT.updated_time = objdm_model_relation_view_type_dictENS.updated_time; //更新时间
objdm_model_relation_view_type_dictENT.remark = objdm_model_relation_view_type_dictENS.remark; //备注
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
 /// <param name = "objdm_model_relation_view_type_dictEN">源简化对象</param>
 public static void SetUpdFlag(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
try
{
objdm_model_relation_view_type_dictEN.ClearUpdateState();
   string strsfUpdFldSetStr = objdm_model_relation_view_type_dictEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(condm_model_relation_view_type_dict.view_type_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.view_type_id = objdm_model_relation_view_type_dictEN.view_type_id; //视图类型ID
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.view_type_code, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.view_type_code = objdm_model_relation_view_type_dictEN.view_type_code; //视图类型编码
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.view_type_name, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.view_type_name = objdm_model_relation_view_type_dictEN.view_type_name; //视图类型名称
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.view_type_desc, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.view_type_desc = objdm_model_relation_view_type_dictEN.view_type_desc == "[null]" ? null :  objdm_model_relation_view_type_dictEN.view_type_desc; //视图类型说明
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.is_active, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.is_active = objdm_model_relation_view_type_dictEN.is_active; //是否启用
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.sort_no, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.sort_no = objdm_model_relation_view_type_dictEN.sort_no; //排序号
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.Status = objdm_model_relation_view_type_dictEN.Status; //Status
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.created_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.created_by = objdm_model_relation_view_type_dictEN.created_by; //创建人
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.created_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.created_time = objdm_model_relation_view_type_dictEN.created_time; //创建时间
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.updated_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.updated_by = objdm_model_relation_view_type_dictEN.updated_by; //更新人
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.updated_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.updated_time = objdm_model_relation_view_type_dictEN.updated_time; //更新时间
}
if (arrFldSet.Contains(condm_model_relation_view_type_dict.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_relation_view_type_dictEN.remark = objdm_model_relation_view_type_dictEN.remark == "[null]" ? null :  objdm_model_relation_view_type_dictEN.remark; //备注
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
 /// <param name = "objdm_model_relation_view_type_dictEN">源简化对象</param>
 public static void AccessFldValueNull(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
try
{
if (objdm_model_relation_view_type_dictEN.view_type_desc == "[null]") objdm_model_relation_view_type_dictEN.view_type_desc = null; //视图类型说明
if (objdm_model_relation_view_type_dictEN.remark == "[null]") objdm_model_relation_view_type_dictEN.remark = null; //备注
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
public static void CheckPropertyNew(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 dm_model_relation_view_type_dictDA.CheckPropertyNew(objdm_model_relation_view_type_dictEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictEN)
{
 dm_model_relation_view_type_dictDA.CheckProperty4Condition(objdm_model_relation_view_type_dictEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_view_type_idCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[关系视图类型字典]...","0");
List<clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLst = GetAlldm_model_relation_view_type_dictObjLstCache(); 
objDDL.DataValueField = condm_model_relation_view_type_dict.view_type_id;
objDDL.DataTextField = condm_model_relation_view_type_dict.view_type_name;
objDDL.DataSource = arrdm_model_relation_view_type_dictObjLst;
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
if (clsdm_model_relation_view_type_dictBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsdm_model_relation_view_type_dictBL没有刷新缓存机制(clsdm_model_relation_view_type_dictBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by view_type_id");
//if (arrdm_model_relation_view_type_dictObjLstCache == null)
//{
//arrdm_model_relation_view_type_dictObjLstCache = dm_model_relation_view_type_dictDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strview_type_id">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_relation_view_type_dictEN GetObjByview_type_idCache(string strview_type_id)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsdm_model_relation_view_type_dictEN._CurrTabName);
List<clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLst_Sel =
arrdm_model_relation_view_type_dictObjLstCache
.Where(x=> x.view_type_id == strview_type_id 
);
if (arrdm_model_relation_view_type_dictObjLst_Sel.Count() == 0)
{
   clsdm_model_relation_view_type_dictEN obj = clsdm_model_relation_view_type_dictBL.GetObjByview_type_id(strview_type_id);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrdm_model_relation_view_type_dictObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strview_type_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string Getview_type_nameByview_type_idCache(string strview_type_id)
{
if (string.IsNullOrEmpty(strview_type_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dict = GetObjByview_type_idCache(strview_type_id);
if (objdm_model_relation_view_type_dict == null) return "";
return objdm_model_relation_view_type_dict.view_type_name;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strview_type_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByview_type_idCache(string strview_type_id)
{
if (string.IsNullOrEmpty(strview_type_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dict = GetObjByview_type_idCache(strview_type_id);
if (objdm_model_relation_view_type_dict == null) return "";
return objdm_model_relation_view_type_dict.view_type_name;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetAlldm_model_relation_view_type_dictObjLstCache()
{
//获取缓存中的对象列表
List<clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLstCache = GetObjLstCache(); 
return arrdm_model_relation_view_type_dictObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_relation_view_type_dictEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsdm_model_relation_view_type_dictEN._CurrTabName);
List<clsdm_model_relation_view_type_dictEN> arrdm_model_relation_view_type_dictObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrdm_model_relation_view_type_dictObjLstCache;
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
string strKey = string.Format("{0}", clsdm_model_relation_view_type_dictEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_relation_view_type_dictEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsdm_model_relation_view_type_dictEN._RefreshTimeLst.Count == 0) return "";
return clsdm_model_relation_view_type_dictEN._RefreshTimeLst[clsdm_model_relation_view_type_dictEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsdm_model_relation_view_type_dictBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsdm_model_relation_view_type_dictEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_relation_view_type_dictEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsdm_model_relation_view_type_dictBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf_agc
 /// 日期:2026-08-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strview_type_id)
{
if (strInFldName != condm_model_relation_view_type_dict.view_type_id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (condm_model_relation_view_type_dict._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", condm_model_relation_view_type_dict._AttributeName));
throw new Exception(strMsg);
}
var objdm_model_relation_view_type_dict = clsdm_model_relation_view_type_dictBL.GetObjByview_type_idCache(strview_type_id);
if (objdm_model_relation_view_type_dict == null) return "";
return objdm_model_relation_view_type_dict[strOutFldName].ToString();
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
int intRecCount = clsdm_model_relation_view_type_dictDA.GetRecCount(strTabName);
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
int intRecCount = clsdm_model_relation_view_type_dictDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsdm_model_relation_view_type_dictDA.GetRecCount();
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
int intRecCount = clsdm_model_relation_view_type_dictDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objdm_model_relation_view_type_dictCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsdm_model_relation_view_type_dictEN objdm_model_relation_view_type_dictCond)
{
List<clsdm_model_relation_view_type_dictEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_relation_view_type_dictEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_relation_view_type_dict._AttributeName)
{
if (objdm_model_relation_view_type_dictCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_relation_view_type_dictCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_relation_view_type_dictCond[strFldName].ToString());
}
else
{
if (objdm_model_relation_view_type_dictCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_relation_view_type_dictCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_relation_view_type_dictCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_relation_view_type_dictCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_relation_view_type_dictCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_relation_view_type_dictCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_relation_view_type_dictCond[strFldName]));
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
 List<string> arrList = clsdm_model_relation_view_type_dictDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = dm_model_relation_view_type_dictDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = dm_model_relation_view_type_dictDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = dm_model_relation_view_type_dictDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_relation_view_type_dictDA.SetFldValue(clsdm_model_relation_view_type_dictEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = dm_model_relation_view_type_dictDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_relation_view_type_dictDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_relation_view_type_dictDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_relation_view_type_dictDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[dm_model_relation_view_type_dict] "); 
 strCreateTabCode.Append(" ( "); 
 // /**视图类型ID*/ 
 strCreateTabCode.Append(" view_type_id varchar(32) primary key, "); 
 // /**视图类型编码*/ 
 strCreateTabCode.Append(" view_type_code varchar(30) not Null, "); 
 // /**视图类型名称*/ 
 strCreateTabCode.Append(" view_type_name varchar(50) not Null, "); 
 // /**视图类型说明*/ 
 strCreateTabCode.Append(" view_type_desc varchar(300) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" is_active bit not Null, "); 
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
 strCreateTabCode.Append(" remark varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 关系视图类型字典(dm_model_relation_view_type_dict)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4dm_model_relation_view_type_dict : clsCommFun4BL
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
clsdm_model_relation_view_type_dictBL.ReFreshThisCache();
}
}

}