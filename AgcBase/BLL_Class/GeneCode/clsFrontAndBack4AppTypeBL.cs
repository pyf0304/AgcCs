
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFrontAndBack4AppTypeBL
 表名:FrontAndBack4AppType(00050423)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsFrontAndBack4AppTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFrontAndBack4AppTypeEN GetObj(this K_mId_FrontAndBack4AppType myKey)
{
clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.GetObjBymId(myKey.Value);
return objFrontAndBack4AppTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFrontAndBack4AppTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!应用类型Id4Back = [{0}],应用类型Id4Front = [{1}]的数据已经存在!(in clsFrontAndBack4AppTypeBL.AddNewRecord)", objFrontAndBack4AppTypeEN.AppTypeId4Back,objFrontAndBack4AppTypeEN.AppTypeId4Front);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.AddNewRecordBySQL2(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, bool bolIsNeedCheckUniqueness = true)
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
objFrontAndBack4AppTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFrontAndBack4AppTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(应用类型Id4Back(AppTypeId4Back)=[{0}],应用类型Id4Front(AppTypeId4Front)=[{1}])已经存在,不能重复!", objFrontAndBack4AppTypeEN.AppTypeId4Back, objFrontAndBack4AppTypeEN.AppTypeId4Front);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFrontAndBack4AppTypeEN.AddNewRecord();
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFrontAndBack4AppTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!应用类型Id4Back = [{0}],应用类型Id4Front = [{1}]的数据已经存在!(in clsFrontAndBack4AppTypeBL.AddNewRecordWithReturnKey)", objFrontAndBack4AppTypeEN.AppTypeId4Back,objFrontAndBack4AppTypeEN.AppTypeId4Front);
throw new Exception(strMsg);
}
try
{
string strKey = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.AddNewRecordBySQL2WithReturnKey(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetmId(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, long lngmId, string strComparisonOp="")
	{
objFrontAndBack4AppTypeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.mId) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.mId, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.mId] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetAppTypeId4Front(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, int intAppTypeId4Front, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAppTypeId4Front, conFrontAndBack4AppType.AppTypeId4Front);
objFrontAndBack4AppTypeEN.AppTypeId4Front = intAppTypeId4Front; //应用类型Id4Front
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.AppTypeId4Front) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.AppTypeId4Front, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.AppTypeId4Front] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetAppTypeId4Back(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, int intAppTypeId4Back, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAppTypeId4Back, conFrontAndBack4AppType.AppTypeId4Back);
objFrontAndBack4AppTypeEN.AppTypeId4Back = intAppTypeId4Back; //应用类型Id4Back
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.AppTypeId4Back) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.AppTypeId4Back, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.AppTypeId4Back] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetUpdDate(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFrontAndBack4AppType.UpdDate);
}
objFrontAndBack4AppTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.UpdDate) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.UpdDate, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.UpdDate] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetUpdUser(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFrontAndBack4AppType.UpdUser);
}
objFrontAndBack4AppTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.UpdUser) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.UpdUser, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.UpdUser] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFrontAndBack4AppTypeEN SetMemo(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFrontAndBack4AppType.Memo);
}
objFrontAndBack4AppTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(conFrontAndBack4AppType.Memo) == false)
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(conFrontAndBack4AppType.Memo, strComparisonOp);
}
else
{
objFrontAndBack4AppTypeEN.dicFldComparisonOp[conFrontAndBack4AppType.Memo] = strComparisonOp;
}
}
return objFrontAndBack4AppTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFrontAndBack4AppTypeEN.CheckPropertyNew();
clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeCond = new clsFrontAndBack4AppTypeEN();
string strCondition = objFrontAndBack4AppTypeCond
.SetmId(objFrontAndBack4AppTypeEN.mId, "<>")
.SetAppTypeId4Back(objFrontAndBack4AppTypeEN.AppTypeId4Back, "=")
.SetAppTypeId4Front(objFrontAndBack4AppTypeEN.AppTypeId4Front, "=")
.GetCombineCondition();
objFrontAndBack4AppTypeEN._IsCheckProperty = true;
bool bolIsExist = clsFrontAndBack4AppTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AppTypeId4Back_AppTypeId4Front)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFrontAndBack4AppTypeEN.Update();
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
 /// <param name = "objFrontAndBack4AppType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeCond = new clsFrontAndBack4AppTypeEN();
string strCondition = objFrontAndBack4AppTypeCond
.SetAppTypeId4Back(objFrontAndBack4AppType.AppTypeId4Back, "=")
.SetAppTypeId4Front(objFrontAndBack4AppType.AppTypeId4Front, "=")
.GetCombineCondition();
objFrontAndBack4AppType._IsCheckProperty = true;
bool bolIsExist = clsFrontAndBack4AppTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFrontAndBack4AppType.mId = clsFrontAndBack4AppTypeBL.GetFirstID_S(strCondition);
objFrontAndBack4AppType.UpdateWithCondition(strCondition);
}
else
{
objFrontAndBack4AppType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 if (objFrontAndBack4AppTypeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.UpdateBySql2(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFrontAndBack4AppTypeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.UpdateBySql2(objFrontAndBack4AppTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.UpdateBySqlWithCondition(objFrontAndBack4AppTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.UpdateBySqlWithConditionTransaction(objFrontAndBack4AppTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
public static int Delete(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
try
{
int intRecNum = clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.DelRecord(objFrontAndBack4AppTypeEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
 public static void CopyTo(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENS, clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENT)
{
try
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
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
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <returns>目标对象=>clsFrontAndBack4AppTypeEN:objFrontAndBack4AppTypeENT</returns>
 public static clsFrontAndBack4AppTypeEN CopyTo(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENS)
{
try
{
 clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENT = new clsFrontAndBack4AppTypeEN()
{
mId = objFrontAndBack4AppTypeENS.mId, //mId
AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front, //应用类型Id4Front
AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back, //应用类型Id4Back
UpdDate = objFrontAndBack4AppTypeENS.UpdDate, //修改日期
UpdUser = objFrontAndBack4AppTypeENS.UpdUser, //修改者
Memo = objFrontAndBack4AppTypeENS.Memo, //说明
};
 return objFrontAndBack4AppTypeENT;
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
public static void CheckPropertyNew(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.CheckPropertyNew(objFrontAndBack4AppTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 clsFrontAndBack4AppTypeBL.FrontAndBack4AppTypeDA.CheckProperty4Condition(objFrontAndBack4AppTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.mId) == true)
{
string strComparisonOpmId = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFrontAndBack4AppType.mId, objFrontAndBack4AppTypeCond.mId, strComparisonOpmId);
}
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.AppTypeId4Front) == true)
{
string strComparisonOpAppTypeId4Front = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.AppTypeId4Front];
strWhereCond += string.Format(" And {0} {2} {1}", conFrontAndBack4AppType.AppTypeId4Front, objFrontAndBack4AppTypeCond.AppTypeId4Front, strComparisonOpAppTypeId4Front);
}
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.AppTypeId4Back) == true)
{
string strComparisonOpAppTypeId4Back = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.AppTypeId4Back];
strWhereCond += string.Format(" And {0} {2} {1}", conFrontAndBack4AppType.AppTypeId4Back, objFrontAndBack4AppTypeCond.AppTypeId4Back, strComparisonOpAppTypeId4Back);
}
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.UpdDate) == true)
{
string strComparisonOpUpdDate = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFrontAndBack4AppType.UpdDate, objFrontAndBack4AppTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.UpdUser) == true)
{
string strComparisonOpUpdUser = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFrontAndBack4AppType.UpdUser, objFrontAndBack4AppTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFrontAndBack4AppTypeCond.IsUpdated(conFrontAndBack4AppType.Memo) == true)
{
string strComparisonOpMemo = objFrontAndBack4AppTypeCond.dicFldComparisonOp[conFrontAndBack4AppType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFrontAndBack4AppType.Memo, objFrontAndBack4AppTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FrontAndBack4AppType(应用类型的前后台关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AppTypeId4Back_AppTypeId4Front
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFrontAndBack4AppTypeEN == null) return true;
if (objFrontAndBack4AppTypeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AppTypeId4Back = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Back);
 sbCondition.AppendFormat(" and AppTypeId4Front = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Front);
if (clsFrontAndBack4AppTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFrontAndBack4AppTypeEN.mId);
 sbCondition.AppendFormat(" and AppTypeId4Back = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Back);
 sbCondition.AppendFormat(" and AppTypeId4Front = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Front);
if (clsFrontAndBack4AppTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FrontAndBack4AppType(应用类型的前后台关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AppTypeId4Back_AppTypeId4Front
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFrontAndBack4AppTypeEN == null) return "";
if (objFrontAndBack4AppTypeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AppTypeId4Back = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Back);
 sbCondition.AppendFormat(" and AppTypeId4Front = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Front);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFrontAndBack4AppTypeEN.mId);
 sbCondition.AppendFormat(" and AppTypeId4Back = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Back);
 sbCondition.AppendFormat(" and AppTypeId4Front = '{0}'", objFrontAndBack4AppTypeEN.AppTypeId4Front);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FrontAndBack4AppType
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 应用类型的前后台关系(FrontAndBack4AppType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFrontAndBack4AppTypeBL
{
public static RelatedActions_FrontAndBack4AppType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFrontAndBack4AppTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFrontAndBack4AppTypeDA FrontAndBack4AppTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFrontAndBack4AppTypeDA();
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
 public clsFrontAndBack4AppTypeBL()
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
if (string.IsNullOrEmpty(clsFrontAndBack4AppTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFrontAndBack4AppTypeEN._ConnectString);
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
public static DataTable GetDataTable_FrontAndBack4AppType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FrontAndBack4AppTypeDA.GetDataTable_FrontAndBack4AppType(strWhereCond);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable(strWhereCond);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable_Top(objTopPara);
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
objDT = FrontAndBack4AppTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FrontAndBack4AppTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FrontAndBack4AppTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
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
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFrontAndBack4AppTypeEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFrontAndBack4AppTypeEN._CurrTabName);
List<clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLst_Sel =
arrFrontAndBack4AppTypeObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFrontAndBack4AppTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetObjLst(string strWhereCond)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFrontAndBack4AppTypeEN> GetSubObjLstCache(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeCond)
{
List<clsFrontAndBack4AppTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFrontAndBack4AppTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFrontAndBack4AppType._AttributeName)
{
if (objFrontAndBack4AppTypeCond.IsUpdated(strFldName) == false) continue;
if (objFrontAndBack4AppTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFrontAndBack4AppTypeCond[strFldName].ToString());
}
else
{
if (objFrontAndBack4AppTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFrontAndBack4AppTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFrontAndBack4AppTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFrontAndBack4AppTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFrontAndBack4AppTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFrontAndBack4AppTypeCond[strFldName]));
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
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
List<clsFrontAndBack4AppTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFrontAndBack4AppTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFrontAndBack4AppTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
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
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
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
public static List<clsFrontAndBack4AppTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
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
public static List<clsFrontAndBack4AppTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFrontAndBack4AppTypeEN> arrObjLst = new List<clsFrontAndBack4AppTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = new clsFrontAndBack4AppTypeEN();
try
{
objFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[conFrontAndBack4AppType.mId].ToString().Trim()); //mId
objFrontAndBack4AppTypeEN.AppTypeId4Front = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objFrontAndBack4AppTypeEN.AppTypeId4Back = Int32.Parse(objRow[conFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objFrontAndBack4AppTypeEN.UpdDate = objRow[conFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objFrontAndBack4AppTypeEN.UpdUser = objRow[conFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objFrontAndBack4AppTypeEN.Memo = objRow[conFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[conFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFrontAndBack4AppType(ref clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
bool bolResult = FrontAndBack4AppTypeDA.GetFrontAndBack4AppType(ref objFrontAndBack4AppTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFrontAndBack4AppTypeEN GetObjBymId(long lngmId)
{
clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = FrontAndBack4AppTypeDA.GetObjBymId(lngmId);
return objFrontAndBack4AppTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFrontAndBack4AppTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = FrontAndBack4AppTypeDA.GetFirstObj(strWhereCond);
 return objFrontAndBack4AppTypeEN;
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
public static clsFrontAndBack4AppTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = FrontAndBack4AppTypeDA.GetObjByDataRow(objRow);
 return objFrontAndBack4AppTypeEN;
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
public static clsFrontAndBack4AppTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = FrontAndBack4AppTypeDA.GetObjByDataRow(objRow);
 return objFrontAndBack4AppTypeEN;
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
 /// <param name = "lstFrontAndBack4AppTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFrontAndBack4AppTypeEN GetObjBymIdFromList(long lngmId, List<clsFrontAndBack4AppTypeEN> lstFrontAndBack4AppTypeObjLst)
{
foreach (clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN in lstFrontAndBack4AppTypeObjLst)
{
if (objFrontAndBack4AppTypeEN.mId == lngmId)
{
return objFrontAndBack4AppTypeEN;
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
 lngmId = new clsFrontAndBack4AppTypeDA().GetFirstID(strWhereCond);
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
 arrList = FrontAndBack4AppTypeDA.GetID(strWhereCond);
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
bool bolIsExist = FrontAndBack4AppTypeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FrontAndBack4AppTypeDA.IsExist(lngmId);
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
clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = clsFrontAndBack4AppTypeBL.GetObjBymId(lngmId);
objFrontAndBack4AppTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFrontAndBack4AppTypeEN.UpdUser = strOpUser;
return clsFrontAndBack4AppTypeBL.UpdateBySql2(objFrontAndBack4AppTypeEN);
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
 bolIsExist = clsFrontAndBack4AppTypeDA.IsExistTable();
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
 bolIsExist = FrontAndBack4AppTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFrontAndBack4AppTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用类型Id4Back = [{0}],应用类型Id4Front = [{1}]的数据已经存在!(in clsFrontAndBack4AppTypeBL.AddNewRecordBySql2)", objFrontAndBack4AppTypeEN.AppTypeId4Back,objFrontAndBack4AppTypeEN.AppTypeId4Front);
throw new Exception(strMsg);
}
try
{
bool bolResult = FrontAndBack4AppTypeDA.AddNewRecordBySQL2(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFrontAndBack4AppTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用类型Id4Back = [{0}],应用类型Id4Front = [{1}]的数据已经存在!(in clsFrontAndBack4AppTypeBL.AddNewRecordBySql2WithReturnKey)", objFrontAndBack4AppTypeEN.AppTypeId4Back,objFrontAndBack4AppTypeEN.AppTypeId4Front);
throw new Exception(strMsg);
}
try
{
string strKey = FrontAndBack4AppTypeDA.AddNewRecordBySQL2WithReturnKey(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
try
{
bool bolResult = FrontAndBack4AppTypeDA.Update(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 /// <param name = "objFrontAndBack4AppTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 if (objFrontAndBack4AppTypeEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FrontAndBack4AppTypeDA.UpdateBySql2(objFrontAndBack4AppTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFrontAndBack4AppTypeBL.ReFreshCache();

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
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
 clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN = clsFrontAndBack4AppTypeBL.GetObjBymId(lngmId);

if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(objFrontAndBack4AppTypeEN.mId, objFrontAndBack4AppTypeEN.UpdUser);
}
if (objFrontAndBack4AppTypeEN != null)
{
int intRecNum = FrontAndBack4AppTypeDA.DelRecord(lngmId);
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
objSQL = clsFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
//删除与表:[FrontAndBack4AppType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFrontAndBack4AppType.mId,
//lngmId);
//        clsFrontAndBack4AppTypeBL.DelFrontAndBack4AppTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFrontAndBack4AppTypeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFrontAndBack4AppTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FrontAndBack4AppTypeDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFrontAndBack4AppTypes(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FrontAndBack4AppTypeDA.DelFrontAndBack4AppType(arrmIdLst);
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
public static int DelFrontAndBack4AppTypesByCond(string strWhereCond)
{
try
{
if (clsFrontAndBack4AppTypeBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFrontAndBack4AppTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FrontAndBack4AppTypeDA.DelFrontAndBack4AppType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FrontAndBack4AppType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
//删除与表:[FrontAndBack4AppType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFrontAndBack4AppTypeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFrontAndBack4AppTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objFrontAndBack4AppTypeENT">目标对象</param>
 public static void CopyTo(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENS, clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeENT)
{
try
{
objFrontAndBack4AppTypeENT.mId = objFrontAndBack4AppTypeENS.mId; //mId
objFrontAndBack4AppTypeENT.AppTypeId4Front = objFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objFrontAndBack4AppTypeENT.AppTypeId4Back = objFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objFrontAndBack4AppTypeENT.UpdDate = objFrontAndBack4AppTypeENS.UpdDate; //修改日期
objFrontAndBack4AppTypeENT.UpdUser = objFrontAndBack4AppTypeENS.UpdUser; //修改者
objFrontAndBack4AppTypeENT.Memo = objFrontAndBack4AppTypeENS.Memo; //说明
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
 /// <param name = "objFrontAndBack4AppTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
try
{
objFrontAndBack4AppTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFrontAndBack4AppTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFrontAndBack4AppType.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.mId = objFrontAndBack4AppTypeEN.mId; //mId
}
if (arrFldSet.Contains(conFrontAndBack4AppType.AppTypeId4Front, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.AppTypeId4Front = objFrontAndBack4AppTypeEN.AppTypeId4Front; //应用类型Id4Front
}
if (arrFldSet.Contains(conFrontAndBack4AppType.AppTypeId4Back, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.AppTypeId4Back = objFrontAndBack4AppTypeEN.AppTypeId4Back; //应用类型Id4Back
}
if (arrFldSet.Contains(conFrontAndBack4AppType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.UpdDate = objFrontAndBack4AppTypeEN.UpdDate == "[null]" ? null :  objFrontAndBack4AppTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFrontAndBack4AppType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.UpdUser = objFrontAndBack4AppTypeEN.UpdUser == "[null]" ? null :  objFrontAndBack4AppTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFrontAndBack4AppType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFrontAndBack4AppTypeEN.Memo = objFrontAndBack4AppTypeEN.Memo == "[null]" ? null :  objFrontAndBack4AppTypeEN.Memo; //说明
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
 /// <param name = "objFrontAndBack4AppTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
try
{
if (objFrontAndBack4AppTypeEN.UpdDate == "[null]") objFrontAndBack4AppTypeEN.UpdDate = null; //修改日期
if (objFrontAndBack4AppTypeEN.UpdUser == "[null]") objFrontAndBack4AppTypeEN.UpdUser = null; //修改者
if (objFrontAndBack4AppTypeEN.Memo == "[null]") objFrontAndBack4AppTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 FrontAndBack4AppTypeDA.CheckPropertyNew(objFrontAndBack4AppTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
 FrontAndBack4AppTypeDA.CheckProperty4Condition(objFrontAndBack4AppTypeEN);
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
if (clsFrontAndBack4AppTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFrontAndBack4AppTypeBL没有刷新缓存机制(clsFrontAndBack4AppTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFrontAndBack4AppTypeObjLstCache == null)
//{
//arrFrontAndBack4AppTypeObjLstCache = FrontAndBack4AppTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFrontAndBack4AppTypeEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFrontAndBack4AppTypeEN._CurrTabName);
List<clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLst_Sel =
arrFrontAndBack4AppTypeObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFrontAndBack4AppTypeObjLst_Sel.Count() == 0)
{
   clsFrontAndBack4AppTypeEN obj = clsFrontAndBack4AppTypeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFrontAndBack4AppTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetAllFrontAndBack4AppTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLstCache = GetObjLstCache(); 
return arrFrontAndBack4AppTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFrontAndBack4AppTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFrontAndBack4AppTypeEN._CurrTabName);
List<clsFrontAndBack4AppTypeEN> arrFrontAndBack4AppTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFrontAndBack4AppTypeObjLstCache;
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
string strKey = string.Format("{0}", clsFrontAndBack4AppTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFrontAndBack4AppTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFrontAndBack4AppTypeEN._RefreshTimeLst.Count == 0) return "";
return clsFrontAndBack4AppTypeEN._RefreshTimeLst[clsFrontAndBack4AppTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFrontAndBack4AppTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFrontAndBack4AppTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFrontAndBack4AppTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFrontAndBack4AppTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FrontAndBack4AppType(应用类型的前后台关系)
 /// 唯一性条件:AppTypeId4Back_AppTypeId4Front
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeEN)
{
//检测记录是否存在
string strResult = FrontAndBack4AppTypeDA.GetUniCondStr(objFrontAndBack4AppTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFrontAndBack4AppType.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFrontAndBack4AppType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFrontAndBack4AppType._AttributeName));
throw new Exception(strMsg);
}
var objFrontAndBack4AppType = clsFrontAndBack4AppTypeBL.GetObjBymIdCache(lngmId);
if (objFrontAndBack4AppType == null) return "";
return objFrontAndBack4AppType[strOutFldName].ToString();
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
int intRecCount = clsFrontAndBack4AppTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsFrontAndBack4AppTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFrontAndBack4AppTypeDA.GetRecCount();
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
int intRecCount = clsFrontAndBack4AppTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFrontAndBack4AppTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFrontAndBack4AppTypeEN objFrontAndBack4AppTypeCond)
{
List<clsFrontAndBack4AppTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFrontAndBack4AppTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFrontAndBack4AppType._AttributeName)
{
if (objFrontAndBack4AppTypeCond.IsUpdated(strFldName) == false) continue;
if (objFrontAndBack4AppTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFrontAndBack4AppTypeCond[strFldName].ToString());
}
else
{
if (objFrontAndBack4AppTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFrontAndBack4AppTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFrontAndBack4AppTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFrontAndBack4AppTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFrontAndBack4AppTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFrontAndBack4AppTypeCond[strFldName]));
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
 List<string> arrList = clsFrontAndBack4AppTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FrontAndBack4AppTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FrontAndBack4AppTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FrontAndBack4AppTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFrontAndBack4AppTypeDA.SetFldValue(clsFrontAndBack4AppTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FrontAndBack4AppTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFrontAndBack4AppTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFrontAndBack4AppTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFrontAndBack4AppTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FrontAndBack4AppType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**应用类型Id4Front*/ 
 strCreateTabCode.Append(" AppTypeId4Front int not Null, "); 
 // /**应用类型Id4Back*/ 
 strCreateTabCode.Append(" AppTypeId4Back int not Null, "); 
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
 /// 应用类型的前后台关系(FrontAndBack4AppType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FrontAndBack4AppType : clsCommFun4BL
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
clsFrontAndBack4AppTypeBL.ReFreshThisCache();
}
}

}