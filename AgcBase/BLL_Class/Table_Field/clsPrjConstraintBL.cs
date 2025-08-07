
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjConstraintBL
 表名:PrjConstraint(00050331)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:13
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
public static class  clsPrjConstraintBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjConstraintEN GetObj(this K_PrjConstraintId_PrjConstraint myKey)
{
clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintBL.PrjConstraintDA.GetObjByPrjConstraintId(myKey.Value);
return objPrjConstraintEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjConstraintEN) == false)
{
var strMsg = string.Format("记录已经存在!约束名 = [{0}],工程Id = [{1}],表ID = [{2}]的数据已经存在!(in clsPrjConstraintBL.AddNewRecord)", objPrjConstraintEN.ConstraintName,objPrjConstraintEN.PrjId,objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjConstraintBL.PrjConstraintDA.AddNewRecordBySQL2(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
public static bool AddRecordEx(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjConstraintEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjConstraintEN.CheckUniqueness() == false)
{
strMsg = string.Format("(约束名(ConstraintName)=[{0}],工程Id(PrjId)=[{1}],表ID(TabId)=[{2}])已经存在,不能重复!", objPrjConstraintEN.ConstraintName, objPrjConstraintEN.PrjId, objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjConstraintEN.AddNewRecord();
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjConstraintEN) == false)
{
var strMsg = string.Format("记录已经存在!约束名 = [{0}],工程Id = [{1}],表ID = [{2}]的数据已经存在!(in clsPrjConstraintBL.AddNewRecordWithMaxId)", objPrjConstraintEN.ConstraintName,objPrjConstraintEN.PrjId,objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
string strPrjConstraintId = clsPrjConstraintBL.PrjConstraintDA.AddNewRecordBySQL2WithReturnKey(objPrjConstraintEN);
     objPrjConstraintEN.PrjConstraintId = strPrjConstraintId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
}
return strPrjConstraintId;
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjConstraintEN) == false)
{
var strMsg = string.Format("记录已经存在!约束名 = [{0}],工程Id = [{1}],表ID = [{2}]的数据已经存在!(in clsPrjConstraintBL.AddNewRecordWithReturnKey)", objPrjConstraintEN.ConstraintName,objPrjConstraintEN.PrjId,objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
string strKey = clsPrjConstraintBL.PrjConstraintDA.AddNewRecordBySQL2WithReturnKey(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetPrjConstraintId(this clsPrjConstraintEN objPrjConstraintEN, string strPrjConstraintId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, conPrjConstraint.PrjConstraintId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, conPrjConstraint.PrjConstraintId);
}
objPrjConstraintEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.PrjConstraintId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.PrjConstraintId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.PrjConstraintId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintName(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, conPrjConstraint.ConstraintName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintName, 100, conPrjConstraint.ConstraintName);
}
objPrjConstraintEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintName) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintName, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintName] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetPrjId(this clsPrjConstraintEN objPrjConstraintEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjConstraint.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjConstraint.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjConstraint.PrjId);
}
objPrjConstraintEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.PrjId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.PrjId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.PrjId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetTabId(this clsPrjConstraintEN objPrjConstraintEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjConstraint.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjConstraint.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjConstraint.TabId);
}
objPrjConstraintEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.TabId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.TabId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.TabId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintTypeId(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeId, conPrjConstraint.ConstraintTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, conPrjConstraint.ConstraintTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, conPrjConstraint.ConstraintTypeId);
}
objPrjConstraintEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintTypeId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintTypeId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintTypeId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintDescription(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstraintDescription, 500, conPrjConstraint.ConstraintDescription);
}
objPrjConstraintEN.ConstraintDescription = strConstraintDescription; //约束说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintDescription) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintDescription, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintDescription] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetCreateUserId(this clsPrjConstraintEN objPrjConstraintEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conPrjConstraint.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conPrjConstraint.CreateUserId);
}
objPrjConstraintEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.CreateUserId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.CreateUserId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.CreateUserId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetIsNullable(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNullable, conPrjConstraint.IsNullable);
objPrjConstraintEN.IsNullable = bolIsNullable; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.IsNullable) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.IsNullable, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.IsNullable] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetCheckDate(this clsPrjConstraintEN objPrjConstraintEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conPrjConstraint.CheckDate);
}
objPrjConstraintEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.CheckDate) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.CheckDate, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.CheckDate] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetErrMsg(this clsPrjConstraintEN objPrjConstraintEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjConstraint.ErrMsg);
}
objPrjConstraintEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ErrMsg) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ErrMsg, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ErrMsg] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetInUse(this clsPrjConstraintEN objPrjConstraintEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conPrjConstraint.InUse);
objPrjConstraintEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.InUse) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.InUse, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.InUse] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetUpdDate(this clsPrjConstraintEN objPrjConstraintEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjConstraint.UpdDate);
}
objPrjConstraintEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.UpdDate) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.UpdDate, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.UpdDate] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetUpdUser(this clsPrjConstraintEN objPrjConstraintEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjConstraint.UpdUser);
}
objPrjConstraintEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.UpdUser) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.UpdUser, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.UpdUser] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetMemo(this clsPrjConstraintEN objPrjConstraintEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjConstraint.Memo);
}
objPrjConstraintEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.Memo) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.Memo, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.Memo] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjConstraintEN objPrjConstraintEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjConstraintEN.CheckPropertyNew();
clsPrjConstraintEN objPrjConstraintCond = new clsPrjConstraintEN();
string strCondition = objPrjConstraintCond
.SetPrjConstraintId(objPrjConstraintEN.PrjConstraintId, "<>")
.SetConstraintName(objPrjConstraintEN.ConstraintName, "=")
.SetPrjId(objPrjConstraintEN.PrjId, "=")
.SetTabId(objPrjConstraintEN.TabId, "=")
.GetCombineCondition();
objPrjConstraintEN._IsCheckProperty = true;
bool bolIsExist = clsPrjConstraintBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ConstraintName_PrjId_TabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjConstraintEN.Update();
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
 /// <param name = "objPrjConstraint">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjConstraintEN objPrjConstraint)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjConstraintEN objPrjConstraintCond = new clsPrjConstraintEN();
string strCondition = objPrjConstraintCond
.SetConstraintName(objPrjConstraint.ConstraintName, "=")
.SetPrjId(objPrjConstraint.PrjId, "=")
.SetTabId(objPrjConstraint.TabId, "=")
.GetCombineCondition();
objPrjConstraint._IsCheckProperty = true;
bool bolIsExist = clsPrjConstraintBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjConstraint.PrjConstraintId = clsPrjConstraintBL.GetFirstID_S(strCondition);
objPrjConstraint.UpdateWithCondition(strCondition);
}
else
{
objPrjConstraint.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
objPrjConstraint.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjConstraintEN objPrjConstraintEN)
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjConstraintBL.PrjConstraintDA.UpdateBySql2(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjConstraintEN objPrjConstraintEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjConstraintBL.PrjConstraintDA.UpdateBySql2(objPrjConstraintEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjConstraintEN objPrjConstraintEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjConstraintBL.PrjConstraintDA.UpdateBySqlWithCondition(objPrjConstraintEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjConstraintEN objPrjConstraintEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjConstraintBL.PrjConstraintDA.UpdateBySqlWithConditionTransaction(objPrjConstraintEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjConstraintEN objPrjConstraintEN)
{
try
{
int intRecNum = clsPrjConstraintBL.PrjConstraintDA.DelRecord(objPrjConstraintEN.PrjConstraintId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintENS">源对象</param>
 /// <param name = "objPrjConstraintENT">目标对象</param>
 public static void CopyTo(this clsPrjConstraintEN objPrjConstraintENS, clsPrjConstraintEN objPrjConstraintENT)
{
try
{
objPrjConstraintENT.PrjConstraintId = objPrjConstraintENS.PrjConstraintId; //约束表Id
objPrjConstraintENT.ConstraintName = objPrjConstraintENS.ConstraintName; //约束名
objPrjConstraintENT.PrjId = objPrjConstraintENS.PrjId; //工程Id
objPrjConstraintENT.TabId = objPrjConstraintENS.TabId; //表ID
objPrjConstraintENT.ConstraintTypeId = objPrjConstraintENS.ConstraintTypeId; //约束类型Id
objPrjConstraintENT.ConstraintDescription = objPrjConstraintENS.ConstraintDescription; //约束说明
objPrjConstraintENT.CreateUserId = objPrjConstraintENS.CreateUserId; //建立用户Id
objPrjConstraintENT.IsNullable = objPrjConstraintENS.IsNullable; //是否可空
objPrjConstraintENT.CheckDate = objPrjConstraintENS.CheckDate; //检查日期
objPrjConstraintENT.ErrMsg = objPrjConstraintENS.ErrMsg; //错误信息
objPrjConstraintENT.InUse = objPrjConstraintENS.InUse; //是否在用
objPrjConstraintENT.UpdDate = objPrjConstraintENS.UpdDate; //修改日期
objPrjConstraintENT.UpdUser = objPrjConstraintENS.UpdUser; //修改者
objPrjConstraintENT.Memo = objPrjConstraintENS.Memo; //说明
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
 /// <param name = "objPrjConstraintENS">源对象</param>
 /// <returns>目标对象=>clsPrjConstraintEN:objPrjConstraintENT</returns>
 public static clsPrjConstraintEN CopyTo(this clsPrjConstraintEN objPrjConstraintENS)
{
try
{
 clsPrjConstraintEN objPrjConstraintENT = new clsPrjConstraintEN()
{
PrjConstraintId = objPrjConstraintENS.PrjConstraintId, //约束表Id
ConstraintName = objPrjConstraintENS.ConstraintName, //约束名
PrjId = objPrjConstraintENS.PrjId, //工程Id
TabId = objPrjConstraintENS.TabId, //表ID
ConstraintTypeId = objPrjConstraintENS.ConstraintTypeId, //约束类型Id
ConstraintDescription = objPrjConstraintENS.ConstraintDescription, //约束说明
CreateUserId = objPrjConstraintENS.CreateUserId, //建立用户Id
IsNullable = objPrjConstraintENS.IsNullable, //是否可空
CheckDate = objPrjConstraintENS.CheckDate, //检查日期
ErrMsg = objPrjConstraintENS.ErrMsg, //错误信息
InUse = objPrjConstraintENS.InUse, //是否在用
UpdDate = objPrjConstraintENS.UpdDate, //修改日期
UpdUser = objPrjConstraintENS.UpdUser, //修改者
Memo = objPrjConstraintENS.Memo, //说明
};
 return objPrjConstraintENT;
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
public static void CheckPropertyNew(this clsPrjConstraintEN objPrjConstraintEN)
{
 clsPrjConstraintBL.PrjConstraintDA.CheckPropertyNew(objPrjConstraintEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjConstraintEN objPrjConstraintEN)
{
 clsPrjConstraintBL.PrjConstraintDA.CheckProperty4Condition(objPrjConstraintEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjConstraintEN objPrjConstraintCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.PrjConstraintId, objPrjConstraintCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintName) == true)
{
string strComparisonOpConstraintName = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintName, objPrjConstraintCond.ConstraintName, strComparisonOpConstraintName);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.PrjId) == true)
{
string strComparisonOpPrjId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.PrjId, objPrjConstraintCond.PrjId, strComparisonOpPrjId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.TabId) == true)
{
string strComparisonOpTabId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.TabId, objPrjConstraintCond.TabId, strComparisonOpTabId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintTypeId, objPrjConstraintCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintDescription) == true)
{
string strComparisonOpConstraintDescription = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintDescription, objPrjConstraintCond.ConstraintDescription, strComparisonOpConstraintDescription);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.CreateUserId, objPrjConstraintCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.IsNullable) == true)
{
if (objPrjConstraintCond.IsNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjConstraint.IsNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjConstraint.IsNullable);
}
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.CheckDate) == true)
{
string strComparisonOpCheckDate = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.CheckDate, objPrjConstraintCond.CheckDate, strComparisonOpCheckDate);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ErrMsg, objPrjConstraintCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.InUse) == true)
{
if (objPrjConstraintCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjConstraint.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjConstraint.InUse);
}
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.UpdDate, objPrjConstraintCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.UpdUser, objPrjConstraintCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.Memo) == true)
{
string strComparisonOpMemo = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.Memo, objPrjConstraintCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjConstraint(约束), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConstraintName_PrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjConstraintEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjConstraintEN objPrjConstraintEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjConstraintEN == null) return true;
if (objPrjConstraintEN.PrjConstraintId == null || objPrjConstraintEN.PrjConstraintId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
if (clsPrjConstraintBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjConstraintId !=  '{0}'", objPrjConstraintEN.PrjConstraintId);
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
if (clsPrjConstraintBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjConstraint(约束), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConstraintName_PrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjConstraintEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjConstraintEN objPrjConstraintEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjConstraintEN == null) return "";
if (objPrjConstraintEN.PrjConstraintId == null || objPrjConstraintEN.PrjConstraintId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjConstraintId !=  '{0}'", objPrjConstraintEN.PrjConstraintId);
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjConstraint
{
public virtual bool UpdRelaTabDate(string strPrjConstraintId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 约束(PrjConstraint)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjConstraintBL
{
public static RelatedActions_PrjConstraint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjConstraintDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjConstraintDA PrjConstraintDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjConstraintDA();
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
 public clsPrjConstraintBL()
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
if (string.IsNullOrEmpty(clsPrjConstraintEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjConstraintEN._ConnectString);
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
public static DataTable GetDataTable_PrjConstraint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjConstraintDA.GetDataTable_PrjConstraint(strWhereCond);
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
objDT = PrjConstraintDA.GetDataTable(strWhereCond);
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
objDT = PrjConstraintDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjConstraintDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjConstraintDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjConstraintDA.GetDataTable_Top(objTopPara);
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
objDT = PrjConstraintDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjConstraintDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjConstraintDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstByPrjConstraintIdLst(List<string> arrPrjConstraintIdLst)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjConstraintIdLst, true);
 string strWhereCond = string.Format("PrjConstraintId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjConstraintIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjConstraintEN> GetObjLstByPrjConstraintIdLstCache(List<string> arrPrjConstraintIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel =
arrPrjConstraintObjLstCache
.Where(x => arrPrjConstraintIdLst.Contains(x.PrjConstraintId));
return arrPrjConstraintObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLst(string strWhereCond)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
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
public static List<clsPrjConstraintEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjConstraintCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjConstraintEN> GetSubObjLstCache(clsPrjConstraintEN objPrjConstraintCond)
{
 string strPrjId = objPrjConstraintCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPrjConstraintBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPrjConstraintEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjConstraintEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjConstraint._AttributeName)
{
if (objPrjConstraintCond.IsUpdated(strFldName) == false) continue;
if (objPrjConstraintCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjConstraintCond[strFldName].ToString());
}
else
{
if (objPrjConstraintCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjConstraintCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjConstraintCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjConstraintCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjConstraintCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjConstraintCond[strFldName]));
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
public static List<clsPrjConstraintEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
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
public static List<clsPrjConstraintEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
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
List<clsPrjConstraintEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjConstraintEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjConstraintEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
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
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
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
public static List<clsPrjConstraintEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjConstraintEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
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
public static List<clsPrjConstraintEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjConstraintEN> arrObjLst = new List<clsPrjConstraintEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN();
try
{
objPrjConstraintEN.PrjConstraintId = objRow[conPrjConstraint.PrjConstraintId].ToString().Trim(); //约束表Id
objPrjConstraintEN.ConstraintName = objRow[conPrjConstraint.ConstraintName].ToString().Trim(); //约束名
objPrjConstraintEN.PrjId = objRow[conPrjConstraint.PrjId].ToString().Trim(); //工程Id
objPrjConstraintEN.TabId = objRow[conPrjConstraint.TabId].ToString().Trim(); //表ID
objPrjConstraintEN.ConstraintTypeId = objRow[conPrjConstraint.ConstraintTypeId].ToString().Trim(); //约束类型Id
objPrjConstraintEN.ConstraintDescription = objRow[conPrjConstraint.ConstraintDescription] == DBNull.Value ? null : objRow[conPrjConstraint.ConstraintDescription].ToString().Trim(); //约束说明
objPrjConstraintEN.CreateUserId = objRow[conPrjConstraint.CreateUserId].ToString().Trim(); //建立用户Id
objPrjConstraintEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.IsNullable].ToString().Trim()); //是否可空
objPrjConstraintEN.CheckDate = objRow[conPrjConstraint.CheckDate] == DBNull.Value ? null : objRow[conPrjConstraint.CheckDate].ToString().Trim(); //检查日期
objPrjConstraintEN.ErrMsg = objRow[conPrjConstraint.ErrMsg] == DBNull.Value ? null : objRow[conPrjConstraint.ErrMsg].ToString().Trim(); //错误信息
objPrjConstraintEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjConstraint.InUse].ToString().Trim()); //是否在用
objPrjConstraintEN.UpdDate = objRow[conPrjConstraint.UpdDate] == DBNull.Value ? null : objRow[conPrjConstraint.UpdDate].ToString().Trim(); //修改日期
objPrjConstraintEN.UpdUser = objRow[conPrjConstraint.UpdUser] == DBNull.Value ? null : objRow[conPrjConstraint.UpdUser].ToString().Trim(); //修改者
objPrjConstraintEN.Memo = objRow[conPrjConstraint.Memo] == DBNull.Value ? null : objRow[conPrjConstraint.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjConstraintEN.PrjConstraintId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjConstraintEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjConstraintEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjConstraint(ref clsPrjConstraintEN objPrjConstraintEN)
{
bool bolResult = PrjConstraintDA.GetPrjConstraint(ref objPrjConstraintEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjConstraintEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
if (strPrjConstraintId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjConstraintId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjConstraintId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjConstraintEN objPrjConstraintEN = PrjConstraintDA.GetObjByPrjConstraintId(strPrjConstraintId);
return objPrjConstraintEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjConstraintEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjConstraintEN objPrjConstraintEN = PrjConstraintDA.GetFirstObj(strWhereCond);
 return objPrjConstraintEN;
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
public static clsPrjConstraintEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjConstraintEN objPrjConstraintEN = PrjConstraintDA.GetObjByDataRow(objRow);
 return objPrjConstraintEN;
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
public static clsPrjConstraintEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjConstraintEN objPrjConstraintEN = PrjConstraintDA.GetObjByDataRow(objRow);
 return objPrjConstraintEN;
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
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <param name = "lstPrjConstraintObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjConstraintEN GetObjByPrjConstraintIdFromList(string strPrjConstraintId, List<clsPrjConstraintEN> lstPrjConstraintObjLst)
{
foreach (clsPrjConstraintEN objPrjConstraintEN in lstPrjConstraintObjLst)
{
if (objPrjConstraintEN.PrjConstraintId == strPrjConstraintId)
{
return objPrjConstraintEN;
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
 string strMaxPrjConstraintId;
 try
 {
 strMaxPrjConstraintId = clsPrjConstraintDA.GetMaxStrId();
 return strMaxPrjConstraintId;
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
 string strPrjConstraintId;
 try
 {
 strPrjConstraintId = new clsPrjConstraintDA().GetFirstID(strWhereCond);
 return strPrjConstraintId;
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
 arrList = PrjConstraintDA.GetID(strWhereCond);
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
bool bolIsExist = PrjConstraintDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjConstraintId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjConstraintDA.IsExist(strPrjConstraintId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPrjConstraintId">约束表Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPrjConstraintId, string strOpUser)
{
clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintBL.GetObjByPrjConstraintId(strPrjConstraintId);
objPrjConstraintEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjConstraintEN.UpdUser = strOpUser;
return clsPrjConstraintBL.UpdateBySql2(objPrjConstraintEN);
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
 bolIsExist = clsPrjConstraintDA.IsExistTable();
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
 bolIsExist = PrjConstraintDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjConstraintEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!约束名 = [{0}],工程Id = [{1}],表ID = [{2}]的数据已经存在!(in clsPrjConstraintBL.AddNewRecordBySql2)", objPrjConstraintEN.ConstraintName,objPrjConstraintEN.PrjId,objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
bool bolResult = PrjConstraintDA.AddNewRecordBySQL2(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjConstraintEN objPrjConstraintEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjConstraintEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!约束名 = [{0}],工程Id = [{1}],表ID = [{2}]的数据已经存在!(in clsPrjConstraintBL.AddNewRecordBySql2WithReturnKey)", objPrjConstraintEN.ConstraintName,objPrjConstraintEN.PrjId,objPrjConstraintEN.TabId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintBL.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintBL.GetMaxStrId_S();
 }
string strKey = PrjConstraintDA.AddNewRecordBySQL2WithReturnKey(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjConstraintEN objPrjConstraintEN)
{
try
{
bool bolResult = PrjConstraintDA.Update(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjConstraintEN objPrjConstraintEN)
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjConstraintDA.UpdateBySql2(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintBL.ReFreshCache(objPrjConstraintEN.PrjId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
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
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjConstraintId)
{
try
{
 clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintBL.GetObjByPrjConstraintId(strPrjConstraintId);

if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(objPrjConstraintEN.PrjConstraintId, objPrjConstraintEN.UpdUser);
}
if (objPrjConstraintEN != null)
{
int intRecNum = PrjConstraintDA.DelRecord(strPrjConstraintId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjConstraintEN.PrjId);
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
/// <param name="strPrjConstraintId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjConstraintId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjConstraintDA.GetSpecSQLObj();
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
//删除与表:[PrjConstraint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjConstraint.PrjConstraintId,
//strPrjConstraintId);
//        clsPrjConstraintBL.DelPrjConstraintsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjConstraintBL.DelRecord(strPrjConstraintId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjConstraintBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjConstraintId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjConstraintId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjConstraintId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjConstraintBL.relatedActions != null)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(strPrjConstraintId, "UpdRelaTabDate");
}
bool bolResult = PrjConstraintDA.DelRecord(strPrjConstraintId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjConstraintIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjConstraints(List<string> arrPrjConstraintIdLst)
{
if (arrPrjConstraintIdLst.Count == 0) return 0;
try
{
if (clsPrjConstraintBL.relatedActions != null)
{
foreach (var strPrjConstraintId in arrPrjConstraintIdLst)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(strPrjConstraintId, "UpdRelaTabDate");
}
}
 clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintBL.GetObjByPrjConstraintId(arrPrjConstraintIdLst[0]);
int intDelRecNum = PrjConstraintDA.DelPrjConstraint(arrPrjConstraintIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjConstraintEN.PrjId);
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
public static int DelPrjConstraintsByCond(string strWhereCond)
{
try
{
if (clsPrjConstraintBL.relatedActions != null)
{
List<string> arrPrjConstraintId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjConstraintId in arrPrjConstraintId)
{
clsPrjConstraintBL.relatedActions.UpdRelaTabDate(strPrjConstraintId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conPrjConstraint.PrjId, strWhereCond);
int intRecNum = PrjConstraintDA.DelPrjConstraint(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjConstraint]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjConstraintId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjConstraintId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjConstraintDA.GetSpecSQLObj();
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
//删除与表:[PrjConstraint]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjConstraintBL.DelRecord(strPrjConstraintId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjConstraintBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjConstraintId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjConstraintENS">源对象</param>
 /// <param name = "objPrjConstraintENT">目标对象</param>
 public static void CopyTo(clsPrjConstraintEN objPrjConstraintENS, clsPrjConstraintEN objPrjConstraintENT)
{
try
{
objPrjConstraintENT.PrjConstraintId = objPrjConstraintENS.PrjConstraintId; //约束表Id
objPrjConstraintENT.ConstraintName = objPrjConstraintENS.ConstraintName; //约束名
objPrjConstraintENT.PrjId = objPrjConstraintENS.PrjId; //工程Id
objPrjConstraintENT.TabId = objPrjConstraintENS.TabId; //表ID
objPrjConstraintENT.ConstraintTypeId = objPrjConstraintENS.ConstraintTypeId; //约束类型Id
objPrjConstraintENT.ConstraintDescription = objPrjConstraintENS.ConstraintDescription; //约束说明
objPrjConstraintENT.CreateUserId = objPrjConstraintENS.CreateUserId; //建立用户Id
objPrjConstraintENT.IsNullable = objPrjConstraintENS.IsNullable; //是否可空
objPrjConstraintENT.CheckDate = objPrjConstraintENS.CheckDate; //检查日期
objPrjConstraintENT.ErrMsg = objPrjConstraintENS.ErrMsg; //错误信息
objPrjConstraintENT.InUse = objPrjConstraintENS.InUse; //是否在用
objPrjConstraintENT.UpdDate = objPrjConstraintENS.UpdDate; //修改日期
objPrjConstraintENT.UpdUser = objPrjConstraintENS.UpdUser; //修改者
objPrjConstraintENT.Memo = objPrjConstraintENS.Memo; //说明
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
 /// <param name = "objPrjConstraintEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjConstraintEN objPrjConstraintEN)
{
try
{
objPrjConstraintEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjConstraintEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjConstraint.PrjConstraintId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.PrjConstraintId = objPrjConstraintEN.PrjConstraintId; //约束表Id
}
if (arrFldSet.Contains(conPrjConstraint.ConstraintName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.ConstraintName = objPrjConstraintEN.ConstraintName; //约束名
}
if (arrFldSet.Contains(conPrjConstraint.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.PrjId = objPrjConstraintEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjConstraint.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.TabId = objPrjConstraintEN.TabId; //表ID
}
if (arrFldSet.Contains(conPrjConstraint.ConstraintTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.ConstraintTypeId = objPrjConstraintEN.ConstraintTypeId; //约束类型Id
}
if (arrFldSet.Contains(conPrjConstraint.ConstraintDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.ConstraintDescription = objPrjConstraintEN.ConstraintDescription == "[null]" ? null :  objPrjConstraintEN.ConstraintDescription; //约束说明
}
if (arrFldSet.Contains(conPrjConstraint.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.CreateUserId = objPrjConstraintEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(conPrjConstraint.IsNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.IsNullable = objPrjConstraintEN.IsNullable; //是否可空
}
if (arrFldSet.Contains(conPrjConstraint.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.CheckDate = objPrjConstraintEN.CheckDate == "[null]" ? null :  objPrjConstraintEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conPrjConstraint.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.ErrMsg = objPrjConstraintEN.ErrMsg == "[null]" ? null :  objPrjConstraintEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conPrjConstraint.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.InUse = objPrjConstraintEN.InUse; //是否在用
}
if (arrFldSet.Contains(conPrjConstraint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.UpdDate = objPrjConstraintEN.UpdDate == "[null]" ? null :  objPrjConstraintEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjConstraint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.UpdUser = objPrjConstraintEN.UpdUser == "[null]" ? null :  objPrjConstraintEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conPrjConstraint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjConstraintEN.Memo = objPrjConstraintEN.Memo == "[null]" ? null :  objPrjConstraintEN.Memo; //说明
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
 /// <param name = "objPrjConstraintEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjConstraintEN objPrjConstraintEN)
{
try
{
if (objPrjConstraintEN.ConstraintDescription == "[null]") objPrjConstraintEN.ConstraintDescription = null; //约束说明
if (objPrjConstraintEN.CheckDate == "[null]") objPrjConstraintEN.CheckDate = null; //检查日期
if (objPrjConstraintEN.ErrMsg == "[null]") objPrjConstraintEN.ErrMsg = null; //错误信息
if (objPrjConstraintEN.UpdDate == "[null]") objPrjConstraintEN.UpdDate = null; //修改日期
if (objPrjConstraintEN.UpdUser == "[null]") objPrjConstraintEN.UpdUser = null; //修改者
if (objPrjConstraintEN.Memo == "[null]") objPrjConstraintEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjConstraintEN objPrjConstraintEN)
{
 PrjConstraintDA.CheckPropertyNew(objPrjConstraintEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjConstraintEN objPrjConstraintEN)
{
 PrjConstraintDA.CheckProperty4Condition(objPrjConstraintEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_PrjConstraintId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjConstraint.PrjConstraintId); 
List<clsPrjConstraintEN> arrObjLst = clsPrjConstraintBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN()
{
PrjConstraintId = "0",
ConstraintName = "选[约束]..."
};
arrObjLstSel.Insert(0, objPrjConstraintEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjConstraint.PrjConstraintId;
objComboBox.DisplayMember = conPrjConstraint.ConstraintName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_PrjConstraintId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[约束]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjConstraint.PrjConstraintId); 
IEnumerable<clsPrjConstraintEN> arrObjLst = clsPrjConstraintBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conPrjConstraint.PrjConstraintId;
objDDL.DataTextField = conPrjConstraint.ConstraintName;
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
public static void BindDdl_PrjConstraintIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[约束]...","0");
List<clsPrjConstraintEN> arrPrjConstraintObjLst = GetAllPrjConstraintObjLstCache(strPrjId); 
objDDL.DataValueField = conPrjConstraint.PrjConstraintId;
objDDL.DataTextField = conPrjConstraint.ConstraintName;
objDDL.DataSource = arrPrjConstraintObjLst;
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
if (clsPrjConstraintBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjConstraintBL没有刷新缓存机制(clsPrjConstraintBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjConstraintId");
//if (arrPrjConstraintObjLstCache == null)
//{
//arrPrjConstraintObjLstCache = PrjConstraintDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjConstraintEN GetObjByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel =
arrPrjConstraintObjLstCache
.Where(x=> x.PrjConstraintId == strPrjConstraintId 
);
if (arrPrjConstraintObjLst_Sel.Count() == 0)
{
   clsPrjConstraintEN obj = clsPrjConstraintBL.GetObjByPrjConstraintId(strPrjConstraintId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPrjConstraintId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPrjConstraintObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsPrjConstraintEN objPrjConstraint = GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objPrjConstraint == null) return "";
return objPrjConstraint.ConstraintName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjConstraintIdCache(string strPrjConstraintId, string strPrjId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//获取缓存中的对象列表
clsPrjConstraintEN objPrjConstraint = GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objPrjConstraint == null) return "";
return objPrjConstraint.ConstraintName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjConstraintEN> GetAllPrjConstraintObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache(strPrjId); 
return arrPrjConstraintObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPrjConstraintObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjConstraintEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjConstraintEN._RefreshTimeLst.Count == 0) return "";
return clsPrjConstraintEN._RefreshTimeLst[clsPrjConstraintEN._RefreshTimeLst.Count - 1];
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
if (clsPrjConstraintBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjConstraintEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjConstraintBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjConstraint(约束)
 /// 唯一性条件:ConstraintName_PrjId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjConstraintEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjConstraintEN objPrjConstraintEN)
{
//检测记录是否存在
string strResult = PrjConstraintDA.GetUniCondStr(objPrjConstraintEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjConstraintId, string strPrjId)
{
if (strInFldName != conPrjConstraint.PrjConstraintId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjConstraint._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjConstraint._AttributeName));
throw new Exception(strMsg);
}
var objPrjConstraint = clsPrjConstraintBL.GetObjByPrjConstraintIdCache(strPrjConstraintId, strPrjId);
if (objPrjConstraint == null) return "";
return objPrjConstraint[strOutFldName].ToString();
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
int intRecCount = clsPrjConstraintDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjConstraintDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjConstraintDA.GetRecCount();
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
int intRecCount = clsPrjConstraintDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjConstraintCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjConstraintEN objPrjConstraintCond)
{
 string strPrjId = objPrjConstraintCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPrjConstraintBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPrjConstraintEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjConstraintEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjConstraint._AttributeName)
{
if (objPrjConstraintCond.IsUpdated(strFldName) == false) continue;
if (objPrjConstraintCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjConstraintCond[strFldName].ToString());
}
else
{
if (objPrjConstraintCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjConstraintCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjConstraintCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjConstraintCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjConstraintCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjConstraintCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjConstraintCond[strFldName]));
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
 List<string> arrList = clsPrjConstraintDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjConstraintDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjConstraintDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjConstraintDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjConstraintDA.SetFldValue(clsPrjConstraintEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjConstraintDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjConstraintDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjConstraintDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjConstraintDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjConstraint] "); 
 strCreateTabCode.Append(" ( "); 
 // /**约束表Id*/ 
 strCreateTabCode.Append(" PrjConstraintId char(8) primary key, "); 
 // /**约束名*/ 
 strCreateTabCode.Append(" ConstraintName varchar(100) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**约束类型Id*/ 
 strCreateTabCode.Append(" ConstraintTypeId char(2) not Null, "); 
 // /**约束说明*/ 
 strCreateTabCode.Append(" ConstraintDescription varchar(500) Null, "); 
 // /**建立用户Id*/ 
 strCreateTabCode.Append(" CreateUserId varchar(18) not Null, "); 
 // /**是否可空*/ 
 strCreateTabCode.Append(" IsNullable bit not Null, "); 
 // /**检查日期*/ 
 strCreateTabCode.Append(" CheckDate varchar(20) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**约束类型名*/ 
 strCreateTabCode.Append(" ConstraintTypeName varchar(50) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNames varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 约束(PrjConstraint)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjConstraint : clsCommFun4BLV2
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
clsPrjConstraintBL.ReFreshThisCache(strPrjId);
}
}

}