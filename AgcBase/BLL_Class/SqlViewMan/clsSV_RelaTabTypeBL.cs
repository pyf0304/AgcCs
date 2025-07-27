
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSV_RelaTabTypeBL
 表名:SV_RelaTabType(00050248)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:16:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class clsSV_RelaTabTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSV_RelaTabTypeEN GetObj(this K_SvRelaTabTypeId_SV_RelaTabType myKey)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.GetObjBySvRelaTabTypeId(myKey.Value);
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (CheckUniqueness_SV_RelaTabTypeName(objSV_RelaTabTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图相关表类型名 = [{0}]的数据已经存在!(in clsSV_RelaTabTypeBL.AddNewRecord)", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.AddNewRecordBySQL2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSV_RelaTabTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objSV_RelaTabTypeEN. CheckUniqueness_SV_RelaTabTypeName() == false)
{
strMsg = string.Format("(Sql视图相关表类型名(SvRelaTabTypeName)=[{0}])已经存在，不能重复!", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSV_RelaTabTypeEN.AddNewRecord();
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (CheckUniqueness_SV_RelaTabTypeName(objSV_RelaTabTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图相关表类型名 = [{0}]的数据已经存在!(in clsSV_RelaTabTypeBL.AddNewRecordWithMaxId)", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
string strSvRelaTabTypeId = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.AddNewRecordBySQL2WithReturnKey(objSV_RelaTabTypeEN);
     objSV_RelaTabTypeEN.SvRelaTabTypeId = strSvRelaTabTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
}
return strSvRelaTabTypeId;
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (CheckUniqueness_SV_RelaTabTypeName(objSV_RelaTabTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图相关表类型名 = [{0}]的数据已经存在!(in clsSV_RelaTabTypeBL.AddNewRecordWithReturnKey)", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
string strKey = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.AddNewRecordBySQL2WithReturnKey(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetSvRelaTabTypeId(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
}
objSV_RelaTabTypeEN.SvRelaTabTypeId = strSvRelaTabTypeId; //Sql视图相关表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.SvRelaTabTypeId) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.SvRelaTabTypeId, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeId] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetSvRelaTabTypeName(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strSvRelaTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeName, 30, conSV_RelaTabType.SvRelaTabTypeName);
}
objSV_RelaTabTypeEN.SvRelaTabTypeName = strSvRelaTabTypeName; //Sql视图相关表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.SvRelaTabTypeName) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.SvRelaTabTypeName, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeName] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetMemo(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSV_RelaTabType.Memo);
}
objSV_RelaTabTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.Memo) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.Memo, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.Memo] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSV_RelaTabTypeEN.CheckPropertyNew();
clsSV_RelaTabTypeEN objSV_RelaTabTypeCond = new clsSV_RelaTabTypeEN();
string strCondition = objSV_RelaTabTypeCond
.SetSvRelaTabTypeId(objSV_RelaTabTypeEN.SvRelaTabTypeId, "<>")
.SetSvRelaTabTypeName(objSV_RelaTabTypeEN.SvRelaTabTypeName, "=")
.GetCombineCondition();
objSV_RelaTabTypeEN._IsCheckProperty = true;
bool bolIsExist = clsSV_RelaTabTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SV_RelaTabTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSV_RelaTabTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objSV_RelaTabType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSV_RelaTabTypeEN objSV_RelaTabType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSV_RelaTabTypeEN objSV_RelaTabTypeCond = new clsSV_RelaTabTypeEN();
string strCondition = objSV_RelaTabTypeCond
.SetSvRelaTabTypeName(objSV_RelaTabType.SvRelaTabTypeName, "=")
.GetCombineCondition();
objSV_RelaTabType._IsCheckProperty = true;
bool bolIsExist = clsSV_RelaTabTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSV_RelaTabType.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetFirstID_S(strCondition);
objSV_RelaTabType.UpdateWithCondition(strCondition);
}
else
{
objSV_RelaTabType.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
objSV_RelaTabType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.UpdateBySql2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.UpdateBySql2(objSV_RelaTabTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.UpdateBySqlWithCondition(objSV_RelaTabTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.UpdateBySqlWithConditionTransaction(objSV_RelaTabTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
int intRecNum = clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.DelRecord(objSV_RelaTabTypeEN.SvRelaTabTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeENS">源对象</param>
 /// <param name = "objSV_RelaTabTypeENT">目标对象</param>
 public static void CopyTo(this clsSV_RelaTabTypeEN objSV_RelaTabTypeENS, clsSV_RelaTabTypeEN objSV_RelaTabTypeENT)
{
try
{
objSV_RelaTabTypeENT.SvRelaTabTypeId = objSV_RelaTabTypeENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSV_RelaTabTypeENT.SvRelaTabTypeName = objSV_RelaTabTypeENS.SvRelaTabTypeName; //Sql视图相关表类型名
objSV_RelaTabTypeENT.Memo = objSV_RelaTabTypeENS.Memo; //说明
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
 /// <param name = "objSV_RelaTabTypeENS">源对象</param>
 /// <returns>目标对象=>clsSV_RelaTabTypeEN:objSV_RelaTabTypeENT</returns>
 public static clsSV_RelaTabTypeEN CopyTo(this clsSV_RelaTabTypeEN objSV_RelaTabTypeENS)
{
try
{
 clsSV_RelaTabTypeEN objSV_RelaTabTypeENT = new clsSV_RelaTabTypeEN()
{
SvRelaTabTypeId = objSV_RelaTabTypeENS.SvRelaTabTypeId, //Sql视图相关表类型Id
SvRelaTabTypeName = objSV_RelaTabTypeENS.SvRelaTabTypeName, //Sql视图相关表类型名
Memo = objSV_RelaTabTypeENS.Memo, //说明
};
 return objSV_RelaTabTypeENT;
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
public static void CheckPropertyNew(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.CheckPropertyNew(objSV_RelaTabTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 clsSV_RelaTabTypeBL.SV_RelaTabTypeDA.CheckProperty4Condition(objSV_RelaTabTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSV_RelaTabTypeEN objSV_RelaTabTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSV_RelaTabTypeCond.IsUpdated(conSV_RelaTabType.SvRelaTabTypeId) == true)
{
string strComparisonOpSvRelaTabTypeId = objSV_RelaTabTypeCond.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.SvRelaTabTypeId, objSV_RelaTabTypeCond.SvRelaTabTypeId, strComparisonOpSvRelaTabTypeId);
}
if (objSV_RelaTabTypeCond.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName) == true)
{
string strComparisonOpSvRelaTabTypeName = objSV_RelaTabTypeCond.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.SvRelaTabTypeName, objSV_RelaTabTypeCond.SvRelaTabTypeName, strComparisonOpSvRelaTabTypeName);
}
if (objSV_RelaTabTypeCond.IsUpdated(conSV_RelaTabType.Memo) == true)
{
string strComparisonOpMemo = objSV_RelaTabTypeCond.dicFldComparisonOp[conSV_RelaTabType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.Memo, objSV_RelaTabTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SV_RelaTabType(Sql视图相关表类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_SV_RelaTabTypeName(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSV_RelaTabTypeEN == null) return true;
if (objSV_RelaTabTypeEN.SvRelaTabTypeId == null || objSV_RelaTabTypeEN.SvRelaTabTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
if (clsSV_RelaTabTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SvRelaTabTypeId !=  '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeId);
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
if (clsSV_RelaTabTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--SV_RelaTabType(Sql视图相关表类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrSV_RelaTabTypeName(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSV_RelaTabTypeEN == null) return "";
if (objSV_RelaTabTypeEN.SvRelaTabTypeId == null || objSV_RelaTabTypeEN.SvRelaTabTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SvRelaTabTypeId !=  '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeId);
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SV_RelaTabType
{
public virtual bool UpdRelaTabDate(string strSvRelaTabTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Sql视图相关表类型(SV_RelaTabType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSV_RelaTabTypeBL
{
public static RelatedActions_SV_RelaTabType relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "SV_RelaTabTypeListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "SV_RelaTabTypeList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSV_RelaTabTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSV_RelaTabTypeDA SV_RelaTabTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSV_RelaTabTypeDA();
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
 public clsSV_RelaTabTypeBL()
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
if (string.IsNullOrEmpty(clsSV_RelaTabTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSV_RelaTabTypeEN._ConnectString);
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
objDS = SV_RelaTabTypeDA.GetDataSet(strWhereCond);
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
objDS = SV_RelaTabTypeDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = SV_RelaTabTypeDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_SV_RelaTabType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SV_RelaTabTypeDA.GetDataTable_SV_RelaTabType(strWhereCond);
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
objDT = SV_RelaTabTypeDA.GetDataTable(strWhereCond);
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
objDT = SV_RelaTabTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SV_RelaTabTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SV_RelaTabTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SV_RelaTabTypeDA.GetDataTable_Top(objTopPara);
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
objDT = SV_RelaTabTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SV_RelaTabTypeDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = SV_RelaTabTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SV_RelaTabTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = SV_RelaTabTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = SV_RelaTabTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = SV_RelaTabTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = SV_RelaTabTypeDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrSvRelaTabTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstBySvRelaTabTypeIdLst(List<string> arrSvRelaTabTypeIdLst)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSvRelaTabTypeIdLst, true);
 string strWhereCond = string.Format("SvRelaTabTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSvRelaTabTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSV_RelaTabTypeEN> GetObjLstBySvRelaTabTypeIdLstCache(List<string> arrSvRelaTabTypeIdLst)
{
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel =
arrSV_RelaTabTypeObjLstCache
.Where(x => arrSvRelaTabTypeIdLst.Contains(x.SvRelaTabTypeId));
return arrSV_RelaTabTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLst(string strWhereCond)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static List<clsSV_RelaTabTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSV_RelaTabTypeEN> GetSubObjLstCache(clsSV_RelaTabTypeEN objSV_RelaTabTypeCond)
{
List<clsSV_RelaTabTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSV_RelaTabTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSV_RelaTabType.AttributeName)
{
if (objSV_RelaTabTypeCond.IsUpdated(strFldName) == false) continue;
if (objSV_RelaTabTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else
{
if (objSV_RelaTabTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSV_RelaTabTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSV_RelaTabTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
List<clsSV_RelaTabTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSV_RelaTabTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSV_RelaTabTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
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
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static List<clsSV_RelaTabTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static IEnumerable<clsSV_RelaTabTypeEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsSV_RelaTabTypeEN objSV_RelaTabTypeCond, string strOrderBy)
{
List<clsSV_RelaTabTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSV_RelaTabTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSV_RelaTabType.AttributeName)
{
if (objSV_RelaTabTypeCond.IsUpdated(strFldName) == false) continue;
if (objSV_RelaTabTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else
{
if (objSV_RelaTabTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSV_RelaTabTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSV_RelaTabTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
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
public static IEnumerable<clsSV_RelaTabTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeCond = JsonConvert.DeserializeObject<clsSV_RelaTabTypeEN>(objPagerPara.whereCond);
if (objSV_RelaTabTypeCond.sfFldComparisonOp == null)
{
objSV_RelaTabTypeCond.dicFldComparisonOp = null;
}
else
{
objSV_RelaTabTypeCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objSV_RelaTabTypeCond.sfFldComparisonOp);
}
clsSV_RelaTabTypeBL.SetUpdFlag(objSV_RelaTabTypeCond);
 try
{
CheckProperty4Condition(objSV_RelaTabTypeCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsSV_RelaTabTypeBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objSV_RelaTabTypeCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSV_RelaTabTypeEN> arrObjLst = new List<clsSV_RelaTabTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
try
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objRow[conSV_RelaTabType.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSV_RelaTabTypeEN.SvRelaTabTypeName = objRow[conSV_RelaTabType.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objSV_RelaTabTypeEN.Memo = objRow[conSV_RelaTabType.Memo] == DBNull.Value ? null : objRow[conSV_RelaTabType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSV_RelaTabTypeEN.SvRelaTabTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSV_RelaTabTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSV_RelaTabType(ref clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
bool bolResult = SV_RelaTabTypeDA.GetSV_RelaTabType(ref objSV_RelaTabTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeId(string strSvRelaTabTypeId)
{
if (strSvRelaTabTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSvRelaTabTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSvRelaTabTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = SV_RelaTabTypeDA.GetObjBySvRelaTabTypeId(strSvRelaTabTypeId);
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSV_RelaTabTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = SV_RelaTabTypeDA.GetFirstObj(strWhereCond);
 return objSV_RelaTabTypeEN;
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
public static clsSV_RelaTabTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = SV_RelaTabTypeDA.GetObjByDataRow(objRow);
 return objSV_RelaTabTypeEN;
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
public static clsSV_RelaTabTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = SV_RelaTabTypeDA.GetObjByDataRow(objRow);
 return objSV_RelaTabTypeEN;
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
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <param name = "lstSV_RelaTabTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeIdFromList(string strSvRelaTabTypeId, List<clsSV_RelaTabTypeEN> lstSV_RelaTabTypeObjLst)
{
foreach (clsSV_RelaTabTypeEN objSV_RelaTabTypeEN in lstSV_RelaTabTypeObjLst)
{
if (objSV_RelaTabTypeEN.SvRelaTabTypeId == strSvRelaTabTypeId)
{
return objSV_RelaTabTypeEN;
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
 string strMaxSvRelaTabTypeId;
 try
 {
 strMaxSvRelaTabTypeId = clsSV_RelaTabTypeDA.GetMaxStrId();
 return strMaxSvRelaTabTypeId;
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
 string strSvRelaTabTypeId;
 try
 {
 strSvRelaTabTypeId = new clsSV_RelaTabTypeDA().GetFirstID(strWhereCond);
 return strSvRelaTabTypeId;
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
 arrList = SV_RelaTabTypeDA.GetID(strWhereCond);
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
bool bolIsExist = SV_RelaTabTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSvRelaTabTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SV_RelaTabTypeDA.IsExist(strSvRelaTabTypeId);
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
 bolIsExist = clsSV_RelaTabTypeDA.IsExistTable();
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
 bolIsExist = SV_RelaTabTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (objSV_RelaTabTypeEN.CheckUniqueness_SV_RelaTabTypeName() == false)
{
var strMsg = string.Format("记录已经存在!Sql视图相关表类型名 = [{0}]的数据已经存在!(in clsSV_RelaTabTypeBL.AddNewRecordBySql2)", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
bool bolResult = SV_RelaTabTypeDA.AddNewRecordBySQL2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (objSV_RelaTabTypeEN.CheckUniqueness_SV_RelaTabTypeName() == false)
{
var strMsg = string.Format("记录已经存在!Sql视图相关表类型名 = [{0}]的数据已经存在!(in clsSV_RelaTabTypeBL.AddNewRecordBySql2WithReturnKey)", objSV_RelaTabTypeEN.SvRelaTabTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeBL.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeBL.GetMaxStrId_S();
 }
string strKey = SV_RelaTabTypeDA.AddNewRecordBySQL2WithReturnKey(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "strSV_RelaTabTypeObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strSV_RelaTabTypeObjXml)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = GetObjFromXmlStr(strSV_RelaTabTypeObjXml);
try
{
bool bolResult = SV_RelaTabTypeDA.AddNewRecordBySQL2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
bool bolResult = SV_RelaTabTypeDA.Update(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SV_RelaTabTypeDA.UpdateBySql2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "strSV_RelaTabTypeObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strSV_RelaTabTypeObjXml)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = GetObjFromXmlStr(strSV_RelaTabTypeObjXml);
try
{
bool bolResult = SV_RelaTabTypeDA.UpdateBySql2(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeBL.ReFreshCache();

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSvRelaTabTypeId)
{
try
{
 clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = clsSV_RelaTabTypeBL.GetObjBySvRelaTabTypeId(strSvRelaTabTypeId);

if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(objSV_RelaTabTypeEN.SvRelaTabTypeId, "SetUpdDate");
}
if (objSV_RelaTabTypeEN != null)
{
int intRecNum = SV_RelaTabTypeDA.DelRecord(strSvRelaTabTypeId);
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
/// <param name="strSvRelaTabTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSvRelaTabTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
//删除与表:[SV_RelaTabType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSV_RelaTabType.SvRelaTabTypeId,
//strSvRelaTabTypeId);
//        clsSV_RelaTabTypeBL.DelSV_RelaTabTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSV_RelaTabTypeBL.DelRecord(strSvRelaTabTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSV_RelaTabTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strSvRelaTabTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSvRelaTabTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(strSvRelaTabTypeId, "UpdRelaTabDate");
}
bool bolResult = SV_RelaTabTypeDA.DelRecord(strSvRelaTabTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strSvRelaTabTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strSvRelaTabTypeId) 
{
try
{
if (clsSV_RelaTabTypeBL.relatedActions != null)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(strSvRelaTabTypeId, "UpdRelaTabDate");
}
bool bolResult = SV_RelaTabTypeDA.DelRecordBySP(strSvRelaTabTypeId);
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
 /// <param name = "arrSvRelaTabTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSV_RelaTabTypes(List<string> arrSvRelaTabTypeIdLst)
{
if (arrSvRelaTabTypeIdLst.Count == 0) return 0;
try
{
if (clsSV_RelaTabTypeBL.relatedActions != null)
{
foreach (var strSvRelaTabTypeId in arrSvRelaTabTypeIdLst)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(strSvRelaTabTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = SV_RelaTabTypeDA.DelSV_RelaTabType(arrSvRelaTabTypeIdLst);
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
public static int DelSV_RelaTabTypesByCond(string strWhereCond)
{
try
{
if (clsSV_RelaTabTypeBL.relatedActions != null)
{
List<string> arrSvRelaTabTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSvRelaTabTypeId in arrSvRelaTabTypeId)
{
clsSV_RelaTabTypeBL.relatedActions.UpdRelaTabDate(strSvRelaTabTypeId, "UpdRelaTabDate");
}
}
int intRecNum = SV_RelaTabTypeDA.DelSV_RelaTabType(strWhereCond);
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
/// 这里仅仅是演示函数，使用时请复制到扩展类:[SV_RelaTabType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSvRelaTabTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSvRelaTabTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSV_RelaTabTypeDA.GetSpecSQLObj();
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
//删除与表:[SV_RelaTabType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSV_RelaTabTypeBL.DelRecord(strSvRelaTabTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSV_RelaTabTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strSvRelaTabTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSV_RelaTabTypeENS">源对象</param>
 /// <param name = "objSV_RelaTabTypeENT">目标对象</param>
 public static void CopyTo(clsSV_RelaTabTypeEN objSV_RelaTabTypeENS, clsSV_RelaTabTypeEN objSV_RelaTabTypeENT)
{
try
{
objSV_RelaTabTypeENT.SvRelaTabTypeId = objSV_RelaTabTypeENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSV_RelaTabTypeENT.SvRelaTabTypeName = objSV_RelaTabTypeENS.SvRelaTabTypeName; //Sql视图相关表类型名
objSV_RelaTabTypeENT.Memo = objSV_RelaTabTypeENS.Memo; //说明
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
 /// <param name = "objSV_RelaTabTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
objSV_RelaTabTypeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objSV_RelaTabTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSV_RelaTabType.SvRelaTabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = objSV_RelaTabTypeEN.SvRelaTabTypeId; //Sql视图相关表类型Id
}
if (arrFldSet.Contains(conSV_RelaTabType.SvRelaTabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSV_RelaTabTypeEN.SvRelaTabTypeName = objSV_RelaTabTypeEN.SvRelaTabTypeName; //Sql视图相关表类型名
}
if (arrFldSet.Contains(conSV_RelaTabType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSV_RelaTabTypeEN.Memo = objSV_RelaTabTypeEN.Memo == "[null]" ? null :  objSV_RelaTabTypeEN.Memo; //说明
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
 /// <param name = "objSV_RelaTabTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
if (objSV_RelaTabTypeEN.Memo == "[null]") objSV_RelaTabTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 SV_RelaTabTypeDA.CheckPropertyNew(objSV_RelaTabTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 SV_RelaTabTypeDA.CheckProperty4Condition(objSV_RelaTabTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_SvRelaTabTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSV_RelaTabType.SvRelaTabTypeId); 
List<clsSV_RelaTabTypeEN> arrObjLst = clsSV_RelaTabTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN()
{
SvRelaTabTypeId = "0",
SvRelaTabTypeName = "选[Sql视图相关表类型]..."
};
arrObjLst.Insert(0, objSV_RelaTabTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSV_RelaTabType.SvRelaTabTypeId;
objComboBox.DisplayMember = conSV_RelaTabType.SvRelaTabTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlSvRelaTabTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[Sql视图相关表类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSV_RelaTabType.SvRelaTabTypeId); 
IEnumerable<clsSV_RelaTabTypeEN> arrObjLst = clsSV_RelaTabTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conSV_RelaTabType.SvRelaTabTypeId;
objDDL.DataTextField = conSV_RelaTabType.SvRelaTabTypeName;
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
public static void BindDdlSvRelaTabTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[Sql视图相关表类型]...","0");
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst = GetAllSV_RelaTabTypeObjLstCache(); 
objDDL.DataValueField = conSV_RelaTabType.SvRelaTabTypeId;
objDDL.DataTextField = conSV_RelaTabType.SvRelaTabTypeName;
objDDL.DataSource = arrSV_RelaTabTypeObjLst;
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
if (clsSV_RelaTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSV_RelaTabTypeBL没有刷新缓存机制(clsSV_RelaTabTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SvRelaTabTypeId");
//if (arrSV_RelaTabTypeObjLstCache == null)
//{
//arrSV_RelaTabTypeObjLstCache = SV_RelaTabTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeIdCache(string strSvRelaTabTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel =
arrSV_RelaTabTypeObjLstCache
.Where(x=> x.SvRelaTabTypeId == strSvRelaTabTypeId 
);
if (arrSV_RelaTabTypeObjLst_Sel.Count() == 0)
{
   clsSV_RelaTabTypeEN obj = clsSV_RelaTabTypeBL.GetObjBySvRelaTabTypeId(strSvRelaTabTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSV_RelaTabTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSvRelaTabTypeNameBySvRelaTabTypeIdCache(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return "";
//获取缓存中的对象列表
clsSV_RelaTabTypeEN objSV_RelaTabType = GetObjBySvRelaTabTypeIdCache(strSvRelaTabTypeId);
if (objSV_RelaTabType == null) return "";
return objSV_RelaTabType.SvRelaTabTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySvRelaTabTypeIdCache(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return "";
//获取缓存中的对象列表
clsSV_RelaTabTypeEN objSV_RelaTabType = GetObjBySvRelaTabTypeIdCache(strSvRelaTabTypeId);
if (objSV_RelaTabType == null) return "";
return objSV_RelaTabType.SvRelaTabTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetAllSV_RelaTabTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLstCache = GetObjLstCache(); 
return arrSV_RelaTabTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSV_RelaTabTypeObjLstCache;
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
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
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
if (clsSV_RelaTabTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSV_RelaTabTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SV_RelaTabType(Sql视图相关表类型)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrSV_RelaTabTypeName(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检测记录是否存在
string strResult = SV_RelaTabTypeDA.GetUniCondStrSV_RelaTabTypeName(objSV_RelaTabTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstSV_RelaTabTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsSV_RelaTabTypeEN> lstSV_RelaTabTypeObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstSV_RelaTabTypeObjLst, writer);
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
 /// <param name = "lstSV_RelaTabTypeObjLst">[clsSV_RelaTabTypeEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsSV_RelaTabTypeEN> lstSV_RelaTabTypeObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsSV_RelaTabTypeBL.listXmlNode);
writer.WriteStartElement(clsSV_RelaTabTypeBL.itemsXmlNode);
foreach (clsSV_RelaTabTypeEN objSV_RelaTabTypeEN in lstSV_RelaTabTypeObjLst)
{
clsSV_RelaTabTypeBL.SerializeXML(writer, objSV_RelaTabTypeEN);
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
 /// <param name = "objSV_RelaTabTypeEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
writer.WriteStartElement(clsSV_RelaTabTypeBL.itemXmlNode);
 
if (objSV_RelaTabTypeEN.SvRelaTabTypeId != null)
{
writer.WriteElementString(conSV_RelaTabType.SvRelaTabTypeId, objSV_RelaTabTypeEN.SvRelaTabTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objSV_RelaTabTypeEN.SvRelaTabTypeName != null)
{
writer.WriteElementString(conSV_RelaTabType.SvRelaTabTypeName, objSV_RelaTabTypeEN.SvRelaTabTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objSV_RelaTabTypeEN.Memo != null)
{
writer.WriteElementString(conSV_RelaTabType.Memo, objSV_RelaTabTypeEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsSV_RelaTabTypeEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
reader.Read();
while (!(reader.Name == clsSV_RelaTabTypeBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conSV_RelaTabType.SvRelaTabTypeId))
{
objSV_RelaTabTypeEN.SvRelaTabTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conSV_RelaTabType.SvRelaTabTypeName))
{
objSV_RelaTabTypeEN.SvRelaTabTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conSV_RelaTabType.Memo))
{
objSV_RelaTabTypeEN.Memo = reader.ReadElementContentAsString();
}
}
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strSV_RelaTabTypeObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsSV_RelaTabTypeEN GetObjFromXmlStr(string strSV_RelaTabTypeObjXmlStr)
{
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strSV_RelaTabTypeObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsSV_RelaTabTypeBL.itemXmlNode))
{
objSV_RelaTabTypeEN = GetObjFromXml(reader);
return objSV_RelaTabTypeEN;
}
}
return objSV_RelaTabTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objSV_RelaTabTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSvRelaTabTypeId)
{
if (strInFldName != conSV_RelaTabType.SvRelaTabTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSV_RelaTabType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSV_RelaTabType.AttributeName));
throw new Exception(strMsg);
}
var objSV_RelaTabType = clsSV_RelaTabTypeBL.GetObjBySvRelaTabTypeIdCache(strSvRelaTabTypeId);
if (objSV_RelaTabType == null) return "";
return objSV_RelaTabType[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsSV_RelaTabTypeEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objSV_RelaTabTypeEN[strField]);
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
 /// <param name = "lstSV_RelaTabTypeObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsSV_RelaTabTypeEN> lstSV_RelaTabTypeObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstSV_RelaTabTypeObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsSV_RelaTabTypeEN objSV_RelaTabTypeEN in lstSV_RelaTabTypeObjLst)
{
string strJSON_One = SerializeObjToJSON(objSV_RelaTabTypeEN);
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
int intRecCount = clsSV_RelaTabTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsSV_RelaTabTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSV_RelaTabTypeDA.GetRecCount();
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
int intRecCount = clsSV_RelaTabTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSV_RelaTabTypeEN objSV_RelaTabTypeCond)
{
List<clsSV_RelaTabTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSV_RelaTabTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSV_RelaTabType.AttributeName)
{
if (objSV_RelaTabTypeCond.IsUpdated(strFldName) == false) continue;
if (objSV_RelaTabTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else
{
if (objSV_RelaTabTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSV_RelaTabTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSV_RelaTabTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSV_RelaTabTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSV_RelaTabTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSV_RelaTabTypeCond[strFldName]));
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
 List<string> arrList = clsSV_RelaTabTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SV_RelaTabTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SV_RelaTabTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SV_RelaTabTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSV_RelaTabTypeDA.SetFldValue(clsSV_RelaTabTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SV_RelaTabTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSV_RelaTabTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSV_RelaTabTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSV_RelaTabTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SV_RelaTabType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Sql视图相关表类型Id*/ 
 strCreateTabCode.Append(" SvRelaTabTypeId char(2) primary key, "); 
 // /**Sql视图相关表类型名*/ 
 strCreateTabCode.Append(" SvRelaTabTypeName varchar(30) not Null, "); 
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
 /// Sql视图相关表类型(SV_RelaTabType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4SV_RelaTabType : clsCommFun4BL
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
clsSV_RelaTabTypeBL.ReFreshThisCache();
}
}

}