
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFileTypeBL
 表名:PrjFileType(00050649)
 * 版本:2026.05.30(服务器:WIN-SRV103-116)
 日期:2026/06/16 16:24:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
public static class  clsPrjFileTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjFileTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFileTypeEN GetObj(this K_PrjFileTypeId_PrjFileType myKey)
{
clsPrjFileTypeEN objPrjFileTypeEN = clsPrjFileTypeBL.PrjFileTypeDA.GetObjByPrjFileTypeId(myKey.Value);
return objPrjFileTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFileTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程文件类型名 = [{0}]的数据已经存在!(in clsPrjFileTypeBL.AddNewRecord)", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsPrjFileTypeBL.PrjFileTypeDA.AddNewRecordBySQL2(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objPrjFileTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjFileTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程文件类型名(PrjFileTypeName)=[{0}])已经存在,不能重复!", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objPrjFileTypeEN.AddNewRecord();
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFileTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程文件类型名 = [{0}]的数据已经存在!(in clsPrjFileTypeBL.AddNewRecordWithMaxId)", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
string strPrjFileTypeId = clsPrjFileTypeBL.PrjFileTypeDA.AddNewRecordBySQL2WithReturnKey(objPrjFileTypeEN);
     objPrjFileTypeEN.PrjFileTypeId = strPrjFileTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
}
return strPrjFileTypeId;
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFileTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程文件类型名 = [{0}]的数据已经存在!(in clsPrjFileTypeBL.AddNewRecordWithReturnKey)", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
string strKey = clsPrjFileTypeBL.PrjFileTypeDA.AddNewRecordBySQL2WithReturnKey(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetPrjFileTypeId(this clsPrjFileTypeEN objPrjFileTypeEN, string strPrjFileTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileTypeId, 2, conPrjFileType.PrjFileTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjFileTypeId, 2, conPrjFileType.PrjFileTypeId);
}
objPrjFileTypeEN.PrjFileTypeId = strPrjFileTypeId; //项目文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.PrjFileTypeId) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.PrjFileTypeId, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.PrjFileTypeId] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetPrjFileTypeName(this clsPrjFileTypeEN objPrjFileTypeEN, string strPrjFileTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjFileTypeName, conPrjFileType.PrjFileTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileTypeName, 50, conPrjFileType.PrjFileTypeName);
}
objPrjFileTypeEN.PrjFileTypeName = strPrjFileTypeName; //工程文件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.PrjFileTypeName) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.PrjFileTypeName, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.PrjFileTypeName] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetPrjFileTypeENName(this clsPrjFileTypeEN objPrjFileTypeEN, string strPrjFileTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileTypeENName, 50, conPrjFileType.PrjFileTypeENName);
}
objPrjFileTypeEN.PrjFileTypeENName = strPrjFileTypeENName; //工程文件类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.PrjFileTypeENName) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.PrjFileTypeENName, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.PrjFileTypeENName] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetInUse(this clsPrjFileTypeEN objPrjFileTypeEN, bool bolInUse, string strComparisonOp="")
	{
objPrjFileTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.InUse) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.InUse, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.InUse] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetOrderNum(this clsPrjFileTypeEN objPrjFileTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conPrjFileType.OrderNum);
objPrjFileTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.OrderNum) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.OrderNum, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.OrderNum] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetUpdDate(this clsPrjFileTypeEN objPrjFileTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conPrjFileType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjFileType.UpdDate);
}
objPrjFileTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.UpdDate) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.UpdDate, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.UpdDate] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetUpdUserId(this clsPrjFileTypeEN objPrjFileTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conPrjFileType.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPrjFileType.UpdUserId);
}
objPrjFileTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.UpdUserId) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.UpdUserId, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.UpdUserId] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFileTypeEN SetMemo(this clsPrjFileTypeEN objPrjFileTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjFileType.Memo);
}
objPrjFileTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFileTypeEN.dicFldComparisonOp.ContainsKey(conPrjFileType.Memo) == false)
{
objPrjFileTypeEN.dicFldComparisonOp.Add(conPrjFileType.Memo, strComparisonOp);
}
else
{
objPrjFileTypeEN.dicFldComparisonOp[conPrjFileType.Memo] = strComparisonOp;
}
}
return objPrjFileTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjFileTypeEN objPrjFileTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjFileTypeEN.CheckPropertyNew();
clsPrjFileTypeEN objPrjFileTypeCond = new clsPrjFileTypeEN();
string strCondition = objPrjFileTypeCond
.SetPrjFileTypeId(objPrjFileTypeEN.PrjFileTypeId, "<>")
.SetPrjFileTypeName(objPrjFileTypeEN.PrjFileTypeName, "=")
.GetCombineCondition();
objPrjFileTypeEN._IsCheckProperty = true;
bool bolIsExist = clsPrjFileTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjFileTypeEN.Update();
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
 /// <param name = "objPrjFileType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjFileTypeEN objPrjFileType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjFileTypeEN objPrjFileTypeCond = new clsPrjFileTypeEN();
string strCondition = objPrjFileTypeCond
.SetPrjFileTypeName(objPrjFileType.PrjFileTypeName, "=")
.GetCombineCondition();
objPrjFileType._IsCheckProperty = true;
bool bolIsExist = clsPrjFileTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjFileType.PrjFileTypeId = clsPrjFileTypeBL.GetFirstID_S(strCondition);
objPrjFileType.UpdateWithCondition(strCondition);
}
else
{
objPrjFileType.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
objPrjFileType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFileTypeEN objPrjFileTypeEN)
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFileTypeBL.PrjFileTypeDA.UpdateBySql2(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFileTypeEN objPrjFileTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFileTypeBL.PrjFileTypeDA.UpdateBySql2(objPrjFileTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFileTypeEN objPrjFileTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjFileTypeBL.PrjFileTypeDA.UpdateBySqlWithCondition(objPrjFileTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFileTypeEN objPrjFileTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjFileTypeBL.PrjFileTypeDA.UpdateBySqlWithConditionTransaction(objPrjFileTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "strPrjFileTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjFileTypeEN objPrjFileTypeEN)
{
try
{
int intRecNum = clsPrjFileTypeBL.PrjFileTypeDA.DelRecord(objPrjFileTypeEN.PrjFileTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeENS">源对象</param>
 /// <param name = "objPrjFileTypeENT">目标对象</param>
 public static void CopyTo(this clsPrjFileTypeEN objPrjFileTypeENS, clsPrjFileTypeEN objPrjFileTypeENT)
{
try
{
objPrjFileTypeENT.PrjFileTypeId = objPrjFileTypeENS.PrjFileTypeId; //项目文件类型Id
objPrjFileTypeENT.PrjFileTypeName = objPrjFileTypeENS.PrjFileTypeName; //工程文件类型名
objPrjFileTypeENT.PrjFileTypeENName = objPrjFileTypeENS.PrjFileTypeENName; //工程文件类型英文名
objPrjFileTypeENT.InUse = objPrjFileTypeENS.InUse; //是否在用
objPrjFileTypeENT.OrderNum = objPrjFileTypeENS.OrderNum; //序号
objPrjFileTypeENT.UpdDate = objPrjFileTypeENS.UpdDate; //修改日期
objPrjFileTypeENT.UpdUserId = objPrjFileTypeENS.UpdUserId; //修改用户Id
objPrjFileTypeENT.Memo = objPrjFileTypeENS.Memo; //说明
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
 /// <param name = "objPrjFileTypeENS">源对象</param>
 /// <returns>目标对象=>clsPrjFileTypeEN:objPrjFileTypeENT</returns>
 public static clsPrjFileTypeEN CopyTo(this clsPrjFileTypeEN objPrjFileTypeENS)
{
try
{
 clsPrjFileTypeEN objPrjFileTypeENT = new clsPrjFileTypeEN()
{
PrjFileTypeId = objPrjFileTypeENS.PrjFileTypeId, //项目文件类型Id
PrjFileTypeName = objPrjFileTypeENS.PrjFileTypeName, //工程文件类型名
PrjFileTypeENName = objPrjFileTypeENS.PrjFileTypeENName, //工程文件类型英文名
InUse = objPrjFileTypeENS.InUse, //是否在用
OrderNum = objPrjFileTypeENS.OrderNum, //序号
UpdDate = objPrjFileTypeENS.UpdDate, //修改日期
UpdUserId = objPrjFileTypeENS.UpdUserId, //修改用户Id
Memo = objPrjFileTypeENS.Memo, //说明
};
 return objPrjFileTypeENT;
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
public static void CheckPropertyNew(this clsPrjFileTypeEN objPrjFileTypeEN)
{
 clsPrjFileTypeBL.PrjFileTypeDA.CheckPropertyNew(objPrjFileTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjFileTypeEN objPrjFileTypeEN)
{
 clsPrjFileTypeBL.PrjFileTypeDA.CheckProperty4Condition(objPrjFileTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjFileTypeEN objPrjFileTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.PrjFileTypeId) == true)
{
string strComparisonOpPrjFileTypeId = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.PrjFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.PrjFileTypeId, objPrjFileTypeCond.PrjFileTypeId, strComparisonOpPrjFileTypeId);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.PrjFileTypeName) == true)
{
string strComparisonOpPrjFileTypeName = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.PrjFileTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.PrjFileTypeName, objPrjFileTypeCond.PrjFileTypeName, strComparisonOpPrjFileTypeName);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.PrjFileTypeENName) == true)
{
string strComparisonOpPrjFileTypeENName = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.PrjFileTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.PrjFileTypeENName, objPrjFileTypeCond.PrjFileTypeENName, strComparisonOpPrjFileTypeENName);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.InUse) == true)
{
if (objPrjFileTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFileType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFileType.InUse);
}
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.OrderNum) == true)
{
string strComparisonOpOrderNum = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjFileType.OrderNum, objPrjFileTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.UpdDate, objPrjFileTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.UpdUserId, objPrjFileTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPrjFileTypeCond.IsUpdated(conPrjFileType.Memo) == true)
{
string strComparisonOpMemo = objPrjFileTypeCond.dicFldComparisonOp[conPrjFileType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFileType.Memo, objPrjFileTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjFileType(工程文件类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjFileTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjFileTypeEN objPrjFileTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjFileTypeEN == null) return true;
if (objPrjFileTypeEN.PrjFileTypeId == null || objPrjFileTypeEN.PrjFileTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjFileTypeName = '{0}'", objPrjFileTypeEN.PrjFileTypeName);
if (clsPrjFileTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjFileTypeId !=  '{0}'", objPrjFileTypeEN.PrjFileTypeId);
 sbCondition.AppendFormat(" and PrjFileTypeName = '{0}'", objPrjFileTypeEN.PrjFileTypeName);
if (clsPrjFileTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjFileType(工程文件类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjFileTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjFileTypeEN objPrjFileTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjFileTypeEN == null) return "";
if (objPrjFileTypeEN.PrjFileTypeId == null || objPrjFileTypeEN.PrjFileTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjFileTypeName = '{0}'", objPrjFileTypeEN.PrjFileTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjFileTypeId !=  '{0}'", objPrjFileTypeEN.PrjFileTypeId);
 sbCondition.AppendFormat(" and PrjFileTypeName = '{0}'", objPrjFileTypeEN.PrjFileTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjFileType
{
public virtual bool UpdRelaTabDate(string strPrjFileTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumPrjFileType
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 系统文件
 /// </summary>
public const string SysFile_01 = "01";
 /// <summary>
 /// 生成代码文件
 /// </summary>
public const string GcFile_02 = "02";
 /// <summary>
 /// 系统设置文件
 /// </summary>
public const string SysSetFile_05 = "05";
 /// <summary>
 /// 路由文件
 /// </summary>
public const string RouterFile_06 = "06";
 /// <summary>
 /// 框架布局文件
 /// </summary>
public const string LayoutFile_07 = "07";
 /// <summary>
 /// 存储文件
 /// </summary>
public const string StoreFile_08 = "08";
 /// <summary>
 /// 项目内公共类函数文件
 /// </summary>
public const string CommClassFunInPrjFile_09 = "09";
 /// <summary>
 /// 本地化文件
 /// </summary>
public const string localesFile_10 = "10";
 /// <summary>
 /// 样式文件
 /// </summary>
public const string StylesFile_11 = "11";
 /// <summary>
 /// 组件文件
 /// </summary>
public const string ComponentsFile_12 = "12";
 /// <summary>
 /// 界面文件
 /// </summary>
public const string ViewFile_13 = "13";
 /// <summary>
 /// 界面基础文件
 /// </summary>
public const string ViewBaseFile_14 = "14";
 /// <summary>
 /// 业务逻辑文件
 /// </summary>
public const string L2BLLFile_15 = "15";
 /// <summary>
 /// 生成后修改文件
 /// </summary>
public const string GcEditFile_16 = "16";
 /// <summary>
 /// 跨项目公共类函数文件
 /// </summary>
public const string CommClassFunOverPrjFile_17 = "17";
 /// <summary>
 /// 本地文件处理接口
 /// </summary>
public const string LocalFileAccessInterface_18 = "18";
 /// <summary>
 /// 插件文件
 /// </summary>
public const string pluginsFile_19 = "19";
 /// <summary>
 /// 测试文件
 /// </summary>
public const string TestFile_20 = "20";
 /// <summary>
 /// 跨项目共享文件
 /// </summary>
public const string ShareOverPrjFile_21 = "21";
 /// <summary>
 /// 资源文件
 /// </summary>
public const string AssetsFile_22 = "22";
 /// <summary>
 /// Api文件
 /// </summary>
public const string ApiFile_23 = "23";
}
 /// <summary>
 /// 工程文件类型(PrjFileType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjFileTypeBL
{
public static RelatedActions_PrjFileType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjFileTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjFileTypeDA PrjFileTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjFileTypeDA();
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
 public clsPrjFileTypeBL()
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
if (string.IsNullOrEmpty(clsPrjFileTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFileTypeEN._ConnectString);
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
public static DataTable GetDataTable_PrjFileType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjFileTypeDA.GetDataTable_PrjFileType(strWhereCond);
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
objDT = PrjFileTypeDA.GetDataTable(strWhereCond);
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
objDT = PrjFileTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjFileTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjFileTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjFileTypeDA.GetDataTable_Top(objTopPara);
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
objDT = PrjFileTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjFileTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjFileTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjFileTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjFileTypeEN> GetObjLstByPrjFileTypeIdLst(List<string> arrPrjFileTypeIdLst)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjFileTypeIdLst, true);
 string strWhereCond = string.Format("PrjFileTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjFileTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjFileTypeEN> GetObjLstByPrjFileTypeIdLstCache(List<string> arrPrjFileTypeIdLst)
{
string strKey = string.Format("{0}", clsPrjFileTypeEN._CurrTabName);
List<clsPrjFileTypeEN> arrPrjFileTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFileTypeEN> arrPrjFileTypeObjLst_Sel =
arrPrjFileTypeObjLstCache
.Where(x => arrPrjFileTypeIdLst.Contains(x.PrjFileTypeId));
return arrPrjFileTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFileTypeEN> GetObjLst(string strWhereCond)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
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
public static List<clsPrjFileTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjFileTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjFileTypeEN> GetSubObjLstCache(clsPrjFileTypeEN objPrjFileTypeCond)
{
List<clsPrjFileTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFileTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFileType._AttributeName)
{
if (objPrjFileTypeCond.IsUpdated(strFldName) == false) continue;
if (objPrjFileTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFileTypeCond[strFldName].ToString());
}
else
{
if (objPrjFileTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFileTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFileTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFileTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFileTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFileTypeCond[strFldName]));
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
public static List<clsPrjFileTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
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
public static List<clsPrjFileTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
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
List<clsPrjFileTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjFileTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFileTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjFileTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
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
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
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
public static List<clsPrjFileTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjFileTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjFileTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
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
public static List<clsPrjFileTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFileTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjFileTypeEN> arrObjLst = new List<clsPrjFileTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFileTypeEN objPrjFileTypeEN = new clsPrjFileTypeEN();
try
{
objPrjFileTypeEN.PrjFileTypeId = objRow[conPrjFileType.PrjFileTypeId].ToString().Trim(); //项目文件类型Id
objPrjFileTypeEN.PrjFileTypeName = objRow[conPrjFileType.PrjFileTypeName].ToString().Trim(); //工程文件类型名
objPrjFileTypeEN.PrjFileTypeENName = objRow[conPrjFileType.PrjFileTypeENName] == DBNull.Value ? null : objRow[conPrjFileType.PrjFileTypeENName].ToString().Trim(); //工程文件类型英文名
objPrjFileTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conPrjFileType.InUse].ToString().Trim()); //是否在用
objPrjFileTypeEN.OrderNum = Int32.Parse(objRow[conPrjFileType.OrderNum].ToString().Trim()); //序号
objPrjFileTypeEN.UpdDate = objRow[conPrjFileType.UpdDate].ToString().Trim(); //修改日期
objPrjFileTypeEN.UpdUserId = objRow[conPrjFileType.UpdUserId].ToString().Trim(); //修改用户Id
objPrjFileTypeEN.Memo = objRow[conPrjFileType.Memo] == DBNull.Value ? null : objRow[conPrjFileType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFileTypeEN.PrjFileTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFileTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjFileType(ref clsPrjFileTypeEN objPrjFileTypeEN)
{
bool bolResult = PrjFileTypeDA.GetPrjFileType(ref objPrjFileTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjFileTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFileTypeEN GetObjByPrjFileTypeId(string strPrjFileTypeId)
{
if (strPrjFileTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjFileTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjFileTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjFileTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjFileTypeEN objPrjFileTypeEN = PrjFileTypeDA.GetObjByPrjFileTypeId(strPrjFileTypeId);
return objPrjFileTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjFileTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjFileTypeEN objPrjFileTypeEN = PrjFileTypeDA.GetFirstObj(strWhereCond);
 return objPrjFileTypeEN;
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
public static clsPrjFileTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjFileTypeEN objPrjFileTypeEN = PrjFileTypeDA.GetObjByDataRow(objRow);
 return objPrjFileTypeEN;
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
public static clsPrjFileTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjFileTypeEN objPrjFileTypeEN = PrjFileTypeDA.GetObjByDataRow(objRow);
 return objPrjFileTypeEN;
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
 /// <param name = "strPrjFileTypeId">所给的关键字</param>
 /// <param name = "lstPrjFileTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFileTypeEN GetObjByPrjFileTypeIdFromList(string strPrjFileTypeId, List<clsPrjFileTypeEN> lstPrjFileTypeObjLst)
{
foreach (clsPrjFileTypeEN objPrjFileTypeEN in lstPrjFileTypeObjLst)
{
if (objPrjFileTypeEN.PrjFileTypeId == strPrjFileTypeId)
{
return objPrjFileTypeEN;
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
 string strMaxPrjFileTypeId;
 try
 {
 strMaxPrjFileTypeId = clsPrjFileTypeDA.GetMaxStrId();
 return strMaxPrjFileTypeId;
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
 string strPrjFileTypeId;
 try
 {
 strPrjFileTypeId = new clsPrjFileTypeDA().GetFirstID(strWhereCond);
 return strPrjFileTypeId;
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
 arrList = PrjFileTypeDA.GetID(strWhereCond);
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
bool bolIsExist = PrjFileTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjFileTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjFileTypeId)
{
if (string.IsNullOrEmpty(strPrjFileTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjFileTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjFileTypeDA.IsExist(strPrjFileTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPrjFileTypeId">项目文件类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPrjFileTypeId, string strOpUser)
{
clsPrjFileTypeEN objPrjFileTypeEN = clsPrjFileTypeBL.GetObjByPrjFileTypeId(strPrjFileTypeId);
objPrjFileTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjFileTypeEN.UpdUserId = strOpUser;
return clsPrjFileTypeBL.UpdateBySql2(objPrjFileTypeEN);
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
 bolIsExist = clsPrjFileTypeDA.IsExistTable();
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
 bolIsExist = PrjFileTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjFileTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程文件类型名 = [{0}]的数据已经存在!(in clsPrjFileTypeBL.AddNewRecordBySql2)", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
bool bolResult = PrjFileTypeDA.AddNewRecordBySQL2(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjFileTypeEN objPrjFileTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjFileTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程文件类型名 = [{0}]的数据已经存在!(in clsPrjFileTypeBL.AddNewRecordBySql2WithReturnKey)", objPrjFileTypeEN.PrjFileTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true || clsPrjFileTypeBL.IsExist(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
     objPrjFileTypeEN.PrjFileTypeId = clsPrjFileTypeBL.GetMaxStrId_S();
 }
string strKey = PrjFileTypeDA.AddNewRecordBySQL2WithReturnKey(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjFileTypeEN objPrjFileTypeEN)
{
try
{
bool bolResult = PrjFileTypeDA.Update(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "objPrjFileTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjFileTypeEN objPrjFileTypeEN)
{
 if (string.IsNullOrEmpty(objPrjFileTypeEN.PrjFileTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjFileTypeDA.UpdateBySql2(objPrjFileTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFileTypeBL.ReFreshCache();

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
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
 /// <param name = "strPrjFileTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjFileTypeId)
{
try
{
 clsPrjFileTypeEN objPrjFileTypeEN = clsPrjFileTypeBL.GetObjByPrjFileTypeId(strPrjFileTypeId);

if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(objPrjFileTypeEN.PrjFileTypeId, objPrjFileTypeEN.UpdUserId);
}
if (objPrjFileTypeEN != null)
{
int intRecNum = PrjFileTypeDA.DelRecord(strPrjFileTypeId);
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
/// <param name="strPrjFileTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjFileTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFileTypeDA.GetSpecSQLObj();
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
//删除与表:[PrjFileType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjFileType.PrjFileTypeId,
//strPrjFileTypeId);
//        clsPrjFileTypeBL.DelPrjFileTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFileTypeBL.DelRecord(strPrjFileTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFileTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjFileTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjFileTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjFileTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjFileTypeBL.relatedActions != null)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(strPrjFileTypeId, "UpdRelaTabDate");
}
bool bolResult = PrjFileTypeDA.DelRecord(strPrjFileTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjFileTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjFileTypes(List<string> arrPrjFileTypeIdLst)
{
if (arrPrjFileTypeIdLst.Count == 0) return 0;
try
{
if (clsPrjFileTypeBL.relatedActions != null)
{
foreach (var strPrjFileTypeId in arrPrjFileTypeIdLst)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(strPrjFileTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjFileTypeDA.DelPrjFileType(arrPrjFileTypeIdLst);
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
public static int DelPrjFileTypesByCond(string strWhereCond)
{
try
{
if (clsPrjFileTypeBL.relatedActions != null)
{
List<string> arrPrjFileTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjFileTypeId in arrPrjFileTypeId)
{
clsPrjFileTypeBL.relatedActions.UpdRelaTabDate(strPrjFileTypeId, "UpdRelaTabDate");
}
}
int intRecNum = PrjFileTypeDA.DelPrjFileType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjFileType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjFileTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjFileTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFileTypeDA.GetSpecSQLObj();
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
//删除与表:[PrjFileType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFileTypeBL.DelRecord(strPrjFileTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFileTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjFileTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjFileTypeENS">源对象</param>
 /// <param name = "objPrjFileTypeENT">目标对象</param>
 public static void CopyTo(clsPrjFileTypeEN objPrjFileTypeENS, clsPrjFileTypeEN objPrjFileTypeENT)
{
try
{
objPrjFileTypeENT.PrjFileTypeId = objPrjFileTypeENS.PrjFileTypeId; //项目文件类型Id
objPrjFileTypeENT.PrjFileTypeName = objPrjFileTypeENS.PrjFileTypeName; //工程文件类型名
objPrjFileTypeENT.PrjFileTypeENName = objPrjFileTypeENS.PrjFileTypeENName; //工程文件类型英文名
objPrjFileTypeENT.InUse = objPrjFileTypeENS.InUse; //是否在用
objPrjFileTypeENT.OrderNum = objPrjFileTypeENS.OrderNum; //序号
objPrjFileTypeENT.UpdDate = objPrjFileTypeENS.UpdDate; //修改日期
objPrjFileTypeENT.UpdUserId = objPrjFileTypeENS.UpdUserId; //修改用户Id
objPrjFileTypeENT.Memo = objPrjFileTypeENS.Memo; //说明
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
 /// <param name = "objPrjFileTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjFileTypeEN objPrjFileTypeEN)
{
try
{
objPrjFileTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjFileTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjFileType.PrjFileTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.PrjFileTypeId = objPrjFileTypeEN.PrjFileTypeId; //项目文件类型Id
}
if (arrFldSet.Contains(conPrjFileType.PrjFileTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.PrjFileTypeName = objPrjFileTypeEN.PrjFileTypeName; //工程文件类型名
}
if (arrFldSet.Contains(conPrjFileType.PrjFileTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.PrjFileTypeENName = objPrjFileTypeEN.PrjFileTypeENName == "[null]" ? null :  objPrjFileTypeEN.PrjFileTypeENName; //工程文件类型英文名
}
if (arrFldSet.Contains(conPrjFileType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.InUse = objPrjFileTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conPrjFileType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.OrderNum = objPrjFileTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conPrjFileType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.UpdDate = objPrjFileTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjFileType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.UpdUserId = objPrjFileTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPrjFileType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFileTypeEN.Memo = objPrjFileTypeEN.Memo == "[null]" ? null :  objPrjFileTypeEN.Memo; //说明
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
 /// <param name = "objPrjFileTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjFileTypeEN objPrjFileTypeEN)
{
try
{
if (objPrjFileTypeEN.PrjFileTypeENName == "[null]") objPrjFileTypeEN.PrjFileTypeENName = null; //工程文件类型英文名
if (objPrjFileTypeEN.Memo == "[null]") objPrjFileTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjFileTypeEN objPrjFileTypeEN)
{
 PrjFileTypeDA.CheckPropertyNew(objPrjFileTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjFileTypeEN objPrjFileTypeEN)
{
 PrjFileTypeDA.CheckProperty4Condition(objPrjFileTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjFileTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程文件类型]...","0");
List<clsPrjFileTypeEN> arrPrjFileTypeObjLst = GetAllPrjFileTypeObjLstCache(); 
arrPrjFileTypeObjLst = arrPrjFileTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conPrjFileType.PrjFileTypeId;
objDDL.DataTextField = conPrjFileType.PrjFileTypeName;
objDDL.DataSource = arrPrjFileTypeObjLst;
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
if (clsPrjFileTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFileTypeBL没有刷新缓存机制(clsPrjFileTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjFileTypeId");
//if (arrPrjFileTypeObjLstCache == null)
//{
//arrPrjFileTypeObjLstCache = PrjFileTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjFileTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFileTypeEN GetObjByPrjFileTypeIdCache(string strPrjFileTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjFileTypeEN._CurrTabName);
List<clsPrjFileTypeEN> arrPrjFileTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFileTypeEN> arrPrjFileTypeObjLst_Sel =
arrPrjFileTypeObjLstCache
.Where(x=> x.PrjFileTypeId == strPrjFileTypeId 
);
if (arrPrjFileTypeObjLst_Sel.Count() == 0)
{
   clsPrjFileTypeEN obj = clsPrjFileTypeBL.GetObjByPrjFileTypeId(strPrjFileTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjFileTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjFileTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjFileTypeNameByPrjFileTypeIdCache(string strPrjFileTypeId)
{
if (string.IsNullOrEmpty(strPrjFileTypeId) == true) return "";
//获取缓存中的对象列表
clsPrjFileTypeEN objPrjFileType = GetObjByPrjFileTypeIdCache(strPrjFileTypeId);
if (objPrjFileType == null) return "";
return objPrjFileType.PrjFileTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjFileTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjFileTypeIdCache(string strPrjFileTypeId)
{
if (string.IsNullOrEmpty(strPrjFileTypeId) == true) return "";
//获取缓存中的对象列表
clsPrjFileTypeEN objPrjFileType = GetObjByPrjFileTypeIdCache(strPrjFileTypeId);
if (objPrjFileType == null) return "";
return objPrjFileType.PrjFileTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFileTypeEN> GetAllPrjFileTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjFileTypeEN> arrPrjFileTypeObjLstCache = GetObjLstCache(); 
return arrPrjFileTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFileTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjFileTypeEN._CurrTabName);
List<clsPrjFileTypeEN> arrPrjFileTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjFileTypeObjLstCache;
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
string strKey = string.Format("{0}", clsPrjFileTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFileTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjFileTypeEN._RefreshTimeLst.Count == 0) return "";
return clsPrjFileTypeEN._RefreshTimeLst[clsPrjFileTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsPrjFileTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjFileTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFileTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjFileTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjFileType(工程文件类型)
 /// 唯一性条件:PrjFileTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFileTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjFileTypeEN objPrjFileTypeEN)
{
//检测记录是否存在
string strResult = PrjFileTypeDA.GetUniCondStr(objPrjFileTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-06-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPrjFileTypeId)
{
if (strInFldName != conPrjFileType.PrjFileTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjFileType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjFileType._AttributeName));
throw new Exception(strMsg);
}
var objPrjFileType = clsPrjFileTypeBL.GetObjByPrjFileTypeIdCache(strPrjFileTypeId);
if (objPrjFileType == null) return "";
return objPrjFileType[strOutFldName].ToString();
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
int intRecCount = clsPrjFileTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjFileTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjFileTypeDA.GetRecCount();
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
int intRecCount = clsPrjFileTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjFileTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjFileTypeEN objPrjFileTypeCond)
{
List<clsPrjFileTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFileTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFileType._AttributeName)
{
if (objPrjFileTypeCond.IsUpdated(strFldName) == false) continue;
if (objPrjFileTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFileTypeCond[strFldName].ToString());
}
else
{
if (objPrjFileTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFileTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFileTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFileTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFileTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFileTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFileTypeCond[strFldName]));
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
 List<string> arrList = clsPrjFileTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjFileTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjFileTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjFileTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFileTypeDA.SetFldValue(clsPrjFileTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjFileTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFileTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFileTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFileTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjFileType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**项目文件类型Id*/ 
 strCreateTabCode.Append(" PrjFileTypeId char(2) primary key, "); 
 // /**工程文件类型名*/ 
 strCreateTabCode.Append(" PrjFileTypeName varchar(50) not Null, "); 
 // /**工程文件类型英文名*/ 
 strCreateTabCode.Append(" PrjFileTypeENName varchar(50) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder( )
{
try
{
string strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFileTypeEN> arrPrjFileTypeObjList = new clsPrjFileTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFileTypeEN objPrjFileType in arrPrjFileTypeObjList)
{
objPrjFileType.OrderNum = intIndex;
UpdateBySql2(objPrjFileType);
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
/// 调整所给关键字记录的序号。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strPrjFileTypeId">所给的关键字</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strPrjFileTypeId  )
{
try
{
//操作步骤：
//1、根据所给定的关键字[PrjFileTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字PrjFileTypeId
//5、把当前关键字PrjFileTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字PrjFileTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevPrjFileTypeId = "";    //上一条序号的关键字PrjFileTypeId
string strNextPrjFileTypeId = "";    //下一条序号的关键字PrjFileTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[PrjFileTypeId],获取相应的序号[OrderNum]。

 clsPrjFileTypeEN objPrjFileType = clsPrjFileTypeBL.GetObjByPrjFileTypeId(strPrjFileTypeId);

intOrderNum = objPrjFileType.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
intTabRecNum = clsPrjFileTypeBL.GetRecCountByCond(clsPrjFileTypeEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conPrjFileType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字PrjFileTypeId
strPrevPrjFileTypeId = clsPrjFileTypeBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevPrjFileTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字PrjFileTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字PrjFileTypeId所对应的记录序号加1
clsPrjFileTypeBL.SetFldValue(clsPrjFileTypeEN._CurrTabName, conPrjFileType.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conPrjFileType.PrjFileTypeId, strPrjFileTypeId));
clsPrjFileTypeBL.SetFldValue(clsPrjFileTypeEN._CurrTabName, conPrjFileType.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjFileType.PrjFileTypeId, strPrevPrjFileTypeId));
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

//4、获取下一个序号字段的关键字PrjFileTypeId
sbCondition.AppendFormat(" {0} = {1} ", conPrjFileType.OrderNum, intOrderNum + 1);

strNextPrjFileTypeId = clsPrjFileTypeBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextPrjFileTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字PrjFileTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字PrjFileTypeId所对应的记录序号减1
clsPrjFileTypeBL.SetFldValue(clsPrjFileTypeEN._CurrTabName, conPrjFileType.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjFileType.PrjFileTypeId, strPrjFileTypeId));
clsPrjFileTypeBL.SetFldValue(clsPrjFileTypeEN._CurrTabName, conPrjFileType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conPrjFileType.PrjFileTypeId, strNextPrjFileTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conPrjFileType.PrjFileTypeId, strKeyList);
List<clsPrjFileTypeEN> arrPrjFileTypeLst = GetObjLst(strCondition);
foreach (clsPrjFileTypeEN objPrjFileType in arrPrjFileTypeLst)
{
objPrjFileType.OrderNum = objPrjFileType.OrderNum + 10000;
UpdateBySql2(objPrjFileType);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFileTypeEN> arrPrjFileTypeObjList = new clsPrjFileTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFileTypeEN objPrjFileType in arrPrjFileTypeObjList)
{
objPrjFileType.OrderNum = intIndex;
UpdateBySql2(objPrjFileType);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conPrjFileType.PrjFileTypeId, strKeyList);
List<clsPrjFileTypeEN> arrPrjFileTypeLst = GetObjLst(strCondition);
foreach (clsPrjFileTypeEN objPrjFileType in arrPrjFileTypeLst)
{
objPrjFileType.OrderNum = objPrjFileType.OrderNum - 10000;
UpdateBySql2(objPrjFileType);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsPrjFileTypeEN> arrPrjFileTypeObjList = new clsPrjFileTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjFileTypeEN objPrjFileType in arrPrjFileTypeObjList)
{
objPrjFileType.OrderNum = intIndex;
UpdateBySql2(objPrjFileType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 工程文件类型(PrjFileType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjFileType : clsCommFun4BL
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
clsPrjFileTypeBL.ReFreshThisCache();
}
}

}