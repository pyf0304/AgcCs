
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDepartmentInfoBL
 表名:DepartmentInfo(00050029)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class  clsDepartmentInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDepartmentInfoEN GetObj(this K_DepartmentId_DepartmentInfo myKey)
{
clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.DepartmentInfoDA.GetObjByDepartmentId(myKey.Value);
return objDepartmentInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDepartmentInfoEN objDepartmentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDepartmentInfoBL.IsExist(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDepartmentInfoEN.DepartmentId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDepartmentInfoBL.DepartmentInfoDA.AddNewRecordBySQL2(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDepartmentInfoEN objDepartmentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDepartmentInfoBL.IsExist(objDepartmentInfoEN.DepartmentId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDepartmentInfoEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDepartmentInfoEN.AddNewRecord();
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDepartmentInfoEN objDepartmentInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDepartmentInfoBL.IsExist(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDepartmentInfoEN.DepartmentId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDepartmentInfoBL.DepartmentInfoDA.AddNewRecordBySQL2WithReturnKey(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetDepartmentId(this clsDepartmentInfoEN objDepartmentInfoEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, conDepartmentInfo.DepartmentId);
}
objDepartmentInfoEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.DepartmentId) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.DepartmentId, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.DepartmentId] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetDepartmentName(this clsDepartmentInfoEN objDepartmentInfoEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, conDepartmentInfo.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, conDepartmentInfo.DepartmentName);
}
objDepartmentInfoEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.DepartmentName) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.DepartmentName, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.DepartmentName] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetDepartmentAbbrName(this clsDepartmentInfoEN objDepartmentInfoEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, conDepartmentInfo.DepartmentAbbrName);
}
objDepartmentInfoEN.DepartmentAbbrName = strDepartmentAbbrName; //部门简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.DepartmentAbbrName) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.DepartmentAbbrName, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.DepartmentAbbrName] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetDepartmentTypeId(this clsDepartmentInfoEN objDepartmentInfoEN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, conDepartmentInfo.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, conDepartmentInfo.DepartmentTypeId);
}
objDepartmentInfoEN.DepartmentTypeId = strDepartmentTypeId; //部门类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.DepartmentTypeId) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.DepartmentTypeId, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.DepartmentTypeId] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetUpDepartmentId(this clsDepartmentInfoEN objDepartmentInfoEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, conDepartmentInfo.UpDepartmentId);
}
objDepartmentInfoEN.UpDepartmentId = strUpDepartmentId; //上级部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.UpDepartmentId) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.UpDepartmentId, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.UpDepartmentId] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetInUse(this clsDepartmentInfoEN objDepartmentInfoEN, bool bolInUse, string strComparisonOp="")
	{
objDepartmentInfoEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.InUse) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.InUse, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.InUse] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetOrderNum(this clsDepartmentInfoEN objDepartmentInfoEN, int? intOrderNum, string strComparisonOp="")
	{
objDepartmentInfoEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.OrderNum) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.OrderNum, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.OrderNum] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDepartmentInfoEN SetMemo(this clsDepartmentInfoEN objDepartmentInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDepartmentInfo.Memo);
}
objDepartmentInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDepartmentInfoEN.dicFldComparisonOp.ContainsKey(conDepartmentInfo.Memo) == false)
{
objDepartmentInfoEN.dicFldComparisonOp.Add(conDepartmentInfo.Memo, strComparisonOp);
}
else
{
objDepartmentInfoEN.dicFldComparisonOp[conDepartmentInfo.Memo] = strComparisonOp;
}
}
return objDepartmentInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDepartmentInfoEN objDepartmentInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDepartmentInfoEN.CheckPropertyNew();
clsDepartmentInfoEN objDepartmentInfoCond = new clsDepartmentInfoEN();
string strCondition = objDepartmentInfoCond
.SetDepartmentId(objDepartmentInfoEN.DepartmentId, "=")
.GetCombineCondition();
objDepartmentInfoEN._IsCheckProperty = true;
bool bolIsExist = clsDepartmentInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDepartmentInfoEN.Update();
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDepartmentInfoBL.DepartmentInfoDA.UpdateBySql2(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDepartmentInfoEN objDepartmentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDepartmentInfoBL.DepartmentInfoDA.UpdateBySql2(objDepartmentInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDepartmentInfoEN objDepartmentInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsDepartmentInfoBL.DepartmentInfoDA.UpdateBySqlWithCondition(objDepartmentInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDepartmentInfoEN objDepartmentInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDepartmentInfoBL.DepartmentInfoDA.UpdateBySqlWithConditionTransaction(objDepartmentInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDepartmentInfoEN objDepartmentInfoEN)
{
try
{
int intRecNum = clsDepartmentInfoBL.DepartmentInfoDA.DelRecord(objDepartmentInfoEN.DepartmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoENS">源对象</param>
 /// <param name = "objDepartmentInfoENT">目标对象</param>
 public static void CopyTo(this clsDepartmentInfoEN objDepartmentInfoENS, clsDepartmentInfoEN objDepartmentInfoENT)
{
try
{
objDepartmentInfoENT.DepartmentId = objDepartmentInfoENS.DepartmentId; //部门ID
objDepartmentInfoENT.DepartmentName = objDepartmentInfoENS.DepartmentName; //部门名称
objDepartmentInfoENT.DepartmentAbbrName = objDepartmentInfoENS.DepartmentAbbrName; //部门简称
objDepartmentInfoENT.DepartmentTypeId = objDepartmentInfoENS.DepartmentTypeId; //部门类型Id
objDepartmentInfoENT.UpDepartmentId = objDepartmentInfoENS.UpDepartmentId; //上级部门Id
objDepartmentInfoENT.InUse = objDepartmentInfoENS.InUse; //是否在用
objDepartmentInfoENT.OrderNum = objDepartmentInfoENS.OrderNum; //序号
objDepartmentInfoENT.Memo = objDepartmentInfoENS.Memo; //说明
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
 /// <param name = "objDepartmentInfoENS">源对象</param>
 /// <returns>目标对象=>clsDepartmentInfoEN:objDepartmentInfoENT</returns>
 public static clsDepartmentInfoEN CopyTo(this clsDepartmentInfoEN objDepartmentInfoENS)
{
try
{
 clsDepartmentInfoEN objDepartmentInfoENT = new clsDepartmentInfoEN()
{
DepartmentId = objDepartmentInfoENS.DepartmentId, //部门ID
DepartmentName = objDepartmentInfoENS.DepartmentName, //部门名称
DepartmentAbbrName = objDepartmentInfoENS.DepartmentAbbrName, //部门简称
DepartmentTypeId = objDepartmentInfoENS.DepartmentTypeId, //部门类型Id
UpDepartmentId = objDepartmentInfoENS.UpDepartmentId, //上级部门Id
InUse = objDepartmentInfoENS.InUse, //是否在用
OrderNum = objDepartmentInfoENS.OrderNum, //序号
Memo = objDepartmentInfoENS.Memo, //说明
};
 return objDepartmentInfoENT;
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
public static void CheckPropertyNew(this clsDepartmentInfoEN objDepartmentInfoEN)
{
 clsDepartmentInfoBL.DepartmentInfoDA.CheckPropertyNew(objDepartmentInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDepartmentInfoEN objDepartmentInfoEN)
{
 clsDepartmentInfoBL.DepartmentInfoDA.CheckProperty4Condition(objDepartmentInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDepartmentInfoEN objDepartmentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.DepartmentId, objDepartmentInfoCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.DepartmentName, objDepartmentInfoCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.DepartmentAbbrName, objDepartmentInfoCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.DepartmentTypeId, objDepartmentInfoCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.UpDepartmentId, objDepartmentInfoCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.InUse) == true)
{
if (objDepartmentInfoCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDepartmentInfo.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDepartmentInfo.InUse);
}
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.OrderNum) == true)
{
string strComparisonOpOrderNum = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDepartmentInfo.OrderNum, objDepartmentInfoCond.OrderNum, strComparisonOpOrderNum);
}
if (objDepartmentInfoCond.IsUpdated(conDepartmentInfo.Memo) == true)
{
string strComparisonOpMemo = objDepartmentInfoCond.dicFldComparisonOp[conDepartmentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDepartmentInfo.Memo, objDepartmentInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DepartmentInfo
{
public virtual bool UpdRelaTabDate(string strDepartmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 部门(DepartmentInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDepartmentInfoBL
{
public static RelatedActions_DepartmentInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDepartmentInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDepartmentInfoDA DepartmentInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDepartmentInfoDA();
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
 public clsDepartmentInfoBL()
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
if (string.IsNullOrEmpty(clsDepartmentInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDepartmentInfoEN._ConnectString);
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
public static DataTable GetDataTable_DepartmentInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DepartmentInfoDA.GetDataTable_DepartmentInfo(strWhereCond);
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
objDT = DepartmentInfoDA.GetDataTable(strWhereCond);
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
objDT = DepartmentInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DepartmentInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DepartmentInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DepartmentInfoDA.GetDataTable_Top(objTopPara);
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
objDT = DepartmentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDepartmentInfoEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentIdLst)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDepartmentIdLst, true);
 string strWhereCond = string.Format("DepartmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDepartmentInfoEN> GetObjLstByDepartmentIdLstCache(List<string> arrDepartmentIdLst)
{
string strKey = string.Format("{0}", clsDepartmentInfoEN._CurrTabName);
List<clsDepartmentInfoEN> arrDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsDepartmentInfoEN> arrDepartmentInfoObjLst_Sel =
arrDepartmentInfoObjLstCache
.Where(x => arrDepartmentIdLst.Contains(x.DepartmentId));
return arrDepartmentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDepartmentInfoEN> GetObjLst(string strWhereCond)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
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
public static List<clsDepartmentInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDepartmentInfoEN> GetSubObjLstCache(clsDepartmentInfoEN objDepartmentInfoCond)
{
List<clsDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDepartmentInfo._AttributeName)
{
if (objDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDepartmentInfoCond[strFldName]));
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
public static List<clsDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
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
public static List<clsDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
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
List<clsDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDepartmentInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
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
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
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
public static List<clsDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDepartmentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
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
public static List<clsDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDepartmentInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDepartmentInfoEN> arrObjLst = new List<clsDepartmentInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
try
{
objDepartmentInfoEN.DepartmentId = objRow[conDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objDepartmentInfoEN.DepartmentName = objRow[conDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objDepartmentInfoEN.DepartmentAbbrName = objRow[conDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objDepartmentInfoEN.DepartmentTypeId = objRow[conDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[conDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objDepartmentInfoEN.UpDepartmentId = objRow[conDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[conDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDepartmentInfo.InUse].ToString().Trim()); //是否在用
objDepartmentInfoEN.OrderNum = objRow[conDepartmentInfo.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDepartmentInfo.OrderNum].ToString().Trim()); //序号
objDepartmentInfoEN.Memo = objRow[conDepartmentInfo.Memo] == DBNull.Value ? null : objRow[conDepartmentInfo.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDepartmentInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDepartmentInfo(ref clsDepartmentInfoEN objDepartmentInfoEN)
{
bool bolResult = DepartmentInfoDA.GetDepartmentInfo(ref objDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
if (strDepartmentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDepartmentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDepartmentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDepartmentInfoEN objDepartmentInfoEN = DepartmentInfoDA.GetObjByDepartmentId(strDepartmentId);
return objDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDepartmentInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDepartmentInfoEN objDepartmentInfoEN = DepartmentInfoDA.GetFirstObj(strWhereCond);
 return objDepartmentInfoEN;
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
public static clsDepartmentInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDepartmentInfoEN objDepartmentInfoEN = DepartmentInfoDA.GetObjByDataRow(objRow);
 return objDepartmentInfoEN;
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
public static clsDepartmentInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDepartmentInfoEN objDepartmentInfoEN = DepartmentInfoDA.GetObjByDataRow(objRow);
 return objDepartmentInfoEN;
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
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <param name = "lstDepartmentInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDepartmentInfoEN GetObjByDepartmentIdFromList(string strDepartmentId, List<clsDepartmentInfoEN> lstDepartmentInfoObjLst)
{
foreach (clsDepartmentInfoEN objDepartmentInfoEN in lstDepartmentInfoObjLst)
{
if (objDepartmentInfoEN.DepartmentId == strDepartmentId)
{
return objDepartmentInfoEN;
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
 string strDepartmentId;
 try
 {
 strDepartmentId = new clsDepartmentInfoDA().GetFirstID(strWhereCond);
 return strDepartmentId;
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
 arrList = DepartmentInfoDA.GetID(strWhereCond);
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
bool bolIsExist = DepartmentInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDepartmentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DepartmentInfoDA.IsExist(strDepartmentId);
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
 bolIsExist = clsDepartmentInfoDA.IsExistTable();
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
 bolIsExist = DepartmentInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDepartmentInfoEN objDepartmentInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDepartmentInfoBL.IsExist(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDepartmentInfoEN.DepartmentId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DepartmentInfoDA.AddNewRecordBySQL2(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDepartmentInfoEN objDepartmentInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDepartmentInfoBL.IsExist(objDepartmentInfoEN.DepartmentId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDepartmentInfoEN.DepartmentId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DepartmentInfoDA.AddNewRecordBySQL2WithReturnKey(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDepartmentInfoEN objDepartmentInfoEN)
{
try
{
bool bolResult = DepartmentInfoDA.Update(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "objDepartmentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(objDepartmentInfoEN.DepartmentId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DepartmentInfoDA.UpdateBySql2(objDepartmentInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDepartmentInfoBL.ReFreshCache();

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDepartmentId)
{
try
{
 clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.GetObjByDepartmentId(strDepartmentId);

if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(objDepartmentInfoEN.DepartmentId, "SetUpdDate");
}
if (objDepartmentInfoEN != null)
{
int intRecNum = DepartmentInfoDA.DelRecord(strDepartmentId);
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
/// <param name="strDepartmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDepartmentId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDepartmentInfoDA.GetSpecSQLObj();
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
//删除与表:[DepartmentInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDepartmentInfo.DepartmentId,
//strDepartmentId);
//        clsDepartmentInfoBL.DelDepartmentInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDepartmentInfoBL.DelRecord(strDepartmentId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDepartmentInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDepartmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDepartmentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDepartmentInfoBL.relatedActions != null)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(strDepartmentId, "UpdRelaTabDate");
}
bool bolResult = DepartmentInfoDA.DelRecord(strDepartmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDepartmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDepartmentInfos(List<string> arrDepartmentIdLst)
{
if (arrDepartmentIdLst.Count == 0) return 0;
try
{
if (clsDepartmentInfoBL.relatedActions != null)
{
foreach (var strDepartmentId in arrDepartmentIdLst)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(strDepartmentId, "UpdRelaTabDate");
}
}
int intDelRecNum = DepartmentInfoDA.DelDepartmentInfo(arrDepartmentIdLst);
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
public static int DelDepartmentInfosByCond(string strWhereCond)
{
try
{
if (clsDepartmentInfoBL.relatedActions != null)
{
List<string> arrDepartmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDepartmentId in arrDepartmentId)
{
clsDepartmentInfoBL.relatedActions.UpdRelaTabDate(strDepartmentId, "UpdRelaTabDate");
}
}
int intRecNum = DepartmentInfoDA.DelDepartmentInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DepartmentInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDepartmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDepartmentId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDepartmentInfoDA.GetSpecSQLObj();
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
//删除与表:[DepartmentInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDepartmentInfoBL.DelRecord(strDepartmentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDepartmentInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDepartmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDepartmentInfoENS">源对象</param>
 /// <param name = "objDepartmentInfoENT">目标对象</param>
 public static void CopyTo(clsDepartmentInfoEN objDepartmentInfoENS, clsDepartmentInfoEN objDepartmentInfoENT)
{
try
{
objDepartmentInfoENT.DepartmentId = objDepartmentInfoENS.DepartmentId; //部门ID
objDepartmentInfoENT.DepartmentName = objDepartmentInfoENS.DepartmentName; //部门名称
objDepartmentInfoENT.DepartmentAbbrName = objDepartmentInfoENS.DepartmentAbbrName; //部门简称
objDepartmentInfoENT.DepartmentTypeId = objDepartmentInfoENS.DepartmentTypeId; //部门类型Id
objDepartmentInfoENT.UpDepartmentId = objDepartmentInfoENS.UpDepartmentId; //上级部门Id
objDepartmentInfoENT.InUse = objDepartmentInfoENS.InUse; //是否在用
objDepartmentInfoENT.OrderNum = objDepartmentInfoENS.OrderNum; //序号
objDepartmentInfoENT.Memo = objDepartmentInfoENS.Memo; //说明
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
 /// <param name = "objDepartmentInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsDepartmentInfoEN objDepartmentInfoEN)
{
try
{
objDepartmentInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDepartmentInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDepartmentInfo.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.DepartmentId = objDepartmentInfoEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(conDepartmentInfo.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.DepartmentName = objDepartmentInfoEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(conDepartmentInfo.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.DepartmentAbbrName = objDepartmentInfoEN.DepartmentAbbrName == "[null]" ? null :  objDepartmentInfoEN.DepartmentAbbrName; //部门简称
}
if (arrFldSet.Contains(conDepartmentInfo.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.DepartmentTypeId = objDepartmentInfoEN.DepartmentTypeId == "[null]" ? null :  objDepartmentInfoEN.DepartmentTypeId; //部门类型Id
}
if (arrFldSet.Contains(conDepartmentInfo.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.UpDepartmentId = objDepartmentInfoEN.UpDepartmentId == "[null]" ? null :  objDepartmentInfoEN.UpDepartmentId; //上级部门Id
}
if (arrFldSet.Contains(conDepartmentInfo.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.InUse = objDepartmentInfoEN.InUse; //是否在用
}
if (arrFldSet.Contains(conDepartmentInfo.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.OrderNum = objDepartmentInfoEN.OrderNum; //序号
}
if (arrFldSet.Contains(conDepartmentInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDepartmentInfoEN.Memo = objDepartmentInfoEN.Memo == "[null]" ? null :  objDepartmentInfoEN.Memo; //说明
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
 /// <param name = "objDepartmentInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsDepartmentInfoEN objDepartmentInfoEN)
{
try
{
if (objDepartmentInfoEN.DepartmentAbbrName == "[null]") objDepartmentInfoEN.DepartmentAbbrName = null; //部门简称
if (objDepartmentInfoEN.DepartmentTypeId == "[null]") objDepartmentInfoEN.DepartmentTypeId = null; //部门类型Id
if (objDepartmentInfoEN.UpDepartmentId == "[null]") objDepartmentInfoEN.UpDepartmentId = null; //上级部门Id
if (objDepartmentInfoEN.Memo == "[null]") objDepartmentInfoEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDepartmentInfoEN objDepartmentInfoEN)
{
 DepartmentInfoDA.CheckPropertyNew(objDepartmentInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDepartmentInfoEN objDepartmentInfoEN)
{
 DepartmentInfoDA.CheckProperty4Condition(objDepartmentInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDepartmentInfo.DepartmentId); 
List<clsDepartmentInfoEN> arrObjLst = clsDepartmentInfoBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN()
{
DepartmentId = "0",
DepartmentName = "选[部门]..."
};
arrObjLst.Insert(0, objDepartmentInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDepartmentInfo.DepartmentId;
objComboBox.DisplayMember = conDepartmentInfo.DepartmentName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[部门]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDepartmentInfo.DepartmentId); 
IEnumerable<clsDepartmentInfoEN> arrObjLst = clsDepartmentInfoBL.GetObjLst(strCondition);
objDDL.DataValueField = conDepartmentInfo.DepartmentId;
objDDL.DataTextField = conDepartmentInfo.DepartmentName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[部门]...","0");
List<clsDepartmentInfoEN> arrDepartmentInfoObjLst = GetAllDepartmentInfoObjLstCache(); 
objDDL.DataValueField = conDepartmentInfo.DepartmentId;
objDDL.DataTextField = conDepartmentInfo.DepartmentName;
objDDL.DataSource = arrDepartmentInfoObjLst;
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
if (clsDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DepartmentId");
//if (arrDepartmentInfoObjLstCache == null)
//{
//arrDepartmentInfoObjLstCache = DepartmentInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDepartmentInfoEN GetObjByDepartmentIdCache(string strDepartmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDepartmentInfoEN._CurrTabName);
List<clsDepartmentInfoEN> arrDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsDepartmentInfoEN> arrDepartmentInfoObjLst_Sel =
arrDepartmentInfoObjLstCache
.Where(x=> x.DepartmentId == strDepartmentId 
);
if (arrDepartmentInfoObjLst_Sel.Count() == 0)
{
   clsDepartmentInfoEN obj = clsDepartmentInfoBL.GetObjByDepartmentId(strDepartmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDepartmentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentIdCache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//获取缓存中的对象列表
clsDepartmentInfoEN objDepartmentInfo = GetObjByDepartmentIdCache(strDepartmentId);
if (objDepartmentInfo == null) return "";
return objDepartmentInfo.DepartmentName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDepartmentIdCache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//获取缓存中的对象列表
clsDepartmentInfoEN objDepartmentInfo = GetObjByDepartmentIdCache(strDepartmentId);
if (objDepartmentInfo == null) return "";
return objDepartmentInfo.DepartmentName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDepartmentInfoEN> GetAllDepartmentInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsDepartmentInfoEN> arrDepartmentInfoObjLstCache = GetObjLstCache(); 
return arrDepartmentInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDepartmentInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDepartmentInfoEN._CurrTabName);
List<clsDepartmentInfoEN> arrDepartmentInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDepartmentInfoObjLstCache;
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
string strKey = string.Format("{0}", clsDepartmentInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDepartmentInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDepartmentInfoEN._RefreshTimeLst.Count == 0) return "";
return clsDepartmentInfoEN._RefreshTimeLst[clsDepartmentInfoEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDepartmentInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDepartmentInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDepartmentInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDepartmentInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strDepartmentId)
{
if (strInFldName != conDepartmentInfo.DepartmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDepartmentInfo._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDepartmentInfo._AttributeName));
throw new Exception(strMsg);
}
var objDepartmentInfo = clsDepartmentInfoBL.GetObjByDepartmentIdCache(strDepartmentId);
if (objDepartmentInfo == null) return "";
return objDepartmentInfo[strOutFldName].ToString();
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
int intRecCount = clsDepartmentInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsDepartmentInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDepartmentInfoDA.GetRecCount();
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
int intRecCount = clsDepartmentInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDepartmentInfoEN objDepartmentInfoCond)
{
List<clsDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDepartmentInfo._AttributeName)
{
if (objDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDepartmentInfoCond[strFldName]));
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
 List<string> arrList = clsDepartmentInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DepartmentInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DepartmentInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DepartmentInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDepartmentInfoDA.SetFldValue(clsDepartmentInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DepartmentInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDepartmentInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDepartmentInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDepartmentInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DepartmentInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**部门ID*/ 
 strCreateTabCode.Append(" DepartmentId varchar(6) primary key, "); 
 // /**部门名称*/ 
 strCreateTabCode.Append(" DepartmentName varchar(30) not Null, "); 
 // /**部门简称*/ 
 strCreateTabCode.Append(" DepartmentAbbrName varchar(8) Null, "); 
 // /**部门类型Id*/ 
 strCreateTabCode.Append(" DepartmentTypeId char(2) Null, "); 
 // /**上级部门Id*/ 
 strCreateTabCode.Append(" UpDepartmentId varchar(6) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 部门(DepartmentInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DepartmentInfo : clsCommFun4BL
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
clsDepartmentInfoBL.ReFreshThisCache();
}
}

}