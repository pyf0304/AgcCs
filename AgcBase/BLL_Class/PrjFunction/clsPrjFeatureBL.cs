
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureBL
 表名:PrjFeature(00050322)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:24:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsPrjFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFeatureEN GetObj(this K_FeatureId_PrjFeature myKey)
{
clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.PrjFeatureDA.GetObjByFeatureId(myKey.Value);
return objPrjFeatureEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}]的数据已经存在!(in clsPrjFeatureBL.AddNewRecord)", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjFeatureBL.PrjFeatureDA.AddNewRecordBySQL2(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
public static bool AddRecordEx(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjFeatureEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjFeatureEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能名称(FeatureName)=[{0}])已经存在,不能重复!", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjFeatureEN.AddNewRecord();
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}]的数据已经存在!(in clsPrjFeatureBL.AddNewRecordWithMaxId)", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
string strFeatureId = clsPrjFeatureBL.PrjFeatureDA.AddNewRecordBySQL2WithReturnKey(objPrjFeatureEN);
     objPrjFeatureEN.FeatureId = strFeatureId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
}
return strFeatureId;
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}]的数据已经存在!(in clsPrjFeatureBL.AddNewRecordWithReturnKey)", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
string strKey = clsPrjFeatureBL.PrjFeatureDA.AddNewRecordBySQL2WithReturnKey(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureId(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conPrjFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conPrjFeature.FeatureId);
}
objPrjFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureName(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, conPrjFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, conPrjFeature.FeatureName);
}
objPrjFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureENName(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureENName, 100, conPrjFeature.FeatureENName);
}
objPrjFeatureEN.FeatureENName = strFeatureENName; //功能英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureENName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureENName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureENName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetKeyWords(this clsPrjFeatureEN objPrjFeatureEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conPrjFeature.KeyWords);
}
objPrjFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.KeyWords) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.KeyWords, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.KeyWords] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetDefaButtonName(this clsPrjFeatureEN objPrjFeatureEN, string strDefaButtonName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaButtonName, 30, conPrjFeature.DefaButtonName);
}
objPrjFeatureEN.DefaButtonName = strDefaButtonName; //默认按钮名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.DefaButtonName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.DefaButtonName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.DefaButtonName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetDefaButtonName4Mvc(this clsPrjFeatureEN objPrjFeatureEN, string strDefaButtonName4Mvc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaButtonName4Mvc, 30, conPrjFeature.DefaButtonName4Mvc);
}
objPrjFeatureEN.DefaButtonName4Mvc = strDefaButtonName4Mvc; //默认按钮名4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.DefaButtonName4Mvc) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.DefaButtonName4Mvc, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.DefaButtonName4Mvc] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetRegionTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conPrjFeature.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conPrjFeature.RegionTypeId);
}
objPrjFeatureEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.RegionTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.RegionTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.RegionTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetGroupName(this clsPrjFeatureEN objPrjFeatureEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, conPrjFeature.GroupName);
}
objPrjFeatureEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.GroupName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.GroupName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.GroupName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureDescription(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conPrjFeature.FeatureDescription);
}
objPrjFeatureEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureDescription) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureDescription, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureDescription] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetInOutTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, conPrjFeature.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conPrjFeature.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conPrjFeature.InOutTypeId);
}
objPrjFeatureEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.InOutTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.InOutTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.InOutTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetIsNeedField(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedField, string strComparisonOp="")
	{
objPrjFeatureEN.IsNeedField = bolIsNeedField; //是否需要字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.IsNeedField) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.IsNeedField, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.IsNeedField] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetIsNeedTabFeature(this clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedTabFeature, string strComparisonOp="")
	{
objPrjFeatureEN.IsNeedTabFeature = bolIsNeedTabFeature; //是否需要表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.IsNeedTabFeature) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.IsNeedTabFeature, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.IsNeedTabFeature] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetParentFeatureId(this clsPrjFeatureEN objPrjFeatureEN, string strParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, conPrjFeature.ParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, conPrjFeature.ParentFeatureId);
}
objPrjFeatureEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.ParentFeatureId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.ParentFeatureId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.ParentFeatureId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetParentFeatureName(this clsPrjFeatureEN objPrjFeatureEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, conPrjFeature.ParentFeatureName);
}
objPrjFeatureEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.ParentFeatureName) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.ParentFeatureName, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.ParentFeatureName] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFunctionGroupId(this clsPrjFeatureEN objPrjFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, conPrjFeature.FunctionGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, conPrjFeature.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, conPrjFeature.FunctionGroupId);
}
objPrjFeatureEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FunctionGroupId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FunctionGroupId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FunctionGroupId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetFeatureTypeId(this clsPrjFeatureEN objPrjFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, conPrjFeature.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, conPrjFeature.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, conPrjFeature.FeatureTypeId);
}
objPrjFeatureEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.FeatureTypeId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.FeatureTypeId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.FeatureTypeId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetCreateUserId(this clsPrjFeatureEN objPrjFeatureEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conPrjFeature.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conPrjFeature.CreateUserId);
}
objPrjFeatureEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.CreateUserId) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.CreateUserId, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.CreateUserId] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetInUse(this clsPrjFeatureEN objPrjFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objPrjFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.InUse) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.InUse, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.InUse] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetOrderNum(this clsPrjFeatureEN objPrjFeatureEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conPrjFeature.OrderNum);
objPrjFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.OrderNum) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.OrderNum, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.OrderNum] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetUpdDate(this clsPrjFeatureEN objPrjFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjFeature.UpdDate);
}
objPrjFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.UpdDate) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.UpdDate, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.UpdDate] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetUpdUser(this clsPrjFeatureEN objPrjFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjFeature.UpdUser);
}
objPrjFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.UpdUser) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.UpdUser, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.UpdUser] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureEN SetMemo(this clsPrjFeatureEN objPrjFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjFeature.Memo);
}
objPrjFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureEN.dicFldComparisonOp.ContainsKey(conPrjFeature.Memo) == false)
{
objPrjFeatureEN.dicFldComparisonOp.Add(conPrjFeature.Memo, strComparisonOp);
}
else
{
objPrjFeatureEN.dicFldComparisonOp[conPrjFeature.Memo] = strComparisonOp;
}
}
return objPrjFeatureEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjFeatureEN objPrjFeatureEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjFeatureEN.CheckPropertyNew();
clsPrjFeatureEN objPrjFeatureCond = new clsPrjFeatureEN();
string strCondition = objPrjFeatureCond
.SetFeatureId(objPrjFeatureEN.FeatureId, "<>")
.SetFeatureName(objPrjFeatureEN.FeatureName, "=")
.GetCombineCondition();
objPrjFeatureEN._IsCheckProperty = true;
bool bolIsExist = clsPrjFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FeatureName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjFeatureEN.Update();
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
 /// <param name = "objPrjFeature">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjFeatureEN objPrjFeature)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjFeatureEN objPrjFeatureCond = new clsPrjFeatureEN();
string strCondition = objPrjFeatureCond
.SetFeatureName(objPrjFeature.FeatureName, "=")
.GetCombineCondition();
objPrjFeature._IsCheckProperty = true;
bool bolIsExist = clsPrjFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjFeature.FeatureId = clsPrjFeatureBL.GetFirstID_S(strCondition);
objPrjFeature.UpdateWithCondition(strCondition);
}
else
{
objPrjFeature.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
objPrjFeature.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFeatureEN objPrjFeatureEN)
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFeatureBL.PrjFeatureDA.UpdateBySql2(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFeatureEN objPrjFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFeatureBL.PrjFeatureDA.UpdateBySql2(objPrjFeatureEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFeatureEN objPrjFeatureEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjFeatureBL.PrjFeatureDA.UpdateBySqlWithCondition(objPrjFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFeatureEN objPrjFeatureEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjFeatureBL.PrjFeatureDA.UpdateBySqlWithConditionTransaction(objPrjFeatureEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjFeatureEN objPrjFeatureEN)
{
try
{
int intRecNum = clsPrjFeatureBL.PrjFeatureDA.DelRecord(objPrjFeatureEN.FeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureENS">源对象</param>
 /// <param name = "objPrjFeatureENT">目标对象</param>
 public static void CopyTo(this clsPrjFeatureEN objPrjFeatureENS, clsPrjFeatureEN objPrjFeatureENT)
{
try
{
objPrjFeatureENT.FeatureId = objPrjFeatureENS.FeatureId; //功能Id
objPrjFeatureENT.FeatureName = objPrjFeatureENS.FeatureName; //功能名称
objPrjFeatureENT.FeatureENName = objPrjFeatureENS.FeatureENName; //功能英文名
objPrjFeatureENT.KeyWords = objPrjFeatureENS.KeyWords; //关键字
objPrjFeatureENT.DefaButtonName = objPrjFeatureENS.DefaButtonName; //默认按钮名
objPrjFeatureENT.DefaButtonName4Mvc = objPrjFeatureENS.DefaButtonName4Mvc; //默认按钮名4Mvc
objPrjFeatureENT.RegionTypeId = objPrjFeatureENS.RegionTypeId; //区域类型Id
objPrjFeatureENT.GroupName = objPrjFeatureENS.GroupName; //组名
objPrjFeatureENT.FeatureDescription = objPrjFeatureENS.FeatureDescription; //功能说明
objPrjFeatureENT.InOutTypeId = objPrjFeatureENS.InOutTypeId; //INOUT类型ID
objPrjFeatureENT.IsNeedField = objPrjFeatureENS.IsNeedField; //是否需要字段
objPrjFeatureENT.IsNeedTabFeature = objPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
objPrjFeatureENT.ParentFeatureId = objPrjFeatureENS.ParentFeatureId; //父功能Id
objPrjFeatureENT.ParentFeatureName = objPrjFeatureENS.ParentFeatureName; //父功能名
objPrjFeatureENT.FunctionGroupId = objPrjFeatureENS.FunctionGroupId; //函数组Id
objPrjFeatureENT.FeatureTypeId = objPrjFeatureENS.FeatureTypeId; //功能类型Id
objPrjFeatureENT.CreateUserId = objPrjFeatureENS.CreateUserId; //建立用户Id
objPrjFeatureENT.InUse = objPrjFeatureENS.InUse; //是否在用
objPrjFeatureENT.OrderNum = objPrjFeatureENS.OrderNum; //序号
objPrjFeatureENT.UpdDate = objPrjFeatureENS.UpdDate; //修改日期
objPrjFeatureENT.UpdUser = objPrjFeatureENS.UpdUser; //修改者
objPrjFeatureENT.Memo = objPrjFeatureENS.Memo; //说明
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
 /// <param name = "objPrjFeatureENS">源对象</param>
 /// <returns>目标对象=>clsPrjFeatureEN:objPrjFeatureENT</returns>
 public static clsPrjFeatureEN CopyTo(this clsPrjFeatureEN objPrjFeatureENS)
{
try
{
 clsPrjFeatureEN objPrjFeatureENT = new clsPrjFeatureEN()
{
FeatureId = objPrjFeatureENS.FeatureId, //功能Id
FeatureName = objPrjFeatureENS.FeatureName, //功能名称
FeatureENName = objPrjFeatureENS.FeatureENName, //功能英文名
KeyWords = objPrjFeatureENS.KeyWords, //关键字
DefaButtonName = objPrjFeatureENS.DefaButtonName, //默认按钮名
DefaButtonName4Mvc = objPrjFeatureENS.DefaButtonName4Mvc, //默认按钮名4Mvc
RegionTypeId = objPrjFeatureENS.RegionTypeId, //区域类型Id
GroupName = objPrjFeatureENS.GroupName, //组名
FeatureDescription = objPrjFeatureENS.FeatureDescription, //功能说明
InOutTypeId = objPrjFeatureENS.InOutTypeId, //INOUT类型ID
IsNeedField = objPrjFeatureENS.IsNeedField, //是否需要字段
IsNeedTabFeature = objPrjFeatureENS.IsNeedTabFeature, //是否需要表功能
ParentFeatureId = objPrjFeatureENS.ParentFeatureId, //父功能Id
ParentFeatureName = objPrjFeatureENS.ParentFeatureName, //父功能名
FunctionGroupId = objPrjFeatureENS.FunctionGroupId, //函数组Id
FeatureTypeId = objPrjFeatureENS.FeatureTypeId, //功能类型Id
CreateUserId = objPrjFeatureENS.CreateUserId, //建立用户Id
InUse = objPrjFeatureENS.InUse, //是否在用
OrderNum = objPrjFeatureENS.OrderNum, //序号
UpdDate = objPrjFeatureENS.UpdDate, //修改日期
UpdUser = objPrjFeatureENS.UpdUser, //修改者
Memo = objPrjFeatureENS.Memo, //说明
};
 return objPrjFeatureENT;
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
public static void CheckPropertyNew(this clsPrjFeatureEN objPrjFeatureEN)
{
 clsPrjFeatureBL.PrjFeatureDA.CheckPropertyNew(objPrjFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjFeatureEN objPrjFeatureEN)
{
 clsPrjFeatureBL.PrjFeatureDA.CheckProperty4Condition(objPrjFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjFeatureEN objPrjFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureId, objPrjFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureName, objPrjFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureENName) == true)
{
string strComparisonOpFeatureENName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureENName, objPrjFeatureCond.FeatureENName, strComparisonOpFeatureENName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.KeyWords, objPrjFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.DefaButtonName) == true)
{
string strComparisonOpDefaButtonName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.DefaButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.DefaButtonName, objPrjFeatureCond.DefaButtonName, strComparisonOpDefaButtonName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.DefaButtonName4Mvc) == true)
{
string strComparisonOpDefaButtonName4Mvc = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.DefaButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.DefaButtonName4Mvc, objPrjFeatureCond.DefaButtonName4Mvc, strComparisonOpDefaButtonName4Mvc);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.RegionTypeId, objPrjFeatureCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.GroupName) == true)
{
string strComparisonOpGroupName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.GroupName, objPrjFeatureCond.GroupName, strComparisonOpGroupName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureDescription, objPrjFeatureCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.InOutTypeId, objPrjFeatureCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.IsNeedField) == true)
{
if (objPrjFeatureCond.IsNeedField == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.IsNeedField);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.IsNeedField);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.IsNeedTabFeature) == true)
{
if (objPrjFeatureCond.IsNeedTabFeature == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.IsNeedTabFeature);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.IsNeedTabFeature);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.ParentFeatureId, objPrjFeatureCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.ParentFeatureName, objPrjFeatureCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FunctionGroupId, objPrjFeatureCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.FeatureTypeId, objPrjFeatureCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.CreateUserId, objPrjFeatureCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.InUse) == true)
{
if (objPrjFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFeature.InUse);
}
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjFeature.OrderNum, objPrjFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.UpdDate, objPrjFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.UpdUser, objPrjFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjFeatureCond.IsUpdated(conPrjFeature.Memo) == true)
{
string strComparisonOpMemo = objPrjFeatureCond.dicFldComparisonOp[conPrjFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeature.Memo, objPrjFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjFeature(功能), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjFeatureEN objPrjFeatureEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjFeatureEN == null) return true;
if (objPrjFeatureEN.FeatureId == null || objPrjFeatureEN.FeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
if (clsPrjFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FeatureId !=  '{0}'", objPrjFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
if (clsPrjFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjFeature(功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjFeatureEN objPrjFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjFeatureEN == null) return "";
if (objPrjFeatureEN.FeatureId == null || objPrjFeatureEN.FeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FeatureId !=  '{0}'", objPrjFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FeatureName = '{0}'", objPrjFeatureEN.FeatureName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjFeature
{
public virtual bool UpdRelaTabDate(string strFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumPrjFeature
{
 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// </summary>
public const string _0004 = "0004";
 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入-Sim
 /// </summary>
public const string _0005 = "0005";
 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0006 = "0006";
 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0007 = "0007";
 /// <summary>
 /// 根据条件获取一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0008 = "0008";
 /// <summary>
 /// 根据条件获取一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击(带排除)
 /// </summary>
public const string _0010 = "0010";
 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取
 /// </summary>
public const string _0011 = "0011";
 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0012 = "0012";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0014 = "0014";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0015 = "0015";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0016 = "0016";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0017 = "0017";
 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0018 = "0018";
 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0019 = "0019";
 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0020 = "0020";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0021 = "0021";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0022 = "0022";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0023 = "0023";
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// </summary>
public const string _0024 = "0024";
 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0025 = "0025";
 /// <summary>
 /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0026 = "0026";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0027 = "0027";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检(带排除)
 /// </summary>
public const string _0028 = "0028";
 /// <summary>
 /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击.
 /// </summary>
public const string _0029 = "0029";
 /// <summary>
 /// 根据条件获取对象列表,带排除
 /// </summary>
public const string _0030 = "0030";
 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// </summary>
public const string _0031 = "0031";
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示
 /// </summary>
public const string _0032 = "0032";
 /// <summary>
 /// 根据关键字工获取相关对象,用对象的形式表示.
 /// </summary>
public const string _0033 = "0033";
 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程College_SelectOne来获取
 /// </summary>
public const string _0034 = "0034";
 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// </summary>
public const string _0035 = "0035";
 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// </summary>
public const string _0036 = "0036";
 /// <summary>
 /// 把DataRow转换成记录对象
 /// </summary>
public const string _0037 = "0037";
 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// </summary>
public const string _0038 = "0038";
 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// </summary>
public const string _0039 = "0039";
 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// </summary>
public const string _0040 = "0040";
 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// </summary>
public const string _0041 = "0041";
 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// </summary>
public const string _0042 = "0042";
 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// </summary>
public const string _0043 = "0043";
 /// <summary>
 /// 判断是否存在某一条件的记录
 /// </summary>
public const string _0044 = "0044";
 /// <summary>
 /// 检查是否存在当前表
 /// </summary>
public const string _0045 = "0045";
 /// <summary>
 /// 添加新记录
 /// </summary>
public const string _0046 = "0046";
 /// <summary>
 /// 通过SQL命令来插入记录
 /// </summary>
public const string _0047 = "0047";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式
 /// </summary>
public const string _0048 = "0048";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值
 /// </summary>
public const string _0049 = "0049";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,进行事务处理
 /// </summary>
public const string _0050 = "0050";
 /// <summary>
 /// 通过SQL命令来插入记录,带事务处理
 /// </summary>
public const string _0051 = "0051";
 /// <summary>
 /// 通过SQL命令来插入记录,该方式是优化方式,带事务处理
 /// </summary>
public const string _0052 = "0052";
 /// <summary>
 /// 通过存储过程来插入记录
 /// </summary>
public const string _0053 = "0053";
 /// <summary>
 /// 把多条记录同时插入到表中
 /// </summary>
public const string _0054 = "0054";
 /// <summary>
 /// 通过ADO修改记录
 /// </summary>
public const string _0055 = "0055";
 /// <summary>
 /// 通过存储过程(StoreProcedure)来修改记录
 /// </summary>
public const string _0056 = "0056";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式
 /// </summary>
public const string _0057 = "0057";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是优化方式
 /// </summary>
public const string _0058 = "0058";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// </summary>
public const string _0059 = "0059";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// </summary>
public const string _0060 = "0060";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是非优化方式.(带事务处理)
 /// </summary>
public const string _0061 = "0061";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// </summary>
public const string _0062 = "0062";
 /// <summary>
 /// 删除关键字所指定的记录,通过存储过程(SP)来删除
 /// </summary>
public const string _0063 = "0063";
 /// <summary>
 /// 删除关键字所指的记录,使用事务
 /// </summary>
public const string _0064 = "0064";
 /// <summary>
 /// 同时删除多条记录,删除给定关键字列表的记录
 /// </summary>
public const string _0065 = "0065";
 /// <summary>
 /// 删除关键字所指定的记录
 /// </summary>
public const string _0066 = "0066";
 /// <summary>
 /// 删除满足条件的多条记录
 /// </summary>
public const string _0067 = "0067";
 /// <summary>
 /// 删除满足条件的多条记录,同时处理事务
 /// </summary>
public const string _0068 = "0068";
 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// </summary>
public const string _0069 = "0069";
 /// <summary>
 /// 把同一个类的对象,复制到另一个对象(简单)
 /// </summary>
public const string _0070 = "0070";
 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象
 /// </summary>
public const string _0071 = "0071";
 /// <summary>
 /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制
 /// </summary>
public const string _0072 = "0072";
 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// </summary>
public const string _0073 = "0073";
 /// <summary>
 /// 专门针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// </summary>
public const string _0074 = "0074";
 /// <summary>
 /// 检查对象字段值是否合法,1)检查字段值长度是否超长;2)检查属性是否包含Sql注入等非法字符.
 /// </summary>
public const string _0075 = "0075";
 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// </summary>
public const string _0076 = "0076";
 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// </summary>
public const string _0077 = "0077";
 /// <summary>
 /// 检查唯一性(Uniqueness), 如果不唯一,即存在相同的记录,就返回False
 /// </summary>
public const string _0078 = "0078";
 /// <summary>
 /// 获取唯一性条件串(Uniqueness)
 /// </summary>
public const string _0079 = "0079";
 /// <summary>
 /// 把Null数据转换成String型,如果给定的对象不是Null,就直接返回
 /// </summary>
public const string _0080 = "0080";
 /// <summary>
 /// 把给定的异常对象存储到日志中去
 /// </summary>
public const string _0081 = "0081";
 /// <summary>
 /// 把给定的异常对象存储到日志中去(含模块名)
 /// </summary>
public const string _0082 = "0082";
 /// <summary>
 /// 获取给定表的记录数, 该表与当前类不相关
 /// </summary>
public const string _0083 = "0083";
 /// <summary>
 /// 获取给定表中满足条件的记录数, 该表与当前类不相关
 /// </summary>
public const string _0084 = "0084";
 /// <summary>
 /// 获取当前表的记录数.该表与当前类相关
 /// </summary>
public const string _0085 = "0085";
 /// <summary>
 /// 获取当前表中满足条件的记录数, 该表与当前类相关
 /// </summary>
public const string _0086 = "0086";
 /// <summary>
 /// 获取给定表中的符合条件的某字段的值,以列表返回
 /// </summary>
public const string _0087 = "0087";
 /// <summary>
 /// 获取当前表中的符合条件的某字段的值,以列表返回
 /// </summary>
public const string _0088 = "0088";
 /// <summary>
 /// 获取当前表中的符合条件的某字段的值,以列表返回(去除重复值)
 /// </summary>
public const string _0089 = "0089";
 /// <summary>
 /// 设置当前表中的符合条件的某字段的值
 /// </summary>
public const string _0090 = "0090";
 /// <summary>
 /// 获取SQL服务器连接对象(静态)
 /// </summary>
public const string _0091 = "0091";
 /// <summary>
 /// 获取SQL服务器连接对象
 /// </summary>
public const string _0092 = "0092";
 /// <summary>
 /// Copy_根据条件获取一定范围数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// </summary>
public const string _0093 = "0093";
 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0094 = "0094";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// </summary>
public const string _0095 = "0095";
 /// <summary>
 /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时可以决定是否检查SQL攻击
 /// </summary>
public const string _0096 = "0096";
 /// <summary>
 /// 构造函数
 /// </summary>
public const string _0097 = "0097";
 /// <summary>
 /// 根据条件获取顶部对象列表
 /// </summary>
public const string _0098 = "0098";
 /// <summary>
 /// 根据条件获取一定范围对象列表
 /// </summary>
public const string _0099 = "0099";
 /// <summary>
 /// 根据条件获取对象列表
 /// </summary>
public const string _0100 = "0100";
 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// </summary>
public const string _0101 = "0101";
 /// <summary>
 /// 根据关键字列表获取相关对象列表
 /// </summary>
public const string _0102 = "0102";
 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// </summary>
public const string _0103 = "0103";
 /// <summary>
 /// 通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// </summary>
public const string _0104 = "0104";
 /// <summary>
 /// 通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// </summary>
public const string _0105 = "0105";
 /// <summary>
 /// 把对象转换成简化对象
 /// </summary>
public const string _0106 = "0106";
 /// <summary>
 /// 把简化对象转换成对象
 /// </summary>
public const string _0107 = "0107";
 /// <summary>
 /// 把简化对象转换成对象.专门针对修改记录，即脏字段才复制
 /// </summary>
public const string _0108 = "0108";
 /// <summary>
 /// 把对象列表转换成简化对象列表
 /// </summary>
public const string _0109 = "0109";
 /// <summary>
 /// 绑定基于Win的下拉框
 /// </summary>
public const string _0110 = "0110";
 /// <summary>
 /// 绑定基于Web的下拉框
 /// </summary>
public const string _0111 = "0111";
 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// </summary>
public const string _0112 = "0112";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// </summary>
public const string _0113 = "0113";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.(再试一次)
 /// </summary>
public const string _0114 = "0114";
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// </summary>
public const string _0115 = "0115";
 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// </summary>
public const string _0116 = "0116";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
 /// </summary>
public const string _0117 = "0117";
 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.(一次)
 /// </summary>
public const string _0118 = "0118";
 /// <summary>
 /// 序列化一个对象列表到Xml字符串
 /// </summary>
public const string _0119 = "0119";
 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// </summary>
public const string _0120 = "0120";
 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// </summary>
public const string _0121 = "0121";
 /// <summary>
 /// 序列化一个对象到XmlWriter
 /// </summary>
public const string _0122 = "0122";
 /// <summary>
 /// 从XML串中获取一个对象列表
 /// </summary>
public const string _0123 = "0123";
 /// <summary>
 /// 从XML文件中获取一个对象列表
 /// </summary>
public const string _0124 = "0124";
 /// <summary>
 /// 读XmlReader到一个对象
 /// </summary>
public const string _0125 = "0125";
 /// <summary>
 /// 读Xml字符串到一个对象
 /// </summary>
public const string _0126 = "0126";
 /// <summary>
 /// 序列化一个对象到Xml字符串
 /// </summary>
public const string _0127 = "0127";
 /// <summary>
 /// 获取当前类的相关表名
 /// </summary>
public const string _0128 = "0128";
 /// <summary>
 /// 定义对象:专门在逻辑层用于处理缓存等公共函数的对象
 /// </summary>
public const string _0129 = "0129";
 /// <summary>
 /// 定义常量:专门在逻辑层用于处理XML的常量
 /// </summary>
public const string _0130 = "0130";
 /// <summary>
 /// 定义缓存对象列表:专门在逻辑层用于处理缓存的对象列表
 /// </summary>
public const string _0131 = "0131";
 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// </summary>
public const string _0132 = "0132";
 /// <summary>
 /// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
 /// </summary>
public const string _0133 = "0133";
 /// <summary>
 /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
 /// </summary>
public const string _0134 = "0134";
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集
 /// </summary>
public const string _0135 = "0135";
 /// <summary>
 /// 添加
 /// </summary>
public const string AddNewRecord_0136 = "0136";
 /// <summary>
 /// 修改
 /// </summary>
public const string UpdateRecord_0137 = "0137";
 /// <summary>
 /// 删除
 /// </summary>
public const string DelRecord_0138 = "0138";
 /// <summary>
 /// 查询
 /// </summary>
public const string Query_0139 = "0139";
 /// <summary>
 /// 查询并显示
 /// </summary>
public const string _0140 = "0140";
 /// <summary>
 /// 复制记录
 /// </summary>
public const string CopyRecord_0141 = "0141";
 /// <summary>
 /// 调整次序
 /// </summary>
public const string AdjustOrderNum_0142 = "0142";
 /// <summary>
 /// 导出Excel
 /// </summary>
public const string ExportToFile_0143 = "0143";
 /// <summary>
 /// 设置导出字段
 /// </summary>
public const string SetExportExcel4User_0144 = "0144";
 /// <summary>
 /// 初始化列表缓存.
 /// </summary>
public const string _0145 = "0145";
 /// <summary>
 /// 刷新缓存.把当前表的缓存清空.
 /// </summary>
public const string _0146 = "0146";
 /// <summary>
 /// 根据条件获取对象列表,返回JSON串
 /// </summary>
public const string _0147 = "0147";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string SetFieldValue_0148 = "0148";
 /// <summary>
 /// 界面初始化
 /// </summary>
public const string _0149 = "0149";
 /// <summary>
 /// 权限管理
 /// </summary>
public const string _0150 = "0150";
 /// <summary>
 /// 定义字段控件属性
 /// </summary>
public const string _0151 = "0151";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string BindDdl_0152 = "0152";
 /// <summary>
 /// 校验控件值
 /// </summary>
public const string _0153 = "0153";
 /// <summary>
 /// 设置控件状态
 /// </summary>
public const string _0154 = "0154";
 /// <summary>
 /// 任务队列
 /// </summary>
public const string _0155 = "0155";
 /// <summary>
 /// 用户控件初始化
 /// </summary>
public const string _0156 = "0156";
 /// <summary>
 /// 标志删除
 /// </summary>
public const string DelRecordBySign_0157 = "0157";
 /// <summary>
 /// 恢复删除
 /// </summary>
public const string UnDelRecordBySign_0158 = "0158";
 /// <summary>
 /// 移顶00
 /// </summary>
public const string GoTop_0159 = "0159";
 /// <summary>
 /// 上移00
 /// </summary>
public const string UpMove_0160 = "0160";
 /// <summary>
 /// 下移00
 /// </summary>
public const string DownMove_0161 = "0161";
 /// <summary>
 /// 移底00
 /// </summary>
public const string GoButton_0162 = "0162";
 /// <summary>
 /// 重序00
 /// </summary>
public const string ReOrder_0163 = "0163";
 /// <summary>
 /// 添加-弹出层
 /// </summary>
public const string AddRecord_Popup_0164 = "0164";
 /// <summary>
 /// 修改-弹出层
 /// </summary>
public const string UpdateRecord_Popup_0165 = "0165";
 /// <summary>
 /// 批量修改
 /// </summary>
public const string BatchUpdateRecord_0166 = "0166";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string Tab_AdjustOrderNum_0167 = "0167";
 /// <summary>
 /// 根据标志删除
 /// </summary>
public const string Tab_DelRecordBySign_0168 = "0168";
 /// <summary>
 /// 恢复删除
 /// </summary>
public const string Tab_UnDelRecordBySign_0169 = "0169";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string Tab_SetFieldValue_0170 = "0170";
 /// <summary>
 /// XML相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0171 = "0171";
 /// <summary>
 /// 表相关事务操作
 /// </summary>
public const string Tab_TransEvent_0172 = "0172";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string Tab_BindDdl_0173 = "0173";
 /// <summary>
 /// 修改Gv
 /// </summary>
public const string UpdateRecord_Gv_0174 = "0174";
 /// <summary>
 /// 删除Gv
 /// </summary>
public const string DelRecord_Gv_0175 = "0175";
 /// <summary>
 /// 详细信息_Gv
 /// </summary>
public const string DetailRecord_Gv_0181 = "0181";
 /// <summary>
 /// 选择记录_Gv
 /// </summary>
public const string SelectRecord_Gv_0182 = "0182";
 /// <summary>
 /// 添加-关键字自增
 /// </summary>
public const string AddNewRecordWithMaxId_0183 = "0183";
 /// <summary>
 /// 删除
 /// </summary>
public const string DelRecord_0184 = "0184";
 /// <summary>
 /// 查询
 /// </summary>
public const string Query_0186 = "0186";
 /// <summary>
 /// 根据标志删除
 /// </summary>
public const string Tab_DelRecordBySign_0190 = "0190";
 /// <summary>
 /// XML相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0192 = "0192";
 /// <summary>
 /// 事务操作
 /// </summary>
public const string Tab_TransEvent_0193 = "0193";
 /// <summary>
 /// 导出Excel
 /// </summary>
public const string ExportToFile_0196 = "0196";
 /// <summary>
 /// 添加
 /// </summary>
public const string AddNewRecord_0197 = "0197";
 /// <summary>
 /// 复制记录
 /// </summary>
public const string CopyRecord_0198 = "0198";
 /// <summary>
 /// 修改
 /// </summary>
public const string UpdateRecord_0199 = "0199";
 /// <summary>
 /// 获取对象
 /// </summary>
public const string _0200 = "0200";
 /// <summary>
 /// 获取对象列表
 /// </summary>
public const string _0201 = "0201";
 /// <summary>
 /// 检查表关键字是否合法
 /// </summary>
public const string _0202 = "0202";
 /// <summary>
 /// 获取SQL服务器连接对象
 /// </summary>
public const string _0203 = "0203";
 /// <summary>
 /// 获取数据集
 /// </summary>
public const string _0204 = "0204";
 /// <summary>
 /// 获取数据表
 /// </summary>
public const string _0205 = "0205";
 /// <summary>
 /// 获取字符串长度
 /// </summary>
public const string _0206 = "0206";
 /// <summary>
 /// 检查唯一性
 /// </summary>
public const string _0207 = "0207";
 /// <summary>
 /// 把Null数据转换成相应类型
 /// </summary>
public const string _0208 = "0208";
 /// <summary>
 /// 日志操作
 /// </summary>
public const string _0209 = "0209";
 /// <summary>
 /// 设置字段值
 /// </summary>
public const string Tab_SetFieldValue_0210 = "0210";
 /// <summary>
 /// 获取表的记录数
 /// </summary>
public const string _0211 = "0211";
 /// <summary>
 /// 获取字段值
 /// </summary>
public const string Tab_SetFieldValue_0212 = "0212";
 /// <summary>
 /// 把DataRow转换成对象
 /// </summary>
public const string _0213 = "0213";
 /// <summary>
 /// 构造函数
 /// </summary>
public const string _0214 = "0214";
 /// <summary>
 /// 定义属性
 /// </summary>
public const string _0215 = "0215";
 /// <summary>
 /// 获取关键字、名称
 /// </summary>
public const string _0216 = "0216";
 /// <summary>
 /// 定义字段常量
 /// </summary>
public const string _0217 = "0217";
 /// <summary>
 /// Json相关操作
 /// </summary>
public const string Tab_XMLRelaOP_0218 = "0218";
 /// <summary>
 /// 条件串
 /// </summary>
public const string Tab_XMLRelaOP_0219 = "0219";
 /// <summary>
 /// 数据同步
 /// </summary>
public const string Tab_XMLRelaOP_0220 = "0220";
 /// <summary>
 /// 绑定下拉框
 /// </summary>
public const string Tab_BindDdl_0221 = "0221";
 /// <summary>
 /// 缓存操作
 /// </summary>
public const string _0222 = "0222";
 /// <summary>
 /// 获取最大关键字Id
 /// </summary>
public const string _0223 = "0223";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string AdjustOrderNum_0224 = "0224";
 /// <summary>
 /// 排序函数
 /// </summary>
public const string AdjustOrderNum_0225 = "0225";
 /// <summary>
 /// 检查约束
 /// </summary>
public const string _0226 = "0226";
 /// <summary>
 /// 检查表字段
 /// </summary>
public const string _0227 = "0227";
 /// <summary>
 /// 判断是否存在记录
 /// </summary>
public const string _0228 = "0228";
 /// <summary>
 /// 测试
 /// </summary>
public const string _0229 = "0229";
 /// <summary>
 /// 定义枚举常量
 /// </summary>
public const string _0230 = "0230";
 /// <summary>
 /// 打印区域定义
 /// </summary>
public const string _0231 = "0231";
 /// <summary>
 /// 绑定列表
 /// </summary>
public const string Tab_BindList_0232 = "0232";
 /// <summary>
 /// 权限管理
 /// </summary>
public const string _0233 = "0233";
 /// <summary>
 /// 状态管理
 /// </summary>
public const string _0234 = "0234";
 /// <summary>
 /// 页面导入
 /// </summary>
public const string _0235 = "0235";
 /// <summary>
 /// 编辑
 /// </summary>
public const string EditRecord_0236 = "0236";
 /// <summary>
 /// 获取设置页面数据
 /// </summary>
public const string _0237 = "0237";
 /// <summary>
 /// 区域代码生成
 /// </summary>
public const string Tab_XMLRelaOP_0238 = "0238";
 /// <summary>
 /// 详细信息
 /// </summary>
public const string DetailRecord_0239 = "0239";
 /// <summary>
 /// 自定义功能
 /// </summary>
public const string DefaultFeature_0240 = "0240";
 /// <summary>
 /// 重序00
 /// </summary>
public const string Tab_ReOrder_1187 = "1187";
 /// <summary>
 /// 移底00
 /// </summary>
public const string Tab_GoButton_1188 = "1188";
 /// <summary>
 /// 下移00
 /// </summary>
public const string Tab_DownMove_1189 = "1189";
 /// <summary>
 /// 移顶00
 /// </summary>
public const string Tab_GoTop_1194 = "1194";
 /// <summary>
 /// 上移00
 /// </summary>
public const string Tab_UpMove_1195 = "1195";
 /// <summary>
 /// 调整记录次序
 /// </summary>
public const string AdjustOrderNum_1196 = "1196";
}
 /// <summary>
 /// 功能(PrjFeature)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjFeatureBL
{
public static RelatedActions_PrjFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjFeatureDA PrjFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjFeatureDA();
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
 public clsPrjFeatureBL()
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
if (string.IsNullOrEmpty(clsPrjFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFeatureEN._ConnectString);
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
public static DataTable GetDataTable_PrjFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjFeatureDA.GetDataTable_PrjFeature(strWhereCond);
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
objDT = PrjFeatureDA.GetDataTable(strWhereCond);
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
objDT = PrjFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = PrjFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstByFeatureIdLst(List<string> arrFeatureIdLst)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFeatureIdLst, true);
 string strWhereCond = string.Format("FeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjFeatureEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureIdLst)
{
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel =
arrPrjFeatureObjLstCache
.Where(x => arrFeatureIdLst.Contains(x.FeatureId));
return arrPrjFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLst(string strWhereCond)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
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
public static List<clsPrjFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjFeatureEN> GetSubObjLstCache(clsPrjFeatureEN objPrjFeatureCond)
{
List<clsPrjFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFeature._AttributeName)
{
if (objPrjFeatureCond.IsUpdated(strFldName) == false) continue;
if (objPrjFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFeatureCond[strFldName].ToString());
}
else
{
if (objPrjFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFeatureCond[strFldName]));
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
public static List<clsPrjFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
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
public static List<clsPrjFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
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
List<clsPrjFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
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
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
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
public static List<clsPrjFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
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
public static List<clsPrjFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjFeatureEN> arrObjLst = new List<clsPrjFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN();
try
{
objPrjFeatureEN.FeatureId = objRow[conPrjFeature.FeatureId].ToString().Trim(); //功能Id
objPrjFeatureEN.FeatureName = objRow[conPrjFeature.FeatureName].ToString().Trim(); //功能名称
objPrjFeatureEN.FeatureENName = objRow[conPrjFeature.FeatureENName] == DBNull.Value ? null : objRow[conPrjFeature.FeatureENName].ToString().Trim(); //功能英文名
objPrjFeatureEN.KeyWords = objRow[conPrjFeature.KeyWords] == DBNull.Value ? null : objRow[conPrjFeature.KeyWords].ToString().Trim(); //关键字
objPrjFeatureEN.DefaButtonName = objRow[conPrjFeature.DefaButtonName] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName].ToString().Trim(); //默认按钮名
objPrjFeatureEN.DefaButtonName4Mvc = objRow[conPrjFeature.DefaButtonName4Mvc] == DBNull.Value ? null : objRow[conPrjFeature.DefaButtonName4Mvc].ToString().Trim(); //默认按钮名4Mvc
objPrjFeatureEN.RegionTypeId = objRow[conPrjFeature.RegionTypeId] == DBNull.Value ? null : objRow[conPrjFeature.RegionTypeId].ToString().Trim(); //区域类型Id
objPrjFeatureEN.GroupName = objRow[conPrjFeature.GroupName] == DBNull.Value ? null : objRow[conPrjFeature.GroupName].ToString().Trim(); //组名
objPrjFeatureEN.FeatureDescription = objRow[conPrjFeature.FeatureDescription] == DBNull.Value ? null : objRow[conPrjFeature.FeatureDescription].ToString().Trim(); //功能说明
objPrjFeatureEN.InOutTypeId = objRow[conPrjFeature.InOutTypeId].ToString().Trim(); //INOUT类型ID
objPrjFeatureEN.IsNeedField = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedField].ToString().Trim()); //是否需要字段
objPrjFeatureEN.IsNeedTabFeature = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.IsNeedTabFeature].ToString().Trim()); //是否需要表功能
objPrjFeatureEN.ParentFeatureId = objRow[conPrjFeature.ParentFeatureId] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureId].ToString().Trim(); //父功能Id
objPrjFeatureEN.ParentFeatureName = objRow[conPrjFeature.ParentFeatureName] == DBNull.Value ? null : objRow[conPrjFeature.ParentFeatureName].ToString().Trim(); //父功能名
objPrjFeatureEN.FunctionGroupId = objRow[conPrjFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objPrjFeatureEN.FeatureTypeId = objRow[conPrjFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objPrjFeatureEN.CreateUserId = objRow[conPrjFeature.CreateUserId].ToString().Trim(); //建立用户Id
objPrjFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFeature.InUse].ToString().Trim()); //是否在用
objPrjFeatureEN.OrderNum = Int32.Parse(objRow[conPrjFeature.OrderNum].ToString().Trim()); //序号
objPrjFeatureEN.UpdDate = objRow[conPrjFeature.UpdDate] == DBNull.Value ? null : objRow[conPrjFeature.UpdDate].ToString().Trim(); //修改日期
objPrjFeatureEN.UpdUser = objRow[conPrjFeature.UpdUser] == DBNull.Value ? null : objRow[conPrjFeature.UpdUser].ToString().Trim(); //修改者
objPrjFeatureEN.Memo = objRow[conPrjFeature.Memo] == DBNull.Value ? null : objRow[conPrjFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFeatureEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjFeature(ref clsPrjFeatureEN objPrjFeatureEN)
{
bool bolResult = PrjFeatureDA.GetPrjFeature(ref objPrjFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFeatureEN GetObjByFeatureId(string strFeatureId)
{
if (strFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjFeatureEN objPrjFeatureEN = PrjFeatureDA.GetObjByFeatureId(strFeatureId);
return objPrjFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjFeatureEN objPrjFeatureEN = PrjFeatureDA.GetFirstObj(strWhereCond);
 return objPrjFeatureEN;
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
public static clsPrjFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjFeatureEN objPrjFeatureEN = PrjFeatureDA.GetObjByDataRow(objRow);
 return objPrjFeatureEN;
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
public static clsPrjFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjFeatureEN objPrjFeatureEN = PrjFeatureDA.GetObjByDataRow(objRow);
 return objPrjFeatureEN;
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
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <param name = "lstPrjFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFeatureEN GetObjByFeatureIdFromList(string strFeatureId, List<clsPrjFeatureEN> lstPrjFeatureObjLst)
{
foreach (clsPrjFeatureEN objPrjFeatureEN in lstPrjFeatureObjLst)
{
if (objPrjFeatureEN.FeatureId == strFeatureId)
{
return objPrjFeatureEN;
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
 string strMaxFeatureId;
 try
 {
 strMaxFeatureId = clsPrjFeatureDA.GetMaxStrId();
 return strMaxFeatureId;
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
 string strFeatureId;
 try
 {
 strFeatureId = new clsPrjFeatureDA().GetFirstID(strWhereCond);
 return strFeatureId;
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
 arrList = PrjFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = PrjFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjFeatureDA.IsExist(strFeatureId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFeatureId">功能Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFeatureId, string strOpUser)
{
clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureId(strFeatureId);
objPrjFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjFeatureEN.UpdUser = strOpUser;
return clsPrjFeatureBL.UpdateBySql2(objPrjFeatureEN);
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
 bolIsExist = clsPrjFeatureDA.IsExistTable();
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
 bolIsExist = PrjFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}]的数据已经存在!(in clsPrjFeatureBL.AddNewRecordBySql2)", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
bool bolResult = PrjFeatureDA.AddNewRecordBySQL2(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjFeatureEN objPrjFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}]的数据已经存在!(in clsPrjFeatureBL.AddNewRecordBySql2WithReturnKey)", objPrjFeatureEN.FeatureName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true || clsPrjFeatureBL.IsExist(objPrjFeatureEN.FeatureId) == true)
 {
     objPrjFeatureEN.FeatureId = clsPrjFeatureBL.GetMaxStrId_S();
 }
string strKey = PrjFeatureDA.AddNewRecordBySQL2WithReturnKey(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjFeatureEN objPrjFeatureEN)
{
try
{
bool bolResult = PrjFeatureDA.Update(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "objPrjFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjFeatureEN objPrjFeatureEN)
{
 if (string.IsNullOrEmpty(objPrjFeatureEN.FeatureId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjFeatureDA.UpdateBySql2(objPrjFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureBL.ReFreshCache();

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
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
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFeatureId)
{
try
{
 clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureId(strFeatureId);

if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(objPrjFeatureEN.FeatureId, objPrjFeatureEN.UpdUser);
}
if (objPrjFeatureEN != null)
{
int intRecNum = PrjFeatureDA.DelRecord(strFeatureId);
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
/// <param name="strFeatureId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFeatureId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
//删除与表:[PrjFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjFeature.FeatureId,
//strFeatureId);
//        clsPrjFeatureBL.DelPrjFeaturesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFeatureBL.DelRecord(strFeatureId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFeatureBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFeatureId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjFeatureBL.relatedActions != null)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(strFeatureId, "UpdRelaTabDate");
}
bool bolResult = PrjFeatureDA.DelRecord(strFeatureId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFeatureIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjFeatures(List<string> arrFeatureIdLst)
{
if (arrFeatureIdLst.Count == 0) return 0;
try
{
if (clsPrjFeatureBL.relatedActions != null)
{
foreach (var strFeatureId in arrFeatureIdLst)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(strFeatureId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjFeatureDA.DelPrjFeature(arrFeatureIdLst);
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
public static int DelPrjFeaturesByCond(string strWhereCond)
{
try
{
if (clsPrjFeatureBL.relatedActions != null)
{
List<string> arrFeatureId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFeatureId in arrFeatureId)
{
clsPrjFeatureBL.relatedActions.UpdRelaTabDate(strFeatureId, "UpdRelaTabDate");
}
}
int intRecNum = PrjFeatureDA.DelPrjFeature(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjFeature]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFeatureId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFeatureId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFeatureDA.GetSpecSQLObj();
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
//删除与表:[PrjFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFeatureBL.DelRecord(strFeatureId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFeatureBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjFeatureENS">源对象</param>
 /// <param name = "objPrjFeatureENT">目标对象</param>
 public static void CopyTo(clsPrjFeatureEN objPrjFeatureENS, clsPrjFeatureEN objPrjFeatureENT)
{
try
{
objPrjFeatureENT.FeatureId = objPrjFeatureENS.FeatureId; //功能Id
objPrjFeatureENT.FeatureName = objPrjFeatureENS.FeatureName; //功能名称
objPrjFeatureENT.FeatureENName = objPrjFeatureENS.FeatureENName; //功能英文名
objPrjFeatureENT.KeyWords = objPrjFeatureENS.KeyWords; //关键字
objPrjFeatureENT.DefaButtonName = objPrjFeatureENS.DefaButtonName; //默认按钮名
objPrjFeatureENT.DefaButtonName4Mvc = objPrjFeatureENS.DefaButtonName4Mvc; //默认按钮名4Mvc
objPrjFeatureENT.RegionTypeId = objPrjFeatureENS.RegionTypeId; //区域类型Id
objPrjFeatureENT.GroupName = objPrjFeatureENS.GroupName; //组名
objPrjFeatureENT.FeatureDescription = objPrjFeatureENS.FeatureDescription; //功能说明
objPrjFeatureENT.InOutTypeId = objPrjFeatureENS.InOutTypeId; //INOUT类型ID
objPrjFeatureENT.IsNeedField = objPrjFeatureENS.IsNeedField; //是否需要字段
objPrjFeatureENT.IsNeedTabFeature = objPrjFeatureENS.IsNeedTabFeature; //是否需要表功能
objPrjFeatureENT.ParentFeatureId = objPrjFeatureENS.ParentFeatureId; //父功能Id
objPrjFeatureENT.ParentFeatureName = objPrjFeatureENS.ParentFeatureName; //父功能名
objPrjFeatureENT.FunctionGroupId = objPrjFeatureENS.FunctionGroupId; //函数组Id
objPrjFeatureENT.FeatureTypeId = objPrjFeatureENS.FeatureTypeId; //功能类型Id
objPrjFeatureENT.CreateUserId = objPrjFeatureENS.CreateUserId; //建立用户Id
objPrjFeatureENT.InUse = objPrjFeatureENS.InUse; //是否在用
objPrjFeatureENT.OrderNum = objPrjFeatureENS.OrderNum; //序号
objPrjFeatureENT.UpdDate = objPrjFeatureENS.UpdDate; //修改日期
objPrjFeatureENT.UpdUser = objPrjFeatureENS.UpdUser; //修改者
objPrjFeatureENT.Memo = objPrjFeatureENS.Memo; //说明
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
 /// <param name = "objPrjFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjFeatureEN objPrjFeatureEN)
{
try
{
objPrjFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FeatureId = objPrjFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conPrjFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FeatureName = objPrjFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(conPrjFeature.FeatureENName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FeatureENName = objPrjFeatureEN.FeatureENName == "[null]" ? null :  objPrjFeatureEN.FeatureENName; //功能英文名
}
if (arrFldSet.Contains(conPrjFeature.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.KeyWords = objPrjFeatureEN.KeyWords == "[null]" ? null :  objPrjFeatureEN.KeyWords; //关键字
}
if (arrFldSet.Contains(conPrjFeature.DefaButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.DefaButtonName = objPrjFeatureEN.DefaButtonName == "[null]" ? null :  objPrjFeatureEN.DefaButtonName; //默认按钮名
}
if (arrFldSet.Contains(conPrjFeature.DefaButtonName4Mvc, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.DefaButtonName4Mvc = objPrjFeatureEN.DefaButtonName4Mvc == "[null]" ? null :  objPrjFeatureEN.DefaButtonName4Mvc; //默认按钮名4Mvc
}
if (arrFldSet.Contains(conPrjFeature.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.RegionTypeId = objPrjFeatureEN.RegionTypeId == "[null]" ? null :  objPrjFeatureEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conPrjFeature.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.GroupName = objPrjFeatureEN.GroupName == "[null]" ? null :  objPrjFeatureEN.GroupName; //组名
}
if (arrFldSet.Contains(conPrjFeature.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FeatureDescription = objPrjFeatureEN.FeatureDescription == "[null]" ? null :  objPrjFeatureEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(conPrjFeature.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.InOutTypeId = objPrjFeatureEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(conPrjFeature.IsNeedField, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.IsNeedField = objPrjFeatureEN.IsNeedField; //是否需要字段
}
if (arrFldSet.Contains(conPrjFeature.IsNeedTabFeature, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.IsNeedTabFeature = objPrjFeatureEN.IsNeedTabFeature; //是否需要表功能
}
if (arrFldSet.Contains(conPrjFeature.ParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.ParentFeatureId = objPrjFeatureEN.ParentFeatureId == "[null]" ? null :  objPrjFeatureEN.ParentFeatureId; //父功能Id
}
if (arrFldSet.Contains(conPrjFeature.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.ParentFeatureName = objPrjFeatureEN.ParentFeatureName == "[null]" ? null :  objPrjFeatureEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(conPrjFeature.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FunctionGroupId = objPrjFeatureEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(conPrjFeature.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.FeatureTypeId = objPrjFeatureEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(conPrjFeature.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.CreateUserId = objPrjFeatureEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(conPrjFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.InUse = objPrjFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(conPrjFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.OrderNum = objPrjFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(conPrjFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.UpdDate = objPrjFeatureEN.UpdDate == "[null]" ? null :  objPrjFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.UpdUser = objPrjFeatureEN.UpdUser == "[null]" ? null :  objPrjFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conPrjFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFeatureEN.Memo = objPrjFeatureEN.Memo == "[null]" ? null :  objPrjFeatureEN.Memo; //说明
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
 /// <param name = "objPrjFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjFeatureEN objPrjFeatureEN)
{
try
{
if (objPrjFeatureEN.FeatureENName == "[null]") objPrjFeatureEN.FeatureENName = null; //功能英文名
if (objPrjFeatureEN.KeyWords == "[null]") objPrjFeatureEN.KeyWords = null; //关键字
if (objPrjFeatureEN.DefaButtonName == "[null]") objPrjFeatureEN.DefaButtonName = null; //默认按钮名
if (objPrjFeatureEN.DefaButtonName4Mvc == "[null]") objPrjFeatureEN.DefaButtonName4Mvc = null; //默认按钮名4Mvc
if (objPrjFeatureEN.RegionTypeId == "[null]") objPrjFeatureEN.RegionTypeId = null; //区域类型Id
if (objPrjFeatureEN.GroupName == "[null]") objPrjFeatureEN.GroupName = null; //组名
if (objPrjFeatureEN.FeatureDescription == "[null]") objPrjFeatureEN.FeatureDescription = null; //功能说明
if (objPrjFeatureEN.ParentFeatureId == "[null]") objPrjFeatureEN.ParentFeatureId = null; //父功能Id
if (objPrjFeatureEN.ParentFeatureName == "[null]") objPrjFeatureEN.ParentFeatureName = null; //父功能名
if (objPrjFeatureEN.UpdDate == "[null]") objPrjFeatureEN.UpdDate = null; //修改日期
if (objPrjFeatureEN.UpdUser == "[null]") objPrjFeatureEN.UpdUser = null; //修改者
if (objPrjFeatureEN.Memo == "[null]") objPrjFeatureEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjFeatureEN objPrjFeatureEN)
{
 PrjFeatureDA.CheckPropertyNew(objPrjFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjFeatureEN objPrjFeatureEN)
{
 PrjFeatureDA.CheckProperty4Condition(objPrjFeatureEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFeatureTypeId"></param>
public static void BindCbo_FeatureId(System.Windows.Forms.ComboBox objComboBox , string strFeatureTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjFeature.FeatureId); 
List<clsPrjFeatureEN> arrObjLst = clsPrjFeatureBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FeatureTypeId == strFeatureTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjFeatureEN objPrjFeatureEN = new clsPrjFeatureEN()
{
FeatureId = "0",
FeatureName = "选[功能]..."
};
arrObjLstSel.Insert(0, objPrjFeatureEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjFeature.FeatureId;
objComboBox.DisplayMember = conPrjFeature.FeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strFeatureTypeId"></param>
public static void BindDdl_FeatureId(System.Web.UI.WebControls.DropDownList objDDL , string strFeatureTypeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjFeature.FeatureId); 
IEnumerable<clsPrjFeatureEN> arrObjLst = clsPrjFeatureBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FeatureTypeId == strFeatureTypeId).ToList();
objDDL.DataValueField = conPrjFeature.FeatureId;
objDDL.DataTextField = conPrjFeature.FeatureName;
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
public static void BindDdl_FeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能]...","0");
List<clsPrjFeatureEN> arrPrjFeatureObjLst = GetAllPrjFeatureObjLstCache(); 
arrPrjFeatureObjLst = arrPrjFeatureObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conPrjFeature.FeatureId;
objDDL.DataTextField = conPrjFeature.FeatureName;
objDDL.DataSource = arrPrjFeatureObjLst;
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
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FeatureId");
//if (arrPrjFeatureObjLstCache == null)
//{
//arrPrjFeatureObjLstCache = PrjFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFeatureEN GetObjByFeatureIdCache(string strFeatureId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrPrjFeatureObjLst_Sel =
arrPrjFeatureObjLstCache
.Where(x=> x.FeatureId == strFeatureId 
);
if (arrPrjFeatureObjLst_Sel.Count() == 0)
{
   clsPrjFeatureEN obj = clsPrjFeatureBL.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//获取缓存中的对象列表
clsPrjFeatureEN objPrjFeature = GetObjByFeatureIdCache(strFeatureId);
if (objPrjFeature == null) return "";
return objPrjFeature.FeatureName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//获取缓存中的对象列表
clsPrjFeatureEN objPrjFeature = GetObjByFeatureIdCache(strFeatureId);
if (objPrjFeature == null) return "";
return objPrjFeature.FeatureName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFeatureEN> GetAllPrjFeatureObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = GetObjLstCache(); 
return arrPrjFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFeatureEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
List<clsPrjFeatureEN> arrPrjFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjFeatureObjLstCache;
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
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsPrjFeatureEN._RefreshTimeLst[clsPrjFeatureEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPrjFeatureBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjFeatureBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjFeature(功能)
 /// 唯一性条件:FeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjFeatureEN objPrjFeatureEN)
{
//检测记录是否存在
string strResult = PrjFeatureDA.GetUniCondStr(objPrjFeatureEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFeatureId)
{
if (strInFldName != conPrjFeature.FeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjFeature._AttributeName));
throw new Exception(strMsg);
}
var objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(strFeatureId);
if (objPrjFeature == null) return "";
return objPrjFeature[strOutFldName].ToString();
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
int intRecCount = clsPrjFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjFeatureDA.GetRecCount();
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
int intRecCount = clsPrjFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjFeatureEN objPrjFeatureCond)
{
List<clsPrjFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFeature._AttributeName)
{
if (objPrjFeatureCond.IsUpdated(strFldName) == false) continue;
if (objPrjFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFeatureCond[strFldName].ToString());
}
else
{
if (objPrjFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFeatureCond[strFldName]));
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
 List<string> arrList = clsPrjFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjFeatureDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFeatureDA.SetFldValue(clsPrjFeatureEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjFeatureDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFeatureDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFeatureDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFeatureDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjFeature] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) primary key, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) not Null, "); 
 // /**功能英文名*/ 
 strCreateTabCode.Append(" FeatureENName varchar(100) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" KeyWords varchar(500) Null, "); 
 // /**默认按钮名*/ 
 strCreateTabCode.Append(" DefaButtonName varchar(30) Null, "); 
 // /**默认按钮名4Mvc*/ 
 strCreateTabCode.Append(" DefaButtonName4Mvc varchar(30) Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**功能说明*/ 
 strCreateTabCode.Append(" FeatureDescription varchar(4000) Null, "); 
 // /**INOUT类型ID*/ 
 strCreateTabCode.Append(" InOutTypeId char(2) not Null, "); 
 // /**是否需要字段*/ 
 strCreateTabCode.Append(" IsNeedField bit Null, "); 
 // /**是否需要表功能*/ 
 strCreateTabCode.Append(" IsNeedTabFeature bit Null, "); 
 // /**父功能Id*/ 
 strCreateTabCode.Append(" ParentFeatureId char(4) Null, "); 
 // /**父功能名*/ 
 strCreateTabCode.Append(" ParentFeatureName varchar(500) Null, "); 
 // /**函数组Id*/ 
 strCreateTabCode.Append(" FunctionGroupId char(4) not Null, "); 
 // /**功能类型Id*/ 
 strCreateTabCode.Append(" FeatureTypeId char(2) not Null, "); 
 // /**建立用户Id*/ 
 strCreateTabCode.Append(" CreateUserId varchar(18) not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**按钮集合*/ 
 strCreateTabCode.Append(" ButtonSet varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：FeatureTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strFeatureTypeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strFeatureTypeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFeatureEN> arrPrjFeatureObjList = new clsPrjFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList)
{
objPrjFeature.OrderNum = intIndex;
UpdateBySql2(objPrjFeature);
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
/// 调整所给关键字记录的序号。根据分类字段：FeatureTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strFeatureId">所给的关键字</param>
/// <param name="strFeatureTypeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strFeatureId ,string strFeatureTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FeatureId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FeatureId
//5、把当前关键字FeatureId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FeatureId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFeatureId = "";    //上一条序号的关键字FeatureId
string strNextFeatureId = "";    //下一条序号的关键字FeatureId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[FeatureId],获取相应的序号[OrderNum]。

clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureId(strFeatureId);

intOrderNum = objPrjFeature.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);
intTabRecNum = clsPrjFeatureBL.GetRecCountByCond(clsPrjFeatureEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conPrjFeature.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);
//4、获取上一个序号字段的关键字FeatureId
strPrevFeatureId = clsPrjFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevFeatureId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FeatureId所对应记录的序号减1
//6、把下(上)一个序号关键字FeatureId所对应的记录序号加1
clsPrjFeatureBL.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strFeatureId));
clsPrjFeatureBL.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strPrevFeatureId));
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

//4、获取下一个序号字段的关键字FeatureId
sbCondition.AppendFormat(" {0} = {1} ", conPrjFeature.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);

strNextFeatureId = clsPrjFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextFeatureId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FeatureId所对应记录的序号加1
//6、把下(上)一个序号关键字FeatureId所对应的记录序号减1
clsPrjFeatureBL.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strFeatureId));
clsPrjFeatureBL.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strNextFeatureId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：FeatureTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strFeatureTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conPrjFeature.FeatureId, strKeyList);
List<clsPrjFeatureEN> arrPrjFeatureLst = GetObjLst(strCondition);
foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureLst)
{
objPrjFeature.OrderNum = objPrjFeature.OrderNum + 10000;
UpdateBySql2(objPrjFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFeatureEN> arrPrjFeatureObjList = new clsPrjFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList)
{
objPrjFeature.OrderNum = intIndex;
UpdateBySql2(objPrjFeature);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：FeatureTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strFeatureTypeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strFeatureTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conPrjFeature.FeatureId, strKeyList);
List<clsPrjFeatureEN> arrPrjFeatureLst = GetObjLst(strCondition);
foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureLst)
{
objPrjFeature.OrderNum = objPrjFeature.OrderNum - 10000;
UpdateBySql2(objPrjFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjFeature.FeatureTypeId, strFeatureTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFeatureEN> arrPrjFeatureObjList = new clsPrjFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList)
{
objPrjFeature.OrderNum = intIndex;
UpdateBySql2(objPrjFeature);
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
 /// 功能(PrjFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjFeature : clsCommFun4BL
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
clsPrjFeatureBL.ReFreshThisCache();
}
}

}