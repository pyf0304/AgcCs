
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRegionTypeBL
 表名:RegionType(00050081)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsRegionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRegionTypeEN GetObj(this K_RegionTypeId_RegionType myKey)
{
clsRegionTypeEN objRegionTypeEN = clsRegionTypeBL.RegionTypeDA.GetObjByRegionTypeId(myKey.Value);
return objRegionTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRegionTypeEN objRegionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRegionTypeBL.IsExist(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objRegionTypeEN.RegionTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsRegionTypeBL.RegionTypeDA.AddNewRecordBySQL2(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsRegionTypeEN objRegionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsRegionTypeBL.IsExist(objRegionTypeEN.RegionTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objRegionTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objRegionTypeEN.AddNewRecord();
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRegionTypeEN objRegionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRegionTypeBL.IsExist(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objRegionTypeEN.RegionTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsRegionTypeBL.RegionTypeDA.AddNewRecordBySQL2WithReturnKey(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetRegionTypeId(this clsRegionTypeEN objRegionTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conRegionType.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conRegionType.RegionTypeId);
}
objRegionTypeEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.RegionTypeId) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.RegionTypeId, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.RegionTypeId] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetRegionTypeName(this clsRegionTypeEN objRegionTypeEN, string strRegionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeName, conRegionType.RegionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeName, 30, conRegionType.RegionTypeName);
}
objRegionTypeEN.RegionTypeName = strRegionTypeName; //区域类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.RegionTypeName) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.RegionTypeName, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.RegionTypeName] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetRegionTypeENName(this clsRegionTypeEN objRegionTypeEN, string strRegionTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeENName, 30, conRegionType.RegionTypeENName);
}
objRegionTypeEN.RegionTypeENName = strRegionTypeENName; //区域类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.RegionTypeENName) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.RegionTypeENName, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.RegionTypeENName] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetRegionTypeSimName(this clsRegionTypeEN objRegionTypeEN, string strRegionTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeSimName, 10, conRegionType.RegionTypeSimName);
}
objRegionTypeEN.RegionTypeSimName = strRegionTypeSimName; //区域类型简名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.RegionTypeSimName) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.RegionTypeSimName, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.RegionTypeSimName] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetDefaWidth(this clsRegionTypeEN objRegionTypeEN, int? intDefaWidth, string strComparisonOp="")
	{
objRegionTypeEN.DefaWidth = intDefaWidth; //缺省宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.DefaWidth) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.DefaWidth, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.DefaWidth] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetRegionTypeOrderNum(this clsRegionTypeEN objRegionTypeEN, int? intRegionTypeOrderNum, string strComparisonOp="")
	{
objRegionTypeEN.RegionTypeOrderNum = intRegionTypeOrderNum; //区域类型序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.RegionTypeOrderNum) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.RegionTypeOrderNum, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.RegionTypeOrderNum] = strComparisonOp;
}
}
return objRegionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRegionTypeEN SetMemo(this clsRegionTypeEN objRegionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRegionType.Memo);
}
objRegionTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRegionTypeEN.dicFldComparisonOp.ContainsKey(conRegionType.Memo) == false)
{
objRegionTypeEN.dicFldComparisonOp.Add(conRegionType.Memo, strComparisonOp);
}
else
{
objRegionTypeEN.dicFldComparisonOp[conRegionType.Memo] = strComparisonOp;
}
}
return objRegionTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRegionTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRegionTypeEN objRegionTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRegionTypeEN.CheckPropertyNew();
clsRegionTypeEN objRegionTypeCond = new clsRegionTypeEN();
string strCondition = objRegionTypeCond
.SetRegionTypeId(objRegionTypeEN.RegionTypeId, "=")
.GetCombineCondition();
objRegionTypeEN._IsCheckProperty = true;
bool bolIsExist = clsRegionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRegionTypeEN.Update();
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRegionTypeEN objRegionTypeEN)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRegionTypeBL.RegionTypeDA.UpdateBySql2(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRegionTypeEN objRegionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRegionTypeBL.RegionTypeDA.UpdateBySql2(objRegionTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRegionTypeEN objRegionTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsRegionTypeBL.RegionTypeDA.UpdateBySqlWithCondition(objRegionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRegionTypeEN objRegionTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRegionTypeBL.RegionTypeDA.UpdateBySqlWithConditionTransaction(objRegionTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "strRegionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsRegionTypeEN objRegionTypeEN)
{
try
{
int intRecNum = clsRegionTypeBL.RegionTypeDA.DelRecord(objRegionTypeEN.RegionTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
 public static void CopyTo(this clsRegionTypeEN objRegionTypeENS, clsRegionTypeEN objRegionTypeENT)
{
try
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
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
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <returns>目标对象=>clsRegionTypeEN:objRegionTypeENT</returns>
 public static clsRegionTypeEN CopyTo(this clsRegionTypeEN objRegionTypeENS)
{
try
{
 clsRegionTypeEN objRegionTypeENT = new clsRegionTypeEN()
{
RegionTypeId = objRegionTypeENS.RegionTypeId, //区域类型Id
RegionTypeName = objRegionTypeENS.RegionTypeName, //区域类型名称
RegionTypeENName = objRegionTypeENS.RegionTypeENName, //区域类型英文名
RegionTypeSimName = objRegionTypeENS.RegionTypeSimName, //区域类型简名
DefaWidth = objRegionTypeENS.DefaWidth, //缺省宽度
RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum, //区域类型序号
Memo = objRegionTypeENS.Memo, //说明
};
 return objRegionTypeENT;
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
public static void CheckPropertyNew(this clsRegionTypeEN objRegionTypeEN)
{
 clsRegionTypeBL.RegionTypeDA.CheckPropertyNew(objRegionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRegionTypeEN objRegionTypeEN)
{
 clsRegionTypeBL.RegionTypeDA.CheckProperty4Condition(objRegionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRegionTypeEN objRegionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRegionTypeCond.IsUpdated(conRegionType.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objRegionTypeCond.dicFldComparisonOp[conRegionType.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRegionType.RegionTypeId, objRegionTypeCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objRegionTypeCond.IsUpdated(conRegionType.RegionTypeName) == true)
{
string strComparisonOpRegionTypeName = objRegionTypeCond.dicFldComparisonOp[conRegionType.RegionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRegionType.RegionTypeName, objRegionTypeCond.RegionTypeName, strComparisonOpRegionTypeName);
}
if (objRegionTypeCond.IsUpdated(conRegionType.RegionTypeENName) == true)
{
string strComparisonOpRegionTypeENName = objRegionTypeCond.dicFldComparisonOp[conRegionType.RegionTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRegionType.RegionTypeENName, objRegionTypeCond.RegionTypeENName, strComparisonOpRegionTypeENName);
}
if (objRegionTypeCond.IsUpdated(conRegionType.RegionTypeSimName) == true)
{
string strComparisonOpRegionTypeSimName = objRegionTypeCond.dicFldComparisonOp[conRegionType.RegionTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRegionType.RegionTypeSimName, objRegionTypeCond.RegionTypeSimName, strComparisonOpRegionTypeSimName);
}
if (objRegionTypeCond.IsUpdated(conRegionType.DefaWidth) == true)
{
string strComparisonOpDefaWidth = objRegionTypeCond.dicFldComparisonOp[conRegionType.DefaWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conRegionType.DefaWidth, objRegionTypeCond.DefaWidth, strComparisonOpDefaWidth);
}
if (objRegionTypeCond.IsUpdated(conRegionType.RegionTypeOrderNum) == true)
{
string strComparisonOpRegionTypeOrderNum = objRegionTypeCond.dicFldComparisonOp[conRegionType.RegionTypeOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conRegionType.RegionTypeOrderNum, objRegionTypeCond.RegionTypeOrderNum, strComparisonOpRegionTypeOrderNum);
}
if (objRegionTypeCond.IsUpdated(conRegionType.Memo) == true)
{
string strComparisonOpMemo = objRegionTypeCond.dicFldComparisonOp[conRegionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRegionType.Memo, objRegionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RegionType
{
public virtual bool UpdRelaTabDate(string strRegionTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumRegionType
{
 /// <summary>
 /// 未知区域
 /// </summary>
public const string Unknown_0000 = "0000";
 /// <summary>
 /// 查询区域
 /// </summary>
public const string QueryRegion_0001 = "0001";
 /// <summary>
 /// 列表区域
 /// </summary>
public const string ListRegion_0002 = "0002";
 /// <summary>
 /// 编辑区域
 /// </summary>
public const string EditRegion_0003 = "0003";
 /// <summary>
 /// 树形区域
 /// </summary>
public const string TreeViewRegion_0005 = "0005";
 /// <summary>
 /// 详细信息区域
 /// </summary>
public const string DetailRegion_0006 = "0006";
 /// <summary>
 /// Excel导出区域
 /// </summary>
public const string ExcelExportRegion_0007 = "0007";
 /// <summary>
 /// 功能区域
 /// </summary>
public const string FeatureRegion_0008 = "0008";
}
 /// <summary>
 /// 区域类型(RegionType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRegionTypeBL
{
public static RelatedActions_RegionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRegionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRegionTypeDA RegionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRegionTypeDA();
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
 public clsRegionTypeBL()
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
if (string.IsNullOrEmpty(clsRegionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRegionTypeEN._ConnectString);
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
public static DataTable GetDataTable_RegionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RegionTypeDA.GetDataTable_RegionType(strWhereCond);
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
objDT = RegionTypeDA.GetDataTable(strWhereCond);
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
objDT = RegionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RegionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RegionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RegionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = RegionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RegionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RegionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRegionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsRegionTypeEN> GetObjLstByRegionTypeIdLst(List<string> arrRegionTypeIdLst)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRegionTypeIdLst, true);
 string strWhereCond = string.Format("RegionTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRegionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRegionTypeEN> GetObjLstByRegionTypeIdLstCache(List<string> arrRegionTypeIdLst)
{
string strKey = string.Format("{0}", clsRegionTypeEN._CurrTabName);
List<clsRegionTypeEN> arrRegionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsRegionTypeEN> arrRegionTypeObjLst_Sel =
arrRegionTypeObjLstCache
.Where(x => arrRegionTypeIdLst.Contains(x.RegionTypeId));
return arrRegionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRegionTypeEN> GetObjLst(string strWhereCond)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
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
public static List<clsRegionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRegionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRegionTypeEN> GetSubObjLstCache(clsRegionTypeEN objRegionTypeCond)
{
List<clsRegionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRegionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRegionType._AttributeName)
{
if (objRegionTypeCond.IsUpdated(strFldName) == false) continue;
if (objRegionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRegionTypeCond[strFldName].ToString());
}
else
{
if (objRegionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRegionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRegionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRegionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRegionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRegionTypeCond[strFldName]));
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
public static List<clsRegionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
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
public static List<clsRegionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
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
List<clsRegionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRegionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRegionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRegionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
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
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
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
public static List<clsRegionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRegionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRegionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
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
public static List<clsRegionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRegionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRegionTypeEN> arrObjLst = new List<clsRegionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN();
try
{
objRegionTypeEN.RegionTypeId = objRow[conRegionType.RegionTypeId].ToString().Trim(); //区域类型Id
objRegionTypeEN.RegionTypeName = objRow[conRegionType.RegionTypeName].ToString().Trim(); //区域类型名称
objRegionTypeEN.RegionTypeENName = objRow[conRegionType.RegionTypeENName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeENName].ToString().Trim(); //区域类型英文名
objRegionTypeEN.RegionTypeSimName = objRow[conRegionType.RegionTypeSimName] == DBNull.Value ? null : objRow[conRegionType.RegionTypeSimName].ToString().Trim(); //区域类型简名
objRegionTypeEN.DefaWidth = objRow[conRegionType.DefaWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.DefaWidth].ToString().Trim()); //缺省宽度
objRegionTypeEN.RegionTypeOrderNum = objRow[conRegionType.RegionTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRegionType.RegionTypeOrderNum].ToString().Trim()); //区域类型序号
objRegionTypeEN.Memo = objRow[conRegionType.Memo] == DBNull.Value ? null : objRow[conRegionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRegionTypeEN.RegionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRegionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRegionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRegionType(ref clsRegionTypeEN objRegionTypeEN)
{
bool bolResult = RegionTypeDA.GetRegionType(ref objRegionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRegionTypeEN GetObjByRegionTypeId(string strRegionTypeId)
{
if (strRegionTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRegionTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRegionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRegionTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsRegionTypeEN objRegionTypeEN = RegionTypeDA.GetObjByRegionTypeId(strRegionTypeId);
return objRegionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRegionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRegionTypeEN objRegionTypeEN = RegionTypeDA.GetFirstObj(strWhereCond);
 return objRegionTypeEN;
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
public static clsRegionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRegionTypeEN objRegionTypeEN = RegionTypeDA.GetObjByDataRow(objRow);
 return objRegionTypeEN;
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
public static clsRegionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRegionTypeEN objRegionTypeEN = RegionTypeDA.GetObjByDataRow(objRow);
 return objRegionTypeEN;
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
 /// <param name = "strRegionTypeId">所给的关键字</param>
 /// <param name = "lstRegionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRegionTypeEN GetObjByRegionTypeIdFromList(string strRegionTypeId, List<clsRegionTypeEN> lstRegionTypeObjLst)
{
foreach (clsRegionTypeEN objRegionTypeEN in lstRegionTypeObjLst)
{
if (objRegionTypeEN.RegionTypeId == strRegionTypeId)
{
return objRegionTypeEN;
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
 string strRegionTypeId;
 try
 {
 strRegionTypeId = new clsRegionTypeDA().GetFirstID(strWhereCond);
 return strRegionTypeId;
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
 arrList = RegionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = RegionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRegionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRegionTypeId)
{
if (string.IsNullOrEmpty(strRegionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRegionTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = RegionTypeDA.IsExist(strRegionTypeId);
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
 bolIsExist = clsRegionTypeDA.IsExistTable();
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
 bolIsExist = RegionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRegionTypeEN objRegionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRegionTypeBL.IsExist(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objRegionTypeEN.RegionTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = RegionTypeDA.AddNewRecordBySQL2(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRegionTypeEN objRegionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRegionTypeBL.IsExist(objRegionTypeEN.RegionTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objRegionTypeEN.RegionTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = RegionTypeDA.AddNewRecordBySQL2WithReturnKey(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRegionTypeEN objRegionTypeEN)
{
try
{
bool bolResult = RegionTypeDA.Update(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "objRegionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRegionTypeEN objRegionTypeEN)
{
 if (string.IsNullOrEmpty(objRegionTypeEN.RegionTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RegionTypeDA.UpdateBySql2(objRegionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRegionTypeBL.ReFreshCache();

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
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
 /// <param name = "strRegionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRegionTypeId)
{
try
{
 clsRegionTypeEN objRegionTypeEN = clsRegionTypeBL.GetObjByRegionTypeId(strRegionTypeId);

if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionTypeEN.RegionTypeId, "SetUpdDate");
}
if (objRegionTypeEN != null)
{
int intRecNum = RegionTypeDA.DelRecord(strRegionTypeId);
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
/// <param name="strRegionTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRegionTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRegionTypeDA.GetSpecSQLObj();
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
//删除与表:[RegionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRegionType.RegionTypeId,
//strRegionTypeId);
//        clsRegionTypeBL.DelRegionTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRegionTypeBL.DelRecord(strRegionTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRegionTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRegionTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRegionTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(strRegionTypeId, "UpdRelaTabDate");
}
bool bolResult = RegionTypeDA.DelRecord(strRegionTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRegionTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRegionTypes(List<string> arrRegionTypeIdLst)
{
if (arrRegionTypeIdLst.Count == 0) return 0;
try
{
if (clsRegionTypeBL.relatedActions != null)
{
foreach (var strRegionTypeId in arrRegionTypeIdLst)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(strRegionTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = RegionTypeDA.DelRegionType(arrRegionTypeIdLst);
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
public static int DelRegionTypesByCond(string strWhereCond)
{
try
{
if (clsRegionTypeBL.relatedActions != null)
{
List<string> arrRegionTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRegionTypeId in arrRegionTypeId)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(strRegionTypeId, "UpdRelaTabDate");
}
}
int intRecNum = RegionTypeDA.DelRegionType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RegionType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRegionTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRegionTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRegionTypeDA.GetSpecSQLObj();
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
//删除与表:[RegionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRegionTypeBL.DelRecord(strRegionTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRegionTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objRegionTypeENS">源对象</param>
 /// <param name = "objRegionTypeENT">目标对象</param>
 public static void CopyTo(clsRegionTypeEN objRegionTypeENS, clsRegionTypeEN objRegionTypeENT)
{
try
{
objRegionTypeENT.RegionTypeId = objRegionTypeENS.RegionTypeId; //区域类型Id
objRegionTypeENT.RegionTypeName = objRegionTypeENS.RegionTypeName; //区域类型名称
objRegionTypeENT.RegionTypeENName = objRegionTypeENS.RegionTypeENName; //区域类型英文名
objRegionTypeENT.RegionTypeSimName = objRegionTypeENS.RegionTypeSimName; //区域类型简名
objRegionTypeENT.DefaWidth = objRegionTypeENS.DefaWidth; //缺省宽度
objRegionTypeENT.RegionTypeOrderNum = objRegionTypeENS.RegionTypeOrderNum; //区域类型序号
objRegionTypeENT.Memo = objRegionTypeENS.Memo; //说明
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
 /// <param name = "objRegionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsRegionTypeEN objRegionTypeEN)
{
try
{
objRegionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRegionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRegionType.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.RegionTypeId = objRegionTypeEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conRegionType.RegionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.RegionTypeName = objRegionTypeEN.RegionTypeName; //区域类型名称
}
if (arrFldSet.Contains(conRegionType.RegionTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.RegionTypeENName = objRegionTypeEN.RegionTypeENName == "[null]" ? null :  objRegionTypeEN.RegionTypeENName; //区域类型英文名
}
if (arrFldSet.Contains(conRegionType.RegionTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.RegionTypeSimName = objRegionTypeEN.RegionTypeSimName == "[null]" ? null :  objRegionTypeEN.RegionTypeSimName; //区域类型简名
}
if (arrFldSet.Contains(conRegionType.DefaWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.DefaWidth = objRegionTypeEN.DefaWidth; //缺省宽度
}
if (arrFldSet.Contains(conRegionType.RegionTypeOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.RegionTypeOrderNum = objRegionTypeEN.RegionTypeOrderNum; //区域类型序号
}
if (arrFldSet.Contains(conRegionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRegionTypeEN.Memo = objRegionTypeEN.Memo == "[null]" ? null :  objRegionTypeEN.Memo; //说明
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
 /// <param name = "objRegionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsRegionTypeEN objRegionTypeEN)
{
try
{
if (objRegionTypeEN.RegionTypeENName == "[null]") objRegionTypeEN.RegionTypeENName = null; //区域类型英文名
if (objRegionTypeEN.RegionTypeSimName == "[null]") objRegionTypeEN.RegionTypeSimName = null; //区域类型简名
if (objRegionTypeEN.Memo == "[null]") objRegionTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsRegionTypeEN objRegionTypeEN)
{
 RegionTypeDA.CheckPropertyNew(objRegionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRegionTypeEN objRegionTypeEN)
{
 RegionTypeDA.CheckProperty4Condition(objRegionTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RegionTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conRegionType.RegionTypeId); 
List<clsRegionTypeEN> arrObjLst = clsRegionTypeBL.GetObjLst(strCondition).OrderBy(x=>x.RegionTypeOrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsRegionTypeEN objRegionTypeEN = new clsRegionTypeEN()
{
RegionTypeId = "0",
RegionTypeName = "选[区域类型]..."
};
arrObjLst.Insert(0, objRegionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conRegionType.RegionTypeId;
objComboBox.DisplayMember = conRegionType.RegionTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RegionTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[区域类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conRegionType.RegionTypeId); 
IEnumerable<clsRegionTypeEN> arrObjLst = clsRegionTypeBL.GetObjLst(strCondition).OrderBy(x=>x.RegionTypeOrderNum);
objDDL.DataValueField = conRegionType.RegionTypeId;
objDDL.DataTextField = conRegionType.RegionTypeName;
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
public static void BindDdl_RegionTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[区域类型]...","0");
List<clsRegionTypeEN> arrRegionTypeObjLst = GetAllRegionTypeObjLstCache(); 
arrRegionTypeObjLst = arrRegionTypeObjLst.OrderBy(x=>x.RegionTypeOrderNum).ToList(); 
objDDL.DataValueField = conRegionType.RegionTypeId;
objDDL.DataTextField = conRegionType.RegionTypeName;
objDDL.DataSource = arrRegionTypeObjLst;
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
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RegionTypeId");
//if (arrRegionTypeObjLstCache == null)
//{
//arrRegionTypeObjLstCache = RegionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRegionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRegionTypeEN GetObjByRegionTypeIdCache(string strRegionTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRegionTypeEN._CurrTabName);
List<clsRegionTypeEN> arrRegionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsRegionTypeEN> arrRegionTypeObjLst_Sel =
arrRegionTypeObjLstCache
.Where(x=> x.RegionTypeId == strRegionTypeId 
);
if (arrRegionTypeObjLst_Sel.Count() == 0)
{
   clsRegionTypeEN obj = clsRegionTypeBL.GetObjByRegionTypeId(strRegionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRegionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRegionTypeNameByRegionTypeIdCache(string strRegionTypeId)
{
if (string.IsNullOrEmpty(strRegionTypeId) == true) return "";
//获取缓存中的对象列表
clsRegionTypeEN objRegionType = GetObjByRegionTypeIdCache(strRegionTypeId);
if (objRegionType == null) return "";
return objRegionType.RegionTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRegionTypeIdCache(string strRegionTypeId)
{
if (string.IsNullOrEmpty(strRegionTypeId) == true) return "";
//获取缓存中的对象列表
clsRegionTypeEN objRegionType = GetObjByRegionTypeIdCache(strRegionTypeId);
if (objRegionType == null) return "";
return objRegionType.RegionTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRegionTypeEN> GetAllRegionTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsRegionTypeEN> arrRegionTypeObjLstCache = GetObjLstCache(); 
return arrRegionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRegionTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRegionTypeEN._CurrTabName);
List<clsRegionTypeEN> arrRegionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRegionTypeObjLstCache;
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
string strKey = string.Format("{0}", clsRegionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRegionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRegionTypeEN._RefreshTimeLst.Count == 0) return "";
return clsRegionTypeEN._RefreshTimeLst[clsRegionTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsRegionTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRegionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRegionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRegionTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strRegionTypeId)
{
if (strInFldName != conRegionType.RegionTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRegionType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRegionType._AttributeName));
throw new Exception(strMsg);
}
var objRegionType = clsRegionTypeBL.GetObjByRegionTypeIdCache(strRegionTypeId);
if (objRegionType == null) return "";
return objRegionType[strOutFldName].ToString();
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
int intRecCount = clsRegionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsRegionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRegionTypeDA.GetRecCount();
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
int intRecCount = clsRegionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRegionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRegionTypeEN objRegionTypeCond)
{
List<clsRegionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRegionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRegionType._AttributeName)
{
if (objRegionTypeCond.IsUpdated(strFldName) == false) continue;
if (objRegionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRegionTypeCond[strFldName].ToString());
}
else
{
if (objRegionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRegionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRegionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRegionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRegionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRegionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRegionTypeCond[strFldName]));
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
 List<string> arrList = clsRegionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RegionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RegionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RegionTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRegionTypeDA.SetFldValue(clsRegionTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RegionTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRegionTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRegionTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRegionTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RegionType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) primary key, "); 
 // /**区域类型名称*/ 
 strCreateTabCode.Append(" RegionTypeName varchar(30) not Null, "); 
 // /**区域类型英文名*/ 
 strCreateTabCode.Append(" RegionTypeENName varchar(30) Null, "); 
 // /**区域类型简名*/ 
 strCreateTabCode.Append(" RegionTypeSimName varchar(10) Null, "); 
 // /**缺省宽度*/ 
 strCreateTabCode.Append(" DefaWidth int Null, "); 
 // /**区域类型序号*/ 
 strCreateTabCode.Append(" RegionTypeOrderNum int Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conRegionType.RegionTypeOrderNum); 
List<clsRegionTypeEN> arrRegionTypeObjList = new clsRegionTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRegionTypeEN objRegionType in arrRegionTypeObjList)
{
objRegionType.RegionTypeOrderNum = intIndex;
UpdateBySql2(objRegionType);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strRegionTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strRegionTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[RegionTypeId],获取相应的序号[RegionTypeOrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字RegionTypeId
//5、把当前关键字RegionTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字RegionTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevRegionTypeId = "";    //上一条序号的关键字RegionTypeId
string strNextRegionTypeId = "";    //下一条序号的关键字RegionTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[RegionTypeId],获取相应的序号[RegionTypeOrderNum]。

clsRegionTypeEN objRegionType = clsRegionTypeBL.GetObjByRegionTypeId(strRegionTypeId);

intOrderNum = objRegionType.RegionTypeOrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsRegionTypeBL.GetRecCountByCond(clsRegionTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conRegionType.RegionTypeOrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字RegionTypeId
strPrevRegionTypeId = clsRegionTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevRegionTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字RegionTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字RegionTypeId所对应的记录序号加1
clsRegionTypeBL.SetFldValue(clsRegionTypeEN._CurrTabName, conRegionType.RegionTypeOrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conRegionType.RegionTypeId, strRegionTypeId));
clsRegionTypeBL.SetFldValue(clsRegionTypeEN._CurrTabName, conRegionType.RegionTypeOrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conRegionType.RegionTypeId, strPrevRegionTypeId));
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

//4、获取下一个序号字段的关键字RegionTypeId
strCondition.AppendFormat(" {0} = {1}", conRegionType.RegionTypeOrderNum, intOrderNum + 1);

strNextRegionTypeId = clsRegionTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextRegionTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字RegionTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字RegionTypeId所对应的记录序号减1
clsRegionTypeBL.SetFldValue(clsRegionTypeEN._CurrTabName, conRegionType.RegionTypeOrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conRegionType.RegionTypeId, strRegionTypeId));
clsRegionTypeBL.SetFldValue(clsRegionTypeEN._CurrTabName, conRegionType.RegionTypeOrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conRegionType.RegionTypeId, strNextRegionTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsRegionTypeBL.ReFreshCache();
if (clsRegionTypeBL.relatedActions != null)
{
clsRegionTypeBL.relatedActions.UpdRelaTabDate(objRegionType.RegionTypeId, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conRegionType.RegionTypeId, strKeyList);
List<clsRegionTypeEN> arrRegionTypeLst = GetObjLst(strCondition);
foreach (clsRegionTypeEN objRegionType in arrRegionTypeLst)
{
objRegionType.RegionTypeOrderNum = objRegionType.RegionTypeOrderNum + 10000;
UpdateBySql2(objRegionType);
}
strCondition = string.Format("1 = 1 order by {0} ", conRegionType.RegionTypeOrderNum); 
List<clsRegionTypeEN> arrRegionTypeObjList = new clsRegionTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRegionTypeEN objRegionType in arrRegionTypeObjList)
{
objRegionType.RegionTypeOrderNum = intIndex;
UpdateBySql2(objRegionType);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conRegionType.RegionTypeId, strKeyList);
List<clsRegionTypeEN> arrRegionTypeLst = GetObjLst(strCondition);
foreach (clsRegionTypeEN objRegionType in arrRegionTypeLst)
{
objRegionType.RegionTypeOrderNum = objRegionType.RegionTypeOrderNum - 10000;
UpdateBySql2(objRegionType);
}
strCondition = string.Format("1 = 1 order by {0} ", conRegionType.RegionTypeOrderNum); 
List<clsRegionTypeEN> arrRegionTypeObjList = new clsRegionTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRegionTypeEN objRegionType in arrRegionTypeObjList)
{
objRegionType.RegionTypeOrderNum = intIndex;
UpdateBySql2(objRegionType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 区域类型(RegionType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RegionType : clsCommFun4BL
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
clsRegionTypeBL.ReFreshThisCache();
}
}

}