
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureAppTypeRelaBL
 表名:FeatureAppTypeRela(00050430)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFeatureAppTypeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureAppTypeRelaEN GetObj(this K_mId_FeatureAppTypeRela myKey)
{
clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.GetObjBymId(myKey.Value);
return objFeatureAppTypeRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureAppTypeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],功能Id = [{1}]的数据已经存在!(in clsFeatureAppTypeRelaBL.AddNewRecord)", objFeatureAppTypeRelaEN.ApplicationTypeId,objFeatureAppTypeRelaEN.FeatureId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.AddNewRecordBySQL2(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objFeatureAppTypeRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFeatureAppTypeRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(应用程序类型ID(ApplicationTypeId)=[{0}],功能Id(FeatureId)=[{1}])已经存在,不能重复!", objFeatureAppTypeRelaEN.ApplicationTypeId, objFeatureAppTypeRelaEN.FeatureId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFeatureAppTypeRelaEN.AddNewRecord();
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureAppTypeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],功能Id = [{1}]的数据已经存在!(in clsFeatureAppTypeRelaBL.AddNewRecordWithReturnKey)", objFeatureAppTypeRelaEN.ApplicationTypeId,objFeatureAppTypeRelaEN.FeatureId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.AddNewRecordBySQL2WithReturnKey(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetmId(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objFeatureAppTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.mId) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.mId, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.mId] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetApplicationTypeId(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conFeatureAppTypeRela.ApplicationTypeId);
objFeatureAppTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.ApplicationTypeId) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetFeatureId(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFeatureAppTypeRela.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFeatureAppTypeRela.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFeatureAppTypeRela.FeatureId);
}
objFeatureAppTypeRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.FeatureId) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.FeatureId, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.FeatureId] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetOrderNum(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFeatureAppTypeRela.OrderNum);
objFeatureAppTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.OrderNum) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.OrderNum, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.OrderNum] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetInUse(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolInUse, string strComparisonOp="")
	{
objFeatureAppTypeRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.InUse) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.InUse, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.InUse] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetUpdDate(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFeatureAppTypeRela.UpdDate);
}
objFeatureAppTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.UpdDate) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.UpdDate, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.UpdDate] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetUpdUser(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFeatureAppTypeRela.UpdUser);
}
objFeatureAppTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.UpdUser) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.UpdUser, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.UpdUser] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureAppTypeRelaEN SetMemo(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFeatureAppTypeRela.Memo);
}
objFeatureAppTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(conFeatureAppTypeRela.Memo) == false)
{
objFeatureAppTypeRelaEN.dicFldComparisonOp.Add(conFeatureAppTypeRela.Memo, strComparisonOp);
}
else
{
objFeatureAppTypeRelaEN.dicFldComparisonOp[conFeatureAppTypeRela.Memo] = strComparisonOp;
}
}
return objFeatureAppTypeRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFeatureAppTypeRelaEN.CheckPropertyNew();
clsFeatureAppTypeRelaEN objFeatureAppTypeRelaCond = new clsFeatureAppTypeRelaEN();
string strCondition = objFeatureAppTypeRelaCond
.SetmId(objFeatureAppTypeRelaEN.mId, "<>")
.SetApplicationTypeId(objFeatureAppTypeRelaEN.ApplicationTypeId, "=")
.SetFeatureId(objFeatureAppTypeRelaEN.FeatureId, "=")
.GetCombineCondition();
objFeatureAppTypeRelaEN._IsCheckProperty = true;
bool bolIsExist = clsFeatureAppTypeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ApplicationTypeId_FeatureId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFeatureAppTypeRelaEN.Update();
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
 /// <param name = "objFeatureAppTypeRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFeatureAppTypeRelaEN objFeatureAppTypeRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFeatureAppTypeRelaEN objFeatureAppTypeRelaCond = new clsFeatureAppTypeRelaEN();
string strCondition = objFeatureAppTypeRelaCond
.SetApplicationTypeId(objFeatureAppTypeRela.ApplicationTypeId, "=")
.SetFeatureId(objFeatureAppTypeRela.FeatureId, "=")
.GetCombineCondition();
objFeatureAppTypeRela._IsCheckProperty = true;
bool bolIsExist = clsFeatureAppTypeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFeatureAppTypeRela.mId = clsFeatureAppTypeRelaBL.GetFirstID_S(strCondition);
objFeatureAppTypeRela.UpdateWithCondition(strCondition);
}
else
{
objFeatureAppTypeRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 if (objFeatureAppTypeRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.UpdateBySql2(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFeatureAppTypeRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.UpdateBySql2(objFeatureAppTypeRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.UpdateBySqlWithCondition(objFeatureAppTypeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.UpdateBySqlWithConditionTransaction(objFeatureAppTypeRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
public static int Delete(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
try
{
int intRecNum = clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.DelRecord(objFeatureAppTypeRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaENS">源对象</param>
 /// <param name = "objFeatureAppTypeRelaENT">目标对象</param>
 public static void CopyTo(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENS, clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENT)
{
try
{
objFeatureAppTypeRelaENT.mId = objFeatureAppTypeRelaENS.mId; //mId
objFeatureAppTypeRelaENT.ApplicationTypeId = objFeatureAppTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objFeatureAppTypeRelaENT.FeatureId = objFeatureAppTypeRelaENS.FeatureId; //功能Id
objFeatureAppTypeRelaENT.OrderNum = objFeatureAppTypeRelaENS.OrderNum; //序号
objFeatureAppTypeRelaENT.InUse = objFeatureAppTypeRelaENS.InUse; //是否在用
objFeatureAppTypeRelaENT.UpdDate = objFeatureAppTypeRelaENS.UpdDate; //修改日期
objFeatureAppTypeRelaENT.UpdUser = objFeatureAppTypeRelaENS.UpdUser; //修改者
objFeatureAppTypeRelaENT.Memo = objFeatureAppTypeRelaENS.Memo; //说明
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
 /// <param name = "objFeatureAppTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsFeatureAppTypeRelaEN:objFeatureAppTypeRelaENT</returns>
 public static clsFeatureAppTypeRelaEN CopyTo(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENS)
{
try
{
 clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENT = new clsFeatureAppTypeRelaEN()
{
mId = objFeatureAppTypeRelaENS.mId, //mId
ApplicationTypeId = objFeatureAppTypeRelaENS.ApplicationTypeId, //应用程序类型ID
FeatureId = objFeatureAppTypeRelaENS.FeatureId, //功能Id
OrderNum = objFeatureAppTypeRelaENS.OrderNum, //序号
InUse = objFeatureAppTypeRelaENS.InUse, //是否在用
UpdDate = objFeatureAppTypeRelaENS.UpdDate, //修改日期
UpdUser = objFeatureAppTypeRelaENS.UpdUser, //修改者
Memo = objFeatureAppTypeRelaENS.Memo, //说明
};
 return objFeatureAppTypeRelaENT;
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
public static void CheckPropertyNew(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.CheckPropertyNew(objFeatureAppTypeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 clsFeatureAppTypeRelaBL.FeatureAppTypeRelaDA.CheckProperty4Condition(objFeatureAppTypeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.mId) == true)
{
string strComparisonOpmId = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureAppTypeRela.mId, objFeatureAppTypeRelaCond.mId, strComparisonOpmId);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureAppTypeRela.ApplicationTypeId, objFeatureAppTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureAppTypeRela.FeatureId, objFeatureAppTypeRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureAppTypeRela.OrderNum, objFeatureAppTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.InUse) == true)
{
if (objFeatureAppTypeRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFeatureAppTypeRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFeatureAppTypeRela.InUse);
}
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureAppTypeRela.UpdDate, objFeatureAppTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureAppTypeRela.UpdUser, objFeatureAppTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFeatureAppTypeRelaCond.IsUpdated(conFeatureAppTypeRela.Memo) == true)
{
string strComparisonOpMemo = objFeatureAppTypeRelaCond.dicFldComparisonOp[conFeatureAppTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureAppTypeRela.Memo, objFeatureAppTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FeatureAppTypeRela(功能应用关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeId_FeatureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFeatureAppTypeRelaEN == null) return true;
if (objFeatureAppTypeRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureAppTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureAppTypeRelaEN.FeatureId);
if (clsFeatureAppTypeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFeatureAppTypeRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureAppTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureAppTypeRelaEN.FeatureId);
if (clsFeatureAppTypeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FeatureAppTypeRela(功能应用关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_FeatureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFeatureAppTypeRelaEN == null) return "";
if (objFeatureAppTypeRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureAppTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureAppTypeRelaEN.FeatureId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFeatureAppTypeRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureAppTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureAppTypeRelaEN.FeatureId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FeatureAppTypeRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能应用关系(FeatureAppTypeRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFeatureAppTypeRelaBL
{
public static RelatedActions_FeatureAppTypeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFeatureAppTypeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFeatureAppTypeRelaDA FeatureAppTypeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFeatureAppTypeRelaDA();
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
 public clsFeatureAppTypeRelaBL()
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
if (string.IsNullOrEmpty(clsFeatureAppTypeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFeatureAppTypeRelaEN._ConnectString);
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
public static DataTable GetDataTable_FeatureAppTypeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FeatureAppTypeRelaDA.GetDataTable_FeatureAppTypeRela(strWhereCond);
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
objDT = FeatureAppTypeRelaDA.GetDataTable(strWhereCond);
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
objDT = FeatureAppTypeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FeatureAppTypeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FeatureAppTypeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FeatureAppTypeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = FeatureAppTypeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FeatureAppTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FeatureAppTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFeatureAppTypeRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
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
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFeatureAppTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFeatureAppTypeRelaEN._CurrTabName);
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLst_Sel =
arrFeatureAppTypeRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFeatureAppTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetObjLst(string strWhereCond)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
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
public static List<clsFeatureAppTypeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFeatureAppTypeRelaEN> GetSubObjLstCache(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaCond)
{
List<clsFeatureAppTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureAppTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureAppTypeRela._AttributeName)
{
if (objFeatureAppTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objFeatureAppTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureAppTypeRelaCond[strFldName].ToString());
}
else
{
if (objFeatureAppTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureAppTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureAppTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureAppTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureAppTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureAppTypeRelaCond[strFldName]));
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
public static List<clsFeatureAppTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
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
public static List<clsFeatureAppTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
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
List<clsFeatureAppTypeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFeatureAppTypeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFeatureAppTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
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
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
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
public static List<clsFeatureAppTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFeatureAppTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
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
public static List<clsFeatureAppTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFeatureAppTypeRelaEN> arrObjLst = new List<clsFeatureAppTypeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = new clsFeatureAppTypeRelaEN();
try
{
objFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[conFeatureAppTypeRela.mId].ToString().Trim()); //mId
objFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFeatureAppTypeRelaEN.FeatureId = objRow[conFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[conFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objFeatureAppTypeRelaEN.UpdDate = objRow[conFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureAppTypeRelaEN.UpdUser = objRow[conFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureAppTypeRelaEN.Memo = objRow[conFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureAppTypeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFeatureAppTypeRela(ref clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
bool bolResult = FeatureAppTypeRelaDA.GetFeatureAppTypeRela(ref objFeatureAppTypeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureAppTypeRelaEN GetObjBymId(long lngmId)
{
clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = FeatureAppTypeRelaDA.GetObjBymId(lngmId);
return objFeatureAppTypeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFeatureAppTypeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = FeatureAppTypeRelaDA.GetFirstObj(strWhereCond);
 return objFeatureAppTypeRelaEN;
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
public static clsFeatureAppTypeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = FeatureAppTypeRelaDA.GetObjByDataRow(objRow);
 return objFeatureAppTypeRelaEN;
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
public static clsFeatureAppTypeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = FeatureAppTypeRelaDA.GetObjByDataRow(objRow);
 return objFeatureAppTypeRelaEN;
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
 /// <param name = "lstFeatureAppTypeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureAppTypeRelaEN GetObjBymIdFromList(long lngmId, List<clsFeatureAppTypeRelaEN> lstFeatureAppTypeRelaObjLst)
{
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN in lstFeatureAppTypeRelaObjLst)
{
if (objFeatureAppTypeRelaEN.mId == lngmId)
{
return objFeatureAppTypeRelaEN;
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
 lngmId = new clsFeatureAppTypeRelaDA().GetFirstID(strWhereCond);
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
 arrList = FeatureAppTypeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = FeatureAppTypeRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FeatureAppTypeRelaDA.IsExist(lngmId);
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
clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);
objFeatureAppTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFeatureAppTypeRelaEN.UpdUser = strOpUser;
return clsFeatureAppTypeRelaBL.UpdateBySql2(objFeatureAppTypeRelaEN);
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
 bolIsExist = clsFeatureAppTypeRelaDA.IsExistTable();
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
 bolIsExist = FeatureAppTypeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureAppTypeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],功能Id = [{1}]的数据已经存在!(in clsFeatureAppTypeRelaBL.AddNewRecordBySql2)", objFeatureAppTypeRelaEN.ApplicationTypeId,objFeatureAppTypeRelaEN.FeatureId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FeatureAppTypeRelaDA.AddNewRecordBySQL2(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureAppTypeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],功能Id = [{1}]的数据已经存在!(in clsFeatureAppTypeRelaBL.AddNewRecordBySql2WithReturnKey)", objFeatureAppTypeRelaEN.ApplicationTypeId,objFeatureAppTypeRelaEN.FeatureId);
throw new Exception(strMsg);
}
try
{
string strKey = FeatureAppTypeRelaDA.AddNewRecordBySQL2WithReturnKey(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
try
{
bool bolResult = FeatureAppTypeRelaDA.Update(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 /// <param name = "objFeatureAppTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 if (objFeatureAppTypeRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FeatureAppTypeRelaDA.UpdateBySql2(objFeatureAppTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureAppTypeRelaBL.ReFreshCache();

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
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
 clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);

if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(objFeatureAppTypeRelaEN.mId, objFeatureAppTypeRelaEN.UpdUser);
}
if (objFeatureAppTypeRelaEN != null)
{
int intRecNum = FeatureAppTypeRelaDA.DelRecord(lngmId);
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
objSQL = clsFeatureAppTypeRelaDA.GetSpecSQLObj();
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
//删除与表:[FeatureAppTypeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFeatureAppTypeRela.mId,
//lngmId);
//        clsFeatureAppTypeRelaBL.DelFeatureAppTypeRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureAppTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureAppTypeRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FeatureAppTypeRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFeatureAppTypeRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FeatureAppTypeRelaDA.DelFeatureAppTypeRela(arrmIdLst);
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
public static int DelFeatureAppTypeRelasByCond(string strWhereCond)
{
try
{
if (clsFeatureAppTypeRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFeatureAppTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FeatureAppTypeRelaDA.DelFeatureAppTypeRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FeatureAppTypeRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFeatureAppTypeRelaDA.GetSpecSQLObj();
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
//删除与表:[FeatureAppTypeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureAppTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureAppTypeRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFeatureAppTypeRelaENS">源对象</param>
 /// <param name = "objFeatureAppTypeRelaENT">目标对象</param>
 public static void CopyTo(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENS, clsFeatureAppTypeRelaEN objFeatureAppTypeRelaENT)
{
try
{
objFeatureAppTypeRelaENT.mId = objFeatureAppTypeRelaENS.mId; //mId
objFeatureAppTypeRelaENT.ApplicationTypeId = objFeatureAppTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objFeatureAppTypeRelaENT.FeatureId = objFeatureAppTypeRelaENS.FeatureId; //功能Id
objFeatureAppTypeRelaENT.OrderNum = objFeatureAppTypeRelaENS.OrderNum; //序号
objFeatureAppTypeRelaENT.InUse = objFeatureAppTypeRelaENS.InUse; //是否在用
objFeatureAppTypeRelaENT.UpdDate = objFeatureAppTypeRelaENS.UpdDate; //修改日期
objFeatureAppTypeRelaENT.UpdUser = objFeatureAppTypeRelaENS.UpdUser; //修改者
objFeatureAppTypeRelaENT.Memo = objFeatureAppTypeRelaENS.Memo; //说明
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
 /// <param name = "objFeatureAppTypeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
try
{
objFeatureAppTypeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFeatureAppTypeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFeatureAppTypeRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.mId = objFeatureAppTypeRelaEN.mId; //mId
}
if (arrFldSet.Contains(conFeatureAppTypeRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.ApplicationTypeId = objFeatureAppTypeRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conFeatureAppTypeRela.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.FeatureId = objFeatureAppTypeRelaEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conFeatureAppTypeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.OrderNum = objFeatureAppTypeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFeatureAppTypeRela.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.InUse = objFeatureAppTypeRelaEN.InUse; //是否在用
}
if (arrFldSet.Contains(conFeatureAppTypeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.UpdDate = objFeatureAppTypeRelaEN.UpdDate == "[null]" ? null :  objFeatureAppTypeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFeatureAppTypeRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.UpdUser = objFeatureAppTypeRelaEN.UpdUser == "[null]" ? null :  objFeatureAppTypeRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFeatureAppTypeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureAppTypeRelaEN.Memo = objFeatureAppTypeRelaEN.Memo == "[null]" ? null :  objFeatureAppTypeRelaEN.Memo; //说明
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
 /// <param name = "objFeatureAppTypeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
try
{
if (objFeatureAppTypeRelaEN.UpdDate == "[null]") objFeatureAppTypeRelaEN.UpdDate = null; //修改日期
if (objFeatureAppTypeRelaEN.UpdUser == "[null]") objFeatureAppTypeRelaEN.UpdUser = null; //修改者
if (objFeatureAppTypeRelaEN.Memo == "[null]") objFeatureAppTypeRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 FeatureAppTypeRelaDA.CheckPropertyNew(objFeatureAppTypeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
 FeatureAppTypeRelaDA.CheckProperty4Condition(objFeatureAppTypeRelaEN);
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
if (clsFeatureAppTypeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureAppTypeRelaBL没有刷新缓存机制(clsFeatureAppTypeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFeatureAppTypeRelaObjLstCache == null)
//{
//arrFeatureAppTypeRelaObjLstCache = FeatureAppTypeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureAppTypeRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFeatureAppTypeRelaEN._CurrTabName);
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLst_Sel =
arrFeatureAppTypeRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFeatureAppTypeRelaObjLst_Sel.Count() == 0)
{
   clsFeatureAppTypeRelaEN obj = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFeatureAppTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetAllFeatureAppTypeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLstCache = GetObjLstCache(); 
return arrFeatureAppTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureAppTypeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFeatureAppTypeRelaEN._CurrTabName);
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFeatureAppTypeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsFeatureAppTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFeatureAppTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFeatureAppTypeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsFeatureAppTypeRelaEN._RefreshTimeLst[clsFeatureAppTypeRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFeatureAppTypeRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFeatureAppTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFeatureAppTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFeatureAppTypeRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FeatureAppTypeRela(功能应用关系)
 /// 唯一性条件:ApplicationTypeId_FeatureId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaEN)
{
//检测记录是否存在
string strResult = FeatureAppTypeRelaDA.GetUniCondStr(objFeatureAppTypeRelaEN);
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
if (strInFldName != conFeatureAppTypeRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFeatureAppTypeRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFeatureAppTypeRela._AttributeName));
throw new Exception(strMsg);
}
var objFeatureAppTypeRela = clsFeatureAppTypeRelaBL.GetObjBymIdCache(lngmId);
if (objFeatureAppTypeRela == null) return "";
return objFeatureAppTypeRela[strOutFldName].ToString();
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
int intRecCount = clsFeatureAppTypeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsFeatureAppTypeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFeatureAppTypeRelaDA.GetRecCount();
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
int intRecCount = clsFeatureAppTypeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFeatureAppTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFeatureAppTypeRelaEN objFeatureAppTypeRelaCond)
{
List<clsFeatureAppTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFeatureAppTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureAppTypeRela._AttributeName)
{
if (objFeatureAppTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objFeatureAppTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureAppTypeRelaCond[strFldName].ToString());
}
else
{
if (objFeatureAppTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureAppTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureAppTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureAppTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureAppTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureAppTypeRelaCond[strFldName]));
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
 List<string> arrList = clsFeatureAppTypeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FeatureAppTypeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FeatureAppTypeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FeatureAppTypeRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureAppTypeRelaDA.SetFldValue(clsFeatureAppTypeRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FeatureAppTypeRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureAppTypeRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureAppTypeRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureAppTypeRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FeatureAppTypeRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
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


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(int intApplicationTypeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjList = new clsFeatureAppTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRela in arrFeatureAppTypeRelaObjList)
{
objFeatureAppTypeRela.OrderNum = intIndex;
UpdateBySql2(objFeatureAppTypeRela);
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
/// 调整所给关键字记录的序号。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,int intApplicationTypeId)
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

clsFeatureAppTypeRelaEN objFeatureAppTypeRela = clsFeatureAppTypeRelaBL.GetObjBymId(lngmId);

intOrderNum = objFeatureAppTypeRela.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);
intTabRecNum = clsFeatureAppTypeRelaBL.GetRecCountByCond(clsFeatureAppTypeRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conFeatureAppTypeRela.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsFeatureAppTypeRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsFeatureAppTypeRelaBL.SetFldValue(clsFeatureAppTypeRelaEN._CurrTabName, conFeatureAppTypeRela.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conFeatureAppTypeRela.mId, lngmId));
clsFeatureAppTypeRelaBL.SetFldValue(clsFeatureAppTypeRelaEN._CurrTabName, conFeatureAppTypeRela.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFeatureAppTypeRela.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conFeatureAppTypeRela.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);

lngNextmId = clsFeatureAppTypeRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsFeatureAppTypeRelaBL.SetFldValue(clsFeatureAppTypeRelaEN._CurrTabName, conFeatureAppTypeRela.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFeatureAppTypeRela.mId, lngmId));
clsFeatureAppTypeRelaBL.SetFldValue(clsFeatureAppTypeRelaEN._CurrTabName, conFeatureAppTypeRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conFeatureAppTypeRela.mId, lngNextmId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,int intApplicationTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conFeatureAppTypeRela.mId, strKeyList);
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaLst = GetObjLst(strCondition);
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRela in arrFeatureAppTypeRelaLst)
{
objFeatureAppTypeRela.OrderNum = objFeatureAppTypeRela.OrderNum + 10000;
UpdateBySql2(objFeatureAppTypeRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjList = new clsFeatureAppTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRela in arrFeatureAppTypeRelaObjList)
{
objFeatureAppTypeRela.OrderNum = intIndex;
UpdateBySql2(objFeatureAppTypeRela);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,int intApplicationTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conFeatureAppTypeRela.mId, strKeyList);
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaLst = GetObjLst(strCondition);
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRela in arrFeatureAppTypeRelaLst)
{
objFeatureAppTypeRela.OrderNum = objFeatureAppTypeRela.OrderNum - 10000;
UpdateBySql2(objFeatureAppTypeRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureAppTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsFeatureAppTypeRelaEN> arrFeatureAppTypeRelaObjList = new clsFeatureAppTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureAppTypeRelaEN objFeatureAppTypeRela in arrFeatureAppTypeRelaObjList)
{
objFeatureAppTypeRela.OrderNum = intIndex;
UpdateBySql2(objFeatureAppTypeRela);
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
 /// 功能应用关系(FeatureAppTypeRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FeatureAppTypeRela : clsCommFun4BL
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
clsFeatureAppTypeRelaBL.ReFreshThisCache();
}
}

}