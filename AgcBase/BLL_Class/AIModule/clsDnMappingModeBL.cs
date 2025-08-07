
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnMappingModeBL
 表名:DnMappingMode(00050571)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsDnMappingModeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMappingModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnMappingModeEN GetObj(this K_MappingModeId_DnMappingMode myKey)
{
clsDnMappingModeEN objDnMappingModeEN = clsDnMappingModeBL.DnMappingModeDA.GetObjByMappingModeId(myKey.Value);
return objDnMappingModeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnMappingModeEN) == false)
{
var strMsg = string.Format("记录已经存在!映射模式名 = [{0}]的数据已经存在!(in clsDnMappingModeBL.AddNewRecord)", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
bool bolResult = clsDnMappingModeBL.DnMappingModeDA.AddNewRecordBySQL2(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
public static bool AddRecordEx(this clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDnMappingModeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDnMappingModeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(映射模式名(MappingModeName)=[{0}])已经存在,不能重复!", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDnMappingModeEN.AddNewRecord();
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnMappingModeEN) == false)
{
var strMsg = string.Format("记录已经存在!映射模式名 = [{0}]的数据已经存在!(in clsDnMappingModeBL.AddNewRecordWithMaxId)", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
string strMappingModeId = clsDnMappingModeBL.DnMappingModeDA.AddNewRecordBySQL2WithReturnKey(objDnMappingModeEN);
     objDnMappingModeEN.MappingModeId = strMappingModeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
}
return strMappingModeId;
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnMappingModeEN) == false)
{
var strMsg = string.Format("记录已经存在!映射模式名 = [{0}]的数据已经存在!(in clsDnMappingModeBL.AddNewRecordWithReturnKey)", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
string strKey = clsDnMappingModeBL.DnMappingModeDA.AddNewRecordBySQL2WithReturnKey(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetMappingModeId(this clsDnMappingModeEN objDnMappingModeEN, string strMappingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMappingModeId, 2, conDnMappingMode.MappingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMappingModeId, 2, conDnMappingMode.MappingModeId);
}
objDnMappingModeEN.MappingModeId = strMappingModeId; //映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.MappingModeId) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.MappingModeId, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.MappingModeId] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetMappingModeName(this clsDnMappingModeEN objDnMappingModeEN, string strMappingModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMappingModeName, 50, conDnMappingMode.MappingModeName);
}
objDnMappingModeEN.MappingModeName = strMappingModeName; //映射模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.MappingModeName) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.MappingModeName, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.MappingModeName] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetMappingModeENName(this clsDnMappingModeEN objDnMappingModeEN, string strMappingModeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMappingModeENName, 50, conDnMappingMode.MappingModeENName);
}
objDnMappingModeEN.MappingModeENName = strMappingModeENName; //映射模式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.MappingModeENName) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.MappingModeENName, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.MappingModeENName] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetUpdDate(this clsDnMappingModeEN objDnMappingModeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnMappingMode.UpdDate);
}
objDnMappingModeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.UpdDate) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.UpdDate, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.UpdDate] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetUpdUser(this clsDnMappingModeEN objDnMappingModeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnMappingMode.UpdUser);
}
objDnMappingModeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.UpdUser) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.UpdUser, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.UpdUser] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnMappingModeEN SetMemo(this clsDnMappingModeEN objDnMappingModeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnMappingMode.Memo);
}
objDnMappingModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnMappingModeEN.dicFldComparisonOp.ContainsKey(conDnMappingMode.Memo) == false)
{
objDnMappingModeEN.dicFldComparisonOp.Add(conDnMappingMode.Memo, strComparisonOp);
}
else
{
objDnMappingModeEN.dicFldComparisonOp[conDnMappingMode.Memo] = strComparisonOp;
}
}
return objDnMappingModeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDnMappingModeEN objDnMappingModeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDnMappingModeEN.CheckPropertyNew();
clsDnMappingModeEN objDnMappingModeCond = new clsDnMappingModeEN();
string strCondition = objDnMappingModeCond
.SetMappingModeId(objDnMappingModeEN.MappingModeId, "<>")
.SetMappingModeName(objDnMappingModeEN.MappingModeName, "=")
.GetCombineCondition();
objDnMappingModeEN._IsCheckProperty = true;
bool bolIsExist = clsDnMappingModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MappingModeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDnMappingModeEN.Update();
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
 /// <param name = "objDnMappingMode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDnMappingModeEN objDnMappingMode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDnMappingModeEN objDnMappingModeCond = new clsDnMappingModeEN();
string strCondition = objDnMappingModeCond
.SetMappingModeName(objDnMappingMode.MappingModeName, "=")
.GetCombineCondition();
objDnMappingMode._IsCheckProperty = true;
bool bolIsExist = clsDnMappingModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDnMappingMode.MappingModeId = clsDnMappingModeBL.GetFirstID_S(strCondition);
objDnMappingMode.UpdateWithCondition(strCondition);
}
else
{
objDnMappingMode.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
objDnMappingMode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnMappingModeEN objDnMappingModeEN)
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnMappingModeBL.DnMappingModeDA.UpdateBySql2(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnMappingModeEN objDnMappingModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnMappingModeBL.DnMappingModeDA.UpdateBySql2(objDnMappingModeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnMappingModeEN objDnMappingModeEN, string strWhereCond)
{
try
{
bool bolResult = clsDnMappingModeBL.DnMappingModeDA.UpdateBySqlWithCondition(objDnMappingModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnMappingModeEN objDnMappingModeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDnMappingModeBL.DnMappingModeDA.UpdateBySqlWithConditionTransaction(objDnMappingModeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDnMappingModeEN objDnMappingModeEN)
{
try
{
int intRecNum = clsDnMappingModeBL.DnMappingModeDA.DelRecord(objDnMappingModeEN.MappingModeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <param name = "objDnMappingModeENT">目标对象</param>
 public static void CopyTo(this clsDnMappingModeEN objDnMappingModeENS, clsDnMappingModeEN objDnMappingModeENT)
{
try
{
objDnMappingModeENT.MappingModeId = objDnMappingModeENS.MappingModeId; //映射模式Id
objDnMappingModeENT.MappingModeName = objDnMappingModeENS.MappingModeName; //映射模式名
objDnMappingModeENT.MappingModeENName = objDnMappingModeENS.MappingModeENName; //映射模式英文名
objDnMappingModeENT.UpdDate = objDnMappingModeENS.UpdDate; //修改日期
objDnMappingModeENT.UpdUser = objDnMappingModeENS.UpdUser; //修改者
objDnMappingModeENT.Memo = objDnMappingModeENS.Memo; //说明
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
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <returns>目标对象=>clsDnMappingModeEN:objDnMappingModeENT</returns>
 public static clsDnMappingModeEN CopyTo(this clsDnMappingModeEN objDnMappingModeENS)
{
try
{
 clsDnMappingModeEN objDnMappingModeENT = new clsDnMappingModeEN()
{
MappingModeId = objDnMappingModeENS.MappingModeId, //映射模式Id
MappingModeName = objDnMappingModeENS.MappingModeName, //映射模式名
MappingModeENName = objDnMappingModeENS.MappingModeENName, //映射模式英文名
UpdDate = objDnMappingModeENS.UpdDate, //修改日期
UpdUser = objDnMappingModeENS.UpdUser, //修改者
Memo = objDnMappingModeENS.Memo, //说明
};
 return objDnMappingModeENT;
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
public static void CheckPropertyNew(this clsDnMappingModeEN objDnMappingModeEN)
{
 clsDnMappingModeBL.DnMappingModeDA.CheckPropertyNew(objDnMappingModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDnMappingModeEN objDnMappingModeEN)
{
 clsDnMappingModeBL.DnMappingModeDA.CheckProperty4Condition(objDnMappingModeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnMappingModeEN objDnMappingModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.MappingModeId) == true)
{
string strComparisonOpMappingModeId = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.MappingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.MappingModeId, objDnMappingModeCond.MappingModeId, strComparisonOpMappingModeId);
}
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.MappingModeName) == true)
{
string strComparisonOpMappingModeName = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.MappingModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.MappingModeName, objDnMappingModeCond.MappingModeName, strComparisonOpMappingModeName);
}
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.MappingModeENName) == true)
{
string strComparisonOpMappingModeENName = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.MappingModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.MappingModeENName, objDnMappingModeCond.MappingModeENName, strComparisonOpMappingModeENName);
}
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.UpdDate, objDnMappingModeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.UpdUser, objDnMappingModeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnMappingModeCond.IsUpdated(conDnMappingMode.Memo) == true)
{
string strComparisonOpMemo = objDnMappingModeCond.dicFldComparisonOp[conDnMappingMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnMappingMode.Memo, objDnMappingModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DnMappingMode(结点映射模式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MappingModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDnMappingModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDnMappingModeEN objDnMappingModeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDnMappingModeEN == null) return true;
if (objDnMappingModeEN.MappingModeId == null || objDnMappingModeEN.MappingModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDnMappingModeEN.MappingModeName == null)
{
 sbCondition.AppendFormat(" and MappingModeName is null", objDnMappingModeEN.MappingModeName);
}
else
{
 sbCondition.AppendFormat(" and MappingModeName = '{0}'", objDnMappingModeEN.MappingModeName);
}
if (clsDnMappingModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MappingModeId !=  '{0}'", objDnMappingModeEN.MappingModeId);
 sbCondition.AppendFormat(" and MappingModeName = '{0}'", objDnMappingModeEN.MappingModeName);
if (clsDnMappingModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DnMappingMode(结点映射模式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MappingModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnMappingModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDnMappingModeEN objDnMappingModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnMappingModeEN == null) return "";
if (objDnMappingModeEN.MappingModeId == null || objDnMappingModeEN.MappingModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objDnMappingModeEN.MappingModeName == null)
{
 sbCondition.AppendFormat(" and MappingModeName is null", objDnMappingModeEN.MappingModeName);
}
else
{
 sbCondition.AppendFormat(" and MappingModeName = '{0}'", objDnMappingModeEN.MappingModeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MappingModeId !=  '{0}'", objDnMappingModeEN.MappingModeId);
 sbCondition.AppendFormat(" and MappingModeName = '{0}'", objDnMappingModeEN.MappingModeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DnMappingMode
{
public virtual bool UpdRelaTabDate(string strMappingModeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumDnMappingMode
{
}
 /// <summary>
 /// 结点映射模式(DnMappingMode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDnMappingModeBL
{
public static RelatedActions_DnMappingMode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDnMappingModeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDnMappingModeDA DnMappingModeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDnMappingModeDA();
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
 public clsDnMappingModeBL()
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
if (string.IsNullOrEmpty(clsDnMappingModeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnMappingModeEN._ConnectString);
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
public static DataTable GetDataTable_DnMappingMode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DnMappingModeDA.GetDataTable_DnMappingMode(strWhereCond);
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
objDT = DnMappingModeDA.GetDataTable(strWhereCond);
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
objDT = DnMappingModeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DnMappingModeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DnMappingModeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DnMappingModeDA.GetDataTable_Top(objTopPara);
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
objDT = DnMappingModeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DnMappingModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DnMappingModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMappingModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDnMappingModeEN> GetObjLstByMappingModeIdLst(List<string> arrMappingModeIdLst)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMappingModeIdLst, true);
 string strWhereCond = string.Format("MappingModeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMappingModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDnMappingModeEN> GetObjLstByMappingModeIdLstCache(List<string> arrMappingModeIdLst)
{
string strKey = string.Format("{0}", clsDnMappingModeEN._CurrTabName);
List<clsDnMappingModeEN> arrDnMappingModeObjLstCache = GetObjLstCache();
IEnumerable <clsDnMappingModeEN> arrDnMappingModeObjLst_Sel =
arrDnMappingModeObjLstCache
.Where(x => arrMappingModeIdLst.Contains(x.MappingModeId));
return arrDnMappingModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnMappingModeEN> GetObjLst(string strWhereCond)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
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
public static List<clsDnMappingModeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDnMappingModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDnMappingModeEN> GetSubObjLstCache(clsDnMappingModeEN objDnMappingModeCond)
{
List<clsDnMappingModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDnMappingModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnMappingMode._AttributeName)
{
if (objDnMappingModeCond.IsUpdated(strFldName) == false) continue;
if (objDnMappingModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnMappingModeCond[strFldName].ToString());
}
else
{
if (objDnMappingModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnMappingModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnMappingModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnMappingModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnMappingModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnMappingModeCond[strFldName]));
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
public static List<clsDnMappingModeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
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
public static List<clsDnMappingModeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
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
List<clsDnMappingModeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDnMappingModeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnMappingModeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDnMappingModeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
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
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
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
public static List<clsDnMappingModeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDnMappingModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDnMappingModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
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
public static List<clsDnMappingModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnMappingModeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDnMappingModeEN> arrObjLst = new List<clsDnMappingModeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN();
try
{
objDnMappingModeEN.MappingModeId = objRow[conDnMappingMode.MappingModeId].ToString().Trim(); //映射模式Id
objDnMappingModeEN.MappingModeName = objRow[conDnMappingMode.MappingModeName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeName].ToString().Trim(); //映射模式名
objDnMappingModeEN.MappingModeENName = objRow[conDnMappingMode.MappingModeENName] == DBNull.Value ? null : objRow[conDnMappingMode.MappingModeENName].ToString().Trim(); //映射模式英文名
objDnMappingModeEN.UpdDate = objRow[conDnMappingMode.UpdDate] == DBNull.Value ? null : objRow[conDnMappingMode.UpdDate].ToString().Trim(); //修改日期
objDnMappingModeEN.UpdUser = objRow[conDnMappingMode.UpdUser] == DBNull.Value ? null : objRow[conDnMappingMode.UpdUser].ToString().Trim(); //修改者
objDnMappingModeEN.Memo = objRow[conDnMappingMode.Memo] == DBNull.Value ? null : objRow[conDnMappingMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnMappingModeEN.MappingModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnMappingModeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDnMappingModeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDnMappingMode(ref clsDnMappingModeEN objDnMappingModeEN)
{
bool bolResult = DnMappingModeDA.GetDnMappingMode(ref objDnMappingModeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMappingModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnMappingModeEN GetObjByMappingModeId(string strMappingModeId)
{
if (strMappingModeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMappingModeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMappingModeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMappingModeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDnMappingModeEN objDnMappingModeEN = DnMappingModeDA.GetObjByMappingModeId(strMappingModeId);
return objDnMappingModeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDnMappingModeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDnMappingModeEN objDnMappingModeEN = DnMappingModeDA.GetFirstObj(strWhereCond);
 return objDnMappingModeEN;
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
public static clsDnMappingModeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDnMappingModeEN objDnMappingModeEN = DnMappingModeDA.GetObjByDataRow(objRow);
 return objDnMappingModeEN;
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
public static clsDnMappingModeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDnMappingModeEN objDnMappingModeEN = DnMappingModeDA.GetObjByDataRow(objRow);
 return objDnMappingModeEN;
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
 /// <param name = "strMappingModeId">所给的关键字</param>
 /// <param name = "lstDnMappingModeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnMappingModeEN GetObjByMappingModeIdFromList(string strMappingModeId, List<clsDnMappingModeEN> lstDnMappingModeObjLst)
{
foreach (clsDnMappingModeEN objDnMappingModeEN in lstDnMappingModeObjLst)
{
if (objDnMappingModeEN.MappingModeId == strMappingModeId)
{
return objDnMappingModeEN;
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
 string strMaxMappingModeId;
 try
 {
 strMaxMappingModeId = clsDnMappingModeDA.GetMaxStrId();
 return strMaxMappingModeId;
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
 string strMappingModeId;
 try
 {
 strMappingModeId = new clsDnMappingModeDA().GetFirstID(strWhereCond);
 return strMappingModeId;
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
 arrList = DnMappingModeDA.GetID(strWhereCond);
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
bool bolIsExist = DnMappingModeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMappingModeId)
{
if (string.IsNullOrEmpty(strMappingModeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMappingModeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DnMappingModeDA.IsExist(strMappingModeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strMappingModeId">映射模式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strMappingModeId, string strOpUser)
{
clsDnMappingModeEN objDnMappingModeEN = clsDnMappingModeBL.GetObjByMappingModeId(strMappingModeId);
objDnMappingModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDnMappingModeEN.UpdUser = strOpUser;
return clsDnMappingModeBL.UpdateBySql2(objDnMappingModeEN);
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
 bolIsExist = clsDnMappingModeDA.IsExistTable();
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
 bolIsExist = DnMappingModeDA.IsExistTable(strTabName);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnMappingModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!映射模式名 = [{0}]的数据已经存在!(in clsDnMappingModeBL.AddNewRecordBySql2)", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
bool bolResult = DnMappingModeDA.AddNewRecordBySQL2(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDnMappingModeEN objDnMappingModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnMappingModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!映射模式名 = [{0}]的数据已经存在!(in clsDnMappingModeBL.AddNewRecordBySql2WithReturnKey)", objDnMappingModeEN.MappingModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true || clsDnMappingModeBL.IsExist(objDnMappingModeEN.MappingModeId) == true)
 {
     objDnMappingModeEN.MappingModeId = clsDnMappingModeBL.GetMaxStrId_S();
 }
string strKey = DnMappingModeDA.AddNewRecordBySQL2WithReturnKey(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDnMappingModeEN objDnMappingModeEN)
{
try
{
bool bolResult = DnMappingModeDA.Update(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "objDnMappingModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDnMappingModeEN objDnMappingModeEN)
{
 if (string.IsNullOrEmpty(objDnMappingModeEN.MappingModeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DnMappingModeDA.UpdateBySql2(objDnMappingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnMappingModeBL.ReFreshCache();

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
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
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strMappingModeId)
{
try
{
 clsDnMappingModeEN objDnMappingModeEN = clsDnMappingModeBL.GetObjByMappingModeId(strMappingModeId);

if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(objDnMappingModeEN.MappingModeId, objDnMappingModeEN.UpdUser);
}
if (objDnMappingModeEN != null)
{
int intRecNum = DnMappingModeDA.DelRecord(strMappingModeId);
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
/// <param name="strMappingModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strMappingModeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
//删除与表:[DnMappingMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDnMappingMode.MappingModeId,
//strMappingModeId);
//        clsDnMappingModeBL.DelDnMappingModesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnMappingModeBL.DelRecord(strMappingModeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnMappingModeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMappingModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strMappingModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strMappingModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDnMappingModeBL.relatedActions != null)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(strMappingModeId, "UpdRelaTabDate");
}
bool bolResult = DnMappingModeDA.DelRecord(strMappingModeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrMappingModeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDnMappingModes(List<string> arrMappingModeIdLst)
{
if (arrMappingModeIdLst.Count == 0) return 0;
try
{
if (clsDnMappingModeBL.relatedActions != null)
{
foreach (var strMappingModeId in arrMappingModeIdLst)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(strMappingModeId, "UpdRelaTabDate");
}
}
int intDelRecNum = DnMappingModeDA.DelDnMappingMode(arrMappingModeIdLst);
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
public static int DelDnMappingModesByCond(string strWhereCond)
{
try
{
if (clsDnMappingModeBL.relatedActions != null)
{
List<string> arrMappingModeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMappingModeId in arrMappingModeId)
{
clsDnMappingModeBL.relatedActions.UpdRelaTabDate(strMappingModeId, "UpdRelaTabDate");
}
}
int intRecNum = DnMappingModeDA.DelDnMappingMode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DnMappingMode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strMappingModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strMappingModeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnMappingModeDA.GetSpecSQLObj();
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
//删除与表:[DnMappingMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnMappingModeBL.DelRecord(strMappingModeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnMappingModeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMappingModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDnMappingModeENS">源对象</param>
 /// <param name = "objDnMappingModeENT">目标对象</param>
 public static void CopyTo(clsDnMappingModeEN objDnMappingModeENS, clsDnMappingModeEN objDnMappingModeENT)
{
try
{
objDnMappingModeENT.MappingModeId = objDnMappingModeENS.MappingModeId; //映射模式Id
objDnMappingModeENT.MappingModeName = objDnMappingModeENS.MappingModeName; //映射模式名
objDnMappingModeENT.MappingModeENName = objDnMappingModeENS.MappingModeENName; //映射模式英文名
objDnMappingModeENT.UpdDate = objDnMappingModeENS.UpdDate; //修改日期
objDnMappingModeENT.UpdUser = objDnMappingModeENS.UpdUser; //修改者
objDnMappingModeENT.Memo = objDnMappingModeENS.Memo; //说明
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
 /// <param name = "objDnMappingModeEN">源简化对象</param>
 public static void SetUpdFlag(clsDnMappingModeEN objDnMappingModeEN)
{
try
{
objDnMappingModeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDnMappingModeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDnMappingMode.MappingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.MappingModeId = objDnMappingModeEN.MappingModeId; //映射模式Id
}
if (arrFldSet.Contains(conDnMappingMode.MappingModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.MappingModeName = objDnMappingModeEN.MappingModeName == "[null]" ? null :  objDnMappingModeEN.MappingModeName; //映射模式名
}
if (arrFldSet.Contains(conDnMappingMode.MappingModeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.MappingModeENName = objDnMappingModeEN.MappingModeENName == "[null]" ? null :  objDnMappingModeEN.MappingModeENName; //映射模式英文名
}
if (arrFldSet.Contains(conDnMappingMode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.UpdDate = objDnMappingModeEN.UpdDate == "[null]" ? null :  objDnMappingModeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDnMappingMode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.UpdUser = objDnMappingModeEN.UpdUser == "[null]" ? null :  objDnMappingModeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDnMappingMode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDnMappingModeEN.Memo = objDnMappingModeEN.Memo == "[null]" ? null :  objDnMappingModeEN.Memo; //说明
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
 /// <param name = "objDnMappingModeEN">源简化对象</param>
 public static void AccessFldValueNull(clsDnMappingModeEN objDnMappingModeEN)
{
try
{
if (objDnMappingModeEN.MappingModeName == "[null]") objDnMappingModeEN.MappingModeName = null; //映射模式名
if (objDnMappingModeEN.MappingModeENName == "[null]") objDnMappingModeEN.MappingModeENName = null; //映射模式英文名
if (objDnMappingModeEN.UpdDate == "[null]") objDnMappingModeEN.UpdDate = null; //修改日期
if (objDnMappingModeEN.UpdUser == "[null]") objDnMappingModeEN.UpdUser = null; //修改者
if (objDnMappingModeEN.Memo == "[null]") objDnMappingModeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDnMappingModeEN objDnMappingModeEN)
{
 DnMappingModeDA.CheckPropertyNew(objDnMappingModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDnMappingModeEN objDnMappingModeEN)
{
 DnMappingModeDA.CheckProperty4Condition(objDnMappingModeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_MappingModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDnMappingMode.MappingModeId); 
List<clsDnMappingModeEN> arrObjLst = clsDnMappingModeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDnMappingModeEN objDnMappingModeEN = new clsDnMappingModeEN()
{
MappingModeId = "0",
MappingModeName = "选[结点映射模式]..."
};
arrObjLst.Insert(0, objDnMappingModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDnMappingMode.MappingModeId;
objComboBox.DisplayMember = conDnMappingMode.MappingModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_MappingModeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结点映射模式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDnMappingMode.MappingModeId); 
IEnumerable<clsDnMappingModeEN> arrObjLst = clsDnMappingModeBL.GetObjLst(strCondition);
objDDL.DataValueField = conDnMappingMode.MappingModeId;
objDDL.DataTextField = conDnMappingMode.MappingModeName;
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
public static void BindDdl_MappingModeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[结点映射模式]...","0");
List<clsDnMappingModeEN> arrDnMappingModeObjLst = GetAllDnMappingModeObjLstCache(); 
objDDL.DataValueField = conDnMappingMode.MappingModeId;
objDDL.DataTextField = conDnMappingMode.MappingModeName;
objDDL.DataSource = arrDnMappingModeObjLst;
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
if (clsDnMappingModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnMappingModeBL没有刷新缓存机制(clsDnMappingModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MappingModeId");
//if (arrDnMappingModeObjLstCache == null)
//{
//arrDnMappingModeObjLstCache = DnMappingModeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMappingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnMappingModeEN GetObjByMappingModeIdCache(string strMappingModeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDnMappingModeEN._CurrTabName);
List<clsDnMappingModeEN> arrDnMappingModeObjLstCache = GetObjLstCache();
IEnumerable <clsDnMappingModeEN> arrDnMappingModeObjLst_Sel =
arrDnMappingModeObjLstCache
.Where(x=> x.MappingModeId == strMappingModeId 
);
if (arrDnMappingModeObjLst_Sel.Count() == 0)
{
   clsDnMappingModeEN obj = clsDnMappingModeBL.GetObjByMappingModeId(strMappingModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDnMappingModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMappingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMappingModeNameByMappingModeIdCache(string strMappingModeId)
{
if (string.IsNullOrEmpty(strMappingModeId) == true) return "";
//获取缓存中的对象列表
clsDnMappingModeEN objDnMappingMode = GetObjByMappingModeIdCache(strMappingModeId);
if (objDnMappingMode == null) return "";
return objDnMappingMode.MappingModeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMappingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMappingModeIdCache(string strMappingModeId)
{
if (string.IsNullOrEmpty(strMappingModeId) == true) return "";
//获取缓存中的对象列表
clsDnMappingModeEN objDnMappingMode = GetObjByMappingModeIdCache(strMappingModeId);
if (objDnMappingMode == null) return "";
return objDnMappingMode.MappingModeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnMappingModeEN> GetAllDnMappingModeObjLstCache()
{
//获取缓存中的对象列表
List<clsDnMappingModeEN> arrDnMappingModeObjLstCache = GetObjLstCache(); 
return arrDnMappingModeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnMappingModeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDnMappingModeEN._CurrTabName);
List<clsDnMappingModeEN> arrDnMappingModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDnMappingModeObjLstCache;
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
string strKey = string.Format("{0}", clsDnMappingModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDnMappingModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDnMappingModeEN._RefreshTimeLst.Count == 0) return "";
return clsDnMappingModeEN._RefreshTimeLst[clsDnMappingModeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDnMappingModeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDnMappingModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDnMappingModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDnMappingModeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DnMappingMode(结点映射模式)
 /// 唯一性条件:MappingModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnMappingModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDnMappingModeEN objDnMappingModeEN)
{
//检测记录是否存在
string strResult = DnMappingModeDA.GetUniCondStr(objDnMappingModeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMappingModeId)
{
if (strInFldName != conDnMappingMode.MappingModeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDnMappingMode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDnMappingMode._AttributeName));
throw new Exception(strMsg);
}
var objDnMappingMode = clsDnMappingModeBL.GetObjByMappingModeIdCache(strMappingModeId);
if (objDnMappingMode == null) return "";
return objDnMappingMode[strOutFldName].ToString();
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
int intRecCount = clsDnMappingModeDA.GetRecCount(strTabName);
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
int intRecCount = clsDnMappingModeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDnMappingModeDA.GetRecCount();
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
int intRecCount = clsDnMappingModeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDnMappingModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDnMappingModeEN objDnMappingModeCond)
{
List<clsDnMappingModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDnMappingModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnMappingMode._AttributeName)
{
if (objDnMappingModeCond.IsUpdated(strFldName) == false) continue;
if (objDnMappingModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnMappingModeCond[strFldName].ToString());
}
else
{
if (objDnMappingModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnMappingModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnMappingModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnMappingModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnMappingModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnMappingModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnMappingModeCond[strFldName]));
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
 List<string> arrList = clsDnMappingModeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DnMappingModeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DnMappingModeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DnMappingModeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnMappingModeDA.SetFldValue(clsDnMappingModeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DnMappingModeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnMappingModeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnMappingModeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnMappingModeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DnMappingMode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**映射模式Id*/ 
 strCreateTabCode.Append(" MappingModeId char(2) primary key, "); 
 // /**映射模式名*/ 
 strCreateTabCode.Append(" MappingModeName varchar(50) Null, "); 
 // /**映射模式英文名*/ 
 strCreateTabCode.Append(" MappingModeENName varchar(50) Null, "); 
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
 /// 结点映射模式(DnMappingMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DnMappingMode : clsCommFun4BL
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
clsDnMappingModeBL.ReFreshThisCache();
}
}

}