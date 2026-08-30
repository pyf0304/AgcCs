
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_layoutBL
 表名:dm_model_layout(00050663)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/04 15:30:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据模型(DataModel)
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
public static class  clsdm_model_layoutBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strmodel_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_layoutEN GetObj(this K_model_id_dm_model_layout myKey)
{
clsdm_model_layoutEN objdm_model_layoutEN = clsdm_model_layoutBL.dm_model_layoutDA.GetObjBymodel_id(myKey.Value);
return objdm_model_layoutEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_layoutEN) == false)
{
var strMsg = string.Format("记录已经存在!模型名称 = [{0}],项目ID = [{1}]的数据已经存在!(in clsdm_model_layoutBL.AddNewRecord)", objdm_model_layoutEN.model_name,objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
bool bolResult = clsdm_model_layoutBL.dm_model_layoutDA.AddNewRecordBySQL2(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
public static bool AddRecordEx(this clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objdm_model_layoutEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objdm_model_layoutEN.CheckUniqueness() == false)
{
strMsg = string.Format("(模型名称(model_name)=[{0}],项目ID(prj_id)=[{1}])已经存在,不能重复!", objdm_model_layoutEN.model_name, objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objdm_model_layoutEN.AddNewRecord();
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_layoutEN) == false)
{
var strMsg = string.Format("记录已经存在!模型名称 = [{0}],项目ID = [{1}]的数据已经存在!(in clsdm_model_layoutBL.AddNewRecordWithMaxId)", objdm_model_layoutEN.model_name,objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
string strmodel_id = clsdm_model_layoutBL.dm_model_layoutDA.AddNewRecordBySQL2WithReturnKey(objdm_model_layoutEN);
     objdm_model_layoutEN.model_id = strmodel_id;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
}
return strmodel_id;
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_layoutEN) == false)
{
var strMsg = string.Format("记录已经存在!模型名称 = [{0}],项目ID = [{1}]的数据已经存在!(in clsdm_model_layoutBL.AddNewRecordWithReturnKey)", objdm_model_layoutEN.model_name,objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
string strKey = clsdm_model_layoutBL.dm_model_layoutDA.AddNewRecordBySQL2WithReturnKey(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setmodel_id(this clsdm_model_layoutEN objdm_model_layoutEN, string strmodel_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmodel_id, 32, condm_model_layout.model_id);
}
objdm_model_layoutEN.model_id = strmodel_id; //模型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.model_id) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.model_id, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.model_id] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setmodel_name(this clsdm_model_layoutEN objdm_model_layoutEN, string strmodel_name, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strmodel_name, condm_model_layout.model_name);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmodel_name, 100, condm_model_layout.model_name);
}
objdm_model_layoutEN.model_name = strmodel_name; //模型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.model_name) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.model_name, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.model_name] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setprj_id(this clsdm_model_layoutEN objdm_model_layoutEN, string strprj_id, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strprj_id, condm_model_layout.prj_id);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strprj_id, 32, condm_model_layout.prj_id);
}
objdm_model_layoutEN.prj_id = strprj_id; //项目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.prj_id) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.prj_id, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.prj_id] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setmodel_desc(this clsdm_model_layoutEN objdm_model_layoutEN, string strmodel_desc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmodel_desc, 500, condm_model_layout.model_desc);
}
objdm_model_layoutEN.model_desc = strmodel_desc; //模型说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.model_desc) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.model_desc, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.model_desc] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setlayout_data(this clsdm_model_layoutEN objdm_model_layoutEN, string strlayout_data, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strlayout_data, 4000, condm_model_layout.layout_data);
}
objdm_model_layoutEN.layout_data = strlayout_data; //布局数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.layout_data) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.layout_data, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.layout_data] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setcanvas_height(this clsdm_model_layoutEN objdm_model_layoutEN, int? intcanvas_height, string strComparisonOp="")
	{
objdm_model_layoutEN.canvas_height = intcanvas_height; //画布高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.canvas_height) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.canvas_height, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.canvas_height] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setcanvas_width(this clsdm_model_layoutEN objdm_model_layoutEN, int? intcanvas_width, string strComparisonOp="")
	{
objdm_model_layoutEN.canvas_width = intcanvas_width; //画布宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.canvas_width) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.canvas_width, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.canvas_width] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN SetStatus(this clsdm_model_layoutEN objdm_model_layoutEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, condm_model_layout.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, condm_model_layout.Status);
}
objdm_model_layoutEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.Status) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.Status, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.Status] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setsort_no(this clsdm_model_layoutEN objdm_model_layoutEN, int? intsort_no, string strComparisonOp="")
	{
objdm_model_layoutEN.sort_no = intsort_no; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.sort_no) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.sort_no, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.sort_no] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setcreated_by(this clsdm_model_layoutEN objdm_model_layoutEN, string strcreated_by, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreated_by, 50, condm_model_layout.created_by);
}
objdm_model_layoutEN.created_by = strcreated_by; //创建人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.created_by) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.created_by, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.created_by] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setcreated_time(this clsdm_model_layoutEN objdm_model_layoutEN, DateTime dtecreated_time, string strComparisonOp="")
	{
objdm_model_layoutEN.created_time = dtecreated_time; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.created_time) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.created_time, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.created_time] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setupdated_by(this clsdm_model_layoutEN objdm_model_layoutEN, string strupdated_by, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdated_by, 50, condm_model_layout.updated_by);
}
objdm_model_layoutEN.updated_by = strupdated_by; //更新人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.updated_by) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.updated_by, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.updated_by] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setupdated_time(this clsdm_model_layoutEN objdm_model_layoutEN, DateTime dteupdated_time, string strComparisonOp="")
	{
objdm_model_layoutEN.updated_time = dteupdated_time; //更新时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.updated_time) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.updated_time, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.updated_time] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_layoutEN Setremark(this clsdm_model_layoutEN objdm_model_layoutEN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 500, condm_model_layout.remark);
}
objdm_model_layoutEN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_layoutEN.dicFldComparisonOp.ContainsKey(condm_model_layout.remark) == false)
{
objdm_model_layoutEN.dicFldComparisonOp.Add(condm_model_layout.remark, strComparisonOp);
}
else
{
objdm_model_layoutEN.dicFldComparisonOp[condm_model_layout.remark] = strComparisonOp;
}
}
return objdm_model_layoutEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsdm_model_layoutEN objdm_model_layoutEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objdm_model_layoutEN.CheckPropertyNew();
clsdm_model_layoutEN objdm_model_layoutCond = new clsdm_model_layoutEN();
string strCondition = objdm_model_layoutCond
.Setmodel_id(objdm_model_layoutEN.model_id, "<>")
.Setmodel_name(objdm_model_layoutEN.model_name, "=")
.Setprj_id(objdm_model_layoutEN.prj_id, "=")
.GetCombineCondition();
objdm_model_layoutEN._IsCheckProperty = true;
bool bolIsExist = clsdm_model_layoutBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objdm_model_layoutEN.Update();
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
 /// <param name = "objdm_model_layout">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsdm_model_layoutEN objdm_model_layout)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsdm_model_layoutEN objdm_model_layoutCond = new clsdm_model_layoutEN();
string strCondition = objdm_model_layoutCond
.Setmodel_name(objdm_model_layout.model_name, "=")
.Setprj_id(objdm_model_layout.prj_id, "=")
.GetCombineCondition();
objdm_model_layout._IsCheckProperty = true;
bool bolIsExist = clsdm_model_layoutBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objdm_model_layout.model_id = clsdm_model_layoutBL.GetFirstID_S(strCondition);
objdm_model_layout.UpdateWithCondition(strCondition);
}
else
{
objdm_model_layout.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
objdm_model_layout.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_layoutBL.dm_model_layoutDA.UpdateBySql2(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_layoutEN objdm_model_layoutEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_layoutBL.dm_model_layoutDA.UpdateBySql2(objdm_model_layoutEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_layoutEN objdm_model_layoutEN, string strWhereCond)
{
try
{
bool bolResult = clsdm_model_layoutBL.dm_model_layoutDA.UpdateBySqlWithCondition(objdm_model_layoutEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_layoutEN objdm_model_layoutEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsdm_model_layoutBL.dm_model_layoutDA.UpdateBySqlWithConditionTransaction(objdm_model_layoutEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsdm_model_layoutEN objdm_model_layoutEN)
{
try
{
int intRecNum = clsdm_model_layoutBL.dm_model_layoutDA.DelRecord(objdm_model_layoutEN.model_id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutENS">源对象</param>
 /// <param name = "objdm_model_layoutENT">目标对象</param>
 public static void CopyTo(this clsdm_model_layoutEN objdm_model_layoutENS, clsdm_model_layoutEN objdm_model_layoutENT)
{
try
{
objdm_model_layoutENT.model_id = objdm_model_layoutENS.model_id; //模型ID
objdm_model_layoutENT.model_name = objdm_model_layoutENS.model_name; //模型名称
objdm_model_layoutENT.prj_id = objdm_model_layoutENS.prj_id; //项目ID
objdm_model_layoutENT.model_desc = objdm_model_layoutENS.model_desc; //模型说明
objdm_model_layoutENT.layout_data = objdm_model_layoutENS.layout_data; //布局数据
objdm_model_layoutENT.canvas_height = objdm_model_layoutENS.canvas_height; //画布高
objdm_model_layoutENT.canvas_width = objdm_model_layoutENS.canvas_width; //画布宽
objdm_model_layoutENT.Status = objdm_model_layoutENS.Status; //Status
objdm_model_layoutENT.sort_no = objdm_model_layoutENS.sort_no; //排序号
objdm_model_layoutENT.created_by = objdm_model_layoutENS.created_by; //创建人
objdm_model_layoutENT.created_time = objdm_model_layoutENS.created_time; //创建时间
objdm_model_layoutENT.updated_by = objdm_model_layoutENS.updated_by; //更新人
objdm_model_layoutENT.updated_time = objdm_model_layoutENS.updated_time; //更新时间
objdm_model_layoutENT.remark = objdm_model_layoutENS.remark; //备注
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
 /// <param name = "objdm_model_layoutENS">源对象</param>
 /// <returns>目标对象=>clsdm_model_layoutEN:objdm_model_layoutENT</returns>
 public static clsdm_model_layoutEN CopyTo(this clsdm_model_layoutEN objdm_model_layoutENS)
{
try
{
 clsdm_model_layoutEN objdm_model_layoutENT = new clsdm_model_layoutEN()
{
model_id = objdm_model_layoutENS.model_id, //模型ID
model_name = objdm_model_layoutENS.model_name, //模型名称
prj_id = objdm_model_layoutENS.prj_id, //项目ID
model_desc = objdm_model_layoutENS.model_desc, //模型说明
layout_data = objdm_model_layoutENS.layout_data, //布局数据
canvas_height = objdm_model_layoutENS.canvas_height, //画布高
canvas_width = objdm_model_layoutENS.canvas_width, //画布宽
Status = objdm_model_layoutENS.Status, //Status
sort_no = objdm_model_layoutENS.sort_no, //排序号
created_by = objdm_model_layoutENS.created_by, //创建人
created_time = objdm_model_layoutENS.created_time, //创建时间
updated_by = objdm_model_layoutENS.updated_by, //更新人
updated_time = objdm_model_layoutENS.updated_time, //更新时间
remark = objdm_model_layoutENS.remark, //备注
};
 return objdm_model_layoutENT;
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
public static void CheckPropertyNew(this clsdm_model_layoutEN objdm_model_layoutEN)
{
 clsdm_model_layoutBL.dm_model_layoutDA.CheckPropertyNew(objdm_model_layoutEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsdm_model_layoutEN objdm_model_layoutEN)
{
 clsdm_model_layoutBL.dm_model_layoutDA.CheckProperty4Condition(objdm_model_layoutEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsdm_model_layoutEN objdm_model_layoutCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.model_id) == true)
{
string strComparisonOpmodel_id = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.model_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.model_id, objdm_model_layoutCond.model_id, strComparisonOpmodel_id);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.model_name) == true)
{
string strComparisonOpmodel_name = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.model_name];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.model_name, objdm_model_layoutCond.model_name, strComparisonOpmodel_name);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.prj_id) == true)
{
string strComparisonOpprj_id = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.prj_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.prj_id, objdm_model_layoutCond.prj_id, strComparisonOpprj_id);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.model_desc) == true)
{
string strComparisonOpmodel_desc = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.model_desc];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.model_desc, objdm_model_layoutCond.model_desc, strComparisonOpmodel_desc);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.layout_data) == true)
{
string strComparisonOplayout_data = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.layout_data];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.layout_data, objdm_model_layoutCond.layout_data, strComparisonOplayout_data);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.canvas_height) == true)
{
string strComparisonOpcanvas_height = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.canvas_height];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_layout.canvas_height, objdm_model_layoutCond.canvas_height, strComparisonOpcanvas_height);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.canvas_width) == true)
{
string strComparisonOpcanvas_width = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.canvas_width];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_layout.canvas_width, objdm_model_layoutCond.canvas_width, strComparisonOpcanvas_width);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.Status) == true)
{
string strComparisonOpStatus = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.Status, objdm_model_layoutCond.Status, strComparisonOpStatus);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.sort_no) == true)
{
string strComparisonOpsort_no = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.sort_no];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_layout.sort_no, objdm_model_layoutCond.sort_no, strComparisonOpsort_no);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.created_by) == true)
{
string strComparisonOpcreated_by = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.created_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.created_by, objdm_model_layoutCond.created_by, strComparisonOpcreated_by);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.created_time) == true)
{
string strComparisonOpcreated_time = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.created_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.created_time, objdm_model_layoutCond.created_time, strComparisonOpcreated_time);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.updated_by) == true)
{
string strComparisonOpupdated_by = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.updated_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.updated_by, objdm_model_layoutCond.updated_by, strComparisonOpupdated_by);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.updated_time) == true)
{
string strComparisonOpupdated_time = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.updated_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.updated_time, objdm_model_layoutCond.updated_time, strComparisonOpupdated_time);
}
if (objdm_model_layoutCond.IsUpdated(condm_model_layout.remark) == true)
{
string strComparisonOpremark = objdm_model_layoutCond.dicFldComparisonOp[condm_model_layout.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_layout.remark, objdm_model_layoutCond.remark, strComparisonOpremark);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--dm_model_layout(模型布局表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:model_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsdm_model_layoutEN objdm_model_layoutEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_layoutEN == null) return true;
if (objdm_model_layoutEN.model_id == null || objdm_model_layoutEN.model_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and model_name = '{0}'", objdm_model_layoutEN.model_name);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_layoutEN.prj_id);
if (clsdm_model_layoutBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("model_id !=  '{0}'", objdm_model_layoutEN.model_id);
 sbCondition.AppendFormat(" and model_name = '{0}'", objdm_model_layoutEN.model_name);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_layoutEN.prj_id);
if (clsdm_model_layoutBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--dm_model_layout(模型布局表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:model_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsdm_model_layoutEN objdm_model_layoutEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_layoutEN == null) return "";
if (objdm_model_layoutEN.model_id == null || objdm_model_layoutEN.model_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and model_name = '{0}'", objdm_model_layoutEN.model_name);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_layoutEN.prj_id);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("model_id !=  '{0}'", objdm_model_layoutEN.model_id);
 sbCondition.AppendFormat(" and model_name = '{0}'", objdm_model_layoutEN.model_name);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_layoutEN.prj_id);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_dm_model_layout
{
public virtual bool UpdRelaTabDate(string strmodel_id, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 模型布局表(dm_model_layout)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsdm_model_layoutBL
{
public static RelatedActions_dm_model_layout relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsdm_model_layoutDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsdm_model_layoutDA dm_model_layoutDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsdm_model_layoutDA();
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
 public clsdm_model_layoutBL()
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
if (string.IsNullOrEmpty(clsdm_model_layoutEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_layoutEN._ConnectString);
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
public static DataTable GetDataTable_dm_model_layout(string strWhereCond)
{
DataTable objDT;
try
{
objDT = dm_model_layoutDA.GetDataTable_dm_model_layout(strWhereCond);
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
objDT = dm_model_layoutDA.GetDataTable(strWhereCond);
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
objDT = dm_model_layoutDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = dm_model_layoutDA.GetDataTable(strWhereCond, strTabName);
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
objDT = dm_model_layoutDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = dm_model_layoutDA.GetDataTable_Top(objTopPara);
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
objDT = dm_model_layoutDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = dm_model_layoutDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = dm_model_layoutDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrModel_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsdm_model_layoutEN> GetObjLstByModel_idLst(List<string> arrModel_idLst)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrModel_idLst, true);
 string strWhereCond = string.Format("model_id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrModel_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsdm_model_layoutEN> GetObjLstByModel_idLstCache(List<string> arrModel_idLst)
{
string strKey = string.Format("{0}", clsdm_model_layoutEN._CurrTabName);
List<clsdm_model_layoutEN> arrdm_model_layoutObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_layoutEN> arrdm_model_layoutObjLst_Sel =
arrdm_model_layoutObjLstCache
.Where(x => arrModel_idLst.Contains(x.model_id));
return arrdm_model_layoutObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_layoutEN> GetObjLst(string strWhereCond)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
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
public static List<clsdm_model_layoutEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objdm_model_layoutCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsdm_model_layoutEN> GetSubObjLstCache(clsdm_model_layoutEN objdm_model_layoutCond)
{
List<clsdm_model_layoutEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_layoutEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_layout._AttributeName)
{
if (objdm_model_layoutCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_layoutCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_layoutCond[strFldName].ToString());
}
else
{
if (objdm_model_layoutCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_layoutCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_layoutCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_layoutCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_layoutCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_layoutCond[strFldName]));
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
public static List<clsdm_model_layoutEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
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
public static List<clsdm_model_layoutEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
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
List<clsdm_model_layoutEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsdm_model_layoutEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_layoutEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsdm_model_layoutEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
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
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
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
public static List<clsdm_model_layoutEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsdm_model_layoutEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsdm_model_layoutEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
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
public static List<clsdm_model_layoutEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_layoutEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsdm_model_layoutEN> arrObjLst = new List<clsdm_model_layoutEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_layoutEN objdm_model_layoutEN = new clsdm_model_layoutEN();
try
{
objdm_model_layoutEN.model_id = objRow[condm_model_layout.model_id].ToString().Trim(); //模型ID
objdm_model_layoutEN.model_name = objRow[condm_model_layout.model_name].ToString().Trim(); //模型名称
objdm_model_layoutEN.prj_id = objRow[condm_model_layout.prj_id].ToString().Trim(); //项目ID
objdm_model_layoutEN.model_desc = objRow[condm_model_layout.model_desc] == DBNull.Value ? null : objRow[condm_model_layout.model_desc].ToString().Trim(); //模型说明
objdm_model_layoutEN.layout_data = objRow[condm_model_layout.layout_data] == DBNull.Value ? null : objRow[condm_model_layout.layout_data].ToString().Trim(); //布局数据
objdm_model_layoutEN.canvas_height = objRow[condm_model_layout.canvas_height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_height].ToString().Trim()); //画布高
objdm_model_layoutEN.canvas_width = objRow[condm_model_layout.canvas_width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.canvas_width].ToString().Trim()); //画布宽
objdm_model_layoutEN.Status = objRow[condm_model_layout.Status].ToString().Trim(); //Status
objdm_model_layoutEN.sort_no = objRow[condm_model_layout.sort_no] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_layout.sort_no].ToString().Trim()); //排序号
objdm_model_layoutEN.created_by = objRow[condm_model_layout.created_by] == DBNull.Value ? null : objRow[condm_model_layout.created_by].ToString().Trim(); //创建人
objdm_model_layoutEN.created_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.created_time].ToString().Trim()); //创建时间
objdm_model_layoutEN.updated_by = objRow[condm_model_layout.updated_by] == DBNull.Value ? null : objRow[condm_model_layout.updated_by].ToString().Trim(); //更新人
objdm_model_layoutEN.updated_time = clsEntityBase2.TransNullToDate_S(objRow[condm_model_layout.updated_time].ToString().Trim()); //更新时间
objdm_model_layoutEN.remark = objRow[condm_model_layout.remark] == DBNull.Value ? null : objRow[condm_model_layout.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_layoutEN.model_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_layoutEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getdm_model_layout(ref clsdm_model_layoutEN objdm_model_layoutEN)
{
bool bolResult = dm_model_layoutDA.Getdm_model_layout(ref objdm_model_layoutEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strmodel_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_layoutEN GetObjBymodel_id(string strmodel_id)
{
if (strmodel_id.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strmodel_id]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strmodel_id) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strmodel_id]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsdm_model_layoutEN objdm_model_layoutEN = dm_model_layoutDA.GetObjBymodel_id(strmodel_id);
return objdm_model_layoutEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsdm_model_layoutEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsdm_model_layoutEN objdm_model_layoutEN = dm_model_layoutDA.GetFirstObj(strWhereCond);
 return objdm_model_layoutEN;
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
public static clsdm_model_layoutEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsdm_model_layoutEN objdm_model_layoutEN = dm_model_layoutDA.GetObjByDataRow(objRow);
 return objdm_model_layoutEN;
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
public static clsdm_model_layoutEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsdm_model_layoutEN objdm_model_layoutEN = dm_model_layoutDA.GetObjByDataRow(objRow);
 return objdm_model_layoutEN;
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
 /// <param name = "strmodel_id">所给的关键字</param>
 /// <param name = "lstdm_model_layoutObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_layoutEN GetObjBymodel_idFromList(string strmodel_id, List<clsdm_model_layoutEN> lstdm_model_layoutObjLst)
{
foreach (clsdm_model_layoutEN objdm_model_layoutEN in lstdm_model_layoutObjLst)
{
if (objdm_model_layoutEN.model_id == strmodel_id)
{
return objdm_model_layoutEN;
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
 string strMaxModel_id;
 try
 {
 strMaxModel_id = clsdm_model_layoutDA.GetMaxStrId();
 return strMaxModel_id;
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
 string strmodel_id;
 try
 {
 strmodel_id = new clsdm_model_layoutDA().GetFirstID(strWhereCond);
 return strmodel_id;
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
 arrList = dm_model_layoutDA.GetID(strWhereCond);
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
bool bolIsExist = dm_model_layoutDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strmodel_id)
{
if (string.IsNullOrEmpty(strmodel_id) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strmodel_id]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = dm_model_layoutDA.IsExist(strmodel_id);
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
 bolIsExist = clsdm_model_layoutDA.IsExistTable();
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
 bolIsExist = dm_model_layoutDA.IsExistTable(strTabName);
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objdm_model_layoutEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!模型名称 = [{0}],项目ID = [{1}]的数据已经存在!(in clsdm_model_layoutBL.AddNewRecordBySql2)", objdm_model_layoutEN.model_name,objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
bool bolResult = dm_model_layoutDA.AddNewRecordBySQL2(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsdm_model_layoutEN objdm_model_layoutEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objdm_model_layoutEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!模型名称 = [{0}],项目ID = [{1}]的数据已经存在!(in clsdm_model_layoutBL.AddNewRecordBySql2WithReturnKey)", objdm_model_layoutEN.model_name,objdm_model_layoutEN.prj_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true || clsdm_model_layoutBL.IsExist(objdm_model_layoutEN.model_id) == true)
 {
     objdm_model_layoutEN.model_id = clsdm_model_layoutBL.GetMaxStrId_S();
 }
string strKey = dm_model_layoutDA.AddNewRecordBySQL2WithReturnKey(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsdm_model_layoutEN objdm_model_layoutEN)
{
try
{
bool bolResult = dm_model_layoutDA.Update(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "objdm_model_layoutEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsdm_model_layoutEN objdm_model_layoutEN)
{
 if (string.IsNullOrEmpty(objdm_model_layoutEN.model_id) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = dm_model_layoutDA.UpdateBySql2(objdm_model_layoutEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_layoutBL.ReFreshCache();

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
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
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strmodel_id)
{
try
{
 clsdm_model_layoutEN objdm_model_layoutEN = clsdm_model_layoutBL.GetObjBymodel_id(strmodel_id);

if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(objdm_model_layoutEN.model_id, "SetUpdDate");
}
if (objdm_model_layoutEN != null)
{
int intRecNum = dm_model_layoutDA.DelRecord(strmodel_id);
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
/// <param name="strmodel_id">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strmodel_id )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
//删除与表:[dm_model_layout]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//condm_model_layout.model_id,
//strmodel_id);
//        clsdm_model_layoutBL.Deldm_model_layoutsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_layoutBL.DelRecord(strmodel_id, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_layoutBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strmodel_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strmodel_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strmodel_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsdm_model_layoutBL.relatedActions != null)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(strmodel_id, "UpdRelaTabDate");
}
bool bolResult = dm_model_layoutDA.DelRecord(strmodel_id,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmodel_idLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deldm_model_layouts(List<string> arrmodel_idLst)
{
if (arrmodel_idLst.Count == 0) return 0;
try
{
if (clsdm_model_layoutBL.relatedActions != null)
{
foreach (var strmodel_id in arrmodel_idLst)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(strmodel_id, "UpdRelaTabDate");
}
}
int intDelRecNum = dm_model_layoutDA.Deldm_model_layout(arrmodel_idLst);
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
public static int Deldm_model_layoutsByCond(string strWhereCond)
{
try
{
if (clsdm_model_layoutBL.relatedActions != null)
{
List<string> arrmodel_id = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmodel_id in arrmodel_id)
{
clsdm_model_layoutBL.relatedActions.UpdRelaTabDate(strmodel_id, "UpdRelaTabDate");
}
}
int intRecNum = dm_model_layoutDA.Deldm_model_layout(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[dm_model_layout]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strmodel_id">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strmodel_id)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_layoutDA.GetSpecSQLObj();
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
//删除与表:[dm_model_layout]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_layoutBL.DelRecord(strmodel_id, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_layoutBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strmodel_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objdm_model_layoutENS">源对象</param>
 /// <param name = "objdm_model_layoutENT">目标对象</param>
 public static void CopyTo(clsdm_model_layoutEN objdm_model_layoutENS, clsdm_model_layoutEN objdm_model_layoutENT)
{
try
{
objdm_model_layoutENT.model_id = objdm_model_layoutENS.model_id; //模型ID
objdm_model_layoutENT.model_name = objdm_model_layoutENS.model_name; //模型名称
objdm_model_layoutENT.prj_id = objdm_model_layoutENS.prj_id; //项目ID
objdm_model_layoutENT.model_desc = objdm_model_layoutENS.model_desc; //模型说明
objdm_model_layoutENT.layout_data = objdm_model_layoutENS.layout_data; //布局数据
objdm_model_layoutENT.canvas_height = objdm_model_layoutENS.canvas_height; //画布高
objdm_model_layoutENT.canvas_width = objdm_model_layoutENS.canvas_width; //画布宽
objdm_model_layoutENT.Status = objdm_model_layoutENS.Status; //Status
objdm_model_layoutENT.sort_no = objdm_model_layoutENS.sort_no; //排序号
objdm_model_layoutENT.created_by = objdm_model_layoutENS.created_by; //创建人
objdm_model_layoutENT.created_time = objdm_model_layoutENS.created_time; //创建时间
objdm_model_layoutENT.updated_by = objdm_model_layoutENS.updated_by; //更新人
objdm_model_layoutENT.updated_time = objdm_model_layoutENS.updated_time; //更新时间
objdm_model_layoutENT.remark = objdm_model_layoutENS.remark; //备注
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
 /// <param name = "objdm_model_layoutEN">源简化对象</param>
 public static void SetUpdFlag(clsdm_model_layoutEN objdm_model_layoutEN)
{
try
{
objdm_model_layoutEN.ClearUpdateState();
   string strsfUpdFldSetStr = objdm_model_layoutEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(condm_model_layout.model_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.model_id = objdm_model_layoutEN.model_id; //模型ID
}
if (arrFldSet.Contains(condm_model_layout.model_name, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.model_name = objdm_model_layoutEN.model_name; //模型名称
}
if (arrFldSet.Contains(condm_model_layout.prj_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.prj_id = objdm_model_layoutEN.prj_id; //项目ID
}
if (arrFldSet.Contains(condm_model_layout.model_desc, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.model_desc = objdm_model_layoutEN.model_desc == "[null]" ? null :  objdm_model_layoutEN.model_desc; //模型说明
}
if (arrFldSet.Contains(condm_model_layout.layout_data, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.layout_data = objdm_model_layoutEN.layout_data == "[null]" ? null :  objdm_model_layoutEN.layout_data; //布局数据
}
if (arrFldSet.Contains(condm_model_layout.canvas_height, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.canvas_height = objdm_model_layoutEN.canvas_height; //画布高
}
if (arrFldSet.Contains(condm_model_layout.canvas_width, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.canvas_width = objdm_model_layoutEN.canvas_width; //画布宽
}
if (arrFldSet.Contains(condm_model_layout.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.Status = objdm_model_layoutEN.Status; //Status
}
if (arrFldSet.Contains(condm_model_layout.sort_no, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.sort_no = objdm_model_layoutEN.sort_no; //排序号
}
if (arrFldSet.Contains(condm_model_layout.created_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.created_by = objdm_model_layoutEN.created_by == "[null]" ? null :  objdm_model_layoutEN.created_by; //创建人
}
if (arrFldSet.Contains(condm_model_layout.created_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.created_time = objdm_model_layoutEN.created_time; //创建时间
}
if (arrFldSet.Contains(condm_model_layout.updated_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.updated_by = objdm_model_layoutEN.updated_by == "[null]" ? null :  objdm_model_layoutEN.updated_by; //更新人
}
if (arrFldSet.Contains(condm_model_layout.updated_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.updated_time = objdm_model_layoutEN.updated_time; //更新时间
}
if (arrFldSet.Contains(condm_model_layout.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_layoutEN.remark = objdm_model_layoutEN.remark == "[null]" ? null :  objdm_model_layoutEN.remark; //备注
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
 /// <param name = "objdm_model_layoutEN">源简化对象</param>
 public static void AccessFldValueNull(clsdm_model_layoutEN objdm_model_layoutEN)
{
try
{
if (objdm_model_layoutEN.model_desc == "[null]") objdm_model_layoutEN.model_desc = null; //模型说明
if (objdm_model_layoutEN.layout_data == "[null]") objdm_model_layoutEN.layout_data = null; //布局数据
if (objdm_model_layoutEN.created_by == "[null]") objdm_model_layoutEN.created_by = null; //创建人
if (objdm_model_layoutEN.updated_by == "[null]") objdm_model_layoutEN.updated_by = null; //更新人
if (objdm_model_layoutEN.remark == "[null]") objdm_model_layoutEN.remark = null; //备注
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
public static void CheckPropertyNew(clsdm_model_layoutEN objdm_model_layoutEN)
{
 dm_model_layoutDA.CheckPropertyNew(objdm_model_layoutEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsdm_model_layoutEN objdm_model_layoutEN)
{
 dm_model_layoutDA.CheckProperty4Condition(objdm_model_layoutEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_model_idCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[模型布局表]...","0");
List<clsdm_model_layoutEN> arrdm_model_layoutObjLst = GetAlldm_model_layoutObjLstCache(); 
objDDL.DataValueField = condm_model_layout.model_id;
objDDL.DataTextField = condm_model_layout.model_name;
objDDL.DataSource = arrdm_model_layoutObjLst;
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
if (clsdm_model_layoutBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsdm_model_layoutBL没有刷新缓存机制(clsdm_model_layoutBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by model_id");
//if (arrdm_model_layoutObjLstCache == null)
//{
//arrdm_model_layoutObjLstCache = dm_model_layoutDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strmodel_id">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_layoutEN GetObjBymodel_idCache(string strmodel_id)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsdm_model_layoutEN._CurrTabName);
List<clsdm_model_layoutEN> arrdm_model_layoutObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_layoutEN> arrdm_model_layoutObjLst_Sel =
arrdm_model_layoutObjLstCache
.Where(x=> x.model_id == strmodel_id 
);
if (arrdm_model_layoutObjLst_Sel.Count() == 0)
{
   clsdm_model_layoutEN obj = clsdm_model_layoutBL.GetObjBymodel_id(strmodel_id);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrdm_model_layoutObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strmodel_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string Getmodel_nameBymodel_idCache(string strmodel_id)
{
if (string.IsNullOrEmpty(strmodel_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_layoutEN objdm_model_layout = GetObjBymodel_idCache(strmodel_id);
if (objdm_model_layout == null) return "";
return objdm_model_layout.model_name;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strmodel_id">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymodel_idCache(string strmodel_id)
{
if (string.IsNullOrEmpty(strmodel_id) == true) return "";
//获取缓存中的对象列表
clsdm_model_layoutEN objdm_model_layout = GetObjBymodel_idCache(strmodel_id);
if (objdm_model_layout == null) return "";
return objdm_model_layout.model_name;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_layoutEN> GetAlldm_model_layoutObjLstCache()
{
//获取缓存中的对象列表
List<clsdm_model_layoutEN> arrdm_model_layoutObjLstCache = GetObjLstCache(); 
return arrdm_model_layoutObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_layoutEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsdm_model_layoutEN._CurrTabName);
List<clsdm_model_layoutEN> arrdm_model_layoutObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrdm_model_layoutObjLstCache;
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
string strKey = string.Format("{0}", clsdm_model_layoutEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_layoutEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsdm_model_layoutEN._RefreshTimeLst.Count == 0) return "";
return clsdm_model_layoutEN._RefreshTimeLst[clsdm_model_layoutEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsdm_model_layoutBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsdm_model_layoutEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_layoutEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsdm_model_layoutBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--dm_model_layout(模型布局表)
 /// 唯一性条件:model_name_prj_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_layoutEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsdm_model_layoutEN objdm_model_layoutEN)
{
//检测记录是否存在
string strResult = dm_model_layoutDA.GetUniCondStr(objdm_model_layoutEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-08-04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strmodel_id)
{
if (strInFldName != condm_model_layout.model_id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (condm_model_layout._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", condm_model_layout._AttributeName));
throw new Exception(strMsg);
}
var objdm_model_layout = clsdm_model_layoutBL.GetObjBymodel_idCache(strmodel_id);
if (objdm_model_layout == null) return "";
return objdm_model_layout[strOutFldName].ToString();
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
int intRecCount = clsdm_model_layoutDA.GetRecCount(strTabName);
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
int intRecCount = clsdm_model_layoutDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsdm_model_layoutDA.GetRecCount();
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
int intRecCount = clsdm_model_layoutDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objdm_model_layoutCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsdm_model_layoutEN objdm_model_layoutCond)
{
List<clsdm_model_layoutEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_layoutEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_layout._AttributeName)
{
if (objdm_model_layoutCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_layoutCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_layoutCond[strFldName].ToString());
}
else
{
if (objdm_model_layoutCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_layoutCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_layoutCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_layoutCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_layoutCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_layoutCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_layoutCond[strFldName]));
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
 List<string> arrList = clsdm_model_layoutDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = dm_model_layoutDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = dm_model_layoutDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = dm_model_layoutDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_layoutDA.SetFldValue(clsdm_model_layoutEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = dm_model_layoutDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_layoutDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_layoutDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_layoutDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[dm_model_layout] "); 
 strCreateTabCode.Append(" ( "); 
 // /**模型ID*/ 
 strCreateTabCode.Append(" model_id varchar(32) primary key, "); 
 // /**模型名称*/ 
 strCreateTabCode.Append(" model_name varchar(100) not Null, "); 
 // /**项目ID*/ 
 strCreateTabCode.Append(" prj_id varchar(32) not Null, "); 
 // /**模型说明*/ 
 strCreateTabCode.Append(" model_desc varchar(500) Null, "); 
 // /**布局数据*/ 
 strCreateTabCode.Append(" layout_data varchar(4000) Null, "); 
 // /**画布高*/ 
 strCreateTabCode.Append(" canvas_height int Null, "); 
 // /**画布宽*/ 
 strCreateTabCode.Append(" canvas_width int Null, "); 
 // /**Status*/ 
 strCreateTabCode.Append(" Status varchar(20) not Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" sort_no int Null, "); 
 // /**创建人*/ 
 strCreateTabCode.Append(" created_by varchar(50) Null, "); 
 // /**创建时间*/ 
 strCreateTabCode.Append(" created_time datetime Null, "); 
 // /**更新人*/ 
 strCreateTabCode.Append(" updated_by varchar(50) Null, "); 
 // /**更新时间*/ 
 strCreateTabCode.Append(" updated_time datetime Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" remark varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 模型布局表(dm_model_layout)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4dm_model_layout : clsCommFun4BL
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
clsdm_model_layoutBL.ReFreshThisCache();
}
}

}