
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCPathBL
 表名:GCPath(00050595)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsGCPathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strGcPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCPathEN GetObj(this K_GcPathId_GCPath myKey)
{
clsGCPathEN objGCPathEN = clsGCPathBL.GCPathDA.GetObjByGcPathId(myKey.Value);
return objGCPathEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCPathEN) == false)
{
var strMsg = string.Format("记录已经存在!GC路径名 = [{0}],是否For主目录 = [{1}],用户Id = [{2}],工程Id = [{3}]的数据已经存在!(in clsGCPathBL.AddNewRecord)", objGCPathEN.GcPathName,objGCPathEN.IsForMainPath,objGCPathEN.UserId,objGCPathEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
bool bolResult = clsGCPathBL.GCPathDA.AddNewRecordBySQL2(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
public static bool AddRecordEx(this clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCPathBL.IsExist(objGCPathEN.GcPathId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCPathEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCPathEN.CheckUniqueness() == false)
{
strMsg = string.Format("(GC路径名(GcPathName)=[{0}],是否For主目录(IsForMainPath)=[{1}],用户Id(UserId)=[{2}],工程Id(PrjId)=[{3}])已经存在,不能重复!", objGCPathEN.GcPathName, objGCPathEN.IsForMainPath, objGCPathEN.UserId, objGCPathEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCPathEN.AddNewRecord();
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCPathEN) == false)
{
var strMsg = string.Format("记录已经存在!GC路径名 = [{0}],是否For主目录 = [{1}],用户Id = [{2}],工程Id = [{3}]的数据已经存在!(in clsGCPathBL.AddNewRecordWithMaxId)", objGCPathEN.GcPathName,objGCPathEN.IsForMainPath,objGCPathEN.UserId,objGCPathEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
string strGcPathId = clsGCPathBL.GCPathDA.AddNewRecordBySQL2WithReturnKey(objGCPathEN);
     objGCPathEN.GcPathId = strGcPathId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
}
return strGcPathId;
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCPathEN) == false)
{
var strMsg = string.Format("记录已经存在!GC路径名 = [{0}],是否For主目录 = [{1}],用户Id = [{2}],工程Id = [{3}]的数据已经存在!(in clsGCPathBL.AddNewRecordWithReturnKey)", objGCPathEN.GcPathName,objGCPathEN.IsForMainPath,objGCPathEN.UserId,objGCPathEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
string strKey = clsGCPathBL.GCPathDA.AddNewRecordBySQL2WithReturnKey(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetGcPathId(this clsGCPathEN objGCPathEN, string strGcPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conGCPath.GcPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conGCPath.GcPathId);
}
objGCPathEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.GcPathId) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.GcPathId, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.GcPathId] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetGcPathName(this clsGCPathEN objGCPathEN, string strGcPathName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGcPathName, conGCPath.GcPathName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcPathName, 150, conGCPath.GcPathName);
}
objGCPathEN.GcPathName = strGcPathName; //GC路径名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.GcPathName) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.GcPathName, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.GcPathName] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetIsForMainPath(this clsGCPathEN objGCPathEN, bool bolIsForMainPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsForMainPath, conGCPath.IsForMainPath);
objGCPathEN.IsForMainPath = bolIsForMainPath; //是否For主目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.IsForMainPath) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.IsForMainPath, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.IsForMainPath] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetUserId(this clsGCPathEN objGCPathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conGCPath.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conGCPath.UserId);
}
objGCPathEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.UserId) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.UserId, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.UserId] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetPrjId(this clsGCPathEN objGCPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conGCPath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conGCPath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conGCPath.PrjId);
}
objGCPathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.PrjId) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.PrjId, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.PrjId] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetUpdDate(this clsGCPathEN objGCPathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCPath.UpdDate);
}
objGCPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.UpdDate) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.UpdDate, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.UpdDate] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetUpdUser(this clsGCPathEN objGCPathEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCPath.UpdUser);
}
objGCPathEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.UpdUser) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.UpdUser, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.UpdUser] = strComparisonOp;
}
}
return objGCPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCPathEN SetMemo(this clsGCPathEN objGCPathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCPath.Memo);
}
objGCPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCPathEN.dicFldComparisonOp.ContainsKey(conGCPath.Memo) == false)
{
objGCPathEN.dicFldComparisonOp.Add(conGCPath.Memo, strComparisonOp);
}
else
{
objGCPathEN.dicFldComparisonOp[conGCPath.Memo] = strComparisonOp;
}
}
return objGCPathEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCPathEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCPathEN objGCPathEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCPathEN.CheckPropertyNew();
clsGCPathEN objGCPathCond = new clsGCPathEN();
string strCondition = objGCPathCond
.SetGcPathId(objGCPathEN.GcPathId, "<>")
.SetGcPathName(objGCPathEN.GcPathName, "=")
.SetIsForMainPath(objGCPathEN.IsForMainPath, "=")
.SetUserId(objGCPathEN.UserId, "=")
.SetPrjId(objGCPathEN.PrjId, "=")
.GetCombineCondition();
objGCPathEN._IsCheckProperty = true;
bool bolIsExist = clsGCPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(GCPathName_IsForMainPath_UserId_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCPathEN.Update();
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
 /// <param name = "objGCPath">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCPathEN objGCPath)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCPathEN objGCPathCond = new clsGCPathEN();
string strCondition = objGCPathCond
.SetGcPathName(objGCPath.GcPathName, "=")
.SetIsForMainPath(objGCPath.IsForMainPath, "=")
.SetUserId(objGCPath.UserId, "=")
.SetPrjId(objGCPath.PrjId, "=")
.GetCombineCondition();
objGCPath._IsCheckProperty = true;
bool bolIsExist = clsGCPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCPath.GcPathId = clsGCPathBL.GetFirstID_S(strCondition);
objGCPath.UpdateWithCondition(strCondition);
}
else
{
objGCPath.GcPathId = clsGCPathBL.GetMaxStrId_S();
objGCPath.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCPathEN objGCPathEN)
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCPathBL.GCPathDA.UpdateBySql2(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCPathEN objGCPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCPathBL.GCPathDA.UpdateBySql2(objGCPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCPathEN objGCPathEN, string strWhereCond)
{
try
{
bool bolResult = clsGCPathBL.GCPathDA.UpdateBySqlWithCondition(objGCPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCPathEN objGCPathEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCPathBL.GCPathDA.UpdateBySqlWithConditionTransaction(objGCPathEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "strGcPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCPathEN objGCPathEN)
{
try
{
int intRecNum = clsGCPathBL.GCPathDA.DelRecord(objGCPathEN.GcPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathENS">源对象</param>
 /// <param name = "objGCPathENT">目标对象</param>
 public static void CopyTo(this clsGCPathEN objGCPathENS, clsGCPathEN objGCPathENT)
{
try
{
objGCPathENT.GcPathId = objGCPathENS.GcPathId; //GC路径Id
objGCPathENT.GcPathName = objGCPathENS.GcPathName; //GC路径名
objGCPathENT.IsForMainPath = objGCPathENS.IsForMainPath; //是否For主目录
objGCPathENT.UserId = objGCPathENS.UserId; //用户Id
objGCPathENT.PrjId = objGCPathENS.PrjId; //工程Id
objGCPathENT.UpdDate = objGCPathENS.UpdDate; //修改日期
objGCPathENT.UpdUser = objGCPathENS.UpdUser; //修改者
objGCPathENT.Memo = objGCPathENS.Memo; //说明
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
 /// <param name = "objGCPathENS">源对象</param>
 /// <returns>目标对象=>clsGCPathEN:objGCPathENT</returns>
 public static clsGCPathEN CopyTo(this clsGCPathEN objGCPathENS)
{
try
{
 clsGCPathEN objGCPathENT = new clsGCPathEN()
{
GcPathId = objGCPathENS.GcPathId, //GC路径Id
GcPathName = objGCPathENS.GcPathName, //GC路径名
IsForMainPath = objGCPathENS.IsForMainPath, //是否For主目录
UserId = objGCPathENS.UserId, //用户Id
PrjId = objGCPathENS.PrjId, //工程Id
UpdDate = objGCPathENS.UpdDate, //修改日期
UpdUser = objGCPathENS.UpdUser, //修改者
Memo = objGCPathENS.Memo, //说明
};
 return objGCPathENT;
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
public static void CheckPropertyNew(this clsGCPathEN objGCPathEN)
{
 clsGCPathBL.GCPathDA.CheckPropertyNew(objGCPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCPathEN objGCPathEN)
{
 clsGCPathBL.GCPathDA.CheckProperty4Condition(objGCPathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCPathEN objGCPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCPathCond.IsUpdated(conGCPath.GcPathId) == true)
{
string strComparisonOpGcPathId = objGCPathCond.dicFldComparisonOp[conGCPath.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.GcPathId, objGCPathCond.GcPathId, strComparisonOpGcPathId);
}
if (objGCPathCond.IsUpdated(conGCPath.GcPathName) == true)
{
string strComparisonOpGcPathName = objGCPathCond.dicFldComparisonOp[conGCPath.GcPathName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.GcPathName, objGCPathCond.GcPathName, strComparisonOpGcPathName);
}
if (objGCPathCond.IsUpdated(conGCPath.IsForMainPath) == true)
{
if (objGCPathCond.IsForMainPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conGCPath.IsForMainPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conGCPath.IsForMainPath);
}
}
if (objGCPathCond.IsUpdated(conGCPath.UserId) == true)
{
string strComparisonOpUserId = objGCPathCond.dicFldComparisonOp[conGCPath.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.UserId, objGCPathCond.UserId, strComparisonOpUserId);
}
if (objGCPathCond.IsUpdated(conGCPath.PrjId) == true)
{
string strComparisonOpPrjId = objGCPathCond.dicFldComparisonOp[conGCPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.PrjId, objGCPathCond.PrjId, strComparisonOpPrjId);
}
if (objGCPathCond.IsUpdated(conGCPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCPathCond.dicFldComparisonOp[conGCPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.UpdDate, objGCPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCPathCond.IsUpdated(conGCPath.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCPathCond.dicFldComparisonOp[conGCPath.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.UpdUser, objGCPathCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCPathCond.IsUpdated(conGCPath.Memo) == true)
{
string strComparisonOpMemo = objGCPathCond.dicFldComparisonOp[conGCPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCPath.Memo, objGCPathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCPath(GC路径), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GCPathName_IsForMainPath_UserId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCPathEN objGCPathEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCPathEN == null) return true;
if (objGCPathEN.GcPathId == null || objGCPathEN.GcPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GcPathName = '{0}'", objGCPathEN.GcPathName);
 sbCondition.AppendFormat(" and IsForMainPath = '{0}'", objGCPathEN.IsForMainPath);
 sbCondition.AppendFormat(" and UserId = '{0}'", objGCPathEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objGCPathEN.PrjId);
if (clsGCPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("GcPathId !=  '{0}'", objGCPathEN.GcPathId);
 sbCondition.AppendFormat(" and GcPathName = '{0}'", objGCPathEN.GcPathName);
 sbCondition.AppendFormat(" and IsForMainPath = '{0}'", objGCPathEN.IsForMainPath);
 sbCondition.AppendFormat(" and UserId = '{0}'", objGCPathEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objGCPathEN.PrjId);
if (clsGCPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCPath(GC路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GCPathName_IsForMainPath_UserId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCPathEN objGCPathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCPathEN == null) return "";
if (objGCPathEN.GcPathId == null || objGCPathEN.GcPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GcPathName = '{0}'", objGCPathEN.GcPathName);
 sbCondition.AppendFormat(" and IsForMainPath = '{0}'", objGCPathEN.IsForMainPath);
 sbCondition.AppendFormat(" and UserId = '{0}'", objGCPathEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objGCPathEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("GcPathId !=  '{0}'", objGCPathEN.GcPathId);
 sbCondition.AppendFormat(" and GcPathName = '{0}'", objGCPathEN.GcPathName);
 sbCondition.AppendFormat(" and IsForMainPath = '{0}'", objGCPathEN.IsForMainPath);
 sbCondition.AppendFormat(" and UserId = '{0}'", objGCPathEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objGCPathEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCPath
{
public virtual bool UpdRelaTabDate(string strGcPathId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// GC路径(GCPath)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCPathBL
{
public static RelatedActions_GCPath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCPathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCPathDA GCPathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCPathDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV3 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsGCPathBL()
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
if (string.IsNullOrEmpty(clsGCPathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCPathEN._ConnectString);
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
public static DataTable GetDataTable_GCPath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCPathDA.GetDataTable_GCPath(strWhereCond);
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
objDT = GCPathDA.GetDataTable(strWhereCond);
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
objDT = GCPathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCPathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCPathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCPathDA.GetDataTable_Top(objTopPara);
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
objDT = GCPathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGcPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCPathEN> GetObjLstByGcPathIdLst(List<string> arrGcPathIdLst)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGcPathIdLst, true);
 string strWhereCond = string.Format("GcPathId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGcPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCPathEN> GetObjLstByGcPathIdLstCache(List<string> arrGcPathIdLst, string strPrjId, string strUserId)
{
string strKey = string.Format("{0}_{1}_{2}", clsGCPathEN._CurrTabName, strPrjId, strUserId);
List<clsGCPathEN> arrGCPathObjLstCache = GetObjLstCache(strPrjId, strUserId);
IEnumerable <clsGCPathEN> arrGCPathObjLst_Sel =
arrGCPathObjLstCache
.Where(x => arrGcPathIdLst.Contains(x.GcPathId));
return arrGCPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCPathEN> GetObjLst(string strWhereCond)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
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
public static List<clsGCPathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCPathEN> GetSubObjLstCache(clsGCPathEN objGCPathCond)
{
 string strPrjId = objGCPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsGCPathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
 string strUserId = objGCPathCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000175)在表中,缓存分类字段值2不能为空!(clsGCPathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsGCPathEN> arrObjLstCache = GetObjLstCache(strPrjId, strUserId);
IEnumerable <clsGCPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCPath._AttributeName)
{
if (objGCPathCond.IsUpdated(strFldName) == false) continue;
if (objGCPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCPathCond[strFldName].ToString());
}
else
{
if (objGCPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCPathCond[strFldName]));
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
public static List<clsGCPathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
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
public static List<clsGCPathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
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
List<clsGCPathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCPathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCPathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCPathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
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
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
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
public static List<clsGCPathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
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
public static List<clsGCPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCPathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCPathEN> arrObjLst = new List<clsGCPathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCPathEN objGCPathEN = new clsGCPathEN();
try
{
objGCPathEN.GcPathId = objRow[conGCPath.GcPathId].ToString().Trim(); //GC路径Id
objGCPathEN.GcPathName = objRow[conGCPath.GcPathName].ToString().Trim(); //GC路径名
objGCPathEN.IsForMainPath = clsEntityBase2.TransNullToBool_S(objRow[conGCPath.IsForMainPath].ToString().Trim()); //是否For主目录
objGCPathEN.UserId = objRow[conGCPath.UserId].ToString().Trim(); //用户Id
objGCPathEN.PrjId = objRow[conGCPath.PrjId].ToString().Trim(); //工程Id
objGCPathEN.UpdDate = objRow[conGCPath.UpdDate] == DBNull.Value ? null : objRow[conGCPath.UpdDate].ToString().Trim(); //修改日期
objGCPathEN.UpdUser = objRow[conGCPath.UpdUser] == DBNull.Value ? null : objRow[conGCPath.UpdUser].ToString().Trim(); //修改者
objGCPathEN.Memo = objRow[conGCPath.Memo] == DBNull.Value ? null : objRow[conGCPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCPathEN.GcPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCPathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCPathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCPath(ref clsGCPathEN objGCPathEN)
{
bool bolResult = GCPathDA.GetGCPath(ref objGCPathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strGcPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCPathEN GetObjByGcPathId(string strGcPathId)
{
if (strGcPathId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strGcPathId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGcPathId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strGcPathId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCPathEN objGCPathEN = GCPathDA.GetObjByGcPathId(strGcPathId);
return objGCPathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCPathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCPathEN objGCPathEN = GCPathDA.GetFirstObj(strWhereCond);
 return objGCPathEN;
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
public static clsGCPathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCPathEN objGCPathEN = GCPathDA.GetObjByDataRow(objRow);
 return objGCPathEN;
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
public static clsGCPathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCPathEN objGCPathEN = GCPathDA.GetObjByDataRow(objRow);
 return objGCPathEN;
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
 /// <param name = "strGcPathId">所给的关键字</param>
 /// <param name = "lstGCPathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCPathEN GetObjByGcPathIdFromList(string strGcPathId, List<clsGCPathEN> lstGCPathObjLst)
{
foreach (clsGCPathEN objGCPathEN in lstGCPathObjLst)
{
if (objGCPathEN.GcPathId == strGcPathId)
{
return objGCPathEN;
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
 string strMaxGcPathId;
 try
 {
 strMaxGcPathId = clsGCPathDA.GetMaxStrId();
 return strMaxGcPathId;
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
 string strGcPathId;
 try
 {
 strGcPathId = new clsGCPathDA().GetFirstID(strWhereCond);
 return strGcPathId;
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
 arrList = GCPathDA.GetID(strWhereCond);
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
bool bolIsExist = GCPathDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strGcPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strGcPathId)
{
if (string.IsNullOrEmpty(strGcPathId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strGcPathId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCPathDA.IsExist(strGcPathId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strGcPathId">GC路径Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strGcPathId, string strOpUser)
{
clsGCPathEN objGCPathEN = clsGCPathBL.GetObjByGcPathId(strGcPathId);
objGCPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCPathEN.UpdUser = strOpUser;
return clsGCPathBL.UpdateBySql2(objGCPathEN);
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
 bolIsExist = clsGCPathDA.IsExistTable();
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
 bolIsExist = GCPathDA.IsExistTable(strTabName);
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!GC路径名 = [{0}],是否For主目录 = [{1}],用户Id = [{2}],工程Id = [{3}]的数据已经存在!(in clsGCPathBL.AddNewRecordBySql2)", objGCPathEN.GcPathName,objGCPathEN.IsForMainPath,objGCPathEN.UserId,objGCPathEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
bool bolResult = GCPathDA.AddNewRecordBySQL2(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCPathEN objGCPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!GC路径名 = [{0}],是否For主目录 = [{1}],用户Id = [{2}],工程Id = [{3}]的数据已经存在!(in clsGCPathBL.AddNewRecordBySql2WithReturnKey)", objGCPathEN.GcPathName,objGCPathEN.IsForMainPath,objGCPathEN.UserId,objGCPathEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true || clsGCPathBL.IsExist(objGCPathEN.GcPathId) == true)
 {
     objGCPathEN.GcPathId = clsGCPathBL.GetMaxStrId_S();
 }
string strKey = GCPathDA.AddNewRecordBySQL2WithReturnKey(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCPathEN objGCPathEN)
{
try
{
bool bolResult = GCPathDA.Update(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "objGCPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCPathEN objGCPathEN)
{
 if (string.IsNullOrEmpty(objGCPathEN.GcPathId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCPathDA.UpdateBySql2(objGCPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCPathBL.ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
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
 /// <param name = "strGcPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strGcPathId)
{
try
{
 clsGCPathEN objGCPathEN = clsGCPathBL.GetObjByGcPathId(strGcPathId);

if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(objGCPathEN.GcPathId, objGCPathEN.UpdUser);
}
if (objGCPathEN != null)
{
int intRecNum = GCPathDA.DelRecord(strGcPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);
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
/// <param name="strGcPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strGcPathId , string strPrjId, string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCPathDA.GetSpecSQLObj();
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
//删除与表:[GCPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCPath.GcPathId,
//strGcPathId);
//        clsGCPathBL.DelGCPathsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCPathBL.DelRecord(strGcPathId, strPrjId, strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGcPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strGcPathId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strGcPathId, string strPrjId, string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCPathBL.relatedActions != null)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(strGcPathId, "UpdRelaTabDate");
}
bool bolResult = GCPathDA.DelRecord(strGcPathId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId, strUserId);
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
 /// <param name = "arrGcPathIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCPaths(List<string> arrGcPathIdLst)
{
if (arrGcPathIdLst.Count == 0) return 0;
try
{
if (clsGCPathBL.relatedActions != null)
{
foreach (var strGcPathId in arrGcPathIdLst)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(strGcPathId, "UpdRelaTabDate");
}
}
 clsGCPathEN objGCPathEN = clsGCPathBL.GetObjByGcPathId(arrGcPathIdLst[0]);
int intDelRecNum = GCPathDA.DelGCPath(arrGcPathIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objGCPathEN.PrjId, objGCPathEN.UserId);
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
public static int DelGCPathsByCond(string strWhereCond)
{
try
{
if (clsGCPathBL.relatedActions != null)
{
List<string> arrGcPathId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strGcPathId in arrGcPathId)
{
clsGCPathBL.relatedActions.UpdRelaTabDate(strGcPathId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conGCPath.PrjId, strWhereCond);
List<string> arrUserId = GetFldValue(conGCPath.UserId, strWhereCond);
int intRecNum = GCPathDA.DelGCPath(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
foreach (var x in arrPrjId)
{
foreach (var y in arrUserId)
{
              ReFreshCache(x, y);
}
}
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCPath]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strGcPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strGcPathId, string strPrjId, string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCPathDA.GetSpecSQLObj();
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
//删除与表:[GCPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCPathBL.DelRecord(strGcPathId, strPrjId, strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCPathBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGcPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCPathENS">源对象</param>
 /// <param name = "objGCPathENT">目标对象</param>
 public static void CopyTo(clsGCPathEN objGCPathENS, clsGCPathEN objGCPathENT)
{
try
{
objGCPathENT.GcPathId = objGCPathENS.GcPathId; //GC路径Id
objGCPathENT.GcPathName = objGCPathENS.GcPathName; //GC路径名
objGCPathENT.IsForMainPath = objGCPathENS.IsForMainPath; //是否For主目录
objGCPathENT.UserId = objGCPathENS.UserId; //用户Id
objGCPathENT.PrjId = objGCPathENS.PrjId; //工程Id
objGCPathENT.UpdDate = objGCPathENS.UpdDate; //修改日期
objGCPathENT.UpdUser = objGCPathENS.UpdUser; //修改者
objGCPathENT.Memo = objGCPathENS.Memo; //说明
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
 /// <param name = "objGCPathEN">源简化对象</param>
 public static void SetUpdFlag(clsGCPathEN objGCPathEN)
{
try
{
objGCPathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCPathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCPath.GcPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.GcPathId = objGCPathEN.GcPathId; //GC路径Id
}
if (arrFldSet.Contains(conGCPath.GcPathName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.GcPathName = objGCPathEN.GcPathName; //GC路径名
}
if (arrFldSet.Contains(conGCPath.IsForMainPath, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.IsForMainPath = objGCPathEN.IsForMainPath; //是否For主目录
}
if (arrFldSet.Contains(conGCPath.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.UserId = objGCPathEN.UserId; //用户Id
}
if (arrFldSet.Contains(conGCPath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.PrjId = objGCPathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conGCPath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.UpdDate = objGCPathEN.UpdDate == "[null]" ? null :  objGCPathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCPath.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.UpdUser = objGCPathEN.UpdUser == "[null]" ? null :  objGCPathEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCPath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCPathEN.Memo = objGCPathEN.Memo == "[null]" ? null :  objGCPathEN.Memo; //说明
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
 /// <param name = "objGCPathEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCPathEN objGCPathEN)
{
try
{
if (objGCPathEN.UpdDate == "[null]") objGCPathEN.UpdDate = null; //修改日期
if (objGCPathEN.UpdUser == "[null]") objGCPathEN.UpdUser = null; //修改者
if (objGCPathEN.Memo == "[null]") objGCPathEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCPathEN objGCPathEN)
{
 GCPathDA.CheckPropertyNew(objGCPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCPathEN objGCPathEN)
{
 GCPathDA.CheckProperty4Condition(objGCPathEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
 /// <param name = "strUserId"></param>
public static void BindCbo_GcPathId(System.Windows.Forms.ComboBox objComboBox , string strPrjId,string strUserId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCPath.GcPathId); 
List<clsGCPathEN> arrObjLst = clsGCPathBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId&& x.UserId == strUserId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCPathEN objGCPathEN = new clsGCPathEN()
{
GcPathId = "0",
GcPathName = "选[GC路径]..."
};
arrObjLstSel.Insert(0, objGCPathEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCPath.GcPathId;
objComboBox.DisplayMember = conGCPath.GcPathName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
 /// <param name = "strUserId"></param>
public static void BindDdl_GcPathId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId,string strUserId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC路径]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conGCPath.GcPathId); 
IEnumerable<clsGCPathEN> arrObjLst = clsGCPathBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId&& x.UserId == strUserId).ToList();
objDDL.DataValueField = conGCPath.GcPathId;
objDDL.DataTextField = conGCPath.GcPathName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_GcPathIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strUserId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC路径]...","0");
List<clsGCPathEN> arrGCPathObjLst = GetAllGCPathObjLstCache(strPrjId, strUserId); 
objDDL.DataValueField = conGCPath.GcPathId;
objDDL.DataTextField = conGCPath.GcPathName;
objDDL.DataSource = arrGCPathObjLst;
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
if (clsGCPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCPathBL没有刷新缓存机制(clsGCPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by GcPathId");
//if (arrGCPathObjLstCache == null)
//{
//arrGCPathObjLstCache = GCPathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strGcPathId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCPathEN GetObjByGcPathIdCache(string strGcPathId, string strPrjId, string strUserId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}_{2}", clsGCPathEN._CurrTabName, strPrjId, strUserId);
List<clsGCPathEN> arrGCPathObjLstCache = GetObjLstCache(strPrjId, strUserId);
IEnumerable <clsGCPathEN> arrGCPathObjLst_Sel =
arrGCPathObjLstCache
.Where(x=> x.GcPathId == strGcPathId 
);
if (arrGCPathObjLst_Sel.Count() == 0)
{
   clsGCPathEN obj = clsGCPathBL.GetObjByGcPathId(strGcPathId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strGcPathId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrGCPathObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGcPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGcPathNameByGcPathIdCache(string strGcPathId, string strPrjId, string strUserId)
{
if (string.IsNullOrEmpty(strGcPathId) == true) return "";
//获取缓存中的对象列表
clsGCPathEN objGCPath = GetObjByGcPathIdCache(strGcPathId, strPrjId, strUserId);
if (objGCPath == null) return "";
return objGCPath.GcPathName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGcPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByGcPathIdCache(string strGcPathId, string strPrjId, string strUserId)
{
if (string.IsNullOrEmpty(strGcPathId) == true) return "";
//获取缓存中的对象列表
clsGCPathEN objGCPath = GetObjByGcPathIdCache(strGcPathId, strPrjId, strUserId);
if (objGCPath == null) return "";
return objGCPath.GcPathName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCPathEN> GetAllGCPathObjLstCache(string strPrjId, string strUserId)
{
//获取缓存中的对象列表
List<clsGCPathEN> arrGCPathObjLstCache = GetObjLstCache(strPrjId, strUserId); 
return arrGCPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCPathEN> GetObjLstCache(string strPrjId, string strUserId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}_{2}", clsGCPathEN._CurrTabName, strPrjId, strUserId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
strCondition += string.Format(" and UserId='{0}'", strUserId); 
List<clsGCPathEN> arrGCPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition);});
return arrGCPathObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId, string strUserId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}_{2}", clsGCPathEN._CurrTabName, strPrjId, strUserId);
CacheHelper.Remove(strKey);
clsGCPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCPathEN._RefreshTimeLst.Count == 0) return "";
return clsGCPathEN._RefreshTimeLst[clsGCPathEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId,string strUserId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsGCPathBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsGCPathBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsGCPathBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (clsGCPathBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}_{2}", clsGCPathEN._CurrTabName, strPrjId, strUserId);
CacheHelper.Remove(strKey);
clsGCPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCPathBL.objCommFun4BL.ReFreshCache(strPrjId, strUserId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCPath(GC路径)
 /// 唯一性条件:GCPathName_IsForMainPath_UserId_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCPathEN objGCPathEN)
{
//检测记录是否存在
string strResult = GCPathDA.GetUniCondStr(objGCPathEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strGcPathId, string strPrjId, string strUserId)
{
if (strInFldName != conGCPath.GcPathId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCPath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCPath._AttributeName));
throw new Exception(strMsg);
}
var objGCPath = clsGCPathBL.GetObjByGcPathIdCache(strGcPathId, strPrjId, strUserId);
if (objGCPath == null) return "";
return objGCPath[strOutFldName].ToString();
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
int intRecCount = clsGCPathDA.GetRecCount(strTabName);
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
int intRecCount = clsGCPathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCPathDA.GetRecCount();
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
int intRecCount = clsGCPathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCPathEN objGCPathCond)
{
 string strPrjId = objGCPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsGCPathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
 string strUserId = objGCPathCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000176)在表中,缓存分类字段值2不能为空!(clsGCPathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsGCPathEN> arrObjLstCache = GetObjLstCache(strPrjId, strUserId);
IEnumerable <clsGCPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCPath._AttributeName)
{
if (objGCPathCond.IsUpdated(strFldName) == false) continue;
if (objGCPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCPathCond[strFldName].ToString());
}
else
{
if (objGCPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCPathCond[strFldName]));
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
 List<string> arrList = clsGCPathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCPathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCPathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCPathDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCPathDA.SetFldValue(clsGCPathEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCPathDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCPathDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCPathDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCPathDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCPath] "); 
 strCreateTabCode.Append(" ( "); 
 // /**GC路径Id*/ 
 strCreateTabCode.Append(" GcPathId char(8) primary key, "); 
 // /**GC路径名*/ 
 strCreateTabCode.Append(" GcPathName varchar(150) not Null, "); 
 // /**是否For主目录*/ 
 strCreateTabCode.Append(" IsForMainPath bit not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
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
 /// GC路径(GCPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCPath : clsCommFun4BLV3
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId,string strUserId)
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
clsGCPathBL.ReFreshThisCache(strPrjId, strUserId);
}
}

}