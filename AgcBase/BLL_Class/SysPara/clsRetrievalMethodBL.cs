
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRetrievalMethodBL
 表名:RetrievalMethod(00050632)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsRetrievalMethodBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRetrievalMethodId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRetrievalMethodEN GetObj(this K_RetrievalMethodId_RetrievalMethod myKey)
{
clsRetrievalMethodEN objRetrievalMethodEN = clsRetrievalMethodBL.RetrievalMethodDA.GetObjByRetrievalMethodId(myKey.Value);
return objRetrievalMethodEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRetrievalMethodEN) == false)
{
var strMsg = string.Format("记录已经存在!获取方式名 = [{0}]的数据已经存在!(in clsRetrievalMethodBL.AddNewRecord)", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
bool bolResult = clsRetrievalMethodBL.RetrievalMethodDA.AddNewRecordBySQL2(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
public static bool AddRecordEx(this clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objRetrievalMethodEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objRetrievalMethodEN.CheckUniqueness() == false)
{
strMsg = string.Format("(获取方式名(RetrievalMethodName)=[{0}])已经存在,不能重复!", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objRetrievalMethodEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRetrievalMethodEN) == false)
{
var strMsg = string.Format("记录已经存在!获取方式名 = [{0}]的数据已经存在!(in clsRetrievalMethodBL.AddNewRecordWithMaxId)", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
string strRetrievalMethodId = clsRetrievalMethodBL.RetrievalMethodDA.AddNewRecordBySQL2WithReturnKey(objRetrievalMethodEN);
     objRetrievalMethodEN.RetrievalMethodId = strRetrievalMethodId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
}
return strRetrievalMethodId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRetrievalMethodEN) == false)
{
var strMsg = string.Format("记录已经存在!获取方式名 = [{0}]的数据已经存在!(in clsRetrievalMethodBL.AddNewRecordWithReturnKey)", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
string strKey = clsRetrievalMethodBL.RetrievalMethodDA.AddNewRecordBySQL2WithReturnKey(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetRetrievalMethodId(this clsRetrievalMethodEN objRetrievalMethodEN, string strRetrievalMethodId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRetrievalMethodId, 2, conRetrievalMethod.RetrievalMethodId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRetrievalMethodId, 2, conRetrievalMethod.RetrievalMethodId);
}
objRetrievalMethodEN.RetrievalMethodId = strRetrievalMethodId; //获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.RetrievalMethodId) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.RetrievalMethodId, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodId] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetRetrievalMethodName(this clsRetrievalMethodEN objRetrievalMethodEN, string strRetrievalMethodName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRetrievalMethodName, conRetrievalMethod.RetrievalMethodName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRetrievalMethodName, 50, conRetrievalMethod.RetrievalMethodName);
}
objRetrievalMethodEN.RetrievalMethodName = strRetrievalMethodName; //获取方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.RetrievalMethodName) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.RetrievalMethodName, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodName] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetRetrievalMethodEnName(this clsRetrievalMethodEN objRetrievalMethodEN, string strRetrievalMethodEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRetrievalMethodEnName, conRetrievalMethod.RetrievalMethodEnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRetrievalMethodEnName, 50, conRetrievalMethod.RetrievalMethodEnName);
}
objRetrievalMethodEN.RetrievalMethodEnName = strRetrievalMethodEnName; //获取方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.RetrievalMethodEnName) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.RetrievalMethodEnName, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodEnName] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetUpdDate(this clsRetrievalMethodEN objRetrievalMethodEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conRetrievalMethod.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRetrievalMethod.UpdDate);
}
objRetrievalMethodEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.UpdDate) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.UpdDate, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.UpdDate] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetUpdUser(this clsRetrievalMethodEN objRetrievalMethodEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conRetrievalMethod.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRetrievalMethod.UpdUser);
}
objRetrievalMethodEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.UpdUser) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.UpdUser, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.UpdUser] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRetrievalMethodEN SetMemo(this clsRetrievalMethodEN objRetrievalMethodEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRetrievalMethod.Memo);
}
objRetrievalMethodEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRetrievalMethodEN.dicFldComparisonOp.ContainsKey(conRetrievalMethod.Memo) == false)
{
objRetrievalMethodEN.dicFldComparisonOp.Add(conRetrievalMethod.Memo, strComparisonOp);
}
else
{
objRetrievalMethodEN.dicFldComparisonOp[conRetrievalMethod.Memo] = strComparisonOp;
}
}
return objRetrievalMethodEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRetrievalMethodEN objRetrievalMethodEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRetrievalMethodEN.CheckPropertyNew();
clsRetrievalMethodEN objRetrievalMethodCond = new clsRetrievalMethodEN();
string strCondition = objRetrievalMethodCond
.SetRetrievalMethodId(objRetrievalMethodEN.RetrievalMethodId, "<>")
.SetRetrievalMethodName(objRetrievalMethodEN.RetrievalMethodName, "=")
.GetCombineCondition();
objRetrievalMethodEN._IsCheckProperty = true;
bool bolIsExist = clsRetrievalMethodBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(22)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRetrievalMethodEN.Update();
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
 /// <param name = "objRetrievalMethod">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRetrievalMethodEN objRetrievalMethod)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRetrievalMethodEN objRetrievalMethodCond = new clsRetrievalMethodEN();
string strCondition = objRetrievalMethodCond
.SetRetrievalMethodName(objRetrievalMethod.RetrievalMethodName, "=")
.GetCombineCondition();
objRetrievalMethod._IsCheckProperty = true;
bool bolIsExist = clsRetrievalMethodBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRetrievalMethod.RetrievalMethodId = clsRetrievalMethodBL.GetFirstID_S(strCondition);
objRetrievalMethod.UpdateWithCondition(strCondition);
}
else
{
objRetrievalMethod.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
objRetrievalMethod.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRetrievalMethodEN objRetrievalMethodEN)
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRetrievalMethodBL.RetrievalMethodDA.UpdateBySql2(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRetrievalMethodEN objRetrievalMethodEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRetrievalMethodBL.RetrievalMethodDA.UpdateBySql2(objRetrievalMethodEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRetrievalMethodEN objRetrievalMethodEN, string strWhereCond)
{
try
{
bool bolResult = clsRetrievalMethodBL.RetrievalMethodDA.UpdateBySqlWithCondition(objRetrievalMethodEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRetrievalMethodEN objRetrievalMethodEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRetrievalMethodBL.RetrievalMethodDA.UpdateBySqlWithConditionTransaction(objRetrievalMethodEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "strRetrievalMethodId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsRetrievalMethodEN objRetrievalMethodEN)
{
try
{
int intRecNum = clsRetrievalMethodBL.RetrievalMethodDA.DelRecord(objRetrievalMethodEN.RetrievalMethodId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <param name = "objRetrievalMethodENT">目标对象</param>
 public static void CopyTo(this clsRetrievalMethodEN objRetrievalMethodENS, clsRetrievalMethodEN objRetrievalMethodENT)
{
try
{
objRetrievalMethodENT.RetrievalMethodId = objRetrievalMethodENS.RetrievalMethodId; //获取方式Id
objRetrievalMethodENT.RetrievalMethodName = objRetrievalMethodENS.RetrievalMethodName; //获取方式名
objRetrievalMethodENT.RetrievalMethodEnName = objRetrievalMethodENS.RetrievalMethodEnName; //获取方式英文名
objRetrievalMethodENT.UpdDate = objRetrievalMethodENS.UpdDate; //修改日期
objRetrievalMethodENT.UpdUser = objRetrievalMethodENS.UpdUser; //修改者
objRetrievalMethodENT.Memo = objRetrievalMethodENS.Memo; //说明
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
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <returns>目标对象=>clsRetrievalMethodEN:objRetrievalMethodENT</returns>
 public static clsRetrievalMethodEN CopyTo(this clsRetrievalMethodEN objRetrievalMethodENS)
{
try
{
 clsRetrievalMethodEN objRetrievalMethodENT = new clsRetrievalMethodEN()
{
RetrievalMethodId = objRetrievalMethodENS.RetrievalMethodId, //获取方式Id
RetrievalMethodName = objRetrievalMethodENS.RetrievalMethodName, //获取方式名
RetrievalMethodEnName = objRetrievalMethodENS.RetrievalMethodEnName, //获取方式英文名
UpdDate = objRetrievalMethodENS.UpdDate, //修改日期
UpdUser = objRetrievalMethodENS.UpdUser, //修改者
Memo = objRetrievalMethodENS.Memo, //说明
};
 return objRetrievalMethodENT;
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
public static void CheckPropertyNew(this clsRetrievalMethodEN objRetrievalMethodEN)
{
 clsRetrievalMethodBL.RetrievalMethodDA.CheckPropertyNew(objRetrievalMethodEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRetrievalMethodEN objRetrievalMethodEN)
{
 clsRetrievalMethodBL.RetrievalMethodDA.CheckProperty4Condition(objRetrievalMethodEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRetrievalMethodEN objRetrievalMethodCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.RetrievalMethodId) == true)
{
string strComparisonOpRetrievalMethodId = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.RetrievalMethodId, objRetrievalMethodCond.RetrievalMethodId, strComparisonOpRetrievalMethodId);
}
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.RetrievalMethodName) == true)
{
string strComparisonOpRetrievalMethodName = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.RetrievalMethodName, objRetrievalMethodCond.RetrievalMethodName, strComparisonOpRetrievalMethodName);
}
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.RetrievalMethodEnName) == true)
{
string strComparisonOpRetrievalMethodEnName = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.RetrievalMethodEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.RetrievalMethodEnName, objRetrievalMethodCond.RetrievalMethodEnName, strComparisonOpRetrievalMethodEnName);
}
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.UpdDate) == true)
{
string strComparisonOpUpdDate = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.UpdDate, objRetrievalMethodCond.UpdDate, strComparisonOpUpdDate);
}
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.UpdUser) == true)
{
string strComparisonOpUpdUser = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.UpdUser, objRetrievalMethodCond.UpdUser, strComparisonOpUpdUser);
}
if (objRetrievalMethodCond.IsUpdated(conRetrievalMethod.Memo) == true)
{
string strComparisonOpMemo = objRetrievalMethodCond.dicFldComparisonOp[conRetrievalMethod.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRetrievalMethod.Memo, objRetrievalMethodCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--RetrievalMethod(获取方式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RetrievalMethodName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRetrievalMethodEN objRetrievalMethodEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRetrievalMethodEN == null) return true;
if (objRetrievalMethodEN.RetrievalMethodId == null || objRetrievalMethodEN.RetrievalMethodId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RetrievalMethodName = '{0}'", objRetrievalMethodEN.RetrievalMethodName);
if (clsRetrievalMethodBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RetrievalMethodId !=  '{0}'", objRetrievalMethodEN.RetrievalMethodId);
 sbCondition.AppendFormat(" and RetrievalMethodName = '{0}'", objRetrievalMethodEN.RetrievalMethodName);
if (clsRetrievalMethodBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--RetrievalMethod(获取方式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RetrievalMethodName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRetrievalMethodEN objRetrievalMethodEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRetrievalMethodEN == null) return "";
if (objRetrievalMethodEN.RetrievalMethodId == null || objRetrievalMethodEN.RetrievalMethodId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RetrievalMethodName = '{0}'", objRetrievalMethodEN.RetrievalMethodName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RetrievalMethodId !=  '{0}'", objRetrievalMethodEN.RetrievalMethodId);
 sbCondition.AppendFormat(" and RetrievalMethodName = '{0}'", objRetrievalMethodEN.RetrievalMethodName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RetrievalMethod
{
public virtual bool UpdRelaTabDate(string strRetrievalMethodId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumRetrievalMethod
{
 /// <summary>
 /// 未定义
 /// </summary>
public const string Undefined_01 = "01";
 /// <summary>
 /// 路由参数
 /// </summary>
public const string RouteParameters_02 = "02";
 /// <summary>
 /// 路由查询
 /// </summary>
public const string RouteQuery_03 = "03";
 /// <summary>
 /// SessionStorage
 /// </summary>
public const string SessionStorage_04 = "04";
 /// <summary>
 /// LocalStorage
 /// </summary>
public const string LocalStorage_05 = "05";
 /// <summary>
 /// Store存储
 /// </summary>
public const string StoreStorage_06 = "06";
 /// <summary>
 /// 自定义
 /// </summary>
public const string CustomDefined_07 = "07";
}
 /// <summary>
 /// 获取方式(RetrievalMethod)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRetrievalMethodBL
{
public static RelatedActions_RetrievalMethod relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRetrievalMethodDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRetrievalMethodDA RetrievalMethodDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRetrievalMethodDA();
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
 public clsRetrievalMethodBL()
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
if (string.IsNullOrEmpty(clsRetrievalMethodEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRetrievalMethodEN._ConnectString);
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
public static DataTable GetDataTable_RetrievalMethod(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RetrievalMethodDA.GetDataTable_RetrievalMethod(strWhereCond);
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
objDT = RetrievalMethodDA.GetDataTable(strWhereCond);
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
objDT = RetrievalMethodDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RetrievalMethodDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RetrievalMethodDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RetrievalMethodDA.GetDataTable_Top(objTopPara);
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
objDT = RetrievalMethodDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RetrievalMethodDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RetrievalMethodDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRetrievalMethodIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsRetrievalMethodEN> GetObjLstByRetrievalMethodIdLst(List<string> arrRetrievalMethodIdLst)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRetrievalMethodIdLst, true);
 string strWhereCond = string.Format("RetrievalMethodId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRetrievalMethodIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRetrievalMethodEN> GetObjLstByRetrievalMethodIdLstCache(List<string> arrRetrievalMethodIdLst)
{
string strKey = string.Format("{0}", clsRetrievalMethodEN._CurrTabName);
List<clsRetrievalMethodEN> arrRetrievalMethodObjLstCache = GetObjLstCache();
IEnumerable <clsRetrievalMethodEN> arrRetrievalMethodObjLst_Sel =
arrRetrievalMethodObjLstCache
.Where(x => arrRetrievalMethodIdLst.Contains(x.RetrievalMethodId));
return arrRetrievalMethodObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRetrievalMethodEN> GetObjLst(string strWhereCond)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
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
public static List<clsRetrievalMethodEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRetrievalMethodCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRetrievalMethodEN> GetSubObjLstCache(clsRetrievalMethodEN objRetrievalMethodCond)
{
List<clsRetrievalMethodEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRetrievalMethodEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRetrievalMethod._AttributeName)
{
if (objRetrievalMethodCond.IsUpdated(strFldName) == false) continue;
if (objRetrievalMethodCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRetrievalMethodCond[strFldName].ToString());
}
else
{
if (objRetrievalMethodCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRetrievalMethodCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRetrievalMethodCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRetrievalMethodCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRetrievalMethodCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRetrievalMethodCond[strFldName]));
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
public static List<clsRetrievalMethodEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
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
public static List<clsRetrievalMethodEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
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
List<clsRetrievalMethodEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRetrievalMethodEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRetrievalMethodEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRetrievalMethodEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
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
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
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
public static List<clsRetrievalMethodEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRetrievalMethodEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRetrievalMethodEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
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
public static List<clsRetrievalMethodEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRetrievalMethodEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRetrievalMethodEN> arrObjLst = new List<clsRetrievalMethodEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRetrievalMethodEN objRetrievalMethodEN = new clsRetrievalMethodEN();
try
{
objRetrievalMethodEN.RetrievalMethodId = objRow[conRetrievalMethod.RetrievalMethodId].ToString().Trim(); //获取方式Id
objRetrievalMethodEN.RetrievalMethodName = objRow[conRetrievalMethod.RetrievalMethodName].ToString().Trim(); //获取方式名
objRetrievalMethodEN.RetrievalMethodEnName = objRow[conRetrievalMethod.RetrievalMethodEnName].ToString().Trim(); //获取方式英文名
objRetrievalMethodEN.UpdDate = objRow[conRetrievalMethod.UpdDate].ToString().Trim(); //修改日期
objRetrievalMethodEN.UpdUser = objRow[conRetrievalMethod.UpdUser].ToString().Trim(); //修改者
objRetrievalMethodEN.Memo = objRow[conRetrievalMethod.Memo] == DBNull.Value ? null : objRow[conRetrievalMethod.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRetrievalMethodEN.RetrievalMethodId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRetrievalMethodEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRetrievalMethod(ref clsRetrievalMethodEN objRetrievalMethodEN)
{
bool bolResult = RetrievalMethodDA.GetRetrievalMethod(ref objRetrievalMethodEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRetrievalMethodId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRetrievalMethodEN GetObjByRetrievalMethodId(string strRetrievalMethodId)
{
if (strRetrievalMethodId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRetrievalMethodId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRetrievalMethodId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRetrievalMethodId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsRetrievalMethodEN objRetrievalMethodEN = RetrievalMethodDA.GetObjByRetrievalMethodId(strRetrievalMethodId);
return objRetrievalMethodEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRetrievalMethodEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRetrievalMethodEN objRetrievalMethodEN = RetrievalMethodDA.GetFirstObj(strWhereCond);
 return objRetrievalMethodEN;
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
public static clsRetrievalMethodEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRetrievalMethodEN objRetrievalMethodEN = RetrievalMethodDA.GetObjByDataRow(objRow);
 return objRetrievalMethodEN;
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
public static clsRetrievalMethodEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRetrievalMethodEN objRetrievalMethodEN = RetrievalMethodDA.GetObjByDataRow(objRow);
 return objRetrievalMethodEN;
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
 /// <param name = "strRetrievalMethodId">所给的关键字</param>
 /// <param name = "lstRetrievalMethodObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRetrievalMethodEN GetObjByRetrievalMethodIdFromList(string strRetrievalMethodId, List<clsRetrievalMethodEN> lstRetrievalMethodObjLst)
{
foreach (clsRetrievalMethodEN objRetrievalMethodEN in lstRetrievalMethodObjLst)
{
if (objRetrievalMethodEN.RetrievalMethodId == strRetrievalMethodId)
{
return objRetrievalMethodEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxRetrievalMethodId;
 try
 {
 strMaxRetrievalMethodId = clsRetrievalMethodDA.GetMaxStrId();
 return strMaxRetrievalMethodId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strRetrievalMethodId;
 try
 {
 strRetrievalMethodId = new clsRetrievalMethodDA().GetFirstID(strWhereCond);
 return strRetrievalMethodId;
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
 arrList = RetrievalMethodDA.GetID(strWhereCond);
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
bool bolIsExist = RetrievalMethodDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRetrievalMethodId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRetrievalMethodId)
{
if (string.IsNullOrEmpty(strRetrievalMethodId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRetrievalMethodId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = RetrievalMethodDA.IsExist(strRetrievalMethodId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRetrievalMethodId">获取方式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRetrievalMethodId, string strOpUser)
{
clsRetrievalMethodEN objRetrievalMethodEN = clsRetrievalMethodBL.GetObjByRetrievalMethodId(strRetrievalMethodId);
objRetrievalMethodEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objRetrievalMethodEN.UpdUser = strOpUser;
return clsRetrievalMethodBL.UpdateBySql2(objRetrievalMethodEN);
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
 bolIsExist = clsRetrievalMethodDA.IsExistTable();
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
 bolIsExist = RetrievalMethodDA.IsExistTable(strTabName);
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
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRetrievalMethodEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!获取方式名 = [{0}]的数据已经存在!(in clsRetrievalMethodBL.AddNewRecordBySql2)", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
bool bolResult = RetrievalMethodDA.AddNewRecordBySQL2(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRetrievalMethodEN objRetrievalMethodEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRetrievalMethodEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!获取方式名 = [{0}]的数据已经存在!(in clsRetrievalMethodBL.AddNewRecordBySql2WithReturnKey)", objRetrievalMethodEN.RetrievalMethodName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true || clsRetrievalMethodBL.IsExist(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
     objRetrievalMethodEN.RetrievalMethodId = clsRetrievalMethodBL.GetMaxStrId_S();
 }
string strKey = RetrievalMethodDA.AddNewRecordBySQL2WithReturnKey(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRetrievalMethodEN objRetrievalMethodEN)
{
try
{
bool bolResult = RetrievalMethodDA.Update(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "objRetrievalMethodEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRetrievalMethodEN objRetrievalMethodEN)
{
 if (string.IsNullOrEmpty(objRetrievalMethodEN.RetrievalMethodId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RetrievalMethodDA.UpdateBySql2(objRetrievalMethodEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRetrievalMethodBL.ReFreshCache();

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
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
 /// <param name = "strRetrievalMethodId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRetrievalMethodId)
{
try
{
 clsRetrievalMethodEN objRetrievalMethodEN = clsRetrievalMethodBL.GetObjByRetrievalMethodId(strRetrievalMethodId);

if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(objRetrievalMethodEN.RetrievalMethodId, objRetrievalMethodEN.UpdUser);
}
if (objRetrievalMethodEN != null)
{
int intRecNum = RetrievalMethodDA.DelRecord(strRetrievalMethodId);
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
/// <param name="strRetrievalMethodId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRetrievalMethodId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRetrievalMethodDA.GetSpecSQLObj();
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
//删除与表:[RetrievalMethod]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRetrievalMethod.RetrievalMethodId,
//strRetrievalMethodId);
//        clsRetrievalMethodBL.DelRetrievalMethodsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRetrievalMethodBL.DelRecord(strRetrievalMethodId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRetrievalMethodBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRetrievalMethodId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRetrievalMethodId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRetrievalMethodId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRetrievalMethodBL.relatedActions != null)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(strRetrievalMethodId, "UpdRelaTabDate");
}
bool bolResult = RetrievalMethodDA.DelRecord(strRetrievalMethodId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRetrievalMethodIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRetrievalMethods(List<string> arrRetrievalMethodIdLst)
{
if (arrRetrievalMethodIdLst.Count == 0) return 0;
try
{
if (clsRetrievalMethodBL.relatedActions != null)
{
foreach (var strRetrievalMethodId in arrRetrievalMethodIdLst)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(strRetrievalMethodId, "UpdRelaTabDate");
}
}
int intDelRecNum = RetrievalMethodDA.DelRetrievalMethod(arrRetrievalMethodIdLst);
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
public static int DelRetrievalMethodsByCond(string strWhereCond)
{
try
{
if (clsRetrievalMethodBL.relatedActions != null)
{
List<string> arrRetrievalMethodId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRetrievalMethodId in arrRetrievalMethodId)
{
clsRetrievalMethodBL.relatedActions.UpdRelaTabDate(strRetrievalMethodId, "UpdRelaTabDate");
}
}
int intRecNum = RetrievalMethodDA.DelRetrievalMethod(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RetrievalMethod]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRetrievalMethodId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRetrievalMethodId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRetrievalMethodDA.GetSpecSQLObj();
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
//删除与表:[RetrievalMethod]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRetrievalMethodBL.DelRecord(strRetrievalMethodId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRetrievalMethodBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRetrievalMethodId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objRetrievalMethodENS">源对象</param>
 /// <param name = "objRetrievalMethodENT">目标对象</param>
 public static void CopyTo(clsRetrievalMethodEN objRetrievalMethodENS, clsRetrievalMethodEN objRetrievalMethodENT)
{
try
{
objRetrievalMethodENT.RetrievalMethodId = objRetrievalMethodENS.RetrievalMethodId; //获取方式Id
objRetrievalMethodENT.RetrievalMethodName = objRetrievalMethodENS.RetrievalMethodName; //获取方式名
objRetrievalMethodENT.RetrievalMethodEnName = objRetrievalMethodENS.RetrievalMethodEnName; //获取方式英文名
objRetrievalMethodENT.UpdDate = objRetrievalMethodENS.UpdDate; //修改日期
objRetrievalMethodENT.UpdUser = objRetrievalMethodENS.UpdUser; //修改者
objRetrievalMethodENT.Memo = objRetrievalMethodENS.Memo; //说明
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
 /// <param name = "objRetrievalMethodEN">源简化对象</param>
 public static void SetUpdFlag(clsRetrievalMethodEN objRetrievalMethodEN)
{
try
{
objRetrievalMethodEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRetrievalMethodEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRetrievalMethod.RetrievalMethodId, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.RetrievalMethodId = objRetrievalMethodEN.RetrievalMethodId; //获取方式Id
}
if (arrFldSet.Contains(conRetrievalMethod.RetrievalMethodName, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.RetrievalMethodName = objRetrievalMethodEN.RetrievalMethodName; //获取方式名
}
if (arrFldSet.Contains(conRetrievalMethod.RetrievalMethodEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.RetrievalMethodEnName = objRetrievalMethodEN.RetrievalMethodEnName; //获取方式英文名
}
if (arrFldSet.Contains(conRetrievalMethod.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.UpdDate = objRetrievalMethodEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conRetrievalMethod.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.UpdUser = objRetrievalMethodEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conRetrievalMethod.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRetrievalMethodEN.Memo = objRetrievalMethodEN.Memo == "[null]" ? null :  objRetrievalMethodEN.Memo; //说明
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
 /// <param name = "objRetrievalMethodEN">源简化对象</param>
 public static void AccessFldValueNull(clsRetrievalMethodEN objRetrievalMethodEN)
{
try
{
if (objRetrievalMethodEN.Memo == "[null]") objRetrievalMethodEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsRetrievalMethodEN objRetrievalMethodEN)
{
 RetrievalMethodDA.CheckPropertyNew(objRetrievalMethodEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRetrievalMethodEN objRetrievalMethodEN)
{
 RetrievalMethodDA.CheckProperty4Condition(objRetrievalMethodEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RetrievalMethodIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[获取方式]...","0");
List<clsRetrievalMethodEN> arrRetrievalMethodObjLst = GetAllRetrievalMethodObjLstCache(); 
objDDL.DataValueField = conRetrievalMethod.RetrievalMethodId;
objDDL.DataTextField = conRetrievalMethod.RetrievalMethodName;
objDDL.DataSource = arrRetrievalMethodObjLst;
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
if (clsRetrievalMethodBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRetrievalMethodBL没有刷新缓存机制(clsRetrievalMethodBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RetrievalMethodId");
//if (arrRetrievalMethodObjLstCache == null)
//{
//arrRetrievalMethodObjLstCache = RetrievalMethodDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRetrievalMethodId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRetrievalMethodEN GetObjByRetrievalMethodIdCache(string strRetrievalMethodId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsRetrievalMethodEN._CurrTabName);
List<clsRetrievalMethodEN> arrRetrievalMethodObjLstCache = GetObjLstCache();
IEnumerable <clsRetrievalMethodEN> arrRetrievalMethodObjLst_Sel =
arrRetrievalMethodObjLstCache
.Where(x=> x.RetrievalMethodId == strRetrievalMethodId 
);
if (arrRetrievalMethodObjLst_Sel.Count() == 0)
{
   clsRetrievalMethodEN obj = clsRetrievalMethodBL.GetObjByRetrievalMethodId(strRetrievalMethodId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrRetrievalMethodObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRetrievalMethodId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRetrievalMethodNameByRetrievalMethodIdCache(string strRetrievalMethodId)
{
if (string.IsNullOrEmpty(strRetrievalMethodId) == true) return "";
//获取缓存中的对象列表
clsRetrievalMethodEN objRetrievalMethod = GetObjByRetrievalMethodIdCache(strRetrievalMethodId);
if (objRetrievalMethod == null) return "";
return objRetrievalMethod.RetrievalMethodName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRetrievalMethodId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRetrievalMethodIdCache(string strRetrievalMethodId)
{
if (string.IsNullOrEmpty(strRetrievalMethodId) == true) return "";
//获取缓存中的对象列表
clsRetrievalMethodEN objRetrievalMethod = GetObjByRetrievalMethodIdCache(strRetrievalMethodId);
if (objRetrievalMethod == null) return "";
return objRetrievalMethod.RetrievalMethodName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRetrievalMethodEN> GetAllRetrievalMethodObjLstCache()
{
//获取缓存中的对象列表
List<clsRetrievalMethodEN> arrRetrievalMethodObjLstCache = GetObjLstCache(); 
return arrRetrievalMethodObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRetrievalMethodEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsRetrievalMethodEN._CurrTabName);
List<clsRetrievalMethodEN> arrRetrievalMethodObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRetrievalMethodObjLstCache;
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
string strKey = string.Format("{0}", clsRetrievalMethodEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRetrievalMethodEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRetrievalMethodEN._RefreshTimeLst.Count == 0) return "";
return clsRetrievalMethodEN._RefreshTimeLst[clsRetrievalMethodEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsRetrievalMethodBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRetrievalMethodEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRetrievalMethodEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRetrievalMethodBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--RetrievalMethod(获取方式)
 /// 唯一性条件:RetrievalMethodName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRetrievalMethodEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRetrievalMethodEN objRetrievalMethodEN)
{
//检测记录是否存在
string strResult = RetrievalMethodDA.GetUniCondStr(objRetrievalMethodEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRetrievalMethodId)
{
if (strInFldName != conRetrievalMethod.RetrievalMethodId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRetrievalMethod._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRetrievalMethod._AttributeName));
throw new Exception(strMsg);
}
var objRetrievalMethod = clsRetrievalMethodBL.GetObjByRetrievalMethodIdCache(strRetrievalMethodId);
if (objRetrievalMethod == null) return "";
return objRetrievalMethod[strOutFldName].ToString();
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
int intRecCount = clsRetrievalMethodDA.GetRecCount(strTabName);
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
int intRecCount = clsRetrievalMethodDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRetrievalMethodDA.GetRecCount();
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
int intRecCount = clsRetrievalMethodDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRetrievalMethodCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRetrievalMethodEN objRetrievalMethodCond)
{
List<clsRetrievalMethodEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsRetrievalMethodEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRetrievalMethod._AttributeName)
{
if (objRetrievalMethodCond.IsUpdated(strFldName) == false) continue;
if (objRetrievalMethodCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRetrievalMethodCond[strFldName].ToString());
}
else
{
if (objRetrievalMethodCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRetrievalMethodCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRetrievalMethodCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRetrievalMethodCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRetrievalMethodCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRetrievalMethodCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRetrievalMethodCond[strFldName]));
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
 List<string> arrList = clsRetrievalMethodDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RetrievalMethodDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RetrievalMethodDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RetrievalMethodDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRetrievalMethodDA.SetFldValue(clsRetrievalMethodEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RetrievalMethodDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRetrievalMethodDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRetrievalMethodDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRetrievalMethodDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RetrievalMethod] "); 
 strCreateTabCode.Append(" ( "); 
 // /**获取方式Id*/ 
 strCreateTabCode.Append(" RetrievalMethodId char(2) primary key, "); 
 // /**获取方式名*/ 
 strCreateTabCode.Append(" RetrievalMethodName varchar(50) not Null, "); 
 // /**获取方式英文名*/ 
 strCreateTabCode.Append(" RetrievalMethodEnName varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 获取方式(RetrievalMethod)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RetrievalMethod : clsCommFun4BL
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
clsRetrievalMethodBL.ReFreshThisCache();
}
}

}