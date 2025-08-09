
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabRelationBL
 表名:TabRelation(00050086)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsTabRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabRelationEN GetObj(this K_RelationId_TabRelation myKey)
{
clsTabRelationEN objTabRelationEN = clsTabRelationBL.TabRelationDA.GetObjByRelationId(myKey.Value);
return objTabRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabRelationEN objTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabRelationBL.IsExist(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabRelationEN.RelationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsTabRelationBL.TabRelationDA.AddNewRecordBySQL2(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTabRelationEN objTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTabRelationBL.IsExist(objTabRelationEN.RelationId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTabRelationEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTabRelationEN.AddNewRecord();
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabRelationEN objTabRelationEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabRelationBL.IsExist(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabRelationEN.RelationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsTabRelationBL.TabRelationDA.AddNewRecordBySQL2WithReturnKey(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetRelationId(this clsTabRelationEN objTabRelationEN, string strRelationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationId, 8, conTabRelation.RelationId);
}
objTabRelationEN.RelationId = strRelationId; //RelationId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.RelationId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.RelationId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.RelationId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetRelationName(this clsTabRelationEN objTabRelationEN, string strRelationName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationName, conTabRelation.RelationName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationName, 40, conTabRelation.RelationName);
}
objTabRelationEN.RelationName = strRelationName; //关系名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.RelationName) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.RelationName, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.RelationName] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetTabRelationTypeId(this clsTabRelationEN objTabRelationEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, conTabRelation.TabRelationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
}
objTabRelationEN.TabRelationTypeId = strTabRelationTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.TabRelationTypeId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.TabRelationTypeId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.TabRelationTypeId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetPrimaryKeyTabId(this clsTabRelationEN objTabRelationEN, string strPrimaryKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryKeyTabId, conTabRelation.PrimaryKeyTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabId, 8, conTabRelation.PrimaryKeyTabId);
}
objTabRelationEN.PrimaryKeyTabId = strPrimaryKeyTabId; //PrimaryKeyTabId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.PrimaryKeyTabId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.PrimaryKeyTabId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.PrimaryKeyTabId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetPrimaryKeyFldId(this clsTabRelationEN objTabRelationEN, string strPrimaryKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryKeyFldId, conTabRelation.PrimaryKeyFldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryKeyFldId, 8, conTabRelation.PrimaryKeyFldId);
}
objTabRelationEN.PrimaryKeyFldId = strPrimaryKeyFldId; //PrimaryKeyFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.PrimaryKeyFldId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.PrimaryKeyFldId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.PrimaryKeyFldId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetForeignKeyTabId(this clsTabRelationEN objTabRelationEN, string strForeignKeyTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
}
objTabRelationEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.ForeignKeyTabId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.ForeignKeyTabId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.ForeignKeyTabId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetForeignKeyFldId(this clsTabRelationEN objTabRelationEN, string strForeignKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignKeyFldId, conTabRelation.ForeignKeyFldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
}
objTabRelationEN.ForeignKeyFldId = strForeignKeyFldId; //外键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.ForeignKeyFldId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.ForeignKeyFldId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.ForeignKeyFldId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsCheckCurrData(this clsTabRelationEN objTabRelationEN, bool bolIsCheckCurrData, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCheckCurrData, conTabRelation.IsCheckCurrData);
objTabRelationEN.IsCheckCurrData = bolIsCheckCurrData; //是否检查当前数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsCheckCurrData) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsCheckCurrData, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsCheckCurrData] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsCopyForceRela(this clsTabRelationEN objTabRelationEN, bool bolIsCopyForceRela, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCopyForceRela, conTabRelation.IsCopyForceRela);
objTabRelationEN.IsCopyForceRela = bolIsCopyForceRela; //IsCopyForceRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsCopyForceRela) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsCopyForceRela, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsCopyForceRela] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsUpdRelateFld(this clsTabRelationEN objTabRelationEN, bool bolIsUpdRelateFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdRelateFld, conTabRelation.IsUpdRelateFld);
objTabRelationEN.IsUpdRelateFld = bolIsUpdRelateFld; //是否修改关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsUpdRelateFld) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsUpdRelateFld, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsUpdRelateFld] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsDelRelateRec(this clsTabRelationEN objTabRelationEN, bool bolIsDelRelateRec, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDelRelateRec, conTabRelation.IsDelRelateRec);
objTabRelationEN.IsDelRelateRec = bolIsDelRelateRec; //是否删除相关记录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsDelRelateRec) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsDelRelateRec, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsDelRelateRec] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetMemo(this clsTabRelationEN objTabRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabRelation.Memo);
}
objTabRelationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.Memo) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.Memo, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.Memo] = strComparisonOp;
}
}
return objTabRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabRelationEN objTabRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabRelationEN.CheckPropertyNew();
clsTabRelationEN objTabRelationCond = new clsTabRelationEN();
string strCondition = objTabRelationCond
.SetRelationId(objTabRelationEN.RelationId, "=")
.GetCombineCondition();
objTabRelationEN._IsCheckProperty = true;
bool bolIsExist = clsTabRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabRelationEN.Update();
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabRelationEN objTabRelationEN)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabRelationBL.TabRelationDA.UpdateBySql2(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabRelationEN objTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabRelationBL.TabRelationDA.UpdateBySql2(objTabRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabRelationEN objTabRelationEN, string strWhereCond)
{
try
{
bool bolResult = clsTabRelationBL.TabRelationDA.UpdateBySqlWithCondition(objTabRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabRelationEN objTabRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabRelationBL.TabRelationDA.UpdateBySqlWithConditionTransaction(objTabRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabRelationEN objTabRelationEN)
{
try
{
int intRecNum = clsTabRelationBL.TabRelationDA.DelRecord(objTabRelationEN.RelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationENS">源对象</param>
 /// <param name = "objTabRelationENT">目标对象</param>
 public static void CopyTo(this clsTabRelationEN objTabRelationENS, clsTabRelationEN objTabRelationENT)
{
try
{
objTabRelationENT.RelationId = objTabRelationENS.RelationId; //RelationId
objTabRelationENT.RelationName = objTabRelationENS.RelationName; //关系名
objTabRelationENT.TabRelationTypeId = objTabRelationENS.TabRelationTypeId; //表关系类型Id
objTabRelationENT.PrimaryKeyTabId = objTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objTabRelationENT.PrimaryKeyFldId = objTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
objTabRelationENT.ForeignKeyTabId = objTabRelationENS.ForeignKeyTabId; //外键表ID
objTabRelationENT.ForeignKeyFldId = objTabRelationENS.ForeignKeyFldId; //外键字段Id
objTabRelationENT.IsCheckCurrData = objTabRelationENS.IsCheckCurrData; //是否检查当前数据
objTabRelationENT.IsCopyForceRela = objTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objTabRelationENT.IsUpdRelateFld = objTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objTabRelationENT.IsDelRelateRec = objTabRelationENS.IsDelRelateRec; //是否删除相关记录
objTabRelationENT.Memo = objTabRelationENS.Memo; //说明
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
 /// <param name = "objTabRelationENS">源对象</param>
 /// <returns>目标对象=>clsTabRelationEN:objTabRelationENT</returns>
 public static clsTabRelationEN CopyTo(this clsTabRelationEN objTabRelationENS)
{
try
{
 clsTabRelationEN objTabRelationENT = new clsTabRelationEN()
{
RelationId = objTabRelationENS.RelationId, //RelationId
RelationName = objTabRelationENS.RelationName, //关系名
TabRelationTypeId = objTabRelationENS.TabRelationTypeId, //表关系类型Id
PrimaryKeyTabId = objTabRelationENS.PrimaryKeyTabId, //PrimaryKeyTabId
PrimaryKeyFldId = objTabRelationENS.PrimaryKeyFldId, //PrimaryKeyFldId
ForeignKeyTabId = objTabRelationENS.ForeignKeyTabId, //外键表ID
ForeignKeyFldId = objTabRelationENS.ForeignKeyFldId, //外键字段Id
IsCheckCurrData = objTabRelationENS.IsCheckCurrData, //是否检查当前数据
IsCopyForceRela = objTabRelationENS.IsCopyForceRela, //IsCopyForceRela
IsUpdRelateFld = objTabRelationENS.IsUpdRelateFld, //是否修改关系字段
IsDelRelateRec = objTabRelationENS.IsDelRelateRec, //是否删除相关记录
Memo = objTabRelationENS.Memo, //说明
};
 return objTabRelationENT;
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
public static void CheckPropertyNew(this clsTabRelationEN objTabRelationEN)
{
 clsTabRelationBL.TabRelationDA.CheckPropertyNew(objTabRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabRelationEN objTabRelationEN)
{
 clsTabRelationBL.TabRelationDA.CheckProperty4Condition(objTabRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabRelationEN objTabRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabRelationCond.IsUpdated(conTabRelation.RelationId) == true)
{
string strComparisonOpRelationId = objTabRelationCond.dicFldComparisonOp[conTabRelation.RelationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.RelationId, objTabRelationCond.RelationId, strComparisonOpRelationId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.RelationName) == true)
{
string strComparisonOpRelationName = objTabRelationCond.dicFldComparisonOp[conTabRelation.RelationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.RelationName, objTabRelationCond.RelationName, strComparisonOpRelationName);
}
if (objTabRelationCond.IsUpdated(conTabRelation.TabRelationTypeId) == true)
{
string strComparisonOpTabRelationTypeId = objTabRelationCond.dicFldComparisonOp[conTabRelation.TabRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.TabRelationTypeId, objTabRelationCond.TabRelationTypeId, strComparisonOpTabRelationTypeId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.PrimaryKeyTabId) == true)
{
string strComparisonOpPrimaryKeyTabId = objTabRelationCond.dicFldComparisonOp[conTabRelation.PrimaryKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.PrimaryKeyTabId, objTabRelationCond.PrimaryKeyTabId, strComparisonOpPrimaryKeyTabId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.PrimaryKeyFldId) == true)
{
string strComparisonOpPrimaryKeyFldId = objTabRelationCond.dicFldComparisonOp[conTabRelation.PrimaryKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.PrimaryKeyFldId, objTabRelationCond.PrimaryKeyFldId, strComparisonOpPrimaryKeyFldId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objTabRelationCond.dicFldComparisonOp[conTabRelation.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.ForeignKeyTabId, objTabRelationCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.ForeignKeyFldId) == true)
{
string strComparisonOpForeignKeyFldId = objTabRelationCond.dicFldComparisonOp[conTabRelation.ForeignKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.ForeignKeyFldId, objTabRelationCond.ForeignKeyFldId, strComparisonOpForeignKeyFldId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsCheckCurrData) == true)
{
if (objTabRelationCond.IsCheckCurrData == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsCheckCurrData);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsCheckCurrData);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsCopyForceRela) == true)
{
if (objTabRelationCond.IsCopyForceRela == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsCopyForceRela);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsCopyForceRela);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsUpdRelateFld) == true)
{
if (objTabRelationCond.IsUpdRelateFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsUpdRelateFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsUpdRelateFld);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsDelRelateRec) == true)
{
if (objTabRelationCond.IsDelRelateRec == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsDelRelateRec);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsDelRelateRec);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.Memo) == true)
{
string strComparisonOpMemo = objTabRelationCond.dicFldComparisonOp[conTabRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.Memo, objTabRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabRelation
{
public virtual bool UpdRelaTabDate(string strRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// TabRelation(TabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabRelationBL
{
public static RelatedActions_TabRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabRelationDA TabRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabRelationDA();
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
 public clsTabRelationBL()
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
if (string.IsNullOrEmpty(clsTabRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabRelationEN._ConnectString);
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
public static DataTable GetDataTable_TabRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabRelationDA.GetDataTable_TabRelation(strWhereCond);
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
objDT = TabRelationDA.GetDataTable(strWhereCond);
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
objDT = TabRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabRelationDA.GetDataTable_Top(objTopPara);
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
objDT = TabRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabRelationEN> GetObjLstByRelationIdLst(List<string> arrRelationIdLst)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelationIdLst, true);
 string strWhereCond = string.Format("RelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabRelationEN> GetObjLstByRelationIdLstCache(List<string> arrRelationIdLst)
{
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
List<clsTabRelationEN> arrTabRelationObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrTabRelationObjLst_Sel =
arrTabRelationObjLstCache
.Where(x => arrRelationIdLst.Contains(x.RelationId));
return arrTabRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetObjLst(string strWhereCond)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
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
public static List<clsTabRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabRelationEN> GetSubObjLstCache(clsTabRelationEN objTabRelationCond)
{
List<clsTabRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabRelation._AttributeName)
{
if (objTabRelationCond.IsUpdated(strFldName) == false) continue;
if (objTabRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabRelationCond[strFldName].ToString());
}
else
{
if (objTabRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabRelationCond[strFldName]));
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
public static List<clsTabRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
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
public static List<clsTabRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
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
List<clsTabRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
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
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
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
public static List<clsTabRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
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
public static List<clsTabRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabRelation(ref clsTabRelationEN objTabRelationEN)
{
bool bolResult = TabRelationDA.GetTabRelation(ref objTabRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabRelationEN GetObjByRelationId(string strRelationId)
{
if (strRelationId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRelationId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRelationId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRelationId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTabRelationEN objTabRelationEN = TabRelationDA.GetObjByRelationId(strRelationId);
return objTabRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabRelationEN objTabRelationEN = TabRelationDA.GetFirstObj(strWhereCond);
 return objTabRelationEN;
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
public static clsTabRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabRelationEN objTabRelationEN = TabRelationDA.GetObjByDataRow(objRow);
 return objTabRelationEN;
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
public static clsTabRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabRelationEN objTabRelationEN = TabRelationDA.GetObjByDataRow(objRow);
 return objTabRelationEN;
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
 /// <param name = "strRelationId">所给的关键字</param>
 /// <param name = "lstTabRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabRelationEN GetObjByRelationIdFromList(string strRelationId, List<clsTabRelationEN> lstTabRelationObjLst)
{
foreach (clsTabRelationEN objTabRelationEN in lstTabRelationObjLst)
{
if (objTabRelationEN.RelationId == strRelationId)
{
return objTabRelationEN;
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
 string strRelationId;
 try
 {
 strRelationId = new clsTabRelationDA().GetFirstID(strWhereCond);
 return strRelationId;
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
 arrList = TabRelationDA.GetID(strWhereCond);
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
bool bolIsExist = TabRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRelationId)
{
if (string.IsNullOrEmpty(strRelationId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRelationId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TabRelationDA.IsExist(strRelationId);
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
 bolIsExist = clsTabRelationDA.IsExistTable();
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
 bolIsExist = TabRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabRelationEN objTabRelationEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabRelationBL.IsExist(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabRelationEN.RelationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = TabRelationDA.AddNewRecordBySQL2(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabRelationEN objTabRelationEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabRelationBL.IsExist(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabRelationEN.RelationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = TabRelationDA.AddNewRecordBySQL2WithReturnKey(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabRelationEN objTabRelationEN)
{
try
{
bool bolResult = TabRelationDA.Update(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabRelationEN objTabRelationEN)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabRelationDA.UpdateBySql2(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationBL.ReFreshCache();

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
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
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRelationId)
{
try
{
 clsTabRelationEN objTabRelationEN = clsTabRelationBL.GetObjByRelationId(strRelationId);

if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(objTabRelationEN.RelationId, "SetUpdDate");
}
if (objTabRelationEN != null)
{
int intRecNum = TabRelationDA.DelRecord(strRelationId);
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
/// <param name="strRelationId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRelationId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabRelationDA.GetSpecSQLObj();
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
//删除与表:[TabRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabRelation.RelationId,
//strRelationId);
//        clsTabRelationBL.DelTabRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabRelationBL.DelRecord(strRelationId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRelationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabRelationBL.relatedActions != null)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(strRelationId, "UpdRelaTabDate");
}
bool bolResult = TabRelationDA.DelRecord(strRelationId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRelationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabRelations(List<string> arrRelationIdLst)
{
if (arrRelationIdLst.Count == 0) return 0;
try
{
if (clsTabRelationBL.relatedActions != null)
{
foreach (var strRelationId in arrRelationIdLst)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(strRelationId, "UpdRelaTabDate");
}
}
int intDelRecNum = TabRelationDA.DelTabRelation(arrRelationIdLst);
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
public static int DelTabRelationsByCond(string strWhereCond)
{
try
{
if (clsTabRelationBL.relatedActions != null)
{
List<string> arrRelationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRelationId in arrRelationId)
{
clsTabRelationBL.relatedActions.UpdRelaTabDate(strRelationId, "UpdRelaTabDate");
}
}
int intRecNum = TabRelationDA.DelTabRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRelationId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRelationId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabRelationDA.GetSpecSQLObj();
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
//删除与表:[TabRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabRelationBL.DelRecord(strRelationId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabRelationENS">源对象</param>
 /// <param name = "objTabRelationENT">目标对象</param>
 public static void CopyTo(clsTabRelationEN objTabRelationENS, clsTabRelationEN objTabRelationENT)
{
try
{
objTabRelationENT.RelationId = objTabRelationENS.RelationId; //RelationId
objTabRelationENT.RelationName = objTabRelationENS.RelationName; //关系名
objTabRelationENT.TabRelationTypeId = objTabRelationENS.TabRelationTypeId; //表关系类型Id
objTabRelationENT.PrimaryKeyTabId = objTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objTabRelationENT.PrimaryKeyFldId = objTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
objTabRelationENT.ForeignKeyTabId = objTabRelationENS.ForeignKeyTabId; //外键表ID
objTabRelationENT.ForeignKeyFldId = objTabRelationENS.ForeignKeyFldId; //外键字段Id
objTabRelationENT.IsCheckCurrData = objTabRelationENS.IsCheckCurrData; //是否检查当前数据
objTabRelationENT.IsCopyForceRela = objTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objTabRelationENT.IsUpdRelateFld = objTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objTabRelationENT.IsDelRelateRec = objTabRelationENS.IsDelRelateRec; //是否删除相关记录
objTabRelationENT.Memo = objTabRelationENS.Memo; //说明
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
 /// <param name = "objTabRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsTabRelationEN objTabRelationEN)
{
try
{
objTabRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabRelation.RelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.RelationId = objTabRelationEN.RelationId; //RelationId
}
if (arrFldSet.Contains(conTabRelation.RelationName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.RelationName = objTabRelationEN.RelationName; //关系名
}
if (arrFldSet.Contains(conTabRelation.TabRelationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.TabRelationTypeId = objTabRelationEN.TabRelationTypeId; //表关系类型Id
}
if (arrFldSet.Contains(conTabRelation.PrimaryKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.PrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
}
if (arrFldSet.Contains(conTabRelation.PrimaryKeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.PrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
}
if (arrFldSet.Contains(conTabRelation.ForeignKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.ForeignKeyTabId = objTabRelationEN.ForeignKeyTabId == "[null]" ? null :  objTabRelationEN.ForeignKeyTabId; //外键表ID
}
if (arrFldSet.Contains(conTabRelation.ForeignKeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.ForeignKeyFldId = objTabRelationEN.ForeignKeyFldId; //外键字段Id
}
if (arrFldSet.Contains(conTabRelation.IsCheckCurrData, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.IsCheckCurrData = objTabRelationEN.IsCheckCurrData; //是否检查当前数据
}
if (arrFldSet.Contains(conTabRelation.IsCopyForceRela, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.IsCopyForceRela = objTabRelationEN.IsCopyForceRela; //IsCopyForceRela
}
if (arrFldSet.Contains(conTabRelation.IsUpdRelateFld, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.IsUpdRelateFld = objTabRelationEN.IsUpdRelateFld; //是否修改关系字段
}
if (arrFldSet.Contains(conTabRelation.IsDelRelateRec, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.IsDelRelateRec = objTabRelationEN.IsDelRelateRec; //是否删除相关记录
}
if (arrFldSet.Contains(conTabRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabRelationEN.Memo = objTabRelationEN.Memo == "[null]" ? null :  objTabRelationEN.Memo; //说明
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
 /// <param name = "objTabRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabRelationEN objTabRelationEN)
{
try
{
if (objTabRelationEN.ForeignKeyTabId == "[null]") objTabRelationEN.ForeignKeyTabId = null; //外键表ID
if (objTabRelationEN.Memo == "[null]") objTabRelationEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTabRelationEN objTabRelationEN)
{
 TabRelationDA.CheckPropertyNew(objTabRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabRelationEN objTabRelationEN)
{
 TabRelationDA.CheckProperty4Condition(objTabRelationEN);
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
if (clsTabRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabRelationBL没有刷新缓存机制(clsTabRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationId");
//if (arrTabRelationObjLstCache == null)
//{
//arrTabRelationObjLstCache = TabRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabRelationEN GetObjByRelationIdCache(string strRelationId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
List<clsTabRelationEN> arrTabRelationObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrTabRelationObjLst_Sel =
arrTabRelationObjLstCache
.Where(x=> x.RelationId == strRelationId 
);
if (arrTabRelationObjLst_Sel.Count() == 0)
{
   clsTabRelationEN obj = clsTabRelationBL.GetObjByRelationId(strRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTabRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabRelationEN> GetAllTabRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsTabRelationEN> arrTabRelationObjLstCache = GetObjLstCache(); 
return arrTabRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
List<clsTabRelationEN> arrTabRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTabRelationObjLstCache;
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
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabRelationEN._RefreshTimeLst.Count == 0) return "";
return clsTabRelationEN._RefreshTimeLst[clsTabRelationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsTabRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabRelationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strRelationId)
{
if (strInFldName != conTabRelation.RelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabRelation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabRelation._AttributeName));
throw new Exception(strMsg);
}
var objTabRelation = clsTabRelationBL.GetObjByRelationIdCache(strRelationId);
if (objTabRelation == null) return "";
return objTabRelation[strOutFldName].ToString();
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
int intRecCount = clsTabRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsTabRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabRelationDA.GetRecCount();
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
int intRecCount = clsTabRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabRelationEN objTabRelationCond)
{
List<clsTabRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabRelation._AttributeName)
{
if (objTabRelationCond.IsUpdated(strFldName) == false) continue;
if (objTabRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabRelationCond[strFldName].ToString());
}
else
{
if (objTabRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabRelationCond[strFldName]));
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
 List<string> arrList = clsTabRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabRelationDA.SetFldValue(clsTabRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RelationId*/ 
 strCreateTabCode.Append(" RelationId varchar(8) primary key, "); 
 // /**关系名*/ 
 strCreateTabCode.Append(" RelationName varchar(40) not Null, "); 
 // /**表关系类型Id*/ 
 strCreateTabCode.Append(" TabRelationTypeId char(2) not Null, "); 
 // /**PrimaryKeyTabId*/ 
 strCreateTabCode.Append(" PrimaryKeyTabId varchar(8) not Null, "); 
 // /**PrimaryKeyFldId*/ 
 strCreateTabCode.Append(" PrimaryKeyFldId varchar(8) not Null, "); 
 // /**外键表ID*/ 
 strCreateTabCode.Append(" ForeignKeyTabId char(8) Null, "); 
 // /**外键字段Id*/ 
 strCreateTabCode.Append(" ForeignKeyFldId char(8) not Null, "); 
 // /**是否检查当前数据*/ 
 strCreateTabCode.Append(" IsCheckCurrData bit not Null, "); 
 // /**IsCopyForceRela*/ 
 strCreateTabCode.Append(" IsCopyForceRela bit not Null, "); 
 // /**是否修改关系字段*/ 
 strCreateTabCode.Append(" IsUpdRelateFld bit not Null, "); 
 // /**是否删除相关记录*/ 
 strCreateTabCode.Append(" IsDelRelateRec bit not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// TabRelation(TabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabRelation : clsCommFun4BL
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
clsTabRelationBL.ReFreshThisCache();
}
}

}