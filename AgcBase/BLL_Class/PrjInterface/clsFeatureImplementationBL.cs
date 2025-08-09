
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureImplementationBL
 表名:FeatureImplementation(00050393)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsFeatureImplementationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureImplementationEN GetObj(this K_mId_FeatureImplementation myKey)
{
clsFeatureImplementationEN objFeatureImplementationEN = clsFeatureImplementationBL.FeatureImplementationDA.GetObjBymId(myKey.Value);
return objFeatureImplementationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureImplementationEN) == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],界面实现Id = [{1}]的数据已经存在!(in clsFeatureImplementationBL.AddNewRecord)", objFeatureImplementationEN.FeatureId,objFeatureImplementationEN.ViewImplId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFeatureImplementationBL.FeatureImplementationDA.AddNewRecordBySQL2(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
public static bool AddRecordEx(this clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsNeedCheckUniqueness = true)
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
objFeatureImplementationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFeatureImplementationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能Id(FeatureId)=[{0}],界面实现Id(ViewImplId)=[{1}])已经存在,不能重复!", objFeatureImplementationEN.FeatureId, objFeatureImplementationEN.ViewImplId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFeatureImplementationEN.AddNewRecord();
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureImplementationEN) == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],界面实现Id = [{1}]的数据已经存在!(in clsFeatureImplementationBL.AddNewRecordWithReturnKey)", objFeatureImplementationEN.FeatureId,objFeatureImplementationEN.ViewImplId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFeatureImplementationBL.FeatureImplementationDA.AddNewRecordBySQL2WithReturnKey(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetmId(this clsFeatureImplementationEN objFeatureImplementationEN, long lngmId, string strComparisonOp="")
	{
objFeatureImplementationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.mId) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.mId, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.mId] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetFeatureId(this clsFeatureImplementationEN objFeatureImplementationEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFeatureImplementation.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFeatureImplementation.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFeatureImplementation.FeatureId);
}
objFeatureImplementationEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.FeatureId) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.FeatureId, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.FeatureId] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetViewImplId(this clsFeatureImplementationEN objFeatureImplementationEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, conFeatureImplementation.ViewImplId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, conFeatureImplementation.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, conFeatureImplementation.ViewImplId);
}
objFeatureImplementationEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.ViewImplId) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.ViewImplId, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.ViewImplId] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetIsDefault(this clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsDefault, string strComparisonOp="")
	{
objFeatureImplementationEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.IsDefault) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.IsDefault, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.IsDefault] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetUpdDate(this clsFeatureImplementationEN objFeatureImplementationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFeatureImplementation.UpdDate);
}
objFeatureImplementationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.UpdDate) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.UpdDate, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.UpdDate] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetUpdUser(this clsFeatureImplementationEN objFeatureImplementationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFeatureImplementation.UpdUser);
}
objFeatureImplementationEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.UpdUser) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.UpdUser, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.UpdUser] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureImplementationEN SetMemo(this clsFeatureImplementationEN objFeatureImplementationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFeatureImplementation.Memo);
}
objFeatureImplementationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureImplementationEN.dicFldComparisonOp.ContainsKey(conFeatureImplementation.Memo) == false)
{
objFeatureImplementationEN.dicFldComparisonOp.Add(conFeatureImplementation.Memo, strComparisonOp);
}
else
{
objFeatureImplementationEN.dicFldComparisonOp[conFeatureImplementation.Memo] = strComparisonOp;
}
}
return objFeatureImplementationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFeatureImplementationEN objFeatureImplementationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFeatureImplementationEN.CheckPropertyNew();
clsFeatureImplementationEN objFeatureImplementationCond = new clsFeatureImplementationEN();
string strCondition = objFeatureImplementationCond
.SetmId(objFeatureImplementationEN.mId, "<>")
.SetFeatureId(objFeatureImplementationEN.FeatureId, "=")
.SetViewImplId(objFeatureImplementationEN.ViewImplId, "=")
.GetCombineCondition();
objFeatureImplementationEN._IsCheckProperty = true;
bool bolIsExist = clsFeatureImplementationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FeatureId_ViewImplId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFeatureImplementationEN.Update();
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
 /// <param name = "objFeatureImplementation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFeatureImplementationEN objFeatureImplementation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFeatureImplementationEN objFeatureImplementationCond = new clsFeatureImplementationEN();
string strCondition = objFeatureImplementationCond
.SetFeatureId(objFeatureImplementation.FeatureId, "=")
.SetViewImplId(objFeatureImplementation.ViewImplId, "=")
.GetCombineCondition();
objFeatureImplementation._IsCheckProperty = true;
bool bolIsExist = clsFeatureImplementationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFeatureImplementation.mId = clsFeatureImplementationBL.GetFirstID_S(strCondition);
objFeatureImplementation.UpdateWithCondition(strCondition);
}
else
{
objFeatureImplementation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureImplementationEN objFeatureImplementationEN)
{
 if (objFeatureImplementationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureImplementationBL.FeatureImplementationDA.UpdateBySql2(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureImplementationEN objFeatureImplementationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFeatureImplementationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureImplementationBL.FeatureImplementationDA.UpdateBySql2(objFeatureImplementationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureImplementationEN objFeatureImplementationEN, string strWhereCond)
{
try
{
bool bolResult = clsFeatureImplementationBL.FeatureImplementationDA.UpdateBySqlWithCondition(objFeatureImplementationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureImplementationEN objFeatureImplementationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFeatureImplementationBL.FeatureImplementationDA.UpdateBySqlWithConditionTransaction(objFeatureImplementationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
public static int Delete(this clsFeatureImplementationEN objFeatureImplementationEN)
{
try
{
int intRecNum = clsFeatureImplementationBL.FeatureImplementationDA.DelRecord(objFeatureImplementationEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationENS">源对象</param>
 /// <param name = "objFeatureImplementationENT">目标对象</param>
 public static void CopyTo(this clsFeatureImplementationEN objFeatureImplementationENS, clsFeatureImplementationEN objFeatureImplementationENT)
{
try
{
objFeatureImplementationENT.mId = objFeatureImplementationENS.mId; //mId
objFeatureImplementationENT.FeatureId = objFeatureImplementationENS.FeatureId; //功能Id
objFeatureImplementationENT.ViewImplId = objFeatureImplementationENS.ViewImplId; //界面实现Id
objFeatureImplementationENT.IsDefault = objFeatureImplementationENS.IsDefault; //是否默认
objFeatureImplementationENT.UpdDate = objFeatureImplementationENS.UpdDate; //修改日期
objFeatureImplementationENT.UpdUser = objFeatureImplementationENS.UpdUser; //修改者
objFeatureImplementationENT.Memo = objFeatureImplementationENS.Memo; //说明
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
 /// <param name = "objFeatureImplementationENS">源对象</param>
 /// <returns>目标对象=>clsFeatureImplementationEN:objFeatureImplementationENT</returns>
 public static clsFeatureImplementationEN CopyTo(this clsFeatureImplementationEN objFeatureImplementationENS)
{
try
{
 clsFeatureImplementationEN objFeatureImplementationENT = new clsFeatureImplementationEN()
{
mId = objFeatureImplementationENS.mId, //mId
FeatureId = objFeatureImplementationENS.FeatureId, //功能Id
ViewImplId = objFeatureImplementationENS.ViewImplId, //界面实现Id
IsDefault = objFeatureImplementationENS.IsDefault, //是否默认
UpdDate = objFeatureImplementationENS.UpdDate, //修改日期
UpdUser = objFeatureImplementationENS.UpdUser, //修改者
Memo = objFeatureImplementationENS.Memo, //说明
};
 return objFeatureImplementationENT;
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
public static void CheckPropertyNew(this clsFeatureImplementationEN objFeatureImplementationEN)
{
 clsFeatureImplementationBL.FeatureImplementationDA.CheckPropertyNew(objFeatureImplementationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFeatureImplementationEN objFeatureImplementationEN)
{
 clsFeatureImplementationBL.FeatureImplementationDA.CheckProperty4Condition(objFeatureImplementationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFeatureImplementationEN objFeatureImplementationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.mId) == true)
{
string strComparisonOpmId = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureImplementation.mId, objFeatureImplementationCond.mId, strComparisonOpmId);
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.FeatureId) == true)
{
string strComparisonOpFeatureId = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureImplementation.FeatureId, objFeatureImplementationCond.FeatureId, strComparisonOpFeatureId);
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.ViewImplId) == true)
{
string strComparisonOpViewImplId = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureImplementation.ViewImplId, objFeatureImplementationCond.ViewImplId, strComparisonOpViewImplId);
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.IsDefault) == true)
{
if (objFeatureImplementationCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFeatureImplementation.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFeatureImplementation.IsDefault);
}
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.UpdDate) == true)
{
string strComparisonOpUpdDate = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureImplementation.UpdDate, objFeatureImplementationCond.UpdDate, strComparisonOpUpdDate);
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.UpdUser) == true)
{
string strComparisonOpUpdUser = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureImplementation.UpdUser, objFeatureImplementationCond.UpdUser, strComparisonOpUpdUser);
}
if (objFeatureImplementationCond.IsUpdated(conFeatureImplementation.Memo) == true)
{
string strComparisonOpMemo = objFeatureImplementationCond.dicFldComparisonOp[conFeatureImplementation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureImplementation.Memo, objFeatureImplementationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FeatureImplementation(功能实现方式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FeatureId_ViewImplId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFeatureImplementationEN objFeatureImplementationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFeatureImplementationEN == null) return true;
if (objFeatureImplementationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureImplementationEN.FeatureId);
 sbCondition.AppendFormat(" and ViewImplId = '{0}'", objFeatureImplementationEN.ViewImplId);
if (clsFeatureImplementationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFeatureImplementationEN.mId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureImplementationEN.FeatureId);
 sbCondition.AppendFormat(" and ViewImplId = '{0}'", objFeatureImplementationEN.ViewImplId);
if (clsFeatureImplementationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FeatureImplementation(功能实现方式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureId_ViewImplId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFeatureImplementationEN objFeatureImplementationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFeatureImplementationEN == null) return "";
if (objFeatureImplementationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureImplementationEN.FeatureId);
 sbCondition.AppendFormat(" and ViewImplId = '{0}'", objFeatureImplementationEN.ViewImplId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFeatureImplementationEN.mId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureImplementationEN.FeatureId);
 sbCondition.AppendFormat(" and ViewImplId = '{0}'", objFeatureImplementationEN.ViewImplId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FeatureImplementation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能实现方式(FeatureImplementation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFeatureImplementationBL
{
public static RelatedActions_FeatureImplementation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFeatureImplementationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFeatureImplementationDA FeatureImplementationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFeatureImplementationDA();
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
 public clsFeatureImplementationBL()
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
if (string.IsNullOrEmpty(clsFeatureImplementationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFeatureImplementationEN._ConnectString);
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
public static DataTable GetDataTable_FeatureImplementation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FeatureImplementationDA.GetDataTable_FeatureImplementation(strWhereCond);
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
objDT = FeatureImplementationDA.GetDataTable(strWhereCond);
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
objDT = FeatureImplementationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FeatureImplementationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FeatureImplementationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FeatureImplementationDA.GetDataTable_Top(objTopPara);
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
objDT = FeatureImplementationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FeatureImplementationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FeatureImplementationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFeatureImplementationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
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
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFeatureImplementationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
List<clsFeatureImplementationEN> arrFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureImplementationEN> arrFeatureImplementationObjLst_Sel =
arrFeatureImplementationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFeatureImplementationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureImplementationEN> GetObjLst(string strWhereCond)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
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
public static List<clsFeatureImplementationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFeatureImplementationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFeatureImplementationEN> GetSubObjLstCache(clsFeatureImplementationEN objFeatureImplementationCond)
{
List<clsFeatureImplementationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureImplementationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureImplementation._AttributeName)
{
if (objFeatureImplementationCond.IsUpdated(strFldName) == false) continue;
if (objFeatureImplementationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureImplementationCond[strFldName].ToString());
}
else
{
if (objFeatureImplementationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureImplementationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureImplementationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureImplementationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureImplementationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureImplementationCond[strFldName]));
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
public static List<clsFeatureImplementationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
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
public static List<clsFeatureImplementationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
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
List<clsFeatureImplementationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFeatureImplementationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureImplementationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFeatureImplementationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
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
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
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
public static List<clsFeatureImplementationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFeatureImplementationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFeatureImplementationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
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
public static List<clsFeatureImplementationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureImplementationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFeatureImplementationEN> arrObjLst = new List<clsFeatureImplementationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureImplementationEN objFeatureImplementationEN = new clsFeatureImplementationEN();
try
{
objFeatureImplementationEN.mId = Int32.Parse(objRow[conFeatureImplementation.mId].ToString().Trim()); //mId
objFeatureImplementationEN.FeatureId = objRow[conFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objFeatureImplementationEN.ViewImplId = objRow[conFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureImplementationEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conFeatureImplementation.IsDefault].ToString().Trim()); //是否默认
objFeatureImplementationEN.UpdDate = objRow[conFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objFeatureImplementationEN.UpdUser = objRow[conFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[conFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objFeatureImplementationEN.Memo = objRow[conFeatureImplementation.Memo] == DBNull.Value ? null : objRow[conFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureImplementationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFeatureImplementation(ref clsFeatureImplementationEN objFeatureImplementationEN)
{
bool bolResult = FeatureImplementationDA.GetFeatureImplementation(ref objFeatureImplementationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureImplementationEN GetObjBymId(long lngmId)
{
clsFeatureImplementationEN objFeatureImplementationEN = FeatureImplementationDA.GetObjBymId(lngmId);
return objFeatureImplementationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFeatureImplementationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFeatureImplementationEN objFeatureImplementationEN = FeatureImplementationDA.GetFirstObj(strWhereCond);
 return objFeatureImplementationEN;
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
public static clsFeatureImplementationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFeatureImplementationEN objFeatureImplementationEN = FeatureImplementationDA.GetObjByDataRow(objRow);
 return objFeatureImplementationEN;
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
public static clsFeatureImplementationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFeatureImplementationEN objFeatureImplementationEN = FeatureImplementationDA.GetObjByDataRow(objRow);
 return objFeatureImplementationEN;
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
 /// <param name = "lstFeatureImplementationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureImplementationEN GetObjBymIdFromList(long lngmId, List<clsFeatureImplementationEN> lstFeatureImplementationObjLst)
{
foreach (clsFeatureImplementationEN objFeatureImplementationEN in lstFeatureImplementationObjLst)
{
if (objFeatureImplementationEN.mId == lngmId)
{
return objFeatureImplementationEN;
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
 lngmId = new clsFeatureImplementationDA().GetFirstID(strWhereCond);
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
 arrList = FeatureImplementationDA.GetID(strWhereCond);
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
bool bolIsExist = FeatureImplementationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FeatureImplementationDA.IsExist(lngmId);
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
clsFeatureImplementationEN objFeatureImplementationEN = clsFeatureImplementationBL.GetObjBymId(lngmId);
objFeatureImplementationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFeatureImplementationEN.UpdUser = strOpUser;
return clsFeatureImplementationBL.UpdateBySql2(objFeatureImplementationEN);
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
 bolIsExist = clsFeatureImplementationDA.IsExistTable();
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
 bolIsExist = FeatureImplementationDA.IsExistTable(strTabName);
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureImplementationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],界面实现Id = [{1}]的数据已经存在!(in clsFeatureImplementationBL.AddNewRecordBySql2)", objFeatureImplementationEN.FeatureId,objFeatureImplementationEN.ViewImplId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FeatureImplementationDA.AddNewRecordBySQL2(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFeatureImplementationEN objFeatureImplementationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureImplementationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能Id = [{0}],界面实现Id = [{1}]的数据已经存在!(in clsFeatureImplementationBL.AddNewRecordBySql2WithReturnKey)", objFeatureImplementationEN.FeatureId,objFeatureImplementationEN.ViewImplId);
throw new Exception(strMsg);
}
try
{
string strKey = FeatureImplementationDA.AddNewRecordBySQL2WithReturnKey(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFeatureImplementationEN objFeatureImplementationEN)
{
try
{
bool bolResult = FeatureImplementationDA.Update(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 /// <param name = "objFeatureImplementationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFeatureImplementationEN objFeatureImplementationEN)
{
 if (objFeatureImplementationEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FeatureImplementationDA.UpdateBySql2(objFeatureImplementationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureImplementationBL.ReFreshCache();

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
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
 clsFeatureImplementationEN objFeatureImplementationEN = clsFeatureImplementationBL.GetObjBymId(lngmId);

if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(objFeatureImplementationEN.mId, objFeatureImplementationEN.UpdUser);
}
if (objFeatureImplementationEN != null)
{
int intRecNum = FeatureImplementationDA.DelRecord(lngmId);
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
objSQL = clsFeatureImplementationDA.GetSpecSQLObj();
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
//删除与表:[FeatureImplementation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFeatureImplementation.mId,
//lngmId);
//        clsFeatureImplementationBL.DelFeatureImplementationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureImplementationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureImplementationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFeatureImplementationBL.relatedActions != null)
{
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FeatureImplementationDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFeatureImplementations(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFeatureImplementationBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FeatureImplementationDA.DelFeatureImplementation(arrmIdLst);
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
public static int DelFeatureImplementationsByCond(string strWhereCond)
{
try
{
if (clsFeatureImplementationBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFeatureImplementationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FeatureImplementationDA.DelFeatureImplementation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FeatureImplementation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFeatureImplementationDA.GetSpecSQLObj();
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
//删除与表:[FeatureImplementation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureImplementationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureImplementationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFeatureImplementationENS">源对象</param>
 /// <param name = "objFeatureImplementationENT">目标对象</param>
 public static void CopyTo(clsFeatureImplementationEN objFeatureImplementationENS, clsFeatureImplementationEN objFeatureImplementationENT)
{
try
{
objFeatureImplementationENT.mId = objFeatureImplementationENS.mId; //mId
objFeatureImplementationENT.FeatureId = objFeatureImplementationENS.FeatureId; //功能Id
objFeatureImplementationENT.ViewImplId = objFeatureImplementationENS.ViewImplId; //界面实现Id
objFeatureImplementationENT.IsDefault = objFeatureImplementationENS.IsDefault; //是否默认
objFeatureImplementationENT.UpdDate = objFeatureImplementationENS.UpdDate; //修改日期
objFeatureImplementationENT.UpdUser = objFeatureImplementationENS.UpdUser; //修改者
objFeatureImplementationENT.Memo = objFeatureImplementationENS.Memo; //说明
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
 /// <param name = "objFeatureImplementationEN">源简化对象</param>
 public static void SetUpdFlag(clsFeatureImplementationEN objFeatureImplementationEN)
{
try
{
objFeatureImplementationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFeatureImplementationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFeatureImplementation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.mId = objFeatureImplementationEN.mId; //mId
}
if (arrFldSet.Contains(conFeatureImplementation.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.FeatureId = objFeatureImplementationEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conFeatureImplementation.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.ViewImplId = objFeatureImplementationEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(conFeatureImplementation.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.IsDefault = objFeatureImplementationEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(conFeatureImplementation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.UpdDate = objFeatureImplementationEN.UpdDate == "[null]" ? null :  objFeatureImplementationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFeatureImplementation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.UpdUser = objFeatureImplementationEN.UpdUser == "[null]" ? null :  objFeatureImplementationEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFeatureImplementation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureImplementationEN.Memo = objFeatureImplementationEN.Memo == "[null]" ? null :  objFeatureImplementationEN.Memo; //说明
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
 /// <param name = "objFeatureImplementationEN">源简化对象</param>
 public static void AccessFldValueNull(clsFeatureImplementationEN objFeatureImplementationEN)
{
try
{
if (objFeatureImplementationEN.UpdDate == "[null]") objFeatureImplementationEN.UpdDate = null; //修改日期
if (objFeatureImplementationEN.UpdUser == "[null]") objFeatureImplementationEN.UpdUser = null; //修改者
if (objFeatureImplementationEN.Memo == "[null]") objFeatureImplementationEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFeatureImplementationEN objFeatureImplementationEN)
{
 FeatureImplementationDA.CheckPropertyNew(objFeatureImplementationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFeatureImplementationEN objFeatureImplementationEN)
{
 FeatureImplementationDA.CheckProperty4Condition(objFeatureImplementationEN);
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
if (clsFeatureImplementationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureImplementationBL没有刷新缓存机制(clsFeatureImplementationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFeatureImplementationObjLstCache == null)
//{
//arrFeatureImplementationObjLstCache = FeatureImplementationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureImplementationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
List<clsFeatureImplementationEN> arrFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureImplementationEN> arrFeatureImplementationObjLst_Sel =
arrFeatureImplementationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFeatureImplementationObjLst_Sel.Count() == 0)
{
   clsFeatureImplementationEN obj = clsFeatureImplementationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFeatureImplementationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureImplementationEN> GetAllFeatureImplementationObjLstCache()
{
//获取缓存中的对象列表
List<clsFeatureImplementationEN> arrFeatureImplementationObjLstCache = GetObjLstCache(); 
return arrFeatureImplementationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureImplementationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
List<clsFeatureImplementationEN> arrFeatureImplementationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFeatureImplementationObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:FeatureId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrFeatureImplementationObjLst">需要排序的对象列表</param>
public static List <clsFeatureImplementationEN> GetSubSet4FeatureImplementationObjLstByFeatureIdCache(string strFeatureId)
{
   if (string.IsNullOrEmpty(strFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
List<clsFeatureImplementationEN> arrFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureImplementationEN> arrFeatureImplementationObjLst_Sel1 =
from objFeatureImplementationEN in arrFeatureImplementationObjLstCache
where objFeatureImplementationEN.FeatureId == strFeatureId
select objFeatureImplementationEN;
List <clsFeatureImplementationEN> arrFeatureImplementationObjLst_Sel = new List<clsFeatureImplementationEN>();
foreach (clsFeatureImplementationEN obj in arrFeatureImplementationObjLst_Sel1)
{
arrFeatureImplementationObjLst_Sel.Add(obj);
}
return arrFeatureImplementationObjLst_Sel;
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
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFeatureImplementationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFeatureImplementationEN._RefreshTimeLst.Count == 0) return "";
return clsFeatureImplementationEN._RefreshTimeLst[clsFeatureImplementationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFeatureImplementationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFeatureImplementationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFeatureImplementationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFeatureImplementationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FeatureImplementation(功能实现方式)
 /// 唯一性条件:FeatureId_ViewImplId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFeatureImplementationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFeatureImplementationEN objFeatureImplementationEN)
{
//检测记录是否存在
string strResult = FeatureImplementationDA.GetUniCondStr(objFeatureImplementationEN);
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
if (strInFldName != conFeatureImplementation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFeatureImplementation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFeatureImplementation._AttributeName));
throw new Exception(strMsg);
}
var objFeatureImplementation = clsFeatureImplementationBL.GetObjBymIdCache(lngmId);
if (objFeatureImplementation == null) return "";
return objFeatureImplementation[strOutFldName].ToString();
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
int intRecCount = clsFeatureImplementationDA.GetRecCount(strTabName);
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
int intRecCount = clsFeatureImplementationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFeatureImplementationDA.GetRecCount();
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
int intRecCount = clsFeatureImplementationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFeatureImplementationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFeatureImplementationEN objFeatureImplementationCond)
{
List<clsFeatureImplementationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureImplementationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureImplementation._AttributeName)
{
if (objFeatureImplementationCond.IsUpdated(strFldName) == false) continue;
if (objFeatureImplementationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureImplementationCond[strFldName].ToString());
}
else
{
if (objFeatureImplementationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureImplementationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureImplementationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureImplementationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureImplementationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureImplementationCond[strFldName]));
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
 List<string> arrList = clsFeatureImplementationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FeatureImplementationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FeatureImplementationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FeatureImplementationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureImplementationDA.SetFldValue(clsFeatureImplementationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FeatureImplementationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureImplementationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureImplementationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureImplementationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FeatureImplementation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**界面实现Id*/ 
 strCreateTabCode.Append(" ViewImplId char(4) not Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null, "); 
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
 /// 功能实现方式(FeatureImplementation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FeatureImplementation : clsCommFun4BL
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
clsFeatureImplementationBL.ReFreshThisCache();
}
}

}