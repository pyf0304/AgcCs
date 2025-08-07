
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionCmPrjIdRelaBL
 表名:ViewRegionCmPrjIdRela(00050622)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsViewRegionCmPrjIdRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewRegionCmPrjIdRelaBL.IsExist(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewRegionCmPrjIdRelaEN.RegionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.AddNewRecordBySQL2(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewRegionCmPrjIdRelaBL.IsExist(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewRegionCmPrjIdRelaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objViewRegionCmPrjIdRelaEN.AddNewRecord();
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewRegionCmPrjIdRelaBL.IsExist(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewRegionCmPrjIdRelaEN.RegionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.AddNewRecordBySQL2WithReturnKey(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionCmPrjIdRelaEN SetRegionId(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strRegionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conViewRegionCmPrjIdRela.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conViewRegionCmPrjIdRela.RegionId);
}
objViewRegionCmPrjIdRelaEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionCmPrjIdRela.RegionId) == false)
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewRegionCmPrjIdRela.RegionId, strComparisonOp);
}
else
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp[conViewRegionCmPrjIdRela.RegionId] = strComparisonOp;
}
}
return objViewRegionCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionCmPrjIdRelaEN SetCmPrjId(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conViewRegionCmPrjIdRela.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conViewRegionCmPrjIdRela.CmPrjId);
}
objViewRegionCmPrjIdRelaEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionCmPrjIdRela.CmPrjId) == false)
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewRegionCmPrjIdRela.CmPrjId, strComparisonOp);
}
else
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp[conViewRegionCmPrjIdRela.CmPrjId] = strComparisonOp;
}
}
return objViewRegionCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionCmPrjIdRelaEN SetUpdUser(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewRegionCmPrjIdRela.UpdUser);
}
objViewRegionCmPrjIdRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionCmPrjIdRela.UpdUser) == false)
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewRegionCmPrjIdRela.UpdUser, strComparisonOp);
}
else
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp[conViewRegionCmPrjIdRela.UpdUser] = strComparisonOp;
}
}
return objViewRegionCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionCmPrjIdRelaEN SetUpdDate(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewRegionCmPrjIdRela.UpdDate);
}
objViewRegionCmPrjIdRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionCmPrjIdRela.UpdDate) == false)
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewRegionCmPrjIdRela.UpdDate, strComparisonOp);
}
else
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp[conViewRegionCmPrjIdRela.UpdDate] = strComparisonOp;
}
}
return objViewRegionCmPrjIdRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionCmPrjIdRelaEN SetMemo(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewRegionCmPrjIdRela.Memo);
}
objViewRegionCmPrjIdRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionCmPrjIdRela.Memo) == false)
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp.Add(conViewRegionCmPrjIdRela.Memo, strComparisonOp);
}
else
{
objViewRegionCmPrjIdRelaEN.dicFldComparisonOp[conViewRegionCmPrjIdRela.Memo] = strComparisonOp;
}
}
return objViewRegionCmPrjIdRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewRegionCmPrjIdRelaEN.CheckPropertyNew();
clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaCond = new clsViewRegionCmPrjIdRelaEN();
string strCondition = objViewRegionCmPrjIdRelaCond
.SetRegionId(objViewRegionCmPrjIdRelaEN.RegionId, "=")
.GetCombineCondition();
objViewRegionCmPrjIdRelaEN._IsCheckProperty = true;
bool bolIsExist = clsViewRegionCmPrjIdRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewRegionCmPrjIdRelaEN.Update();
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.UpdateBySql2(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.UpdateBySql2(objViewRegionCmPrjIdRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.UpdateBySqlWithCondition(objViewRegionCmPrjIdRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.UpdateBySqlWithConditionTransaction(objViewRegionCmPrjIdRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
try
{
int intRecNum = clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.DelRecord(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <param name = "objViewRegionCmPrjIdRelaENT">目标对象</param>
 public static void CopyTo(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS, clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENT)
{
try
{
objViewRegionCmPrjIdRelaENT.RegionId = objViewRegionCmPrjIdRelaENS.RegionId; //区域Id
objViewRegionCmPrjIdRelaENT.CmPrjId = objViewRegionCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objViewRegionCmPrjIdRelaENT.UpdUser = objViewRegionCmPrjIdRelaENS.UpdUser; //修改者
objViewRegionCmPrjIdRelaENT.UpdDate = objViewRegionCmPrjIdRelaENS.UpdDate; //修改日期
objViewRegionCmPrjIdRelaENT.Memo = objViewRegionCmPrjIdRelaENS.Memo; //说明
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
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionCmPrjIdRelaEN:objViewRegionCmPrjIdRelaENT</returns>
 public static clsViewRegionCmPrjIdRelaEN CopyTo(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS)
{
try
{
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENT = new clsViewRegionCmPrjIdRelaEN()
{
RegionId = objViewRegionCmPrjIdRelaENS.RegionId, //区域Id
CmPrjId = objViewRegionCmPrjIdRelaENS.CmPrjId, //Cm工程Id
UpdUser = objViewRegionCmPrjIdRelaENS.UpdUser, //修改者
UpdDate = objViewRegionCmPrjIdRelaENS.UpdDate, //修改日期
Memo = objViewRegionCmPrjIdRelaENS.Memo, //说明
};
 return objViewRegionCmPrjIdRelaENT;
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
public static void CheckPropertyNew(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 clsViewRegionCmPrjIdRelaBL.ViewRegionCmPrjIdRelaDA.CheckProperty4Condition(objViewRegionCmPrjIdRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewRegionCmPrjIdRelaCond.IsUpdated(conViewRegionCmPrjIdRela.RegionId) == true)
{
string strComparisonOpRegionId = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[conViewRegionCmPrjIdRela.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionCmPrjIdRela.RegionId, objViewRegionCmPrjIdRelaCond.RegionId, strComparisonOpRegionId);
}
if (objViewRegionCmPrjIdRelaCond.IsUpdated(conViewRegionCmPrjIdRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[conViewRegionCmPrjIdRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionCmPrjIdRela.CmPrjId, objViewRegionCmPrjIdRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objViewRegionCmPrjIdRelaCond.IsUpdated(conViewRegionCmPrjIdRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[conViewRegionCmPrjIdRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionCmPrjIdRela.UpdUser, objViewRegionCmPrjIdRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewRegionCmPrjIdRelaCond.IsUpdated(conViewRegionCmPrjIdRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[conViewRegionCmPrjIdRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionCmPrjIdRela.UpdDate, objViewRegionCmPrjIdRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewRegionCmPrjIdRelaCond.IsUpdated(conViewRegionCmPrjIdRela.Memo) == true)
{
string strComparisonOpMemo = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[conViewRegionCmPrjIdRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionCmPrjIdRela.Memo, objViewRegionCmPrjIdRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewRegionCmPrjIdRela
{
public virtual bool UpdRelaTabDate(string strRegionId,string strCmPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面区域CmPrjId关系(ViewRegionCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewRegionCmPrjIdRelaBL
{
public static RelatedActions_ViewRegionCmPrjIdRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewRegionCmPrjIdRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewRegionCmPrjIdRelaDA ViewRegionCmPrjIdRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewRegionCmPrjIdRelaDA();
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
 public clsViewRegionCmPrjIdRelaBL()
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
if (string.IsNullOrEmpty(clsViewRegionCmPrjIdRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionCmPrjIdRelaEN._ConnectString);
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
public static DataTable GetDataTable_ViewRegionCmPrjIdRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable_ViewRegionCmPrjIdRela(strWhereCond);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable(strWhereCond);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable_Top(objTopPara);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewRegionCmPrjIdRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--ViewRegionCmPrjIdRela(界面区域CmPrjId关系)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objViewRegionCmPrjIdRelaEN.RegionId;
strResult += "|" + objViewRegionCmPrjIdRelaEN.CmPrjId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewRegionCmPrjIdRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsViewRegionCmPrjIdRelaEN._CurrTabName);
List<clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLstCache = GetObjLstCache();
IEnumerable <clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLst_Sel =
arrViewRegionCmPrjIdRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrViewRegionCmPrjIdRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLst(string strWhereCond)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewRegionCmPrjIdRelaEN> GetSubObjLstCache(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaCond)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewRegionCmPrjIdRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegionCmPrjIdRela._AttributeName)
{
if (objViewRegionCmPrjIdRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionCmPrjIdRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCmPrjIdRelaCond[strFldName].ToString());
}
else
{
if (objViewRegionCmPrjIdRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCmPrjIdRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionCmPrjIdRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionCmPrjIdRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionCmPrjIdRelaCond[strFldName]));
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
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewRegionCmPrjIdRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
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
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
public static List<clsViewRegionCmPrjIdRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
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
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLst = new List<clsViewRegionCmPrjIdRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = new clsViewRegionCmPrjIdRelaEN();
try
{
objViewRegionCmPrjIdRelaEN.RegionId = objRow[conViewRegionCmPrjIdRela.RegionId].ToString().Trim(); //区域Id
objViewRegionCmPrjIdRelaEN.CmPrjId = objRow[conViewRegionCmPrjIdRela.CmPrjId].ToString().Trim(); //Cm工程Id
objViewRegionCmPrjIdRelaEN.UpdUser = objRow[conViewRegionCmPrjIdRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdUser].ToString().Trim(); //修改者
objViewRegionCmPrjIdRelaEN.UpdDate = objRow[conViewRegionCmPrjIdRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionCmPrjIdRelaEN.Memo = objRow[conViewRegionCmPrjIdRela.Memo] == DBNull.Value ? null : objRow[conViewRegionCmPrjIdRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionCmPrjIdRelaEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionCmPrjIdRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewRegionCmPrjIdRela(ref clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
bool bolResult = ViewRegionCmPrjIdRelaDA.GetViewRegionCmPrjIdRela(ref objViewRegionCmPrjIdRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionCmPrjIdRelaEN GetObjByKeyLst(string strRegionId,string strCmPrjId)
{
if (strRegionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strRegionId,strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strCmPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strRegionId,strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRegionId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strRegionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strCmPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = ViewRegionCmPrjIdRelaDA.GetObjByKeyLst(strRegionId,strCmPrjId);
return objViewRegionCmPrjIdRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewRegionCmPrjIdRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = ViewRegionCmPrjIdRelaDA.GetFirstObj(strWhereCond);
 return objViewRegionCmPrjIdRelaEN;
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
public static clsViewRegionCmPrjIdRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = ViewRegionCmPrjIdRelaDA.GetObjByDataRow(objRow);
 return objViewRegionCmPrjIdRelaEN;
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
public static clsViewRegionCmPrjIdRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = ViewRegionCmPrjIdRelaDA.GetObjByDataRow(objRow);
 return objViewRegionCmPrjIdRelaEN;
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
 /// <param name = "strRegionId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <param name = "lstViewRegionCmPrjIdRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionCmPrjIdRelaEN GetObjByKeyLstFromList(string strRegionId,string strCmPrjId, List<clsViewRegionCmPrjIdRelaEN> lstViewRegionCmPrjIdRelaObjLst)
{
foreach (clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN in lstViewRegionCmPrjIdRelaObjLst)
{
if (objViewRegionCmPrjIdRelaEN.RegionId == strRegionId 
 && objViewRegionCmPrjIdRelaEN.CmPrjId == strCmPrjId 
)
{
return objViewRegionCmPrjIdRelaEN;
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
 string strRegionId;
 try
 {
 strRegionId = new clsViewRegionCmPrjIdRelaDA().GetFirstID(strWhereCond);
 return strRegionId;
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
 arrList = ViewRegionCmPrjIdRelaDA.GetID(strWhereCond);
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
bool bolIsExist = ViewRegionCmPrjIdRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRegionId,string strCmPrjId)
{
//检测记录是否存在
bool bolIsExist = ViewRegionCmPrjIdRelaDA.IsExist(strRegionId,strCmPrjId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRegionId">区域Id</param>
/// <param name = "strCmPrjId">Cm工程Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRegionId , string strCmPrjId, string strOpUser)
{
clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = clsViewRegionCmPrjIdRelaBL.GetObjByKeyLst(strRegionId,strCmPrjId);
objViewRegionCmPrjIdRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewRegionCmPrjIdRelaEN.UpdUser = strOpUser;
return clsViewRegionCmPrjIdRelaBL.UpdateBySql2(objViewRegionCmPrjIdRelaEN);
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
 bolIsExist = clsViewRegionCmPrjIdRelaDA.IsExistTable();
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
 bolIsExist = ViewRegionCmPrjIdRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewRegionCmPrjIdRelaBL.IsExist(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewRegionCmPrjIdRelaEN.RegionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ViewRegionCmPrjIdRelaDA.AddNewRecordBySQL2(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewRegionCmPrjIdRelaBL.IsExist(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewRegionCmPrjIdRelaEN.RegionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ViewRegionCmPrjIdRelaDA.AddNewRecordBySQL2WithReturnKey(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
try
{
bool bolResult = ViewRegionCmPrjIdRelaDA.Update(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 if (string.IsNullOrEmpty(objViewRegionCmPrjIdRelaEN.RegionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewRegionCmPrjIdRelaDA.UpdateBySql2(objViewRegionCmPrjIdRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionCmPrjIdRelaBL.ReFreshCache();

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRegionId,string strCmPrjId)
{
try
{
 clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN = clsViewRegionCmPrjIdRelaBL.GetObjByKeyLst(strRegionId,strCmPrjId);

if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(objViewRegionCmPrjIdRelaEN.RegionId,objViewRegionCmPrjIdRelaEN.CmPrjId, objViewRegionCmPrjIdRelaEN.UpdUser);
}
if (objViewRegionCmPrjIdRelaEN != null)
{
int intRecNum = ViewRegionCmPrjIdRelaDA.DelRecord(strRegionId,strCmPrjId);
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
/// <param name="strRegionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRegionId,string strCmPrjId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewRegionCmPrjIdRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewRegionCmPrjIdRela.RegionId,
//strRegionId);
//        clsViewRegionCmPrjIdRelaBL.DelViewRegionCmPrjIdRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionCmPrjIdRelaBL.DelRecord(strRegionId,strCmPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionCmPrjIdRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRegionId,string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(strRegionId,strCmPrjId, "UpdRelaTabDate");
}
bool bolResult = ViewRegionCmPrjIdRelaDA.DelRecord(strRegionId,strCmPrjId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRegionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strRegionId;
string strCmPrjId;
if (clsViewRegionCmPrjIdRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strRegionId = sstrKey[0];
strCmPrjId = sstrKey[1];
clsViewRegionCmPrjIdRelaBL.relatedActions.UpdRelaTabDate(strRegionId,strCmPrjId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strRegionId = sstrKey[0];
strCmPrjId = sstrKey[1];
int intDelRecNum = ViewRegionCmPrjIdRelaDA.DelRecKeyLsts(arrKeyLsts);
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
public static int DelViewRegionCmPrjIdRelasByCond(string strWhereCond)
{
try
{
int intRecNum = ViewRegionCmPrjIdRelaDA.DelViewRegionCmPrjIdRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewRegionCmPrjIdRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRegionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRegionId,string strCmPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRegionCmPrjIdRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewRegionCmPrjIdRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionCmPrjIdRelaBL.DelRecord(strRegionId,strCmPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionCmPrjIdRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewRegionCmPrjIdRelaENS">源对象</param>
 /// <param name = "objViewRegionCmPrjIdRelaENT">目标对象</param>
 public static void CopyTo(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENS, clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaENT)
{
try
{
objViewRegionCmPrjIdRelaENT.RegionId = objViewRegionCmPrjIdRelaENS.RegionId; //区域Id
objViewRegionCmPrjIdRelaENT.CmPrjId = objViewRegionCmPrjIdRelaENS.CmPrjId; //Cm工程Id
objViewRegionCmPrjIdRelaENT.UpdUser = objViewRegionCmPrjIdRelaENS.UpdUser; //修改者
objViewRegionCmPrjIdRelaENT.UpdDate = objViewRegionCmPrjIdRelaENS.UpdDate; //修改日期
objViewRegionCmPrjIdRelaENT.Memo = objViewRegionCmPrjIdRelaENS.Memo; //说明
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
try
{
objViewRegionCmPrjIdRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewRegionCmPrjIdRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewRegionCmPrjIdRela.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionCmPrjIdRelaEN.RegionId = objViewRegionCmPrjIdRelaEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conViewRegionCmPrjIdRela.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionCmPrjIdRelaEN.CmPrjId = objViewRegionCmPrjIdRelaEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conViewRegionCmPrjIdRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionCmPrjIdRelaEN.UpdUser = objViewRegionCmPrjIdRelaEN.UpdUser == "[null]" ? null :  objViewRegionCmPrjIdRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewRegionCmPrjIdRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionCmPrjIdRelaEN.UpdDate = objViewRegionCmPrjIdRelaEN.UpdDate == "[null]" ? null :  objViewRegionCmPrjIdRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewRegionCmPrjIdRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionCmPrjIdRelaEN.Memo = objViewRegionCmPrjIdRelaEN.Memo == "[null]" ? null :  objViewRegionCmPrjIdRelaEN.Memo; //说明
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
 /// <param name = "objViewRegionCmPrjIdRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
try
{
if (objViewRegionCmPrjIdRelaEN.UpdUser == "[null]") objViewRegionCmPrjIdRelaEN.UpdUser = null; //修改者
if (objViewRegionCmPrjIdRelaEN.UpdDate == "[null]") objViewRegionCmPrjIdRelaEN.UpdDate = null; //修改日期
if (objViewRegionCmPrjIdRelaEN.Memo == "[null]") objViewRegionCmPrjIdRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 ViewRegionCmPrjIdRelaDA.CheckPropertyNew(objViewRegionCmPrjIdRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaEN)
{
 ViewRegionCmPrjIdRelaDA.CheckProperty4Condition(objViewRegionCmPrjIdRelaEN);
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
if (clsViewRegionCmPrjIdRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionCmPrjIdRelaBL没有刷新缓存机制(clsViewRegionCmPrjIdRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RegionId");
//if (arrViewRegionCmPrjIdRelaObjLstCache == null)
//{
//arrViewRegionCmPrjIdRelaObjLstCache = ViewRegionCmPrjIdRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionCmPrjIdRelaEN GetObjByKeyLstCache(string strRegionId,string strCmPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewRegionCmPrjIdRelaEN._CurrTabName);
List<clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLstCache = GetObjLstCache();
IEnumerable <clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLst_Sel =
arrViewRegionCmPrjIdRelaObjLstCache
.Where(x=> x.RegionId == strRegionId 
 && x.CmPrjId == strCmPrjId 
);
if (arrViewRegionCmPrjIdRelaObjLst_Sel.Count() == 0)
{
   clsViewRegionCmPrjIdRelaEN obj = clsViewRegionCmPrjIdRelaBL.GetObjByKeyLst(strRegionId,strCmPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewRegionCmPrjIdRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetAllViewRegionCmPrjIdRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLstCache = GetObjLstCache(); 
return arrViewRegionCmPrjIdRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionCmPrjIdRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewRegionCmPrjIdRelaEN._CurrTabName);
List<clsViewRegionCmPrjIdRelaEN> arrViewRegionCmPrjIdRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewRegionCmPrjIdRelaObjLstCache;
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
string strKey = string.Format("{0}", clsViewRegionCmPrjIdRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewRegionCmPrjIdRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewRegionCmPrjIdRelaEN._RefreshTimeLst.Count == 0) return "";
return clsViewRegionCmPrjIdRelaEN._RefreshTimeLst[clsViewRegionCmPrjIdRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsViewRegionCmPrjIdRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewRegionCmPrjIdRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewRegionCmPrjIdRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewRegionCmPrjIdRelaBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strRegionId,string strCmPrjId)
{
if (strInFldName != conViewRegionCmPrjIdRela.RegionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewRegionCmPrjIdRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewRegionCmPrjIdRela._AttributeName));
throw new Exception(strMsg);
}
var objViewRegionCmPrjIdRela = clsViewRegionCmPrjIdRelaBL.GetObjByKeyLstCache(strRegionId,strCmPrjId);
if (objViewRegionCmPrjIdRela == null) return "";
return objViewRegionCmPrjIdRela[strOutFldName].ToString();
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewRegionCmPrjIdRelaDA.GetRecCount();
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewRegionCmPrjIdRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewRegionCmPrjIdRelaEN objViewRegionCmPrjIdRelaCond)
{
List<clsViewRegionCmPrjIdRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewRegionCmPrjIdRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegionCmPrjIdRela._AttributeName)
{
if (objViewRegionCmPrjIdRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionCmPrjIdRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCmPrjIdRelaCond[strFldName].ToString());
}
else
{
if (objViewRegionCmPrjIdRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionCmPrjIdRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCmPrjIdRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionCmPrjIdRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionCmPrjIdRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionCmPrjIdRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionCmPrjIdRelaCond[strFldName]));
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
 List<string> arrList = clsViewRegionCmPrjIdRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionCmPrjIdRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionCmPrjIdRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewRegionCmPrjIdRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.SetFldValue(clsViewRegionCmPrjIdRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewRegionCmPrjIdRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionCmPrjIdRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewRegionCmPrjIdRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) primary key, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) primary key, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面区域CmPrjId关系(ViewRegionCmPrjIdRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewRegionCmPrjIdRela : clsCommFun4BL
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
clsViewRegionCmPrjIdRelaBL.ReFreshThisCache();
}
}

}