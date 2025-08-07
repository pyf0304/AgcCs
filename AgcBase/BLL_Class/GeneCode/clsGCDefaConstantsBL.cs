
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCDefaConstantsBL
 表名:GCDefaConstants(00050640)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:38
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
public static class  clsGCDefaConstantsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strConstId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCDefaConstantsEN GetObj(this K_ConstId_GCDefaConstants myKey)
{
clsGCDefaConstantsEN objGCDefaConstantsEN = clsGCDefaConstantsBL.GCDefaConstantsDA.GetObjByConstId(myKey.Value);
return objGCDefaConstantsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCDefaConstantsEN) == false)
{
var strMsg = string.Format("记录已经存在!常量名 = [{0}]的数据已经存在!(in clsGCDefaConstantsBL.AddNewRecord)", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
bool bolResult = clsGCDefaConstantsBL.GCDefaConstantsDA.AddNewRecordBySQL2(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
public static bool AddRecordEx(this clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCDefaConstantsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCDefaConstantsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(常量名(ConstName)=[{0}])已经存在,不能重复!", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCDefaConstantsEN.AddNewRecord();
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCDefaConstantsEN) == false)
{
var strMsg = string.Format("记录已经存在!常量名 = [{0}]的数据已经存在!(in clsGCDefaConstantsBL.AddNewRecordWithMaxId)", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
string strConstId = clsGCDefaConstantsBL.GCDefaConstantsDA.AddNewRecordBySQL2WithReturnKey(objGCDefaConstantsEN);
     objGCDefaConstantsEN.ConstId = strConstId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
}
return strConstId;
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCDefaConstantsEN) == false)
{
var strMsg = string.Format("记录已经存在!常量名 = [{0}]的数据已经存在!(in clsGCDefaConstantsBL.AddNewRecordWithReturnKey)", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
string strKey = clsGCDefaConstantsBL.GCDefaConstantsDA.AddNewRecordBySQL2WithReturnKey(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetConstId(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strConstId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstId, 8, conGCDefaConstants.ConstId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConstId, 8, conGCDefaConstants.ConstId);
}
objGCDefaConstantsEN.ConstId = strConstId; //常量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.ConstId) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.ConstId, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.ConstId] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetConstName(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strConstName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstName, conGCDefaConstants.ConstName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstName, 50, conGCDefaConstants.ConstName);
}
objGCDefaConstantsEN.ConstName = strConstName; //常量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.ConstName) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.ConstName, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.ConstName] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetConstExpression(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strConstExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstExpression, conGCDefaConstants.ConstExpression);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstExpression, 150, conGCDefaConstants.ConstExpression);
}
objGCDefaConstantsEN.ConstExpression = strConstExpression; //常量表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.ConstExpression) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.ConstExpression, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.ConstExpression] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetFilePath(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conGCDefaConstants.FilePath);
}
objGCDefaConstantsEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.FilePath) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.FilePath, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.FilePath] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetInitValue(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strInitValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInitValue, 1000, conGCDefaConstants.InitValue);
}
objGCDefaConstantsEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.InitValue) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.InitValue, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.InitValue] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetDataTypeId(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conGCDefaConstants.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conGCDefaConstants.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conGCDefaConstants.DataTypeId);
}
objGCDefaConstantsEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.DataTypeId) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.DataTypeId, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.DataTypeId] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetClsName(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conGCDefaConstants.ClsName);
}
objGCDefaConstantsEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.ClsName) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.ClsName, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.ClsName] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetUpdDate(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCDefaConstants.UpdDate);
}
objGCDefaConstantsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.UpdDate) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.UpdDate, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.UpdDate] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetUpdUser(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCDefaConstants.UpdUser);
}
objGCDefaConstantsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.UpdUser) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.UpdUser, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.UpdUser] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCDefaConstantsEN SetMemo(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCDefaConstants.Memo);
}
objGCDefaConstantsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCDefaConstantsEN.dicFldComparisonOp.ContainsKey(conGCDefaConstants.Memo) == false)
{
objGCDefaConstantsEN.dicFldComparisonOp.Add(conGCDefaConstants.Memo, strComparisonOp);
}
else
{
objGCDefaConstantsEN.dicFldComparisonOp[conGCDefaConstants.Memo] = strComparisonOp;
}
}
return objGCDefaConstantsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCDefaConstantsEN.CheckPropertyNew();
clsGCDefaConstantsEN objGCDefaConstantsCond = new clsGCDefaConstantsEN();
string strCondition = objGCDefaConstantsCond
.SetConstId(objGCDefaConstantsEN.ConstId, "<>")
.SetConstName(objGCDefaConstantsEN.ConstName, "=")
.GetCombineCondition();
objGCDefaConstantsEN._IsCheckProperty = true;
bool bolIsExist = clsGCDefaConstantsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa33)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCDefaConstantsEN.Update();
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
 /// <param name = "objGCDefaConstants">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCDefaConstantsEN objGCDefaConstants)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCDefaConstantsEN objGCDefaConstantsCond = new clsGCDefaConstantsEN();
string strCondition = objGCDefaConstantsCond
.SetConstName(objGCDefaConstants.ConstName, "=")
.GetCombineCondition();
objGCDefaConstants._IsCheckProperty = true;
bool bolIsExist = clsGCDefaConstantsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCDefaConstants.ConstId = clsGCDefaConstantsBL.GetFirstID_S(strCondition);
objGCDefaConstants.UpdateWithCondition(strCondition);
}
else
{
objGCDefaConstants.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
objGCDefaConstants.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCDefaConstantsBL.GCDefaConstantsDA.UpdateBySql2(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCDefaConstantsEN objGCDefaConstantsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCDefaConstantsBL.GCDefaConstantsDA.UpdateBySql2(objGCDefaConstantsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strWhereCond)
{
try
{
bool bolResult = clsGCDefaConstantsBL.GCDefaConstantsDA.UpdateBySqlWithCondition(objGCDefaConstantsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCDefaConstantsEN objGCDefaConstantsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCDefaConstantsBL.GCDefaConstantsDA.UpdateBySqlWithConditionTransaction(objGCDefaConstantsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "strConstId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
try
{
int intRecNum = clsGCDefaConstantsBL.GCDefaConstantsDA.DelRecord(objGCDefaConstantsEN.ConstId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <param name = "objGCDefaConstantsENT">目标对象</param>
 public static void CopyTo(this clsGCDefaConstantsEN objGCDefaConstantsENS, clsGCDefaConstantsEN objGCDefaConstantsENT)
{
try
{
objGCDefaConstantsENT.ConstId = objGCDefaConstantsENS.ConstId; //常量Id
objGCDefaConstantsENT.ConstName = objGCDefaConstantsENS.ConstName; //常量名
objGCDefaConstantsENT.ConstExpression = objGCDefaConstantsENS.ConstExpression; //常量表达式
objGCDefaConstantsENT.FilePath = objGCDefaConstantsENS.FilePath; //文件路径
objGCDefaConstantsENT.InitValue = objGCDefaConstantsENS.InitValue; //初始值
objGCDefaConstantsENT.DataTypeId = objGCDefaConstantsENS.DataTypeId; //数据类型Id
objGCDefaConstantsENT.ClsName = objGCDefaConstantsENS.ClsName; //类名
objGCDefaConstantsENT.UpdDate = objGCDefaConstantsENS.UpdDate; //修改日期
objGCDefaConstantsENT.UpdUser = objGCDefaConstantsENS.UpdUser; //修改者
objGCDefaConstantsENT.Memo = objGCDefaConstantsENS.Memo; //说明
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
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <returns>目标对象=>clsGCDefaConstantsEN:objGCDefaConstantsENT</returns>
 public static clsGCDefaConstantsEN CopyTo(this clsGCDefaConstantsEN objGCDefaConstantsENS)
{
try
{
 clsGCDefaConstantsEN objGCDefaConstantsENT = new clsGCDefaConstantsEN()
{
ConstId = objGCDefaConstantsENS.ConstId, //常量Id
ConstName = objGCDefaConstantsENS.ConstName, //常量名
ConstExpression = objGCDefaConstantsENS.ConstExpression, //常量表达式
FilePath = objGCDefaConstantsENS.FilePath, //文件路径
InitValue = objGCDefaConstantsENS.InitValue, //初始值
DataTypeId = objGCDefaConstantsENS.DataTypeId, //数据类型Id
ClsName = objGCDefaConstantsENS.ClsName, //类名
UpdDate = objGCDefaConstantsENS.UpdDate, //修改日期
UpdUser = objGCDefaConstantsENS.UpdUser, //修改者
Memo = objGCDefaConstantsENS.Memo, //说明
};
 return objGCDefaConstantsENT;
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
public static void CheckPropertyNew(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 clsGCDefaConstantsBL.GCDefaConstantsDA.CheckPropertyNew(objGCDefaConstantsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 clsGCDefaConstantsBL.GCDefaConstantsDA.CheckProperty4Condition(objGCDefaConstantsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCDefaConstantsEN objGCDefaConstantsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.ConstId) == true)
{
string strComparisonOpConstId = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.ConstId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.ConstId, objGCDefaConstantsCond.ConstId, strComparisonOpConstId);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.ConstName) == true)
{
string strComparisonOpConstName = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.ConstName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.ConstName, objGCDefaConstantsCond.ConstName, strComparisonOpConstName);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.ConstExpression) == true)
{
string strComparisonOpConstExpression = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.ConstExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.ConstExpression, objGCDefaConstantsCond.ConstExpression, strComparisonOpConstExpression);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.FilePath) == true)
{
string strComparisonOpFilePath = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.FilePath, objGCDefaConstantsCond.FilePath, strComparisonOpFilePath);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.InitValue) == true)
{
string strComparisonOpInitValue = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.InitValue, objGCDefaConstantsCond.InitValue, strComparisonOpInitValue);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.DataTypeId, objGCDefaConstantsCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.ClsName) == true)
{
string strComparisonOpClsName = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.ClsName, objGCDefaConstantsCond.ClsName, strComparisonOpClsName);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.UpdDate, objGCDefaConstantsCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.UpdUser, objGCDefaConstantsCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCDefaConstantsCond.IsUpdated(conGCDefaConstants.Memo) == true)
{
string strComparisonOpMemo = objGCDefaConstantsCond.dicFldComparisonOp[conGCDefaConstants.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCDefaConstants.Memo, objGCDefaConstantsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCDefaConstants(GC常量), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConstName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCDefaConstantsEN == null) return true;
if (objGCDefaConstantsEN.ConstId == null || objGCDefaConstantsEN.ConstId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConstName = '{0}'", objGCDefaConstantsEN.ConstName);
if (clsGCDefaConstantsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConstId !=  '{0}'", objGCDefaConstantsEN.ConstId);
 sbCondition.AppendFormat(" and ConstName = '{0}'", objGCDefaConstantsEN.ConstName);
if (clsGCDefaConstantsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCDefaConstants(GC常量), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConstName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCDefaConstantsEN objGCDefaConstantsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCDefaConstantsEN == null) return "";
if (objGCDefaConstantsEN.ConstId == null || objGCDefaConstantsEN.ConstId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConstName = '{0}'", objGCDefaConstantsEN.ConstName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConstId !=  '{0}'", objGCDefaConstantsEN.ConstId);
 sbCondition.AppendFormat(" and ConstName = '{0}'", objGCDefaConstantsEN.ConstName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCDefaConstants
{
public virtual bool UpdRelaTabDate(string strConstId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// GC常量(GCDefaConstants)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCDefaConstantsBL
{
public static RelatedActions_GCDefaConstants relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCDefaConstantsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCDefaConstantsDA GCDefaConstantsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCDefaConstantsDA();
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
 public clsGCDefaConstantsBL()
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
if (string.IsNullOrEmpty(clsGCDefaConstantsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCDefaConstantsEN._ConnectString);
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
public static DataTable GetDataTable_GCDefaConstants(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCDefaConstantsDA.GetDataTable_GCDefaConstants(strWhereCond);
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
objDT = GCDefaConstantsDA.GetDataTable(strWhereCond);
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
objDT = GCDefaConstantsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCDefaConstantsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCDefaConstantsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCDefaConstantsDA.GetDataTable_Top(objTopPara);
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
objDT = GCDefaConstantsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCDefaConstantsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCDefaConstantsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConstIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCDefaConstantsEN> GetObjLstByConstIdLst(List<string> arrConstIdLst)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConstIdLst, true);
 string strWhereCond = string.Format("ConstId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConstIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCDefaConstantsEN> GetObjLstByConstIdLstCache(List<string> arrConstIdLst)
{
string strKey = string.Format("{0}", clsGCDefaConstantsEN._CurrTabName);
List<clsGCDefaConstantsEN> arrGCDefaConstantsObjLstCache = GetObjLstCache();
IEnumerable <clsGCDefaConstantsEN> arrGCDefaConstantsObjLst_Sel =
arrGCDefaConstantsObjLstCache
.Where(x => arrConstIdLst.Contains(x.ConstId));
return arrGCDefaConstantsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCDefaConstantsEN> GetObjLst(string strWhereCond)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
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
public static List<clsGCDefaConstantsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCDefaConstantsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCDefaConstantsEN> GetSubObjLstCache(clsGCDefaConstantsEN objGCDefaConstantsCond)
{
List<clsGCDefaConstantsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCDefaConstantsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCDefaConstants._AttributeName)
{
if (objGCDefaConstantsCond.IsUpdated(strFldName) == false) continue;
if (objGCDefaConstantsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCDefaConstantsCond[strFldName].ToString());
}
else
{
if (objGCDefaConstantsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCDefaConstantsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCDefaConstantsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCDefaConstantsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCDefaConstantsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCDefaConstantsCond[strFldName]));
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
public static List<clsGCDefaConstantsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
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
public static List<clsGCDefaConstantsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
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
List<clsGCDefaConstantsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCDefaConstantsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCDefaConstantsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCDefaConstantsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
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
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
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
public static List<clsGCDefaConstantsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCDefaConstantsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCDefaConstantsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
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
public static List<clsGCDefaConstantsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCDefaConstantsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCDefaConstantsEN> arrObjLst = new List<clsGCDefaConstantsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCDefaConstantsEN objGCDefaConstantsEN = new clsGCDefaConstantsEN();
try
{
objGCDefaConstantsEN.ConstId = objRow[conGCDefaConstants.ConstId].ToString().Trim(); //常量Id
objGCDefaConstantsEN.ConstName = objRow[conGCDefaConstants.ConstName].ToString().Trim(); //常量名
objGCDefaConstantsEN.ConstExpression = objRow[conGCDefaConstants.ConstExpression].ToString().Trim(); //常量表达式
objGCDefaConstantsEN.FilePath = objRow[conGCDefaConstants.FilePath] == DBNull.Value ? null : objRow[conGCDefaConstants.FilePath].ToString().Trim(); //文件路径
objGCDefaConstantsEN.InitValue = objRow[conGCDefaConstants.InitValue] == DBNull.Value ? null : objRow[conGCDefaConstants.InitValue].ToString().Trim(); //初始值
objGCDefaConstantsEN.DataTypeId = objRow[conGCDefaConstants.DataTypeId].ToString().Trim(); //数据类型Id
objGCDefaConstantsEN.ClsName = objRow[conGCDefaConstants.ClsName] == DBNull.Value ? null : objRow[conGCDefaConstants.ClsName].ToString().Trim(); //类名
objGCDefaConstantsEN.UpdDate = objRow[conGCDefaConstants.UpdDate] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdDate].ToString().Trim(); //修改日期
objGCDefaConstantsEN.UpdUser = objRow[conGCDefaConstants.UpdUser] == DBNull.Value ? null : objRow[conGCDefaConstants.UpdUser].ToString().Trim(); //修改者
objGCDefaConstantsEN.Memo = objRow[conGCDefaConstants.Memo] == DBNull.Value ? null : objRow[conGCDefaConstants.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCDefaConstantsEN.ConstId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCDefaConstantsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCDefaConstants(ref clsGCDefaConstantsEN objGCDefaConstantsEN)
{
bool bolResult = GCDefaConstantsDA.GetGCDefaConstants(ref objGCDefaConstantsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strConstId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCDefaConstantsEN GetObjByConstId(string strConstId)
{
if (strConstId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strConstId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strConstId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strConstId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCDefaConstantsEN objGCDefaConstantsEN = GCDefaConstantsDA.GetObjByConstId(strConstId);
return objGCDefaConstantsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCDefaConstantsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCDefaConstantsEN objGCDefaConstantsEN = GCDefaConstantsDA.GetFirstObj(strWhereCond);
 return objGCDefaConstantsEN;
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
public static clsGCDefaConstantsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCDefaConstantsEN objGCDefaConstantsEN = GCDefaConstantsDA.GetObjByDataRow(objRow);
 return objGCDefaConstantsEN;
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
public static clsGCDefaConstantsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCDefaConstantsEN objGCDefaConstantsEN = GCDefaConstantsDA.GetObjByDataRow(objRow);
 return objGCDefaConstantsEN;
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
 /// <param name = "strConstId">所给的关键字</param>
 /// <param name = "lstGCDefaConstantsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCDefaConstantsEN GetObjByConstIdFromList(string strConstId, List<clsGCDefaConstantsEN> lstGCDefaConstantsObjLst)
{
foreach (clsGCDefaConstantsEN objGCDefaConstantsEN in lstGCDefaConstantsObjLst)
{
if (objGCDefaConstantsEN.ConstId == strConstId)
{
return objGCDefaConstantsEN;
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
 string strMaxConstId;
 try
 {
 strMaxConstId = clsGCDefaConstantsDA.GetMaxStrId();
 return strMaxConstId;
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
 string strConstId;
 try
 {
 strConstId = new clsGCDefaConstantsDA().GetFirstID(strWhereCond);
 return strConstId;
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
 arrList = GCDefaConstantsDA.GetID(strWhereCond);
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
bool bolIsExist = GCDefaConstantsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strConstId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strConstId)
{
if (string.IsNullOrEmpty(strConstId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strConstId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCDefaConstantsDA.IsExist(strConstId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strConstId">常量Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strConstId, string strOpUser)
{
clsGCDefaConstantsEN objGCDefaConstantsEN = clsGCDefaConstantsBL.GetObjByConstId(strConstId);
objGCDefaConstantsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCDefaConstantsEN.UpdUser = strOpUser;
return clsGCDefaConstantsBL.UpdateBySql2(objGCDefaConstantsEN);
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
 bolIsExist = clsGCDefaConstantsDA.IsExistTable();
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
 bolIsExist = GCDefaConstantsDA.IsExistTable(strTabName);
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCDefaConstantsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!常量名 = [{0}]的数据已经存在!(in clsGCDefaConstantsBL.AddNewRecordBySql2)", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
bool bolResult = GCDefaConstantsDA.AddNewRecordBySQL2(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCDefaConstantsEN objGCDefaConstantsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCDefaConstantsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!常量名 = [{0}]的数据已经存在!(in clsGCDefaConstantsBL.AddNewRecordBySql2WithReturnKey)", objGCDefaConstantsEN.ConstName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true || clsGCDefaConstantsBL.IsExist(objGCDefaConstantsEN.ConstId) == true)
 {
     objGCDefaConstantsEN.ConstId = clsGCDefaConstantsBL.GetMaxStrId_S();
 }
string strKey = GCDefaConstantsDA.AddNewRecordBySQL2WithReturnKey(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
try
{
bool bolResult = GCDefaConstantsDA.Update(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "objGCDefaConstantsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 if (string.IsNullOrEmpty(objGCDefaConstantsEN.ConstId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCDefaConstantsDA.UpdateBySql2(objGCDefaConstantsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCDefaConstantsBL.ReFreshCache();

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
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
 /// <param name = "strConstId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strConstId)
{
try
{
 clsGCDefaConstantsEN objGCDefaConstantsEN = clsGCDefaConstantsBL.GetObjByConstId(strConstId);

if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(objGCDefaConstantsEN.ConstId, objGCDefaConstantsEN.UpdUser);
}
if (objGCDefaConstantsEN != null)
{
int intRecNum = GCDefaConstantsDA.DelRecord(strConstId);
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
/// <param name="strConstId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strConstId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCDefaConstantsDA.GetSpecSQLObj();
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
//删除与表:[GCDefaConstants]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCDefaConstants.ConstId,
//strConstId);
//        clsGCDefaConstantsBL.DelGCDefaConstantssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCDefaConstantsBL.DelRecord(strConstId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCDefaConstantsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConstId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strConstId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strConstId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCDefaConstantsBL.relatedActions != null)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(strConstId, "UpdRelaTabDate");
}
bool bolResult = GCDefaConstantsDA.DelRecord(strConstId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrConstIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCDefaConstantss(List<string> arrConstIdLst)
{
if (arrConstIdLst.Count == 0) return 0;
try
{
if (clsGCDefaConstantsBL.relatedActions != null)
{
foreach (var strConstId in arrConstIdLst)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(strConstId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCDefaConstantsDA.DelGCDefaConstants(arrConstIdLst);
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
public static int DelGCDefaConstantssByCond(string strWhereCond)
{
try
{
if (clsGCDefaConstantsBL.relatedActions != null)
{
List<string> arrConstId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConstId in arrConstId)
{
clsGCDefaConstantsBL.relatedActions.UpdRelaTabDate(strConstId, "UpdRelaTabDate");
}
}
int intRecNum = GCDefaConstantsDA.DelGCDefaConstants(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCDefaConstants]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strConstId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strConstId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCDefaConstantsDA.GetSpecSQLObj();
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
//删除与表:[GCDefaConstants]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCDefaConstantsBL.DelRecord(strConstId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCDefaConstantsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConstId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCDefaConstantsENS">源对象</param>
 /// <param name = "objGCDefaConstantsENT">目标对象</param>
 public static void CopyTo(clsGCDefaConstantsEN objGCDefaConstantsENS, clsGCDefaConstantsEN objGCDefaConstantsENT)
{
try
{
objGCDefaConstantsENT.ConstId = objGCDefaConstantsENS.ConstId; //常量Id
objGCDefaConstantsENT.ConstName = objGCDefaConstantsENS.ConstName; //常量名
objGCDefaConstantsENT.ConstExpression = objGCDefaConstantsENS.ConstExpression; //常量表达式
objGCDefaConstantsENT.FilePath = objGCDefaConstantsENS.FilePath; //文件路径
objGCDefaConstantsENT.InitValue = objGCDefaConstantsENS.InitValue; //初始值
objGCDefaConstantsENT.DataTypeId = objGCDefaConstantsENS.DataTypeId; //数据类型Id
objGCDefaConstantsENT.ClsName = objGCDefaConstantsENS.ClsName; //类名
objGCDefaConstantsENT.UpdDate = objGCDefaConstantsENS.UpdDate; //修改日期
objGCDefaConstantsENT.UpdUser = objGCDefaConstantsENS.UpdUser; //修改者
objGCDefaConstantsENT.Memo = objGCDefaConstantsENS.Memo; //说明
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
 /// <param name = "objGCDefaConstantsEN">源简化对象</param>
 public static void SetUpdFlag(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
try
{
objGCDefaConstantsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCDefaConstantsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCDefaConstants.ConstId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.ConstId = objGCDefaConstantsEN.ConstId; //常量Id
}
if (arrFldSet.Contains(conGCDefaConstants.ConstName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.ConstName = objGCDefaConstantsEN.ConstName; //常量名
}
if (arrFldSet.Contains(conGCDefaConstants.ConstExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.ConstExpression = objGCDefaConstantsEN.ConstExpression; //常量表达式
}
if (arrFldSet.Contains(conGCDefaConstants.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.FilePath = objGCDefaConstantsEN.FilePath == "[null]" ? null :  objGCDefaConstantsEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conGCDefaConstants.InitValue, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.InitValue = objGCDefaConstantsEN.InitValue == "[null]" ? null :  objGCDefaConstantsEN.InitValue; //初始值
}
if (arrFldSet.Contains(conGCDefaConstants.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.DataTypeId = objGCDefaConstantsEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conGCDefaConstants.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.ClsName = objGCDefaConstantsEN.ClsName == "[null]" ? null :  objGCDefaConstantsEN.ClsName; //类名
}
if (arrFldSet.Contains(conGCDefaConstants.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.UpdDate = objGCDefaConstantsEN.UpdDate == "[null]" ? null :  objGCDefaConstantsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCDefaConstants.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.UpdUser = objGCDefaConstantsEN.UpdUser == "[null]" ? null :  objGCDefaConstantsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCDefaConstants.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCDefaConstantsEN.Memo = objGCDefaConstantsEN.Memo == "[null]" ? null :  objGCDefaConstantsEN.Memo; //说明
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
 /// <param name = "objGCDefaConstantsEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
try
{
if (objGCDefaConstantsEN.FilePath == "[null]") objGCDefaConstantsEN.FilePath = null; //文件路径
if (objGCDefaConstantsEN.InitValue == "[null]") objGCDefaConstantsEN.InitValue = null; //初始值
if (objGCDefaConstantsEN.ClsName == "[null]") objGCDefaConstantsEN.ClsName = null; //类名
if (objGCDefaConstantsEN.UpdDate == "[null]") objGCDefaConstantsEN.UpdDate = null; //修改日期
if (objGCDefaConstantsEN.UpdUser == "[null]") objGCDefaConstantsEN.UpdUser = null; //修改者
if (objGCDefaConstantsEN.Memo == "[null]") objGCDefaConstantsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 GCDefaConstantsDA.CheckPropertyNew(objGCDefaConstantsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
 GCDefaConstantsDA.CheckProperty4Condition(objGCDefaConstantsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ConstIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC常量]...","0");
List<clsGCDefaConstantsEN> arrGCDefaConstantsObjLst = GetAllGCDefaConstantsObjLstCache(); 
objDDL.DataValueField = conGCDefaConstants.ConstId;
objDDL.DataTextField = conGCDefaConstants.ConstName;
objDDL.DataSource = arrGCDefaConstantsObjLst;
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
if (clsGCDefaConstantsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCDefaConstantsBL没有刷新缓存机制(clsGCDefaConstantsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConstId");
//if (arrGCDefaConstantsObjLstCache == null)
//{
//arrGCDefaConstantsObjLstCache = GCDefaConstantsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strConstId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCDefaConstantsEN GetObjByConstIdCache(string strConstId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCDefaConstantsEN._CurrTabName);
List<clsGCDefaConstantsEN> arrGCDefaConstantsObjLstCache = GetObjLstCache();
IEnumerable <clsGCDefaConstantsEN> arrGCDefaConstantsObjLst_Sel =
arrGCDefaConstantsObjLstCache
.Where(x=> x.ConstId == strConstId 
);
if (arrGCDefaConstantsObjLst_Sel.Count() == 0)
{
   clsGCDefaConstantsEN obj = clsGCDefaConstantsBL.GetObjByConstId(strConstId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCDefaConstantsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConstId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstNameByConstIdCache(string strConstId)
{
if (string.IsNullOrEmpty(strConstId) == true) return "";
//获取缓存中的对象列表
clsGCDefaConstantsEN objGCDefaConstants = GetObjByConstIdCache(strConstId);
if (objGCDefaConstants == null) return "";
return objGCDefaConstants.ConstName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConstId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByConstIdCache(string strConstId)
{
if (string.IsNullOrEmpty(strConstId) == true) return "";
//获取缓存中的对象列表
clsGCDefaConstantsEN objGCDefaConstants = GetObjByConstIdCache(strConstId);
if (objGCDefaConstants == null) return "";
return objGCDefaConstants.ConstName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCDefaConstantsEN> GetAllGCDefaConstantsObjLstCache()
{
//获取缓存中的对象列表
List<clsGCDefaConstantsEN> arrGCDefaConstantsObjLstCache = GetObjLstCache(); 
return arrGCDefaConstantsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCDefaConstantsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCDefaConstantsEN._CurrTabName);
List<clsGCDefaConstantsEN> arrGCDefaConstantsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCDefaConstantsObjLstCache;
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
string strKey = string.Format("{0}", clsGCDefaConstantsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCDefaConstantsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCDefaConstantsEN._RefreshTimeLst.Count == 0) return "";
return clsGCDefaConstantsEN._RefreshTimeLst[clsGCDefaConstantsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsGCDefaConstantsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCDefaConstantsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCDefaConstantsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCDefaConstantsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCDefaConstants(GC常量)
 /// 唯一性条件:ConstName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCDefaConstantsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCDefaConstantsEN objGCDefaConstantsEN)
{
//检测记录是否存在
string strResult = GCDefaConstantsDA.GetUniCondStr(objGCDefaConstantsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strConstId)
{
if (strInFldName != conGCDefaConstants.ConstId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCDefaConstants._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCDefaConstants._AttributeName));
throw new Exception(strMsg);
}
var objGCDefaConstants = clsGCDefaConstantsBL.GetObjByConstIdCache(strConstId);
if (objGCDefaConstants == null) return "";
return objGCDefaConstants[strOutFldName].ToString();
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
int intRecCount = clsGCDefaConstantsDA.GetRecCount(strTabName);
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
int intRecCount = clsGCDefaConstantsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCDefaConstantsDA.GetRecCount();
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
int intRecCount = clsGCDefaConstantsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCDefaConstantsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCDefaConstantsEN objGCDefaConstantsCond)
{
List<clsGCDefaConstantsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCDefaConstantsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCDefaConstants._AttributeName)
{
if (objGCDefaConstantsCond.IsUpdated(strFldName) == false) continue;
if (objGCDefaConstantsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCDefaConstantsCond[strFldName].ToString());
}
else
{
if (objGCDefaConstantsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCDefaConstantsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCDefaConstantsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCDefaConstantsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCDefaConstantsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCDefaConstantsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCDefaConstantsCond[strFldName]));
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
 List<string> arrList = clsGCDefaConstantsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCDefaConstantsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCDefaConstantsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCDefaConstantsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCDefaConstantsDA.SetFldValue(clsGCDefaConstantsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCDefaConstantsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCDefaConstantsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCDefaConstantsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCDefaConstantsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCDefaConstants] "); 
 strCreateTabCode.Append(" ( "); 
 // /**常量Id*/ 
 strCreateTabCode.Append(" ConstId char(8) primary key, "); 
 // /**常量名*/ 
 strCreateTabCode.Append(" ConstName varchar(50) not Null, "); 
 // /**常量表达式*/ 
 strCreateTabCode.Append(" ConstExpression varchar(150) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) Null, "); 
 // /**初始值*/ 
 strCreateTabCode.Append(" InitValue varchar(1000) Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**常量名Ex*/ 
 strCreateTabCode.Append(" ConstNameEx varchar(50) Null, "); 
 // /**常量表达式Ex*/ 
 strCreateTabCode.Append(" ConstExpressionEx varchar(50) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" DuFilePath varchar(500) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" DuClassName varchar(100) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DuDataTypeName varchar(100) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// GC常量(GCDefaConstants)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCDefaConstants : clsCommFun4BL
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
clsGCDefaConstantsBL.ReFreshThisCache();
}
}

}