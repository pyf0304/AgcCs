
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewMasterBL
 表名:ViewMaster(00050557)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsViewMasterBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewMasterEN GetObj(this K_ViewMasterId_ViewMaster myKey)
{
clsViewMasterEN objViewMasterEN = clsViewMasterBL.ViewMasterDA.GetObjByViewMasterId(myKey.Value);
return objViewMasterEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewMasterEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],应用程序类型ID = [{1}],界面母版名 = [{2}]的数据已经存在!(in clsViewMasterBL.AddNewRecord)", objViewMasterEN.PrjId,objViewMasterEN.ApplicationTypeId,objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
bool bolResult = clsViewMasterBL.ViewMasterDA.AddNewRecordBySQL2(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
public static bool AddRecordEx(this clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objViewMasterEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewMasterEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],应用程序类型ID(ApplicationTypeId)=[{1}],界面母版名(ViewMasterName)=[{2}])已经存在,不能重复!", objViewMasterEN.PrjId, objViewMasterEN.ApplicationTypeId, objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objViewMasterEN.AddNewRecord();
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewMasterEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],应用程序类型ID = [{1}],界面母版名 = [{2}]的数据已经存在!(in clsViewMasterBL.AddNewRecordWithMaxId)", objViewMasterEN.PrjId,objViewMasterEN.ApplicationTypeId,objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
string strViewMasterId = clsViewMasterBL.ViewMasterDA.AddNewRecordBySQL2WithReturnKey(objViewMasterEN);
     objViewMasterEN.ViewMasterId = strViewMasterId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
}
return strViewMasterId;
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewMasterEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],应用程序类型ID = [{1}],界面母版名 = [{2}]的数据已经存在!(in clsViewMasterBL.AddNewRecordWithReturnKey)", objViewMasterEN.PrjId,objViewMasterEN.ApplicationTypeId,objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
string strKey = clsViewMasterBL.ViewMasterDA.AddNewRecordBySQL2WithReturnKey(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterId(this clsViewMasterEN objViewMasterEN, string strViewMasterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, conViewMaster.ViewMasterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, conViewMaster.ViewMasterId);
}
objViewMasterEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterName(this clsViewMasterEN objViewMasterEN, string strViewMasterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewMasterName, conViewMaster.ViewMasterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterName, 50, conViewMaster.ViewMasterName);
}
objViewMasterEN.ViewMasterName = strViewMasterName; //界面母版名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterName) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterName, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterName] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterPath(this clsViewMasterEN objViewMasterEN, string strViewMasterPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewMasterPath, conViewMaster.ViewMasterPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewMasterPath, 100, conViewMaster.ViewMasterPath);
}
objViewMasterEN.ViewMasterPath = strViewMasterPath; //界面母版路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterPath) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterPath, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterPath] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetApplicationTypeId(this clsViewMasterEN objViewMasterEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewMaster.ApplicationTypeId);
objViewMasterEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ApplicationTypeId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ApplicationTypeId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ApplicationTypeId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetPrjId(this clsViewMasterEN objViewMasterEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewMaster.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewMaster.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewMaster.PrjId);
}
objViewMasterEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.PrjId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.PrjId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.PrjId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetUpdDate(this clsViewMasterEN objViewMasterEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewMaster.UpdDate);
}
objViewMasterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.UpdDate) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.UpdDate, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.UpdDate] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetUpdUser(this clsViewMasterEN objViewMasterEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewMaster.UpdUser);
}
objViewMasterEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.UpdUser) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.UpdUser, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.UpdUser] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetMemo(this clsViewMasterEN objViewMasterEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewMaster.Memo);
}
objViewMasterEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.Memo) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.Memo, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.Memo] = strComparisonOp;
}
}
return objViewMasterEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewMasterEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewMasterEN objViewMasterEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewMasterEN.CheckPropertyNew();
clsViewMasterEN objViewMasterCond = new clsViewMasterEN();
string strCondition = objViewMasterCond
.SetViewMasterId(objViewMasterEN.ViewMasterId, "<>")
.SetPrjId(objViewMasterEN.PrjId, "=")
.SetApplicationTypeId(objViewMasterEN.ApplicationTypeId, "=")
.SetViewMasterName(objViewMasterEN.ViewMasterName, "=")
.GetCombineCondition();
objViewMasterEN._IsCheckProperty = true;
bool bolIsExist = clsViewMasterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_ApplicationTypeId_ViewMasterName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewMasterEN.Update();
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
 /// <param name = "objViewMaster">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewMasterEN objViewMaster)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewMasterEN objViewMasterCond = new clsViewMasterEN();
string strCondition = objViewMasterCond
.SetPrjId(objViewMaster.PrjId, "=")
.SetApplicationTypeId(objViewMaster.ApplicationTypeId, "=")
.SetViewMasterName(objViewMaster.ViewMasterName, "=")
.GetCombineCondition();
objViewMaster._IsCheckProperty = true;
bool bolIsExist = clsViewMasterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewMaster.ViewMasterId = clsViewMasterBL.GetFirstID_S(strCondition);
objViewMaster.UpdateWithCondition(strCondition);
}
else
{
objViewMaster.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
objViewMaster.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewMasterEN objViewMasterEN)
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewMasterBL.ViewMasterDA.UpdateBySql2(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewMasterEN objViewMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewMasterBL.ViewMasterDA.UpdateBySql2(objViewMasterEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewMasterEN objViewMasterEN, string strWhereCond)
{
try
{
bool bolResult = clsViewMasterBL.ViewMasterDA.UpdateBySqlWithCondition(objViewMasterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewMasterEN objViewMasterEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewMasterBL.ViewMasterDA.UpdateBySqlWithConditionTransaction(objViewMasterEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewMasterEN objViewMasterEN)
{
try
{
int intRecNum = clsViewMasterBL.ViewMasterDA.DelRecord(objViewMasterEN.ViewMasterId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterENS">源对象</param>
 /// <param name = "objViewMasterENT">目标对象</param>
 public static void CopyTo(this clsViewMasterEN objViewMasterENS, clsViewMasterEN objViewMasterENT)
{
try
{
objViewMasterENT.ViewMasterId = objViewMasterENS.ViewMasterId; //界面母版Id
objViewMasterENT.ViewMasterName = objViewMasterENS.ViewMasterName; //界面母版名
objViewMasterENT.ViewMasterPath = objViewMasterENS.ViewMasterPath; //界面母版路径
objViewMasterENT.ApplicationTypeId = objViewMasterENS.ApplicationTypeId; //应用程序类型ID
objViewMasterENT.PrjId = objViewMasterENS.PrjId; //工程Id
objViewMasterENT.UpdDate = objViewMasterENS.UpdDate; //修改日期
objViewMasterENT.UpdUser = objViewMasterENS.UpdUser; //修改者
objViewMasterENT.Memo = objViewMasterENS.Memo; //说明
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
 /// <param name = "objViewMasterENS">源对象</param>
 /// <returns>目标对象=>clsViewMasterEN:objViewMasterENT</returns>
 public static clsViewMasterEN CopyTo(this clsViewMasterEN objViewMasterENS)
{
try
{
 clsViewMasterEN objViewMasterENT = new clsViewMasterEN()
{
ViewMasterId = objViewMasterENS.ViewMasterId, //界面母版Id
ViewMasterName = objViewMasterENS.ViewMasterName, //界面母版名
ViewMasterPath = objViewMasterENS.ViewMasterPath, //界面母版路径
ApplicationTypeId = objViewMasterENS.ApplicationTypeId, //应用程序类型ID
PrjId = objViewMasterENS.PrjId, //工程Id
UpdDate = objViewMasterENS.UpdDate, //修改日期
UpdUser = objViewMasterENS.UpdUser, //修改者
Memo = objViewMasterENS.Memo, //说明
};
 return objViewMasterENT;
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
public static void CheckPropertyNew(this clsViewMasterEN objViewMasterEN)
{
 clsViewMasterBL.ViewMasterDA.CheckPropertyNew(objViewMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewMasterEN objViewMasterEN)
{
 clsViewMasterBL.ViewMasterDA.CheckProperty4Condition(objViewMasterEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewMasterEN objViewMasterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterId, objViewMasterCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterName) == true)
{
string strComparisonOpViewMasterName = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterName, objViewMasterCond.ViewMasterName, strComparisonOpViewMasterName);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterPath) == true)
{
string strComparisonOpViewMasterPath = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterPath, objViewMasterCond.ViewMasterPath, strComparisonOpViewMasterPath);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewMasterCond.dicFldComparisonOp[conViewMaster.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewMaster.ApplicationTypeId, objViewMasterCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.PrjId) == true)
{
string strComparisonOpPrjId = objViewMasterCond.dicFldComparisonOp[conViewMaster.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.PrjId, objViewMasterCond.PrjId, strComparisonOpPrjId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewMasterCond.dicFldComparisonOp[conViewMaster.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.UpdDate, objViewMasterCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewMasterCond.IsUpdated(conViewMaster.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewMasterCond.dicFldComparisonOp[conViewMaster.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.UpdUser, objViewMasterCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewMasterCond.IsUpdated(conViewMaster.Memo) == true)
{
string strComparisonOpMemo = objViewMasterCond.dicFldComparisonOp[conViewMaster.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.Memo, objViewMasterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewMaster(界面母版), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_ApplicationTypeId_ViewMasterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewMasterEN objViewMasterEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewMasterEN == null) return true;
if (objViewMasterEN.ViewMasterId == null || objViewMasterEN.ViewMasterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
if (clsViewMasterBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewMasterId !=  '{0}'", objViewMasterEN.ViewMasterId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
if (clsViewMasterBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewMaster(界面母版), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ApplicationTypeId_ViewMasterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewMasterEN objViewMasterEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewMasterEN == null) return "";
if (objViewMasterEN.ViewMasterId == null || objViewMasterEN.ViewMasterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewMasterId !=  '{0}'", objViewMasterEN.ViewMasterId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewMaster
{
public virtual bool UpdRelaTabDate(string strViewMasterId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面母版(ViewMaster)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewMasterBL
{
public static RelatedActions_ViewMaster relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewMasterDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewMasterDA ViewMasterDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewMasterDA();
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
 public clsViewMasterBL()
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
if (string.IsNullOrEmpty(clsViewMasterEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewMasterEN._ConnectString);
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
public static DataTable GetDataTable_ViewMaster(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewMasterDA.GetDataTable_ViewMaster(strWhereCond);
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
objDT = ViewMasterDA.GetDataTable(strWhereCond);
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
objDT = ViewMasterDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewMasterDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewMasterDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewMasterDA.GetDataTable_Top(objTopPara);
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
objDT = ViewMasterDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewMasterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewMasterEN> GetObjLstByViewMasterIdLst(List<string> arrViewMasterIdLst)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewMasterIdLst, true);
 string strWhereCond = string.Format("ViewMasterId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewMasterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewMasterEN> GetObjLstByViewMasterIdLstCache(List<string> arrViewMasterIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel =
arrViewMasterObjLstCache
.Where(x => arrViewMasterIdLst.Contains(x.ViewMasterId));
return arrViewMasterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetObjLst(string strWhereCond)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
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
public static List<clsViewMasterEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewMasterEN> GetSubObjLstCache(clsViewMasterEN objViewMasterCond)
{
 string strPrjId = objViewMasterCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewMasterBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewMasterEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewMaster._AttributeName)
{
if (objViewMasterCond.IsUpdated(strFldName) == false) continue;
if (objViewMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewMasterCond[strFldName].ToString());
}
else
{
if (objViewMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewMasterCond[strFldName]));
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
public static List<clsViewMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
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
public static List<clsViewMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
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
List<clsViewMasterEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewMasterEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
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
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
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
public static List<clsViewMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewMasterEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
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
public static List<clsViewMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewMasterEN> arrObjLst = new List<clsViewMasterEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewMasterEN objViewMasterEN = new clsViewMasterEN();
try
{
objViewMasterEN.ViewMasterId = objRow[conViewMaster.ViewMasterId].ToString().Trim(); //界面母版Id
objViewMasterEN.ViewMasterName = objRow[conViewMaster.ViewMasterName].ToString().Trim(); //界面母版名
objViewMasterEN.ViewMasterPath = objRow[conViewMaster.ViewMasterPath].ToString().Trim(); //界面母版路径
objViewMasterEN.ApplicationTypeId = Int32.Parse(objRow[conViewMaster.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewMasterEN.PrjId = objRow[conViewMaster.PrjId].ToString().Trim(); //工程Id
objViewMasterEN.UpdDate = objRow[conViewMaster.UpdDate] == DBNull.Value ? null : objRow[conViewMaster.UpdDate].ToString().Trim(); //修改日期
objViewMasterEN.UpdUser = objRow[conViewMaster.UpdUser] == DBNull.Value ? null : objRow[conViewMaster.UpdUser].ToString().Trim(); //修改者
objViewMasterEN.Memo = objRow[conViewMaster.Memo] == DBNull.Value ? null : objRow[conViewMaster.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewMasterEN.ViewMasterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewMasterEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewMasterEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewMaster(ref clsViewMasterEN objViewMasterEN)
{
bool bolResult = ViewMasterDA.GetViewMaster(ref objViewMasterEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewMasterEN GetObjByViewMasterId(string strViewMasterId)
{
if (strViewMasterId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewMasterId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewMasterId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewMasterId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewMasterEN objViewMasterEN = ViewMasterDA.GetObjByViewMasterId(strViewMasterId);
return objViewMasterEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewMasterEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewMasterEN objViewMasterEN = ViewMasterDA.GetFirstObj(strWhereCond);
 return objViewMasterEN;
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
public static clsViewMasterEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewMasterEN objViewMasterEN = ViewMasterDA.GetObjByDataRow(objRow);
 return objViewMasterEN;
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
public static clsViewMasterEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewMasterEN objViewMasterEN = ViewMasterDA.GetObjByDataRow(objRow);
 return objViewMasterEN;
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
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <param name = "lstViewMasterObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewMasterEN GetObjByViewMasterIdFromList(string strViewMasterId, List<clsViewMasterEN> lstViewMasterObjLst)
{
foreach (clsViewMasterEN objViewMasterEN in lstViewMasterObjLst)
{
if (objViewMasterEN.ViewMasterId == strViewMasterId)
{
return objViewMasterEN;
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
 string strMaxViewMasterId;
 try
 {
 strMaxViewMasterId = clsViewMasterDA.GetMaxStrId();
 return strMaxViewMasterId;
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
 string strViewMasterId;
 try
 {
 strViewMasterId = new clsViewMasterDA().GetFirstID(strWhereCond);
 return strViewMasterId;
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
 arrList = ViewMasterDA.GetID(strWhereCond);
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
bool bolIsExist = ViewMasterDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewMasterId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewMasterId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ViewMasterDA.IsExist(strViewMasterId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewMasterId">界面母版Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewMasterId, string strOpUser)
{
clsViewMasterEN objViewMasterEN = clsViewMasterBL.GetObjByViewMasterId(strViewMasterId);
objViewMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewMasterEN.UpdUser = strOpUser;
return clsViewMasterBL.UpdateBySql2(objViewMasterEN);
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
 bolIsExist = clsViewMasterDA.IsExistTable();
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
 bolIsExist = ViewMasterDA.IsExistTable(strTabName);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewMasterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],应用程序类型ID = [{1}],界面母版名 = [{2}]的数据已经存在!(in clsViewMasterBL.AddNewRecordBySql2)", objViewMasterEN.PrjId,objViewMasterEN.ApplicationTypeId,objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
bool bolResult = ViewMasterDA.AddNewRecordBySQL2(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewMasterEN objViewMasterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewMasterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],应用程序类型ID = [{1}],界面母版名 = [{2}]的数据已经存在!(in clsViewMasterBL.AddNewRecordBySql2WithReturnKey)", objViewMasterEN.PrjId,objViewMasterEN.ApplicationTypeId,objViewMasterEN.ViewMasterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterBL.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterBL.GetMaxStrId_S();
 }
string strKey = ViewMasterDA.AddNewRecordBySQL2WithReturnKey(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewMasterEN objViewMasterEN)
{
try
{
bool bolResult = ViewMasterDA.Update(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewMasterEN objViewMasterEN)
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewMasterDA.UpdateBySql2(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterBL.ReFreshCache(objViewMasterEN.PrjId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
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
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewMasterId)
{
try
{
 clsViewMasterEN objViewMasterEN = clsViewMasterBL.GetObjByViewMasterId(strViewMasterId);

if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(objViewMasterEN.ViewMasterId, objViewMasterEN.UpdUser);
}
if (objViewMasterEN != null)
{
int intRecNum = ViewMasterDA.DelRecord(strViewMasterId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewMasterEN.PrjId);
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
/// <param name="strViewMasterId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewMasterId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewMasterDA.GetSpecSQLObj();
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
//删除与表:[ViewMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewMaster.ViewMasterId,
//strViewMasterId);
//        clsViewMasterBL.DelViewMastersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewMasterBL.DelRecord(strViewMasterId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewMasterBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewMasterId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewMasterId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewMasterId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewMasterBL.relatedActions != null)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(strViewMasterId, "UpdRelaTabDate");
}
bool bolResult = ViewMasterDA.DelRecord(strViewMasterId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewMasterIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewMasters(List<string> arrViewMasterIdLst)
{
if (arrViewMasterIdLst.Count == 0) return 0;
try
{
if (clsViewMasterBL.relatedActions != null)
{
foreach (var strViewMasterId in arrViewMasterIdLst)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(strViewMasterId, "UpdRelaTabDate");
}
}
 clsViewMasterEN objViewMasterEN = clsViewMasterBL.GetObjByViewMasterId(arrViewMasterIdLst[0]);
int intDelRecNum = ViewMasterDA.DelViewMaster(arrViewMasterIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewMasterEN.PrjId);
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
public static int DelViewMastersByCond(string strWhereCond)
{
try
{
if (clsViewMasterBL.relatedActions != null)
{
List<string> arrViewMasterId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewMasterId in arrViewMasterId)
{
clsViewMasterBL.relatedActions.UpdRelaTabDate(strViewMasterId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewMaster.PrjId, strWhereCond);
int intRecNum = ViewMasterDA.DelViewMaster(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewMaster]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewMasterId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewMasterId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewMasterDA.GetSpecSQLObj();
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
//删除与表:[ViewMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewMasterBL.DelRecord(strViewMasterId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewMasterBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewMasterId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewMasterENS">源对象</param>
 /// <param name = "objViewMasterENT">目标对象</param>
 public static void CopyTo(clsViewMasterEN objViewMasterENS, clsViewMasterEN objViewMasterENT)
{
try
{
objViewMasterENT.ViewMasterId = objViewMasterENS.ViewMasterId; //界面母版Id
objViewMasterENT.ViewMasterName = objViewMasterENS.ViewMasterName; //界面母版名
objViewMasterENT.ViewMasterPath = objViewMasterENS.ViewMasterPath; //界面母版路径
objViewMasterENT.ApplicationTypeId = objViewMasterENS.ApplicationTypeId; //应用程序类型ID
objViewMasterENT.PrjId = objViewMasterENS.PrjId; //工程Id
objViewMasterENT.UpdDate = objViewMasterENS.UpdDate; //修改日期
objViewMasterENT.UpdUser = objViewMasterENS.UpdUser; //修改者
objViewMasterENT.Memo = objViewMasterENS.Memo; //说明
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
 /// <param name = "objViewMasterEN">源简化对象</param>
 public static void SetUpdFlag(clsViewMasterEN objViewMasterEN)
{
try
{
objViewMasterEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewMasterEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewMaster.ViewMasterId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.ViewMasterId = objViewMasterEN.ViewMasterId; //界面母版Id
}
if (arrFldSet.Contains(conViewMaster.ViewMasterName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.ViewMasterName = objViewMasterEN.ViewMasterName; //界面母版名
}
if (arrFldSet.Contains(conViewMaster.ViewMasterPath, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.ViewMasterPath = objViewMasterEN.ViewMasterPath; //界面母版路径
}
if (arrFldSet.Contains(conViewMaster.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.ApplicationTypeId = objViewMasterEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conViewMaster.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.PrjId = objViewMasterEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewMaster.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.UpdDate = objViewMasterEN.UpdDate == "[null]" ? null :  objViewMasterEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewMaster.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.UpdUser = objViewMasterEN.UpdUser == "[null]" ? null :  objViewMasterEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewMaster.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewMasterEN.Memo = objViewMasterEN.Memo == "[null]" ? null :  objViewMasterEN.Memo; //说明
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
 /// <param name = "objViewMasterEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewMasterEN objViewMasterEN)
{
try
{
if (objViewMasterEN.UpdDate == "[null]") objViewMasterEN.UpdDate = null; //修改日期
if (objViewMasterEN.UpdUser == "[null]") objViewMasterEN.UpdUser = null; //修改者
if (objViewMasterEN.Memo == "[null]") objViewMasterEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewMasterEN objViewMasterEN)
{
 ViewMasterDA.CheckPropertyNew(objViewMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewMasterEN objViewMasterEN)
{
 ViewMasterDA.CheckProperty4Condition(objViewMasterEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "intApplicationTypeId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewMasterId(System.Windows.Forms.ComboBox objComboBox , int intApplicationTypeId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewMaster.ViewMasterId); 
List<clsViewMasterEN> arrObjLst = clsViewMasterBL.GetObjLst(strCondition).OrderBy(x=>x.ViewMasterName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.ApplicationTypeId == intApplicationTypeId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewMasterEN objViewMasterEN = new clsViewMasterEN()
{
ViewMasterId = "0",
ViewMasterName = "选[界面母版]..."
};
arrObjLstSel.Insert(0, objViewMasterEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewMaster.ViewMasterId;
objComboBox.DisplayMember = conViewMaster.ViewMasterName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "intApplicationTypeId"></param>
 /// <param name = "strPrjId"></param>
public static void BindDdl_ViewMasterId(System.Web.UI.WebControls.DropDownList objDDL , int intApplicationTypeId,string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面母版]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conViewMaster.ViewMasterId); 
IEnumerable<clsViewMasterEN> arrObjLst = clsViewMasterBL.GetObjLst(strCondition).OrderBy(x=>x.ViewMasterName);
var arrObjLstSel = arrObjLst.Where(x=>x.ApplicationTypeId == intApplicationTypeId&& x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conViewMaster.ViewMasterId;
objDDL.DataTextField = conViewMaster.ViewMasterName;
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
public static void BindDdl_ViewMasterIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面母版]...","0");
List<clsViewMasterEN> arrViewMasterObjLst = GetAllViewMasterObjLstCache(strPrjId); 
objDDL.DataValueField = conViewMaster.ViewMasterId;
objDDL.DataTextField = conViewMaster.ViewMasterName;
objDDL.DataSource = arrViewMasterObjLst;
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
if (clsViewMasterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewMasterBL没有刷新缓存机制(clsViewMasterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewMasterId");
//if (arrViewMasterObjLstCache == null)
//{
//arrViewMasterObjLstCache = ViewMasterDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewMasterEN GetObjByViewMasterIdCache(string strViewMasterId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel =
arrViewMasterObjLstCache
.Where(x=> x.ViewMasterId == strViewMasterId 
);
if (arrViewMasterObjLst_Sel.Count() == 0)
{
   clsViewMasterEN obj = clsViewMasterBL.GetObjByViewMasterId(strViewMasterId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewMasterId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewMasterObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewMasterNameByViewMasterIdCache(string strViewMasterId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return "";
//获取缓存中的对象列表
clsViewMasterEN objViewMaster = GetObjByViewMasterIdCache(strViewMasterId, strPrjId);
if (objViewMaster == null) return "";
return objViewMaster.ViewMasterName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewMasterIdCache(string strViewMasterId, string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return "";
//获取缓存中的对象列表
clsViewMasterEN objViewMaster = GetObjByViewMasterIdCache(strViewMasterId, strPrjId);
if (objViewMaster == null) return "";
return objViewMaster.ViewMasterName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewMasterEN> GetAllViewMasterObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId); 
return arrViewMasterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewMasterEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewMasterObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewMasterEN._RefreshTimeLst.Count == 0) return "";
return clsViewMasterEN._RefreshTimeLst[clsViewMasterEN._RefreshTimeLst.Count - 1];
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
if (clsViewMasterBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewMasterBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewMaster(界面母版)
 /// 唯一性条件:PrjId_ApplicationTypeId_ViewMasterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewMasterEN objViewMasterEN)
{
//检测记录是否存在
string strResult = ViewMasterDA.GetUniCondStr(objViewMasterEN);
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
public static string Func(string strInFldName, string strOutFldName, string strViewMasterId, string strPrjId)
{
if (strInFldName != conViewMaster.ViewMasterId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewMaster._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewMaster._AttributeName));
throw new Exception(strMsg);
}
var objViewMaster = clsViewMasterBL.GetObjByViewMasterIdCache(strViewMasterId, strPrjId);
if (objViewMaster == null) return "";
return objViewMaster[strOutFldName].ToString();
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
int intRecCount = clsViewMasterDA.GetRecCount(strTabName);
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
int intRecCount = clsViewMasterDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewMasterDA.GetRecCount();
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
int intRecCount = clsViewMasterDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewMasterEN objViewMasterCond)
{
 string strPrjId = objViewMasterCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewMasterBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewMasterEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewMaster._AttributeName)
{
if (objViewMasterCond.IsUpdated(strFldName) == false) continue;
if (objViewMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewMasterCond[strFldName].ToString());
}
else
{
if (objViewMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewMasterCond[strFldName]));
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
 List<string> arrList = clsViewMasterDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewMasterDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewMasterDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewMasterDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewMasterDA.SetFldValue(clsViewMasterEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewMasterDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewMasterDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewMasterDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewMasterDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewMaster] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面母版Id*/ 
 strCreateTabCode.Append(" ViewMasterId char(8) primary key, "); 
 // /**界面母版名*/ 
 strCreateTabCode.Append(" ViewMasterName varchar(50) not Null, "); 
 // /**界面母版路径*/ 
 strCreateTabCode.Append(" ViewMasterPath varchar(100) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面母版(ViewMaster)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewMaster : clsCommFun4BLV2
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
clsViewMasterBL.ReFreshThisCache(strPrjId);
}
}

}