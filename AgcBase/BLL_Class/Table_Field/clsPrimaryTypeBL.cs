
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrimaryTypeBL
 表名:PrimaryType(00050020)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsPrimaryTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrimaryTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrimaryTypeEN GetObj(this K_PrimaryTypeId_PrimaryType myKey)
{
clsPrimaryTypeEN objPrimaryTypeEN = clsPrimaryTypeBL.PrimaryTypeDA.GetObjByPrimaryTypeId(myKey.Value);
return objPrimaryTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrimaryTypeEN objPrimaryTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrimaryTypeBL.IsExist(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrimaryTypeEN.PrimaryTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPrimaryTypeBL.PrimaryTypeDA.AddNewRecordBySQL2(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPrimaryTypeEN objPrimaryTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPrimaryTypeBL.IsExist(objPrimaryTypeEN.PrimaryTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPrimaryTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPrimaryTypeEN.AddNewRecord();
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrimaryTypeEN objPrimaryTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrimaryTypeBL.IsExist(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrimaryTypeEN.PrimaryTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPrimaryTypeBL.PrimaryTypeDA.AddNewRecordBySQL2WithReturnKey(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrimaryTypeEN SetPrimaryTypeId(this clsPrimaryTypeEN objPrimaryTypeEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conPrimaryType.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conPrimaryType.PrimaryTypeId);
}
objPrimaryTypeEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrimaryTypeEN.dicFldComparisonOp.ContainsKey(conPrimaryType.PrimaryTypeId) == false)
{
objPrimaryTypeEN.dicFldComparisonOp.Add(conPrimaryType.PrimaryTypeId, strComparisonOp);
}
else
{
objPrimaryTypeEN.dicFldComparisonOp[conPrimaryType.PrimaryTypeId] = strComparisonOp;
}
}
return objPrimaryTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrimaryTypeEN SetPrimaryTypeName(this clsPrimaryTypeEN objPrimaryTypeEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeName, conPrimaryType.PrimaryTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, conPrimaryType.PrimaryTypeName);
}
objPrimaryTypeEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrimaryTypeEN.dicFldComparisonOp.ContainsKey(conPrimaryType.PrimaryTypeName) == false)
{
objPrimaryTypeEN.dicFldComparisonOp.Add(conPrimaryType.PrimaryTypeName, strComparisonOp);
}
else
{
objPrimaryTypeEN.dicFldComparisonOp[conPrimaryType.PrimaryTypeName] = strComparisonOp;
}
}
return objPrimaryTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrimaryTypeEN SetPrimaryTypeENName(this clsPrimaryTypeEN objPrimaryTypeEN, string strPrimaryTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeENName, 50, conPrimaryType.PrimaryTypeENName);
}
objPrimaryTypeEN.PrimaryTypeENName = strPrimaryTypeENName; //主键类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrimaryTypeEN.dicFldComparisonOp.ContainsKey(conPrimaryType.PrimaryTypeENName) == false)
{
objPrimaryTypeEN.dicFldComparisonOp.Add(conPrimaryType.PrimaryTypeENName, strComparisonOp);
}
else
{
objPrimaryTypeEN.dicFldComparisonOp[conPrimaryType.PrimaryTypeENName] = strComparisonOp;
}
}
return objPrimaryTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrimaryTypeEN SetOrderNum(this clsPrimaryTypeEN objPrimaryTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objPrimaryTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrimaryTypeEN.dicFldComparisonOp.ContainsKey(conPrimaryType.OrderNum) == false)
{
objPrimaryTypeEN.dicFldComparisonOp.Add(conPrimaryType.OrderNum, strComparisonOp);
}
else
{
objPrimaryTypeEN.dicFldComparisonOp[conPrimaryType.OrderNum] = strComparisonOp;
}
}
return objPrimaryTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrimaryTypeEN SetMemo(this clsPrimaryTypeEN objPrimaryTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrimaryType.Memo);
}
objPrimaryTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrimaryTypeEN.dicFldComparisonOp.ContainsKey(conPrimaryType.Memo) == false)
{
objPrimaryTypeEN.dicFldComparisonOp.Add(conPrimaryType.Memo, strComparisonOp);
}
else
{
objPrimaryTypeEN.dicFldComparisonOp[conPrimaryType.Memo] = strComparisonOp;
}
}
return objPrimaryTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrimaryTypeEN objPrimaryTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrimaryTypeEN.CheckPropertyNew();
clsPrimaryTypeEN objPrimaryTypeCond = new clsPrimaryTypeEN();
string strCondition = objPrimaryTypeCond
.SetPrimaryTypeId(objPrimaryTypeEN.PrimaryTypeId, "=")
.GetCombineCondition();
objPrimaryTypeEN._IsCheckProperty = true;
bool bolIsExist = clsPrimaryTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrimaryTypeEN.Update();
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrimaryTypeBL.PrimaryTypeDA.UpdateBySql2(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrimaryTypeEN objPrimaryTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrimaryTypeBL.PrimaryTypeDA.UpdateBySql2(objPrimaryTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrimaryTypeEN objPrimaryTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsPrimaryTypeBL.PrimaryTypeDA.UpdateBySqlWithCondition(objPrimaryTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrimaryTypeEN objPrimaryTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrimaryTypeBL.PrimaryTypeDA.UpdateBySqlWithConditionTransaction(objPrimaryTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrimaryTypeEN objPrimaryTypeEN)
{
try
{
int intRecNum = clsPrimaryTypeBL.PrimaryTypeDA.DelRecord(objPrimaryTypeEN.PrimaryTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
 public static void CopyTo(this clsPrimaryTypeEN objPrimaryTypeENS, clsPrimaryTypeEN objPrimaryTypeENT)
{
try
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.OrderNum = objPrimaryTypeENS.OrderNum; //序号
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
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
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <returns>目标对象=>clsPrimaryTypeEN:objPrimaryTypeENT</returns>
 public static clsPrimaryTypeEN CopyTo(this clsPrimaryTypeEN objPrimaryTypeENS)
{
try
{
 clsPrimaryTypeEN objPrimaryTypeENT = new clsPrimaryTypeEN()
{
PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName, //主键类型名
PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName, //主键类型英文名
OrderNum = objPrimaryTypeENS.OrderNum, //序号
Memo = objPrimaryTypeENS.Memo, //说明
};
 return objPrimaryTypeENT;
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
public static void CheckPropertyNew(this clsPrimaryTypeEN objPrimaryTypeEN)
{
 clsPrimaryTypeBL.PrimaryTypeDA.CheckPropertyNew(objPrimaryTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrimaryTypeEN objPrimaryTypeEN)
{
 clsPrimaryTypeBL.PrimaryTypeDA.CheckProperty4Condition(objPrimaryTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrimaryTypeEN objPrimaryTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrimaryTypeCond.IsUpdated(conPrimaryType.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objPrimaryTypeCond.dicFldComparisonOp[conPrimaryType.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrimaryType.PrimaryTypeId, objPrimaryTypeCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objPrimaryTypeCond.IsUpdated(conPrimaryType.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objPrimaryTypeCond.dicFldComparisonOp[conPrimaryType.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrimaryType.PrimaryTypeName, objPrimaryTypeCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objPrimaryTypeCond.IsUpdated(conPrimaryType.PrimaryTypeENName) == true)
{
string strComparisonOpPrimaryTypeENName = objPrimaryTypeCond.dicFldComparisonOp[conPrimaryType.PrimaryTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrimaryType.PrimaryTypeENName, objPrimaryTypeCond.PrimaryTypeENName, strComparisonOpPrimaryTypeENName);
}
if (objPrimaryTypeCond.IsUpdated(conPrimaryType.OrderNum) == true)
{
string strComparisonOpOrderNum = objPrimaryTypeCond.dicFldComparisonOp[conPrimaryType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrimaryType.OrderNum, objPrimaryTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objPrimaryTypeCond.IsUpdated(conPrimaryType.Memo) == true)
{
string strComparisonOpMemo = objPrimaryTypeCond.dicFldComparisonOp[conPrimaryType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrimaryType.Memo, objPrimaryTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrimaryType
{
public virtual bool UpdRelaTabDate(string strPrimaryTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumPrimaryType
{
 /// <summary>
 /// 非关键字
 /// </summary>
public const string NonPrimaryKey_00 = "00";
 /// <summary>
 /// 关键字
 /// </summary>
public const string PrimaryKey_01 = "01";
 /// <summary>
 /// identity
 /// </summary>
public const string Identity_02 = "02";
 /// <summary>
 /// 自增
 /// </summary>
public const string StringAutoAddPrimaryKey_03 = "03";
 /// <summary>
 /// 整型
 /// </summary>
public const string IntegerPrimaryKey_04 = "04";
 /// <summary>
 /// 外键型
 /// </summary>
public const string ForeignPrimaryKey_05 = "05";
 /// <summary>
 /// 前缀自增
 /// </summary>
public const string StringAutoAddPrimaryKeyWithPrefix_06 = "06";
 /// <summary>
 /// 复合主键
 /// </summary>
public const string CompositePrimaryKey_07 = "07";
}
 /// <summary>
 /// 主键类型(PrimaryType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrimaryTypeBL
{
public static RelatedActions_PrimaryType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrimaryTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrimaryTypeDA PrimaryTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrimaryTypeDA();
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
 public clsPrimaryTypeBL()
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
if (string.IsNullOrEmpty(clsPrimaryTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrimaryTypeEN._ConnectString);
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
public static DataTable GetDataTable_PrimaryType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrimaryTypeDA.GetDataTable_PrimaryType(strWhereCond);
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
objDT = PrimaryTypeDA.GetDataTable(strWhereCond);
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
objDT = PrimaryTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrimaryTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrimaryTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrimaryTypeDA.GetDataTable_Top(objTopPara);
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
objDT = PrimaryTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrimaryTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrimaryTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrimaryTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrimaryTypeEN> GetObjLstByPrimaryTypeIdLst(List<string> arrPrimaryTypeIdLst)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrimaryTypeIdLst, true);
 string strWhereCond = string.Format("PrimaryTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrimaryTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrimaryTypeEN> GetObjLstByPrimaryTypeIdLstCache(List<string> arrPrimaryTypeIdLst)
{
string strKey = string.Format("{0}", clsPrimaryTypeEN._CurrTabName);
List<clsPrimaryTypeEN> arrPrimaryTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrimaryTypeEN> arrPrimaryTypeObjLst_Sel =
arrPrimaryTypeObjLstCache
.Where(x => arrPrimaryTypeIdLst.Contains(x.PrimaryTypeId));
return arrPrimaryTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrimaryTypeEN> GetObjLst(string strWhereCond)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
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
public static List<clsPrimaryTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrimaryTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrimaryTypeEN> GetSubObjLstCache(clsPrimaryTypeEN objPrimaryTypeCond)
{
List<clsPrimaryTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrimaryTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrimaryType._AttributeName)
{
if (objPrimaryTypeCond.IsUpdated(strFldName) == false) continue;
if (objPrimaryTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrimaryTypeCond[strFldName].ToString());
}
else
{
if (objPrimaryTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrimaryTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrimaryTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrimaryTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrimaryTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrimaryTypeCond[strFldName]));
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
public static List<clsPrimaryTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
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
public static List<clsPrimaryTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
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
List<clsPrimaryTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrimaryTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrimaryTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrimaryTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
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
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
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
public static List<clsPrimaryTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrimaryTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrimaryTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
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
public static List<clsPrimaryTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrimaryTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrimaryTypeEN> arrObjLst = new List<clsPrimaryTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN();
try
{
objPrimaryTypeEN.PrimaryTypeId = objRow[conPrimaryType.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrimaryTypeEN.PrimaryTypeName = objRow[conPrimaryType.PrimaryTypeName].ToString().Trim(); //主键类型名
objPrimaryTypeEN.PrimaryTypeENName = objRow[conPrimaryType.PrimaryTypeENName] == DBNull.Value ? null : objRow[conPrimaryType.PrimaryTypeENName].ToString().Trim(); //主键类型英文名
objPrimaryTypeEN.OrderNum = objRow[conPrimaryType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrimaryType.OrderNum].ToString().Trim()); //序号
objPrimaryTypeEN.Memo = objRow[conPrimaryType.Memo] == DBNull.Value ? null : objRow[conPrimaryType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrimaryTypeEN.PrimaryTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrimaryTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrimaryTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrimaryType(ref clsPrimaryTypeEN objPrimaryTypeEN)
{
bool bolResult = PrimaryTypeDA.GetPrimaryType(ref objPrimaryTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrimaryTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrimaryTypeEN GetObjByPrimaryTypeId(string strPrimaryTypeId)
{
if (strPrimaryTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrimaryTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrimaryTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrimaryTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrimaryTypeEN objPrimaryTypeEN = PrimaryTypeDA.GetObjByPrimaryTypeId(strPrimaryTypeId);
return objPrimaryTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrimaryTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrimaryTypeEN objPrimaryTypeEN = PrimaryTypeDA.GetFirstObj(strWhereCond);
 return objPrimaryTypeEN;
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
public static clsPrimaryTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrimaryTypeEN objPrimaryTypeEN = PrimaryTypeDA.GetObjByDataRow(objRow);
 return objPrimaryTypeEN;
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
public static clsPrimaryTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrimaryTypeEN objPrimaryTypeEN = PrimaryTypeDA.GetObjByDataRow(objRow);
 return objPrimaryTypeEN;
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
 /// <param name = "strPrimaryTypeId">所给的关键字</param>
 /// <param name = "lstPrimaryTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrimaryTypeEN GetObjByPrimaryTypeIdFromList(string strPrimaryTypeId, List<clsPrimaryTypeEN> lstPrimaryTypeObjLst)
{
foreach (clsPrimaryTypeEN objPrimaryTypeEN in lstPrimaryTypeObjLst)
{
if (objPrimaryTypeEN.PrimaryTypeId == strPrimaryTypeId)
{
return objPrimaryTypeEN;
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
 string strPrimaryTypeId;
 try
 {
 strPrimaryTypeId = new clsPrimaryTypeDA().GetFirstID(strWhereCond);
 return strPrimaryTypeId;
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
 arrList = PrimaryTypeDA.GetID(strWhereCond);
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
bool bolIsExist = PrimaryTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrimaryTypeId)
{
if (string.IsNullOrEmpty(strPrimaryTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrimaryTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrimaryTypeDA.IsExist(strPrimaryTypeId);
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
 bolIsExist = clsPrimaryTypeDA.IsExistTable();
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
 bolIsExist = PrimaryTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrimaryTypeEN objPrimaryTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrimaryTypeBL.IsExist(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrimaryTypeEN.PrimaryTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PrimaryTypeDA.AddNewRecordBySQL2(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrimaryTypeEN objPrimaryTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrimaryTypeBL.IsExist(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrimaryTypeEN.PrimaryTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PrimaryTypeDA.AddNewRecordBySQL2WithReturnKey(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrimaryTypeEN objPrimaryTypeEN)
{
try
{
bool bolResult = PrimaryTypeDA.Update(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "objPrimaryTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrimaryTypeEN objPrimaryTypeEN)
{
 if (string.IsNullOrEmpty(objPrimaryTypeEN.PrimaryTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrimaryTypeDA.UpdateBySql2(objPrimaryTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrimaryTypeBL.ReFreshCache();

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
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
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrimaryTypeId)
{
try
{
 clsPrimaryTypeEN objPrimaryTypeEN = clsPrimaryTypeBL.GetObjByPrimaryTypeId(strPrimaryTypeId);

if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryTypeEN.PrimaryTypeId, "SetUpdDate");
}
if (objPrimaryTypeEN != null)
{
int intRecNum = PrimaryTypeDA.DelRecord(strPrimaryTypeId);
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
/// <param name="strPrimaryTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrimaryTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
//删除与表:[PrimaryType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrimaryType.PrimaryTypeId,
//strPrimaryTypeId);
//        clsPrimaryTypeBL.DelPrimaryTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrimaryTypeBL.DelRecord(strPrimaryTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrimaryTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrimaryTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrimaryTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrimaryTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(strPrimaryTypeId, "UpdRelaTabDate");
}
bool bolResult = PrimaryTypeDA.DelRecord(strPrimaryTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrimaryTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrimaryTypes(List<string> arrPrimaryTypeIdLst)
{
if (arrPrimaryTypeIdLst.Count == 0) return 0;
try
{
if (clsPrimaryTypeBL.relatedActions != null)
{
foreach (var strPrimaryTypeId in arrPrimaryTypeIdLst)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(strPrimaryTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrimaryTypeDA.DelPrimaryType(arrPrimaryTypeIdLst);
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
public static int DelPrimaryTypesByCond(string strWhereCond)
{
try
{
if (clsPrimaryTypeBL.relatedActions != null)
{
List<string> arrPrimaryTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrimaryTypeId in arrPrimaryTypeId)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(strPrimaryTypeId, "UpdRelaTabDate");
}
}
int intRecNum = PrimaryTypeDA.DelPrimaryType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrimaryType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrimaryTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrimaryTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrimaryTypeDA.GetSpecSQLObj();
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
//删除与表:[PrimaryType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrimaryTypeBL.DelRecord(strPrimaryTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrimaryTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrimaryTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrimaryTypeENS">源对象</param>
 /// <param name = "objPrimaryTypeENT">目标对象</param>
 public static void CopyTo(clsPrimaryTypeEN objPrimaryTypeENS, clsPrimaryTypeEN objPrimaryTypeENT)
{
try
{
objPrimaryTypeENT.PrimaryTypeId = objPrimaryTypeENS.PrimaryTypeId; //主键类型ID
objPrimaryTypeENT.PrimaryTypeName = objPrimaryTypeENS.PrimaryTypeName; //主键类型名
objPrimaryTypeENT.PrimaryTypeENName = objPrimaryTypeENS.PrimaryTypeENName; //主键类型英文名
objPrimaryTypeENT.OrderNum = objPrimaryTypeENS.OrderNum; //序号
objPrimaryTypeENT.Memo = objPrimaryTypeENS.Memo; //说明
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
 /// <param name = "objPrimaryTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsPrimaryTypeEN objPrimaryTypeEN)
{
try
{
objPrimaryTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrimaryTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrimaryType.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrimaryTypeEN.PrimaryTypeId = objPrimaryTypeEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(conPrimaryType.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrimaryTypeEN.PrimaryTypeName = objPrimaryTypeEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(conPrimaryType.PrimaryTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrimaryTypeEN.PrimaryTypeENName = objPrimaryTypeEN.PrimaryTypeENName == "[null]" ? null :  objPrimaryTypeEN.PrimaryTypeENName; //主键类型英文名
}
if (arrFldSet.Contains(conPrimaryType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPrimaryTypeEN.OrderNum = objPrimaryTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conPrimaryType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrimaryTypeEN.Memo = objPrimaryTypeEN.Memo == "[null]" ? null :  objPrimaryTypeEN.Memo; //说明
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
 /// <param name = "objPrimaryTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrimaryTypeEN objPrimaryTypeEN)
{
try
{
if (objPrimaryTypeEN.PrimaryTypeENName == "[null]") objPrimaryTypeEN.PrimaryTypeENName = null; //主键类型英文名
if (objPrimaryTypeEN.Memo == "[null]") objPrimaryTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrimaryTypeEN objPrimaryTypeEN)
{
 PrimaryTypeDA.CheckPropertyNew(objPrimaryTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrimaryTypeEN objPrimaryTypeEN)
{
 PrimaryTypeDA.CheckProperty4Condition(objPrimaryTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PrimaryTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrimaryType.PrimaryTypeId); 
List<clsPrimaryTypeEN> arrObjLst = clsPrimaryTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrimaryTypeEN objPrimaryTypeEN = new clsPrimaryTypeEN()
{
PrimaryTypeId = "0",
PrimaryTypeName = "选[主键类型]..."
};
arrObjLst.Insert(0, objPrimaryTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrimaryType.PrimaryTypeId;
objComboBox.DisplayMember = conPrimaryType.PrimaryTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PrimaryTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[主键类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrimaryType.PrimaryTypeId); 
IEnumerable<clsPrimaryTypeEN> arrObjLst = clsPrimaryTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum);
objDDL.DataValueField = conPrimaryType.PrimaryTypeId;
objDDL.DataTextField = conPrimaryType.PrimaryTypeName;
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
public static void BindDdl_PrimaryTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[主键类型]...","0");
List<clsPrimaryTypeEN> arrPrimaryTypeObjLst = GetAllPrimaryTypeObjLstCache(); 
arrPrimaryTypeObjLst = arrPrimaryTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conPrimaryType.PrimaryTypeId;
objDDL.DataTextField = conPrimaryType.PrimaryTypeName;
objDDL.DataSource = arrPrimaryTypeObjLst;
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
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrimaryTypeId");
//if (arrPrimaryTypeObjLstCache == null)
//{
//arrPrimaryTypeObjLstCache = PrimaryTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrimaryTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrimaryTypeEN GetObjByPrimaryTypeIdCache(string strPrimaryTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrimaryTypeEN._CurrTabName);
List<clsPrimaryTypeEN> arrPrimaryTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrimaryTypeEN> arrPrimaryTypeObjLst_Sel =
arrPrimaryTypeObjLstCache
.Where(x=> x.PrimaryTypeId == strPrimaryTypeId 
);
if (arrPrimaryTypeObjLst_Sel.Count() == 0)
{
   clsPrimaryTypeEN obj = clsPrimaryTypeBL.GetObjByPrimaryTypeId(strPrimaryTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrimaryTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrimaryTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrimaryTypeNameByPrimaryTypeIdCache(string strPrimaryTypeId)
{
if (string.IsNullOrEmpty(strPrimaryTypeId) == true) return "";
//获取缓存中的对象列表
clsPrimaryTypeEN objPrimaryType = GetObjByPrimaryTypeIdCache(strPrimaryTypeId);
if (objPrimaryType == null) return "";
return objPrimaryType.PrimaryTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrimaryTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrimaryTypeIdCache(string strPrimaryTypeId)
{
if (string.IsNullOrEmpty(strPrimaryTypeId) == true) return "";
//获取缓存中的对象列表
clsPrimaryTypeEN objPrimaryType = GetObjByPrimaryTypeIdCache(strPrimaryTypeId);
if (objPrimaryType == null) return "";
return objPrimaryType.PrimaryTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrimaryTypeEN> GetAllPrimaryTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsPrimaryTypeEN> arrPrimaryTypeObjLstCache = GetObjLstCache(); 
return arrPrimaryTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrimaryTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrimaryTypeEN._CurrTabName);
List<clsPrimaryTypeEN> arrPrimaryTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrimaryTypeObjLstCache;
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
string strKey = string.Format("{0}", clsPrimaryTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrimaryTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrimaryTypeEN._RefreshTimeLst.Count == 0) return "";
return clsPrimaryTypeEN._RefreshTimeLst[clsPrimaryTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPrimaryTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrimaryTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrimaryTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrimaryTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strPrimaryTypeId)
{
if (strInFldName != conPrimaryType.PrimaryTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrimaryType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrimaryType._AttributeName));
throw new Exception(strMsg);
}
var objPrimaryType = clsPrimaryTypeBL.GetObjByPrimaryTypeIdCache(strPrimaryTypeId);
if (objPrimaryType == null) return "";
return objPrimaryType[strOutFldName].ToString();
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
int intRecCount = clsPrimaryTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsPrimaryTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrimaryTypeDA.GetRecCount();
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
int intRecCount = clsPrimaryTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrimaryTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrimaryTypeEN objPrimaryTypeCond)
{
List<clsPrimaryTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrimaryTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrimaryType._AttributeName)
{
if (objPrimaryTypeCond.IsUpdated(strFldName) == false) continue;
if (objPrimaryTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrimaryTypeCond[strFldName].ToString());
}
else
{
if (objPrimaryTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrimaryTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrimaryTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrimaryTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrimaryTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrimaryTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrimaryTypeCond[strFldName]));
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
 List<string> arrList = clsPrimaryTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrimaryTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrimaryTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrimaryTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrimaryTypeDA.SetFldValue(clsPrimaryTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrimaryTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrimaryTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrimaryTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrimaryTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrimaryType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) primary key, "); 
 // /**主键类型名*/ 
 strCreateTabCode.Append(" PrimaryTypeName varchar(30) not Null, "); 
 // /**主键类型英文名*/ 
 strCreateTabCode.Append(" PrimaryTypeENName varchar(50) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
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
string strCondition = string.Format("1 = 1 order by {0} ", conPrimaryType.OrderNum); 
List<clsPrimaryTypeEN> arrPrimaryTypeObjList = new clsPrimaryTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeObjList)
{
objPrimaryType.OrderNum = intIndex;
UpdateBySql2(objPrimaryType);
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
/// <param name="strPrimaryTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strPrimaryTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[PrimaryTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字PrimaryTypeId
//5、把当前关键字PrimaryTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字PrimaryTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevPrimaryTypeId = "";    //上一条序号的关键字PrimaryTypeId
string strNextPrimaryTypeId = "";    //下一条序号的关键字PrimaryTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[PrimaryTypeId],获取相应的序号[OrderNum]。

clsPrimaryTypeEN objPrimaryType = clsPrimaryTypeBL.GetObjByPrimaryTypeId(strPrimaryTypeId);

intOrderNum = objPrimaryType.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsPrimaryTypeBL.GetRecCountByCond(clsPrimaryTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conPrimaryType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字PrimaryTypeId
strPrevPrimaryTypeId = clsPrimaryTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevPrimaryTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字PrimaryTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字PrimaryTypeId所对应的记录序号加1
clsPrimaryTypeBL.SetFldValue(clsPrimaryTypeEN._CurrTabName, conPrimaryType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conPrimaryType.PrimaryTypeId, strPrimaryTypeId));
clsPrimaryTypeBL.SetFldValue(clsPrimaryTypeEN._CurrTabName, conPrimaryType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conPrimaryType.PrimaryTypeId, strPrevPrimaryTypeId));
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

//4、获取下一个序号字段的关键字PrimaryTypeId
strCondition.AppendFormat(" {0} = {1}", conPrimaryType.OrderNum, intOrderNum + 1);

strNextPrimaryTypeId = clsPrimaryTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextPrimaryTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字PrimaryTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字PrimaryTypeId所对应的记录序号减1
clsPrimaryTypeBL.SetFldValue(clsPrimaryTypeEN._CurrTabName, conPrimaryType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conPrimaryType.PrimaryTypeId, strPrimaryTypeId));
clsPrimaryTypeBL.SetFldValue(clsPrimaryTypeEN._CurrTabName, conPrimaryType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conPrimaryType.PrimaryTypeId, strNextPrimaryTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsPrimaryTypeBL.ReFreshCache();
if (clsPrimaryTypeBL.relatedActions != null)
{
clsPrimaryTypeBL.relatedActions.UpdRelaTabDate(objPrimaryType.PrimaryTypeId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", conPrimaryType.PrimaryTypeId, strKeyList);
List<clsPrimaryTypeEN> arrPrimaryTypeLst = GetObjLst(strCondition);
foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeLst)
{
objPrimaryType.OrderNum = objPrimaryType.OrderNum + 10000;
UpdateBySql2(objPrimaryType);
}
strCondition = string.Format("1 = 1 order by {0} ", conPrimaryType.OrderNum); 
List<clsPrimaryTypeEN> arrPrimaryTypeObjList = new clsPrimaryTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeObjList)
{
objPrimaryType.OrderNum = intIndex;
UpdateBySql2(objPrimaryType);
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
string strCondition = string.Format("{0} in ({1})", conPrimaryType.PrimaryTypeId, strKeyList);
List<clsPrimaryTypeEN> arrPrimaryTypeLst = GetObjLst(strCondition);
foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeLst)
{
objPrimaryType.OrderNum = objPrimaryType.OrderNum - 10000;
UpdateBySql2(objPrimaryType);
}
strCondition = string.Format("1 = 1 order by {0} ", conPrimaryType.OrderNum); 
List<clsPrimaryTypeEN> arrPrimaryTypeObjList = new clsPrimaryTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrimaryTypeEN objPrimaryType in arrPrimaryTypeObjList)
{
objPrimaryType.OrderNum = intIndex;
UpdateBySql2(objPrimaryType);
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
 /// 主键类型(PrimaryType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrimaryType : clsCommFun4BL
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
clsPrimaryTypeBL.ReFreshThisCache();
}
}

}