
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataTypeAbbrBL
 表名:DataTypeAbbr(00050023)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsDataTypeAbbrBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataTypeAbbrEN GetObj(this K_DataTypeId_DataTypeAbbr myKey)
{
clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.DataTypeAbbrDA.GetObjByDataTypeId(myKey.Value);
return objDataTypeAbbrEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataTypeAbbrEN.DataTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDataTypeAbbrBL.DataTypeAbbrDA.AddNewRecordBySQL2(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDataTypeAbbrEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDataTypeAbbrEN.AddNewRecord();
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataTypeAbbrEN.DataTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDataTypeAbbrBL.DataTypeAbbrDA.AddNewRecordBySQL2WithReturnKey(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeId(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conDataTypeAbbr.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conDataTypeAbbr.DataTypeId);
}
objDataTypeAbbrEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeId) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeId, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeId] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, conDataTypeAbbr.DataTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, conDataTypeAbbr.DataTypeName);
}
objDataTypeAbbrEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeENName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeENName, 100, conDataTypeAbbr.DataTypeENName);
}
objDataTypeAbbrEN.DataTypeENName = strDataTypeENName; //DataTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeENName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeENName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeENName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataCnName(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, conDataTypeAbbr.DataCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, conDataTypeAbbr.DataCnName);
}
objDataTypeAbbrEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataCnName) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataCnName, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataCnName] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDataTypeAbbr(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strDataTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeAbbr, conDataTypeAbbr.DataTypeAbbr);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, conDataTypeAbbr.DataTypeAbbr);
}
objDataTypeAbbrEN.DataTypeAbbr = strDataTypeAbbr; //数据类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DataTypeAbbr) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DataTypeAbbr, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DataTypeAbbr] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetNetSysType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strNetSysType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNetSysType, conDataTypeAbbr.NetSysType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNetSysType, 20, conDataTypeAbbr.NetSysType);
}
objDataTypeAbbrEN.NetSysType = strNetSysType; //NET系统类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.NetSysType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.NetSysType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.NetSysType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetVbNetType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strVbNetType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVbNetType, conDataTypeAbbr.VbNetType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVbNetType, 100, conDataTypeAbbr.VbNetType);
}
objDataTypeAbbrEN.VbNetType = strVbNetType; //VBNET类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.VbNetType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.VbNetType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.VbNetType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetCsType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, conDataTypeAbbr.CsType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, conDataTypeAbbr.CsType);
}
objDataTypeAbbrEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.CsType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.CsType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.CsType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetJavaType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, conDataTypeAbbr.JavaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, conDataTypeAbbr.JavaType);
}
objDataTypeAbbrEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.JavaType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.JavaType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.JavaType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetTypeScriptType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strTypeScriptType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTypeScriptType, 100, conDataTypeAbbr.TypeScriptType);
}
objDataTypeAbbrEN.TypeScriptType = strTypeScriptType; //TypeScript类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.TypeScriptType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.TypeScriptType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.TypeScriptType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetJavaObjType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, conDataTypeAbbr.JavaObjType);
}
objDataTypeAbbrEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.JavaObjType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.JavaObjType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.JavaObjType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetSwiftType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, conDataTypeAbbr.SwiftType);
}
objDataTypeAbbrEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.SwiftType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.SwiftType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.SwiftType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetIsNeedQuote(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, conDataTypeAbbr.IsNeedQuote);
objDataTypeAbbrEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.IsNeedQuote) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.IsNeedQuote, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.IsNeedQuote] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetOraDbType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strOraDbType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, conDataTypeAbbr.OraDbType);
}
objDataTypeAbbrEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.OraDbType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.OraDbType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.OraDbType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetIsReturnType(this clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsReturnType, string strComparisonOp="")
	{
objDataTypeAbbrEN.IsReturnType = bolIsReturnType; //是否可作返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.IsReturnType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.IsReturnType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.IsReturnType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetSqlParaType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strSqlParaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlParaType, 100, conDataTypeAbbr.SqlParaType);
}
objDataTypeAbbrEN.SqlParaType = strSqlParaType; //SQL参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.SqlParaType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.SqlParaType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.SqlParaType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetMySqlType(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, conDataTypeAbbr.MySqlType);
}
objDataTypeAbbrEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.MySqlType) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.MySqlType, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.MySqlType] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDefaFldLength(this clsDataTypeAbbrEN objDataTypeAbbrEN, int? intDefaFldLength, string strComparisonOp="")
	{
objDataTypeAbbrEN.DefaFldLength = intDefaFldLength; //默认长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DefaFldLength) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DefaFldLength, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DefaFldLength] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetDefaFldPrecision(this clsDataTypeAbbrEN objDataTypeAbbrEN, int? intDefaFldPrecision, string strComparisonOp="")
	{
objDataTypeAbbrEN.DefaFldPrecision = intDefaFldPrecision; //默认小数位数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.DefaFldPrecision) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.DefaFldPrecision, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.DefaFldPrecision] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataTypeAbbrEN SetMemo(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataTypeAbbr.Memo);
}
objDataTypeAbbrEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataTypeAbbrEN.dicFldComparisonOp.ContainsKey(conDataTypeAbbr.Memo) == false)
{
objDataTypeAbbrEN.dicFldComparisonOp.Add(conDataTypeAbbr.Memo, strComparisonOp);
}
else
{
objDataTypeAbbrEN.dicFldComparisonOp[conDataTypeAbbr.Memo] = strComparisonOp;
}
}
return objDataTypeAbbrEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataTypeAbbrEN.CheckPropertyNew();
clsDataTypeAbbrEN objDataTypeAbbrCond = new clsDataTypeAbbrEN();
string strCondition = objDataTypeAbbrCond
.SetDataTypeId(objDataTypeAbbrEN.DataTypeId, "=")
.GetCombineCondition();
objDataTypeAbbrEN._IsCheckProperty = true;
bool bolIsExist = clsDataTypeAbbrBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataTypeAbbrEN.Update();
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataTypeAbbrBL.DataTypeAbbrDA.UpdateBySql2(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataTypeAbbrEN objDataTypeAbbrEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataTypeAbbrBL.DataTypeAbbrDA.UpdateBySql2(objDataTypeAbbrEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strWhereCond)
{
try
{
bool bolResult = clsDataTypeAbbrBL.DataTypeAbbrDA.UpdateBySqlWithCondition(objDataTypeAbbrEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataTypeAbbrEN objDataTypeAbbrEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataTypeAbbrBL.DataTypeAbbrDA.UpdateBySqlWithConditionTransaction(objDataTypeAbbrEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
try
{
int intRecNum = clsDataTypeAbbrBL.DataTypeAbbrDA.DelRecord(objDataTypeAbbrEN.DataTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
 public static void CopyTo(this clsDataTypeAbbrEN objDataTypeAbbrENS, clsDataTypeAbbrEN objDataTypeAbbrENT)
{
try
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VbNetType = objDataTypeAbbrENS.VbNetType; //VBNET类型
objDataTypeAbbrENT.CsType = objDataTypeAbbrENS.CsType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
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
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <returns>目标对象=>clsDataTypeAbbrEN:objDataTypeAbbrENT</returns>
 public static clsDataTypeAbbrEN CopyTo(this clsDataTypeAbbrEN objDataTypeAbbrENS)
{
try
{
 clsDataTypeAbbrEN objDataTypeAbbrENT = new clsDataTypeAbbrEN()
{
DataTypeId = objDataTypeAbbrENS.DataTypeId, //数据类型Id
DataTypeName = objDataTypeAbbrENS.DataTypeName, //数据类型名称
DataTypeENName = objDataTypeAbbrENS.DataTypeENName, //DataTypeENName
DataCnName = objDataTypeAbbrENS.DataCnName, //数据类型中文名称
DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr, //数据类型缩写
NetSysType = objDataTypeAbbrENS.NetSysType, //NET系统类型
VbNetType = objDataTypeAbbrENS.VbNetType, //VBNET类型
CsType = objDataTypeAbbrENS.CsType, //CS类型
JavaType = objDataTypeAbbrENS.JavaType, //JAVA类型
TypeScriptType = objDataTypeAbbrENS.TypeScriptType, //TypeScript类型
JavaObjType = objDataTypeAbbrENS.JavaObjType, //JAVA对象类型
SwiftType = objDataTypeAbbrENS.SwiftType, //SwiftType
IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote, //是否需要引号
OraDbType = objDataTypeAbbrENS.OraDbType, //Ora数据类型
IsReturnType = objDataTypeAbbrENS.IsReturnType, //是否可作返回类型
SqlParaType = objDataTypeAbbrENS.SqlParaType, //SQL参数类型
MySqlType = objDataTypeAbbrENS.MySqlType, //MySqlType
DefaFldLength = objDataTypeAbbrENS.DefaFldLength, //默认长度
DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision, //默认小数位数
Memo = objDataTypeAbbrENS.Memo, //说明
};
 return objDataTypeAbbrENT;
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
public static void CheckPropertyNew(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 clsDataTypeAbbrBL.DataTypeAbbrDA.CheckPropertyNew(objDataTypeAbbrEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 clsDataTypeAbbrBL.DataTypeAbbrDA.CheckProperty4Condition(objDataTypeAbbrEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataTypeAbbrEN objDataTypeAbbrCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeId, objDataTypeAbbrCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeName, objDataTypeAbbrCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeENName) == true)
{
string strComparisonOpDataTypeENName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeENName, objDataTypeAbbrCond.DataTypeENName, strComparisonOpDataTypeENName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataCnName) == true)
{
string strComparisonOpDataCnName = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataCnName, objDataTypeAbbrCond.DataCnName, strComparisonOpDataCnName);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DataTypeAbbr) == true)
{
string strComparisonOpDataTypeAbbr = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DataTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.DataTypeAbbr, objDataTypeAbbrCond.DataTypeAbbr, strComparisonOpDataTypeAbbr);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.NetSysType) == true)
{
string strComparisonOpNetSysType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.NetSysType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.NetSysType, objDataTypeAbbrCond.NetSysType, strComparisonOpNetSysType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.VbNetType) == true)
{
string strComparisonOpVbNetType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.VbNetType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.VbNetType, objDataTypeAbbrCond.VbNetType, strComparisonOpVbNetType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.CsType) == true)
{
string strComparisonOpCsType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.CsType, objDataTypeAbbrCond.CsType, strComparisonOpCsType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.JavaType) == true)
{
string strComparisonOpJavaType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.JavaType, objDataTypeAbbrCond.JavaType, strComparisonOpJavaType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.TypeScriptType) == true)
{
string strComparisonOpTypeScriptType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.TypeScriptType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.TypeScriptType, objDataTypeAbbrCond.TypeScriptType, strComparisonOpTypeScriptType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.JavaObjType, objDataTypeAbbrCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.SwiftType) == true)
{
string strComparisonOpSwiftType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.SwiftType, objDataTypeAbbrCond.SwiftType, strComparisonOpSwiftType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.IsNeedQuote) == true)
{
if (objDataTypeAbbrCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataTypeAbbr.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataTypeAbbr.IsNeedQuote);
}
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.OraDbType) == true)
{
string strComparisonOpOraDbType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.OraDbType, objDataTypeAbbrCond.OraDbType, strComparisonOpOraDbType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.IsReturnType) == true)
{
if (objDataTypeAbbrCond.IsReturnType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataTypeAbbr.IsReturnType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataTypeAbbr.IsReturnType);
}
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.SqlParaType) == true)
{
string strComparisonOpSqlParaType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.SqlParaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.SqlParaType, objDataTypeAbbrCond.SqlParaType, strComparisonOpSqlParaType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.MySqlType) == true)
{
string strComparisonOpMySqlType = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.MySqlType, objDataTypeAbbrCond.MySqlType, strComparisonOpMySqlType);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DefaFldLength) == true)
{
string strComparisonOpDefaFldLength = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DefaFldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conDataTypeAbbr.DefaFldLength, objDataTypeAbbrCond.DefaFldLength, strComparisonOpDefaFldLength);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.DefaFldPrecision) == true)
{
string strComparisonOpDefaFldPrecision = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.DefaFldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conDataTypeAbbr.DefaFldPrecision, objDataTypeAbbrCond.DefaFldPrecision, strComparisonOpDefaFldPrecision);
}
if (objDataTypeAbbrCond.IsUpdated(conDataTypeAbbr.Memo) == true)
{
string strComparisonOpMemo = objDataTypeAbbrCond.dicFldComparisonOp[conDataTypeAbbr.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataTypeAbbr.Memo, objDataTypeAbbrCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataTypeAbbr
{
public virtual bool UpdRelaTabDate(string strDataTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumDataTypeAbbr
{
 /// <summary>
 /// bigint
 /// </summary>
public const string bigint_01 = "01";
 /// <summary>
 /// binary
 /// </summary>
public const string binary_02 = "02";
 /// <summary>
 /// bit
 /// </summary>
public const string bit_03 = "03";
 /// <summary>
 /// char
 /// </summary>
public const string char_04 = "04";
 /// <summary>
 /// datetime
 /// </summary>
public const string datetime_05 = "05";
 /// <summary>
 /// decimal
 /// </summary>
public const string decimal_06 = "06";
 /// <summary>
 /// float
 /// </summary>
public const string float_07 = "07";
 /// <summary>
 /// image
 /// </summary>
public const string image_08 = "08";
 /// <summary>
 /// int
 /// </summary>
public const string int_09 = "09";
 /// <summary>
 /// int identity
 /// </summary>
public const string intidentity_10 = "10";
 /// <summary>
 /// money
 /// </summary>
public const string money_11 = "11";
 /// <summary>
 /// nchar
 /// </summary>
public const string nchar_12 = "12";
 /// <summary>
 /// ntext
 /// </summary>
public const string ntext_13 = "13";
 /// <summary>
 /// numeric
 /// </summary>
public const string numeric_14 = "14";
 /// <summary>
 /// nvarchar
 /// </summary>
public const string nvarchar_15 = "15";
 /// <summary>
 /// real
 /// </summary>
public const string real_16 = "16";
 /// <summary>
 /// smalldatetime
 /// </summary>
public const string smalldatetime_17 = "17";
 /// <summary>
 /// smallint
 /// </summary>
public const string smallint_18 = "18";
 /// <summary>
 /// smallmoney
 /// </summary>
public const string smallmoney_19 = "19";
 /// <summary>
 /// text
 /// </summary>
public const string text_20 = "20";
 /// <summary>
 /// timestamp
 /// </summary>
public const string timestamp_21 = "21";
 /// <summary>
 /// tinyint
 /// </summary>
public const string tinyint_22 = "22";
 /// <summary>
 /// uniqueidentifier
 /// </summary>
public const string uniqueidentifier_23 = "23";
 /// <summary>
 /// varbinary
 /// </summary>
public const string varbinary_24 = "24";
 /// <summary>
 /// varchar
 /// </summary>
public const string varchar_25 = "25";
 /// <summary>
 /// bigint identity
 /// </summary>
public const string bigintidentity_26 = "26";
 /// <summary>
 /// void
 /// </summary>
public const string void_27 = "27";
 /// <summary>
 /// System.Data.DataSet
 /// </summary>
public const string System_Data_DataSet_28 = "28";
 /// <summary>
 /// Object
 /// </summary>
public const string Object_29 = "29";
 /// <summary>
 /// ObjectLst
 /// </summary>
public const string ObjectLst_30 = "30";
 /// <summary>
 /// Array
 /// </summary>
public const string Array_31 = "31";
 /// <summary>
 /// T
 /// </summary>
public const string T_32 = "32";
 /// <summary>
 /// Var4Key
 /// </summary>
public const string Var4Key_33 = "33";
 /// <summary>
 /// Var4Field
 /// </summary>
public const string Var4Field_34 = "34";
}
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataTypeAbbrBL
{
public static RelatedActions_DataTypeAbbr relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataTypeAbbrDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataTypeAbbrDA DataTypeAbbrDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataTypeAbbrDA();
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
 public clsDataTypeAbbrBL()
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
if (string.IsNullOrEmpty(clsDataTypeAbbrEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataTypeAbbrEN._ConnectString);
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
public static DataTable GetDataTable_DataTypeAbbr(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataTypeAbbrDA.GetDataTable_DataTypeAbbr(strWhereCond);
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
objDT = DataTypeAbbrDA.GetDataTable(strWhereCond);
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
objDT = DataTypeAbbrDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataTypeAbbrDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataTypeAbbrDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataTypeAbbrDA.GetDataTable_Top(objTopPara);
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
objDT = DataTypeAbbrDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataTypeAbbrDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataTypeAbbrDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDataTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByDataTypeIdLst(List<string> arrDataTypeIdLst)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataTypeIdLst, true);
 string strWhereCond = string.Format("DataTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataTypeAbbrEN> GetObjLstByDataTypeIdLstCache(List<string> arrDataTypeIdLst)
{
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel =
arrDataTypeAbbrObjLstCache
.Where(x => arrDataTypeIdLst.Contains(x.DataTypeId));
return arrDataTypeAbbrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLst(string strWhereCond)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
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
public static List<clsDataTypeAbbrEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataTypeAbbrCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataTypeAbbrEN> GetSubObjLstCache(clsDataTypeAbbrEN objDataTypeAbbrCond)
{
List<clsDataTypeAbbrEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataTypeAbbr._AttributeName)
{
if (objDataTypeAbbrCond.IsUpdated(strFldName) == false) continue;
if (objDataTypeAbbrCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataTypeAbbrCond[strFldName].ToString());
}
else
{
if (objDataTypeAbbrCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataTypeAbbrCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataTypeAbbrCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataTypeAbbrCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataTypeAbbrCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataTypeAbbrCond[strFldName]));
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
public static List<clsDataTypeAbbrEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
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
public static List<clsDataTypeAbbrEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
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
List<clsDataTypeAbbrEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataTypeAbbrEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataTypeAbbrEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
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
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
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
public static List<clsDataTypeAbbrEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataTypeAbbrEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
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
public static List<clsDataTypeAbbrEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataTypeAbbrEN> arrObjLst = new List<clsDataTypeAbbrEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN();
try
{
objDataTypeAbbrEN.DataTypeId = objRow[conDataTypeAbbr.DataTypeId].ToString().Trim(); //数据类型Id
objDataTypeAbbrEN.DataTypeName = objRow[conDataTypeAbbr.DataTypeName].ToString().Trim(); //数据类型名称
objDataTypeAbbrEN.DataTypeENName = objRow[conDataTypeAbbr.DataTypeENName] == DBNull.Value ? null : objRow[conDataTypeAbbr.DataTypeENName].ToString().Trim(); //DataTypeENName
objDataTypeAbbrEN.DataCnName = objRow[conDataTypeAbbr.DataCnName].ToString().Trim(); //数据类型中文名称
objDataTypeAbbrEN.DataTypeAbbr = objRow[conDataTypeAbbr.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objDataTypeAbbrEN.NetSysType = objRow[conDataTypeAbbr.NetSysType].ToString().Trim(); //NET系统类型
objDataTypeAbbrEN.VbNetType = objRow[conDataTypeAbbr.VbNetType].ToString().Trim(); //VBNET类型
objDataTypeAbbrEN.CsType = objRow[conDataTypeAbbr.CsType].ToString().Trim(); //CS类型
objDataTypeAbbrEN.JavaType = objRow[conDataTypeAbbr.JavaType].ToString().Trim(); //JAVA类型
objDataTypeAbbrEN.TypeScriptType = objRow[conDataTypeAbbr.TypeScriptType] == DBNull.Value ? null : objRow[conDataTypeAbbr.TypeScriptType].ToString().Trim(); //TypeScript类型
objDataTypeAbbrEN.JavaObjType = objRow[conDataTypeAbbr.JavaObjType] == DBNull.Value ? null : objRow[conDataTypeAbbr.JavaObjType].ToString().Trim(); //JAVA对象类型
objDataTypeAbbrEN.SwiftType = objRow[conDataTypeAbbr.SwiftType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SwiftType].ToString().Trim(); //SwiftType
objDataTypeAbbrEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsNeedQuote].ToString().Trim()); //是否需要引号
objDataTypeAbbrEN.OraDbType = objRow[conDataTypeAbbr.OraDbType] == DBNull.Value ? null : objRow[conDataTypeAbbr.OraDbType].ToString().Trim(); //Ora数据类型
objDataTypeAbbrEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conDataTypeAbbr.IsReturnType].ToString().Trim()); //是否可作返回类型
objDataTypeAbbrEN.SqlParaType = objRow[conDataTypeAbbr.SqlParaType] == DBNull.Value ? null : objRow[conDataTypeAbbr.SqlParaType].ToString().Trim(); //SQL参数类型
objDataTypeAbbrEN.MySqlType = objRow[conDataTypeAbbr.MySqlType] == DBNull.Value ? null : objRow[conDataTypeAbbr.MySqlType].ToString().Trim(); //MySqlType
objDataTypeAbbrEN.DefaFldLength = objRow[conDataTypeAbbr.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldLength].ToString().Trim()); //默认长度
objDataTypeAbbrEN.DefaFldPrecision = objRow[conDataTypeAbbr.DefaFldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataTypeAbbr.DefaFldPrecision].ToString().Trim()); //默认小数位数
objDataTypeAbbrEN.Memo = objRow[conDataTypeAbbr.Memo] == DBNull.Value ? null : objRow[conDataTypeAbbr.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataTypeAbbrEN.DataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataTypeAbbrEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataTypeAbbrEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataTypeAbbr(ref clsDataTypeAbbrEN objDataTypeAbbrEN)
{
bool bolResult = DataTypeAbbrDA.GetDataTypeAbbr(ref objDataTypeAbbrEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataTypeAbbrEN GetObjByDataTypeId(string strDataTypeId)
{
if (strDataTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDataTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDataTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDataTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDataTypeAbbrEN objDataTypeAbbrEN = DataTypeAbbrDA.GetObjByDataTypeId(strDataTypeId);
return objDataTypeAbbrEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataTypeAbbrEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataTypeAbbrEN objDataTypeAbbrEN = DataTypeAbbrDA.GetFirstObj(strWhereCond);
 return objDataTypeAbbrEN;
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
public static clsDataTypeAbbrEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataTypeAbbrEN objDataTypeAbbrEN = DataTypeAbbrDA.GetObjByDataRow(objRow);
 return objDataTypeAbbrEN;
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
public static clsDataTypeAbbrEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataTypeAbbrEN objDataTypeAbbrEN = DataTypeAbbrDA.GetObjByDataRow(objRow);
 return objDataTypeAbbrEN;
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
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <param name = "lstDataTypeAbbrObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataTypeAbbrEN GetObjByDataTypeIdFromList(string strDataTypeId, List<clsDataTypeAbbrEN> lstDataTypeAbbrObjLst)
{
foreach (clsDataTypeAbbrEN objDataTypeAbbrEN in lstDataTypeAbbrObjLst)
{
if (objDataTypeAbbrEN.DataTypeId == strDataTypeId)
{
return objDataTypeAbbrEN;
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
 string strDataTypeId;
 try
 {
 strDataTypeId = new clsDataTypeAbbrDA().GetFirstID(strWhereCond);
 return strDataTypeId;
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
 arrList = DataTypeAbbrDA.GetID(strWhereCond);
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
bool bolIsExist = DataTypeAbbrDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDataTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DataTypeAbbrDA.IsExist(strDataTypeId);
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
 bolIsExist = clsDataTypeAbbrDA.IsExistTable();
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
 bolIsExist = DataTypeAbbrDA.IsExistTable(strTabName);
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataTypeAbbrEN.DataTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DataTypeAbbrDA.AddNewRecordBySQL2(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataTypeAbbrEN objDataTypeAbbrEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataTypeAbbrBL.IsExist(objDataTypeAbbrEN.DataTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataTypeAbbrEN.DataTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DataTypeAbbrDA.AddNewRecordBySQL2WithReturnKey(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
try
{
bool bolResult = DataTypeAbbrDA.Update(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "objDataTypeAbbrEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 if (string.IsNullOrEmpty(objDataTypeAbbrEN.DataTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataTypeAbbrDA.UpdateBySql2(objDataTypeAbbrEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataTypeAbbrBL.ReFreshCache();

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
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
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDataTypeId)
{
try
{
 clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId(strDataTypeId);

if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(objDataTypeAbbrEN.DataTypeId, "SetUpdDate");
}
if (objDataTypeAbbrEN != null)
{
int intRecNum = DataTypeAbbrDA.DelRecord(strDataTypeId);
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
/// <param name="strDataTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDataTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
//删除与表:[DataTypeAbbr]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataTypeAbbr.DataTypeId,
//strDataTypeId);
//        clsDataTypeAbbrBL.DelDataTypeAbbrsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataTypeAbbrBL.DelRecord(strDataTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataTypeAbbrBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDataTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDataTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataTypeAbbrBL.relatedActions != null)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(strDataTypeId, "UpdRelaTabDate");
}
bool bolResult = DataTypeAbbrDA.DelRecord(strDataTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDataTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataTypeAbbrs(List<string> arrDataTypeIdLst)
{
if (arrDataTypeIdLst.Count == 0) return 0;
try
{
if (clsDataTypeAbbrBL.relatedActions != null)
{
foreach (var strDataTypeId in arrDataTypeIdLst)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(strDataTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = DataTypeAbbrDA.DelDataTypeAbbr(arrDataTypeIdLst);
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
public static int DelDataTypeAbbrsByCond(string strWhereCond)
{
try
{
if (clsDataTypeAbbrBL.relatedActions != null)
{
List<string> arrDataTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDataTypeId in arrDataTypeId)
{
clsDataTypeAbbrBL.relatedActions.UpdRelaTabDate(strDataTypeId, "UpdRelaTabDate");
}
}
int intRecNum = DataTypeAbbrDA.DelDataTypeAbbr(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataTypeAbbr]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDataTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDataTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataTypeAbbrDA.GetSpecSQLObj();
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
//删除与表:[DataTypeAbbr]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataTypeAbbrBL.DelRecord(strDataTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataTypeAbbrBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDataTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataTypeAbbrENS">源对象</param>
 /// <param name = "objDataTypeAbbrENT">目标对象</param>
 public static void CopyTo(clsDataTypeAbbrEN objDataTypeAbbrENS, clsDataTypeAbbrEN objDataTypeAbbrENT)
{
try
{
objDataTypeAbbrENT.DataTypeId = objDataTypeAbbrENS.DataTypeId; //数据类型Id
objDataTypeAbbrENT.DataTypeName = objDataTypeAbbrENS.DataTypeName; //数据类型名称
objDataTypeAbbrENT.DataTypeENName = objDataTypeAbbrENS.DataTypeENName; //DataTypeENName
objDataTypeAbbrENT.DataCnName = objDataTypeAbbrENS.DataCnName; //数据类型中文名称
objDataTypeAbbrENT.DataTypeAbbr = objDataTypeAbbrENS.DataTypeAbbr; //数据类型缩写
objDataTypeAbbrENT.NetSysType = objDataTypeAbbrENS.NetSysType; //NET系统类型
objDataTypeAbbrENT.VbNetType = objDataTypeAbbrENS.VbNetType; //VBNET类型
objDataTypeAbbrENT.CsType = objDataTypeAbbrENS.CsType; //CS类型
objDataTypeAbbrENT.JavaType = objDataTypeAbbrENS.JavaType; //JAVA类型
objDataTypeAbbrENT.TypeScriptType = objDataTypeAbbrENS.TypeScriptType; //TypeScript类型
objDataTypeAbbrENT.JavaObjType = objDataTypeAbbrENS.JavaObjType; //JAVA对象类型
objDataTypeAbbrENT.SwiftType = objDataTypeAbbrENS.SwiftType; //SwiftType
objDataTypeAbbrENT.IsNeedQuote = objDataTypeAbbrENS.IsNeedQuote; //是否需要引号
objDataTypeAbbrENT.OraDbType = objDataTypeAbbrENS.OraDbType; //Ora数据类型
objDataTypeAbbrENT.IsReturnType = objDataTypeAbbrENS.IsReturnType; //是否可作返回类型
objDataTypeAbbrENT.SqlParaType = objDataTypeAbbrENS.SqlParaType; //SQL参数类型
objDataTypeAbbrENT.MySqlType = objDataTypeAbbrENS.MySqlType; //MySqlType
objDataTypeAbbrENT.DefaFldLength = objDataTypeAbbrENS.DefaFldLength; //默认长度
objDataTypeAbbrENT.DefaFldPrecision = objDataTypeAbbrENS.DefaFldPrecision; //默认小数位数
objDataTypeAbbrENT.Memo = objDataTypeAbbrENS.Memo; //说明
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
 /// <param name = "objDataTypeAbbrEN">源简化对象</param>
 public static void SetUpdFlag(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
try
{
objDataTypeAbbrEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataTypeAbbrEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataTypeAbbr.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DataTypeId = objDataTypeAbbrEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conDataTypeAbbr.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DataTypeName = objDataTypeAbbrEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(conDataTypeAbbr.DataTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DataTypeENName = objDataTypeAbbrEN.DataTypeENName == "[null]" ? null :  objDataTypeAbbrEN.DataTypeENName; //DataTypeENName
}
if (arrFldSet.Contains(conDataTypeAbbr.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DataCnName = objDataTypeAbbrEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(conDataTypeAbbr.DataTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DataTypeAbbr = objDataTypeAbbrEN.DataTypeAbbr; //数据类型缩写
}
if (arrFldSet.Contains(conDataTypeAbbr.NetSysType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.NetSysType = objDataTypeAbbrEN.NetSysType; //NET系统类型
}
if (arrFldSet.Contains(conDataTypeAbbr.VbNetType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.VbNetType = objDataTypeAbbrEN.VbNetType; //VBNET类型
}
if (arrFldSet.Contains(conDataTypeAbbr.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.CsType = objDataTypeAbbrEN.CsType; //CS类型
}
if (arrFldSet.Contains(conDataTypeAbbr.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.JavaType = objDataTypeAbbrEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(conDataTypeAbbr.TypeScriptType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.TypeScriptType = objDataTypeAbbrEN.TypeScriptType == "[null]" ? null :  objDataTypeAbbrEN.TypeScriptType; //TypeScript类型
}
if (arrFldSet.Contains(conDataTypeAbbr.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.JavaObjType = objDataTypeAbbrEN.JavaObjType == "[null]" ? null :  objDataTypeAbbrEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(conDataTypeAbbr.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.SwiftType = objDataTypeAbbrEN.SwiftType == "[null]" ? null :  objDataTypeAbbrEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(conDataTypeAbbr.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.IsNeedQuote = objDataTypeAbbrEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(conDataTypeAbbr.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.OraDbType = objDataTypeAbbrEN.OraDbType == "[null]" ? null :  objDataTypeAbbrEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(conDataTypeAbbr.IsReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.IsReturnType = objDataTypeAbbrEN.IsReturnType; //是否可作返回类型
}
if (arrFldSet.Contains(conDataTypeAbbr.SqlParaType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.SqlParaType = objDataTypeAbbrEN.SqlParaType == "[null]" ? null :  objDataTypeAbbrEN.SqlParaType; //SQL参数类型
}
if (arrFldSet.Contains(conDataTypeAbbr.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.MySqlType = objDataTypeAbbrEN.MySqlType == "[null]" ? null :  objDataTypeAbbrEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(conDataTypeAbbr.DefaFldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DefaFldLength = objDataTypeAbbrEN.DefaFldLength; //默认长度
}
if (arrFldSet.Contains(conDataTypeAbbr.DefaFldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.DefaFldPrecision = objDataTypeAbbrEN.DefaFldPrecision; //默认小数位数
}
if (arrFldSet.Contains(conDataTypeAbbr.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDataTypeAbbrEN.Memo = objDataTypeAbbrEN.Memo == "[null]" ? null :  objDataTypeAbbrEN.Memo; //说明
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
 /// <param name = "objDataTypeAbbrEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
try
{
if (objDataTypeAbbrEN.DataTypeENName == "[null]") objDataTypeAbbrEN.DataTypeENName = null; //DataTypeENName
if (objDataTypeAbbrEN.TypeScriptType == "[null]") objDataTypeAbbrEN.TypeScriptType = null; //TypeScript类型
if (objDataTypeAbbrEN.JavaObjType == "[null]") objDataTypeAbbrEN.JavaObjType = null; //JAVA对象类型
if (objDataTypeAbbrEN.SwiftType == "[null]") objDataTypeAbbrEN.SwiftType = null; //SwiftType
if (objDataTypeAbbrEN.OraDbType == "[null]") objDataTypeAbbrEN.OraDbType = null; //Ora数据类型
if (objDataTypeAbbrEN.SqlParaType == "[null]") objDataTypeAbbrEN.SqlParaType = null; //SQL参数类型
if (objDataTypeAbbrEN.MySqlType == "[null]") objDataTypeAbbrEN.MySqlType = null; //MySqlType
if (objDataTypeAbbrEN.Memo == "[null]") objDataTypeAbbrEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 DataTypeAbbrDA.CheckPropertyNew(objDataTypeAbbrEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataTypeAbbrEN objDataTypeAbbrEN)
{
 DataTypeAbbrDA.CheckProperty4Condition(objDataTypeAbbrEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DataTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataTypeAbbr.DataTypeId); 
List<clsDataTypeAbbrEN> arrObjLst = clsDataTypeAbbrBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataTypeAbbrEN objDataTypeAbbrEN = new clsDataTypeAbbrEN()
{
DataTypeId = "0",
DataTypeName = "选[数据类型]..."
};
arrObjLst.Insert(0, objDataTypeAbbrEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataTypeAbbr.DataTypeId;
objComboBox.DisplayMember = conDataTypeAbbr.DataTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DataTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDataTypeAbbr.DataTypeId); 
IEnumerable<clsDataTypeAbbrEN> arrObjLst = clsDataTypeAbbrBL.GetObjLst(strCondition);
objDDL.DataValueField = conDataTypeAbbr.DataTypeId;
objDDL.DataTextField = conDataTypeAbbr.DataTypeName;
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
public static void BindDdl_DataTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据类型]...","0");
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLst = GetAllDataTypeAbbrObjLstCache(); 
objDDL.DataValueField = conDataTypeAbbr.DataTypeId;
objDDL.DataTextField = conDataTypeAbbr.DataTypeName;
objDDL.DataSource = arrDataTypeAbbrObjLst;
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
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataTypeId");
//if (arrDataTypeAbbrObjLstCache == null)
//{
//arrDataTypeAbbrObjLstCache = DataTypeAbbrDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataTypeAbbrEN GetObjByDataTypeIdCache(string strDataTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrDataTypeAbbrObjLst_Sel =
arrDataTypeAbbrObjLstCache
.Where(x=> x.DataTypeId == strDataTypeId 
);
if (arrDataTypeAbbrObjLst_Sel.Count() == 0)
{
   clsDataTypeAbbrEN obj = clsDataTypeAbbrBL.GetObjByDataTypeId(strDataTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDataTypeAbbrObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataTypeNameByDataTypeIdCache(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return "";
//获取缓存中的对象列表
clsDataTypeAbbrEN objDataTypeAbbr = GetObjByDataTypeIdCache(strDataTypeId);
if (objDataTypeAbbr == null) return "";
return objDataTypeAbbr.DataTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataTypeIdCache(string strDataTypeId)
{
if (string.IsNullOrEmpty(strDataTypeId) == true) return "";
//获取缓存中的对象列表
clsDataTypeAbbrEN objDataTypeAbbr = GetObjByDataTypeIdCache(strDataTypeId);
if (objDataTypeAbbr == null) return "";
return objDataTypeAbbr.DataTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataTypeAbbrEN> GetAllDataTypeAbbrObjLstCache()
{
//获取缓存中的对象列表
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = GetObjLstCache(); 
return arrDataTypeAbbrObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataTypeAbbrEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
List<clsDataTypeAbbrEN> arrDataTypeAbbrObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataTypeAbbrObjLstCache;
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
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataTypeAbbrEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDataTypeAbbrEN._RefreshTimeLst.Count == 0) return "";
return clsDataTypeAbbrEN._RefreshTimeLst[clsDataTypeAbbrEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsDataTypeAbbrBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataTypeAbbrEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataTypeAbbrEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDataTypeAbbrBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strDataTypeId)
{
if (strInFldName != conDataTypeAbbr.DataTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataTypeAbbr._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataTypeAbbr._AttributeName));
throw new Exception(strMsg);
}
var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(strDataTypeId);
if (objDataTypeAbbr == null) return "";
return objDataTypeAbbr[strOutFldName].ToString();
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
int intRecCount = clsDataTypeAbbrDA.GetRecCount(strTabName);
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
int intRecCount = clsDataTypeAbbrDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataTypeAbbrDA.GetRecCount();
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
int intRecCount = clsDataTypeAbbrDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataTypeAbbrCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataTypeAbbrEN objDataTypeAbbrCond)
{
List<clsDataTypeAbbrEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataTypeAbbrEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataTypeAbbr._AttributeName)
{
if (objDataTypeAbbrCond.IsUpdated(strFldName) == false) continue;
if (objDataTypeAbbrCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataTypeAbbrCond[strFldName].ToString());
}
else
{
if (objDataTypeAbbrCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataTypeAbbrCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataTypeAbbrCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataTypeAbbrCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataTypeAbbrCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataTypeAbbrCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataTypeAbbrCond[strFldName]));
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
 List<string> arrList = clsDataTypeAbbrDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataTypeAbbrDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataTypeAbbrDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataTypeAbbrDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataTypeAbbrDA.SetFldValue(clsDataTypeAbbrEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataTypeAbbrDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataTypeAbbrDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataTypeAbbrDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataTypeAbbrDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataTypeAbbr] "); 
 strCreateTabCode.Append(" ( "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) primary key, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) not Null, "); 
 // /**DataTypeENName*/ 
 strCreateTabCode.Append(" DataTypeENName varchar(100) Null, "); 
 // /**数据类型中文名称*/ 
 strCreateTabCode.Append(" DataCnName varchar(100) not Null, "); 
 // /**数据类型缩写*/ 
 strCreateTabCode.Append(" DataTypeAbbr varchar(5) not Null, "); 
 // /**NET系统类型*/ 
 strCreateTabCode.Append(" NetSysType varchar(20) not Null, "); 
 // /**VBNET类型*/ 
 strCreateTabCode.Append(" VbNetType varchar(100) not Null, "); 
 // /**CS类型*/ 
 strCreateTabCode.Append(" CsType varchar(100) not Null, "); 
 // /**JAVA类型*/ 
 strCreateTabCode.Append(" JavaType varchar(100) not Null, "); 
 // /**TypeScript类型*/ 
 strCreateTabCode.Append(" TypeScriptType varchar(100) Null, "); 
 // /**JAVA对象类型*/ 
 strCreateTabCode.Append(" JavaObjType varchar(100) Null, "); 
 // /**SwiftType*/ 
 strCreateTabCode.Append(" SwiftType varchar(100) Null, "); 
 // /**是否需要引号*/ 
 strCreateTabCode.Append(" IsNeedQuote bit not Null, "); 
 // /**Ora数据类型*/ 
 strCreateTabCode.Append(" OraDbType varchar(100) Null, "); 
 // /**是否可作返回类型*/ 
 strCreateTabCode.Append(" IsReturnType bit Null, "); 
 // /**SQL参数类型*/ 
 strCreateTabCode.Append(" SqlParaType varchar(100) Null, "); 
 // /**MySqlType*/ 
 strCreateTabCode.Append(" MySqlType varchar(100) Null, "); 
 // /**默认长度*/ 
 strCreateTabCode.Append(" DefaFldLength int Null, "); 
 // /**默认小数位数*/ 
 strCreateTabCode.Append(" DefaFldPrecision int Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据类型(DataTypeAbbr)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataTypeAbbr : clsCommFun4BL
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
clsDataTypeAbbrBL.ReFreshThisCache();
}
}

}