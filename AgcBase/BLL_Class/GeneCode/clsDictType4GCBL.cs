
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDictType4GCBL
 表名:DictType4GC(00050352)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsDictType4GCBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDictTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDictType4GCEN GetObj(this K_DictTypeId_DictType4GC myKey)
{
clsDictType4GCEN objDictType4GCEN = clsDictType4GCBL.DictType4GCDA.GetObjByDictTypeId(myKey.Value);
return objDictType4GCEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDictType4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典类型名 = [{0}]的数据已经存在!(in clsDictType4GCBL.AddNewRecord)", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
bool bolResult = clsDictType4GCBL.DictType4GCDA.AddNewRecordBySQL2(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
public static bool AddRecordEx(this clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDictType4GCEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDictType4GCEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字典类型名(DictTypeName)=[{0}])已经存在,不能重复!", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDictType4GCEN.AddNewRecord();
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDictType4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典类型名 = [{0}]的数据已经存在!(in clsDictType4GCBL.AddNewRecordWithMaxId)", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
string strDictTypeId = clsDictType4GCBL.DictType4GCDA.AddNewRecordBySQL2WithReturnKey(objDictType4GCEN);
     objDictType4GCEN.DictTypeId = strDictTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
}
return strDictTypeId;
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDictType4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典类型名 = [{0}]的数据已经存在!(in clsDictType4GCBL.AddNewRecordWithReturnKey)", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
string strKey = clsDictType4GCBL.DictType4GCDA.AddNewRecordBySQL2WithReturnKey(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDictType4GCEN SetDictTypeId(this clsDictType4GCEN objDictType4GCEN, string strDictTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictTypeId, 4, conDictType4GC.DictTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDictTypeId, 4, conDictType4GC.DictTypeId);
}
objDictType4GCEN.DictTypeId = strDictTypeId; //字典类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDictType4GCEN.dicFldComparisonOp.ContainsKey(conDictType4GC.DictTypeId) == false)
{
objDictType4GCEN.dicFldComparisonOp.Add(conDictType4GC.DictTypeId, strComparisonOp);
}
else
{
objDictType4GCEN.dicFldComparisonOp[conDictType4GC.DictTypeId] = strComparisonOp;
}
}
return objDictType4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDictType4GCEN SetDictTypeName(this clsDictType4GCEN objDictType4GCEN, string strDictTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictTypeName, conDictType4GC.DictTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictTypeName, 50, conDictType4GC.DictTypeName);
}
objDictType4GCEN.DictTypeName = strDictTypeName; //字典类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDictType4GCEN.dicFldComparisonOp.ContainsKey(conDictType4GC.DictTypeName) == false)
{
objDictType4GCEN.dicFldComparisonOp.Add(conDictType4GC.DictTypeName, strComparisonOp);
}
else
{
objDictType4GCEN.dicFldComparisonOp[conDictType4GC.DictTypeName] = strComparisonOp;
}
}
return objDictType4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDictType4GCEN SetUpdDate(this clsDictType4GCEN objDictType4GCEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDictType4GC.UpdDate);
}
objDictType4GCEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDictType4GCEN.dicFldComparisonOp.ContainsKey(conDictType4GC.UpdDate) == false)
{
objDictType4GCEN.dicFldComparisonOp.Add(conDictType4GC.UpdDate, strComparisonOp);
}
else
{
objDictType4GCEN.dicFldComparisonOp[conDictType4GC.UpdDate] = strComparisonOp;
}
}
return objDictType4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDictType4GCEN SetUpdUser(this clsDictType4GCEN objDictType4GCEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDictType4GC.UpdUser);
}
objDictType4GCEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDictType4GCEN.dicFldComparisonOp.ContainsKey(conDictType4GC.UpdUser) == false)
{
objDictType4GCEN.dicFldComparisonOp.Add(conDictType4GC.UpdUser, strComparisonOp);
}
else
{
objDictType4GCEN.dicFldComparisonOp[conDictType4GC.UpdUser] = strComparisonOp;
}
}
return objDictType4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDictType4GCEN SetMemo(this clsDictType4GCEN objDictType4GCEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDictType4GC.Memo);
}
objDictType4GCEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDictType4GCEN.dicFldComparisonOp.ContainsKey(conDictType4GC.Memo) == false)
{
objDictType4GCEN.dicFldComparisonOp.Add(conDictType4GC.Memo, strComparisonOp);
}
else
{
objDictType4GCEN.dicFldComparisonOp[conDictType4GC.Memo] = strComparisonOp;
}
}
return objDictType4GCEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDictType4GCEN objDictType4GCEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDictType4GCEN.CheckPropertyNew();
clsDictType4GCEN objDictType4GCCond = new clsDictType4GCEN();
string strCondition = objDictType4GCCond
.SetDictTypeId(objDictType4GCEN.DictTypeId, "<>")
.SetDictTypeName(objDictType4GCEN.DictTypeName, "=")
.GetCombineCondition();
objDictType4GCEN._IsCheckProperty = true;
bool bolIsExist = clsDictType4GCBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DictTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDictType4GCEN.Update();
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
 /// <param name = "objDictType4GC">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDictType4GCEN objDictType4GC)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDictType4GCEN objDictType4GCCond = new clsDictType4GCEN();
string strCondition = objDictType4GCCond
.SetDictTypeName(objDictType4GC.DictTypeName, "=")
.GetCombineCondition();
objDictType4GC._IsCheckProperty = true;
bool bolIsExist = clsDictType4GCBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDictType4GC.DictTypeId = clsDictType4GCBL.GetFirstID_S(strCondition);
objDictType4GC.UpdateWithCondition(strCondition);
}
else
{
objDictType4GC.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
objDictType4GC.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDictType4GCEN objDictType4GCEN)
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDictType4GCBL.DictType4GCDA.UpdateBySql2(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDictType4GCEN objDictType4GCEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDictType4GCBL.DictType4GCDA.UpdateBySql2(objDictType4GCEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDictType4GCEN objDictType4GCEN, string strWhereCond)
{
try
{
bool bolResult = clsDictType4GCBL.DictType4GCDA.UpdateBySqlWithCondition(objDictType4GCEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDictType4GCEN objDictType4GCEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDictType4GCBL.DictType4GCDA.UpdateBySqlWithConditionTransaction(objDictType4GCEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "strDictTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDictType4GCEN objDictType4GCEN)
{
try
{
int intRecNum = clsDictType4GCBL.DictType4GCDA.DelRecord(objDictType4GCEN.DictTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCENS">源对象</param>
 /// <param name = "objDictType4GCENT">目标对象</param>
 public static void CopyTo(this clsDictType4GCEN objDictType4GCENS, clsDictType4GCEN objDictType4GCENT)
{
try
{
objDictType4GCENT.DictTypeId = objDictType4GCENS.DictTypeId; //字典类型Id
objDictType4GCENT.DictTypeName = objDictType4GCENS.DictTypeName; //字典类型名
objDictType4GCENT.UpdDate = objDictType4GCENS.UpdDate; //修改日期
objDictType4GCENT.UpdUser = objDictType4GCENS.UpdUser; //修改者
objDictType4GCENT.Memo = objDictType4GCENS.Memo; //说明
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
 /// <param name = "objDictType4GCENS">源对象</param>
 /// <returns>目标对象=>clsDictType4GCEN:objDictType4GCENT</returns>
 public static clsDictType4GCEN CopyTo(this clsDictType4GCEN objDictType4GCENS)
{
try
{
 clsDictType4GCEN objDictType4GCENT = new clsDictType4GCEN()
{
DictTypeId = objDictType4GCENS.DictTypeId, //字典类型Id
DictTypeName = objDictType4GCENS.DictTypeName, //字典类型名
UpdDate = objDictType4GCENS.UpdDate, //修改日期
UpdUser = objDictType4GCENS.UpdUser, //修改者
Memo = objDictType4GCENS.Memo, //说明
};
 return objDictType4GCENT;
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
public static void CheckPropertyNew(this clsDictType4GCEN objDictType4GCEN)
{
 clsDictType4GCBL.DictType4GCDA.CheckPropertyNew(objDictType4GCEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDictType4GCEN objDictType4GCEN)
{
 clsDictType4GCBL.DictType4GCDA.CheckProperty4Condition(objDictType4GCEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDictType4GCEN objDictType4GCCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDictType4GCCond.IsUpdated(conDictType4GC.DictTypeId) == true)
{
string strComparisonOpDictTypeId = objDictType4GCCond.dicFldComparisonOp[conDictType4GC.DictTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDictType4GC.DictTypeId, objDictType4GCCond.DictTypeId, strComparisonOpDictTypeId);
}
if (objDictType4GCCond.IsUpdated(conDictType4GC.DictTypeName) == true)
{
string strComparisonOpDictTypeName = objDictType4GCCond.dicFldComparisonOp[conDictType4GC.DictTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDictType4GC.DictTypeName, objDictType4GCCond.DictTypeName, strComparisonOpDictTypeName);
}
if (objDictType4GCCond.IsUpdated(conDictType4GC.UpdDate) == true)
{
string strComparisonOpUpdDate = objDictType4GCCond.dicFldComparisonOp[conDictType4GC.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDictType4GC.UpdDate, objDictType4GCCond.UpdDate, strComparisonOpUpdDate);
}
if (objDictType4GCCond.IsUpdated(conDictType4GC.UpdUser) == true)
{
string strComparisonOpUpdUser = objDictType4GCCond.dicFldComparisonOp[conDictType4GC.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDictType4GC.UpdUser, objDictType4GCCond.UpdUser, strComparisonOpUpdUser);
}
if (objDictType4GCCond.IsUpdated(conDictType4GC.Memo) == true)
{
string strComparisonOpMemo = objDictType4GCCond.dicFldComparisonOp[conDictType4GC.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDictType4GC.Memo, objDictType4GCCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DictType4GC(生成代码字典类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DictTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDictType4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDictType4GCEN objDictType4GCEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDictType4GCEN == null) return true;
if (objDictType4GCEN.DictTypeId == null || objDictType4GCEN.DictTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictTypeName = '{0}'", objDictType4GCEN.DictTypeName);
if (clsDictType4GCBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DictTypeId !=  '{0}'", objDictType4GCEN.DictTypeId);
 sbCondition.AppendFormat(" and DictTypeName = '{0}'", objDictType4GCEN.DictTypeName);
if (clsDictType4GCBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DictType4GC(生成代码字典类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DictTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDictType4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDictType4GCEN objDictType4GCEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDictType4GCEN == null) return "";
if (objDictType4GCEN.DictTypeId == null || objDictType4GCEN.DictTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictTypeName = '{0}'", objDictType4GCEN.DictTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DictTypeId !=  '{0}'", objDictType4GCEN.DictTypeId);
 sbCondition.AppendFormat(" and DictTypeName = '{0}'", objDictType4GCEN.DictTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DictType4GC
{
public virtual bool UpdRelaTabDate(string strDictTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 生成代码字典类型(DictType4GC)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDictType4GCBL
{
public static RelatedActions_DictType4GC relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDictType4GCDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDictType4GCDA DictType4GCDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDictType4GCDA();
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
 public clsDictType4GCBL()
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
if (string.IsNullOrEmpty(clsDictType4GCEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDictType4GCEN._ConnectString);
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
public static DataTable GetDataTable_DictType4GC(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DictType4GCDA.GetDataTable_DictType4GC(strWhereCond);
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
objDT = DictType4GCDA.GetDataTable(strWhereCond);
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
objDT = DictType4GCDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DictType4GCDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DictType4GCDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DictType4GCDA.GetDataTable_Top(objTopPara);
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
objDT = DictType4GCDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DictType4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DictType4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDictTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDictType4GCEN> GetObjLstByDictTypeIdLst(List<string> arrDictTypeIdLst)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDictTypeIdLst, true);
 string strWhereCond = string.Format("DictTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDictTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDictType4GCEN> GetObjLstByDictTypeIdLstCache(List<string> arrDictTypeIdLst)
{
string strKey = string.Format("{0}", clsDictType4GCEN._CurrTabName);
List<clsDictType4GCEN> arrDictType4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDictType4GCEN> arrDictType4GCObjLst_Sel =
arrDictType4GCObjLstCache
.Where(x => arrDictTypeIdLst.Contains(x.DictTypeId));
return arrDictType4GCObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDictType4GCEN> GetObjLst(string strWhereCond)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
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
public static List<clsDictType4GCEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDictType4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDictType4GCEN> GetSubObjLstCache(clsDictType4GCEN objDictType4GCCond)
{
List<clsDictType4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDictType4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDictType4GC._AttributeName)
{
if (objDictType4GCCond.IsUpdated(strFldName) == false) continue;
if (objDictType4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDictType4GCCond[strFldName].ToString());
}
else
{
if (objDictType4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDictType4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDictType4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDictType4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDictType4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDictType4GCCond[strFldName]));
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
public static List<clsDictType4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
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
public static List<clsDictType4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
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
List<clsDictType4GCEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDictType4GCEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDictType4GCEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDictType4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
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
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
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
public static List<clsDictType4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDictType4GCEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDictType4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
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
public static List<clsDictType4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDictType4GCEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDictType4GCEN> arrObjLst = new List<clsDictType4GCEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN();
try
{
objDictType4GCEN.DictTypeId = objRow[conDictType4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDictType4GCEN.DictTypeName = objRow[conDictType4GC.DictTypeName].ToString().Trim(); //字典类型名
objDictType4GCEN.UpdDate = objRow[conDictType4GC.UpdDate] == DBNull.Value ? null : objRow[conDictType4GC.UpdDate].ToString().Trim(); //修改日期
objDictType4GCEN.UpdUser = objRow[conDictType4GC.UpdUser] == DBNull.Value ? null : objRow[conDictType4GC.UpdUser].ToString().Trim(); //修改者
objDictType4GCEN.Memo = objRow[conDictType4GC.Memo] == DBNull.Value ? null : objRow[conDictType4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDictType4GCEN.DictTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDictType4GCEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDictType4GCEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDictType4GC(ref clsDictType4GCEN objDictType4GCEN)
{
bool bolResult = DictType4GCDA.GetDictType4GC(ref objDictType4GCEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDictTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDictType4GCEN GetObjByDictTypeId(string strDictTypeId)
{
if (strDictTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDictTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDictTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDictTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDictType4GCEN objDictType4GCEN = DictType4GCDA.GetObjByDictTypeId(strDictTypeId);
return objDictType4GCEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDictType4GCEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDictType4GCEN objDictType4GCEN = DictType4GCDA.GetFirstObj(strWhereCond);
 return objDictType4GCEN;
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
public static clsDictType4GCEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDictType4GCEN objDictType4GCEN = DictType4GCDA.GetObjByDataRow(objRow);
 return objDictType4GCEN;
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
public static clsDictType4GCEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDictType4GCEN objDictType4GCEN = DictType4GCDA.GetObjByDataRow(objRow);
 return objDictType4GCEN;
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
 /// <param name = "strDictTypeId">所给的关键字</param>
 /// <param name = "lstDictType4GCObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDictType4GCEN GetObjByDictTypeIdFromList(string strDictTypeId, List<clsDictType4GCEN> lstDictType4GCObjLst)
{
foreach (clsDictType4GCEN objDictType4GCEN in lstDictType4GCObjLst)
{
if (objDictType4GCEN.DictTypeId == strDictTypeId)
{
return objDictType4GCEN;
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
 string strMaxDictTypeId;
 try
 {
 strMaxDictTypeId = clsDictType4GCDA.GetMaxStrId();
 return strMaxDictTypeId;
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
 string strDictTypeId;
 try
 {
 strDictTypeId = new clsDictType4GCDA().GetFirstID(strWhereCond);
 return strDictTypeId;
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
 arrList = DictType4GCDA.GetID(strWhereCond);
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
bool bolIsExist = DictType4GCDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDictTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDictTypeId)
{
if (string.IsNullOrEmpty(strDictTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDictTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DictType4GCDA.IsExist(strDictTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDictTypeId">字典类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDictTypeId, string strOpUser)
{
clsDictType4GCEN objDictType4GCEN = clsDictType4GCBL.GetObjByDictTypeId(strDictTypeId);
objDictType4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDictType4GCEN.UpdUser = strOpUser;
return clsDictType4GCBL.UpdateBySql2(objDictType4GCEN);
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
 bolIsExist = clsDictType4GCDA.IsExistTable();
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
 bolIsExist = DictType4GCDA.IsExistTable(strTabName);
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDictType4GCEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字典类型名 = [{0}]的数据已经存在!(in clsDictType4GCBL.AddNewRecordBySql2)", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
bool bolResult = DictType4GCDA.AddNewRecordBySQL2(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDictType4GCEN objDictType4GCEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDictType4GCEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字典类型名 = [{0}]的数据已经存在!(in clsDictType4GCBL.AddNewRecordBySql2WithReturnKey)", objDictType4GCEN.DictTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true || clsDictType4GCBL.IsExist(objDictType4GCEN.DictTypeId) == true)
 {
     objDictType4GCEN.DictTypeId = clsDictType4GCBL.GetMaxStrId_S();
 }
string strKey = DictType4GCDA.AddNewRecordBySQL2WithReturnKey(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDictType4GCEN objDictType4GCEN)
{
try
{
bool bolResult = DictType4GCDA.Update(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "objDictType4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDictType4GCEN objDictType4GCEN)
{
 if (string.IsNullOrEmpty(objDictType4GCEN.DictTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DictType4GCDA.UpdateBySql2(objDictType4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDictType4GCBL.ReFreshCache();

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
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
 /// <param name = "strDictTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDictTypeId)
{
try
{
 clsDictType4GCEN objDictType4GCEN = clsDictType4GCBL.GetObjByDictTypeId(strDictTypeId);

if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(objDictType4GCEN.DictTypeId, objDictType4GCEN.UpdUser);
}
if (objDictType4GCEN != null)
{
int intRecNum = DictType4GCDA.DelRecord(strDictTypeId);
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
/// <param name="strDictTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDictTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDictType4GCDA.GetSpecSQLObj();
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
//删除与表:[DictType4GC]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDictType4GC.DictTypeId,
//strDictTypeId);
//        clsDictType4GCBL.DelDictType4GCsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDictType4GCBL.DelRecord(strDictTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDictType4GCBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDictTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDictTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDictTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDictType4GCBL.relatedActions != null)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(strDictTypeId, "UpdRelaTabDate");
}
bool bolResult = DictType4GCDA.DelRecord(strDictTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDictTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDictType4GCs(List<string> arrDictTypeIdLst)
{
if (arrDictTypeIdLst.Count == 0) return 0;
try
{
if (clsDictType4GCBL.relatedActions != null)
{
foreach (var strDictTypeId in arrDictTypeIdLst)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(strDictTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = DictType4GCDA.DelDictType4GC(arrDictTypeIdLst);
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
public static int DelDictType4GCsByCond(string strWhereCond)
{
try
{
if (clsDictType4GCBL.relatedActions != null)
{
List<string> arrDictTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDictTypeId in arrDictTypeId)
{
clsDictType4GCBL.relatedActions.UpdRelaTabDate(strDictTypeId, "UpdRelaTabDate");
}
}
int intRecNum = DictType4GCDA.DelDictType4GC(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DictType4GC]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDictTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDictTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDictType4GCDA.GetSpecSQLObj();
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
//删除与表:[DictType4GC]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDictType4GCBL.DelRecord(strDictTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDictType4GCBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDictTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDictType4GCENS">源对象</param>
 /// <param name = "objDictType4GCENT">目标对象</param>
 public static void CopyTo(clsDictType4GCEN objDictType4GCENS, clsDictType4GCEN objDictType4GCENT)
{
try
{
objDictType4GCENT.DictTypeId = objDictType4GCENS.DictTypeId; //字典类型Id
objDictType4GCENT.DictTypeName = objDictType4GCENS.DictTypeName; //字典类型名
objDictType4GCENT.UpdDate = objDictType4GCENS.UpdDate; //修改日期
objDictType4GCENT.UpdUser = objDictType4GCENS.UpdUser; //修改者
objDictType4GCENT.Memo = objDictType4GCENS.Memo; //说明
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
 /// <param name = "objDictType4GCEN">源简化对象</param>
 public static void SetUpdFlag(clsDictType4GCEN objDictType4GCEN)
{
try
{
objDictType4GCEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDictType4GCEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDictType4GC.DictTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDictType4GCEN.DictTypeId = objDictType4GCEN.DictTypeId; //字典类型Id
}
if (arrFldSet.Contains(conDictType4GC.DictTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDictType4GCEN.DictTypeName = objDictType4GCEN.DictTypeName; //字典类型名
}
if (arrFldSet.Contains(conDictType4GC.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDictType4GCEN.UpdDate = objDictType4GCEN.UpdDate == "[null]" ? null :  objDictType4GCEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDictType4GC.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDictType4GCEN.UpdUser = objDictType4GCEN.UpdUser == "[null]" ? null :  objDictType4GCEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDictType4GC.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDictType4GCEN.Memo = objDictType4GCEN.Memo == "[null]" ? null :  objDictType4GCEN.Memo; //说明
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
 /// <param name = "objDictType4GCEN">源简化对象</param>
 public static void AccessFldValueNull(clsDictType4GCEN objDictType4GCEN)
{
try
{
if (objDictType4GCEN.UpdDate == "[null]") objDictType4GCEN.UpdDate = null; //修改日期
if (objDictType4GCEN.UpdUser == "[null]") objDictType4GCEN.UpdUser = null; //修改者
if (objDictType4GCEN.Memo == "[null]") objDictType4GCEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDictType4GCEN objDictType4GCEN)
{
 DictType4GCDA.CheckPropertyNew(objDictType4GCEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDictType4GCEN objDictType4GCEN)
{
 DictType4GCDA.CheckProperty4Condition(objDictType4GCEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DictTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDictType4GC.DictTypeId); 
List<clsDictType4GCEN> arrObjLst = clsDictType4GCBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDictType4GCEN objDictType4GCEN = new clsDictType4GCEN()
{
DictTypeId = "0",
DictTypeName = "选[生成代码字典类型]..."
};
arrObjLst.Insert(0, objDictType4GCEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDictType4GC.DictTypeId;
objComboBox.DisplayMember = conDictType4GC.DictTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DictTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[生成代码字典类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDictType4GC.DictTypeId); 
IEnumerable<clsDictType4GCEN> arrObjLst = clsDictType4GCBL.GetObjLst(strCondition);
objDDL.DataValueField = conDictType4GC.DictTypeId;
objDDL.DataTextField = conDictType4GC.DictTypeName;
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
public static void BindDdl_DictTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[生成代码字典类型]...","0");
List<clsDictType4GCEN> arrDictType4GCObjLst = GetAllDictType4GCObjLstCache(); 
objDDL.DataValueField = conDictType4GC.DictTypeId;
objDDL.DataTextField = conDictType4GC.DictTypeName;
objDDL.DataSource = arrDictType4GCObjLst;
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
if (clsDictType4GCBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDictType4GCBL没有刷新缓存机制(clsDictType4GCBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DictTypeId");
//if (arrDictType4GCObjLstCache == null)
//{
//arrDictType4GCObjLstCache = DictType4GCDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDictTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDictType4GCEN GetObjByDictTypeIdCache(string strDictTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDictType4GCEN._CurrTabName);
List<clsDictType4GCEN> arrDictType4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDictType4GCEN> arrDictType4GCObjLst_Sel =
arrDictType4GCObjLstCache
.Where(x=> x.DictTypeId == strDictTypeId 
);
if (arrDictType4GCObjLst_Sel.Count() == 0)
{
   clsDictType4GCEN obj = clsDictType4GCBL.GetObjByDictTypeId(strDictTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDictType4GCObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDictTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDictTypeNameByDictTypeIdCache(string strDictTypeId)
{
if (string.IsNullOrEmpty(strDictTypeId) == true) return "";
//获取缓存中的对象列表
clsDictType4GCEN objDictType4GC = GetObjByDictTypeIdCache(strDictTypeId);
if (objDictType4GC == null) return "";
return objDictType4GC.DictTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDictTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDictTypeIdCache(string strDictTypeId)
{
if (string.IsNullOrEmpty(strDictTypeId) == true) return "";
//获取缓存中的对象列表
clsDictType4GCEN objDictType4GC = GetObjByDictTypeIdCache(strDictTypeId);
if (objDictType4GC == null) return "";
return objDictType4GC.DictTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDictType4GCEN> GetAllDictType4GCObjLstCache()
{
//获取缓存中的对象列表
List<clsDictType4GCEN> arrDictType4GCObjLstCache = GetObjLstCache(); 
return arrDictType4GCObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDictType4GCEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDictType4GCEN._CurrTabName);
List<clsDictType4GCEN> arrDictType4GCObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDictType4GCObjLstCache;
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
string strKey = string.Format("{0}", clsDictType4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDictType4GCEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDictType4GCEN._RefreshTimeLst.Count == 0) return "";
return clsDictType4GCEN._RefreshTimeLst[clsDictType4GCEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDictType4GCBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDictType4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDictType4GCEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDictType4GCBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DictType4GC(生成代码字典类型)
 /// 唯一性条件:DictTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDictType4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDictType4GCEN objDictType4GCEN)
{
//检测记录是否存在
string strResult = DictType4GCDA.GetUniCondStr(objDictType4GCEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDictTypeId)
{
if (strInFldName != conDictType4GC.DictTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDictType4GC._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDictType4GC._AttributeName));
throw new Exception(strMsg);
}
var objDictType4GC = clsDictType4GCBL.GetObjByDictTypeIdCache(strDictTypeId);
if (objDictType4GC == null) return "";
return objDictType4GC[strOutFldName].ToString();
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
int intRecCount = clsDictType4GCDA.GetRecCount(strTabName);
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
int intRecCount = clsDictType4GCDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDictType4GCDA.GetRecCount();
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
int intRecCount = clsDictType4GCDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDictType4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDictType4GCEN objDictType4GCCond)
{
List<clsDictType4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDictType4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDictType4GC._AttributeName)
{
if (objDictType4GCCond.IsUpdated(strFldName) == false) continue;
if (objDictType4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDictType4GCCond[strFldName].ToString());
}
else
{
if (objDictType4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDictType4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDictType4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDictType4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDictType4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDictType4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDictType4GCCond[strFldName]));
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
 List<string> arrList = clsDictType4GCDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DictType4GCDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DictType4GCDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DictType4GCDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDictType4GCDA.SetFldValue(clsDictType4GCEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DictType4GCDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDictType4GCDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDictType4GCDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDictType4GCDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DictType4GC] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字典类型Id*/ 
 strCreateTabCode.Append(" DictTypeId char(4) primary key, "); 
 // /**字典类型名*/ 
 strCreateTabCode.Append(" DictTypeName varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 生成代码字典类型(DictType4GC)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DictType4GC : clsCommFun4BL
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
clsDictType4GCBL.ReFreshThisCache();
}
}

}