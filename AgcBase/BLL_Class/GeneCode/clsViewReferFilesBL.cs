
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewReferFilesBL
 表名:ViewReferFiles(00050465)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsViewReferFilesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewReferFilesEN GetObj(this K_mId_ViewReferFiles myKey)
{
clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesBL.ViewReferFilesDA.GetObjBymId(myKey.Value);
return objViewReferFilesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewReferFilesEN objViewReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewReferFilesEN) == false)
{
var strMsg = string.Format("记录已经存在!引用文件Id = [{0}],界面Id = [{1}],代码类型Id = [{2}]的数据已经存在!(in clsViewReferFilesBL.AddNewRecord)", objViewReferFilesEN.ReferFileId,objViewReferFilesEN.ViewId,objViewReferFilesEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewReferFilesBL.ViewReferFilesDA.AddNewRecordBySQL2(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
public static bool AddRecordEx(this clsViewReferFilesEN objViewReferFilesEN, bool bolIsNeedCheckUniqueness = true)
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
objViewReferFilesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewReferFilesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(引用文件Id(ReferFileId)=[{0}],界面Id(ViewId)=[{1}],代码类型Id(CodeTypeId)=[{2}])已经存在,不能重复!", objViewReferFilesEN.ReferFileId, objViewReferFilesEN.ViewId, objViewReferFilesEN.CodeTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewReferFilesEN.AddNewRecord();
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewReferFilesEN objViewReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewReferFilesEN) == false)
{
var strMsg = string.Format("记录已经存在!引用文件Id = [{0}],界面Id = [{1}],代码类型Id = [{2}]的数据已经存在!(in clsViewReferFilesBL.AddNewRecordWithReturnKey)", objViewReferFilesEN.ReferFileId,objViewReferFilesEN.ViewId,objViewReferFilesEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewReferFilesBL.ViewReferFilesDA.AddNewRecordBySQL2WithReturnKey(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetmId(this clsViewReferFilesEN objViewReferFilesEN, long lngmId, string strComparisonOp="")
	{
objViewReferFilesEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.mId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.mId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.mId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetViewId(this clsViewReferFilesEN objViewReferFilesEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewReferFiles.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewReferFiles.ViewId);
}
objViewReferFilesEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.ViewId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.ViewId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.ViewId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetCodeTypeId(this clsViewReferFilesEN objViewReferFilesEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conViewReferFiles.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conViewReferFiles.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conViewReferFiles.CodeTypeId);
}
objViewReferFilesEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.CodeTypeId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.CodeTypeId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.CodeTypeId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetReferFileId(this clsViewReferFilesEN objViewReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReferFileId, conViewReferFiles.ReferFileId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileId, 8, conViewReferFiles.ReferFileId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, conViewReferFiles.ReferFileId);
}
objViewReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.ReferFileId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.ReferFileId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.ReferFileId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetInUse(this clsViewReferFilesEN objViewReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objViewReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.InUse) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.InUse, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.InUse] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetOrderNum(this clsViewReferFilesEN objViewReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conViewReferFiles.OrderNum);
objViewReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.OrderNum) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.OrderNum, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.OrderNum] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetIsTemplate(this clsViewReferFilesEN objViewReferFilesEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conViewReferFiles.IsTemplate);
objViewReferFilesEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.IsTemplate) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.IsTemplate, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.IsTemplate] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetPrjId(this clsViewReferFilesEN objViewReferFilesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewReferFiles.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewReferFiles.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewReferFiles.PrjId);
}
objViewReferFilesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.PrjId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.PrjId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.PrjId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetUpdDate(this clsViewReferFilesEN objViewReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conViewReferFiles.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewReferFiles.UpdDate);
}
objViewReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.UpdDate) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.UpdDate, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.UpdDate] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetUpdUserId(this clsViewReferFilesEN objViewReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conViewReferFiles.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conViewReferFiles.UpdUserId);
}
objViewReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.UpdUserId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.UpdUserId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.UpdUserId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetMemo(this clsViewReferFilesEN objViewReferFilesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewReferFiles.Memo);
}
objViewReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.Memo) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.Memo, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.Memo] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewReferFilesEN objViewReferFilesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewReferFilesEN.CheckPropertyNew();
clsViewReferFilesEN objViewReferFilesCond = new clsViewReferFilesEN();
string strCondition = objViewReferFilesCond
.SetmId(objViewReferFilesEN.mId, "<>")
.SetReferFileId(objViewReferFilesEN.ReferFileId, "=")
.SetViewId(objViewReferFilesEN.ViewId, "=")
.SetCodeTypeId(objViewReferFilesEN.CodeTypeId, "=")
.GetCombineCondition();
objViewReferFilesEN._IsCheckProperty = true;
bool bolIsExist = clsViewReferFilesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewId_CodeTypeId_ReferFileId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewReferFilesEN.Update();
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
 /// <param name = "objViewReferFiles">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewReferFilesEN objViewReferFiles)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewReferFilesEN objViewReferFilesCond = new clsViewReferFilesEN();
string strCondition = objViewReferFilesCond
.SetReferFileId(objViewReferFiles.ReferFileId, "=")
.SetViewId(objViewReferFiles.ViewId, "=")
.SetCodeTypeId(objViewReferFiles.CodeTypeId, "=")
.GetCombineCondition();
objViewReferFiles._IsCheckProperty = true;
bool bolIsExist = clsViewReferFilesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewReferFiles.mId = clsViewReferFilesBL.GetFirstID_S(strCondition);
objViewReferFiles.UpdateWithCondition(strCondition);
}
else
{
objViewReferFiles.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewReferFilesEN objViewReferFilesEN)
{
 if (objViewReferFilesEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewReferFilesBL.ViewReferFilesDA.UpdateBySql2(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewReferFilesEN objViewReferFilesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewReferFilesEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewReferFilesBL.ViewReferFilesDA.UpdateBySql2(objViewReferFilesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewReferFilesEN objViewReferFilesEN, string strWhereCond)
{
try
{
bool bolResult = clsViewReferFilesBL.ViewReferFilesDA.UpdateBySqlWithCondition(objViewReferFilesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewReferFilesEN objViewReferFilesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewReferFilesBL.ViewReferFilesDA.UpdateBySqlWithConditionTransaction(objViewReferFilesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
public static int Delete(this clsViewReferFilesEN objViewReferFilesEN)
{
try
{
int intRecNum = clsViewReferFilesBL.ViewReferFilesDA.DelRecord(objViewReferFilesEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesENS">源对象</param>
 /// <param name = "objViewReferFilesENT">目标对象</param>
 public static void CopyTo(this clsViewReferFilesEN objViewReferFilesENS, clsViewReferFilesEN objViewReferFilesENT)
{
try
{
objViewReferFilesENT.mId = objViewReferFilesENS.mId; //mId
objViewReferFilesENT.ViewId = objViewReferFilesENS.ViewId; //界面Id
objViewReferFilesENT.CodeTypeId = objViewReferFilesENS.CodeTypeId; //代码类型Id
objViewReferFilesENT.ReferFileId = objViewReferFilesENS.ReferFileId; //引用文件Id
objViewReferFilesENT.InUse = objViewReferFilesENS.InUse; //是否在用
objViewReferFilesENT.OrderNum = objViewReferFilesENS.OrderNum; //序号
objViewReferFilesENT.IsTemplate = objViewReferFilesENS.IsTemplate; //是否模板
objViewReferFilesENT.PrjId = objViewReferFilesENS.PrjId; //工程Id
objViewReferFilesENT.UpdDate = objViewReferFilesENS.UpdDate; //修改日期
objViewReferFilesENT.UpdUserId = objViewReferFilesENS.UpdUserId; //修改用户Id
objViewReferFilesENT.Memo = objViewReferFilesENS.Memo; //说明
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
 /// <param name = "objViewReferFilesENS">源对象</param>
 /// <returns>目标对象=>clsViewReferFilesEN:objViewReferFilesENT</returns>
 public static clsViewReferFilesEN CopyTo(this clsViewReferFilesEN objViewReferFilesENS)
{
try
{
 clsViewReferFilesEN objViewReferFilesENT = new clsViewReferFilesEN()
{
mId = objViewReferFilesENS.mId, //mId
ViewId = objViewReferFilesENS.ViewId, //界面Id
CodeTypeId = objViewReferFilesENS.CodeTypeId, //代码类型Id
ReferFileId = objViewReferFilesENS.ReferFileId, //引用文件Id
InUse = objViewReferFilesENS.InUse, //是否在用
OrderNum = objViewReferFilesENS.OrderNum, //序号
IsTemplate = objViewReferFilesENS.IsTemplate, //是否模板
PrjId = objViewReferFilesENS.PrjId, //工程Id
UpdDate = objViewReferFilesENS.UpdDate, //修改日期
UpdUserId = objViewReferFilesENS.UpdUserId, //修改用户Id
Memo = objViewReferFilesENS.Memo, //说明
};
 return objViewReferFilesENT;
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
public static void CheckPropertyNew(this clsViewReferFilesEN objViewReferFilesEN)
{
 clsViewReferFilesBL.ViewReferFilesDA.CheckPropertyNew(objViewReferFilesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewReferFilesEN objViewReferFilesEN)
{
 clsViewReferFilesBL.ViewReferFilesDA.CheckProperty4Condition(objViewReferFilesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewReferFilesEN objViewReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.mId) == true)
{
string strComparisonOpmId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewReferFiles.mId, objViewReferFilesCond.mId, strComparisonOpmId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.ViewId) == true)
{
string strComparisonOpViewId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.ViewId, objViewReferFilesCond.ViewId, strComparisonOpViewId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.CodeTypeId, objViewReferFilesCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.ReferFileId, objViewReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.InUse) == true)
{
if (objViewReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewReferFiles.InUse);
}
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewReferFiles.OrderNum, objViewReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.IsTemplate) == true)
{
if (objViewReferFilesCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewReferFiles.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewReferFiles.IsTemplate);
}
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.PrjId) == true)
{
string strComparisonOpPrjId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.PrjId, objViewReferFilesCond.PrjId, strComparisonOpPrjId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.UpdDate, objViewReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.UpdUserId, objViewReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.Memo) == true)
{
string strComparisonOpMemo = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.Memo, objViewReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewReferFiles(界面引用文件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewId_CodeTypeId_ReferFileId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewReferFilesEN objViewReferFilesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewReferFilesEN == null) return true;
if (objViewReferFilesEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 if (objViewReferFilesEN.ViewId == null)
{
 sbCondition.AppendFormat(" and ViewId is null", objViewReferFilesEN.ViewId);
}
else
{
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
}
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
if (clsViewReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewReferFilesEN.mId);
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
if (clsViewReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewReferFiles(界面引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewId_CodeTypeId_ReferFileId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewReferFilesEN objViewReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewReferFilesEN == null) return "";
if (objViewReferFilesEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 if (objViewReferFilesEN.ViewId == null)
{
 sbCondition.AppendFormat(" and ViewId is null", objViewReferFilesEN.ViewId);
}
else
{
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
}
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewReferFilesEN.mId);
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewReferFiles
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面引用文件(ViewReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewReferFilesBL
{
public static RelatedActions_ViewReferFiles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewReferFilesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewReferFilesDA ViewReferFilesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewReferFilesDA();
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
 public clsViewReferFilesBL()
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
if (string.IsNullOrEmpty(clsViewReferFilesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewReferFilesEN._ConnectString);
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
public static DataTable GetDataTable_ViewReferFiles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewReferFilesDA.GetDataTable_ViewReferFiles(strWhereCond);
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
objDT = ViewReferFilesDA.GetDataTable(strWhereCond);
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
objDT = ViewReferFilesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewReferFilesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewReferFilesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewReferFilesDA.GetDataTable_Top(objTopPara);
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
objDT = ViewReferFilesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsViewReferFilesEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
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
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewReferFilesEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
List<clsViewReferFilesEN> arrViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewReferFilesEN> arrViewReferFilesObjLst_Sel =
arrViewReferFilesObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrViewReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewReferFilesEN> GetObjLst(string strWhereCond)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
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
public static List<clsViewReferFilesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewReferFilesEN> GetSubObjLstCache(clsViewReferFilesEN objViewReferFilesCond)
{
 string strPrjId = objViewReferFilesCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewReferFilesBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewReferFilesEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewReferFiles._AttributeName)
{
if (objViewReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objViewReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewReferFilesCond[strFldName].ToString());
}
else
{
if (objViewReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewReferFilesCond[strFldName]));
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
public static List<clsViewReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
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
public static List<clsViewReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
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
List<clsViewReferFilesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewReferFilesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
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
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
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
public static List<clsViewReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
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
public static List<clsViewReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewReferFilesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewReferFilesEN> arrObjLst = new List<clsViewReferFilesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewReferFilesEN objViewReferFilesEN = new clsViewReferFilesEN();
try
{
objViewReferFilesEN.mId = Int32.Parse(objRow[conViewReferFiles.mId].ToString().Trim()); //mId
objViewReferFilesEN.ViewId = objRow[conViewReferFiles.ViewId] == DBNull.Value ? null : objRow[conViewReferFiles.ViewId].ToString().Trim(); //界面Id
objViewReferFilesEN.CodeTypeId = objRow[conViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objViewReferFilesEN.ReferFileId = objRow[conViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.InUse].ToString().Trim()); //是否在用
objViewReferFilesEN.OrderNum = Int32.Parse(objRow[conViewReferFiles.OrderNum].ToString().Trim()); //序号
objViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objViewReferFilesEN.PrjId = objRow[conViewReferFiles.PrjId].ToString().Trim(); //工程Id
objViewReferFilesEN.UpdDate = objRow[conViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objViewReferFilesEN.UpdUserId = objRow[conViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objViewReferFilesEN.Memo = objRow[conViewReferFiles.Memo] == DBNull.Value ? null : objRow[conViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewReferFilesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewReferFilesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewReferFiles(ref clsViewReferFilesEN objViewReferFilesEN)
{
bool bolResult = ViewReferFilesDA.GetViewReferFiles(ref objViewReferFilesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewReferFilesEN GetObjBymId(long lngmId)
{
clsViewReferFilesEN objViewReferFilesEN = ViewReferFilesDA.GetObjBymId(lngmId);
return objViewReferFilesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewReferFilesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewReferFilesEN objViewReferFilesEN = ViewReferFilesDA.GetFirstObj(strWhereCond);
 return objViewReferFilesEN;
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
public static clsViewReferFilesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewReferFilesEN objViewReferFilesEN = ViewReferFilesDA.GetObjByDataRow(objRow);
 return objViewReferFilesEN;
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
public static clsViewReferFilesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewReferFilesEN objViewReferFilesEN = ViewReferFilesDA.GetObjByDataRow(objRow);
 return objViewReferFilesEN;
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
 /// <param name = "lstViewReferFilesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewReferFilesEN GetObjBymIdFromList(long lngmId, List<clsViewReferFilesEN> lstViewReferFilesObjLst)
{
foreach (clsViewReferFilesEN objViewReferFilesEN in lstViewReferFilesObjLst)
{
if (objViewReferFilesEN.mId == lngmId)
{
return objViewReferFilesEN;
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
 lngmId = new clsViewReferFilesDA().GetFirstID(strWhereCond);
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
 arrList = ViewReferFilesDA.GetID(strWhereCond);
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
bool bolIsExist = ViewReferFilesDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ViewReferFilesDA.IsExist(lngmId);
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
clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesBL.GetObjBymId(lngmId);
objViewReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewReferFilesEN.UpdUserId = strOpUser;
return clsViewReferFilesBL.UpdateBySql2(objViewReferFilesEN);
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
 bolIsExist = clsViewReferFilesDA.IsExistTable();
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
 bolIsExist = ViewReferFilesDA.IsExistTable(strTabName);
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewReferFilesEN objViewReferFilesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewReferFilesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!引用文件Id = [{0}],界面Id = [{1}],代码类型Id = [{2}]的数据已经存在!(in clsViewReferFilesBL.AddNewRecordBySql2)", objViewReferFilesEN.ReferFileId,objViewReferFilesEN.ViewId,objViewReferFilesEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewReferFilesDA.AddNewRecordBySQL2(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewReferFilesEN objViewReferFilesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewReferFilesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!引用文件Id = [{0}],界面Id = [{1}],代码类型Id = [{2}]的数据已经存在!(in clsViewReferFilesBL.AddNewRecordBySql2WithReturnKey)", objViewReferFilesEN.ReferFileId,objViewReferFilesEN.ViewId,objViewReferFilesEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewReferFilesDA.AddNewRecordBySQL2WithReturnKey(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewReferFilesEN objViewReferFilesEN)
{
try
{
bool bolResult = ViewReferFilesDA.Update(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewReferFilesEN objViewReferFilesEN)
{
 if (objViewReferFilesEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewReferFilesDA.UpdateBySql2(objViewReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewReferFilesBL.ReFreshCache(objViewReferFilesEN.PrjId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
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
 clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesBL.GetObjBymId(lngmId);

if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(objViewReferFilesEN.mId, objViewReferFilesEN.UpdUserId);
}
if (objViewReferFilesEN != null)
{
int intRecNum = ViewReferFilesDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewReferFilesEN.PrjId);
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
objSQL = clsViewReferFilesDA.GetSpecSQLObj();
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
//删除与表:[ViewReferFiles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewReferFiles.mId,
//lngmId);
//        clsViewReferFilesBL.DelViewReferFilessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewReferFilesBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewReferFilesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsViewReferFilesBL.relatedActions != null)
{
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewReferFilesDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelViewReferFiless(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsViewReferFilesBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ViewReferFilesDA.DelViewReferFiles(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewReferFilesEN.PrjId);
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
public static int DelViewReferFilessByCond(string strWhereCond)
{
try
{
if (clsViewReferFilesBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewReferFilesBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewReferFiles.PrjId, strWhereCond);
int intRecNum = ViewReferFilesDA.DelViewReferFiles(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewReferFiles]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewReferFilesDA.GetSpecSQLObj();
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
//删除与表:[ViewReferFiles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewReferFilesBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewReferFilesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objViewReferFilesENS">源对象</param>
 /// <param name = "objViewReferFilesENT">目标对象</param>
 public static void CopyTo(clsViewReferFilesEN objViewReferFilesENS, clsViewReferFilesEN objViewReferFilesENT)
{
try
{
objViewReferFilesENT.mId = objViewReferFilesENS.mId; //mId
objViewReferFilesENT.ViewId = objViewReferFilesENS.ViewId; //界面Id
objViewReferFilesENT.CodeTypeId = objViewReferFilesENS.CodeTypeId; //代码类型Id
objViewReferFilesENT.ReferFileId = objViewReferFilesENS.ReferFileId; //引用文件Id
objViewReferFilesENT.InUse = objViewReferFilesENS.InUse; //是否在用
objViewReferFilesENT.OrderNum = objViewReferFilesENS.OrderNum; //序号
objViewReferFilesENT.IsTemplate = objViewReferFilesENS.IsTemplate; //是否模板
objViewReferFilesENT.PrjId = objViewReferFilesENS.PrjId; //工程Id
objViewReferFilesENT.UpdDate = objViewReferFilesENS.UpdDate; //修改日期
objViewReferFilesENT.UpdUserId = objViewReferFilesENS.UpdUserId; //修改用户Id
objViewReferFilesENT.Memo = objViewReferFilesENS.Memo; //说明
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
 /// <param name = "objViewReferFilesEN">源简化对象</param>
 public static void SetUpdFlag(clsViewReferFilesEN objViewReferFilesEN)
{
try
{
objViewReferFilesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewReferFilesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewReferFiles.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.mId = objViewReferFilesEN.mId; //mId
}
if (arrFldSet.Contains(conViewReferFiles.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.ViewId = objViewReferFilesEN.ViewId == "[null]" ? null :  objViewReferFilesEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewReferFiles.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.CodeTypeId = objViewReferFilesEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conViewReferFiles.ReferFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.ReferFileId = objViewReferFilesEN.ReferFileId; //引用文件Id
}
if (arrFldSet.Contains(conViewReferFiles.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.InUse = objViewReferFilesEN.InUse; //是否在用
}
if (arrFldSet.Contains(conViewReferFiles.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.OrderNum = objViewReferFilesEN.OrderNum; //序号
}
if (arrFldSet.Contains(conViewReferFiles.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.IsTemplate = objViewReferFilesEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conViewReferFiles.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.PrjId = objViewReferFilesEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewReferFiles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.UpdDate = objViewReferFilesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewReferFiles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.UpdUserId = objViewReferFilesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conViewReferFiles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewReferFilesEN.Memo = objViewReferFilesEN.Memo == "[null]" ? null :  objViewReferFilesEN.Memo; //说明
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
 /// <param name = "objViewReferFilesEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewReferFilesEN objViewReferFilesEN)
{
try
{
if (objViewReferFilesEN.ViewId == "[null]") objViewReferFilesEN.ViewId = null; //界面Id
if (objViewReferFilesEN.Memo == "[null]") objViewReferFilesEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewReferFilesEN objViewReferFilesEN)
{
 ViewReferFilesDA.CheckPropertyNew(objViewReferFilesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewReferFilesEN objViewReferFilesEN)
{
 ViewReferFilesDA.CheckProperty4Condition(objViewReferFilesEN);
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
if (clsViewReferFilesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewReferFilesBL没有刷新缓存机制(clsViewReferFilesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrViewReferFilesObjLstCache == null)
//{
//arrViewReferFilesObjLstCache = ViewReferFilesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewReferFilesEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
List<clsViewReferFilesEN> arrViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewReferFilesEN> arrViewReferFilesObjLst_Sel =
arrViewReferFilesObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrViewReferFilesObjLst_Sel.Count() == 0)
{
   clsViewReferFilesEN obj = clsViewReferFilesBL.GetObjBymId(lngmId);
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
return arrViewReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewReferFilesEN> GetAllViewReferFilesObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewReferFilesEN> arrViewReferFilesObjLstCache = GetObjLstCache(strPrjId); 
return arrViewReferFilesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewReferFilesEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewReferFilesEN> arrViewReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewReferFilesObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewReferFilesEN._RefreshTimeLst.Count == 0) return "";
return clsViewReferFilesEN._RefreshTimeLst[clsViewReferFilesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewReferFilesBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewReferFilesBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsViewReferFilesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewReferFilesBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewReferFiles(界面引用文件)
 /// 唯一性条件:ViewId_CodeTypeId_ReferFileId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewReferFilesEN objViewReferFilesEN)
{
//检测记录是否存在
string strResult = ViewReferFilesDA.GetUniCondStr(objViewReferFilesEN);
return strResult;
}


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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conViewReferFiles.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewReferFiles._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewReferFiles._AttributeName));
throw new Exception(strMsg);
}
var objViewReferFiles = clsViewReferFilesBL.GetObjBymIdCache(lngmId, strPrjId);
if (objViewReferFiles == null) return "";
return objViewReferFiles[strOutFldName].ToString();
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
int intRecCount = clsViewReferFilesDA.GetRecCount(strTabName);
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
int intRecCount = clsViewReferFilesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewReferFilesDA.GetRecCount();
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
int intRecCount = clsViewReferFilesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewReferFilesEN objViewReferFilesCond)
{
 string strPrjId = objViewReferFilesCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewReferFilesBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewReferFilesEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewReferFiles._AttributeName)
{
if (objViewReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objViewReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewReferFilesCond[strFldName].ToString());
}
else
{
if (objViewReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewReferFilesCond[strFldName]));
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
 List<string> arrList = clsViewReferFilesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewReferFilesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewReferFilesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewReferFilesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewReferFilesDA.SetFldValue(clsViewReferFilesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewReferFilesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewReferFilesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewReferFilesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewReferFilesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewReferFiles] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) not Null, "); 
 // /**引用文件Id*/ 
 strCreateTabCode.Append(" ReferFileId char(8) not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：ViewId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strViewId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strViewId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewReferFilesEN> arrViewReferFilesObjList = new clsViewReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewReferFilesEN objViewReferFiles in arrViewReferFilesObjList)
{
objViewReferFiles.OrderNum = intIndex;
UpdateBySql2(objViewReferFiles);
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
/// 调整所给关键字记录的序号。根据分类字段：ViewId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strViewId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strViewId)
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

clsViewReferFilesEN objViewReferFiles = clsViewReferFilesBL.GetObjBymId(lngmId);

intOrderNum = objViewReferFiles.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);
intTabRecNum = clsViewReferFilesBL.GetRecCountByCond(clsViewReferFilesEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conViewReferFiles.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsViewReferFilesBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsViewReferFilesBL.SetFldValue(clsViewReferFilesEN._CurrTabName, conViewReferFiles.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conViewReferFiles.mId, lngmId));
clsViewReferFilesBL.SetFldValue(clsViewReferFilesEN._CurrTabName, conViewReferFiles.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conViewReferFiles.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conViewReferFiles.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);

lngNextmId = clsViewReferFilesBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsViewReferFilesBL.SetFldValue(clsViewReferFilesEN._CurrTabName, conViewReferFiles.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conViewReferFiles.mId, lngmId));
clsViewReferFilesBL.SetFldValue(clsViewReferFilesEN._CurrTabName, conViewReferFiles.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conViewReferFiles.mId, lngNextmId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ViewId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strViewId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conViewReferFiles.mId, strKeyList);
List<clsViewReferFilesEN> arrViewReferFilesLst = GetObjLst(strCondition);
foreach (clsViewReferFilesEN objViewReferFiles in arrViewReferFilesLst)
{
objViewReferFiles.OrderNum = objViewReferFiles.OrderNum + 10000;
UpdateBySql2(objViewReferFiles);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewReferFilesEN> arrViewReferFilesObjList = new clsViewReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewReferFilesEN objViewReferFiles in arrViewReferFilesObjList)
{
objViewReferFiles.OrderNum = intIndex;
UpdateBySql2(objViewReferFiles);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ViewId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strViewId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strViewId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conViewReferFiles.mId, strKeyList);
List<clsViewReferFilesEN> arrViewReferFilesLst = GetObjLst(strCondition);
foreach (clsViewReferFilesEN objViewReferFiles in arrViewReferFilesLst)
{
objViewReferFiles.OrderNum = objViewReferFiles.OrderNum - 10000;
UpdateBySql2(objViewReferFiles);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conViewReferFiles.ViewId, strViewId);
 strCondition += string.Format(" order by OrderNum ");
List<clsViewReferFilesEN> arrViewReferFilesObjList = new clsViewReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsViewReferFilesEN objViewReferFiles in arrViewReferFilesObjList)
{
objViewReferFiles.OrderNum = intIndex;
UpdateBySql2(objViewReferFiles);
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
 /// 界面引用文件(ViewReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewReferFiles : clsCommFun4BLV2
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
clsViewReferFilesBL.ReFreshThisCache(strPrjId);
}
}

}