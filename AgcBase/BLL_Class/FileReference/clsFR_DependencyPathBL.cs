
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_DependencyPathBL
 表名:FR_DependencyPath(00050656)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:50:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
public static class  clsFR_DependencyPathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_DependencyPathEN GetObj(this K_mId_FR_DependencyPath myKey)
{
clsFR_DependencyPathEN objFR_DependencyPathEN = clsFR_DependencyPathBL.FR_DependencyPathDA.GetObjBymId(myKey.Value);
return objFR_DependencyPathEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
bool bolResult = clsFR_DependencyPathBL.FR_DependencyPathDA.AddNewRecordBySQL2(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFR_DependencyPathBL.IsExist(objFR_DependencyPathEN.mId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFR_DependencyPathEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFR_DependencyPathEN.AddNewRecord();
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
string strKey = clsFR_DependencyPathBL.FR_DependencyPathDA.AddNewRecordBySQL2WithReturnKey(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetmId(this clsFR_DependencyPathEN objFR_DependencyPathEN, long lngmId, string strComparisonOp="")
	{
objFR_DependencyPathEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.mId) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.mId, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.mId] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetSourceFileId(this clsFR_DependencyPathEN objFR_DependencyPathEN, long lngSourceFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSourceFileId, conFR_DependencyPath.SourceFileId);
objFR_DependencyPathEN.SourceFileId = lngSourceFileId; //源文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.SourceFileId) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.SourceFileId, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.SourceFileId] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetTargetFileId(this clsFR_DependencyPathEN objFR_DependencyPathEN, long lngTargetFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTargetFileId, conFR_DependencyPath.TargetFileId);
objFR_DependencyPathEN.TargetFileId = lngTargetFileId; //目标文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.TargetFileId) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.TargetFileId, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.TargetFileId] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetPathLength(this clsFR_DependencyPathEN objFR_DependencyPathEN, int intPathLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intPathLength, conFR_DependencyPath.PathLength);
objFR_DependencyPathEN.PathLength = intPathLength; //路径长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.PathLength) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.PathLength, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.PathLength] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetPathString(this clsFR_DependencyPathEN objFR_DependencyPathEN, string strPathString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPathString, 2000, conFR_DependencyPath.PathString);
}
objFR_DependencyPathEN.PathString = strPathString; //路径字符串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.PathString) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.PathString, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.PathString] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetIsCircular(this clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsCircular, string strComparisonOp="")
	{
objFR_DependencyPathEN.IsCircular = bolIsCircular; //是否循环依赖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.IsCircular) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.IsCircular, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.IsCircular] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_DependencyPathEN SetCreatedAt(this clsFR_DependencyPathEN objFR_DependencyPathEN, DateTime dteCreatedAt, string strComparisonOp="")
	{
objFR_DependencyPathEN.CreatedAt = dteCreatedAt; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_DependencyPathEN.dicFldComparisonOp.ContainsKey(conFR_DependencyPath.CreatedAt) == false)
{
objFR_DependencyPathEN.dicFldComparisonOp.Add(conFR_DependencyPath.CreatedAt, strComparisonOp);
}
else
{
objFR_DependencyPathEN.dicFldComparisonOp[conFR_DependencyPath.CreatedAt] = strComparisonOp;
}
}
return objFR_DependencyPathEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFR_DependencyPathEN objFR_DependencyPathEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFR_DependencyPathEN.CheckPropertyNew();
clsFR_DependencyPathEN objFR_DependencyPathCond = new clsFR_DependencyPathEN();
string strCondition = objFR_DependencyPathCond
.SetmId(objFR_DependencyPathEN.mId, "=")
.GetCombineCondition();
objFR_DependencyPathEN._IsCheckProperty = true;
bool bolIsExist = clsFR_DependencyPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFR_DependencyPathEN.Update();
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 if (objFR_DependencyPathEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_DependencyPathBL.FR_DependencyPathDA.UpdateBySql2(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_DependencyPathEN objFR_DependencyPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_DependencyPathEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_DependencyPathBL.FR_DependencyPathDA.UpdateBySql2(objFR_DependencyPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_DependencyPathEN objFR_DependencyPathEN, string strWhereCond)
{
try
{
bool bolResult = clsFR_DependencyPathBL.FR_DependencyPathDA.UpdateBySqlWithCondition(objFR_DependencyPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_DependencyPathEN objFR_DependencyPathEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFR_DependencyPathBL.FR_DependencyPathDA.UpdateBySqlWithConditionTransaction(objFR_DependencyPathEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
public static int Delete(this clsFR_DependencyPathEN objFR_DependencyPathEN)
{
try
{
int intRecNum = clsFR_DependencyPathBL.FR_DependencyPathDA.DelRecord(objFR_DependencyPathEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathENS">源对象</param>
 /// <param name = "objFR_DependencyPathENT">目标对象</param>
 public static void CopyTo(this clsFR_DependencyPathEN objFR_DependencyPathENS, clsFR_DependencyPathEN objFR_DependencyPathENT)
{
try
{
objFR_DependencyPathENT.mId = objFR_DependencyPathENS.mId; //mId
objFR_DependencyPathENT.SourceFileId = objFR_DependencyPathENS.SourceFileId; //源文件Id
objFR_DependencyPathENT.TargetFileId = objFR_DependencyPathENS.TargetFileId; //目标文件Id
objFR_DependencyPathENT.PathLength = objFR_DependencyPathENS.PathLength; //路径长度
objFR_DependencyPathENT.PathString = objFR_DependencyPathENS.PathString; //路径字符串
objFR_DependencyPathENT.IsCircular = objFR_DependencyPathENS.IsCircular; //是否循环依赖
objFR_DependencyPathENT.CreatedAt = objFR_DependencyPathENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_DependencyPathENS">源对象</param>
 /// <returns>目标对象=>clsFR_DependencyPathEN:objFR_DependencyPathENT</returns>
 public static clsFR_DependencyPathEN CopyTo(this clsFR_DependencyPathEN objFR_DependencyPathENS)
{
try
{
 clsFR_DependencyPathEN objFR_DependencyPathENT = new clsFR_DependencyPathEN()
{
mId = objFR_DependencyPathENS.mId, //mId
SourceFileId = objFR_DependencyPathENS.SourceFileId, //源文件Id
TargetFileId = objFR_DependencyPathENS.TargetFileId, //目标文件Id
PathLength = objFR_DependencyPathENS.PathLength, //路径长度
PathString = objFR_DependencyPathENS.PathString, //路径字符串
IsCircular = objFR_DependencyPathENS.IsCircular, //是否循环依赖
CreatedAt = objFR_DependencyPathENS.CreatedAt, //建立时间
};
 return objFR_DependencyPathENT;
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
public static void CheckPropertyNew(this clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 clsFR_DependencyPathBL.FR_DependencyPathDA.CheckPropertyNew(objFR_DependencyPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 clsFR_DependencyPathBL.FR_DependencyPathDA.CheckProperty4Condition(objFR_DependencyPathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFR_DependencyPathEN objFR_DependencyPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.mId) == true)
{
string strComparisonOpmId = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_DependencyPath.mId, objFR_DependencyPathCond.mId, strComparisonOpmId);
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.SourceFileId) == true)
{
string strComparisonOpSourceFileId = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.SourceFileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_DependencyPath.SourceFileId, objFR_DependencyPathCond.SourceFileId, strComparisonOpSourceFileId);
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.TargetFileId) == true)
{
string strComparisonOpTargetFileId = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.TargetFileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_DependencyPath.TargetFileId, objFR_DependencyPathCond.TargetFileId, strComparisonOpTargetFileId);
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.PathLength) == true)
{
string strComparisonOpPathLength = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.PathLength];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_DependencyPath.PathLength, objFR_DependencyPathCond.PathLength, strComparisonOpPathLength);
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.PathString) == true)
{
string strComparisonOpPathString = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.PathString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_DependencyPath.PathString, objFR_DependencyPathCond.PathString, strComparisonOpPathString);
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.IsCircular) == true)
{
if (objFR_DependencyPathCond.IsCircular == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFR_DependencyPath.IsCircular);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFR_DependencyPath.IsCircular);
}
}
if (objFR_DependencyPathCond.IsUpdated(conFR_DependencyPath.CreatedAt) == true)
{
string strComparisonOpCreatedAt = objFR_DependencyPathCond.dicFldComparisonOp[conFR_DependencyPath.CreatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_DependencyPath.CreatedAt, objFR_DependencyPathCond.CreatedAt, strComparisonOpCreatedAt);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FR_DependencyPath
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// FR_DependencyPath(FR_DependencyPath)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFR_DependencyPathBL
{
public static RelatedActions_FR_DependencyPath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFR_DependencyPathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFR_DependencyPathDA FR_DependencyPathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFR_DependencyPathDA();
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
 public clsFR_DependencyPathBL()
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
if (string.IsNullOrEmpty(clsFR_DependencyPathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFR_DependencyPathEN._ConnectString);
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
public static DataTable GetDataTable_FR_DependencyPath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FR_DependencyPathDA.GetDataTable_FR_DependencyPath(strWhereCond);
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
objDT = FR_DependencyPathDA.GetDataTable(strWhereCond);
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
objDT = FR_DependencyPathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FR_DependencyPathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FR_DependencyPathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FR_DependencyPathDA.GetDataTable_Top(objTopPara);
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
objDT = FR_DependencyPathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FR_DependencyPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FR_DependencyPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFR_DependencyPathEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
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
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFR_DependencyPathEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFR_DependencyPathEN._CurrTabName);
List<clsFR_DependencyPathEN> arrFR_DependencyPathObjLstCache = GetObjLstCache();
IEnumerable <clsFR_DependencyPathEN> arrFR_DependencyPathObjLst_Sel =
arrFR_DependencyPathObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFR_DependencyPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_DependencyPathEN> GetObjLst(string strWhereCond)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
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
public static List<clsFR_DependencyPathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFR_DependencyPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFR_DependencyPathEN> GetSubObjLstCache(clsFR_DependencyPathEN objFR_DependencyPathCond)
{
List<clsFR_DependencyPathEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_DependencyPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_DependencyPath._AttributeName)
{
if (objFR_DependencyPathCond.IsUpdated(strFldName) == false) continue;
if (objFR_DependencyPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_DependencyPathCond[strFldName].ToString());
}
else
{
if (objFR_DependencyPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_DependencyPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_DependencyPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_DependencyPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_DependencyPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_DependencyPathCond[strFldName]));
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
public static List<clsFR_DependencyPathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
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
public static List<clsFR_DependencyPathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
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
List<clsFR_DependencyPathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFR_DependencyPathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_DependencyPathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFR_DependencyPathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
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
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
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
public static List<clsFR_DependencyPathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFR_DependencyPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFR_DependencyPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
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
public static List<clsFR_DependencyPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_DependencyPathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFR_DependencyPathEN> arrObjLst = new List<clsFR_DependencyPathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_DependencyPathEN objFR_DependencyPathEN = new clsFR_DependencyPathEN();
try
{
objFR_DependencyPathEN.mId = Int32.Parse(objRow[conFR_DependencyPath.mId].ToString().Trim()); //mId
objFR_DependencyPathEN.SourceFileId = Int32.Parse(objRow[conFR_DependencyPath.SourceFileId].ToString().Trim()); //源文件Id
objFR_DependencyPathEN.TargetFileId = Int32.Parse(objRow[conFR_DependencyPath.TargetFileId].ToString().Trim()); //目标文件Id
objFR_DependencyPathEN.PathLength = Int32.Parse(objRow[conFR_DependencyPath.PathLength].ToString().Trim()); //路径长度
objFR_DependencyPathEN.PathString = objRow[conFR_DependencyPath.PathString] == DBNull.Value ? null : objRow[conFR_DependencyPath.PathString].ToString().Trim(); //路径字符串
objFR_DependencyPathEN.IsCircular = clsEntityBase2.TransNullToBool_S(objRow[conFR_DependencyPath.IsCircular].ToString().Trim()); //是否循环依赖
objFR_DependencyPathEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_DependencyPath.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_DependencyPathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_DependencyPathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFR_DependencyPathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFR_DependencyPath(ref clsFR_DependencyPathEN objFR_DependencyPathEN)
{
bool bolResult = FR_DependencyPathDA.GetFR_DependencyPath(ref objFR_DependencyPathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_DependencyPathEN GetObjBymId(long lngmId)
{
clsFR_DependencyPathEN objFR_DependencyPathEN = FR_DependencyPathDA.GetObjBymId(lngmId);
return objFR_DependencyPathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFR_DependencyPathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFR_DependencyPathEN objFR_DependencyPathEN = FR_DependencyPathDA.GetFirstObj(strWhereCond);
 return objFR_DependencyPathEN;
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
public static clsFR_DependencyPathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFR_DependencyPathEN objFR_DependencyPathEN = FR_DependencyPathDA.GetObjByDataRow(objRow);
 return objFR_DependencyPathEN;
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
public static clsFR_DependencyPathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFR_DependencyPathEN objFR_DependencyPathEN = FR_DependencyPathDA.GetObjByDataRow(objRow);
 return objFR_DependencyPathEN;
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
 /// <param name = "lstFR_DependencyPathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_DependencyPathEN GetObjBymIdFromList(long lngmId, List<clsFR_DependencyPathEN> lstFR_DependencyPathObjLst)
{
foreach (clsFR_DependencyPathEN objFR_DependencyPathEN in lstFR_DependencyPathObjLst)
{
if (objFR_DependencyPathEN.mId == lngmId)
{
return objFR_DependencyPathEN;
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
 lngmId = new clsFR_DependencyPathDA().GetFirstID(strWhereCond);
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
 arrList = FR_DependencyPathDA.GetID(strWhereCond);
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
bool bolIsExist = FR_DependencyPathDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FR_DependencyPathDA.IsExist(lngmId);
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
 bolIsExist = clsFR_DependencyPathDA.IsExistTable();
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
 bolIsExist = FR_DependencyPathDA.IsExistTable(strTabName);
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
bool bolResult = FR_DependencyPathDA.AddNewRecordBySQL2(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFR_DependencyPathEN objFR_DependencyPathEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
string strKey = FR_DependencyPathDA.AddNewRecordBySQL2WithReturnKey(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
try
{
bool bolResult = FR_DependencyPathDA.Update(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_DependencyPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 if (objFR_DependencyPathEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FR_DependencyPathDA.UpdateBySql2(objFR_DependencyPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_DependencyPathBL.ReFreshCache();

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
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
 clsFR_DependencyPathEN objFR_DependencyPathEN = clsFR_DependencyPathBL.GetObjBymId(lngmId);

if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(objFR_DependencyPathEN.mId, "SetUpdDate");
}
if (objFR_DependencyPathEN != null)
{
int intRecNum = FR_DependencyPathDA.DelRecord(lngmId);
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
objSQL = clsFR_DependencyPathDA.GetSpecSQLObj();
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
//删除与表:[FR_DependencyPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFR_DependencyPath.mId,
//lngmId);
//        clsFR_DependencyPathBL.DelFR_DependencyPathsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_DependencyPathBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_DependencyPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFR_DependencyPathBL.relatedActions != null)
{
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FR_DependencyPathDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFR_DependencyPaths(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFR_DependencyPathBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FR_DependencyPathDA.DelFR_DependencyPath(arrmIdLst);
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
public static int DelFR_DependencyPathsByCond(string strWhereCond)
{
try
{
if (clsFR_DependencyPathBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFR_DependencyPathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FR_DependencyPathDA.DelFR_DependencyPath(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FR_DependencyPath]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFR_DependencyPathDA.GetSpecSQLObj();
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
//删除与表:[FR_DependencyPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_DependencyPathBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_DependencyPathBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFR_DependencyPathENS">源对象</param>
 /// <param name = "objFR_DependencyPathENT">目标对象</param>
 public static void CopyTo(clsFR_DependencyPathEN objFR_DependencyPathENS, clsFR_DependencyPathEN objFR_DependencyPathENT)
{
try
{
objFR_DependencyPathENT.mId = objFR_DependencyPathENS.mId; //mId
objFR_DependencyPathENT.SourceFileId = objFR_DependencyPathENS.SourceFileId; //源文件Id
objFR_DependencyPathENT.TargetFileId = objFR_DependencyPathENS.TargetFileId; //目标文件Id
objFR_DependencyPathENT.PathLength = objFR_DependencyPathENS.PathLength; //路径长度
objFR_DependencyPathENT.PathString = objFR_DependencyPathENS.PathString; //路径字符串
objFR_DependencyPathENT.IsCircular = objFR_DependencyPathENS.IsCircular; //是否循环依赖
objFR_DependencyPathENT.CreatedAt = objFR_DependencyPathENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_DependencyPathEN">源简化对象</param>
 public static void SetUpdFlag(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
try
{
objFR_DependencyPathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFR_DependencyPathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFR_DependencyPath.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.mId = objFR_DependencyPathEN.mId; //mId
}
if (arrFldSet.Contains(conFR_DependencyPath.SourceFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.SourceFileId = objFR_DependencyPathEN.SourceFileId; //源文件Id
}
if (arrFldSet.Contains(conFR_DependencyPath.TargetFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.TargetFileId = objFR_DependencyPathEN.TargetFileId; //目标文件Id
}
if (arrFldSet.Contains(conFR_DependencyPath.PathLength, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.PathLength = objFR_DependencyPathEN.PathLength; //路径长度
}
if (arrFldSet.Contains(conFR_DependencyPath.PathString, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.PathString = objFR_DependencyPathEN.PathString == "[null]" ? null :  objFR_DependencyPathEN.PathString; //路径字符串
}
if (arrFldSet.Contains(conFR_DependencyPath.IsCircular, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.IsCircular = objFR_DependencyPathEN.IsCircular; //是否循环依赖
}
if (arrFldSet.Contains(conFR_DependencyPath.CreatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_DependencyPathEN.CreatedAt = objFR_DependencyPathEN.CreatedAt; //建立时间
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
 /// <param name = "objFR_DependencyPathEN">源简化对象</param>
 public static void AccessFldValueNull(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
try
{
if (objFR_DependencyPathEN.PathString == "[null]") objFR_DependencyPathEN.PathString = null; //路径字符串
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
public static void CheckPropertyNew(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 FR_DependencyPathDA.CheckPropertyNew(objFR_DependencyPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFR_DependencyPathEN objFR_DependencyPathEN)
{
 FR_DependencyPathDA.CheckProperty4Condition(objFR_DependencyPathEN);
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
if (clsFR_DependencyPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFR_DependencyPathBL没有刷新缓存机制(clsFR_DependencyPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFR_DependencyPathObjLstCache == null)
//{
//arrFR_DependencyPathObjLstCache = FR_DependencyPathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_DependencyPathEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFR_DependencyPathEN._CurrTabName);
List<clsFR_DependencyPathEN> arrFR_DependencyPathObjLstCache = GetObjLstCache();
IEnumerable <clsFR_DependencyPathEN> arrFR_DependencyPathObjLst_Sel =
arrFR_DependencyPathObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFR_DependencyPathObjLst_Sel.Count() == 0)
{
   clsFR_DependencyPathEN obj = clsFR_DependencyPathBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFR_DependencyPathObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_DependencyPathEN> GetAllFR_DependencyPathObjLstCache()
{
//获取缓存中的对象列表
List<clsFR_DependencyPathEN> arrFR_DependencyPathObjLstCache = GetObjLstCache(); 
return arrFR_DependencyPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_DependencyPathEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFR_DependencyPathEN._CurrTabName);
List<clsFR_DependencyPathEN> arrFR_DependencyPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFR_DependencyPathObjLstCache;
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
string strKey = string.Format("{0}", clsFR_DependencyPathEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_DependencyPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFR_DependencyPathEN._RefreshTimeLst.Count == 0) return "";
return clsFR_DependencyPathEN._RefreshTimeLst[clsFR_DependencyPathEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFR_DependencyPathBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFR_DependencyPathEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_DependencyPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFR_DependencyPathBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-07-23
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFR_DependencyPath.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFR_DependencyPath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFR_DependencyPath._AttributeName));
throw new Exception(strMsg);
}
var objFR_DependencyPath = clsFR_DependencyPathBL.GetObjBymIdCache(lngmId);
if (objFR_DependencyPath == null) return "";
return objFR_DependencyPath[strOutFldName].ToString();
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
int intRecCount = clsFR_DependencyPathDA.GetRecCount(strTabName);
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
int intRecCount = clsFR_DependencyPathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFR_DependencyPathDA.GetRecCount();
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
int intRecCount = clsFR_DependencyPathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFR_DependencyPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFR_DependencyPathEN objFR_DependencyPathCond)
{
List<clsFR_DependencyPathEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_DependencyPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_DependencyPath._AttributeName)
{
if (objFR_DependencyPathCond.IsUpdated(strFldName) == false) continue;
if (objFR_DependencyPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_DependencyPathCond[strFldName].ToString());
}
else
{
if (objFR_DependencyPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_DependencyPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_DependencyPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_DependencyPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_DependencyPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_DependencyPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_DependencyPathCond[strFldName]));
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
 List<string> arrList = clsFR_DependencyPathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FR_DependencyPathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FR_DependencyPathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FR_DependencyPathDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_DependencyPathDA.SetFldValue(clsFR_DependencyPathEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FR_DependencyPathDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_DependencyPathDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_DependencyPathDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_DependencyPathDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FR_DependencyPath] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key, "); 
 // /**源文件Id*/ 
 strCreateTabCode.Append(" SourceFileId bigint not Null, "); 
 // /**目标文件Id*/ 
 strCreateTabCode.Append(" TargetFileId bigint not Null, "); 
 // /**路径长度*/ 
 strCreateTabCode.Append(" PathLength int not Null, "); 
 // /**路径字符串*/ 
 strCreateTabCode.Append(" PathString varchar(2000) Null, "); 
 // /**是否循环依赖*/ 
 strCreateTabCode.Append(" IsCircular bit Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreatedAt datetime Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// FR_DependencyPath(FR_DependencyPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FR_DependencyPath : clsCommFun4BL
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
clsFR_DependencyPathBL.ReFreshThisCache();
}
}

}