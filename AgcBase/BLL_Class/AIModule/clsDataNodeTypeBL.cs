
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeTypeBL
 表名:DataNodeType(00050548)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsDataNodeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDataNodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeTypeEN GetObj(this K_DataNodeTypeId_DataNodeType myKey)
{
clsDataNodeTypeEN objDataNodeTypeEN = clsDataNodeTypeBL.DataNodeTypeDA.GetObjByDataNodeTypeId(myKey.Value);
return objDataNodeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据结点类型名 = [{0}]的数据已经存在!(in clsDataNodeTypeBL.AddNewRecord)", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsDataNodeTypeBL.DataNodeTypeDA.AddNewRecordBySQL2(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDataNodeTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDataNodeTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(数据结点类型名(DataNodeTypeName)=[{0}])已经存在,不能重复!", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDataNodeTypeEN.AddNewRecord();
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据结点类型名 = [{0}]的数据已经存在!(in clsDataNodeTypeBL.AddNewRecordWithMaxId)", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
string strDataNodeTypeId = clsDataNodeTypeBL.DataNodeTypeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeTypeEN);
     objDataNodeTypeEN.DataNodeTypeId = strDataNodeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
}
return strDataNodeTypeId;
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDataNodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据结点类型名 = [{0}]的数据已经存在!(in clsDataNodeTypeBL.AddNewRecordWithReturnKey)", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
string strKey = clsDataNodeTypeBL.DataNodeTypeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeId(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, conDataNodeType.DataNodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, conDataNodeType.DataNodeTypeId);
}
objDataNodeTypeEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeId) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeId, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeId] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeName(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeName, 50, conDataNodeType.DataNodeTypeName);
}
objDataNodeTypeEN.DataNodeTypeName = strDataNodeTypeName; //数据结点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeName) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeName, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeName] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeENName(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeENName, 50, conDataNodeType.DataNodeTypeENName);
}
objDataNodeTypeEN.DataNodeTypeENName = strDataNodeTypeENName; //数据结点类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeENName) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeENName, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeENName] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetUpdDate(this clsDataNodeTypeEN objDataNodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDataNodeType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNodeType.UpdDate);
}
objDataNodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.UpdDate) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.UpdDate, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.UpdDate] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetUpdUser(this clsDataNodeTypeEN objDataNodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDataNodeType.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNodeType.UpdUser);
}
objDataNodeTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.UpdUser) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.UpdUser, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.UpdUser] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetMemo(this clsDataNodeTypeEN objDataNodeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNodeType.Memo);
}
objDataNodeTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.Memo) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.Memo, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.Memo] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataNodeTypeEN objDataNodeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataNodeTypeEN.CheckPropertyNew();
clsDataNodeTypeEN objDataNodeTypeCond = new clsDataNodeTypeEN();
string strCondition = objDataNodeTypeCond
.SetDataNodeTypeId(objDataNodeTypeEN.DataNodeTypeId, "<>")
.SetDataNodeTypeName(objDataNodeTypeEN.DataNodeTypeName, "=")
.GetCombineCondition();
objDataNodeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsDataNodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DataNodeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataNodeTypeEN.Update();
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
 /// <param name = "objDataNodeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDataNodeTypeEN objDataNodeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDataNodeTypeEN objDataNodeTypeCond = new clsDataNodeTypeEN();
string strCondition = objDataNodeTypeCond
.SetDataNodeTypeName(objDataNodeType.DataNodeTypeName, "=")
.GetCombineCondition();
objDataNodeType._IsCheckProperty = true;
bool bolIsExist = clsDataNodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDataNodeType.DataNodeTypeId = clsDataNodeTypeBL.GetFirstID_S(strCondition);
objDataNodeType.UpdateWithCondition(strCondition);
}
else
{
objDataNodeType.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
objDataNodeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeTypeEN objDataNodeTypeEN)
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeTypeBL.DataNodeTypeDA.UpdateBySql2(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeTypeEN objDataNodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataNodeTypeBL.DataNodeTypeDA.UpdateBySql2(objDataNodeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeTypeEN objDataNodeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsDataNodeTypeBL.DataNodeTypeDA.UpdateBySqlWithCondition(objDataNodeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeTypeEN objDataNodeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataNodeTypeBL.DataNodeTypeDA.UpdateBySqlWithConditionTransaction(objDataNodeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "strDataNodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
int intRecNum = clsDataNodeTypeBL.DataNodeTypeDA.DelRecord(objDataNodeTypeEN.DataNodeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeENS">源对象</param>
 /// <param name = "objDataNodeTypeENT">目标对象</param>
 public static void CopyTo(this clsDataNodeTypeEN objDataNodeTypeENS, clsDataNodeTypeEN objDataNodeTypeENT)
{
try
{
objDataNodeTypeENT.DataNodeTypeId = objDataNodeTypeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeTypeENT.DataNodeTypeName = objDataNodeTypeENS.DataNodeTypeName; //数据结点类型名
objDataNodeTypeENT.DataNodeTypeENName = objDataNodeTypeENS.DataNodeTypeENName; //数据结点类型英文名
objDataNodeTypeENT.UpdDate = objDataNodeTypeENS.UpdDate; //修改日期
objDataNodeTypeENT.UpdUser = objDataNodeTypeENS.UpdUser; //修改者
objDataNodeTypeENT.Memo = objDataNodeTypeENS.Memo; //说明
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
 /// <param name = "objDataNodeTypeENS">源对象</param>
 /// <returns>目标对象=>clsDataNodeTypeEN:objDataNodeTypeENT</returns>
 public static clsDataNodeTypeEN CopyTo(this clsDataNodeTypeEN objDataNodeTypeENS)
{
try
{
 clsDataNodeTypeEN objDataNodeTypeENT = new clsDataNodeTypeEN()
{
DataNodeTypeId = objDataNodeTypeENS.DataNodeTypeId, //数据结点类型Id
DataNodeTypeName = objDataNodeTypeENS.DataNodeTypeName, //数据结点类型名
DataNodeTypeENName = objDataNodeTypeENS.DataNodeTypeENName, //数据结点类型英文名
UpdDate = objDataNodeTypeENS.UpdDate, //修改日期
UpdUser = objDataNodeTypeENS.UpdUser, //修改者
Memo = objDataNodeTypeENS.Memo, //说明
};
 return objDataNodeTypeENT;
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
public static void CheckPropertyNew(this clsDataNodeTypeEN objDataNodeTypeEN)
{
 clsDataNodeTypeBL.DataNodeTypeDA.CheckPropertyNew(objDataNodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataNodeTypeEN objDataNodeTypeEN)
{
 clsDataNodeTypeBL.DataNodeTypeDA.CheckProperty4Condition(objDataNodeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeTypeEN objDataNodeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeId, objDataNodeTypeCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeName) == true)
{
string strComparisonOpDataNodeTypeName = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeName, objDataNodeTypeCond.DataNodeTypeName, strComparisonOpDataNodeTypeName);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeENName) == true)
{
string strComparisonOpDataNodeTypeENName = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeENName, objDataNodeTypeCond.DataNodeTypeENName, strComparisonOpDataNodeTypeENName);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.UpdDate, objDataNodeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.UpdUser, objDataNodeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.Memo) == true)
{
string strComparisonOpMemo = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.Memo, objDataNodeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DataNodeType(数据结点类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DataNodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDataNodeTypeEN objDataNodeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeTypeEN == null) return true;
if (objDataNodeTypeEN.DataNodeTypeId == null || objDataNodeTypeEN.DataNodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDataNodeTypeEN.DataNodeTypeName == null)
{
 sbCondition.AppendFormat(" and DataNodeTypeName is null", objDataNodeTypeEN.DataNodeTypeName);
}
else
{
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
}
if (clsDataNodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DataNodeTypeId !=  '{0}'", objDataNodeTypeEN.DataNodeTypeId);
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
if (clsDataNodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DataNodeType(数据结点类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DataNodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDataNodeTypeEN objDataNodeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeTypeEN == null) return "";
if (objDataNodeTypeEN.DataNodeTypeId == null || objDataNodeTypeEN.DataNodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDataNodeTypeEN.DataNodeTypeName == null)
{
 sbCondition.AppendFormat(" and DataNodeTypeName is null", objDataNodeTypeEN.DataNodeTypeName);
}
else
{
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DataNodeTypeId !=  '{0}'", objDataNodeTypeEN.DataNodeTypeId);
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataNodeType
{
public virtual bool UpdRelaTabDate(string strDataNodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumDataNodeType
{
 /// <summary>
 /// 关键字
 /// </summary>
public const string Keyword_01 = "01";
 /// <summary>
 /// 名称结点
 /// </summary>
public const string NameNode_02 = "02";
 /// <summary>
 /// 一般结点
 /// </summary>
public const string GeneralCode_03 = "03";
 /// <summary>
 /// 外键结点
 /// </summary>
public const string ForeignKeyNode_04 = "04";
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_05 = "05";
}
 /// <summary>
 /// 数据结点类型(DataNodeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeTypeBL
{
public static RelatedActions_DataNodeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataNodeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataNodeTypeDA DataNodeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataNodeTypeDA();
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
 public clsDataNodeTypeBL()
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
if (string.IsNullOrEmpty(clsDataNodeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeTypeEN._ConnectString);
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
public static DataTable GetDataTable_DataNodeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataNodeTypeDA.GetDataTable_DataNodeType(strWhereCond);
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
objDT = DataNodeTypeDA.GetDataTable(strWhereCond);
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
objDT = DataNodeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataNodeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataNodeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataNodeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = DataNodeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataNodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataNodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDataNodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstByDataNodeTypeIdLst(List<string> arrDataNodeTypeIdLst)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataNodeTypeIdLst, true);
 string strWhereCond = string.Format("DataNodeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataNodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataNodeTypeEN> GetObjLstByDataNodeTypeIdLstCache(List<string> arrDataNodeTypeIdLst)
{
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel =
arrDataNodeTypeObjLstCache
.Where(x => arrDataNodeTypeIdLst.Contains(x.DataNodeTypeId));
return arrDataNodeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLst(string strWhereCond)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
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
public static List<clsDataNodeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataNodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataNodeTypeEN> GetSubObjLstCache(clsDataNodeTypeEN objDataNodeTypeCond)
{
List<clsDataNodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNodeType._AttributeName)
{
if (objDataNodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeTypeCond[strFldName].ToString());
}
else
{
if (objDataNodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeTypeCond[strFldName]));
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
public static List<clsDataNodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
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
public static List<clsDataNodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
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
List<clsDataNodeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataNodeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataNodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
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
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
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
public static List<clsDataNodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataNodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
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
public static List<clsDataNodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataNodeTypeEN> arrObjLst = new List<clsDataNodeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN();
try
{
objDataNodeTypeEN.DataNodeTypeId = objRow[conDataNodeType.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeTypeEN.DataNodeTypeName = objRow[conDataNodeType.DataNodeTypeName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objDataNodeTypeEN.DataNodeTypeENName = objRow[conDataNodeType.DataNodeTypeENName] == DBNull.Value ? null : objRow[conDataNodeType.DataNodeTypeENName].ToString().Trim(); //数据结点类型英文名
objDataNodeTypeEN.UpdDate = objRow[conDataNodeType.UpdDate].ToString().Trim(); //修改日期
objDataNodeTypeEN.UpdUser = objRow[conDataNodeType.UpdUser].ToString().Trim(); //修改者
objDataNodeTypeEN.Memo = objRow[conDataNodeType.Memo] == DBNull.Value ? null : objRow[conDataNodeType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataNodeTypeEN.DataNodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataNodeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataNodeType(ref clsDataNodeTypeEN objDataNodeTypeEN)
{
bool bolResult = DataNodeTypeDA.GetDataNodeType(ref objDataNodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDataNodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeTypeEN GetObjByDataNodeTypeId(string strDataNodeTypeId)
{
if (strDataNodeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDataNodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDataNodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDataNodeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDataNodeTypeEN objDataNodeTypeEN = DataNodeTypeDA.GetObjByDataNodeTypeId(strDataNodeTypeId);
return objDataNodeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataNodeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataNodeTypeEN objDataNodeTypeEN = DataNodeTypeDA.GetFirstObj(strWhereCond);
 return objDataNodeTypeEN;
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
public static clsDataNodeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataNodeTypeEN objDataNodeTypeEN = DataNodeTypeDA.GetObjByDataRow(objRow);
 return objDataNodeTypeEN;
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
public static clsDataNodeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataNodeTypeEN objDataNodeTypeEN = DataNodeTypeDA.GetObjByDataRow(objRow);
 return objDataNodeTypeEN;
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
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <param name = "lstDataNodeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeTypeEN GetObjByDataNodeTypeIdFromList(string strDataNodeTypeId, List<clsDataNodeTypeEN> lstDataNodeTypeObjLst)
{
foreach (clsDataNodeTypeEN objDataNodeTypeEN in lstDataNodeTypeObjLst)
{
if (objDataNodeTypeEN.DataNodeTypeId == strDataNodeTypeId)
{
return objDataNodeTypeEN;
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
 string strMaxDataNodeTypeId;
 try
 {
 strMaxDataNodeTypeId = clsDataNodeTypeDA.GetMaxStrId();
 return strMaxDataNodeTypeId;
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
 string strDataNodeTypeId;
 try
 {
 strDataNodeTypeId = new clsDataNodeTypeDA().GetFirstID(strWhereCond);
 return strDataNodeTypeId;
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
 arrList = DataNodeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = DataNodeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDataNodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDataNodeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DataNodeTypeDA.IsExist(strDataNodeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDataNodeTypeId">数据结点类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDataNodeTypeId, string strOpUser)
{
clsDataNodeTypeEN objDataNodeTypeEN = clsDataNodeTypeBL.GetObjByDataNodeTypeId(strDataNodeTypeId);
objDataNodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDataNodeTypeEN.UpdUser = strOpUser;
return clsDataNodeTypeBL.UpdateBySql2(objDataNodeTypeEN);
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
 bolIsExist = clsDataNodeTypeDA.IsExistTable();
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
 bolIsExist = DataNodeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据结点类型名 = [{0}]的数据已经存在!(in clsDataNodeTypeBL.AddNewRecordBySql2)", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = DataNodeTypeDA.AddNewRecordBySQL2(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataNodeTypeEN objDataNodeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDataNodeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据结点类型名 = [{0}]的数据已经存在!(in clsDataNodeTypeBL.AddNewRecordBySql2WithReturnKey)", objDataNodeTypeEN.DataNodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeBL.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeBL.GetMaxStrId_S();
 }
string strKey = DataNodeTypeDA.AddNewRecordBySQL2WithReturnKey(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
bool bolResult = DataNodeTypeDA.Update(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataNodeTypeEN objDataNodeTypeEN)
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataNodeTypeDA.UpdateBySql2(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeBL.ReFreshCache();

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
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
 /// <param name = "strDataNodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDataNodeTypeId)
{
try
{
 clsDataNodeTypeEN objDataNodeTypeEN = clsDataNodeTypeBL.GetObjByDataNodeTypeId(strDataNodeTypeId);

if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(objDataNodeTypeEN.DataNodeTypeId, objDataNodeTypeEN.UpdUser);
}
if (objDataNodeTypeEN != null)
{
int intRecNum = DataNodeTypeDA.DelRecord(strDataNodeTypeId);
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
/// <param name="strDataNodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDataNodeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataNodeTypeDA.GetSpecSQLObj();
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
//删除与表:[DataNodeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataNodeType.DataNodeTypeId,
//strDataNodeTypeId);
//        clsDataNodeTypeBL.DelDataNodeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeTypeBL.DelRecord(strDataNodeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataNodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDataNodeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDataNodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataNodeTypeBL.relatedActions != null)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(strDataNodeTypeId, "UpdRelaTabDate");
}
bool bolResult = DataNodeTypeDA.DelRecord(strDataNodeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDataNodeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataNodeTypes(List<string> arrDataNodeTypeIdLst)
{
if (arrDataNodeTypeIdLst.Count == 0) return 0;
try
{
if (clsDataNodeTypeBL.relatedActions != null)
{
foreach (var strDataNodeTypeId in arrDataNodeTypeIdLst)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(strDataNodeTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = DataNodeTypeDA.DelDataNodeType(arrDataNodeTypeIdLst);
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
public static int DelDataNodeTypesByCond(string strWhereCond)
{
try
{
if (clsDataNodeTypeBL.relatedActions != null)
{
List<string> arrDataNodeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataNodeTypeId in arrDataNodeTypeId)
{
clsDataNodeTypeBL.relatedActions.UpdRelaTabDate(strDataNodeTypeId, "UpdRelaTabDate");
}
}
int intRecNum = DataNodeTypeDA.DelDataNodeType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataNodeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDataNodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDataNodeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataNodeTypeDA.GetSpecSQLObj();
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
//删除与表:[DataNodeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataNodeTypeBL.DelRecord(strDataNodeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataNodeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataNodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataNodeTypeENS">源对象</param>
 /// <param name = "objDataNodeTypeENT">目标对象</param>
 public static void CopyTo(clsDataNodeTypeEN objDataNodeTypeENS, clsDataNodeTypeEN objDataNodeTypeENT)
{
try
{
objDataNodeTypeENT.DataNodeTypeId = objDataNodeTypeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeTypeENT.DataNodeTypeName = objDataNodeTypeENS.DataNodeTypeName; //数据结点类型名
objDataNodeTypeENT.DataNodeTypeENName = objDataNodeTypeENS.DataNodeTypeENName; //数据结点类型英文名
objDataNodeTypeENT.UpdDate = objDataNodeTypeENS.UpdDate; //修改日期
objDataNodeTypeENT.UpdUser = objDataNodeTypeENS.UpdUser; //修改者
objDataNodeTypeENT.Memo = objDataNodeTypeENS.Memo; //说明
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
 /// <param name = "objDataNodeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
objDataNodeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataNodeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataNodeType.DataNodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.DataNodeTypeId = objDataNodeTypeEN.DataNodeTypeId; //数据结点类型Id
}
if (arrFldSet.Contains(conDataNodeType.DataNodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.DataNodeTypeName = objDataNodeTypeEN.DataNodeTypeName == "[null]" ? null :  objDataNodeTypeEN.DataNodeTypeName; //数据结点类型名
}
if (arrFldSet.Contains(conDataNodeType.DataNodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.DataNodeTypeENName = objDataNodeTypeEN.DataNodeTypeENName == "[null]" ? null :  objDataNodeTypeEN.DataNodeTypeENName; //数据结点类型英文名
}
if (arrFldSet.Contains(conDataNodeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.UpdDate = objDataNodeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDataNodeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.UpdUser = objDataNodeTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDataNodeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataNodeTypeEN.Memo = objDataNodeTypeEN.Memo == "[null]" ? null :  objDataNodeTypeEN.Memo; //说明
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
 /// <param name = "objDataNodeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
if (objDataNodeTypeEN.DataNodeTypeName == "[null]") objDataNodeTypeEN.DataNodeTypeName = null; //数据结点类型名
if (objDataNodeTypeEN.DataNodeTypeENName == "[null]") objDataNodeTypeEN.DataNodeTypeENName = null; //数据结点类型英文名
if (objDataNodeTypeEN.Memo == "[null]") objDataNodeTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDataNodeTypeEN objDataNodeTypeEN)
{
 DataNodeTypeDA.CheckPropertyNew(objDataNodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataNodeTypeEN objDataNodeTypeEN)
{
 DataNodeTypeDA.CheckProperty4Condition(objDataNodeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DataNodeTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataNodeType.DataNodeTypeId); 
List<clsDataNodeTypeEN> arrObjLst = clsDataNodeTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN()
{
DataNodeTypeId = "0",
DataNodeTypeName = "选[数据结点类型]..."
};
arrObjLst.Insert(0, objDataNodeTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataNodeType.DataNodeTypeId;
objComboBox.DisplayMember = conDataNodeType.DataNodeTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DataNodeTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDataNodeType.DataNodeTypeId); 
IEnumerable<clsDataNodeTypeEN> arrObjLst = clsDataNodeTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conDataNodeType.DataNodeTypeId;
objDDL.DataTextField = conDataNodeType.DataNodeTypeName;
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
public static void BindDdl_DataNodeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点类型]...","0");
List<clsDataNodeTypeEN> arrDataNodeTypeObjLst = GetAllDataNodeTypeObjLstCache(); 
objDDL.DataValueField = conDataNodeType.DataNodeTypeId;
objDDL.DataTextField = conDataNodeType.DataNodeTypeName;
objDDL.DataSource = arrDataNodeTypeObjLst;
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
if (clsDataNodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeTypeBL没有刷新缓存机制(clsDataNodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataNodeTypeId");
//if (arrDataNodeTypeObjLstCache == null)
//{
//arrDataNodeTypeObjLstCache = DataNodeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeTypeEN GetObjByDataNodeTypeIdCache(string strDataNodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel =
arrDataNodeTypeObjLstCache
.Where(x=> x.DataNodeTypeId == strDataNodeTypeId 
);
if (arrDataNodeTypeObjLst_Sel.Count() == 0)
{
   clsDataNodeTypeEN obj = clsDataNodeTypeBL.GetObjByDataNodeTypeId(strDataNodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDataNodeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeTypeNameByDataNodeTypeIdCache(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return "";
//获取缓存中的对象列表
clsDataNodeTypeEN objDataNodeType = GetObjByDataNodeTypeIdCache(strDataNodeTypeId);
if (objDataNodeType == null) return "";
return objDataNodeType.DataNodeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeTypeIdCache(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return "";
//获取缓存中的对象列表
clsDataNodeTypeEN objDataNodeType = GetObjByDataNodeTypeIdCache(strDataNodeTypeId);
if (objDataNodeType == null) return "";
return objDataNodeType.DataNodeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeTypeEN> GetAllDataNodeTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache(); 
return arrDataNodeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataNodeTypeObjLstCache;
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
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataNodeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDataNodeTypeEN._RefreshTimeLst.Count == 0) return "";
return clsDataNodeTypeEN._RefreshTimeLst[clsDataNodeTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsDataNodeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataNodeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDataNodeTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DataNodeType(数据结点类型)
 /// 唯一性条件:DataNodeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDataNodeTypeEN objDataNodeTypeEN)
{
//检测记录是否存在
string strResult = DataNodeTypeDA.GetUniCondStr(objDataNodeTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDataNodeTypeId)
{
if (strInFldName != conDataNodeType.DataNodeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataNodeType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataNodeType._AttributeName));
throw new Exception(strMsg);
}
var objDataNodeType = clsDataNodeTypeBL.GetObjByDataNodeTypeIdCache(strDataNodeTypeId);
if (objDataNodeType == null) return "";
return objDataNodeType[strOutFldName].ToString();
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
int intRecCount = clsDataNodeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsDataNodeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataNodeTypeDA.GetRecCount();
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
int intRecCount = clsDataNodeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataNodeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataNodeTypeEN objDataNodeTypeCond)
{
List<clsDataNodeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataNodeType._AttributeName)
{
if (objDataNodeTypeCond.IsUpdated(strFldName) == false) continue;
if (objDataNodeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeTypeCond[strFldName].ToString());
}
else
{
if (objDataNodeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataNodeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataNodeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataNodeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataNodeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataNodeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataNodeTypeCond[strFldName]));
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
 List<string> arrList = clsDataNodeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataNodeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataNodeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataNodeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeTypeDA.SetFldValue(clsDataNodeTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataNodeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataNodeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataNodeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataNodeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**数据结点类型Id*/ 
 strCreateTabCode.Append(" DataNodeTypeId char(2) primary key, "); 
 // /**数据结点类型名*/ 
 strCreateTabCode.Append(" DataNodeTypeName varchar(50) Null, "); 
 // /**数据结点类型英文名*/ 
 strCreateTabCode.Append(" DataNodeTypeENName varchar(50) Null, "); 
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
 /// 数据结点类型(DataNodeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataNodeType : clsCommFun4BL
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
clsDataNodeTypeBL.ReFreshThisCache();
}
}

}