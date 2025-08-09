
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncMapModeBL
 表名:FuncMapMode(00050551)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:11
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsFuncMapModeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncMapModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncMapModeEN GetObj(this K_FuncMapModeId_FuncMapMode myKey)
{
clsFuncMapModeEN objFuncMapModeEN = clsFuncMapModeBL.FuncMapModeDA.GetObjByFuncMapModeId(myKey.Value);
return objFuncMapModeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncMapModeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数映射模式名 = [{0}]的数据已经存在!(in clsFuncMapModeBL.AddNewRecord)", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
bool bolResult = clsFuncMapModeBL.FuncMapModeDA.AddNewRecordBySQL2(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
public static bool AddRecordEx(this clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFuncMapModeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFuncMapModeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数映射模式名(FuncMapModeName)=[{0}])已经存在,不能重复!", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFuncMapModeEN.AddNewRecord();
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncMapModeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数映射模式名 = [{0}]的数据已经存在!(in clsFuncMapModeBL.AddNewRecordWithMaxId)", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
string strFuncMapModeId = clsFuncMapModeBL.FuncMapModeDA.AddNewRecordBySQL2WithReturnKey(objFuncMapModeEN);
     objFuncMapModeEN.FuncMapModeId = strFuncMapModeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
}
return strFuncMapModeId;
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncMapModeEN) == false)
{
var strMsg = string.Format("记录已经存在!函数映射模式名 = [{0}]的数据已经存在!(in clsFuncMapModeBL.AddNewRecordWithReturnKey)", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
string strKey = clsFuncMapModeBL.FuncMapModeDA.AddNewRecordBySQL2WithReturnKey(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetFuncMapModeId(this clsFuncMapModeEN objFuncMapModeEN, string strFuncMapModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, conFuncMapMode.FuncMapModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, conFuncMapMode.FuncMapModeId);
}
objFuncMapModeEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.FuncMapModeId) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.FuncMapModeId, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.FuncMapModeId] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetFuncMapModeName(this clsFuncMapModeEN objFuncMapModeEN, string strFuncMapModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeName, 50, conFuncMapMode.FuncMapModeName);
}
objFuncMapModeEN.FuncMapModeName = strFuncMapModeName; //函数映射模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.FuncMapModeName) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.FuncMapModeName, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.FuncMapModeName] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetFuncMapModeENName(this clsFuncMapModeEN objFuncMapModeEN, string strFuncMapModeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeENName, 50, conFuncMapMode.FuncMapModeENName);
}
objFuncMapModeEN.FuncMapModeENName = strFuncMapModeENName; //函数映射模式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.FuncMapModeENName) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.FuncMapModeENName, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.FuncMapModeENName] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetUpdDate(this clsFuncMapModeEN objFuncMapModeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncMapMode.UpdDate);
}
objFuncMapModeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.UpdDate) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.UpdDate, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.UpdDate] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetUpdUser(this clsFuncMapModeEN objFuncMapModeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncMapMode.UpdUser);
}
objFuncMapModeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.UpdUser) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.UpdUser, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.UpdUser] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncMapModeEN SetMemo(this clsFuncMapModeEN objFuncMapModeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncMapMode.Memo);
}
objFuncMapModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncMapModeEN.dicFldComparisonOp.ContainsKey(conFuncMapMode.Memo) == false)
{
objFuncMapModeEN.dicFldComparisonOp.Add(conFuncMapMode.Memo, strComparisonOp);
}
else
{
objFuncMapModeEN.dicFldComparisonOp[conFuncMapMode.Memo] = strComparisonOp;
}
}
return objFuncMapModeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncMapModeEN objFuncMapModeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncMapModeEN.CheckPropertyNew();
clsFuncMapModeEN objFuncMapModeCond = new clsFuncMapModeEN();
string strCondition = objFuncMapModeCond
.SetFuncMapModeId(objFuncMapModeEN.FuncMapModeId, "<>")
.SetFuncMapModeName(objFuncMapModeEN.FuncMapModeName, "=")
.GetCombineCondition();
objFuncMapModeEN._IsCheckProperty = true;
bool bolIsExist = clsFuncMapModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncMapModeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncMapModeEN.Update();
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
 /// <param name = "objFuncMapMode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFuncMapModeEN objFuncMapMode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFuncMapModeEN objFuncMapModeCond = new clsFuncMapModeEN();
string strCondition = objFuncMapModeCond
.SetFuncMapModeName(objFuncMapMode.FuncMapModeName, "=")
.GetCombineCondition();
objFuncMapMode._IsCheckProperty = true;
bool bolIsExist = clsFuncMapModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFuncMapMode.FuncMapModeId = clsFuncMapModeBL.GetFirstID_S(strCondition);
objFuncMapMode.UpdateWithCondition(strCondition);
}
else
{
objFuncMapMode.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
objFuncMapMode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncMapModeEN objFuncMapModeEN)
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncMapModeBL.FuncMapModeDA.UpdateBySql2(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncMapModeEN objFuncMapModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncMapModeBL.FuncMapModeDA.UpdateBySql2(objFuncMapModeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncMapModeEN objFuncMapModeEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncMapModeBL.FuncMapModeDA.UpdateBySqlWithCondition(objFuncMapModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncMapModeEN objFuncMapModeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncMapModeBL.FuncMapModeDA.UpdateBySqlWithConditionTransaction(objFuncMapModeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFuncMapModeEN objFuncMapModeEN)
{
try
{
int intRecNum = clsFuncMapModeBL.FuncMapModeDA.DelRecord(objFuncMapModeEN.FuncMapModeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <param name = "objFuncMapModeENT">目标对象</param>
 public static void CopyTo(this clsFuncMapModeEN objFuncMapModeENS, clsFuncMapModeEN objFuncMapModeENT)
{
try
{
objFuncMapModeENT.FuncMapModeId = objFuncMapModeENS.FuncMapModeId; //函数映射模式Id
objFuncMapModeENT.FuncMapModeName = objFuncMapModeENS.FuncMapModeName; //函数映射模式名
objFuncMapModeENT.FuncMapModeENName = objFuncMapModeENS.FuncMapModeENName; //函数映射模式英文名
objFuncMapModeENT.UpdDate = objFuncMapModeENS.UpdDate; //修改日期
objFuncMapModeENT.UpdUser = objFuncMapModeENS.UpdUser; //修改者
objFuncMapModeENT.Memo = objFuncMapModeENS.Memo; //说明
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
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <returns>目标对象=>clsFuncMapModeEN:objFuncMapModeENT</returns>
 public static clsFuncMapModeEN CopyTo(this clsFuncMapModeEN objFuncMapModeENS)
{
try
{
 clsFuncMapModeEN objFuncMapModeENT = new clsFuncMapModeEN()
{
FuncMapModeId = objFuncMapModeENS.FuncMapModeId, //函数映射模式Id
FuncMapModeName = objFuncMapModeENS.FuncMapModeName, //函数映射模式名
FuncMapModeENName = objFuncMapModeENS.FuncMapModeENName, //函数映射模式英文名
UpdDate = objFuncMapModeENS.UpdDate, //修改日期
UpdUser = objFuncMapModeENS.UpdUser, //修改者
Memo = objFuncMapModeENS.Memo, //说明
};
 return objFuncMapModeENT;
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
public static void CheckPropertyNew(this clsFuncMapModeEN objFuncMapModeEN)
{
 clsFuncMapModeBL.FuncMapModeDA.CheckPropertyNew(objFuncMapModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncMapModeEN objFuncMapModeEN)
{
 clsFuncMapModeBL.FuncMapModeDA.CheckProperty4Condition(objFuncMapModeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncMapModeEN objFuncMapModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.FuncMapModeId, objFuncMapModeCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.FuncMapModeName) == true)
{
string strComparisonOpFuncMapModeName = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.FuncMapModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.FuncMapModeName, objFuncMapModeCond.FuncMapModeName, strComparisonOpFuncMapModeName);
}
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.FuncMapModeENName) == true)
{
string strComparisonOpFuncMapModeENName = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.FuncMapModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.FuncMapModeENName, objFuncMapModeCond.FuncMapModeENName, strComparisonOpFuncMapModeENName);
}
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.UpdDate, objFuncMapModeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.UpdUser, objFuncMapModeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncMapModeCond.IsUpdated(conFuncMapMode.Memo) == true)
{
string strComparisonOpMemo = objFuncMapModeCond.dicFldComparisonOp[conFuncMapMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncMapMode.Memo, objFuncMapModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FuncMapMode(函数映射模式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncMapModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFuncMapModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFuncMapModeEN objFuncMapModeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFuncMapModeEN == null) return true;
if (objFuncMapModeEN.FuncMapModeId == null || objFuncMapModeEN.FuncMapModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncMapModeEN.FuncMapModeName == null)
{
 sbCondition.AppendFormat(" and FuncMapModeName is null", objFuncMapModeEN.FuncMapModeName);
}
else
{
 sbCondition.AppendFormat(" and FuncMapModeName = '{0}'", objFuncMapModeEN.FuncMapModeName);
}
if (clsFuncMapModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncMapModeId !=  '{0}'", objFuncMapModeEN.FuncMapModeId);
 sbCondition.AppendFormat(" and FuncMapModeName = '{0}'", objFuncMapModeEN.FuncMapModeName);
if (clsFuncMapModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FuncMapMode(函数映射模式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncMapModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncMapModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFuncMapModeEN objFuncMapModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncMapModeEN == null) return "";
if (objFuncMapModeEN.FuncMapModeId == null || objFuncMapModeEN.FuncMapModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncMapModeEN.FuncMapModeName == null)
{
 sbCondition.AppendFormat(" and FuncMapModeName is null", objFuncMapModeEN.FuncMapModeName);
}
else
{
 sbCondition.AppendFormat(" and FuncMapModeName = '{0}'", objFuncMapModeEN.FuncMapModeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncMapModeId !=  '{0}'", objFuncMapModeEN.FuncMapModeId);
 sbCondition.AppendFormat(" and FuncMapModeName = '{0}'", objFuncMapModeEN.FuncMapModeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncMapMode
{
public virtual bool UpdRelaTabDate(string strFuncMapModeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumFuncMapMode
{
 /// <summary>
 /// 表
 /// </summary>
public const string Table_01 = "01";
 /// <summary>
 /// 函数
 /// </summary>
public const string Function_02 = "02";
}
 /// <summary>
 /// 函数映射模式(FuncMapMode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncMapModeBL
{
public static RelatedActions_FuncMapMode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncMapModeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncMapModeDA FuncMapModeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncMapModeDA();
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
 public clsFuncMapModeBL()
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
if (string.IsNullOrEmpty(clsFuncMapModeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncMapModeEN._ConnectString);
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
public static DataTable GetDataTable_FuncMapMode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncMapModeDA.GetDataTable_FuncMapMode(strWhereCond);
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
objDT = FuncMapModeDA.GetDataTable(strWhereCond);
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
objDT = FuncMapModeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncMapModeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncMapModeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncMapModeDA.GetDataTable_Top(objTopPara);
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
objDT = FuncMapModeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FuncMapModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncMapModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncMapModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFuncMapModeEN> GetObjLstByFuncMapModeIdLst(List<string> arrFuncMapModeIdLst)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncMapModeIdLst, true);
 string strWhereCond = string.Format("FuncMapModeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncMapModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncMapModeEN> GetObjLstByFuncMapModeIdLstCache(List<string> arrFuncMapModeIdLst)
{
string strKey = string.Format("{0}", clsFuncMapModeEN._CurrTabName);
List<clsFuncMapModeEN> arrFuncMapModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncMapModeEN> arrFuncMapModeObjLst_Sel =
arrFuncMapModeObjLstCache
.Where(x => arrFuncMapModeIdLst.Contains(x.FuncMapModeId));
return arrFuncMapModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncMapModeEN> GetObjLst(string strWhereCond)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
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
public static List<clsFuncMapModeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncMapModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncMapModeEN> GetSubObjLstCache(clsFuncMapModeEN objFuncMapModeCond)
{
List<clsFuncMapModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncMapModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncMapMode._AttributeName)
{
if (objFuncMapModeCond.IsUpdated(strFldName) == false) continue;
if (objFuncMapModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncMapModeCond[strFldName].ToString());
}
else
{
if (objFuncMapModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncMapModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncMapModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncMapModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncMapModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncMapModeCond[strFldName]));
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
public static List<clsFuncMapModeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
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
public static List<clsFuncMapModeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
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
List<clsFuncMapModeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncMapModeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncMapModeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncMapModeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
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
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
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
public static List<clsFuncMapModeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncMapModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncMapModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
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
public static List<clsFuncMapModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncMapModeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncMapModeEN> arrObjLst = new List<clsFuncMapModeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN();
try
{
objFuncMapModeEN.FuncMapModeId = objRow[conFuncMapMode.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objFuncMapModeEN.FuncMapModeName = objRow[conFuncMapMode.FuncMapModeName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeName].ToString().Trim(); //函数映射模式名
objFuncMapModeEN.FuncMapModeENName = objRow[conFuncMapMode.FuncMapModeENName] == DBNull.Value ? null : objRow[conFuncMapMode.FuncMapModeENName].ToString().Trim(); //函数映射模式英文名
objFuncMapModeEN.UpdDate = objRow[conFuncMapMode.UpdDate] == DBNull.Value ? null : objRow[conFuncMapMode.UpdDate].ToString().Trim(); //修改日期
objFuncMapModeEN.UpdUser = objRow[conFuncMapMode.UpdUser] == DBNull.Value ? null : objRow[conFuncMapMode.UpdUser].ToString().Trim(); //修改者
objFuncMapModeEN.Memo = objRow[conFuncMapMode.Memo] == DBNull.Value ? null : objRow[conFuncMapMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncMapModeEN.FuncMapModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncMapModeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncMapModeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncMapMode(ref clsFuncMapModeEN objFuncMapModeEN)
{
bool bolResult = FuncMapModeDA.GetFuncMapMode(ref objFuncMapModeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncMapModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncMapModeEN GetObjByFuncMapModeId(string strFuncMapModeId)
{
if (strFuncMapModeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncMapModeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncMapModeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncMapModeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFuncMapModeEN objFuncMapModeEN = FuncMapModeDA.GetObjByFuncMapModeId(strFuncMapModeId);
return objFuncMapModeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncMapModeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncMapModeEN objFuncMapModeEN = FuncMapModeDA.GetFirstObj(strWhereCond);
 return objFuncMapModeEN;
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
public static clsFuncMapModeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncMapModeEN objFuncMapModeEN = FuncMapModeDA.GetObjByDataRow(objRow);
 return objFuncMapModeEN;
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
public static clsFuncMapModeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncMapModeEN objFuncMapModeEN = FuncMapModeDA.GetObjByDataRow(objRow);
 return objFuncMapModeEN;
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
 /// <param name = "strFuncMapModeId">所给的关键字</param>
 /// <param name = "lstFuncMapModeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncMapModeEN GetObjByFuncMapModeIdFromList(string strFuncMapModeId, List<clsFuncMapModeEN> lstFuncMapModeObjLst)
{
foreach (clsFuncMapModeEN objFuncMapModeEN in lstFuncMapModeObjLst)
{
if (objFuncMapModeEN.FuncMapModeId == strFuncMapModeId)
{
return objFuncMapModeEN;
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
 string strMaxFuncMapModeId;
 try
 {
 strMaxFuncMapModeId = clsFuncMapModeDA.GetMaxStrId();
 return strMaxFuncMapModeId;
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
 string strFuncMapModeId;
 try
 {
 strFuncMapModeId = new clsFuncMapModeDA().GetFirstID(strWhereCond);
 return strFuncMapModeId;
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
 arrList = FuncMapModeDA.GetID(strWhereCond);
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
bool bolIsExist = FuncMapModeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncMapModeId)
{
if (string.IsNullOrEmpty(strFuncMapModeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncMapModeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FuncMapModeDA.IsExist(strFuncMapModeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncMapModeId">函数映射模式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncMapModeId, string strOpUser)
{
clsFuncMapModeEN objFuncMapModeEN = clsFuncMapModeBL.GetObjByFuncMapModeId(strFuncMapModeId);
objFuncMapModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFuncMapModeEN.UpdUser = strOpUser;
return clsFuncMapModeBL.UpdateBySql2(objFuncMapModeEN);
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
 bolIsExist = clsFuncMapModeDA.IsExistTable();
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
 bolIsExist = FuncMapModeDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncMapModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数映射模式名 = [{0}]的数据已经存在!(in clsFuncMapModeBL.AddNewRecordBySql2)", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
bool bolResult = FuncMapModeDA.AddNewRecordBySQL2(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncMapModeEN objFuncMapModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncMapModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数映射模式名 = [{0}]的数据已经存在!(in clsFuncMapModeBL.AddNewRecordBySql2WithReturnKey)", objFuncMapModeEN.FuncMapModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true || clsFuncMapModeBL.IsExist(objFuncMapModeEN.FuncMapModeId) == true)
 {
     objFuncMapModeEN.FuncMapModeId = clsFuncMapModeBL.GetMaxStrId_S();
 }
string strKey = FuncMapModeDA.AddNewRecordBySQL2WithReturnKey(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncMapModeEN objFuncMapModeEN)
{
try
{
bool bolResult = FuncMapModeDA.Update(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "objFuncMapModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncMapModeEN objFuncMapModeEN)
{
 if (string.IsNullOrEmpty(objFuncMapModeEN.FuncMapModeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncMapModeDA.UpdateBySql2(objFuncMapModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncMapModeBL.ReFreshCache();

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
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
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncMapModeId)
{
try
{
 clsFuncMapModeEN objFuncMapModeEN = clsFuncMapModeBL.GetObjByFuncMapModeId(strFuncMapModeId);

if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(objFuncMapModeEN.FuncMapModeId, objFuncMapModeEN.UpdUser);
}
if (objFuncMapModeEN != null)
{
int intRecNum = FuncMapModeDA.DelRecord(strFuncMapModeId);
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
/// <param name="strFuncMapModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncMapModeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
//删除与表:[FuncMapMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncMapMode.FuncMapModeId,
//strFuncMapModeId);
//        clsFuncMapModeBL.DelFuncMapModesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncMapModeBL.DelRecord(strFuncMapModeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncMapModeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncMapModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncMapModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncMapModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFuncMapModeBL.relatedActions != null)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(strFuncMapModeId, "UpdRelaTabDate");
}
bool bolResult = FuncMapModeDA.DelRecord(strFuncMapModeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncMapModeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFuncMapModes(List<string> arrFuncMapModeIdLst)
{
if (arrFuncMapModeIdLst.Count == 0) return 0;
try
{
if (clsFuncMapModeBL.relatedActions != null)
{
foreach (var strFuncMapModeId in arrFuncMapModeIdLst)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(strFuncMapModeId, "UpdRelaTabDate");
}
}
int intDelRecNum = FuncMapModeDA.DelFuncMapMode(arrFuncMapModeIdLst);
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
public static int DelFuncMapModesByCond(string strWhereCond)
{
try
{
if (clsFuncMapModeBL.relatedActions != null)
{
List<string> arrFuncMapModeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncMapModeId in arrFuncMapModeId)
{
clsFuncMapModeBL.relatedActions.UpdRelaTabDate(strFuncMapModeId, "UpdRelaTabDate");
}
}
int intRecNum = FuncMapModeDA.DelFuncMapMode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FuncMapMode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncMapModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncMapModeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncMapModeDA.GetSpecSQLObj();
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
//删除与表:[FuncMapMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncMapModeBL.DelRecord(strFuncMapModeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncMapModeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncMapModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFuncMapModeENS">源对象</param>
 /// <param name = "objFuncMapModeENT">目标对象</param>
 public static void CopyTo(clsFuncMapModeEN objFuncMapModeENS, clsFuncMapModeEN objFuncMapModeENT)
{
try
{
objFuncMapModeENT.FuncMapModeId = objFuncMapModeENS.FuncMapModeId; //函数映射模式Id
objFuncMapModeENT.FuncMapModeName = objFuncMapModeENS.FuncMapModeName; //函数映射模式名
objFuncMapModeENT.FuncMapModeENName = objFuncMapModeENS.FuncMapModeENName; //函数映射模式英文名
objFuncMapModeENT.UpdDate = objFuncMapModeENS.UpdDate; //修改日期
objFuncMapModeENT.UpdUser = objFuncMapModeENS.UpdUser; //修改者
objFuncMapModeENT.Memo = objFuncMapModeENS.Memo; //说明
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
 /// <param name = "objFuncMapModeEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncMapModeEN objFuncMapModeEN)
{
try
{
objFuncMapModeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFuncMapModeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncMapMode.FuncMapModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.FuncMapModeId = objFuncMapModeEN.FuncMapModeId; //函数映射模式Id
}
if (arrFldSet.Contains(conFuncMapMode.FuncMapModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.FuncMapModeName = objFuncMapModeEN.FuncMapModeName == "[null]" ? null :  objFuncMapModeEN.FuncMapModeName; //函数映射模式名
}
if (arrFldSet.Contains(conFuncMapMode.FuncMapModeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.FuncMapModeENName = objFuncMapModeEN.FuncMapModeENName == "[null]" ? null :  objFuncMapModeEN.FuncMapModeENName; //函数映射模式英文名
}
if (arrFldSet.Contains(conFuncMapMode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.UpdDate = objFuncMapModeEN.UpdDate == "[null]" ? null :  objFuncMapModeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFuncMapMode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.UpdUser = objFuncMapModeEN.UpdUser == "[null]" ? null :  objFuncMapModeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFuncMapMode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncMapModeEN.Memo = objFuncMapModeEN.Memo == "[null]" ? null :  objFuncMapModeEN.Memo; //说明
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
 /// <param name = "objFuncMapModeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncMapModeEN objFuncMapModeEN)
{
try
{
if (objFuncMapModeEN.FuncMapModeName == "[null]") objFuncMapModeEN.FuncMapModeName = null; //函数映射模式名
if (objFuncMapModeEN.FuncMapModeENName == "[null]") objFuncMapModeEN.FuncMapModeENName = null; //函数映射模式英文名
if (objFuncMapModeEN.UpdDate == "[null]") objFuncMapModeEN.UpdDate = null; //修改日期
if (objFuncMapModeEN.UpdUser == "[null]") objFuncMapModeEN.UpdUser = null; //修改者
if (objFuncMapModeEN.Memo == "[null]") objFuncMapModeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFuncMapModeEN objFuncMapModeEN)
{
 FuncMapModeDA.CheckPropertyNew(objFuncMapModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncMapModeEN objFuncMapModeEN)
{
 FuncMapModeDA.CheckProperty4Condition(objFuncMapModeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncMapModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncMapMode.FuncMapModeId); 
List<clsFuncMapModeEN> arrObjLst = clsFuncMapModeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncMapModeEN objFuncMapModeEN = new clsFuncMapModeEN()
{
FuncMapModeId = "0",
FuncMapModeName = "选[函数映射模式]..."
};
arrObjLst.Insert(0, objFuncMapModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncMapMode.FuncMapModeId;
objComboBox.DisplayMember = conFuncMapMode.FuncMapModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncMapModeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数映射模式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFuncMapMode.FuncMapModeId); 
IEnumerable<clsFuncMapModeEN> arrObjLst = clsFuncMapModeBL.GetObjLst(strCondition);
objDDL.DataValueField = conFuncMapMode.FuncMapModeId;
objDDL.DataTextField = conFuncMapMode.FuncMapModeName;
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
public static void BindDdl_FuncMapModeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数映射模式]...","0");
List<clsFuncMapModeEN> arrFuncMapModeObjLst = GetAllFuncMapModeObjLstCache(); 
objDDL.DataValueField = conFuncMapMode.FuncMapModeId;
objDDL.DataTextField = conFuncMapMode.FuncMapModeName;
objDDL.DataSource = arrFuncMapModeObjLst;
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
if (clsFuncMapModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncMapModeBL没有刷新缓存机制(clsFuncMapModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncMapModeId");
//if (arrFuncMapModeObjLstCache == null)
//{
//arrFuncMapModeObjLstCache = FuncMapModeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncMapModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncMapModeEN GetObjByFuncMapModeIdCache(string strFuncMapModeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFuncMapModeEN._CurrTabName);
List<clsFuncMapModeEN> arrFuncMapModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncMapModeEN> arrFuncMapModeObjLst_Sel =
arrFuncMapModeObjLstCache
.Where(x=> x.FuncMapModeId == strFuncMapModeId 
);
if (arrFuncMapModeObjLst_Sel.Count() == 0)
{
   clsFuncMapModeEN obj = clsFuncMapModeBL.GetObjByFuncMapModeId(strFuncMapModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFuncMapModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncMapModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncMapModeNameByFuncMapModeIdCache(string strFuncMapModeId)
{
if (string.IsNullOrEmpty(strFuncMapModeId) == true) return "";
//获取缓存中的对象列表
clsFuncMapModeEN objFuncMapMode = GetObjByFuncMapModeIdCache(strFuncMapModeId);
if (objFuncMapMode == null) return "";
return objFuncMapMode.FuncMapModeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncMapModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncMapModeIdCache(string strFuncMapModeId)
{
if (string.IsNullOrEmpty(strFuncMapModeId) == true) return "";
//获取缓存中的对象列表
clsFuncMapModeEN objFuncMapMode = GetObjByFuncMapModeIdCache(strFuncMapModeId);
if (objFuncMapMode == null) return "";
return objFuncMapMode.FuncMapModeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncMapModeEN> GetAllFuncMapModeObjLstCache()
{
//获取缓存中的对象列表
List<clsFuncMapModeEN> arrFuncMapModeObjLstCache = GetObjLstCache(); 
return arrFuncMapModeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncMapModeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFuncMapModeEN._CurrTabName);
List<clsFuncMapModeEN> arrFuncMapModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFuncMapModeObjLstCache;
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
string strKey = string.Format("{0}", clsFuncMapModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncMapModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFuncMapModeEN._RefreshTimeLst.Count == 0) return "";
return clsFuncMapModeEN._RefreshTimeLst[clsFuncMapModeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFuncMapModeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncMapModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncMapModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFuncMapModeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FuncMapMode(函数映射模式)
 /// 唯一性条件:FuncMapModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncMapModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFuncMapModeEN objFuncMapModeEN)
{
//检测记录是否存在
string strResult = FuncMapModeDA.GetUniCondStr(objFuncMapModeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncMapModeId)
{
if (strInFldName != conFuncMapMode.FuncMapModeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncMapMode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncMapMode._AttributeName));
throw new Exception(strMsg);
}
var objFuncMapMode = clsFuncMapModeBL.GetObjByFuncMapModeIdCache(strFuncMapModeId);
if (objFuncMapMode == null) return "";
return objFuncMapMode[strOutFldName].ToString();
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
int intRecCount = clsFuncMapModeDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncMapModeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncMapModeDA.GetRecCount();
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
int intRecCount = clsFuncMapModeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncMapModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncMapModeEN objFuncMapModeCond)
{
List<clsFuncMapModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFuncMapModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncMapMode._AttributeName)
{
if (objFuncMapModeCond.IsUpdated(strFldName) == false) continue;
if (objFuncMapModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncMapModeCond[strFldName].ToString());
}
else
{
if (objFuncMapModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncMapModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncMapModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncMapModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncMapModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncMapModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncMapModeCond[strFldName]));
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
 List<string> arrList = clsFuncMapModeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncMapModeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncMapModeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncMapModeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncMapModeDA.SetFldValue(clsFuncMapModeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncMapModeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncMapModeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncMapModeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncMapModeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncMapMode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数映射模式Id*/ 
 strCreateTabCode.Append(" FuncMapModeId char(2) primary key, "); 
 // /**函数映射模式名*/ 
 strCreateTabCode.Append(" FuncMapModeName varchar(50) Null, "); 
 // /**函数映射模式英文名*/ 
 strCreateTabCode.Append(" FuncMapModeENName varchar(50) Null, "); 
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
}
 /// <summary>
 /// 函数映射模式(FuncMapMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FuncMapMode : clsCommFun4BL
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
clsFuncMapModeBL.ReFreshThisCache();
}
}

}