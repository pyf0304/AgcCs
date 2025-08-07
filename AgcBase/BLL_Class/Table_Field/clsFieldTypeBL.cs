
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTypeBL
 表名:FieldType(00050173)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:16
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
public static class  clsFieldTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFieldTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTypeEN GetObj(this K_FieldTypeId_FieldType myKey)
{
clsFieldTypeEN objFieldTypeEN = clsFieldTypeBL.FieldTypeDA.GetObjByFieldTypeId(myKey.Value);
return objFieldTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTypeEN objFieldTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTypeBL.IsExist(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTypeEN.FieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsFieldTypeBL.FieldTypeDA.AddNewRecordBySQL2(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFieldTypeEN objFieldTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFieldTypeBL.IsExist(objFieldTypeEN.FieldTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFieldTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFieldTypeEN.AddNewRecord();
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFieldTypeEN objFieldTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTypeBL.IsExist(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTypeEN.FieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsFieldTypeBL.FieldTypeDA.AddNewRecordBySQL2WithReturnKey(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTypeEN SetFieldTypeId(this clsFieldTypeEN objFieldTypeEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conFieldType.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conFieldType.FieldTypeId);
}
objFieldTypeEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTypeEN.dicFldComparisonOp.ContainsKey(conFieldType.FieldTypeId) == false)
{
objFieldTypeEN.dicFldComparisonOp.Add(conFieldType.FieldTypeId, strComparisonOp);
}
else
{
objFieldTypeEN.dicFldComparisonOp[conFieldType.FieldTypeId] = strComparisonOp;
}
}
return objFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTypeEN SetFieldTypeName(this clsFieldTypeEN objFieldTypeEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeName, conFieldType.FieldTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, conFieldType.FieldTypeName);
}
objFieldTypeEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTypeEN.dicFldComparisonOp.ContainsKey(conFieldType.FieldTypeName) == false)
{
objFieldTypeEN.dicFldComparisonOp.Add(conFieldType.FieldTypeName, strComparisonOp);
}
else
{
objFieldTypeEN.dicFldComparisonOp[conFieldType.FieldTypeName] = strComparisonOp;
}
}
return objFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTypeEN SetFieldTypeENName(this clsFieldTypeEN objFieldTypeEN, string strFieldTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeENName, 30, conFieldType.FieldTypeENName);
}
objFieldTypeEN.FieldTypeENName = strFieldTypeENName; //字段类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTypeEN.dicFldComparisonOp.ContainsKey(conFieldType.FieldTypeENName) == false)
{
objFieldTypeEN.dicFldComparisonOp.Add(conFieldType.FieldTypeENName, strComparisonOp);
}
else
{
objFieldTypeEN.dicFldComparisonOp[conFieldType.FieldTypeENName] = strComparisonOp;
}
}
return objFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTypeEN SetOrderNum(this clsFieldTypeEN objFieldTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objFieldTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTypeEN.dicFldComparisonOp.ContainsKey(conFieldType.OrderNum) == false)
{
objFieldTypeEN.dicFldComparisonOp.Add(conFieldType.OrderNum, strComparisonOp);
}
else
{
objFieldTypeEN.dicFldComparisonOp[conFieldType.OrderNum] = strComparisonOp;
}
}
return objFieldTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTypeEN SetMemo(this clsFieldTypeEN objFieldTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldType.Memo);
}
objFieldTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTypeEN.dicFldComparisonOp.ContainsKey(conFieldType.Memo) == false)
{
objFieldTypeEN.dicFldComparisonOp.Add(conFieldType.Memo, strComparisonOp);
}
else
{
objFieldTypeEN.dicFldComparisonOp[conFieldType.Memo] = strComparisonOp;
}
}
return objFieldTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFieldTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFieldTypeEN objFieldTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFieldTypeEN.CheckPropertyNew();
clsFieldTypeEN objFieldTypeCond = new clsFieldTypeEN();
string strCondition = objFieldTypeCond
.SetFieldTypeId(objFieldTypeEN.FieldTypeId, "=")
.GetCombineCondition();
objFieldTypeEN._IsCheckProperty = true;
bool bolIsExist = clsFieldTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFieldTypeEN.Update();
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTypeEN objFieldTypeEN)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTypeBL.FieldTypeDA.UpdateBySql2(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTypeEN objFieldTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTypeBL.FieldTypeDA.UpdateBySql2(objFieldTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTypeEN objFieldTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsFieldTypeBL.FieldTypeDA.UpdateBySqlWithCondition(objFieldTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTypeEN objFieldTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFieldTypeBL.FieldTypeDA.UpdateBySqlWithConditionTransaction(objFieldTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "strFieldTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFieldTypeEN objFieldTypeEN)
{
try
{
int intRecNum = clsFieldTypeBL.FieldTypeDA.DelRecord(objFieldTypeEN.FieldTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeENS">源对象</param>
 /// <param name = "objFieldTypeENT">目标对象</param>
 public static void CopyTo(this clsFieldTypeEN objFieldTypeENS, clsFieldTypeEN objFieldTypeENT)
{
try
{
objFieldTypeENT.FieldTypeId = objFieldTypeENS.FieldTypeId; //字段类型Id
objFieldTypeENT.FieldTypeName = objFieldTypeENS.FieldTypeName; //字段类型名
objFieldTypeENT.FieldTypeENName = objFieldTypeENS.FieldTypeENName; //字段类型英文名
objFieldTypeENT.OrderNum = objFieldTypeENS.OrderNum; //序号
objFieldTypeENT.Memo = objFieldTypeENS.Memo; //说明
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
 /// <param name = "objFieldTypeENS">源对象</param>
 /// <returns>目标对象=>clsFieldTypeEN:objFieldTypeENT</returns>
 public static clsFieldTypeEN CopyTo(this clsFieldTypeEN objFieldTypeENS)
{
try
{
 clsFieldTypeEN objFieldTypeENT = new clsFieldTypeEN()
{
FieldTypeId = objFieldTypeENS.FieldTypeId, //字段类型Id
FieldTypeName = objFieldTypeENS.FieldTypeName, //字段类型名
FieldTypeENName = objFieldTypeENS.FieldTypeENName, //字段类型英文名
OrderNum = objFieldTypeENS.OrderNum, //序号
Memo = objFieldTypeENS.Memo, //说明
};
 return objFieldTypeENT;
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
public static void CheckPropertyNew(this clsFieldTypeEN objFieldTypeEN)
{
 clsFieldTypeBL.FieldTypeDA.CheckPropertyNew(objFieldTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFieldTypeEN objFieldTypeEN)
{
 clsFieldTypeBL.FieldTypeDA.CheckProperty4Condition(objFieldTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTypeEN objFieldTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTypeCond.IsUpdated(conFieldType.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objFieldTypeCond.dicFldComparisonOp[conFieldType.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldType.FieldTypeId, objFieldTypeCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objFieldTypeCond.IsUpdated(conFieldType.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objFieldTypeCond.dicFldComparisonOp[conFieldType.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldType.FieldTypeName, objFieldTypeCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objFieldTypeCond.IsUpdated(conFieldType.FieldTypeENName) == true)
{
string strComparisonOpFieldTypeENName = objFieldTypeCond.dicFldComparisonOp[conFieldType.FieldTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldType.FieldTypeENName, objFieldTypeCond.FieldTypeENName, strComparisonOpFieldTypeENName);
}
if (objFieldTypeCond.IsUpdated(conFieldType.OrderNum) == true)
{
string strComparisonOpOrderNum = objFieldTypeCond.dicFldComparisonOp[conFieldType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldType.OrderNum, objFieldTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objFieldTypeCond.IsUpdated(conFieldType.Memo) == true)
{
string strComparisonOpMemo = objFieldTypeCond.dicFldComparisonOp[conFieldType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldType.Memo, objFieldTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FieldType
{
public virtual bool UpdRelaTabDate(string strFieldTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumFieldType
{
 /// <summary>
 /// 一般字段
 /// </summary>
public const string NormalField_01 = "01";
 /// <summary>
 /// 关键字段
 /// </summary>
public const string KeyField_02 = "02";
 /// <summary>
 /// 名称字段
 /// </summary>
public const string NameField_03 = "03";
 /// <summary>
 /// 管理字段
 /// </summary>
public const string ManageField_04 = "04";
 /// <summary>
 /// 英文名称字段
 /// </summary>
public const string EnglishNameFIeld_05 = "05";
 /// <summary>
 /// 排序字段
 /// </summary>
public const string SortField_06 = "06";
 /// <summary>
 /// 字符常量字段
 /// </summary>
public const string CharsConstField_07 = "07";
 /// <summary>
 /// 同步字段
 /// </summary>
public const string SynField_08 = "08";
 /// <summary>
 /// 序号字段
 /// </summary>
public const string OrderNumField_09 = "09";
 /// <summary>
 /// 分类字段
 /// </summary>
public const string ClassificationField_10 = "10";
 /// <summary>
 /// 计算列
 /// </summary>
public const string CalcField_11 = "11";
 /// <summary>
 /// 删除标志字段
 /// </summary>
public const string DelSignField_12 = "12";
 /// <summary>
 /// 日志-修改日期
 /// </summary>
public const string Log_UpdDate_13 = "13";
 /// <summary>
 /// 日志-修改人
 /// </summary>
public const string Log_UpdUser_14 = "14";
 /// <summary>
 /// 附加Copy字段
 /// </summary>
public const string AdditionalCopyField_15 = "15";
 /// <summary>
 /// 条件字段
 /// </summary>
public const string ConditionField_16 = "16";
 /// <summary>
 /// 设置字段
 /// </summary>
public const string SetField_17 = "17";
 /// <summary>
 /// 暂时不用
 /// </summary>
public const string BeingNot_18 = "18";
 /// <summary>
 /// 前缀字段
 /// </summary>
public const string PrefixField_19 = "19";
 /// <summary>
 /// 显示单元(扩展)
 /// </summary>
public const string DisplayUnit_20 = "20";
}
 /// <summary>
 /// 字段类型(FieldType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFieldTypeBL
{
public static RelatedActions_FieldType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFieldTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFieldTypeDA FieldTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFieldTypeDA();
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
 public clsFieldTypeBL()
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
if (string.IsNullOrEmpty(clsFieldTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTypeEN._ConnectString);
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
public static DataTable GetDataTable_FieldType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FieldTypeDA.GetDataTable_FieldType(strWhereCond);
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
objDT = FieldTypeDA.GetDataTable(strWhereCond);
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
objDT = FieldTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FieldTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FieldTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FieldTypeDA.GetDataTable_Top(objTopPara);
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
objDT = FieldTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FieldTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FieldTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFieldTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFieldTypeEN> GetObjLstByFieldTypeIdLst(List<string> arrFieldTypeIdLst)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFieldTypeIdLst, true);
 string strWhereCond = string.Format("FieldTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFieldTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFieldTypeEN> GetObjLstByFieldTypeIdLstCache(List<string> arrFieldTypeIdLst)
{
string strKey = string.Format("{0}", clsFieldTypeEN._CurrTabName);
List<clsFieldTypeEN> arrFieldTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTypeEN> arrFieldTypeObjLst_Sel =
arrFieldTypeObjLstCache
.Where(x => arrFieldTypeIdLst.Contains(x.FieldTypeId));
return arrFieldTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTypeEN> GetObjLst(string strWhereCond)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
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
public static List<clsFieldTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFieldTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFieldTypeEN> GetSubObjLstCache(clsFieldTypeEN objFieldTypeCond)
{
List<clsFieldTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldType._AttributeName)
{
if (objFieldTypeCond.IsUpdated(strFldName) == false) continue;
if (objFieldTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTypeCond[strFldName].ToString());
}
else
{
if (objFieldTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTypeCond[strFldName]));
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
public static List<clsFieldTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
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
public static List<clsFieldTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
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
List<clsFieldTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFieldTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFieldTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
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
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
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
public static List<clsFieldTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFieldTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFieldTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
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
public static List<clsFieldTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFieldTypeEN> arrObjLst = new List<clsFieldTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN();
try
{
objFieldTypeEN.FieldTypeId = objRow[conFieldType.FieldTypeId].ToString().Trim(); //字段类型Id
objFieldTypeEN.FieldTypeName = objRow[conFieldType.FieldTypeName].ToString().Trim(); //字段类型名
objFieldTypeEN.FieldTypeENName = objRow[conFieldType.FieldTypeENName] == DBNull.Value ? null : objRow[conFieldType.FieldTypeENName].ToString().Trim(); //字段类型英文名
objFieldTypeEN.OrderNum = objRow[conFieldType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFieldType.OrderNum].ToString().Trim()); //序号
objFieldTypeEN.Memo = objRow[conFieldType.Memo] == DBNull.Value ? null : objRow[conFieldType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTypeEN.FieldTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFieldTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFieldType(ref clsFieldTypeEN objFieldTypeEN)
{
bool bolResult = FieldTypeDA.GetFieldType(ref objFieldTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFieldTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTypeEN GetObjByFieldTypeId(string strFieldTypeId)
{
if (strFieldTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFieldTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFieldTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFieldTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFieldTypeEN objFieldTypeEN = FieldTypeDA.GetObjByFieldTypeId(strFieldTypeId);
return objFieldTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFieldTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFieldTypeEN objFieldTypeEN = FieldTypeDA.GetFirstObj(strWhereCond);
 return objFieldTypeEN;
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
public static clsFieldTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFieldTypeEN objFieldTypeEN = FieldTypeDA.GetObjByDataRow(objRow);
 return objFieldTypeEN;
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
public static clsFieldTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFieldTypeEN objFieldTypeEN = FieldTypeDA.GetObjByDataRow(objRow);
 return objFieldTypeEN;
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
 /// <param name = "strFieldTypeId">所给的关键字</param>
 /// <param name = "lstFieldTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTypeEN GetObjByFieldTypeIdFromList(string strFieldTypeId, List<clsFieldTypeEN> lstFieldTypeObjLst)
{
foreach (clsFieldTypeEN objFieldTypeEN in lstFieldTypeObjLst)
{
if (objFieldTypeEN.FieldTypeId == strFieldTypeId)
{
return objFieldTypeEN;
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
 string strFieldTypeId;
 try
 {
 strFieldTypeId = new clsFieldTypeDA().GetFirstID(strWhereCond);
 return strFieldTypeId;
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
 arrList = FieldTypeDA.GetID(strWhereCond);
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
bool bolIsExist = FieldTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFieldTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFieldTypeId)
{
if (string.IsNullOrEmpty(strFieldTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFieldTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FieldTypeDA.IsExist(strFieldTypeId);
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
 bolIsExist = clsFieldTypeDA.IsExistTable();
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
 bolIsExist = FieldTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFieldTypeEN objFieldTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTypeBL.IsExist(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTypeEN.FieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = FieldTypeDA.AddNewRecordBySQL2(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFieldTypeEN objFieldTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTypeBL.IsExist(objFieldTypeEN.FieldTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTypeEN.FieldTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = FieldTypeDA.AddNewRecordBySQL2WithReturnKey(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFieldTypeEN objFieldTypeEN)
{
try
{
bool bolResult = FieldTypeDA.Update(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "objFieldTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFieldTypeEN objFieldTypeEN)
{
 if (string.IsNullOrEmpty(objFieldTypeEN.FieldTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FieldTypeDA.UpdateBySql2(objFieldTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTypeBL.ReFreshCache();

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
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
 /// <param name = "strFieldTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFieldTypeId)
{
try
{
 clsFieldTypeEN objFieldTypeEN = clsFieldTypeBL.GetObjByFieldTypeId(strFieldTypeId);

if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldTypeEN.FieldTypeId, "SetUpdDate");
}
if (objFieldTypeEN != null)
{
int intRecNum = FieldTypeDA.DelRecord(strFieldTypeId);
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
/// <param name="strFieldTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFieldTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFieldTypeDA.GetSpecSQLObj();
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
//删除与表:[FieldType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFieldType.FieldTypeId,
//strFieldTypeId);
//        clsFieldTypeBL.DelFieldTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTypeBL.DelRecord(strFieldTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFieldTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFieldTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFieldTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(strFieldTypeId, "UpdRelaTabDate");
}
bool bolResult = FieldTypeDA.DelRecord(strFieldTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFieldTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFieldTypes(List<string> arrFieldTypeIdLst)
{
if (arrFieldTypeIdLst.Count == 0) return 0;
try
{
if (clsFieldTypeBL.relatedActions != null)
{
foreach (var strFieldTypeId in arrFieldTypeIdLst)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(strFieldTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = FieldTypeDA.DelFieldType(arrFieldTypeIdLst);
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
public static int DelFieldTypesByCond(string strWhereCond)
{
try
{
if (clsFieldTypeBL.relatedActions != null)
{
List<string> arrFieldTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFieldTypeId in arrFieldTypeId)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(strFieldTypeId, "UpdRelaTabDate");
}
}
int intRecNum = FieldTypeDA.DelFieldType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FieldType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFieldTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFieldTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFieldTypeDA.GetSpecSQLObj();
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
//删除与表:[FieldType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTypeBL.DelRecord(strFieldTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFieldTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFieldTypeENS">源对象</param>
 /// <param name = "objFieldTypeENT">目标对象</param>
 public static void CopyTo(clsFieldTypeEN objFieldTypeENS, clsFieldTypeEN objFieldTypeENT)
{
try
{
objFieldTypeENT.FieldTypeId = objFieldTypeENS.FieldTypeId; //字段类型Id
objFieldTypeENT.FieldTypeName = objFieldTypeENS.FieldTypeName; //字段类型名
objFieldTypeENT.FieldTypeENName = objFieldTypeENS.FieldTypeENName; //字段类型英文名
objFieldTypeENT.OrderNum = objFieldTypeENS.OrderNum; //序号
objFieldTypeENT.Memo = objFieldTypeENS.Memo; //说明
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
 /// <param name = "objFieldTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsFieldTypeEN objFieldTypeEN)
{
try
{
objFieldTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFieldTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFieldType.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTypeEN.FieldTypeId = objFieldTypeEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conFieldType.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTypeEN.FieldTypeName = objFieldTypeEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(conFieldType.FieldTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTypeEN.FieldTypeENName = objFieldTypeEN.FieldTypeENName == "[null]" ? null :  objFieldTypeEN.FieldTypeENName; //字段类型英文名
}
if (arrFldSet.Contains(conFieldType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTypeEN.OrderNum = objFieldTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFieldType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTypeEN.Memo = objFieldTypeEN.Memo == "[null]" ? null :  objFieldTypeEN.Memo; //说明
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
 /// <param name = "objFieldTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFieldTypeEN objFieldTypeEN)
{
try
{
if (objFieldTypeEN.FieldTypeENName == "[null]") objFieldTypeEN.FieldTypeENName = null; //字段类型英文名
if (objFieldTypeEN.Memo == "[null]") objFieldTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFieldTypeEN objFieldTypeEN)
{
 FieldTypeDA.CheckPropertyNew(objFieldTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFieldTypeEN objFieldTypeEN)
{
 FieldTypeDA.CheckProperty4Condition(objFieldTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FieldTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFieldType.FieldTypeId); 
List<clsFieldTypeEN> arrObjLst = clsFieldTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFieldTypeEN objFieldTypeEN = new clsFieldTypeEN()
{
FieldTypeId = "0",
FieldTypeName = "选[字段类型]..."
};
arrObjLst.Insert(0, objFieldTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFieldType.FieldTypeId;
objComboBox.DisplayMember = conFieldType.FieldTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FieldTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFieldType.FieldTypeId); 
IEnumerable<clsFieldTypeEN> arrObjLst = clsFieldTypeBL.GetObjLst(strCondition).OrderBy(x=>x.OrderNum);
objDDL.DataValueField = conFieldType.FieldTypeId;
objDDL.DataTextField = conFieldType.FieldTypeName;
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
public static void BindDdl_FieldTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段类型]...","0");
List<clsFieldTypeEN> arrFieldTypeObjLst = GetAllFieldTypeObjLstCache(); 
arrFieldTypeObjLst = arrFieldTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conFieldType.FieldTypeId;
objDDL.DataTextField = conFieldType.FieldTypeName;
objDDL.DataSource = arrFieldTypeObjLst;
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
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FieldTypeId");
//if (arrFieldTypeObjLstCache == null)
//{
//arrFieldTypeObjLstCache = FieldTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTypeEN GetObjByFieldTypeIdCache(string strFieldTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFieldTypeEN._CurrTabName);
List<clsFieldTypeEN> arrFieldTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTypeEN> arrFieldTypeObjLst_Sel =
arrFieldTypeObjLstCache
.Where(x=> x.FieldTypeId == strFieldTypeId 
);
if (arrFieldTypeObjLst_Sel.Count() == 0)
{
   clsFieldTypeEN obj = clsFieldTypeBL.GetObjByFieldTypeId(strFieldTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFieldTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFieldTypeNameByFieldTypeIdCache(string strFieldTypeId)
{
if (string.IsNullOrEmpty(strFieldTypeId) == true) return "";
//获取缓存中的对象列表
clsFieldTypeEN objFieldType = GetObjByFieldTypeIdCache(strFieldTypeId);
if (objFieldType == null) return "";
return objFieldType.FieldTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFieldTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFieldTypeIdCache(string strFieldTypeId)
{
if (string.IsNullOrEmpty(strFieldTypeId) == true) return "";
//获取缓存中的对象列表
clsFieldTypeEN objFieldType = GetObjByFieldTypeIdCache(strFieldTypeId);
if (objFieldType == null) return "";
return objFieldType.FieldTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTypeEN> GetAllFieldTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsFieldTypeEN> arrFieldTypeObjLstCache = GetObjLstCache(); 
return arrFieldTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFieldTypeEN._CurrTabName);
List<clsFieldTypeEN> arrFieldTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFieldTypeObjLstCache;
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
string strKey = string.Format("{0}", clsFieldTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFieldTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFieldTypeEN._RefreshTimeLst.Count == 0) return "";
return clsFieldTypeEN._RefreshTimeLst[clsFieldTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFieldTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFieldTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFieldTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFieldTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strFieldTypeId)
{
if (strInFldName != conFieldType.FieldTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFieldType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFieldType._AttributeName));
throw new Exception(strMsg);
}
var objFieldType = clsFieldTypeBL.GetObjByFieldTypeIdCache(strFieldTypeId);
if (objFieldType == null) return "";
return objFieldType[strOutFldName].ToString();
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
int intRecCount = clsFieldTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsFieldTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFieldTypeDA.GetRecCount();
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
int intRecCount = clsFieldTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFieldTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFieldTypeEN objFieldTypeCond)
{
List<clsFieldTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldType._AttributeName)
{
if (objFieldTypeCond.IsUpdated(strFldName) == false) continue;
if (objFieldTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTypeCond[strFldName].ToString());
}
else
{
if (objFieldTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTypeCond[strFldName]));
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
 List<string> arrList = clsFieldTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FieldTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FieldTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FieldTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTypeDA.SetFldValue(clsFieldTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FieldTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FieldType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) primary key, "); 
 // /**字段类型名*/ 
 strCreateTabCode.Append(" FieldTypeName varchar(30) not Null, "); 
 // /**字段类型英文名*/ 
 strCreateTabCode.Append(" FieldTypeENName varchar(30) Null, "); 
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
string strCondition = string.Format("1 = 1 order by {0} ", conFieldType.OrderNum); 
List<clsFieldTypeEN> arrFieldTypeObjList = new clsFieldTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFieldTypeEN objFieldType in arrFieldTypeObjList)
{
objFieldType.OrderNum = intIndex;
UpdateBySql2(objFieldType);
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
/// <param name="strFieldTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strFieldTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FieldTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FieldTypeId
//5、把当前关键字FieldTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FieldTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFieldTypeId = "";    //上一条序号的关键字FieldTypeId
string strNextFieldTypeId = "";    //下一条序号的关键字FieldTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[FieldTypeId],获取相应的序号[OrderNum]。

clsFieldTypeEN objFieldType = clsFieldTypeBL.GetObjByFieldTypeId(strFieldTypeId);

intOrderNum = objFieldType.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsFieldTypeBL.GetRecCountByCond(clsFieldTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conFieldType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字FieldTypeId
strPrevFieldTypeId = clsFieldTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevFieldTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FieldTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字FieldTypeId所对应的记录序号加1
clsFieldTypeBL.SetFldValue(clsFieldTypeEN._CurrTabName, conFieldType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conFieldType.FieldTypeId, strFieldTypeId));
clsFieldTypeBL.SetFldValue(clsFieldTypeEN._CurrTabName, conFieldType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conFieldType.FieldTypeId, strPrevFieldTypeId));
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

//4、获取下一个序号字段的关键字FieldTypeId
strCondition.AppendFormat(" {0} = {1}", conFieldType.OrderNum, intOrderNum + 1);

strNextFieldTypeId = clsFieldTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextFieldTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FieldTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字FieldTypeId所对应的记录序号减1
clsFieldTypeBL.SetFldValue(clsFieldTypeEN._CurrTabName, conFieldType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conFieldType.FieldTypeId, strFieldTypeId));
clsFieldTypeBL.SetFldValue(clsFieldTypeEN._CurrTabName, conFieldType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conFieldType.FieldTypeId, strNextFieldTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsFieldTypeBL.ReFreshCache();
if (clsFieldTypeBL.relatedActions != null)
{
clsFieldTypeBL.relatedActions.UpdRelaTabDate(objFieldType.FieldTypeId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", conFieldType.FieldTypeId, strKeyList);
List<clsFieldTypeEN> arrFieldTypeLst = GetObjLst(strCondition);
foreach (clsFieldTypeEN objFieldType in arrFieldTypeLst)
{
objFieldType.OrderNum = objFieldType.OrderNum + 10000;
UpdateBySql2(objFieldType);
}
strCondition = string.Format("1 = 1 order by {0} ", conFieldType.OrderNum); 
List<clsFieldTypeEN> arrFieldTypeObjList = new clsFieldTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFieldTypeEN objFieldType in arrFieldTypeObjList)
{
objFieldType.OrderNum = intIndex;
UpdateBySql2(objFieldType);
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
string strCondition = string.Format("{0} in ({1})", conFieldType.FieldTypeId, strKeyList);
List<clsFieldTypeEN> arrFieldTypeLst = GetObjLst(strCondition);
foreach (clsFieldTypeEN objFieldType in arrFieldTypeLst)
{
objFieldType.OrderNum = objFieldType.OrderNum - 10000;
UpdateBySql2(objFieldType);
}
strCondition = string.Format("1 = 1 order by {0} ", conFieldType.OrderNum); 
List<clsFieldTypeEN> arrFieldTypeObjList = new clsFieldTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFieldTypeEN objFieldType in arrFieldTypeObjList)
{
objFieldType.OrderNum = intIndex;
UpdateBySql2(objFieldType);
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
 /// 字段类型(FieldType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FieldType : clsCommFun4BL
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
clsFieldTypeBL.ReFreshThisCache();
}
}

}