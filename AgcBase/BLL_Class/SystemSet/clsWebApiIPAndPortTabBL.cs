
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebApiIPAndPortTabBL
 表名:WebApiIPAndPortTab(00050529)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsWebApiIPAndPortTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebApiIPAndPortTabEN GetObj(this K_mId_WebApiIPAndPortTab myKey)
{
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.GetObjBymId(myKey.Value);
return objWebApiIPAndPortTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebApiIPAndPortTabEN) == false)
{
var strMsg = string.Format("记录已经存在!WebApiIPAndPort = [{0}],WebApi虚拟路径 = [{1}]的数据已经存在!(in clsWebApiIPAndPortTabBL.AddNewRecord)", objWebApiIPAndPortTabEN.WebApiIPAndPort,objWebApiIPAndPortTabEN.WebApiVirtualPath);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.AddNewRecordBySQL2(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
public static bool AddRecordEx(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, bool bolIsNeedCheckUniqueness = true)
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
objWebApiIPAndPortTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objWebApiIPAndPortTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(WebApiIPAndPort(WebApiIPAndPort)=[{0}],WebApi虚拟路径(WebApiVirtualPath)=[{1}])已经存在,不能重复!", objWebApiIPAndPortTabEN.WebApiIPAndPort, objWebApiIPAndPortTabEN.WebApiVirtualPath);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objWebApiIPAndPortTabEN.AddNewRecord();
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebApiIPAndPortTabEN) == false)
{
var strMsg = string.Format("记录已经存在!WebApiIPAndPort = [{0}],WebApi虚拟路径 = [{1}]的数据已经存在!(in clsWebApiIPAndPortTabBL.AddNewRecordWithReturnKey)", objWebApiIPAndPortTabEN.WebApiIPAndPort,objWebApiIPAndPortTabEN.WebApiVirtualPath);
throw new Exception(strMsg);
}
try
{
string strKey = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.AddNewRecordBySQL2WithReturnKey(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetmId(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, long lngmId, string strComparisonOp="")
	{
objWebApiIPAndPortTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.mId) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.mId, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.mId] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetWebApiIPAndPort(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strWebApiIPAndPort, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebApiIPAndPort, 50, conWebApiIPAndPortTab.WebApiIPAndPort);
}
objWebApiIPAndPortTabEN.WebApiIPAndPort = strWebApiIPAndPort; //WebApiIPAndPort
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.WebApiIPAndPort) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.WebApiIPAndPort, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.WebApiIPAndPort] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetWebApiVirtualPath(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strWebApiVirtualPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebApiVirtualPath, 50, conWebApiIPAndPortTab.WebApiVirtualPath);
}
objWebApiIPAndPortTabEN.WebApiVirtualPath = strWebApiVirtualPath; //WebApi虚拟路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.WebApiVirtualPath) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.WebApiVirtualPath, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.WebApiVirtualPath] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetOrderNum(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conWebApiIPAndPortTab.OrderNum);
objWebApiIPAndPortTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.OrderNum) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.OrderNum, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.OrderNum] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetUpdDate(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWebApiIPAndPortTab.UpdDate);
}
objWebApiIPAndPortTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.UpdDate) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.UpdDate, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.UpdDate] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetUpdUserId(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conWebApiIPAndPortTab.UpdUserId);
}
objWebApiIPAndPortTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.UpdUserId) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.UpdUserId, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.UpdUserId] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebApiIPAndPortTabEN SetMemo(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWebApiIPAndPortTab.Memo);
}
objWebApiIPAndPortTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebApiIPAndPortTabEN.dicFldComparisonOp.ContainsKey(conWebApiIPAndPortTab.Memo) == false)
{
objWebApiIPAndPortTabEN.dicFldComparisonOp.Add(conWebApiIPAndPortTab.Memo, strComparisonOp);
}
else
{
objWebApiIPAndPortTabEN.dicFldComparisonOp[conWebApiIPAndPortTab.Memo] = strComparisonOp;
}
}
return objWebApiIPAndPortTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objWebApiIPAndPortTabEN.CheckPropertyNew();
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabCond = new clsWebApiIPAndPortTabEN();
string strCondition = objWebApiIPAndPortTabCond
.SetmId(objWebApiIPAndPortTabEN.mId, "<>")
.SetWebApiIPAndPort(objWebApiIPAndPortTabEN.WebApiIPAndPort, "=")
.SetWebApiVirtualPath(objWebApiIPAndPortTabEN.WebApiVirtualPath, "=")
.GetCombineCondition();
objWebApiIPAndPortTabEN._IsCheckProperty = true;
bool bolIsExist = clsWebApiIPAndPortTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(WebApiIPAndPort_VirtualPath)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objWebApiIPAndPortTabEN.Update();
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
 /// <param name = "objWebApiIPAndPortTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabCond = new clsWebApiIPAndPortTabEN();
string strCondition = objWebApiIPAndPortTabCond
.SetWebApiIPAndPort(objWebApiIPAndPortTab.WebApiIPAndPort, "=")
.SetWebApiVirtualPath(objWebApiIPAndPortTab.WebApiVirtualPath, "=")
.GetCombineCondition();
objWebApiIPAndPortTab._IsCheckProperty = true;
bool bolIsExist = clsWebApiIPAndPortTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objWebApiIPAndPortTab.mId = clsWebApiIPAndPortTabBL.GetFirstID_S(strCondition);
objWebApiIPAndPortTab.UpdateWithCondition(strCondition);
}
else
{
objWebApiIPAndPortTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 if (objWebApiIPAndPortTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.UpdateBySql2(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objWebApiIPAndPortTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.UpdateBySql2(objWebApiIPAndPortTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strWhereCond)
{
try
{
bool bolResult = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.UpdateBySqlWithCondition(objWebApiIPAndPortTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.UpdateBySqlWithConditionTransaction(objWebApiIPAndPortTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
public static int Delete(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
try
{
int intRecNum = clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.DelRecord(objWebApiIPAndPortTabEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
 /// <param name = "objWebApiIPAndPortTabENT">目标对象</param>
 public static void CopyTo(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENS, clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENT)
{
try
{
objWebApiIPAndPortTabENT.mId = objWebApiIPAndPortTabENS.mId; //mId
objWebApiIPAndPortTabENT.WebApiIPAndPort = objWebApiIPAndPortTabENS.WebApiIPAndPort; //WebApiIPAndPort
objWebApiIPAndPortTabENT.WebApiVirtualPath = objWebApiIPAndPortTabENS.WebApiVirtualPath; //WebApi虚拟路径
objWebApiIPAndPortTabENT.OrderNum = objWebApiIPAndPortTabENS.OrderNum; //序号
objWebApiIPAndPortTabENT.UpdDate = objWebApiIPAndPortTabENS.UpdDate; //修改日期
objWebApiIPAndPortTabENT.UpdUserId = objWebApiIPAndPortTabENS.UpdUserId; //修改用户Id
objWebApiIPAndPortTabENT.Memo = objWebApiIPAndPortTabENS.Memo; //说明
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
 /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
 /// <returns>目标对象=>clsWebApiIPAndPortTabEN:objWebApiIPAndPortTabENT</returns>
 public static clsWebApiIPAndPortTabEN CopyTo(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENS)
{
try
{
 clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENT = new clsWebApiIPAndPortTabEN()
{
mId = objWebApiIPAndPortTabENS.mId, //mId
WebApiIPAndPort = objWebApiIPAndPortTabENS.WebApiIPAndPort, //WebApiIPAndPort
WebApiVirtualPath = objWebApiIPAndPortTabENS.WebApiVirtualPath, //WebApi虚拟路径
OrderNum = objWebApiIPAndPortTabENS.OrderNum, //序号
UpdDate = objWebApiIPAndPortTabENS.UpdDate, //修改日期
UpdUserId = objWebApiIPAndPortTabENS.UpdUserId, //修改用户Id
Memo = objWebApiIPAndPortTabENS.Memo, //说明
};
 return objWebApiIPAndPortTabENT;
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
public static void CheckPropertyNew(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.CheckPropertyNew(objWebApiIPAndPortTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.CheckProperty4Condition(objWebApiIPAndPortTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.mId) == true)
{
string strComparisonOpmId = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conWebApiIPAndPortTab.mId, objWebApiIPAndPortTabCond.mId, strComparisonOpmId);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort) == true)
{
string strComparisonOpWebApiIPAndPort = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.WebApiIPAndPort];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebApiIPAndPortTab.WebApiIPAndPort, objWebApiIPAndPortTabCond.WebApiIPAndPort, strComparisonOpWebApiIPAndPort);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath) == true)
{
string strComparisonOpWebApiVirtualPath = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.WebApiVirtualPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebApiIPAndPortTab.WebApiVirtualPath, objWebApiIPAndPortTabCond.WebApiVirtualPath, strComparisonOpWebApiVirtualPath);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conWebApiIPAndPortTab.OrderNum, objWebApiIPAndPortTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebApiIPAndPortTab.UpdDate, objWebApiIPAndPortTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebApiIPAndPortTab.UpdUserId, objWebApiIPAndPortTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objWebApiIPAndPortTabCond.IsUpdated(conWebApiIPAndPortTab.Memo) == true)
{
string strComparisonOpMemo = objWebApiIPAndPortTabCond.dicFldComparisonOp[conWebApiIPAndPortTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebApiIPAndPortTab.Memo, objWebApiIPAndPortTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--WebApiIPAndPortTab(WebApiIP表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:WebApiIPAndPort_VirtualPath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objWebApiIPAndPortTabEN == null) return true;
if (objWebApiIPAndPortTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort == null)
{
 sbCondition.AppendFormat(" and WebApiIPAndPort is null", objWebApiIPAndPortTabEN.WebApiIPAndPort);
}
else
{
 sbCondition.AppendFormat(" and WebApiIPAndPort = '{0}'", objWebApiIPAndPortTabEN.WebApiIPAndPort);
}
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath == null)
{
 sbCondition.AppendFormat(" and WebApiVirtualPath is null", objWebApiIPAndPortTabEN.WebApiVirtualPath);
}
else
{
 sbCondition.AppendFormat(" and WebApiVirtualPath = '{0}'", objWebApiIPAndPortTabEN.WebApiVirtualPath);
}
if (clsWebApiIPAndPortTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objWebApiIPAndPortTabEN.mId);
 sbCondition.AppendFormat(" and WebApiIPAndPort = '{0}'", objWebApiIPAndPortTabEN.WebApiIPAndPort);
 sbCondition.AppendFormat(" and WebApiVirtualPath = '{0}'", objWebApiIPAndPortTabEN.WebApiVirtualPath);
if (clsWebApiIPAndPortTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--WebApiIPAndPortTab(WebApiIP表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:WebApiIPAndPort_VirtualPath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objWebApiIPAndPortTabEN == null) return "";
if (objWebApiIPAndPortTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort == null)
{
 sbCondition.AppendFormat(" and WebApiIPAndPort is null", objWebApiIPAndPortTabEN.WebApiIPAndPort);
}
else
{
 sbCondition.AppendFormat(" and WebApiIPAndPort = '{0}'", objWebApiIPAndPortTabEN.WebApiIPAndPort);
}
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath == null)
{
 sbCondition.AppendFormat(" and WebApiVirtualPath is null", objWebApiIPAndPortTabEN.WebApiVirtualPath);
}
else
{
 sbCondition.AppendFormat(" and WebApiVirtualPath = '{0}'", objWebApiIPAndPortTabEN.WebApiVirtualPath);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objWebApiIPAndPortTabEN.mId);
 sbCondition.AppendFormat(" and WebApiIPAndPort = '{0}'", objWebApiIPAndPortTabEN.WebApiIPAndPort);
 sbCondition.AppendFormat(" and WebApiVirtualPath = '{0}'", objWebApiIPAndPortTabEN.WebApiVirtualPath);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_WebApiIPAndPortTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// WebApiIP表(WebApiIPAndPortTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsWebApiIPAndPortTabBL
{
public static RelatedActions_WebApiIPAndPortTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsWebApiIPAndPortTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsWebApiIPAndPortTabDA WebApiIPAndPortTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsWebApiIPAndPortTabDA();
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
 public clsWebApiIPAndPortTabBL()
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
if (string.IsNullOrEmpty(clsWebApiIPAndPortTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebApiIPAndPortTabEN._ConnectString);
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
public static DataTable GetDataTable_WebApiIPAndPortTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = WebApiIPAndPortTabDA.GetDataTable_WebApiIPAndPortTab(strWhereCond);
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
objDT = WebApiIPAndPortTabDA.GetDataTable(strWhereCond);
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
objDT = WebApiIPAndPortTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = WebApiIPAndPortTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = WebApiIPAndPortTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = WebApiIPAndPortTabDA.GetDataTable_Top(objTopPara);
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
objDT = WebApiIPAndPortTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = WebApiIPAndPortTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = WebApiIPAndPortTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsWebApiIPAndPortTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
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
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsWebApiIPAndPortTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsWebApiIPAndPortTabEN._CurrTabName);
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLstCache = GetObjLstCache();
IEnumerable <clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLst_Sel =
arrWebApiIPAndPortTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrWebApiIPAndPortTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetObjLst(string strWhereCond)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
public static List<clsWebApiIPAndPortTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsWebApiIPAndPortTabEN> GetSubObjLstCache(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabCond)
{
List<clsWebApiIPAndPortTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsWebApiIPAndPortTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebApiIPAndPortTab._AttributeName)
{
if (objWebApiIPAndPortTabCond.IsUpdated(strFldName) == false) continue;
if (objWebApiIPAndPortTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebApiIPAndPortTabCond[strFldName].ToString());
}
else
{
if (objWebApiIPAndPortTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebApiIPAndPortTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebApiIPAndPortTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebApiIPAndPortTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebApiIPAndPortTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebApiIPAndPortTabCond[strFldName]));
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
public static List<clsWebApiIPAndPortTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
public static List<clsWebApiIPAndPortTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
List<clsWebApiIPAndPortTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsWebApiIPAndPortTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsWebApiIPAndPortTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
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
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
public static List<clsWebApiIPAndPortTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsWebApiIPAndPortTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
public static List<clsWebApiIPAndPortTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebApiIPAndPortTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetWebApiIPAndPortTab(ref clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
bool bolResult = WebApiIPAndPortTabDA.GetWebApiIPAndPortTab(ref objWebApiIPAndPortTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebApiIPAndPortTabEN GetObjBymId(long lngmId)
{
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = WebApiIPAndPortTabDA.GetObjBymId(lngmId);
return objWebApiIPAndPortTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsWebApiIPAndPortTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = WebApiIPAndPortTabDA.GetFirstObj(strWhereCond);
 return objWebApiIPAndPortTabEN;
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
public static clsWebApiIPAndPortTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = WebApiIPAndPortTabDA.GetObjByDataRow(objRow);
 return objWebApiIPAndPortTabEN;
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
public static clsWebApiIPAndPortTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = WebApiIPAndPortTabDA.GetObjByDataRow(objRow);
 return objWebApiIPAndPortTabEN;
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
 /// <param name = "lstWebApiIPAndPortTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebApiIPAndPortTabEN GetObjBymIdFromList(long lngmId, List<clsWebApiIPAndPortTabEN> lstWebApiIPAndPortTabObjLst)
{
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN in lstWebApiIPAndPortTabObjLst)
{
if (objWebApiIPAndPortTabEN.mId == lngmId)
{
return objWebApiIPAndPortTabEN;
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
 lngmId = new clsWebApiIPAndPortTabDA().GetFirstID(strWhereCond);
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
 arrList = WebApiIPAndPortTabDA.GetID(strWhereCond);
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
bool bolIsExist = WebApiIPAndPortTabDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = WebApiIPAndPortTabDA.IsExist(lngmId);
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
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = clsWebApiIPAndPortTabBL.GetObjBymId(lngmId);
objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objWebApiIPAndPortTabEN.UpdUserId = strOpUser;
return clsWebApiIPAndPortTabBL.UpdateBySql2(objWebApiIPAndPortTabEN);
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
 bolIsExist = clsWebApiIPAndPortTabDA.IsExistTable();
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
 bolIsExist = WebApiIPAndPortTabDA.IsExistTable(strTabName);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebApiIPAndPortTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!WebApiIPAndPort = [{0}],WebApi虚拟路径 = [{1}]的数据已经存在!(in clsWebApiIPAndPortTabBL.AddNewRecordBySql2)", objWebApiIPAndPortTabEN.WebApiIPAndPort,objWebApiIPAndPortTabEN.WebApiVirtualPath);
throw new Exception(strMsg);
}
try
{
bool bolResult = WebApiIPAndPortTabDA.AddNewRecordBySQL2(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebApiIPAndPortTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!WebApiIPAndPort = [{0}],WebApi虚拟路径 = [{1}]的数据已经存在!(in clsWebApiIPAndPortTabBL.AddNewRecordBySql2WithReturnKey)", objWebApiIPAndPortTabEN.WebApiIPAndPort,objWebApiIPAndPortTabEN.WebApiVirtualPath);
throw new Exception(strMsg);
}
try
{
string strKey = WebApiIPAndPortTabDA.AddNewRecordBySQL2WithReturnKey(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
try
{
bool bolResult = WebApiIPAndPortTabDA.Update(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 if (objWebApiIPAndPortTabEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = WebApiIPAndPortTabDA.UpdateBySql2(objWebApiIPAndPortTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebApiIPAndPortTabBL.ReFreshCache();

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
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
 clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = clsWebApiIPAndPortTabBL.GetObjBymId(lngmId);

if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTabEN.mId, objWebApiIPAndPortTabEN.UpdUserId);
}
if (objWebApiIPAndPortTabEN != null)
{
int intRecNum = WebApiIPAndPortTabDA.DelRecord(lngmId);
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
objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
//删除与表:[WebApiIPAndPortTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conWebApiIPAndPortTab.mId,
//lngmId);
//        clsWebApiIPAndPortTabBL.DelWebApiIPAndPortTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebApiIPAndPortTabBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebApiIPAndPortTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = WebApiIPAndPortTabDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelWebApiIPAndPortTabs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = WebApiIPAndPortTabDA.DelWebApiIPAndPortTab(arrmIdLst);
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
public static int DelWebApiIPAndPortTabsByCond(string strWhereCond)
{
try
{
if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = WebApiIPAndPortTabDA.DelWebApiIPAndPortTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[WebApiIPAndPortTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
//删除与表:[WebApiIPAndPortTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebApiIPAndPortTabBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebApiIPAndPortTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
 /// <param name = "objWebApiIPAndPortTabENT">目标对象</param>
 public static void CopyTo(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENS, clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENT)
{
try
{
objWebApiIPAndPortTabENT.mId = objWebApiIPAndPortTabENS.mId; //mId
objWebApiIPAndPortTabENT.WebApiIPAndPort = objWebApiIPAndPortTabENS.WebApiIPAndPort; //WebApiIPAndPort
objWebApiIPAndPortTabENT.WebApiVirtualPath = objWebApiIPAndPortTabENS.WebApiVirtualPath; //WebApi虚拟路径
objWebApiIPAndPortTabENT.OrderNum = objWebApiIPAndPortTabENS.OrderNum; //序号
objWebApiIPAndPortTabENT.UpdDate = objWebApiIPAndPortTabENS.UpdDate; //修改日期
objWebApiIPAndPortTabENT.UpdUserId = objWebApiIPAndPortTabENS.UpdUserId; //修改用户Id
objWebApiIPAndPortTabENT.Memo = objWebApiIPAndPortTabENS.Memo; //说明
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
 /// <param name = "objWebApiIPAndPortTabEN">源简化对象</param>
 public static void SetUpdFlag(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
try
{
objWebApiIPAndPortTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objWebApiIPAndPortTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conWebApiIPAndPortTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.mId = objWebApiIPAndPortTabEN.mId; //mId
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.WebApiIPAndPort, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.WebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort == "[null]" ? null :  objWebApiIPAndPortTabEN.WebApiIPAndPort; //WebApiIPAndPort
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.WebApiVirtualPath, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.WebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath == "[null]" ? null :  objWebApiIPAndPortTabEN.WebApiVirtualPath; //WebApi虚拟路径
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.OrderNum = objWebApiIPAndPortTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.UpdDate = objWebApiIPAndPortTabEN.UpdDate == "[null]" ? null :  objWebApiIPAndPortTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.UpdUserId = objWebApiIPAndPortTabEN.UpdUserId == "[null]" ? null :  objWebApiIPAndPortTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conWebApiIPAndPortTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objWebApiIPAndPortTabEN.Memo = objWebApiIPAndPortTabEN.Memo == "[null]" ? null :  objWebApiIPAndPortTabEN.Memo; //说明
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
 /// <param name = "objWebApiIPAndPortTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
try
{
if (objWebApiIPAndPortTabEN.WebApiIPAndPort == "[null]") objWebApiIPAndPortTabEN.WebApiIPAndPort = null; //WebApiIPAndPort
if (objWebApiIPAndPortTabEN.WebApiVirtualPath == "[null]") objWebApiIPAndPortTabEN.WebApiVirtualPath = null; //WebApi虚拟路径
if (objWebApiIPAndPortTabEN.UpdDate == "[null]") objWebApiIPAndPortTabEN.UpdDate = null; //修改日期
if (objWebApiIPAndPortTabEN.UpdUserId == "[null]") objWebApiIPAndPortTabEN.UpdUserId = null; //修改用户Id
if (objWebApiIPAndPortTabEN.Memo == "[null]") objWebApiIPAndPortTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 WebApiIPAndPortTabDA.CheckPropertyNew(objWebApiIPAndPortTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 WebApiIPAndPortTabDA.CheckProperty4Condition(objWebApiIPAndPortTabEN);
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
if (clsWebApiIPAndPortTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebApiIPAndPortTabBL没有刷新缓存机制(clsWebApiIPAndPortTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrWebApiIPAndPortTabObjLstCache == null)
//{
//arrWebApiIPAndPortTabObjLstCache = WebApiIPAndPortTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebApiIPAndPortTabEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsWebApiIPAndPortTabEN._CurrTabName);
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLstCache = GetObjLstCache();
IEnumerable <clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLst_Sel =
arrWebApiIPAndPortTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrWebApiIPAndPortTabObjLst_Sel.Count() == 0)
{
   clsWebApiIPAndPortTabEN obj = clsWebApiIPAndPortTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrWebApiIPAndPortTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetAllWebApiIPAndPortTabObjLstCache()
{
//获取缓存中的对象列表
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLstCache = GetObjLstCache(); 
return arrWebApiIPAndPortTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebApiIPAndPortTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsWebApiIPAndPortTabEN._CurrTabName);
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrWebApiIPAndPortTabObjLstCache;
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
string strKey = string.Format("{0}", clsWebApiIPAndPortTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebApiIPAndPortTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsWebApiIPAndPortTabEN._RefreshTimeLst.Count == 0) return "";
return clsWebApiIPAndPortTabEN._RefreshTimeLst[clsWebApiIPAndPortTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsWebApiIPAndPortTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWebApiIPAndPortTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebApiIPAndPortTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsWebApiIPAndPortTabBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--WebApiIPAndPortTab(WebApiIP表)
 /// 唯一性条件:WebApiIPAndPort_VirtualPath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检测记录是否存在
string strResult = WebApiIPAndPortTabDA.GetUniCondStr(objWebApiIPAndPortTabEN);
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
if (strInFldName != conWebApiIPAndPortTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conWebApiIPAndPortTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conWebApiIPAndPortTab._AttributeName));
throw new Exception(strMsg);
}
var objWebApiIPAndPortTab = clsWebApiIPAndPortTabBL.GetObjBymIdCache(lngmId);
if (objWebApiIPAndPortTab == null) return "";
return objWebApiIPAndPortTab[strOutFldName].ToString();
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
int intRecCount = clsWebApiIPAndPortTabDA.GetRecCount(strTabName);
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
int intRecCount = clsWebApiIPAndPortTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsWebApiIPAndPortTabDA.GetRecCount();
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
int intRecCount = clsWebApiIPAndPortTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabCond)
{
List<clsWebApiIPAndPortTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsWebApiIPAndPortTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebApiIPAndPortTab._AttributeName)
{
if (objWebApiIPAndPortTabCond.IsUpdated(strFldName) == false) continue;
if (objWebApiIPAndPortTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebApiIPAndPortTabCond[strFldName].ToString());
}
else
{
if (objWebApiIPAndPortTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebApiIPAndPortTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebApiIPAndPortTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebApiIPAndPortTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebApiIPAndPortTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebApiIPAndPortTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebApiIPAndPortTabCond[strFldName]));
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
 List<string> arrList = clsWebApiIPAndPortTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = WebApiIPAndPortTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = WebApiIPAndPortTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = WebApiIPAndPortTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebApiIPAndPortTabDA.SetFldValue(clsWebApiIPAndPortTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = WebApiIPAndPortTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebApiIPAndPortTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebApiIPAndPortTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebApiIPAndPortTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[WebApiIPAndPortTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**WebApiIPAndPort*/ 
 strCreateTabCode.Append(" WebApiIPAndPort varchar(50) Null, "); 
 // /**WebApi虚拟路径*/ 
 strCreateTabCode.Append(" WebApiVirtualPath varchar(50) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
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
string strCondition = string.Format("1 = 1 order by {0} ", conWebApiIPAndPortTab.OrderNum); 
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjList = new clsWebApiIPAndPortTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTab in arrWebApiIPAndPortTabObjList)
{
objWebApiIPAndPortTab.OrderNum = intIndex;
UpdateBySql2(objWebApiIPAndPortTab);
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
/// <param name="lngmId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId)
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
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsWebApiIPAndPortTabEN objWebApiIPAndPortTab = clsWebApiIPAndPortTabBL.GetObjBymId(lngmId);

intOrderNum = objWebApiIPAndPortTab.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsWebApiIPAndPortTabBL.GetRecCountByCond(clsWebApiIPAndPortTabEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conWebApiIPAndPortTab.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsWebApiIPAndPortTabBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsWebApiIPAndPortTabBL.SetFldValue(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conWebApiIPAndPortTab.mId, lngmId));
clsWebApiIPAndPortTabBL.SetFldValue(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conWebApiIPAndPortTab.mId, lngPrevmId));
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
strCondition.AppendFormat(" {0} = {1}", conWebApiIPAndPortTab.OrderNum, intOrderNum + 1);

lngNextmId = clsWebApiIPAndPortTabBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsWebApiIPAndPortTabBL.SetFldValue(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conWebApiIPAndPortTab.mId, lngmId));
clsWebApiIPAndPortTabBL.SetFldValue(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conWebApiIPAndPortTab.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsWebApiIPAndPortTabBL.ReFreshCache();
if (clsWebApiIPAndPortTabBL.relatedActions != null)
{
clsWebApiIPAndPortTabBL.relatedActions.UpdRelaTabDate(objWebApiIPAndPortTab.mId, "UpdRelaTabDate");
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
public static bool GoBottom(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conWebApiIPAndPortTab.mId, strKeyList);
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabLst = GetObjLst(strCondition);
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTab in arrWebApiIPAndPortTabLst)
{
objWebApiIPAndPortTab.OrderNum = objWebApiIPAndPortTab.OrderNum + 10000;
UpdateBySql2(objWebApiIPAndPortTab);
}
strCondition = string.Format("1 = 1 order by {0} ", conWebApiIPAndPortTab.OrderNum); 
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjList = new clsWebApiIPAndPortTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTab in arrWebApiIPAndPortTabObjList)
{
objWebApiIPAndPortTab.OrderNum = intIndex;
UpdateBySql2(objWebApiIPAndPortTab);
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
public static bool GoTop(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conWebApiIPAndPortTab.mId, strKeyList);
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabLst = GetObjLst(strCondition);
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTab in arrWebApiIPAndPortTabLst)
{
objWebApiIPAndPortTab.OrderNum = objWebApiIPAndPortTab.OrderNum - 10000;
UpdateBySql2(objWebApiIPAndPortTab);
}
strCondition = string.Format("1 = 1 order by {0} ", conWebApiIPAndPortTab.OrderNum); 
List<clsWebApiIPAndPortTabEN> arrWebApiIPAndPortTabObjList = new clsWebApiIPAndPortTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsWebApiIPAndPortTabEN objWebApiIPAndPortTab in arrWebApiIPAndPortTabObjList)
{
objWebApiIPAndPortTab.OrderNum = intIndex;
UpdateBySql2(objWebApiIPAndPortTab);
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
 /// WebApiIP表(WebApiIPAndPortTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4WebApiIPAndPortTab : clsCommFun4BL
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
clsWebApiIPAndPortTabBL.ReFreshThisCache();
}
}

}