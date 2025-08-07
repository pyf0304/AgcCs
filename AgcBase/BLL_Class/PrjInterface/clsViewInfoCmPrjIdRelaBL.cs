
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoCmPrjIdRelaBL
 表名:ViewInfoCmPrjIdRela(00050621)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:24
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
public static class  clsViewInfoCmPrjIdRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoCmPrjIdRelaBL.IsExist(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoCmPrjIdRelaEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.AddNewRecordBySQL2(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewInfoCmPrjIdRelaBL.IsExist(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewInfoCmPrjIdRelaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objViewInfoCmPrjIdRelaEN.AddNewRecord();
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoCmPrjIdRelaBL.IsExist(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoCmPrjIdRelaEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.AddNewRecordBySQL2WithReturnKey(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoCmPrjIdRelaEN SetViewId(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewInfoCmPrjIdRela.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewInfoCmPrjIdRela.ViewId);
}
objViewInfoCmPrjIdRelaEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewInfoCmPrjIdRela.ViewId) == false)
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewInfoCmPrjIdRela.ViewId, strComparisonOp);
}
else
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp[conViewInfoCmPrjIdRela.ViewId] = strComparisonOp;
}
}
return objViewInfoCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoCmPrjIdRelaEN SetCmPrjId(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conViewInfoCmPrjIdRela.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conViewInfoCmPrjIdRela.CmPrjId);
}
objViewInfoCmPrjIdRelaEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewInfoCmPrjIdRela.CmPrjId) == false)
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewInfoCmPrjIdRela.CmPrjId, strComparisonOp);
}
else
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp[conViewInfoCmPrjIdRela.CmPrjId] = strComparisonOp;
}
}
return objViewInfoCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoCmPrjIdRelaEN SetUpdDate(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewInfoCmPrjIdRela.UpdDate);
}
objViewInfoCmPrjIdRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewInfoCmPrjIdRela.UpdDate) == false)
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewInfoCmPrjIdRela.UpdDate, strComparisonOp);
}
else
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp[conViewInfoCmPrjIdRela.UpdDate] = strComparisonOp;
}
}
return objViewInfoCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoCmPrjIdRelaEN SetUpdUserId(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conViewInfoCmPrjIdRela.UpdUserId);
}
objViewInfoCmPrjIdRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewInfoCmPrjIdRela.UpdUserId) == false)
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewInfoCmPrjIdRela.UpdUserId, strComparisonOp);
}
else
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp[conViewInfoCmPrjIdRela.UpdUserId] = strComparisonOp;
}
}
return objViewInfoCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewInfoCmPrjIdRelaEN SetMemo(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewInfoCmPrjIdRela.Memo);
}
objViewInfoCmPrjIdRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewInfoCmPrjIdRela.Memo) == false)
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewInfoCmPrjIdRela.Memo, strComparisonOp);
}
else
{
objViewInfoCmPrjIdRelaEN.dicFldComparisonOp[conViewInfoCmPrjIdRela.Memo] = strComparisonOp;
}
}
return objViewInfoCmPrjIdRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewInfoCmPrjIdRelaEN.CheckPropertyNew();
clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaCond = new clsViewInfoCmPrjIdRelaEN();
string strCondition = objViewInfoCmPrjIdRelaCond
.SetViewId(objViewInfoCmPrjIdRelaEN.ViewId, "=")
.GetCombineCondition();
objViewInfoCmPrjIdRelaEN._IsCheckProperty = true;
bool bolIsExist = clsViewInfoCmPrjIdRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewInfoCmPrjIdRelaEN.Update();
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.UpdateBySql2(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.UpdateBySql2(objViewInfoCmPrjIdRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.UpdateBySqlWithCondition(objViewInfoCmPrjIdRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.UpdateBySqlWithConditionTransaction(objViewInfoCmPrjIdRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
try
{
int intRecNum = clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.DelRecord(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
 /// <param name = "objViewInfoCmPrjIdRelaENT">目标对象</param>
 public static void CopyTo(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENS, clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENT)
{
try
{
objViewInfoCmPrjIdRelaENT.ViewId = objViewInfoCmPrjIdRelaENS.ViewId; //界面Id
objViewInfoCmPrjIdRelaENT.CmPrjId = objViewInfoCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objViewInfoCmPrjIdRelaENT.UpdDate = objViewInfoCmPrjIdRelaENS.UpdDate; //修改日期
objViewInfoCmPrjIdRelaENT.UpdUserId = objViewInfoCmPrjIdRelaENS.UpdUserId; //修改用户Id
objViewInfoCmPrjIdRelaENT.Memo = objViewInfoCmPrjIdRelaENS.Memo; //说明
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
 /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewInfoCmPrjIdRelaEN:objViewInfoCmPrjIdRelaENT</returns>
 public static clsViewInfoCmPrjIdRelaEN CopyTo(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENS)
{
try
{
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENT = new clsViewInfoCmPrjIdRelaEN()
{
ViewId = objViewInfoCmPrjIdRelaENS.ViewId, //界面Id
CmPrjId = objViewInfoCmPrjIdRelaENS.CmPrjId, //Cm工程Id
UpdDate = objViewInfoCmPrjIdRelaENS.UpdDate, //修改日期
UpdUserId = objViewInfoCmPrjIdRelaENS.UpdUserId, //修改用户Id
Memo = objViewInfoCmPrjIdRelaENS.Memo, //说明
};
 return objViewInfoCmPrjIdRelaENT;
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
public static void CheckPropertyNew(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.CheckPropertyNew(objViewInfoCmPrjIdRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.CheckProperty4Condition(objViewInfoCmPrjIdRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewInfoCmPrjIdRelaCond.IsUpdated(conViewInfoCmPrjIdRela.ViewId) == true)
{
string strComparisonOpViewId = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[conViewInfoCmPrjIdRela.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfoCmPrjIdRela.ViewId, objViewInfoCmPrjIdRelaCond.ViewId, strComparisonOpViewId);
}
if (objViewInfoCmPrjIdRelaCond.IsUpdated(conViewInfoCmPrjIdRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[conViewInfoCmPrjIdRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfoCmPrjIdRela.CmPrjId, objViewInfoCmPrjIdRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objViewInfoCmPrjIdRelaCond.IsUpdated(conViewInfoCmPrjIdRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[conViewInfoCmPrjIdRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfoCmPrjIdRela.UpdDate, objViewInfoCmPrjIdRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewInfoCmPrjIdRelaCond.IsUpdated(conViewInfoCmPrjIdRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[conViewInfoCmPrjIdRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfoCmPrjIdRela.UpdUserId, objViewInfoCmPrjIdRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objViewInfoCmPrjIdRelaCond.IsUpdated(conViewInfoCmPrjIdRela.Memo) == true)
{
string strComparisonOpMemo = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[conViewInfoCmPrjIdRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewInfoCmPrjIdRela.Memo, objViewInfoCmPrjIdRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewInfoCmPrjIdRela
{
public virtual bool UpdRelaTabDate(string strViewId,string strCmPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面CmPrjId关系(ViewInfoCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewInfoCmPrjIdRelaBL
{
public static RelatedActions_ViewInfoCmPrjIdRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewInfoCmPrjIdRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewInfoCmPrjIdRelaDA ViewInfoCmPrjIdRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewInfoCmPrjIdRelaDA();
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
 public clsViewInfoCmPrjIdRelaBL()
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
if (string.IsNullOrEmpty(clsViewInfoCmPrjIdRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewInfoCmPrjIdRelaEN._ConnectString);
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
public static DataTable GetDataTable_ViewInfoCmPrjIdRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable_ViewInfoCmPrjIdRela(strWhereCond);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable(strWhereCond);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable_Top(objTopPara);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewInfoCmPrjIdRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--ViewInfoCmPrjIdRela(界面CmPrjId关系)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objViewInfoCmPrjIdRelaEN.ViewId;
strResult += "|" + objViewInfoCmPrjIdRelaEN.CmPrjId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewInfoCmPrjIdRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewInfoCmPrjIdRelaEN._CurrTabName, strCmPrjId);
List<clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLst_Sel =
arrViewInfoCmPrjIdRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrViewInfoCmPrjIdRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLst(string strWhereCond)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
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
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewInfoCmPrjIdRelaEN> GetSubObjLstCache(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaCond)
{
 string strCmPrjId = objViewInfoCmPrjIdRelaCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewInfoCmPrjIdRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewInfoCmPrjIdRelaEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsViewInfoCmPrjIdRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewInfoCmPrjIdRela._AttributeName)
{
if (objViewInfoCmPrjIdRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewInfoCmPrjIdRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCmPrjIdRelaCond[strFldName].ToString());
}
else
{
if (objViewInfoCmPrjIdRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCmPrjIdRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewInfoCmPrjIdRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewInfoCmPrjIdRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewInfoCmPrjIdRelaCond[strFldName]));
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
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
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
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
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
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewInfoCmPrjIdRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
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
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
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
public static List<clsViewInfoCmPrjIdRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
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
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewInfoCmPrjIdRelaEN> arrObjLst = new List<clsViewInfoCmPrjIdRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = new clsViewInfoCmPrjIdRelaEN();
try
{
objViewInfoCmPrjIdRelaEN.ViewId = objRow[conViewInfoCmPrjIdRela.ViewId].ToString().Trim(); //界面Id
objViewInfoCmPrjIdRelaEN.CmPrjId = objRow[conViewInfoCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewInfoCmPrjIdRelaEN.UpdDate = objRow[conViewInfoCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewInfoCmPrjIdRelaEN.UpdUserId = objRow[conViewInfoCmPrjIdRela.UpdUserId] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoCmPrjIdRelaEN.Memo = objRow[conViewInfoCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewInfoCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewInfoCmPrjIdRelaEN.ViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewInfoCmPrjIdRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewInfoCmPrjIdRela(ref clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
bool bolResult = ViewInfoCmPrjIdRelaDA.GetViewInfoCmPrjIdRela(ref objViewInfoCmPrjIdRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewInfoCmPrjIdRelaEN GetObjByKeyLst(string strViewId,string strCmPrjId)
{
if (strViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strViewId,strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strCmPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strViewId,strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strCmPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = ViewInfoCmPrjIdRelaDA.GetObjByKeyLst(strViewId,strCmPrjId);
return objViewInfoCmPrjIdRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewInfoCmPrjIdRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = ViewInfoCmPrjIdRelaDA.GetFirstObj(strWhereCond);
 return objViewInfoCmPrjIdRelaEN;
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
public static clsViewInfoCmPrjIdRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = ViewInfoCmPrjIdRelaDA.GetObjByDataRow(objRow);
 return objViewInfoCmPrjIdRelaEN;
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
public static clsViewInfoCmPrjIdRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = ViewInfoCmPrjIdRelaDA.GetObjByDataRow(objRow);
 return objViewInfoCmPrjIdRelaEN;
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
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <param name = "lstViewInfoCmPrjIdRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewInfoCmPrjIdRelaEN GetObjByKeyLstFromList(string strViewId,string strCmPrjId, List<clsViewInfoCmPrjIdRelaEN> lstViewInfoCmPrjIdRelaObjLst)
{
foreach (clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN in lstViewInfoCmPrjIdRelaObjLst)
{
if (objViewInfoCmPrjIdRelaEN.ViewId == strViewId 
 && objViewInfoCmPrjIdRelaEN.CmPrjId == strCmPrjId 
)
{
return objViewInfoCmPrjIdRelaEN;
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
 string strViewId;
 try
 {
 strViewId = new clsViewInfoCmPrjIdRelaDA().GetFirstID(strWhereCond);
 return strViewId;
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
 arrList = ViewInfoCmPrjIdRelaDA.GetID(strWhereCond);
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
bool bolIsExist = ViewInfoCmPrjIdRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewId,string strCmPrjId)
{
//检测记录是否存在
bool bolIsExist = ViewInfoCmPrjIdRelaDA.IsExist(strViewId,strCmPrjId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewId">界面Id</param>
/// <param name = "strCmPrjId">Cm工程Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewId , string strCmPrjId, string strOpUser)
{
clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLst(strViewId,strCmPrjId);
objViewInfoCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewInfoCmPrjIdRelaEN.UpdUserId = strOpUser;
return clsViewInfoCmPrjIdRelaBL.UpdateBySql2(objViewInfoCmPrjIdRelaEN);
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
 bolIsExist = clsViewInfoCmPrjIdRelaDA.IsExistTable();
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
 bolIsExist = ViewInfoCmPrjIdRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoCmPrjIdRelaBL.IsExist(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoCmPrjIdRelaEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ViewInfoCmPrjIdRelaDA.AddNewRecordBySQL2(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewInfoCmPrjIdRelaBL.IsExist(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewInfoCmPrjIdRelaEN.ViewId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ViewInfoCmPrjIdRelaDA.AddNewRecordBySQL2WithReturnKey(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
try
{
bool bolResult = ViewInfoCmPrjIdRelaDA.Update(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 if (string.IsNullOrEmpty(objViewInfoCmPrjIdRelaEN.ViewId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewInfoCmPrjIdRelaDA.UpdateBySql2(objViewInfoCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewInfoCmPrjIdRelaBL.ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewId,string strCmPrjId)
{
try
{
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLst(strViewId,strCmPrjId);

if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewInfoCmPrjIdRelaEN.ViewId,objViewInfoCmPrjIdRelaEN.CmPrjId, objViewInfoCmPrjIdRelaEN.UpdUserId);
}
if (objViewInfoCmPrjIdRelaEN != null)
{
int intRecNum = ViewInfoCmPrjIdRelaDA.DelRecord(strViewId,strCmPrjId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);
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
/// <param name="strViewId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewId,string strCmPrjId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewInfoCmPrjIdRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewInfoCmPrjIdRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewInfoCmPrjIdRela.ViewId,
//strViewId);
//        clsViewInfoCmPrjIdRelaBL.DelViewInfoCmPrjIdRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewInfoCmPrjIdRelaBL.DelRecord(strViewId,strCmPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewInfoCmPrjIdRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewId,string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(strViewId,strCmPrjId, "UpdRelaTabDate");
}
bool bolResult = ViewInfoCmPrjIdRelaDA.DelRecord(strViewId,strCmPrjId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCmPrjId);
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
 /// <param name = "arrViewIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strViewId;
string strCmPrjId;
if (clsViewInfoCmPrjIdRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strViewId = sstrKey[0];
strCmPrjId = sstrKey[1];
clsViewInfoCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(strViewId,strCmPrjId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strViewId = sstrKey[0];
strCmPrjId = sstrKey[1];
 clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLst(strViewId,strCmPrjId);
int intDelRecNum = ViewInfoCmPrjIdRelaDA.DelRecKeyLsts(arrKeyLsts);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewInfoCmPrjIdRelaEN.CmPrjId);
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
public static int DelViewInfoCmPrjIdRelasByCond(string strWhereCond)
{
try
{
List<string> arrCmPrjId = GetFldValue(conViewInfoCmPrjIdRela.CmPrjId, strWhereCond);
int intRecNum = ViewInfoCmPrjIdRelaDA.DelViewInfoCmPrjIdRela(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCmPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewInfoCmPrjIdRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewId,string strCmPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewInfoCmPrjIdRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewInfoCmPrjIdRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewInfoCmPrjIdRelaBL.DelRecord(strViewId,strCmPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewInfoCmPrjIdRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
 /// <param name = "objViewInfoCmPrjIdRelaENT">目标对象</param>
 public static void CopyTo(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENS, clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENT)
{
try
{
objViewInfoCmPrjIdRelaENT.ViewId = objViewInfoCmPrjIdRelaENS.ViewId; //界面Id
objViewInfoCmPrjIdRelaENT.CmPrjId = objViewInfoCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objViewInfoCmPrjIdRelaENT.UpdDate = objViewInfoCmPrjIdRelaENS.UpdDate; //修改日期
objViewInfoCmPrjIdRelaENT.UpdUserId = objViewInfoCmPrjIdRelaENS.UpdUserId; //修改用户Id
objViewInfoCmPrjIdRelaENT.Memo = objViewInfoCmPrjIdRelaENS.Memo; //说明
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
try
{
objViewInfoCmPrjIdRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewInfoCmPrjIdRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewInfoCmPrjIdRela.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoCmPrjIdRelaEN.ViewId = objViewInfoCmPrjIdRelaEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewInfoCmPrjIdRela.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoCmPrjIdRelaEN.CmPrjId = objViewInfoCmPrjIdRelaEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conViewInfoCmPrjIdRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoCmPrjIdRelaEN.UpdDate = objViewInfoCmPrjIdRelaEN.UpdDate == "[null]" ? null :  objViewInfoCmPrjIdRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewInfoCmPrjIdRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoCmPrjIdRelaEN.UpdUserId = objViewInfoCmPrjIdRelaEN.UpdUserId == "[null]" ? null :  objViewInfoCmPrjIdRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conViewInfoCmPrjIdRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewInfoCmPrjIdRelaEN.Memo = objViewInfoCmPrjIdRelaEN.Memo == "[null]" ? null :  objViewInfoCmPrjIdRelaEN.Memo; //说明
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
 /// <param name = "objViewInfoCmPrjIdRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
try
{
if (objViewInfoCmPrjIdRelaEN.UpdDate == "[null]") objViewInfoCmPrjIdRelaEN.UpdDate = null; //修改日期
if (objViewInfoCmPrjIdRelaEN.UpdUserId == "[null]") objViewInfoCmPrjIdRelaEN.UpdUserId = null; //修改用户Id
if (objViewInfoCmPrjIdRelaEN.Memo == "[null]") objViewInfoCmPrjIdRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 ViewInfoCmPrjIdRelaDA.CheckPropertyNew(objViewInfoCmPrjIdRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN)
{
 ViewInfoCmPrjIdRelaDA.CheckProperty4Condition(objViewInfoCmPrjIdRelaEN);
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
if (clsViewInfoCmPrjIdRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoCmPrjIdRelaBL没有刷新缓存机制(clsViewInfoCmPrjIdRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewId");
//if (arrViewInfoCmPrjIdRelaObjLstCache == null)
//{
//arrViewInfoCmPrjIdRelaObjLstCache = ViewInfoCmPrjIdRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewInfoCmPrjIdRelaEN GetObjByKeyLstCache(string strViewId,string strCmPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsViewInfoCmPrjIdRelaEN._CurrTabName, strCmPrjId);
List<clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLst_Sel =
arrViewInfoCmPrjIdRelaObjLstCache
.Where(x=> x.ViewId == strViewId 
 && x.CmPrjId == strCmPrjId 
);
if (arrViewInfoCmPrjIdRelaObjLst_Sel.Count() == 0)
{
   clsViewInfoCmPrjIdRelaEN obj = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLst(strViewId,strCmPrjId);
   if (obj != null)
 {
if (obj.CmPrjId == strCmPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
 }
return null;
}
return arrViewInfoCmPrjIdRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetAllViewInfoCmPrjIdRelaObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLstCache = GetObjLstCache(strCmPrjId); 
return arrViewInfoCmPrjIdRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewInfoCmPrjIdRelaEN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsViewInfoCmPrjIdRelaEN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsViewInfoCmPrjIdRelaEN> arrViewInfoCmPrjIdRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewInfoCmPrjIdRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewInfoCmPrjIdRelaEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsViewInfoCmPrjIdRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewInfoCmPrjIdRelaEN._RefreshTimeLst.Count == 0) return "";
return clsViewInfoCmPrjIdRelaEN._RefreshTimeLst[clsViewInfoCmPrjIdRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[CmPrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoCmPrjIdRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewInfoCmPrjIdRelaEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsViewInfoCmPrjIdRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewInfoCmPrjIdRelaBL.objCommFun4BL.ReFreshCache(strCmPrjId);
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
public static string Func(string strInFldName, string strOutFldName, string strViewId,string strCmPrjId)
{
if (strInFldName != conViewInfoCmPrjIdRela.ViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewInfoCmPrjIdRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewInfoCmPrjIdRela._AttributeName));
throw new Exception(strMsg);
}
var objViewInfoCmPrjIdRela = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLstCache(strViewId,strCmPrjId);
if (objViewInfoCmPrjIdRela == null) return "";
return objViewInfoCmPrjIdRela[strOutFldName].ToString();
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewInfoCmPrjIdRelaDA.GetRecCount();
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewInfoCmPrjIdRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaCond)
{
 string strCmPrjId = objViewInfoCmPrjIdRelaCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewInfoCmPrjIdRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewInfoCmPrjIdRelaEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsViewInfoCmPrjIdRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewInfoCmPrjIdRela._AttributeName)
{
if (objViewInfoCmPrjIdRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewInfoCmPrjIdRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCmPrjIdRelaCond[strFldName].ToString());
}
else
{
if (objViewInfoCmPrjIdRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewInfoCmPrjIdRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewInfoCmPrjIdRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewInfoCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewInfoCmPrjIdRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewInfoCmPrjIdRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewInfoCmPrjIdRelaCond[strFldName]));
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
 List<string> arrList = clsViewInfoCmPrjIdRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewInfoCmPrjIdRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewInfoCmPrjIdRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewInfoCmPrjIdRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.SetFldValue(clsViewInfoCmPrjIdRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewInfoCmPrjIdRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewInfoCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewInfoCmPrjIdRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) primary key, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) primary key, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面CmPrjId关系(ViewInfoCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewInfoCmPrjIdRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCmPrjId)
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
clsViewInfoCmPrjIdRelaBL.ReFreshThisCache(strCmPrjId);
}
}

}