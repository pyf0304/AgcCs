
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabBL
 表名:FieldTab(00050021)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:08
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
public static class  clsFieldTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTabEN GetObj(this K_FldId_FieldTab myKey)
{
clsFieldTabEN objFieldTabEN = clsFieldTabBL.FieldTabDA.GetObjByFldId(myKey.Value);
return objFieldTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTabBL.IsExist(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTabEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFieldTabEN) == false)
{
var strMsg = string.Format("记录已经存在!字段名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFieldTabBL.AddNewRecord)", objFieldTabEN.FldName,objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFieldTabBL.FieldTabDA.AddNewRecordBySQL2(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFieldTabBL.IsExist(objFieldTabEN.FldId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFieldTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFieldTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字段名(FldName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objFieldTabEN.FldName, objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFieldTabEN.AddNewRecord();
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFieldTabEN) == false)
{
var strMsg = string.Format("记录已经存在!字段名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFieldTabBL.AddNewRecordWithMaxId)", objFieldTabEN.FldName,objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true || clsFieldTabBL.IsExist(objFieldTabEN.FldId) == true)
 {
     objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(objFieldTabEN.PrjId);
 }
string strFldId = clsFieldTabBL.FieldTabDA.AddNewRecordBySQL2WithReturnKey(objFieldTabEN);
     objFieldTabEN.FldId = strFldId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
}
return strFldId;
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTabBL.IsExist(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTabEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFieldTabEN) == false)
{
var strMsg = string.Format("记录已经存在!字段名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFieldTabBL.AddNewRecordWithReturnKey)", objFieldTabEN.FldName,objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFieldTabBL.FieldTabDA.AddNewRecordBySQL2WithReturnKey(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldId(this clsFieldTabEN objFieldTabEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conFieldTab.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conFieldTab.FldId);
}
objFieldTabEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldName(this clsFieldTabEN objFieldTabEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, conFieldTab.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, conFieldTab.FldName);
}
objFieldTabEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldName) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldName, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldName] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldCnName(this clsFieldTabEN objFieldTabEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, conFieldTab.FldCnName);
}
objFieldTabEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldCnName) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldCnName, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldCnName] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetCaption(this clsFieldTabEN objFieldTabEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, conFieldTab.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, conFieldTab.Caption);
}
objFieldTabEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.Caption) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.Caption, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.Caption] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFieldTypeId(this clsFieldTabEN objFieldTabEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conFieldTab.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conFieldTab.FieldTypeId);
}
objFieldTabEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FieldTypeId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FieldTypeId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FieldTypeId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetDataTypeId(this clsFieldTabEN objFieldTabEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conFieldTab.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conFieldTab.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conFieldTab.DataTypeId);
}
objFieldTabEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.DataTypeId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.DataTypeId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.DataTypeId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldLength(this clsFieldTabEN objFieldTabEN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, conFieldTab.FldLength);
objFieldTabEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldLength) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldLength, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldLength] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldPrecision(this clsFieldTabEN objFieldTabEN, int? intFldPrecision, string strComparisonOp="")
	{
objFieldTabEN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldPrecision) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldPrecision, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldPrecision] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldInfo(this clsFieldTabEN objFieldTabEN, string strFldInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldInfo, 100, conFieldTab.FldInfo);
}
objFieldTabEN.FldInfo = strFldInfo; //字段信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldInfo) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldInfo, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldInfo] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsNull(this clsFieldTabEN objFieldTabEN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, conFieldTab.IsNull);
objFieldTabEN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsNull) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsNull, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsNull] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsPrimaryKey(this clsFieldTabEN objFieldTabEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, conFieldTab.IsPrimaryKey);
objFieldTabEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsPrimaryKey) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsPrimaryKey, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsPrimaryKey] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsIdentity(this clsFieldTabEN objFieldTabEN, bool bolIsIdentity, string strComparisonOp="")
	{
objFieldTabEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsIdentity) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsIdentity, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsIdentity] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsChecked(this clsFieldTabEN objFieldTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objFieldTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsChecked) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsChecked, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsChecked] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsArchive(this clsFieldTabEN objFieldTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objFieldTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsArchive) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsArchive, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsArchive] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsOnlyOne(this clsFieldTabEN objFieldTabEN, bool bolIsOnlyOne, string strComparisonOp="")
	{
objFieldTabEN.IsOnlyOne = bolIsOnlyOne; //是否唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsOnlyOne) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsOnlyOne, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsOnlyOne] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMaxValue(this clsFieldTabEN objFieldTabEN, string strMaxValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, conFieldTab.MaxValue);
}
objFieldTabEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.MaxValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.MaxValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.MaxValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMinValue(this clsFieldTabEN objFieldTabEN, string strMinValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, conFieldTab.MinValue);
}
objFieldTabEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.MinValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.MinValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.MinValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetDefaultValue(this clsFieldTabEN objFieldTabEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conFieldTab.DefaultValue);
}
objFieldTabEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.DefaultValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.DefaultValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.DefaultValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldStateId(this clsFieldTabEN objFieldTabEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, conFieldTab.FldStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldStateId, 2, conFieldTab.FldStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, conFieldTab.FldStateId);
}
objFieldTabEN.FldStateId = strFldStateId; //字段状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldStateId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldStateId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldStateId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetHomologousFldId(this clsFieldTabEN objFieldTabEN, string strHomologousFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, conFieldTab.HomologousFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, conFieldTab.HomologousFldId);
}
objFieldTabEN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.HomologousFldId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.HomologousFldId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.HomologousFldId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetTabNum(this clsFieldTabEN objFieldTabEN, int? intTabNum, string strComparisonOp="")
	{
objFieldTabEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.TabNum) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.TabNum, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.TabNum] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetInUse(this clsFieldTabEN objFieldTabEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conFieldTab.InUse);
objFieldTabEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.InUse) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.InUse, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.InUse] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetPrjId(this clsFieldTabEN objFieldTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFieldTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFieldTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFieldTab.PrjId);
}
objFieldTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.PrjId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.PrjId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.PrjId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetUpdDate(this clsFieldTabEN objFieldTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conFieldTab.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFieldTab.UpdDate);
}
objFieldTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.UpdDate) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.UpdDate, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.UpdDate] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetUpdUser(this clsFieldTabEN objFieldTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFieldTab.UpdUser);
}
objFieldTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.UpdUser) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.UpdUser, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.UpdUser] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMemo(this clsFieldTabEN objFieldTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldTab.Memo);
}
objFieldTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.Memo) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.Memo, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.Memo] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsNeedTransCode(this clsFieldTabEN objFieldTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
objFieldTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsNeedTransCode) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsNeedTransCode, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsNeedTransCode] = strComparisonOp;
}
}
return objFieldTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFieldTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFieldTabEN objFieldTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFieldTabEN.CheckPropertyNew();
clsFieldTabEN objFieldTabCond = new clsFieldTabEN();
string strCondition = objFieldTabCond
.SetFldId(objFieldTabEN.FldId, "<>")
.SetFldName(objFieldTabEN.FldName, "=")
.SetPrjId(objFieldTabEN.PrjId, "=")
.GetCombineCondition();
objFieldTabEN._IsCheckProperty = true;
bool bolIsExist = clsFieldTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_FldName_DataTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFieldTabEN.Update();
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
 /// <param name = "objFieldTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFieldTabEN objFieldTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFieldTabEN objFieldTabCond = new clsFieldTabEN();
string strCondition = objFieldTabCond
.SetFldName(objFieldTab.FldName, "=")
.SetPrjId(objFieldTab.PrjId, "=")
.GetCombineCondition();
objFieldTab._IsCheckProperty = true;
bool bolIsExist = clsFieldTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFieldTab.FldId = clsFieldTabBL.GetFirstID_S(strCondition);
objFieldTab.UpdateWithCondition(strCondition);
}
else
{
objFieldTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTabEN objFieldTabEN)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTabBL.FieldTabDA.UpdateBySql2(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTabEN objFieldTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTabBL.FieldTabDA.UpdateBySql2(objFieldTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTabEN objFieldTabEN, string strWhereCond)
{
try
{
bool bolResult = clsFieldTabBL.FieldTabDA.UpdateBySqlWithCondition(objFieldTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTabEN objFieldTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFieldTabBL.FieldTabDA.UpdateBySqlWithConditionTransaction(objFieldTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFieldTabEN objFieldTabEN)
{
try
{
int intRecNum = clsFieldTabBL.FieldTabDA.DelRecord(objFieldTabEN.FldId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
 public static void CopyTo(this clsFieldTabEN objFieldTabENS, clsFieldTabEN objFieldTabENT)
{
try
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.HomologousFldId = objFieldTabENS.HomologousFldId; //同源字段Id
objFieldTabENT.TabNum = objFieldTabENS.TabNum; //表数
objFieldTabENT.InUse = objFieldTabENS.InUse; //是否在用
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程Id
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
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
 /// <param name = "objFieldTabENS">源对象</param>
 /// <returns>目标对象=>clsFieldTabEN:objFieldTabENT</returns>
 public static clsFieldTabEN CopyTo(this clsFieldTabEN objFieldTabENS)
{
try
{
 clsFieldTabEN objFieldTabENT = new clsFieldTabEN()
{
FldId = objFieldTabENS.FldId, //字段Id
FldName = objFieldTabENS.FldName, //字段名
FldCnName = objFieldTabENS.FldCnName, //字段中文详名
Caption = objFieldTabENS.Caption, //标题
FieldTypeId = objFieldTabENS.FieldTypeId, //字段类型Id
DataTypeId = objFieldTabENS.DataTypeId, //数据类型Id
FldLength = objFieldTabENS.FldLength, //字段长度
FldPrecision = objFieldTabENS.FldPrecision, //精确度
FldInfo = objFieldTabENS.FldInfo, //字段信息
IsNull = objFieldTabENS.IsNull, //是否可空
IsPrimaryKey = objFieldTabENS.IsPrimaryKey, //是否主键
IsIdentity = objFieldTabENS.IsIdentity, //是否Identity
IsChecked = objFieldTabENS.IsChecked, //是否核实
IsArchive = objFieldTabENS.IsArchive, //是否存档
IsOnlyOne = objFieldTabENS.IsOnlyOne, //是否唯一
MaxValue = objFieldTabENS.MaxValue, //最大值
MinValue = objFieldTabENS.MinValue, //最小值
DefaultValue = objFieldTabENS.DefaultValue, //缺省值
FldStateId = objFieldTabENS.FldStateId, //字段状态Id
HomologousFldId = objFieldTabENS.HomologousFldId, //同源字段Id
TabNum = objFieldTabENS.TabNum, //表数
InUse = objFieldTabENS.InUse, //是否在用
PrjId = objFieldTabENS.PrjId, //工程Id
UpdDate = objFieldTabENS.UpdDate, //修改日期
UpdUser = objFieldTabENS.UpdUser, //修改者
Memo = objFieldTabENS.Memo, //说明
IsNeedTransCode = objFieldTabENS.IsNeedTransCode, //是否需要转换代码
};
 return objFieldTabENT;
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
public static void CheckPropertyNew(this clsFieldTabEN objFieldTabEN)
{
 clsFieldTabBL.FieldTabDA.CheckPropertyNew(objFieldTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFieldTabEN objFieldTabEN)
{
 clsFieldTabBL.FieldTabDA.CheckProperty4Condition(objFieldTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTabEN objFieldTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTabCond.IsUpdated(conFieldTab.FldId) == true)
{
string strComparisonOpFldId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldId, objFieldTabCond.FldId, strComparisonOpFldId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldName) == true)
{
string strComparisonOpFldName = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldName, objFieldTabCond.FldName, strComparisonOpFldName);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldCnName) == true)
{
string strComparisonOpFldCnName = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldCnName, objFieldTabCond.FldCnName, strComparisonOpFldCnName);
}
if (objFieldTabCond.IsUpdated(conFieldTab.Caption) == true)
{
string strComparisonOpCaption = objFieldTabCond.dicFldComparisonOp[conFieldTab.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.Caption, objFieldTabCond.Caption, strComparisonOpCaption);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FieldTypeId, objFieldTabCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objFieldTabCond.dicFldComparisonOp[conFieldTab.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.DataTypeId, objFieldTabCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldLength) == true)
{
string strComparisonOpFldLength = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.FldLength, objFieldTabCond.FldLength, strComparisonOpFldLength);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.FldPrecision, objFieldTabCond.FldPrecision, strComparisonOpFldPrecision);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldInfo) == true)
{
string strComparisonOpFldInfo = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldInfo, objFieldTabCond.FldInfo, strComparisonOpFldInfo);
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsNull) == true)
{
if (objFieldTabCond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsNull);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsPrimaryKey) == true)
{
if (objFieldTabCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsPrimaryKey);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsIdentity) == true)
{
if (objFieldTabCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsIdentity);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsChecked) == true)
{
if (objFieldTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsChecked);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsArchive) == true)
{
if (objFieldTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsArchive);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsOnlyOne) == true)
{
if (objFieldTabCond.IsOnlyOne == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsOnlyOne);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsOnlyOne);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.MaxValue) == true)
{
string strComparisonOpMaxValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.MaxValue, objFieldTabCond.MaxValue, strComparisonOpMaxValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.MinValue) == true)
{
string strComparisonOpMinValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.MinValue, objFieldTabCond.MinValue, strComparisonOpMinValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.DefaultValue, objFieldTabCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldStateId) == true)
{
string strComparisonOpFldStateId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldStateId, objFieldTabCond.FldStateId, strComparisonOpFldStateId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objFieldTabCond.dicFldComparisonOp[conFieldTab.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.HomologousFldId, objFieldTabCond.HomologousFldId, strComparisonOpHomologousFldId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.TabNum) == true)
{
string strComparisonOpTabNum = objFieldTabCond.dicFldComparisonOp[conFieldTab.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.TabNum, objFieldTabCond.TabNum, strComparisonOpTabNum);
}
if (objFieldTabCond.IsUpdated(conFieldTab.InUse) == true)
{
if (objFieldTabCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.InUse);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.PrjId) == true)
{
string strComparisonOpPrjId = objFieldTabCond.dicFldComparisonOp[conFieldTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.PrjId, objFieldTabCond.PrjId, strComparisonOpPrjId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objFieldTabCond.dicFldComparisonOp[conFieldTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.UpdDate, objFieldTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objFieldTabCond.IsUpdated(conFieldTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objFieldTabCond.dicFldComparisonOp[conFieldTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.UpdUser, objFieldTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objFieldTabCond.IsUpdated(conFieldTab.Memo) == true)
{
string strComparisonOpMemo = objFieldTabCond.dicFldComparisonOp[conFieldTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.Memo, objFieldTabCond.Memo, strComparisonOpMemo);
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsNeedTransCode) == true)
{
if (objFieldTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsNeedTransCode);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FieldTab(工程字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FldName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFieldTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFieldTabEN objFieldTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFieldTabEN == null) return true;
if (objFieldTabEN.FldId == null || objFieldTabEN.FldId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
if (clsFieldTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FldId !=  '{0}'", objFieldTabEN.FldId);
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
if (clsFieldTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FieldTab(工程字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFieldTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFieldTabEN objFieldTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFieldTabEN == null) return "";
if (objFieldTabEN.FldId == null || objFieldTabEN.FldId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FldId !=  '{0}'", objFieldTabEN.FldId);
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FieldTab
{
public virtual bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程字段(FieldTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFieldTabBL
{
public static RelatedActions_FieldTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFieldTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFieldTabDA FieldTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFieldTabDA();
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
 public clsFieldTabBL()
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
if (string.IsNullOrEmpty(clsFieldTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTabEN._ConnectString);
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
public static DataTable GetDataTable_FieldTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FieldTabDA.GetDataTable_FieldTab(strWhereCond);
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
objDT = FieldTabDA.GetDataTable(strWhereCond);
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
objDT = FieldTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FieldTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FieldTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FieldTabDA.GetDataTable_Top(objTopPara);
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
objDT = FieldTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FieldTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FieldTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFieldTabEN> GetObjLstByFldIdLst(List<string> arrFldIdLst)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldIdLst, true);
 string strWhereCond = string.Format("FldId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFieldTabEN> GetObjLstByFldIdLstCache(List<string> arrFldIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel =
arrFieldTabObjLstCache
.Where(x => arrFldIdLst.Contains(x.FldId));
return arrFieldTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTabEN> GetObjLst(string strWhereCond)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
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
public static List<clsFieldTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFieldTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFieldTabEN> GetSubObjLstCache(clsFieldTabEN objFieldTabCond)
{
 string strPrjId = objFieldTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsFieldTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsFieldTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldTab._AttributeName)
{
if (objFieldTabCond.IsUpdated(strFldName) == false) continue;
if (objFieldTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTabCond[strFldName].ToString());
}
else
{
if (objFieldTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTabCond[strFldName]));
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
public static List<clsFieldTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
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
public static List<clsFieldTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
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
List<clsFieldTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFieldTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFieldTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
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
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
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
public static List<clsFieldTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFieldTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFieldTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
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
public static List<clsFieldTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFieldTabEN> arrObjLst = new List<clsFieldTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTabEN objFieldTabEN = new clsFieldTabEN();
try
{
objFieldTabEN.FldId = objRow[conFieldTab.FldId].ToString().Trim(); //字段Id
objFieldTabEN.FldName = objRow[conFieldTab.FldName].ToString().Trim(); //字段名
objFieldTabEN.FldCnName = objRow[conFieldTab.FldCnName] == DBNull.Value ? null : objRow[conFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objFieldTabEN.Caption = objRow[conFieldTab.Caption].ToString().Trim(); //标题
objFieldTabEN.FieldTypeId = objRow[conFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[conFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTabEN.DataTypeId = objRow[conFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objFieldTabEN.FldLength = Int32.Parse(objRow[conFieldTab.FldLength].ToString().Trim()); //字段长度
objFieldTabEN.FldPrecision = objRow[conFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.FldPrecision].ToString().Trim()); //精确度
objFieldTabEN.FldInfo = objRow[conFieldTab.FldInfo] == DBNull.Value ? null : objRow[conFieldTab.FldInfo].ToString().Trim(); //字段信息
objFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNull].ToString().Trim()); //是否可空
objFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsChecked].ToString().Trim()); //是否核实
objFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsArchive].ToString().Trim()); //是否存档
objFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objFieldTabEN.MaxValue = objRow[conFieldTab.MaxValue] == DBNull.Value ? null : objRow[conFieldTab.MaxValue].ToString().Trim(); //最大值
objFieldTabEN.MinValue = objRow[conFieldTab.MinValue] == DBNull.Value ? null : objRow[conFieldTab.MinValue].ToString().Trim(); //最小值
objFieldTabEN.DefaultValue = objRow[conFieldTab.DefaultValue] == DBNull.Value ? null : objRow[conFieldTab.DefaultValue].ToString().Trim(); //缺省值
objFieldTabEN.FldStateId = objRow[conFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objFieldTabEN.HomologousFldId = objRow[conFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[conFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objFieldTabEN.TabNum = objRow[conFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldTab.TabNum].ToString().Trim()); //表数
objFieldTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.InUse].ToString().Trim()); //是否在用
objFieldTabEN.PrjId = objRow[conFieldTab.PrjId].ToString().Trim(); //工程Id
objFieldTabEN.UpdDate = objRow[conFieldTab.UpdDate].ToString().Trim(); //修改日期
objFieldTabEN.UpdUser = objRow[conFieldTab.UpdUser] == DBNull.Value ? null : objRow[conFieldTab.UpdUser].ToString().Trim(); //修改者
objFieldTabEN.Memo = objRow[conFieldTab.Memo] == DBNull.Value ? null : objRow[conFieldTab.Memo].ToString().Trim(); //说明
objFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFieldTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFieldTab(ref clsFieldTabEN objFieldTabEN)
{
bool bolResult = FieldTabDA.GetFieldTab(ref objFieldTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTabEN GetObjByFldId(string strFldId)
{
if (strFldId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFieldTabEN objFieldTabEN = FieldTabDA.GetObjByFldId(strFldId);
return objFieldTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFieldTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFieldTabEN objFieldTabEN = FieldTabDA.GetFirstObj(strWhereCond);
 return objFieldTabEN;
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
public static clsFieldTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFieldTabEN objFieldTabEN = FieldTabDA.GetObjByDataRow(objRow);
 return objFieldTabEN;
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
public static clsFieldTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFieldTabEN objFieldTabEN = FieldTabDA.GetObjByDataRow(objRow);
 return objFieldTabEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "lstFieldTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTabEN GetObjByFldIdFromList(string strFldId, List<clsFieldTabEN> lstFieldTabObjLst)
{
foreach (clsFieldTabEN objFieldTabEN in lstFieldTabObjLst)
{
if (objFieldTabEN.FldId == strFldId)
{
return objFieldTabEN;
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
 string strMaxFldId;
 try
 {
 strMaxFldId = new clsFieldTabDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxFldId;
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
 string strFldId;
 try
 {
 strFldId = new clsFieldTabDA().GetFirstID(strWhereCond);
 return strFldId;
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
 arrList = FieldTabDA.GetID(strWhereCond);
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
bool bolIsExist = FieldTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FieldTabDA.IsExist(strFldId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFldId">字段Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFldId, string strOpUser)
{
clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsFieldTabBL.UpdateBySql2(objFieldTabEN);
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
 bolIsExist = clsFieldTabDA.IsExistTable();
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
 bolIsExist = FieldTabDA.IsExistTable(strTabName);
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
protected static bool AddNewRecordBySql2(clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTabBL.IsExist(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTabEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objFieldTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFieldTabBL.AddNewRecordBySql2)", objFieldTabEN.FldName,objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FieldTabDA.AddNewRecordBySQL2(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFieldTabEN objFieldTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTabBL.IsExist(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTabEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objFieldTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFieldTabBL.AddNewRecordBySql2WithReturnKey)", objFieldTabEN.FldName,objFieldTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = FieldTabDA.AddNewRecordBySQL2WithReturnKey(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFieldTabEN objFieldTabEN)
{
try
{
bool bolResult = FieldTabDA.Update(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFieldTabEN objFieldTabEN)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FieldTabDA.UpdateBySql2(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabBL.ReFreshCache(objFieldTabEN.PrjId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFldId)
{
try
{
 clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(objFieldTabEN.FldId, "SetUpdDate");
}
if (objFieldTabEN != null)
{
int intRecNum = FieldTabDA.DelRecord(strFldId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFieldTabEN.PrjId);
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
/// <param name="strFldId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strFldId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFieldTabDA.GetSpecSQLObj();
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
//删除与表:[FieldTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFieldTab.FldId,
//strFldId);
//        clsFieldTabBL.DelFieldTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTabBL.DelRecord(strFldId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFldId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFldId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFieldTabBL.relatedActions != null)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(strFldId, "UpdRelaTabDate");
}
bool bolResult = FieldTabDA.DelRecord(strFldId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFldIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFieldTabs(List<string> arrFldIdLst)
{
if (arrFldIdLst.Count == 0) return 0;
try
{
if (clsFieldTabBL.relatedActions != null)
{
foreach (var strFldId in arrFldIdLst)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(strFldId, "UpdRelaTabDate");
}
}
 clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(arrFldIdLst[0]);
int intDelRecNum = FieldTabDA.DelFieldTab(arrFldIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFieldTabEN.PrjId);
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
public static int DelFieldTabsByCond(string strWhereCond)
{
try
{
if (clsFieldTabBL.relatedActions != null)
{
List<string> arrFldId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFldId in arrFldId)
{
clsFieldTabBL.relatedActions.UpdRelaTabDate(strFldId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conFieldTab.PrjId, strWhereCond);
int intRecNum = FieldTabDA.DelFieldTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FieldTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFldId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFldId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFieldTabDA.GetSpecSQLObj();
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
//删除与表:[FieldTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTabBL.DelRecord(strFldId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
 public static void CopyTo(clsFieldTabEN objFieldTabENS, clsFieldTabEN objFieldTabENT)
{
try
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.HomologousFldId = objFieldTabENS.HomologousFldId; //同源字段Id
objFieldTabENT.TabNum = objFieldTabENS.TabNum; //表数
objFieldTabENT.InUse = objFieldTabENS.InUse; //是否在用
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程Id
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
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
 /// <param name = "objFieldTabEN">源简化对象</param>
 public static void SetUpdFlag(clsFieldTabEN objFieldTabEN)
{
try
{
objFieldTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFieldTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFieldTab.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldId = objFieldTabEN.FldId; //字段Id
}
if (arrFldSet.Contains(conFieldTab.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldName = objFieldTabEN.FldName; //字段名
}
if (arrFldSet.Contains(conFieldTab.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldCnName = objFieldTabEN.FldCnName == "[null]" ? null :  objFieldTabEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(conFieldTab.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.Caption = objFieldTabEN.Caption; //标题
}
if (arrFldSet.Contains(conFieldTab.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FieldTypeId = objFieldTabEN.FieldTypeId == "[null]" ? null :  objFieldTabEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conFieldTab.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.DataTypeId = objFieldTabEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conFieldTab.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldLength = objFieldTabEN.FldLength; //字段长度
}
if (arrFldSet.Contains(conFieldTab.FldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldPrecision = objFieldTabEN.FldPrecision; //精确度
}
if (arrFldSet.Contains(conFieldTab.FldInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldInfo = objFieldTabEN.FldInfo == "[null]" ? null :  objFieldTabEN.FldInfo; //字段信息
}
if (arrFldSet.Contains(conFieldTab.IsNull, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsNull = objFieldTabEN.IsNull; //是否可空
}
if (arrFldSet.Contains(conFieldTab.IsPrimaryKey, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsPrimaryKey = objFieldTabEN.IsPrimaryKey; //是否主键
}
if (arrFldSet.Contains(conFieldTab.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsIdentity = objFieldTabEN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(conFieldTab.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsChecked = objFieldTabEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(conFieldTab.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsArchive = objFieldTabEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(conFieldTab.IsOnlyOne, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsOnlyOne = objFieldTabEN.IsOnlyOne; //是否唯一
}
if (arrFldSet.Contains(conFieldTab.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.MaxValue = objFieldTabEN.MaxValue == "[null]" ? null :  objFieldTabEN.MaxValue; //最大值
}
if (arrFldSet.Contains(conFieldTab.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.MinValue = objFieldTabEN.MinValue == "[null]" ? null :  objFieldTabEN.MinValue; //最小值
}
if (arrFldSet.Contains(conFieldTab.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.DefaultValue = objFieldTabEN.DefaultValue == "[null]" ? null :  objFieldTabEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conFieldTab.FldStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.FldStateId = objFieldTabEN.FldStateId; //字段状态Id
}
if (arrFldSet.Contains(conFieldTab.HomologousFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.HomologousFldId = objFieldTabEN.HomologousFldId == "[null]" ? null :  objFieldTabEN.HomologousFldId; //同源字段Id
}
if (arrFldSet.Contains(conFieldTab.TabNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.TabNum = objFieldTabEN.TabNum; //表数
}
if (arrFldSet.Contains(conFieldTab.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.InUse = objFieldTabEN.InUse; //是否在用
}
if (arrFldSet.Contains(conFieldTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.PrjId = objFieldTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFieldTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.UpdDate = objFieldTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFieldTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.UpdUser = objFieldTabEN.UpdUser == "[null]" ? null :  objFieldTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFieldTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.Memo = objFieldTabEN.Memo == "[null]" ? null :  objFieldTabEN.Memo; //说明
}
if (arrFldSet.Contains(conFieldTab.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTabEN.IsNeedTransCode = objFieldTabEN.IsNeedTransCode; //是否需要转换代码
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
 /// <param name = "objFieldTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsFieldTabEN objFieldTabEN)
{
try
{
if (objFieldTabEN.FldCnName == "[null]") objFieldTabEN.FldCnName = null; //字段中文详名
if (objFieldTabEN.FieldTypeId == "[null]") objFieldTabEN.FieldTypeId = null; //字段类型Id
if (objFieldTabEN.FldInfo == "[null]") objFieldTabEN.FldInfo = null; //字段信息
if (objFieldTabEN.MaxValue == "[null]") objFieldTabEN.MaxValue = null; //最大值
if (objFieldTabEN.MinValue == "[null]") objFieldTabEN.MinValue = null; //最小值
if (objFieldTabEN.DefaultValue == "[null]") objFieldTabEN.DefaultValue = null; //缺省值
if (objFieldTabEN.HomologousFldId == "[null]") objFieldTabEN.HomologousFldId = null; //同源字段Id
if (objFieldTabEN.UpdUser == "[null]") objFieldTabEN.UpdUser = null; //修改者
if (objFieldTabEN.Memo == "[null]") objFieldTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFieldTabEN objFieldTabEN)
{
 FieldTabDA.CheckPropertyNew(objFieldTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFieldTabEN objFieldTabEN)
{
 FieldTabDA.CheckProperty4Condition(objFieldTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_FldId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFieldTab.FldId); 
List<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFieldTabEN objFieldTabEN = new clsFieldTabEN()
{
FldId = "0",
FldName = "选[工程字段]..."
};
arrObjLstSel.Insert(0, objFieldTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFieldTab.FldId;
objComboBox.DisplayMember = conFieldTab.FldName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程字段]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFieldTab.FldId); 
IEnumerable<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conFieldTab.FldId;
objDDL.DataTextField = conFieldTab.FldName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程字段]...","0");
List<clsFieldTabEN> arrFieldTabObjLst = GetAllFieldTabObjLstCache(strPrjId); 
objDDL.DataValueField = conFieldTab.FldId;
objDDL.DataTextField = conFieldTab.FldName;
objDDL.DataSource = arrFieldTabObjLst;
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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldId");
//if (arrFieldTabObjLstCache == null)
//{
//arrFieldTabObjLstCache = FieldTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTabEN GetObjByFldIdCache(string strFldId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel =
arrFieldTabObjLstCache
.Where(x=> x.FldId == strFldId 
);
if (arrFieldTabObjLst_Sel.Count() == 0)
{
   clsFieldTabEN obj = clsFieldTabBL.GetObjByFldId(strFldId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFldId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrFieldTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldNameByFldIdCache(string strFldId, string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//获取缓存中的对象列表
clsFieldTabEN objFieldTab = GetObjByFldIdCache(strFldId, strPrjId);
if (objFieldTab == null) return "";
return objFieldTab.FldName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldIdCache(string strFldId, string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//获取缓存中的对象列表
clsFieldTabEN objFieldTab = GetObjByFldIdCache(strFldId, strPrjId);
if (objFieldTab == null) return "";
return objFieldTab.FldName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTabEN> GetAllFieldTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache(strPrjId); 
return arrFieldTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrFieldTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFieldTabEN._RefreshTimeLst.Count == 0) return "";
return clsFieldTabEN._RefreshTimeLst[clsFieldTabEN._RefreshTimeLst.Count - 1];
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
if (clsFieldTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFieldTabBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FieldTab(工程字段)
 /// 唯一性条件:FldName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFieldTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFieldTabEN objFieldTabEN)
{
//检测记录是否存在
string strResult = FieldTabDA.GetUniCondStr(objFieldTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFldId, string strPrjId)
{
if (strInFldName != conFieldTab.FldId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFieldTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFieldTab._AttributeName));
throw new Exception(strMsg);
}
var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
if (objFieldTab == null) return "";
return objFieldTab[strOutFldName].ToString();
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
int intRecCount = clsFieldTabDA.GetRecCount(strTabName);
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
int intRecCount = clsFieldTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFieldTabDA.GetRecCount();
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
int intRecCount = clsFieldTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFieldTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFieldTabEN objFieldTabCond)
{
 string strPrjId = objFieldTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsFieldTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsFieldTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldTab._AttributeName)
{
if (objFieldTabCond.IsUpdated(strFldName) == false) continue;
if (objFieldTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTabCond[strFldName].ToString());
}
else
{
if (objFieldTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTabCond[strFldName]));
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
 List<string> arrList = clsFieldTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FieldTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FieldTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FieldTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTabDA.SetFldValue(clsFieldTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FieldTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FieldTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) primary key, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) not Null, "); 
 // /**字段中文详名*/ 
 strCreateTabCode.Append(" FldCnName varchar(200) Null, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" Caption varchar(200) not Null, "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**字段长度*/ 
 strCreateTabCode.Append(" FldLength int not Null, "); 
 // /**精确度*/ 
 strCreateTabCode.Append(" FldPrecision int Null, "); 
 // /**字段信息*/ 
 strCreateTabCode.Append(" FldInfo varchar(100) Null, "); 
 // /**是否可空*/ 
 strCreateTabCode.Append(" IsNull bit not Null, "); 
 // /**是否主键*/ 
 strCreateTabCode.Append(" IsPrimaryKey bit not Null, "); 
 // /**是否Identity*/ 
 strCreateTabCode.Append(" IsIdentity bit Null, "); 
 // /**是否核实*/ 
 strCreateTabCode.Append(" IsChecked bit Null, "); 
 // /**是否存档*/ 
 strCreateTabCode.Append(" IsArchive bit Null, "); 
 // /**是否唯一*/ 
 strCreateTabCode.Append(" IsOnlyOne bit Null, "); 
 // /**最大值*/ 
 strCreateTabCode.Append(" MaxValue varchar(50) Null, "); 
 // /**最小值*/ 
 strCreateTabCode.Append(" MinValue varchar(50) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**字段状态Id*/ 
 strCreateTabCode.Append(" FldStateId char(2) not Null, "); 
 // /**同源字段Id*/ 
 strCreateTabCode.Append(" HomologousFldId char(8) Null, "); 
 // /**表数*/ 
 strCreateTabCode.Append(" TabNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否需要转换代码*/ 
 strCreateTabCode.Append(" IsNeedTransCode bit Null, "); 
 // /**字段类型名*/ 
 strCreateTabCode.Append(" FieldTypeName varchar(30) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) Null, "); 
 // /**数据类型对象*/ 
 strCreateTabCode.Append(" ObjDataTypeAbbr Object(10) Null, "); 
 // /**转换字段名*/ 
 strCreateTabCode.Append(" ConvFldName varchar(50) not Null, "); 
 // /**字段名Ex*/ 
 strCreateTabCode.Append(" FldNameEx varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程字段(FieldTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FieldTab : clsCommFun4BLV2
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
clsFieldTabBL.ReFreshThisCache(strPrjId);
}
}

}