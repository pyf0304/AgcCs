
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsdm_model_diagram_relationBL
 表名:dm_model_diagram_relation(00050666)
 * 版本:2026.08.01(服务器:WIN-SRV103-116)
 日期:2026/08/05 16:02:20
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
public static class  clsdm_model_diagram_relationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_relation_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagram_relationEN GetObj(this K_diagram_relation_id_dm_model_diagram_relation myKey)
{
clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.GetObjBydiagram_relation_id(myKey.Value);
return objdm_model_diagram_relationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_relationEN) == false)
{
var strMsg = string.Format("记录已经存在!项目ID = [{0}],关系ID = [{1}],图ID = [{2}]的数据已经存在!(in clsdm_model_diagram_relationBL.AddNewRecord)", objdm_model_diagram_relationEN.prj_id,objdm_model_diagram_relationEN.relation_id,objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
bool bolResult = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.AddNewRecordBySQL2(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
public static bool AddRecordEx(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objdm_model_diagram_relationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_relationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(项目ID(prj_id)=[{0}],关系ID(relation_id)=[{1}],图ID(diagram_id)=[{2}])已经存在,不能重复!", objdm_model_diagram_relationEN.prj_id, objdm_model_diagram_relationEN.relation_id, objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objdm_model_diagram_relationEN.AddNewRecord();
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_relationEN) == false)
{
var strMsg = string.Format("记录已经存在!项目ID = [{0}],关系ID = [{1}],图ID = [{2}]的数据已经存在!(in clsdm_model_diagram_relationBL.AddNewRecordWithMaxId)", objdm_model_diagram_relationEN.prj_id,objdm_model_diagram_relationEN.relation_id,objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
string strdiagram_relation_id = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_relationEN);
     objdm_model_diagram_relationEN.diagram_relation_id = strdiagram_relation_id;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
}
return strdiagram_relation_id;
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objdm_model_diagram_relationEN) == false)
{
var strMsg = string.Format("记录已经存在!项目ID = [{0}],关系ID = [{1}],图ID = [{2}]的数据已经存在!(in clsdm_model_diagram_relationBL.AddNewRecordWithReturnKey)", objdm_model_diagram_relationEN.prj_id,objdm_model_diagram_relationEN.relation_id,objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
string strKey = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setdiagram_relation_id(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strdiagram_relation_id, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_relation_id, 32, condm_model_diagram_relation.diagram_relation_id);
}
objdm_model_diagram_relationEN.diagram_relation_id = strdiagram_relation_id; //图关系映射ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.diagram_relation_id) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.diagram_relation_id, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.diagram_relation_id] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setprj_id(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strprj_id, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strprj_id, condm_model_diagram_relation.prj_id);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strprj_id, 32, condm_model_diagram_relation.prj_id);
}
objdm_model_diagram_relationEN.prj_id = strprj_id; //项目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.prj_id) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.prj_id, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.prj_id] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setdiagram_id(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strdiagram_id, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strdiagram_id, condm_model_diagram_relation.diagram_id);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strdiagram_id, 32, condm_model_diagram_relation.diagram_id);
}
objdm_model_diagram_relationEN.diagram_id = strdiagram_id; //图ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.diagram_id) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.diagram_id, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.diagram_id] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setrelation_id(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strrelation_id, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strrelation_id, condm_model_diagram_relation.relation_id);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strrelation_id, 32, condm_model_diagram_relation.relation_id);
}
objdm_model_diagram_relationEN.relation_id = strrelation_id; //关系ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.relation_id) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.relation_id, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.relation_id] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setrelation_view_type(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strrelation_view_type, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strrelation_view_type, condm_model_diagram_relation.relation_view_type);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strrelation_view_type, 30, condm_model_diagram_relation.relation_view_type);
}
objdm_model_diagram_relationEN.relation_view_type = strrelation_view_type; //关系视图类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.relation_view_type) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.relation_view_type, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.relation_view_type] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setline_style(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strline_style, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strline_style, condm_model_diagram_relation.line_style);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strline_style, 20, condm_model_diagram_relation.line_style);
}
objdm_model_diagram_relationEN.line_style = strline_style; //线条样式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.line_style) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.line_style, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.line_style] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setarrow_mode(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strarrow_mode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strarrow_mode, condm_model_diagram_relation.arrow_mode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strarrow_mode, 20, condm_model_diagram_relation.arrow_mode);
}
objdm_model_diagram_relationEN.arrow_mode = strarrow_mode; //箭头模式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.arrow_mode) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.arrow_mode, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.arrow_mode] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setsort_no(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, int intsort_no, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intsort_no, condm_model_diagram_relation.sort_no);
objdm_model_diagram_relationEN.sort_no = intsort_no; //排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.sort_no) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.sort_no, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.sort_no] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setis_visible(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolis_visible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolis_visible, condm_model_diagram_relation.is_visible);
objdm_model_diagram_relationEN.is_visible = bolis_visible; //是否可见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.is_visible) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.is_visible, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.is_visible] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setroute_points_json(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strroute_points_json, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strroute_points_json, 4000, condm_model_diagram_relation.route_points_json);
}
objdm_model_diagram_relationEN.route_points_json = strroute_points_json; //连线路径点JSON
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.route_points_json) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.route_points_json, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.route_points_json] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setsource_port_side(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strsource_port_side, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsource_port_side, 10, condm_model_diagram_relation.source_port_side);
}
objdm_model_diagram_relationEN.source_port_side = strsource_port_side; //起点端口边
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.source_port_side) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.source_port_side, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.source_port_side] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Settarget_port_side(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strtarget_port_side, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strtarget_port_side, 10, condm_model_diagram_relation.target_port_side);
}
objdm_model_diagram_relationEN.target_port_side = strtarget_port_side; //终点端口边
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.target_port_side) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.target_port_side, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.target_port_side] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setsource_port_slot(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, int? intsource_port_slot, string strComparisonOp="")
	{
objdm_model_diagram_relationEN.source_port_slot = intsource_port_slot; //起点端口槽位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.source_port_slot) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.source_port_slot, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.source_port_slot] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Settarget_port_slot(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, int? inttarget_port_slot, string strComparisonOp="")
	{
objdm_model_diagram_relationEN.target_port_slot = inttarget_port_slot; //终点端口槽位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.target_port_slot) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.target_port_slot, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.target_port_slot] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setroute_algo(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strroute_algo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strroute_algo, 30, condm_model_diagram_relation.route_algo);
}
objdm_model_diagram_relationEN.route_algo = strroute_algo; //路线算法版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.route_algo) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.route_algo, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.route_algo] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN SetStatus(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, condm_model_diagram_relation.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, condm_model_diagram_relation.Status);
}
objdm_model_diagram_relationEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.Status) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.Status, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.Status] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setcreated_by(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strcreated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcreated_by, condm_model_diagram_relation.created_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcreated_by, 50, condm_model_diagram_relation.created_by);
}
objdm_model_diagram_relationEN.created_by = strcreated_by; //创建人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.created_by) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.created_by, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.created_by] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setcreated_time(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, DateTime dtecreated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dtecreated_time, condm_model_diagram_relation.created_time);
objdm_model_diagram_relationEN.created_time = dtecreated_time; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.created_time) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.created_time, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.created_time] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setupdated_by(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strupdated_by, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strupdated_by, condm_model_diagram_relation.updated_by);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strupdated_by, 50, condm_model_diagram_relation.updated_by);
}
objdm_model_diagram_relationEN.updated_by = strupdated_by; //更新人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.updated_by) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.updated_by, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.updated_by] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setupdated_time(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, DateTime dteupdated_time, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteupdated_time, condm_model_diagram_relation.updated_time);
objdm_model_diagram_relationEN.updated_time = dteupdated_time; //更新时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.updated_time) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.updated_time, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.updated_time] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsdm_model_diagram_relationEN Setremark(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strremark, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strremark, 500, condm_model_diagram_relation.remark);
}
objdm_model_diagram_relationEN.remark = strremark; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objdm_model_diagram_relationEN.dicFldComparisonOp.ContainsKey(condm_model_diagram_relation.remark) == false)
{
objdm_model_diagram_relationEN.dicFldComparisonOp.Add(condm_model_diagram_relation.remark, strComparisonOp);
}
else
{
objdm_model_diagram_relationEN.dicFldComparisonOp[condm_model_diagram_relation.remark] = strComparisonOp;
}
}
return objdm_model_diagram_relationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objdm_model_diagram_relationEN.CheckPropertyNew();
clsdm_model_diagram_relationEN objdm_model_diagram_relationCond = new clsdm_model_diagram_relationEN();
string strCondition = objdm_model_diagram_relationCond
.Setdiagram_relation_id(objdm_model_diagram_relationEN.diagram_relation_id, "<>")
.Setprj_id(objdm_model_diagram_relationEN.prj_id, "=")
.Setrelation_id(objdm_model_diagram_relationEN.relation_id, "=")
.Setdiagram_id(objdm_model_diagram_relationEN.diagram_id, "=")
.GetCombineCondition();
objdm_model_diagram_relationEN._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagram_relationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objdm_model_diagram_relationEN.Update();
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
 /// <param name = "objdm_model_diagram_relation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsdm_model_diagram_relationEN objdm_model_diagram_relation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsdm_model_diagram_relationEN objdm_model_diagram_relationCond = new clsdm_model_diagram_relationEN();
string strCondition = objdm_model_diagram_relationCond
.Setprj_id(objdm_model_diagram_relation.prj_id, "=")
.Setrelation_id(objdm_model_diagram_relation.relation_id, "=")
.Setdiagram_id(objdm_model_diagram_relation.diagram_id, "=")
.GetCombineCondition();
objdm_model_diagram_relation._IsCheckProperty = true;
bool bolIsExist = clsdm_model_diagram_relationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objdm_model_diagram_relation.diagram_relation_id = clsdm_model_diagram_relationBL.GetFirstID_S(strCondition);
objdm_model_diagram_relation.UpdateWithCondition(strCondition);
}
else
{
objdm_model_diagram_relation.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
objdm_model_diagram_relation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.UpdateBySql2(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.UpdateBySql2(objdm_model_diagram_relationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strWhereCond)
{
try
{
bool bolResult = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.UpdateBySqlWithCondition(objdm_model_diagram_relationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.UpdateBySqlWithConditionTransaction(objdm_model_diagram_relationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "strdiagram_relation_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
try
{
int intRecNum = clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.DelRecord(objdm_model_diagram_relationEN.diagram_relation_id);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationENS">源对象</param>
 /// <param name = "objdm_model_diagram_relationENT">目标对象</param>
 public static void CopyTo(this clsdm_model_diagram_relationEN objdm_model_diagram_relationENS, clsdm_model_diagram_relationEN objdm_model_diagram_relationENT)
{
try
{
objdm_model_diagram_relationENT.diagram_relation_id = objdm_model_diagram_relationENS.diagram_relation_id; //图关系映射ID
objdm_model_diagram_relationENT.prj_id = objdm_model_diagram_relationENS.prj_id; //项目ID
objdm_model_diagram_relationENT.diagram_id = objdm_model_diagram_relationENS.diagram_id; //图ID
objdm_model_diagram_relationENT.relation_id = objdm_model_diagram_relationENS.relation_id; //关系ID
objdm_model_diagram_relationENT.relation_view_type = objdm_model_diagram_relationENS.relation_view_type; //关系视图类型
objdm_model_diagram_relationENT.line_style = objdm_model_diagram_relationENS.line_style; //线条样式
objdm_model_diagram_relationENT.arrow_mode = objdm_model_diagram_relationENS.arrow_mode; //箭头模式
objdm_model_diagram_relationENT.sort_no = objdm_model_diagram_relationENS.sort_no; //排序号
objdm_model_diagram_relationENT.is_visible = objdm_model_diagram_relationENS.is_visible; //是否可见
objdm_model_diagram_relationENT.route_points_json = objdm_model_diagram_relationENS.route_points_json; //连线路径点JSON
objdm_model_diagram_relationENT.source_port_side = objdm_model_diagram_relationENS.source_port_side; //起点端口边
objdm_model_diagram_relationENT.target_port_side = objdm_model_diagram_relationENS.target_port_side; //终点端口边
objdm_model_diagram_relationENT.source_port_slot = objdm_model_diagram_relationENS.source_port_slot; //起点端口槽位
objdm_model_diagram_relationENT.target_port_slot = objdm_model_diagram_relationENS.target_port_slot; //终点端口槽位
objdm_model_diagram_relationENT.route_algo = objdm_model_diagram_relationENS.route_algo; //路线算法版本
objdm_model_diagram_relationENT.Status = objdm_model_diagram_relationENS.Status; //Status
objdm_model_diagram_relationENT.created_by = objdm_model_diagram_relationENS.created_by; //创建人
objdm_model_diagram_relationENT.created_time = objdm_model_diagram_relationENS.created_time; //创建时间
objdm_model_diagram_relationENT.updated_by = objdm_model_diagram_relationENS.updated_by; //更新人
objdm_model_diagram_relationENT.updated_time = objdm_model_diagram_relationENS.updated_time; //更新时间
objdm_model_diagram_relationENT.remark = objdm_model_diagram_relationENS.remark; //备注
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
 /// <param name = "objdm_model_diagram_relationENS">源对象</param>
 /// <returns>目标对象=>clsdm_model_diagram_relationEN:objdm_model_diagram_relationENT</returns>
 public static clsdm_model_diagram_relationEN CopyTo(this clsdm_model_diagram_relationEN objdm_model_diagram_relationENS)
{
try
{
 clsdm_model_diagram_relationEN objdm_model_diagram_relationENT = new clsdm_model_diagram_relationEN()
{
diagram_relation_id = objdm_model_diagram_relationENS.diagram_relation_id, //图关系映射ID
prj_id = objdm_model_diagram_relationENS.prj_id, //项目ID
diagram_id = objdm_model_diagram_relationENS.diagram_id, //图ID
relation_id = objdm_model_diagram_relationENS.relation_id, //关系ID
relation_view_type = objdm_model_diagram_relationENS.relation_view_type, //关系视图类型
line_style = objdm_model_diagram_relationENS.line_style, //线条样式
arrow_mode = objdm_model_diagram_relationENS.arrow_mode, //箭头模式
sort_no = objdm_model_diagram_relationENS.sort_no, //排序号
is_visible = objdm_model_diagram_relationENS.is_visible, //是否可见
route_points_json = objdm_model_diagram_relationENS.route_points_json, //连线路径点JSON
source_port_side = objdm_model_diagram_relationENS.source_port_side, //起点端口边
target_port_side = objdm_model_diagram_relationENS.target_port_side, //终点端口边
source_port_slot = objdm_model_diagram_relationENS.source_port_slot, //起点端口槽位
target_port_slot = objdm_model_diagram_relationENS.target_port_slot, //终点端口槽位
route_algo = objdm_model_diagram_relationENS.route_algo, //路线算法版本
Status = objdm_model_diagram_relationENS.Status, //Status
created_by = objdm_model_diagram_relationENS.created_by, //创建人
created_time = objdm_model_diagram_relationENS.created_time, //创建时间
updated_by = objdm_model_diagram_relationENS.updated_by, //更新人
updated_time = objdm_model_diagram_relationENS.updated_time, //更新时间
remark = objdm_model_diagram_relationENS.remark, //备注
};
 return objdm_model_diagram_relationENT;
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
public static void CheckPropertyNew(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.CheckPropertyNew(objdm_model_diagram_relationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 clsdm_model_diagram_relationBL.dm_model_diagram_relationDA.CheckProperty4Condition(objdm_model_diagram_relationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsdm_model_diagram_relationEN objdm_model_diagram_relationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.diagram_relation_id) == true)
{
string strComparisonOpdiagram_relation_id = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.diagram_relation_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.diagram_relation_id, objdm_model_diagram_relationCond.diagram_relation_id, strComparisonOpdiagram_relation_id);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.prj_id) == true)
{
string strComparisonOpprj_id = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.prj_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.prj_id, objdm_model_diagram_relationCond.prj_id, strComparisonOpprj_id);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.diagram_id) == true)
{
string strComparisonOpdiagram_id = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.diagram_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.diagram_id, objdm_model_diagram_relationCond.diagram_id, strComparisonOpdiagram_id);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.relation_id) == true)
{
string strComparisonOprelation_id = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.relation_id];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.relation_id, objdm_model_diagram_relationCond.relation_id, strComparisonOprelation_id);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.relation_view_type) == true)
{
string strComparisonOprelation_view_type = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.relation_view_type];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.relation_view_type, objdm_model_diagram_relationCond.relation_view_type, strComparisonOprelation_view_type);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.line_style) == true)
{
string strComparisonOpline_style = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.line_style];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.line_style, objdm_model_diagram_relationCond.line_style, strComparisonOpline_style);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.arrow_mode) == true)
{
string strComparisonOparrow_mode = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.arrow_mode];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.arrow_mode, objdm_model_diagram_relationCond.arrow_mode, strComparisonOparrow_mode);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.sort_no) == true)
{
string strComparisonOpsort_no = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.sort_no];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_relation.sort_no, objdm_model_diagram_relationCond.sort_no, strComparisonOpsort_no);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.is_visible) == true)
{
if (objdm_model_diagram_relationCond.is_visible == true)
{
strWhereCond += string.Format(" And {0} = '1'", condm_model_diagram_relation.is_visible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", condm_model_diagram_relation.is_visible);
}
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.route_points_json) == true)
{
string strComparisonOproute_points_json = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.route_points_json];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.route_points_json, objdm_model_diagram_relationCond.route_points_json, strComparisonOproute_points_json);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.source_port_side) == true)
{
string strComparisonOpsource_port_side = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.source_port_side];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.source_port_side, objdm_model_diagram_relationCond.source_port_side, strComparisonOpsource_port_side);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.target_port_side) == true)
{
string strComparisonOptarget_port_side = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.target_port_side];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.target_port_side, objdm_model_diagram_relationCond.target_port_side, strComparisonOptarget_port_side);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.source_port_slot) == true)
{
string strComparisonOpsource_port_slot = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.source_port_slot];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_relation.source_port_slot, objdm_model_diagram_relationCond.source_port_slot, strComparisonOpsource_port_slot);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.target_port_slot) == true)
{
string strComparisonOptarget_port_slot = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.target_port_slot];
strWhereCond += string.Format(" And {0} {2} {1}", condm_model_diagram_relation.target_port_slot, objdm_model_diagram_relationCond.target_port_slot, strComparisonOptarget_port_slot);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.route_algo) == true)
{
string strComparisonOproute_algo = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.route_algo];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.route_algo, objdm_model_diagram_relationCond.route_algo, strComparisonOproute_algo);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.Status) == true)
{
string strComparisonOpStatus = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.Status, objdm_model_diagram_relationCond.Status, strComparisonOpStatus);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.created_by) == true)
{
string strComparisonOpcreated_by = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.created_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.created_by, objdm_model_diagram_relationCond.created_by, strComparisonOpcreated_by);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.created_time) == true)
{
string strComparisonOpcreated_time = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.created_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.created_time, objdm_model_diagram_relationCond.created_time, strComparisonOpcreated_time);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.updated_by) == true)
{
string strComparisonOpupdated_by = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.updated_by];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.updated_by, objdm_model_diagram_relationCond.updated_by, strComparisonOpupdated_by);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.updated_time) == true)
{
string strComparisonOpupdated_time = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.updated_time];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.updated_time, objdm_model_diagram_relationCond.updated_time, strComparisonOpupdated_time);
}
if (objdm_model_diagram_relationCond.IsUpdated(condm_model_diagram_relation.remark) == true)
{
string strComparisonOpremark = objdm_model_diagram_relationCond.dicFldComparisonOp[condm_model_diagram_relation.remark];
strWhereCond += string.Format(" And {0} {2} '{1}'", condm_model_diagram_relation.remark, objdm_model_diagram_relationCond.remark, strComparisonOpremark);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--dm_model_diagram_relation(数据模型图关系映射), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:diagram_id_prj_id_relation_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagram_relationEN == null) return true;
if (objdm_model_diagram_relationEN.diagram_relation_id == null || objdm_model_diagram_relationEN.diagram_relation_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_diagram_relationEN.prj_id);
 sbCondition.AppendFormat(" and relation_id = '{0}'", objdm_model_diagram_relationEN.relation_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_relationEN.diagram_id);
if (clsdm_model_diagram_relationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("diagram_relation_id !=  '{0}'", objdm_model_diagram_relationEN.diagram_relation_id);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_diagram_relationEN.prj_id);
 sbCondition.AppendFormat(" and relation_id = '{0}'", objdm_model_diagram_relationEN.relation_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_relationEN.diagram_id);
if (clsdm_model_diagram_relationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--dm_model_diagram_relation(数据模型图关系映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:diagram_id_prj_id_relation_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objdm_model_diagram_relationEN == null) return "";
if (objdm_model_diagram_relationEN.diagram_relation_id == null || objdm_model_diagram_relationEN.diagram_relation_id == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_diagram_relationEN.prj_id);
 sbCondition.AppendFormat(" and relation_id = '{0}'", objdm_model_diagram_relationEN.relation_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_relationEN.diagram_id);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("diagram_relation_id !=  '{0}'", objdm_model_diagram_relationEN.diagram_relation_id);
 sbCondition.AppendFormat(" and prj_id = '{0}'", objdm_model_diagram_relationEN.prj_id);
 sbCondition.AppendFormat(" and relation_id = '{0}'", objdm_model_diagram_relationEN.relation_id);
 sbCondition.AppendFormat(" and diagram_id = '{0}'", objdm_model_diagram_relationEN.diagram_id);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_dm_model_diagram_relation
{
public virtual bool UpdRelaTabDate(string strdiagram_relation_id, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据模型图关系映射(dm_model_diagram_relation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsdm_model_diagram_relationBL
{
public static RelatedActions_dm_model_diagram_relation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsdm_model_diagram_relationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsdm_model_diagram_relationDA dm_model_diagram_relationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsdm_model_diagram_relationDA();
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
 public clsdm_model_diagram_relationBL()
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
if (string.IsNullOrEmpty(clsdm_model_diagram_relationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsdm_model_diagram_relationEN._ConnectString);
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
public static DataTable GetDataTable_dm_model_diagram_relation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = dm_model_diagram_relationDA.GetDataTable_dm_model_diagram_relation(strWhereCond);
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
objDT = dm_model_diagram_relationDA.GetDataTable(strWhereCond);
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
objDT = dm_model_diagram_relationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = dm_model_diagram_relationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = dm_model_diagram_relationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = dm_model_diagram_relationDA.GetDataTable_Top(objTopPara);
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
objDT = dm_model_diagram_relationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = dm_model_diagram_relationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = dm_model_diagram_relationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDiagram_relation_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetObjLstByDiagram_relation_idLst(List<string> arrDiagram_relation_idLst)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDiagram_relation_idLst, true);
 string strWhereCond = string.Format("diagram_relation_id in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDiagram_relation_idLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsdm_model_diagram_relationEN> GetObjLstByDiagram_relation_idLstCache(List<string> arrDiagram_relation_idLst)
{
string strKey = string.Format("{0}", clsdm_model_diagram_relationEN._CurrTabName);
List<clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLst_Sel =
arrdm_model_diagram_relationObjLstCache
.Where(x => arrDiagram_relation_idLst.Contains(x.diagram_relation_id));
return arrdm_model_diagram_relationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetObjLst(string strWhereCond)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
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
public static List<clsdm_model_diagram_relationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsdm_model_diagram_relationEN> GetSubObjLstCache(clsdm_model_diagram_relationEN objdm_model_diagram_relationCond)
{
List<clsdm_model_diagram_relationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_relationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram_relation._AttributeName)
{
if (objdm_model_diagram_relationCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagram_relationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_relationCond[strFldName].ToString());
}
else
{
if (objdm_model_diagram_relationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagram_relationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_relationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagram_relationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_relationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_relationCond[strFldName]));
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
public static List<clsdm_model_diagram_relationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
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
public static List<clsdm_model_diagram_relationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
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
List<clsdm_model_diagram_relationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsdm_model_diagram_relationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsdm_model_diagram_relationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
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
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
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
public static List<clsdm_model_diagram_relationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsdm_model_diagram_relationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
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
public static List<clsdm_model_diagram_relationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsdm_model_diagram_relationEN> arrObjLst = new List<clsdm_model_diagram_relationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = new clsdm_model_diagram_relationEN();
try
{
objdm_model_diagram_relationEN.diagram_relation_id = objRow[condm_model_diagram_relation.diagram_relation_id].ToString().Trim(); //图关系映射ID
objdm_model_diagram_relationEN.prj_id = objRow[condm_model_diagram_relation.prj_id].ToString().Trim(); //项目ID
objdm_model_diagram_relationEN.diagram_id = objRow[condm_model_diagram_relation.diagram_id].ToString().Trim(); //图ID
objdm_model_diagram_relationEN.relation_id = objRow[condm_model_diagram_relation.relation_id].ToString().Trim(); //关系ID
objdm_model_diagram_relationEN.relation_view_type = objRow[condm_model_diagram_relation.relation_view_type].ToString().Trim(); //关系视图类型
objdm_model_diagram_relationEN.line_style = objRow[condm_model_diagram_relation.line_style].ToString().Trim(); //线条样式
objdm_model_diagram_relationEN.arrow_mode = objRow[condm_model_diagram_relation.arrow_mode].ToString().Trim(); //箭头模式
objdm_model_diagram_relationEN.sort_no = Int32.Parse(objRow[condm_model_diagram_relation.sort_no].ToString().Trim()); //排序号
objdm_model_diagram_relationEN.is_visible = clsEntityBase2.TransNullToBool_S(objRow[condm_model_diagram_relation.is_visible].ToString().Trim()); //是否可见
objdm_model_diagram_relationEN.route_points_json = objRow[condm_model_diagram_relation.route_points_json] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_points_json].ToString().Trim(); //连线路径点JSON
objdm_model_diagram_relationEN.source_port_side = objRow[condm_model_diagram_relation.source_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.source_port_side].ToString().Trim(); //起点端口边
objdm_model_diagram_relationEN.target_port_side = objRow[condm_model_diagram_relation.target_port_side] == DBNull.Value ? null : objRow[condm_model_diagram_relation.target_port_side].ToString().Trim(); //终点端口边
objdm_model_diagram_relationEN.source_port_slot = objRow[condm_model_diagram_relation.source_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.source_port_slot].ToString().Trim()); //起点端口槽位
objdm_model_diagram_relationEN.target_port_slot = objRow[condm_model_diagram_relation.target_port_slot] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[condm_model_diagram_relation.target_port_slot].ToString().Trim()); //终点端口槽位
objdm_model_diagram_relationEN.route_algo = objRow[condm_model_diagram_relation.route_algo] == DBNull.Value ? null : objRow[condm_model_diagram_relation.route_algo].ToString().Trim(); //路线算法版本
objdm_model_diagram_relationEN.Status = objRow[condm_model_diagram_relation.Status].ToString().Trim(); //Status
objdm_model_diagram_relationEN.created_by = objRow[condm_model_diagram_relation.created_by].ToString().Trim(); //创建人
objdm_model_diagram_relationEN.created_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.created_time].ToString().Trim()); //创建时间
objdm_model_diagram_relationEN.updated_by = objRow[condm_model_diagram_relation.updated_by].ToString().Trim(); //更新人
objdm_model_diagram_relationEN.updated_time = System.DateTime.Parse(objRow[condm_model_diagram_relation.updated_time].ToString().Trim()); //更新时间
objdm_model_diagram_relationEN.remark = objRow[condm_model_diagram_relation.remark] == DBNull.Value ? null : objRow[condm_model_diagram_relation.remark].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objdm_model_diagram_relationEN.diagram_relation_id, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objdm_model_diagram_relationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getdm_model_diagram_relation(ref clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
bool bolResult = dm_model_diagram_relationDA.Getdm_model_diagram_relation(ref objdm_model_diagram_relationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strdiagram_relation_id">表关键字</param>
 /// <returns>表对象</returns>
public static clsdm_model_diagram_relationEN GetObjBydiagram_relation_id(string strdiagram_relation_id)
{
if (strdiagram_relation_id.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strdiagram_relation_id]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strdiagram_relation_id) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strdiagram_relation_id]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = dm_model_diagram_relationDA.GetObjBydiagram_relation_id(strdiagram_relation_id);
return objdm_model_diagram_relationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsdm_model_diagram_relationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = dm_model_diagram_relationDA.GetFirstObj(strWhereCond);
 return objdm_model_diagram_relationEN;
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
public static clsdm_model_diagram_relationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = dm_model_diagram_relationDA.GetObjByDataRow(objRow);
 return objdm_model_diagram_relationEN;
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
public static clsdm_model_diagram_relationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = dm_model_diagram_relationDA.GetObjByDataRow(objRow);
 return objdm_model_diagram_relationEN;
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
 /// <param name = "strdiagram_relation_id">所给的关键字</param>
 /// <param name = "lstdm_model_diagram_relationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagram_relationEN GetObjBydiagram_relation_idFromList(string strdiagram_relation_id, List<clsdm_model_diagram_relationEN> lstdm_model_diagram_relationObjLst)
{
foreach (clsdm_model_diagram_relationEN objdm_model_diagram_relationEN in lstdm_model_diagram_relationObjLst)
{
if (objdm_model_diagram_relationEN.diagram_relation_id == strdiagram_relation_id)
{
return objdm_model_diagram_relationEN;
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
 string strMaxDiagram_relation_id;
 try
 {
 strMaxDiagram_relation_id = clsdm_model_diagram_relationDA.GetMaxStrId();
 return strMaxDiagram_relation_id;
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
 string strdiagram_relation_id;
 try
 {
 strdiagram_relation_id = new clsdm_model_diagram_relationDA().GetFirstID(strWhereCond);
 return strdiagram_relation_id;
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
 arrList = dm_model_diagram_relationDA.GetID(strWhereCond);
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
bool bolIsExist = dm_model_diagram_relationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strdiagram_relation_id">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strdiagram_relation_id)
{
if (string.IsNullOrEmpty(strdiagram_relation_id) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strdiagram_relation_id]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = dm_model_diagram_relationDA.IsExist(strdiagram_relation_id);
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
 bolIsExist = clsdm_model_diagram_relationDA.IsExistTable();
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
 bolIsExist = dm_model_diagram_relationDA.IsExistTable(strTabName);
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_relationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目ID = [{0}],关系ID = [{1}],图ID = [{2}]的数据已经存在!(in clsdm_model_diagram_relationBL.AddNewRecordBySql2)", objdm_model_diagram_relationEN.prj_id,objdm_model_diagram_relationEN.relation_id,objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
bool bolResult = dm_model_diagram_relationDA.AddNewRecordBySQL2(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objdm_model_diagram_relationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目ID = [{0}],关系ID = [{1}],图ID = [{2}]的数据已经存在!(in clsdm_model_diagram_relationBL.AddNewRecordBySql2WithReturnKey)", objdm_model_diagram_relationEN.prj_id,objdm_model_diagram_relationEN.relation_id,objdm_model_diagram_relationEN.diagram_id);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true || clsdm_model_diagram_relationBL.IsExist(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
     objdm_model_diagram_relationEN.diagram_relation_id = clsdm_model_diagram_relationBL.GetMaxStrId_S();
 }
string strKey = dm_model_diagram_relationDA.AddNewRecordBySQL2WithReturnKey(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
try
{
bool bolResult = dm_model_diagram_relationDA.Update(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "objdm_model_diagram_relationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 if (string.IsNullOrEmpty(objdm_model_diagram_relationEN.diagram_relation_id) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = dm_model_diagram_relationDA.UpdateBySql2(objdm_model_diagram_relationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsdm_model_diagram_relationBL.ReFreshCache();

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
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
 /// <param name = "strdiagram_relation_id">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strdiagram_relation_id)
{
try
{
 clsdm_model_diagram_relationEN objdm_model_diagram_relationEN = clsdm_model_diagram_relationBL.GetObjBydiagram_relation_id(strdiagram_relation_id);

if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(objdm_model_diagram_relationEN.diagram_relation_id, "SetUpdDate");
}
if (objdm_model_diagram_relationEN != null)
{
int intRecNum = dm_model_diagram_relationDA.DelRecord(strdiagram_relation_id);
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
/// <param name="strdiagram_relation_id">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strdiagram_relation_id )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagram_relationDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram_relation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//condm_model_diagram_relation.diagram_relation_id,
//strdiagram_relation_id);
//        clsdm_model_diagram_relationBL.Deldm_model_diagram_relationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagram_relationBL.DelRecord(strdiagram_relation_id, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagram_relationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_relation_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strdiagram_relation_id">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strdiagram_relation_id, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsdm_model_diagram_relationBL.relatedActions != null)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(strdiagram_relation_id, "UpdRelaTabDate");
}
bool bolResult = dm_model_diagram_relationDA.DelRecord(strdiagram_relation_id,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrdiagram_relation_idLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deldm_model_diagram_relations(List<string> arrdiagram_relation_idLst)
{
if (arrdiagram_relation_idLst.Count == 0) return 0;
try
{
if (clsdm_model_diagram_relationBL.relatedActions != null)
{
foreach (var strdiagram_relation_id in arrdiagram_relation_idLst)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(strdiagram_relation_id, "UpdRelaTabDate");
}
}
int intDelRecNum = dm_model_diagram_relationDA.Deldm_model_diagram_relation(arrdiagram_relation_idLst);
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
public static int Deldm_model_diagram_relationsByCond(string strWhereCond)
{
try
{
if (clsdm_model_diagram_relationBL.relatedActions != null)
{
List<string> arrdiagram_relation_id = GetPrimaryKeyID_S(strWhereCond);
foreach (var strdiagram_relation_id in arrdiagram_relation_id)
{
clsdm_model_diagram_relationBL.relatedActions.UpdRelaTabDate(strdiagram_relation_id, "UpdRelaTabDate");
}
}
int intRecNum = dm_model_diagram_relationDA.Deldm_model_diagram_relation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[dm_model_diagram_relation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strdiagram_relation_id">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strdiagram_relation_id)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsdm_model_diagram_relationDA.GetSpecSQLObj();
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
//删除与表:[dm_model_diagram_relation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsdm_model_diagram_relationBL.DelRecord(strdiagram_relation_id, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsdm_model_diagram_relationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strdiagram_relation_id, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objdm_model_diagram_relationENS">源对象</param>
 /// <param name = "objdm_model_diagram_relationENT">目标对象</param>
 public static void CopyTo(clsdm_model_diagram_relationEN objdm_model_diagram_relationENS, clsdm_model_diagram_relationEN objdm_model_diagram_relationENT)
{
try
{
objdm_model_diagram_relationENT.diagram_relation_id = objdm_model_diagram_relationENS.diagram_relation_id; //图关系映射ID
objdm_model_diagram_relationENT.prj_id = objdm_model_diagram_relationENS.prj_id; //项目ID
objdm_model_diagram_relationENT.diagram_id = objdm_model_diagram_relationENS.diagram_id; //图ID
objdm_model_diagram_relationENT.relation_id = objdm_model_diagram_relationENS.relation_id; //关系ID
objdm_model_diagram_relationENT.relation_view_type = objdm_model_diagram_relationENS.relation_view_type; //关系视图类型
objdm_model_diagram_relationENT.line_style = objdm_model_diagram_relationENS.line_style; //线条样式
objdm_model_diagram_relationENT.arrow_mode = objdm_model_diagram_relationENS.arrow_mode; //箭头模式
objdm_model_diagram_relationENT.sort_no = objdm_model_diagram_relationENS.sort_no; //排序号
objdm_model_diagram_relationENT.is_visible = objdm_model_diagram_relationENS.is_visible; //是否可见
objdm_model_diagram_relationENT.route_points_json = objdm_model_diagram_relationENS.route_points_json; //连线路径点JSON
objdm_model_diagram_relationENT.source_port_side = objdm_model_diagram_relationENS.source_port_side; //起点端口边
objdm_model_diagram_relationENT.target_port_side = objdm_model_diagram_relationENS.target_port_side; //终点端口边
objdm_model_diagram_relationENT.source_port_slot = objdm_model_diagram_relationENS.source_port_slot; //起点端口槽位
objdm_model_diagram_relationENT.target_port_slot = objdm_model_diagram_relationENS.target_port_slot; //终点端口槽位
objdm_model_diagram_relationENT.route_algo = objdm_model_diagram_relationENS.route_algo; //路线算法版本
objdm_model_diagram_relationENT.Status = objdm_model_diagram_relationENS.Status; //Status
objdm_model_diagram_relationENT.created_by = objdm_model_diagram_relationENS.created_by; //创建人
objdm_model_diagram_relationENT.created_time = objdm_model_diagram_relationENS.created_time; //创建时间
objdm_model_diagram_relationENT.updated_by = objdm_model_diagram_relationENS.updated_by; //更新人
objdm_model_diagram_relationENT.updated_time = objdm_model_diagram_relationENS.updated_time; //更新时间
objdm_model_diagram_relationENT.remark = objdm_model_diagram_relationENS.remark; //备注
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
 /// <param name = "objdm_model_diagram_relationEN">源简化对象</param>
 public static void SetUpdFlag(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
try
{
objdm_model_diagram_relationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objdm_model_diagram_relationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(condm_model_diagram_relation.diagram_relation_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.diagram_relation_id = objdm_model_diagram_relationEN.diagram_relation_id; //图关系映射ID
}
if (arrFldSet.Contains(condm_model_diagram_relation.prj_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.prj_id = objdm_model_diagram_relationEN.prj_id; //项目ID
}
if (arrFldSet.Contains(condm_model_diagram_relation.diagram_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.diagram_id = objdm_model_diagram_relationEN.diagram_id; //图ID
}
if (arrFldSet.Contains(condm_model_diagram_relation.relation_id, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.relation_id = objdm_model_diagram_relationEN.relation_id; //关系ID
}
if (arrFldSet.Contains(condm_model_diagram_relation.relation_view_type, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.relation_view_type = objdm_model_diagram_relationEN.relation_view_type; //关系视图类型
}
if (arrFldSet.Contains(condm_model_diagram_relation.line_style, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.line_style = objdm_model_diagram_relationEN.line_style; //线条样式
}
if (arrFldSet.Contains(condm_model_diagram_relation.arrow_mode, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.arrow_mode = objdm_model_diagram_relationEN.arrow_mode; //箭头模式
}
if (arrFldSet.Contains(condm_model_diagram_relation.sort_no, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.sort_no = objdm_model_diagram_relationEN.sort_no; //排序号
}
if (arrFldSet.Contains(condm_model_diagram_relation.is_visible, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.is_visible = objdm_model_diagram_relationEN.is_visible; //是否可见
}
if (arrFldSet.Contains(condm_model_diagram_relation.route_points_json, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.route_points_json = objdm_model_diagram_relationEN.route_points_json == "[null]" ? null :  objdm_model_diagram_relationEN.route_points_json; //连线路径点JSON
}
if (arrFldSet.Contains(condm_model_diagram_relation.source_port_side, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.source_port_side = objdm_model_diagram_relationEN.source_port_side == "[null]" ? null :  objdm_model_diagram_relationEN.source_port_side; //起点端口边
}
if (arrFldSet.Contains(condm_model_diagram_relation.target_port_side, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.target_port_side = objdm_model_diagram_relationEN.target_port_side == "[null]" ? null :  objdm_model_diagram_relationEN.target_port_side; //终点端口边
}
if (arrFldSet.Contains(condm_model_diagram_relation.source_port_slot, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.source_port_slot = objdm_model_diagram_relationEN.source_port_slot; //起点端口槽位
}
if (arrFldSet.Contains(condm_model_diagram_relation.target_port_slot, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.target_port_slot = objdm_model_diagram_relationEN.target_port_slot; //终点端口槽位
}
if (arrFldSet.Contains(condm_model_diagram_relation.route_algo, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.route_algo = objdm_model_diagram_relationEN.route_algo == "[null]" ? null :  objdm_model_diagram_relationEN.route_algo; //路线算法版本
}
if (arrFldSet.Contains(condm_model_diagram_relation.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.Status = objdm_model_diagram_relationEN.Status; //Status
}
if (arrFldSet.Contains(condm_model_diagram_relation.created_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.created_by = objdm_model_diagram_relationEN.created_by; //创建人
}
if (arrFldSet.Contains(condm_model_diagram_relation.created_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.created_time = objdm_model_diagram_relationEN.created_time; //创建时间
}
if (arrFldSet.Contains(condm_model_diagram_relation.updated_by, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.updated_by = objdm_model_diagram_relationEN.updated_by; //更新人
}
if (arrFldSet.Contains(condm_model_diagram_relation.updated_time, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.updated_time = objdm_model_diagram_relationEN.updated_time; //更新时间
}
if (arrFldSet.Contains(condm_model_diagram_relation.remark, new clsStrCompareIgnoreCase())  ==  true)
{
objdm_model_diagram_relationEN.remark = objdm_model_diagram_relationEN.remark == "[null]" ? null :  objdm_model_diagram_relationEN.remark; //备注
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
 /// <param name = "objdm_model_diagram_relationEN">源简化对象</param>
 public static void AccessFldValueNull(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
try
{
if (objdm_model_diagram_relationEN.route_points_json == "[null]") objdm_model_diagram_relationEN.route_points_json = null; //连线路径点JSON
if (objdm_model_diagram_relationEN.source_port_side == "[null]") objdm_model_diagram_relationEN.source_port_side = null; //起点端口边
if (objdm_model_diagram_relationEN.target_port_side == "[null]") objdm_model_diagram_relationEN.target_port_side = null; //终点端口边
if (objdm_model_diagram_relationEN.route_algo == "[null]") objdm_model_diagram_relationEN.route_algo = null; //路线算法版本
if (objdm_model_diagram_relationEN.remark == "[null]") objdm_model_diagram_relationEN.remark = null; //备注
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
public static void CheckPropertyNew(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 dm_model_diagram_relationDA.CheckPropertyNew(objdm_model_diagram_relationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
 dm_model_diagram_relationDA.CheckProperty4Condition(objdm_model_diagram_relationEN);
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
if (clsdm_model_diagram_relationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsdm_model_diagram_relationBL没有刷新缓存机制(clsdm_model_diagram_relationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by diagram_relation_id");
//if (arrdm_model_diagram_relationObjLstCache == null)
//{
//arrdm_model_diagram_relationObjLstCache = dm_model_diagram_relationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strdiagram_relation_id">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsdm_model_diagram_relationEN GetObjBydiagram_relation_idCache(string strdiagram_relation_id)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsdm_model_diagram_relationEN._CurrTabName);
List<clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLst_Sel =
arrdm_model_diagram_relationObjLstCache
.Where(x=> x.diagram_relation_id == strdiagram_relation_id 
);
if (arrdm_model_diagram_relationObjLst_Sel.Count() == 0)
{
   clsdm_model_diagram_relationEN obj = clsdm_model_diagram_relationBL.GetObjBydiagram_relation_id(strdiagram_relation_id);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrdm_model_diagram_relationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetAlldm_model_diagram_relationObjLstCache()
{
//获取缓存中的对象列表
List<clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLstCache = GetObjLstCache(); 
return arrdm_model_diagram_relationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsdm_model_diagram_relationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsdm_model_diagram_relationEN._CurrTabName);
List<clsdm_model_diagram_relationEN> arrdm_model_diagram_relationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrdm_model_diagram_relationObjLstCache;
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
string strKey = string.Format("{0}", clsdm_model_diagram_relationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagram_relationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsdm_model_diagram_relationEN._RefreshTimeLst.Count == 0) return "";
return clsdm_model_diagram_relationEN._RefreshTimeLst[clsdm_model_diagram_relationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsdm_model_diagram_relationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsdm_model_diagram_relationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsdm_model_diagram_relationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsdm_model_diagram_relationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--dm_model_diagram_relation(数据模型图关系映射)
 /// 唯一性条件:diagram_id_prj_id_relation_id
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsdm_model_diagram_relationEN objdm_model_diagram_relationEN)
{
//检测记录是否存在
string strResult = dm_model_diagram_relationDA.GetUniCondStr(objdm_model_diagram_relationEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-08-05
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strdiagram_relation_id)
{
if (strInFldName != condm_model_diagram_relation.diagram_relation_id)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (condm_model_diagram_relation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", condm_model_diagram_relation._AttributeName));
throw new Exception(strMsg);
}
var objdm_model_diagram_relation = clsdm_model_diagram_relationBL.GetObjBydiagram_relation_idCache(strdiagram_relation_id);
if (objdm_model_diagram_relation == null) return "";
return objdm_model_diagram_relation[strOutFldName].ToString();
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
int intRecCount = clsdm_model_diagram_relationDA.GetRecCount(strTabName);
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
int intRecCount = clsdm_model_diagram_relationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsdm_model_diagram_relationDA.GetRecCount();
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
int intRecCount = clsdm_model_diagram_relationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objdm_model_diagram_relationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsdm_model_diagram_relationEN objdm_model_diagram_relationCond)
{
List<clsdm_model_diagram_relationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsdm_model_diagram_relationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in condm_model_diagram_relation._AttributeName)
{
if (objdm_model_diagram_relationCond.IsUpdated(strFldName) == false) continue;
if (objdm_model_diagram_relationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_relationCond[strFldName].ToString());
}
else
{
if (objdm_model_diagram_relationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objdm_model_diagram_relationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objdm_model_diagram_relationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objdm_model_diagram_relationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objdm_model_diagram_relationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_relationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objdm_model_diagram_relationCond[strFldName]));
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
 List<string> arrList = clsdm_model_diagram_relationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagram_relationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = dm_model_diagram_relationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = dm_model_diagram_relationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_relationDA.SetFldValue(clsdm_model_diagram_relationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = dm_model_diagram_relationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_relationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_relationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsdm_model_diagram_relationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[dm_model_diagram_relation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**图关系映射ID*/ 
 strCreateTabCode.Append(" diagram_relation_id varchar(32) primary key, "); 
 // /**项目ID*/ 
 strCreateTabCode.Append(" prj_id varchar(32) not Null, "); 
 // /**图ID*/ 
 strCreateTabCode.Append(" diagram_id varchar(32) not Null, "); 
 // /**关系ID*/ 
 strCreateTabCode.Append(" relation_id varchar(32) not Null, "); 
 // /**关系视图类型*/ 
 strCreateTabCode.Append(" relation_view_type varchar(30) not Null, "); 
 // /**线条样式*/ 
 strCreateTabCode.Append(" line_style varchar(20) not Null, "); 
 // /**箭头模式*/ 
 strCreateTabCode.Append(" arrow_mode varchar(20) not Null, "); 
 // /**排序号*/ 
 strCreateTabCode.Append(" sort_no int not Null, "); 
 // /**是否可见*/ 
 strCreateTabCode.Append(" is_visible bit not Null, "); 
 // /**连线路径点JSON*/ 
 strCreateTabCode.Append(" route_points_json varchar(4000) Null, "); 
 // /**起点端口边*/ 
 strCreateTabCode.Append(" source_port_side varchar(10) Null, "); 
 // /**终点端口边*/ 
 strCreateTabCode.Append(" target_port_side varchar(10) Null, "); 
 // /**起点端口槽位*/ 
 strCreateTabCode.Append(" source_port_slot int Null, "); 
 // /**终点端口槽位*/ 
 strCreateTabCode.Append(" target_port_slot int Null, "); 
 // /**路线算法版本*/ 
 strCreateTabCode.Append(" route_algo varchar(30) Null, "); 
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
 /// 数据模型图关系映射(dm_model_diagram_relation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4dm_model_diagram_relation : clsCommFun4BL
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
clsdm_model_diagram_relationBL.ReFreshThisCache();
}
}

}