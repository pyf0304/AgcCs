
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysDefaValNameBL
 表名:SysDefaValName(00050085)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsSysDefaValNameBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDefaValNameId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysDefaValNameEN GetObj(this K_DefaValNameId_SysDefaValName myKey)
{
clsSysDefaValNameEN objSysDefaValNameEN = clsSysDefaValNameBL.SysDefaValNameDA.GetObjByDefaValNameId(myKey.Value);
return objSysDefaValNameEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysDefaValNameEN.DefaValNameId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysDefaValNameEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],DefaValName = [{1}]的数据已经存在!(in clsSysDefaValNameBL.AddNewRecord)", objSysDefaValNameEN.PrjId,objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSysDefaValNameBL.SysDefaValNameDA.AddNewRecordBySQL2(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSysDefaValNameEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysDefaValNameEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],DefaValName(DefaValName)=[{1}])已经存在,不能重复!", objSysDefaValNameEN.PrjId, objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSysDefaValNameEN.AddNewRecord();
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysDefaValNameEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],DefaValName = [{1}]的数据已经存在!(in clsSysDefaValNameBL.AddNewRecordWithMaxId)", objSysDefaValNameEN.PrjId,objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true || clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId) == true)
 {
     objSysDefaValNameEN.DefaValNameId = clsSysDefaValNameBL.GetMaxStrIdByPrefix_S(objSysDefaValNameEN.PrjId);
 }
string strDefaValNameId = clsSysDefaValNameBL.SysDefaValNameDA.AddNewRecordBySQL2WithReturnKey(objSysDefaValNameEN);
     objSysDefaValNameEN.DefaValNameId = strDefaValNameId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
}
return strDefaValNameId;
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysDefaValNameEN.DefaValNameId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysDefaValNameEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],DefaValName = [{1}]的数据已经存在!(in clsSysDefaValNameBL.AddNewRecordWithReturnKey)", objSysDefaValNameEN.PrjId,objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
try
{
string strKey = clsSysDefaValNameBL.SysDefaValNameDA.AddNewRecordBySQL2WithReturnKey(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysDefaValNameEN SetDefaValNameId(this clsSysDefaValNameEN objSysDefaValNameEN, string strDefaValNameId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaValNameId, 8, conSysDefaValName.DefaValNameId);
}
objSysDefaValNameEN.DefaValNameId = strDefaValNameId; //DefaValNameId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysDefaValNameEN.dicFldComparisonOp.ContainsKey(conSysDefaValName.DefaValNameId) == false)
{
objSysDefaValNameEN.dicFldComparisonOp.Add(conSysDefaValName.DefaValNameId, strComparisonOp);
}
else
{
objSysDefaValNameEN.dicFldComparisonOp[conSysDefaValName.DefaValNameId] = strComparisonOp;
}
}
return objSysDefaValNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysDefaValNameEN SetPrjId(this clsSysDefaValNameEN objSysDefaValNameEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSysDefaValName.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSysDefaValName.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSysDefaValName.PrjId);
}
objSysDefaValNameEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysDefaValNameEN.dicFldComparisonOp.ContainsKey(conSysDefaValName.PrjId) == false)
{
objSysDefaValNameEN.dicFldComparisonOp.Add(conSysDefaValName.PrjId, strComparisonOp);
}
else
{
objSysDefaValNameEN.dicFldComparisonOp[conSysDefaValName.PrjId] = strComparisonOp;
}
}
return objSysDefaValNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysDefaValNameEN SetDefaValName(this clsSysDefaValNameEN objSysDefaValNameEN, string strDefaValName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaValName, conSysDefaValName.DefaValName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaValName, 40, conSysDefaValName.DefaValName);
}
objSysDefaValNameEN.DefaValName = strDefaValName; //DefaValName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysDefaValNameEN.dicFldComparisonOp.ContainsKey(conSysDefaValName.DefaValName) == false)
{
objSysDefaValNameEN.dicFldComparisonOp.Add(conSysDefaValName.DefaValName, strComparisonOp);
}
else
{
objSysDefaValNameEN.dicFldComparisonOp[conSysDefaValName.DefaValName] = strComparisonOp;
}
}
return objSysDefaValNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysDefaValNameEN SetSysDefaValue(this clsSysDefaValNameEN objSysDefaValNameEN, string strSysDefaValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSysDefaValue, conSysDefaValName.SysDefaValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSysDefaValue, 100, conSysDefaValName.SysDefaValue);
}
objSysDefaValNameEN.SysDefaValue = strSysDefaValue; //SysDefaValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysDefaValNameEN.dicFldComparisonOp.ContainsKey(conSysDefaValName.SysDefaValue) == false)
{
objSysDefaValNameEN.dicFldComparisonOp.Add(conSysDefaValName.SysDefaValue, strComparisonOp);
}
else
{
objSysDefaValNameEN.dicFldComparisonOp[conSysDefaValName.SysDefaValue] = strComparisonOp;
}
}
return objSysDefaValNameEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysDefaValNameEN objSysDefaValNameEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysDefaValNameEN.CheckPropertyNew();
clsSysDefaValNameEN objSysDefaValNameCond = new clsSysDefaValNameEN();
string strCondition = objSysDefaValNameCond
.SetDefaValNameId(objSysDefaValNameEN.DefaValNameId, "<>")
.SetPrjId(objSysDefaValNameEN.PrjId, "=")
.SetDefaValName(objSysDefaValNameEN.DefaValName, "=")
.GetCombineCondition();
objSysDefaValNameEN._IsCheckProperty = true;
bool bolIsExist = clsSysDefaValNameBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_DefaValName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysDefaValNameEN.Update();
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
 /// <param name = "objSysDefaValName">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysDefaValNameEN objSysDefaValName)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysDefaValNameEN objSysDefaValNameCond = new clsSysDefaValNameEN();
string strCondition = objSysDefaValNameCond
.SetPrjId(objSysDefaValName.PrjId, "=")
.SetDefaValName(objSysDefaValName.DefaValName, "=")
.GetCombineCondition();
objSysDefaValName._IsCheckProperty = true;
bool bolIsExist = clsSysDefaValNameBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysDefaValName.DefaValNameId = clsSysDefaValNameBL.GetFirstID_S(strCondition);
objSysDefaValName.UpdateWithCondition(strCondition);
}
else
{
objSysDefaValName.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysDefaValNameEN objSysDefaValNameEN)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysDefaValNameBL.SysDefaValNameDA.UpdateBySql2(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysDefaValNameEN objSysDefaValNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysDefaValNameBL.SysDefaValNameDA.UpdateBySql2(objSysDefaValNameEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysDefaValNameEN objSysDefaValNameEN, string strWhereCond)
{
try
{
bool bolResult = clsSysDefaValNameBL.SysDefaValNameDA.UpdateBySqlWithCondition(objSysDefaValNameEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysDefaValNameEN objSysDefaValNameEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysDefaValNameBL.SysDefaValNameDA.UpdateBySqlWithConditionTransaction(objSysDefaValNameEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "strDefaValNameId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysDefaValNameEN objSysDefaValNameEN)
{
try
{
int intRecNum = clsSysDefaValNameBL.SysDefaValNameDA.DelRecord(objSysDefaValNameEN.DefaValNameId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameENS">源对象</param>
 /// <param name = "objSysDefaValNameENT">目标对象</param>
 public static void CopyTo(this clsSysDefaValNameEN objSysDefaValNameENS, clsSysDefaValNameEN objSysDefaValNameENT)
{
try
{
objSysDefaValNameENT.DefaValNameId = objSysDefaValNameENS.DefaValNameId; //DefaValNameId
objSysDefaValNameENT.PrjId = objSysDefaValNameENS.PrjId; //工程Id
objSysDefaValNameENT.DefaValName = objSysDefaValNameENS.DefaValName; //DefaValName
objSysDefaValNameENT.SysDefaValue = objSysDefaValNameENS.SysDefaValue; //SysDefaValue
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
 /// <param name = "objSysDefaValNameENS">源对象</param>
 /// <returns>目标对象=>clsSysDefaValNameEN:objSysDefaValNameENT</returns>
 public static clsSysDefaValNameEN CopyTo(this clsSysDefaValNameEN objSysDefaValNameENS)
{
try
{
 clsSysDefaValNameEN objSysDefaValNameENT = new clsSysDefaValNameEN()
{
DefaValNameId = objSysDefaValNameENS.DefaValNameId, //DefaValNameId
PrjId = objSysDefaValNameENS.PrjId, //工程Id
DefaValName = objSysDefaValNameENS.DefaValName, //DefaValName
SysDefaValue = objSysDefaValNameENS.SysDefaValue, //SysDefaValue
};
 return objSysDefaValNameENT;
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
public static void CheckPropertyNew(this clsSysDefaValNameEN objSysDefaValNameEN)
{
 clsSysDefaValNameBL.SysDefaValNameDA.CheckPropertyNew(objSysDefaValNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysDefaValNameEN objSysDefaValNameEN)
{
 clsSysDefaValNameBL.SysDefaValNameDA.CheckProperty4Condition(objSysDefaValNameEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysDefaValNameEN objSysDefaValNameCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysDefaValNameCond.IsUpdated(conSysDefaValName.DefaValNameId) == true)
{
string strComparisonOpDefaValNameId = objSysDefaValNameCond.dicFldComparisonOp[conSysDefaValName.DefaValNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysDefaValName.DefaValNameId, objSysDefaValNameCond.DefaValNameId, strComparisonOpDefaValNameId);
}
if (objSysDefaValNameCond.IsUpdated(conSysDefaValName.PrjId) == true)
{
string strComparisonOpPrjId = objSysDefaValNameCond.dicFldComparisonOp[conSysDefaValName.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysDefaValName.PrjId, objSysDefaValNameCond.PrjId, strComparisonOpPrjId);
}
if (objSysDefaValNameCond.IsUpdated(conSysDefaValName.DefaValName) == true)
{
string strComparisonOpDefaValName = objSysDefaValNameCond.dicFldComparisonOp[conSysDefaValName.DefaValName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysDefaValName.DefaValName, objSysDefaValNameCond.DefaValName, strComparisonOpDefaValName);
}
if (objSysDefaValNameCond.IsUpdated(conSysDefaValName.SysDefaValue) == true)
{
string strComparisonOpSysDefaValue = objSysDefaValNameCond.dicFldComparisonOp[conSysDefaValName.SysDefaValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysDefaValName.SysDefaValue, objSysDefaValNameCond.SysDefaValue, strComparisonOpSysDefaValue);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysDefaValName(SysDefaValName), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_DefaValName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysDefaValNameEN objSysDefaValNameEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysDefaValNameEN == null) return true;
if (objSysDefaValNameEN.DefaValNameId == null || objSysDefaValNameEN.DefaValNameId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysDefaValNameEN.PrjId);
 sbCondition.AppendFormat(" and DefaValName = '{0}'", objSysDefaValNameEN.DefaValName);
if (clsSysDefaValNameBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DefaValNameId !=  '{0}'", objSysDefaValNameEN.DefaValNameId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysDefaValNameEN.PrjId);
 sbCondition.AppendFormat(" and DefaValName = '{0}'", objSysDefaValNameEN.DefaValName);
if (clsSysDefaValNameBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysDefaValName(SysDefaValName), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_DefaValName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysDefaValNameEN objSysDefaValNameEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysDefaValNameEN == null) return "";
if (objSysDefaValNameEN.DefaValNameId == null || objSysDefaValNameEN.DefaValNameId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysDefaValNameEN.PrjId);
 sbCondition.AppendFormat(" and DefaValName = '{0}'", objSysDefaValNameEN.DefaValName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DefaValNameId !=  '{0}'", objSysDefaValNameEN.DefaValNameId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysDefaValNameEN.PrjId);
 sbCondition.AppendFormat(" and DefaValName = '{0}'", objSysDefaValNameEN.DefaValName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysDefaValName
{
public virtual bool UpdRelaTabDate(string strDefaValNameId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysDefaValNameBL
{
public static RelatedActions_SysDefaValName relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysDefaValNameDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysDefaValNameDA SysDefaValNameDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysDefaValNameDA();
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
 public clsSysDefaValNameBL()
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
if (string.IsNullOrEmpty(clsSysDefaValNameEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysDefaValNameEN._ConnectString);
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
public static DataTable GetDataTable_SysDefaValName(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysDefaValNameDA.GetDataTable_SysDefaValName(strWhereCond);
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
objDT = SysDefaValNameDA.GetDataTable(strWhereCond);
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
objDT = SysDefaValNameDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysDefaValNameDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysDefaValNameDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysDefaValNameDA.GetDataTable_Top(objTopPara);
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
objDT = SysDefaValNameDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysDefaValNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysDefaValNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDefaValNameIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysDefaValNameEN> GetObjLstByDefaValNameIdLst(List<string> arrDefaValNameIdLst)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDefaValNameIdLst, true);
 string strWhereCond = string.Format("DefaValNameId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDefaValNameIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysDefaValNameEN> GetObjLstByDefaValNameIdLstCache(List<string> arrDefaValNameIdLst)
{
string strKey = string.Format("{0}", clsSysDefaValNameEN._CurrTabName);
List<clsSysDefaValNameEN> arrSysDefaValNameObjLstCache = GetObjLstCache();
IEnumerable <clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel =
arrSysDefaValNameObjLstCache
.Where(x => arrDefaValNameIdLst.Contains(x.DefaValNameId));
return arrSysDefaValNameObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysDefaValNameEN> GetObjLst(string strWhereCond)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
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
public static List<clsSysDefaValNameEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysDefaValNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysDefaValNameEN> GetSubObjLstCache(clsSysDefaValNameEN objSysDefaValNameCond)
{
List<clsSysDefaValNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysDefaValNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysDefaValName._AttributeName)
{
if (objSysDefaValNameCond.IsUpdated(strFldName) == false) continue;
if (objSysDefaValNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysDefaValNameCond[strFldName].ToString());
}
else
{
if (objSysDefaValNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysDefaValNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysDefaValNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysDefaValNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysDefaValNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysDefaValNameCond[strFldName]));
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
public static List<clsSysDefaValNameEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
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
public static List<clsSysDefaValNameEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
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
List<clsSysDefaValNameEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysDefaValNameEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysDefaValNameEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysDefaValNameEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
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
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
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
public static List<clsSysDefaValNameEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysDefaValNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysDefaValNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
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
public static List<clsSysDefaValNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysDefaValNameEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysDefaValNameEN> arrObjLst = new List<clsSysDefaValNameEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysDefaValNameEN objSysDefaValNameEN = new clsSysDefaValNameEN();
try
{
objSysDefaValNameEN.DefaValNameId = objRow[conSysDefaValName.DefaValNameId].ToString().Trim(); //DefaValNameId
objSysDefaValNameEN.PrjId = objRow[conSysDefaValName.PrjId].ToString().Trim(); //工程Id
objSysDefaValNameEN.DefaValName = objRow[conSysDefaValName.DefaValName].ToString().Trim(); //DefaValName
objSysDefaValNameEN.SysDefaValue = objRow[conSysDefaValName.SysDefaValue].ToString().Trim(); //SysDefaValue
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysDefaValNameEN.DefaValNameId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysDefaValNameEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysDefaValName(ref clsSysDefaValNameEN objSysDefaValNameEN)
{
bool bolResult = SysDefaValNameDA.GetSysDefaValName(ref objSysDefaValNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDefaValNameId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysDefaValNameEN GetObjByDefaValNameId(string strDefaValNameId)
{
if (strDefaValNameId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDefaValNameId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDefaValNameId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDefaValNameId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysDefaValNameEN objSysDefaValNameEN = SysDefaValNameDA.GetObjByDefaValNameId(strDefaValNameId);
return objSysDefaValNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysDefaValNameEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysDefaValNameEN objSysDefaValNameEN = SysDefaValNameDA.GetFirstObj(strWhereCond);
 return objSysDefaValNameEN;
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
public static clsSysDefaValNameEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysDefaValNameEN objSysDefaValNameEN = SysDefaValNameDA.GetObjByDataRow(objRow);
 return objSysDefaValNameEN;
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
public static clsSysDefaValNameEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysDefaValNameEN objSysDefaValNameEN = SysDefaValNameDA.GetObjByDataRow(objRow);
 return objSysDefaValNameEN;
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
 /// <param name = "strDefaValNameId">所给的关键字</param>
 /// <param name = "lstSysDefaValNameObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysDefaValNameEN GetObjByDefaValNameIdFromList(string strDefaValNameId, List<clsSysDefaValNameEN> lstSysDefaValNameObjLst)
{
foreach (clsSysDefaValNameEN objSysDefaValNameEN in lstSysDefaValNameObjLst)
{
if (objSysDefaValNameEN.DefaValNameId == strDefaValNameId)
{
return objSysDefaValNameEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxDefaValNameId;
 try
 {
 strMaxDefaValNameId = new clsSysDefaValNameDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxDefaValNameId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strDefaValNameId;
 try
 {
 strDefaValNameId = new clsSysDefaValNameDA().GetFirstID(strWhereCond);
 return strDefaValNameId;
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
 arrList = SysDefaValNameDA.GetID(strWhereCond);
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
bool bolIsExist = SysDefaValNameDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDefaValNameId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDefaValNameId)
{
if (string.IsNullOrEmpty(strDefaValNameId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDefaValNameId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysDefaValNameDA.IsExist(strDefaValNameId);
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
 bolIsExist = clsSysDefaValNameDA.IsExistTable();
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
 bolIsExist = SysDefaValNameDA.IsExistTable(strTabName);
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysDefaValNameEN.DefaValNameId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objSysDefaValNameEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],DefaValName = [{1}]的数据已经存在!(in clsSysDefaValNameBL.AddNewRecordBySql2)", objSysDefaValNameEN.PrjId,objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
try
{
bool bolResult = SysDefaValNameDA.AddNewRecordBySQL2(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysDefaValNameEN objSysDefaValNameEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysDefaValNameBL.IsExist(objSysDefaValNameEN.DefaValNameId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysDefaValNameEN.DefaValNameId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objSysDefaValNameEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],DefaValName = [{1}]的数据已经存在!(in clsSysDefaValNameBL.AddNewRecordBySql2WithReturnKey)", objSysDefaValNameEN.PrjId,objSysDefaValNameEN.DefaValName);
throw new Exception(strMsg);
}
try
{
string strKey = SysDefaValNameDA.AddNewRecordBySQL2WithReturnKey(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysDefaValNameEN objSysDefaValNameEN)
{
try
{
bool bolResult = SysDefaValNameDA.Update(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "objSysDefaValNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysDefaValNameEN objSysDefaValNameEN)
{
 if (string.IsNullOrEmpty(objSysDefaValNameEN.DefaValNameId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysDefaValNameDA.UpdateBySql2(objSysDefaValNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysDefaValNameBL.ReFreshCache();

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
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
 /// <param name = "strDefaValNameId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDefaValNameId)
{
try
{
 clsSysDefaValNameEN objSysDefaValNameEN = clsSysDefaValNameBL.GetObjByDefaValNameId(strDefaValNameId);

if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(objSysDefaValNameEN.DefaValNameId, "SetUpdDate");
}
if (objSysDefaValNameEN != null)
{
int intRecNum = SysDefaValNameDA.DelRecord(strDefaValNameId);
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
/// <param name="strDefaValNameId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDefaValNameId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysDefaValNameDA.GetSpecSQLObj();
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
//删除与表:[SysDefaValName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysDefaValName.DefaValNameId,
//strDefaValNameId);
//        clsSysDefaValNameBL.DelSysDefaValNamesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysDefaValNameBL.DelRecord(strDefaValNameId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysDefaValNameBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDefaValNameId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDefaValNameId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDefaValNameId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysDefaValNameBL.relatedActions != null)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(strDefaValNameId, "UpdRelaTabDate");
}
bool bolResult = SysDefaValNameDA.DelRecord(strDefaValNameId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDefaValNameIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysDefaValNames(List<string> arrDefaValNameIdLst)
{
if (arrDefaValNameIdLst.Count == 0) return 0;
try
{
if (clsSysDefaValNameBL.relatedActions != null)
{
foreach (var strDefaValNameId in arrDefaValNameIdLst)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(strDefaValNameId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysDefaValNameDA.DelSysDefaValName(arrDefaValNameIdLst);
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
public static int DelSysDefaValNamesByCond(string strWhereCond)
{
try
{
if (clsSysDefaValNameBL.relatedActions != null)
{
List<string> arrDefaValNameId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDefaValNameId in arrDefaValNameId)
{
clsSysDefaValNameBL.relatedActions.UpdRelaTabDate(strDefaValNameId, "UpdRelaTabDate");
}
}
int intRecNum = SysDefaValNameDA.DelSysDefaValName(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysDefaValName]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDefaValNameId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDefaValNameId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysDefaValNameDA.GetSpecSQLObj();
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
//删除与表:[SysDefaValName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysDefaValNameBL.DelRecord(strDefaValNameId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysDefaValNameBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDefaValNameId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysDefaValNameENS">源对象</param>
 /// <param name = "objSysDefaValNameENT">目标对象</param>
 public static void CopyTo(clsSysDefaValNameEN objSysDefaValNameENS, clsSysDefaValNameEN objSysDefaValNameENT)
{
try
{
objSysDefaValNameENT.DefaValNameId = objSysDefaValNameENS.DefaValNameId; //DefaValNameId
objSysDefaValNameENT.PrjId = objSysDefaValNameENS.PrjId; //工程Id
objSysDefaValNameENT.DefaValName = objSysDefaValNameENS.DefaValName; //DefaValName
objSysDefaValNameENT.SysDefaValue = objSysDefaValNameENS.SysDefaValue; //SysDefaValue
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
 /// <param name = "objSysDefaValNameEN">源简化对象</param>
 public static void SetUpdFlag(clsSysDefaValNameEN objSysDefaValNameEN)
{
try
{
objSysDefaValNameEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysDefaValNameEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysDefaValName.DefaValNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysDefaValNameEN.DefaValNameId = objSysDefaValNameEN.DefaValNameId; //DefaValNameId
}
if (arrFldSet.Contains(conSysDefaValName.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysDefaValNameEN.PrjId = objSysDefaValNameEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSysDefaValName.DefaValName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysDefaValNameEN.DefaValName = objSysDefaValNameEN.DefaValName; //DefaValName
}
if (arrFldSet.Contains(conSysDefaValName.SysDefaValue, new clsStrCompareIgnoreCase())  ==  true)
{
objSysDefaValNameEN.SysDefaValue = objSysDefaValNameEN.SysDefaValue; //SysDefaValue
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
 /// <param name = "objSysDefaValNameEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysDefaValNameEN objSysDefaValNameEN)
{
try
{
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
public static void CheckPropertyNew(clsSysDefaValNameEN objSysDefaValNameEN)
{
 SysDefaValNameDA.CheckPropertyNew(objSysDefaValNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysDefaValNameEN objSysDefaValNameEN)
{
 SysDefaValNameDA.CheckProperty4Condition(objSysDefaValNameEN);
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
if (clsSysDefaValNameBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysDefaValNameBL没有刷新缓存机制(clsSysDefaValNameBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DefaValNameId");
//if (arrSysDefaValNameObjLstCache == null)
//{
//arrSysDefaValNameObjLstCache = SysDefaValNameDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDefaValNameId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysDefaValNameEN GetObjByDefaValNameIdCache(string strDefaValNameId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysDefaValNameEN._CurrTabName);
List<clsSysDefaValNameEN> arrSysDefaValNameObjLstCache = GetObjLstCache();
IEnumerable <clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel =
arrSysDefaValNameObjLstCache
.Where(x=> x.DefaValNameId == strDefaValNameId 
);
if (arrSysDefaValNameObjLst_Sel.Count() == 0)
{
   clsSysDefaValNameEN obj = clsSysDefaValNameBL.GetObjByDefaValNameId(strDefaValNameId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysDefaValNameObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysDefaValNameEN> GetAllSysDefaValNameObjLstCache()
{
//获取缓存中的对象列表
List<clsSysDefaValNameEN> arrSysDefaValNameObjLstCache = GetObjLstCache(); 
return arrSysDefaValNameObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysDefaValNameEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysDefaValNameEN._CurrTabName);
List<clsSysDefaValNameEN> arrSysDefaValNameObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysDefaValNameObjLstCache;
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
string strKey = string.Format("{0}", clsSysDefaValNameEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysDefaValNameEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysDefaValNameEN._RefreshTimeLst.Count == 0) return "";
return clsSysDefaValNameEN._RefreshTimeLst[clsSysDefaValNameEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsSysDefaValNameBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysDefaValNameEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysDefaValNameEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysDefaValNameBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysDefaValName(SysDefaValName)
 /// 唯一性条件:PrjId_DefaValName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysDefaValNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysDefaValNameEN objSysDefaValNameEN)
{
//检测记录是否存在
string strResult = SysDefaValNameDA.GetUniCondStr(objSysDefaValNameEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDefaValNameId)
{
if (strInFldName != conSysDefaValName.DefaValNameId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysDefaValName._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysDefaValName._AttributeName));
throw new Exception(strMsg);
}
var objSysDefaValName = clsSysDefaValNameBL.GetObjByDefaValNameIdCache(strDefaValNameId);
if (objSysDefaValName == null) return "";
return objSysDefaValName[strOutFldName].ToString();
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
int intRecCount = clsSysDefaValNameDA.GetRecCount(strTabName);
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
int intRecCount = clsSysDefaValNameDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysDefaValNameDA.GetRecCount();
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
int intRecCount = clsSysDefaValNameDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysDefaValNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysDefaValNameEN objSysDefaValNameCond)
{
List<clsSysDefaValNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysDefaValNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysDefaValName._AttributeName)
{
if (objSysDefaValNameCond.IsUpdated(strFldName) == false) continue;
if (objSysDefaValNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysDefaValNameCond[strFldName].ToString());
}
else
{
if (objSysDefaValNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysDefaValNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysDefaValNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysDefaValNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysDefaValNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysDefaValNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysDefaValNameCond[strFldName]));
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
 List<string> arrList = clsSysDefaValNameDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysDefaValNameDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysDefaValNameDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysDefaValNameDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysDefaValNameDA.SetFldValue(clsSysDefaValNameEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysDefaValNameDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysDefaValNameDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysDefaValNameDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysDefaValNameDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysDefaValName] "); 
 strCreateTabCode.Append(" ( "); 
 // /**DefaValNameId*/ 
 strCreateTabCode.Append(" DefaValNameId varchar(8) primary key, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**DefaValName*/ 
 strCreateTabCode.Append(" DefaValName varchar(40) not Null, "); 
 // /**SysDefaValue*/ 
 strCreateTabCode.Append(" SysDefaValue varchar(100) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// SysDefaValName(SysDefaValName)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysDefaValName : clsCommFun4BL
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
clsSysDefaValNameBL.ReFreshThisCache();
}
}

}