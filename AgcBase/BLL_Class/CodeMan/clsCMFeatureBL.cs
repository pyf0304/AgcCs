
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureBL
 表名:CMFeature(00050517)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureEN GetObj(this K_CmFeatureId_CMFeature myKey)
{
clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.CMFeatureDA.GetObjByCmFeatureId(myKey.Value);
return objCMFeatureEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMFeatureEN.CmFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],Cm工程Id = [{1}]的数据已经存在!(in clsCMFeatureBL.AddNewRecord)", objCMFeatureEN.FeatureName,objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMFeatureBL.CMFeatureDA.AddNewRecordBySQL2(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
public static bool AddRecordEx(this clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCMFeatureEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMFeatureEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能名称(FeatureName)=[{0}],Cm工程Id(CmPrjId)=[{1}])已经存在,不能重复!", objCMFeatureEN.FeatureName, objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMFeatureEN.AddNewRecord();
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],Cm工程Id = [{1}]的数据已经存在!(in clsCMFeatureBL.AddNewRecordWithMaxId)", objCMFeatureEN.FeatureName,objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true || clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
     objCMFeatureEN.CmFeatureId = clsCMFeatureBL.GetMaxStrIdByPrefix_S(objCMFeatureEN.PrjId);
 }
string strCmFeatureId = clsCMFeatureBL.CMFeatureDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureEN);
     objCMFeatureEN.CmFeatureId = strCmFeatureId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
}
return strCmFeatureId;
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMFeatureEN.CmFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],Cm工程Id = [{1}]的数据已经存在!(in clsCMFeatureBL.AddNewRecordWithReturnKey)", objCMFeatureEN.FeatureName,objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMFeatureBL.CMFeatureDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmFeatureId(this clsCMFeatureEN objCMFeatureEN, string strCmFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, conCMFeature.CmFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, conCMFeature.CmFeatureId);
}
objCMFeatureEN.CmFeatureId = strCmFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmFeatureId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmFeatureId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmFeatureId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureName(this clsCMFeatureEN objCMFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, conCMFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, conCMFeature.FeatureName);
}
objCMFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureENName(this clsCMFeatureEN objCMFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, conCMFeature.FeatureENName);
}
objCMFeatureEN.FeatureENName = strFeatureENName; //功能英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureENName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureENName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureENName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetKeyWords(this clsCMFeatureEN objCMFeatureEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conCMFeature.KeyWords);
}
objCMFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.KeyWords) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.KeyWords, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.KeyWords] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFeatureDescription(this clsCMFeatureEN objCMFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conCMFeature.FeatureDescription);
}
objCMFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FeatureDescription) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FeatureDescription, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FeatureDescription] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmParentFeatureId(this clsCMFeatureEN objCMFeatureEN, string strCmParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmParentFeatureId, 8, conCMFeature.CmParentFeatureId);
}
objCMFeatureEN.CmParentFeatureId = strCmParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmParentFeatureId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmParentFeatureId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmParentFeatureId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetParentFeatureName(this clsCMFeatureEN objCMFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, conCMFeature.ParentFeatureName);
}
objCMFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.ParentFeatureName) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.ParentFeatureName, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.ParentFeatureName] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmFeatureTypeId(this clsCMFeatureEN objCMFeatureEN, string strCmFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureTypeId, conCMFeature.CmFeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureTypeId, 2, conCMFeature.CmFeatureTypeId);
}
objCMFeatureEN.CmFeatureTypeId = strCmFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmFeatureTypeId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmFeatureTypeId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmFeatureTypeId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCreateUserId(this clsCMFeatureEN objCMFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conCMFeature.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conCMFeature.CreateUserId);
}
objCMFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CreateUserId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CreateUserId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CreateUserId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetInUse(this clsCMFeatureEN objCMFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objCMFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.InUse) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.InUse, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.InUse] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetOrderNum(this clsCMFeatureEN objCMFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMFeature.OrderNum);
objCMFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.OrderNum) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.OrderNum, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.OrderNum] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetFuncModuleAgcId(this clsCMFeatureEN objCMFeatureEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, conCMFeature.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMFeature.FuncModuleAgcId);
}
objCMFeatureEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.FuncModuleAgcId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetCmPrjId(this clsCMFeatureEN objCMFeatureEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMFeature.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMFeature.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMFeature.CmPrjId);
}
objCMFeatureEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.CmPrjId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.CmPrjId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.CmPrjId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetPrjId(this clsCMFeatureEN objCMFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMFeature.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMFeature.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMFeature.PrjId);
}
objCMFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.PrjId) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.PrjId, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.PrjId] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetUpdDate(this clsCMFeatureEN objCMFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFeature.UpdDate);
}
objCMFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.UpdDate) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.UpdDate, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.UpdDate] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetUpdUser(this clsCMFeatureEN objCMFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFeature.UpdUser);
}
objCMFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.UpdUser) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.UpdUser, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.UpdUser] = strComparisonOp;
}
}
return objCMFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureEN SetMemo(this clsCMFeatureEN objCMFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFeature.Memo);
}
objCMFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureEN.dicFldComparisonOp.ContainsKey(conCMFeature.Memo) == false)
{
objCMFeatureEN.dicFldComparisonOp.Add(conCMFeature.Memo, strComparisonOp);
}
else
{
objCMFeatureEN.dicFldComparisonOp[conCMFeature.Memo] = strComparisonOp;
}
}
return objCMFeatureEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMFeatureEN objCMFeatureEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMFeatureEN.CheckPropertyNew();
clsCMFeatureEN objCMFeatureCond = new clsCMFeatureEN();
string strCondition = objCMFeatureCond
.SetCmFeatureId(objCMFeatureEN.CmFeatureId, "<>")
.SetFeatureName(objCMFeatureEN.FeatureName, "=")
.SetCmPrjId(objCMFeatureEN.CmPrjId, "=")
.GetCombineCondition();
objCMFeatureEN._IsCheckProperty = true;
bool bolIsExist = clsCMFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FeatureName_CMPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMFeatureEN.Update();
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
 /// <param name = "objCMFeature">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMFeatureEN objCMFeature)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMFeatureEN objCMFeatureCond = new clsCMFeatureEN();
string strCondition = objCMFeatureCond
.SetFeatureName(objCMFeature.FeatureName, "=")
.SetCmPrjId(objCMFeature.CmPrjId, "=")
.GetCombineCondition();
objCMFeature._IsCheckProperty = true;
bool bolIsExist = clsCMFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMFeature.CmFeatureId = clsCMFeatureBL.GetFirstID_S(strCondition);
objCMFeature.UpdateWithCondition(strCondition);
}
else
{
objCMFeature.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureEN objCMFeatureEN)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFeatureBL.CMFeatureDA.UpdateBySql2(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureEN objCMFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFeatureBL.CMFeatureDA.UpdateBySql2(objCMFeatureEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureEN objCMFeatureEN, string strWhereCond)
{
try
{
bool bolResult = clsCMFeatureBL.CMFeatureDA.UpdateBySqlWithCondition(objCMFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureEN objCMFeatureEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMFeatureBL.CMFeatureDA.UpdateBySqlWithConditionTransaction(objCMFeatureEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMFeatureEN objCMFeatureEN)
{
try
{
int intRecNum = clsCMFeatureBL.CMFeatureDA.DelRecord(objCMFeatureEN.CmFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureENS">源对象</param>
 /// <param name = "objCMFeatureENT">目标对象</param>
 public static void CopyTo(this clsCMFeatureEN objCMFeatureENS, clsCMFeatureEN objCMFeatureENT)
{
try
{
objCMFeatureENT.CmFeatureId = objCMFeatureENS.CmFeatureId; //功能Id
objCMFeatureENT.FeatureName = objCMFeatureENS.FeatureName; //功能名称
objCMFeatureENT.FeatureENName = objCMFeatureENS.FeatureENName; //功能英文名
objCMFeatureENT.KeyWords = objCMFeatureENS.KeyWords; //关键字
objCMFeatureENT.FeatureDescription = objCMFeatureENS.FeatureDescription; //功能说明
objCMFeatureENT.CmParentFeatureId = objCMFeatureENS.CmParentFeatureId; //父功能Id
objCMFeatureENT.ParentFeatureName = objCMFeatureENS.ParentFeatureName; //父功能名
objCMFeatureENT.CmFeatureTypeId = objCMFeatureENS.CmFeatureTypeId; //功能类型Id
objCMFeatureENT.CreateUserId = objCMFeatureENS.CreateUserId; //建立用户Id
objCMFeatureENT.InUse = objCMFeatureENS.InUse; //是否在用
objCMFeatureENT.OrderNum = objCMFeatureENS.OrderNum; //序号
objCMFeatureENT.FuncModuleAgcId = objCMFeatureENS.FuncModuleAgcId; //功能模块Id
objCMFeatureENT.CmPrjId = objCMFeatureENS.CmPrjId; //Cm工程Id
objCMFeatureENT.PrjId = objCMFeatureENS.PrjId; //工程Id
objCMFeatureENT.UpdDate = objCMFeatureENS.UpdDate; //修改日期
objCMFeatureENT.UpdUser = objCMFeatureENS.UpdUser; //修改者
objCMFeatureENT.Memo = objCMFeatureENS.Memo; //说明
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
 /// <param name = "objCMFeatureENS">源对象</param>
 /// <returns>目标对象=>clsCMFeatureEN:objCMFeatureENT</returns>
 public static clsCMFeatureEN CopyTo(this clsCMFeatureEN objCMFeatureENS)
{
try
{
 clsCMFeatureEN objCMFeatureENT = new clsCMFeatureEN()
{
CmFeatureId = objCMFeatureENS.CmFeatureId, //功能Id
FeatureName = objCMFeatureENS.FeatureName, //功能名称
FeatureENName = objCMFeatureENS.FeatureENName, //功能英文名
KeyWords = objCMFeatureENS.KeyWords, //关键字
FeatureDescription = objCMFeatureENS.FeatureDescription, //功能说明
CmParentFeatureId = objCMFeatureENS.CmParentFeatureId, //父功能Id
ParentFeatureName = objCMFeatureENS.ParentFeatureName, //父功能名
CmFeatureTypeId = objCMFeatureENS.CmFeatureTypeId, //功能类型Id
CreateUserId = objCMFeatureENS.CreateUserId, //建立用户Id
InUse = objCMFeatureENS.InUse, //是否在用
OrderNum = objCMFeatureENS.OrderNum, //序号
FuncModuleAgcId = objCMFeatureENS.FuncModuleAgcId, //功能模块Id
CmPrjId = objCMFeatureENS.CmPrjId, //Cm工程Id
PrjId = objCMFeatureENS.PrjId, //工程Id
UpdDate = objCMFeatureENS.UpdDate, //修改日期
UpdUser = objCMFeatureENS.UpdUser, //修改者
Memo = objCMFeatureENS.Memo, //说明
};
 return objCMFeatureENT;
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
public static void CheckPropertyNew(this clsCMFeatureEN objCMFeatureEN)
{
 clsCMFeatureBL.CMFeatureDA.CheckPropertyNew(objCMFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMFeatureEN objCMFeatureEN)
{
 clsCMFeatureBL.CMFeatureDA.CheckProperty4Condition(objCMFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFeatureEN objCMFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFeatureCond.IsUpdated(conCMFeature.CmFeatureId) == true)
{
string strComparisonOpCmFeatureId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmFeatureId, objCMFeatureCond.CmFeatureId, strComparisonOpCmFeatureId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureName, objCMFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureENName) == true)
{
string strComparisonOpFeatureENName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureENName, objCMFeatureCond.FeatureENName, strComparisonOpFeatureENName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objCMFeatureCond.dicFldComparisonOp[conCMFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.KeyWords, objCMFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FeatureDescription, objCMFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmParentFeatureId) == true)
{
string strComparisonOpCmParentFeatureId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmParentFeatureId, objCMFeatureCond.CmParentFeatureId, strComparisonOpCmParentFeatureId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objCMFeatureCond.dicFldComparisonOp[conCMFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.ParentFeatureName, objCMFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmFeatureTypeId) == true)
{
string strComparisonOpCmFeatureTypeId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmFeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmFeatureTypeId, objCMFeatureCond.CmFeatureTypeId, strComparisonOpCmFeatureTypeId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CreateUserId, objCMFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.InUse) == true)
{
if (objCMFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFeature.InUse);
}
}
if (objCMFeatureCond.IsUpdated(conCMFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMFeatureCond.dicFldComparisonOp[conCMFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFeature.OrderNum, objCMFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.FuncModuleAgcId, objCMFeatureCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.CmPrjId, objCMFeatureCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.PrjId) == true)
{
string strComparisonOpPrjId = objCMFeatureCond.dicFldComparisonOp[conCMFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.PrjId, objCMFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFeatureCond.dicFldComparisonOp[conCMFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.UpdDate, objCMFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFeatureCond.dicFldComparisonOp[conCMFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.UpdUser, objCMFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFeatureCond.IsUpdated(conCMFeature.Memo) == true)
{
string strComparisonOpMemo = objCMFeatureCond.dicFldComparisonOp[conCMFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeature.Memo, objCMFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMFeature(CM功能), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FeatureName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMFeatureEN objCMFeatureEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureEN == null) return true;
if (objCMFeatureEN.CmFeatureId == null || objCMFeatureEN.CmFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
if (clsCMFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmFeatureId !=  '{0}'", objCMFeatureEN.CmFeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
if (clsCMFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMFeature(CM功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMFeatureEN objCMFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureEN == null) return "";
if (objCMFeatureEN.CmFeatureId == null || objCMFeatureEN.CmFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFeatureId !=  '{0}'", objCMFeatureEN.CmFeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objCMFeatureEN.FeatureName);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMFeatureEN.CmPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMFeature
{
public virtual bool UpdRelaTabDate(string strCmFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCMFeature
{
 /// <summary>
 /// 个人中心
 /// </summary>
public const string _00070008 = "00070008";
 /// <summary>
 /// 主任务维护
 /// </summary>
public const string _00070009 = "00070009";
 /// <summary>
 /// 首页
 /// </summary>
public const string _00070010 = "00070010";
 /// <summary>
 /// 子任务维护
 /// </summary>
public const string _00070011 = "00070011";
 /// <summary>
 /// 工程角色切换
 /// </summary>
public const string _00070012 = "00070012";
 /// <summary>
 /// 微信用户绑定
 /// </summary>
public const string _00070015 = "00070015";
 /// <summary>
 /// 任务类型统计
 /// </summary>
public const string _00070021 = "00070021";
 /// <summary>
 /// 任务相关数量统计
 /// </summary>
public const string _00070023 = "00070023";
 /// <summary>
 /// 任务进度
 /// </summary>
public const string _00070025 = "00070025";
 /// <summary>
 /// 意见反馈
 /// </summary>
public const string _00070026 = "00070026";
 /// <summary>
 /// 用户信息展示修改
 /// </summary>
public const string _00070028 = "00070028";
 /// <summary>
 /// 用户密码修改
 /// </summary>
public const string _00070030 = "00070030";
 /// <summary>
 /// 使用任务模板
 /// </summary>
public const string _00070033 = "00070033";
 /// <summary>
 /// 签到
 /// </summary>
public const string _00070037 = "00070037";
 /// <summary>
 /// 审核
 /// </summary>
public const string _00070038 = "00070038";
 /// <summary>
 /// 统计
 /// </summary>
public const string _00070039 = "00070039";
 /// <summary>
 /// 季报
 /// </summary>
public const string _00070040 = "00070040";
 /// <summary>
 /// 月报
 /// </summary>
public const string _00070041 = "00070041";
 /// <summary>
 /// 微信小程序 ，通过微信跳转登录习题试卷
 /// </summary>
public const string _01120013 = "01120013";
 /// <summary>
 /// 课程视频
 /// </summary>
public const string _01120014 = "01120014";
 /// <summary>
 /// 课件视频播放
 /// </summary>
public const string _01120016 = "01120016";
 /// <summary>
 /// 课件案例视频评论及评论列表展示
 /// </summary>
public const string _01120017 = "01120017";
 /// <summary>
 /// 课件案例视频点赞功能
 /// </summary>
public const string _01120018 = "01120018";
 /// <summary>
 /// 课件案例视频浏览次数记录功能
 /// </summary>
public const string _01120019 = "01120019";
 /// <summary>
 /// 课件案例视频收藏功能
 /// </summary>
public const string _01120020 = "01120020";
 /// <summary>
 /// 登录权限模块流程
 /// </summary>
public const string _01120022 = "01120022";
 /// <summary>
 /// 视频库
 /// </summary>
public const string _01120024 = "01120024";
 /// <summary>
 /// 视频库播放
 /// </summary>
public const string _01120031 = "01120031";
 /// <summary>
 /// 视频库视频播放评论及评论列表功能
 /// </summary>
public const string _01120032 = "01120032";
 /// <summary>
 /// 视频库播放浏览记录
 /// </summary>
public const string _01120034 = "01120034";
 /// <summary>
 /// 视频库点赞功能
 /// </summary>
public const string _01120035 = "01120035";
 /// <summary>
 /// 视频库收藏
 /// </summary>
public const string _01120036 = "01120036";
 /// <summary>
 /// 习题作业
 /// </summary>
public const string _01120042 = "01120042";
 /// <summary>
 /// 教学班作业列表功能
 /// </summary>
public const string _01120043 = "01120043";
 /// <summary>
 /// 习题题目展示
 /// </summary>
public const string _01120044 = "01120044";
 /// <summary>
 /// 试卷模块
 /// </summary>
public const string _01120045 = "01120045";
 /// <summary>
 /// 试卷列表功能
 /// </summary>
public const string _01120046 = "01120046";
 /// <summary>
 /// 试卷展示
 /// </summary>
public const string _01120047 = "01120047";
 /// <summary>
 /// 服务商信息展示
 /// </summary>
public const string _01120048 = "01120048";
 /// <summary>
 /// 关于界面
 /// </summary>
public const string _01120049 = "01120049";
 /// <summary>
 /// 意见反馈
 /// </summary>
public const string _01120050 = "01120050";
 /// <summary>
 /// 案例库收藏功能展示；
 /// </summary>
public const string _01120051 = "01120051";
 /// <summary>
 /// 视频库收藏功能列表展示
 /// </summary>
public const string _01120052 = "01120052";
 /// <summary>
 /// 个人中心案例库浏览记录列表功能
 /// </summary>
public const string _01120053 = "01120053";
 /// <summary>
 /// 个人中心视频库浏览记录列表功能
 /// </summary>
public const string _01120054 = "01120054";
 /// <summary>
 /// 流程更正；登录后无需选择课程直接跳转主页
 /// </summary>
public const string _01120055 = "01120055";
 /// <summary>
 /// 在视频库播放界面判断是否已收藏、或已点赞
 /// </summary>
public const string _01120056 = "01120056";
 /// <summary>
 /// 案例库界面判断是否已收藏或点赞；
 /// </summary>
public const string _01120057 = "01120057";
 /// <summary>
 /// 知识点维护
 /// </summary>
public const string _01120058 = "01120058";
 /// <summary>
 /// 论文阅读
 /// </summary>
public const string _01120059 = "01120059";
 /// <summary>
 /// 论文写作过程
 /// </summary>
public const string _01120060 = "01120060";
 /// <summary>
 /// 论文维护
 /// </summary>
public const string _01120061 = "01120061";
 /// <summary>
 /// 论文管理
 /// </summary>
public const string _01120062 = "01120062";
 /// <summary>
 /// 用户引用论文引用观点维护
 /// </summary>
public const string _01120063 = "01120063";
 /// <summary>
 /// 论文查看组
 /// </summary>
public const string _01120064 = "01120064";
 /// <summary>
 /// 论文查看1
 /// </summary>
public const string _01120065 = "01120065";
 /// <summary>
 /// 论文阅读查看
 /// </summary>
public const string _01120066 = "01120066";
 /// <summary>
 /// 论文写作查看
 /// </summary>
public const string _01120067 = "01120067";
 /// <summary>
 /// 专业方向
 /// </summary>
public const string _01120068 = "01120068";
 /// <summary>
 /// 专业方向维护
 /// </summary>
public const string _01120069 = "01120069";
 /// <summary>
 /// 专业方向与论文关系
 /// </summary>
public const string _01120070 = "01120070";
 /// <summary>
 /// 主题收集管理
 /// </summary>
public const string _01120071 = "01120071";
 /// <summary>
 /// 主题维护
 /// </summary>
public const string _01120072 = "01120072";
 /// <summary>
 /// 主题观点维护
 /// </summary>
public const string _01120073 = "01120073";
 /// <summary>
 /// 主题观点关系
 /// </summary>
public const string _01120074 = "01120074";
 /// <summary>
 /// 主题观点类型
 /// </summary>
public const string _01120075 = "01120075";
 /// <summary>
 /// 基础知识管理
 /// </summary>
public const string _01120076 = "01120076";
 /// <summary>
 /// 基本原理维护
 /// </summary>
public const string _01120078 = "01120078";
 /// <summary>
 /// 专业方向2
 /// </summary>
public const string _01120079 = "01120079";
}
 /// <summary>
 /// CM功能(CMFeature)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMFeatureBL
{
public static RelatedActions_CMFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMFeatureDA CMFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMFeatureDA();
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
 public clsCMFeatureBL()
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
if (string.IsNullOrEmpty(clsCMFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFeatureEN._ConnectString);
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
public static DataTable GetDataTable_CMFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMFeatureDA.GetDataTable_CMFeature(strWhereCond);
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
objDT = CMFeatureDA.GetDataTable(strWhereCond);
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
objDT = CMFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = CMFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstByCmFeatureIdLst(List<string> arrCmFeatureIdLst)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFeatureIdLst, true);
 string strWhereCond = string.Format("CmFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMFeatureEN> GetObjLstByCmFeatureIdLstCache(List<string> arrCmFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel =
arrCMFeatureObjLstCache
.Where(x => arrCmFeatureIdLst.Contains(x.CmFeatureId));
return arrCMFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureEN> GetObjLst(string strWhereCond)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
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
public static List<clsCMFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMFeatureEN> GetSubObjLstCache(clsCMFeatureEN objCMFeatureCond)
{
 string strPrjId = objCMFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCMFeatureBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCMFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFeature._AttributeName)
{
if (objCMFeatureCond.IsUpdated(strFldName) == false) continue;
if (objCMFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureCond[strFldName].ToString());
}
else
{
if (objCMFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFeatureCond[strFldName]));
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
public static List<clsCMFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
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
public static List<clsCMFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
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
List<clsCMFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
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
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
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
public static List<clsCMFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
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
public static List<clsCMFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMFeatureEN> arrObjLst = new List<clsCMFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN();
try
{
objCMFeatureEN.CmFeatureId = objRow[conCMFeature.CmFeatureId].ToString().Trim(); //功能Id
objCMFeatureEN.FeatureName = objRow[conCMFeature.FeatureName].ToString().Trim(); //功能名称
objCMFeatureEN.FeatureENName = objRow[conCMFeature.FeatureENName] == DBNull.Value ? null : objRow[conCMFeature.FeatureENName].ToString().Trim(); //功能英文名
objCMFeatureEN.KeyWords = objRow[conCMFeature.KeyWords] == DBNull.Value ? null : objRow[conCMFeature.KeyWords].ToString().Trim(); //关键字
objCMFeatureEN.FeatureDescription = objRow[conCMFeature.FeatureDescription] == DBNull.Value ? null : objRow[conCMFeature.FeatureDescription].ToString().Trim(); //功能说明
objCMFeatureEN.CmParentFeatureId = objRow[conCMFeature.CmParentFeatureId] == DBNull.Value ? null : objRow[conCMFeature.CmParentFeatureId].ToString().Trim(); //父功能Id
objCMFeatureEN.ParentFeatureName = objRow[conCMFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conCMFeature.ParentFeatureName].ToString().Trim(); //父功能名
objCMFeatureEN.CmFeatureTypeId = objRow[conCMFeature.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureEN.CreateUserId = objRow[conCMFeature.CreateUserId].ToString().Trim(); //建立用户Id
objCMFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCMFeature.InUse].ToString().Trim()); //是否在用
objCMFeatureEN.OrderNum = Int32.Parse(objRow[conCMFeature.OrderNum].ToString().Trim()); //序号
objCMFeatureEN.FuncModuleAgcId = objRow[conCMFeature.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMFeatureEN.CmPrjId = objRow[conCMFeature.CmPrjId].ToString().Trim(); //Cm工程Id
objCMFeatureEN.PrjId = objRow[conCMFeature.PrjId].ToString().Trim(); //工程Id
objCMFeatureEN.UpdDate = objRow[conCMFeature.UpdDate] == DBNull.Value ? null : objRow[conCMFeature.UpdDate].ToString().Trim(); //修改日期
objCMFeatureEN.UpdUser = objRow[conCMFeature.UpdUser] == DBNull.Value ? null : objRow[conCMFeature.UpdUser].ToString().Trim(); //修改者
objCMFeatureEN.Memo = objRow[conCMFeature.Memo] == DBNull.Value ? null : objRow[conCMFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureEN.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMFeature(ref clsCMFeatureEN objCMFeatureEN)
{
bool bolResult = CMFeatureDA.GetCMFeature(ref objCMFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureEN GetObjByCmFeatureId(string strCmFeatureId)
{
if (strCmFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMFeatureEN objCMFeatureEN = CMFeatureDA.GetObjByCmFeatureId(strCmFeatureId);
return objCMFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMFeatureEN objCMFeatureEN = CMFeatureDA.GetFirstObj(strWhereCond);
 return objCMFeatureEN;
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
public static clsCMFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMFeatureEN objCMFeatureEN = CMFeatureDA.GetObjByDataRow(objRow);
 return objCMFeatureEN;
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
public static clsCMFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMFeatureEN objCMFeatureEN = CMFeatureDA.GetObjByDataRow(objRow);
 return objCMFeatureEN;
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
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <param name = "lstCMFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFeatureEN GetObjByCmFeatureIdFromList(string strCmFeatureId, List<clsCMFeatureEN> lstCMFeatureObjLst)
{
foreach (clsCMFeatureEN objCMFeatureEN in lstCMFeatureObjLst)
{
if (objCMFeatureEN.CmFeatureId == strCmFeatureId)
{
return objCMFeatureEN;
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
 string strMaxCmFeatureId;
 try
 {
 strMaxCmFeatureId = new clsCMFeatureDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxCmFeatureId;
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
 string strCmFeatureId;
 try
 {
 strCmFeatureId = new clsCMFeatureDA().GetFirstID(strWhereCond);
 return strCmFeatureId;
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
 arrList = CMFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = CMFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFeatureId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMFeatureDA.IsExist(strCmFeatureId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmFeatureId">功能Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmFeatureId, string strOpUser)
{
clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMFeatureEN.UpdUser = strOpUser;
return clsCMFeatureBL.UpdateBySql2(objCMFeatureEN);
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
 bolIsExist = clsCMFeatureDA.IsExistTable();
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
 bolIsExist = CMFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMFeatureEN.CmFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objCMFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],Cm工程Id = [{1}]的数据已经存在!(in clsCMFeatureBL.AddNewRecordBySql2)", objCMFeatureEN.FeatureName,objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMFeatureDA.AddNewRecordBySQL2(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMFeatureEN objCMFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMFeatureEN.CmFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objCMFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],Cm工程Id = [{1}]的数据已经存在!(in clsCMFeatureBL.AddNewRecordBySql2WithReturnKey)", objCMFeatureEN.FeatureName,objCMFeatureEN.CmPrjId);
throw new Exception(strMsg);
}
try
{
string strKey = CMFeatureDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMFeatureEN objCMFeatureEN)
{
try
{
bool bolResult = CMFeatureDA.Update(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "objCMFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMFeatureEN objCMFeatureEN)
{
 if (string.IsNullOrEmpty(objCMFeatureEN.CmFeatureId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMFeatureDA.UpdateBySql2(objCMFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureBL.ReFreshCache(objCMFeatureEN.PrjId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmFeatureId)
{
try
{
 clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);

if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(objCMFeatureEN.CmFeatureId, objCMFeatureEN.UpdUser);
}
if (objCMFeatureEN != null)
{
int intRecNum = CMFeatureDA.DelRecord(strCmFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMFeatureEN.PrjId);
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
/// <param name="strCmFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmFeatureId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
//删除与表:[CMFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMFeature.CmFeatureId,
//strCmFeatureId);
//        clsCMFeatureBL.DelCMFeaturesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFeatureBL.DelRecord(strCmFeatureId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFeatureBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmFeatureId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMFeatureBL.relatedActions != null)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(strCmFeatureId, "UpdRelaTabDate");
}
bool bolResult = CMFeatureDA.DelRecord(strCmFeatureId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmFeatureIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMFeatures(List<string> arrCmFeatureIdLst)
{
if (arrCmFeatureIdLst.Count == 0) return 0;
try
{
if (clsCMFeatureBL.relatedActions != null)
{
foreach (var strCmFeatureId in arrCmFeatureIdLst)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(strCmFeatureId, "UpdRelaTabDate");
}
}
 clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.GetObjByCmFeatureId(arrCmFeatureIdLst[0]);
int intDelRecNum = CMFeatureDA.DelCMFeature(arrCmFeatureIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMFeatureEN.PrjId);
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
public static int DelCMFeaturesByCond(string strWhereCond)
{
try
{
if (clsCMFeatureBL.relatedActions != null)
{
List<string> arrCmFeatureId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmFeatureId in arrCmFeatureId)
{
clsCMFeatureBL.relatedActions.UpdRelaTabDate(strCmFeatureId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conCMFeature.PrjId, strWhereCond);
int intRecNum = CMFeatureDA.DelCMFeature(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMFeature]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmFeatureId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFeatureDA.GetSpecSQLObj();
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
//删除与表:[CMFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFeatureBL.DelRecord(strCmFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFeatureBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMFeatureENS">源对象</param>
 /// <param name = "objCMFeatureENT">目标对象</param>
 public static void CopyTo(clsCMFeatureEN objCMFeatureENS, clsCMFeatureEN objCMFeatureENT)
{
try
{
objCMFeatureENT.CmFeatureId = objCMFeatureENS.CmFeatureId; //功能Id
objCMFeatureENT.FeatureName = objCMFeatureENS.FeatureName; //功能名称
objCMFeatureENT.FeatureENName = objCMFeatureENS.FeatureENName; //功能英文名
objCMFeatureENT.KeyWords = objCMFeatureENS.KeyWords; //关键字
objCMFeatureENT.FeatureDescription = objCMFeatureENS.FeatureDescription; //功能说明
objCMFeatureENT.CmParentFeatureId = objCMFeatureENS.CmParentFeatureId; //父功能Id
objCMFeatureENT.ParentFeatureName = objCMFeatureENS.ParentFeatureName; //父功能名
objCMFeatureENT.CmFeatureTypeId = objCMFeatureENS.CmFeatureTypeId; //功能类型Id
objCMFeatureENT.CreateUserId = objCMFeatureENS.CreateUserId; //建立用户Id
objCMFeatureENT.InUse = objCMFeatureENS.InUse; //是否在用
objCMFeatureENT.OrderNum = objCMFeatureENS.OrderNum; //序号
objCMFeatureENT.FuncModuleAgcId = objCMFeatureENS.FuncModuleAgcId; //功能模块Id
objCMFeatureENT.CmPrjId = objCMFeatureENS.CmPrjId; //Cm工程Id
objCMFeatureENT.PrjId = objCMFeatureENS.PrjId; //工程Id
objCMFeatureENT.UpdDate = objCMFeatureENS.UpdDate; //修改日期
objCMFeatureENT.UpdUser = objCMFeatureENS.UpdUser; //修改者
objCMFeatureENT.Memo = objCMFeatureENS.Memo; //说明
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
 /// <param name = "objCMFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsCMFeatureEN objCMFeatureEN)
{
try
{
objCMFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMFeature.CmFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.CmFeatureId = objCMFeatureEN.CmFeatureId; //功能Id
}
if (arrFldSet.Contains(conCMFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.FeatureName = objCMFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(conCMFeature.FeatureENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.FeatureENName = objCMFeatureEN.FeatureENName == "[null]" ? null :  objCMFeatureEN.FeatureENName; //功能英文名
}
if (arrFldSet.Contains(conCMFeature.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.KeyWords = objCMFeatureEN.KeyWords == "[null]" ? null :  objCMFeatureEN.KeyWords; //关键字
}
if (arrFldSet.Contains(conCMFeature.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.FeatureDescription = objCMFeatureEN.FeatureDescription == "[null]" ? null :  objCMFeatureEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(conCMFeature.CmParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.CmParentFeatureId = objCMFeatureEN.CmParentFeatureId == "[null]" ? null :  objCMFeatureEN.CmParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(conCMFeature.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.ParentFeatureName = objCMFeatureEN.ParentFeatureName == "[null]" ? null :  objCMFeatureEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(conCMFeature.CmFeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.CmFeatureTypeId = objCMFeatureEN.CmFeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(conCMFeature.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.CreateUserId = objCMFeatureEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(conCMFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.InUse = objCMFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCMFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.OrderNum = objCMFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCMFeature.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.FuncModuleAgcId = objCMFeatureEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conCMFeature.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.CmPrjId = objCMFeatureEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conCMFeature.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.PrjId = objCMFeatureEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.UpdDate = objCMFeatureEN.UpdDate == "[null]" ? null :  objCMFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.UpdUser = objCMFeatureEN.UpdUser == "[null]" ? null :  objCMFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureEN.Memo = objCMFeatureEN.Memo == "[null]" ? null :  objCMFeatureEN.Memo; //说明
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
 /// <param name = "objCMFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMFeatureEN objCMFeatureEN)
{
try
{
if (objCMFeatureEN.FeatureENName == "[null]") objCMFeatureEN.FeatureENName = null; //功能英文名
if (objCMFeatureEN.KeyWords == "[null]") objCMFeatureEN.KeyWords = null; //关键字
if (objCMFeatureEN.FeatureDescription == "[null]") objCMFeatureEN.FeatureDescription = null; //功能说明
if (objCMFeatureEN.CmParentFeatureId == "[null]") objCMFeatureEN.CmParentFeatureId = null; //父功能Id
if (objCMFeatureEN.ParentFeatureName == "[null]") objCMFeatureEN.ParentFeatureName = null; //父功能名
if (objCMFeatureEN.UpdDate == "[null]") objCMFeatureEN.UpdDate = null; //修改日期
if (objCMFeatureEN.UpdUser == "[null]") objCMFeatureEN.UpdUser = null; //修改者
if (objCMFeatureEN.Memo == "[null]") objCMFeatureEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMFeatureEN objCMFeatureEN)
{
 CMFeatureDA.CheckPropertyNew(objCMFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMFeatureEN objCMFeatureEN)
{
 CMFeatureDA.CheckProperty4Condition(objCMFeatureEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_CmFeatureId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMFeature.CmFeatureId); 
List<clsCMFeatureEN> arrObjLst = clsCMFeatureBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMFeatureEN objCMFeatureEN = new clsCMFeatureEN()
{
CmFeatureId = "0",
FeatureName = "选[CM功能]..."
};
arrObjLstSel.Insert(0, objCMFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMFeature.CmFeatureId;
objComboBox.DisplayMember = conCMFeature.FeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindDdl_CmFeatureId(System.Web.UI.WebControls.DropDownList objDDL , string strCmPrjId,string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM功能]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMFeature.CmFeatureId); 
IEnumerable<clsCMFeatureEN> arrObjLst = clsCMFeatureBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conCMFeature.CmFeatureId;
objDDL.DataTextField = conCMFeature.FeatureName;
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
public static void BindDdl_CmFeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM功能]...","0");
List<clsCMFeatureEN> arrCMFeatureObjLst = GetAllCMFeatureObjLstCache(strPrjId); 
arrCMFeatureObjLst = arrCMFeatureObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conCMFeature.CmFeatureId;
objDDL.DataTextField = conCMFeature.FeatureName;
objDDL.DataSource = arrCMFeatureObjLst;
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
if (clsCMFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFeatureBL没有刷新缓存机制(clsCMFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFeatureId");
//if (arrCMFeatureObjLstCache == null)
//{
//arrCMFeatureObjLstCache = CMFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFeatureEN GetObjByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMFeatureEN> arrCMFeatureObjLst_Sel =
arrCMFeatureObjLstCache
.Where(x=> x.CmFeatureId == strCmFeatureId 
);
if (arrCMFeatureObjLst_Sel.Count() == 0)
{
   clsCMFeatureEN obj = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCmFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCMFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureNameByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return "";
//获取缓存中的对象列表
clsCMFeatureEN objCMFeature = GetObjByCmFeatureIdCache(strCmFeatureId, strPrjId);
if (objCMFeature == null) return "";
return objCMFeature.FeatureName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strCmFeatureId) == true) return "";
//获取缓存中的对象列表
clsCMFeatureEN objCMFeature = GetObjByCmFeatureIdCache(strCmFeatureId, strPrjId);
if (objCMFeature == null) return "";
return objCMFeature.FeatureName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureEN> GetAllCMFeatureObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsCMFeatureEN> arrCMFeatureObjLstCache = GetObjLstCache(strPrjId); 
return arrCMFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsCMFeatureEN> arrCMFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCMFeatureObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsCMFeatureEN._RefreshTimeLst[clsCMFeatureEN._RefreshTimeLst.Count - 1];
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
if (clsCMFeatureBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMFeatureBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMFeature(CM功能)
 /// 唯一性条件:FeatureName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMFeatureEN objCMFeatureEN)
{
//检测记录是否存在
string strResult = CMFeatureDA.GetUniCondStr(objCMFeatureEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCmFeatureId, string strPrjId)
{
if (strInFldName != conCMFeature.CmFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMFeature._AttributeName));
throw new Exception(strMsg);
}
var objCMFeature = clsCMFeatureBL.GetObjByCmFeatureIdCache(strCmFeatureId, strPrjId);
if (objCMFeature == null) return "";
return objCMFeature[strOutFldName].ToString();
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
int intRecCount = clsCMFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsCMFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMFeatureDA.GetRecCount();
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
int intRecCount = clsCMFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMFeatureEN objCMFeatureCond)
{
 string strPrjId = objCMFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCMFeatureBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCMFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFeature._AttributeName)
{
if (objCMFeatureCond.IsUpdated(strFldName) == false) continue;
if (objCMFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureCond[strFldName].ToString());
}
else
{
if (objCMFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFeatureCond[strFldName]));
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
 List<string> arrList = clsCMFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMFeatureDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFeatureDA.SetFldValue(clsCMFeatureEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMFeatureDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFeatureDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFeatureDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFeatureDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMFeature] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" CmFeatureId char(8) primary key, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) not Null, "); 
 // /**功能英文名*/ 
 strCreateTabCode.Append(" FeatureENName varchar(100) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" KeyWords varchar(500) Null, "); 
 // /**功能说明*/ 
 strCreateTabCode.Append(" FeatureDescription varchar(4000) Null, "); 
 // /**父功能Id*/ 
 strCreateTabCode.Append(" CmParentFeatureId char(8) Null, "); 
 // /**父功能名*/ 
 strCreateTabCode.Append(" ParentFeatureName varchar(500) Null, "); 
 // /**功能类型Id*/ 
 strCreateTabCode.Append(" CmFeatureTypeId char(2) not Null, "); 
 // /**建立用户Id*/ 
 strCreateTabCode.Append(" CreateUserId varchar(18) not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) not Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCmPrjId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCmPrjId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMFeatureEN> arrCMFeatureObjList = new clsCMFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureEN objCMFeature in arrCMFeatureObjList)
{
objCMFeature.OrderNum = intIndex;
UpdateBySql2(objCMFeature);
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
/// 调整所给关键字记录的序号。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCmFeatureId">所给的关键字</param>
/// <param name="strCmPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strCmFeatureId ,string strCmPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CmFeatureId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CmFeatureId
//5、把当前关键字CmFeatureId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CmFeatureId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCmFeatureId = "";    //上一条序号的关键字CmFeatureId
string strNextCmFeatureId = "";    //下一条序号的关键字CmFeatureId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[CmFeatureId],获取相应的序号[OrderNum]。

clsCMFeatureEN objCMFeature = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);

intOrderNum = objCMFeature.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
intTabRecNum = clsCMFeatureBL.GetRecCountByCond(clsCMFeatureEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
//4、获取上一个序号字段的关键字CmFeatureId
strPrevCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevCmFeatureId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CmFeatureId所对应记录的序号减1
//6、把下(上)一个序号关键字CmFeatureId所对应的记录序号加1
clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strPrevCmFeatureId));
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

//4、获取下一个序号字段的关键字CmFeatureId
sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);

strNextCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextCmFeatureId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CmFeatureId所对应记录的序号加1
//6、把下(上)一个序号关键字CmFeatureId所对应的记录序号减1
clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strNextCmFeatureId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strCmPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCMFeature.CmFeatureId, strKeyList);
List<clsCMFeatureEN> arrCMFeatureLst = GetObjLst(strCondition);
foreach (clsCMFeatureEN objCMFeature in arrCMFeatureLst)
{
objCMFeature.OrderNum = objCMFeature.OrderNum + 10000;
UpdateBySql2(objCMFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMFeatureEN> arrCMFeatureObjList = new clsCMFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureEN objCMFeature in arrCMFeatureObjList)
{
objCMFeature.OrderNum = intIndex;
UpdateBySql2(objCMFeature);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCmPrjId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strCmPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCMFeature.CmFeatureId, strKeyList);
List<clsCMFeatureEN> arrCMFeatureLst = GetObjLst(strCondition);
foreach (clsCMFeatureEN objCMFeature in arrCMFeatureLst)
{
objCMFeature.OrderNum = objCMFeature.OrderNum - 10000;
UpdateBySql2(objCMFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsCMFeatureEN> arrCMFeatureObjList = new clsCMFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureEN objCMFeature in arrCMFeatureObjList)
{
objCMFeature.OrderNum = intIndex;
UpdateBySql2(objCMFeature);
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
 /// CM功能(CMFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMFeature : clsCommFun4BLV2
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
clsCMFeatureBL.ReFreshThisCache(strPrjId);
}
}

}