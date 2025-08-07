
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFuncParaBL
 表名:CMFuncPara(00050503)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMFuncParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFuncParaEN GetObj(this K_CmFuncParaId_CMFuncPara myKey)
{
clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBL.CMFuncParaDA.GetObjByCmFuncParaId(myKey.Value);
return objCMFuncParaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFuncParaEN) == false)
{
var strMsg = string.Format("记录已经存在!参数名 = [{0}],数据类型Id = [{1}],参数类型 = [{2}],工程Id = [{3}]的数据已经存在!(in clsCMFuncParaBL.AddNewRecord)", objCMFuncParaEN.ParaName,objCMFuncParaEN.DataTypeId,objCMFuncParaEN.ParameterType,objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
bool bolResult = clsCMFuncParaBL.CMFuncParaDA.AddNewRecordBySQL2(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
public static bool AddRecordEx(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCMFuncParaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMFuncParaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(参数名(ParaName)=[{0}],数据类型Id(DataTypeId)=[{1}],参数类型(ParameterType)=[{2}],工程Id(PrjId)=[{3}])已经存在,不能重复!", objCMFuncParaEN.ParaName, objCMFuncParaEN.DataTypeId, objCMFuncParaEN.ParameterType, objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCMFuncParaEN.AddNewRecord();
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFuncParaEN) == false)
{
var strMsg = string.Format("记录已经存在!参数名 = [{0}],数据类型Id = [{1}],参数类型 = [{2}],工程Id = [{3}]的数据已经存在!(in clsCMFuncParaBL.AddNewRecordWithMaxId)", objCMFuncParaEN.ParaName,objCMFuncParaEN.DataTypeId,objCMFuncParaEN.ParameterType,objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
string strCmFuncParaId = clsCMFuncParaBL.CMFuncParaDA.AddNewRecordBySQL2WithReturnKey(objCMFuncParaEN);
     objCMFuncParaEN.CmFuncParaId = strCmFuncParaId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
}
return strCmFuncParaId;
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFuncParaEN) == false)
{
var strMsg = string.Format("记录已经存在!参数名 = [{0}],数据类型Id = [{1}],参数类型 = [{2}],工程Id = [{3}]的数据已经存在!(in clsCMFuncParaBL.AddNewRecordWithReturnKey)", objCMFuncParaEN.ParaName,objCMFuncParaEN.DataTypeId,objCMFuncParaEN.ParameterType,objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
string strKey = clsCMFuncParaBL.CMFuncParaDA.AddNewRecordBySQL2WithReturnKey(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetCmFuncParaId(this clsCMFuncParaEN objCMFuncParaEN, string strCmFuncParaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
}
objCMFuncParaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.CmFuncParaId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.CmFuncParaId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.CmFuncParaId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaName(this clsCMFuncParaEN objCMFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conCMFuncPara.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, conCMFuncPara.ParaName);
}
objCMFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaComments(this clsCMFuncParaEN objCMFuncParaEN, string strParaComments, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaComments, 500, conCMFuncPara.ParaComments);
}
objCMFuncParaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaComments) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaComments, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaComments] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParameterType(this clsCMFuncParaEN objCMFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParameterType, conCMFuncPara.ParameterType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, conCMFuncPara.ParameterType);
}
objCMFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParameterType) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParameterType, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParameterType] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetDataTypeId(this clsCMFuncParaEN objCMFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conCMFuncPara.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conCMFuncPara.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conCMFuncPara.DataTypeId);
}
objCMFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.DataTypeId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.DataTypeId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.DataTypeId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParameterTypeFullName(this clsCMFuncParaEN objCMFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, conCMFuncPara.ParameterTypeFullName);
}
objCMFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParameterTypeFullName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetIsByRef(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, conCMFuncPara.IsByRef);
objCMFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.IsByRef) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.IsByRef, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.IsByRef] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaCnName(this clsCMFuncParaEN objCMFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, conCMFuncPara.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, conCMFuncPara.ParaCnName);
}
objCMFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaCnName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaCnName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaCnName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetIsKnownType(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsKnownType, string strComparisonOp="")
	{
objCMFuncParaEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.IsKnownType) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.IsKnownType, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.IsKnownType] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetPrjId(this clsCMFuncParaEN objCMFuncParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMFuncPara.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMFuncPara.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMFuncPara.PrjId);
}
objCMFuncParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.PrjId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.PrjId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.PrjId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetUpdDate(this clsCMFuncParaEN objCMFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFuncPara.UpdDate);
}
objCMFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.UpdDate) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.UpdDate, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.UpdDate] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetUpdUser(this clsCMFuncParaEN objCMFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFuncPara.UpdUser);
}
objCMFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.UpdUser) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.UpdUser, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.UpdUser] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetMemo(this clsCMFuncParaEN objCMFuncParaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFuncPara.Memo);
}
objCMFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.Memo) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.Memo, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.Memo] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMFuncParaEN objCMFuncParaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMFuncParaEN.CheckPropertyNew();
clsCMFuncParaEN objCMFuncParaCond = new clsCMFuncParaEN();
string strCondition = objCMFuncParaCond
.SetCmFuncParaId(objCMFuncParaEN.CmFuncParaId, "<>")
.SetParaName(objCMFuncParaEN.ParaName, "=")
.SetDataTypeId(objCMFuncParaEN.DataTypeId, "=")
.SetParameterType(objCMFuncParaEN.ParameterType, "=")
.SetPrjId(objCMFuncParaEN.PrjId, "=")
.GetCombineCondition();
objCMFuncParaEN._IsCheckProperty = true;
bool bolIsExist = clsCMFuncParaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_ParaName_DataTypeId_ParameterType)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMFuncParaEN.Update();
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
 /// <param name = "objCMFuncPara">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMFuncParaEN objCMFuncPara)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMFuncParaEN objCMFuncParaCond = new clsCMFuncParaEN();
string strCondition = objCMFuncParaCond
.SetParaName(objCMFuncPara.ParaName, "=")
.SetDataTypeId(objCMFuncPara.DataTypeId, "=")
.SetParameterType(objCMFuncPara.ParameterType, "=")
.SetPrjId(objCMFuncPara.PrjId, "=")
.GetCombineCondition();
objCMFuncPara._IsCheckProperty = true;
bool bolIsExist = clsCMFuncParaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMFuncPara.CmFuncParaId = clsCMFuncParaBL.GetFirstID_S(strCondition);
objCMFuncPara.UpdateWithCondition(strCondition);
}
else
{
objCMFuncPara.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
objCMFuncPara.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFuncParaEN objCMFuncParaEN)
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFuncParaBL.CMFuncParaDA.UpdateBySql2(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFuncParaEN objCMFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFuncParaBL.CMFuncParaDA.UpdateBySql2(objCMFuncParaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFuncParaEN objCMFuncParaEN, string strWhereCond)
{
try
{
bool bolResult = clsCMFuncParaBL.CMFuncParaDA.UpdateBySqlWithCondition(objCMFuncParaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFuncParaEN objCMFuncParaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMFuncParaBL.CMFuncParaDA.UpdateBySqlWithConditionTransaction(objCMFuncParaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMFuncParaEN objCMFuncParaEN)
{
try
{
int intRecNum = clsCMFuncParaBL.CMFuncParaDA.DelRecord(objCMFuncParaEN.CmFuncParaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaENS">源对象</param>
 /// <param name = "objCMFuncParaENT">目标对象</param>
 public static void CopyTo(this clsCMFuncParaEN objCMFuncParaENS, clsCMFuncParaEN objCMFuncParaENT)
{
try
{
objCMFuncParaENT.CmFuncParaId = objCMFuncParaENS.CmFuncParaId; //函数参数Id
objCMFuncParaENT.ParaName = objCMFuncParaENS.ParaName; //参数名
objCMFuncParaENT.ParaComments = objCMFuncParaENS.ParaComments; //参数注释
objCMFuncParaENT.ParameterType = objCMFuncParaENS.ParameterType; //参数类型
objCMFuncParaENT.DataTypeId = objCMFuncParaENS.DataTypeId; //数据类型Id
objCMFuncParaENT.ParameterTypeFullName = objCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objCMFuncParaENT.IsByRef = objCMFuncParaENS.IsByRef; //是否引用型参数
objCMFuncParaENT.ParaCnName = objCMFuncParaENS.ParaCnName; //参数中文名
objCMFuncParaENT.IsKnownType = objCMFuncParaENS.IsKnownType; //是否已知类型
objCMFuncParaENT.PrjId = objCMFuncParaENS.PrjId; //工程Id
objCMFuncParaENT.UpdDate = objCMFuncParaENS.UpdDate; //修改日期
objCMFuncParaENT.UpdUser = objCMFuncParaENS.UpdUser; //修改者
objCMFuncParaENT.Memo = objCMFuncParaENS.Memo; //说明
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
 /// <param name = "objCMFuncParaENS">源对象</param>
 /// <returns>目标对象=>clsCMFuncParaEN:objCMFuncParaENT</returns>
 public static clsCMFuncParaEN CopyTo(this clsCMFuncParaEN objCMFuncParaENS)
{
try
{
 clsCMFuncParaEN objCMFuncParaENT = new clsCMFuncParaEN()
{
CmFuncParaId = objCMFuncParaENS.CmFuncParaId, //函数参数Id
ParaName = objCMFuncParaENS.ParaName, //参数名
ParaComments = objCMFuncParaENS.ParaComments, //参数注释
ParameterType = objCMFuncParaENS.ParameterType, //参数类型
DataTypeId = objCMFuncParaENS.DataTypeId, //数据类型Id
ParameterTypeFullName = objCMFuncParaENS.ParameterTypeFullName, //参数类型全名
IsByRef = objCMFuncParaENS.IsByRef, //是否引用型参数
ParaCnName = objCMFuncParaENS.ParaCnName, //参数中文名
IsKnownType = objCMFuncParaENS.IsKnownType, //是否已知类型
PrjId = objCMFuncParaENS.PrjId, //工程Id
UpdDate = objCMFuncParaENS.UpdDate, //修改日期
UpdUser = objCMFuncParaENS.UpdUser, //修改者
Memo = objCMFuncParaENS.Memo, //说明
};
 return objCMFuncParaENT;
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
public static void CheckPropertyNew(this clsCMFuncParaEN objCMFuncParaEN)
{
 clsCMFuncParaBL.CMFuncParaDA.CheckPropertyNew(objCMFuncParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMFuncParaEN objCMFuncParaEN)
{
 clsCMFuncParaBL.CMFuncParaDA.CheckProperty4Condition(objCMFuncParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFuncParaEN objCMFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.CmFuncParaId, objCMFuncParaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaName, objCMFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaComments) == true)
{
string strComparisonOpParaComments = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaComments, objCMFuncParaCond.ParaComments, strComparisonOpParaComments);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParameterType, objCMFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.DataTypeId, objCMFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParameterTypeFullName, objCMFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.IsByRef) == true)
{
if (objCMFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFuncPara.IsByRef);
}
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaCnName, objCMFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.IsKnownType) == true)
{
if (objCMFuncParaCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFuncPara.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFuncPara.IsKnownType);
}
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.PrjId) == true)
{
string strComparisonOpPrjId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.PrjId, objCMFuncParaCond.PrjId, strComparisonOpPrjId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.UpdDate, objCMFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.UpdUser, objCMFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.Memo) == true)
{
string strComparisonOpMemo = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.Memo, objCMFuncParaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMFuncPara(CM函数参数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_ParaName_DataTypeId_ParameterType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMFuncParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMFuncParaEN objCMFuncParaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMFuncParaEN == null) return true;
if (objCMFuncParaEN.CmFuncParaId == null || objCMFuncParaEN.CmFuncParaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
if (clsCMFuncParaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmFuncParaId !=  '{0}'", objCMFuncParaEN.CmFuncParaId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
if (clsCMFuncParaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMFuncPara(CM函数参数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ParaName_DataTypeId_ParameterType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFuncParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMFuncParaEN objCMFuncParaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFuncParaEN == null) return "";
if (objCMFuncParaEN.CmFuncParaId == null || objCMFuncParaEN.CmFuncParaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFuncParaId !=  '{0}'", objCMFuncParaEN.CmFuncParaId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMFuncPara
{
public virtual bool UpdRelaTabDate(string strCmFuncParaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM函数参数(CMFuncPara)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMFuncParaBL
{
public static RelatedActions_CMFuncPara relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMFuncParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMFuncParaDA CMFuncParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMFuncParaDA();
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
 public clsCMFuncParaBL()
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
if (string.IsNullOrEmpty(clsCMFuncParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFuncParaEN._ConnectString);
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
public static DataTable GetDataTable_CMFuncPara(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMFuncParaDA.GetDataTable_CMFuncPara(strWhereCond);
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
objDT = CMFuncParaDA.GetDataTable(strWhereCond);
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
objDT = CMFuncParaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMFuncParaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMFuncParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMFuncParaDA.GetDataTable_Top(objTopPara);
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
objDT = CMFuncParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLstByCmFuncParaIdLst(List<string> arrCmFuncParaIdLst)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFuncParaIdLst, true);
 string strWhereCond = string.Format("CmFuncParaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMFuncParaEN> GetObjLstByCmFuncParaIdLstCache(List<string> arrCmFuncParaIdLst)
{
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
List<clsCMFuncParaEN> arrCMFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsCMFuncParaEN> arrCMFuncParaObjLst_Sel =
arrCMFuncParaObjLstCache
.Where(x => arrCmFuncParaIdLst.Contains(x.CmFuncParaId));
return arrCMFuncParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLst(string strWhereCond)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
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
public static List<clsCMFuncParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMFuncParaEN> GetSubObjLstCache(clsCMFuncParaEN objCMFuncParaCond)
{
List<clsCMFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFuncPara._AttributeName)
{
if (objCMFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objCMFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFuncParaCond[strFldName].ToString());
}
else
{
if (objCMFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFuncParaCond[strFldName]));
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
public static List<clsCMFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
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
public static List<clsCMFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
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
List<clsCMFuncParaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMFuncParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
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
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
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
public static List<clsCMFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
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
public static List<clsCMFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMFuncParaEN> arrObjLst = new List<clsCMFuncParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFuncParaEN objCMFuncParaEN = new clsCMFuncParaEN();
try
{
objCMFuncParaEN.CmFuncParaId = objRow[conCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objCMFuncParaEN.ParaName = objRow[conCMFuncPara.ParaName].ToString().Trim(); //参数名
objCMFuncParaEN.ParaComments = objRow[conCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[conCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objCMFuncParaEN.ParameterType = objRow[conCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objCMFuncParaEN.DataTypeId = objRow[conCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objCMFuncParaEN.ParameterTypeFullName = objRow[conCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objCMFuncParaEN.ParaCnName = objRow[conCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objCMFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objCMFuncParaEN.PrjId = objRow[conCMFuncPara.PrjId].ToString().Trim(); //工程Id
objCMFuncParaEN.UpdDate = objRow[conCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[conCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objCMFuncParaEN.UpdUser = objRow[conCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[conCMFuncPara.UpdUser].ToString().Trim(); //修改者
objCMFuncParaEN.Memo = objRow[conCMFuncPara.Memo] == DBNull.Value ? null : objRow[conCMFuncPara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFuncParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMFuncParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMFuncPara(ref clsCMFuncParaEN objCMFuncParaEN)
{
bool bolResult = CMFuncParaDA.GetCMFuncPara(ref objCMFuncParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
if (strCmFuncParaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFuncParaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFuncParaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMFuncParaEN objCMFuncParaEN = CMFuncParaDA.GetObjByCmFuncParaId(strCmFuncParaId);
return objCMFuncParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMFuncParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMFuncParaEN objCMFuncParaEN = CMFuncParaDA.GetFirstObj(strWhereCond);
 return objCMFuncParaEN;
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
public static clsCMFuncParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMFuncParaEN objCMFuncParaEN = CMFuncParaDA.GetObjByDataRow(objRow);
 return objCMFuncParaEN;
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
public static clsCMFuncParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMFuncParaEN objCMFuncParaEN = CMFuncParaDA.GetObjByDataRow(objRow);
 return objCMFuncParaEN;
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
 /// <param name = "strCmFuncParaId">所给的关键字</param>
 /// <param name = "lstCMFuncParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFuncParaEN GetObjByCmFuncParaIdFromList(string strCmFuncParaId, List<clsCMFuncParaEN> lstCMFuncParaObjLst)
{
foreach (clsCMFuncParaEN objCMFuncParaEN in lstCMFuncParaObjLst)
{
if (objCMFuncParaEN.CmFuncParaId == strCmFuncParaId)
{
return objCMFuncParaEN;
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
 string strMaxCmFuncParaId;
 try
 {
 strMaxCmFuncParaId = clsCMFuncParaDA.GetMaxStrId();
 return strMaxCmFuncParaId;
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
 string strCmFuncParaId;
 try
 {
 strCmFuncParaId = new clsCMFuncParaDA().GetFirstID(strWhereCond);
 return strCmFuncParaId;
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
 arrList = CMFuncParaDA.GetID(strWhereCond);
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
bool bolIsExist = CMFuncParaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFuncParaId)
{
if (string.IsNullOrEmpty(strCmFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFuncParaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMFuncParaDA.IsExist(strCmFuncParaId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmFuncParaId">函数参数Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmFuncParaId, string strOpUser)
{
clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);
objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMFuncParaEN.UpdUser = strOpUser;
return clsCMFuncParaBL.UpdateBySql2(objCMFuncParaEN);
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
 bolIsExist = clsCMFuncParaDA.IsExistTable();
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
 bolIsExist = CMFuncParaDA.IsExistTable(strTabName);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFuncParaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!参数名 = [{0}],数据类型Id = [{1}],参数类型 = [{2}],工程Id = [{3}]的数据已经存在!(in clsCMFuncParaBL.AddNewRecordBySql2)", objCMFuncParaEN.ParaName,objCMFuncParaEN.DataTypeId,objCMFuncParaEN.ParameterType,objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
bool bolResult = CMFuncParaDA.AddNewRecordBySQL2(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMFuncParaEN objCMFuncParaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFuncParaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!参数名 = [{0}],数据类型Id = [{1}],参数类型 = [{2}],工程Id = [{3}]的数据已经存在!(in clsCMFuncParaBL.AddNewRecordBySql2WithReturnKey)", objCMFuncParaEN.ParaName,objCMFuncParaEN.DataTypeId,objCMFuncParaEN.ParameterType,objCMFuncParaEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaBL.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
 }
string strKey = CMFuncParaDA.AddNewRecordBySQL2WithReturnKey(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMFuncParaEN objCMFuncParaEN)
{
try
{
bool bolResult = CMFuncParaDA.Update(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMFuncParaEN objCMFuncParaEN)
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMFuncParaDA.UpdateBySql2(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFuncParaBL.ReFreshCache();

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
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
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmFuncParaId)
{
try
{
 clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);

if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(objCMFuncParaEN.CmFuncParaId, objCMFuncParaEN.UpdUser);
}
if (objCMFuncParaEN != null)
{
int intRecNum = CMFuncParaDA.DelRecord(strCmFuncParaId);
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
/// <param name="strCmFuncParaId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmFuncParaId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
//删除与表:[CMFuncPara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMFuncPara.CmFuncParaId,
//strCmFuncParaId);
//        clsCMFuncParaBL.DelCMFuncParasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFuncParaBL.DelRecord(strCmFuncParaId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFuncParaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFuncParaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmFuncParaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMFuncParaBL.relatedActions != null)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(strCmFuncParaId, "UpdRelaTabDate");
}
bool bolResult = CMFuncParaDA.DelRecord(strCmFuncParaId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmFuncParaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMFuncParas(List<string> arrCmFuncParaIdLst)
{
if (arrCmFuncParaIdLst.Count == 0) return 0;
try
{
if (clsCMFuncParaBL.relatedActions != null)
{
foreach (var strCmFuncParaId in arrCmFuncParaIdLst)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(strCmFuncParaId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMFuncParaDA.DelCMFuncPara(arrCmFuncParaIdLst);
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
public static int DelCMFuncParasByCond(string strWhereCond)
{
try
{
if (clsCMFuncParaBL.relatedActions != null)
{
List<string> arrCmFuncParaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmFuncParaId in arrCmFuncParaId)
{
clsCMFuncParaBL.relatedActions.UpdRelaTabDate(strCmFuncParaId, "UpdRelaTabDate");
}
}
int intRecNum = CMFuncParaDA.DelCMFuncPara(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMFuncPara]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmFuncParaId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmFuncParaId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
//删除与表:[CMFuncPara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFuncParaBL.DelRecord(strCmFuncParaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFuncParaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFuncParaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMFuncParaENS">源对象</param>
 /// <param name = "objCMFuncParaENT">目标对象</param>
 public static void CopyTo(clsCMFuncParaEN objCMFuncParaENS, clsCMFuncParaEN objCMFuncParaENT)
{
try
{
objCMFuncParaENT.CmFuncParaId = objCMFuncParaENS.CmFuncParaId; //函数参数Id
objCMFuncParaENT.ParaName = objCMFuncParaENS.ParaName; //参数名
objCMFuncParaENT.ParaComments = objCMFuncParaENS.ParaComments; //参数注释
objCMFuncParaENT.ParameterType = objCMFuncParaENS.ParameterType; //参数类型
objCMFuncParaENT.DataTypeId = objCMFuncParaENS.DataTypeId; //数据类型Id
objCMFuncParaENT.ParameterTypeFullName = objCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objCMFuncParaENT.IsByRef = objCMFuncParaENS.IsByRef; //是否引用型参数
objCMFuncParaENT.ParaCnName = objCMFuncParaENS.ParaCnName; //参数中文名
objCMFuncParaENT.IsKnownType = objCMFuncParaENS.IsKnownType; //是否已知类型
objCMFuncParaENT.PrjId = objCMFuncParaENS.PrjId; //工程Id
objCMFuncParaENT.UpdDate = objCMFuncParaENS.UpdDate; //修改日期
objCMFuncParaENT.UpdUser = objCMFuncParaENS.UpdUser; //修改者
objCMFuncParaENT.Memo = objCMFuncParaENS.Memo; //说明
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
 /// <param name = "objCMFuncParaEN">源简化对象</param>
 public static void SetUpdFlag(clsCMFuncParaEN objCMFuncParaEN)
{
try
{
objCMFuncParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMFuncParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMFuncPara.CmFuncParaId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.CmFuncParaId = objCMFuncParaEN.CmFuncParaId; //函数参数Id
}
if (arrFldSet.Contains(conCMFuncPara.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.ParaName = objCMFuncParaEN.ParaName; //参数名
}
if (arrFldSet.Contains(conCMFuncPara.ParaComments, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.ParaComments = objCMFuncParaEN.ParaComments == "[null]" ? null :  objCMFuncParaEN.ParaComments; //参数注释
}
if (arrFldSet.Contains(conCMFuncPara.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.ParameterType = objCMFuncParaEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(conCMFuncPara.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.DataTypeId = objCMFuncParaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conCMFuncPara.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.ParameterTypeFullName = objCMFuncParaEN.ParameterTypeFullName == "[null]" ? null :  objCMFuncParaEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(conCMFuncPara.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.IsByRef = objCMFuncParaEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(conCMFuncPara.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.ParaCnName = objCMFuncParaEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(conCMFuncPara.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.IsKnownType = objCMFuncParaEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(conCMFuncPara.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.PrjId = objCMFuncParaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMFuncPara.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.UpdDate = objCMFuncParaEN.UpdDate == "[null]" ? null :  objCMFuncParaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMFuncPara.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.UpdUser = objCMFuncParaEN.UpdUser == "[null]" ? null :  objCMFuncParaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMFuncPara.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFuncParaEN.Memo = objCMFuncParaEN.Memo == "[null]" ? null :  objCMFuncParaEN.Memo; //说明
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
 /// <param name = "objCMFuncParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMFuncParaEN objCMFuncParaEN)
{
try
{
if (objCMFuncParaEN.ParaComments == "[null]") objCMFuncParaEN.ParaComments = null; //参数注释
if (objCMFuncParaEN.ParameterTypeFullName == "[null]") objCMFuncParaEN.ParameterTypeFullName = null; //参数类型全名
if (objCMFuncParaEN.UpdDate == "[null]") objCMFuncParaEN.UpdDate = null; //修改日期
if (objCMFuncParaEN.UpdUser == "[null]") objCMFuncParaEN.UpdUser = null; //修改者
if (objCMFuncParaEN.Memo == "[null]") objCMFuncParaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMFuncParaEN objCMFuncParaEN)
{
 CMFuncParaDA.CheckPropertyNew(objCMFuncParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMFuncParaEN objCMFuncParaEN)
{
 CMFuncParaDA.CheckProperty4Condition(objCMFuncParaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsCMFuncParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFuncParaBL没有刷新缓存机制(clsCMFuncParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFuncParaId");
//if (arrCMFuncParaObjLstCache == null)
//{
//arrCMFuncParaObjLstCache = CMFuncParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFuncParaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFuncParaEN GetObjByCmFuncParaIdCache(string strCmFuncParaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
List<clsCMFuncParaEN> arrCMFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsCMFuncParaEN> arrCMFuncParaObjLst_Sel =
arrCMFuncParaObjLstCache
.Where(x=> x.CmFuncParaId == strCmFuncParaId 
);
if (arrCMFuncParaObjLst_Sel.Count() == 0)
{
   clsCMFuncParaEN obj = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMFuncParaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFuncParaEN> GetAllCMFuncParaObjLstCache()
{
//获取缓存中的对象列表
List<clsCMFuncParaEN> arrCMFuncParaObjLstCache = GetObjLstCache(); 
return arrCMFuncParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
List<clsCMFuncParaEN> arrCMFuncParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMFuncParaObjLstCache;
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
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFuncParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMFuncParaEN._RefreshTimeLst.Count == 0) return "";
return clsCMFuncParaEN._RefreshTimeLst[clsCMFuncParaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCMFuncParaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFuncParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMFuncParaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMFuncPara(CM函数参数)
 /// 唯一性条件:PrjId_ParaName_DataTypeId_ParameterType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFuncParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMFuncParaEN objCMFuncParaEN)
{
//检测记录是否存在
string strResult = CMFuncParaDA.GetUniCondStr(objCMFuncParaEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCmFuncParaId)
{
if (strInFldName != conCMFuncPara.CmFuncParaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMFuncPara._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMFuncPara._AttributeName));
throw new Exception(strMsg);
}
var objCMFuncPara = clsCMFuncParaBL.GetObjByCmFuncParaIdCache(strCmFuncParaId);
if (objCMFuncPara == null) return "";
return objCMFuncPara[strOutFldName].ToString();
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
int intRecCount = clsCMFuncParaDA.GetRecCount(strTabName);
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
int intRecCount = clsCMFuncParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMFuncParaDA.GetRecCount();
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
int intRecCount = clsCMFuncParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMFuncParaEN objCMFuncParaCond)
{
List<clsCMFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFuncPara._AttributeName)
{
if (objCMFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objCMFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFuncParaCond[strFldName].ToString());
}
else
{
if (objCMFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFuncParaCond[strFldName]));
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
 List<string> arrList = clsCMFuncParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMFuncParaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMFuncParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMFuncParaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFuncParaDA.SetFldValue(clsCMFuncParaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMFuncParaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFuncParaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFuncParaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFuncParaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMFuncPara] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数参数Id*/ 
 strCreateTabCode.Append(" CmFuncParaId char(8) primary key, "); 
 // /**参数名*/ 
 strCreateTabCode.Append(" ParaName varchar(50) not Null, "); 
 // /**参数注释*/ 
 strCreateTabCode.Append(" ParaComments varchar(500) Null, "); 
 // /**参数类型*/ 
 strCreateTabCode.Append(" ParameterType varchar(100) not Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**参数类型全名*/ 
 strCreateTabCode.Append(" ParameterTypeFullName varchar(500) Null, "); 
 // /**是否引用型参数*/ 
 strCreateTabCode.Append(" IsByRef bit not Null, "); 
 // /**参数中文名*/ 
 strCreateTabCode.Append(" ParaCnName varchar(50) not Null, "); 
 // /**是否已知类型*/ 
 strCreateTabCode.Append(" IsKnownType bit Null, "); 
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
 /// CM函数参数(CMFuncPara)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMFuncPara : clsCommFun4BL
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
clsCMFuncParaBL.ReFreshThisCache();
}
}

}