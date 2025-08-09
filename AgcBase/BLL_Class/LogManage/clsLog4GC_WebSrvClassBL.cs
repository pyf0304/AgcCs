
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GC_WebSrvClassBL
 表名:Log4GC_WebSrvClass(00050370)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsLog4GC_WebSrvClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4GC_WebSrvClassEN GetObj(this K_mId_Log4GC_WebSrvClass myKey)
{
clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.GetObjBymId(myKey.Value);
return objLog4GC_WebSrvClassEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLog4GC_WebSrvClassEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],类Id = [{1}]的数据已经存在!(in clsLog4GC_WebSrvClassBL.AddNewRecord)", objLog4GC_WebSrvClassEN.UserId,objLog4GC_WebSrvClassEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.AddNewRecordBySQL2(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
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
objLog4GC_WebSrvClassEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objLog4GC_WebSrvClassEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户Id(UserId)=[{0}],类Id(WebSrvClassId)=[{1}])已经存在,不能重复!", objLog4GC_WebSrvClassEN.UserId, objLog4GC_WebSrvClassEN.WebSrvClassId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objLog4GC_WebSrvClassEN.AddNewRecord();
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLog4GC_WebSrvClassEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],类Id = [{1}]的数据已经存在!(in clsLog4GC_WebSrvClassBL.AddNewRecordWithReturnKey)", objLog4GC_WebSrvClassEN.UserId,objLog4GC_WebSrvClassEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
string strKey = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.AddNewRecordBySQL2WithReturnKey(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetmId(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, long lngmId, string strComparisonOp="")
	{
objLog4GC_WebSrvClassEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.mId) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.mId, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.mId] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetUserId(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conLog4GC_WebSrvClass.UserId);
}
objLog4GC_WebSrvClassEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.UserId) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.UserId, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.UserId] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetWebSrvClassId(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, conLog4GC_WebSrvClass.WebSrvClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, conLog4GC_WebSrvClass.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, conLog4GC_WebSrvClass.WebSrvClassId);
}
objLog4GC_WebSrvClassEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.WebSrvClassId) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.WebSrvClassId, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.WebSrvClassId] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetGeneCodeDate(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conLog4GC_WebSrvClass.GeneCodeDate);
}
objLog4GC_WebSrvClassEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.GeneCodeDate) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.GeneCodeDate, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.GeneCodeDate] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetVersionGeneCode(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, conLog4GC_WebSrvClass.VersionGeneCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, conLog4GC_WebSrvClass.VersionGeneCode);
}
objLog4GC_WebSrvClassEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.VersionGeneCode) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.VersionGeneCode, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.VersionGeneCode] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GC_WebSrvClassEN SetMemo(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLog4GC_WebSrvClass.Memo);
}
objLog4GC_WebSrvClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GC_WebSrvClassEN.dicFldComparisonOp.ContainsKey(conLog4GC_WebSrvClass.Memo) == false)
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp.Add(conLog4GC_WebSrvClass.Memo, strComparisonOp);
}
else
{
objLog4GC_WebSrvClassEN.dicFldComparisonOp[conLog4GC_WebSrvClass.Memo] = strComparisonOp;
}
}
return objLog4GC_WebSrvClassEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objLog4GC_WebSrvClassEN.CheckPropertyNew();
clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassCond = new clsLog4GC_WebSrvClassEN();
string strCondition = objLog4GC_WebSrvClassCond
.SetmId(objLog4GC_WebSrvClassEN.mId, "<>")
.SetUserId(objLog4GC_WebSrvClassEN.UserId, "=")
.SetWebSrvClassId(objLog4GC_WebSrvClassEN.WebSrvClassId, "=")
.GetCombineCondition();
objLog4GC_WebSrvClassEN._IsCheckProperty = true;
bool bolIsExist = clsLog4GC_WebSrvClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_WebSrvClassId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objLog4GC_WebSrvClassEN.Update();
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
 /// <param name = "objLog4GC_WebSrvClass">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClass)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassCond = new clsLog4GC_WebSrvClassEN();
string strCondition = objLog4GC_WebSrvClassCond
.SetUserId(objLog4GC_WebSrvClass.UserId, "=")
.SetWebSrvClassId(objLog4GC_WebSrvClass.WebSrvClassId, "=")
.GetCombineCondition();
objLog4GC_WebSrvClass._IsCheckProperty = true;
bool bolIsExist = clsLog4GC_WebSrvClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objLog4GC_WebSrvClass.mId = clsLog4GC_WebSrvClassBL.GetFirstID_S(strCondition);
objLog4GC_WebSrvClass.UpdateWithCondition(strCondition);
}
else
{
objLog4GC_WebSrvClass.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 if (objLog4GC_WebSrvClassEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.UpdateBySql2(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GC_WebSrvClassEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.UpdateBySql2(objLog4GC_WebSrvClassEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strWhereCond)
{
try
{
bool bolResult = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.UpdateBySqlWithCondition(objLog4GC_WebSrvClassEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.UpdateBySqlWithConditionTransaction(objLog4GC_WebSrvClassEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
public static int Delete(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
try
{
int intRecNum = clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.DelRecord(objLog4GC_WebSrvClassEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassENS">源对象</param>
 /// <param name = "objLog4GC_WebSrvClassENT">目标对象</param>
 public static void CopyTo(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENS, clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENT)
{
try
{
objLog4GC_WebSrvClassENT.mId = objLog4GC_WebSrvClassENS.mId; //mId
objLog4GC_WebSrvClassENT.UserId = objLog4GC_WebSrvClassENS.UserId; //用户Id
objLog4GC_WebSrvClassENT.WebSrvClassId = objLog4GC_WebSrvClassENS.WebSrvClassId; //类Id
objLog4GC_WebSrvClassENT.GeneCodeDate = objLog4GC_WebSrvClassENS.GeneCodeDate; //生成代码日期
objLog4GC_WebSrvClassENT.VersionGeneCode = objLog4GC_WebSrvClassENS.VersionGeneCode; //生成代码版本
objLog4GC_WebSrvClassENT.Memo = objLog4GC_WebSrvClassENS.Memo; //说明
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
 /// <param name = "objLog4GC_WebSrvClassENS">源对象</param>
 /// <returns>目标对象=>clsLog4GC_WebSrvClassEN:objLog4GC_WebSrvClassENT</returns>
 public static clsLog4GC_WebSrvClassEN CopyTo(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENS)
{
try
{
 clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENT = new clsLog4GC_WebSrvClassEN()
{
mId = objLog4GC_WebSrvClassENS.mId, //mId
UserId = objLog4GC_WebSrvClassENS.UserId, //用户Id
WebSrvClassId = objLog4GC_WebSrvClassENS.WebSrvClassId, //类Id
GeneCodeDate = objLog4GC_WebSrvClassENS.GeneCodeDate, //生成代码日期
VersionGeneCode = objLog4GC_WebSrvClassENS.VersionGeneCode, //生成代码版本
Memo = objLog4GC_WebSrvClassENS.Memo, //说明
};
 return objLog4GC_WebSrvClassENT;
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
public static void CheckPropertyNew(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.CheckPropertyNew(objLog4GC_WebSrvClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 clsLog4GC_WebSrvClassBL.Log4GC_WebSrvClassDA.CheckProperty4Condition(objLog4GC_WebSrvClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.mId) == true)
{
string strComparisonOpmId = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4GC_WebSrvClass.mId, objLog4GC_WebSrvClassCond.mId, strComparisonOpmId);
}
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.UserId) == true)
{
string strComparisonOpUserId = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GC_WebSrvClass.UserId, objLog4GC_WebSrvClassCond.UserId, strComparisonOpUserId);
}
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GC_WebSrvClass.WebSrvClassId, objLog4GC_WebSrvClassCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GC_WebSrvClass.GeneCodeDate, objLog4GC_WebSrvClassCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GC_WebSrvClass.VersionGeneCode, objLog4GC_WebSrvClassCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objLog4GC_WebSrvClassCond.IsUpdated(conLog4GC_WebSrvClass.Memo) == true)
{
string strComparisonOpMemo = objLog4GC_WebSrvClassCond.dicFldComparisonOp[conLog4GC_WebSrvClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GC_WebSrvClass.Memo, objLog4GC_WebSrvClassCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Log4GC_WebSrvClass(生成WebSrvClass代码日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objLog4GC_WebSrvClassEN == null) return true;
if (objLog4GC_WebSrvClassEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objLog4GC_WebSrvClassEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objLog4GC_WebSrvClassEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GC_WebSrvClassEN.UserId);
}
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objLog4GC_WebSrvClassEN.WebSrvClassId);
if (clsLog4GC_WebSrvClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4GC_WebSrvClassEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GC_WebSrvClassEN.UserId);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objLog4GC_WebSrvClassEN.WebSrvClassId);
if (clsLog4GC_WebSrvClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Log4GC_WebSrvClass(生成WebSrvClass代码日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLog4GC_WebSrvClassEN == null) return "";
if (objLog4GC_WebSrvClassEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objLog4GC_WebSrvClassEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objLog4GC_WebSrvClassEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GC_WebSrvClassEN.UserId);
}
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objLog4GC_WebSrvClassEN.WebSrvClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4GC_WebSrvClassEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GC_WebSrvClassEN.UserId);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objLog4GC_WebSrvClassEN.WebSrvClassId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Log4GC_WebSrvClass
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 生成WebSrvClass代码日志(Log4GC_WebSrvClass)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsLog4GC_WebSrvClassBL
{
public static RelatedActions_Log4GC_WebSrvClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsLog4GC_WebSrvClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsLog4GC_WebSrvClassDA Log4GC_WebSrvClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsLog4GC_WebSrvClassDA();
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
 public clsLog4GC_WebSrvClassBL()
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
if (string.IsNullOrEmpty(clsLog4GC_WebSrvClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLog4GC_WebSrvClassEN._ConnectString);
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
public static DataTable GetDataTable_Log4GC_WebSrvClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Log4GC_WebSrvClassDA.GetDataTable_Log4GC_WebSrvClass(strWhereCond);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable(strWhereCond);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable_Top(objTopPara);
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
objDT = Log4GC_WebSrvClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Log4GC_WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Log4GC_WebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
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
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsLog4GC_WebSrvClassEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsLog4GC_WebSrvClassEN._CurrTabName);
List<clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLst_Sel =
arrLog4GC_WebSrvClassObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrLog4GC_WebSrvClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetObjLst(string strWhereCond)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsLog4GC_WebSrvClassEN> GetSubObjLstCache(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassCond)
{
List<clsLog4GC_WebSrvClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GC_WebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLog4GC_WebSrvClass._AttributeName)
{
if (objLog4GC_WebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objLog4GC_WebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GC_WebSrvClassCond[strFldName].ToString());
}
else
{
if (objLog4GC_WebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLog4GC_WebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GC_WebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLog4GC_WebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLog4GC_WebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLog4GC_WebSrvClassCond[strFldName]));
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
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
List<clsLog4GC_WebSrvClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsLog4GC_WebSrvClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsLog4GC_WebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
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
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
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
public static List<clsLog4GC_WebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
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
public static List<clsLog4GC_WebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsLog4GC_WebSrvClassEN> arrObjLst = new List<clsLog4GC_WebSrvClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = new clsLog4GC_WebSrvClassEN();
try
{
objLog4GC_WebSrvClassEN.mId = Int32.Parse(objRow[conLog4GC_WebSrvClass.mId].ToString().Trim()); //mId
objLog4GC_WebSrvClassEN.UserId = objRow[conLog4GC_WebSrvClass.UserId] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.UserId].ToString().Trim(); //用户Id
objLog4GC_WebSrvClassEN.WebSrvClassId = objRow[conLog4GC_WebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objLog4GC_WebSrvClassEN.GeneCodeDate = objRow[conLog4GC_WebSrvClass.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GC_WebSrvClassEN.VersionGeneCode = objRow[conLog4GC_WebSrvClass.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GC_WebSrvClassEN.Memo = objRow[conLog4GC_WebSrvClass.Memo] == DBNull.Value ? null : objRow[conLog4GC_WebSrvClass.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GC_WebSrvClassEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GC_WebSrvClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetLog4GC_WebSrvClass(ref clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
bool bolResult = Log4GC_WebSrvClassDA.GetLog4GC_WebSrvClass(ref objLog4GC_WebSrvClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4GC_WebSrvClassEN GetObjBymId(long lngmId)
{
clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = Log4GC_WebSrvClassDA.GetObjBymId(lngmId);
return objLog4GC_WebSrvClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsLog4GC_WebSrvClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = Log4GC_WebSrvClassDA.GetFirstObj(strWhereCond);
 return objLog4GC_WebSrvClassEN;
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
public static clsLog4GC_WebSrvClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = Log4GC_WebSrvClassDA.GetObjByDataRow(objRow);
 return objLog4GC_WebSrvClassEN;
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
public static clsLog4GC_WebSrvClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = Log4GC_WebSrvClassDA.GetObjByDataRow(objRow);
 return objLog4GC_WebSrvClassEN;
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
 /// <param name = "lstLog4GC_WebSrvClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLog4GC_WebSrvClassEN GetObjBymIdFromList(long lngmId, List<clsLog4GC_WebSrvClassEN> lstLog4GC_WebSrvClassObjLst)
{
foreach (clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN in lstLog4GC_WebSrvClassObjLst)
{
if (objLog4GC_WebSrvClassEN.mId == lngmId)
{
return objLog4GC_WebSrvClassEN;
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
 lngmId = new clsLog4GC_WebSrvClassDA().GetFirstID(strWhereCond);
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
 arrList = Log4GC_WebSrvClassDA.GetID(strWhereCond);
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
bool bolIsExist = Log4GC_WebSrvClassDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = Log4GC_WebSrvClassDA.IsExist(lngmId);
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
 bolIsExist = clsLog4GC_WebSrvClassDA.IsExistTable();
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
 bolIsExist = Log4GC_WebSrvClassDA.IsExistTable(strTabName);
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLog4GC_WebSrvClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],类Id = [{1}]的数据已经存在!(in clsLog4GC_WebSrvClassBL.AddNewRecordBySql2)", objLog4GC_WebSrvClassEN.UserId,objLog4GC_WebSrvClassEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
bool bolResult = Log4GC_WebSrvClassDA.AddNewRecordBySQL2(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLog4GC_WebSrvClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],类Id = [{1}]的数据已经存在!(in clsLog4GC_WebSrvClassBL.AddNewRecordBySql2WithReturnKey)", objLog4GC_WebSrvClassEN.UserId,objLog4GC_WebSrvClassEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
string strKey = Log4GC_WebSrvClassDA.AddNewRecordBySQL2WithReturnKey(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
try
{
bool bolResult = Log4GC_WebSrvClassDA.Update(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GC_WebSrvClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 if (objLog4GC_WebSrvClassEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Log4GC_WebSrvClassDA.UpdateBySql2(objLog4GC_WebSrvClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GC_WebSrvClassBL.ReFreshCache();

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
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
 clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN = clsLog4GC_WebSrvClassBL.GetObjBymId(lngmId);

if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(objLog4GC_WebSrvClassEN.mId, "SetUpdDate");
}
if (objLog4GC_WebSrvClassEN != null)
{
int intRecNum = Log4GC_WebSrvClassDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLog4GC_WebSrvClassDA.GetSpecSQLObj();
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
//删除与表:[Log4GC_WebSrvClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conLog4GC_WebSrvClass.mId,
//lngmId);
//        clsLog4GC_WebSrvClassBL.DelLog4GC_WebSrvClasssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLog4GC_WebSrvClassBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLog4GC_WebSrvClassBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = Log4GC_WebSrvClassDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelLog4GC_WebSrvClasss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = Log4GC_WebSrvClassDA.DelLog4GC_WebSrvClass(arrmIdLst);
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
public static int DelLog4GC_WebSrvClasssByCond(string strWhereCond)
{
try
{
if (clsLog4GC_WebSrvClassBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsLog4GC_WebSrvClassBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = Log4GC_WebSrvClassDA.DelLog4GC_WebSrvClass(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Log4GC_WebSrvClass]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLog4GC_WebSrvClassDA.GetSpecSQLObj();
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
//删除与表:[Log4GC_WebSrvClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLog4GC_WebSrvClassBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLog4GC_WebSrvClassBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objLog4GC_WebSrvClassENS">源对象</param>
 /// <param name = "objLog4GC_WebSrvClassENT">目标对象</param>
 public static void CopyTo(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENS, clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassENT)
{
try
{
objLog4GC_WebSrvClassENT.mId = objLog4GC_WebSrvClassENS.mId; //mId
objLog4GC_WebSrvClassENT.UserId = objLog4GC_WebSrvClassENS.UserId; //用户Id
objLog4GC_WebSrvClassENT.WebSrvClassId = objLog4GC_WebSrvClassENS.WebSrvClassId; //类Id
objLog4GC_WebSrvClassENT.GeneCodeDate = objLog4GC_WebSrvClassENS.GeneCodeDate; //生成代码日期
objLog4GC_WebSrvClassENT.VersionGeneCode = objLog4GC_WebSrvClassENS.VersionGeneCode; //生成代码版本
objLog4GC_WebSrvClassENT.Memo = objLog4GC_WebSrvClassENS.Memo; //说明
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
 /// <param name = "objLog4GC_WebSrvClassEN">源简化对象</param>
 public static void SetUpdFlag(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
try
{
objLog4GC_WebSrvClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objLog4GC_WebSrvClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conLog4GC_WebSrvClass.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.mId = objLog4GC_WebSrvClassEN.mId; //mId
}
if (arrFldSet.Contains(conLog4GC_WebSrvClass.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.UserId = objLog4GC_WebSrvClassEN.UserId == "[null]" ? null :  objLog4GC_WebSrvClassEN.UserId; //用户Id
}
if (arrFldSet.Contains(conLog4GC_WebSrvClass.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.WebSrvClassId = objLog4GC_WebSrvClassEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(conLog4GC_WebSrvClass.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.GeneCodeDate = objLog4GC_WebSrvClassEN.GeneCodeDate == "[null]" ? null :  objLog4GC_WebSrvClassEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(conLog4GC_WebSrvClass.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.VersionGeneCode = objLog4GC_WebSrvClassEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(conLog4GC_WebSrvClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GC_WebSrvClassEN.Memo = objLog4GC_WebSrvClassEN.Memo == "[null]" ? null :  objLog4GC_WebSrvClassEN.Memo; //说明
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
 /// <param name = "objLog4GC_WebSrvClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
try
{
if (objLog4GC_WebSrvClassEN.UserId == "[null]") objLog4GC_WebSrvClassEN.UserId = null; //用户Id
if (objLog4GC_WebSrvClassEN.GeneCodeDate == "[null]") objLog4GC_WebSrvClassEN.GeneCodeDate = null; //生成代码日期
if (objLog4GC_WebSrvClassEN.Memo == "[null]") objLog4GC_WebSrvClassEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 Log4GC_WebSrvClassDA.CheckPropertyNew(objLog4GC_WebSrvClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
 Log4GC_WebSrvClassDA.CheckProperty4Condition(objLog4GC_WebSrvClassEN);
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
if (clsLog4GC_WebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GC_WebSrvClassBL没有刷新缓存机制(clsLog4GC_WebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrLog4GC_WebSrvClassObjLstCache == null)
//{
//arrLog4GC_WebSrvClassObjLstCache = Log4GC_WebSrvClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLog4GC_WebSrvClassEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsLog4GC_WebSrvClassEN._CurrTabName);
List<clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLst_Sel =
arrLog4GC_WebSrvClassObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrLog4GC_WebSrvClassObjLst_Sel.Count() == 0)
{
   clsLog4GC_WebSrvClassEN obj = clsLog4GC_WebSrvClassBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrLog4GC_WebSrvClassObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetAllLog4GC_WebSrvClassObjLstCache()
{
//获取缓存中的对象列表
List<clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLstCache = GetObjLstCache(); 
return arrLog4GC_WebSrvClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLog4GC_WebSrvClassEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsLog4GC_WebSrvClassEN._CurrTabName);
List<clsLog4GC_WebSrvClassEN> arrLog4GC_WebSrvClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLog4GC_WebSrvClassObjLstCache;
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
string strKey = string.Format("{0}", clsLog4GC_WebSrvClassEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4GC_WebSrvClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsLog4GC_WebSrvClassEN._RefreshTimeLst.Count == 0) return "";
return clsLog4GC_WebSrvClassEN._RefreshTimeLst[clsLog4GC_WebSrvClassEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsLog4GC_WebSrvClassBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLog4GC_WebSrvClassEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4GC_WebSrvClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsLog4GC_WebSrvClassBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Log4GC_WebSrvClass(生成WebSrvClass代码日志)
 /// 唯一性条件:UserId_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassEN)
{
//检测记录是否存在
string strResult = Log4GC_WebSrvClassDA.GetUniCondStr(objLog4GC_WebSrvClassEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conLog4GC_WebSrvClass.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conLog4GC_WebSrvClass._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conLog4GC_WebSrvClass._AttributeName));
throw new Exception(strMsg);
}
var objLog4GC_WebSrvClass = clsLog4GC_WebSrvClassBL.GetObjBymIdCache(lngmId);
if (objLog4GC_WebSrvClass == null) return "";
return objLog4GC_WebSrvClass[strOutFldName].ToString();
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
int intRecCount = clsLog4GC_WebSrvClassDA.GetRecCount(strTabName);
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
int intRecCount = clsLog4GC_WebSrvClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsLog4GC_WebSrvClassDA.GetRecCount();
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
int intRecCount = clsLog4GC_WebSrvClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objLog4GC_WebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsLog4GC_WebSrvClassEN objLog4GC_WebSrvClassCond)
{
List<clsLog4GC_WebSrvClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GC_WebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLog4GC_WebSrvClass._AttributeName)
{
if (objLog4GC_WebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objLog4GC_WebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GC_WebSrvClassCond[strFldName].ToString());
}
else
{
if (objLog4GC_WebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLog4GC_WebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GC_WebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLog4GC_WebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLog4GC_WebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLog4GC_WebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLog4GC_WebSrvClassCond[strFldName]));
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
 List<string> arrList = clsLog4GC_WebSrvClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Log4GC_WebSrvClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Log4GC_WebSrvClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Log4GC_WebSrvClassDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsLog4GC_WebSrvClassDA.SetFldValue(clsLog4GC_WebSrvClassEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Log4GC_WebSrvClassDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsLog4GC_WebSrvClassDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsLog4GC_WebSrvClassDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsLog4GC_WebSrvClassDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Log4GC_WebSrvClass] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" WebSrvClassId char(8) not Null, "); 
 // /**生成代码日期*/ 
 strCreateTabCode.Append(" GeneCodeDate varchar(20) Null, "); 
 // /**生成代码版本*/ 
 strCreateTabCode.Append(" VersionGeneCode varchar(30) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 生成WebSrvClass代码日志(Log4GC_WebSrvClass)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Log4GC_WebSrvClass : clsCommFun4BL
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
clsLog4GC_WebSrvClassBL.ReFreshThisCache();
}
}

}