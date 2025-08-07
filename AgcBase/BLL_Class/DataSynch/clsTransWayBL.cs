
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTransWayBL
 表名:TransWay(00050268)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsTransWayBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTransWayId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTransWayEN GetObj(this K_TransWayId_TransWay myKey)
{
clsTransWayEN objTransWayEN = clsTransWayBL.TransWayDA.GetObjByTransWayId(myKey.Value);
return objTransWayEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTransWayBL.IsExist(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTransWayEN.TransWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsTransWayBL.TransWayDA.AddNewRecordBySQL2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTransWayEN objTransWayEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTransWayBL.IsExist(objTransWayEN.TransWayId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTransWayEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTransWayEN.AddNewRecord();
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTransWayBL.IsExist(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTransWayEN.TransWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsTransWayBL.TransWayDA.AddNewRecordBySQL2WithReturnKey(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTransWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTransWayEN SetTransWayId(this clsTransWayEN objTransWayEN, string strTransWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransWayId, 2, conTransWay.TransWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTransWayId, 2, conTransWay.TransWayId);
}
objTransWayEN.TransWayId = strTransWayId; //转换方式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTransWayEN.dicFldComparisonOp.ContainsKey(conTransWay.TransWayId) == false)
{
objTransWayEN.dicFldComparisonOp.Add(conTransWay.TransWayId, strComparisonOp);
}
else
{
objTransWayEN.dicFldComparisonOp[conTransWay.TransWayId] = strComparisonOp;
}
}
return objTransWayEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTransWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTransWayEN SetTransWayName(this clsTransWayEN objTransWayEN, string strTransWayName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTransWayName, conTransWay.TransWayName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTransWayName, 30, conTransWay.TransWayName);
}
objTransWayEN.TransWayName = strTransWayName; //转换方式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTransWayEN.dicFldComparisonOp.ContainsKey(conTransWay.TransWayName) == false)
{
objTransWayEN.dicFldComparisonOp.Add(conTransWay.TransWayName, strComparisonOp);
}
else
{
objTransWayEN.dicFldComparisonOp[conTransWay.TransWayName] = strComparisonOp;
}
}
return objTransWayEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTransWayEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTransWayEN SetMemo(this clsTransWayEN objTransWayEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTransWay.Memo);
}
objTransWayEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTransWayEN.dicFldComparisonOp.ContainsKey(conTransWay.Memo) == false)
{
objTransWayEN.dicFldComparisonOp.Add(conTransWay.Memo, strComparisonOp);
}
else
{
objTransWayEN.dicFldComparisonOp[conTransWay.Memo] = strComparisonOp;
}
}
return objTransWayEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTransWayEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTransWayEN objTransWayEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTransWayEN.CheckPropertyNew();
clsTransWayEN objTransWayCond = new clsTransWayEN();
string strCondition = objTransWayCond
.SetTransWayId(objTransWayEN.TransWayId, "=")
.GetCombineCondition();
objTransWayEN._IsCheckProperty = true;
bool bolIsExist = clsTransWayBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTransWayEN.Update();
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTransWayBL.TransWayDA.UpdateBySql2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTransWayEN objTransWayEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTransWayBL.TransWayDA.UpdateBySql2(objTransWayEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTransWayEN objTransWayEN, string strWhereCond)
{
try
{
bool bolResult = clsTransWayBL.TransWayDA.UpdateBySqlWithCondition(objTransWayEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTransWayEN objTransWayEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTransWayBL.TransWayDA.UpdateBySqlWithConditionTransaction(objTransWayEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "strTransWayId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTransWayEN objTransWayEN)
{
try
{
int intRecNum = clsTransWayBL.TransWayDA.DelRecord(objTransWayEN.TransWayId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayENS">源对象</param>
 /// <param name = "objTransWayENT">目标对象</param>
 public static void CopyTo(this clsTransWayEN objTransWayENS, clsTransWayEN objTransWayENT)
{
try
{
objTransWayENT.TransWayId = objTransWayENS.TransWayId; //转换方式ID
objTransWayENT.TransWayName = objTransWayENS.TransWayName; //转换方式名称
objTransWayENT.Memo = objTransWayENS.Memo; //说明
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
 /// <param name = "objTransWayENS">源对象</param>
 /// <returns>目标对象=>clsTransWayEN:objTransWayENT</returns>
 public static clsTransWayEN CopyTo(this clsTransWayEN objTransWayENS)
{
try
{
 clsTransWayEN objTransWayENT = new clsTransWayEN()
{
TransWayId = objTransWayENS.TransWayId, //转换方式ID
TransWayName = objTransWayENS.TransWayName, //转换方式名称
Memo = objTransWayENS.Memo, //说明
};
 return objTransWayENT;
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
public static void CheckPropertyNew(this clsTransWayEN objTransWayEN)
{
 clsTransWayBL.TransWayDA.CheckPropertyNew(objTransWayEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTransWayEN objTransWayEN)
{
 clsTransWayBL.TransWayDA.CheckProperty4Condition(objTransWayEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTransWayEN objTransWayCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTransWayCond.IsUpdated(conTransWay.TransWayId) == true)
{
string strComparisonOpTransWayId = objTransWayCond.dicFldComparisonOp[conTransWay.TransWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTransWay.TransWayId, objTransWayCond.TransWayId, strComparisonOpTransWayId);
}
if (objTransWayCond.IsUpdated(conTransWay.TransWayName) == true)
{
string strComparisonOpTransWayName = objTransWayCond.dicFldComparisonOp[conTransWay.TransWayName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTransWay.TransWayName, objTransWayCond.TransWayName, strComparisonOpTransWayName);
}
if (objTransWayCond.IsUpdated(conTransWay.Memo) == true)
{
string strComparisonOpMemo = objTransWayCond.dicFldComparisonOp[conTransWay.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTransWay.Memo, objTransWayCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TransWay
{
public virtual bool UpdRelaTabDate(string strTransWayId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 转换方式(TransWay)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTransWayBL
{
public static RelatedActions_TransWay relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "TransWayListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "TransWayList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsTransWayEN> arrTransWayObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTransWayDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTransWayDA TransWayDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTransWayDA();
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
 public clsTransWayBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsTransWayEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTransWayEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = TransWayDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = TransWayDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = TransWayDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_TransWay(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTable_TransWay(strWhereCond);
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
objDT = TransWayDA.GetDataTable(strWhereCond);
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
objDT = TransWayDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TransWayDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TransWayDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TransWayDA.GetDataTable_Top(objTopPara);
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
objDT = TransWayDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = TransWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TransWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = TransWayDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrTransWayIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTransWayEN> GetObjLstByTransWayIdLst(List<string> arrTransWayIdLst)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTransWayIdLst, true);
 string strWhereCond = string.Format("TransWayId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTransWayIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTransWayEN> GetObjLstByTransWayIdLstCache(List<string> arrTransWayIdLst)
{
string strKey = string.Format("{0}", clsTransWayEN._CurrTabName);
List<clsTransWayEN> arrTransWayObjLstCache = GetObjLstCache();
IEnumerable <clsTransWayEN> arrTransWayObjLst_Sel =
arrTransWayObjLstCache
.Where(x => arrTransWayIdLst.Contains(x.TransWayId));
return arrTransWayObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetObjLst(string strWhereCond)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
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
public static List<clsTransWayEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTransWayCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTransWayEN> GetSubObjLstCache(clsTransWayEN objTransWayCond)
{
List<clsTransWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTransWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTransWay.AttributeName)
{
if (objTransWayCond.IsUpdated(strFldName) == false) continue;
if (objTransWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else
{
if (objTransWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTransWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTransWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
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
public static List<clsTransWayEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
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
public static List<clsTransWayEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
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
List<clsTransWayEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTransWayEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTransWayEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
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
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
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
public static List<clsTransWayEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTransWayEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTransWayEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
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
public static List<clsTransWayEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsTransWayEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsTransWayEN objTransWayCond, string strOrderBy)
{
List<clsTransWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTransWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTransWay.AttributeName)
{
if (objTransWayCond.IsUpdated(strFldName) == false) continue;
if (objTransWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else
{
if (objTransWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTransWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTransWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsTransWayEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsTransWayEN objTransWayCond = JsonConvert.DeserializeObject<clsTransWayEN>(objPagerPara.whereCond);
if (objTransWayCond.sfFldComparisonOp == null)
{
objTransWayCond.dicFldComparisonOp = null;
}
else
{
objTransWayCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objTransWayCond.sfFldComparisonOp);
}
clsTransWayBL.SetUpdFlag(objTransWayCond);
 try
{
CheckProperty4Condition(objTransWayCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsTransWayBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objTransWayCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTransWayEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTransWayEN> arrObjLst = new List<clsTransWayEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTransWayEN objTransWayEN = new clsTransWayEN();
try
{
objTransWayEN.TransWayId = objRow[conTransWay.TransWayId].ToString().Trim(); //转换方式ID
objTransWayEN.TransWayName = objRow[conTransWay.TransWayName].ToString().Trim(); //转换方式名称
objTransWayEN.Memo = objRow[conTransWay.Memo] == DBNull.Value ? null : objRow[conTransWay.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTransWayEN.TransWayId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTransWayEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTransWayEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTransWay(ref clsTransWayEN objTransWayEN)
{
bool bolResult = TransWayDA.GetTransWay(ref objTransWayEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTransWayId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTransWayEN GetObjByTransWayId(string strTransWayId)
{
if (strTransWayId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTransWayId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTransWayId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTransWayId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTransWayEN objTransWayEN = TransWayDA.GetObjByTransWayId(strTransWayId);
return objTransWayEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTransWayEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTransWayEN objTransWayEN = TransWayDA.GetFirstObj(strWhereCond);
 return objTransWayEN;
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
public static clsTransWayEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTransWayEN objTransWayEN = TransWayDA.GetObjByDataRow(objRow);
 return objTransWayEN;
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
public static clsTransWayEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTransWayEN objTransWayEN = TransWayDA.GetObjByDataRow(objRow);
 return objTransWayEN;
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
 /// <param name = "strTransWayId">所给的关键字</param>
 /// <param name = "lstTransWayObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTransWayEN GetObjByTransWayIdFromList(string strTransWayId, List<clsTransWayEN> lstTransWayObjLst)
{
foreach (clsTransWayEN objTransWayEN in lstTransWayObjLst)
{
if (objTransWayEN.TransWayId == strTransWayId)
{
return objTransWayEN;
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
 string strTransWayId;
 try
 {
 strTransWayId = new clsTransWayDA().GetFirstID(strWhereCond);
 return strTransWayId;
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
 arrList = TransWayDA.GetID(strWhereCond);
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
bool bolIsExist = TransWayDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTransWayId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTransWayId)
{
if (string.IsNullOrEmpty(strTransWayId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTransWayId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TransWayDA.IsExist(strTransWayId);
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
 bolIsExist = clsTransWayDA.IsExistTable();
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
 bolIsExist = TransWayDA.IsExistTable(strTabName);
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTransWayBL.IsExist(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTransWayEN.TransWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = TransWayDA.AddNewRecordBySQL2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTransWayBL.IsExist(objTransWayEN.TransWayId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTransWayEN.TransWayId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = TransWayDA.AddNewRecordBySQL2WithReturnKey(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strTransWayObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strTransWayObjXml)
{
clsTransWayEN objTransWayEN = GetObjFromXmlStr(strTransWayObjXml);
try
{
bool bolResult = TransWayDA.AddNewRecordBySQL2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTransWayEN objTransWayEN)
{
try
{
bool bolResult = TransWayDA.Update(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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
 /// <param name = "objTransWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTransWayEN objTransWayEN)
{
 if (string.IsNullOrEmpty(objTransWayEN.TransWayId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TransWayDA.UpdateBySql2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strTransWayObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strTransWayObjXml)
{
clsTransWayEN objTransWayEN = GetObjFromXmlStr(strTransWayObjXml);
try
{
bool bolResult = TransWayDA.UpdateBySql2(objTransWayEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTransWayBL.ReFreshCache();

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "strTransWayId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTransWayId)
{
try
{
 clsTransWayEN objTransWayEN = clsTransWayBL.GetObjByTransWayId(strTransWayId);

if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(objTransWayEN.TransWayId, "SetUpdDate");
}
if (objTransWayEN != null)
{
int intRecNum = TransWayDA.DelRecord(strTransWayId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strTransWayId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTransWayId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTransWayDA.GetSpecSQLObj();
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
//删除与表:[TransWay]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTransWay.TransWayId,
//strTransWayId);
//        clsTransWayBL.DelTransWaysByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTransWayBL.DelRecord(strTransWayId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTransWayBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strTransWayId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTransWayId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTransWayId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(strTransWayId, "UpdRelaTabDate");
}
bool bolResult = TransWayDA.DelRecord(strTransWayId,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "strTransWayId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTransWayId) 
{
try
{
if (clsTransWayBL.relatedActions != null)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(strTransWayId, "UpdRelaTabDate");
}
bool bolResult = TransWayDA.DelRecordBySP(strTransWayId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrTransWayIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTransWays(List<string> arrTransWayIdLst)
{
if (arrTransWayIdLst.Count == 0) return 0;
try
{
if (clsTransWayBL.relatedActions != null)
{
foreach (var strTransWayId in arrTransWayIdLst)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(strTransWayId, "UpdRelaTabDate");
}
}
int intDelRecNum = TransWayDA.DelTransWay(arrTransWayIdLst);
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
public static int DelTransWaysByCond(string strWhereCond)
{
try
{
if (clsTransWayBL.relatedActions != null)
{
List<string> arrTransWayId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTransWayId in arrTransWayId)
{
clsTransWayBL.relatedActions.UpdRelaTabDate(strTransWayId, "UpdRelaTabDate");
}
}
int intRecNum = TransWayDA.DelTransWay(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[TransWay]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTransWayId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTransWayId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTransWayDA.GetSpecSQLObj();
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
//删除与表:[TransWay]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTransWayBL.DelRecord(strTransWayId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTransWayBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strTransWayId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTransWayENS">源对象</param>
 /// <param name = "objTransWayENT">目标对象</param>
 public static void CopyTo(clsTransWayEN objTransWayENS, clsTransWayEN objTransWayENT)
{
try
{
objTransWayENT.TransWayId = objTransWayENS.TransWayId; //转换方式ID
objTransWayENT.TransWayName = objTransWayENS.TransWayName; //转换方式名称
objTransWayENT.Memo = objTransWayENS.Memo; //说明
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
 /// <param name = "objTransWayEN">源简化对象</param>
 public static void SetUpdFlag(clsTransWayEN objTransWayEN)
{
try
{
objTransWayEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objTransWayEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTransWay.TransWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objTransWayEN.TransWayId = objTransWayEN.TransWayId; //转换方式ID
}
if (arrFldSet.Contains(conTransWay.TransWayName, new clsStrCompareIgnoreCase())  ==  true)
{
objTransWayEN.TransWayName = objTransWayEN.TransWayName; //转换方式名称
}
if (arrFldSet.Contains(conTransWay.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTransWayEN.Memo = objTransWayEN.Memo == "[null]" ? null :  objTransWayEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objTransWayEN">源简化对象</param>
 public static void AccessFldValueNull(clsTransWayEN objTransWayEN)
{
try
{
if (objTransWayEN.Memo == "[null]") objTransWayEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsTransWayEN objTransWayEN)
{
 TransWayDA.CheckPropertyNew(objTransWayEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTransWayEN objTransWayEN)
{
 TransWayDA.CheckProperty4Condition(objTransWayEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_TransWayId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTransWay.TransWayId); 
List<clsTransWayEN> arrObjLst = clsTransWayBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTransWayEN objTransWayEN = new clsTransWayEN()
{
TransWayId = "0",
TransWayName = "选[转换方式]..."
};
arrObjLst.Insert(0, objTransWayEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTransWay.TransWayId;
objComboBox.DisplayMember = conTransWay.TransWayName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlTransWayId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[转换方式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conTransWay.TransWayId); 
IEnumerable<clsTransWayEN> arrObjLst = clsTransWayBL.GetObjLst(strCondition);
objDDL.DataValueField = conTransWay.TransWayId;
objDDL.DataTextField = conTransWay.TransWayName;
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
public static void BindDdlTransWayIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[转换方式]...","0");
List<clsTransWayEN> arrTransWayObjLst = GetAllTransWayObjLstCache(); 
objDDL.DataValueField = conTransWay.TransWayId;
objDDL.DataTextField = conTransWay.TransWayName;
objDDL.DataSource = arrTransWayObjLst;
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
if (clsTransWayBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTransWayBL没有刷新缓存机制(clsTransWayBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TransWayId");
//if (arrTransWayObjLstCache == null)
//{
//arrTransWayObjLstCache = TransWayDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTransWayId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTransWayEN GetObjByTransWayIdCache(string strTransWayId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTransWayEN._CurrTabName);
List<clsTransWayEN> arrTransWayObjLstCache = GetObjLstCache();
IEnumerable <clsTransWayEN> arrTransWayObjLst_Sel =
arrTransWayObjLstCache
.Where(x=> x.TransWayId == strTransWayId 
);
if (arrTransWayObjLst_Sel.Count() == 0)
{
   clsTransWayEN obj = clsTransWayBL.GetObjByTransWayId(strTransWayId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTransWayObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTransWayId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTransWayNameByTransWayIdCache(string strTransWayId)
{
if (string.IsNullOrEmpty(strTransWayId) == true) return "";
//获取缓存中的对象列表
clsTransWayEN objTransWay = GetObjByTransWayIdCache(strTransWayId);
if (objTransWay == null) return "";
return objTransWay.TransWayName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTransWayId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTransWayIdCache(string strTransWayId)
{
if (string.IsNullOrEmpty(strTransWayId) == true) return "";
//获取缓存中的对象列表
clsTransWayEN objTransWay = GetObjByTransWayIdCache(strTransWayId);
if (objTransWay == null) return "";
return objTransWay.TransWayName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTransWayEN> GetAllTransWayObjLstCache()
{
//获取缓存中的对象列表
List<clsTransWayEN> arrTransWayObjLstCache = GetObjLstCache(); 
return arrTransWayObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTransWayEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTransWayEN._CurrTabName);
List<clsTransWayEN> arrTransWayObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTransWayObjLstCache;
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
string strKey = string.Format("{0}", clsTransWayEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsTransWayBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTransWayEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTransWayBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstTransWayObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsTransWayEN> lstTransWayObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstTransWayObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstTransWayObjLst">[clsTransWayEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsTransWayEN> lstTransWayObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsTransWayBL.listXmlNode);
writer.WriteStartElement(clsTransWayBL.itemsXmlNode);
foreach (clsTransWayEN objTransWayEN in lstTransWayObjLst)
{
clsTransWayBL.SerializeXML(writer, objTransWayEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objTransWayEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsTransWayEN objTransWayEN)
{
writer.WriteStartElement(clsTransWayBL.itemXmlNode);
 
if (objTransWayEN.TransWayId != null)
{
writer.WriteElementString(conTransWay.TransWayId, objTransWayEN.TransWayId.ToString(CultureInfo.InvariantCulture));
}
 
if (objTransWayEN.TransWayName != null)
{
writer.WriteElementString(conTransWay.TransWayName, objTransWayEN.TransWayName.ToString(CultureInfo.InvariantCulture));
}
 
if (objTransWayEN.Memo != null)
{
writer.WriteElementString(conTransWay.Memo, objTransWayEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsTransWayEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsTransWayEN objTransWayEN = new clsTransWayEN();
reader.Read();
while (!(reader.Name == clsTransWayBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conTransWay.TransWayId))
{
objTransWayEN.TransWayId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conTransWay.TransWayName))
{
objTransWayEN.TransWayName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conTransWay.Memo))
{
objTransWayEN.Memo = reader.ReadElementContentAsString();
}
}
return objTransWayEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strTransWayObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsTransWayEN GetObjFromXmlStr(string strTransWayObjXmlStr)
{
clsTransWayEN objTransWayEN = new clsTransWayEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strTransWayObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsTransWayBL.itemXmlNode))
{
objTransWayEN = GetObjFromXml(reader);
return objTransWayEN;
}
}
return objTransWayEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objTransWayEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsTransWayEN objTransWayEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objTransWayEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTransWayId)
{
if (strInFldName != conTransWay.TransWayId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTransWay.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTransWay.AttributeName));
throw new Exception(strMsg);
}
var objTransWay = clsTransWayBL.GetObjByTransWayIdCache(strTransWayId);
if (objTransWay == null) return "";
return objTransWay[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objTransWayEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsTransWayEN objTransWayEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsTransWayEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objTransWayEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstTransWayObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsTransWayEN> lstTransWayObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstTransWayObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsTransWayEN objTransWayEN in lstTransWayObjLst)
{
string strJSON_One = SerializeObjToJSON(objTransWayEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsTransWayDA.GetRecCount(strTabName);
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
int intRecCount = clsTransWayDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTransWayDA.GetRecCount();
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
int intRecCount = clsTransWayDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTransWayCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTransWayEN objTransWayCond)
{
List<clsTransWayEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTransWayEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTransWay.AttributeName)
{
if (objTransWayCond.IsUpdated(strFldName) == false) continue;
if (objTransWayCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else
{
if (objTransWayCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTransWayCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTransWayCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTransWayCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTransWayCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTransWayCond[strFldName]));
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
 List<string> arrList = clsTransWayDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TransWayDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TransWayDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TransWayDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTransWayDA.SetFldValue(clsTransWayEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TransWayDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTransWayDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTransWayDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTransWayDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TransWay] "); 
 strCreateTabCode.Append(" ( "); 
 // /**转换方式ID*/ 
 strCreateTabCode.Append(" TransWayId char(2) primary key, "); 
 // /**转换方式名称*/ 
 strCreateTabCode.Append(" TransWayName varchar(30) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 转换方式(TransWay)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4TransWay : clsCommFun4BL
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
clsTransWayBL.ReFreshThisCache();
}
}

}