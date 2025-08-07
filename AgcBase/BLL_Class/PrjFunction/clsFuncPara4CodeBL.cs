
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncPara4CodeBL
 表名:FuncPara4Code(00050384)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFuncPara4CodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncPara4CodeEN GetObj(this K_FuncParaId4Code_FuncPara4Code myKey)
{
clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.FuncPara4CodeDA.GetObjByFuncParaId4Code(myKey.Value);
return objFuncPara4CodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncPara4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],参数名 = [{1}],数据类型Id = [{2}],函数用途Id = [{3}]的数据已经存在!(in clsFuncPara4CodeBL.AddNewRecord)", objFuncPara4CodeEN.PrjId,objFuncPara4CodeEN.ParaName,objFuncPara4CodeEN.DataTypeId,objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
bool bolResult = clsFuncPara4CodeBL.FuncPara4CodeDA.AddNewRecordBySQL2(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
public static bool AddRecordEx(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFuncPara4CodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFuncPara4CodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],参数名(ParaName)=[{1}],数据类型Id(DataTypeId)=[{2}],函数用途Id(FuncPurposeId)=[{3}])已经存在,不能重复!", objFuncPara4CodeEN.PrjId, objFuncPara4CodeEN.ParaName, objFuncPara4CodeEN.DataTypeId, objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFuncPara4CodeEN.AddNewRecord();
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncPara4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],参数名 = [{1}],数据类型Id = [{2}],函数用途Id = [{3}]的数据已经存在!(in clsFuncPara4CodeBL.AddNewRecordWithMaxId)", objFuncPara4CodeEN.PrjId,objFuncPara4CodeEN.ParaName,objFuncPara4CodeEN.DataTypeId,objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
string strFuncParaId4Code = clsFuncPara4CodeBL.FuncPara4CodeDA.AddNewRecordBySQL2WithReturnKey(objFuncPara4CodeEN);
     objFuncPara4CodeEN.FuncParaId4Code = strFuncParaId4Code;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
}
return strFuncParaId4Code;
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFuncPara4CodeEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],参数名 = [{1}],数据类型Id = [{2}],函数用途Id = [{3}]的数据已经存在!(in clsFuncPara4CodeBL.AddNewRecordWithReturnKey)", objFuncPara4CodeEN.PrjId,objFuncPara4CodeEN.ParaName,objFuncPara4CodeEN.DataTypeId,objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
string strKey = clsFuncPara4CodeBL.FuncPara4CodeDA.AddNewRecordBySQL2WithReturnKey(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetFuncParaId4Code(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strFuncParaId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
}
objFuncPara4CodeEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.FuncParaId4Code) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.FuncParaId4Code, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.FuncParaId4Code] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParaName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conFuncPara4Code.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, conFuncPara4Code.ParaName);
}
objFuncPara4CodeEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParaName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParaName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParaName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParaCnName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, conFuncPara4Code.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, conFuncPara4Code.ParaCnName);
}
objFuncPara4CodeEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParaCnName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParaCnName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParaCnName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetDataTypeId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conFuncPara4Code.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conFuncPara4Code.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conFuncPara4Code.DataTypeId);
}
objFuncPara4CodeEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.DataTypeId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.DataTypeId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.DataTypeId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParameterType(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParameterType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, conFuncPara4Code.ParameterType);
}
objFuncPara4CodeEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParameterType) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParameterType, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParameterType] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParameterTypeFullName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, conFuncPara4Code.ParameterTypeFullName);
}
objFuncPara4CodeEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParameterTypeFullName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParameterTypeFullName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParameterTypeFullName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetIsByRef(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, conFuncPara4Code.IsByRef);
objFuncPara4CodeEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.IsByRef) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.IsByRef, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.IsByRef] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetPrjId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFuncPara4Code.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFuncPara4Code.PrjId);
}
objFuncPara4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.PrjId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.PrjId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.PrjId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetIsTemplate(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFuncPara4CodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.IsTemplate) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.IsTemplate, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.IsTemplate] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetFuncPurposeId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, conFuncPara4Code.FuncPurposeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
}
objFuncPara4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.FuncPurposeId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.FuncPurposeId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.FuncPurposeId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetUpdDate(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncPara4Code.UpdDate);
}
objFuncPara4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.UpdDate) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.UpdDate, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.UpdDate] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetUpdUser(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncPara4Code.UpdUser);
}
objFuncPara4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.UpdUser) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.UpdUser, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.UpdUser] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetMemo(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncPara4Code.Memo);
}
objFuncPara4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.Memo) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.Memo, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.Memo] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFuncPara4CodeEN.CheckPropertyNew();
clsFuncPara4CodeEN objFuncPara4CodeCond = new clsFuncPara4CodeEN();
string strCondition = objFuncPara4CodeCond
.SetFuncParaId4Code(objFuncPara4CodeEN.FuncParaId4Code, "<>")
.SetPrjId(objFuncPara4CodeEN.PrjId, "=")
.SetParaName(objFuncPara4CodeEN.ParaName, "=")
.SetDataTypeId(objFuncPara4CodeEN.DataTypeId, "=")
.SetFuncPurposeId(objFuncPara4CodeEN.FuncPurposeId, "=")
.GetCombineCondition();
objFuncPara4CodeEN._IsCheckProperty = true;
bool bolIsExist = clsFuncPara4CodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_ParaName_DataTypeId_FuncPurposeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFuncPara4CodeEN.Update();
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
 /// <param name = "objFuncPara4Code">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFuncPara4CodeEN objFuncPara4Code)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFuncPara4CodeEN objFuncPara4CodeCond = new clsFuncPara4CodeEN();
string strCondition = objFuncPara4CodeCond
.SetPrjId(objFuncPara4Code.PrjId, "=")
.SetParaName(objFuncPara4Code.ParaName, "=")
.SetDataTypeId(objFuncPara4Code.DataTypeId, "=")
.SetFuncPurposeId(objFuncPara4Code.FuncPurposeId, "=")
.GetCombineCondition();
objFuncPara4Code._IsCheckProperty = true;
bool bolIsExist = clsFuncPara4CodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFuncPara4Code.FuncParaId4Code = clsFuncPara4CodeBL.GetFirstID_S(strCondition);
objFuncPara4Code.UpdateWithCondition(strCondition);
}
else
{
objFuncPara4Code.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
objFuncPara4Code.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncPara4CodeBL.FuncPara4CodeDA.UpdateBySql2(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncPara4CodeEN objFuncPara4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFuncPara4CodeBL.FuncPara4CodeDA.UpdateBySql2(objFuncPara4CodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strWhereCond)
{
try
{
bool bolResult = clsFuncPara4CodeBL.FuncPara4CodeDA.UpdateBySqlWithCondition(objFuncPara4CodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFuncPara4CodeBL.FuncPara4CodeDA.UpdateBySqlWithConditionTransaction(objFuncPara4CodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
int intRecNum = clsFuncPara4CodeBL.FuncPara4CodeDA.DelRecord(objFuncPara4CodeEN.FuncParaId4Code);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeENS">源对象</param>
 /// <param name = "objFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(this clsFuncPara4CodeEN objFuncPara4CodeENS, clsFuncPara4CodeEN objFuncPara4CodeENT)
{
try
{
objFuncPara4CodeENT.FuncParaId4Code = objFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objFuncPara4CodeENT.ParaName = objFuncPara4CodeENS.ParaName; //参数名
objFuncPara4CodeENT.ParaCnName = objFuncPara4CodeENS.ParaCnName; //参数中文名
objFuncPara4CodeENT.DataTypeId = objFuncPara4CodeENS.DataTypeId; //数据类型Id
objFuncPara4CodeENT.ParameterType = objFuncPara4CodeENS.ParameterType; //参数类型
objFuncPara4CodeENT.ParameterTypeFullName = objFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objFuncPara4CodeENT.IsByRef = objFuncPara4CodeENS.IsByRef; //是否引用型参数
objFuncPara4CodeENT.PrjId = objFuncPara4CodeENS.PrjId; //工程Id
objFuncPara4CodeENT.IsTemplate = objFuncPara4CodeENS.IsTemplate; //是否模板
objFuncPara4CodeENT.FuncPurposeId = objFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objFuncPara4CodeENT.UpdDate = objFuncPara4CodeENS.UpdDate; //修改日期
objFuncPara4CodeENT.UpdUser = objFuncPara4CodeENS.UpdUser; //修改者
objFuncPara4CodeENT.Memo = objFuncPara4CodeENS.Memo; //说明
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
 /// <param name = "objFuncPara4CodeENS">源对象</param>
 /// <returns>目标对象=>clsFuncPara4CodeEN:objFuncPara4CodeENT</returns>
 public static clsFuncPara4CodeEN CopyTo(this clsFuncPara4CodeEN objFuncPara4CodeENS)
{
try
{
 clsFuncPara4CodeEN objFuncPara4CodeENT = new clsFuncPara4CodeEN()
{
FuncParaId4Code = objFuncPara4CodeENS.FuncParaId4Code, //函数参数Id
ParaName = objFuncPara4CodeENS.ParaName, //参数名
ParaCnName = objFuncPara4CodeENS.ParaCnName, //参数中文名
DataTypeId = objFuncPara4CodeENS.DataTypeId, //数据类型Id
ParameterType = objFuncPara4CodeENS.ParameterType, //参数类型
ParameterTypeFullName = objFuncPara4CodeENS.ParameterTypeFullName, //参数类型全名
IsByRef = objFuncPara4CodeENS.IsByRef, //是否引用型参数
PrjId = objFuncPara4CodeENS.PrjId, //工程Id
IsTemplate = objFuncPara4CodeENS.IsTemplate, //是否模板
FuncPurposeId = objFuncPara4CodeENS.FuncPurposeId, //函数用途Id
UpdDate = objFuncPara4CodeENS.UpdDate, //修改日期
UpdUser = objFuncPara4CodeENS.UpdUser, //修改者
Memo = objFuncPara4CodeENS.Memo, //说明
};
 return objFuncPara4CodeENT;
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
public static void CheckPropertyNew(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 clsFuncPara4CodeBL.FuncPara4CodeDA.CheckPropertyNew(objFuncPara4CodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 clsFuncPara4CodeBL.FuncPara4CodeDA.CheckProperty4Condition(objFuncPara4CodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncPara4CodeEN objFuncPara4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.FuncParaId4Code, objFuncPara4CodeCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParaName) == true)
{
string strComparisonOpParaName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParaName, objFuncPara4CodeCond.ParaName, strComparisonOpParaName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParaCnName) == true)
{
string strComparisonOpParaCnName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParaCnName, objFuncPara4CodeCond.ParaCnName, strComparisonOpParaCnName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.DataTypeId, objFuncPara4CodeCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParameterType) == true)
{
string strComparisonOpParameterType = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParameterType, objFuncPara4CodeCond.ParameterType, strComparisonOpParameterType);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParameterTypeFullName, objFuncPara4CodeCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.IsByRef) == true)
{
if (objFuncPara4CodeCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFuncPara4Code.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFuncPara4Code.IsByRef);
}
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.PrjId) == true)
{
string strComparisonOpPrjId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.PrjId, objFuncPara4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.IsTemplate) == true)
{
if (objFuncPara4CodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFuncPara4Code.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFuncPara4Code.IsTemplate);
}
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.FuncPurposeId, objFuncPara4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.UpdDate, objFuncPara4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.UpdUser, objFuncPara4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.Memo) == true)
{
string strComparisonOpMemo = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.Memo, objFuncPara4CodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FuncPara4Code(函数参数4Code), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_ParaName_DataTypeId_FuncPurposeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFuncPara4CodeEN == null) return true;
if (objFuncPara4CodeEN.FuncParaId4Code == null || objFuncPara4CodeEN.FuncParaId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncPara4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objFuncPara4CodeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
}
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
if (clsFuncPara4CodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncParaId4Code !=  '{0}'", objFuncPara4CodeEN.FuncParaId4Code);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
if (clsFuncPara4CodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FuncPara4Code(函数参数4Code), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ParaName_DataTypeId_FuncPurposeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncPara4CodeEN == null) return "";
if (objFuncPara4CodeEN.FuncParaId4Code == null || objFuncPara4CodeEN.FuncParaId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objFuncPara4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objFuncPara4CodeEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
}
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncParaId4Code !=  '{0}'", objFuncPara4CodeEN.FuncParaId4Code);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FuncPara4Code
{
public virtual bool UpdRelaTabDate(string strFuncParaId4Code, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数参数4Code(FuncPara4Code)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFuncPara4CodeBL
{
public static RelatedActions_FuncPara4Code relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFuncPara4CodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFuncPara4CodeDA FuncPara4CodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFuncPara4CodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsFuncPara4CodeBL()
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
if (string.IsNullOrEmpty(clsFuncPara4CodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncPara4CodeEN._ConnectString);
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
public static DataTable GetDataTable_FuncPara4Code(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FuncPara4CodeDA.GetDataTable_FuncPara4Code(strWhereCond);
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
objDT = FuncPara4CodeDA.GetDataTable(strWhereCond);
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
objDT = FuncPara4CodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FuncPara4CodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FuncPara4CodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FuncPara4CodeDA.GetDataTable_Top(objTopPara);
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
objDT = FuncPara4CodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FuncPara4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FuncPara4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncParaId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLst(List<string> arrFuncParaId4CodeLst)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncParaId4CodeLst, true);
 string strWhereCond = string.Format("FuncParaId4Code in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncParaId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLstCache(List<string> arrFuncParaId4CodeLst, string strFuncPurposeId)
{
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsFuncPara4CodeEN> arrFuncPara4CodeObjLst_Sel =
arrFuncPara4CodeObjLstCache
.Where(x => arrFuncParaId4CodeLst.Contains(x.FuncParaId4Code));
return arrFuncPara4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLst(string strWhereCond)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
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
public static List<clsFuncPara4CodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFuncPara4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFuncPara4CodeEN> GetSubObjLstCache(clsFuncPara4CodeEN objFuncPara4CodeCond)
{
 string strFuncPurposeId = objFuncPara4CodeCond.FuncPurposeId;
 if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsFuncPara4CodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsFuncPara4CodeEN> arrObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsFuncPara4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncPara4Code._AttributeName)
{
if (objFuncPara4CodeCond.IsUpdated(strFldName) == false) continue;
if (objFuncPara4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncPara4CodeCond[strFldName].ToString());
}
else
{
if (objFuncPara4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncPara4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncPara4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncPara4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncPara4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncPara4CodeCond[strFldName]));
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
public static List<clsFuncPara4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
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
public static List<clsFuncPara4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
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
List<clsFuncPara4CodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFuncPara4CodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncPara4CodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFuncPara4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
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
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
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
public static List<clsFuncPara4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFuncPara4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
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
public static List<clsFuncPara4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFuncPara4CodeEN> arrObjLst = new List<clsFuncPara4CodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN();
try
{
objFuncPara4CodeEN.FuncParaId4Code = objRow[conFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objFuncPara4CodeEN.ParaName = objRow[conFuncPara4Code.ParaName].ToString().Trim(); //参数名
objFuncPara4CodeEN.ParaCnName = objRow[conFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objFuncPara4CodeEN.DataTypeId = objRow[conFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objFuncPara4CodeEN.ParameterType = objRow[conFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objFuncPara4CodeEN.ParameterTypeFullName = objRow[conFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[conFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objFuncPara4CodeEN.PrjId = objRow[conFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[conFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objFuncPara4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncPara4Code.IsTemplate].ToString().Trim()); //是否模板
objFuncPara4CodeEN.FuncPurposeId = objRow[conFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFuncPara4CodeEN.UpdDate = objRow[conFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objFuncPara4CodeEN.UpdUser = objRow[conFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[conFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objFuncPara4CodeEN.Memo = objRow[conFuncPara4Code.Memo] == DBNull.Value ? null : objRow[conFuncPara4Code.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFuncPara4CodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFuncPara4Code(ref clsFuncPara4CodeEN objFuncPara4CodeEN)
{
bool bolResult = FuncPara4CodeDA.GetFuncPara4Code(ref objFuncPara4CodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
if (strFuncParaId4Code.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncParaId4Code]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncParaId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncParaId4Code]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFuncPara4CodeEN objFuncPara4CodeEN = FuncPara4CodeDA.GetObjByFuncParaId4Code(strFuncParaId4Code);
return objFuncPara4CodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFuncPara4CodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFuncPara4CodeEN objFuncPara4CodeEN = FuncPara4CodeDA.GetFirstObj(strWhereCond);
 return objFuncPara4CodeEN;
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
public static clsFuncPara4CodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFuncPara4CodeEN objFuncPara4CodeEN = FuncPara4CodeDA.GetObjByDataRow(objRow);
 return objFuncPara4CodeEN;
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
public static clsFuncPara4CodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFuncPara4CodeEN objFuncPara4CodeEN = FuncPara4CodeDA.GetObjByDataRow(objRow);
 return objFuncPara4CodeEN;
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
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <param name = "lstFuncPara4CodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncPara4CodeEN GetObjByFuncParaId4CodeFromList(string strFuncParaId4Code, List<clsFuncPara4CodeEN> lstFuncPara4CodeObjLst)
{
foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in lstFuncPara4CodeObjLst)
{
if (objFuncPara4CodeEN.FuncParaId4Code == strFuncParaId4Code)
{
return objFuncPara4CodeEN;
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
 string strMaxFuncParaId4Code;
 try
 {
 strMaxFuncParaId4Code = clsFuncPara4CodeDA.GetMaxStrId();
 return strMaxFuncParaId4Code;
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
 string strFuncParaId4Code;
 try
 {
 strFuncParaId4Code = new clsFuncPara4CodeDA().GetFirstID(strWhereCond);
 return strFuncParaId4Code;
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
 arrList = FuncPara4CodeDA.GetID(strWhereCond);
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
bool bolIsExist = FuncPara4CodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncParaId4Code)
{
if (string.IsNullOrEmpty(strFuncParaId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncParaId4Code]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FuncPara4CodeDA.IsExist(strFuncParaId4Code);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncParaId4Code">函数参数Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncParaId4Code, string strOpUser)
{
clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);
objFuncPara4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFuncPara4CodeEN.UpdUser = strOpUser;
return clsFuncPara4CodeBL.UpdateBySql2(objFuncPara4CodeEN);
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
 bolIsExist = clsFuncPara4CodeDA.IsExistTable();
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
 bolIsExist = FuncPara4CodeDA.IsExistTable(strTabName);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncPara4CodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],参数名 = [{1}],数据类型Id = [{2}],函数用途Id = [{3}]的数据已经存在!(in clsFuncPara4CodeBL.AddNewRecordBySql2)", objFuncPara4CodeEN.PrjId,objFuncPara4CodeEN.ParaName,objFuncPara4CodeEN.DataTypeId,objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
bool bolResult = FuncPara4CodeDA.AddNewRecordBySQL2(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFuncPara4CodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],参数名 = [{1}],数据类型Id = [{2}],函数用途Id = [{3}]的数据已经存在!(in clsFuncPara4CodeBL.AddNewRecordBySql2WithReturnKey)", objFuncPara4CodeEN.PrjId,objFuncPara4CodeEN.ParaName,objFuncPara4CodeEN.DataTypeId,objFuncPara4CodeEN.FuncPurposeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeBL.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeBL.GetMaxStrId_S();
 }
string strKey = FuncPara4CodeDA.AddNewRecordBySQL2WithReturnKey(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
bool bolResult = FuncPara4CodeDA.Update(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FuncPara4CodeDA.UpdateBySql2(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncPara4CodeBL.ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
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
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncParaId4Code)
{
try
{
 clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);

if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(objFuncPara4CodeEN.FuncParaId4Code, objFuncPara4CodeEN.UpdUser);
}
if (objFuncPara4CodeEN != null)
{
int intRecNum = FuncPara4CodeDA.DelRecord(strFuncParaId4Code);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);
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
/// <param name="strFuncParaId4Code">表关键字</param>
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncParaId4Code , string strFuncPurposeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
//删除与表:[FuncPara4Code]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFuncPara4Code.FuncParaId4Code,
//strFuncParaId4Code);
//        clsFuncPara4CodeBL.DelFuncPara4CodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncPara4CodeBL.DelRecord(strFuncParaId4Code, strFuncPurposeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncPara4CodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncParaId4Code, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncParaId4Code, string strFuncPurposeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFuncPara4CodeBL.relatedActions != null)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(strFuncParaId4Code, "UpdRelaTabDate");
}
bool bolResult = FuncPara4CodeDA.DelRecord(strFuncParaId4Code,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strFuncPurposeId);
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
 /// <param name = "arrFuncParaId4CodeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFuncPara4Codes(List<string> arrFuncParaId4CodeLst)
{
if (arrFuncParaId4CodeLst.Count == 0) return 0;
try
{
if (clsFuncPara4CodeBL.relatedActions != null)
{
foreach (var strFuncParaId4Code in arrFuncParaId4CodeLst)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(strFuncParaId4Code, "UpdRelaTabDate");
}
}
 clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(arrFuncParaId4CodeLst[0]);
int intDelRecNum = FuncPara4CodeDA.DelFuncPara4Code(arrFuncParaId4CodeLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFuncPara4CodeEN.FuncPurposeId);
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
public static int DelFuncPara4CodesByCond(string strWhereCond)
{
try
{
if (clsFuncPara4CodeBL.relatedActions != null)
{
List<string> arrFuncParaId4Code = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncParaId4Code in arrFuncParaId4Code)
{
clsFuncPara4CodeBL.relatedActions.UpdRelaTabDate(strFuncParaId4Code, "UpdRelaTabDate");
}
}
List<string> arrFuncPurposeId = GetFldValue(conFuncPara4Code.FuncPurposeId, strWhereCond);
int intRecNum = FuncPara4CodeDA.DelFuncPara4Code(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrFuncPurposeId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FuncPara4Code]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncParaId4Code">表关键字</param>
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncParaId4Code, string strFuncPurposeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFuncPara4CodeDA.GetSpecSQLObj();
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
//删除与表:[FuncPara4Code]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFuncPara4CodeBL.DelRecord(strFuncParaId4Code, strFuncPurposeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFuncPara4CodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncParaId4Code, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFuncPara4CodeENS">源对象</param>
 /// <param name = "objFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(clsFuncPara4CodeEN objFuncPara4CodeENS, clsFuncPara4CodeEN objFuncPara4CodeENT)
{
try
{
objFuncPara4CodeENT.FuncParaId4Code = objFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objFuncPara4CodeENT.ParaName = objFuncPara4CodeENS.ParaName; //参数名
objFuncPara4CodeENT.ParaCnName = objFuncPara4CodeENS.ParaCnName; //参数中文名
objFuncPara4CodeENT.DataTypeId = objFuncPara4CodeENS.DataTypeId; //数据类型Id
objFuncPara4CodeENT.ParameterType = objFuncPara4CodeENS.ParameterType; //参数类型
objFuncPara4CodeENT.ParameterTypeFullName = objFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objFuncPara4CodeENT.IsByRef = objFuncPara4CodeENS.IsByRef; //是否引用型参数
objFuncPara4CodeENT.PrjId = objFuncPara4CodeENS.PrjId; //工程Id
objFuncPara4CodeENT.IsTemplate = objFuncPara4CodeENS.IsTemplate; //是否模板
objFuncPara4CodeENT.FuncPurposeId = objFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objFuncPara4CodeENT.UpdDate = objFuncPara4CodeENS.UpdDate; //修改日期
objFuncPara4CodeENT.UpdUser = objFuncPara4CodeENS.UpdUser; //修改者
objFuncPara4CodeENT.Memo = objFuncPara4CodeENS.Memo; //说明
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
 /// <param name = "objFuncPara4CodeEN">源简化对象</param>
 public static void SetUpdFlag(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
objFuncPara4CodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFuncPara4CodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFuncPara4Code.FuncParaId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.FuncParaId4Code = objFuncPara4CodeEN.FuncParaId4Code; //函数参数Id
}
if (arrFldSet.Contains(conFuncPara4Code.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.ParaName = objFuncPara4CodeEN.ParaName; //参数名
}
if (arrFldSet.Contains(conFuncPara4Code.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.ParaCnName = objFuncPara4CodeEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(conFuncPara4Code.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.DataTypeId = objFuncPara4CodeEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conFuncPara4Code.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.ParameterType = objFuncPara4CodeEN.ParameterType == "[null]" ? null :  objFuncPara4CodeEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(conFuncPara4Code.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.ParameterTypeFullName = objFuncPara4CodeEN.ParameterTypeFullName == "[null]" ? null :  objFuncPara4CodeEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(conFuncPara4Code.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.IsByRef = objFuncPara4CodeEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(conFuncPara4Code.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.PrjId = objFuncPara4CodeEN.PrjId == "[null]" ? null :  objFuncPara4CodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFuncPara4Code.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.IsTemplate = objFuncPara4CodeEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conFuncPara4Code.FuncPurposeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.FuncPurposeId = objFuncPara4CodeEN.FuncPurposeId; //函数用途Id
}
if (arrFldSet.Contains(conFuncPara4Code.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.UpdDate = objFuncPara4CodeEN.UpdDate == "[null]" ? null :  objFuncPara4CodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFuncPara4Code.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.UpdUser = objFuncPara4CodeEN.UpdUser == "[null]" ? null :  objFuncPara4CodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFuncPara4Code.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFuncPara4CodeEN.Memo = objFuncPara4CodeEN.Memo == "[null]" ? null :  objFuncPara4CodeEN.Memo; //说明
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
 /// <param name = "objFuncPara4CodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
if (objFuncPara4CodeEN.ParameterType == "[null]") objFuncPara4CodeEN.ParameterType = null; //参数类型
if (objFuncPara4CodeEN.ParameterTypeFullName == "[null]") objFuncPara4CodeEN.ParameterTypeFullName = null; //参数类型全名
if (objFuncPara4CodeEN.PrjId == "[null]") objFuncPara4CodeEN.PrjId = null; //工程Id
if (objFuncPara4CodeEN.UpdDate == "[null]") objFuncPara4CodeEN.UpdDate = null; //修改日期
if (objFuncPara4CodeEN.UpdUser == "[null]") objFuncPara4CodeEN.UpdUser = null; //修改者
if (objFuncPara4CodeEN.Memo == "[null]") objFuncPara4CodeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 FuncPara4CodeDA.CheckPropertyNew(objFuncPara4CodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 FuncPara4CodeDA.CheckProperty4Condition(objFuncPara4CodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncPurposeId"></param>
public static void BindCbo_FuncParaId4Code(System.Windows.Forms.ComboBox objComboBox , string strFuncPurposeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncPara4Code.FuncParaId4Code); 
List<clsFuncPara4CodeEN> arrObjLst = clsFuncPara4CodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncPurposeId == strFuncPurposeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN()
{
FuncParaId4Code = "0",
ParaName = "选[函数参数4Code]..."
};
arrObjLstSel.Insert(0, objFuncPara4CodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncPara4Code.FuncParaId4Code;
objComboBox.DisplayMember = conFuncPara4Code.ParaName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strFuncPurposeId"></param>
public static void BindDdl_FuncParaId4Code(System.Web.UI.WebControls.DropDownList objDDL , string strFuncPurposeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数参数4Code]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFuncPara4Code.FuncParaId4Code); 
IEnumerable<clsFuncPara4CodeEN> arrObjLst = clsFuncPara4CodeBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncPurposeId == strFuncPurposeId).ToList();
objDDL.DataValueField = conFuncPara4Code.FuncParaId4Code;
objDDL.DataTextField = conFuncPara4Code.ParaName;
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
public static void BindDdl_FuncParaId4CodeCache(System.Web.UI.WebControls.DropDownList objDDL, string strFuncPurposeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数参数4Code]...","0");
List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst = GetAllFuncPara4CodeObjLstCache(strFuncPurposeId); 
objDDL.DataValueField = conFuncPara4Code.FuncParaId4Code;
objDDL.DataTextField = conFuncPara4Code.ParaName;
objDDL.DataSource = arrFuncPara4CodeObjLst;
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
if (clsFuncPara4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncPara4CodeBL没有刷新缓存机制(clsFuncPara4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncParaId4Code");
//if (arrFuncPara4CodeObjLstCache == null)
//{
//arrFuncPara4CodeObjLstCache = FuncPara4CodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncPara4CodeEN GetObjByFuncParaId4CodeCache(string strFuncParaId4Code, string strFuncPurposeId)
{

if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确!(In {1})", strFuncPurposeId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsFuncPara4CodeEN> arrFuncPara4CodeObjLst_Sel =
arrFuncPara4CodeObjLstCache
.Where(x=> x.FuncParaId4Code == strFuncParaId4Code 
);
if (arrFuncPara4CodeObjLst_Sel.Count() == 0)
{
   clsFuncPara4CodeEN obj = clsFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);
   if (obj != null)
 {
if (obj.FuncPurposeId == strFuncPurposeId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFuncParaId4Code, strFuncPurposeId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrFuncPara4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetParaNameByFuncParaId4CodeCache(string strFuncParaId4Code, string strFuncPurposeId)
{
if (string.IsNullOrEmpty(strFuncParaId4Code) == true) return "";
//获取缓存中的对象列表
clsFuncPara4CodeEN objFuncPara4Code = GetObjByFuncParaId4CodeCache(strFuncParaId4Code, strFuncPurposeId);
if (objFuncPara4Code == null) return "";
return objFuncPara4Code.ParaName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncParaId4CodeCache(string strFuncParaId4Code, string strFuncPurposeId)
{
if (string.IsNullOrEmpty(strFuncParaId4Code) == true) return "";
//获取缓存中的对象列表
clsFuncPara4CodeEN objFuncPara4Code = GetObjByFuncParaId4CodeCache(strFuncParaId4Code, strFuncPurposeId);
if (objFuncPara4Code == null) return "";
return objFuncPara4Code.ParaName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncPara4CodeEN> GetAllFuncPara4CodeObjLstCache(string strFuncPurposeId)
{
//获取缓存中的对象列表
List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId); 
return arrFuncPara4CodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLstCache(string strFuncPurposeId)
{

if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确!(In {1})", strFuncPurposeId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
string strCondition = string.Format("FuncPurposeId='{0}'", strFuncPurposeId);
List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrFuncPara4CodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strFuncPurposeId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
CacheHelper.Remove(strKey);
clsFuncPara4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFuncPara4CodeEN._RefreshTimeLst.Count == 0) return "";
return clsFuncPara4CodeEN._RefreshTimeLst[clsFuncPara4CodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strFuncPurposeId)
{
if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
string strMsg = string.Format("缓存分类字段:[FuncPurposeId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncPara4CodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
CacheHelper.Remove(strKey);
clsFuncPara4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFuncPara4CodeBL.objCommFun4BL.ReFreshCache(strFuncPurposeId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FuncPara4Code(函数参数4Code)
 /// 唯一性条件:PrjId_ParaName_DataTypeId_FuncPurposeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检测记录是否存在
string strResult = FuncPara4CodeDA.GetUniCondStr(objFuncPara4CodeEN);
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
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncParaId4Code, string strFuncPurposeId)
{
if (strInFldName != conFuncPara4Code.FuncParaId4Code)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFuncPara4Code._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFuncPara4Code._AttributeName));
throw new Exception(strMsg);
}
var objFuncPara4Code = clsFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(strFuncParaId4Code, strFuncPurposeId);
if (objFuncPara4Code == null) return "";
return objFuncPara4Code[strOutFldName].ToString();
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
int intRecCount = clsFuncPara4CodeDA.GetRecCount(strTabName);
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
int intRecCount = clsFuncPara4CodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFuncPara4CodeDA.GetRecCount();
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
int intRecCount = clsFuncPara4CodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFuncPara4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFuncPara4CodeEN objFuncPara4CodeCond)
{
 string strFuncPurposeId = objFuncPara4CodeCond.FuncPurposeId;
 if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsFuncPara4CodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsFuncPara4CodeEN> arrObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsFuncPara4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFuncPara4Code._AttributeName)
{
if (objFuncPara4CodeCond.IsUpdated(strFldName) == false) continue;
if (objFuncPara4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncPara4CodeCond[strFldName].ToString());
}
else
{
if (objFuncPara4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFuncPara4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFuncPara4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFuncPara4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFuncPara4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFuncPara4CodeCond[strFldName]));
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
 List<string> arrList = clsFuncPara4CodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FuncPara4CodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FuncPara4CodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FuncPara4CodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncPara4CodeDA.SetFldValue(clsFuncPara4CodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FuncPara4CodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncPara4CodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFuncPara4CodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFuncPara4CodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FuncPara4Code] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数参数Id*/ 
 strCreateTabCode.Append(" FuncParaId4Code char(8) primary key, "); 
 // /**参数名*/ 
 strCreateTabCode.Append(" ParaName varchar(50) not Null, "); 
 // /**参数中文名*/ 
 strCreateTabCode.Append(" ParaCnName varchar(50) not Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**参数类型*/ 
 strCreateTabCode.Append(" ParameterType varchar(100) Null, "); 
 // /**参数类型全名*/ 
 strCreateTabCode.Append(" ParameterTypeFullName varchar(500) Null, "); 
 // /**是否引用型参数*/ 
 strCreateTabCode.Append(" IsByRef bit not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit Null, "); 
 // /**函数用途Id*/ 
 strCreateTabCode.Append(" FuncPurposeId char(2) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) Null, "); 
 // /**函数用途名*/ 
 strCreateTabCode.Append(" FuncPurposeName varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数参数4Code(FuncPara4Code)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FuncPara4Code : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strFuncPurposeId)
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
clsFuncPara4CodeBL.ReFreshThisCache(strFuncPurposeId);
}
}

}