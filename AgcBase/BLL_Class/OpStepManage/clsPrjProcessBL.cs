
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjProcessBL
 表名:PrjProcess(00050027)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:操作步骤管理(OpStepManage)
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
public static class  clsPrjProcessBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjProcessEN GetObj(this K_PrjProcessId_PrjProcess myKey)
{
clsPrjProcessEN objPrjProcessEN = clsPrjProcessBL.PrjProcessDA.GetObjByPrjProcessId(myKey.Value);
return objPrjProcessEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!项目过程名称 = [{0}]的数据已经存在!(in clsPrjProcessBL.AddNewRecord)", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjProcessBL.PrjProcessDA.AddNewRecordBySQL2(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjProcessEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjProcessEN.CheckUniqueness() == false)
{
strMsg = string.Format("(项目过程名称(PrjProcessName)=[{0}])已经存在,不能重复!", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjProcessEN.AddNewRecord();
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!项目过程名称 = [{0}]的数据已经存在!(in clsPrjProcessBL.AddNewRecordWithMaxId)", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
string strPrjProcessId = clsPrjProcessBL.PrjProcessDA.AddNewRecordBySQL2WithReturnKey(objPrjProcessEN);
     objPrjProcessEN.PrjProcessId = strPrjProcessId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
}
return strPrjProcessId;
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!项目过程名称 = [{0}]的数据已经存在!(in clsPrjProcessBL.AddNewRecordWithReturnKey)", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
string strKey = clsPrjProcessBL.PrjProcessDA.AddNewRecordBySQL2WithReturnKey(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjProcessEN SetPrjProcessId(this clsPrjProcessEN objPrjProcessEN, string strPrjProcessId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjProcessId, 4, conPrjProcess.PrjProcessId);
}
objPrjProcessEN.PrjProcessId = strPrjProcessId; //项目过程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjProcessEN.dicFldComparisonOp.ContainsKey(conPrjProcess.PrjProcessId) == false)
{
objPrjProcessEN.dicFldComparisonOp.Add(conPrjProcess.PrjProcessId, strComparisonOp);
}
else
{
objPrjProcessEN.dicFldComparisonOp[conPrjProcess.PrjProcessId] = strComparisonOp;
}
}
return objPrjProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjProcessEN SetPrjProcessName(this clsPrjProcessEN objPrjProcessEN, string strPrjProcessName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjProcessName, conPrjProcess.PrjProcessName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjProcessName, 30, conPrjProcess.PrjProcessName);
}
objPrjProcessEN.PrjProcessName = strPrjProcessName; //项目过程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjProcessEN.dicFldComparisonOp.ContainsKey(conPrjProcess.PrjProcessName) == false)
{
objPrjProcessEN.dicFldComparisonOp.Add(conPrjProcess.PrjProcessName, strComparisonOp);
}
else
{
objPrjProcessEN.dicFldComparisonOp[conPrjProcess.PrjProcessName] = strComparisonOp;
}
}
return objPrjProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjProcessEN SetPrjProcessTypeId(this clsPrjProcessEN objPrjProcessEN, string strPrjProcessTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjProcessTypeId, conPrjProcess.PrjProcessTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjProcessTypeId, 2, conPrjProcess.PrjProcessTypeId);
}
objPrjProcessEN.PrjProcessTypeId = strPrjProcessTypeId; //项目过程分类ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjProcessEN.dicFldComparisonOp.ContainsKey(conPrjProcess.PrjProcessTypeId) == false)
{
objPrjProcessEN.dicFldComparisonOp.Add(conPrjProcess.PrjProcessTypeId, strComparisonOp);
}
else
{
objPrjProcessEN.dicFldComparisonOp[conPrjProcess.PrjProcessTypeId] = strComparisonOp;
}
}
return objPrjProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjProcessEN SetMemo(this clsPrjProcessEN objPrjProcessEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjProcess.Memo);
}
objPrjProcessEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjProcessEN.dicFldComparisonOp.ContainsKey(conPrjProcess.Memo) == false)
{
objPrjProcessEN.dicFldComparisonOp.Add(conPrjProcess.Memo, strComparisonOp);
}
else
{
objPrjProcessEN.dicFldComparisonOp[conPrjProcess.Memo] = strComparisonOp;
}
}
return objPrjProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjProcessEN SetIsViewRela(this clsPrjProcessEN objPrjProcessEN, bool bolIsViewRela, string strComparisonOp="")
	{
objPrjProcessEN.IsViewRela = bolIsViewRela; //是否界面相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjProcessEN.dicFldComparisonOp.ContainsKey(conPrjProcess.IsViewRela) == false)
{
objPrjProcessEN.dicFldComparisonOp.Add(conPrjProcess.IsViewRela, strComparisonOp);
}
else
{
objPrjProcessEN.dicFldComparisonOp[conPrjProcess.IsViewRela] = strComparisonOp;
}
}
return objPrjProcessEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjProcessEN objPrjProcessEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjProcessEN.CheckPropertyNew();
clsPrjProcessEN objPrjProcessCond = new clsPrjProcessEN();
string strCondition = objPrjProcessCond
.SetPrjProcessId(objPrjProcessEN.PrjProcessId, "<>")
.SetPrjProcessName(objPrjProcessEN.PrjProcessName, "=")
.GetCombineCondition();
objPrjProcessEN._IsCheckProperty = true;
bool bolIsExist = clsPrjProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjProcessName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjProcessEN.Update();
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
 /// <param name = "objPrjProcess">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjProcessEN objPrjProcess)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjProcessEN objPrjProcessCond = new clsPrjProcessEN();
string strCondition = objPrjProcessCond
.SetPrjProcessName(objPrjProcess.PrjProcessName, "=")
.GetCombineCondition();
objPrjProcess._IsCheckProperty = true;
bool bolIsExist = clsPrjProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjProcess.PrjProcessId = clsPrjProcessBL.GetFirstID_S(strCondition);
objPrjProcess.UpdateWithCondition(strCondition);
}
else
{
objPrjProcess.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
objPrjProcess.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjProcessEN objPrjProcessEN)
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjProcessBL.PrjProcessDA.UpdateBySql2(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjProcessEN objPrjProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjProcessBL.PrjProcessDA.UpdateBySql2(objPrjProcessEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjProcessEN objPrjProcessEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjProcessBL.PrjProcessDA.UpdateBySqlWithCondition(objPrjProcessEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjProcessEN objPrjProcessEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjProcessBL.PrjProcessDA.UpdateBySqlWithConditionTransaction(objPrjProcessEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "strPrjProcessId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjProcessEN objPrjProcessEN)
{
try
{
int intRecNum = clsPrjProcessBL.PrjProcessDA.DelRecord(objPrjProcessEN.PrjProcessId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessENS">源对象</param>
 /// <param name = "objPrjProcessENT">目标对象</param>
 public static void CopyTo(this clsPrjProcessEN objPrjProcessENS, clsPrjProcessEN objPrjProcessENT)
{
try
{
objPrjProcessENT.PrjProcessId = objPrjProcessENS.PrjProcessId; //项目过程ID
objPrjProcessENT.PrjProcessName = objPrjProcessENS.PrjProcessName; //项目过程名称
objPrjProcessENT.PrjProcessTypeId = objPrjProcessENS.PrjProcessTypeId; //项目过程分类ID
objPrjProcessENT.Memo = objPrjProcessENS.Memo; //说明
objPrjProcessENT.IsViewRela = objPrjProcessENS.IsViewRela; //是否界面相关
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
 /// <param name = "objPrjProcessENS">源对象</param>
 /// <returns>目标对象=>clsPrjProcessEN:objPrjProcessENT</returns>
 public static clsPrjProcessEN CopyTo(this clsPrjProcessEN objPrjProcessENS)
{
try
{
 clsPrjProcessEN objPrjProcessENT = new clsPrjProcessEN()
{
PrjProcessId = objPrjProcessENS.PrjProcessId, //项目过程ID
PrjProcessName = objPrjProcessENS.PrjProcessName, //项目过程名称
PrjProcessTypeId = objPrjProcessENS.PrjProcessTypeId, //项目过程分类ID
Memo = objPrjProcessENS.Memo, //说明
IsViewRela = objPrjProcessENS.IsViewRela, //是否界面相关
};
 return objPrjProcessENT;
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
public static void CheckPropertyNew(this clsPrjProcessEN objPrjProcessEN)
{
 clsPrjProcessBL.PrjProcessDA.CheckPropertyNew(objPrjProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjProcessEN objPrjProcessEN)
{
 clsPrjProcessBL.PrjProcessDA.CheckProperty4Condition(objPrjProcessEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjProcessEN objPrjProcessCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjProcessCond.IsUpdated(conPrjProcess.PrjProcessId) == true)
{
string strComparisonOpPrjProcessId = objPrjProcessCond.dicFldComparisonOp[conPrjProcess.PrjProcessId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjProcess.PrjProcessId, objPrjProcessCond.PrjProcessId, strComparisonOpPrjProcessId);
}
if (objPrjProcessCond.IsUpdated(conPrjProcess.PrjProcessName) == true)
{
string strComparisonOpPrjProcessName = objPrjProcessCond.dicFldComparisonOp[conPrjProcess.PrjProcessName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjProcess.PrjProcessName, objPrjProcessCond.PrjProcessName, strComparisonOpPrjProcessName);
}
if (objPrjProcessCond.IsUpdated(conPrjProcess.PrjProcessTypeId) == true)
{
string strComparisonOpPrjProcessTypeId = objPrjProcessCond.dicFldComparisonOp[conPrjProcess.PrjProcessTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjProcess.PrjProcessTypeId, objPrjProcessCond.PrjProcessTypeId, strComparisonOpPrjProcessTypeId);
}
if (objPrjProcessCond.IsUpdated(conPrjProcess.Memo) == true)
{
string strComparisonOpMemo = objPrjProcessCond.dicFldComparisonOp[conPrjProcess.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjProcess.Memo, objPrjProcessCond.Memo, strComparisonOpMemo);
}
if (objPrjProcessCond.IsUpdated(conPrjProcess.IsViewRela) == true)
{
if (objPrjProcessCond.IsViewRela == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjProcess.IsViewRela);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjProcess.IsViewRela);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjProcess(项目过程步骤), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjProcessName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjProcessEN objPrjProcessEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjProcessEN == null) return true;
if (objPrjProcessEN.PrjProcessId == null || objPrjProcessEN.PrjProcessId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjProcessName = '{0}'", objPrjProcessEN.PrjProcessName);
if (clsPrjProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjProcessId !=  '{0}'", objPrjProcessEN.PrjProcessId);
 sbCondition.AppendFormat(" and PrjProcessName = '{0}'", objPrjProcessEN.PrjProcessName);
if (clsPrjProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjProcess(项目过程步骤), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjProcessName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjProcessEN objPrjProcessEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjProcessEN == null) return "";
if (objPrjProcessEN.PrjProcessId == null || objPrjProcessEN.PrjProcessId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjProcessName = '{0}'", objPrjProcessEN.PrjProcessName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjProcessId !=  '{0}'", objPrjProcessEN.PrjProcessId);
 sbCondition.AppendFormat(" and PrjProcessName = '{0}'", objPrjProcessEN.PrjProcessName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjProcess
{
public virtual bool UpdRelaTabDate(string strPrjProcessId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 项目过程步骤(PrjProcess)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjProcessBL
{
public static RelatedActions_PrjProcess relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjProcessDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjProcessDA PrjProcessDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjProcessDA();
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
 public clsPrjProcessBL()
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
if (string.IsNullOrEmpty(clsPrjProcessEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjProcessEN._ConnectString);
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
public static DataTable GetDataTable_PrjProcess(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjProcessDA.GetDataTable_PrjProcess(strWhereCond);
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
objDT = PrjProcessDA.GetDataTable(strWhereCond);
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
objDT = PrjProcessDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjProcessDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjProcessDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjProcessDA.GetDataTable_Top(objTopPara);
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
objDT = PrjProcessDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjProcessEN> GetObjLstByPrjProcessIdLst(List<string> arrPrjProcessIdLst)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjProcessIdLst, true);
 string strWhereCond = string.Format("PrjProcessId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjProcessEN> GetObjLstByPrjProcessIdLstCache(List<string> arrPrjProcessIdLst)
{
string strKey = string.Format("{0}", clsPrjProcessEN._CurrTabName);
List<clsPrjProcessEN> arrPrjProcessObjLstCache = GetObjLstCache();
IEnumerable <clsPrjProcessEN> arrPrjProcessObjLst_Sel =
arrPrjProcessObjLstCache
.Where(x => arrPrjProcessIdLst.Contains(x.PrjProcessId));
return arrPrjProcessObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjProcessEN> GetObjLst(string strWhereCond)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
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
public static List<clsPrjProcessEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjProcessEN> GetSubObjLstCache(clsPrjProcessEN objPrjProcessCond)
{
List<clsPrjProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjProcess._AttributeName)
{
if (objPrjProcessCond.IsUpdated(strFldName) == false) continue;
if (objPrjProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjProcessCond[strFldName].ToString());
}
else
{
if (objPrjProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjProcessCond[strFldName]));
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
public static List<clsPrjProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
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
public static List<clsPrjProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
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
List<clsPrjProcessEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjProcessEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjProcessEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
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
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
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
public static List<clsPrjProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjProcessEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
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
public static List<clsPrjProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjProcessEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjProcessEN> arrObjLst = new List<clsPrjProcessEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjProcessEN objPrjProcessEN = new clsPrjProcessEN();
try
{
objPrjProcessEN.PrjProcessId = objRow[conPrjProcess.PrjProcessId].ToString().Trim(); //项目过程ID
objPrjProcessEN.PrjProcessName = objRow[conPrjProcess.PrjProcessName].ToString().Trim(); //项目过程名称
objPrjProcessEN.PrjProcessTypeId = objRow[conPrjProcess.PrjProcessTypeId].ToString().Trim(); //项目过程分类ID
objPrjProcessEN.Memo = objRow[conPrjProcess.Memo] == DBNull.Value ? null : objRow[conPrjProcess.Memo].ToString().Trim(); //说明
objPrjProcessEN.IsViewRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjProcess.IsViewRela].ToString().Trim()); //是否界面相关
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjProcessEN.PrjProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjProcessEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjProcessEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjProcess(ref clsPrjProcessEN objPrjProcessEN)
{
bool bolResult = PrjProcessDA.GetPrjProcess(ref objPrjProcessEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjProcessEN GetObjByPrjProcessId(string strPrjProcessId)
{
if (strPrjProcessId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjProcessId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjProcessId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjProcessEN objPrjProcessEN = PrjProcessDA.GetObjByPrjProcessId(strPrjProcessId);
return objPrjProcessEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjProcessEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjProcessEN objPrjProcessEN = PrjProcessDA.GetFirstObj(strWhereCond);
 return objPrjProcessEN;
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
public static clsPrjProcessEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjProcessEN objPrjProcessEN = PrjProcessDA.GetObjByDataRow(objRow);
 return objPrjProcessEN;
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
public static clsPrjProcessEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjProcessEN objPrjProcessEN = PrjProcessDA.GetObjByDataRow(objRow);
 return objPrjProcessEN;
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
 /// <param name = "strPrjProcessId">所给的关键字</param>
 /// <param name = "lstPrjProcessObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjProcessEN GetObjByPrjProcessIdFromList(string strPrjProcessId, List<clsPrjProcessEN> lstPrjProcessObjLst)
{
foreach (clsPrjProcessEN objPrjProcessEN in lstPrjProcessObjLst)
{
if (objPrjProcessEN.PrjProcessId == strPrjProcessId)
{
return objPrjProcessEN;
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
 string strMaxPrjProcessId;
 try
 {
 strMaxPrjProcessId = clsPrjProcessDA.GetMaxStrId();
 return strMaxPrjProcessId;
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
 string strPrjProcessId;
 try
 {
 strPrjProcessId = new clsPrjProcessDA().GetFirstID(strWhereCond);
 return strPrjProcessId;
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
 arrList = PrjProcessDA.GetID(strWhereCond);
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
bool bolIsExist = PrjProcessDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjProcessId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjProcessId)
{
if (string.IsNullOrEmpty(strPrjProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjProcessId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjProcessDA.IsExist(strPrjProcessId);
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
 bolIsExist = clsPrjProcessDA.IsExistTable();
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
 bolIsExist = PrjProcessDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjProcessEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目过程名称 = [{0}]的数据已经存在!(in clsPrjProcessBL.AddNewRecordBySql2)", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
bool bolResult = PrjProcessDA.AddNewRecordBySQL2(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjProcessEN objPrjProcessEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjProcessEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!项目过程名称 = [{0}]的数据已经存在!(in clsPrjProcessBL.AddNewRecordBySql2WithReturnKey)", objPrjProcessEN.PrjProcessName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true || clsPrjProcessBL.IsExist(objPrjProcessEN.PrjProcessId) == true)
 {
     objPrjProcessEN.PrjProcessId = clsPrjProcessBL.GetMaxStrId_S();
 }
string strKey = PrjProcessDA.AddNewRecordBySQL2WithReturnKey(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjProcessEN objPrjProcessEN)
{
try
{
bool bolResult = PrjProcessDA.Update(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "objPrjProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjProcessEN objPrjProcessEN)
{
 if (string.IsNullOrEmpty(objPrjProcessEN.PrjProcessId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjProcessDA.UpdateBySql2(objPrjProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjProcessBL.ReFreshCache();

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
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
 /// <param name = "strPrjProcessId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjProcessId)
{
try
{
 clsPrjProcessEN objPrjProcessEN = clsPrjProcessBL.GetObjByPrjProcessId(strPrjProcessId);

if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(objPrjProcessEN.PrjProcessId, "SetUpdDate");
}
if (objPrjProcessEN != null)
{
int intRecNum = PrjProcessDA.DelRecord(strPrjProcessId);
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
/// <param name="strPrjProcessId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjProcessId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjProcessDA.GetSpecSQLObj();
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
//删除与表:[PrjProcess]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjProcess.PrjProcessId,
//strPrjProcessId);
//        clsPrjProcessBL.DelPrjProcesssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjProcessBL.DelRecord(strPrjProcessId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjProcessBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjProcessId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjProcessId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjProcessId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjProcessBL.relatedActions != null)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(strPrjProcessId, "UpdRelaTabDate");
}
bool bolResult = PrjProcessDA.DelRecord(strPrjProcessId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjProcessIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjProcesss(List<string> arrPrjProcessIdLst)
{
if (arrPrjProcessIdLst.Count == 0) return 0;
try
{
if (clsPrjProcessBL.relatedActions != null)
{
foreach (var strPrjProcessId in arrPrjProcessIdLst)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(strPrjProcessId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjProcessDA.DelPrjProcess(arrPrjProcessIdLst);
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
public static int DelPrjProcesssByCond(string strWhereCond)
{
try
{
if (clsPrjProcessBL.relatedActions != null)
{
List<string> arrPrjProcessId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjProcessId in arrPrjProcessId)
{
clsPrjProcessBL.relatedActions.UpdRelaTabDate(strPrjProcessId, "UpdRelaTabDate");
}
}
int intRecNum = PrjProcessDA.DelPrjProcess(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjProcess]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjProcessId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjProcessId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjProcessDA.GetSpecSQLObj();
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
//删除与表:[PrjProcess]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjProcessBL.DelRecord(strPrjProcessId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjProcessBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjProcessId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjProcessENS">源对象</param>
 /// <param name = "objPrjProcessENT">目标对象</param>
 public static void CopyTo(clsPrjProcessEN objPrjProcessENS, clsPrjProcessEN objPrjProcessENT)
{
try
{
objPrjProcessENT.PrjProcessId = objPrjProcessENS.PrjProcessId; //项目过程ID
objPrjProcessENT.PrjProcessName = objPrjProcessENS.PrjProcessName; //项目过程名称
objPrjProcessENT.PrjProcessTypeId = objPrjProcessENS.PrjProcessTypeId; //项目过程分类ID
objPrjProcessENT.Memo = objPrjProcessENS.Memo; //说明
objPrjProcessENT.IsViewRela = objPrjProcessENS.IsViewRela; //是否界面相关
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
 /// <param name = "objPrjProcessEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjProcessEN objPrjProcessEN)
{
try
{
objPrjProcessEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjProcessEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjProcess.PrjProcessId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjProcessEN.PrjProcessId = objPrjProcessEN.PrjProcessId; //项目过程ID
}
if (arrFldSet.Contains(conPrjProcess.PrjProcessName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjProcessEN.PrjProcessName = objPrjProcessEN.PrjProcessName; //项目过程名称
}
if (arrFldSet.Contains(conPrjProcess.PrjProcessTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjProcessEN.PrjProcessTypeId = objPrjProcessEN.PrjProcessTypeId; //项目过程分类ID
}
if (arrFldSet.Contains(conPrjProcess.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjProcessEN.Memo = objPrjProcessEN.Memo == "[null]" ? null :  objPrjProcessEN.Memo; //说明
}
if (arrFldSet.Contains(conPrjProcess.IsViewRela, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjProcessEN.IsViewRela = objPrjProcessEN.IsViewRela; //是否界面相关
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
 /// <param name = "objPrjProcessEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjProcessEN objPrjProcessEN)
{
try
{
if (objPrjProcessEN.Memo == "[null]") objPrjProcessEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjProcessEN objPrjProcessEN)
{
 PrjProcessDA.CheckPropertyNew(objPrjProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjProcessEN objPrjProcessEN)
{
 PrjProcessDA.CheckProperty4Condition(objPrjProcessEN);
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
if (clsPrjProcessBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjProcessBL没有刷新缓存机制(clsPrjProcessBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjProcessId");
//if (arrPrjProcessObjLstCache == null)
//{
//arrPrjProcessObjLstCache = PrjProcessDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjProcessEN GetObjByPrjProcessIdCache(string strPrjProcessId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjProcessEN._CurrTabName);
List<clsPrjProcessEN> arrPrjProcessObjLstCache = GetObjLstCache();
IEnumerable <clsPrjProcessEN> arrPrjProcessObjLst_Sel =
arrPrjProcessObjLstCache
.Where(x=> x.PrjProcessId == strPrjProcessId 
);
if (arrPrjProcessObjLst_Sel.Count() == 0)
{
   clsPrjProcessEN obj = clsPrjProcessBL.GetObjByPrjProcessId(strPrjProcessId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjProcessObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjProcessEN> GetAllPrjProcessObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjProcessEN> arrPrjProcessObjLstCache = GetObjLstCache(); 
return arrPrjProcessObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjProcessEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjProcessEN._CurrTabName);
List<clsPrjProcessEN> arrPrjProcessObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjProcessObjLstCache;
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
string strKey = string.Format("{0}", clsPrjProcessEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjProcessEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjProcessEN._RefreshTimeLst.Count == 0) return "";
return clsPrjProcessEN._RefreshTimeLst[clsPrjProcessEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPrjProcessBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjProcessEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjProcessEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjProcessBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjProcess(项目过程步骤)
 /// 唯一性条件:PrjProcessName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjProcessEN objPrjProcessEN)
{
//检测记录是否存在
string strResult = PrjProcessDA.GetUniCondStr(objPrjProcessEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjProcessId)
{
if (strInFldName != conPrjProcess.PrjProcessId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjProcess._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjProcess._AttributeName));
throw new Exception(strMsg);
}
var objPrjProcess = clsPrjProcessBL.GetObjByPrjProcessIdCache(strPrjProcessId);
if (objPrjProcess == null) return "";
return objPrjProcess[strOutFldName].ToString();
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
int intRecCount = clsPrjProcessDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjProcessDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjProcessDA.GetRecCount();
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
int intRecCount = clsPrjProcessDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjProcessEN objPrjProcessCond)
{
List<clsPrjProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjProcess._AttributeName)
{
if (objPrjProcessCond.IsUpdated(strFldName) == false) continue;
if (objPrjProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjProcessCond[strFldName].ToString());
}
else
{
if (objPrjProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjProcessCond[strFldName]));
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
 List<string> arrList = clsPrjProcessDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjProcessDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjProcessDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjProcessDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjProcessDA.SetFldValue(clsPrjProcessEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjProcessDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjProcessDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjProcessDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjProcessDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjProcess] "); 
 strCreateTabCode.Append(" ( "); 
 // /**项目过程ID*/ 
 strCreateTabCode.Append(" PrjProcessId varchar(4) primary key, "); 
 // /**项目过程名称*/ 
 strCreateTabCode.Append(" PrjProcessName varchar(30) not Null, "); 
 // /**项目过程分类ID*/ 
 strCreateTabCode.Append(" PrjProcessTypeId varchar(2) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否界面相关*/ 
 strCreateTabCode.Append(" IsViewRela bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 项目过程步骤(PrjProcess)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjProcess : clsCommFun4BL
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
clsPrjProcessBL.ReFreshThisCache();
}
}

}