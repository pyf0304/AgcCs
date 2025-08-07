
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSelfDefDataTypeBL
 表名:SelfDefDataType(00050350)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:35
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
public static class  clsSelfDefDataTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSdDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSelfDefDataTypeEN GetObj(this K_SdDataTypeId_SelfDefDataType myKey)
{
clsSelfDefDataTypeEN objSelfDefDataTypeEN = clsSelfDefDataTypeBL.SelfDefDataTypeDA.GetObjBySdDataTypeId(myKey.Value);
return objSelfDefDataTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSelfDefDataTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据类型名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsSelfDefDataTypeBL.AddNewRecord)", objSelfDefDataTypeEN.DataTypeName,objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsSelfDefDataTypeBL.SelfDefDataTypeDA.AddNewRecordBySQL2(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSelfDefDataTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSelfDefDataTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(数据类型名称(DataTypeName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objSelfDefDataTypeEN.DataTypeName, objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSelfDefDataTypeEN.AddNewRecord();
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSelfDefDataTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据类型名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsSelfDefDataTypeBL.AddNewRecordWithMaxId)", objSelfDefDataTypeEN.DataTypeName,objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
string strSdDataTypeId = clsSelfDefDataTypeBL.SelfDefDataTypeDA.AddNewRecordBySQL2WithReturnKey(objSelfDefDataTypeEN);
     objSelfDefDataTypeEN.SdDataTypeId = strSdDataTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
}
return strSdDataTypeId;
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSelfDefDataTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!数据类型名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsSelfDefDataTypeBL.AddNewRecordWithReturnKey)", objSelfDefDataTypeEN.DataTypeName,objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
string strKey = clsSelfDefDataTypeBL.SelfDefDataTypeDA.AddNewRecordBySQL2WithReturnKey(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSdDataTypeId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSdDataTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
}
objSelfDefDataTypeEN.SdDataTypeId = strSdDataTypeId; //自定义数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SdDataTypeId) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SdDataTypeId, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SdDataTypeId] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataTypeName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, conSelfDefDataType.DataTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, conSelfDefDataType.DataTypeName);
}
objSelfDefDataTypeEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataTypeName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataTypeName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataTypeName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsObject(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsObject, string strComparisonOp="")
	{
objSelfDefDataTypeEN.IsObject = bolIsObject; //是否对象
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsObject) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsObject, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsObject] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaVarName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDefaVarName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaVarName, 50, conSelfDefDataType.DefaVarName);
}
objSelfDefDataTypeEN.DefaVarName = strDefaVarName; //默认变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaVarName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaVarName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaVarName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataCnName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, conSelfDefDataType.DataCnName);
}
objSelfDefDataTypeEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataCnName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataCnName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataCnName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataTypeAbbr(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataTypeAbbr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, conSelfDefDataType.DataTypeAbbr);
}
objSelfDefDataTypeEN.DataTypeAbbr = strDataTypeAbbr; //数据类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataTypeAbbr) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataTypeAbbr, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataTypeAbbr] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetVbNetType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strVbNetType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVbNetType, 100, conSelfDefDataType.VbNetType);
}
objSelfDefDataTypeEN.VbNetType = strVbNetType; //VBNET类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.VbNetType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.VbNetType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.VbNetType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetCsType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, conSelfDefDataType.CsType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, conSelfDefDataType.CsType);
}
objSelfDefDataTypeEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.CsType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.CsType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.CsType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetJavaType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strJavaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, conSelfDefDataType.JavaType);
}
objSelfDefDataTypeEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.JavaType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.JavaType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.JavaType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetJavaObjType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, conSelfDefDataType.JavaObjType);
}
objSelfDefDataTypeEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.JavaObjType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.JavaObjType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.JavaObjType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSwiftType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, conSelfDefDataType.SwiftType);
}
objSelfDefDataTypeEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SwiftType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SwiftType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SwiftType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsNeedQuote(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, conSelfDefDataType.IsNeedQuote);
objSelfDefDataTypeEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsNeedQuote) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsNeedQuote, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsNeedQuote] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetOraDbType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strOraDbType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, conSelfDefDataType.OraDbType);
}
objSelfDefDataTypeEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.OraDbType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.OraDbType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.OraDbType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsReturnType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsReturnType, string strComparisonOp="")
	{
objSelfDefDataTypeEN.IsReturnType = bolIsReturnType; //是否可作返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsReturnType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsReturnType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsReturnType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSqlParaType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSqlParaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlParaType, 100, conSelfDefDataType.SqlParaType);
}
objSelfDefDataTypeEN.SqlParaType = strSqlParaType; //SQL参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SqlParaType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SqlParaType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SqlParaType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetMySqlType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, conSelfDefDataType.MySqlType);
}
objSelfDefDataTypeEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.MySqlType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.MySqlType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.MySqlType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaFldLength(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, int? intDefaFldLength, string strComparisonOp="")
	{
objSelfDefDataTypeEN.DefaFldLength = intDefaFldLength; //默认长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaFldLength) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaFldLength, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaFldLength] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaFldPrecision(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, int intDefaFldPrecision, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intDefaFldPrecision, conSelfDefDataType.DefaFldPrecision);
objSelfDefDataTypeEN.DefaFldPrecision = intDefaFldPrecision; //默认小数位数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaFldPrecision) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaFldPrecision, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaFldPrecision] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetPrjId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSelfDefDataType.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSelfDefDataType.PrjId);
}
objSelfDefDataTypeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.PrjId) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.PrjId, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.PrjId] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetUpdDate(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSelfDefDataType.UpdDate);
}
objSelfDefDataTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.UpdDate) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.UpdDate, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.UpdDate] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetUpdUser(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSelfDefDataType.UpdUser);
}
objSelfDefDataTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.UpdUser) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.UpdUser, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.UpdUser] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetMemo(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSelfDefDataType.Memo);
}
objSelfDefDataTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.Memo) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.Memo, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.Memo] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSelfDefDataTypeEN.CheckPropertyNew();
clsSelfDefDataTypeEN objSelfDefDataTypeCond = new clsSelfDefDataTypeEN();
string strCondition = objSelfDefDataTypeCond
.SetSdDataTypeId(objSelfDefDataTypeEN.SdDataTypeId, "<>")
.SetDataTypeName(objSelfDefDataTypeEN.DataTypeName, "=")
.SetPrjId(objSelfDefDataTypeEN.PrjId, "=")
.GetCombineCondition();
objSelfDefDataTypeEN._IsCheckProperty = true;
bool bolIsExist = clsSelfDefDataTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DataTypeName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSelfDefDataTypeEN.Update();
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
 /// <param name = "objSelfDefDataType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSelfDefDataTypeEN objSelfDefDataType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSelfDefDataTypeEN objSelfDefDataTypeCond = new clsSelfDefDataTypeEN();
string strCondition = objSelfDefDataTypeCond
.SetDataTypeName(objSelfDefDataType.DataTypeName, "=")
.SetPrjId(objSelfDefDataType.PrjId, "=")
.GetCombineCondition();
objSelfDefDataType._IsCheckProperty = true;
bool bolIsExist = clsSelfDefDataTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSelfDefDataType.SdDataTypeId = clsSelfDefDataTypeBL.GetFirstID_S(strCondition);
objSelfDefDataType.UpdateWithCondition(strCondition);
}
else
{
objSelfDefDataType.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
objSelfDefDataType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSelfDefDataTypeBL.SelfDefDataTypeDA.UpdateBySql2(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSelfDefDataTypeBL.SelfDefDataTypeDA.UpdateBySql2(objSelfDefDataTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsSelfDefDataTypeBL.SelfDefDataTypeDA.UpdateBySqlWithCondition(objSelfDefDataTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSelfDefDataTypeBL.SelfDefDataTypeDA.UpdateBySqlWithConditionTransaction(objSelfDefDataTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
int intRecNum = clsSelfDefDataTypeBL.SelfDefDataTypeDA.DelRecord(objSelfDefDataTypeEN.SdDataTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeENS">源对象</param>
 /// <param name = "objSelfDefDataTypeENT">目标对象</param>
 public static void CopyTo(this clsSelfDefDataTypeEN objSelfDefDataTypeENS, clsSelfDefDataTypeEN objSelfDefDataTypeENT)
{
try
{
objSelfDefDataTypeENT.SdDataTypeId = objSelfDefDataTypeENS.SdDataTypeId; //自定义数据类型Id
objSelfDefDataTypeENT.DataTypeName = objSelfDefDataTypeENS.DataTypeName; //数据类型名称
objSelfDefDataTypeENT.IsObject = objSelfDefDataTypeENS.IsObject; //是否对象
objSelfDefDataTypeENT.DefaVarName = objSelfDefDataTypeENS.DefaVarName; //默认变量名
objSelfDefDataTypeENT.DataCnName = objSelfDefDataTypeENS.DataCnName; //数据类型中文名称
objSelfDefDataTypeENT.DataTypeAbbr = objSelfDefDataTypeENS.DataTypeAbbr; //数据类型缩写
objSelfDefDataTypeENT.VbNetType = objSelfDefDataTypeENS.VbNetType; //VBNET类型
objSelfDefDataTypeENT.CsType = objSelfDefDataTypeENS.CsType; //CS类型
objSelfDefDataTypeENT.JavaType = objSelfDefDataTypeENS.JavaType; //JAVA类型
objSelfDefDataTypeENT.JavaObjType = objSelfDefDataTypeENS.JavaObjType; //JAVA对象类型
objSelfDefDataTypeENT.SwiftType = objSelfDefDataTypeENS.SwiftType; //SwiftType
objSelfDefDataTypeENT.IsNeedQuote = objSelfDefDataTypeENS.IsNeedQuote; //是否需要引号
objSelfDefDataTypeENT.OraDbType = objSelfDefDataTypeENS.OraDbType; //Ora数据类型
objSelfDefDataTypeENT.IsReturnType = objSelfDefDataTypeENS.IsReturnType; //是否可作返回类型
objSelfDefDataTypeENT.SqlParaType = objSelfDefDataTypeENS.SqlParaType; //SQL参数类型
objSelfDefDataTypeENT.MySqlType = objSelfDefDataTypeENS.MySqlType; //MySqlType
objSelfDefDataTypeENT.DefaFldLength = objSelfDefDataTypeENS.DefaFldLength; //默认长度
objSelfDefDataTypeENT.DefaFldPrecision = objSelfDefDataTypeENS.DefaFldPrecision; //默认小数位数
objSelfDefDataTypeENT.PrjId = objSelfDefDataTypeENS.PrjId; //工程Id
objSelfDefDataTypeENT.UpdDate = objSelfDefDataTypeENS.UpdDate; //修改日期
objSelfDefDataTypeENT.UpdUser = objSelfDefDataTypeENS.UpdUser; //修改者
objSelfDefDataTypeENT.Memo = objSelfDefDataTypeENS.Memo; //说明
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
 /// <param name = "objSelfDefDataTypeENS">源对象</param>
 /// <returns>目标对象=>clsSelfDefDataTypeEN:objSelfDefDataTypeENT</returns>
 public static clsSelfDefDataTypeEN CopyTo(this clsSelfDefDataTypeEN objSelfDefDataTypeENS)
{
try
{
 clsSelfDefDataTypeEN objSelfDefDataTypeENT = new clsSelfDefDataTypeEN()
{
SdDataTypeId = objSelfDefDataTypeENS.SdDataTypeId, //自定义数据类型Id
DataTypeName = objSelfDefDataTypeENS.DataTypeName, //数据类型名称
IsObject = objSelfDefDataTypeENS.IsObject, //是否对象
DefaVarName = objSelfDefDataTypeENS.DefaVarName, //默认变量名
DataCnName = objSelfDefDataTypeENS.DataCnName, //数据类型中文名称
DataTypeAbbr = objSelfDefDataTypeENS.DataTypeAbbr, //数据类型缩写
VbNetType = objSelfDefDataTypeENS.VbNetType, //VBNET类型
CsType = objSelfDefDataTypeENS.CsType, //CS类型
JavaType = objSelfDefDataTypeENS.JavaType, //JAVA类型
JavaObjType = objSelfDefDataTypeENS.JavaObjType, //JAVA对象类型
SwiftType = objSelfDefDataTypeENS.SwiftType, //SwiftType
IsNeedQuote = objSelfDefDataTypeENS.IsNeedQuote, //是否需要引号
OraDbType = objSelfDefDataTypeENS.OraDbType, //Ora数据类型
IsReturnType = objSelfDefDataTypeENS.IsReturnType, //是否可作返回类型
SqlParaType = objSelfDefDataTypeENS.SqlParaType, //SQL参数类型
MySqlType = objSelfDefDataTypeENS.MySqlType, //MySqlType
DefaFldLength = objSelfDefDataTypeENS.DefaFldLength, //默认长度
DefaFldPrecision = objSelfDefDataTypeENS.DefaFldPrecision, //默认小数位数
PrjId = objSelfDefDataTypeENS.PrjId, //工程Id
UpdDate = objSelfDefDataTypeENS.UpdDate, //修改日期
UpdUser = objSelfDefDataTypeENS.UpdUser, //修改者
Memo = objSelfDefDataTypeENS.Memo, //说明
};
 return objSelfDefDataTypeENT;
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
public static void CheckPropertyNew(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 clsSelfDefDataTypeBL.SelfDefDataTypeDA.CheckPropertyNew(objSelfDefDataTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 clsSelfDefDataTypeBL.SelfDefDataTypeDA.CheckProperty4Condition(objSelfDefDataTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSelfDefDataTypeEN objSelfDefDataTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SdDataTypeId) == true)
{
string strComparisonOpSdDataTypeId = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SdDataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SdDataTypeId, objSelfDefDataTypeCond.SdDataTypeId, strComparisonOpSdDataTypeId);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataTypeName, objSelfDefDataTypeCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsObject) == true)
{
if (objSelfDefDataTypeCond.IsObject == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsObject);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsObject);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaVarName) == true)
{
string strComparisonOpDefaVarName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaVarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DefaVarName, objSelfDefDataTypeCond.DefaVarName, strComparisonOpDefaVarName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataCnName) == true)
{
string strComparisonOpDataCnName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataCnName, objSelfDefDataTypeCond.DataCnName, strComparisonOpDataCnName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataTypeAbbr) == true)
{
string strComparisonOpDataTypeAbbr = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataTypeAbbr, objSelfDefDataTypeCond.DataTypeAbbr, strComparisonOpDataTypeAbbr);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.VbNetType) == true)
{
string strComparisonOpVbNetType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.VbNetType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.VbNetType, objSelfDefDataTypeCond.VbNetType, strComparisonOpVbNetType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.CsType) == true)
{
string strComparisonOpCsType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.CsType, objSelfDefDataTypeCond.CsType, strComparisonOpCsType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.JavaType) == true)
{
string strComparisonOpJavaType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.JavaType, objSelfDefDataTypeCond.JavaType, strComparisonOpJavaType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.JavaObjType, objSelfDefDataTypeCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SwiftType) == true)
{
string strComparisonOpSwiftType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SwiftType, objSelfDefDataTypeCond.SwiftType, strComparisonOpSwiftType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsNeedQuote) == true)
{
if (objSelfDefDataTypeCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsNeedQuote);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.OraDbType) == true)
{
string strComparisonOpOraDbType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.OraDbType, objSelfDefDataTypeCond.OraDbType, strComparisonOpOraDbType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsReturnType) == true)
{
if (objSelfDefDataTypeCond.IsReturnType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsReturnType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsReturnType);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SqlParaType) == true)
{
string strComparisonOpSqlParaType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SqlParaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SqlParaType, objSelfDefDataTypeCond.SqlParaType, strComparisonOpSqlParaType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.MySqlType) == true)
{
string strComparisonOpMySqlType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.MySqlType, objSelfDefDataTypeCond.MySqlType, strComparisonOpMySqlType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaFldLength) == true)
{
string strComparisonOpDefaFldLength = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaFldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conSelfDefDataType.DefaFldLength, objSelfDefDataTypeCond.DefaFldLength, strComparisonOpDefaFldLength);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaFldPrecision) == true)
{
string strComparisonOpDefaFldPrecision = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaFldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conSelfDefDataType.DefaFldPrecision, objSelfDefDataTypeCond.DefaFldPrecision, strComparisonOpDefaFldPrecision);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.PrjId) == true)
{
string strComparisonOpPrjId = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.PrjId, objSelfDefDataTypeCond.PrjId, strComparisonOpPrjId);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.UpdDate) == true)
{
string strComparisonOpUpdDate = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.UpdDate, objSelfDefDataTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.UpdUser) == true)
{
string strComparisonOpUpdUser = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.UpdUser, objSelfDefDataTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.Memo) == true)
{
string strComparisonOpMemo = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.Memo, objSelfDefDataTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SelfDefDataType(自定义数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DataTypeName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSelfDefDataTypeEN == null) return true;
if (objSelfDefDataTypeEN.SdDataTypeId == null || objSelfDefDataTypeEN.SdDataTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 if (objSelfDefDataTypeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objSelfDefDataTypeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
}
if (clsSelfDefDataTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SdDataTypeId !=  '{0}'", objSelfDefDataTypeEN.SdDataTypeId);
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
if (clsSelfDefDataTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SelfDefDataType(自定义数据类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DataTypeName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSelfDefDataTypeEN == null) return "";
if (objSelfDefDataTypeEN.SdDataTypeId == null || objSelfDefDataTypeEN.SdDataTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 if (objSelfDefDataTypeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objSelfDefDataTypeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SdDataTypeId !=  '{0}'", objSelfDefDataTypeEN.SdDataTypeId);
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SelfDefDataType
{
public virtual bool UpdRelaTabDate(string strSdDataTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 自定义数据类型(SelfDefDataType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSelfDefDataTypeBL
{
public static RelatedActions_SelfDefDataType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSelfDefDataTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSelfDefDataTypeDA SelfDefDataTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSelfDefDataTypeDA();
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
 public clsSelfDefDataTypeBL()
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
if (string.IsNullOrEmpty(clsSelfDefDataTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSelfDefDataTypeEN._ConnectString);
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
public static DataTable GetDataTable_SelfDefDataType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SelfDefDataTypeDA.GetDataTable_SelfDefDataType(strWhereCond);
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
objDT = SelfDefDataTypeDA.GetDataTable(strWhereCond);
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
objDT = SelfDefDataTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SelfDefDataTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SelfDefDataTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SelfDefDataTypeDA.GetDataTable_Top(objTopPara);
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
objDT = SelfDefDataTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SelfDefDataTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SelfDefDataTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSdDataTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstBySdDataTypeIdLst(List<string> arrSdDataTypeIdLst)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSdDataTypeIdLst, true);
 string strWhereCond = string.Format("SdDataTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSdDataTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSelfDefDataTypeEN> GetObjLstBySdDataTypeIdLstCache(List<string> arrSdDataTypeIdLst)
{
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel =
arrSelfDefDataTypeObjLstCache
.Where(x => arrSdDataTypeIdLst.Contains(x.SdDataTypeId));
return arrSelfDefDataTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLst(string strWhereCond)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
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
public static List<clsSelfDefDataTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSelfDefDataTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSelfDefDataTypeEN> GetSubObjLstCache(clsSelfDefDataTypeEN objSelfDefDataTypeCond)
{
List<clsSelfDefDataTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSelfDefDataType._AttributeName)
{
if (objSelfDefDataTypeCond.IsUpdated(strFldName) == false) continue;
if (objSelfDefDataTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSelfDefDataTypeCond[strFldName].ToString());
}
else
{
if (objSelfDefDataTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSelfDefDataTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSelfDefDataTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSelfDefDataTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSelfDefDataTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSelfDefDataTypeCond[strFldName]));
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
public static List<clsSelfDefDataTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
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
public static List<clsSelfDefDataTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
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
List<clsSelfDefDataTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSelfDefDataTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSelfDefDataTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
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
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
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
public static List<clsSelfDefDataTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSelfDefDataTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
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
public static List<clsSelfDefDataTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSelfDefDataTypeEN> arrObjLst = new List<clsSelfDefDataTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
try
{
objSelfDefDataTypeEN.SdDataTypeId = objRow[conSelfDefDataType.SdDataTypeId].ToString().Trim(); //自定义数据类型Id
objSelfDefDataTypeEN.DataTypeName = objRow[conSelfDefDataType.DataTypeName].ToString().Trim(); //数据类型名称
objSelfDefDataTypeEN.IsObject = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsObject].ToString().Trim()); //是否对象
objSelfDefDataTypeEN.DefaVarName = objRow[conSelfDefDataType.DefaVarName] == DBNull.Value ? null : objRow[conSelfDefDataType.DefaVarName].ToString().Trim(); //默认变量名
objSelfDefDataTypeEN.DataCnName = objRow[conSelfDefDataType.DataCnName] == DBNull.Value ? null : objRow[conSelfDefDataType.DataCnName].ToString().Trim(); //数据类型中文名称
objSelfDefDataTypeEN.DataTypeAbbr = objRow[conSelfDefDataType.DataTypeAbbr] == DBNull.Value ? null : objRow[conSelfDefDataType.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objSelfDefDataTypeEN.VbNetType = objRow[conSelfDefDataType.VbNetType] == DBNull.Value ? null : objRow[conSelfDefDataType.VbNetType].ToString().Trim(); //VBNET类型
objSelfDefDataTypeEN.CsType = objRow[conSelfDefDataType.CsType].ToString().Trim(); //CS类型
objSelfDefDataTypeEN.JavaType = objRow[conSelfDefDataType.JavaType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaType].ToString().Trim(); //JAVA类型
objSelfDefDataTypeEN.JavaObjType = objRow[conSelfDefDataType.JavaObjType] == DBNull.Value ? null : objRow[conSelfDefDataType.JavaObjType].ToString().Trim(); //JAVA对象类型
objSelfDefDataTypeEN.SwiftType = objRow[conSelfDefDataType.SwiftType] == DBNull.Value ? null : objRow[conSelfDefDataType.SwiftType].ToString().Trim(); //SwiftType
objSelfDefDataTypeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsNeedQuote].ToString().Trim()); //是否需要引号
objSelfDefDataTypeEN.OraDbType = objRow[conSelfDefDataType.OraDbType] == DBNull.Value ? null : objRow[conSelfDefDataType.OraDbType].ToString().Trim(); //Ora数据类型
objSelfDefDataTypeEN.IsReturnType = clsEntityBase2.TransNullToBool_S(objRow[conSelfDefDataType.IsReturnType].ToString().Trim()); //是否可作返回类型
objSelfDefDataTypeEN.SqlParaType = objRow[conSelfDefDataType.SqlParaType] == DBNull.Value ? null : objRow[conSelfDefDataType.SqlParaType].ToString().Trim(); //SQL参数类型
objSelfDefDataTypeEN.MySqlType = objRow[conSelfDefDataType.MySqlType] == DBNull.Value ? null : objRow[conSelfDefDataType.MySqlType].ToString().Trim(); //MySqlType
objSelfDefDataTypeEN.DefaFldLength = objRow[conSelfDefDataType.DefaFldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSelfDefDataType.DefaFldLength].ToString().Trim()); //默认长度
objSelfDefDataTypeEN.DefaFldPrecision = Int32.Parse(objRow[conSelfDefDataType.DefaFldPrecision].ToString().Trim()); //默认小数位数
objSelfDefDataTypeEN.PrjId = objRow[conSelfDefDataType.PrjId] == DBNull.Value ? null : objRow[conSelfDefDataType.PrjId].ToString().Trim(); //工程Id
objSelfDefDataTypeEN.UpdDate = objRow[conSelfDefDataType.UpdDate] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdDate].ToString().Trim(); //修改日期
objSelfDefDataTypeEN.UpdUser = objRow[conSelfDefDataType.UpdUser] == DBNull.Value ? null : objRow[conSelfDefDataType.UpdUser].ToString().Trim(); //修改者
objSelfDefDataTypeEN.Memo = objRow[conSelfDefDataType.Memo] == DBNull.Value ? null : objRow[conSelfDefDataType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSelfDefDataTypeEN.SdDataTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSelfDefDataTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSelfDefDataType(ref clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
bool bolResult = SelfDefDataTypeDA.GetSelfDefDataType(ref objSelfDefDataTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSdDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSelfDefDataTypeEN GetObjBySdDataTypeId(string strSdDataTypeId)
{
if (strSdDataTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSdDataTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSdDataTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSdDataTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSelfDefDataTypeEN objSelfDefDataTypeEN = SelfDefDataTypeDA.GetObjBySdDataTypeId(strSdDataTypeId);
return objSelfDefDataTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSelfDefDataTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSelfDefDataTypeEN objSelfDefDataTypeEN = SelfDefDataTypeDA.GetFirstObj(strWhereCond);
 return objSelfDefDataTypeEN;
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
public static clsSelfDefDataTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSelfDefDataTypeEN objSelfDefDataTypeEN = SelfDefDataTypeDA.GetObjByDataRow(objRow);
 return objSelfDefDataTypeEN;
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
public static clsSelfDefDataTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSelfDefDataTypeEN objSelfDefDataTypeEN = SelfDefDataTypeDA.GetObjByDataRow(objRow);
 return objSelfDefDataTypeEN;
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
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <param name = "lstSelfDefDataTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSelfDefDataTypeEN GetObjBySdDataTypeIdFromList(string strSdDataTypeId, List<clsSelfDefDataTypeEN> lstSelfDefDataTypeObjLst)
{
foreach (clsSelfDefDataTypeEN objSelfDefDataTypeEN in lstSelfDefDataTypeObjLst)
{
if (objSelfDefDataTypeEN.SdDataTypeId == strSdDataTypeId)
{
return objSelfDefDataTypeEN;
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
 string strMaxSdDataTypeId;
 try
 {
 strMaxSdDataTypeId = clsSelfDefDataTypeDA.GetMaxStrId();
 return strMaxSdDataTypeId;
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
 string strSdDataTypeId;
 try
 {
 strSdDataTypeId = new clsSelfDefDataTypeDA().GetFirstID(strWhereCond);
 return strSdDataTypeId;
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
 arrList = SelfDefDataTypeDA.GetID(strWhereCond);
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
bool bolIsExist = SelfDefDataTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSdDataTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SelfDefDataTypeDA.IsExist(strSdDataTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strSdDataTypeId">自定义数据类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strSdDataTypeId, string strOpUser)
{
clsSelfDefDataTypeEN objSelfDefDataTypeEN = clsSelfDefDataTypeBL.GetObjBySdDataTypeId(strSdDataTypeId);
objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSelfDefDataTypeEN.UpdUser = strOpUser;
return clsSelfDefDataTypeBL.UpdateBySql2(objSelfDefDataTypeEN);
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
 bolIsExist = clsSelfDefDataTypeDA.IsExistTable();
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
 bolIsExist = SelfDefDataTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSelfDefDataTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据类型名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsSelfDefDataTypeBL.AddNewRecordBySql2)", objSelfDefDataTypeEN.DataTypeName,objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
bool bolResult = SelfDefDataTypeDA.AddNewRecordBySQL2(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSelfDefDataTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!数据类型名称 = [{0}],工程Id = [{1}]的数据已经存在!(in clsSelfDefDataTypeBL.AddNewRecordBySql2WithReturnKey)", objSelfDefDataTypeEN.DataTypeName,objSelfDefDataTypeEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeBL.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeBL.GetMaxStrId_S();
 }
string strKey = SelfDefDataTypeDA.AddNewRecordBySQL2WithReturnKey(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
bool bolResult = SelfDefDataTypeDA.Update(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SelfDefDataTypeDA.UpdateBySql2(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeBL.ReFreshCache();

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
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
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSdDataTypeId)
{
try
{
 clsSelfDefDataTypeEN objSelfDefDataTypeEN = clsSelfDefDataTypeBL.GetObjBySdDataTypeId(strSdDataTypeId);

if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(objSelfDefDataTypeEN.SdDataTypeId, objSelfDefDataTypeEN.UpdUser);
}
if (objSelfDefDataTypeEN != null)
{
int intRecNum = SelfDefDataTypeDA.DelRecord(strSdDataTypeId);
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
/// <param name="strSdDataTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSdDataTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
//删除与表:[SelfDefDataType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSelfDefDataType.SdDataTypeId,
//strSdDataTypeId);
//        clsSelfDefDataTypeBL.DelSelfDefDataTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSelfDefDataTypeBL.DelRecord(strSdDataTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSelfDefDataTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSdDataTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSdDataTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSdDataTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSelfDefDataTypeBL.relatedActions != null)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(strSdDataTypeId, "UpdRelaTabDate");
}
bool bolResult = SelfDefDataTypeDA.DelRecord(strSdDataTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSdDataTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSelfDefDataTypes(List<string> arrSdDataTypeIdLst)
{
if (arrSdDataTypeIdLst.Count == 0) return 0;
try
{
if (clsSelfDefDataTypeBL.relatedActions != null)
{
foreach (var strSdDataTypeId in arrSdDataTypeIdLst)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(strSdDataTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = SelfDefDataTypeDA.DelSelfDefDataType(arrSdDataTypeIdLst);
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
public static int DelSelfDefDataTypesByCond(string strWhereCond)
{
try
{
if (clsSelfDefDataTypeBL.relatedActions != null)
{
List<string> arrSdDataTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSdDataTypeId in arrSdDataTypeId)
{
clsSelfDefDataTypeBL.relatedActions.UpdRelaTabDate(strSdDataTypeId, "UpdRelaTabDate");
}
}
int intRecNum = SelfDefDataTypeDA.DelSelfDefDataType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SelfDefDataType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSdDataTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSdDataTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSelfDefDataTypeDA.GetSpecSQLObj();
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
//删除与表:[SelfDefDataType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSelfDefDataTypeBL.DelRecord(strSdDataTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSelfDefDataTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSdDataTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSelfDefDataTypeENS">源对象</param>
 /// <param name = "objSelfDefDataTypeENT">目标对象</param>
 public static void CopyTo(clsSelfDefDataTypeEN objSelfDefDataTypeENS, clsSelfDefDataTypeEN objSelfDefDataTypeENT)
{
try
{
objSelfDefDataTypeENT.SdDataTypeId = objSelfDefDataTypeENS.SdDataTypeId; //自定义数据类型Id
objSelfDefDataTypeENT.DataTypeName = objSelfDefDataTypeENS.DataTypeName; //数据类型名称
objSelfDefDataTypeENT.IsObject = objSelfDefDataTypeENS.IsObject; //是否对象
objSelfDefDataTypeENT.DefaVarName = objSelfDefDataTypeENS.DefaVarName; //默认变量名
objSelfDefDataTypeENT.DataCnName = objSelfDefDataTypeENS.DataCnName; //数据类型中文名称
objSelfDefDataTypeENT.DataTypeAbbr = objSelfDefDataTypeENS.DataTypeAbbr; //数据类型缩写
objSelfDefDataTypeENT.VbNetType = objSelfDefDataTypeENS.VbNetType; //VBNET类型
objSelfDefDataTypeENT.CsType = objSelfDefDataTypeENS.CsType; //CS类型
objSelfDefDataTypeENT.JavaType = objSelfDefDataTypeENS.JavaType; //JAVA类型
objSelfDefDataTypeENT.JavaObjType = objSelfDefDataTypeENS.JavaObjType; //JAVA对象类型
objSelfDefDataTypeENT.SwiftType = objSelfDefDataTypeENS.SwiftType; //SwiftType
objSelfDefDataTypeENT.IsNeedQuote = objSelfDefDataTypeENS.IsNeedQuote; //是否需要引号
objSelfDefDataTypeENT.OraDbType = objSelfDefDataTypeENS.OraDbType; //Ora数据类型
objSelfDefDataTypeENT.IsReturnType = objSelfDefDataTypeENS.IsReturnType; //是否可作返回类型
objSelfDefDataTypeENT.SqlParaType = objSelfDefDataTypeENS.SqlParaType; //SQL参数类型
objSelfDefDataTypeENT.MySqlType = objSelfDefDataTypeENS.MySqlType; //MySqlType
objSelfDefDataTypeENT.DefaFldLength = objSelfDefDataTypeENS.DefaFldLength; //默认长度
objSelfDefDataTypeENT.DefaFldPrecision = objSelfDefDataTypeENS.DefaFldPrecision; //默认小数位数
objSelfDefDataTypeENT.PrjId = objSelfDefDataTypeENS.PrjId; //工程Id
objSelfDefDataTypeENT.UpdDate = objSelfDefDataTypeENS.UpdDate; //修改日期
objSelfDefDataTypeENT.UpdUser = objSelfDefDataTypeENS.UpdUser; //修改者
objSelfDefDataTypeENT.Memo = objSelfDefDataTypeENS.Memo; //说明
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
 /// <param name = "objSelfDefDataTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
objSelfDefDataTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSelfDefDataTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSelfDefDataType.SdDataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.SdDataTypeId = objSelfDefDataTypeEN.SdDataTypeId; //自定义数据类型Id
}
if (arrFldSet.Contains(conSelfDefDataType.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DataTypeName = objSelfDefDataTypeEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(conSelfDefDataType.IsObject, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.IsObject = objSelfDefDataTypeEN.IsObject; //是否对象
}
if (arrFldSet.Contains(conSelfDefDataType.DefaVarName, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DefaVarName = objSelfDefDataTypeEN.DefaVarName == "[null]" ? null :  objSelfDefDataTypeEN.DefaVarName; //默认变量名
}
if (arrFldSet.Contains(conSelfDefDataType.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DataCnName = objSelfDefDataTypeEN.DataCnName == "[null]" ? null :  objSelfDefDataTypeEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(conSelfDefDataType.DataTypeAbbr, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DataTypeAbbr = objSelfDefDataTypeEN.DataTypeAbbr == "[null]" ? null :  objSelfDefDataTypeEN.DataTypeAbbr; //数据类型缩写
}
if (arrFldSet.Contains(conSelfDefDataType.VbNetType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.VbNetType = objSelfDefDataTypeEN.VbNetType == "[null]" ? null :  objSelfDefDataTypeEN.VbNetType; //VBNET类型
}
if (arrFldSet.Contains(conSelfDefDataType.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.CsType = objSelfDefDataTypeEN.CsType; //CS类型
}
if (arrFldSet.Contains(conSelfDefDataType.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.JavaType = objSelfDefDataTypeEN.JavaType == "[null]" ? null :  objSelfDefDataTypeEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(conSelfDefDataType.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.JavaObjType = objSelfDefDataTypeEN.JavaObjType == "[null]" ? null :  objSelfDefDataTypeEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(conSelfDefDataType.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.SwiftType = objSelfDefDataTypeEN.SwiftType == "[null]" ? null :  objSelfDefDataTypeEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(conSelfDefDataType.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.IsNeedQuote = objSelfDefDataTypeEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(conSelfDefDataType.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.OraDbType = objSelfDefDataTypeEN.OraDbType == "[null]" ? null :  objSelfDefDataTypeEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(conSelfDefDataType.IsReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.IsReturnType = objSelfDefDataTypeEN.IsReturnType; //是否可作返回类型
}
if (arrFldSet.Contains(conSelfDefDataType.SqlParaType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.SqlParaType = objSelfDefDataTypeEN.SqlParaType == "[null]" ? null :  objSelfDefDataTypeEN.SqlParaType; //SQL参数类型
}
if (arrFldSet.Contains(conSelfDefDataType.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.MySqlType = objSelfDefDataTypeEN.MySqlType == "[null]" ? null :  objSelfDefDataTypeEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(conSelfDefDataType.DefaFldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DefaFldLength = objSelfDefDataTypeEN.DefaFldLength; //默认长度
}
if (arrFldSet.Contains(conSelfDefDataType.DefaFldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.DefaFldPrecision = objSelfDefDataTypeEN.DefaFldPrecision; //默认小数位数
}
if (arrFldSet.Contains(conSelfDefDataType.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.PrjId = objSelfDefDataTypeEN.PrjId == "[null]" ? null :  objSelfDefDataTypeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSelfDefDataType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.UpdDate = objSelfDefDataTypeEN.UpdDate == "[null]" ? null :  objSelfDefDataTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSelfDefDataType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.UpdUser = objSelfDefDataTypeEN.UpdUser == "[null]" ? null :  objSelfDefDataTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conSelfDefDataType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSelfDefDataTypeEN.Memo = objSelfDefDataTypeEN.Memo == "[null]" ? null :  objSelfDefDataTypeEN.Memo; //说明
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
 /// <param name = "objSelfDefDataTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
if (objSelfDefDataTypeEN.DefaVarName == "[null]") objSelfDefDataTypeEN.DefaVarName = null; //默认变量名
if (objSelfDefDataTypeEN.DataCnName == "[null]") objSelfDefDataTypeEN.DataCnName = null; //数据类型中文名称
if (objSelfDefDataTypeEN.DataTypeAbbr == "[null]") objSelfDefDataTypeEN.DataTypeAbbr = null; //数据类型缩写
if (objSelfDefDataTypeEN.VbNetType == "[null]") objSelfDefDataTypeEN.VbNetType = null; //VBNET类型
if (objSelfDefDataTypeEN.JavaType == "[null]") objSelfDefDataTypeEN.JavaType = null; //JAVA类型
if (objSelfDefDataTypeEN.JavaObjType == "[null]") objSelfDefDataTypeEN.JavaObjType = null; //JAVA对象类型
if (objSelfDefDataTypeEN.SwiftType == "[null]") objSelfDefDataTypeEN.SwiftType = null; //SwiftType
if (objSelfDefDataTypeEN.OraDbType == "[null]") objSelfDefDataTypeEN.OraDbType = null; //Ora数据类型
if (objSelfDefDataTypeEN.SqlParaType == "[null]") objSelfDefDataTypeEN.SqlParaType = null; //SQL参数类型
if (objSelfDefDataTypeEN.MySqlType == "[null]") objSelfDefDataTypeEN.MySqlType = null; //MySqlType
if (objSelfDefDataTypeEN.PrjId == "[null]") objSelfDefDataTypeEN.PrjId = null; //工程Id
if (objSelfDefDataTypeEN.UpdDate == "[null]") objSelfDefDataTypeEN.UpdDate = null; //修改日期
if (objSelfDefDataTypeEN.UpdUser == "[null]") objSelfDefDataTypeEN.UpdUser = null; //修改者
if (objSelfDefDataTypeEN.Memo == "[null]") objSelfDefDataTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 SelfDefDataTypeDA.CheckPropertyNew(objSelfDefDataTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 SelfDefDataTypeDA.CheckProperty4Condition(objSelfDefDataTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_SdDataTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSelfDefDataType.SdDataTypeId); 
List<clsSelfDefDataTypeEN> arrObjLst = clsSelfDefDataTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN()
{
SdDataTypeId = "0",
DataTypeName = "选[自定义数据类型]..."
};
arrObjLst.Insert(0, objSelfDefDataTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSelfDefDataType.SdDataTypeId;
objComboBox.DisplayMember = conSelfDefDataType.DataTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_SdDataTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[自定义数据类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSelfDefDataType.SdDataTypeId); 
IEnumerable<clsSelfDefDataTypeEN> arrObjLst = clsSelfDefDataTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conSelfDefDataType.SdDataTypeId;
objDDL.DataTextField = conSelfDefDataType.DataTypeName;
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
public static void BindDdl_SdDataTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[自定义数据类型]...","0");
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst = GetAllSelfDefDataTypeObjLstCache(); 
objDDL.DataValueField = conSelfDefDataType.SdDataTypeId;
objDDL.DataTextField = conSelfDefDataType.DataTypeName;
objDDL.DataSource = arrSelfDefDataTypeObjLst;
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
if (clsSelfDefDataTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSelfDefDataTypeBL没有刷新缓存机制(clsSelfDefDataTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SdDataTypeId");
//if (arrSelfDefDataTypeObjLstCache == null)
//{
//arrSelfDefDataTypeObjLstCache = SelfDefDataTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSelfDefDataTypeEN GetObjBySdDataTypeIdCache(string strSdDataTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel =
arrSelfDefDataTypeObjLstCache
.Where(x=> x.SdDataTypeId == strSdDataTypeId 
);
if (arrSelfDefDataTypeObjLst_Sel.Count() == 0)
{
   clsSelfDefDataTypeEN obj = clsSelfDefDataTypeBL.GetObjBySdDataTypeId(strSdDataTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSelfDefDataTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataTypeNameBySdDataTypeIdCache(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return "";
//获取缓存中的对象列表
clsSelfDefDataTypeEN objSelfDefDataType = GetObjBySdDataTypeIdCache(strSdDataTypeId);
if (objSelfDefDataType == null) return "";
return objSelfDefDataType.DataTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySdDataTypeIdCache(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return "";
//获取缓存中的对象列表
clsSelfDefDataTypeEN objSelfDefDataType = GetObjBySdDataTypeIdCache(strSdDataTypeId);
if (objSelfDefDataType == null) return "";
return objSelfDefDataType.DataTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetAllSelfDefDataTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache(); 
return arrSelfDefDataTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSelfDefDataTypeObjLstCache;
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
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSelfDefDataTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSelfDefDataTypeEN._RefreshTimeLst.Count == 0) return "";
return clsSelfDefDataTypeEN._RefreshTimeLst[clsSelfDefDataTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSelfDefDataTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSelfDefDataTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSelfDefDataTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SelfDefDataType(自定义数据类型)
 /// 唯一性条件:DataTypeName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检测记录是否存在
string strResult = SelfDefDataTypeDA.GetUniCondStr(objSelfDefDataTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSdDataTypeId)
{
if (strInFldName != conSelfDefDataType.SdDataTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSelfDefDataType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSelfDefDataType._AttributeName));
throw new Exception(strMsg);
}
var objSelfDefDataType = clsSelfDefDataTypeBL.GetObjBySdDataTypeIdCache(strSdDataTypeId);
if (objSelfDefDataType == null) return "";
return objSelfDefDataType[strOutFldName].ToString();
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
int intRecCount = clsSelfDefDataTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsSelfDefDataTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSelfDefDataTypeDA.GetRecCount();
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
int intRecCount = clsSelfDefDataTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSelfDefDataTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSelfDefDataTypeEN objSelfDefDataTypeCond)
{
List<clsSelfDefDataTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSelfDefDataType._AttributeName)
{
if (objSelfDefDataTypeCond.IsUpdated(strFldName) == false) continue;
if (objSelfDefDataTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSelfDefDataTypeCond[strFldName].ToString());
}
else
{
if (objSelfDefDataTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSelfDefDataTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSelfDefDataTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSelfDefDataTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSelfDefDataTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSelfDefDataTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSelfDefDataTypeCond[strFldName]));
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
 List<string> arrList = clsSelfDefDataTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SelfDefDataTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SelfDefDataTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SelfDefDataTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSelfDefDataTypeDA.SetFldValue(clsSelfDefDataTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SelfDefDataTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSelfDefDataTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSelfDefDataTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSelfDefDataTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SelfDefDataType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**自定义数据类型Id*/ 
 strCreateTabCode.Append(" SdDataTypeId char(4) primary key, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) not Null, "); 
 // /**是否对象*/ 
 strCreateTabCode.Append(" IsObject bit Null, "); 
 // /**默认变量名*/ 
 strCreateTabCode.Append(" DefaVarName varchar(50) Null, "); 
 // /**数据类型中文名称*/ 
 strCreateTabCode.Append(" DataCnName varchar(100) Null, "); 
 // /**数据类型缩写*/ 
 strCreateTabCode.Append(" DataTypeAbbr varchar(5) Null, "); 
 // /**VBNET类型*/ 
 strCreateTabCode.Append(" VbNetType varchar(100) Null, "); 
 // /**CS类型*/ 
 strCreateTabCode.Append(" CsType varchar(100) not Null, "); 
 // /**JAVA类型*/ 
 strCreateTabCode.Append(" JavaType varchar(100) Null, "); 
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
 strCreateTabCode.Append(" DefaFldPrecision int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
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
 /// 自定义数据类型(SelfDefDataType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SelfDefDataType : clsCommFun4BL
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
clsSelfDefDataTypeBL.ReFreshThisCache();
}
}

}