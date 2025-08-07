
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewFeatureFldsBL
 表名:ViewFeatureFlds(00050453)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsViewFeatureFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewFeatureFldsEN GetObj(this K_mId_ViewFeatureFlds myKey)
{
clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.ViewFeatureFldsDA.GetObjBymId(myKey.Value);
return objViewFeatureFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewFeatureFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecord)", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.AddNewRecordBySQL2(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objViewFeatureFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewFeatureFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面功能Id(ViewFeatureId)=[{0}],字段类型Id(FieldTypeId)=[{1}])已经存在,不能重复!", objViewFeatureFldsEN.ViewFeatureId, objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewFeatureFldsEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewFeatureFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecord(SqlTransaction))", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.AddNewRecordBySQL2(objViewFeatureFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewFeatureFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecordWithReturnKey)", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewFeatureFldsBL.ViewFeatureFldsDA.AddNewRecordBySQL2WithReturnKey(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewFeatureFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecordWithReturnKey)", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewFeatureFldsBL.ViewFeatureFldsDA.AddNewRecordBySQL2WithReturnKey(objViewFeatureFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetmId(this clsViewFeatureFldsEN objViewFeatureFldsEN, long lngmId, string strComparisonOp="")
	{
objViewFeatureFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.mId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.mId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.mId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetViewFeatureId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewFeatureId, conViewFeatureFlds.ViewFeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, conViewFeatureFlds.ViewFeatureId);
}
objViewFeatureFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ViewFeatureId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ViewFeatureId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ViewFeatureId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFieldTypeId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, conViewFeatureFlds.FieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conViewFeatureFlds.FieldTypeId);
}
objViewFeatureFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FieldTypeId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FieldTypeId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FieldTypeId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetReleFldId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strReleFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleFldId, 8, conViewFeatureFlds.ReleFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, conViewFeatureFlds.ReleFldId);
}
objViewFeatureFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ReleFldId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ReleFldId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ReleFldId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFuncName(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, conViewFeatureFlds.FuncName);
}
objViewFeatureFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FuncName) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FuncName, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FuncName] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetLabelCaption(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conViewFeatureFlds.LabelCaption);
}
objViewFeatureFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.LabelCaption) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.LabelCaption, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.LabelCaption] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCtlTypeId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conViewFeatureFlds.CtlTypeId);
}
objViewFeatureFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CtlTypeId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CtlTypeId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CtlTypeId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conViewFeatureFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conViewFeatureFlds.VarId);
}
objViewFeatureFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCtrlId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCtrlId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtrlId, 50, conViewFeatureFlds.CtrlId);
}
objViewFeatureFldsEN.CtrlId = strCtrlId; //控件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CtrlId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CtrlId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CtrlId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDefaultValue(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conViewFeatureFlds.DefaultValue);
}
objViewFeatureFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DefaultValue) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DefaultValue, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DefaultValue] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetOrderNum(this clsViewFeatureFldsEN objViewFeatureFldsEN, int? intOrderNum, string strComparisonOp="")
	{
objViewFeatureFldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.OrderNum) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.OrderNum, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.OrderNum] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetCssClass(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strCssClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCssClass, 50, conViewFeatureFlds.CssClass);
}
objViewFeatureFldsEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.CssClass) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.CssClass, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.CssClass] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDdlItemsOptionId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conViewFeatureFlds.DdlItemsOptionId);
}
objViewFeatureFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DdlItemsOptionId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsTabId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conViewFeatureFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conViewFeatureFlds.DsTabId);
}
objViewFeatureFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsTabId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsTabId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsTabId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFldIdCond2(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conViewFeatureFlds.FldIdCond2);
}
objViewFeatureFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FldIdCond2) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FldIdCond2, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FldIdCond2] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetFldIdCond1(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conViewFeatureFlds.FldIdCond1);
}
objViewFeatureFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.FldIdCond1) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.FldIdCond1, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.FldIdCond1] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarIdCond2(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conViewFeatureFlds.VarIdCond2);
}
objViewFeatureFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarIdCond2) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarIdCond2, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarIdCond2] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetVarIdCond1(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conViewFeatureFlds.VarIdCond1);
}
objViewFeatureFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.VarIdCond1) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.VarIdCond1, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.VarIdCond1] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetTabFeatureId4Ddl(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conViewFeatureFlds.TabFeatureId4Ddl);
}
objViewFeatureFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.TabFeatureId4Ddl) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetViewImplId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strViewImplId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, conViewFeatureFlds.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, conViewFeatureFlds.ViewImplId);
}
objViewFeatureFldsEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ViewImplId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ViewImplId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ViewImplId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetText(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, conViewFeatureFlds.Text);
}
objViewFeatureFldsEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.Text) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.Text, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.Text] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsCondStr(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conViewFeatureFlds.DsCondStr);
}
objViewFeatureFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsCondStr) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsCondStr, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsCondStr] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetDsSqlStr(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conViewFeatureFlds.DsSqlStr);
}
objViewFeatureFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.DsSqlStr) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.DsSqlStr, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.DsSqlStr] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetItemsString(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, conViewFeatureFlds.ItemsString);
}
objViewFeatureFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.ItemsString) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.ItemsString, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.ItemsString] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetPrjId(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewFeatureFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewFeatureFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewFeatureFlds.PrjId);
}
objViewFeatureFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.PrjId) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.PrjId, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.PrjId] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetUpdUser(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conViewFeatureFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewFeatureFlds.UpdUser);
}
objViewFeatureFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.UpdUser) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.UpdUser, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.UpdUser] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetUpdDate(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewFeatureFlds.UpdDate);
}
objViewFeatureFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.UpdDate) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.UpdDate, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.UpdDate] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetInUse(this clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolInUse, string strComparisonOp="")
	{
objViewFeatureFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.InUse) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.InUse, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.InUse] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewFeatureFldsEN SetMemo(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewFeatureFlds.Memo);
}
objViewFeatureFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewFeatureFldsEN.dicFldComparisonOp.ContainsKey(conViewFeatureFlds.Memo) == false)
{
objViewFeatureFldsEN.dicFldComparisonOp.Add(conViewFeatureFlds.Memo, strComparisonOp);
}
else
{
objViewFeatureFldsEN.dicFldComparisonOp[conViewFeatureFlds.Memo] = strComparisonOp;
}
}
return objViewFeatureFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewFeatureFldsEN.CheckPropertyNew();
clsViewFeatureFldsEN objViewFeatureFldsCond = new clsViewFeatureFldsEN();
string strCondition = objViewFeatureFldsCond
.SetmId(objViewFeatureFldsEN.mId, "<>")
.SetViewFeatureId(objViewFeatureFldsEN.ViewFeatureId, "=")
.SetFieldTypeId(objViewFeatureFldsEN.FieldTypeId, "=")
.GetCombineCondition();
objViewFeatureFldsEN._IsCheckProperty = true;
bool bolIsExist = clsViewFeatureFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewFeatureId_FieldTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewFeatureFldsEN.Update();
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
 /// <param name = "objViewFeatureFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewFeatureFldsEN objViewFeatureFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewFeatureFldsEN objViewFeatureFldsCond = new clsViewFeatureFldsEN();
string strCondition = objViewFeatureFldsCond
.SetViewFeatureId(objViewFeatureFlds.ViewFeatureId, "=")
.SetFieldTypeId(objViewFeatureFlds.FieldTypeId, "=")
.GetCombineCondition();
objViewFeatureFlds._IsCheckProperty = true;
bool bolIsExist = clsViewFeatureFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewFeatureFlds.mId = clsViewFeatureFldsBL.GetFirstID_S(strCondition);
objViewFeatureFlds.UpdateWithCondition(strCondition);
}
else
{
objViewFeatureFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 if (objViewFeatureFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.UpdateBySql2(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewFeatureFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.UpdateBySql2(objViewFeatureFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewFeatureFldsEN objViewFeatureFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewFeatureFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.UpdateBySql2(objViewFeatureFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.UpdateBySqlWithCondition(objViewFeatureFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewFeatureFldsEN objViewFeatureFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewFeatureFldsBL.ViewFeatureFldsDA.UpdateBySqlWithConditionTransaction(objViewFeatureFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
public static int Delete(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
try
{
int intRecNum = clsViewFeatureFldsBL.ViewFeatureFldsDA.DelRecord(objViewFeatureFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsENS">源对象</param>
 /// <param name = "objViewFeatureFldsENT">目标对象</param>
 public static void CopyTo(this clsViewFeatureFldsEN objViewFeatureFldsENS, clsViewFeatureFldsEN objViewFeatureFldsENT)
{
try
{
objViewFeatureFldsENT.mId = objViewFeatureFldsENS.mId; //mId
objViewFeatureFldsENT.ViewFeatureId = objViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objViewFeatureFldsENT.FieldTypeId = objViewFeatureFldsENS.FieldTypeId; //字段类型Id
objViewFeatureFldsENT.ReleFldId = objViewFeatureFldsENS.ReleFldId; //相关字段Id
objViewFeatureFldsENT.FuncName = objViewFeatureFldsENS.FuncName; //函数名
objViewFeatureFldsENT.LabelCaption = objViewFeatureFldsENS.LabelCaption; //标签标题
objViewFeatureFldsENT.CtlTypeId = objViewFeatureFldsENS.CtlTypeId; //控件类型号
objViewFeatureFldsENT.VarId = objViewFeatureFldsENS.VarId; //变量Id
objViewFeatureFldsENT.CtrlId = objViewFeatureFldsENS.CtrlId; //控件Id
objViewFeatureFldsENT.DefaultValue = objViewFeatureFldsENS.DefaultValue; //缺省值
objViewFeatureFldsENT.OrderNum = objViewFeatureFldsENS.OrderNum; //序号
objViewFeatureFldsENT.CssClass = objViewFeatureFldsENS.CssClass; //样式表
objViewFeatureFldsENT.DdlItemsOptionId = objViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewFeatureFldsENT.DsTabId = objViewFeatureFldsENS.DsTabId; //数据源表ID
objViewFeatureFldsENT.FldIdCond2 = objViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objViewFeatureFldsENT.FldIdCond1 = objViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objViewFeatureFldsENT.VarIdCond2 = objViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objViewFeatureFldsENT.VarIdCond1 = objViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objViewFeatureFldsENT.TabFeatureId4Ddl = objViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objViewFeatureFldsENT.ViewImplId = objViewFeatureFldsENS.ViewImplId; //界面实现Id
objViewFeatureFldsENT.Text = objViewFeatureFldsENS.Text; //文本
objViewFeatureFldsENT.DsCondStr = objViewFeatureFldsENS.DsCondStr; //数据源条件串
objViewFeatureFldsENT.DsSqlStr = objViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objViewFeatureFldsENT.ItemsString = objViewFeatureFldsENS.ItemsString; //列表项串
objViewFeatureFldsENT.PrjId = objViewFeatureFldsENS.PrjId; //工程Id
objViewFeatureFldsENT.UpdUser = objViewFeatureFldsENS.UpdUser; //修改者
objViewFeatureFldsENT.UpdDate = objViewFeatureFldsENS.UpdDate; //修改日期
objViewFeatureFldsENT.InUse = objViewFeatureFldsENS.InUse; //是否在用
objViewFeatureFldsENT.Memo = objViewFeatureFldsENS.Memo; //说明
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
 /// <param name = "objViewFeatureFldsENS">源对象</param>
 /// <returns>目标对象=>clsViewFeatureFldsEN:objViewFeatureFldsENT</returns>
 public static clsViewFeatureFldsEN CopyTo(this clsViewFeatureFldsEN objViewFeatureFldsENS)
{
try
{
 clsViewFeatureFldsEN objViewFeatureFldsENT = new clsViewFeatureFldsEN()
{
mId = objViewFeatureFldsENS.mId, //mId
ViewFeatureId = objViewFeatureFldsENS.ViewFeatureId, //界面功能Id
FieldTypeId = objViewFeatureFldsENS.FieldTypeId, //字段类型Id
ReleFldId = objViewFeatureFldsENS.ReleFldId, //相关字段Id
FuncName = objViewFeatureFldsENS.FuncName, //函数名
LabelCaption = objViewFeatureFldsENS.LabelCaption, //标签标题
CtlTypeId = objViewFeatureFldsENS.CtlTypeId, //控件类型号
VarId = objViewFeatureFldsENS.VarId, //变量Id
CtrlId = objViewFeatureFldsENS.CtrlId, //控件Id
DefaultValue = objViewFeatureFldsENS.DefaultValue, //缺省值
OrderNum = objViewFeatureFldsENS.OrderNum, //序号
CssClass = objViewFeatureFldsENS.CssClass, //样式表
DdlItemsOptionId = objViewFeatureFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DsTabId = objViewFeatureFldsENS.DsTabId, //数据源表ID
FldIdCond2 = objViewFeatureFldsENS.FldIdCond2, //字段Id_条件2
FldIdCond1 = objViewFeatureFldsENS.FldIdCond1, //字段Id_条件1
VarIdCond2 = objViewFeatureFldsENS.VarIdCond2, //数据源字段_条件1
VarIdCond1 = objViewFeatureFldsENS.VarIdCond1, //变量Id_条件1
TabFeatureId4Ddl = objViewFeatureFldsENS.TabFeatureId4Ddl, //下拉框表功能Id
ViewImplId = objViewFeatureFldsENS.ViewImplId, //界面实现Id
Text = objViewFeatureFldsENS.Text, //文本
DsCondStr = objViewFeatureFldsENS.DsCondStr, //数据源条件串
DsSqlStr = objViewFeatureFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objViewFeatureFldsENS.ItemsString, //列表项串
PrjId = objViewFeatureFldsENS.PrjId, //工程Id
UpdUser = objViewFeatureFldsENS.UpdUser, //修改者
UpdDate = objViewFeatureFldsENS.UpdDate, //修改日期
InUse = objViewFeatureFldsENS.InUse, //是否在用
Memo = objViewFeatureFldsENS.Memo, //说明
};
 return objViewFeatureFldsENT;
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
public static void CheckPropertyNew(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 clsViewFeatureFldsBL.ViewFeatureFldsDA.CheckPropertyNew(objViewFeatureFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 clsViewFeatureFldsBL.ViewFeatureFldsDA.CheckProperty4Condition(objViewFeatureFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewFeatureFldsEN objViewFeatureFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.mId) == true)
{
string strComparisonOpmId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewFeatureFlds.mId, objViewFeatureFldsCond.mId, strComparisonOpmId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ViewFeatureId, objViewFeatureFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FieldTypeId, objViewFeatureFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ReleFldId, objViewFeatureFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FuncName) == true)
{
string strComparisonOpFuncName = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FuncName, objViewFeatureFldsCond.FuncName, strComparisonOpFuncName);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.LabelCaption, objViewFeatureFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CtlTypeId, objViewFeatureFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarId) == true)
{
string strComparisonOpVarId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarId, objViewFeatureFldsCond.VarId, strComparisonOpVarId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CtrlId) == true)
{
string strComparisonOpCtrlId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CtrlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CtrlId, objViewFeatureFldsCond.CtrlId, strComparisonOpCtrlId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DefaultValue, objViewFeatureFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewFeatureFlds.OrderNum, objViewFeatureFldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.CssClass) == true)
{
string strComparisonOpCssClass = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.CssClass, objViewFeatureFldsCond.CssClass, strComparisonOpCssClass);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DdlItemsOptionId, objViewFeatureFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsTabId, objViewFeatureFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FldIdCond2, objViewFeatureFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.FldIdCond1, objViewFeatureFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarIdCond2, objViewFeatureFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.VarIdCond1, objViewFeatureFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.TabFeatureId4Ddl, objViewFeatureFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ViewImplId) == true)
{
string strComparisonOpViewImplId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ViewImplId, objViewFeatureFldsCond.ViewImplId, strComparisonOpViewImplId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.Text) == true)
{
string strComparisonOpText = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.Text, objViewFeatureFldsCond.Text, strComparisonOpText);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsCondStr, objViewFeatureFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.DsSqlStr, objViewFeatureFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.ItemsString, objViewFeatureFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.PrjId) == true)
{
string strComparisonOpPrjId = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.PrjId, objViewFeatureFldsCond.PrjId, strComparisonOpPrjId);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.UpdUser, objViewFeatureFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.UpdDate, objViewFeatureFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.InUse) == true)
{
if (objViewFeatureFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewFeatureFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewFeatureFlds.InUse);
}
}
if (objViewFeatureFldsCond.IsUpdated(conViewFeatureFlds.Memo) == true)
{
string strComparisonOpMemo = objViewFeatureFldsCond.dicFldComparisonOp[conViewFeatureFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewFeatureFlds.Memo, objViewFeatureFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewFeatureFlds(界面功能字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewFeatureId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewFeatureFldsEN == null) return true;
if (objViewFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
if (clsViewFeatureFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
if (clsViewFeatureFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewFeatureFlds(界面功能字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewFeatureId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewFeatureFldsEN == null) return "";
if (objViewFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and ViewFeatureId = '{0}'", objViewFeatureFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objViewFeatureFldsEN.FieldTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewFeatureFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面功能字段(ViewFeatureFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewFeatureFldsBL
{
public static RelatedActions_ViewFeatureFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewFeatureFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewFeatureFldsDA ViewFeatureFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewFeatureFldsDA();
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
 public clsViewFeatureFldsBL()
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
if (string.IsNullOrEmpty(clsViewFeatureFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewFeatureFldsEN._ConnectString);
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
public static DataTable GetDataTable_ViewFeatureFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewFeatureFldsDA.GetDataTable_ViewFeatureFlds(strWhereCond);
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
objDT = ViewFeatureFldsDA.GetDataTable(strWhereCond);
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
objDT = ViewFeatureFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewFeatureFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewFeatureFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewFeatureFldsDA.GetDataTable_Top(objTopPara);
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
objDT = ViewFeatureFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewFeatureFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsViewFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
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
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewFeatureFldsEN> arrViewFeatureFldsObjLst_Sel =
arrViewFeatureFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrViewFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLst(string strWhereCond)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
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
public static List<clsViewFeatureFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewFeatureFldsEN> GetSubObjLstCache(clsViewFeatureFldsEN objViewFeatureFldsCond)
{
 string strPrjId = objViewFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewFeatureFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewFeatureFlds._AttributeName)
{
if (objViewFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objViewFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewFeatureFldsCond[strFldName].ToString());
}
else
{
if (objViewFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewFeatureFldsCond[strFldName]));
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
public static List<clsViewFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
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
public static List<clsViewFeatureFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
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
List<clsViewFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewFeatureFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
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
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
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
public static List<clsViewFeatureFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
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
public static List<clsViewFeatureFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewFeatureFldsEN> arrObjLst = new List<clsViewFeatureFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewFeatureFldsEN objViewFeatureFldsEN = new clsViewFeatureFldsEN();
try
{
objViewFeatureFldsEN.mId = Int32.Parse(objRow[conViewFeatureFlds.mId].ToString().Trim()); //mId
objViewFeatureFldsEN.ViewFeatureId = objRow[conViewFeatureFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objViewFeatureFldsEN.FieldTypeId = objRow[conViewFeatureFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objViewFeatureFldsEN.ReleFldId = objRow[conViewFeatureFlds.ReleFldId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ReleFldId].ToString().Trim(); //相关字段Id
objViewFeatureFldsEN.FuncName = objRow[conViewFeatureFlds.FuncName] == DBNull.Value ? null : objRow[conViewFeatureFlds.FuncName].ToString().Trim(); //函数名
objViewFeatureFldsEN.LabelCaption = objRow[conViewFeatureFlds.LabelCaption] == DBNull.Value ? null : objRow[conViewFeatureFlds.LabelCaption].ToString().Trim(); //标签标题
objViewFeatureFldsEN.CtlTypeId = objRow[conViewFeatureFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewFeatureFldsEN.VarId = objRow[conViewFeatureFlds.VarId] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarId].ToString().Trim(); //变量Id
objViewFeatureFldsEN.CtrlId = objRow[conViewFeatureFlds.CtrlId] == DBNull.Value ? null : objRow[conViewFeatureFlds.CtrlId].ToString().Trim(); //控件Id
objViewFeatureFldsEN.DefaultValue = objRow[conViewFeatureFlds.DefaultValue] == DBNull.Value ? null : objRow[conViewFeatureFlds.DefaultValue].ToString().Trim(); //缺省值
objViewFeatureFldsEN.OrderNum = objRow[conViewFeatureFlds.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewFeatureFlds.OrderNum].ToString().Trim()); //序号
objViewFeatureFldsEN.CssClass = objRow[conViewFeatureFlds.CssClass] == DBNull.Value ? null : objRow[conViewFeatureFlds.CssClass].ToString().Trim(); //样式表
objViewFeatureFldsEN.DdlItemsOptionId = objRow[conViewFeatureFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewFeatureFldsEN.DsTabId = objRow[conViewFeatureFlds.DsTabId] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewFeatureFldsEN.FldIdCond2 = objRow[conViewFeatureFlds.FldIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objViewFeatureFldsEN.FldIdCond1 = objRow[conViewFeatureFlds.FldIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objViewFeatureFldsEN.VarIdCond2 = objRow[conViewFeatureFlds.VarIdCond2] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objViewFeatureFldsEN.VarIdCond1 = objRow[conViewFeatureFlds.VarIdCond1] == DBNull.Value ? null : objRow[conViewFeatureFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objViewFeatureFldsEN.TabFeatureId4Ddl = objRow[conViewFeatureFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conViewFeatureFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objViewFeatureFldsEN.ViewImplId = objRow[conViewFeatureFlds.ViewImplId] == DBNull.Value ? null : objRow[conViewFeatureFlds.ViewImplId].ToString().Trim(); //界面实现Id
objViewFeatureFldsEN.Text = objRow[conViewFeatureFlds.Text] == DBNull.Value ? null : objRow[conViewFeatureFlds.Text].ToString().Trim(); //文本
objViewFeatureFldsEN.DsCondStr = objRow[conViewFeatureFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewFeatureFldsEN.DsSqlStr = objRow[conViewFeatureFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewFeatureFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewFeatureFldsEN.ItemsString = objRow[conViewFeatureFlds.ItemsString] == DBNull.Value ? null : objRow[conViewFeatureFlds.ItemsString].ToString().Trim(); //列表项串
objViewFeatureFldsEN.PrjId = objRow[conViewFeatureFlds.PrjId].ToString().Trim(); //工程Id
objViewFeatureFldsEN.UpdUser = objRow[conViewFeatureFlds.UpdUser].ToString().Trim(); //修改者
objViewFeatureFldsEN.UpdDate = objRow[conViewFeatureFlds.UpdDate] == DBNull.Value ? null : objRow[conViewFeatureFlds.UpdDate].ToString().Trim(); //修改日期
objViewFeatureFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewFeatureFlds.InUse].ToString().Trim()); //是否在用
objViewFeatureFldsEN.Memo = objRow[conViewFeatureFlds.Memo] == DBNull.Value ? null : objRow[conViewFeatureFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewFeatureFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewFeatureFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewFeatureFlds(ref clsViewFeatureFldsEN objViewFeatureFldsEN)
{
bool bolResult = ViewFeatureFldsDA.GetViewFeatureFlds(ref objViewFeatureFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewFeatureFldsEN GetObjBymId(long lngmId)
{
clsViewFeatureFldsEN objViewFeatureFldsEN = ViewFeatureFldsDA.GetObjBymId(lngmId);
return objViewFeatureFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewFeatureFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewFeatureFldsEN objViewFeatureFldsEN = ViewFeatureFldsDA.GetFirstObj(strWhereCond);
 return objViewFeatureFldsEN;
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
public static clsViewFeatureFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewFeatureFldsEN objViewFeatureFldsEN = ViewFeatureFldsDA.GetObjByDataRow(objRow);
 return objViewFeatureFldsEN;
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
public static clsViewFeatureFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewFeatureFldsEN objViewFeatureFldsEN = ViewFeatureFldsDA.GetObjByDataRow(objRow);
 return objViewFeatureFldsEN;
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
 /// <param name = "lstViewFeatureFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewFeatureFldsEN GetObjBymIdFromList(long lngmId, List<clsViewFeatureFldsEN> lstViewFeatureFldsObjLst)
{
foreach (clsViewFeatureFldsEN objViewFeatureFldsEN in lstViewFeatureFldsObjLst)
{
if (objViewFeatureFldsEN.mId == lngmId)
{
return objViewFeatureFldsEN;
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
 lngmId = new clsViewFeatureFldsDA().GetFirstID(strWhereCond);
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
 arrList = ViewFeatureFldsDA.GetID(strWhereCond);
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
bool bolIsExist = ViewFeatureFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ViewFeatureFldsDA.IsExist(lngmId);
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
clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(lngmId);
objViewFeatureFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewFeatureFldsEN.UpdUser = strOpUser;
return clsViewFeatureFldsBL.UpdateBySql2(objViewFeatureFldsEN);
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
 bolIsExist = clsViewFeatureFldsDA.IsExistTable();
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
 bolIsExist = ViewFeatureFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewFeatureFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecordBySql2)", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewFeatureFldsDA.AddNewRecordBySQL2(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewFeatureFldsEN objViewFeatureFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewFeatureFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面功能Id = [{0}],字段类型Id = [{1}]的数据已经存在!(in clsViewFeatureFldsBL.AddNewRecordBySql2WithReturnKey)", objViewFeatureFldsEN.ViewFeatureId,objViewFeatureFldsEN.FieldTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewFeatureFldsDA.AddNewRecordBySQL2WithReturnKey(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
try
{
bool bolResult = ViewFeatureFldsDA.Update(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 /// <param name = "objViewFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 if (objViewFeatureFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewFeatureFldsDA.UpdateBySql2(objViewFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewFeatureFldsBL.ReFreshCache(objViewFeatureFldsEN.PrjId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
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
 clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(lngmId);

if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(objViewFeatureFldsEN.mId, objViewFeatureFldsEN.UpdUser);
}
if (objViewFeatureFldsEN != null)
{
int intRecNum = ViewFeatureFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewFeatureFldsEN.PrjId);
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
objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
//删除与表:[ViewFeatureFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewFeatureFlds.mId,
//lngmId);
//        clsViewFeatureFldsBL.DelViewFeatureFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewFeatureFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewFeatureFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsViewFeatureFldsBL.relatedActions != null)
{
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewFeatureFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelViewFeatureFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsViewFeatureFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsViewFeatureFldsEN objViewFeatureFldsEN = clsViewFeatureFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ViewFeatureFldsDA.DelViewFeatureFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewFeatureFldsEN.PrjId);
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
public static int DelViewFeatureFldssByCond(string strWhereCond)
{
try
{
if (clsViewFeatureFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewFeatureFlds.PrjId, strWhereCond);
int intRecNum = ViewFeatureFldsDA.DelViewFeatureFlds(strWhereCond);
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
public static bool DelViewFeatureFldssByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewFeatureFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewFeatureFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = ViewFeatureFldsDA.DelViewFeatureFldsWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewFeatureFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewFeatureFldsDA.GetSpecSQLObj();
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
//删除与表:[ViewFeatureFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewFeatureFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewFeatureFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objViewFeatureFldsENS">源对象</param>
 /// <param name = "objViewFeatureFldsENT">目标对象</param>
 public static void CopyTo(clsViewFeatureFldsEN objViewFeatureFldsENS, clsViewFeatureFldsEN objViewFeatureFldsENT)
{
try
{
objViewFeatureFldsENT.mId = objViewFeatureFldsENS.mId; //mId
objViewFeatureFldsENT.ViewFeatureId = objViewFeatureFldsENS.ViewFeatureId; //界面功能Id
objViewFeatureFldsENT.FieldTypeId = objViewFeatureFldsENS.FieldTypeId; //字段类型Id
objViewFeatureFldsENT.ReleFldId = objViewFeatureFldsENS.ReleFldId; //相关字段Id
objViewFeatureFldsENT.FuncName = objViewFeatureFldsENS.FuncName; //函数名
objViewFeatureFldsENT.LabelCaption = objViewFeatureFldsENS.LabelCaption; //标签标题
objViewFeatureFldsENT.CtlTypeId = objViewFeatureFldsENS.CtlTypeId; //控件类型号
objViewFeatureFldsENT.VarId = objViewFeatureFldsENS.VarId; //变量Id
objViewFeatureFldsENT.CtrlId = objViewFeatureFldsENS.CtrlId; //控件Id
objViewFeatureFldsENT.DefaultValue = objViewFeatureFldsENS.DefaultValue; //缺省值
objViewFeatureFldsENT.OrderNum = objViewFeatureFldsENS.OrderNum; //序号
objViewFeatureFldsENT.CssClass = objViewFeatureFldsENS.CssClass; //样式表
objViewFeatureFldsENT.DdlItemsOptionId = objViewFeatureFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewFeatureFldsENT.DsTabId = objViewFeatureFldsENS.DsTabId; //数据源表ID
objViewFeatureFldsENT.FldIdCond2 = objViewFeatureFldsENS.FldIdCond2; //字段Id_条件2
objViewFeatureFldsENT.FldIdCond1 = objViewFeatureFldsENS.FldIdCond1; //字段Id_条件1
objViewFeatureFldsENT.VarIdCond2 = objViewFeatureFldsENS.VarIdCond2; //数据源字段_条件1
objViewFeatureFldsENT.VarIdCond1 = objViewFeatureFldsENS.VarIdCond1; //变量Id_条件1
objViewFeatureFldsENT.TabFeatureId4Ddl = objViewFeatureFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objViewFeatureFldsENT.ViewImplId = objViewFeatureFldsENS.ViewImplId; //界面实现Id
objViewFeatureFldsENT.Text = objViewFeatureFldsENS.Text; //文本
objViewFeatureFldsENT.DsCondStr = objViewFeatureFldsENS.DsCondStr; //数据源条件串
objViewFeatureFldsENT.DsSqlStr = objViewFeatureFldsENS.DsSqlStr; //数据源SQL串
objViewFeatureFldsENT.ItemsString = objViewFeatureFldsENS.ItemsString; //列表项串
objViewFeatureFldsENT.PrjId = objViewFeatureFldsENS.PrjId; //工程Id
objViewFeatureFldsENT.UpdUser = objViewFeatureFldsENS.UpdUser; //修改者
objViewFeatureFldsENT.UpdDate = objViewFeatureFldsENS.UpdDate; //修改日期
objViewFeatureFldsENT.InUse = objViewFeatureFldsENS.InUse; //是否在用
objViewFeatureFldsENT.Memo = objViewFeatureFldsENS.Memo; //说明
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
 /// <param name = "objViewFeatureFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
try
{
objViewFeatureFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewFeatureFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewFeatureFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.mId = objViewFeatureFldsEN.mId; //mId
}
if (arrFldSet.Contains(conViewFeatureFlds.ViewFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.ViewFeatureId = objViewFeatureFldsEN.ViewFeatureId; //界面功能Id
}
if (arrFldSet.Contains(conViewFeatureFlds.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.FieldTypeId = objViewFeatureFldsEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conViewFeatureFlds.ReleFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.ReleFldId = objViewFeatureFldsEN.ReleFldId == "[null]" ? null :  objViewFeatureFldsEN.ReleFldId; //相关字段Id
}
if (arrFldSet.Contains(conViewFeatureFlds.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.FuncName = objViewFeatureFldsEN.FuncName == "[null]" ? null :  objViewFeatureFldsEN.FuncName; //函数名
}
if (arrFldSet.Contains(conViewFeatureFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.LabelCaption = objViewFeatureFldsEN.LabelCaption == "[null]" ? null :  objViewFeatureFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(conViewFeatureFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.CtlTypeId = objViewFeatureFldsEN.CtlTypeId == "[null]" ? null :  objViewFeatureFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conViewFeatureFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.VarId = objViewFeatureFldsEN.VarId == "[null]" ? null :  objViewFeatureFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(conViewFeatureFlds.CtrlId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.CtrlId = objViewFeatureFldsEN.CtrlId == "[null]" ? null :  objViewFeatureFldsEN.CtrlId; //控件Id
}
if (arrFldSet.Contains(conViewFeatureFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.DefaultValue = objViewFeatureFldsEN.DefaultValue == "[null]" ? null :  objViewFeatureFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conViewFeatureFlds.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.OrderNum = objViewFeatureFldsEN.OrderNum; //序号
}
if (arrFldSet.Contains(conViewFeatureFlds.CssClass, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.CssClass = objViewFeatureFldsEN.CssClass == "[null]" ? null :  objViewFeatureFldsEN.CssClass; //样式表
}
if (arrFldSet.Contains(conViewFeatureFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.DdlItemsOptionId = objViewFeatureFldsEN.DdlItemsOptionId == "[null]" ? null :  objViewFeatureFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(conViewFeatureFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.DsTabId = objViewFeatureFldsEN.DsTabId == "[null]" ? null :  objViewFeatureFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(conViewFeatureFlds.FldIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.FldIdCond2 = objViewFeatureFldsEN.FldIdCond2 == "[null]" ? null :  objViewFeatureFldsEN.FldIdCond2; //字段Id_条件2
}
if (arrFldSet.Contains(conViewFeatureFlds.FldIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.FldIdCond1 = objViewFeatureFldsEN.FldIdCond1 == "[null]" ? null :  objViewFeatureFldsEN.FldIdCond1; //字段Id_条件1
}
if (arrFldSet.Contains(conViewFeatureFlds.VarIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.VarIdCond2 = objViewFeatureFldsEN.VarIdCond2 == "[null]" ? null :  objViewFeatureFldsEN.VarIdCond2; //数据源字段_条件1
}
if (arrFldSet.Contains(conViewFeatureFlds.VarIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.VarIdCond1 = objViewFeatureFldsEN.VarIdCond1 == "[null]" ? null :  objViewFeatureFldsEN.VarIdCond1; //变量Id_条件1
}
if (arrFldSet.Contains(conViewFeatureFlds.TabFeatureId4Ddl, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.TabFeatureId4Ddl = objViewFeatureFldsEN.TabFeatureId4Ddl == "[null]" ? null :  objViewFeatureFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
}
if (arrFldSet.Contains(conViewFeatureFlds.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.ViewImplId = objViewFeatureFldsEN.ViewImplId == "[null]" ? null :  objViewFeatureFldsEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(conViewFeatureFlds.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.Text = objViewFeatureFldsEN.Text == "[null]" ? null :  objViewFeatureFldsEN.Text; //文本
}
if (arrFldSet.Contains(conViewFeatureFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.DsCondStr = objViewFeatureFldsEN.DsCondStr == "[null]" ? null :  objViewFeatureFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(conViewFeatureFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.DsSqlStr = objViewFeatureFldsEN.DsSqlStr == "[null]" ? null :  objViewFeatureFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(conViewFeatureFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.ItemsString = objViewFeatureFldsEN.ItemsString == "[null]" ? null :  objViewFeatureFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(conViewFeatureFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.PrjId = objViewFeatureFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewFeatureFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.UpdUser = objViewFeatureFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewFeatureFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.UpdDate = objViewFeatureFldsEN.UpdDate == "[null]" ? null :  objViewFeatureFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewFeatureFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.InUse = objViewFeatureFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conViewFeatureFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewFeatureFldsEN.Memo = objViewFeatureFldsEN.Memo == "[null]" ? null :  objViewFeatureFldsEN.Memo; //说明
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
 /// <param name = "objViewFeatureFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
try
{
if (objViewFeatureFldsEN.ReleFldId == "[null]") objViewFeatureFldsEN.ReleFldId = null; //相关字段Id
if (objViewFeatureFldsEN.FuncName == "[null]") objViewFeatureFldsEN.FuncName = null; //函数名
if (objViewFeatureFldsEN.LabelCaption == "[null]") objViewFeatureFldsEN.LabelCaption = null; //标签标题
if (objViewFeatureFldsEN.CtlTypeId == "[null]") objViewFeatureFldsEN.CtlTypeId = null; //控件类型号
if (objViewFeatureFldsEN.VarId == "[null]") objViewFeatureFldsEN.VarId = null; //变量Id
if (objViewFeatureFldsEN.CtrlId == "[null]") objViewFeatureFldsEN.CtrlId = null; //控件Id
if (objViewFeatureFldsEN.DefaultValue == "[null]") objViewFeatureFldsEN.DefaultValue = null; //缺省值
if (objViewFeatureFldsEN.CssClass == "[null]") objViewFeatureFldsEN.CssClass = null; //样式表
if (objViewFeatureFldsEN.DdlItemsOptionId == "[null]") objViewFeatureFldsEN.DdlItemsOptionId = null; //下拉框列表选项ID
if (objViewFeatureFldsEN.DsTabId == "[null]") objViewFeatureFldsEN.DsTabId = null; //数据源表ID
if (objViewFeatureFldsEN.FldIdCond2 == "[null]") objViewFeatureFldsEN.FldIdCond2 = null; //字段Id_条件2
if (objViewFeatureFldsEN.FldIdCond1 == "[null]") objViewFeatureFldsEN.FldIdCond1 = null; //字段Id_条件1
if (objViewFeatureFldsEN.VarIdCond2 == "[null]") objViewFeatureFldsEN.VarIdCond2 = null; //数据源字段_条件1
if (objViewFeatureFldsEN.VarIdCond1 == "[null]") objViewFeatureFldsEN.VarIdCond1 = null; //变量Id_条件1
if (objViewFeatureFldsEN.TabFeatureId4Ddl == "[null]") objViewFeatureFldsEN.TabFeatureId4Ddl = null; //下拉框表功能Id
if (objViewFeatureFldsEN.ViewImplId == "[null]") objViewFeatureFldsEN.ViewImplId = null; //界面实现Id
if (objViewFeatureFldsEN.Text == "[null]") objViewFeatureFldsEN.Text = null; //文本
if (objViewFeatureFldsEN.DsCondStr == "[null]") objViewFeatureFldsEN.DsCondStr = null; //数据源条件串
if (objViewFeatureFldsEN.DsSqlStr == "[null]") objViewFeatureFldsEN.DsSqlStr = null; //数据源SQL串
if (objViewFeatureFldsEN.ItemsString == "[null]") objViewFeatureFldsEN.ItemsString = null; //列表项串
if (objViewFeatureFldsEN.UpdDate == "[null]") objViewFeatureFldsEN.UpdDate = null; //修改日期
if (objViewFeatureFldsEN.Memo == "[null]") objViewFeatureFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 ViewFeatureFldsDA.CheckPropertyNew(objViewFeatureFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
 ViewFeatureFldsDA.CheckProperty4Condition(objViewFeatureFldsEN);
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
if (clsViewFeatureFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewFeatureFldsBL没有刷新缓存机制(clsViewFeatureFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrViewFeatureFldsObjLstCache == null)
//{
//arrViewFeatureFldsObjLstCache = ViewFeatureFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewFeatureFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewFeatureFldsEN> arrViewFeatureFldsObjLst_Sel =
arrViewFeatureFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrViewFeatureFldsObjLst_Sel.Count() == 0)
{
   clsViewFeatureFldsEN obj = clsViewFeatureFldsBL.GetObjBymId(lngmId);
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
return arrViewFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewFeatureFldsEN> GetAllViewFeatureFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrViewFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewFeatureFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewFeatureFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewFeatureFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewFeatureFldsEN._RefreshTimeLst.Count == 0) return "";
return clsViewFeatureFldsEN._RefreshTimeLst[clsViewFeatureFldsEN._RefreshTimeLst.Count - 1];
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
if (clsViewFeatureFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewFeatureFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewFeatureFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewFeatureFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewFeatureFlds(界面功能字段)
 /// 唯一性条件:ViewFeatureId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewFeatureFldsEN objViewFeatureFldsEN)
{
//检测记录是否存在
string strResult = ViewFeatureFldsDA.GetUniCondStr(objViewFeatureFldsEN);
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
if (strInFldName != conViewFeatureFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewFeatureFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewFeatureFlds._AttributeName));
throw new Exception(strMsg);
}
var objViewFeatureFlds = clsViewFeatureFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objViewFeatureFlds == null) return "";
return objViewFeatureFlds[strOutFldName].ToString();
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
int intRecCount = clsViewFeatureFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsViewFeatureFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewFeatureFldsDA.GetRecCount();
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
int intRecCount = clsViewFeatureFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewFeatureFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewFeatureFldsEN objViewFeatureFldsCond)
{
 string strPrjId = objViewFeatureFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewFeatureFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewFeatureFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewFeatureFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewFeatureFlds._AttributeName)
{
if (objViewFeatureFldsCond.IsUpdated(strFldName) == false) continue;
if (objViewFeatureFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewFeatureFldsCond[strFldName].ToString());
}
else
{
if (objViewFeatureFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewFeatureFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewFeatureFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewFeatureFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewFeatureFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewFeatureFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewFeatureFldsCond[strFldName]));
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
 List<string> arrList = clsViewFeatureFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewFeatureFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewFeatureFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewFeatureFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewFeatureFldsDA.SetFldValue(clsViewFeatureFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewFeatureFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewFeatureFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewFeatureFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewFeatureFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewFeatureFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**界面功能Id*/ 
 strCreateTabCode.Append(" ViewFeatureId char(8) not Null, "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) not Null, "); 
 // /**相关字段Id*/ 
 strCreateTabCode.Append(" ReleFldId char(8) Null, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) Null, "); 
 // /**标签标题*/ 
 strCreateTabCode.Append(" LabelCaption varchar(150) Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) Null, "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" CtrlId varchar(50) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**样式表*/ 
 strCreateTabCode.Append(" CssClass varchar(50) Null, "); 
 // /**下拉框列表选项ID*/ 
 strCreateTabCode.Append(" DdlItemsOptionId char(2) Null, "); 
 // /**数据源表ID*/ 
 strCreateTabCode.Append(" DsTabId char(8) Null, "); 
 // /**字段Id_条件2*/ 
 strCreateTabCode.Append(" FldIdCond2 char(8) Null, "); 
 // /**字段Id_条件1*/ 
 strCreateTabCode.Append(" FldIdCond1 char(8) Null, "); 
 // /**数据源字段_条件1*/ 
 strCreateTabCode.Append(" VarIdCond2 char(8) Null, "); 
 // /**变量Id_条件1*/ 
 strCreateTabCode.Append(" VarIdCond1 char(8) Null, "); 
 // /**下拉框表功能Id*/ 
 strCreateTabCode.Append(" TabFeatureId4Ddl char(8) Null, "); 
 // /**界面实现Id*/ 
 strCreateTabCode.Append(" ViewImplId char(4) Null, "); 
 // /**文本*/ 
 strCreateTabCode.Append(" Text varchar(30) Null, "); 
 // /**字段对象Ex*/ 
 strCreateTabCode.Append(" ObjvFieldTab_SimENEx Object(10) Null, "); 
 // /**控件类型*/ 
 strCreateTabCode.Append(" ObjCtlType Object(10) Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) not Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) not Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**CS类型*/ 
 strCreateTabCode.Append(" CsType varchar(100) not Null, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" Caption varchar(200) not Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) not Null, "); 
 // /**数据源条件串*/ 
 strCreateTabCode.Append(" DsCondStr varchar(50) Null, "); 
 // /**数据源SQL串*/ 
 strCreateTabCode.Append(" DsSqlStr varchar(200) Null, "); 
 // /**列表项串*/ 
 strCreateTabCode.Append(" ItemsString varchar(200) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**字段类型名*/ 
 strCreateTabCode.Append(" FieldTypeName varchar(30) Null, "); 
 // /**相关表名*/ 
 strCreateTabCode.Append(" RelaTabName varchar(100) Null, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) Null, "); 
 // /**数据源表*/ 
 strCreateTabCode.Append(" DsTabName varchar(100) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：ViewFeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strViewFeatureId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strViewFeatureId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjList = new clsViewFeatureFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewFeatureFldsEN objViewFeatureFlds in arrViewFeatureFldsObjList)
{
objViewFeatureFlds.OrderNum = intIndex;
UpdateBySql2(objViewFeatureFlds);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：ViewFeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strViewFeatureId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strViewFeatureId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsViewFeatureFldsEN objViewFeatureFlds = clsViewFeatureFldsBL.GetObjBymId(lngmId);

intOrderNum = objViewFeatureFlds.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);
intTabRecNum = clsViewFeatureFldsBL.GetRecCountByCond(clsViewFeatureFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conViewFeatureFlds.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsViewFeatureFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsViewFeatureFldsBL.SetFldValue(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conViewFeatureFlds.mId, lngmId));
clsViewFeatureFldsBL.SetFldValue(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conViewFeatureFlds.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conViewFeatureFlds.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);

lngNextmId = clsViewFeatureFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsViewFeatureFldsBL.SetFldValue(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conViewFeatureFlds.mId, lngmId));
clsViewFeatureFldsBL.SetFldValue(clsViewFeatureFldsEN._CurrTabName, conViewFeatureFlds.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conViewFeatureFlds.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ViewFeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strViewFeatureId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conViewFeatureFlds.mId, strKeyList);
List<clsViewFeatureFldsEN> arrViewFeatureFldsLst = GetObjLst(strCondition);
foreach (clsViewFeatureFldsEN objViewFeatureFlds in arrViewFeatureFldsLst)
{
objViewFeatureFlds.OrderNum = objViewFeatureFlds.OrderNum + 10000;
UpdateBySql2(objViewFeatureFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjList = new clsViewFeatureFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewFeatureFldsEN objViewFeatureFlds in arrViewFeatureFldsObjList)
{
objViewFeatureFlds.OrderNum = intIndex;
UpdateBySql2(objViewFeatureFlds);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ViewFeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strViewFeatureId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strViewFeatureId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conViewFeatureFlds.mId, strKeyList);
List<clsViewFeatureFldsEN> arrViewFeatureFldsLst = GetObjLst(strCondition);
foreach (clsViewFeatureFldsEN objViewFeatureFlds in arrViewFeatureFldsLst)
{
objViewFeatureFlds.OrderNum = objViewFeatureFlds.OrderNum - 10000;
UpdateBySql2(objViewFeatureFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewFeatureFlds.ViewFeatureId, strViewFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewFeatureFldsEN> arrViewFeatureFldsObjList = new clsViewFeatureFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewFeatureFldsEN objViewFeatureFlds in arrViewFeatureFldsObjList)
{
objViewFeatureFlds.OrderNum = intIndex;
UpdateBySql2(objViewFeatureFlds);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 界面功能字段(ViewFeatureFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewFeatureFlds : clsCommFun4BLV2
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
clsViewFeatureFldsBL.ReFreshThisCache(strPrjId);
}
}

}