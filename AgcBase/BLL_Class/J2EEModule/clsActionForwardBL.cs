
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsActionForwardBL
 表名:ActionForward(00050143)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:J2EE模块(J2EEModule)
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
public static class  clsActionForwardBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngActionForwardId">表关键字</param>
 /// <returns>表对象</returns>
public static clsActionForwardEN GetObj(this K_ActionForwardId_ActionForward myKey)
{
clsActionForwardEN objActionForwardEN = clsActionForwardBL.ActionForwardDA.GetObjByActionForwardId(myKey.Value);
return objActionForwardEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsActionForwardEN objActionForwardEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objActionForwardEN) == false)
{
var strMsg = string.Format("记录已经存在!ActionId = [{0}],Forward名称 = [{1}]的数据已经存在!(in clsActionForwardBL.AddNewRecord)", objActionForwardEN.ActionId,objActionForwardEN.ForwardName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsActionForwardBL.ActionForwardDA.AddNewRecordBySQL2(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
public static bool AddRecordEx(this clsActionForwardEN objActionForwardEN, bool bolIsNeedCheckUniqueness = true)
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
objActionForwardEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objActionForwardEN.CheckUniqueness() == false)
{
strMsg = string.Format("(ActionId(ActionId)=[{0}],Forward名称(ForwardName)=[{1}])已经存在,不能重复!", objActionForwardEN.ActionId, objActionForwardEN.ForwardName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objActionForwardEN.AddNewRecord();
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsActionForwardEN objActionForwardEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objActionForwardEN) == false)
{
var strMsg = string.Format("记录已经存在!ActionId = [{0}],Forward名称 = [{1}]的数据已经存在!(in clsActionForwardBL.AddNewRecordWithReturnKey)", objActionForwardEN.ActionId,objActionForwardEN.ForwardName);
throw new Exception(strMsg);
}
try
{
string strKey = clsActionForwardBL.ActionForwardDA.AddNewRecordBySQL2WithReturnKey(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsActionForwardEN SetActionForwardId(this clsActionForwardEN objActionForwardEN, long lngActionForwardId, string strComparisonOp="")
	{
objActionForwardEN.ActionForwardId = lngActionForwardId; //ActionForwardId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionForwardEN.dicFldComparisonOp.ContainsKey(conActionForward.ActionForwardId) == false)
{
objActionForwardEN.dicFldComparisonOp.Add(conActionForward.ActionForwardId, strComparisonOp);
}
else
{
objActionForwardEN.dicFldComparisonOp[conActionForward.ActionForwardId] = strComparisonOp;
}
}
return objActionForwardEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionForwardEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsActionForwardEN SetActionId(this clsActionForwardEN objActionForwardEN, string strActionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionId, conActionForward.ActionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActionId, 10, conActionForward.ActionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strActionId, 10, conActionForward.ActionId);
}
objActionForwardEN.ActionId = strActionId; //ActionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionForwardEN.dicFldComparisonOp.ContainsKey(conActionForward.ActionId) == false)
{
objActionForwardEN.dicFldComparisonOp.Add(conActionForward.ActionId, strComparisonOp);
}
else
{
objActionForwardEN.dicFldComparisonOp[conActionForward.ActionId] = strComparisonOp;
}
}
return objActionForwardEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionForwardEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsActionForwardEN SetForwardName(this clsActionForwardEN objActionForwardEN, string strForwardName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForwardName, conActionForward.ForwardName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForwardName, 50, conActionForward.ForwardName);
}
objActionForwardEN.ForwardName = strForwardName; //Forward名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionForwardEN.dicFldComparisonOp.ContainsKey(conActionForward.ForwardName) == false)
{
objActionForwardEN.dicFldComparisonOp.Add(conActionForward.ForwardName, strComparisonOp);
}
else
{
objActionForwardEN.dicFldComparisonOp[conActionForward.ForwardName] = strComparisonOp;
}
}
return objActionForwardEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionForwardEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsActionForwardEN SetForwardPath(this clsActionForwardEN objActionForwardEN, string strForwardPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForwardPath, 50, conActionForward.ForwardPath);
}
objActionForwardEN.ForwardPath = strForwardPath; //Forward路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionForwardEN.dicFldComparisonOp.ContainsKey(conActionForward.ForwardPath) == false)
{
objActionForwardEN.dicFldComparisonOp.Add(conActionForward.ForwardPath, strComparisonOp);
}
else
{
objActionForwardEN.dicFldComparisonOp[conActionForward.ForwardPath] = strComparisonOp;
}
}
return objActionForwardEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objActionForwardEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsActionForwardEN objActionForwardEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objActionForwardEN.CheckPropertyNew();
clsActionForwardEN objActionForwardCond = new clsActionForwardEN();
string strCondition = objActionForwardCond
.SetActionForwardId(objActionForwardEN.ActionForwardId, "<>")
.SetActionId(objActionForwardEN.ActionId, "=")
.SetForwardName(objActionForwardEN.ForwardName, "=")
.GetCombineCondition();
objActionForwardEN._IsCheckProperty = true;
bool bolIsExist = clsActionForwardBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ActionId_ForwardName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objActionForwardEN.Update();
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
 /// <param name = "objActionForward">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsActionForwardEN objActionForward)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsActionForwardEN objActionForwardCond = new clsActionForwardEN();
string strCondition = objActionForwardCond
.SetActionId(objActionForward.ActionId, "=")
.SetForwardName(objActionForward.ForwardName, "=")
.GetCombineCondition();
objActionForward._IsCheckProperty = true;
bool bolIsExist = clsActionForwardBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objActionForward.ActionForwardId = clsActionForwardBL.GetFirstID_S(strCondition);
objActionForward.UpdateWithCondition(strCondition);
}
else
{
objActionForward.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN.ActionForwardId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsActionForwardBL.ActionForwardDA.UpdateBySql2(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsActionForwardEN objActionForwardEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objActionForwardEN.ActionForwardId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsActionForwardBL.ActionForwardDA.UpdateBySql2(objActionForwardEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsActionForwardEN objActionForwardEN, string strWhereCond)
{
try
{
bool bolResult = clsActionForwardBL.ActionForwardDA.UpdateBySqlWithCondition(objActionForwardEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsActionForwardEN objActionForwardEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsActionForwardBL.ActionForwardDA.UpdateBySqlWithConditionTransaction(objActionForwardEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsActionForwardEN objActionForwardEN)
{
try
{
int intRecNum = clsActionForwardBL.ActionForwardDA.DelRecord(objActionForwardEN.ActionForwardId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardENS">源对象</param>
 /// <param name = "objActionForwardENT">目标对象</param>
 public static void CopyTo(this clsActionForwardEN objActionForwardENS, clsActionForwardEN objActionForwardENT)
{
try
{
objActionForwardENT.ActionForwardId = objActionForwardENS.ActionForwardId; //ActionForwardId
objActionForwardENT.ActionId = objActionForwardENS.ActionId; //ActionId
objActionForwardENT.ForwardName = objActionForwardENS.ForwardName; //Forward名称
objActionForwardENT.ForwardPath = objActionForwardENS.ForwardPath; //Forward路径
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
 /// <param name = "objActionForwardENS">源对象</param>
 /// <returns>目标对象=>clsActionForwardEN:objActionForwardENT</returns>
 public static clsActionForwardEN CopyTo(this clsActionForwardEN objActionForwardENS)
{
try
{
 clsActionForwardEN objActionForwardENT = new clsActionForwardEN()
{
ActionForwardId = objActionForwardENS.ActionForwardId, //ActionForwardId
ActionId = objActionForwardENS.ActionId, //ActionId
ForwardName = objActionForwardENS.ForwardName, //Forward名称
ForwardPath = objActionForwardENS.ForwardPath, //Forward路径
};
 return objActionForwardENT;
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
public static void CheckPropertyNew(this clsActionForwardEN objActionForwardEN)
{
 clsActionForwardBL.ActionForwardDA.CheckPropertyNew(objActionForwardEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsActionForwardEN objActionForwardEN)
{
 clsActionForwardBL.ActionForwardDA.CheckProperty4Condition(objActionForwardEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsActionForwardEN objActionForwardCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objActionForwardCond.IsUpdated(conActionForward.ActionForwardId) == true)
{
string strComparisonOpActionForwardId = objActionForwardCond.dicFldComparisonOp[conActionForward.ActionForwardId];
strWhereCond += string.Format(" And {0} {2} {1}", conActionForward.ActionForwardId, objActionForwardCond.ActionForwardId, strComparisonOpActionForwardId);
}
if (objActionForwardCond.IsUpdated(conActionForward.ActionId) == true)
{
string strComparisonOpActionId = objActionForwardCond.dicFldComparisonOp[conActionForward.ActionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conActionForward.ActionId, objActionForwardCond.ActionId, strComparisonOpActionId);
}
if (objActionForwardCond.IsUpdated(conActionForward.ForwardName) == true)
{
string strComparisonOpForwardName = objActionForwardCond.dicFldComparisonOp[conActionForward.ForwardName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conActionForward.ForwardName, objActionForwardCond.ForwardName, strComparisonOpForwardName);
}
if (objActionForwardCond.IsUpdated(conActionForward.ForwardPath) == true)
{
string strComparisonOpForwardPath = objActionForwardCond.dicFldComparisonOp[conActionForward.ForwardPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conActionForward.ForwardPath, objActionForwardCond.ForwardPath, strComparisonOpForwardPath);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ActionForward(ActionForward), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ActionId_ForwardName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objActionForwardEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsActionForwardEN objActionForwardEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objActionForwardEN == null) return true;
if (objActionForwardEN.ActionForwardId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ActionId = '{0}'", objActionForwardEN.ActionId);
 sbCondition.AppendFormat(" and ForwardName = '{0}'", objActionForwardEN.ForwardName);
if (clsActionForwardBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ActionForwardId !=  {0}", objActionForwardEN.ActionForwardId);
 sbCondition.AppendFormat(" and ActionId = '{0}'", objActionForwardEN.ActionId);
 sbCondition.AppendFormat(" and ForwardName = '{0}'", objActionForwardEN.ForwardName);
if (clsActionForwardBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ActionForward(ActionForward), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ActionId_ForwardName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objActionForwardEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsActionForwardEN objActionForwardEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objActionForwardEN == null) return "";
if (objActionForwardEN.ActionForwardId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ActionId = '{0}'", objActionForwardEN.ActionId);
 sbCondition.AppendFormat(" and ForwardName = '{0}'", objActionForwardEN.ForwardName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ActionForwardId !=  {0}", objActionForwardEN.ActionForwardId);
 sbCondition.AppendFormat(" and ActionId = '{0}'", objActionForwardEN.ActionId);
 sbCondition.AppendFormat(" and ForwardName = '{0}'", objActionForwardEN.ForwardName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ActionForward
{
public virtual bool UpdRelaTabDate(long lngActionForwardId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// ActionForward(ActionForward)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsActionForwardBL
{
public static RelatedActions_ActionForward relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsActionForwardDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsActionForwardDA ActionForwardDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsActionForwardDA();
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
 public clsActionForwardBL()
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
if (string.IsNullOrEmpty(clsActionForwardEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsActionForwardEN._ConnectString);
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
public static DataTable GetDataTable_ActionForward(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ActionForwardDA.GetDataTable_ActionForward(strWhereCond);
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
objDT = ActionForwardDA.GetDataTable(strWhereCond);
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
objDT = ActionForwardDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ActionForwardDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ActionForwardDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ActionForwardDA.GetDataTable_Top(objTopPara);
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
objDT = ActionForwardDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ActionForwardDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ActionForwardDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrActionForwardIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsActionForwardEN> GetObjLstByActionForwardIdLst(List<long> arrActionForwardIdLst)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrActionForwardIdLst);
 string strWhereCond = string.Format("ActionForwardId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrActionForwardIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsActionForwardEN> GetObjLstByActionForwardIdLstCache(List<long> arrActionForwardIdLst)
{
string strKey = string.Format("{0}", clsActionForwardEN._CurrTabName);
List<clsActionForwardEN> arrActionForwardObjLstCache = GetObjLstCache();
IEnumerable <clsActionForwardEN> arrActionForwardObjLst_Sel =
arrActionForwardObjLstCache
.Where(x => arrActionForwardIdLst.Contains(x.ActionForwardId));
return arrActionForwardObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsActionForwardEN> GetObjLst(string strWhereCond)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
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
public static List<clsActionForwardEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objActionForwardCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsActionForwardEN> GetSubObjLstCache(clsActionForwardEN objActionForwardCond)
{
List<clsActionForwardEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsActionForwardEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conActionForward._AttributeName)
{
if (objActionForwardCond.IsUpdated(strFldName) == false) continue;
if (objActionForwardCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objActionForwardCond[strFldName].ToString());
}
else
{
if (objActionForwardCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objActionForwardCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objActionForwardCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objActionForwardCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objActionForwardCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objActionForwardCond[strFldName]));
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
public static List<clsActionForwardEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
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
public static List<clsActionForwardEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
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
List<clsActionForwardEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsActionForwardEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsActionForwardEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsActionForwardEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
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
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
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
public static List<clsActionForwardEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsActionForwardEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsActionForwardEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
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
public static List<clsActionForwardEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsActionForwardEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsActionForwardEN> arrObjLst = new List<clsActionForwardEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsActionForwardEN objActionForwardEN = new clsActionForwardEN();
try
{
objActionForwardEN.ActionForwardId = Int32.Parse(objRow[conActionForward.ActionForwardId].ToString().Trim()); //ActionForwardId
objActionForwardEN.ActionId = objRow[conActionForward.ActionId].ToString().Trim(); //ActionId
objActionForwardEN.ForwardName = objRow[conActionForward.ForwardName].ToString().Trim(); //Forward名称
objActionForwardEN.ForwardPath = objRow[conActionForward.ForwardPath] == DBNull.Value ? null : objRow[conActionForward.ForwardPath].ToString().Trim(); //Forward路径
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objActionForwardEN.ActionForwardId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objActionForwardEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objActionForwardEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetActionForward(ref clsActionForwardEN objActionForwardEN)
{
bool bolResult = ActionForwardDA.GetActionForward(ref objActionForwardEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngActionForwardId">表关键字</param>
 /// <returns>表对象</returns>
public static clsActionForwardEN GetObjByActionForwardId(long lngActionForwardId)
{
clsActionForwardEN objActionForwardEN = ActionForwardDA.GetObjByActionForwardId(lngActionForwardId);
return objActionForwardEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsActionForwardEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsActionForwardEN objActionForwardEN = ActionForwardDA.GetFirstObj(strWhereCond);
 return objActionForwardEN;
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
public static clsActionForwardEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsActionForwardEN objActionForwardEN = ActionForwardDA.GetObjByDataRow(objRow);
 return objActionForwardEN;
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
public static clsActionForwardEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsActionForwardEN objActionForwardEN = ActionForwardDA.GetObjByDataRow(objRow);
 return objActionForwardEN;
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
 /// <param name = "lngActionForwardId">所给的关键字</param>
 /// <param name = "lstActionForwardObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsActionForwardEN GetObjByActionForwardIdFromList(long lngActionForwardId, List<clsActionForwardEN> lstActionForwardObjLst)
{
foreach (clsActionForwardEN objActionForwardEN in lstActionForwardObjLst)
{
if (objActionForwardEN.ActionForwardId == lngActionForwardId)
{
return objActionForwardEN;
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
 long lngActionForwardId;
 try
 {
 lngActionForwardId = new clsActionForwardDA().GetFirstID(strWhereCond);
 return lngActionForwardId;
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
 arrList = ActionForwardDA.GetID(strWhereCond);
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
bool bolIsExist = ActionForwardDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngActionForwardId)
{
//检测记录是否存在
bool bolIsExist = ActionForwardDA.IsExist(lngActionForwardId);
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
 bolIsExist = clsActionForwardDA.IsExistTable();
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
 bolIsExist = ActionForwardDA.IsExistTable(strTabName);
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsActionForwardEN objActionForwardEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objActionForwardEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ActionId = [{0}],Forward名称 = [{1}]的数据已经存在!(in clsActionForwardBL.AddNewRecordBySql2)", objActionForwardEN.ActionId,objActionForwardEN.ForwardName);
throw new Exception(strMsg);
}
try
{
bool bolResult = ActionForwardDA.AddNewRecordBySQL2(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsActionForwardEN objActionForwardEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objActionForwardEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ActionId = [{0}],Forward名称 = [{1}]的数据已经存在!(in clsActionForwardBL.AddNewRecordBySql2WithReturnKey)", objActionForwardEN.ActionId,objActionForwardEN.ForwardName);
throw new Exception(strMsg);
}
try
{
string strKey = ActionForwardDA.AddNewRecordBySQL2WithReturnKey(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsActionForwardEN objActionForwardEN)
{
try
{
bool bolResult = ActionForwardDA.Update(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "objActionForwardEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsActionForwardEN objActionForwardEN)
{
 if (objActionForwardEN.ActionForwardId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ActionForwardDA.UpdateBySql2(objActionForwardEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionForwardBL.ReFreshCache();

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
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
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngActionForwardId)
{
try
{
 clsActionForwardEN objActionForwardEN = clsActionForwardBL.GetObjByActionForwardId(lngActionForwardId);

if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(objActionForwardEN.ActionForwardId, "SetUpdDate");
}
if (objActionForwardEN != null)
{
int intRecNum = ActionForwardDA.DelRecord(lngActionForwardId);
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
/// <param name="lngActionForwardId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngActionForwardId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsActionForwardDA.GetSpecSQLObj();
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
//删除与表:[ActionForward]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conActionForward.ActionForwardId,
//lngActionForwardId);
//        clsActionForwardBL.DelActionForwardsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsActionForwardBL.DelRecord(lngActionForwardId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsActionForwardBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngActionForwardId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngActionForwardId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngActionForwardId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsActionForwardBL.relatedActions != null)
{
clsActionForwardBL.relatedActions.UpdRelaTabDate(lngActionForwardId, "UpdRelaTabDate");
}
bool bolResult = ActionForwardDA.DelRecord(lngActionForwardId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrActionForwardIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelActionForwards(List<string> arrActionForwardIdLst)
{
if (arrActionForwardIdLst.Count == 0) return 0;
try
{
if (clsActionForwardBL.relatedActions != null)
{
foreach (var strActionForwardId in arrActionForwardIdLst)
{
long lngActionForwardId = long.Parse(strActionForwardId);
clsActionForwardBL.relatedActions.UpdRelaTabDate(lngActionForwardId, "UpdRelaTabDate");
}
}
int intDelRecNum = ActionForwardDA.DelActionForward(arrActionForwardIdLst);
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
public static int DelActionForwardsByCond(string strWhereCond)
{
try
{
if (clsActionForwardBL.relatedActions != null)
{
List<string> arrActionForwardId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strActionForwardId in arrActionForwardId)
{
long lngActionForwardId = long.Parse(strActionForwardId);
clsActionForwardBL.relatedActions.UpdRelaTabDate(lngActionForwardId, "UpdRelaTabDate");
}
}
int intRecNum = ActionForwardDA.DelActionForward(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ActionForward]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngActionForwardId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngActionForwardId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsActionForwardDA.GetSpecSQLObj();
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
//删除与表:[ActionForward]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsActionForwardBL.DelRecord(lngActionForwardId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsActionForwardBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngActionForwardId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objActionForwardENS">源对象</param>
 /// <param name = "objActionForwardENT">目标对象</param>
 public static void CopyTo(clsActionForwardEN objActionForwardENS, clsActionForwardEN objActionForwardENT)
{
try
{
objActionForwardENT.ActionForwardId = objActionForwardENS.ActionForwardId; //ActionForwardId
objActionForwardENT.ActionId = objActionForwardENS.ActionId; //ActionId
objActionForwardENT.ForwardName = objActionForwardENS.ForwardName; //Forward名称
objActionForwardENT.ForwardPath = objActionForwardENS.ForwardPath; //Forward路径
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
 /// <param name = "objActionForwardEN">源简化对象</param>
 public static void SetUpdFlag(clsActionForwardEN objActionForwardEN)
{
try
{
objActionForwardEN.ClearUpdateState();
   string strsfUpdFldSetStr = objActionForwardEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conActionForward.ActionForwardId, new clsStrCompareIgnoreCase())  ==  true)
{
objActionForwardEN.ActionForwardId = objActionForwardEN.ActionForwardId; //ActionForwardId
}
if (arrFldSet.Contains(conActionForward.ActionId, new clsStrCompareIgnoreCase())  ==  true)
{
objActionForwardEN.ActionId = objActionForwardEN.ActionId; //ActionId
}
if (arrFldSet.Contains(conActionForward.ForwardName, new clsStrCompareIgnoreCase())  ==  true)
{
objActionForwardEN.ForwardName = objActionForwardEN.ForwardName; //Forward名称
}
if (arrFldSet.Contains(conActionForward.ForwardPath, new clsStrCompareIgnoreCase())  ==  true)
{
objActionForwardEN.ForwardPath = objActionForwardEN.ForwardPath == "[null]" ? null :  objActionForwardEN.ForwardPath; //Forward路径
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
 /// <param name = "objActionForwardEN">源简化对象</param>
 public static void AccessFldValueNull(clsActionForwardEN objActionForwardEN)
{
try
{
if (objActionForwardEN.ForwardPath == "[null]") objActionForwardEN.ForwardPath = null; //Forward路径
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
public static void CheckPropertyNew(clsActionForwardEN objActionForwardEN)
{
 ActionForwardDA.CheckPropertyNew(objActionForwardEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsActionForwardEN objActionForwardEN)
{
 ActionForwardDA.CheckProperty4Condition(objActionForwardEN);
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
if (clsActionForwardBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsActionForwardBL没有刷新缓存机制(clsActionForwardBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ActionForwardId");
//if (arrActionForwardObjLstCache == null)
//{
//arrActionForwardObjLstCache = ActionForwardDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngActionForwardId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsActionForwardEN GetObjByActionForwardIdCache(long lngActionForwardId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsActionForwardEN._CurrTabName);
List<clsActionForwardEN> arrActionForwardObjLstCache = GetObjLstCache();
IEnumerable <clsActionForwardEN> arrActionForwardObjLst_Sel =
arrActionForwardObjLstCache
.Where(x=> x.ActionForwardId == lngActionForwardId 
);
if (arrActionForwardObjLst_Sel.Count() == 0)
{
   clsActionForwardEN obj = clsActionForwardBL.GetObjByActionForwardId(lngActionForwardId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrActionForwardObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsActionForwardEN> GetAllActionForwardObjLstCache()
{
//获取缓存中的对象列表
List<clsActionForwardEN> arrActionForwardObjLstCache = GetObjLstCache(); 
return arrActionForwardObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsActionForwardEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsActionForwardEN._CurrTabName);
List<clsActionForwardEN> arrActionForwardObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrActionForwardObjLstCache;
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
string strKey = string.Format("{0}", clsActionForwardEN._CurrTabName);
CacheHelper.Remove(strKey);
clsActionForwardEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsActionForwardEN._RefreshTimeLst.Count == 0) return "";
return clsActionForwardEN._RefreshTimeLst[clsActionForwardEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsActionForwardBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsActionForwardEN._CurrTabName);
CacheHelper.Remove(strKey);
clsActionForwardEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsActionForwardBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ActionForward(ActionForward)
 /// 唯一性条件:ActionId_ForwardName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objActionForwardEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsActionForwardEN objActionForwardEN)
{
//检测记录是否存在
string strResult = ActionForwardDA.GetUniCondStr(objActionForwardEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngActionForwardId)
{
if (strInFldName != conActionForward.ActionForwardId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conActionForward._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conActionForward._AttributeName));
throw new Exception(strMsg);
}
var objActionForward = clsActionForwardBL.GetObjByActionForwardIdCache(lngActionForwardId);
if (objActionForward == null) return "";
return objActionForward[strOutFldName].ToString();
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
int intRecCount = clsActionForwardDA.GetRecCount(strTabName);
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
int intRecCount = clsActionForwardDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsActionForwardDA.GetRecCount();
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
int intRecCount = clsActionForwardDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objActionForwardCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsActionForwardEN objActionForwardCond)
{
List<clsActionForwardEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsActionForwardEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conActionForward._AttributeName)
{
if (objActionForwardCond.IsUpdated(strFldName) == false) continue;
if (objActionForwardCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objActionForwardCond[strFldName].ToString());
}
else
{
if (objActionForwardCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objActionForwardCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objActionForwardCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objActionForwardCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objActionForwardCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objActionForwardCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objActionForwardCond[strFldName]));
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
 List<string> arrList = clsActionForwardDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ActionForwardDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ActionForwardDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ActionForwardDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsActionForwardDA.SetFldValue(clsActionForwardEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ActionForwardDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsActionForwardDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsActionForwardDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsActionForwardDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ActionForward] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ActionForwardId*/ 
 strCreateTabCode.Append(" ActionForwardId bigint primary key identity, "); 
 // /**ActionId*/ 
 strCreateTabCode.Append(" ActionId char(10) not Null, "); 
 // /**Forward名称*/ 
 strCreateTabCode.Append(" ForwardName varchar(50) not Null, "); 
 // /**Forward路径*/ 
 strCreateTabCode.Append(" ForwardPath varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// ActionForward(ActionForward)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ActionForward : clsCommFun4BL
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
clsActionForwardBL.ReFreshThisCache();
}
}

}