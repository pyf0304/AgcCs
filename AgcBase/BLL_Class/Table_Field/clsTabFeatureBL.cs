
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureBL
 表名:TabFeature(00050463)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:47
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
public static class  clsTabFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFeatureEN GetObj(this K_TabFeatureId_TabFeature myKey)
{
clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.TabFeatureDA.GetObjByTabFeatureId(myKey.Value);
return objTabFeatureEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabFeatureEN.TabFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],表功能名 = [{2}]的数据已经存在!(in clsTabFeatureBL.AddNewRecord)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],Cs函数名 = [{2}],Js函数名 = [{3}]的数据已经存在!(in clsTabFeatureBL.AddNewRecord)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.FuncNameCs,objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabFeatureBL.TabFeatureDA.AddNewRecordBySQL2(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
public static bool AddRecordEx(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTabFeatureEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],功能Id(FeatureId)=[{1}],表功能名(TabFeatureName)=[{2}])已经存在,不能重复!", objTabFeatureEN.TabId, objTabFeatureEN.FeatureId, objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness_V2() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],功能Id(FeatureId)=[{1}],Cs函数名(FuncNameCs)=[{2}],Js函数名(FuncNameJs)=[{3}])已经存在,不能重复!", objTabFeatureEN.TabId, objTabFeatureEN.FeatureId, objTabFeatureEN.FuncNameCs, objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabFeatureEN.AddNewRecord();
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],表功能名 = [{2}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordWithMaxId)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],Cs函数名 = [{2}],Js函数名 = [{3}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordWithMaxId)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.FuncNameCs,objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true || clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
     objTabFeatureEN.TabFeatureId = clsTabFeatureBL.GetMaxStrIdByPrefix_S(objTabFeatureEN.PrjId);
 }
string strTabFeatureId = clsTabFeatureBL.TabFeatureDA.AddNewRecordBySQL2WithReturnKey(objTabFeatureEN);
     objTabFeatureEN.TabFeatureId = strTabFeatureId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
}
return strTabFeatureId;
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabFeatureEN.TabFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],表功能名 = [{2}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordWithReturnKey)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFeatureEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],Cs函数名 = [{2}],Js函数名 = [{3}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordWithReturnKey)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.FuncNameCs,objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabFeatureBL.TabFeatureDA.AddNewRecordBySQL2WithReturnKey(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabFeatureId(this clsTabFeatureEN objTabFeatureEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, conTabFeature.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, conTabFeature.TabFeatureId);
}
objTabFeatureEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabFeatureId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabFeatureId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabFeatureId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabFeatureName(this clsTabFeatureEN objTabFeatureEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabFeatureName, conTabFeature.TabFeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, conTabFeature.TabFeatureName);
}
objTabFeatureEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabFeatureName) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabFeatureName, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabFeatureName] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetTabId(this clsTabFeatureEN objTabFeatureEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabFeature.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabFeature.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabFeature.TabId);
}
objTabFeatureEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.TabId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.TabId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.TabId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFeatureId(this clsTabFeatureEN objTabFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conTabFeature.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conTabFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conTabFeature.FeatureId);
}
objTabFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FeatureId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FeatureId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FeatureId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFuncNameCs(this clsTabFeatureEN objTabFeatureEN, string strFuncNameCs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, conTabFeature.FuncNameCs);
}
objTabFeatureEN.FuncNameCs = strFuncNameCs; //Cs函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FuncNameCs) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FuncNameCs, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FuncNameCs] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsExtendedClass(this clsTabFeatureEN objTabFeatureEN, bool bolIsExtendedClass, string strComparisonOp="")
	{
objTabFeatureEN.IsExtendedClass = bolIsExtendedClass; //是否在扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsExtendedClass) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsExtendedClass, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsExtendedClass] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetFuncNameJs(this clsTabFeatureEN objTabFeatureEN, string strFuncNameJs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, conTabFeature.FuncNameJs);
}
objTabFeatureEN.FuncNameJs = strFuncNameJs; //Js函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.FuncNameJs) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.FuncNameJs, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.FuncNameJs] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetGetDdlDataFuncName4Ex(this clsTabFeatureEN objTabFeatureEN, string strGetDdlDataFuncName4Ex, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetDdlDataFuncName4Ex, 100, conTabFeature.GetDdlDataFuncName4Ex);
}
objTabFeatureEN.GetDdlDataFuncName4Ex = strGetDdlDataFuncName4Ex; //获取Ddl函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.GetDdlDataFuncName4Ex) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.GetDdlDataFuncName4Ex, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.GetDdlDataFuncName4Ex] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForCSharp(this clsTabFeatureEN objTabFeatureEN, bool bolIsForCSharp, string strComparisonOp="")
	{
objTabFeatureEN.IsForCSharp = bolIsForCSharp; //是否ForCSharp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForCSharp) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForCSharp, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForCSharp] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForTypeScript(this clsTabFeatureEN objTabFeatureEN, bool bolIsForTypeScript, string strComparisonOp="")
	{
objTabFeatureEN.IsForTypeScript = bolIsForTypeScript; //是否ForTypeScript
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForTypeScript) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForTypeScript, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForTypeScript] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsForDiv(this clsTabFeatureEN objTabFeatureEN, bool bolIsForDiv, string strComparisonOp="")
	{
objTabFeatureEN.IsForDiv = bolIsForDiv; //是否针对Div内控件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsForDiv) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsForDiv, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsForDiv] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsNeedGC(this clsTabFeatureEN objTabFeatureEN, bool bolIsNeedGC, string strComparisonOp="")
	{
objTabFeatureEN.IsNeedGC = bolIsNeedGC; //是否需要生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsNeedGC) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsNeedGC, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsNeedGC] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUseTimes(this clsTabFeatureEN objTabFeatureEN, int? intUseTimes, string strComparisonOp="")
	{
objTabFeatureEN.UseTimes = intUseTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UseTimes) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UseTimes, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UseTimes] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetOrderNum(this clsTabFeatureEN objTabFeatureEN, int? intOrderNum, string strComparisonOp="")
	{
objTabFeatureEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.OrderNum) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.OrderNum, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.OrderNum] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetIsNullable(this clsTabFeatureEN objTabFeatureEN, bool bolIsNullable, string strComparisonOp="")
	{
objTabFeatureEN.IsNullable = bolIsNullable; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.IsNullable) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.IsNullable, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.IsNullable] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetInUse(this clsTabFeatureEN objTabFeatureEN, bool bolInUse, string strComparisonOp="")
	{
objTabFeatureEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.InUse) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.InUse, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.InUse] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetCheckDate(this clsTabFeatureEN objTabFeatureEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conTabFeature.CheckDate);
}
objTabFeatureEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.CheckDate) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.CheckDate, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.CheckDate] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetToolTipText(this clsTabFeatureEN objTabFeatureEN, string strToolTipText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strToolTipText, 150, conTabFeature.ToolTipText);
}
objTabFeatureEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.ToolTipText) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.ToolTipText, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.ToolTipText] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetErrMsg(this clsTabFeatureEN objTabFeatureEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conTabFeature.ErrMsg);
}
objTabFeatureEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.ErrMsg) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.ErrMsg, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.ErrMsg] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetPrjId(this clsTabFeatureEN objTabFeatureEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabFeature.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFeature.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFeature.PrjId);
}
objTabFeatureEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.PrjId) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.PrjId, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.PrjId] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUpdUser(this clsTabFeatureEN objTabFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conTabFeature.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabFeature.UpdUser);
}
objTabFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UpdUser) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UpdUser, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UpdUser] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetUpdDate(this clsTabFeatureEN objTabFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabFeature.UpdDate);
}
objTabFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.UpdDate) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.UpdDate, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.UpdDate] = strComparisonOp;
}
}
return objTabFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureEN SetMemo(this clsTabFeatureEN objTabFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFeature.Memo);
}
objTabFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureEN.dicFldComparisonOp.ContainsKey(conTabFeature.Memo) == false)
{
objTabFeatureEN.dicFldComparisonOp.Add(conTabFeature.Memo, strComparisonOp);
}
else
{
objTabFeatureEN.dicFldComparisonOp[conTabFeature.Memo] = strComparisonOp;
}
}
return objTabFeatureEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabFeatureEN objTabFeatureEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabFeatureEN.CheckPropertyNew();
clsTabFeatureEN objTabFeatureCond = new clsTabFeatureEN();
string strCondition = objTabFeatureCond
.SetTabFeatureId(objTabFeatureEN.TabFeatureId, "<>")
.SetTabId(objTabFeatureEN.TabId, "=")
.SetFeatureId(objTabFeatureEN.FeatureId, "=")
.SetFuncNameCs(objTabFeatureEN.FuncNameCs, "=")
.SetFuncNameJs(objTabFeatureEN.FuncNameJs, "=")
.GetCombineCondition();
objTabFeatureEN._IsCheckProperty = true;
bool bolIsExist = clsTabFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_FeatureId_FuncName_Cs_FuncName_Js)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabFeatureEN.Update();
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
 /// <param name = "objTabFeature">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabFeatureEN objTabFeature)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabFeatureEN objTabFeatureCond = new clsTabFeatureEN();
string strCondition = objTabFeatureCond
.SetTabId(objTabFeature.TabId, "=")
.SetFeatureId(objTabFeature.FeatureId, "=")
.SetFuncNameCs(objTabFeature.FuncNameCs, "=")
.SetFuncNameJs(objTabFeature.FuncNameJs, "=")
.GetCombineCondition();
objTabFeature._IsCheckProperty = true;
bool bolIsExist = clsTabFeatureBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabFeature.TabFeatureId = clsTabFeatureBL.GetFirstID_S(strCondition);
objTabFeature.UpdateWithCondition(strCondition);
}
else
{
objTabFeature.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFeatureEN objTabFeatureEN)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFeatureBL.TabFeatureDA.UpdateBySql2(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFeatureEN objTabFeatureEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFeatureBL.TabFeatureDA.UpdateBySql2(objTabFeatureEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFeatureEN objTabFeatureEN, string strWhereCond)
{
try
{
bool bolResult = clsTabFeatureBL.TabFeatureDA.UpdateBySqlWithCondition(objTabFeatureEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFeatureEN objTabFeatureEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabFeatureBL.TabFeatureDA.UpdateBySqlWithConditionTransaction(objTabFeatureEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabFeatureEN objTabFeatureEN)
{
try
{
int intRecNum = clsTabFeatureBL.TabFeatureDA.DelRecord(objTabFeatureEN.TabFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureENS">源对象</param>
 /// <param name = "objTabFeatureENT">目标对象</param>
 public static void CopyTo(this clsTabFeatureEN objTabFeatureENS, clsTabFeatureEN objTabFeatureENT)
{
try
{
objTabFeatureENT.TabFeatureId = objTabFeatureENS.TabFeatureId; //表功能Id
objTabFeatureENT.TabFeatureName = objTabFeatureENS.TabFeatureName; //表功能名
objTabFeatureENT.TabId = objTabFeatureENS.TabId; //表ID
objTabFeatureENT.FeatureId = objTabFeatureENS.FeatureId; //功能Id
objTabFeatureENT.FuncNameCs = objTabFeatureENS.FuncNameCs; //Cs函数名
objTabFeatureENT.IsExtendedClass = objTabFeatureENS.IsExtendedClass; //是否在扩展类
objTabFeatureENT.FuncNameJs = objTabFeatureENS.FuncNameJs; //Js函数名
objTabFeatureENT.GetDdlDataFuncName4Ex = objTabFeatureENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objTabFeatureENT.IsForCSharp = objTabFeatureENS.IsForCSharp; //是否ForCSharp
objTabFeatureENT.IsForTypeScript = objTabFeatureENS.IsForTypeScript; //是否ForTypeScript
objTabFeatureENT.IsForDiv = objTabFeatureENS.IsForDiv; //是否针对Div内控件
objTabFeatureENT.IsNeedGC = objTabFeatureENS.IsNeedGC; //是否需要生成代码
objTabFeatureENT.UseTimes = objTabFeatureENS.UseTimes; //使用次数
objTabFeatureENT.OrderNum = objTabFeatureENS.OrderNum; //序号
objTabFeatureENT.IsNullable = objTabFeatureENS.IsNullable; //是否可空
objTabFeatureENT.InUse = objTabFeatureENS.InUse; //是否在用
objTabFeatureENT.CheckDate = objTabFeatureENS.CheckDate; //检查日期
objTabFeatureENT.ToolTipText = objTabFeatureENS.ToolTipText; //提示文字
objTabFeatureENT.ErrMsg = objTabFeatureENS.ErrMsg; //错误信息
objTabFeatureENT.PrjId = objTabFeatureENS.PrjId; //工程Id
objTabFeatureENT.UpdUser = objTabFeatureENS.UpdUser; //修改者
objTabFeatureENT.UpdDate = objTabFeatureENS.UpdDate; //修改日期
objTabFeatureENT.Memo = objTabFeatureENS.Memo; //说明
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
 /// <param name = "objTabFeatureENS">源对象</param>
 /// <returns>目标对象=>clsTabFeatureEN:objTabFeatureENT</returns>
 public static clsTabFeatureEN CopyTo(this clsTabFeatureEN objTabFeatureENS)
{
try
{
 clsTabFeatureEN objTabFeatureENT = new clsTabFeatureEN()
{
TabFeatureId = objTabFeatureENS.TabFeatureId, //表功能Id
TabFeatureName = objTabFeatureENS.TabFeatureName, //表功能名
TabId = objTabFeatureENS.TabId, //表ID
FeatureId = objTabFeatureENS.FeatureId, //功能Id
FuncNameCs = objTabFeatureENS.FuncNameCs, //Cs函数名
IsExtendedClass = objTabFeatureENS.IsExtendedClass, //是否在扩展类
FuncNameJs = objTabFeatureENS.FuncNameJs, //Js函数名
GetDdlDataFuncName4Ex = objTabFeatureENS.GetDdlDataFuncName4Ex, //获取Ddl函数名
IsForCSharp = objTabFeatureENS.IsForCSharp, //是否ForCSharp
IsForTypeScript = objTabFeatureENS.IsForTypeScript, //是否ForTypeScript
IsForDiv = objTabFeatureENS.IsForDiv, //是否针对Div内控件
IsNeedGC = objTabFeatureENS.IsNeedGC, //是否需要生成代码
UseTimes = objTabFeatureENS.UseTimes, //使用次数
OrderNum = objTabFeatureENS.OrderNum, //序号
IsNullable = objTabFeatureENS.IsNullable, //是否可空
InUse = objTabFeatureENS.InUse, //是否在用
CheckDate = objTabFeatureENS.CheckDate, //检查日期
ToolTipText = objTabFeatureENS.ToolTipText, //提示文字
ErrMsg = objTabFeatureENS.ErrMsg, //错误信息
PrjId = objTabFeatureENS.PrjId, //工程Id
UpdUser = objTabFeatureENS.UpdUser, //修改者
UpdDate = objTabFeatureENS.UpdDate, //修改日期
Memo = objTabFeatureENS.Memo, //说明
};
 return objTabFeatureENT;
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
public static void CheckPropertyNew(this clsTabFeatureEN objTabFeatureEN)
{
 clsTabFeatureBL.TabFeatureDA.CheckPropertyNew(objTabFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabFeatureEN objTabFeatureEN)
{
 clsTabFeatureBL.TabFeatureDA.CheckProperty4Condition(objTabFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFeatureEN objTabFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFeatureCond.IsUpdated(conTabFeature.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabFeatureId, objTabFeatureCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabFeatureName, objTabFeatureCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.TabId) == true)
{
string strComparisonOpTabId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.TabId, objTabFeatureCond.TabId, strComparisonOpTabId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FeatureId, objTabFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FuncNameCs) == true)
{
string strComparisonOpFuncNameCs = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FuncNameCs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FuncNameCs, objTabFeatureCond.FuncNameCs, strComparisonOpFuncNameCs);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsExtendedClass) == true)
{
if (objTabFeatureCond.IsExtendedClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsExtendedClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsExtendedClass);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.FuncNameJs) == true)
{
string strComparisonOpFuncNameJs = objTabFeatureCond.dicFldComparisonOp[conTabFeature.FuncNameJs];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.FuncNameJs, objTabFeatureCond.FuncNameJs, strComparisonOpFuncNameJs);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.GetDdlDataFuncName4Ex) == true)
{
string strComparisonOpGetDdlDataFuncName4Ex = objTabFeatureCond.dicFldComparisonOp[conTabFeature.GetDdlDataFuncName4Ex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.GetDdlDataFuncName4Ex, objTabFeatureCond.GetDdlDataFuncName4Ex, strComparisonOpGetDdlDataFuncName4Ex);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForCSharp) == true)
{
if (objTabFeatureCond.IsForCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForCSharp);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForTypeScript) == true)
{
if (objTabFeatureCond.IsForTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForTypeScript);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsForDiv) == true)
{
if (objTabFeatureCond.IsForDiv == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsForDiv);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsForDiv);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsNeedGC) == true)
{
if (objTabFeatureCond.IsNeedGC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsNeedGC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsNeedGC);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UseTimes) == true)
{
string strComparisonOpUseTimes = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UseTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeature.UseTimes, objTabFeatureCond.UseTimes, strComparisonOpUseTimes);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.OrderNum) == true)
{
string strComparisonOpOrderNum = objTabFeatureCond.dicFldComparisonOp[conTabFeature.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeature.OrderNum, objTabFeatureCond.OrderNum, strComparisonOpOrderNum);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.IsNullable) == true)
{
if (objTabFeatureCond.IsNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.IsNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.IsNullable);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.InUse) == true)
{
if (objTabFeatureCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeature.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeature.InUse);
}
}
if (objTabFeatureCond.IsUpdated(conTabFeature.CheckDate) == true)
{
string strComparisonOpCheckDate = objTabFeatureCond.dicFldComparisonOp[conTabFeature.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.CheckDate, objTabFeatureCond.CheckDate, strComparisonOpCheckDate);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.ToolTipText) == true)
{
string strComparisonOpToolTipText = objTabFeatureCond.dicFldComparisonOp[conTabFeature.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.ToolTipText, objTabFeatureCond.ToolTipText, strComparisonOpToolTipText);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.ErrMsg) == true)
{
string strComparisonOpErrMsg = objTabFeatureCond.dicFldComparisonOp[conTabFeature.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.ErrMsg, objTabFeatureCond.ErrMsg, strComparisonOpErrMsg);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.PrjId) == true)
{
string strComparisonOpPrjId = objTabFeatureCond.dicFldComparisonOp[conTabFeature.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.PrjId, objTabFeatureCond.PrjId, strComparisonOpPrjId);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.UpdUser, objTabFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabFeatureCond.dicFldComparisonOp[conTabFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.UpdDate, objTabFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabFeatureCond.IsUpdated(conTabFeature.Memo) == true)
{
string strComparisonOpMemo = objTabFeatureCond.dicFldComparisonOp[conTabFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeature.Memo, objTabFeatureCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabFeature(表功能), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_FeatureId_TabFeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return true;
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
if (clsTabFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
if (clsTabFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--TabFeature(表功能), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_FeatureId_FuncName_Cs_FuncName_Js
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_V2(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return true;
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 if (objTabFeatureEN.FuncNameCs == null)
{
 sbCondition.AppendFormat(" and FuncNameCs is null", objTabFeatureEN.FuncNameCs);
}
else
{
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
}
 if (objTabFeatureEN.FuncNameJs == null)
{
 sbCondition.AppendFormat(" and FuncNameJs is null", objTabFeatureEN.FuncNameJs);
}
else
{
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
}
if (clsTabFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
if (clsTabFeatureBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TabFeature(表功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FeatureId_TabFeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return "";
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and TabFeatureName = '{0}'", objTabFeatureEN.TabFeatureName);
 return sbCondition.ToString();
}
}
 /// <summary>
 /// 获取唯一性条件串--TabFeature(表功能), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FeatureId_FuncName_Cs_FuncName_Js
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_V2(this clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureEN == null) return "";
if (objTabFeatureEN.TabFeatureId == null || objTabFeatureEN.TabFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 if (objTabFeatureEN.FuncNameCs == null)
{
 sbCondition.AppendFormat(" and FuncNameCs is null", objTabFeatureEN.FuncNameCs);
}
else
{
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
}
 if (objTabFeatureEN.FuncNameJs == null)
{
 sbCondition.AppendFormat(" and FuncNameJs is null", objTabFeatureEN.FuncNameJs);
}
else
{
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabFeatureId !=  '{0}'", objTabFeatureEN.TabFeatureId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFeatureEN.TabId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objTabFeatureEN.FeatureId);
 sbCondition.AppendFormat(" and FuncNameCs = '{0}'", objTabFeatureEN.FuncNameCs);
 sbCondition.AppendFormat(" and FuncNameJs = '{0}'", objTabFeatureEN.FuncNameJs);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabFeature
{
public virtual bool UpdRelaTabDate(string strTabFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表功能(TabFeature)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabFeatureBL
{
public static RelatedActions_TabFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabFeatureDA TabFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabFeatureDA();
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
 public clsTabFeatureBL()
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
if (string.IsNullOrEmpty(clsTabFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFeatureEN._ConnectString);
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
public static DataTable GetDataTable_TabFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabFeatureDA.GetDataTable_TabFeature(strWhereCond);
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
objDT = TabFeatureDA.GetDataTable(strWhereCond);
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
objDT = TabFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = TabFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureIdLst)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabFeatureIdLst, true);
 string strWhereCond = string.Format("TabFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabFeatureEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel =
arrTabFeatureObjLstCache
.Where(x => arrTabFeatureIdLst.Contains(x.TabFeatureId));
return arrTabFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetObjLst(string strWhereCond)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
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
public static List<clsTabFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabFeatureEN> GetSubObjLstCache(clsTabFeatureEN objTabFeatureCond)
{
 string strPrjId = objTabFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsTabFeatureBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsTabFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFeature._AttributeName)
{
if (objTabFeatureCond.IsUpdated(strFldName) == false) continue;
if (objTabFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFeatureCond[strFldName].ToString());
}
else
{
if (objTabFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFeatureCond[strFldName]));
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
public static List<clsTabFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
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
public static List<clsTabFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
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
List<clsTabFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
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
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
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
public static List<clsTabFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
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
public static List<clsTabFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabFeatureEN> arrObjLst = new List<clsTabFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFeatureEN objTabFeatureEN = new clsTabFeatureEN();
try
{
objTabFeatureEN.TabFeatureId = objRow[conTabFeature.TabFeatureId].ToString().Trim(); //表功能Id
objTabFeatureEN.TabFeatureName = objRow[conTabFeature.TabFeatureName].ToString().Trim(); //表功能名
objTabFeatureEN.TabId = objRow[conTabFeature.TabId].ToString().Trim(); //表ID
objTabFeatureEN.FeatureId = objRow[conTabFeature.FeatureId].ToString().Trim(); //功能Id
objTabFeatureEN.FuncNameCs = objRow[conTabFeature.FuncNameCs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameCs].ToString().Trim(); //Cs函数名
objTabFeatureEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsExtendedClass].ToString().Trim()); //是否在扩展类
objTabFeatureEN.FuncNameJs = objRow[conTabFeature.FuncNameJs] == DBNull.Value ? null : objRow[conTabFeature.FuncNameJs].ToString().Trim(); //Js函数名
objTabFeatureEN.GetDdlDataFuncName4Ex = objRow[conTabFeature.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[conTabFeature.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objTabFeatureEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForCSharp].ToString().Trim()); //是否ForCSharp
objTabFeatureEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objTabFeatureEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsForDiv].ToString().Trim()); //是否针对Div内控件
objTabFeatureEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNeedGC].ToString().Trim()); //是否需要生成代码
objTabFeatureEN.UseTimes = objRow[conTabFeature.UseTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.UseTimes].ToString().Trim()); //使用次数
objTabFeatureEN.OrderNum = objRow[conTabFeature.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTabFeature.OrderNum].ToString().Trim()); //序号
objTabFeatureEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.IsNullable].ToString().Trim()); //是否可空
objTabFeatureEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conTabFeature.InUse].ToString().Trim()); //是否在用
objTabFeatureEN.CheckDate = objRow[conTabFeature.CheckDate] == DBNull.Value ? null : objRow[conTabFeature.CheckDate].ToString().Trim(); //检查日期
objTabFeatureEN.ToolTipText = objRow[conTabFeature.ToolTipText] == DBNull.Value ? null : objRow[conTabFeature.ToolTipText].ToString().Trim(); //提示文字
objTabFeatureEN.ErrMsg = objRow[conTabFeature.ErrMsg] == DBNull.Value ? null : objRow[conTabFeature.ErrMsg].ToString().Trim(); //错误信息
objTabFeatureEN.PrjId = objRow[conTabFeature.PrjId].ToString().Trim(); //工程Id
objTabFeatureEN.UpdUser = objRow[conTabFeature.UpdUser].ToString().Trim(); //修改者
objTabFeatureEN.UpdDate = objRow[conTabFeature.UpdDate] == DBNull.Value ? null : objRow[conTabFeature.UpdDate].ToString().Trim(); //修改日期
objTabFeatureEN.Memo = objRow[conTabFeature.Memo] == DBNull.Value ? null : objRow[conTabFeature.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFeatureEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabFeature(ref clsTabFeatureEN objTabFeatureEN)
{
bool bolResult = TabFeatureDA.GetTabFeature(ref objTabFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFeatureEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTabFeatureEN objTabFeatureEN = TabFeatureDA.GetObjByTabFeatureId(strTabFeatureId);
return objTabFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabFeatureEN objTabFeatureEN = TabFeatureDA.GetFirstObj(strWhereCond);
 return objTabFeatureEN;
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
public static clsTabFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabFeatureEN objTabFeatureEN = TabFeatureDA.GetObjByDataRow(objRow);
 return objTabFeatureEN;
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
public static clsTabFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabFeatureEN objTabFeatureEN = TabFeatureDA.GetObjByDataRow(objRow);
 return objTabFeatureEN;
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
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "lstTabFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFeatureEN GetObjByTabFeatureIdFromList(string strTabFeatureId, List<clsTabFeatureEN> lstTabFeatureObjLst)
{
foreach (clsTabFeatureEN objTabFeatureEN in lstTabFeatureObjLst)
{
if (objTabFeatureEN.TabFeatureId == strTabFeatureId)
{
return objTabFeatureEN;
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
 string strMaxTabFeatureId;
 try
 {
 strMaxTabFeatureId = new clsTabFeatureDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxTabFeatureId;
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
 string strTabFeatureId;
 try
 {
 strTabFeatureId = new clsTabFeatureDA().GetFirstID(strWhereCond);
 return strTabFeatureId;
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
 arrList = TabFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = TabFeatureDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabFeatureId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TabFeatureDA.IsExist(strTabFeatureId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTabFeatureId">表功能Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTabFeatureId, string strOpUser)
{
clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
objTabFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTabFeatureEN.UpdUser = strOpUser;
return clsTabFeatureBL.UpdateBySql2(objTabFeatureEN);
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
 bolIsExist = clsTabFeatureDA.IsExistTable();
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
 bolIsExist = TabFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabFeatureEN.TabFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],表功能名 = [{2}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordBySql2)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],Cs函数名 = [{2}],Js函数名 = [{3}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordBySql2)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.FuncNameCs,objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabFeatureDA.AddNewRecordBySQL2(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabFeatureEN objTabFeatureEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabFeatureBL.IsExist(objTabFeatureEN.TabFeatureId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabFeatureEN.TabFeatureId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],表功能名 = [{2}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordBySql2WithReturnKey)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.TabFeatureName);
throw new Exception(strMsg);
}
if (bolIsNeedCheckUniqueness == true && objTabFeatureEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],功能Id = [{1}],Cs函数名 = [{2}],Js函数名 = [{3}]的数据已经存在!(in clsTabFeatureBL.AddNewRecordBySql2WithReturnKey)", objTabFeatureEN.TabId,objTabFeatureEN.FeatureId,objTabFeatureEN.FuncNameCs,objTabFeatureEN.FuncNameJs);
throw new Exception(strMsg);
}
try
{
string strKey = TabFeatureDA.AddNewRecordBySQL2WithReturnKey(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabFeatureEN objTabFeatureEN)
{
try
{
bool bolResult = TabFeatureDA.Update(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "objTabFeatureEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabFeatureEN objTabFeatureEN)
{
 if (string.IsNullOrEmpty(objTabFeatureEN.TabFeatureId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabFeatureDA.UpdateBySql2(objTabFeatureEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureBL.ReFreshCache(objTabFeatureEN.PrjId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
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
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTabFeatureId)
{
try
{
 clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);

if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(objTabFeatureEN.TabFeatureId, objTabFeatureEN.UpdUser);
}
if (objTabFeatureEN != null)
{
int intRecNum = TabFeatureDA.DelRecord(strTabFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabFeatureEN.PrjId);
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
/// <param name="strTabFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabFeatureId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
//删除与表:[TabFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabFeature.TabFeatureId,
//strTabFeatureId);
//        clsTabFeatureBL.DelTabFeaturesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFeatureBL.DelRecord(strTabFeatureId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFeatureBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTabFeatureId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabFeatureBL.relatedActions != null)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(strTabFeatureId, "UpdRelaTabDate");
}
bool bolResult = TabFeatureDA.DelRecord(strTabFeatureId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTabFeatureIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabFeatures(List<string> arrTabFeatureIdLst)
{
if (arrTabFeatureIdLst.Count == 0) return 0;
try
{
if (clsTabFeatureBL.relatedActions != null)
{
foreach (var strTabFeatureId in arrTabFeatureIdLst)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(strTabFeatureId, "UpdRelaTabDate");
}
}
 clsTabFeatureEN objTabFeatureEN = clsTabFeatureBL.GetObjByTabFeatureId(arrTabFeatureIdLst[0]);
int intDelRecNum = TabFeatureDA.DelTabFeature(arrTabFeatureIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabFeatureEN.PrjId);
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
public static int DelTabFeaturesByCond(string strWhereCond)
{
try
{
if (clsTabFeatureBL.relatedActions != null)
{
List<string> arrTabFeatureId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTabFeatureId in arrTabFeatureId)
{
clsTabFeatureBL.relatedActions.UpdRelaTabDate(strTabFeatureId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conTabFeature.PrjId, strWhereCond);
int intRecNum = TabFeatureDA.DelTabFeature(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabFeature]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTabFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTabFeatureId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFeatureDA.GetSpecSQLObj();
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
//删除与表:[TabFeature]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFeatureBL.DelRecord(strTabFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFeatureBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabFeatureENS">源对象</param>
 /// <param name = "objTabFeatureENT">目标对象</param>
 public static void CopyTo(clsTabFeatureEN objTabFeatureENS, clsTabFeatureEN objTabFeatureENT)
{
try
{
objTabFeatureENT.TabFeatureId = objTabFeatureENS.TabFeatureId; //表功能Id
objTabFeatureENT.TabFeatureName = objTabFeatureENS.TabFeatureName; //表功能名
objTabFeatureENT.TabId = objTabFeatureENS.TabId; //表ID
objTabFeatureENT.FeatureId = objTabFeatureENS.FeatureId; //功能Id
objTabFeatureENT.FuncNameCs = objTabFeatureENS.FuncNameCs; //Cs函数名
objTabFeatureENT.IsExtendedClass = objTabFeatureENS.IsExtendedClass; //是否在扩展类
objTabFeatureENT.FuncNameJs = objTabFeatureENS.FuncNameJs; //Js函数名
objTabFeatureENT.GetDdlDataFuncName4Ex = objTabFeatureENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objTabFeatureENT.IsForCSharp = objTabFeatureENS.IsForCSharp; //是否ForCSharp
objTabFeatureENT.IsForTypeScript = objTabFeatureENS.IsForTypeScript; //是否ForTypeScript
objTabFeatureENT.IsForDiv = objTabFeatureENS.IsForDiv; //是否针对Div内控件
objTabFeatureENT.IsNeedGC = objTabFeatureENS.IsNeedGC; //是否需要生成代码
objTabFeatureENT.UseTimes = objTabFeatureENS.UseTimes; //使用次数
objTabFeatureENT.OrderNum = objTabFeatureENS.OrderNum; //序号
objTabFeatureENT.IsNullable = objTabFeatureENS.IsNullable; //是否可空
objTabFeatureENT.InUse = objTabFeatureENS.InUse; //是否在用
objTabFeatureENT.CheckDate = objTabFeatureENS.CheckDate; //检查日期
objTabFeatureENT.ToolTipText = objTabFeatureENS.ToolTipText; //提示文字
objTabFeatureENT.ErrMsg = objTabFeatureENS.ErrMsg; //错误信息
objTabFeatureENT.PrjId = objTabFeatureENS.PrjId; //工程Id
objTabFeatureENT.UpdUser = objTabFeatureENS.UpdUser; //修改者
objTabFeatureENT.UpdDate = objTabFeatureENS.UpdDate; //修改日期
objTabFeatureENT.Memo = objTabFeatureENS.Memo; //说明
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
 /// <param name = "objTabFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsTabFeatureEN objTabFeatureEN)
{
try
{
objTabFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabFeature.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.TabFeatureId = objTabFeatureEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(conTabFeature.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.TabFeatureName = objTabFeatureEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(conTabFeature.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.TabId = objTabFeatureEN.TabId; //表ID
}
if (arrFldSet.Contains(conTabFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.FeatureId = objTabFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conTabFeature.FuncNameCs, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.FuncNameCs = objTabFeatureEN.FuncNameCs == "[null]" ? null :  objTabFeatureEN.FuncNameCs; //Cs函数名
}
if (arrFldSet.Contains(conTabFeature.IsExtendedClass, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsExtendedClass = objTabFeatureEN.IsExtendedClass; //是否在扩展类
}
if (arrFldSet.Contains(conTabFeature.FuncNameJs, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.FuncNameJs = objTabFeatureEN.FuncNameJs == "[null]" ? null :  objTabFeatureEN.FuncNameJs; //Js函数名
}
if (arrFldSet.Contains(conTabFeature.GetDdlDataFuncName4Ex, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.GetDdlDataFuncName4Ex = objTabFeatureEN.GetDdlDataFuncName4Ex == "[null]" ? null :  objTabFeatureEN.GetDdlDataFuncName4Ex; //获取Ddl函数名
}
if (arrFldSet.Contains(conTabFeature.IsForCSharp, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsForCSharp = objTabFeatureEN.IsForCSharp; //是否ForCSharp
}
if (arrFldSet.Contains(conTabFeature.IsForTypeScript, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsForTypeScript = objTabFeatureEN.IsForTypeScript; //是否ForTypeScript
}
if (arrFldSet.Contains(conTabFeature.IsForDiv, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsForDiv = objTabFeatureEN.IsForDiv; //是否针对Div内控件
}
if (arrFldSet.Contains(conTabFeature.IsNeedGC, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsNeedGC = objTabFeatureEN.IsNeedGC; //是否需要生成代码
}
if (arrFldSet.Contains(conTabFeature.UseTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.UseTimes = objTabFeatureEN.UseTimes; //使用次数
}
if (arrFldSet.Contains(conTabFeature.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.OrderNum = objTabFeatureEN.OrderNum; //序号
}
if (arrFldSet.Contains(conTabFeature.IsNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.IsNullable = objTabFeatureEN.IsNullable; //是否可空
}
if (arrFldSet.Contains(conTabFeature.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.InUse = objTabFeatureEN.InUse; //是否在用
}
if (arrFldSet.Contains(conTabFeature.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.CheckDate = objTabFeatureEN.CheckDate == "[null]" ? null :  objTabFeatureEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conTabFeature.ToolTipText, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.ToolTipText = objTabFeatureEN.ToolTipText == "[null]" ? null :  objTabFeatureEN.ToolTipText; //提示文字
}
if (arrFldSet.Contains(conTabFeature.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.ErrMsg = objTabFeatureEN.ErrMsg == "[null]" ? null :  objTabFeatureEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conTabFeature.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.PrjId = objTabFeatureEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.UpdUser = objTabFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conTabFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.UpdDate = objTabFeatureEN.UpdDate == "[null]" ? null :  objTabFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTabFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFeatureEN.Memo = objTabFeatureEN.Memo == "[null]" ? null :  objTabFeatureEN.Memo; //说明
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
 /// <param name = "objTabFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabFeatureEN objTabFeatureEN)
{
try
{
if (objTabFeatureEN.FuncNameCs == "[null]") objTabFeatureEN.FuncNameCs = null; //Cs函数名
if (objTabFeatureEN.FuncNameJs == "[null]") objTabFeatureEN.FuncNameJs = null; //Js函数名
if (objTabFeatureEN.GetDdlDataFuncName4Ex == "[null]") objTabFeatureEN.GetDdlDataFuncName4Ex = null; //获取Ddl函数名
if (objTabFeatureEN.CheckDate == "[null]") objTabFeatureEN.CheckDate = null; //检查日期
if (objTabFeatureEN.ToolTipText == "[null]") objTabFeatureEN.ToolTipText = null; //提示文字
if (objTabFeatureEN.ErrMsg == "[null]") objTabFeatureEN.ErrMsg = null; //错误信息
if (objTabFeatureEN.UpdDate == "[null]") objTabFeatureEN.UpdDate = null; //修改日期
if (objTabFeatureEN.Memo == "[null]") objTabFeatureEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTabFeatureEN objTabFeatureEN)
{
 TabFeatureDA.CheckPropertyNew(objTabFeatureEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabFeatureEN objTabFeatureEN)
{
 TabFeatureDA.CheckProperty4Condition(objTabFeatureEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabFeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[表功能]...","0");
List<clsTabFeatureEN> arrTabFeatureObjLst = GetAllTabFeatureObjLstCache(strPrjId); 
arrTabFeatureObjLst = arrTabFeatureObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conTabFeature.TabFeatureId;
objDDL.DataTextField = conTabFeature.TabFeatureName;
objDDL.DataSource = arrTabFeatureObjLst;
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
if (clsTabFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureBL没有刷新缓存机制(clsTabFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabFeatureId");
//if (arrTabFeatureObjLstCache == null)
//{
//arrTabFeatureObjLstCache = TabFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFeatureEN GetObjByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrTabFeatureObjLst_Sel =
arrTabFeatureObjLstCache
.Where(x=> x.TabFeatureId == strTabFeatureId 
);
if (arrTabFeatureObjLst_Sel.Count() == 0)
{
   clsTabFeatureEN obj = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrTabFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabFeatureNameByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//获取缓存中的对象列表
clsTabFeatureEN objTabFeature = GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objTabFeature == null) return "";
return objTabFeature.TabFeatureName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabFeatureIdCache(string strTabFeatureId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return "";
//获取缓存中的对象列表
clsTabFeatureEN objTabFeature = GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objTabFeature == null) return "";
return objTabFeature.TabFeatureName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureEN> GetAllTabFeatureObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsTabFeatureEN> arrTabFeatureObjLstCache = GetObjLstCache(strPrjId); 
return arrTabFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsTabFeatureEN> arrTabFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrTabFeatureObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsTabFeatureEN._RefreshTimeLst[clsTabFeatureEN._RefreshTimeLst.Count - 1];
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
if (clsTabFeatureBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabFeatureEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabFeatureBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabFeature(表功能)
 /// 唯一性条件:TabId_FeatureId_TabFeatureName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
string strResult = TabFeatureDA.GetUniCondStr(objTabFeatureEN);
return strResult;
}
 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabFeature(表功能)
 /// 唯一性条件:TabId_FeatureId_FuncName_Cs_FuncName_Js
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFeatureEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_V2(clsTabFeatureEN objTabFeatureEN)
{
//检测记录是否存在
string strResult = TabFeatureDA.GetUniCondStr(objTabFeatureEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTabFeatureId, string strPrjId)
{
if (strInFldName != conTabFeature.TabFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabFeature._AttributeName));
throw new Exception(strMsg);
}
var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(strTabFeatureId, strPrjId);
if (objTabFeature == null) return "";
return objTabFeature[strOutFldName].ToString();
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
int intRecCount = clsTabFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsTabFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabFeatureDA.GetRecCount();
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
int intRecCount = clsTabFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabFeatureEN objTabFeatureCond)
{
 string strPrjId = objTabFeatureCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsTabFeatureBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsTabFeatureEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFeature._AttributeName)
{
if (objTabFeatureCond.IsUpdated(strFldName) == false) continue;
if (objTabFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFeatureCond[strFldName].ToString());
}
else
{
if (objTabFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFeatureCond[strFldName]));
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
 List<string> arrList = clsTabFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabFeatureDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFeatureDA.SetFldValue(clsTabFeatureEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabFeatureDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFeatureDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFeatureDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFeatureDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabFeature] "); 
 strCreateTabCode.Append(" ( "); 
 // /**表功能Id*/ 
 strCreateTabCode.Append(" TabFeatureId char(8) primary key, "); 
 // /**表功能名*/ 
 strCreateTabCode.Append(" TabFeatureName varchar(100) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**Cs函数名*/ 
 strCreateTabCode.Append(" FuncNameCs varchar(100) Null, "); 
 // /**是否在扩展类*/ 
 strCreateTabCode.Append(" IsExtendedClass bit Null, "); 
 // /**Js函数名*/ 
 strCreateTabCode.Append(" FuncNameJs varchar(100) Null, "); 
 // /**获取Ddl函数名*/ 
 strCreateTabCode.Append(" GetDdlDataFuncName4Ex varchar(100) Null, "); 
 // /**是否ForCSharp*/ 
 strCreateTabCode.Append(" IsForCSharp bit Null, "); 
 // /**是否ForTypeScript*/ 
 strCreateTabCode.Append(" IsForTypeScript bit Null, "); 
 // /**是否针对Div内控件*/ 
 strCreateTabCode.Append(" IsForDiv bit Null, "); 
 // /**是否需要生成代码*/ 
 strCreateTabCode.Append(" IsNeedGC bit Null, "); 
 // /**使用次数*/ 
 strCreateTabCode.Append(" UseTimes int Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否可空*/ 
 strCreateTabCode.Append(" IsNullable bit Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**检查日期*/ 
 strCreateTabCode.Append(" CheckDate varchar(20) Null, "); 
 // /**提示文字*/ 
 strCreateTabCode.Append(" ToolTipText varchar(150) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) Null, "); 
 // /**父功能名*/ 
 strCreateTabCode.Append(" ParentFeatureName varchar(500) Null, "); 
 // /**功能模块简称*/ 
 strCreateTabCode.Append(" FuncModuleNameSim varchar(30) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**父功能Id*/ 
 strCreateTabCode.Append(" ParentFeatureId char(4) not Null, "); 
 // /**FuncName_JsEx*/ 
 strCreateTabCode.Append(" FuncNameJsEx varchar(50) Null, "); 
 // /**FuncName_CsEx*/ 
 strCreateTabCode.Append(" FuncNameCsEx varchar(50) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNames varchar(50) Null, "); 
 // /**函数s*/ 
 strCreateTabCode.Append(" FuncNames varchar(50) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：FeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strFeatureId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strFeatureId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsTabFeatureEN> arrTabFeatureObjList = new clsTabFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsTabFeatureEN objTabFeature in arrTabFeatureObjList)
{
objTabFeature.OrderNum = intIndex;
UpdateBySql2(objTabFeature);
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
/// 调整所给关键字记录的序号。根据分类字段：FeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strTabFeatureId">所给的关键字</param>
/// <param name="strFeatureId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strTabFeatureId ,string strFeatureId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[TabFeatureId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字TabFeatureId
//5、把当前关键字TabFeatureId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字TabFeatureId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevTabFeatureId = "";    //上一条序号的关键字TabFeatureId
string strNextTabFeatureId = "";    //下一条序号的关键字TabFeatureId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[TabFeatureId],获取相应的序号[OrderNum]。

clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureId(strTabFeatureId);

intOrderNum = objTabFeature.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);
intTabRecNum = clsTabFeatureBL.GetRecCountByCond(clsTabFeatureEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conTabFeature.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);
//4、获取上一个序号字段的关键字TabFeatureId
strPrevTabFeatureId = clsTabFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevTabFeatureId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字TabFeatureId所对应记录的序号减1
//6、把下(上)一个序号关键字TabFeatureId所对应的记录序号加1
clsTabFeatureBL.SetFldValue(clsTabFeatureEN._CurrTabName, conTabFeature.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conTabFeature.TabFeatureId, strTabFeatureId));
clsTabFeatureBL.SetFldValue(clsTabFeatureEN._CurrTabName, conTabFeature.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conTabFeature.TabFeatureId, strPrevTabFeatureId));
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

//4、获取下一个序号字段的关键字TabFeatureId
sbCondition.AppendFormat(" {0} = {1} ", conTabFeature.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);

strNextTabFeatureId = clsTabFeatureBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextTabFeatureId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字TabFeatureId所对应记录的序号加1
//6、把下(上)一个序号关键字TabFeatureId所对应的记录序号减1
clsTabFeatureBL.SetFldValue(clsTabFeatureEN._CurrTabName, conTabFeature.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conTabFeature.TabFeatureId, strTabFeatureId));
clsTabFeatureBL.SetFldValue(clsTabFeatureEN._CurrTabName, conTabFeature.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conTabFeature.TabFeatureId, strNextTabFeatureId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：FeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strFeatureId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conTabFeature.TabFeatureId, strKeyList);
List<clsTabFeatureEN> arrTabFeatureLst = GetObjLst(strCondition);
foreach (clsTabFeatureEN objTabFeature in arrTabFeatureLst)
{
objTabFeature.OrderNum = objTabFeature.OrderNum + 10000;
UpdateBySql2(objTabFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsTabFeatureEN> arrTabFeatureObjList = new clsTabFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsTabFeatureEN objTabFeature in arrTabFeatureObjList)
{
objTabFeature.OrderNum = intIndex;
UpdateBySql2(objTabFeature);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：FeatureId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strFeatureId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strFeatureId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conTabFeature.TabFeatureId, strKeyList);
List<clsTabFeatureEN> arrTabFeatureLst = GetObjLst(strCondition);
foreach (clsTabFeatureEN objTabFeature in arrTabFeatureLst)
{
objTabFeature.OrderNum = objTabFeature.OrderNum - 10000;
UpdateBySql2(objTabFeature);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conTabFeature.FeatureId, strFeatureId);
 strCondition += string.Format(" order by OrderNum ");
List<clsTabFeatureEN> arrTabFeatureObjList = new clsTabFeatureDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsTabFeatureEN objTabFeature in arrTabFeatureObjList)
{
objTabFeature.OrderNum = intIndex;
UpdateBySql2(objTabFeature);
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
 /// 表功能(TabFeature)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabFeature : clsCommFun4BLV2
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
clsTabFeatureBL.ReFreshThisCache(strPrjId);
}
}

}