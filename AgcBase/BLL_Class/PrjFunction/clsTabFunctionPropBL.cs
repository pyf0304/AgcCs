
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFunctionPropBL
 表名:TabFunctionProp(00050522)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:37
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
public static class  clsTabFunctionPropBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFunctionPropEN GetObj(this K_mId_TabFunctionProp myKey)
{
clsTabFunctionPropEN objTabFunctionPropEN = clsTabFunctionPropBL.TabFunctionPropDA.GetObjBymId(myKey.Value);
return objTabFunctionPropEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFunctionPropEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],表ID = [{1}],代码类型Id = [{2}],函数ID = [{3}],函数模板Id = [{4}]的数据已经存在!(in clsTabFunctionPropBL.AddNewRecord)", objTabFunctionPropEN.PrjId,objTabFunctionPropEN.TabId,objTabFunctionPropEN.CodeTypeId,objTabFunctionPropEN.FuncId4GC,objTabFunctionPropEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabFunctionPropBL.TabFunctionPropDA.AddNewRecordBySQL2(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
public static bool AddRecordEx(this clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objTabFunctionPropEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabFunctionPropEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],表ID(TabId)=[{1}],代码类型Id(CodeTypeId)=[{2}],函数ID(FuncId4GC)=[{3}],函数模板Id(FunctionTemplateId)=[{4}])已经存在,不能重复!", objTabFunctionPropEN.PrjId, objTabFunctionPropEN.TabId, objTabFunctionPropEN.CodeTypeId, objTabFunctionPropEN.FuncId4GC, objTabFunctionPropEN.FunctionTemplateId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabFunctionPropEN.AddNewRecord();
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabFunctionPropEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],表ID = [{1}],代码类型Id = [{2}],函数ID = [{3}],函数模板Id = [{4}]的数据已经存在!(in clsTabFunctionPropBL.AddNewRecordWithReturnKey)", objTabFunctionPropEN.PrjId,objTabFunctionPropEN.TabId,objTabFunctionPropEN.CodeTypeId,objTabFunctionPropEN.FuncId4GC,objTabFunctionPropEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabFunctionPropBL.TabFunctionPropDA.AddNewRecordBySQL2WithReturnKey(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetmId(this clsTabFunctionPropEN objTabFunctionPropEN, long lngmId, string strComparisonOp="")
	{
objTabFunctionPropEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.mId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.mId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.mId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetTabId(this clsTabFunctionPropEN objTabFunctionPropEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conTabFunctionProp.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabFunctionProp.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabFunctionProp.TabId);
}
objTabFunctionPropEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.TabId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.TabId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.TabId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetFunctionTemplateId(this clsTabFunctionPropEN objTabFunctionPropEN, string strFunctionTemplateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, conTabFunctionProp.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, conTabFunctionProp.FunctionTemplateId);
}
objTabFunctionPropEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.FunctionTemplateId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.FunctionTemplateId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.FunctionTemplateId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetCodeTypeId(this clsTabFunctionPropEN objTabFunctionPropEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conTabFunctionProp.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conTabFunctionProp.CodeTypeId);
}
objTabFunctionPropEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.CodeTypeId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.CodeTypeId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.CodeTypeId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetFuncId4GC(this clsTabFunctionPropEN objTabFunctionPropEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, conTabFunctionProp.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conTabFunctionProp.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conTabFunctionProp.FuncId4GC);
}
objTabFunctionPropEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.FuncId4GC) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.FuncId4GC, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.FuncId4GC] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetMethodModifierId(this clsTabFunctionPropEN objTabFunctionPropEN, string strMethodModifierId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMethodModifierId, 2, conTabFunctionProp.MethodModifierId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMethodModifierId, 2, conTabFunctionProp.MethodModifierId);
}
objTabFunctionPropEN.MethodModifierId = strMethodModifierId; //函数修饰语Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.MethodModifierId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.MethodModifierId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.MethodModifierId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetIsForAllTemplate(this clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsForAllTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsForAllTemplate, conTabFunctionProp.IsForAllTemplate);
objTabFunctionPropEN.IsForAllTemplate = bolIsForAllTemplate; //是否针对所有模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.IsForAllTemplate) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.IsForAllTemplate, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.IsForAllTemplate] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetOrderNum(this clsTabFunctionPropEN objTabFunctionPropEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conTabFunctionProp.OrderNum);
objTabFunctionPropEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.OrderNum) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.OrderNum, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.OrderNum] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetPrjId(this clsTabFunctionPropEN objTabFunctionPropEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFunctionProp.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFunctionProp.PrjId);
}
objTabFunctionPropEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.PrjId) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.PrjId, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.PrjId] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetUpdDate(this clsTabFunctionPropEN objTabFunctionPropEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabFunctionProp.UpdDate);
}
objTabFunctionPropEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.UpdDate) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.UpdDate, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.UpdDate] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetUpdUser(this clsTabFunctionPropEN objTabFunctionPropEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabFunctionProp.UpdUser);
}
objTabFunctionPropEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.UpdUser) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.UpdUser, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.UpdUser] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFunctionPropEN SetMemo(this clsTabFunctionPropEN objTabFunctionPropEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFunctionProp.Memo);
}
objTabFunctionPropEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFunctionPropEN.dicFldComparisonOp.ContainsKey(conTabFunctionProp.Memo) == false)
{
objTabFunctionPropEN.dicFldComparisonOp.Add(conTabFunctionProp.Memo, strComparisonOp);
}
else
{
objTabFunctionPropEN.dicFldComparisonOp[conTabFunctionProp.Memo] = strComparisonOp;
}
}
return objTabFunctionPropEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabFunctionPropEN objTabFunctionPropEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabFunctionPropEN.CheckPropertyNew();
clsTabFunctionPropEN objTabFunctionPropCond = new clsTabFunctionPropEN();
string strCondition = objTabFunctionPropCond
.SetmId(objTabFunctionPropEN.mId, "<>")
.SetPrjId(objTabFunctionPropEN.PrjId, "=")
.SetTabId(objTabFunctionPropEN.TabId, "=")
.SetCodeTypeId(objTabFunctionPropEN.CodeTypeId, "=")
.SetFuncId4GC(objTabFunctionPropEN.FuncId4GC, "=")
.SetFunctionTemplateId(objTabFunctionPropEN.FunctionTemplateId, "=")
.GetCombineCondition();
objTabFunctionPropEN._IsCheckProperty = true;
bool bolIsExist = clsTabFunctionPropBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_TabId_CodeTypeId_FuncId4GC_FunctionTemplateId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabFunctionPropEN.Update();
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
 /// <param name = "objTabFunctionProp">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabFunctionPropEN objTabFunctionProp)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabFunctionPropEN objTabFunctionPropCond = new clsTabFunctionPropEN();
string strCondition = objTabFunctionPropCond
.SetPrjId(objTabFunctionProp.PrjId, "=")
.SetTabId(objTabFunctionProp.TabId, "=")
.SetCodeTypeId(objTabFunctionProp.CodeTypeId, "=")
.SetFuncId4GC(objTabFunctionProp.FuncId4GC, "=")
.SetFunctionTemplateId(objTabFunctionProp.FunctionTemplateId, "=")
.GetCombineCondition();
objTabFunctionProp._IsCheckProperty = true;
bool bolIsExist = clsTabFunctionPropBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabFunctionProp.mId = clsTabFunctionPropBL.GetFirstID_S(strCondition);
objTabFunctionProp.UpdateWithCondition(strCondition);
}
else
{
objTabFunctionProp.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFunctionPropEN objTabFunctionPropEN)
{
 if (objTabFunctionPropEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFunctionPropBL.TabFunctionPropDA.UpdateBySql2(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFunctionPropEN objTabFunctionPropEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabFunctionPropEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabFunctionPropBL.TabFunctionPropDA.UpdateBySql2(objTabFunctionPropEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFunctionPropEN objTabFunctionPropEN, string strWhereCond)
{
try
{
bool bolResult = clsTabFunctionPropBL.TabFunctionPropDA.UpdateBySqlWithCondition(objTabFunctionPropEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFunctionPropEN objTabFunctionPropEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabFunctionPropBL.TabFunctionPropDA.UpdateBySqlWithConditionTransaction(objTabFunctionPropEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabFunctionPropEN objTabFunctionPropEN)
{
try
{
int intRecNum = clsTabFunctionPropBL.TabFunctionPropDA.DelRecord(objTabFunctionPropEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropENS">源对象</param>
 /// <param name = "objTabFunctionPropENT">目标对象</param>
 public static void CopyTo(this clsTabFunctionPropEN objTabFunctionPropENS, clsTabFunctionPropEN objTabFunctionPropENT)
{
try
{
objTabFunctionPropENT.mId = objTabFunctionPropENS.mId; //mId
objTabFunctionPropENT.TabId = objTabFunctionPropENS.TabId; //表ID
objTabFunctionPropENT.FunctionTemplateId = objTabFunctionPropENS.FunctionTemplateId; //函数模板Id
objTabFunctionPropENT.CodeTypeId = objTabFunctionPropENS.CodeTypeId; //代码类型Id
objTabFunctionPropENT.FuncId4GC = objTabFunctionPropENS.FuncId4GC; //函数ID
objTabFunctionPropENT.MethodModifierId = objTabFunctionPropENS.MethodModifierId; //函数修饰语Id
objTabFunctionPropENT.IsForAllTemplate = objTabFunctionPropENS.IsForAllTemplate; //是否针对所有模板
objTabFunctionPropENT.OrderNum = objTabFunctionPropENS.OrderNum; //序号
objTabFunctionPropENT.PrjId = objTabFunctionPropENS.PrjId; //工程Id
objTabFunctionPropENT.UpdDate = objTabFunctionPropENS.UpdDate; //修改日期
objTabFunctionPropENT.UpdUser = objTabFunctionPropENS.UpdUser; //修改者
objTabFunctionPropENT.Memo = objTabFunctionPropENS.Memo; //说明
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
 /// <param name = "objTabFunctionPropENS">源对象</param>
 /// <returns>目标对象=>clsTabFunctionPropEN:objTabFunctionPropENT</returns>
 public static clsTabFunctionPropEN CopyTo(this clsTabFunctionPropEN objTabFunctionPropENS)
{
try
{
 clsTabFunctionPropEN objTabFunctionPropENT = new clsTabFunctionPropEN()
{
mId = objTabFunctionPropENS.mId, //mId
TabId = objTabFunctionPropENS.TabId, //表ID
FunctionTemplateId = objTabFunctionPropENS.FunctionTemplateId, //函数模板Id
CodeTypeId = objTabFunctionPropENS.CodeTypeId, //代码类型Id
FuncId4GC = objTabFunctionPropENS.FuncId4GC, //函数ID
MethodModifierId = objTabFunctionPropENS.MethodModifierId, //函数修饰语Id
IsForAllTemplate = objTabFunctionPropENS.IsForAllTemplate, //是否针对所有模板
OrderNum = objTabFunctionPropENS.OrderNum, //序号
PrjId = objTabFunctionPropENS.PrjId, //工程Id
UpdDate = objTabFunctionPropENS.UpdDate, //修改日期
UpdUser = objTabFunctionPropENS.UpdUser, //修改者
Memo = objTabFunctionPropENS.Memo, //说明
};
 return objTabFunctionPropENT;
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
public static void CheckPropertyNew(this clsTabFunctionPropEN objTabFunctionPropEN)
{
 clsTabFunctionPropBL.TabFunctionPropDA.CheckPropertyNew(objTabFunctionPropEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabFunctionPropEN objTabFunctionPropEN)
{
 clsTabFunctionPropBL.TabFunctionPropDA.CheckProperty4Condition(objTabFunctionPropEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFunctionPropEN objTabFunctionPropCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.mId) == true)
{
string strComparisonOpmId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFunctionProp.mId, objTabFunctionPropCond.mId, strComparisonOpmId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.TabId) == true)
{
string strComparisonOpTabId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.TabId, objTabFunctionPropCond.TabId, strComparisonOpTabId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.FunctionTemplateId, objTabFunctionPropCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.CodeTypeId, objTabFunctionPropCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.FuncId4GC, objTabFunctionPropCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.MethodModifierId) == true)
{
string strComparisonOpMethodModifierId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.MethodModifierId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.MethodModifierId, objTabFunctionPropCond.MethodModifierId, strComparisonOpMethodModifierId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.IsForAllTemplate) == true)
{
if (objTabFunctionPropCond.IsForAllTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFunctionProp.IsForAllTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFunctionProp.IsForAllTemplate);
}
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.OrderNum) == true)
{
string strComparisonOpOrderNum = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFunctionProp.OrderNum, objTabFunctionPropCond.OrderNum, strComparisonOpOrderNum);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.PrjId) == true)
{
string strComparisonOpPrjId = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.PrjId, objTabFunctionPropCond.PrjId, strComparisonOpPrjId);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.UpdDate, objTabFunctionPropCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.UpdUser, objTabFunctionPropCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabFunctionPropCond.IsUpdated(conTabFunctionProp.Memo) == true)
{
string strComparisonOpMemo = objTabFunctionPropCond.dicFldComparisonOp[conTabFunctionProp.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFunctionProp.Memo, objTabFunctionPropCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabFunctionProp(表函数属性), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_TabId_CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabFunctionPropEN objTabFunctionPropEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabFunctionPropEN == null) return true;
if (objTabFunctionPropEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objTabFunctionPropEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objTabFunctionPropEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabFunctionPropEN.PrjId);
}
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFunctionPropEN.TabId);
 if (objTabFunctionPropEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objTabFunctionPropEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objTabFunctionPropEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objTabFunctionPropEN.FuncId4GC);
 if (objTabFunctionPropEN.FunctionTemplateId == null)
{
 sbCondition.AppendFormat(" and FunctionTemplateId is null", objTabFunctionPropEN.FunctionTemplateId);
}
else
{
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objTabFunctionPropEN.FunctionTemplateId);
}
if (clsTabFunctionPropBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabFunctionPropEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabFunctionPropEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFunctionPropEN.TabId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objTabFunctionPropEN.CodeTypeId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objTabFunctionPropEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objTabFunctionPropEN.FunctionTemplateId);
if (clsTabFunctionPropBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TabFunctionProp(表函数属性), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_TabId_CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabFunctionPropEN objTabFunctionPropEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFunctionPropEN == null) return "";
if (objTabFunctionPropEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objTabFunctionPropEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objTabFunctionPropEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabFunctionPropEN.PrjId);
}
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFunctionPropEN.TabId);
 if (objTabFunctionPropEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objTabFunctionPropEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objTabFunctionPropEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objTabFunctionPropEN.FuncId4GC);
 if (objTabFunctionPropEN.FunctionTemplateId == null)
{
 sbCondition.AppendFormat(" and FunctionTemplateId is null", objTabFunctionPropEN.FunctionTemplateId);
}
else
{
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objTabFunctionPropEN.FunctionTemplateId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabFunctionPropEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabFunctionPropEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabFunctionPropEN.TabId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objTabFunctionPropEN.CodeTypeId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objTabFunctionPropEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objTabFunctionPropEN.FunctionTemplateId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabFunctionProp
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表函数属性(TabFunctionProp)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabFunctionPropBL
{
public static RelatedActions_TabFunctionProp relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabFunctionPropDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabFunctionPropDA TabFunctionPropDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabFunctionPropDA();
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
 public clsTabFunctionPropBL()
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
if (string.IsNullOrEmpty(clsTabFunctionPropEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabFunctionPropEN._ConnectString);
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
public static DataTable GetDataTable_TabFunctionProp(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabFunctionPropDA.GetDataTable_TabFunctionProp(strWhereCond);
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
objDT = TabFunctionPropDA.GetDataTable(strWhereCond);
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
objDT = TabFunctionPropDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TabFunctionPropDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TabFunctionPropDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TabFunctionPropDA.GetDataTable_Top(objTopPara);
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
objDT = TabFunctionPropDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TabFunctionPropDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TabFunctionPropDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabFunctionPropEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabFunctionPropEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsTabFunctionPropEN._CurrTabName, strPrjId);
List<clsTabFunctionPropEN> arrTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFunctionPropEN> arrTabFunctionPropObjLst_Sel =
arrTabFunctionPropObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTabFunctionPropObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFunctionPropEN> GetObjLst(string strWhereCond)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
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
public static List<clsTabFunctionPropEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabFunctionPropCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabFunctionPropEN> GetSubObjLstCache(clsTabFunctionPropEN objTabFunctionPropCond)
{
 string strPrjId = objTabFunctionPropCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsTabFunctionPropBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsTabFunctionPropEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFunctionPropEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFunctionProp._AttributeName)
{
if (objTabFunctionPropCond.IsUpdated(strFldName) == false) continue;
if (objTabFunctionPropCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFunctionPropCond[strFldName].ToString());
}
else
{
if (objTabFunctionPropCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFunctionPropCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFunctionPropCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFunctionPropCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFunctionPropCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFunctionPropCond[strFldName]));
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
public static List<clsTabFunctionPropEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
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
public static List<clsTabFunctionPropEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
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
List<clsTabFunctionPropEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTabFunctionPropEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFunctionPropEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTabFunctionPropEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
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
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
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
public static List<clsTabFunctionPropEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabFunctionPropEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTabFunctionPropEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
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
public static List<clsTabFunctionPropEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFunctionPropEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabFunctionPropEN> arrObjLst = new List<clsTabFunctionPropEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabFunctionPropEN objTabFunctionPropEN = new clsTabFunctionPropEN();
try
{
objTabFunctionPropEN.mId = Int32.Parse(objRow[conTabFunctionProp.mId].ToString().Trim()); //mId
objTabFunctionPropEN.TabId = objRow[conTabFunctionProp.TabId].ToString().Trim(); //表ID
objTabFunctionPropEN.FunctionTemplateId = objRow[conTabFunctionProp.FunctionTemplateId] == DBNull.Value ? null : objRow[conTabFunctionProp.FunctionTemplateId].ToString().Trim(); //函数模板Id
objTabFunctionPropEN.CodeTypeId = objRow[conTabFunctionProp.CodeTypeId] == DBNull.Value ? null : objRow[conTabFunctionProp.CodeTypeId].ToString().Trim(); //代码类型Id
objTabFunctionPropEN.FuncId4GC = objRow[conTabFunctionProp.FuncId4GC].ToString().Trim(); //函数ID
objTabFunctionPropEN.MethodModifierId = objRow[conTabFunctionProp.MethodModifierId] == DBNull.Value ? null : objRow[conTabFunctionProp.MethodModifierId].ToString().Trim(); //函数修饰语Id
objTabFunctionPropEN.IsForAllTemplate = clsEntityBase2.TransNullToBool_S(objRow[conTabFunctionProp.IsForAllTemplate].ToString().Trim()); //是否针对所有模板
objTabFunctionPropEN.OrderNum = Int32.Parse(objRow[conTabFunctionProp.OrderNum].ToString().Trim()); //序号
objTabFunctionPropEN.PrjId = objRow[conTabFunctionProp.PrjId] == DBNull.Value ? null : objRow[conTabFunctionProp.PrjId].ToString().Trim(); //工程Id
objTabFunctionPropEN.UpdDate = objRow[conTabFunctionProp.UpdDate] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdDate].ToString().Trim(); //修改日期
objTabFunctionPropEN.UpdUser = objRow[conTabFunctionProp.UpdUser] == DBNull.Value ? null : objRow[conTabFunctionProp.UpdUser].ToString().Trim(); //修改者
objTabFunctionPropEN.Memo = objRow[conTabFunctionProp.Memo] == DBNull.Value ? null : objRow[conTabFunctionProp.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabFunctionPropEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabFunctionPropEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabFunctionProp(ref clsTabFunctionPropEN objTabFunctionPropEN)
{
bool bolResult = TabFunctionPropDA.GetTabFunctionProp(ref objTabFunctionPropEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFunctionPropEN GetObjBymId(long lngmId)
{
clsTabFunctionPropEN objTabFunctionPropEN = TabFunctionPropDA.GetObjBymId(lngmId);
return objTabFunctionPropEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabFunctionPropEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabFunctionPropEN objTabFunctionPropEN = TabFunctionPropDA.GetFirstObj(strWhereCond);
 return objTabFunctionPropEN;
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
public static clsTabFunctionPropEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabFunctionPropEN objTabFunctionPropEN = TabFunctionPropDA.GetObjByDataRow(objRow);
 return objTabFunctionPropEN;
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
public static clsTabFunctionPropEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabFunctionPropEN objTabFunctionPropEN = TabFunctionPropDA.GetObjByDataRow(objRow);
 return objTabFunctionPropEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstTabFunctionPropObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFunctionPropEN GetObjBymIdFromList(long lngmId, List<clsTabFunctionPropEN> lstTabFunctionPropObjLst)
{
foreach (clsTabFunctionPropEN objTabFunctionPropEN in lstTabFunctionPropObjLst)
{
if (objTabFunctionPropEN.mId == lngmId)
{
return objTabFunctionPropEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsTabFunctionPropDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = TabFunctionPropDA.GetID(strWhereCond);
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
bool bolIsExist = TabFunctionPropDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = TabFunctionPropDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsTabFunctionPropEN objTabFunctionPropEN = clsTabFunctionPropBL.GetObjBymId(lngmId);
objTabFunctionPropEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTabFunctionPropEN.UpdUser = strOpUser;
return clsTabFunctionPropBL.UpdateBySql2(objTabFunctionPropEN);
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
 bolIsExist = clsTabFunctionPropDA.IsExistTable();
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
 bolIsExist = TabFunctionPropDA.IsExistTable(strTabName);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabFunctionPropEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],表ID = [{1}],代码类型Id = [{2}],函数ID = [{3}],函数模板Id = [{4}]的数据已经存在!(in clsTabFunctionPropBL.AddNewRecordBySql2)", objTabFunctionPropEN.PrjId,objTabFunctionPropEN.TabId,objTabFunctionPropEN.CodeTypeId,objTabFunctionPropEN.FuncId4GC,objTabFunctionPropEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabFunctionPropDA.AddNewRecordBySQL2(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabFunctionPropEN objTabFunctionPropEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabFunctionPropEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],表ID = [{1}],代码类型Id = [{2}],函数ID = [{3}],函数模板Id = [{4}]的数据已经存在!(in clsTabFunctionPropBL.AddNewRecordBySql2WithReturnKey)", objTabFunctionPropEN.PrjId,objTabFunctionPropEN.TabId,objTabFunctionPropEN.CodeTypeId,objTabFunctionPropEN.FuncId4GC,objTabFunctionPropEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
string strKey = TabFunctionPropDA.AddNewRecordBySQL2WithReturnKey(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabFunctionPropEN objTabFunctionPropEN)
{
try
{
bool bolResult = TabFunctionPropDA.Update(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "objTabFunctionPropEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabFunctionPropEN objTabFunctionPropEN)
{
 if (objTabFunctionPropEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabFunctionPropDA.UpdateBySql2(objTabFunctionPropEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFunctionPropBL.ReFreshCache(objTabFunctionPropEN.PrjId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsTabFunctionPropEN objTabFunctionPropEN = clsTabFunctionPropBL.GetObjBymId(lngmId);

if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(objTabFunctionPropEN.mId, objTabFunctionPropEN.UpdUser);
}
if (objTabFunctionPropEN != null)
{
int intRecNum = TabFunctionPropDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabFunctionPropEN.PrjId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
//删除与表:[TabFunctionProp]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabFunctionProp.mId,
//lngmId);
//        clsTabFunctionPropBL.DelTabFunctionPropsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFunctionPropBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFunctionPropBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabFunctionPropBL.relatedActions != null)
{
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TabFunctionPropDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabFunctionProps(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTabFunctionPropBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsTabFunctionPropEN objTabFunctionPropEN = clsTabFunctionPropBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = TabFunctionPropDA.DelTabFunctionProp(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTabFunctionPropEN.PrjId);
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
public static int DelTabFunctionPropsByCond(string strWhereCond)
{
try
{
if (clsTabFunctionPropBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTabFunctionPropBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conTabFunctionProp.PrjId, strWhereCond);
int intRecNum = TabFunctionPropDA.DelTabFunctionProp(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabFunctionProp]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabFunctionPropDA.GetSpecSQLObj();
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
//删除与表:[TabFunctionProp]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabFunctionPropBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabFunctionPropBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTabFunctionPropENS">源对象</param>
 /// <param name = "objTabFunctionPropENT">目标对象</param>
 public static void CopyTo(clsTabFunctionPropEN objTabFunctionPropENS, clsTabFunctionPropEN objTabFunctionPropENT)
{
try
{
objTabFunctionPropENT.mId = objTabFunctionPropENS.mId; //mId
objTabFunctionPropENT.TabId = objTabFunctionPropENS.TabId; //表ID
objTabFunctionPropENT.FunctionTemplateId = objTabFunctionPropENS.FunctionTemplateId; //函数模板Id
objTabFunctionPropENT.CodeTypeId = objTabFunctionPropENS.CodeTypeId; //代码类型Id
objTabFunctionPropENT.FuncId4GC = objTabFunctionPropENS.FuncId4GC; //函数ID
objTabFunctionPropENT.MethodModifierId = objTabFunctionPropENS.MethodModifierId; //函数修饰语Id
objTabFunctionPropENT.IsForAllTemplate = objTabFunctionPropENS.IsForAllTemplate; //是否针对所有模板
objTabFunctionPropENT.OrderNum = objTabFunctionPropENS.OrderNum; //序号
objTabFunctionPropENT.PrjId = objTabFunctionPropENS.PrjId; //工程Id
objTabFunctionPropENT.UpdDate = objTabFunctionPropENS.UpdDate; //修改日期
objTabFunctionPropENT.UpdUser = objTabFunctionPropENS.UpdUser; //修改者
objTabFunctionPropENT.Memo = objTabFunctionPropENS.Memo; //说明
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
 /// <param name = "objTabFunctionPropEN">源简化对象</param>
 public static void SetUpdFlag(clsTabFunctionPropEN objTabFunctionPropEN)
{
try
{
objTabFunctionPropEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabFunctionPropEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabFunctionProp.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.mId = objTabFunctionPropEN.mId; //mId
}
if (arrFldSet.Contains(conTabFunctionProp.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.TabId = objTabFunctionPropEN.TabId; //表ID
}
if (arrFldSet.Contains(conTabFunctionProp.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.FunctionTemplateId = objTabFunctionPropEN.FunctionTemplateId == "[null]" ? null :  objTabFunctionPropEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(conTabFunctionProp.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.CodeTypeId = objTabFunctionPropEN.CodeTypeId == "[null]" ? null :  objTabFunctionPropEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conTabFunctionProp.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.FuncId4GC = objTabFunctionPropEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(conTabFunctionProp.MethodModifierId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.MethodModifierId = objTabFunctionPropEN.MethodModifierId == "[null]" ? null :  objTabFunctionPropEN.MethodModifierId; //函数修饰语Id
}
if (arrFldSet.Contains(conTabFunctionProp.IsForAllTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.IsForAllTemplate = objTabFunctionPropEN.IsForAllTemplate; //是否针对所有模板
}
if (arrFldSet.Contains(conTabFunctionProp.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.OrderNum = objTabFunctionPropEN.OrderNum; //序号
}
if (arrFldSet.Contains(conTabFunctionProp.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.PrjId = objTabFunctionPropEN.PrjId == "[null]" ? null :  objTabFunctionPropEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabFunctionProp.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.UpdDate = objTabFunctionPropEN.UpdDate == "[null]" ? null :  objTabFunctionPropEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTabFunctionProp.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.UpdUser = objTabFunctionPropEN.UpdUser == "[null]" ? null :  objTabFunctionPropEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conTabFunctionProp.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabFunctionPropEN.Memo = objTabFunctionPropEN.Memo == "[null]" ? null :  objTabFunctionPropEN.Memo; //说明
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
 /// <param name = "objTabFunctionPropEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabFunctionPropEN objTabFunctionPropEN)
{
try
{
if (objTabFunctionPropEN.FunctionTemplateId == "[null]") objTabFunctionPropEN.FunctionTemplateId = null; //函数模板Id
if (objTabFunctionPropEN.CodeTypeId == "[null]") objTabFunctionPropEN.CodeTypeId = null; //代码类型Id
if (objTabFunctionPropEN.MethodModifierId == "[null]") objTabFunctionPropEN.MethodModifierId = null; //函数修饰语Id
if (objTabFunctionPropEN.PrjId == "[null]") objTabFunctionPropEN.PrjId = null; //工程Id
if (objTabFunctionPropEN.UpdDate == "[null]") objTabFunctionPropEN.UpdDate = null; //修改日期
if (objTabFunctionPropEN.UpdUser == "[null]") objTabFunctionPropEN.UpdUser = null; //修改者
if (objTabFunctionPropEN.Memo == "[null]") objTabFunctionPropEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTabFunctionPropEN objTabFunctionPropEN)
{
 TabFunctionPropDA.CheckPropertyNew(objTabFunctionPropEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabFunctionPropEN objTabFunctionPropEN)
{
 TabFunctionPropDA.CheckProperty4Condition(objTabFunctionPropEN);
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
if (clsTabFunctionPropBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFunctionPropBL没有刷新缓存机制(clsTabFunctionPropBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTabFunctionPropObjLstCache == null)
//{
//arrTabFunctionPropObjLstCache = TabFunctionPropDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabFunctionPropEN GetObjBymIdCache(long lngmId, string strPrjId)
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
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsTabFunctionPropEN._CurrTabName, strPrjId);
List<clsTabFunctionPropEN> arrTabFunctionPropObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFunctionPropEN> arrTabFunctionPropObjLst_Sel =
arrTabFunctionPropObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTabFunctionPropObjLst_Sel.Count() == 0)
{
   clsTabFunctionPropEN obj = clsTabFunctionPropBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrTabFunctionPropObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFunctionPropEN> GetAllTabFunctionPropObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsTabFunctionPropEN> arrTabFunctionPropObjLstCache = GetObjLstCache(strPrjId); 
return arrTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFunctionPropEN> GetObjLstCache(string strPrjId)
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
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsTabFunctionPropEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsTabFunctionPropEN> arrTabFunctionPropObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrTabFunctionPropObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTabFunctionPropEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFunctionPropEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTabFunctionPropEN._RefreshTimeLst.Count == 0) return "";
return clsTabFunctionPropEN._RefreshTimeLst[clsTabFunctionPropEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabFunctionPropBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabFunctionPropEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFunctionPropEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabFunctionPropBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabFunctionProp(表函数属性)
 /// 唯一性条件:PrjId_TabId_CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabFunctionPropEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabFunctionPropEN objTabFunctionPropEN)
{
//检测记录是否存在
string strResult = TabFunctionPropDA.GetUniCondStr(objTabFunctionPropEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conTabFunctionProp.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabFunctionProp._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabFunctionProp._AttributeName));
throw new Exception(strMsg);
}
var objTabFunctionProp = clsTabFunctionPropBL.GetObjBymIdCache(lngmId, strPrjId);
if (objTabFunctionProp == null) return "";
return objTabFunctionProp[strOutFldName].ToString();
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
int intRecCount = clsTabFunctionPropDA.GetRecCount(strTabName);
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
int intRecCount = clsTabFunctionPropDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabFunctionPropDA.GetRecCount();
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
int intRecCount = clsTabFunctionPropDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabFunctionPropCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabFunctionPropEN objTabFunctionPropCond)
{
 string strPrjId = objTabFunctionPropCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsTabFunctionPropBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsTabFunctionPropEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsTabFunctionPropEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabFunctionProp._AttributeName)
{
if (objTabFunctionPropCond.IsUpdated(strFldName) == false) continue;
if (objTabFunctionPropCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFunctionPropCond[strFldName].ToString());
}
else
{
if (objTabFunctionPropCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabFunctionPropCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabFunctionPropCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabFunctionPropCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabFunctionPropCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabFunctionPropCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabFunctionPropCond[strFldName]));
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
 List<string> arrList = clsTabFunctionPropDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TabFunctionPropDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TabFunctionPropDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TabFunctionPropDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFunctionPropDA.SetFldValue(clsTabFunctionPropEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TabFunctionPropDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFunctionPropDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTabFunctionPropDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTabFunctionPropDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TabFunctionProp] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**函数模板Id*/ 
 strCreateTabCode.Append(" FunctionTemplateId char(4) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) Null, "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId4GC char(10) not Null, "); 
 // /**函数修饰语Id*/ 
 strCreateTabCode.Append(" MethodModifierId char(2) Null, "); 
 // /**是否针对所有模板*/ 
 strCreateTabCode.Append(" IsForAllTemplate bit not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**函数模板名*/ 
 strCreateTabCode.Append(" FunctionTemplateName varchar(50) Null, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) Null, "); 
 // /**代码类型英文名*/ 
 strCreateTabCode.Append(" CodeTypeENName varchar(50) Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) Null, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) Null, "); 
 // /**函数修饰语名称*/ 
 strCreateTabCode.Append(" MethodModifierName varchar(50) Null, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) not Null, "); 
 // /**函数Id4Code*/ 
 strCreateTabCode.Append(" FuncId4Code char(8) Null, "); 
 // /**函数名4Code*/ 
 strCreateTabCode.Append(" FuncName4Code varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 表函数属性(TabFunctionProp)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabFunctionProp : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsTabFunctionPropBL.ReFreshThisCache(strPrjId);
}
}

}