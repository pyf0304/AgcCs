
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModule_AgcBL
 表名:FuncModule_Agc(00050015)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsFuncModule_AgcBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncModule_AgcEN GetObj(this K_FuncModuleAgcId_FuncModule_Agc myKey)
{
clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.FuncModule_AgcDA.GetObjByFuncModuleAgcId(myKey.Value);
return objFuncModule_AgcEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncModule_AgcEN) == false)
{
var strMsg = string.Format("记录已经存在!功能模块名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFuncModule_AgcBL.AddNewRecord)", objFuncModule_AgcEN.FuncModuleName,objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFuncModule_AgcBL.FuncModule_AgcDA.AddNewRecordBySQL2(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
public static bool AddRecordEx(this clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFuncModule_AgcEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFuncModule_AgcEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能模块名称(FuncModuleName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objFuncModule_AgcEN.FuncModuleName, objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFuncModule_AgcEN.AddNewRecord();
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncModule_AgcEN) == false)
{
var strMsg = string.Format("记录已经存在!功能模块名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFuncModule_AgcBL.AddNewRecordWithMaxId)", objFuncModule_AgcEN.FuncModuleName,objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true || clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
     objFuncModule_AgcEN.FuncModuleAgcId = clsFuncModule_AgcBL.GetMaxStrIdByPrefix_S(objFuncModule_AgcEN.PrjId);
 }
string strFuncModuleAgcId = clsFuncModule_AgcBL.FuncModule_AgcDA.AddNewRecordBySQL2WithReturnKey(objFuncModule_AgcEN);
     objFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
}
return strFuncModuleAgcId;
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncModule_AgcEN) == false)
{
var strMsg = string.Format("记录已经存在!功能模块名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFuncModule_AgcBL.AddNewRecordWithReturnKey)", objFuncModule_AgcEN.FuncModuleName,objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFuncModule_AgcBL.FuncModule_AgcDA.AddNewRecordBySQL2WithReturnKey(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleAgcId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conFuncModule_Agc.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conFuncModule_Agc.FuncModuleAgcId);
}
objFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleAgcId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleName(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conFuncModule_Agc.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conFuncModule_Agc.FuncModuleName);
}
objFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleName) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleEnName(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conFuncModule_Agc.FuncModuleEnName);
}
objFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleEnName) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleNameSim(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conFuncModule_Agc.FuncModuleNameSim);
}
objFuncModule_AgcEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleNameSim) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleNameSim, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleNameSim] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetPrjId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFuncModule_Agc.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFuncModule_Agc.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFuncModule_Agc.PrjId);
}
objFuncModule_AgcEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.PrjId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.PrjId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.PrjId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetOrderNum(this clsFuncModule_AgcEN objFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFuncModule_Agc.OrderNum);
objFuncModule_AgcEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.OrderNum) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUseStateId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conFuncModule_Agc.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conFuncModule_Agc.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conFuncModule_Agc.UseStateId);
}
objFuncModule_AgcEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UseStateId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUpdUser(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncModule_Agc.UpdUser);
}
objFuncModule_AgcEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UpdUser) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUpdDate(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncModule_Agc.UpdDate);
}
objFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UpdDate) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetMemo(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncModule_Agc.Memo);
}
objFuncModule_AgcEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.Memo) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncModule_AgcEN.CheckPropertyNew();
clsFuncModule_AgcEN objFuncModule_AgcCond = new clsFuncModule_AgcEN();
string strCondition = objFuncModule_AgcCond
.SetFuncModuleAgcId(objFuncModule_AgcEN.FuncModuleAgcId, "<>")
.SetFuncModuleName(objFuncModule_AgcEN.FuncModuleName, "=")
.SetPrjId(objFuncModule_AgcEN.PrjId, "=")
.GetCombineCondition();
objFuncModule_AgcEN._IsCheckProperty = true;
bool bolIsExist = clsFuncModule_AgcBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncModuleName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncModule_AgcEN.Update();
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
 /// <param name = "objFuncModule_Agc">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFuncModule_AgcEN objFuncModule_Agc)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFuncModule_AgcEN objFuncModule_AgcCond = new clsFuncModule_AgcEN();
string strCondition = objFuncModule_AgcCond
.SetFuncModuleName(objFuncModule_Agc.FuncModuleName, "=")
.SetPrjId(objFuncModule_Agc.PrjId, "=")
.GetCombineCondition();
objFuncModule_Agc._IsCheckProperty = true;
bool bolIsExist = clsFuncModule_AgcBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFuncModule_Agc.FuncModuleAgcId = clsFuncModule_AgcBL.GetFirstID_S(strCondition);
objFuncModule_Agc.UpdateWithCondition(strCondition);
}
else
{
objFuncModule_Agc.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncModule_AgcBL.FuncModule_AgcDA.UpdateBySql2(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncModule_AgcEN objFuncModule_AgcEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncModule_AgcBL.FuncModule_AgcDA.UpdateBySql2(objFuncModule_AgcEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncModule_AgcBL.FuncModule_AgcDA.UpdateBySqlWithCondition(objFuncModule_AgcEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncModule_AgcBL.FuncModule_AgcDA.UpdateBySqlWithConditionTransaction(objFuncModule_AgcEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
try
{
int intRecNum = clsFuncModule_AgcBL.FuncModule_AgcDA.DelRecord(objFuncModule_AgcEN.FuncModuleAgcId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(this clsFuncModule_AgcEN objFuncModule_AgcENS, clsFuncModule_AgcEN objFuncModule_AgcENT)
{
try
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleNameSim = objFuncModule_AgcENS.FuncModuleNameSim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程Id
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
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
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <returns>目标对象=>clsFuncModule_AgcEN:objFuncModule_AgcENT</returns>
 public static clsFuncModule_AgcEN CopyTo(this clsFuncModule_AgcEN objFuncModule_AgcENS)
{
try
{
 clsFuncModule_AgcEN objFuncModule_AgcENT = new clsFuncModule_AgcEN()
{
FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objFuncModule_AgcENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName, //功能模块英文名称
FuncModuleNameSim = objFuncModule_AgcENS.FuncModuleNameSim, //功能模块简称
PrjId = objFuncModule_AgcENS.PrjId, //工程Id
OrderNum = objFuncModule_AgcENS.OrderNum, //序号
UseStateId = objFuncModule_AgcENS.UseStateId, //使用状态Id
UpdUser = objFuncModule_AgcENS.UpdUser, //修改者
UpdDate = objFuncModule_AgcENS.UpdDate, //修改日期
Memo = objFuncModule_AgcENS.Memo, //说明
};
 return objFuncModule_AgcENT;
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
public static void CheckPropertyNew(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 clsFuncModule_AgcBL.FuncModule_AgcDA.CheckPropertyNew(objFuncModule_AgcEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 clsFuncModule_AgcBL.FuncModule_AgcDA.CheckProperty4Condition(objFuncModule_AgcEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncModule_AgcEN objFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleAgcId, objFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleName, objFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleEnName, objFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleNameSim, objFuncModule_AgcCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.PrjId) == true)
{
string strComparisonOpPrjId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.PrjId, objFuncModule_AgcCond.PrjId, strComparisonOpPrjId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncModule_Agc.OrderNum, objFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UseStateId, objFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UpdUser, objFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UpdDate, objFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.Memo, objFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FuncModule_Agc(模块), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncModuleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFuncModule_AgcEN == null) return true;
if (objFuncModule_AgcEN.FuncModuleAgcId == null || objFuncModule_AgcEN.FuncModuleAgcId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
if (clsFuncModule_AgcBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncModuleAgcId !=  '{0}'", objFuncModule_AgcEN.FuncModuleAgcId);
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
if (clsFuncModule_AgcBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FuncModule_Agc(模块), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncModuleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncModule_AgcEN == null) return "";
if (objFuncModule_AgcEN.FuncModuleAgcId == null || objFuncModule_AgcEN.FuncModuleAgcId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncModuleAgcId !=  '{0}'", objFuncModule_AgcEN.FuncModuleAgcId);
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncModule_Agc
{
public virtual bool UpdRelaTabDate(string strFuncModuleAgcId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 模块(FuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncModule_AgcBL
{
public static RelatedActions_FuncModule_Agc relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncModule_AgcDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncModule_AgcDA FuncModule_AgcDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncModule_AgcDA();
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
 public clsFuncModule_AgcBL()
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
if (string.IsNullOrEmpty(clsFuncModule_AgcEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncModule_AgcEN._ConnectString);
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
public static DataTable GetDataTable_FuncModule_Agc(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncModule_AgcDA.GetDataTable_FuncModule_Agc(strWhereCond);
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
objDT = FuncModule_AgcDA.GetDataTable(strWhereCond);
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
objDT = FuncModule_AgcDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncModule_AgcDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncModule_AgcDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncModule_AgcDA.GetDataTable_Top(objTopPara);
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
objDT = FuncModule_AgcDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcIdLst)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleAgcIdLst, true);
 string strWhereCond = string.Format("FuncModuleAgcId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel =
arrFuncModule_AgcObjLstCache
.Where(x => arrFuncModuleAgcIdLst.Contains(x.FuncModuleAgcId));
return arrFuncModule_AgcObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
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
public static List<clsFuncModule_AgcEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncModule_AgcEN> GetSubObjLstCache(clsFuncModule_AgcEN objFuncModule_AgcCond)
{
 string strPrjId = objFuncModule_AgcCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsFuncModule_AgcBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsFuncModule_AgcEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncModule_Agc._AttributeName)
{
if (objFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncModule_AgcCond[strFldName]));
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
public static List<clsFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
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
public static List<clsFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
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
List<clsFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
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
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
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
public static List<clsFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
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
public static List<clsFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncModule_AgcEN> arrObjLst = new List<clsFuncModule_AgcEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN();
try
{
objFuncModule_AgcEN.FuncModuleAgcId = objRow[conFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objFuncModule_AgcEN.FuncModuleName = objRow[conFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objFuncModule_AgcEN.FuncModuleEnName = objRow[conFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objFuncModule_AgcEN.FuncModuleNameSim = objRow[conFuncModule_Agc.FuncModuleNameSim] == DBNull.Value ? null : objRow[conFuncModule_Agc.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objFuncModule_AgcEN.PrjId = objRow[conFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[conFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objFuncModule_AgcEN.UseStateId = objRow[conFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objFuncModule_AgcEN.UpdUser = objRow[conFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
objFuncModule_AgcEN.UpdDate = objRow[conFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[conFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objFuncModule_AgcEN.Memo = objRow[conFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[conFuncModule_Agc.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncModule_AgcEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncModule_Agc(ref clsFuncModule_AgcEN objFuncModule_AgcEN)
{
bool bolResult = FuncModule_AgcDA.GetFuncModule_Agc(ref objFuncModule_AgcEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleAgcId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleAgcId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFuncModule_AgcEN objFuncModule_AgcEN = FuncModule_AgcDA.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
return objFuncModule_AgcEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncModule_AgcEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncModule_AgcEN objFuncModule_AgcEN = FuncModule_AgcDA.GetFirstObj(strWhereCond);
 return objFuncModule_AgcEN;
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
public static clsFuncModule_AgcEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncModule_AgcEN objFuncModule_AgcEN = FuncModule_AgcDA.GetObjByDataRow(objRow);
 return objFuncModule_AgcEN;
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
public static clsFuncModule_AgcEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncModule_AgcEN objFuncModule_AgcEN = FuncModule_AgcDA.GetObjByDataRow(objRow);
 return objFuncModule_AgcEN;
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
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "lstFuncModule_AgcObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncModule_AgcEN GetObjByFuncModuleAgcIdFromList(string strFuncModuleAgcId, List<clsFuncModule_AgcEN> lstFuncModule_AgcObjLst)
{
foreach (clsFuncModule_AgcEN objFuncModule_AgcEN in lstFuncModule_AgcObjLst)
{
if (objFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId)
{
return objFuncModule_AgcEN;
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
 string strMaxFuncModuleAgcId;
 try
 {
 strMaxFuncModuleAgcId = new clsFuncModule_AgcDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxFuncModuleAgcId;
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
 string strFuncModuleAgcId;
 try
 {
 strFuncModuleAgcId = new clsFuncModule_AgcDA().GetFirstID(strWhereCond);
 return strFuncModuleAgcId;
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
 arrList = FuncModule_AgcDA.GetID(strWhereCond);
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
bool bolIsExist = FuncModule_AgcDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleAgcId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FuncModule_AgcDA.IsExist(strFuncModuleAgcId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncModuleAgcId">功能模块Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncModuleAgcId, string strOpUser)
{
clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
objFuncModule_AgcEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFuncModule_AgcEN.UpdUser = strOpUser;
return clsFuncModule_AgcBL.UpdateBySql2(objFuncModule_AgcEN);
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
 bolIsExist = clsFuncModule_AgcDA.IsExistTable();
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
 bolIsExist = FuncModule_AgcDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objFuncModule_AgcEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能模块名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFuncModule_AgcBL.AddNewRecordBySql2)", objFuncModule_AgcEN.FuncModuleName,objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FuncModule_AgcDA.AddNewRecordBySQL2(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncModule_AgcEN objFuncModule_AgcEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModule_AgcBL.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objFuncModule_AgcEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能模块名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsFuncModule_AgcBL.AddNewRecordBySql2WithReturnKey)", objFuncModule_AgcEN.FuncModuleName,objFuncModule_AgcEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = FuncModule_AgcDA.AddNewRecordBySQL2WithReturnKey(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
try
{
bool bolResult = FuncModule_AgcDA.Update(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncModule_AgcDA.UpdateBySql2(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcBL.ReFreshCache(objFuncModule_AgcEN.PrjId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncModuleAgcId)
{
try
{
 clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);

if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(objFuncModule_AgcEN.FuncModuleAgcId, objFuncModule_AgcEN.UpdUser);
}
if (objFuncModule_AgcEN != null)
{
int intRecNum = FuncModule_AgcDA.DelRecord(strFuncModuleAgcId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFuncModule_AgcEN.PrjId);
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
/// <param name="strFuncModuleAgcId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncModuleAgcId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncModule_AgcDA.GetSpecSQLObj();
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
//删除与表:[FuncModule_Agc]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncModule_Agc.FuncModuleAgcId,
//strFuncModuleAgcId);
//        clsFuncModule_AgcBL.DelFuncModule_AgcsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncModule_AgcBL.DelRecord(strFuncModuleAgcId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncModule_AgcBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncModuleAgcId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFuncModule_AgcBL.relatedActions != null)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
bool bolResult = FuncModule_AgcDA.DelRecord(strFuncModuleAgcId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncModuleAgcIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFuncModule_Agcs(List<string> arrFuncModuleAgcIdLst)
{
if (arrFuncModuleAgcIdLst.Count == 0) return 0;
try
{
if (clsFuncModule_AgcBL.relatedActions != null)
{
foreach (var strFuncModuleAgcId in arrFuncModuleAgcIdLst)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
}
 clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId(arrFuncModuleAgcIdLst[0]);
int intDelRecNum = FuncModule_AgcDA.DelFuncModule_Agc(arrFuncModuleAgcIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFuncModule_AgcEN.PrjId);
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
public static int DelFuncModule_AgcsByCond(string strWhereCond)
{
try
{
if (clsFuncModule_AgcBL.relatedActions != null)
{
List<string> arrFuncModuleAgcId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncModuleAgcId in arrFuncModuleAgcId)
{
clsFuncModule_AgcBL.relatedActions.UpdRelaTabDate(strFuncModuleAgcId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conFuncModule_Agc.PrjId, strWhereCond);
int intRecNum = FuncModule_AgcDA.DelFuncModule_Agc(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FuncModule_Agc]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncModuleAgcId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncModuleAgcId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncModule_AgcDA.GetSpecSQLObj();
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
//删除与表:[FuncModule_Agc]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncModule_AgcBL.DelRecord(strFuncModuleAgcId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncModule_AgcBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsFuncModule_AgcEN objFuncModule_AgcENS, clsFuncModule_AgcEN objFuncModule_AgcENT)
{
try
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleNameSim = objFuncModule_AgcENS.FuncModuleNameSim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程Id
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
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
 /// <param name = "objFuncModule_AgcEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
try
{
objFuncModule_AgcEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFuncModule_AgcEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncModule_Agc.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.FuncModuleAgcId = objFuncModule_AgcEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conFuncModule_Agc.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.FuncModuleName = objFuncModule_AgcEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(conFuncModule_Agc.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.FuncModuleEnName = objFuncModule_AgcEN.FuncModuleEnName == "[null]" ? null :  objFuncModule_AgcEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(conFuncModule_Agc.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.FuncModuleNameSim = objFuncModule_AgcEN.FuncModuleNameSim == "[null]" ? null :  objFuncModule_AgcEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(conFuncModule_Agc.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.PrjId = objFuncModule_AgcEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFuncModule_Agc.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.OrderNum = objFuncModule_AgcEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFuncModule_Agc.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.UseStateId = objFuncModule_AgcEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(conFuncModule_Agc.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.UpdUser = objFuncModule_AgcEN.UpdUser == "[null]" ? null :  objFuncModule_AgcEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFuncModule_Agc.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.UpdDate = objFuncModule_AgcEN.UpdDate == "[null]" ? null :  objFuncModule_AgcEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFuncModule_Agc.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncModule_AgcEN.Memo = objFuncModule_AgcEN.Memo == "[null]" ? null :  objFuncModule_AgcEN.Memo; //说明
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
 /// <param name = "objFuncModule_AgcEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
try
{
if (objFuncModule_AgcEN.FuncModuleEnName == "[null]") objFuncModule_AgcEN.FuncModuleEnName = null; //功能模块英文名称
if (objFuncModule_AgcEN.FuncModuleNameSim == "[null]") objFuncModule_AgcEN.FuncModuleNameSim = null; //功能模块简称
if (objFuncModule_AgcEN.UpdUser == "[null]") objFuncModule_AgcEN.UpdUser = null; //修改者
if (objFuncModule_AgcEN.UpdDate == "[null]") objFuncModule_AgcEN.UpdDate = null; //修改日期
if (objFuncModule_AgcEN.Memo == "[null]") objFuncModule_AgcEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 FuncModule_AgcDA.CheckPropertyNew(objFuncModule_AgcEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 FuncModule_AgcDA.CheckProperty4Condition(objFuncModule_AgcEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_FuncModuleAgcId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncModule_Agc.FuncModuleAgcId); 
List<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN()
{
FuncModuleAgcId = "0",
FuncModuleName = "选[模块]..."
};
arrObjLstSel.Insert(0, objFuncModule_AgcEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncModule_Agc.FuncModuleAgcId;
objComboBox.DisplayMember = conFuncModule_Agc.FuncModuleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[模块]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFuncModule_Agc.FuncModuleAgcId); 
IEnumerable<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
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
public static void BindDdl_FuncModuleAgcIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[模块]...","0");
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst = GetAllFuncModule_AgcObjLstCache(strPrjId); 
arrFuncModule_AgcObjLst = arrFuncModule_AgcObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
objDDL.DataSource = arrFuncModule_AgcObjLst;
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
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleAgcId");
//if (arrFuncModule_AgcObjLstCache == null)
//{
//arrFuncModule_AgcObjLstCache = FuncModule_AgcDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncModule_AgcEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel =
arrFuncModule_AgcObjLstCache
.Where(x=> x.FuncModuleAgcId == strFuncModuleAgcId 
);
if (arrFuncModule_AgcObjLst_Sel.Count() == 0)
{
   clsFuncModule_AgcEN obj = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFuncModuleAgcId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrFuncModule_AgcObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleAgcIdCache(string strFuncModuleAgcId, string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//获取缓存中的对象列表
clsFuncModule_AgcEN objFuncModule_Agc = GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId, strPrjId);
if (objFuncModule_Agc == null) return "";
return objFuncModule_Agc.FuncModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleAgcIdCache(string strFuncModuleAgcId, string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//获取缓存中的对象列表
clsFuncModule_AgcEN objFuncModule_Agc = GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId, strPrjId);
if (objFuncModule_Agc == null) return "";
return objFuncModule_Agc.FuncModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModule_AgcEN> GetAllFuncModule_AgcObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId); 
return arrFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrFuncModule_AgcObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFuncModule_AgcEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFuncModule_AgcEN._RefreshTimeLst.Count == 0) return "";
return clsFuncModule_AgcEN._RefreshTimeLst[clsFuncModule_AgcEN._RefreshTimeLst.Count - 1];
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
if (clsFuncModule_AgcBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFuncModule_AgcEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFuncModule_AgcBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FuncModule_Agc(模块)
 /// 唯一性条件:FuncModuleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
//检测记录是否存在
string strResult = FuncModule_AgcDA.GetUniCondStr(objFuncModule_AgcEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleAgcId, string strPrjId)
{
if (strInFldName != conFuncModule_Agc.FuncModuleAgcId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncModule_Agc._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncModule_Agc._AttributeName));
throw new Exception(strMsg);
}
var objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId, strPrjId);
if (objFuncModule_Agc == null) return "";
return objFuncModule_Agc[strOutFldName].ToString();
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
int intRecCount = clsFuncModule_AgcDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncModule_AgcDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncModule_AgcDA.GetRecCount();
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
int intRecCount = clsFuncModule_AgcDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncModule_AgcEN objFuncModule_AgcCond)
{
 string strPrjId = objFuncModule_AgcCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsFuncModule_AgcBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsFuncModule_AgcEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncModule_Agc._AttributeName)
{
if (objFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncModule_AgcCond[strFldName]));
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
 List<string> arrList = clsFuncModule_AgcDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncModule_AgcDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncModule_AgcDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncModule_AgcDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncModule_AgcDA.SetFldValue(clsFuncModule_AgcEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncModule_AgcDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncModule_AgcDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncModule_AgcDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncModule_AgcDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncModule_Agc] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) primary key, "); 
 // /**功能模块名称*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) not Null, "); 
 // /**功能模块英文名称*/ 
 strCreateTabCode.Append(" FuncModuleEnName varchar(30) Null, "); 
 // /**功能模块简称*/ 
 strCreateTabCode.Append(" FuncModuleNameSim varchar(30) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**使用状态Id*/ 
 strCreateTabCode.Append(" UseStateId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**使用状态名称*/ 
 strCreateTabCode.Append(" UseStateName varchar(30) Null, "); 
 // /**界面数*/ 
 strCreateTabCode.Append(" ViewNum int Null, "); 
 // /**表数*/ 
 strCreateTabCode.Append(" TabNum int Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strPrjId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strPrjId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = new clsFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList)
{
objFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objFuncModule_Agc);
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
/// 调整所给关键字记录的序号。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strFuncModuleAgcId">所给的关键字</param>
/// <param name="strPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strFuncModuleAgcId ,string strPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FuncModuleAgcId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FuncModuleAgcId
//5、把当前关键字FuncModuleAgcId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFuncModuleAgcId = "";    //上一条序号的关键字FuncModuleAgcId
string strNextFuncModuleAgcId = "";    //下一条序号的关键字FuncModuleAgcId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[FuncModuleAgcId],获取相应的序号[OrderNum]。

clsFuncModule_AgcEN objFuncModule_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);

intOrderNum = objFuncModule_Agc.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);
intTabRecNum = clsFuncModule_AgcBL.GetRecCountByCond(clsFuncModule_AgcEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conFuncModule_Agc.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);
//4、获取上一个序号字段的关键字FuncModuleAgcId
strPrevFuncModuleAgcId = clsFuncModule_AgcBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevFuncModuleAgcId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleAgcId所对应记录的序号减1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号加1
clsFuncModule_AgcBL.SetFldValue(clsFuncModule_AgcEN._CurrTabName, conFuncModule_Agc.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conFuncModule_Agc.FuncModuleAgcId, strFuncModuleAgcId));
clsFuncModule_AgcBL.SetFldValue(clsFuncModule_AgcEN._CurrTabName, conFuncModule_Agc.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFuncModule_Agc.FuncModuleAgcId, strPrevFuncModuleAgcId));
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

//4、获取下一个序号字段的关键字FuncModuleAgcId
sbCondition.AppendFormat(" {0} = {1} ", conFuncModule_Agc.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);

strNextFuncModuleAgcId = clsFuncModule_AgcBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextFuncModuleAgcId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FuncModuleAgcId所对应记录的序号加1
//6、把下(上)一个序号关键字FuncModuleAgcId所对应的记录序号减1
clsFuncModule_AgcBL.SetFldValue(clsFuncModule_AgcEN._CurrTabName, conFuncModule_Agc.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFuncModule_Agc.FuncModuleAgcId, strFuncModuleAgcId));
clsFuncModule_AgcBL.SetFldValue(clsFuncModule_AgcEN._CurrTabName, conFuncModule_Agc.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conFuncModule_Agc.FuncModuleAgcId, strNextFuncModuleAgcId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conFuncModule_Agc.FuncModuleAgcId, strKeyList);
List<clsFuncModule_AgcEN> arrFuncModule_AgcLst = GetObjLst(strCondition);
foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcLst)
{
objFuncModule_Agc.OrderNum = objFuncModule_Agc.OrderNum + 10000;
UpdateBySql2(objFuncModule_Agc);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = new clsFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList)
{
objFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objFuncModule_Agc);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strPrjId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conFuncModule_Agc.FuncModuleAgcId, strKeyList);
List<clsFuncModule_AgcEN> arrFuncModule_AgcLst = GetObjLst(strCondition);
foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcLst)
{
objFuncModule_Agc.OrderNum = objFuncModule_Agc.OrderNum - 10000;
UpdateBySql2(objFuncModule_Agc);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFuncModule_Agc.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjList = new clsFuncModule_AgcDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFuncModule_AgcEN objFuncModule_Agc in arrFuncModule_AgcObjList)
{
objFuncModule_Agc.OrderNum = intIndex;
UpdateBySql2(objFuncModule_Agc);
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
 /// 模块(FuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FuncModule_Agc : clsCommFun4BLV2
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
clsFuncModule_AgcBL.ReFreshThisCache(strPrjId);
}
}

}